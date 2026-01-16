using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAthletics2025
{
    internal class AthleteUSA : Athlete
    {
        public string state {  get; set; }
        public string college { get; set; }
        public new string country = "USA";
        public override void WriteData()
        {
            string data = $"{firstName} {lastName}\n{athleteEvent.name}\n{pb} - {DiffWR(athleteEvent.wr)} from world record\n{country}\n{state}{(college != null ? "\n" + college : "")}";
            Console.WriteLine(data);
        }
    }
}
