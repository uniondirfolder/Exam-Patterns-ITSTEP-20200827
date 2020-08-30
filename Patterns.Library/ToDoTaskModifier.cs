﻿using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace ToDo.Library
{
    public abstract class ToDoTaskModifier : IDisposable
    {
        private bool disposedValue;

        protected ToDoMediator mediator;
        protected ToDoTask doTask;

        protected ToDoTaskModifier(ToDoMediator mediator, ToDoTask doTask) 
        {
            this.mediator = mediator;
            this.doTask = doTask;
            mediator.Queries += Handle;
        }
        protected abstract void Handle(object sender, ToDoQuery q);
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~ToDoTaskModifier()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            mediator.Queries -= Handle;

            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    public class TagModifier : ToDoTaskModifier
    {
        public TagModifier(ToDoMediator mediator, ToDoTask doTask): base(mediator,doTask)
        {

        }
        protected override void Handle(object sender, ToDoQuery q)
        {
            throw new NotImplementedException();
        }
    }
}
