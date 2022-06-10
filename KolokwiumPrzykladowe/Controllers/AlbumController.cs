using System;
using System.Threading.Tasks;
using KolokwiumPrzykladowe.Services;
using Microsoft.AspNetCore.Mvc;

namespace KolokwiumPrzykladowe.Controllers
{



    [ApiController]
    [Route("api/albums")]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _service;

        public AlbumController(IAlbumService service)
        {
            _service = service;
        }


        [HttpGet("IdAlbum")]
        public async Task<IActionResult> GetAlbum([FromRoute] int idAlbum)
        {
            var album = await _service.GetAlbum(idAlbum);
            return Ok(album);
        }

    }
}
