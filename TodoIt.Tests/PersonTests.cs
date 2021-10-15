using System;
using Xunit;
using TodoIt;
using TodoIt.Model;
using TodoIt.Data;


namespace TodoIt.Tests
{
    public class PersonTests
    {
        [Theory]
        [InlineData(0,"Tolvar","Tolvarsson")]
        public void ConstructorPerson(int expectedNumber, string expectedFirstName, string expectedLastName)
        {
            //Prepare
            PersonSequencer.Reset();

            //Arrange               

            //Act
            Person test = new Person(expectedNumber, expectedFirstName, expectedLastName);
            int actualNumber = test.PersonId;
            string actualFirstName = test.FirstName;
            string actualLastName = test.LastName;

            //Assert
            Assert.Equal(expectedNumber, actualNumber);
            Assert.Equal(expectedFirstName, actualFirstName);
            Assert.Equal(expectedLastName, actualLastName);

            //Cleanup
            PersonSequencer.Reset();
            
        }
        
        [Theory]
        [InlineData(0, null, "Tolvarsson")]
        [InlineData(0, "", "Tolvarsson")]
        public void check_FirstName_NullAndEmpty(int expectedNumber, string expectedFirstName, string expectedLastName)
        {
            //Prepare
            PersonSequencer.Reset();

            //Arrange            
            string expectedMessage = "Not a valid name.";

            //Act            
            ArgumentException result = Assert.Throws<ArgumentException>(
                () => new Person(expectedNumber, expectedFirstName, expectedLastName));

            //Assert
            Assert.Equal(expectedMessage, result.Message);            

            //Cleanup
            PersonSequencer.Reset();
        }

        
        [Theory]
        [InlineData(0, "Tolvar", null)]
        [InlineData(0, "Tolvar", "")]
        public void check_LastName_NullAndEmpty(int expectedNumber, string expectedFirstName, string expectedLastName)
        {
            //Prepare
            PersonSequencer.Reset();

            //Arrange            
            string expectedMessage = "Not a valid name.";

            //Act            
            ArgumentException result = Assert.Throws<ArgumentException>(
                () => new Person(expectedNumber, expectedFirstName, expectedLastName));

            //Assert
            Assert.Equal(expectedMessage, result.Message);

            //Cleanup
            PersonSequencer.Reset();
        }        
    }
}
