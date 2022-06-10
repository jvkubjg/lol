using System;
using System.Collections.Generic;

namespace KolokwiumPrzykladowe.Entities
{
    public class Track
    {
        public int IdTrack { get; set; }

        public string TrackName { get; set; }
        public float Duration { get; set; }

        public virtual ICollection<Musican_Track> musician_tracks { get; set; }

        public Track()
        {
            this.musician_tracks = new HashSet<Musican_Track>();
        }
        public int IdMusicAlbum { get; set; }
        public Album IdAlbumNavigation { get; set; }

    }
}
