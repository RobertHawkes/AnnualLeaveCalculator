namespace AnnualLeaveCalculator
{
    partial class frmResult
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
            this.txtResultExplain = new System.Windows.Forms.TextBox();
            this.lblCalculatedAmount = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtResultExplain
            // 
            this.txtResultExplain.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtResultExplain.Location = new System.Drawing.Point(0, 0);
            this.txtResultExplain.Multiline = true;
            this.txtResultExplain.Name = "txtResultExplain";
            this.txtResultExplain.ReadOnly = true;
            this.txtResultExplain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultExplain.Size = new System.Drawing.Size(575, 168);
            this.txtResultExplain.TabIndex = 0;
            // 
            // lblCalculatedAmount
            // 
            this.lblCalculatedAmount.AutoSize = true;
            this.lblCalculatedAmount.Location = new System.Drawing.Point(12, 180);
            this.lblCalculatedAmount.Name = "lblCalculatedAmount";
            this.lblCalculatedAmount.Size = new System.Drawing.Size(99, 13);
            this.lblCalculatedAmount.TabIndex = 1;
            this.lblCalculatedAmount.Text = "Calculated Amount:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(117, 177);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 2;
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 206);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblCalculatedAmount);
            this.Controls.Add(this.txtResultExplain);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResult";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmResult_FormClosing);
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultExplain;
        private System.Windows.Forms.Label lblCalculatedAmount;
        private System.Windows.Forms.TextBox txtResult;
    }
}