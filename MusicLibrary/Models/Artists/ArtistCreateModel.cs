using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordNetCore.MusicLibrary.Models.Artists
{
    public class ArtistCreateModel
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ArtistCreateModel()
        {
        }

        public ArtistCreateModel(string forename, string surname, DateTime dateOfBirth)
        {
            Forename = forename;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }
    }
}
