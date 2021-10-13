using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Model;

namespace TodoIt.Data
{
    public class TodoItems
    {
        //TodoItems should have the same functionality as the People class.

        //Have a private static Person array declared and instantiated as empty 
        //and not null (new Person[0])
        private static Todo[] todoArray = new Todo[0];

        //Add a method public int Size() that return the length of the array.
        public int Size()
        {
            return todoArray.Length;
        }

        //Add a method public Person[] FindAll() that return the Person array.
        public Todo[] FindAll()
        {            
            return todoArray;
        }

        //Add a method public Person FindById(int personId) that return the person
        //that has a matching personId as the passed in parameter.
        public Todo FindById(int personId)
        {
            //return personArray[personId]; //Felaktigt, söker index inte id
            for(int i=0; i < todoArray.Length; i++)
            {
                if (todoArray[i].TodoId == personId)
                {
                    return todoArray[i];
                }
            }
            return null;
        }

        //Add a method that creates a new Person, adds the newly created object in 
        //the array and then return the created object. You have to “expand” the
        //Person array. (tip: send in parameters needed to create the Person object and
        //use the PersonSequencer to give a unique personId)
        public Todo NewTodo(string description)
        {
            int todoId = TodoSequencer.NextTodoId();
            Array.Resize(ref todoArray, todoArray.Length + 1);                          //Add one to index for a new todo
            todoArray[todoArray.Length-1] = new Todo(todoId, description);              //Create and add the new todo to the index
            return todoArray[todoArray.Length-1];                                   //Return the new created todo
        }

        //Add a method public void Clear() that clears all Person objects from the 
        //Person array.
        public void Clear()
        {            
            todoArray = new Todo[0];
        }
    }
}
