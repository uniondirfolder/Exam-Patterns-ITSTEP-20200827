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
        public abstract void Search(SPSBox box);
    }
    class SPSSearchByDateStart: SPSStrategySearch
    {
        public override void Search(SPSBox box)
        {
            var msg = box ?? throw new ArgumentNullException(paramName: nameof(box));
            var list = box.ListStrings ?? throw new ArgumentNullException(paramName: nameof(box.ListStrings));
            var db = box.Tasks ?? throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (msg.Search == SPSSearchBy.Date) {
                foreach (var item in db)
                {
                    if (item.DateTimeStartTask == box.DateTime)
                    { list.Add(item.ToString()); }
                }
            }

            if (list.Count == 0) { list.Add("No search result..."); }
        }
    }
    class SPSSearchByTag: SPSStrategySearch
    {
        public override void Search(SPSBox box)
        {
            var msg = box ?? throw new ArgumentNullException(paramName: nameof(box));
            var list = box.ListStrings ?? throw new ArgumentNullException(paramName: nameof(box.ListStrings));
            var db = box.Tasks ?? throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (msg.Search == SPSSearchBy.Tag)
            {
                foreach (var item in db)
                {
                    if (item.TagTask == msg.SPSTask.TagTask)
                    { list.Add(item.ToString()); }
                }
            }

            if (list.Count == 0) { list.Add("No search result..."); }
        }
    }
    class SPSSearchByPriority : SPSStrategySearch
    {
        public override void Search(SPSBox box)
        {
            var msg = box ?? throw new ArgumentNullException(paramName: nameof(box));
            var list = box.ListStrings ?? throw new ArgumentNullException(paramName: nameof(box.ListStrings));
            var db = box.Tasks ?? throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (msg.Search == SPSSearchBy.Priority)
            {
                foreach (var item in db)
                {
                    if (item.PriorityTask == msg.SPSTask.PriorityTask)
                    { list.Add(item.ToString()); }
                }
            }

            if (list.Count == 0) { list.Add("No search result..."); }
        }
    }
    class SPSSearchByStatus : SPSStrategySearch
    {
        public override void Search(SPSBox box)
        {
            var msg = box ?? throw new ArgumentNullException(paramName: nameof(box));
            var list = box.ListStrings ?? throw new ArgumentNullException(paramName: nameof(box.ListStrings));
            var db = box.Tasks ?? throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (msg.Search == SPSSearchBy.Status)
            {
                foreach (var item in db)
                {
                    if (item.StatusTask == msg.SPSTask.StatusTask)
                    { list.Add(item.ToString()); }
                }
            }

            if (list.Count == 0) { list.Add("No search result..."); }
        }
    }
    class SPSSearchByInfo : SPSStrategySearch
    {
        public override void Search(SPSBox box)
        {
            var msg = box ?? throw new ArgumentNullException(paramName: nameof(box));
            var list = box.ListStrings ?? throw new ArgumentNullException(paramName: nameof(box.ListStrings));
            var db = box.Tasks ?? throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (msg.Search == SPSSearchBy.Info)
            {
                foreach (var item in db)
                {
                    if (string.Compare(item.InfoAboutTask,msg.SPSTask.InfoAboutTask) == 0 
                        || item.InfoAboutTask.Contains(msg.SPSTask.InfoAboutTask))
                    { list.Add(item.ToString()); }
                }
            }

            if (list.Count == 0) { list.Add("No search result..."); }
        }
    }

    public abstract class SPSStrategyChange
    {
        public abstract void Change(SPSBox box);
    }

    class SPSChangePriority : SPSStrategyChange
    {
        public override void Change(SPSBox box)
        {
            var msg = box ?? throw new ArgumentNullException(paramName: nameof(box));
            var db = box.Tasks ?? throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (msg.Change == SPSChange.Priority)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    if (db[i].Id == box.SPSTask.Id)
                    { db[i].PriorityTask = box.SPSTask.PriorityTask; break; }
                }
            }
        }
    }
    class SPSChangeDueDate : SPSStrategyChange
    {
        public override void Change(SPSBox box)
        {
            var msg = box ?? throw new ArgumentNullException(paramName: nameof(box));
            var db = box.Tasks ?? throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (msg.Change == SPSChange.DateEnd)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    if (db[i].Id == box.SPSTask.Id)
                    { db[i].DateTimeEndTask = box.SPSTask.DateTimeEndTask; break; }
                }
            }
        }
    }
    class SPSChangeTag : SPSStrategyChange
    {
        public override void Change(SPSBox box)
        {
            var msg = box ?? throw new ArgumentNullException(paramName: nameof(box));
            var db = box.Tasks ?? throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (msg.Change == SPSChange.Tag)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    if (db[i].Id == box.SPSTask.Id)
                    { db[i].TagTask = box.SPSTask.TagTask; break; }
                }
            }
        }
    }

}
