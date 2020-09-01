using SimplestPlanningSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplestPlanningSystem.Controller
{
    interface ISPSObserver
    {
       void Update(SPSBox box);
    }
}
