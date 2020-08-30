using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Library
{
   
    public class ToDoQuery
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

        public Guid guid;
        public Tag WhatToQuery;

        public int Value;

        public ToDoQuery(Guid guid, Tag tag, int value )
        {
            this.guid = guid;
            WhatToQuery = tag;
            Value = value;
        }
        
    }
}
