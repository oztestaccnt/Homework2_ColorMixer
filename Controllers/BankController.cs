using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OzLearningHub.Controllers
{
    public class BankController : Controller
    {
        // GET: Bank
        public ActionResult Index()
        {
            return View();
        }

        //[HandleError(ExceptionType = typeof(FormatException))]
        [HandleError(ExceptionType = typeof(FormatException), View = "BankError")]
        public ActionResult BankTest(string id)
        {

            try
            {
                Double num1 = double.Parse(id);
                ViewBag.value = id;
            }
            catch (FormatException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }

            return View();
        }

        public double Debit(double amount)
        {
            double balance = 100.10;
            return balance - amount;


        }

    }



}