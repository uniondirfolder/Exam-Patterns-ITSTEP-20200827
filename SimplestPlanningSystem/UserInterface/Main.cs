﻿using SimplestPlanningSystem.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
