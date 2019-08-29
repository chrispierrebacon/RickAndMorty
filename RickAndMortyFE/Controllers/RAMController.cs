using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RickAndMortyBackend;

namespace RickAndMortyFE.Controllers
{
    public class RAMController : Controller
    {
        // GET: RAM
        public ActionResult Index()
        {
            RickAndMortyBL rickAndMortyBL = new RickAndMortyBL();
            List<Episode> episodes = rickAndMortyBL.getEpisodes();


            return View(episodes);
        }
    }
}
