using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplestPlanningSystem.Model
{

    abstract class SPSStrategySearch
    {
        public abstract List<SPSTask> Search(List<SPSTask> tasks, SPSSearchBy search, SPSTask temp);
    }
    class SPSSearchByDateStart: SPSStrategySearch
    {
        public override List<SPSTask> Search(List<SPSTask> tasks, SPSSearchBy search, SPSTask temp)
        {
            var box = temp ?? throw new ArgumentNullException(paramName: nameof(temp));
            var list = tasks ?? throw new ArgumentNullException(paramName: nameof(tasks));

            List<SPSTask> output = null;

            if (search == SPSSearchBy.Date)
            {
                output = new List<SPSTask>();
                foreach (var item in list)
                {
                    if (item.DateTimeStartTask == box.DateTimeStartTask)
                        output.Add(item);
                }
            }
            
            return output;
        }
    }
    class SPSSearchByTag: SPSStrategySearch
    {
        public override List<SPSTask> Search(List<SPSTask> tasks, SPSSearchBy search, SPSTask temp)
        {
            var box = temp ?? throw new ArgumentNullException(paramName: nameof(temp));
            var list = tasks ?? throw new ArgumentNullException(paramName: nameof(tasks));

            List<SPSTask> output = null;

            if (search == SPSSearchBy.Tag)
            {
                output = new List<SPSTask>();
                foreach (var item in list)
                {
                    if (item.DateTimeStartTask == box.DateTimeStartTask)
                        output.Add(item);
                }
            }

            return output;
        }
    }
    class SPSSearchByPriority : SPSStrategySearch
    {
        public override List<SPSTask> Search(List<SPSTask> tasks, SPSSearchBy search, SPSTask temp)
        {
            var box = temp ?? throw new ArgumentNullException(paramName: nameof(temp));
            var list = tasks ?? throw new ArgumentNullException(paramName: nameof(tasks));

            List<SPSTask> output = null;

            if (search == SPSSearchBy.Priority)
            {
                output = new List<SPSTask>();
                foreach (var item in list)
                {
                    if (item.DateTimeStartTask == box.DateTimeStartTask)
                        output.Add(item);
                }
            }

            return output;
        }
    }
    class SPSSearchByStatus : SPSStrategySearch
    {
        public override List<SPSTask> Search(List<SPSTask> tasks, SPSSearchBy search, SPSTask temp)
        {
            var box = temp ?? throw new ArgumentNullException(paramName: nameof(temp));
            var list = tasks ?? throw new ArgumentNullException(paramName: nameof(tasks));

            List<SPSTask> output = null;

            if (search == SPSSearchBy.Status)
            {
                output = new List<SPSTask>();
                foreach (var item in list)
                {
                    if (item.DateTimeStartTask == box.DateTimeStartTask)
                        output.Add(item);
                }
            }

            return output;
        }
    }
    class SPSSearchByInfo : SPSStrategySearch
    {
        public override List<SPSTask> Search(List<SPSTask> tasks, SPSSearchBy search, SPSTask temp)
        {
            var box = temp ?? throw new ArgumentNullException(paramName: nameof(temp));
            var list = tasks ?? throw new ArgumentNullException(paramName: nameof(tasks));

            List<SPSTask> output = null;

            if (search == SPSSearchBy.Info)
            {
                output = new List<SPSTask>();
                foreach (var item in list)
                {
                    if (item.DateTimeStartTask == box.DateTimeStartTask)
                        output.Add(item);
                }
            }

            return output;
        }
    }

    public abstract class SPSStrategyChange
    {
        public abstract void Change(List<SPSTask> tasks, SPSChange todo, SPSTask temp, Guid id);
    }

    class SPSChangePriority : SPSStrategyChange
    {
        public override void Change(List<SPSTask> tasks, SPSChange todo, SPSTask temp, Guid id)
        {
            var box = temp ?? throw new ArgumentNullException(paramName: nameof(temp));
            var list = tasks ?? throw new ArgumentNullException(paramName: nameof(tasks));
            if (todo == SPSChange.Priority)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Id == id)
                        list[i].PriorityTask = box.PriorityTask;
                }
            }
        }
    }
    class SPSChangeDueDate : SPSStrategyChange
    {
        public override void Change(List<SPSTask> tasks, SPSChange todo, SPSTask temp, Guid id)
        {
            var box = temp ?? throw new ArgumentNullException(paramName: nameof(temp));
            var list = tasks ?? throw new ArgumentNullException(paramName: nameof(tasks));
            if (todo == SPSChange.DateEnd)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Id == id)
                        list[i].DateTimeEndTask = box.DateTimeEndTask;
                }
            }
        }
    }
    class SPSChangeTag : SPSStrategyChange
    {
        public override void Change(List<SPSTask> tasks, SPSChange todo, SPSTask temp, Guid id)
        {
            var box = temp ?? throw new ArgumentNullException(paramName: nameof(temp));
            var list = tasks ?? throw new ArgumentNullException(paramName: nameof(tasks));
            if (todo == SPSChange.Tag)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Id == id)
                        list[i].TagTask = box.TagTask;
                }
            }
        }
    }

}
