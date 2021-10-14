using Microsoft.EntityFrameworkCore;
using SwordNetCore.MusicLibrary.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwordNetCore.MusicLibrary.Data
{
    public static class DbInitialiser
    {
        public static void Seed(AppDbContext dbContext)
        {
            dbContext.Database.Migrate();
            if (!dbContext.Artists.Any())
            {
                dbContext.Add(new Artist(0, "Aretha", "Franklin", new DateTime(1942, 3, 25)));
                dbContext.Add(new Artist(0, "Elvis", "Presley", new DateTime(1935, 1, 8)));
                dbContext.Add(new Artist(0, "John", "Lennon", new DateTime(1940, 10, 9)));
                dbContext.Add(new Artist(0, "Marvin", "Gaye", new DateTime(1939, 2, 1)));
                dbContext.Add(new Artist(0, "Kurt", "Cobain", new DateTime(1967, 2, 20)));
                dbContext.Add(new Artist(0, "Thom", "Yorke", new DateTime(1968, 10, 7)));
            }
            
            if (!dbContext.Albums.Any())
            {
                // etc
            }

            dbContext.SaveChanges();
        }
    }
}
