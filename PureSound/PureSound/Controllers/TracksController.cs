using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PureSound.Data.Account;
using PureSound.Data;
using PureSound.Data.Entities;
using PureSound.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using PureSound.Contracts;

namespace PureSound.Controllers
{
    public class TracksController : Controller
    {
        private readonly ITrackService trackService;
        public readonly ApplicationDbContext context;

        public TracksController(ITrackService _trackService, ApplicationDbContext _context)
        {
            this.trackService = _trackService;
            this.context = _context;
        }


        [HttpGet]
        public async Task<IActionResult> Tracks( string sortOption)
        {
            var tracks = await trackService.GetAllTracksAsync();

            foreach (var track in tracks)
            {
                var artistsIds = context.ArtistTrack.Where(x => x.TrackId == track.Id).Select(x => x.ArtistId).ToList();
                var artists = new List<Artist>();
                foreach (var item in artistsIds)
                {
                    var artist = context.Artists.Include(x => x.Genre).FirstOrDefault(x => x.Id == item);
                    artists.Add(artist!);
                }
                var artistsNames = artists.Select(x => x.Username).ToList();
                ViewBag.Artists = artistsNames;
            }
            var toReturn = await trackService.SortTracksAsync(sortOption);

            return View(toReturn);
            //return View(toReturn);
        }

        [HttpGet]
        public IActionResult AddTrack()
        {
            ViewBag.GenreId = new SelectList(context.Genres.ToList(), "Id", "Name");
            ViewBag.Artists = new SelectList(context.Artists.ToList(), "Id", "Username");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddTrack(AddTrackVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await trackService.AddTrackAsync(model);
                return RedirectToAction("Tracks", "Tracks");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View(model);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTrack(Guid id)
        {
            await trackService.DeleteTrackAsync(id);
            return RedirectToAction("AllEntities", "Pages");
        }

        [HttpGet]
        public async Task<IActionResult> EachTrack(Guid id)
        {
            var artistsIds = context.ArtistTrack.Where(x => x.TrackId == id).Select(x => x.ArtistId).ToList();
            var artists = new List<Artist>();
            foreach (var item in artistsIds)
            {
                var artist = context.Artists.Include(x => x.Genre).FirstOrDefault(x => x.Id == item);
                artists.Add(artist!);
            }
            var artistsNames = artists.Select(x => x.Username).ToList();
            ViewBag.Artists = artistsNames;

            var track = await trackService.EachTrackAsync(id);
            if (track != null)
            {
                return View(track);
            }
            else
            {
                return RedirectToAction("Tracks", "Tracks");
            }
        }

    }
}
