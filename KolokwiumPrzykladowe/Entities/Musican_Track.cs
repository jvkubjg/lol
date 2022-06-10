using System;
namespace KolokwiumPrzykladowe.Entities
{
    public class Musican_Track
    {
        public int IdTrack { get; set; }
        public int IdMusician { get; set; }

        public virtual Musician IdMusiciankNavigation { get; set; }
        public virtual Track IdTrackNavigation { get; set; }
    }
}
