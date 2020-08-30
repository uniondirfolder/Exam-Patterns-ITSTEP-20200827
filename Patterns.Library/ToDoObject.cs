using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Library
{
    public abstract class ToDoObject
    {
        readonly Guid _id;
        protected ToDoObject()
        {
            _id = Guid.NewGuid();
        }
        public Guid Id 
        {
            get { return this.Id; }
        }
    }
}
