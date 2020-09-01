using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimplestPlanningSystem.Model
{
    static class SPSExtensionMethods
    {
        static public void SPSChangeItem(this List<SPSTask> list, SPSBox box) 
        {
            var _box = box ?? throw new ArgumentNullException(paramName: nameof(box));
            var _item = _box.SPSTask ?? throw new ArgumentNullException(paramName: nameof(_box.SPSTask));
            var list_temp = list ?? throw new ArgumentNullException(paramName: nameof(list));
            for (int i = 0; i < list_temp.Count; i++)
            {
                if (list_temp[i].Id == _box.SPSTask.Id) 
                {
                    list_temp.RemoveAt(i);
                    list_temp.Add(box.SPSTask);
                    break;
                }
            }
        }
        static public void SPSDeleteItem(this List<SPSTask> list, SPSBox box)
        {
            var list_temp = list ?? throw new ArgumentNullException(paramName: nameof(list));
            var _box = box ?? throw new ArgumentNullException(paramName: nameof(box));
            for (int i = 0; i < list_temp.Count; i++)
            {
                if (list_temp[i].Id == _box.SPSTask.Id)
                {
                    list_temp.RemoveAt(i);
                    break;
                }
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
        static public SPSTask ConvertStringToSPSTask(this string recordSPSTask, SPSBox box)
        {
            var task_str = recordSPSTask ?? throw new ArgumentNullException(paramName: nameof(recordSPSTask));
            var _box = box ?? throw new ArgumentNullException(paramName: nameof(box));
            var _db = _box.Tasks ?? throw new ArgumentNullException(paramName: nameof(_box.Tasks));
            var list = task_str.Trim().Split('|').ToList();
            int index;
            int.TryParse(list[0], out index);
            if (index < 0 || index > _db.Count - 1) throw new IndexOutOfRangeException("Incorrect index");
            return new SPSTask(
                _db[index].Id,
                _db[index].StatusTask,
                _db[index].PriorityTask, 
                _db[index].TagTask,
                _db[index].InfoAboutTask,
                _db[index].DateTimeStartTask,
                _db[index].DateTimeEndTask);
        }
        static public Guid GetGuidByIndex(this SPSBox box, int index)
        {
            var _box = box ?? throw new ArgumentNullException(paramName: nameof(box));
            var _db = _box.Tasks ?? throw new ArgumentNullException(paramName: nameof(_box.Tasks));
            if (index < 0 || index > _db.Count - 1) throw new IndexOutOfRangeException("Incorrect index");
            Guid output = new Guid();
            output = _db[index].Id;

            return output;
        }
        static public SPSTask GetCopyByIndex(this SPSBox box, int index) 
        {
            var _box = box ?? throw new ArgumentNullException(paramName: nameof(box));
            var _db = _box.Tasks ?? throw new ArgumentNullException(paramName: nameof(_box.Tasks));
            return new SPSTask(
                _db[index].Id,
                _db[index].StatusTask,
                _db[index].PriorityTask,
                _db[index].TagTask,
                _db[index].InfoAboutTask,
                _db[index].DateTimeStartTask,
                _db[index].DateTimeEndTask);
        }
    }
}
