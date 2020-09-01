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
        Status, Priority, Tag, Info, DateStart, DateEnd, Task
    }

    [Serializable]
    public class SPSTask: IDisposable
    {
        [NonSerialized]
        private bool disposed;
        public Guid Id { get; set; } = new Guid();
        private Status _status = Status.Expired;
        public Status StatusTask { get { return _status; } }
        public Priority PriorityTask { get; set; } = Priority.Normal;
        public Tag TagTask { get; set; } = Tag.Personal;
        public string InfoAboutTask { get; set; } = "nothing";
        public DateTime DateTimeStartTask { get; set; } = DateTime.UtcNow;
        public DateTime DateTimeEndTask { get; set; } = DateTime.UtcNow;

        public SPSTask() { }
        public SPSTask(
            Guid Id,
            Status status,
            Priority PriorityTask,
            Tag TagTask,
            string InfoAboutTask,
            DateTime DateTimeStartTask,
            DateTime DateTimeEndTask
            )
        {
            if (DateTimeStartTask > DateTimeEndTask)
                throw new Exception($"DateTimeStartTask more then DateTimeEndTask");
            _status = status;
            this.PriorityTask = PriorityTask;
            this.TagTask = TagTask;
            this.InfoAboutTask = InfoAboutTask ?? throw new ArgumentNullException(paramName: nameof(InfoAboutTask));
            this.DateTimeStartTask = DateTimeStartTask;
            this.DateTimeEndTask = DateTimeEndTask;
            this.Id = Id;
        }

        public override string ToString()
        {
            return ($"{InfoAboutTask} | {StatusTask} | " +
                    $"{TagTask} | {PriorityTask} | {DateTimeStartTask} | {DateTimeEndTask}");
        }
        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    
                }
                disposed = true;
            }
        }
        ~SPSTask() 
        {
            Dispose(false);
        }
    }
}
