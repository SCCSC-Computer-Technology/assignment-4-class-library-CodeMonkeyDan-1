//Daniel Schiefer aka CodeMonkeyDan
//CPT-206-A80S-2025SP
//Lab #4: State Library


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSchiefer_Lab_4_State_Library
{
    public class StateLibrary
    {
        //properties - fields
        public int id { get; set; }
        public string name { get; set; }
        public int population { get; set; }
        public string flagDescription { get; set; }
        public string flower { get; set; }
        public string bird { get; set; }
        public string colors { get; set; }
        public string threeLargestCities { get; set; }
        public string capital { get; set; }
        public int medianIncome { get; set; }
        public int percentComputerJobs { get; set; }


        //constructor
        public StateLibrary(int id, string name, int population, string flagDescription, string flower,
            string bird, string colors, string threeLargestCities, string capital, int medianIncome,
            int percentComputerJobs)
        {
            this.id = id;
            this.name = name;
            this.population = population;
            this.flagDescription = flagDescription;
            this.flower = flower;
            this.bird = bird;
            this.colors = colors;
            this.threeLargestCities = threeLargestCities;
            this.capital = capital;
            this.medianIncome = medianIncome;
            this.percentComputerJobs = percentComputerJobs;
        }
    }
}
