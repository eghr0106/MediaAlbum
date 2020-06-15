using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Photos;

namespace BetoniMediaphoto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IPhotoService _photoService;

        public PhotoController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var photos = await _photoService.GetPhotosAsync();

            return Ok(photos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var photos = await _photoService.GetPhotosByAlbumIdAsync(id);

            return Ok(photos);
        }
    }
}
