using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Library
{
    public enum Tag
    {
        Important, Home, Work, Personal, Nothing
    }
    public enum Priority
    {
        Low, Normal, Hight, Middle, Nothing
    }
    public enum Status
    {
        Pending, Current, Overdue, Due, Nothing
    }
    public abstract class ToDoQuery<T>: ToDoObject
    {
        protected Guid guid;
        protected T WhatToQuery;
        protected int state;
    }
    sealed public class QueryTag : ToDoQuery<Tag> 
    {
        public QueryTag(Guid guid, int state )
        {
            this.guid = guid;
            this.state = state;
        }
    }
    sealed public class QueryPriority : ToDoQuery<Priority>
    {
        public QueryPriority(Guid guid, int state)
        {
            this.guid = guid;
            this.state = state;
        }
    }
    sealed public class QueryStatus : ToDoQuery<Status>
    {
        public QueryStatus(Guid guid, int state)
        {
            this.guid = guid;
            this.state = state;
        }
    }
}
