using SimplestPlanningSystem.Controller;
using SimplestPlanningSystem.Model;
using SimplestPlanningSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplestPlanningSystem.Service
{
    public sealed class SPSDispatcher : ISPSMediator
    {
        private SPSFacade controller;
        private SPSView view;
        public void SendServiceCode(SPSServiceCode code, SPSmvc smvc, SPSBox box)
        {
            if (smvc is SPSFacade)
            {
                view.Activity(code,box);
            }
            else if (smvc is SPSView) 
            {
                controller.Activity(code,box);
            }
        }
        public SPSDispatcher(SPSFacade controller, SPSView view)
        {
            this.controller = controller ?? throw new ArgumentNullException(paramName: nameof(controller));
            this.view = view ?? throw new ArgumentNullException(paramName: nameof(view));
        }
    }
}
