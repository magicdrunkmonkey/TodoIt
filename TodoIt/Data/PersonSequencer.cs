using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
    public class PersonSequencer
    {
        private static int personId;

        //Add a static method called nextPersonId that increment and return the next 
        //personId value.
        public static int NextPersonId(int personId)
        {
            return ++personId;
        }

        //Add a static method called reset() that sets the personId variable to 0.
        public static int Reset(int personId)
        {
            return personId = 0;
        }
    }
}
