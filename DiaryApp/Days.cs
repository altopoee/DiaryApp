using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryApp
{
    public class Days
    {
        public static byte CurrentIndex { get; set; }

        DayOfWeek dayOfWeek { get; }

        public string[] Schedule;

        public Days(DayOfWeek dayOfWeek)
        {
            this.dayOfWeek = dayOfWeek;
            Schedule = new string[27];
        }

        public Days(DayOfWeek dayOfWeek, string[] schedule)
        {
            this.dayOfWeek = dayOfWeek;
            Schedule = schedule;
        }
        public static Days monday = new(DayOfWeek.Tuesday);
        public static Days tuesday = new (DayOfWeek.Tuesday);
        public static Days wednesday = new (DayOfWeek.Wednesday);
        public static Days thursday = new (DayOfWeek.Thursday);
        public static Days friday = new (DayOfWeek.Friday);
        public static Days saturday = new (DayOfWeek.Saturday);
        public static Days sunday = new (DayOfWeek.Sunday);

        public static Days[] DaysArray = { monday, tuesday, wednesday, thursday, friday, saturday, sunday };
    }
}
