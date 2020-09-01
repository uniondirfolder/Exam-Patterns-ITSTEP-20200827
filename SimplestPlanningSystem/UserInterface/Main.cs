using SimplestPlanningSystem.Model;
using SimplestPlanningSystem.Service;
using SimplestPlanningSystem.UserInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplestPlanningSystem
{
    public partial class Main : Form
    {
        public SPSDispatcher Dispatcher;
        public Main(SPSDispatcher dispatcher)
        {
            Dispatcher = dispatcher;

            InitializeComponent();
            var box = new SPSBox();
            box.ListView = listView;
            Dispatcher.SendServiceCode(SPSServiceCode.Update, dispatcher.GetView(), box);
            box.Dispose();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateNewList_Click(object sender, EventArgs e)
        {
            var box = new SPSBox();
            box.FilePath = "test2.sps";
            Dispatcher.SendServiceCode(SPSServiceCode.CreateToDoList, Dispatcher.GetView(), box);
            listView.Clear();
            box.Dispose();
        }

        private void btnCreateNewTask_Click(object sender, EventArgs e)
        {
            var frm = new FormNewTask(Dispatcher, listView);
            frm.Show();
        }

        private void btnSetDateDue_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                var index = listView.Items.IndexOf(listView.SelectedItems[0]);
                var frm = new FormNewTask(Dispatcher, listView, SPSChange.DateEnd, index);
                frm.Show();
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                var index = listView.Items.IndexOf(listView.SelectedItems[0]);
                var box = new SPSBox();
                box.index = index;
                Dispatcher.SendServiceCode(SPSServiceCode.DeleteTask, Dispatcher.GetView(), box);
                box.ListView = listView;
                Dispatcher.SendServiceCode(SPSServiceCode.Update, Dispatcher.GetView(), box);
                box.Dispose();
            }
        }

        private void btnChangeTask_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                var index= listView.Items.IndexOf(listView.SelectedItems[0]);
                var frm = new FormNewTask(Dispatcher, listView,SPSChange.Task,index);
                frm.Show();
            }
        }

        private void btnSetTag_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                var index = listView.Items.IndexOf(listView.SelectedItems[0]);
                var frm = new FormNewTask(Dispatcher, listView, SPSChange.Tag, index);
                frm.Show();
            }
        }

        private void btnLoadFromfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "sps files (*.sps)|*.sps|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) 
                {
                    SPSBox box = new SPSBox();
                    box.FilePath = openFileDialog.FileName;
                    Dispatcher.SendServiceCode(SPSServiceCode.CreateToDoList, Dispatcher.GetView(), box);
                    box.ListView = listView;
                    Dispatcher.SendServiceCode(SPSServiceCode.Update, Dispatcher.GetController(), box);
                    box.Dispose();
                }

            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(saveFileDialog.FileName, listView.Items.ToString());
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
