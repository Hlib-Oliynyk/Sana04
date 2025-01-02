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
            StartCity = "Місто відправлення";
            FinishCity = "Місто прибуття";
            StartDate = new MyDate();
            FinishDate = new MyDate();
        }

        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            SetStartCity(startCity);
            SetFinishCity(finishCity);
            SetStartDate(new MyDate(startDate));
            SetFinishDate(new MyDate(finishDate));
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
            if (string.IsNullOrEmpty(startCity))
                throw new Exception("StartCity is empty!");
            StartCity = startCity;
        }

        public void SetFinishCity(string finishCity)
        {
            if (string.IsNullOrEmpty(finishCity))
                throw new Exception("FinishCity is empty!");
            FinishCity = finishCity;
        }

        public void SetStartDate(MyDate startDate)
        {
            StartDate = new MyDate(startDate);
        }

        public void SetFinishDate(MyDate finishDate)
        {
            FinishDate = new MyDate(finishDate);
        }

        public string GetStartCity() { return StartCity; }
        public string GetFinishCity() { return FinishCity; }
        public MyDate GetStartDate() { return StartDate; }
        public MyDate GetFinishDate() { return FinishDate; }

        public int GetTotalTime()
        {
            DateTime start = StartDate.ToDateTime();
            DateTime finish = FinishDate.ToDateTime();
            return (int)(finish - start).TotalMinutes;
        }

        public bool IsArrivingToday()
        {
            DateTime start = StartDate.ToDateTime();
            DateTime finish = FinishDate.ToDateTime();
            return start.Date == finish.Date;
        }
    }
}
