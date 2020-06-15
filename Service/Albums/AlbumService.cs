using Core.HttpClient;
using Core.Models;
using Infraestructure.WebClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Albums
{
    public class AlbumService : IAlbumsService
    {
        private readonly IWebClient _webClient;

        public AlbumService(IWebClient webClient)
        {
            _webClient = webClient;
        }

        public async Task<IList<Album>>GetAlbums() 
        {
           var albums = await _webClient.GetContent<IList<Album>>("albums");

            return albums;
        }
    }
}
