using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using TodoIt.Model;
using TodoIt.Data;

namespace TodoIt.Tests
{
    public class TodoItemsTests
    {
        [Fact]
        public void TestSize()
        {
            //Prepare
            TodoSequencer.Reset();

            //Arrange
            int expectedSize = 0;
            int actualSize = 10;

            //Act
            TodoItems itemsSizeTest = new TodoItems();
            
            //itemsSizeTest.Clear();
            actualSize = itemsSizeTest.Size();

            //Assert
            Assert.Equal(expectedSize, actualSize);
        }

        [Fact]
        public void TestFindAll()
        {
            //Prepare
            TodoSequencer.Reset();

            //Arrange
            TodoItems todoFindAll = new TodoItems();            
            Todo todo1 = todoFindAll.NewTodo("She-Ra is walking in sunshine.");
            Todo todo2 = todoFindAll.NewTodo("He-Man is walking on the beach");

            //Act            

            //Assert
            Assert.Equal(2, todoFindAll.FindAll().Length);

            //Cleanup
            TodoSequencer.Reset();
            todoFindAll.Clear();

        }

        [Fact]
        public void TestClear()
        {
            //Arrange
            TodoItems todoTestClear = new TodoItems();
            TodoSequencer.Reset();
            //Act
            Todo todo1 = todoTestClear.NewTodo("Lucky Luke is playing poker with Jolly Jumper.");
            Todo todo2 = todoTestClear.NewTodo("Alfons Åberg build a windmill.");

            todoTestClear.Clear();

            Assert.Equal(0, todoTestClear.Size());

            //Cleanup
            TodoSequencer.Reset();
            todoTestClear.Clear();
        }

        [Fact]
        public void TestNewTodo()
        {
            //Arrange
            TodoItems todoNewItem = new TodoItems();
            TodoSequencer.Reset();
            string expectedDescription1 = "Kalle Anka var glad i duschen.";
            string expectedDescription2 = "Musse Pigg spelade boll med Jan Långben.";
            string expectedDescription3 = "Jan Långben fångade boll med Musse Pigg.";

            //Act
            Todo item1 = todoNewItem.NewTodo(expectedDescription1);
            Todo item2 = todoNewItem.NewTodo(expectedDescription2);
            Todo item3 = todoNewItem.NewTodo(expectedDescription3);            

            //Assert
            Assert.Equal(1, item1.TodoId);
            Assert.Equal(expectedDescription1, item1.Description);            

            Assert.Equal(2, item2.TodoId);
            Assert.Equal(expectedDescription2, item2.Description);

            Assert.Equal(3, item3.TodoId);
            Assert.Equal(expectedDescription3, item3.Description);

            //Cleanup
            TodoSequencer.Reset();
            todoNewItem.Clear();
        }

        [Fact]
        public void TestFindById()
        {
            //Prepare
            TodoSequencer.Reset();
            string expectedDescription1 = "Kalle Anka var glad i duschen.";
            string expectedDescription2 = "Musse Pigg spelade boll med Jan Långben.";
            string expectedDescription3 = "Jan Långben fångade boll med Musse Pigg.";

            //Arrange
            TodoItems todoFindById = new TodoItems();
            todoFindById.Clear();

            //Act            
            Todo item1 = todoFindById.NewTodo(expectedDescription1);
            Todo item2 = todoFindById.NewTodo(expectedDescription2);
            Todo item3 = todoFindById.NewTodo(expectedDescription3);

            //Assert
            Assert.Equal(expectedDescription1, todoFindById.FindById(1).Description);
            Assert.Equal(expectedDescription2, todoFindById.FindById(2).Description);
            Assert.Equal(expectedDescription3, todoFindById.FindById(3).Description);

            //Cleanup
            TodoSequencer.Reset();
            todoFindById.Clear();
        }
    }
}
