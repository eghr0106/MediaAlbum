using Core.HttpClient;
using Core.Models;
using Infraestructure.WebClient;
using Service.Comments;
using Service.Photos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Albums
{
    public class AlbumService : IAlbumsService
    {
        private readonly IWebClient _webClient;
        private readonly IPhotoService _photoService;
        private readonly ICommentService _commentService;


        public AlbumService(IWebClient webClient, IPhotoService photoService,  ICommentService commentService)
        {
            _webClient = webClient;
            _photoService = photoService;
            _commentService = commentService;
        }

        public async Task<IList<Album>>GetAlbumsAsync() 
        {
           var albums = await _webClient.GetContent<IList<Album>>("albums");

            return albums;
        }
    }
}
