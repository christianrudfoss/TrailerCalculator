using Xunit;
using TrailerCalculatorLibrary;
using TrailerCalculatorCore.Models;

namespace TrailerCalculatorTest
{
    public class TrailerCalculatorUnitTest
    {
        [Theory]
        [InlineData("B", 3530, 0)]
        [InlineData("BE", 3530, 0)]
        [InlineData("C1E", 3530, 0)]
        [InlineData("B96", 3530, 0)]
        public void CarTooHeavy_IsLegalShouldBeFalse(string driverLicenceClassName, int carTotalWeight, int trailerTotalWeight)
        {
            Assert.False(TrailerCalculatorProcessor.ValidDriverLicence(driverLicenceClassName, carTotalWeight, trailerTotalWeight));
        }
        [Theory]
        [InlineData("B", 3130, 0)]
        [InlineData("BE", 3130, 0)]
        [InlineData("C1E", 3130, 0)]
        [InlineData("B96", 3130, 0)]
        public void CarNotTooHeavyIsLegalShouldBeTrue(string driverLicenceClassName, int carTotalWeight, int trailerTotalWeight)
        {
            Assert.True(TrailerCalculatorProcessor.ValidDriverLicence(driverLicenceClassName, carTotalWeight, trailerTotalWeight));
        }

        [Theory]
        [InlineData("B", 3600, 0)]
        [InlineData("B", 3000, 800)]                                                                // move to method under
        [InlineData("BE", 3510, 1000)]
        [InlineData("BE", 3500, 4000)]
        [InlineData("C1E", 3510, 1000)]
        [InlineData("C1E", 3510, 4500)]
        [InlineData("B96", 3510, 500)]
        [InlineData("B96", 3500, 751)]
        public void ValidDriverLicenceShouldBeFalse(string driverLicenceClassName, int carTotalWeight, int trailerTotalWeight)
        {
            Assert.False(TrailerCalculatorProcessor.ValidDriverLicence(driverLicenceClassName, carTotalWeight, trailerTotalWeight));
        }

        [Theory]
        [InlineData("B", 3130, 150)]
        [InlineData("B", 2500, 1000)]
        [InlineData("B", 3000, 600)]                                                                // move to method over
        [InlineData("B", 3400, 200)]                                                                // move to method over
        [InlineData("B", 3500, 750)]                                                                // move to method over
        [InlineData("BE", 2500, 1000)]
        [InlineData("BE", 3500, 3500)]
        [InlineData("C1E", 3500, 1000)]
        [InlineData("C1E", 3500, 4500)]
        [InlineData("B96", 3500, 750)]
        [InlineData("B96", 2500, 1750)]
        public void ValidDriverLicenceShouldBeTrue(string driverLicenceClassName, int carTotalWeight, int trailerTotalWeight)
        {
            Assert.True(TrailerCalculatorProcessor.ValidDriverLicence(driverLicenceClassName, carTotalWeight, trailerTotalWeight));
        }

        
        
        
        
        
        
        
        
        [Fact]
        public void TrailerWeightTooHeavyTrailerWeightIsValidForVehicle_False()
        {
            Vehicle vehicle = new() { MaxTotalWeight = 3500, MaxTrailerWeight = 500, TotalWeight = 2000 };
            int trailerWeight = 600;
            Assert.False(TrailerCalculatorProcessor.TrailerWeightIsValidForVehicle(vehicle, trailerWeight));
        }
        [Fact]
        public void TotalTrailerWeightTooHeavyTrailerWeightIsValidForVehicle_False2()
        {
            Vehicle vehicle = new() { MaxTotalWeight = 4500, MaxTrailerWeight = 1500, TotalWeight = 3500 };
            int trailerWeight = 1100;
            Assert.False(TrailerCalculatorProcessor.TrailerWeightIsValidForVehicle(vehicle, trailerWeight));
        }
        [Fact]
        public void TrailerWeightIsValidForVehicle_True()
        {
            Vehicle vehicle = new() { MaxTotalWeight = 4500, MaxTrailerWeight = 1500, TotalWeight = 3500 };
            int trailerWeight = 900;
            Assert.True(TrailerCalculatorProcessor.TrailerWeightIsValidForVehicle(vehicle, trailerWeight));
        }
    }
}
