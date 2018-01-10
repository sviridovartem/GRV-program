using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Diplom.Models
{
    public enum DeviationLevel
    {
        Normal,
        Low,
        Middle,
        High,
        None
    }

    public class Interval
    {
        public string Name { get; set; }
        public double Low { get; set; }
        public double High { get; set; }
        public DeviationLevel Level { get; set; }

        public override string ToString()
        {
            return "(" + this.Low + "-" + this.High + ") - " + this.Name;
        }

        public static List<Interval> LoadIntervals(string path)
        {
            var json = File.ReadAllText(path);

            if (string.IsNullOrEmpty(json))
                throw new InvalidDataException();

            var res = JsonConvert.DeserializeObject<List<Interval>>(json);

            if (res.Count == 0)
                throw new InvalidDataException("No fingers data");

            return res;
        }

        public static Interval GetIntervalInRange(List<Interval> intervals, double value)
        {
            foreach (var inter in intervals.Where(inter => inter.Low <= value && value < inter.High))
            {
                return inter;
            }

            return value == 100.0 ? intervals.FirstOrDefault(x => x.High == value) :new Interval{High = value,Low = value,Level = DeviationLevel.None,Name = "Интервал не найден!"};
        }

        public static void CreateTestData(string path)
        {
            var data = new List<Interval>
            {
                new Interval
                {
                    High = 9, Low = 0,
                    Name = "Серьезное отклонение",
                    Level = DeviationLevel.High
                },
                new Interval
                {
                    High = 18, Low = 9,
                    Name = "Среднее отклонение",
                    Level = DeviationLevel.Middle
                },
                new Interval
                {
                    High = 27, Low = 18,
                    Name = "Небольшое отклонение",
                    Level = DeviationLevel.Low
                },
                new Interval
                {
                    High = 42, Low = 27,
                    Name = "Норма",
                    Level = DeviationLevel.Normal
                },
                new Interval
                {
                    High = 62, Low = 42,
                    Name = "Небольшое отклонение",
                    Level = DeviationLevel.Low
                },
                new Interval
                {
                    High = 82, Low = 62,
                    Name = "Среднее отклонение",
                    Level = DeviationLevel.Middle
                },
                new Interval
                {
                    High = 100, Low = 82,
                    Name = "Серьезное отклонение",
                    Level = DeviationLevel.High
                },

            };

            string json = JsonConvert.SerializeObject(data.ToArray());

            //write string to file
            File.WriteAllText(path, json);

        }
    }
}
