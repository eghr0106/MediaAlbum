using Core.Models;
using Service.Photos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Albums
{
    public class AlbumDto
    {
        public int id { get; set; }
        public string title { get; set; }
        public IList<PhotoDto> Photos { get; set; }
    }
}
