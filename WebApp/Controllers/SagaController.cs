using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class SagaController : Controller
    {
        public IActionResult Index()
        {
            var model = new SagaViewModel()
            {
                FirstPerson = new Person(),
                SecondPerson = new Person()
            };
            return View(model);
        }

        [HttpPost]
        public ViewResult Saga()
        {
            var model = new SagaViewModel()
            {
                FirstPerson = new Person(),
                SecondPerson = new Person()
            };

            var request = HttpContext.Request;

            //Collect input form into variable
            int personA_AgeOfDeath = Convert.ToInt32(request.Form["textPersonA_AgeOfDeath"]);
            int personA_YearOfDeath = Convert.ToInt32(request.Form["textPersonA_YearOfDeath"]);

            int personB_AgeOfDeath = Convert.ToInt32(request.Form["textPersonB_AgeOfDeath"]);
            int personB_YearOfDeath = Convert.ToInt32(request.Form["textPersonB_YearOfDeath"]);

            //Creating person object
            model.FirstPerson = new Person(personA_AgeOfDeath, personA_YearOfDeath);
            model.SecondPerson = new Person(personB_AgeOfDeath, personB_YearOfDeath);

            model.Average = ((decimal)(model.FirstPerson.NumberOfPersonKilled + model.SecondPerson.NumberOfPersonKilled) / 2);

            return View("Index", model);
        }

    }
}