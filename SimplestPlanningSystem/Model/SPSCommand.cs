using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimplestPlanningSystem.Model.SPSFileFactoryMethod;

namespace SimplestPlanningSystem.Model
{
    class SPSCommand
    {
        public interface Icommand 
        {
            void Execute();
        }

        public class CreateSPSdb : Icommand
        {
            string path;
            private SPSFile db;

            public CreateSPSdb(SPSFile db, string path) 
            {
                this.path = path ?? throw new ArgumentNullException(paramName: nameof(path));
                this.db = db ?? throw new ArgumentNullException(paramName: nameof(db));
            }
            public void Execute()
            {
                db.CreateNewDb(path);
            }
        }
        public class CreateSPSTask : Icommand
        {
            private SPSBox box;
            public CreateSPSTask(SPSBox box)
            {
                this.box = box ?? throw new ArgumentNullException(paramName: nameof(box));
                if (this.box.Tasks == null) throw new ArgumentNullException(paramName: nameof(this.box.Tasks));
                if (this.box.SPSTask == null) throw new ArgumentNullException(paramName: nameof(this.box.SPSTask));
            }
            public void Execute()
            {
                box.Tasks.Add(box.SPSTask);
            }
        }
        public class ChangeSPSTask : Icommand
        {
            private SPSBox box;
            public ChangeSPSTask(SPSBox box)
            {
                this.box = box ?? throw new ArgumentNullException(paramName: nameof(box));
                if (this.box.Tasks==null) throw new ArgumentNullException(paramName: nameof(this.box.Tasks));
            }
            public void Execute()
            {
                box.Tasks.SPSChangeItem(box);
            }
        }
        public class DeleteSPSTask : Icommand
        {
            private SPSBox box;
            public DeleteSPSTask(SPSBox box)
            {
                this.box = box ?? throw new ArgumentNullException(paramName: nameof(box));
                if (this.box.Tasks == null) throw new ArgumentNullException(paramName: nameof(this.box.Tasks));
            }
            public void Execute()
            {
                box.Tasks.SPSDeleteItem(box);
            }
        }
        public class ChangeSPSTaskPriority : Icommand
        {
            private SPSBox box;
            public ChangeSPSTaskPriority(SPSBox box)
            {
                this.box = box ?? throw new ArgumentNullException(paramName: nameof(box));
                if (this.box.Tasks == null) throw new ArgumentNullException(paramName: nameof(this.box.Tasks));
            }
            public void Execute()
            {
                var c = new SPSChangePriority();
                c.Change(box);
            }
        }
        public class ChangeSPSTaskDueDate : Icommand
        {
            private SPSBox box;
            public ChangeSPSTaskDueDate (SPSBox box)
            {
                this.box = box ?? throw new ArgumentNullException(paramName: nameof(box));
                if (this.box.Tasks == null) throw new ArgumentNullException(paramName: nameof(this.box.Tasks));
            }
            public void Execute()
            {
                var c = new SPSChangeDueDate();
                c.Change(box);
            }
        }
        public class UpdateListTasks : Icommand
        {
            private SPSBox box;
            public UpdateListTasks(SPSBox box)
            {
                this.box = box ?? throw new ArgumentNullException(paramName: nameof(box));
                if (this.box.Tasks == null) throw new ArgumentNullException(paramName: nameof(this.box.Tasks));
            }
            public void Execute()
            {
                if (box.ListView != null)
                {
                    box.ListView.Clear();
                    foreach (var item in box.Tasks)
                    {
                        box.ListView.Items.Add(item.ToString());
                    }
                }
                else
                {
                    box.ListStrings = box.Tasks.SPSTasksToListOfStrings();
                }
            }
        }
        public class ChangeSPSTaskTag : Icommand
        {
            private SPSBox box;
            public ChangeSPSTaskTag(SPSBox box)
            {
                this.box = box ?? throw new ArgumentNullException(paramName: nameof(box));
                if (this.box.Tasks == null) throw new ArgumentNullException(paramName: nameof(this.box.Tasks));
            }
            public void Execute()
            {
                var c = new SPSChangeTag();
                c.Change(box);
            }
        }
    }
}
