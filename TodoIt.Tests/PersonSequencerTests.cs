using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TodoIt.Data;

namespace TodoIt.Tests
{
    public class PersonSequencerTests
    {
        [Fact]
        public void IncrementPersonId()
        {
            //Arrange
            int personId = 0;
            int expectedPersonId = 1;

            //Act
            int actualPersonId = PersonSequencer.NextPersonId(personId);

            //Assert
            Assert.Equal(expectedPersonId, actualPersonId);
        }

        [Fact]
        public void ResetPersonId()
        {
            //Arrange
            int personId = 135;
            int expectedPersonId = 0;

            //Act
            int actualPersonId = PersonSequencer.Reset(personId);

            //Assert
            Assert.Equal(expectedPersonId, actualPersonId);
        }
    }
}
