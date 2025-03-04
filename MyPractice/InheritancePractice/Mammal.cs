using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public abstract class Mammal
    {
        protected string fur;
        protected string species;
        protected int gramsWeight;
        protected Genders gender;

        protected Mammal(string fur, string species, int gramsWeight, Genders gender)
        {
            this.fur = fur;
            this.species = species;
            this.gramsWeight = gramsWeight;
            this.gender = gender;

        }

        protected double GetWeightKg()
        {
            return Convert.ToDouble(gramsWeight)/ 1000;
        }
    }
}