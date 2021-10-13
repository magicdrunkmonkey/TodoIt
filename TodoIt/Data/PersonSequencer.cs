using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
    public class PersonSequencer
    {
        //In PersonSequencer creates a private static int variable called personId.
        private static int personId;

        //Add a static method called nextPersonId that increment and return the next 
        //personId value.
        public static int NextPersonId()
        {
           return ++personId;
        }

        //Add a static method called reset() that sets the personId variable to 0.
        public static int Reset()
        {
            return personId = 0;
        }
    }
}
