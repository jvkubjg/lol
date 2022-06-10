using System;
using System.Threading.Tasks;
using KolokwiumPrzykladowe.DTO;
using KolokwiumPrzykladowe.Entities;

namespace KolokwiumPrzykladowe.Services
{
    public interface IAlbumService
    {
        Task<AlbumDto> GetAlbum(int IdAlbum);
    }
}
