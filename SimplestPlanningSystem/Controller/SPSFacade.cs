using SimplestPlanningSystem.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimplestPlanningSystem.Model.FileFactoryMethod;
using static SimplestPlanningSystem.Model.SPSCommand;

namespace SimplestPlanningSystem.Controller
{

    public class SPSFacade : ISPSFacade, ISPSObserver
    {
        private SPSFile db;

        //
        public void CreateToDoList(string pathfile)
        {
            var q = new CreateSPSdb(db, pathfile);
            q.Execute();

        }
        public void CreateToDoTask(SPSTask task)
        {
            var q = new CreateSPSTask(db, task);
            q.Execute();
        }
        public void SetPriority(SPSChange change, SPSTask task, Guid id)
        {
            var q = new ChangeSPSTaskPriority(db, change, id);
            q.Execute();
        }
        public void SetDueDate(SPSChange change, SPSTask task, Guid id)
        {
            var q = new ChangeSPSTaskDueDate(db, change, id);
            q.Execute();
        }
        public void DeleteTask(Guid id)
        {
            var q = new DeleteSPSTask(db, id);
            q.Execute();
        }
        public void Change(SPSTask task, Guid id)
        {
            var q = new ChangeSPSTask(db, task, id);
            q.Execute();
        }
        public void Update(List<string> whom)
        {
            var ent = whom ?? throw new ArgumentNullException(paramName: nameof(whom));
            ent = db.Context.SPSTasksToListOfStrings();
        }

        public SPSFacade(string pathfile = "test.sps")
        {
            string str = pathfile ?? throw new ArgumentNullException(paramName: nameof(pathfile));
            db = new SPSFile(str);
            db.Read();
        }
    }
}
