using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annual_Leave_Calculator
{
    class Long_Service
    {
        //LONG SERVICE
        /*
         * 3 Years = 1 day
         * 4 years = 3 days
         * 5 years = 5 days
         */

        //Work out how much they get on the days by
        //dividing their contractedHoursPerWeek by typicalDaysInAWeek




        //Count full months
        //work out longServicePerMonth by dividing longServiceHoursPerDay by monthsInAYear (12)

        //Find out full months long service for their 10 months so it's longServicePerMonth x FullMonthsTheyWork

        //Find out part month long service by finding they days they will work within that month by minusing the days they are not entitled to from the total days in that month

        //Divide the days they are entitle to by the total days in that month
        //Round that fraction into a decimal

        //Find out part month entitlement by multiplying the rounded decimal by the longServicePerMonth

        //Add the full month and part month entitlement together
        //Subtract the total of above from what they get on the days
        //Remainder is then carried across into the next year


    }
}
