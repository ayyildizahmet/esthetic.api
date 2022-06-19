using AutoMapper;
using Esthetic.Core.Contracts.Enums;
using Esthetic.Core.Contracts.UnitOfWork;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Domain;
using Esthetic.Model;
using Esthetic.Service.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Esthetic.Service
{
    public class PostService : Core.Contracts.ServiceBase.Service, IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IPostMediaService _postMediaService;
        private readonly IImageService _imageService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PostService(IPostRepository postRepository, IPostMediaService postMediaService, IImageService imageService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _postRepository = postRepository;
            _postMediaService = postMediaService;
            _imageService = imageService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public bool CreatePost(PostModel postModel)
        {
            try
            {
                if (postModel == null)
                    throw new NullReferenceException();

                if (!postModel.PostMedias.Any())
                    throw new ArgumentException("Post Media cannot be empty.");
                else
                    postModel.PostMedias.ForEach(postMediaModel =>
                    {
                        if (postMediaModel.MediaType == MediaType.Image && postMediaModel.ImageId == null)
                            throw new ArgumentException("PostMedia Image can not be null");
                        if (postMediaModel.MediaType == MediaType.Video && postMediaModel.VideoId == null)
                            throw new ArgumentException("PostMedia Video can not be null");
                    });

                var post = _mapper.Map<Post>(postModel);

                _postRepository.Add(post);
                return _unitOfWork.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Error occurred while creating post record. Error = {0} Exception = {1}", ex.Message, ex.InnerException));
            }
        }

        public List<PostModel> GetList()
        {
            var postList = _postRepository.Include(x => x.PostMedias).Where(x => x.PostMedias.Any()).ToList();
            var postModelList = _mapper.Map<List<Post>, List<PostModel>>(postList);

            if (postModelList != null && postModelList.Any())
            {
                foreach (var postMediaItem in postModelList)
                {
                    var selestedPostMedias = postMediaItem.PostMedias.Where(x => x.ImageId != null).ToList();
                    if (selestedPostMedias.Any())
                    {
                        foreach (var item in selestedPostMedias)
                        {
                            var selectedImage = _imageService.GetImageWithoutData(item.ImageId.GetValueOrDefault());
                            if (selectedImage != null)
                                item.Image = selectedImage;
                        }
                    }
                }
            }

            return postModelList;
        }
    }
}