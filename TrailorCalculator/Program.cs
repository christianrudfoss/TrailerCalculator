using System;
using TrailerCalculatorCore.Models;
using TrailerCalculatorLibrary;
namespace TrailorCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle carEV66684 = new() { VehicleNumber = "EV66684", TotalWeight = 3130, MaxTrailerWeight = 9000, MaxTotalWeight = 12500 };
            Trailer trailerKY6490 = new() { TrailerNumber = "KY6490", DeadWeight = 1076 };
            Trailer trailerAZ8056 = new() { TrailerNumber = "AZ8056", DeadWeight = 155 };

            Console.WriteLine($"Task 1A: Class 'B' legal with {trailerKY6490.TrailerNumber} (car weight: {carEV66684.TotalWeight}kg. Trailer weight: {trailerKY6490.DeadWeight + 2424}kg): " +
                $"{TrailerCalculatorProcessor.ValidDriverLicence("B", carEV66684.TotalWeight, trailerKY6490.DeadWeight + 2424)}");

            Console.WriteLine($"Task 1B: Class 'BE' legal with {trailerKY6490.TrailerNumber} (car weight: {carEV66684.TotalWeight}kg. Trailer weight: {trailerKY6490.DeadWeight + 2424}kg): " +
                $"{TrailerCalculatorProcessor.ValidDriverLicence("BE", carEV66684.TotalWeight, trailerKY6490.DeadWeight + 2424)}");

            Console.WriteLine($"Task 2:  Class 'B' legal with {trailerAZ8056.TrailerNumber} (car weight: {carEV66684.TotalWeight}kg. Trailer weight: {trailerAZ8056.DeadWeight + 510}kg): " +
                $"{TrailerCalculatorProcessor.ValidDriverLicence("B", carEV66684.TotalWeight, trailerAZ8056.DeadWeight + 510)}");

            Console.WriteLine($"Task 3 (1): Class 'B96' legal with {trailerKY6490.TrailerNumber} (car weight: {carEV66684.TotalWeight}kg. Trailer weight: {trailerKY6490.DeadWeight + 2424}kg): " +
                $"{TrailerCalculatorProcessor.ValidDriverLicence("B96", carEV66684.TotalWeight, trailerKY6490.DeadWeight + 2424)}");

            Console.WriteLine($"Task 3 (2): Class 'B96' legal with {trailerAZ8056.TrailerNumber} (car weight: {carEV66684.TotalWeight}kg. Trailer weight: {trailerAZ8056.DeadWeight + 510}kg): " +
                $"{TrailerCalculatorProcessor.ValidDriverLicence("B96", carEV66684.TotalWeight, trailerAZ8056.DeadWeight + 510)}");
        }
    }
}
