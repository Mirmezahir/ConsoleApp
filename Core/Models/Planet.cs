using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public  class Planet
    {
       private static int _id;

        public Planet(string name, double area)
        {
            Name = name;
            Area = area;
            ++_id;
            ID = _id;
        }

        public  int  ID { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        

    }
}
