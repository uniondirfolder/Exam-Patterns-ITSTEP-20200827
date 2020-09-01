using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimplestPlanningSystem.Model.FileFactoryMethod;

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
            private Guid id;
            private SPSTask task;
            private SPSFile db;
            public ChangeSPSTask(SPSFile db, SPSTask task, Guid id)
            {
                this.task = task ?? throw new ArgumentNullException(paramName: nameof(task));
                this.db = db ?? throw new ArgumentNullException(paramName: nameof(db));
                this.id = id;
            }
            public void Execute()
            {
                db.Context.SPSChangeItem(id, task);
            }
        }
        public class DeleteSPSTask : Icommand
        {
            private Guid id;
            private SPSFile db;
            public DeleteSPSTask(SPSFile db, Guid id)
            {
                this.db = db ?? throw new ArgumentNullException(paramName: nameof(db));
                this.id = id;
            }
            public void Execute()
            {
                db.Context.SPSDeleteItem(id);
            }
        }
        public class ChangeSPSTaskPriority : Icommand
        {
            private SPSTask task;
            private SPSChange change;
            private Guid guid;
            private SPSFile db;
            public ChangeSPSTaskPriority(SPSFile db, SPSChange change, Guid guid)
            {
                this.task = task ?? throw new ArgumentNullException(paramName: nameof(task));
                this.change = change;
                this.guid = guid;
                this.db = db ?? throw new ArgumentNullException(paramName: nameof(db));
            }
            public void Execute()
            {
                var c = new SPSChangePriority();
                c.Change(db.Context, change, task, guid);
            }
        }
        public class ChangeSPSTaskDueDate : Icommand
        {
            private SPSTask task;
            private SPSChange change;
            private Guid guid;
            private SPSFile db;
            public ChangeSPSTaskDueDate (SPSFile db, SPSChange change, Guid guid)
            {
                this.task = task ?? throw new ArgumentNullException(paramName: nameof(task));
                this.change = change;
                this.guid = guid;
                this.db = db ?? throw new ArgumentNullException(paramName: nameof(db));
            }
            public void Execute()
            {
                var c = new SPSChangeDueDate();
                c.Change(db.Context, change, task, guid);
            }
        }
        public class UpdateListTasks : Icommand
        {
            private SPSBox box;
            private SPSFile db;
            public UpdateListTasks(SPSFile db, SPSBox box)
            {
                this.box = box ?? throw new ArgumentNullException(paramName: nameof(box));
                this.box = box;
                this.db = db ?? throw new ArgumentNullException(paramName: nameof(db));
            }
            public void Execute()
            {
                var c = new SPSChangeDueDate();
                c.Change(db.Context, change, task, guid);
            }
        }
    }
}
