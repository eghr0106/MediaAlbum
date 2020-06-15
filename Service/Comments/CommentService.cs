using Core.HttpClient;
using Core.Models;
using System;
using System.Collections.Generic;
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

        public async Task<IList<Comment>> GetComments()
        {
            var albums = await _webClient.GetContent<IList<Comment>>("albums");

            return albums;
        }
    }
}
