using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sana04.Classes
{
    public class MyDate
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        public MyDate(int year, int month, int day, int hours, int minutes)
        {
            SetYear(year);
            SetMonth(month);
            SetDay(day);
            SetHours(hours);
            SetMinutes(minutes);
        }
        public void SetYear(int year)
        {
            if (year < 0 || year == 0)
            {
                throw new Exception("Year is empty!");
            }
            else
            {
                Year = year;
            }
        }
        public void SetMonth(int month)
        {
            if (month < 0 || month > 12)
            {
                throw new Exception("Month is incorrect!");
            }
            else
            {
                Month = month;
            }
        }
        public void SetDay(int day)
        {
            if (day < 0 || day == 0)
            {
                throw new Exception("Day is empty!");
            }
            else
            {
                Day = day;
            }

        }
        public void SetHours(int hours)
        {
            if (hours < 0 || hours == 0)
            {
                throw new Exception("Hours is empty!");
            }
            else
            {
                Hours = hours;
            }
        }
        public void SetMinutes(int minutes)
        {
            if (minutes < 0 || minutes == 0)
            {
                throw new Exception("Minutes is empty!");
            }
            else
            {
                Minutes = minutes;
            }
        }

        public int GetYear() { return Year; }
        public int GetMonth() { return Month; }
        public int GetDay() { return Day; }
        public int GetHours() { return Hours; }
        public int GetMinutes() { return Minutes; }

    }
}
