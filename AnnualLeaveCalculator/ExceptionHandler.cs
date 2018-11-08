using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnnualLeaveCalculator
{
    class ExceptionHandler
    {
        //No fields/Constructors needed

        //Methods
        static public void ThrowException(Exception ex)
        {
            //Show a MessageBox containing all of the Exception info
            MessageBox.Show("An exception occurred: " + ex.Message, "Exception occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
