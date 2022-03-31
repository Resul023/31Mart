using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        public string Color { get; set; } 
       public  string Brand { get; set; }
       public  int Millage { get; set; }

        public virtual void ShowInfo() 
        {
            Console.WriteLine($"Color is-{Color} Brand-{Brand} Millage-{Millage}");
        }

    }
}
