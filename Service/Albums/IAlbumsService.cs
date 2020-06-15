using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Albums
{
    public interface IAlbumsService
    {
        Task<IList<Album>> GetAlbums();
    }
}
