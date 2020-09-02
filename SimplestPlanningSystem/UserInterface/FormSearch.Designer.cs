namespace SimplestPlanningSystem.UserInterface
{
    partial class FormSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDueDate = new System.Windows.Forms.RadioButton();
            this.rbTag = new System.Windows.Forms.RadioButton();
            this.rbPriority = new System.Windows.Forms.RadioButton();
            this.rbInfo = new System.Windows.Forms.RadioButton();
            this.cmbTag = new System.Windows.Forms.ComboBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.tbxStr = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbxStr);
            this.groupBox1.Controls.Add(this.dateTimePickerDueDate);
            this.groupBox1.Controls.Add(this.cmbPriority);
            this.groupBox1.Controls.Add(this.cmbTag);
            this.groupBox1.Controls.Add(this.rbInfo);
            this.groupBox1.Controls.Add(this.rbPriority);
            this.groupBox1.Controls.Add(this.rbTag);
            this.groupBox1.Controls.Add(this.rbDueDate);
            this.groupBox1.Location = new System.Drawing.Point(28, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // rbDueDate
            // 
            this.rbDueDate.AutoSize = true;
            this.rbDueDate.Location = new System.Drawing.Point(7, 30);
            this.rbDueDate.Name = "rbDueDate";
            this.rbDueDate.Size = new System.Drawing.Size(69, 17);
            this.rbDueDate.TabIndex = 0;
            this.rbDueDate.TabStop = true;
            this.rbDueDate.Text = "Due date";
            this.rbDueDate.UseVisualStyleBackColor = true;
            // 
            // rbTag
            // 
            this.rbTag.AutoSize = true;
            this.rbTag.Location = new System.Drawing.Point(7, 54);
            this.rbTag.Name = "rbTag";
            this.rbTag.Size = new System.Drawing.Size(44, 17);
            this.rbTag.TabIndex = 1;
            this.rbTag.TabStop = true;
            this.rbTag.Text = "Tag";
            this.rbTag.UseVisualStyleBackColor = true;
            // 
            // rbPriority
            // 
            this.rbPriority.AutoSize = true;
            this.rbPriority.Location = new System.Drawing.Point(7, 78);
            this.rbPriority.Name = "rbPriority";
            this.rbPriority.Size = new System.Drawing.Size(56, 17);
            this.rbPriority.TabIndex = 2;
            this.rbPriority.TabStop = true;
            this.rbPriority.Text = "Priority";
            this.rbPriority.UseVisualStyleBackColor = true;
            // 
            // rbInfo
            // 
            this.rbInfo.AutoSize = true;
            this.rbInfo.Location = new System.Drawing.Point(7, 102);
            this.rbInfo.Name = "rbInfo";
            this.rbInfo.Size = new System.Drawing.Size(43, 17);
            this.rbInfo.TabIndex = 3;
            this.rbInfo.TabStop = true;
            this.rbInfo.Text = "Info";
            this.rbInfo.UseVisualStyleBackColor = true;
            // 
            // cmbTag
            // 
            this.cmbTag.FormattingEnabled = true;
            this.cmbTag.Location = new System.Drawing.Point(99, 54);
            this.cmbTag.Name = "cmbTag";
            this.cmbTag.Size = new System.Drawing.Size(138, 21);
            this.cmbTag.TabIndex = 4;
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(99, 82);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(138, 21);
            this.cmbPriority.TabIndex = 5;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(99, 28);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(138, 20);
            this.dateTimePickerDueDate.TabIndex = 6;
            // 
            // tbxStr
            // 
            this.tbxStr.Location = new System.Drawing.Point(7, 126);
            this.tbxStr.Name = "tbxStr";
            this.tbxStr.Size = new System.Drawing.Size(230, 20);
            this.tbxStr.TabIndex = 7;
            this.tbxStr.Text = "find information";
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(288, 29);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(483, 385);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 170);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(230, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxStr;
        private System.Windows.Forms.DateTimePicker dateTimePickerDueDate;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.ComboBox cmbTag;
        private System.Windows.Forms.RadioButton rbInfo;
        private System.Windows.Forms.RadioButton rbPriority;
        private System.Windows.Forms.RadioButton rbTag;
        private System.Windows.Forms.RadioButton rbDueDate;
        private System.Windows.Forms.ListView listView;
    }
}