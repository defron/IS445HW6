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

        public ActionResult FormatPhoneNumber(string inputNumber)
        {

            if (string.IsNullOrEmpty(inputNumber) || (inputNumber.Length != 10))
            {
                return Content("invalid input, please try again");
            }
            else
            {
                string formatted = formatNumber(inputNumber);
                return View((object)formatted);
            }
        }

        public ActionResult StringReversal(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return Content("invalid input, please try again");
            }
            else
            {
                string reversed = stringReversal(inputString);
                return View((object)reversed);
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
