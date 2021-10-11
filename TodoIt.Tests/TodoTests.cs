using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TodoIt.Model;

namespace TodoIt.Tests
{
    public class TodoTests
    {
        [Fact]
        public void CunstructorTodo()
        {
            //Arrange
            int expectedNumber = 0;
            string expectedDescription = "This is a description";

            /*Missinterpretation of sub-task 4
            bool expecteDone = false;
            Person expectedAssignee = new Person(0, "Tolvar", "Tolvarsson");
            */

            //Act
            Todo test = new Todo(expectedNumber, expectedDescription);                                       
            int actualNumber = test.TodoId;
            string actualDescription = test.Description;

            /*Missinterpretation of sub-task 4 
            bool actualDone = test.Done;
            test.Assignee = expectedAssignee;
            Person actualAssignee = test.Assignee;
            */            

            //Assert
            Assert.Equal(expectedNumber, actualNumber);
            Assert.Equal(expectedDescription, actualDescription);

            /* Missinterpreation of sub-task 4
            Assert.Equal(expecteDone, actualDone);
            Assert.Equal(expectedAssignee, actualAssignee);
            */
        }
    }
}
