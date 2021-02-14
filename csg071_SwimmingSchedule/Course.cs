using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg071_SwimmingSchedule
{
    class Course
    {
        private int dow;
        private int startTime;
        private int fee;

        public Course(string n, int d, int t, int f)
        {
            CourseName = n;
            DOW = d;
            startTime = t;
            Fee = f;
        }

        public string CourseName { get; private set; }

        public int DOW
        {
            get { return dow; }
            set
            {
                if(value >= 0 && value <= 6)
                {
                    dow = value;
                }
            }
        }

        public int StartTime
        {
            get { return startTime; }
            set
            {
                if(value >= 10 && value <= 20)
                {
                    startTime = value;
                }
            }
        }

        public int Fee
        {
            get { return fee; }
            set
            {
                if(value >= 0)
                {
                    fee = value;
                }
            }
        }

        public string GetClassDays(int y, int m)
        {
            int daysInMonth = DateTime.DaysInMonth(y, m);
            string classDays = "";

            for (int day = 1; day <= daysInMonth - 3; day++)
            {
                DateTime dt = new DateTime(y, m, day);
                if ((int)dt.DayOfWeek == dow)
                    classDays += day + "日  ";
            }

            return classDays;
        }

        public int GetMonthlyFee(int y, int m)
        {
            int dayCount = 0;
            int daysInMonth = DateTime.DaysInMonth(y, m);

            for (int day = 1; day <= daysInMonth - 3; day++)
            {
                DateTime dt = new DateTime(y, m, day);
                if ((int)dt.DayOfWeek == dow)
                    dayCount++;
            }
            return fee * dayCount;
        }
    }
}
