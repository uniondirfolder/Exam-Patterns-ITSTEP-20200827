﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplestPlanningSystem.Model
{
    public class SPSBox: IDisposable
    {
        private bool disposedValue;

        public string FilePath { get; set; } = "nothing";
        public DateTime DateTime { get; set; } = DateTime.UtcNow;

        public List<SPSTask> Tasks = null;
        public SPSTask SPSTask { get; set; } = new SPSTask();
        public SPSSearchBy Search { get; set; } = SPSSearchBy.Tag;
        public SPSChange Change { get; set; } = SPSChange.Tag;

        public List<string> ListStrings = null;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    SPSTask.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~SPSBox()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
