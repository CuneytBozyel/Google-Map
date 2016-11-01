using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using GoogleMaps.Models;

namespace GoogleMaps.Controllers
{
    public class MapController : Controller
    {
        private GoogleMapsContext db = new GoogleMapsContext();

        // GET: Map
        public ActionResult Index()
        {
            return View(db.Locations.ToList());
        }

        [HttpPost]
        public ActionResult Search(string location)
        {
            var result = db.Locations.Where(x => x.LocationName.StartsWith(location)).ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
