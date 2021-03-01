using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Runpath.Data;
using Runpath.Models;

namespace Runpath.Controllers {

    [Route("api/albums")]
    [ApiController]
    public class PhotoAlbumsController : ControllerBase {
        private readonly JsonPhotoAlbumData _data = new JsonPhotoAlbumData();

        [HttpGet]
        public ActionResult<List<Album>> GetAllPhotoAlbums() => Ok(_data.GetAllPhotoAlbums());

        [HttpGet("{userId}")]
        public ActionResult<List<Album>> GetPhotoAlbumsByUserId(int userId) => Ok(_data.GetPhotoAlbumsByUserId(userId));
    }
}
