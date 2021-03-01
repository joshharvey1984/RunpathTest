using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Runpath.Models;

namespace Runpath.Data {
    public class JsonPhotoAlbumData : IPhotoAlbumData {
        public IEnumerable<Album> GetAllPhotoAlbums() {
            var albums = new List<Album>();
            var photos = new List<Photo>();

            using (var wc = new WebClient()) {
                var photoJson = wc.DownloadString("http://jsonplaceholder.typicode.com/photos");
                var albumJson = wc.DownloadString("http://jsonplaceholder.typicode.com/albums");
                photos = JsonConvert.DeserializeObject<List<Photo>>(photoJson);
                albums = JsonConvert.DeserializeObject<List<Album>>(albumJson);
            }

            return CombinePhotoAlbums(albums, photos);
        }

        public IEnumerable<Album> GetPhotoAlbumsByUserId(int userId) => GetAllPhotoAlbums().Where(album => album.UserId == userId);

        public List<Album> CombinePhotoAlbums(List<Album> albums, List<Photo> photos) {    
            albums.ForEach(album => album.Photos.AddRange(photos.Where(photo => photo.AlbumId == album.Id)));
            return albums;
        }
    }
}