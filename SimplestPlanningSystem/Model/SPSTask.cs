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
    public enum SPSSearchBy 
    {
        Status, Priority, Tag, Info, Date
    }
    public enum SPSChange
    {
        Status, Priority, Tag, Info, DateStart, DateEnd
    }

    [Serializable]
    public class SPSTask
    {
        [NonSerialized]
        readonly Guid _id = new Guid();
        public Guid Id{ get { return _id; } }

        private Status _status = Status.Expired;
        public Status StatusTask { get { return _status; } }
        public Priority PriorityTask { get; set; } = Priority.Normal;
        public Tag TagTask { get; set; } = Tag.Personal;
        public string InfoAboutTask { get; set; } = "nothing";
        public DateTime DateTimeStartTask { get; set; } = DateTime.UtcNow;
        public DateTime DateTimeEndTask { get; set; } = DateTime.UtcNow;

        public SPSTask() { }
        public SPSTask(
            Status status,
            Priority PriorityTask,
            Tag TagTask,
            string InfoAboutTask,
            DateTime DateTimeStartTask,
            DateTime DateTimeEndTask
            )
        {
            if (DateTimeStartTask < DateTimeEndTask)
                throw new Exception($"DateTimeEndTask more then DateTimeStartTask");
            _status = status;
            this.PriorityTask = PriorityTask;
            this.TagTask = TagTask;
            this.InfoAboutTask = InfoAboutTask ?? throw new ArgumentNullException(paramName: nameof(InfoAboutTask));
            this.DateTimeStartTask = DateTimeStartTask;
            this.DateTimeEndTask = DateTimeEndTask;
        }

        
    }
}
