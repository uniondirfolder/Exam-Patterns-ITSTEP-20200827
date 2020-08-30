using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Library
{
    public class ToDoMediator
    {
        public event EventHandler<ToDoQuery> Queries;
        public void PerformQuery(object sender, ToDoQuery query)
        {
            Queries?.Invoke(sender, query);
        }
    }
}
