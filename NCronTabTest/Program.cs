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
            while (true) 
            {
                Console.WriteLine("Enter NCronTab expression: \n");
                string myinput = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    GetOccurrences(myinput);
                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to continue...\n");
            }

        }
    
        static void GetOccurrences(string expression)
        {
            var schedule = CrontabSchedule.Parse(expression, new CrontabSchedule.ParseOptions { IncludingSeconds = true });
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
