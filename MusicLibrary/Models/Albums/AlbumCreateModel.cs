using SwordNetCore.MusicLibrary.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordNetCore.MusicLibrary.Models.Albums
{
    public class AlbumCreateModel
    {
        public string Title { get; set; }
        public MusicGenre Genre { get; set; }

        public AlbumCreateModel()
        {
        }

        public AlbumCreateModel(Album album)
        {
            Title = album.Title;
            Genre = album.Genre;
        }

        public AlbumCreateModel(string title, MusicGenre genre)
        {
            Title = title;
            Genre = genre;
        }
    }
}
