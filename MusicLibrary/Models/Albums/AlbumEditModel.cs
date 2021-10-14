using SwordNetCore.MusicLibrary.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordNetCore.MusicLibrary.Models.Albums
{
    public class AlbumEditModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public MusicGenre Genre { get; set; }

        public AlbumEditModel()
        {
        }

        public AlbumEditModel(Album album)
        {
            Id = album.Id;
            Title = album.Title;
            Genre = album.Genre;
        }

        public AlbumEditModel(int id, string title, MusicGenre genre)
        {
            Id = id;
            Title = title;
            Genre = genre;
        }
    }
}
