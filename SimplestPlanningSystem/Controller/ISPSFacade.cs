using SimplestPlanningSystem.Model;
using System;

namespace SimplestPlanningSystem.Controller
{
    interface ISPSFacade
    {
        void Change(SPSTask task, Guid id);
        void CreateToDoList(string pathfile);
        void CreateToDoTask(SPSTask task);
        void DeleteTask(Guid id);
        void SetDueDate(SPSChange change, SPSTask task, Guid id);
        void SetPriority(SPSChange change, SPSTask task, Guid id);
    }
}