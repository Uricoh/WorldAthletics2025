using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAthletics2025
{
    internal class Athlete
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Event athleteEvent { get; set; }
        public double pb { get; set; }
        public string country { get; set; }
        public virtual void WriteData()
        {
            string data = $"{firstName} {lastName}\n{athleteEvent.name}\n{pb} - {DiffWR(athleteEvent.wr)} from world record\n{country}";
            Console.WriteLine(data);
        }
        public double DiffWR(double wr)
        {
            double diff = Math.Abs(wr - pb);
            diff *= 100;
            diff = Math.Round(diff);
            diff /= 100;
            return diff;
        }
    }
}
