using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using YouBook.Controllers;
using YouBook.Models;
using YouBook.Services;
using FluentAssertions;

namespace YouBook.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private Mock<IMeetingDomainService> meetingDomainServiceMock;

        [TestInitialize]
        public void TestInitialize()
        {
            this.meetingDomainServiceMock = new Mock<IMeetingDomainService>();
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            var meeting = new Meeting { Description = "test meeting", ScheduledDate = new DateTime(2019, 01, 01), Id = 999 };
            meetingDomainServiceMock.Setup(x => x.GetMeetingById(It.IsAny<int>())).Returns(meeting);
            HomeController controller = new HomeController(meetingDomainServiceMock.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            string message = result.ViewBag.Message;
            message.Should().Be(meeting.Description);
        }
    }
}
