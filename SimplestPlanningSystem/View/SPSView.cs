using SimplestPlanningSystem.Controller;
using SimplestPlanningSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplestPlanningSystem.View
{  
    public class SPSView : ISPSFacade
    {
        private SPSFacade controller;
        public SPSView(SPSFacade controller)
        {
            this.controller = controller ?? throw new ArgumentNullException(paramName: nameof(controller));
        }
        public void Change(SPSTask task, Guid id)
        {
            controller.Change(task, id);
        }

        public void CreateToDoList(string pathfile)
        {
            controller.CreateToDoList(pathfile);
        }

        public void CreateToDoTask(SPSTask task)
        {
            controller.CreateToDoTask(task);
        }

        public void DeleteTask(Guid id)
        {
            controller.DeleteTask(id);
        }

        public void SetDueDate(SPSChange change, SPSTask task, Guid id)
        {
            controller.SetDueDate(change, task, id);
        }

        public void SetPriority(SPSChange change, SPSTask task, Guid id)
        {
            controller.SetPriority(change, task, id);
        }

        public void Update(List<string> whom)
        {
            controller.Update(whom);
        }
    }
}
