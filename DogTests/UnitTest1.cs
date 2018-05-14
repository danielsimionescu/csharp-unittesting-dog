using System;
using DogLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static DogLibrary.Dog;

namespace DogTests
{
    [TestClass]
    public class UnitTest1
    {
        Dog dog;
        string name;
        int age;
        double weight;

        [TestInitialize]
        public void Initialize()
        {
            name = "Rex";
            age = 12;
            weight = 5.4;
        }

        [TestMethod]
        public void TestNameAge()
        {
            // arrange

            // act
            dog = new Dog(name, age);

            // assert
            Assert.AreEqual(age, dog.Age);
            Assert.AreEqual(name, dog.Name);
        }

        [TestMethod]
        public void TestWeight()
        {
            // arrange
            dog = new Dog(name, age);

            // act
            dog.Weight = weight;

            // assert
            Assert.AreEqual(weight, dog.Weight);
        }

        [TestMethod]
        public void TestColor()
        {
            // arrange
            var color = Colors.White;
            dog = new Dog(name, age);

            // act
            dog.Color = color;

            // assert
            Assert.AreEqual(color, dog.Color);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEmptyName()
        {
            // arrange
            name = string.Empty;

            // act
            dog = new Dog(name, age);

            // assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestShortName()
        {
            // arrange
            name = "RT";

            // act
            dog = new Dog(name, age);

            // assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNegativeAge()
        {
            // arrange
            age = -8;

            // act
            dog = new Dog(name, age);

            // assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNegativeWeight()
        {
            // arrange
            weight = -8;
            dog = new Dog(name, age);

            // act
            dog.Weight = weight;

            // assert
        }
    }
}
