namespace AnnualLeaveCalculator
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpYearlyAL = new System.Windows.Forms.TabPage();
            this.grpSpecificDates = new System.Windows.Forms.GroupBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.rdbtnSpecificDates = new System.Windows.Forms.RadioButton();
            this.rdbtnWholeYear = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudHoursPerWeek = new System.Windows.Forms.NumericUpDown();
            this.lblHoursPerWeek = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.tpContractChangeAL = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpLeaversAL = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpYearlyAL.SuspendLayout();
            this.grpSpecificDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursPerWeek)).BeginInit();
            this.tpContractChangeAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpLeaversAL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpYearlyAL);
            this.tabControl1.Controls.Add(this.tpContractChangeAL);
            this.tabControl1.Controls.Add(this.tpLeaversAL);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 213);
            this.tabControl1.TabIndex = 0;
            // 
            // tpYearlyAL
            // 
            this.tpYearlyAL.Controls.Add(this.grpSpecificDates);
            this.tpYearlyAL.Controls.Add(this.rdbtnSpecificDates);
            this.tpYearlyAL.Controls.Add(this.rdbtnWholeYear);
            this.tpYearlyAL.Controls.Add(this.btnCalculate);
            this.tpYearlyAL.Controls.Add(this.nudHoursPerWeek);
            this.tpYearlyAL.Controls.Add(this.lblHoursPerWeek);
            this.tpYearlyAL.Controls.Add(this.dtpStartDate);
            this.tpYearlyAL.Controls.Add(this.lblStartDate);
            this.tpYearlyAL.Location = new System.Drawing.Point(4, 22);
            this.tpYearlyAL.Name = "tpYearlyAL";
            this.tpYearlyAL.Padding = new System.Windows.Forms.Padding(3);
            this.tpYearlyAL.Size = new System.Drawing.Size(427, 187);
            this.tpYearlyAL.TabIndex = 0;
            this.tpYearlyAL.Text = "Yearly AL";
            this.tpYearlyAL.UseVisualStyleBackColor = true;
            // 
            // grpSpecificDates
            // 
            this.grpSpecificDates.Controls.Add(this.dtpToDate);
            this.grpSpecificDates.Controls.Add(this.label5);
            this.grpSpecificDates.Controls.Add(this.dtpFromDate);
            this.grpSpecificDates.Controls.Add(this.lblFromDate);
            this.grpSpecificDates.Location = new System.Drawing.Point(3, 114);
            this.grpSpecificDates.Name = "grpSpecificDates";
            this.grpSpecificDates.Size = new System.Drawing.Size(329, 70);
            this.grpSpecificDates.TabIndex = 9;
            this.grpSpecificDates.TabStop = false;
            this.grpSpecificDates.Visible = false;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(68, 37);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 20);
            this.dtpToDate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "From Date:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(68, 10);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFromDate.TabIndex = 10;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(3, 16);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(59, 13);
            this.lblFromDate.TabIndex = 0;
            this.lblFromDate.Text = "From Date:";
            // 
            // rdbtnSpecificDates
            // 
            this.rdbtnSpecificDates.AutoSize = true;
            this.rdbtnSpecificDates.Location = new System.Drawing.Point(11, 96);
            this.rdbtnSpecificDates.Name = "rdbtnSpecificDates";
            this.rdbtnSpecificDates.Size = new System.Drawing.Size(94, 17);
            this.rdbtnSpecificDates.TabIndex = 7;
            this.rdbtnSpecificDates.Text = "Specific Dates";
            this.rdbtnSpecificDates.UseVisualStyleBackColor = true;
            this.rdbtnSpecificDates.CheckedChanged += new System.EventHandler(this.rdbtnSpecificDates_CheckedChanged);
            // 
            // rdbtnWholeYear
            // 
            this.rdbtnWholeYear.AutoSize = true;
            this.rdbtnWholeYear.Checked = true;
            this.rdbtnWholeYear.Location = new System.Drawing.Point(11, 73);
            this.rdbtnWholeYear.Name = "rdbtnWholeYear";
            this.rdbtnWholeYear.Size = new System.Drawing.Size(81, 17);
            this.rdbtnWholeYear.TabIndex = 6;
            this.rdbtnWholeYear.TabStop = true;
            this.rdbtnWholeYear.Text = "Whole Year";
            this.rdbtnWholeYear.UseVisualStyleBackColor = true;
            this.rdbtnWholeYear.CheckedChanged += new System.EventHandler(this.rdbtnWholeYear_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(338, 114);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(86, 44);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudHoursPerWeek
            // 
            this.nudHoursPerWeek.DecimalPlaces = 1;
            this.nudHoursPerWeek.Location = new System.Drawing.Point(103, 43);
            this.nudHoursPerWeek.Name = "nudHoursPerWeek";
            this.nudHoursPerWeek.Size = new System.Drawing.Size(66, 20);
            this.nudHoursPerWeek.TabIndex = 4;
            // 
            // lblHoursPerWeek
            // 
            this.lblHoursPerWeek.AutoSize = true;
            this.lblHoursPerWeek.Location = new System.Drawing.Point(8, 45);
            this.lblHoursPerWeek.Name = "lblHoursPerWeek";
            this.lblHoursPerWeek.Size = new System.Drawing.Size(89, 13);
            this.lblHoursPerWeek.TabIndex = 2;
            this.lblHoursPerWeek.Text = "Hours Per Week:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(72, 11);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 1;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(8, 17);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            // 
            // tpContractChangeAL
            // 
            this.tpContractChangeAL.Controls.Add(this.button3);
            this.tpContractChangeAL.Controls.Add(this.button2);
            this.tpContractChangeAL.Controls.Add(this.button1);
            this.tpContractChangeAL.Controls.Add(this.dataGridView1);
            this.tpContractChangeAL.Location = new System.Drawing.Point(4, 22);
            this.tpContractChangeAL.Name = "tpContractChangeAL";
            this.tpContractChangeAL.Padding = new System.Windows.Forms.Padding(3);
            this.tpContractChangeAL.Size = new System.Drawing.Size(427, 187);
            this.tpContractChangeAL.TabIndex = 2;
            this.tpContractChangeAL.Text = "Contract Change AL";
            this.tpContractChangeAL.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete Contract";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Contract";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 91);
            this.dataGridView1.TabIndex = 1;
            // 
            // tpLeaversAL
            // 
            this.tpLeaversAL.Controls.Add(this.button4);
            this.tpLeaversAL.Controls.Add(this.numericUpDown2);
            this.tpLeaversAL.Controls.Add(this.label4);
            this.tpLeaversAL.Controls.Add(this.dateTimePicker3);
            this.tpLeaversAL.Controls.Add(this.label3);
            this.tpLeaversAL.Controls.Add(this.dateTimePicker2);
            this.tpLeaversAL.Controls.Add(this.label2);
            this.tpLeaversAL.Controls.Add(this.numericUpDown1);
            this.tpLeaversAL.Controls.Add(this.label1);
            this.tpLeaversAL.Location = new System.Drawing.Point(4, 22);
            this.tpLeaversAL.Name = "tpLeaversAL";
            this.tpLeaversAL.Padding = new System.Windows.Forms.Padding(3);
            this.tpLeaversAL.Size = new System.Drawing.Size(427, 187);
            this.tpLeaversAL.TabIndex = 1;
            this.tpLeaversAL.Text = "Leavers AL";
            this.tpLeaversAL.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(328, 119);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 39);
            this.button4.TabIndex = 8;
            this.button4.Text = "Calculate";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 1;
            this.numericUpDown2.Location = new System.Drawing.Point(110, 113);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hours of AL taken:";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(80, 78);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Leave Date:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(72, 42);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(103, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours Per Week:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 213);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Annual Leave Calculator";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmMain_HelpButtonClicked);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpYearlyAL.ResumeLayout(false);
            this.tpYearlyAL.PerformLayout();
            this.grpSpecificDates.ResumeLayout(false);
            this.grpSpecificDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursPerWeek)).EndInit();
            this.tpContractChangeAL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpLeaversAL.ResumeLayout(false);
            this.tpLeaversAL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpYearlyAL;
        private System.Windows.Forms.TabPage tpLeaversAL;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudHoursPerWeek;
        private System.Windows.Forms.Label lblHoursPerWeek;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TabPage tpContractChangeAL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rdbtnSpecificDates;
        private System.Windows.Forms.RadioButton rdbtnWholeYear;
        private System.Windows.Forms.GroupBox grpSpecificDates;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblFromDate;
    }
}

