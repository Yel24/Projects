﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

class clock
{
    public static double clockAngle(int hour, int minute)
    {
        if (hour < 0 || minute < 0)
        {
            Console.WriteLine("Invalid");
            return -1;
        }
        if (hour == 12)
            hour = 0;
        if (minute == 60)
        {
            minute = 0;
            hour += 1;
        }
        double hourAngle = 0.5 * (hour * 60 + minute);
        double minuteAngle = minute * 6;
        double clockAngle = Math.Abs(hourAngle - minuteAngle);
        return Math.Min(360 - clockAngle, clockAngle);
    }

    //Change Input
    static void Main()
    {
        Console.WriteLine(clockAngle(8, 30) + " degrees");
        Console.WriteLine(clockAngle(12, 30) + " degrees");
        Console.WriteLine(clockAngle(9, 30) + " degrees");

    }
}
