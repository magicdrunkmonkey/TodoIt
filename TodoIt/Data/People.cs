using System;
using System.Collections.Generic;
using System.Text;
using TodoIt.Model;

namespace TodoIt.Data
{
    public class People
    {
        //Have a private static Person array declared and instantiated as empty 
        //and not null (new Person[0])
        private static Person[] personArray = new Person[0];

        //Add a method public int Size() that return the length of the array.
        public int Size()
        {
            return personArray.Length;
        }

        //Add a method public Person[] FindAll() that return the Person array.
        public Person[] FindAll()
        {            
            return personArray;
        }

        //Add a method public Person FindById(int personId) that return the person
        //that has a matching personId as the passed in parameter.
        public Person FindById(int personId)
        {
            //return personArray[personId]; //Felaktigt, söker index inte id
            for(int i=0; i < personArray.Length; i++)
            {
                if (personArray[i].PersonId == personId)
                {
                    return personArray[i];
                }
            }
            return null;
        }

        //Add a method that creates a new Person, adds the newly created object in 
        //the array and then return the created object. You have to “expand” the
        //Person array. (tip: send in parameters needed to create the Person object and
        //use the PersonSequencer to give a unique personId)
        public Person NewPerson(string firstName, string lastName)
        {
            int personId = PersonSequencer.NextPersonId();
            Array.Resize(ref personArray, personArray.Length + 1);                          //Add one to index for a new person
            personArray[personArray.Length-1] = new Person(personId, firstName, lastName);  //Create and add the new person to the index
            return personArray[personArray.Length-1];                                       //Return the new created person
        }

        //Add a method public void Clear() that clears all Person objects from the 
        //Person array.
        public void Clear()
        {            
            personArray = new Person[0];
        }

        //11. Add the following to TodoItems AND People class.
        //a.Functionality to remove object from array. (not nulling)
        //First: you need to find the correct array index of the object.
        //Second: You need to rebuild array by excluding the object on found index.

        public Person[] RemovePerson(int personId)
        {  
            //Attempt 3
            int j = 0;
            Person[] tempArray = new Person[personArray.Length - 1];
            for (int i = 0; i < personArray.Length; i++)
            {
                if (personArray[i].PersonId != personId)
                {
                    tempArray[j] = personArray[i];
                    j++;
                }
            }

            personArray = tempArray;

            return personArray;
        }
    }
}
