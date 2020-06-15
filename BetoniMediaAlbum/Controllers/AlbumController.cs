using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service.Albums;

namespace BetoniMediaAlbum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumsService _albumService; 

        public AlbumController(IAlbumsService albumService)
        {
            _albumService = albumService;
        }
       
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var albums = await _albumService.GetAlbumsAsync();

            return Ok(albums);
        }    
    }
}
