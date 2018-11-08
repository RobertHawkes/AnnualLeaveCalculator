using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnualLeaveCalculator
{
    public class Contract
    {
        //1. Private fields
        static private DateTime _StartDate;
        static private DateTime _EndDate;
        static private DateTime _FromDate;
        static private DateTime _ToDate;
        static private Decimal _HoursPerWeek;
        static private Boolean _HasNoEnd;

        //2. Constructors
        public Contract() { }

        public Contract(DateTime startDate, Decimal hoursPerWeek, Boolean hasNoEnd)
        {
            StartDate = startDate;
            HoursPerWeek = hoursPerWeek;
            HasNoEnd = true;
        }

        public Contract(DateTime startDate, DateTime endDate, Decimal hoursPerWeek)
        {
            StartDate = startDate;
            EndDate = endDate;
            HoursPerWeek = hoursPerWeek;
            HasNoEnd = false;
        }

        public Contract(DateTime startDate, Decimal hoursPerWeek, DateTime fromDate, DateTime toDate, Boolean hasNoEnd)
        {
            StartDate = startDate;
            HoursPerWeek = hoursPerWeek;
            FromDate = fromDate;
            ToDate = toDate;
            HasNoEnd = true;
        }

        static public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        static public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        static public DateTime FromDate
        {
            get { return _FromDate; }
            set { _FromDate = value; }
        }

        static public DateTime ToDate
        {
            get { return _ToDate; }
            set { _ToDate = value; }
        }

        static public Decimal HoursPerWeek
        {
            get { return _HoursPerWeek; }
            set { _HoursPerWeek = value; }
        }

        static public Boolean HasNoEnd
        {
            get { return _HasNoEnd; }
            set { _HasNoEnd = value; }
        }

        public Tuple<Decimal,String> CalculateYearlyAL()
        {
            Decimal FinalValue = 0.0M;
            String Log = "";

            try
            {
                Log += "Beginning of Full Holiday Year Annual Leave calculation" + Environment.NewLine;

                decimal ALPerAnnumUndrounded = 240 * (HoursPerWeek / 40);
                decimal ALPerAnnumRounded = Math.Round(ALPerAnnumUndrounded, 2);

                Log += HoursPerWeek + " hour contract = Entitlement to " + ALPerAnnumRounded + " hours per holiday annum" + Environment.NewLine;

                FinalValue = ALPerAnnumRounded;

                Log += "Therefore the Annual Leave for the total of the holiday year is: " + FinalValue + Environment.NewLine;
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
                Log += "An error occurred during calculation. Error shown to user as: " + ex.Message + Environment.NewLine;
            }

            Log += "End of Full Holiday Year Annual Leave calculation" + Environment.NewLine;
            return Tuple.Create(FinalValue, Log);
        }

        public Tuple<Decimal, String> CalculateRemainingYearlyAL()
        {
            Decimal FinalValue = 0.0M;
            String Log = "";
            DateTime FromDate = DateTime.Now.Date;
            DateTime ToDate = new DateTime();

            try
            {
                Log += "Beginning of Remaining Holiday Year Annual Leave calculation" + Environment.NewLine;

                decimal ALPerAnnumUndrounded = 240 * (HoursPerWeek / 40);
                decimal ALPerAnnumRounded = Math.Round(ALPerAnnumUndrounded, 2);

                Log += HoursPerWeek + " hour contract = Entitlement to " + ALPerAnnumRounded + " hours per annum" + Environment.NewLine;
                Log += "Person starts on " + StartDate.ToShortDateString() + Environment.NewLine;

                //Working out the ToDate
                if (FromDate >= new DateTime(FromDate.Year,4,1))
                {
                    //From Date comes after the 1st April
                    //Therefore end of Holiday year is next year on 31st March
                    ToDate = new DateTime(FromDate.Year + 1, 3, 31);
                }
                else
                {
                    //From Date comes before the 1st April that year
                    //Therefore end of Holiday year is the current year on 31st March
                    ToDate = new DateTime(FromDate.Year, 3, 31);
                }

                if (FromDate != null && ToDate != null)
                {
                    //Counting Full Months
                    int MonthsAway = 0;

                    //Find Annual Leave per month
                    decimal ALPerMonth = ALPerAnnumRounded / 12;

                    if (ToDate.Year > FromDate.Year)
                    {
                        ////Months left in the FromDate Year
                        //int MonthsLeftInStartDateYear = 12 - StartDate.Month;

                        ////Add the months left in the ToDate year
                        //int MonthsLeft = MonthsLeftInStartDateYear + ToDate.Month;

                        //MonthsAway = MonthsLeft;

                        //Log += "Count full months = " + FromDate.ToString("MMMM") + " to " + ToDate.ToString("MMMM") + " = " + MonthsAway + " full months" + Environment.NewLine;
                    }
                    else if (ToDate.Year == FromDate.Year)
                    {
                        MonthsAway = ToDate.Month - StartDate.Month;
                    }

                    Log += "AL Per Month is " + ALPerAnnumRounded + " / 12 = " + ALPerMonth + Environment.NewLine;

                    //Find the amount of Annual Leave acquired for the full months
                    decimal FullMonthsAnnualLeave = MonthsAway * ALPerMonth;

                    Log += "Therefore the full months annual leave is (" + MonthsAway + " * " + ALPerMonth + " = " + FullMonthsAnnualLeave + Environment.NewLine;

                    //Find how many days they will be working in that month
                    decimal DaysWorkingWithinMonth = DateTime.DaysInMonth(FromDate.Year, FromDate.Month) - FromDate.Day;

                    Log += "Person started on the " + StartDate.ToString("DDDD") + " of " + StartDate.ToString("MMMM" + Environment.NewLine);
                    Log += "There is " + DateTime.DaysInMonth(FromDate.Year, FromDate.Month) + " days in that month" + Environment.NewLine;

                    DaysWorkingWithinMonth++;

                    Log += "Meaning they worked " + DaysWorkingWithinMonth + " days in " + FromDate.ToString("MMMM") + Environment.NewLine;

                    //Divide their DaysWorkingWithinMonth by the total of days within that month
                    decimal DaysInStartMonth = DateTime.DaysInMonth(FromDate.Year, FromDate.Month);
                    decimal EntitleToOfMonth = DaysWorkingWithinMonth / DaysInStartMonth;


                    //Round the number
                    decimal EntitleRound = Math.Round(EntitleToOfMonth, 1);

                    Log += "This means they are entitle to (" + DaysWorkingWithinMonth + " / " + DaysInStartMonth + " = " + EntitleRound + " of the month" + Environment.NewLine;
                    //Multiply the Annual Leave per Month and the Entitle Round to get the Annual Leave for partial month
                    decimal AnnualLeaveForPartialMonthUnRound = EntitleRound * ALPerMonth;

                    //Round out the Partial Month value so it's whole hours
                    decimal AnnualLeaveForPartialMonth = Math.Round(AnnualLeaveForPartialMonthUnRound, 0);

                    Log += EntitleRound + " of " + ALPerMonth + " per month = entitled to " + AnnualLeaveForPartialMonth + " in " + FromDate.ToString("MMMM") + " " + FromDate.ToString("YYYY") + Environment.NewLine;

                    //Adding the partial month on to Annual Leave for the months left
                    decimal FullAnnualLeave = AnnualLeaveForPartialMonth + FullMonthsAnnualLeave;

                    Log += "Add the Partial Month value of " + AnnualLeaveForPartialMonth + " to the Full Months Annual Leave value of " + FullMonthsAnnualLeave + " = " + FullAnnualLeave + " hours" + Environment.NewLine;

                    FinalValue = FullAnnualLeave;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
                Log += "An error occurred during calculation. Error shown to user as: " + ex.Message + Environment.NewLine;
            }

            Log += "End of Partial Holiday Year Annual Leave calculation" + Environment.NewLine;
            return Tuple.Create(FinalValue, Log);
        }

        public Tuple<Decimal, String> CalculatePartYearlyAL()
        {
            Decimal FinalValue = 0.0M;
            String Log = "";

            try
            {
                Log += "Beginning of Partial Holiday Year Annual Leave calculation" + Environment.NewLine;

                decimal ALPerAnnumUndrounded = 240 * (HoursPerWeek / 40);
                decimal ALPerAnnumRounded = Math.Round(ALPerAnnumUndrounded, 2);

                Log += HoursPerWeek + " hour contract = Entitlement to " + ALPerAnnumRounded + " hours per annum" + Environment.NewLine;
                Log += "Person starts on " + StartDate.ToShortDateString() + Environment.NewLine;

                if (FromDate != null && ToDate != null)
                {
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

                    Log += "AL Per Month is " + ALPerAnnumRounded + " / 12 = " + ALPerMonth + Environment.NewLine;

                    //Find the amount of Annual Leave acquired for the full months
                    decimal FullMonthsAnnualLeave = MonthsAway * ALPerMonth;

                    Log += "Therefore the full months annual leave is (" + MonthsAway + " * " + ALPerMonth + " = " + FullMonthsAnnualLeave + Environment.NewLine;

                    //Find how many days they will be working in that month
                    decimal DaysWorkingWithinMonth = DateTime.DaysInMonth(FromDate.Year, FromDate.Month) - FromDate.Day;

                    Log += "Person started on the " + StartDate.ToString("DDDD") + " of " + StartDate.ToString("MMMM" + Environment.NewLine);
                    Log += "There is " + DateTime.DaysInMonth(FromDate.Year, FromDate.Month) + " days in that month" + Environment.NewLine;

                    DaysWorkingWithinMonth++;

                    Log += "Meaning they worked " + DaysWorkingWithinMonth + " days in " + FromDate.ToString("MMMM") + Environment.NewLine;

                    //Divide their DaysWorkingWithinMonth by the total of days within that month
                    decimal DaysInStartMonth = DateTime.DaysInMonth(FromDate.Year, FromDate.Month);
                    decimal EntitleToOfMonth = DaysWorkingWithinMonth / DaysInStartMonth;


                    //Round the number
                    decimal EntitleRound = Math.Round(EntitleToOfMonth, 1);

                    Log += "This means they are entitle to (" + DaysWorkingWithinMonth + " / " + DaysInStartMonth + " = " + EntitleRound + " of the month" + Environment.NewLine;
                    //Multiply the Annual Leave per Month and the Entitle Round to get the Annual Leave for partial month
                    decimal AnnualLeaveForPartialMonthUnRound = EntitleRound * ALPerMonth;

                    //Round out the Partial Month value so it's whole hours
                    decimal AnnualLeaveForPartialMonth = Math.Round(AnnualLeaveForPartialMonthUnRound, 0);

                    Log += EntitleRound + " of " + ALPerMonth + " per month = entitled to " + AnnualLeaveForPartialMonth + " in " + FromDate.ToString("MMMM") + " " + FromDate.ToString("YYYY") + Environment.NewLine;

                    //Adding the partial month on to Annual Leave for the months left
                    decimal FullAnnualLeave = AnnualLeaveForPartialMonth + FullMonthsAnnualLeave;

                    Log += "Add the Partial Month value of " + AnnualLeaveForPartialMonth + " to the Full Months Annual Leave value of " + FullMonthsAnnualLeave + " = " + FullAnnualLeave + " hours" + Environment.NewLine;

                    FinalValue = FullAnnualLeave;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
                Log += "An error occurred during calculation. Error shown to user as: " + ex.Message + Environment.NewLine;
            }

            Log += "End of Partial Holiday Year Annual Leave calculation" + Environment.NewLine;
            return Tuple.Create(FinalValue, Log);
        }

        private Tuple<Decimal,String> CalculateFullLS()
        {
            Decimal FinalValue = 0.0M;
            String Log = "";
            DateTime StartOfHolYear = new DateTime();
            DateTime EndOfHolYear = new DateTime();

            try
            {
                //Log += "Beginning of Long Service calculation" + Environment.NewLine;

                //Log += "Person starts on " + StartDate.ToShortDateString() + Environment.NewLine;

                //if (DateTime.Now >)
                //{

                //}
                //int YearsAsEmployee = StartOfHolYear.Year - StartDate.Year;

                //Log += "Which means that the person has been an employee for " + YearsAsEmployee + " years" + Environment.NewLine;

                //int DaysOfLSEntitlement = 0;
                //int YearsofLS = 0;

                //if (YearsAsEmployee == 3)
                //{
                //    DaysOfLSEntitlement = 1;
                //    YearsofLS = 3;
                //}
                //else if (YearsAsEmployee == 4)
                //{
                //    DaysOfLSEntitlement = 3;
                //    YearsofLS = 4;
                //}
                //else if (YearsAsEmployee >= 5)
                //{
                //    DaysOfLSEntitlement = 5;
                //    YearsofLS = 5;
                //}

                //if (DaysOfLSEntitlement != 0)
                //{
                //    Log += "meaning that the employee will gain " + DaysOfLSEntitlement + " days due to Long Service" + Environment.NewLine;

                //    FinalValue = (DaysOfLSEntitlement * (HoursPerWeek / 5));

                //    Log += "This gives the employee an additional " + FinalValue + " hours due to Long Service" + Environment.NewLine;
                //}
                //else
                //{
                //    Log += "meaning that the employee does not gain any additional hours due to long service" + Environment.NewLine;

                //    FinalValue = 0.0M;
                //}
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }

            Log += "End of Full Holiday Year Long Service calculation" + Environment.NewLine;
            return Tuple.Create(FinalValue, Log);
        }

        private Tuple<Decimal, String> CalculateLS()
        {
            Decimal FinalValue = 0.0M;
            String Log = "";

            try
            {
                Log += "Beginning of Long Service calculation" + Environment.NewLine;

                Log += "Person starts on " + StartDate.ToShortDateString() + Environment.NewLine;
                int YearsAsEmployee = DateTime.Now.Year - StartDate.Year;
                Log += "Which means that the person has been an employee for " + YearsAsEmployee + " years" + Environment.NewLine;

                int DaysOfLSEntitlement = 0;
                int YearsofLS = 0;

                if (YearsAsEmployee == 3)
                {
                    DaysOfLSEntitlement = 1;
                    YearsofLS = 3;
                }
                else if (YearsAsEmployee == 4)
                {
                    DaysOfLSEntitlement = 3;
                    YearsofLS = 4;
                }
                else if (YearsAsEmployee >= 5)
                {
                    DaysOfLSEntitlement = 5;
                    YearsofLS = 5;
                }

                Log += "meaning that the employee will gain " + DaysOfLSEntitlement + " days due to Long Service" + Environment.NewLine;

                if (DaysOfLSEntitlement != 0)
                {
                    decimal LSCarryOverValue = 0.0M;

                    //Going to work out each year carry over LS value
                    for (int i = 3; i < YearsofLS; i++)
                    {
                        decimal LSEarnedPerDay = DaysOfLSEntitlement * (HoursPerWeek / 5);

                        if (new DateTime(DateTime.Now.Year,StartDate.Month,StartDate.Day) <= new DateTime(DateTime.Now.Year, 03, 31))
                        {
                            Log += "The equivalent start day and start month this year is before or on the end of the holiday year" + Environment.NewLine;

                            DateTime StartDateThisYear = new DateTime(DateTime.Now.Year, StartDate.Month, StartDate.Day);
                            DateTime EndOfHolidayYear = new DateTime(DateTime.Now.Year, 03, 31);

                            //No of Days between 31st March and Start Date
                            TimeSpan Difference = EndOfHolidayYear - StartDateThisYear;
                            int NoOfDaysDifference = Difference.Days;

                            decimal LongService = NoOfDaysDifference * LSEarnedPerDay;
                        }
                        else
                        {
                            Log += "The equivalent start day and start month this year has came after the end of the holiday year. We need to take Long Service from 1st April through until 31st March next year" + Environment.NewLine;
                        }
                    }
                }
                else
                {
                    Log += "The years as an employee does not qualify for this person to have Long Service. Therefore they don't receive any additional hours" + Environment.NewLine;
                }



                Log += "End of Long Service calculation" + Environment.NewLine;
                Log += Environment.NewLine + Environment.NewLine;
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }
            return Tuple.Create(FinalValue, Log);
        }

        private Tuple<Decimal,String> CalculateTotal()
        {
            Decimal FinalValue = 0.0M;
            Decimal ALValue = 0.0M;
            Decimal LSValue = 0.0M;
            String Log = "";

            try
            {
                //FinalValue += ALValue += CalculateAL().Item1;
                //Log += CalculateAL().Item2;

                //FinalValue += CalculateLS().Item1;
                //Log += CalculateLS().Item2;

                //Log += "Therefore the person will receive " + ALValue + " Annual Leave hours from " + FromDate.ToShortDateString() + " to " + ToDate.ToShortDateString() + Environment.NewLine;
                //Log += "As well as " + LSValue + " Long Service hours" + Environment.NewLine;
                //Log += "Which makes the total hours = " + FinalValue + Environment.NewLine;
            }
            catch (Exception ex)
            {
                ExceptionHandler.ThrowException(ex);
            }

            return Tuple.Create(FinalValue, Log);
        }
    }
}
