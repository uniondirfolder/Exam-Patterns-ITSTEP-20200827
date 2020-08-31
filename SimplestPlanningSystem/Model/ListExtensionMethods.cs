using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimplestPlanningSystem.Model
{
    static class ListExtensionMethods
    {
        static public void SPSChangeItem(this List<SPSTask> list, Guid IdItem, SPSTask who) 
        {
            var task = who ?? throw new ArgumentNullException(paramName: nameof(who));
            var list_temp = list ?? throw new ArgumentNullException(paramName: nameof(list));
            bool remove = false;
            for (int i = 0; i < list_temp.Count; i++)
            {
                if (list_temp[i].Id == IdItem)
                { list_temp.RemoveAt(i); }
                remove = true;
            }
            if (remove)
                list_temp.Add(who);
        }

        static public void SPSDeleteItem(this List<SPSTask> list, Guid IdItem)
        {
            var list_temp = list ?? throw new ArgumentNullException(paramName: nameof(list));
            
            for (int i = 0; i < list_temp.Count; i++)
            {
                if (list_temp[i].Id == IdItem)
                { list_temp.RemoveAt(i); }
 
            }
        }

        static public List<string>SPSTasksToListOfStrings(this List<SPSTask> list) 
        {
            List<string> output = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                output.Add($"{i + 1} | {list[i].InfoAboutTask} | {list[i].StatusTask} | " +
                    $"{list[i].TagTask} | {list[i].PriorityTask } | {list[i].DateTimeStartTask} | {list[i].DateTimeEndTask}");
            }

            return output;
        }
        static public SPSTask ConvertStringToSPSTask(this string recordSPSTask, List<SPSTask> db)
        {
            var task = recordSPSTask ?? throw new ArgumentNullException(paramName: nameof(recordSPSTask));
            var list = task.Trim().Split('|').ToList();
            int i;
            int.TryParse(list[0], out i);
            return new SPSTask(
                db[i].StatusTask,
                db[i].PriorityTask, 
                db[i].TagTask,
                db[i].InfoAboutTask,
                db[i].DateTimeStartTask,
                db[i].DateTimeEndTask);
        }
    }
}
