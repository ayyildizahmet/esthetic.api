using AutoMapper;
using Esthetic.Core.Contracts.Enums;
using Esthetic.Core.Contracts.UnitOfWork;
using Esthetic.DataAccess.Repositories.Contracts;
using Esthetic.Domain;
using Esthetic.Model;
using Esthetic.Service.Contracts;
using System;

namespace Esthetic.Service
{
    public class PostMediaService : Core.Contracts.ServiceBase.Service, IPostMediaService
    {
        private readonly IPostMediaRepository _postMediaRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PostMediaService(IPostMediaRepository postMediaRepository,IUnitOfWork unitOfWork, IMapper mapper)
        {
            _postMediaRepository = postMediaRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public bool Create(PostMediaModel postMediaModel)
        {
            try
            {
                switch (postMediaModel.MediaType)
                {
                    case MediaType.Image when postMediaModel.ImageId == null:
                        throw new ArgumentException("PostMedia Image can not be null");
                    case MediaType.Video when postMediaModel.VideoId == null:
                        throw new ArgumentException("PostMedia Video can not be null");
                    case MediaType.Pdf:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                var postMedia = _mapper.Map<PostMedia>(postMediaModel);

                _postMediaRepository.Add(postMedia);
                return _unitOfWork.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    $"Error occurred while creating post media record. Error = {ex.Message} Exception = {ex.InnerException}");
            }
        }
      
    }
}