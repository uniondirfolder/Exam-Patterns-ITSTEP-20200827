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
        public FormNewTask(SPSDispatcher dispatcher, ListView listView)
        {
            this.dispatcher = dispatcher;
            this.listView = listView;
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (
                dateTimePickerStart.Value <= dateTimePickerEnd.Value ||
                !string.IsNullOrEmpty(tbxTextInfo.Text) ||
                !string.IsNullOrWhiteSpace(tbxTextInfo.Text) ||
                cmbPriority.SelectedIndex > -1 ||
                cmbTag.SelectedIndex > -1
                )
            {
                SPSBox box = new SPSBox();
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
                listView.Items.Add(box.SPSTask.ToString());
                dispatcher.SendServiceCode(SPSServiceCode.CreateToDoTask, dispatcher.GetView(), box);
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
