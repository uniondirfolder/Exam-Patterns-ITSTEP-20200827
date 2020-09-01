using SimplestPlanningSystem.Model;
using System;

namespace SimplestPlanningSystem.Controller
{
    interface ISPSFacade
    {
        void Change(SPSBox box);
        void CreateToDoList(string pathfile);
        void CreateToDoTask(SPSBox box);
        void DeleteTask(SPSBox box);
        void SetDueDate(SPSBox box);
        void SetPriority(SPSBox box);
        void SetTag(SPSBox box);
        void SetInfo(SPSBox box);
    }
}