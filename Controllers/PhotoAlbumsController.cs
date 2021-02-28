using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Runpath.Data;
using Runpath.Models;

namespace Runpath.Controllers
{
    [Route("api/albums")]
    [ApiController]
    public class PhotoAlbumsController : ControllerBase {
        private readonly JsonPhotoAlbumData _data = new JsonPhotoAlbumData();

        [HttpGet]
        public ActionResult<List<Album>> GetAllPhotoAlbums() {
            var photoAlbums = _data.GetAllPhotoAlbums();
            return Ok(photoAlbums);
        }

        [HttpGet("{userId}")]
        public ActionResult<List<Album>> GetPhotoAlbumsByUserId(int userId) {
            var photoAlbums = _data.GetPhotoAlbumsByUserId(userId);
            return Ok(photoAlbums);
        }
    }
}
