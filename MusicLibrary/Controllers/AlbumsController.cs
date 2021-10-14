using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SwordNetCore.MusicLibrary.Data;
using SwordNetCore.MusicLibrary.Data.Entities;
using SwordNetCore.MusicLibrary.Models.Albums;

namespace SwordNetCore.MusicLibrary.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly AppDbContext appDbContext;

        public AlbumsController(AppDbContext context)
        {
            appDbContext = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await appDbContext.Albums.ToListAsync());
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) { return NotFound(); }

            var album = await appDbContext.Albums.FirstOrDefaultAsync(m => m.Id == id);
            if (album == null) { return NotFound(); }

            var model = new AlbumDetailsModel(album);
            return View(album);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AlbumCreateModel model)
        {
            if (!ModelState.IsValid) { return View(model); }

            var album = new Album(0, model.Title, model.Genre);
            appDbContext.Add(album);
            await appDbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) { return NotFound(); }

            var album = await appDbContext.Albums.FindAsync(id);
            var model = new AlbumEditModel(album);
            if (album == null) { return NotFound(); }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(AlbumEditModel model)
        {
            if (!ModelState.IsValid) { return View(model); }

            var album = new Album(model.Id, model.Title, model.Genre);
            appDbContext.Update(album);
            await appDbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
