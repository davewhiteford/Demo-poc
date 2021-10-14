using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SwordNetCore.MusicLibrary.Data;
using SwordNetCore.MusicLibrary.Data.Entities;
using SwordNetCore.MusicLibrary.Models.Artists;

namespace SwordNetCore.MusicLibrary.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly AppDbContext appDbContext;

        public ArtistsController(AppDbContext context)
        {
            appDbContext = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await appDbContext.Artists.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) { return NotFound(); }

            var artist = await appDbContext.Artists.FirstOrDefaultAsync(m => m.Id == id);
            if (artist == null) { return NotFound(); }

            var model = new ArtistDetailsModel(artist);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ArtistCreateModel model)
        {
            if (!ModelState.IsValid) { return View(model); }

            var newArtist = new Artist(0, model.Forename, model.Surname, model.DateOfBirth);
            appDbContext.Add(newArtist);
            await appDbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) { return NotFound(); }

            var artist = await appDbContext.Artists.FindAsync(id);
            var model = new ArtistEditModel(artist);
            
            if (artist == null) { return NotFound(); }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ArtistEditModel model)
        {
            if (!ModelState.IsValid) { return View(model); }

            var artist = new Artist(model.Id, model.Forename, model.Surname, model.DateOfBirth);
            appDbContext.Update(artist);
            await appDbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Details), new { id = model.Id });
        }
    }
}
