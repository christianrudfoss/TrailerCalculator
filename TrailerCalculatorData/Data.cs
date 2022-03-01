using System;
using System.Collections.Generic;
using System.Linq;
using TrailerCalculatorCore.Models;

namespace TrailerCalculatorData
{
    public static class Data
    {
        public static Licence GetValidDriverLicence(string driverLicenceClassName, int carWeight, int trailerWeight)
        {
            List<Licence> licences = FeedLicences();

            Licence licence = licences.FirstOrDefault(licence =>
                licence.SertificateClassName.Equals(driverLicenceClassName)
                &&
                (
                    ((carWeight + trailerWeight) <= licence.MaxTotalWeight
                    && carWeight <= licence.CarMaxTotalWeight
                    && trailerWeight <= licence.TrailerMaxWeight)
                    ||                                                                                                  // remove
                    ((carWeight + trailerWeight) <= licence.AlternativMaxTotalWeight                                    // remove
                    && carWeight <= licence.CarMaxTotalWeight)                                                          // remove
                )
                );

            return licence;
        }
        public static List<Licence> FeedLicences()
        {
            Licence licence = new()
            {
                SertificateClassName = "B",
                CarMaxTotalWeight = 3500,
                TrailerMaxWeight = 750,                                                                                 // int.MaxValue
                MaxTotalWeight = 4250,                                                                                  // 3500
                AlternativMaxTotalWeight = 3500                                                                         // remove
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

            Licence licence4 = new()
            {
                SertificateClassName = "B96",
                CarMaxTotalWeight = 3500,
                TrailerMaxWeight = int.MaxValue,
                MaxTotalWeight = 4250
            };
            return new List<Licence>() { licence, licence2, licence3, licence4 };
        }
    }
}
