using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyetcoweb2.Controllers
{
    public class insertController : Controller
    {
        // GET: insert
     



        // GET: PersonalDetails/Create
        public ActionResult Create()
        {
            return View();
        }

    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include =
                           "AutoId,FirstName,LastName,Age,Active")] PersonalDetail personalDetail)
        {
            if (ModelState.IsValid)
            {
                db.PersonalDetails.Add(personalDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personalDetail);
        }



    }
}