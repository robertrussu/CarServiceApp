using Xunit;
using Microsoft.AspNetCore.Mvc;
using CarServiceApp.Controllers;

namespace CarServiceApp.Tests
{
    public class VINCheckerControllerTests
    {
        [Fact]
        public void VINChecker_Index_Post_ReturnsError_WhenVinIsEmpty()
        {
            // Arrange
            var controller = new VINCheckerController();

            // Act
            var result = controller.Index("") as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Please enter a VIN.", result.ViewData["Error"]);
        }

        [Fact]
        public void VINChecker_Index_Get_ReturnsView()
        {
            // Arrange
            var controller = new VINCheckerController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result); 
            Assert.True(result?.ViewName == null || result.ViewName == "Index");
        }
        [Fact]
        public void VINChecker_Index_Post_ReturnsError_WhenVinIsTooShort()
        {
            // Arrange
            var controller = new VINCheckerController();
            string shortVin = "123456789";

            // Act
            var result = controller.Index(shortVin) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("VIN must be exactly 17 characters.", result.ViewData["Error"]);
        }

        [Fact]
        public void VINChecker_Index_Post_ReturnsError_WhenVinIsTooLong()
        {
            // Arrange
            var controller = new VINCheckerController();
            string longVin = "12345678901234567890";
            //string longVin = "12345678901234567";

            // Act
            var result = controller.Index(longVin) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("VIN must be exactly 17 characters.", result.ViewData["Error"]);
        }

    }
}
