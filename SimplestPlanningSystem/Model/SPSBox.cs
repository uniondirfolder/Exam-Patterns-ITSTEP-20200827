using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplestPlanningSystem.Model
{
    public class SPSBox
    {
        public SPSTask SPSTask { get; set; } = new SPSTask();
        public SPSSearchBy Search { get; set; } = SPSSearchBy.Tag;
        public SPSChange Change { get; set; } = SPSChange.Tag;
    }
}
