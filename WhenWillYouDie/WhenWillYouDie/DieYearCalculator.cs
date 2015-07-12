using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhenWillYouDie
{
    public static class DieYearCalculator
    {
        public static int CalculateDyingYear(String name)
        {
            if (name.Any(x => !char.IsLetter(x)))
                throw new ArgumentException("name musst be a name");

            int result = 0;
            foreach (char c in name.ToLower())
            {
                result += c - 'a' + 1;
            }
            return result % 100;
        }
    }
}
