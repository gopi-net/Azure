using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DayApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Photos()
        {
            var links = getSourceLinks();
            return View(links);
        }
        public ActionResult Videos()
        {
            return View();
        }
        private List<string> getSourceLinks()
        {
            return new List<string>() {
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(1).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(2).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(3).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(4).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(5).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(6).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(7).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(8).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(9).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(10).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(11).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(12).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(13).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(14).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/smily%20(15).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(1).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(2).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(3).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(4).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(5).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(6).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(7).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(8).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(9).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(10).jpg",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(11).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(12).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(13).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(14).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(15).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(16).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(17).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(18).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(19).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(20).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(21).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(22).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(23).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(24).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(25).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(26).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(27).JPG",
                "https://rajee.blob.core.windows.net/smily/smily/rajee%20(8).JPG",


            };
        }
    }
}