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
            var occurrences = schedule.GetNextOccurrences(DateTime.UtcNow, DateTime.UtcNow.AddYears(50));


            if (occurrences.Count() > 10) 
            {
                for (int i = 0; i < 10; i++ )
                {
                    Console.WriteLine(occurrences.ElementAt(i).ToString());
                }
            }

            else
            {
                foreach (DateTime occurrence in occurrences) 
                {
                    Console.WriteLine(occurrence.ToString());
                }
            }
        }
    }
}
