using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpodIglyMVC.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public string AlbumTitle { get; set; }
        public string ArtistName { get; set; }
        public DateTime DateAdd { get; set; }
        public string CovertFileName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsBestseller { get; set; }
        public bool IsMidden { get; set; }

        public virtual Genre Genre { get; set; }
    }
}
