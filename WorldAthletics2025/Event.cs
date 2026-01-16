using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAthletics2025
{
    public abstract class Event
    {
        public string name { get; set; }
        public double wr { get; set; }
        public string holder { get; set; }
        public string unit;
        public void WriteData()
        {
            string data = $"{name}\n{wr} {unit}\n{holder}";
            Console.WriteLine(data);
        }
    }
}

