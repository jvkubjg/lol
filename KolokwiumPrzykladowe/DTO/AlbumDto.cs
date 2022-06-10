using System;
using System.Collections.Generic;

namespace KolokwiumPrzykladowe.DTO
{
    public class AlbumDto
    {
        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public int MusicLabel { get; set; }

        public virtual MusicLabelDto IdMusicLabelNavigation { get; set; }

        public DateTime PublishDate { get; set; }

        public ICollection<TrackDto> tracksDto { get; set; }

        
    }
}
