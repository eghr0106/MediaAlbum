using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Comments;

namespace BetoniMediaComment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _CommentService;

        public CommentController(ICommentService commentService)
        {
            _CommentService = commentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Comments = await _CommentService.GetCommentsAsync();

            return Ok(Comments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var photos = await _CommentService.GetCommentsByPhotoAsync(id);

            return Ok(photos);
        }
    }
}
