using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimplestPlanningSystem.Model.SPSFileFactoryMethod;

namespace SimplestPlanningSystem.Model
{
    public class SPSBox: IDisposable
    {
        private bool disposed;

        public string FilePath { get; set; } = "nothing";
        public DateTime DateTime { get; set; } = DateTime.UtcNow;

        public List<SPSTask> Tasks = null;
        public SPSTask SPSTask { get; set; } = new SPSTask();
        public SPSSearchBy Search { get; set; } = SPSSearchBy.Tag;
        public SPSChange Change { get; set; } = SPSChange.Tag;
        public ListView ListView = null;
        public List<string> ListStrings = null;

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {

                }
                disposed = true;
            }
        }
        ~SPSBox()
        {
            Tasks = null;
            ListStrings = null;
            ListView = null;
            Dispose(false);
        }
    }
}
