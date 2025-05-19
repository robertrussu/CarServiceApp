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
    }
}
