using SimplestPlanningSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplestPlanningSystem.Service
{
    public enum SPSServiceCode
    {
        CreateToDoList, CreateToDoTask, SetPriority, SetDueDate, DeleteTask, Change, Update, Fill
    }
    public interface ISPSMediator
    {
        void SendServiceCode(SPSServiceCode code, SPSmvc smvc , SPSBox box);
    }
    public abstract class SPSmvc
    {
        protected ISPSMediator dispatcher;
        public SPSmvc(ISPSMediator dispatcher)
        {
            this.dispatcher = dispatcher;
        }

        public void SendServiceCode(SPSServiceCode code, SPSBox box) 
        {
            dispatcher.SendServiceCode(code, this, box);
        }

        public abstract void Activity(SPSServiceCode code , SPSBox box);
    }
}
