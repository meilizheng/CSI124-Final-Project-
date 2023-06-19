using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectClassLibrary
{
    public class Exercies
    {
        public string name;
        public int caloriesBurned;

        public Exercies() { }

        public Exercies(string name, int caloriesBurned)
        {
            this.name = name;
            this.caloriesBurned = caloriesBurned;
        }

        public string Name { get => name; set => name = value; }
        public int CaloriesBurned { get => caloriesBurned; set => caloriesBurned = value; }
    }
}
