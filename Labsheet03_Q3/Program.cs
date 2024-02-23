using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet03_Q3
{
    internal class Program
    {
        class TemperatureTracker
        {
            private double[] dailyTemperatures;

            public TemperatureTracker(int daysInWeek)
            {
                dailyTemperatures = new double[daysInWeek];
            }

            public void SetTemperature(int day, double temperature)
            {
                if (day >= 0 && day < dailyTemperatures.Length)
                {
                    dailyTemperatures[day] = temperature;
                }
                else
                {
                    Console.WriteLine("Invalid day. Please enter a valid day index.");
                }
            }

            public void DisplayWeeklyReport()
            {
                Console.WriteLine("Weekly Temperature Report:");
                for (int i = 0; i < dailyTemperatures.Length; i++)
                {
                    Console.WriteLine($"Day {i + 1}: {dailyTemperatures[i]}°C");
                }
            }
        }
        static void Main(string[] args)
        {
            TemperatureTracker tracker = new TemperatureTracker(7); 

           
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Enter temperature for Day {i + 1}: ");
                double temperature = Convert.ToDouble(Console.ReadLine());
                tracker.SetTemperature(i, temperature);
            }

           
            tracker.DisplayWeeklyReport();

            Console.ReadLine();
        }
    }
}
