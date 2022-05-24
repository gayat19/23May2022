using NUnit.Framework;
using ExampleApplication;
using ExampleApplication.Services;
using System;

namespace ExampleTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(true)]
        public void CheckNumberPass(bool res)
        {
            //Arrange
            ISample sample = new SampleService();
            //Action
            var result = sample.CheckNumber(21);
            //Assert
            Assert.AreEqual(res, result);
        }
        [Test]
        public void CheckNumberFail()
        {
            //Arrange
            ISample sample = new SampleService();
            //Action
            var result = sample.CheckNumber(22);
            //Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void CheckNumberException()
        {
            //Arrange
            ISample sample = new SampleService();
            //Action
            var result = Assert.Throws<OverflowException>(delegate { sample.CheckNumber(int.MaxValue); });
            //Assert
            Assert.AreEqual("Arithmetic operation resulted in an overflow.", result.Message);
        }
        [Test]
        public void ChGetNamesFail()
        {
            //Arrange
            ISample sample = new SampleService();
            //Action
            var result = sample.GetNames();
            //Assert
            Assert.AreNotEqual(0,result.Count);
        }
        [Test]
        [TestCase(2)]
        [TestCase(1)]
        public void ChGetNamesPass(int res)
        {
            //Arrange
            ISample sample = new SampleService();
            //Action
            var result = sample.GetNames();
            //Assert
            Assert.AreEqual(res, result.Count);
        }

    }
}