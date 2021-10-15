using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Data;
using System.Linq;

namespace TodoIt.Model
{
    public class Person
    {
        //Fields, declare, initialize
        private readonly int personId;        
        private string firstName;
        private string lastName;

        //Constructors
        public Person(int personId, string firstName, string lastName)
        {
            this.personId = personId;
            FirstName = firstName;
            LastName = lastName;
        }

        //Getters and Setters
        public int PersonId 
        { 
            get { return personId; }
            set {  }
        }        
        public string FirstName 
        { 
            get { return firstName; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Not a valid name.");
                }
                lastName = value;
            }
        }

        
    }
}
