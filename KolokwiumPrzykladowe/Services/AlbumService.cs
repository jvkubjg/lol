using System;
using System.Linq;
using System.Threading.Tasks;
using KolokwiumPrzykladowe.DTO;
using KolokwiumPrzykladowe.Entities;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumPrzykladowe.Services
{
    public class AlbumService : IAlbumService
    {
        public readonly MusicContext _context;

        public AlbumService(MusicContext context)
        {
            _context = context;
        }

        public async Task<AlbumDto> GetAlbum(int IdAlbum)
        {
            return await _context.Albums.
                Select(a => new AlbumDto
                {
                    IdAlbum = a.IdAlbum,
                    AlbumName = a.AlbumName,
                    PublishDate = a.PublishDate,

                    IdMusicLabelNavigation = new MusicLabelDto
                    {
                        Name = a.IdMusicLabelNavigation.Name
                    },

                    tracksDto = a.Tracks.Select(t => new TrackDto
                    {
                        IdTrack = t.IdTrack,
                        TrackName = t.TrackName,
                        Duration = t.Duration
                    }).OrderByDescending(e => e.Duration).ToList()
                }).FirstOrDefaultAsync(e => e.IdAlbum == IdAlbum);
        }
    }
}
