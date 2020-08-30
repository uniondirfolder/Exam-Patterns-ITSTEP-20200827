using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplestPlanningSystem.Model
{
    
    public enum Tag
    {
        Important, Home, Work, Personal
    }
    public enum Status
    {
        Future, Current, Expired, Due
    }

    public enum Priority 
    {
        Low, Normal, High, Middle
    }

    [Serializable]
    public class SPSTask
    {
        readonly Guid _id = new Guid();
        public Guid Id{ get { return _id; } }

        private Status _status = Status.Expired;
        public Status StatusTask { get { return _status; } }
        public Priority PriorityTask { get; set; } = Priority.Normal;
        public Tag TagTask { get; set; } = Tag.Personal;
        public string InfoAboutTask { get; set; } = "nothing";
        public DateTime DateTimeStartTask { get; set; } = DateTime.UtcNow;
        public DateTime DateTimeEndTask { get; set; } = DateTime.UtcNow;

        public SPSTask()
        {

        }

        
    }
}
