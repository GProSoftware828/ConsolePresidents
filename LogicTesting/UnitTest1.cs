using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.IO;


namespace ListOfUSAPresidents
{
    [TestFixture]
    class NUnitTests
    {
        public string[] ReadFile(string filepath)
        {
            string[] lines = System.IO.File.ReadAllLines(@filepath);
            return lines;
        }
        [Test]
        public void SampleTest()
        {
            //arrange
            string input1 = "Parties";


            //act
            if (input1.Contains("Parties"))
            {
                string output = string.Join("", ReadFile("C:/Users/PC33425/Desktop/ListOfUSAPresidents/PoliticalParties.txt"));


                //assert
                Assert.AreEqual(output, ("Whigs,Progressive Party,Republicans,Democrats,Democratic-Republicans,Federalists,Green Party of the United States,National-Union Party,Unaffiliated,Bull Moose Party,Socialist Party,"));
            }
        }

        [TearDown]
        public void EndTest()
        {
            string input1 = null;
            string output = null;
        }
    }
}