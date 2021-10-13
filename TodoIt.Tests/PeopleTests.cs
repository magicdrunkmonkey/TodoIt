using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TodoIt.Data;
using TodoIt.Model;

namespace TodoIt.Tests
{
    public class PeopleTests
    {
        [Fact]
        public void TestSize()
        {
            //Arrange
            int expectedSize = 0;
            int actualSize = 10;

            //Act
            People people = new People();
            actualSize = people.Size();

            //Assert
            Assert.Equal(expectedSize, actualSize);
        }

        [Fact]
        public void TestFindAll()
        {
            PersonSequencer.Reset();
            
            //Arrange
            People peopleFindAll = new People();
            peopleFindAll.Clear();
            Person person1 = peopleFindAll.NewPerson("She", "Ra");
            Person person2 = peopleFindAll.NewPerson("He", "Man");
            
            //Act            

            //Assert
            Assert.Equal(2, peopleFindAll.FindAll().Length);

            //Cleanup
            PersonSequencer.Reset();
            
        }

        [Fact]
        public void TestClear()
        {
            //Arrange
            People peopleTestClear = new People();

            //Act
            Person array1 = peopleTestClear.NewPerson("Lucky", "Luke");
            Person array2 = peopleTestClear.NewPerson("Alfons", "Åberg");
                        
            peopleTestClear.Clear();
            
            Assert.Equal(0, peopleTestClear.Size());

            //Cleanup
            PersonSequencer.Reset();            
        }

        [Fact]        
        public void TestNewPerson()
        {
            //Arrange
            People people = new People();

            //Act
            Person array1 = people.NewPerson("Kalle", "Anka");
            Person array2 = people.NewPerson("Musse", "Pigg");
            Person array3 = people.NewPerson("Jan", "Långben");            
            
            //Assert
            Assert.Equal(1, array1.PersonId);
            Assert.Equal("Kalle", array1.FirstName);
            Assert.Equal("Anka", array1.LastName);

            Assert.Equal(2, array2.PersonId);
            Assert.Equal("Musse", array2.FirstName);
            Assert.Equal("Pigg", array2.LastName);

            Assert.Equal(3, array3.PersonId);
            Assert.Equal("Jan", array3.FirstName);
            Assert.Equal("Långben", array3.LastName);
                        
            //Cleanup
            PersonSequencer.Reset();
        }

        [Fact]
        public void TestFindById()
        {
            //Prepare
            PersonSequencer.Reset();

            //Arrange
            People peopleFindById = new People();
            peopleFindById.Clear();

            //Act            
            Person person1 = peopleFindById.NewPerson("Kalle", "Anka");
            Person person2 = peopleFindById.NewPerson("Musse", "Pigg");
            Person person3 = peopleFindById.NewPerson("Jan", "Långben");

            //Assert
            Assert.Equal("Musse", peopleFindById.FindById(2).FirstName);
            Assert.Equal("Långben", peopleFindById.FindById(3).LastName);
            Assert.Equal(1, peopleFindById.FindById(1).PersonId);

            //Cleanup
            PersonSequencer.Reset();
        }
    }
}
