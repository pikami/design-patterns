using System;
using System.Collections.Generic;
using System.Text;

namespace TE.Uzd5431
{
    public class Uzd5431Program
    {
        public static void Uzd5431Main()
        {
            var configurator = CarShop.BuyCar();

            configurator.AddBody("Hatchback")
                .AddEngine("2.2L Diesel 81 Kw")
                .AddSeats(5)
                .AddWheels("Stock wheels");

            var car = configurator.BuildCar();
            Console.WriteLine($"Car stats: {car.Body}, {car.Engine}, {car.Seats}, {car.Wheels}");
        }
    }
}
