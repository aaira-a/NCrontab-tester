using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NCrontab;

namespace NCronTabTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystring = "0 0 6 29 2 1";
            var schedule = CrontabSchedule.Parse(mystring, new CrontabSchedule.ParseOptions { IncludingSeconds = true });
            Console.WriteLine(schedule.GetNextOccurrence(DateTime.UtcNow));
        }
    }
}
