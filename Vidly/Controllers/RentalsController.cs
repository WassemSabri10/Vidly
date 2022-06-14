using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class RentalsController : Controller
    {
        // GET: Rentals, I am going to use this action to return form to the client
        public ActionResult New()
        {
            return View();
        }
    }
}