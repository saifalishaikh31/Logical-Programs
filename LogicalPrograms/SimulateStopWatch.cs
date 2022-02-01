using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalPrograms
{
    class SimulateStopWatch
    {
        public void StopWatch()
        {

            int startTimeMilliseconds = 0, startTimeSeconds = 0, startTimeMinutes = 0, startTimeHours = 0; 
            int endTimeMilliseconds = 0, endTimeSeconds = 0, endTimeMinutes = 0, endTimeHours = 0;
            int elapsedMilliseconds = 0, elapsedSeconds = 0, elapsedMinutes = 0, elapsedHours = 0;
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter 1 to Start Stopwatch"
                                 +"\nEnter 2 to Stop Stopwatch");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nStopwatch has Started!");
                        DateTime dtStart = DateTime.Now;
                        startTimeMilliseconds = dtStart.Millisecond;
                        startTimeSeconds = dtStart.Second;
                        startTimeMinutes = dtStart.Minute;
                        startTimeHours = dtStart.Hour;
                        Console.WriteLine("\nStart Time of StopWatch : {0}:{1}:{2}:{3} ", startTimeHours, startTimeMinutes, startTimeSeconds, startTimeMilliseconds);
                    break;

                    case 2:
                        Console.WriteLine("\nStopwatch has Stop!");
                        DateTime dtEnd = DateTime.Now;
                        endTimeMilliseconds = dtEnd.Millisecond;
                        endTimeSeconds = dtEnd.Second;
                        endTimeMinutes = dtEnd.Minute;
                        endTimeHours = dtEnd.Hour;
                        Console.WriteLine("\nStart Time of StopWatch : {0}:{1}:{2}:{3} ", endTimeHours, endTimeMinutes, endTimeSeconds, endTimeMilliseconds);

                        elapsedMilliseconds = endTimeMilliseconds - startTimeMilliseconds;
                        elapsedSeconds = endTimeSeconds - startTimeSeconds;
                        elapsedMinutes = endTimeMinutes - startTimeMinutes;
                        elapsedHours = endTimeHours - startTimeHours;
                        Console.WriteLine("\nTime Elapsed is : {0}:{1}:{2}:{3}", elapsedHours, elapsedMinutes, elapsedSeconds, elapsedMilliseconds);
                    break;

                    case 3:
                        flag = false;
                    break;

                    default:
                        Console.WriteLine("Choose Correct Option!!!\n");
                    break;
                }
            }

        }
    }
}
