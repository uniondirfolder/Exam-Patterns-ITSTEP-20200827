using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Library
{
    sealed public class ToDoTask: ToDoObject
    {
        private  ToDoMediator _mediator;
        private int _tag, _status, _priority; 
        public DateTime StartDate { get; private set; }
        public DateTime DueDate { get; private set; }
        public string TaskInfo { get; set; }
        public ToDoTask(ToDoMediator mediator , string info,
            int tag, int status, int priority,
            DateTime start, DateTime due)
        {
            this._mediator = mediator ?? throw new ArgumentNullException(paramName: nameof(mediator));
            TaskInfo = info ?? throw new ArgumentNullException(paramName: nameof(info));
            _tag = tag;
            _status = status;
            _priority = priority;
        }

        public int Tag 
        {
            get 
            {
                var q = new ToDoQuery(Id, ToDoQuery.Tag., _tag);
                _mediator.PerformQuery(this, q);
                return q.Value;
            }
        }
    }
}
