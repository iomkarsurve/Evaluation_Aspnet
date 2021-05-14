using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserApp.Models

{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int DateReleased { get; set; }
        public string Hero { get; set; }
        public Movie(int ID, string Title, string Director, int DateReleased, string Hero)
        {
            this.ID = ID;
            this.Title = Title;
            this.Director = Director;
            this.DateReleased = DateReleased;
            this.Hero = Hero;

        }

    }
   
}
