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
            if(box==null) throw new ArgumentNullException(paramName: nameof(box));
            if( box.ListStrings ==null) throw new ArgumentNullException(paramName: nameof(box.ListStrings));
            if(box.Tasks==null) throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (box.Search == SPSSearchBy.Date) {
                foreach (var item in box.Tasks)
                {
                    if (item.DateTimeStartTask == box.DateTime)
                    { box.ListStrings.Add(item.ToString()); }
                }
            }

            if (box.ListStrings.Count == 0) { box.ListStrings.Add("No search result..."); }
        }
    }
    class SPSSearchByTag: SPSStrategySearch
    {
        public override void Search(SPSBox box)
        {
            if(box==null) throw new ArgumentNullException(paramName: nameof(box));
            if( box.ListStrings ==null) throw new ArgumentNullException(paramName: nameof(box.ListStrings));
            if(box.Tasks==null) throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (box.Search == SPSSearchBy.Tag)
            {
                foreach (var item in box.Tasks)
                {
                    if (item.TagTask == box.SPSTask.TagTask)
                    { box.ListStrings.Add(item.ToString()); }
                }
            }

            if (box.ListStrings.Count == 0) { box.ListStrings.Add("No search result..."); }
        }
    }
    class SPSSearchByPriority : SPSStrategySearch
    {
        public override void Search(SPSBox box)
        {
            if(box==null) throw new ArgumentNullException(paramName: nameof(box));
            if( box.ListStrings ==null) throw new ArgumentNullException(paramName: nameof(box.ListStrings));
            if(box.Tasks==null) throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (box.Search == SPSSearchBy.Priority)
            {
                foreach (var item in box.Tasks)
                {
                    if (item.PriorityTask == box.SPSTask.PriorityTask)
                    { box.ListStrings.Add(item.ToString()); }
                }
            }

            if (box.ListStrings.Count == 0) { box.ListStrings.Add("No search result..."); }
        }
    }
    class SPSSearchByStatus : SPSStrategySearch
    {
        public override void Search(SPSBox box)
        {
            if(box==null) throw new ArgumentNullException(paramName: nameof(box));
            if( box.ListStrings ==null) throw new ArgumentNullException(paramName: nameof(box.ListStrings));
            if(box.Tasks==null) throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (box.Search == SPSSearchBy.Status)
            {
                foreach (var item in box.Tasks)
                {
                    if (item.StatusTask == box.SPSTask.StatusTask)
                    { box.ListStrings.Add(item.ToString()); }
                }
            }

            if (box.ListStrings.Count == 0) { box.ListStrings.Add("No search result..."); }
        }
    }
    class SPSSearchByInfo : SPSStrategySearch
    {
        public override void Search(SPSBox box)
        {
            if(box==null) throw new ArgumentNullException(paramName: nameof(box));
            if( box.ListStrings ==null) throw new ArgumentNullException(paramName: nameof(box.ListStrings));
            if(box.Tasks==null) throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (box.Search == SPSSearchBy.Info)
            {
                foreach (var item in box.Tasks)
                {
                    if (string.Compare(item.InfoAboutTask,box.SPSTask.InfoAboutTask) == 0 
                        || item.InfoAboutTask.Contains(box.SPSTask.InfoAboutTask))
                    { box.ListStrings.Add(item.ToString()); }
                }
            }

            if (box.ListStrings.Count == 0) { box.ListStrings.Add("No search result..."); }
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
            if(box==null) throw new ArgumentNullException(paramName: nameof(box));
            if(box.Tasks==null) throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (box.Change == SPSChange.Priority)
            {
                for (int i = 0; i < box.Tasks.Count; i++)
                {
                    if (box.Tasks[i].Id == box.SPSTask.Id)
                    { box.Tasks[i].PriorityTask = box.SPSTask.PriorityTask; break; }
                }
            }
        }
    }
    class SPSChangeDueDate : SPSStrategyChange
    {
        public override void Change(SPSBox box)
        {
            //if(box==null)
            if(box==null) throw new ArgumentNullException(paramName: nameof(box));
            if(box.Tasks==null) throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (box.Change == SPSChange.DateEnd)
            {
                for (int i = 0; i < box.Tasks.Count; i++)
                {
                    if (box.Tasks[i].Id == box.SPSTask.Id)
                    { box.Tasks[i].DateTimeEndTask = box.SPSTask.DateTimeEndTask; break; }
                }
            }
        }
    }
    class SPSChangeTag : SPSStrategyChange
    {
        public override void Change(SPSBox box)
        {
            if(box==null) throw new ArgumentNullException(paramName: nameof(box));
            if(box.Tasks==null) throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (box.Change == SPSChange.Tag)
            {
                for (int i = 0; i < box.Tasks.Count; i++)
                {
                    if (box.Tasks[i].Id == box.SPSTask.Id)
                    { box.Tasks[i].TagTask = box.SPSTask.TagTask; break; }
                }
            }
        }
    }
    class SPSChangeInfo : SPSStrategyChange
    {
        public override void Change(SPSBox box)
        {
            if(box==null) throw new ArgumentNullException(paramName: nameof(box));
            if(box.Tasks==null) throw new ArgumentNullException(paramName: nameof(box.Tasks));

            if (box.Change == SPSChange.Info)
            {
                for (int i = 0; i < box.Tasks.Count; i++)
                {
                    if (box.Tasks[i].Id == box.SPSTask.Id)
                    { box.Tasks[i].InfoAboutTask = box.SPSTask.InfoAboutTask; break; }
                }
            }
        }
    }

}
