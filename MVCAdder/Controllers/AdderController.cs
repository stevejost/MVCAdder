using Microsoft.AspNetCore.Mvc;
using MVCAdder.Models;

namespace MVCAdder.Controllers
{
    public class AdderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostFirst(double x, double y)
        {
            var results = new ResultsViewModel();
            results.Sum = x + y;
            results.Difference = x - y;
            results.Product = x * y;
            if (y != 0)
            {
                results.Quotient = x / y;
            }
            else
            {
                results.Quotient = 0;
            }

            results.Remainder = x % y;


            return View("Results", results);
        }

        [HttpPost]
        public IActionResult PostSecond(InputFormModel model)
        {
            var results = new ResultsViewModel();
            results.X = model.X;
            results.Y = model.Y;
            results.Sum = model.X + model.Y;
            results.Difference = model.X - model.Y;
            results.Product = model.X * model.Y;
            if (model.Y != 0)
            {
                results.Quotient = model.X / model.Y;
            }
            else
            {
                results.Quotient = 0;
            }

            results.Remainder = model.X % model.Y;


            return View("Results", results);
        }

        [HttpPost]
        public IActionResult PostThird(InputFormModel model)
        {
            var results = new SecondResultsViewModel() { X = model.X, Y = model.Y };
            return View("SecondResults", results);
        }
    }
}
