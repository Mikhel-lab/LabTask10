using System;
using System.Collections.Generic;
namespace LabTask10
{
    class Program
    {
        static void Main(string[] args)
        {
            string make, model;
            int year;
            decimal price;

            Car car = new Car();

            Console.WriteLine("Welcome to James Stuart’s Cool “Dealers Car” Autos!(show or list or add)" );
            string Dealer = Console.ReadLine();


            Console.WriteLine("Please enter the make of your car: ");
            make = Console.ReadLine();


            Console.WriteLine("Please enter the model of the car:");
            model = Console.ReadLine();


            Console.WriteLine("Please enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter the price: ");
            price = Convert.ToDecimal(Console.ReadLine());

            
            List<Car> cars = new List<Car>(){car};

            var result = $"make : {make}\nmodel :{model}\nyear : {year}\nprice: {price:C}";

            int count = 0;
            foreach (Car c in cars )
            {

               if(Dealer == "list")

                {
                 //   Console.WriteLine("There are currently no cars in the catalog.");
                   car.add();
                   Console.WriteLine(result);
                      break;
                  }
                   else if(Dealer == "show")
                  {
                    Console.WriteLine("There are currently no cars in the catalog.");
                    break;
                  }   else{
                      if(Dealer == "add")
                      {
                             car.add();
                             Console.WriteLine(result);
                              continue;
                             count++;
                            
                      }
                  }
                 
              }


        }
    }
}
