using System.Collections.Generic;
using Runpath.Models;

namespace Runpath.Data
{
    public interface IPhotoAlbumData {
        IEnumerable<Album> GetAllPhotoAlbums();
        IEnumerable<Album> GetPhotoAlbumsByUserId(int userId);
    }

}