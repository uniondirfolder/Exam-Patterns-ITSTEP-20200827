using SimplestPlanningSystem.Model;
using SimplestPlanningSystem.Service;
using SimplestPlanningSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplestPlanningSystem.UserInterface
{
    public partial class FormNewTask : Form
    {
        private ListView listView;
        private SPSDispatcher dispatcher;
        private SPSChange change;
        private int index;
        SPSBox box = new SPSBox();
        public FormNewTask(SPSDispatcher dispatcher, ListView listView, SPSChange change, int index)
        {
            this.dispatcher = dispatcher;
            this.listView = listView;
            this.change = change;
            this.index = index;

            InitializeComponent();

            if (index > -1)
            {
                Text = "Change Task";
                btnAddTask.Text = "Save";
                box.index = index;
                dispatcher.SendServiceCode(SPSServiceCode.Fill, dispatcher.GetView(), box);
                cmbPriority.SelectedIndex = (int)box.SPSTask.PriorityTask;
                cmbTag.SelectedIndex = (int)box.SPSTask.TagTask;
                tbxTextInfo.Text = box.SPSTask.InfoAboutTask;
                dateTimePickerEnd.Value = box.SPSTask.DateTimeEndTask;
                dateTimePickerStart.Value = box.SPSTask.DateTimeStartTask;
                cmbPriority.IsAccessible = false;
                cmbTag.IsAccessible = false;
                tbxTextInfo.ReadOnly = true;
                dateTimePickerEnd.IsAccessible = false;
                dateTimePickerStart.IsAccessible = false;
                switch (change)
                {
                    case SPSChange.Priority:
                        cmbPriority.IsAccessible = true;
                        break;
                    case SPSChange.Tag:
                        cmbTag.IsAccessible = true;
                        break;
                    case SPSChange.Info:
                        tbxTextInfo.ReadOnly = false;
                        break;
                    case SPSChange.DateStart:
                        dateTimePickerStart.IsAccessible = true;
                        break;
                    case SPSChange.DateEnd:
                        dateTimePickerEnd.IsAccessible = true;
                        break;
                    default:
                        break;
                }

            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (
                dateTimePickerStart.Value <= dateTimePickerEnd.Value &&
                !string.IsNullOrEmpty(tbxTextInfo.Text) &&
                !string.IsNullOrWhiteSpace(tbxTextInfo.Text) &&
                cmbPriority.SelectedIndex > -1 &&
                cmbTag.SelectedIndex > -1
                )
            {
                box.SPSTask.DateTimeStartTask = dateTimePickerStart.Value;
                box.SPSTask.DateTimeEndTask = dateTimePickerEnd.Value;
                switch ((Model.Tag)cmbTag.SelectedIndex)
                {
                    case Model.Tag.Important:
                        box.SPSTask.TagTask = Model.Tag.Important;
                        break;
                    case Model.Tag.Home:
                        box.SPSTask.TagTask = Model.Tag.Home;
                        break;
                    case Model.Tag.Work:
                        box.SPSTask.TagTask = Model.Tag.Work;
                        break;
                    case Model.Tag.Personal:
                        box.SPSTask.TagTask = Model.Tag.Personal;
                        break;
                    default:
                        break;
                }
                switch ((Model.Priority)cmbPriority.SelectedIndex)
                {
                    case Priority.Low:
                        box.SPSTask.PriorityTask = Priority.Low;
                        break;
                    case Priority.Normal:
                        box.SPSTask.PriorityTask = Priority.Normal;
                        break;
                    case Priority.High:
                        box.SPSTask.PriorityTask = Priority.High;
                        break;
                    case Priority.Middle:
                        box.SPSTask.PriorityTask = Priority.Middle;
                        break;
                    default:
                        break;
                }
                box.SPSTask.InfoAboutTask = tbxTextInfo.Text;
                if (index == -1)
                {                   
                    listView.Items.Add(box.SPSTask.ToString());
                    dispatcher.SendServiceCode(SPSServiceCode.CreateToDoTask, dispatcher.GetView(), box);
                    
                    
                }
                else
                {
                    switch (change)
                    {
                        case SPSChange.Priority:
                            dispatcher.SendServiceCode(SPSServiceCode.SetPriority, dispatcher.GetView(), box);
                            break;
                        case SPSChange.Tag:
                            dispatcher.SendServiceCode(SPSServiceCode.SetTag, dispatcher.GetView(), box);
                            break;
                        case SPSChange.Info:
                            dispatcher.SendServiceCode(SPSServiceCode.SetInfo, dispatcher.GetView(), box);
                            break;
                        case SPSChange.DateEnd:
                            dispatcher.SendServiceCode(SPSServiceCode.SetDueDate, dispatcher.GetView(), box);
                            break;
                        default:
                            break;
                    }
                    box.ListView = listView;
                    dispatcher.SendServiceCode(SPSServiceCode.Update, dispatcher.GetView(), box);
                    
                }
                box.Dispose();
                Close();
            }
            else
            {
                MessageBox.Show("Not all parameters satisfy");
            }
        }
    }
}
