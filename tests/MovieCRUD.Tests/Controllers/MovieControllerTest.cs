using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieCRUD;
using MovieCRUD.Controllers;

namespace MovieCRUD.Tests.Controllers
{
    [TestClass]
    public class MovieControllerTest
    {
        [TestMethod]
        public void List_ReturnsNotNullMovieModel()
        {
            // Arrange
            MovieController controller = new MovieController();

            // Act
            ViewResult result = controller.List() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create()
        {
            // Arrange
            MovieController controller = new MovieController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Details()
        {
            // Arrange
            MovieController controller = new MovieController();

            /*
            // Act
            ViewResult result = controller.Details() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            */
        }
    }
}
