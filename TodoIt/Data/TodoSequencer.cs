using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
    class TodoSequencer
    {
        //Create a new class TodoSequencer in Data folder that have the same behaviour as 
        //PersonSequencer but different method names.

        private static int todoId;

        public static int NextPersonId()
        {
            return ++todoId;
        }
    }
}
