using SimplestPlanningSystem.Model;
using SimplestPlanningSystem.Service;
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
    public partial class FormSearch : Form
    {
        private SPSDispatcher dispatcher;
        SPSBox box = new SPSBox();
        public FormSearch(SPSDispatcher dispatcher)
        {
            InitializeComponent();
            cmbTag.Items.AddRange(new string[]{ 
                Model.Tag.Important.ToString(),
                Model.Tag.Home.ToString(),
                Model.Tag.Work.ToString(),
                Model.Tag.Personal.ToString()
            });
            cmbPriority.Items.AddRange(new string[]{
                Model.Priority.Low.ToString(),
                Model.Priority.Normal.ToString(),
                Model.Priority.High.ToString(),
                Model.Priority.Middle.ToString()
            });
            if(dispatcher== null) throw new ArgumentNullException(paramName: nameof(dispatcher));
            this.dispatcher = dispatcher;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbDueDate.Checked == true)
            {
                box.DateTime = dateTimePickerDueDate.Value;
                box.Search = SPSSearchBy.DueDate;
                listView.Items.Clear();
                box.ListView = listView;
                dispatcher.SendServiceCode(SPSServiceCode.Search, dispatcher.GetView(), box);
            }
            else if (rbTag.Checked == true && cmbTag.SelectedIndex > -1)
            {
                box.SPSTask.TagTask = (Model.Tag)cmbTag.SelectedIndex;
                box.Search = SPSSearchBy.Tag;
                listView.Items.Clear();
                box.ListView = listView;
                dispatcher.SendServiceCode(SPSServiceCode.Search, dispatcher.GetView(), box);
            }
            else if (rbPriority.Checked == true && cmbPriority.SelectedIndex > -1)
            {
                box.SPSTask.PriorityTask = (Model.Priority)cmbPriority.SelectedIndex;
                box.Search = SPSSearchBy.Priority;
                listView.Items.Clear();
                box.ListView = listView;
                dispatcher.SendServiceCode(SPSServiceCode.Search, dispatcher.GetView(), box);
            }
            else if (rbInfo.Checked == true && !string.IsNullOrEmpty(tbxStr.Text) && !string.IsNullOrWhiteSpace(tbxStr.Text))
            {
                box.SPSTask.InfoAboutTask = tbxStr.Text;
                box.Search = SPSSearchBy.Info;
                listView.Items.Clear();
                box.ListView = listView;
                dispatcher.SendServiceCode(SPSServiceCode.Search, dispatcher.GetView(), box);
            }
            else 
            {
                MessageBox.Show("Wrong parameters");
            }
        }
    }
}
