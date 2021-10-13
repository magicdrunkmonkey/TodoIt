using System;
using Xunit;
using TodoIt;
using TodoIt.Model;


namespace TodoIt.Tests
{
    public class PersonTests
    {
        [Theory]
        [InlineData(0,"Tolvar","Tolvarsson")]
        public void ConstructorPerson(int expectedNumber, string expectedFirstName, string expectedLastName)
        {
            //Arrange            
            //int expectedNumber = 1;
            //string expectedFirstName = "Tolvar";
            //string expectedLastName = "Tolvarsson";

            //Act
            Person test = new Person(expectedNumber, expectedFirstName, expectedLastName);
            int actualNumber = test.PersonId;
            string actualFirstName = test.FirstName;
            string actualLastName = test.LastName;

            //Assert
            Assert.Equal(expectedNumber, actualNumber);
            Assert.Equal(expectedFirstName, actualFirstName);
            Assert.Equal(expectedLastName, actualLastName);
        }
    }
}
