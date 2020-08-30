using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplestPlanningSystem.Model
{
    abstract class SPSStrategy
    {
        public abstract List<SPSTask> Search(List<SPSTask> tasks, SearchBy search, SPSTask temp);
    }

    class SearchByDateStart: SPSStrategy
    {
        public override List<SPSTask> Search(List<SPSTask> tasks, SearchBy search, SPSTask temp)
        {
            var box = temp ?? throw new ArgumentNullException(paramName: nameof(temp));
            var list = tasks ?? throw new ArgumentNullException(paramName: nameof(tasks));

            List<SPSTask> output = null;

            if (search == SearchBy.Date)
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
    class SearchByTag: SPSStrategy
    {
        public override List<SPSTask> Search(List<SPSTask> tasks, SearchBy search, SPSTask temp)
        {
            var box = temp ?? throw new ArgumentNullException(paramName: nameof(temp));
            var list = tasks ?? throw new ArgumentNullException(paramName: nameof(tasks));

            List<SPSTask> output = null;

            if (search == SearchBy.Tag)
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
    class SearchByPriority : SPSStrategy
    {
        public override List<SPSTask> Search(List<SPSTask> tasks, SearchBy search, SPSTask temp)
        {
            var box = temp ?? throw new ArgumentNullException(paramName: nameof(temp));
            var list = tasks ?? throw new ArgumentNullException(paramName: nameof(tasks));

            List<SPSTask> output = null;

            if (search == SearchBy.Priority)
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

    class SearchByStatus : SPSStrategy
    {
        public override List<SPSTask> Search(List<SPSTask> tasks, SearchBy search, SPSTask temp)
        {
            var box = temp ?? throw new ArgumentNullException(paramName: nameof(temp));
            var list = tasks ?? throw new ArgumentNullException(paramName: nameof(tasks));

            List<SPSTask> output = null;

            if (search == SearchBy.Status)
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
    class SearchByInfo : SPSStrategy
    {
        public override List<SPSTask> Search(List<SPSTask> tasks, SearchBy search, SPSTask temp)
        {
            var box = temp ?? throw new ArgumentNullException(paramName: nameof(temp));
            var list = tasks ?? throw new ArgumentNullException(paramName: nameof(tasks));

            List<SPSTask> output = null;

            if (search == SearchBy.Info)
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
}
