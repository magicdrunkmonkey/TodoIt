using System;
using System.Collections.Generic;
using System.Text;

namespace TodoIt.Data
{
    public class TodoSequencer
    {
        //Create a new class TodoSequencer in Data folder that have the same behaviour as 
        //PersonSequencer but different method names.

        private static int todoId;

        public static int NextTodoId()
        {
            return ++todoId;
        }

        public static int Reset()
        {
            return todoId = 0;
        }
    }
}
