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
            //PersonSequencer testId = new PersonSequencer();       //Does not work for some reason?
            int expectedPersonId = 5;                               //Initialize expected value
            int actualPersonId = 0;                                 //Initialize start value
                        

            //Act
            for(int i=0; i < expectedPersonId; i++)                 //Increment amount equal to expected value
            {
                actualPersonId = PersonSequencer.NextPersonId();    //Increment the id by one
                //actualPersonId = testId.NextPersonId();           //Does not work for some reason?
            }

            //Assert
            Assert.Equal(expectedPersonId, actualPersonId);
        }

        [Fact]
        public void ResetPersonId()
        {
            //Arrange, initialize values
            int expectedPersonId = 0;                       
            int actualPersonId = 135;

            //Act            
            actualPersonId = PersonSequencer.Reset();       //Reset value to zero.

            //Assert
            Assert.Equal(expectedPersonId, actualPersonId);
        }
    }
}
