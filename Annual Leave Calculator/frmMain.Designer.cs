namespace Annual_Leave_Calculator
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
            this.numHoursPerWeek = new System.Windows.Forms.NumericUpDown();
            this.lblHoursPerWeek = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.rdoSimple = new System.Windows.Forms.RadioButton();
            this.rdoPartYear = new System.Windows.Forms.RadioButton();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numHoursPerWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // numHoursPerWeek
            // 
            this.numHoursPerWeek.Location = new System.Drawing.Point(139, 10);
            this.numHoursPerWeek.Name = "numHoursPerWeek";
            this.numHoursPerWeek.Size = new System.Drawing.Size(205, 20);
            this.numHoursPerWeek.TabIndex = 4;
            this.numHoursPerWeek.ThousandsSeparator = true;
            this.numHoursPerWeek.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // lblHoursPerWeek
            // 
            this.lblHoursPerWeek.AutoSize = true;
            this.lblHoursPerWeek.Location = new System.Drawing.Point(9, 12);
            this.lblHoursPerWeek.Name = "lblHoursPerWeek";
            this.lblHoursPerWeek.Size = new System.Drawing.Size(86, 13);
            this.lblHoursPerWeek.TabIndex = 5;
            this.lblHoursPerWeek.Text = "Hours Per Week";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(9, 46);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(134, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(205, 44);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(139, 40);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(205, 20);
            this.dateStart.TabIndex = 13;
            // 
            // rdoSimple
            // 
            this.rdoSimple.AutoSize = true;
            this.rdoSimple.Checked = true;
            this.rdoSimple.Location = new System.Drawing.Point(370, 13);
            this.rdoSimple.Name = "rdoSimple";
            this.rdoSimple.Size = new System.Drawing.Size(155, 17);
            this.rdoSimple.TabIndex = 15;
            this.rdoSimple.TabStop = true;
            this.rdoSimple.Text = "Simple Per Year Calculation";
            this.rdoSimple.UseVisualStyleBackColor = true;
            this.rdoSimple.CheckedChanged += new System.EventHandler(this.rdoSimple_CheckedChanged);
            // 
            // rdoPartYear
            // 
            this.rdoPartYear.AutoSize = true;
            this.rdoPartYear.Location = new System.Drawing.Point(370, 36);
            this.rdoPartYear.Name = "rdoPartYear";
            this.rdoPartYear.Size = new System.Drawing.Size(129, 17);
            this.rdoPartYear.TabIndex = 16;
            this.rdoPartYear.TabStop = true;
            this.rdoPartYear.Text = "Part-Year Calculations";
            this.rdoPartYear.UseVisualStyleBackColor = true;
            this.rdoPartYear.CheckedChanged += new System.EventHandler(this.rdo_CheckedChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(9, 75);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 22;
            this.lblEndDate.Text = "End Date";
            this.lblEndDate.Visible = false;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(139, 69);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(205, 20);
            this.dateEnd.TabIndex = 23;
            this.dateEnd.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 271);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.rdoPartYear);
            this.Controls.Add(this.rdoSimple);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblHoursPerWeek);
            this.Controls.Add(this.numHoursPerWeek);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHoursPerWeek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numHoursPerWeek;
        private System.Windows.Forms.Label lblHoursPerWeek;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.RadioButton rdoSimple;
        private System.Windows.Forms.RadioButton rdoPartYear;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateEnd;
    }
}