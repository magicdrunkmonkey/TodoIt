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
            //PersonSequencer.Reset();

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
            //PersonSequencer.Reset();
        }
        /*
        [Theory]
        [InlineData(0, null, "Tolvarsson")]
        //[InlineData(0, "", "Tolvarsson")]
        public void check_FirstName_Null(int expectedNumber, string expectedFirstName, string expectedLastName)
        {
            //Prepare
            PersonSequencer.Reset();

            //Arrange
            Person checkFirstName = new Person(expectedNumber, expectedFirstName, expectedLastName);

            //Act

            //Assert            
            //Assert.Throws<ArgumentException>(() => new Person(expectedNumber, expectedFirstName, expectedLastName));
            //Assert.Throws<NullReferenceException>(() => new Person(expectedNumber, expectedFirstName, expectedLastName));
            //Assert.Equal("Not a valid name.", () => new Person(expectedNumber, expectedFirstName, expectedLastName));
            Assert.Throws<ArgumentException>(() => new Person(expectedNumber, expectedFirstName, expectedLastName));

            //Cleanup
            PersonSequencer.Reset();
        }

        [Theory]
        //[InlineData(0, null, "Tolvarsson")]
        [InlineData(0, "", "Tolvarsson")]
        public void check_FirstName_Empty(int expectedNumber, string expectedFirstName, string expectedLastName)
        {
            //Prepare
            PersonSequencer.Reset();

            //Arrange
            Person checkFirstName = new Person(expectedNumber, expectedFirstName, expectedLastName);
            string actualFirstName = checkFirstName.FirstName;

            //Act

            //Assert
            Assert.Equal(expectedFirstName, actualFirstName);

            //Cleanup
            PersonSequencer.Reset();
        }
        */
    }
}
