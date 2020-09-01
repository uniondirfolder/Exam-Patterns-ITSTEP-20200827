using SimplestPlanningSystem.Model;
using SimplestPlanningSystem.Service;
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

    public sealed class SPSFacade : SPSmvc, ISPSFacade, ISPSObserver 
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
        public void Update(SPSBox box)
        {
            List<string> ent = box.ListStrings ?? throw new ArgumentNullException(paramName: nameof(box.ListStrings));
            ent = db.Context.SPSTasksToListOfStrings();
        }

        public override void Activity(SPSServiceCode code, SPSBox box )
        {
            switch (code)
            {
                case SPSServiceCode.Update:
                    Update(box);
                    break;
                case SPSServiceCode.DeleteTask:
                    DeleteTask(box.Guid);
                    break;
                case SPSServiceCode.Change:
                    Change(box.SPSTask, box.Guid);
                    break;
                case SPSServiceCode.CreateToDoList:
                    CreateToDoList(box.FilePath);
                    break;
                case SPSServiceCode.CreateToDoTask:
                    CreateToDoTask(box.SPSTask);
                    break;
                case SPSServiceCode.SetPriority:
                    SetPriority(box.Change, box.SPSTask, box.Guid);
                    break;
                case SPSServiceCode.SetDueDate:
                    SetDueDate(box.Change, box.SPSTask, box.Guid);
                    break;
                default:
                    break;
            }
        }

        public SPSFacade(ISPSMediator dispatcher, string pathfile = "test.sps"):base(dispatcher)
        {
            string str = pathfile ?? throw new ArgumentNullException(paramName: nameof(pathfile));
            db = new SPSFile(str);
            db.Read();
        }
    }
}
