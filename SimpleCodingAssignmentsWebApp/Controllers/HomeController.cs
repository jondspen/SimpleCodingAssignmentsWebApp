using SimpleCodingAssignmentsWebApp.Models;
using System.Web.Mvc;
using System;

namespace SimpleCodingAssignmentsWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EvalInput(string userInput)
        {
            int userInt = 0;
            UserInputResult uir = new UserInputResult() { InputValue = userInput, FizzBuzzValue = "Invlaid Input", IsPalindrome = false };

            // Check for FizzBuzz (is input an integer)
            if (int.TryParse(userInput, out userInt))
            {
                uir.FizzBuzzValue = userInt.ToString();
                string FizzBuzzResult = "";

                if ((userInt % 3) == 0)
                {
                    FizzBuzzResult = "Fizz";
                }

                if((userInt % 5) == 0)
                {
                    FizzBuzzResult += "Buzz";
                }

                if (!String.IsNullOrEmpty(FizzBuzzResult))
                {
                    uir.FizzBuzzValue = FizzBuzzResult;
                }
            }

            // Check if input is a palindrome
            uir.IsPalindrome = Utilities.GeneralUtilities.EvaluateForPalindrome(userInput.Replace(" ", string.Empty));

            return View(uir);
        }
    }
}