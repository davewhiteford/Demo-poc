using SwordNetCore.MusicLibrary.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordNetCore.MusicLibrary.Models.Artists
{
    public class ArtistEditModel
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ArtistEditModel()
        {
        }

        public ArtistEditModel(Artist artist)
        {
            this.Id = artist.Id;
            Forename = artist.Forename;
            Surname = artist.Surname;
            DateOfBirth = artist.DateOfBirth;
        }

        public ArtistEditModel(int id, string forename, string surname, DateTime dateOfBirth)
        {
            this.Id = id;
            Forename = forename;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }
    }
}
