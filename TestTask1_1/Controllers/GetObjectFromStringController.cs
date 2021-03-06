﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestTask1_1.Models;
using Task1;

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
            //  поиск
            ObjectHeatConsumption objectHeatConsumption = null;
            string name = "", perAc = "", errorMess = "";
            DateTime dateTime;
            bool isFirst = false;
            Task1.GenerateQRString.FirstGetObject(qrSt, out name, out dateTime, out perAc);
            if (name.Equals("") || dateTime.Equals(new DateTime()))
            {
                GenerateQRString.FirstGetObject(qrSt, out name, out dateTime, out perAc);
                if (name.Equals("") && perAc.Equals(""))
                {
                    errorMess = "Объект не найден";
                }
            }
            else
            {
                isFirst = true;
            }

            if (errorMess.Equals(""))
            {
                for (int i = 0; i < StaticData.Objects.Count; i++)
                {
                    if (StaticData.Objects[i].Name.Contains(name) &&
                        StaticData.Objects[i].Consumer.PersonalAccount.Contains(perAc))
                    {
                        if(isFirst )
                        {
                            if (StaticData.Objects[i].DateRegistration.Equals(dateTime))
                            {
                                objectHeatConsumption = StaticData.Objects[i];
                                break;
                            }
                        }
                        else
                        {
                            objectHeatConsumption = StaticData.Objects[i];
                            break;
                        }
                        
                    }
                }
            }

            ViewBag.Error = errorMess;

            return PartialView(objectHeatConsumption);
        }

    }
}