using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Model
{
    public class Todo
    {
        //Fields, declare, initialize        
        private readonly int todoId;
        private string description;
        private bool done;
        private Person assignee;

        //Constructors
        public Todo(int todoId, string description)
        {
            this.todoId = todoId;
            Description = description;
            //Done = done; done=false;
            //Assignee = assignee;
        }

        //Getters and Setters
        public int TodoId
        {
            get{return todoId;}
            set{ }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }
        public Person Assignee
        {
            get { return assignee; }
            set { assignee = value; }
        }
    }
}
