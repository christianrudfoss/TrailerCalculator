using System;
using TrailerCalculatorCore.Models;
using TrailerCalculatorLibrary;
namespace TrailorCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle carEV66684 = new() { RegistrationNumber = "EV66684", TotalWeight = 3130, MaxTrailerWeight = 9000, MaxTotalWeight = 12500 };
            Trailer trailerKY6490 = new() { RegistrationNumber = "KY6490", DeadWeight = 1076 };
            Trailer trailerAZ8056 = new() { RegistrationNumber = "AZ8056", DeadWeight = 155 };

            

            Console.WriteLine($"Task 1A:    Class 'B'   legal with {trailerKY6490.RegistrationNumber} (car weight: {carEV66684.TotalWeight}kg. Trailer weight: {trailerKY6490.DeadWeight + 2424}kg) => " +
                $"{TrailerCalculatorProcessor.ValidDriverLicence("B", carEV66684.TotalWeight, trailerKY6490.DeadWeight + 2424)}");

            Console.WriteLine($"Task 1B:    Class 'BE'  legal with {trailerKY6490.RegistrationNumber} (car weight: {carEV66684.TotalWeight}kg. Trailer weight: {trailerKY6490.DeadWeight + 2424}kg) => " +
                $"{TrailerCalculatorProcessor.ValidDriverLicence("BE", carEV66684.TotalWeight, trailerKY6490.DeadWeight + 2424)}");

            Console.WriteLine($"Task 2:     Class 'B'   legal with {trailerAZ8056.RegistrationNumber} (car weight: {carEV66684.TotalWeight}kg. Trailer weight: {trailerAZ8056.DeadWeight + 510}kg ) => " +
                $"{TrailerCalculatorProcessor.ValidDriverLicence("B", carEV66684.TotalWeight, trailerAZ8056.DeadWeight + 510)}");

            Console.WriteLine($"Task 3 (1): Class 'B96' legal with {trailerKY6490.RegistrationNumber} (car weight: {carEV66684.TotalWeight}kg. Trailer weight: {trailerKY6490.DeadWeight + 2424}kg) => " +
                $"{TrailerCalculatorProcessor.ValidDriverLicence("B96", carEV66684.TotalWeight, trailerKY6490.DeadWeight + 2424)}");

            Console.WriteLine($"Task 3 (2): Class 'B96' legal with {trailerAZ8056.RegistrationNumber} (car weight: {carEV66684.TotalWeight}kg. Trailer weight: {trailerAZ8056.DeadWeight + 510}kg ) => " +
                $"{TrailerCalculatorProcessor.ValidDriverLicence("B96", carEV66684.TotalWeight, trailerAZ8056.DeadWeight + 510)}");



            //Vehicle carEV6668A = new() { RegistrationNumber = "EV6668A", DeadWeight = 100, LoadWeight = 200, MaxTrailerWeight = 9000, MaxTotalWeight = 12500 };
            //Console.WriteLine($"EV6668A total weight: {carEV6668A.TotalWeightCalculate()}");
        }
    }
}
