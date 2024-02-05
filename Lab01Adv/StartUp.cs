/*
2 2.6 3 1.6 2 3.6 3 1.6
1 3.3 2 1.6 5 2.4 1 3.2
No more tires
331 2.2
145 2.0
Engines done
Audi A5 2017 200 12 0 0
BMW X5 2007 175 18 1 1
Show special
 */

using System;
using System.Collections.Generic;
using System.Linq; // Added for Sum

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire> tires = new List<Tire>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            // Collect tire information
            string command = Console.ReadLine();

            while (command != "No more tires")
            {
                string[] tireInfo = command.Split();
                int year = int.Parse(tireInfo[0]);
                double pressure = double.Parse(tireInfo[1]);

                tires.Add(new Tire(year, pressure));
                command = Console.ReadLine();
            }

            // Collect engine information
            command = Console.ReadLine();

            while (command != "Engines done")
            {
                string[] engineInfo = command.Split();
                int horsePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]); // Fix index here

                engines.Add(new Engine(horsePower, cubicCapacity));
                command = Console.ReadLine();
            }

            // Collect car information
            command = Console.ReadLine();
            while (command != "Show special") // Remove second declaration of command
            {
                string[] carInfo = command.Split();
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                // Collect tire indices
                List<int> tireIndices = new List<int>();
                for (int i = 6; i < carInfo.Length; i++)
                {
                    tireIndices.Add(int.Parse(carInfo[i]));
                }

                Engine selectedEngine = engines[engineIndex];
                List<Tire> selectedTires = new List<Tire>();

                // Ensure that the specified tire indices are within bounds
                foreach (var tireIndex in tireIndices)
                {
                    if (tireIndex >= 0 && tireIndex < tires.Count)
                    {
                        selectedTires.Add(tires[tireIndex]);
                    }
                }

                // Create a car with the collected information
                // Create a car with the collected information
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, selectedEngine, selectedTires.ToArray());

                // Add the car to the list
                cars.Add(car);

                command = Console.ReadLine();
            }

            // Drive 20 kilometers for all cars
            foreach (var car in cars)
            {
                car.Drive(20);
            }

            // Display information about special cars
            foreach (var specialCar in cars
                .Where(car => car.Year >= 2017 && car.Engine.HorsePower > 330 &&
                    car.Tires.Sum(tire => tire.Pressure) >= 9 && car.Tires.Sum(tire => tire.Pressure) <= 10))
            {
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
                Console.WriteLine();
            }
        }
    }
}
