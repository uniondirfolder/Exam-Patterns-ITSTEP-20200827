namespace SimplestPlanningSystem
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
            this.btnSetDateDue = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnSetTag = new System.Windows.Forms.Button();
            this.btnCahnge = new System.Windows.Forms.Button();
            this.btnLoadFromfile = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
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
            // btnSetDateDue
            // 
            this.btnSetDateDue.Location = new System.Drawing.Point(440, 112);
            this.btnSetDateDue.Name = "btnSetDateDue";
            this.btnSetDateDue.Size = new System.Drawing.Size(142, 28);
            this.btnSetDateDue.TabIndex = 1;
            this.btnSetDateDue.Text = "Set Date Due";
            this.btnSetDateDue.UseVisualStyleBackColor = true;
            this.btnSetDateDue.Click += new System.EventHandler(this.btnSetDateDue_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(440, 146);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(142, 28);
            this.btnDeleteTask.TabIndex = 1;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnSetTag
            // 
            this.btnSetTag.Location = new System.Drawing.Point(440, 180);
            this.btnSetTag.Name = "btnSetTag";
            this.btnSetTag.Size = new System.Drawing.Size(142, 28);
            this.btnSetTag.TabIndex = 1;
            this.btnSetTag.Text = "Set Tag";
            this.btnSetTag.UseVisualStyleBackColor = true;
            this.btnSetTag.Click += new System.EventHandler(this.btnSetTag_Click);
            // 
            // btnCahnge
            // 
            this.btnCahnge.Location = new System.Drawing.Point(440, 214);
            this.btnCahnge.Name = "btnCahnge";
            this.btnCahnge.Size = new System.Drawing.Size(142, 28);
            this.btnCahnge.TabIndex = 1;
            this.btnCahnge.Text = "Change Task";
            this.btnCahnge.UseVisualStyleBackColor = true;
            this.btnCahnge.Click += new System.EventHandler(this.btnChangeTask_Click);
            // 
            // btnLoadFromfile
            // 
            this.btnLoadFromfile.Location = new System.Drawing.Point(440, 248);
            this.btnLoadFromfile.Name = "btnLoadFromfile";
            this.btnLoadFromfile.Size = new System.Drawing.Size(142, 28);
            this.btnLoadFromfile.TabIndex = 1;
            this.btnLoadFromfile.Text = "Load from file";
            this.btnLoadFromfile.UseVisualStyleBackColor = true;
            this.btnLoadFromfile.Click += new System.EventHandler(this.btnLoadFromfile_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(440, 282);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(142, 28);
            this.btnSaveToFile.TabIndex = 1;
            this.btnSaveToFile.Text = "Save to File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(440, 316);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnLoadFromfile);
            this.Controls.Add(this.btnCahnge);
            this.Controls.Add(this.btnSetTag);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnSetDateDue);
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
        private System.Windows.Forms.Button btnSetDateDue;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnSetTag;
        private System.Windows.Forms.Button btnCahnge;
        private System.Windows.Forms.Button btnLoadFromfile;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listView;
    }
}

