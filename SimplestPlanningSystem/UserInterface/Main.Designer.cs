﻿namespace SimplestPlanningSystem
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateNewList = new System.Windows.Forms.Button();
            this.btnCreateNewTask = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnCreateNewList
            // 
            this.btnCreateNewList.Location = new System.Drawing.Point(440, 44);
            this.btnCreateNewList.Name = "btnCreateNewList";
            this.btnCreateNewList.Size = new System.Drawing.Size(142, 28);
            this.btnCreateNewList.TabIndex = 1;
            this.btnCreateNewList.Text = "Create New List";
            this.btnCreateNewList.UseVisualStyleBackColor = true;
            this.btnCreateNewList.Click += new System.EventHandler(this.btnCreateNewList_Click);
            // 
            // btnCreateNewTask
            // 
            this.btnCreateNewTask.Location = new System.Drawing.Point(440, 78);
            this.btnCreateNewTask.Name = "btnCreateNewTask";
            this.btnCreateNewTask.Size = new System.Drawing.Size(142, 28);
            this.btnCreateNewTask.TabIndex = 1;
            this.btnCreateNewTask.Text = "Create New Task";
            this.btnCreateNewTask.UseVisualStyleBackColor = true;
            this.btnCreateNewTask.Click += new System.EventHandler(this.btnCreateNewTask_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "Set Date Due";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(440, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 28);
            this.button4.TabIndex = 1;
            this.button4.Text = "Delete Task";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(440, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 28);
            this.button5.TabIndex = 1;
            this.button5.Text = "Change Task";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(440, 214);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 28);
            this.button6.TabIndex = 1;
            this.button6.Text = "Set Tag";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(440, 248);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(142, 28);
            this.button7.TabIndex = 1;
            this.button7.Text = "Change Task";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(440, 282);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(142, 28);
            this.button8.TabIndex = 1;
            this.button8.Text = "Load from file";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(440, 316);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(142, 28);
            this.button9.TabIndex = 1;
            this.button9.Text = "Save to File";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(440, 350);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(142, 28);
            this.button10.TabIndex = 1;
            this.button10.Text = "Search";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(35, 36);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(367, 441);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 501);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCreateNewTask);
            this.Controls.Add(this.btnCreateNewList);
            this.Name = "Main";
            this.Text = "Simple Planning System - test model";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreateNewList;
        private System.Windows.Forms.Button btnCreateNewTask;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ListView listView;
    }
}

