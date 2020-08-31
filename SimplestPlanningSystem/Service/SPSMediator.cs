using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplestPlanningSystem.Service
{
    public enum SPSServiceCode
    {

    }
    public interface ISPSMediator
    {
        void SendServiceCode(SPSServiceCode code, SPSmvc smvc);
    }

    public abstract class SPSmvc
    {
        protected ISPSMediator dispatcher;
        public SPSmvc(ISPSMediator dispatcher)
        {
            this.dispatcher = dispatcher;
        }

        public void SendServiceCode(SPSServiceCode code) 
        {
            dispatcher.SendServiceCode(code, this);
        }

        public abstract void Activity(SPSServiceCode code);
    }


}
