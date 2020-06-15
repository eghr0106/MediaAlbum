using Core.HttpClient;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IList<Photo>> GetPhotosAsync()
        {
            var albums = await _webClient.GetContent<IList<Photo>>("photos");

            return albums;
        }

        public async Task<IList<Photo>> GetPhotosByAlbumIdAsync(int albumId) 
        {
            var photos = await GetPhotosAsync();

            var photosByAlbumID = photos.Where(x => x.albumId == albumId).ToList();

            return photosByAlbumID;
        }
    }
}
