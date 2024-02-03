using Microsoft.AspNetCore.Mvc;
using SingASong.com.Models;
using SingASong.com.Repository;

namespace SingASong.com.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminList()
        {
            SongRepository trackRepository = new SongRepository();
            List<Track> tracks = trackRepository.GetAllSongs();
            
            return View(tracks);
        }

        public IActionResult Details(int id)
        {
            SongRepository trackRepository = new SongRepository();
            Track track = trackRepository.GetSongById(id);
            return View(track);
        }
        public IActionResult AdminReport()  
        {
            return View();
        }

    }
}