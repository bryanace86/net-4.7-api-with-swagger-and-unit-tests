using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwaggerAPI.Controllers;
using SwaggerAPI.Models;
using System;
using System.Linq;

namespace SwaggerAPI.Tests.Controllers
{
    [TestClass]
    public class ItemsControllerTest
    {

        [TestMethod]
        public void Get()
        {
            // Arrange
            ItemsController controller = new ItemsController();

            // Act
            IQueryable<Item> result = controller.GetItems();

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
