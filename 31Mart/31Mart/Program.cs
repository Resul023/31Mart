using System;
using ClassLibrary;
namespace _31Mart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write car count:");
            int carCount = Convert.ToInt32(Console.ReadLine());
            Car[] newCars = new Car[carCount];
            Car newCar = new Car();
 
            for (int i = 0; i < carCount; i++)
            {

                Console.WriteLine("Write car brand:");
                string brand = Console.ReadLine();
                Console.WriteLine("Write car color");
                string color = Console.ReadLine();
                Console.WriteLine("Write car CurrentFuel");
                int currentFuel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write car FuelCapacity");
                int fuelCapacity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write car Millage");
                int millage = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Write car FuelFor1km");
                int fuelFor1km = Convert.ToInt32(Console.ReadLine());
                newCars[i] = new Car()
                {
                    Brand = brand,
                    Color=color,
                    CurrentFuel=currentFuel,
                    FuelCapacity= fuelCapacity,
                    Millage = millage,
                    FuelFor1km = fuelFor1km

                };

            }

            bool check = true;
            while (check)
            {
                Console.WriteLine(" 1-Show cars according to millage\n 2-Show all of the cars \n 3-End of process");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1)
                {
                    Console.WriteLine("Write min millage");
                    int answerForMin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Write max millage");
                    int answerForMax = Convert.ToInt32(Console.ReadLine());
                    foreach (var item in newCars)
                    {
                        if (item.Millage > answerForMin && item.Millage < answerForMax)
                        {
                            item.ShowInfo();
                            
                        }
                    }

                }
                else if (answer == 2)
                {
                    foreach (var item in newCars)
                    {
                        item.ShowInfo();
                    }
                }
                else if (answer == 3) 
                {
                    Console.WriteLine("You are welcome :)");
                    check = false;
                
                }
                else
                {
                    Console.WriteLine("You have to write 1 , 2 , 3");
                }
                

            }


        }
        
       

       
    }
}
