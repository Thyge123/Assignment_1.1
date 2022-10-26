using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mandatory_assignment_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandatory_assignment_1.Tests
{
    [TestClass()]
    public class FootballPlayerTests
    {
        FootballPlayer footballPlayer = new FootballPlayer {Id = 1, Name = "Martin", Age = 21, ShirtNumber = 5 };
        FootballPlayer footballPlayerNameNull = new FootballPlayer {Id = 2, Name = null, Age = 21, ShirtNumber = 5 };
        FootballPlayer footballPlayerNameShort = new FootballPlayer {Id = 3, Name = "M", Age = 21, ShirtNumber = 5 };
        FootballPlayer footballPlayerAge = new FootballPlayer {Id = 4, Name = "Martin", Age = 0, ShirtNumber = 5 };
        FootballPlayer footballPlayerShirtNumberLow = new FootballPlayer {Id = 5, Name = "Martin", Age = 21, ShirtNumber = 0 };
        FootballPlayer footballPlayerShirtNumberHigh = new FootballPlayer {Id = 6, Name = "Martin", Age = 21, ShirtNumber = 100 };


        [TestMethod()]
        public void FootballPlayerTest()
        {
            FootballPlayer footballPlayer = new FootballPlayer(1, "Martin", 21, 5);
            Assert.AreEqual(1, footballPlayer.Id);
            Assert.AreEqual("Martin", footballPlayer.Name);
            Assert.AreEqual(21, footballPlayer.Age);
            Assert.AreEqual(5, footballPlayer.ShirtNumber);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            string str = footballPlayer.ToString();
            Assert.AreEqual("{Id=1, Name=Martin, Age=21, ShirtNumber=5}", str);
        }

        [TestMethod()]
        public void ValidateNameTest()
        {
            footballPlayer.ValidateName();
            //Assert.ThrowsException<ArgumentNullException>(() => footballPlayerNameNull.ValidateName());
            Assert.ThrowsException<ArgumentException>(() => footballPlayerNameShort.ValidateName());
        }

        [TestMethod()]
        public void ValidateAgeTest()
        {
            footballPlayer.ValidateAge();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayerAge.ValidateAge());
        }


        [TestMethod()]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(98)]
        [DataRow(99)]
        public void ValidateShirtNumberTest(int shirtNumber)
        {
            footballPlayer.ShirtNumber = shirtNumber;
            footballPlayer.ValidateShirtNumber();
        }

        [TestMethod()]
        public void ValidateShirtNumberOutOfRangeTest()
        {
            footballPlayer.ValidateShirtNumber();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayerShirtNumberLow.ValidateShirtNumber());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayerShirtNumberHigh.ValidateShirtNumber());
        }

        [TestMethod()]
        public void ValidateTest()
        {
            footballPlayer.Validate();
            //Assert.ThrowsException<ArgumentNullException>(() => footballPlayerNameNull.Validate());
            Assert.ThrowsException<ArgumentException>(() => footballPlayerNameShort.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayerAge.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayerShirtNumberLow.Validate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => footballPlayerShirtNumberHigh.Validate());
        }
    }
}