using Xunit;
using Microsoft.AspNetCore.Mvc;
using CarServiceApp.Controllers;
using CarServiceApp.Models;

namespace CarServiceApp.Tests
{
 public class ServiceControllerTests
    {
        [Fact]
        public void Schedule_InvalidModel_ReturnsViewWithModel()
        {
            // Arrange
            var controller = new ServiceController();
            controller.ModelState.AddModelError("FullName", "Required");

            var request = new ServiceRequest
            {
                Email = "test@example.com",
                VehicleModel = "Mazda MX-5",
                ProblemDescription = "Testing test test"
                // FullName is missing
            };

            // Act
            var result = controller.Schedule(request) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.False(controller.ModelState.IsValid);
            Assert.IsType<ServiceRequest>(result.Model);
        }
    }
    
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
