using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VesperDachi.Models;
using Microsoft.AspNetCore.Http;

namespace VesperDachi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Home()
        {
            //Create a new dog
            HttpContext.Session.SetInt32("Happiness", 20);
            HttpContext.Session.SetInt32("Fullness", 20);
            HttpContext.Session.SetInt32("Energy", 50);
            HttpContext.Session.SetInt32("Meals", 3);
            HttpContext.Session.SetString("ImgUrl", "~/img/DSC_2171.JPG");
            Console.WriteLine(HttpContext.Session.GetInt32("Happiness"));
            return View();
        }
        [HttpGet("home")]
        public IActionResult Index()
        {
            //see if the game is over:
            int? happiness = HttpContext.Session.GetInt32("Happiness");
            int? Fullness = HttpContext.Session.GetInt32("Fullness");
            int? Energy = HttpContext.Session.GetInt32("Energy");
            if(happiness.Value > 99 && Fullness.Value > 99 && Energy.Value > 99)
            {
                //winner!
                ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
                ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
                ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
                return View("happy-dog");
            }
            else if(happiness.Value < 1 || Fullness.Value < 1 || Energy.Value < 1)
            {
                //loser
                ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
                ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
                ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
                return View("Loser");
            }

            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            ViewBag.ImgUrl = HttpContext.Session.GetString("ImgUrl");
            ViewBag.Message = HttpContext.Session.GetString("Message");
            return View();
        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            //Feeding your Dojodachi costs 1 meal and gains a random amount of fullness between 5 and 10 
            // (you cannot feed your Dojodachi if you do not have meals)
            Random r = new Random();
            int x = r.Next(5,11);

            //25% chance the dog won't like the food.
            int y = r.Next(1,5);
            if(y == 1)
            {
                int? meals = HttpContext.Session.GetInt32("Meals");
                HttpContext.Session.SetInt32("Meals", (meals.Value - 1));
                HttpContext.Session.SetString("Message", $"Bad news, Vesper threw up her food. She has {meals.Value - 1} meals left.");
                HttpContext.Session.SetString("ImgUrl", "~/img/IMG_2036.JPG");
                return RedirectToAction("Index");
            }
            int? fullness = HttpContext.Session.GetInt32("Fullness");
            int? meals2 = HttpContext.Session.GetInt32("Meals");
            Console.WriteLine($"Feeding vesper, gained {x} fullness.");
            HttpContext.Session.SetInt32("Fullness", (fullness.Value + x));
            HttpContext.Session.SetInt32("Meals", (meals2.Value - 1));
            HttpContext.Session.SetString("ImgUrl", "~/img/DSC_2171.JPG");
            HttpContext.Session.SetString("Message", $"You fed Vesper some good kibble. She gained {x} fullness! She has {meals2.Value - 1} meals left.");
            return  RedirectToAction("Index");
        }

        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            //Sleeping earns 15 energy and decreases fullness and happiness each by 5
            int? happiness = HttpContext.Session.GetInt32("Happiness");
            int? Fullness = HttpContext.Session.GetInt32("Fullness");
            int? Energy = HttpContext.Session.GetInt32("Energy");
            HttpContext.Session.SetInt32("Happiness", (happiness.Value - 5));
            HttpContext.Session.SetInt32("Fullness", (Fullness.Value - 5));
            HttpContext.Session.SetInt32("Energy", (Energy.Value + 15));
            HttpContext.Session.SetString("ImgUrl", "~/img/IMG_0563.JPG");
            HttpContext.Session.SetString("Message", $"Vesper took a good nap. She gained 15 Energy, but lost 5 Happiness and 5 Fullness.");
            return RedirectToAction("Index");
        }

        [HttpGet("work")]
        public IActionResult Work()
        {
            // Working costs 5 energy and earns between 1 and 3 meals
            int? Energy = HttpContext.Session.GetInt32("Energy");
            int? meals = HttpContext.Session.GetInt32("Meals");
            Random r = new Random();
            int x = r.Next(1,4);
            HttpContext.Session.SetInt32("Energy", Energy.Value - 5);
            HttpContext.Session.SetInt32("Meals", meals.Value + x);
            HttpContext.Session.SetString("ImgUrl", "~/img/IMG_2025.JPG");
            HttpContext.Session.SetString("Message", $"Vesper worked hard. She earned {x} meals, but lost 5 Energy Zoomies.");
            return RedirectToAction("Index");
        }

        [HttpGet("play")]
        public IActionResult Play()
        {
            //Playing with your Dojodachi costs 5 energy and gains a random amount of happiness between 5 and 10
            int? Energy = HttpContext.Session.GetInt32("Energy");
            int? Happiness = HttpContext.Session.GetInt32("Happiness");
            Random r = new Random();
            int x = r.Next(5,11);
            int y = r.Next(1,5);
            if(y == 1)
            {
                HttpContext.Session.SetInt32("Energy", Energy.Value - 5);
                HttpContext.Session.SetString("ImgUrl", "~/img/DSC_0875.JPG");
                HttpContext.Session.SetString("Message", $"Vesper didn't enjoy the water. She lost 5 Energy Zoomies and her Happiness stayed the same.");
                return RedirectToAction("Index");
            }
            HttpContext.Session.SetInt32("Happiness", Happiness.Value + x);
            HttpContext.Session.SetInt32("Energy", Energy.Value - 5);
            HttpContext.Session.SetString("ImgUrl", "~/img/IMG_0380.jpg");
            HttpContext.Session.SetString("Message", $"Vesper played disc golf with you! Her happiness grew by {x}, but she lost 5 Energy Zoomies.");
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
