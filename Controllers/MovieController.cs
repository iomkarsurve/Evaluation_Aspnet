using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserApp.Models;

namespace UserApp.Controllers
{
    public class MovieController : Controller
    {



        public ActionResult Index()
        {
            


            List<Movie> stu = new List<Movie>();
                
               

            stu.Add(new Movie(1, "Tanhaji", "Om Raut", 2020, "Ajay Devgn"));
            stu.Add(new Movie(2, "Street Dancer 3D", "	Remo D'Souza", 2019, "Varun Dhawan"));
            stu.Add(new Movie(3, "Baaghi 3", "Ahmed Khan", 2020, "Tiger Shroff"));
            stu.Add(new Movie(4, "Ludo", "Anurag Basu", 2021, "Abhishek Bachchan"));


            return View("Movie",stu);

        }
        





        }
    }
