using NUnit.Framework;
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
        public void Should_BeAFailedTest(string stringToAssert)
        {
            // arrange / act
            string failingTestString = DefaultTestCase.FailedTest();

            // assert
            failingTestString.ShouldBe(stringToAssert);
        }

        [TestCase("This works!...")]
        public void Should_BeASuccessfulTest(string stringToAssert)
        {
            // arrange / act
            string successfulTest = DefaultTestCase.SuccessfulTest();

            // assert
            successfulTest.ShouldBe(stringToAssert);
        }
    }
}