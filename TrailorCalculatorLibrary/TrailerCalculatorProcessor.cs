using System.Collections.Generic;
using System.Linq;
using TrailorCalculatorLibrary.Models;

namespace TrailerCalculatorLibrary
{
    public static class TrailerCalculatorProcessor
    {
        public static List<Licence> FeedLicences()
        {
            Licence licence = new()
            {
                SertificateClassName = "B",
                CarMaxTotalWeight = 3500,
                TrailerMaxWeight = 750,                                                             // int.MaxValue
                MaxTotalWeight = 4250,                                                              // 3500
                AlternativMaxTotalWeight = 3500                                                     // remove
            };

            Licence licence2 = new()
            {
                SertificateClassName = "BE",
                CarMaxTotalWeight = 3500,
                TrailerMaxWeight = 3500,
                MaxTotalWeight = 7000
            };

            Licence licence3 = new()
            {
                SertificateClassName = "C1E",
                CarMaxTotalWeight = 3500,
                TrailerMaxWeight = int.MaxValue,
                MaxTotalWeight = int.MaxValue,
            };

            Licence licence4 = new() { 
                SertificateClassName = "B96",
                CarMaxTotalWeight = 3500,
                TrailerMaxWeight = int.MaxValue,
                MaxTotalWeight = 4250
            };
            return new List<Licence>() {licence, licence2, licence3, licence4 };
        }

        public static bool ValidDriverLicence(string driverLicenceClassName, int carWeight, int trailerWeight)
        {
            if (carWeight > 0)
            {
                //should be stored in database:
                List<Licence> licences = FeedLicences();

                //should retrieve from classlibrary 'Data' (even through api using dependency injection)
                Licence licence = licences.FirstOrDefault(licence =>
                    licence.SertificateClassName.Equals(driverLicenceClassName)
                    &&
                    (
                        ((carWeight + trailerWeight) <= licence.MaxTotalWeight 
                        && carWeight <= licence.CarMaxTotalWeight 
                        && trailerWeight <= licence.TrailerMaxWeight)
                        ||                                                                          // remove
                        ((carWeight + trailerWeight) <= licence.AlternativMaxTotalWeight            // remove
                        && carWeight <= licence.CarMaxTotalWeight)                                  // remove
                    )
                    );

                if (licence == null)
                    return false;
                else
                    return true;
            }
            else
                return true;
        }
    }
}
