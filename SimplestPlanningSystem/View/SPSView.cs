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

        public void Change(SPSBox box)
        {
            dispatcher.SendServiceCode(SPSServiceCode.Change,this,box);
        }

        public void CreateToDoList(string filepath)
        {
            var box = new SPSBox();
            box.FilePath = filepath;
            dispatcher.SendServiceCode(SPSServiceCode.CreateToDoList, this, box);
        }

        public void CreateToDoTask(SPSBox box)
        {
            dispatcher.SendServiceCode(SPSServiceCode.CreateToDoTask, this, box);
        }

        public void DeleteTask(SPSBox box)
        {
            dispatcher.SendServiceCode(SPSServiceCode.DeleteTask, this, box);
        }

        public void SetDueDate(SPSBox box)
        {
            dispatcher.SendServiceCode(SPSServiceCode.SetDueDate, this, box);
        }

        public void SetPriority(SPSBox box)
        {
            dispatcher.SendServiceCode(SPSServiceCode.SetPriority, this, box);
        }

        public void Update(SPSBox box)
        {
            dispatcher.SendServiceCode(SPSServiceCode.Update, this, box);
        }

        public override void Activity(SPSServiceCode code, SPSBox box)
        {
            throw new NotImplementedException();
        }
    }
}
