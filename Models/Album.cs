using System.Collections.Generic;

namespace Runpath.Models {
    public class Album {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Photo> Photos { get; set;} = new List<Photo>();
    }
}
