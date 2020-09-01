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
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateNewList_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateNewTask_Click(object sender, EventArgs e)
        {
            var frm = new FormNewTask(Dispatcher, listView);
            frm.Show();
        }

        private void btnSetDateDue_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeTask_Click(object sender, EventArgs e)
        {

        }

        private void btnSetTag_Click(object sender, EventArgs e)
        {

        }

        private void btnCahnge_Click(object sender, EventArgs e)
        {

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
                    Dispatcher.SendServiceCode(SPSServiceCode.CreateToDoList, Dispatcher.GetController(), box);
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
    }
}
