using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    
    using WebAPI.DataAccess;
    using WebAPI.Models;
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var entities = new MessageBaseEntities();
            return View(entities.Messages.OrderByDescending(m => m.Time));

        }
    }
}