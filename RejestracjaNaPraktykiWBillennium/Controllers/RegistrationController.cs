using RejestracjaNaPraktykiWBillennium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RejestracjaNaPraktykiWBillennium.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registered(Registration registration)
        {
            using (RegistrationEntities db = new RegistrationEntities())
            {
                
                try
                {
                    db.Registration.Add(registration);
                    db.SaveChanges();
                } catch
                {
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Name = registration.NameAndSurname;
            return View();
        }
    }
}