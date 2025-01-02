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

        public MyDate()
        {
            Year = 2024;
            Month = 1;
            Day = 1;
            Hours = 0;
            Minutes = 0;
        }

        public MyDate(int year, int month, int day, int hours, int minutes)
        {
            SetYear(year);
            SetMonth(month);
            SetDay(day);
            SetHours(hours);
            SetMinutes(minutes);
        }

        public MyDate(MyDate other)
        {
            Year = other.Year;
            Month = other.Month;
            Day = other.Day;
            Hours = other.Hours;
            Minutes = other.Minutes;
        }

        public void SetYear(int year)
        {
            if (year < 1)
                throw new Exception("Year must be greater than 0.");
            Year = year;
        }

        public void SetMonth(int month)
        {
            if (month < 1 || month > 12)
                throw new Exception("Month must be between 1 and 12.");
            Month = month;
        }

        public void SetDay(int day)
        {
            if (day < 1 || day > DateTime.DaysInMonth(Year, Month))
                throw new Exception($"Invalid day for the given month and year: {day}.");
            Day = day;
        }

        public void SetHours(int hours)
        {
            if (hours < 0 || hours > 23)
                throw new Exception("Hours must be between 0 and 23.");
            Hours = hours;
        }

        public void SetMinutes(int minutes)
        {
            if (minutes < 0 || minutes > 59)
                throw new Exception("Minutes must be between 0 and 59.");
            Minutes = minutes;
        }

        public int GetYear() { return Year; }
        public int GetMonth() { return Month; }
        public int GetDay() { return Day; }
        public int GetHours() { return Hours; }
        public int GetMinutes() { return Minutes; }

        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day, Hours, Minutes, 0);
        }
    }
}

