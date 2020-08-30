using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Library
{
    sealed public class ToDoTask: ToDoObject
    {
        private List<ToDoTask> _toDoTasks;
        private int _tag, _status, _priority; 
        //private Tag _tag;
        //private Status _status;
        //private Priority _priority;
        public DateTime StartDate { get; private set; }
        public DateTime DueDate { get; private set; }
        public string Name { get; set; }
        public ToDoTask(List<ToDoTask> toDoTasks, string name,
            int tag, int status, int priority,
            DateTime start, DateTime due)
        {
            this._toDoTasks = toDoTasks ?? throw new ArgumentNullException(paramName: nameof(toDoTasks));
            this.Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            _tag = tag;
            _status = status;
            _priority = priority;
        }

        public int Tag 
        {
            get 
            {
                var q = new 
            }
        }
    }
}
