using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {

        // GET: Store
    public string Index()
        {
            return "Hello From Store.Index()";
        }
        //
        //GET: /Store/Browse
        public ActionResult Browse (string genre)
        {
            var genreModel = new Genre { name = genre };
            return View(genreModel);
        }
        //
        //GET:/Store/Details
        public ActionResult Details( int id)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }
        
    }
}