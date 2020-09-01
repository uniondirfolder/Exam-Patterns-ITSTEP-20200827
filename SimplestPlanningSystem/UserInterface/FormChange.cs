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
    public partial class FormChange : Form
    {
        private ListView listView;
        private SPSDispatcher dispatcher;
        
        public FormChange(SPSDispatcher dispatcher, ListView listView, SPSChange Change)
        {

            InitializeComponent();
        }
    }
}
