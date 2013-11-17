using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IS445.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Task2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string inputNumber)
        {

            if (string.IsNullOrEmpty(inputNumber) || (inputNumber.Length != 10))
            {
                //shouldn't be possible anymore
                return Content("invalid input, please try again");
            }
            else
            {
                string formatted = formatNumber(inputNumber);
                return View("FormatPhoneNumber", (object)formatted);
            }
        }

        [HttpPost]
        public ActionResult Task2(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                //shouldn't be possible anymore
                return Content("invalid input, please try again");
            }
            else
            {
                string reversed = stringReversal(inputString);
                return View("StringReversal", (object)reversed);
            }
        }

        // please implement your phone number formatting logic here
        private string formatNumber(string inputNumber)
        {
            return "formated number is: (" + inputNumber.Substring(0, 3) + ") " + inputNumber.Substring(3, 3) + "-" + inputNumber.Substring(6, 4);
        }

        private string stringReversal(string input)
        {
            string[] words = input.Split(' ');
            string reversed = "";
            for (int i = words.Length; i > 0; i -= 1)
            {
                reversed += (words[i - 1] + " ");
            }
            return reversed;
        }

    }
}
