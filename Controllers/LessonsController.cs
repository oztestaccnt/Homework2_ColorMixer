using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;

namespace OzLearningHub.Controllers
{
    public class LessonsController : Controller
    {
        // GET: Lessons
        public ActionResult Homework1()
        {
            return View();
        }

        public ActionResult Lesson1_2()
        {
            return View();
        }

        public ActionResult Lesson7()
        {
            return View();
        }

        public ActionResult Lesson9_10()
        {
            return View();
        }


        //Here is where the color mixer will happen
        public ActionResult Homework2(string colorMix1, string colorMix2)
        {
            if (colorMix1 == "1" && colorMix2 =="1")
            {
                ViewBag.mixedColor = "Red";
            }
            else if ((colorMix1 == "1" && colorMix2 == "3") || (colorMix1 == "3" && colorMix2 == "1"))
            {
                ViewBag.mixedColor = "Yellow";

            }
            else if ((colorMix1 == "1" && colorMix2 == "2") || (colorMix1 == "2" && colorMix2 == "1"))
            {
                ViewBag.mixedColor = "Magenta";
            }
            else if (colorMix1 == "3" && colorMix2 == "3")
            {
                ViewBag.mixedColor = "Green";
            }
            else if (colorMix1 == "2" && colorMix2 == "2")
            {
                ViewBag.mixedColor = "Blue";
            }
            else if ((colorMix1 == "3" && colorMix2 == "2") || (colorMix1 == "2" && colorMix2 == "3"))
            {
                ViewBag.mixedColor = "Cyan";
            }

            List<SelectListItem> colors = new List<SelectListItem>();
            SelectListItem color1 = new SelectListItem() {Text = "Red", Value = "1", Selected = false};
            SelectListItem color2 = new SelectListItem() { Text = "Blue", Value = "2", Selected = false};
            SelectListItem color3 = new SelectListItem() { Text = "Green", Value = "3", Selected = false };

            colors.Add(color1);
            colors.Add(color2);
            colors.Add(color3);
            //passing this value to Html Dropdown on backend side
            ViewBag.colorMix = colors;
            

            return View();
        }
    }
}