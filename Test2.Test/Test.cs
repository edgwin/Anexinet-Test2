using System;
using System.Collections.Generic;
using FizzBuzzLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test2.Test
{
    [TestClass]
    public class Test
    {
        private readonly List<string> expected = new List<string>()
        {
            "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz",
            "16", "17", "Fizz", "19", "Buzz", "Fizz", "22", "23", "Fizz", "Buzz", "26", "Fizz", "28", "29",
            "FizzBuzz", "31", "32", "Fizz", "34", "Buzz", "Fizz", "37", "38", "Fizz", "Buzz", "41", "Fizz", "43",
            "44", "FizzBuzz", "46", "47", "Fizz", "49", "Buzz", "Fizz", "52", "53", "Fizz", "Buzz", "56", "Fizz",
            "58", "59", "FizzBuzz", "61", "62", "Fizz", "64", "Buzz", "Fizz", "67", "68", "Fizz", "Buzz", "71",
            "Fizz", "73", "74", "FizzBuzz", "76", "77", "Fizz", "79", "Buzz", "Fizz", "82", "83", "Fizz", "Buzz",
            "86", "Fizz", "88", "89", "FizzBuzz", "91", "92", "Fizz", "94", "Buzz", "Fizz", "97", "98", "Fizz",
            "Buzz"
        };
        private readonly FizzBuzz _fizzBuzz;
        private string _message = "Failed";

        public Test()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [TestMethod]
        public void FizzBuzzExpected()
        {
            //Arrange
            var tokens = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" }
            };

            //Act
            var result = _fizzBuzz.Execute(1, 100, tokens, ref _message);

            //Assert
            Assert.AreEqual("Success", _message);
            CollectionAssert.AreEqual(expected, result);            
        }
        [TestMethod]
        public void FizzBuzzUnexpected()
        {
            //Arrange
            var tokens = new Dictionary<int, string>
            {
                { 2, "Fizz" },
                { 8, "Buzz" }
            };

            //Act
            var result = _fizzBuzz.Execute(1, 100, tokens, ref _message);

            //Assert
            Assert.AreEqual("Success", _message);
            CollectionAssert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void FizzBuzzInitValueHigher()
        {
            //Arrange
            var tokens = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" }
            };

            //Act
            var result = _fizzBuzz.Execute(100, 10, tokens, ref _message);

            //Assert
            Assert.AreEqual("Falied Initial value could not be higher than end value", _message);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void FizzBuzzDivisionByZero()
        {
            //Arrange
            var tokens = new Dictionary<int, string>
            {
                { 0, "Fizz" },
                { 5, "Buzz" }
            };

            //Act
            var result = _fizzBuzz.Execute(1, 100, tokens, ref _message);

            //Assert
            Assert.AreEqual("No zero allowed in token range", _message);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void FizzBuzzLessThanZero()
        {
            //Arrange
            var tokens = new Dictionary<int, string>
            {
                { 3, "Fizz" },
                { 5, "Buzz" }
            };

            //Act
            var result = _fizzBuzz.Execute(-1, 100, tokens, ref _message);

            //Assert
            Assert.AreEqual("Falied Initial value could not be 0 or less", _message);
            Assert.IsNull(result);
        }
    }
}
