using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifierOOP
{
    public class DateModifier
    {
        public int CalculateDateDifference(string from, string to)
        {
            string[] fromTokens = from.Split(' ');
            string[] toTokens = to.Split(' ');

            var fromDate = new DateTime(int.Parse(fromTokens[0]), int.Parse(fromTokens[1]), int.Parse(fromTokens[2]));
            var toDate = new DateTime(int.Parse(toTokens[0]), int.Parse(toTokens[1]), int.Parse(toTokens[2]));

            int numberOfDays = Math.Abs((fromDate.Date - toDate.Date).Days);

            return numberOfDays;
        }
    }
}
