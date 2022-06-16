using Esthetic.Model;
using Esthetic.Service.Contracts;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Esthetic.Api.Controllers
{
    [EnableCors("corsapp")]
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost("Create")]
        public ResponseModel<bool> Create(PostModel post)
        {
            var response = new ResponseModel<bool>();
            try
            {
                response.Success = _postService.CreatePost(post);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            if (response.Success)
            {
                response.Data = true;
                response.Message = "Post created successfully.";
            }

            return response;
        }

        [HttpGet("GetList")]
        public ResponseModel<List<PostModel>> GetList()
        {
            var response = new ResponseModel<List<PostModel>>();
            try
            {
                response.Data = _postService.GetList();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
