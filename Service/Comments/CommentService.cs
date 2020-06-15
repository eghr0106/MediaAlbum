using Core.HttpClient;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Comments
{
    public class CommentService : ICommentService
    {
        private readonly IWebClient _webClient;

        public CommentService(IWebClient webClient)
        {
            _webClient = webClient;
        }

        public async Task<IList<Comment>> GetCommentsAsync()
        {
            var albums = await _webClient.GetContent<IList<Comment>>("albums");

            return albums;
        }

        public async Task<IList<Comment>> GetCommentsByPhotoAsync(int photoId) 
        {
            var comments = await GetCommentsAsync();

            var commentsByPhoto = comments.Where(x => x.postId == photoId).ToList();

            return commentsByPhoto;
        }
    }
}
