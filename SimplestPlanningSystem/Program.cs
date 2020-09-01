using SimplestPlanningSystem.Controller;
using SimplestPlanningSystem.Service;
using SimplestPlanningSystem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplestPlanningSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var dispatcher = new SPSDispatcher();
            var controller = new SPSFacade(dispatcher);
            var view = new SPSView(dispatcher);
            dispatcher.SetController(controller);
            dispatcher.SetView(view);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(dispatcher));
        }
    }
}
