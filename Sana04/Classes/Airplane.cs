using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana04.Classes
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected MyDate StartDate;
        protected MyDate FinishDate;

        public Airplane()
        {
            StartCity = "Початкове місце";
            FinishCity = "Кінцеве місце";
            StartDate = new MyDate();
            FinishDate = new MyDate();
        }

        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            SetStartCity(startCity);
            SetFinishCity(finishCity);
            SetStartDate(startDate);
            SetFinishDate(finishDate);
        }

        public Airplane(Airplane other)
        {
            StartCity = other.StartCity;
            FinishCity = other.FinishCity;
            StartDate = new MyDate(other.StartDate);
            FinishDate = new MyDate(other.FinishDate);
        }

        public void SetStartCity(string startCity)
        {
            if (startCity == null || startCity.Length == 0)
            {
                throw new Exception("StartCity is empty!");
            }
            else
            {
                StartCity = startCity;
            }
        }

        public void SetFinishCity(string finishCity)
        {
            if (finishCity == null || finishCity.Length == 0)
            {
                throw new Exception("FinishCity is empty!");
            }
            else
            {
                FinishCity = finishCity;
            }
        }

        public void SetStartDate(MyDate startDate)
        {
            StartDate = startDate;
        }

        public void SetFinishDate(MyDate finishDate)
        {
            FinishDate = finishDate;
        }

        public string GetStartCity() { return StartCity; }
        public string GetFinishCity() { return FinishCity; }
        public MyDate GetStartDate() { return StartDate; }
        public MyDate GetFinishDate() { return FinishDate; }
        public int GetTotalTime()
        {
            DateTime start = StartDate.ToDateTime();
            DateTime finish = FinishDate.ToDateTime();
            TimeSpan timeSpan = finish - start;
            return (int)timeSpan.TotalMinutes;
        }

        public bool IsArrivingToday()
        {
            return StartDate.GetYear() == FinishDate.GetYear() &&
                   StartDate.GetMonth() == FinishDate.GetMonth() &&
                   StartDate.GetDay() == FinishDate.GetDay();
        }
    }
}
