using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car : Vehicle
    {
        /*public Car(int millage)
        {
            this.Millage = millage;
        }*/
        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }
        public int FuelFor1km { get; set; }

        public void Drive(int Way) 
        {
            int CanIDrive = this.FuelFor1km * Way;
            if (this.CurrentFuel >=CanIDrive)
            {
                this.CurrentFuel -= CanIDrive;
                this.Millage += Way;

            }
            else
            {
                Console.WriteLine($"This fuel is not enough for the way.You need {CanIDrive-this.CurrentFuel} litrs of fuel ");
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Color is-{Color} Brand-{Brand} Millage-{Millage} Fuelcapacity-{FuelCapacity} Fuelfor1km-{FuelFor1km}");
        }
    }
}
