using SimplestPlanningSystem.Controller;
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
        public void SendServiceCode(SPSServiceCode code, SPSmvc smvc)
        {
            if (smvc is SPSFacade)
            {
                view.Activity(code);
            }
            else if (smvc is SPSView) 
            {
                controller.Activity(code);
            }
        }
        public SPSDispatcher(SPSFacade controller, SPSView view)
        {
            this.controller = controller ?? throw new ArgumentNullException(paramName: nameof(controller));
            this.view = view ?? throw new ArgumentNullException(paramName: nameof(view));
        }
    }
}
