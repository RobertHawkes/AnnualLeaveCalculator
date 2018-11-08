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
    public partial class frmMain : Form
    {
        String Log = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Get todays DateTime
            DateTime DateNow = DateTime.Now;

            //Test if todays DateTime is passed the 1st of April (Beginning of Holiday Year)
            if (DateNow > new DateTime(DateTime.Now.Year,3,31))
            {
                //Todays date is passed 1st April
                //Set the ToDate value to be 1st April next year
                dtpToDate.Value = new DateTime(DateTime.Now.Year + 1, 3, 31);
            }
        }

        private void frmMain_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            try
            {
                MessageBox.Show("Help button clicked!");
                e.Cancel = true;
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Get the values entered by the user
                DateTime StartDate = dtpStartDate.Value.Date;
                decimal HoursPerWeek = nudHoursPerWeek.Value;
                decimal ALPerAnnumUndrounded = 240 * (HoursPerWeek / 40);
                decimal ALPerAnnumRounded = Math.Round(ALPerAnnumUndrounded, 2);
                decimal FinalValue = 0.00M;

                Contract newContract = new Contract(StartDate, HoursPerWeek, true);

                newContract.CalculateRemainingYearlyAL();

                //Logging values entered by the user
                Log += HoursPerWeek + " hour contract = Entitlement to " + ALPerAnnumRounded + " hours per annum" + Environment.NewLine;
                Log += "Person starts on " + StartDate.ToShortDateString() + Environment.NewLine;


                //Check what Radio button is selected and change mode based on it
                if (rdbtnWholeYear.Checked)
                {
                    decimal LongService = CalculateLS(StartDate, HoursPerWeek);
                    FinalValue = ALPerAnnumRounded + LongService;
                    Log += "Therefore the final Annual Leave value is (" + ALPerAnnumRounded + " + " + LongService + ") = " + FinalValue + " hours";
                }
                else if (rdbtnSpecificDates.Checked)
                {
                    DateTime FromDate = dtpFromDate.Value;
                    DateTime ToDate = dtpToDate.Value;

                    //Counting Full Months
                    int MonthsAway = 0;

                    //Find Annual Leave per month
                    decimal ALPerMonth = ALPerAnnumRounded / 12;

                    if (ToDate.Year > FromDate.Year)
                    {
                        //Months left in the FromDate Year
                        int MonthsLeftInStartDateYear = 12 - StartDate.Month;

                        //Add the months left in the ToDate year
                        int MonthsLeft = MonthsLeftInStartDateYear + ToDate.Month;

                        MonthsAway = MonthsLeft;

                        Log += "Count full months = " + FromDate.ToString("MMMM") + " to " + ToDate.ToString("MMMM") + " = " + MonthsAway + " full months" + Environment.NewLine;
                    }
                    else if (ToDate.Year == FromDate.Year)
                    {
                        MonthsAway = ToDate.Month - StartDate.Month;
                    }

                    Log += "AL Per Annum is " + ALPerAnnumRounded + " / 12 = " + ALPerMonth + Environment.NewLine;
                    //Find the amount of Annual Leave acquired for the full months
                    decimal FullMonthsAnnualLeave = MonthsAway * ALPerMonth;

                    
                    
                    //Find how many days they will be working in that month
                    decimal DaysWorkingWithinMonth = DateTime.DaysInMonth(FromDate.Year, FromDate.Month) - FromDate.Day;

                    DaysWorkingWithinMonth++;

                    //Divide their DaysWorkingWithinMonth by the total of days within that month
                    decimal DaysInStartMonth = DateTime.DaysInMonth(FromDate.Year, FromDate.Month);
                    decimal EntitleToOfMonth = DaysWorkingWithinMonth / DaysInStartMonth;

                    //Round the number
                    decimal EntitleRound = Math.Round(EntitleToOfMonth, 1);


                    //Multiply the Annual Leave per Month and the Entitle Round to get the Annual Leave for partial month
                    decimal AnnualLeaveForPartialMonthUnRound = EntitleRound * ALPerMonth;

                    //Round out the Partial Month value so it's whole hours
                    decimal AnnualLeaveForPartialMonth = Math.Round(AnnualLeaveForPartialMonthUnRound, 0);

                    //Adding the partial month on to Annual Leave for the months left
                    decimal FullAnnualLeave = AnnualLeaveForPartialMonth + FullMonthsAnnualLeave;

                    //Calculation done!
                    //Add Long Service through the CalculateLS method
                    decimal LongService = CalculateLS(StartDate, HoursPerWeek);
                    FinalValue = FullAnnualLeave + LongService;

                    Log += "Therefore the final Annual Leave value is (" + FullAnnualLeave + " + " + LongService + ") = " + FinalValue + " hours";
                }

                
                //We have now calculated the Final Value. Time to open the Result form and show the log and result to the user
                FormHandler.OpenResultForm(Log, FinalValue);

                ClearLog();
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }
        }

        private decimal CalculateLS(DateTime StartDate, decimal HoursPerWeek)
        {
            decimal LongService = 0.0M;
            decimal HoursPerDay = HoursPerWeek / 5;
            try
            {
                if (DateTime.Now.Year - StartDate.Year >= 3)
                {
                    Log += "Persons start year is " + StartDate.Year + " which means (" + DateTime.Now.Year + " - " + StartDate.Year + ") = " + (DateTime.Now.Year - StartDate.Year) + " years as an employee" + Environment.NewLine;
                    Log += "Persons hours per week is " + HoursPerWeek + " which means (" + HoursPerWeek + " / " + "5) = " + HoursPerDay + " hours per day" + Environment.NewLine;

                    //Long service has been detected
                    //Check if Long Service is more than 3 years
                    if (DateTime.Now.Year - StartDate.Year >= 4)
                    {
                        //Long service is longer than 3 years
                        //Check if long service is longer than 4 years
                        if (DateTime.Now.Year - StartDate.Year >= 5)
                        {
                            //Long service is 5 years or longer therefore 5 Days
                            LongService += (HoursPerDay * 5);
                            Log += "Long service for 5 years therefore 5 days of Annual Leave added which is (" + HoursPerDay + " * 5) = " + LongService + " long service hours added" + Environment.NewLine;
                        }
                        else
                        {
                            //Long service is for 4 years therefore 3 Days
                            LongService += (HoursPerDay * 3);
                            Log += "Long service for 4 years therefore 3 days of Annual Leave added which is (" + HoursPerDay + " * 3) = " + LongService + " long service hours added" + Environment.NewLine;
                        }
                    }
                    else
                    {
                        //Long service is for 3 years therefore 1 Day
                        LongService += HoursPerDay;
                        Log += "Long service for 3 years therefore 1 day of Annual Leave added which is (" + HoursPerDay + " * 1) = " + LongService + " long service hours added" + Environment.NewLine;

                    }
                }
                else
                {
                    Log += "No long service has been added as todays year " + DateTime.Now.Year + " minus their start date year which is " + StartDate.Year + " = " + (DateTime.Now.Year - StartDate.Year) + " years" + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }

            return LongService;
        }

        private void rdbtnFromNowUntil_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Check that From Now Until has been selected (And not just unchecked through selection of another)
                if (rdbtnSpecificDates.Checked)
                {
                    grpSpecificDates.Visible = true;

                    if (dtpStartDate.Value.Year == DateTime.Now.Year)
                    {
                        dtpFromDate.Value = dtpStartDate.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }
        }

        private void rdbtnWholeYear_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Check that Whole Year has been selected (And not just unchecked through selection of another)
                if (rdbtnWholeYear.Checked)
                {
                    grpSpecificDates.Visible = false;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }
        }

        private void ClearLog()
        {
            Log = "";
        }

        private void rdbtnSpecificDates_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Check that From Now Until has been selected (And not just unchecked through selection of another)
                if (rdbtnSpecificDates.Checked)
                {
                    grpSpecificDates.Visible = true;

                    if (dtpStartDate.Value.Year == DateTime.Now.Year)
                    {
                        dtpFromDate.Value = dtpStartDate.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }
        }
    }
}
