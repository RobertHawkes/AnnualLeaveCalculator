using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Annual_Leave_Calculator
{
    public partial class frmMain : Form
    {
        //Global variables for this class/form
        decimal HoursPerWeek = 0;
        decimal AnnualLeaveEntitlementPerYear = 0.0M;
        decimal AnnualLeavePerMonth = 0.0M;
        decimal FullMonthsAnnualLeave = 0.0M;
        DateTime SystemDate = DateTime.Now;
        int MonthsAway = 0;
        DateTime StartDate = new DateTime();
        DateTime EndDate = new DateTime();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declaring and initializing the variables in which the values will be held
            HoursPerWeek = numHoursPerWeek.Value;
            StartDate = dateStart.Value;
            EndDate = dateEnd.Value;

            if (rdoSimple.Checked)
            {
                //Working out the annual leave entitlement
                AnnualLeaveEntitlementPerYear = 240 * (HoursPerWeek / 40);

                CheckLongService(AnnualLeaveEntitlementPerYear);
            }
            else if (rdoPartYear.Checked)
            {
                //Working out normal annual leave entitlement
                AnnualLeaveEntitlementPerYear = 240 * (HoursPerWeek / 40);

                //Find Annual Leave per month
                AnnualLeavePerMonth = AnnualLeaveEntitlementPerYear / 12;

                if (EndDate.Year > StartDate.Year)
                {
                    //Months left in the StartDate Year
                    int MonthsLeftInStartDateYear = 12 - StartDate.Month;

                    //Add the months left in the end date year
                    int MonthsLeft = MonthsLeftInStartDateYear + EndDate.Month;

                    MonthsAway = MonthsLeft;
                }
                else if (EndDate.Year == StartDate.Year)
                {
                    MonthsAway = EndDate.Month - StartDate.Month;
                }

                //Find the amount of Annual Leave acquired for the full months
                FullMonthsAnnualLeave = MonthsAway * AnnualLeavePerMonth;

                //Finding the DateTime variables of the Date controls
                StartDate = dateStart.Value;
                EndDate = dateEnd.Value;

                //Find how many days they will be working in that month
                decimal DaysWorkingWithinMonth = DateTime.DaysInMonth(StartDate.Year, StartDate.Month) - StartDate.Day;

                DaysWorkingWithinMonth++;

                //Divide their DaysWorkingWithinMonth by the total of days within that month
                decimal DaysInStartMonth = DateTime.DaysInMonth(StartDate.Year, StartDate.Month);
                decimal EntitleToOfMonth = DaysWorkingWithinMonth / DaysInStartMonth;

                //Round the number
                decimal EntitleRound = Math.Round(EntitleToOfMonth, 1);


                //Multiply the Annual Leave per Month and the Entitle Round to get the Annual Leave for partial month
                decimal AnnualLeaveForPartialMonthUnRound = EntitleRound * AnnualLeavePerMonth;

                //Round out the Partial Month value so it's whole hours
                decimal AnnualLeaveForPartialMonth = Math.Round(AnnualLeaveForPartialMonthUnRound, 0);

                //Adding the partial month on to Annual Leave for the months left
                decimal FullAnnualLeave = AnnualLeaveForPartialMonth + FullMonthsAnnualLeave;

                //Calculation done! Sending to check for long service
                CheckLongService(FullAnnualLeave);
            }
        }

        private void CheckLongService(decimal CurrentAnnualLeaveWithoutLongService)
        {
            if (SystemDate.Year - StartDate.Year > 3)
            {
                //Long service has been detected
                //Check if Long Service is more than 3 years
                if (SystemDate.Year - StartDate.Year > 4)
                {
                    //Long service is longer than 3 years
                    //Check if long service is longer than 4 years
                    if (SystemDate.Year - StartDate.Year > 5)
                    {
                        //Long service is longer than 4 years
                    }
                }
                else
                {
                    //Long service is for 3 years

                }
            }
            else
            {
                //No long service detected
                //Output Annual Leave
                MessageBox.Show("This pesons Annual Leave entitlement is: " + CurrentAnnualLeaveWithoutLongService + " Hours");
            }
        }

        private void rdoSimple_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSimple.Checked)
            {
                lblEndDate.Visible = false;
                dateEnd.Visible = false;
            }
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPartYear.Checked)
            {
                lblEndDate.Visible = true;
                dateEnd.Visible = true;
            }
            else if (!rdoPartYear.Checked)
            {
                lblEndDate.Visible = false;
                dateEnd.Visible = false;
            }
        }

        /*
         * 
         * 
         * 
         * For 1 day in Long Service take HoursPerWeek / 5 then + the AnnualLeaveEntitlement
         * 
         * 
         */

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}