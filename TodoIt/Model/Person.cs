using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Model
{
    class Person
    {
        
        //Fields
        private readonly int personId;        
        private string firstName;
        private string lastName;

        //Getters and setters
        readonly int id;
        readonly string fName;
        readonly string lName;
        public int Id 
        { 
            get { return id; }
            set { }
        }        
        public string FirstName 
        { 
            get { return fName; }
            set {
                if (value.Equals("") || value.Equals(null))
                {
                    throw new ArgumentException("Not a valid name.");
                }
                firstName = value;
            } 
        }                
        public string LastName 
        {
            get { return lName; }
            set {
                if (value.Equals("") || value.Equals(null))
                {
                    throw new ArgumentException("Not a valid name.");
                }
                lastName = value;
            }
        }

        //Constructors
        public Person()
        {
            this.personId = Id;
            this.firstName = FirstName;
            this.lastName = LastName;
        }
    }
}
