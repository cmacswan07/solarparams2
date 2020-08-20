using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarParams2
{
    public class Inverters
    {
        public static Hashtable inverterTable = new Hashtable();

        public static List<Inverter> inverterList = new List<Inverter>()
        {
            new Inverter()
            {
                Make = "SolarEdge",
                Model = "SE3000H-US",
                Wattage = 3000,
                Output = 12.5,
                Input = 8.5,
                Breaker = 20
            },
            new Inverter()
            {
                Make = "SolarEdge",
                Model = "SE3800H-US",
                Wattage = 3800,
                Output = 16,
                Input = 10.5,
                Breaker = 20
            },
            new Inverter()
            {
                Make = "SolarEdge",
                Model = "SE5000H-US",
                Wattage = 5000,
                Output = 21,
                Input = 13.5,
                Breaker = 30
            },
            new Inverter()
            {
                Make = "SolarEdge",
                Model = "SE6000H-US",
                Wattage = 6000,
                Output = 25,
                Input = 16.5,
                Breaker = 35
            },
            new Inverter()
            {
                Make = "SolarEdge",
                Model = "SE7600H-US",
                Wattage = 7600,
                Output = 32,
                Input = 20,
                Breaker = 40
            },
            new Inverter()
            {
                Make = "SolarEdge",
                Model = "SE10000H-US",
                Wattage = 10000,
                Output = 42,
                Input = 27,
                Breaker = 60
            },
            new Inverter()
            {
                Make = "SolarEdge",
                Model = "SE11400H-US",
                Wattage = 11400,
                Output = 47.5,
                Input = 30.5,
                Breaker = 60
            }
        };
        public class Inverter
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public double Wattage { get; set; }
            public double Output { get; set; }
            public double Input { get; set; }
            public int Breaker { get; set; }
        }
    }
}
