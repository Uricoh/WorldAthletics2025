using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldAthletics2025
{
    internal class Program
    {
        public static void BoltAndLyles()
        {
            Run Hundred = new Run();
            Hundred.name = "100 m";
            Hundred.wr = 9.58;
            Hundred.holder = "Usain Bolt";
            Hundred.WriteData();

            Console.WriteLine();

            AthleteUSA Lyles = new AthleteUSA();
            Lyles.firstName = "Noah";
            Lyles.lastName = "Lyles";
            Lyles.athleteEvent = Hundred;
            Lyles.pb = 9.79;
            Lyles.state = "Virginia";
            Lyles.college = null;
            Lyles.WriteData();
        }
        static void Main(string[] args)
        {
            BoltAndLyles();
            Console.ReadLine();
        }
    }
}
