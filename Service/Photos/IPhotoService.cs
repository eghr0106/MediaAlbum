using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Photos
{
    public interface IPhotoService
    {
        Task<IList<Photo>> GetPhotosAsync();
        Task<IList<Photo>> GetPhotosByAlbumIdAsync(int albumId);
    }
}
