using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PureSound.Contracts;
using PureSound.Data;
using PureSound.Data.Entities;
using PureSound.Models;
using PureSound.Models.ViewModels;
using PureSound.Services;
using System.Diagnostics;

namespace PureSound.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext _context)
        {
            _logger = logger;
            context = _context;
        }

        public async Task<IActionResult> Index()
        {
            var articles = await context.Articles.Include(x => x.Category).ToListAsync();
            var artists = await context.Artists.Include(x => x.ArtistTrack).Include(x => x.FavoriteArtists).Include(x => x.Genre).ToListAsync();
            var tracks = await context.Tracks.Include(x => x.ArtistTrack).Include(x => x.FavoriteTracks).Include(x => x.Genre).ToListAsync();
            var toReturnArticles = new List<ArticleVM>();
            var toReturnTracks = new List<TrackVM>();
            var toReturnArtists = new List<ArtistVM>();

            foreach (var item in articles)
            {
                var art = new ArticleVM()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Category = item.Category,
                    CategoryId = item.CategoryId,
                    Comments = item.Comments,
                    Content = item.Content,
                    Date = item.Date,
                    ImageURL = item.ImageURL
                };
                toReturnArticles.Add(art);
            }
            foreach (var item in artists)
            {
                var artist = new ArtistVM()
                {
                    Id = item.Id,
                    Age = item.Age,
                    ArtistTrack = item.ArtistTrack,
                    FavoriteArtists = item.FavoriteArtists,
                    Genre = item.Genre,
                    FavouriteCount = item.FavouriteCount,
                    GenreId = item.GenreId,
                    ImageURL = item.ImageURL,
                    Region = item.Region,
                    RegionId = item.RegionId,
                    Username = item.Username
                };
                toReturnArtists.Add(artist);
            }
            foreach (var item in tracks)
            {
                var track = new TrackVM()
                {
                    Id = item.Id,
                    ArtistTrack = item.ArtistTrack,
                    FavoriteTracks = item.FavoriteTracks,
                    FavouriteCount = item.FavouriteCount,
                    Genre = item.Genre,
                    GenreId = item.GenreId,
                    ImageURL = item.ImageURL,
                    Lyrics = item.Lyrics,
                    Title = item.Title,
                    Year = item.Year,
                    YouTubeURL = item.YouTubeURL
                };
                toReturnTracks.Add(track);
            }

            var tracksViewBag = await context.Tracks.Include(x => x.Genre).Include(x => x.FavoriteTracks).Include(x => x.ArtistTrack)!.ThenInclude(x => x.Artist).ToListAsync();


            var toreturn = new IndexVM()
            {
                Articles = toReturnArticles.OrderByDescending(x => x.Date).Take(5).ToList(),
                Artists = toReturnArtists.OrderByDescending(x => x.FavouriteCount).Take(10).ToList(),
                Tracks = toReturnTracks.OrderByDescending(x => x.FavouriteCount).Take(10).ToList()
            };
            return View(toreturn);
        }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
}