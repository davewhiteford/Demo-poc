using SwordNetCore.MusicLibrary.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordNetCore.MusicLibrary.Models.Artists
{
    public class ArtistDetailsModel
    {
        public int Id { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ArtistDetailsModel()
        {
        }

        public ArtistDetailsModel(Artist artist)
        {
            Id = artist.Id;
            Forename = artist.Forename;
            Surname = artist.Surname;
            DateOfBirth = artist.DateOfBirth;
        }

        public ArtistDetailsModel(int id,string forename, string surname, DateTime dateOfBirth)
        {
            Id = id;
            Forename = forename;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }
    }
}
