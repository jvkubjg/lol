using System;
using System.Collections.Generic;

namespace KolokwiumPrzykladowe.Entities
{
    public class Album
    {
        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }

        public int idMusicLabel { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }

        public Album()
        {
            Tracks = new HashSet<Track>();
        }

        public virtual MusicLabel IdMusicLabelNavigation { get; set; }
    }
}
