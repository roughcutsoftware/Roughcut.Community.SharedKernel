using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;
using Roughcut.Community.SharedKernel.Web.Controllers;
using Shouldly;

namespace Roughcut.Community.SharedKernel.Tests.UnitTests
{
    public class SharedKernelTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("This works!...")]
        public void Should_BeFailedTest(string stringToAssert)
        {
            // arrange / act
            string failingTestString = DefaultTestCase.FailedTest();

            // assert
            failingTestString.ShouldBe(stringToAssert);
        }

        [TestCase("This works!...")]
        public void Should_BeSuccessfulTest(string stringToAssert)
        {
            // arrange / act
            string successfulTest = DefaultTestCase.SuccessfulTest();

            // assert
            successfulTest.ShouldBe(stringToAssert);
        }

        [TestCase("This works!...")]
        public void Should_BeSuccessfulWebTest(string stringToAssert)
        {
            // arrange
            HomeController controller = new HomeController(new Logger<HomeController>(new NullLoggerFactory()));

            // act
            IActionResult result = controller.Index() as IActionResult;

            // assert
            result.ShouldNotBeNull();

  
        }
    }
}