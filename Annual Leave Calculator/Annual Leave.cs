using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annual_Leave_Calculator
{
    public static class Annual_Leave
    {
        //Private fields
        //CONSTANTS
        const int totalHoursPerHolidayYear = 240;
        const int typicalHours = 40;
        const int typicalDaysInAWeek = 5;
        const int monthsInAYear = 12;
        //USER DEFINED
        static int fullMonthsTheyWillWork = 0; //Can be anything from 1 to 12. 
        static int maxDaysInTheJoiningMonth = 0; //Will be either 30 or 31 (27 on a leap year if it's Febuary)
        static int daysTheyDontWorkInTheJoiningMonth = 0; //Can be anything from 1 to max days in that month - 1  
        static int contractedHoursPerWeek = 0; //Can be anything, typically 40. Inserted by user on GUI
        //CALCULATED VALUES
        static decimal hoursPerAnnumInFullYear = totalHoursPerHolidayYear * contractedHoursPerWeek / 40;
        static decimal hoursPerMonth = hoursPerAnnumInFullYear /12;
        static decimal fullMonthsEntitlement = hoursPerMonth * fullMonthsTheyWillWork;
        static int daysTheyDoWorkInTheJoiningMonth = maxDaysInTheJoiningMonth - daysTheyDontWorkInTheJoiningMonth;
        static decimal fractionOfTheMonthTheyAreEntitleTo = daysTheyDoWorkInTheJoiningMonth / maxDaysInTheJoiningMonth;
        static decimal roundedDecimalOfTheMonthTheyAreEntitleTo = Math.Round(fractionOfTheMonthTheyAreEntitleTo, 1);
        static decimal partMonthAnnualEntitlement = roundedDecimalOfTheMonthTheyAreEntitleTo * hoursPerMonth;
        static decimal totalAnnualLeave = partMonthAnnualEntitlement + fullMonthsEntitlement;

        //Public Facing Properties

        public static int ContractedHoursPerWeek
        {
            //Returns the private field
            get { return contractedHoursPerWeek; }
            //Sets the private field to the value entered when calling the public property
            set { contractedHoursPerWeek = value; }
        }

        public static int DaysTheyDontWorkInTheJoiningMonth
        {
            get { return daysTheyDontWorkInTheJoiningMonth; }
            set { daysTheyDontWorkInTheJoiningMonth = value; }
        }

        public static int FullMonthsTheyWillWork
        {
            get { return fullMonthsTheyWillWork; }
            set { fullMonthsTheyWillWork = value; }
        }

        public static int MaxDaysInTheJoiningMonth
        {
            get { return maxDaysInTheJoiningMonth; }
            set { maxDaysInTheJoiningMonth = value; }
        }


        //Calculations
        //To find hours per annum in a full year
        //totalHoursPerHolidayYear x contractedHoursPerWeek / 40
        //To find hours per month take total hours per holiday year and divide by 12
        //To find full months entitlement times hours per month by number of months
        //To find the hours when they start half way through a month
        //Calculate days they did work by Total days in month - total days they didn't work
        //Use days they did work and divide by total days in month
        //Round it to 1 decimal place
        //Times the rounded decimal by hoursPerMonth ("Part month entitlement")
        //Add the full months entitilement and the Part month entitlement
    }
}
