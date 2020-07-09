using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTask1_1.Models;
using Task1;
namespace TestTask1_1.Controllers
{
    public class GetStringFromObjectController : Controller
    {
        // GET: GetStringFromObject
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateString(ObjectHeatConsumption objectHeat)
        {
            string st = "";
            if (objectHeat.DateRegistration == null)
            {
                ModelState.AddModelError("DateRegistration", "Некоретная дата");
                st = "Некоретная дата";
                ViewBag.qrSt = st;
            }

            if (ModelState.IsValid)
            {
                st = Task1.GenerateQRString.FirstGenerate(objectHeat.Name, (DateTime)objectHeat.DateRegistration, objectHeat.Consumer.PersonalAccount);
                ViewBag.qrSt = st;
                return PartialView();
            }
            return PartialView();
        }
    }
}