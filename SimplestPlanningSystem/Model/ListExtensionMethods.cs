using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
