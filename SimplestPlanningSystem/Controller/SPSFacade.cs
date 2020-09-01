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
using static SimplestPlanningSystem.Model.SPSFileFactoryMethod;
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
        public void CreateToDoTask(SPSBox box)
        {
            var q = new CreateSPSTask(box);
            q.Execute();
        }
        public void SetPriority(SPSBox box)
        {
            var q = new ChangeSPSTaskPriority(box);
            q.Execute();
        }
        public void SetDueDate(SPSBox box)
        {
            var q = new ChangeSPSTaskDueDate(box);
            q.Execute();
        }
        public void DeleteTask(SPSBox box)
        {
            var q = new DeleteSPSTask(box);
            q.Execute();
        }
        public void Change(SPSBox box)
        {
            var q = new ChangeSPSTask(box);
            q.Execute();
        }
        public void Update(SPSBox box)
        {
            var q = new UpdateListTasks(box);
            q.Execute();
        }
        public void SetContext(List<SPSTask> tasks) 
        {
            db.SetContext(tasks);
        }
        private void Fill(SPSBox box) 
        {
            box.SPSTask = box.GetCopyById(box.index);
        } 
        public override void Activity(SPSServiceCode code, SPSBox box )
        {
            if(box == null) throw new ArgumentNullException(paramName: nameof(box));

            switch (code)
            {
                case SPSServiceCode.Update:
                    Update(box);
                    break;
                case SPSServiceCode.DeleteTask:
                    DeleteTask(box);
                    break;
                case SPSServiceCode.Change:
                    Change(box);
                    break;
                case SPSServiceCode.CreateToDoList:
                    CreateToDoList(box.FilePath);
                    break;
                case SPSServiceCode.CreateToDoTask:
                    CreateToDoTask(box);
                    break;
                case SPSServiceCode.SetPriority:
                    SetPriority(box);
                    break;
                case SPSServiceCode.SetDueDate:
                    SetDueDate(box);
                    break;
                case SPSServiceCode.Fill:
                    Fill(box);
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
