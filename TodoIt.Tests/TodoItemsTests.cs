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
            //Prepare
            TodoSequencer.Reset();
            PersonSequencer.Reset();

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
            PersonSequencer.Reset();
            todoNewItem.Clear();
        }

        [Fact]
        public void TestFindById()
        {
            //Prepare
            TodoSequencer.Reset();
            PersonSequencer.Reset();

            //Arrange
            TodoItems todoFindById = new TodoItems();
            todoFindById.Clear();
            string expectedDescription1 = "Kalle Anka var glad i duschen.";
            string expectedDescription2 = "Musse Pigg spelade boll med Jan Långben.";
            string expectedDescription3 = "Jan Långben fångade boll med Musse Pigg.";

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

        [Fact]
        public void TestFindByDoneStatus()
        {
            //Prepare
            TodoSequencer.Reset();
            PersonSequencer.Reset();

            //Arrange
            TodoItems todoFindByDoneStatus = new TodoItems();
            todoFindByDoneStatus.Clear();
            string expectedDescription1 = "Kalle Anka var glad i duschen.";
            string expectedDescription2 = "Musse Pigg spelade boll med Jan Långben.";
            string expectedDescription3 = "Jan Långben fångade boll med Musse Pigg.";

            Todo item1 = todoFindByDoneStatus.NewTodo(expectedDescription1);
            Todo item2 = todoFindByDoneStatus.NewTodo(expectedDescription2);
            Todo item3 = todoFindByDoneStatus.NewTodo(expectedDescription3);

            item1.Done = true;
            item2.Done = false;
            item3.Done = true;

            //Act            
            Todo[] foundDone = new Todo[3];
            foundDone = todoFindByDoneStatus.FindByDoneStatus(true);

            //Assert
            Assert.Equal(2, foundDone.Length);

            //Cleanup
            TodoSequencer.Reset();
            todoFindByDoneStatus.Clear();
        }

        [Fact]
        public void TestFindByAssigneeWithPerson()
        {
            //Prepare
            TodoSequencer.Reset();
            PersonSequencer.Reset();

            //Arrange
            TodoItems todoFindByAssignee = new TodoItems();
            todoFindByAssignee.Clear();
            string expectedDescription1 = "Kalle Anka var glad i duschen.";
            string expectedDescription2 = "Musse Pigg spelade boll med Jan Långben.";
            string expectedDescription3 = "Jan Långben fångade boll med Musse Pigg.";

            Todo item1 = todoFindByAssignee.NewTodo(expectedDescription1);
            Todo item2 = todoFindByAssignee.NewTodo(expectedDescription2);
            Todo item3 = todoFindByAssignee.NewTodo(expectedDescription3);

            People peopleFindByAssignee = new People();
            peopleFindByAssignee.Clear();
            Person person1 = peopleFindByAssignee.NewPerson("Lucky", "Luke");
            Person person2 = peopleFindByAssignee.NewPerson("Alfons", "Åberg");

            item1.Assignee = person1;
            item2.Assignee = person2;
            item3.Assignee = person1;

            //Act            
            Todo[] foundAssignees = new Todo[3];
            foundAssignees = todoFindByAssignee.FindByAssignee(person1);    //Find all assignees with name Luky Luke

            //Assert
            Assert.Equal(2, foundAssignees.Length);

            //Cleanup
            TodoSequencer.Reset();
            PersonSequencer.Reset();
            todoFindByAssignee.Clear();
            peopleFindByAssignee.Clear();
        }

        [Fact]
        public void TestFindByAssigneeWithPersonId()
        {
            //Prepare
            TodoSequencer.Reset();
            PersonSequencer.Reset();

            //Arrange
            TodoItems todoFindByAssigneePersonId = new TodoItems();
            todoFindByAssigneePersonId.Clear();
            string expectedDescription1 = "Kalle Anka var glad i duschen.";
            string expectedDescription2 = "Musse Pigg spelade boll med Jan Långben.";
            string expectedDescription3 = "Jan Långben fångade boll med Musse Pigg.";

            Todo item1 = todoFindByAssigneePersonId.NewTodo(expectedDescription1);
            Todo item2 = todoFindByAssigneePersonId.NewTodo(expectedDescription2);
            Todo item3 = todoFindByAssigneePersonId.NewTodo(expectedDescription3);

            People peopleFindByAssigneePersonId = new People();
            peopleFindByAssigneePersonId.Clear();
            Person person1 = peopleFindByAssigneePersonId.NewPerson("Lucky", "Luke");
            Person person2 = peopleFindByAssigneePersonId.NewPerson("Alfons", "Åberg");

            item1.Assignee = person1;
            item2.Assignee = person2;
            item3.Assignee = person1;

            //Act            
            Todo[] foundAssignees = new Todo[3];
            foundAssignees = todoFindByAssigneePersonId.FindByAssignee(1);  //Search for all assignees with personId 1

            //Assert
            Assert.Equal(2, foundAssignees.Length);

            //Cleanup
            TodoSequencer.Reset();
            PersonSequencer.Reset();
            todoFindByAssigneePersonId.Clear();
            peopleFindByAssigneePersonId.Clear();
        }

        [Fact]
        public void TestFindByAssigneeWithNoAssignee()
        {
            //Prepare
            TodoSequencer.Reset();
            PersonSequencer.Reset();

            //Arrange
            TodoItems todoFindByAssigneeUnassigned = new TodoItems();
            todoFindByAssigneeUnassigned.Clear();
            string expectedDescription1 = "Kalle Anka var glad i duschen.";
            string expectedDescription2 = "Musse Pigg spelade boll med Jan Långben.";
            string expectedDescription3 = "Jan Långben fångade boll med Musse Pigg.";

            Todo item1 = todoFindByAssigneeUnassigned.NewTodo(expectedDescription1);
            Todo item2 = todoFindByAssigneeUnassigned.NewTodo(expectedDescription2);
            Todo item3 = todoFindByAssigneeUnassigned.NewTodo(expectedDescription3);

            People peopleFindByAssigneeUnassigned = new People();
            peopleFindByAssigneeUnassigned.Clear();
            Person person1 = peopleFindByAssigneeUnassigned.NewPerson("Lucky", "Luke");
            Person person2 = peopleFindByAssigneeUnassigned.NewPerson("Alfons", "Åberg");

            item1.Assignee = person1;
            //item2.Assignee = person2;
            item3.Assignee = person2;

            //Act            
            Todo[] foundUnassigned = new Todo[3];
            foundUnassigned = todoFindByAssigneeUnassigned.FindUnassignedTodoItems();  //Search for all unassigned todo
            int collectionSize = foundUnassigned.Length;

            //Assert
            Assert.Equal(1, collectionSize);

            //Cleanup
            TodoSequencer.Reset();
            PersonSequencer.Reset();
            todoFindByAssigneeUnassigned.Clear();
            peopleFindByAssigneeUnassigned.Clear();
        }

        [Fact]
        public void TestRemoveTodoItem()
        {
            //Prepare
            TodoSequencer.Reset();
            PersonSequencer.Reset();

            //Arrange
            TodoItems removeTodoItem = new TodoItems();
            removeTodoItem.Clear();
            string expectedDescription1 = "Kalle Anka var glad i duschen.";
            string expectedDescription2 = "Musse Pigg spelade boll med Jan Långben.";
            string expectedDescription3 = "Jan Långben fångade boll med Musse Pigg.";

            //Act
            Todo item1 = removeTodoItem.NewTodo(expectedDescription1);
            Todo item2 = removeTodoItem.NewTodo(expectedDescription2);
            Todo item3 = removeTodoItem.NewTodo(expectedDescription3);

            removeTodoItem.RemoveTodoItem(2);            

            //Assert
            Assert.Equal(item1, removeTodoItem.FindById(1));        //Item1 remains
            Assert.Null(removeTodoItem.FindById(2));                //Means Todo object item2 is removed.
            Assert.Equal(item3, removeTodoItem.FindById(3));        //Item3 remains

            Assert.Equal(2, removeTodoItem.Size());                 //Verify only remaining 2 of 3 objects.

            //Cleanup
            TodoSequencer.Reset();
            PersonSequencer.Reset();
            removeTodoItem.Clear();
        }
    }
}
