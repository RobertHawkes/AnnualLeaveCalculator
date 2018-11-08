using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnnualLeaveCalculator
{
    public partial class frmResult : Form
    {
        static private String _Log = "";
        static private decimal _FinalValue = 0.0M;

        public frmResult(String Log, decimal FinalValue)
        {
            InitializeComponent();
            _Log = Log;
            _FinalValue = FinalValue;
        }

        private void frmResult_Load(object sender, EventArgs e)
        {
            try
            {
                txtResultExplain.Text = _Log;
                txtResult.Text = _FinalValue.ToString() + " Hours";
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }
        }

        private void frmResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FormHandler.CloseResultForm();
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }
        }
    }
}
