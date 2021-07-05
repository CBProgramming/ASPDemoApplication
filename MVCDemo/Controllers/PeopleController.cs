using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List <PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel
            {
                FirstName = "Chris",
                LastName = "Burrell",
                Age = 35
            });
            people.Add(new PersonModel
            {
                FirstName = "John",
                LastName = "Smith",
                Age = 40
            });
            people.Add(new PersonModel
            {
                FirstName = "Jenny",
                LastName = "Barnes",
                Age = 45
            });

            return View(people);
        }
    }
}