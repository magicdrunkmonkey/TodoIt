using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Model
{
    public class Person
    {        
        //Fields, declare, initialize
        private readonly int personId;        
        private string firstName;
        private string lastName;
        
        //Getters and Setters
        public int PersonId 
        { 
            get { return personId; }
            set { }
        }        
        public string FirstName 
        { 
            get { return firstName; }
            set 
            {
                if (value.Equals("") || value.Equals(null))
                {
                    throw new ArgumentException("Not a valid name.");
                }
                firstName = value;
            } 
        }                
        public string LastName 
        {
            get { return lastName; }
            set 
            {
                if (value.Equals("") || value.Equals(null))
                {
                    throw new ArgumentException("Not a valid name.");
                }
                lastName = value;
            }
        }

        //Constructors
        public Person(int personId, string firstName, string lastName)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
