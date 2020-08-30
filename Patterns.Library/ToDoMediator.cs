using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Library
{
    public class ToDoMediator<T>
    {
        public event EventHandler<ToDoQuery<T>> Queries;
        public void PerformQuery(object sender, ToDoQuery<T> query) 
        {
            Queries?.Invoke(sender, query);
        }
    }
}
