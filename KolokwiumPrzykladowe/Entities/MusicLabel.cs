using System;
namespace KolokwiumPrzykladowe.Entities
{
    public class MusicLabel
    {
        public int IdMusicLabel { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Album> Albums { get; set; }

        public MusicLabel()
        {
            Albums = new HashSet<Album>();
        }
    }
}
