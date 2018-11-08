using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnnualLeaveCalculator
{
    class FormHandler
    {
        //1. Private Fields

        static private frmMain _MainForm;

        static private frmResult _ResultForm;

        static private frmNewContract _NewContractForm;

        static private bool _MainFormOpen = true;

        static private bool _ResultFormOpen = false;

        static private bool _NewContractFormOpen = false;

        //2. Public Properties

        static public frmMain MainForm
        {
            get { return _MainForm; }
            set { _MainForm = value; }
        }

        static public frmResult ResultForm
        {
            get { return _ResultForm; }
            set { _ResultForm = value; }
        }

        static public frmNewContract NewContractForm
        {
            get { return _NewContractForm; }
            set { _NewContractForm = value; }
        }

        static public bool MainFormOpen
        {
            get { return _MainFormOpen; }
            set { _MainFormOpen = value; }
        }

        static public bool ResultFormOpen
        {
            get { return _ResultFormOpen; }
            set { _ResultFormOpen = value; }
        }

        static public bool NewContractFormOpen
        {
            get { return _NewContractFormOpen; }
            set { _NewContractFormOpen = value; }
        }


        //3. Methods

        static public void OpenResultForm(String Log, Decimal Value)
        {
            try
            {
                //Test if the form the user is wanting to open is not already open
                if (!ResultFormOpen)
                {
                    //Isn't already open
                    //Instantiate a new object of type frmResult and assign it to the ResultForm property
                    ResultForm = new frmResult(Log,Value);
                    //Show the new Result form to the user
                    ResultForm.Show();
                    //Set the Result Form Open boolean to true to avoid duplicate windows
                    ResultFormOpen = true;
                }
                else
                {
                    //Is already open
                    //Tell user it's already open
                    MessageBox.Show("A result screen is already open. Please close the existing result screen.", "Result screen already open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Bring the form they requested to the front of any other form
                    BringFormToFront(ResultForm);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }
        }

        static public void CloseResultForm()
        {
            try
            {
                //Test if the form the user is wanting to close is open
                if (ResultFormOpen)
                {
                    //Form is open
                    //Dispose of the form
                    ResultForm.Dispose();
                    //Set the Result Form Open boolean to false to ensure opening of the form again
                    ResultFormOpen = false;
                }
                else
                {
                    //Form is already closed
                    MessageBox.Show("The Result screen is already closed!", "Result screen already closed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }
        }

        static public void OpenNewContractForm()
        {
            try
            {
                //Test if the form the user is wanting to open is not already open
                if (!NewContractFormOpen)
                {
                    //Isn't already open
                    //Instantiate a new object of type frmNewContract and assign it to the NewContractForm property
                    NewContractForm = new frmNewContract();
                    //Show the new NewContract form to the user
                    NewContractForm.Show();
                    //Set the NewContract Form Open boolean to true to avoid duplicate windows
                    NewContractFormOpen = true;
                }
                else
                {
                    //Is already open
                    //Tell user it's already open
                    MessageBox.Show("A Add New Contract screen is already open. Please close the existing Add New Contract screen.", "Add New Contract screen already open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Bring the form they requested to the front of any other form
                    BringFormToFront(NewContractForm);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }
        }

        static public void CloseNewContractForm()
        {
            try
            {
                //Test if the form the user is wanting to close is open
                if (NewContractFormOpen)
                {
                    //Form is open
                    //Dispose of the form
                    NewContractForm.Dispose();
                    //Set the NewContract Form Open boolean to false to ensure opening of the form again
                    NewContractFormOpen = false;
                }
                else
                {
                    //Form is already closed
                    MessageBox.Show("The Add New Contract screen is already closed!", "Add New Contract screen already closed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }
        }

        static private void BringFormToFront(Form FrontForm)
        {
            //This method allows the functionality of brining an already existing form to the front of the screen
            //which allows it to be more interactive to the user since they requested a form that is open
            //so there is no point duplicating the form.
            try
            {
                //Test if the form is Minimized
                if (FrontForm.WindowState == FormWindowState.Minimized)
                {
                    //If form minimized, make it normal
                    FrontForm.WindowState = FormWindowState.Normal;
                }
                else
                {
                    //If form is not minimized, make it TopMost (Has priority over other forms)
                    FrontForm.TopMost = true;
                    //Focus on the form
                    FrontForm.Focus();
                    //Bring the form to the front
                    FrontForm.BringToFront();
                    //make TopMost property false so it's not obtrusive to the user since it forces itself to the top
                    FrontForm.TopMost = false;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }
        }
    }
}
