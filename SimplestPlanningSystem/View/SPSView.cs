using SimplestPlanningSystem.Controller;
using SimplestPlanningSystem.Model;
using SimplestPlanningSystem.Service;
using System;
using System.Collections.Generic;


namespace SimplestPlanningSystem.View
{  
    public class SPSView : SPSmvc, ISPSFacade
    {
        public SPSView(ISPSMediator dispatcher) : base(dispatcher)
        {
        }

        public void Change(SPSTask task, Guid id)
        {
            var b = new SPSBox();
            b.SPSTask = task;
            b.Guid = id;
            dispatcher.SendServiceCode(SPSServiceCode.Change,this,b);
        }

        public void CreateToDoList(string pathfile)
        {
            var b = new SPSBox();
            b.FilePath = pathfile;
            dispatcher.SendServiceCode(SPSServiceCode.CreateToDoList, this, b);
        }

        public void CreateToDoTask(SPSTask task)
        {
            var b = new SPSBox();
            b.SPSTask = task;
            dispatcher.SendServiceCode(SPSServiceCode.CreateToDoTask, this, b);
        }

        public void DeleteTask(Guid id)
        {
            var b = new SPSBox();
            b.Guid = id;
            dispatcher.SendServiceCode(SPSServiceCode.DeleteTask, this, b);
        }

        public void SetDueDate(SPSChange change, SPSTask task, Guid id)
        {
            var b = new SPSBox();
            b.SPSTask = task;
            b.Guid = id;
            b.Change = change;
            dispatcher.SendServiceCode(SPSServiceCode.SetDueDate, this, b);
        }

        public void SetPriority(SPSChange change, SPSTask task, Guid id)
        {
            var b = new SPSBox();
            b.SPSTask = task;
            b.Guid = id;
            b.Change = change;
            dispatcher.SendServiceCode(SPSServiceCode.SetPriority, this, b);
        }

        public void Update(List<string> whom)
        {
            controller.Update(whom);
        }

        public override void Activity(SPSServiceCode code, SPSBox box)
        {
            throw new NotImplementedException();
        }
    }
}
