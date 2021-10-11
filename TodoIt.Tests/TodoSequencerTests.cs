using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TodoIt.Data;

namespace TodoIt.Tests
{
    public class TodoSequencerTests
    {
        [Fact]
        public void IncrementTodoId()
        {
            //Arrange            
            int expectedTodoId = 5;                               //Initialize expected value
            int actualTodoId = 0;                                 //Initialize start value

            //Act
            for (int i = 0; i < expectedTodoId; i++)                //Increment amount equal to expected value
            {
                actualTodoId = TodoSequencer.NextTodoId();          //Increment the todoId by one                
            }

            //Assert
            Assert.Equal(expectedTodoId, actualTodoId);
        }

        [Fact]
        public void ResetTodoId()
        {
            //Arrange, initialize values
            int expectedTodoId = 0;
            int actualTodoId = 135;

            //Act            
            actualTodoId = TodoSequencer.Reset();           //Reset TodoId to zero.

            //Assert
            Assert.Equal(expectedTodoId, actualTodoId);
        }
    }
}
