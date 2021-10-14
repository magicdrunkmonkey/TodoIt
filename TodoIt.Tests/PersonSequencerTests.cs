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
            //Prepare
            PersonSequencer.Reset();

            //Arrange            
            int expectedPersonId = 5;                               //Initialize expected value
            int actualPersonId = 1000;                              //Initialize start value 

            //Act
            for(int i=0; i < expectedPersonId; i++)                 //Increment amount equal to expected value
            {
                actualPersonId = PersonSequencer.NextPersonId();    //Increment the id by one from zero                
            }

            //Assert
            Assert.Equal(expectedPersonId, actualPersonId);

            //Cleanup
            PersonSequencer.Reset();                                //Reset static personID counter to avoid interacting
                                                                    //with other methods or functions.
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
