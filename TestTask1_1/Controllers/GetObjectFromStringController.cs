using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTask1_1.Models;

namespace TestTask1_1.Controllers
{
    public class GetObjectFromStringController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ObjectSearch(string qrSt)
        {
            var obj = new ObjectHeatConsumption()
            {
                PrimaryKey = Guid.NewGuid(),
                Consumer = new Consumer()
                {
                    PrimaryKey = Guid.NewGuid(),
                    PersonalAccount = 123456789
                },
                DateRegistration = new DateTime(2019, 1, 1),
                Name = "ШШТОРЕ"
            };

            return PartialView(obj);
        }

    }
}