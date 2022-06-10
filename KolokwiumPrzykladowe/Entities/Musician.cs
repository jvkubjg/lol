using System;
using System.Collections.Generic;

namespace KolokwiumPrzykladowe.Entities
{
    public class Musician
    {
        public int IdMusician { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickanme { get; set; }

        public virtual ICollection<Musican_Track> musician_tracks { get; set; }

        public Musician()
        {
            this.musician_tracks = new HashSet<Musican_Track>();
        }
    }
}
