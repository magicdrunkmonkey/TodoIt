﻿using System;
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
            TodoID = todoId;
            Description = description;
        }

        //Getters and Setters
        public int TodoID
        {
            get{return todoId;}
            set{}
        }
        public string Description
        {
            get { return description; }
            set { }
        }
        public bool Done
        {
            get { return done; }
            set { }
        }
        public Person Assignee
        {
            get { return assignee; }
            set { }
        }
    }
}
