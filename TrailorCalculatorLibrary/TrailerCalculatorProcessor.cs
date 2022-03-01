using System;
using System.Collections.Generic;
using System.Linq;
using TrailerCalculatorCore.Models;
using TrailerCalculatorData;

namespace TrailerCalculatorLibrary
{
    public static class TrailerCalculatorProcessor
    {
        public static bool ValidDriverLicence(string driverLicenceClassName, int carWeight, int trailerWeight)
        {
            if (carWeight > 0)
            {
                Licence licence = Data.GetValidDriverLicence(driverLicenceClassName, carWeight, trailerWeight);

                if (licence == null)
                    return false;
                else
                    return true;
            }
            else
                return true;
        }






















        public static bool ValidDriverLicence(string driverLicenceClassName, Vehicle vehicle, int trailerWeight)
        {
            if(TrailerWeightIsValidForVehicle(vehicle, trailerWeight))
            {
                Licence licence = Data.GetValidDriverLicence(driverLicenceClassName, vehicle.TotalWeight, trailerWeight);

                if (licence == null)
                    return false;
                else
                    return true;
            }
            else
                return true;
        }

        public static bool TrailerWeightIsValidForVehicle(Vehicle vehicle, int trailerWeight)
        {
            return vehicle.TotalWeight > 0 
                && trailerWeight <= vehicle.MaxTrailerWeight 
                && (vehicle.TotalWeight + trailerWeight) <= vehicle.MaxTotalWeight;
        }
    }
}
