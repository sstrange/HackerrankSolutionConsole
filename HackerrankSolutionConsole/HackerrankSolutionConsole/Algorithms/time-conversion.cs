using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerrankSolutionConsole
{
    class time_conversion : Challenge
    {
        public override void Main(string[] args)
        {
            string time = Console.ReadLine();
            DateTime date = DateTime.ParseExact(time, "hh:mm:sstt", System.Globalization.CultureInfo.CurrentCulture);
            Console.WriteLine(date.ToString("HH:mm:ss"));
        }
        public time_conversion()
        {
            Name = "Time Conversion";
            Path = "time-conversion";
            Difficulty = Difficulty.Easy;
            Domain = Domain.Algorithms;
            Subdomain = Subdomain.Warmup;
        }
    }

}