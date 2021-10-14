using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwordNetCore.MusicLibrary.Data.Entities
{
    public class Album : Entity
    {
        [Required]
        public string Title { get; set; }

        public MusicGenre Genre { get; set; }

        public Album()
        {
        }

        public Album(int id, string title, MusicGenre genre)
        {
            Id = id;
            Title = title;
            Genre = genre;
        }
    }

    public enum MusicGenre 
    { 
        Rock = 1,
        Pop = 2,
        HipHop = 3,
        Classical = 4
    }
}
