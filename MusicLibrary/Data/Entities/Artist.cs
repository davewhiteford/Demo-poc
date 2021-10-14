using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordNetCore.MusicLibrary.Data.Entities
{
    public class Artist : Entity
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Artist() { 
        }

        public Artist(int id, string forename, string surname, DateTime dateOfBirth)
        {
            Id = id;
            Forename = forename;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }
    }
}
