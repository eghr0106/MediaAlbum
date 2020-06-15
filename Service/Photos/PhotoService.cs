using Core.HttpClient;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Photos
{
    public class PhotoService : IPhotoService
    {
        private readonly IWebClient _webClient;

        public PhotoService(IWebClient webClient)
        {
            _webClient = webClient;
        }

        public async Task<IList<Photo>> GetPhotos()
        {
            var albums = await _webClient.GetContent<IList<Photo>>("albums");

            return albums;
        }
    }
}
