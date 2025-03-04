using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public abstract class Cats : Carnivore
    {
        protected string CanPurr;

        protected Cats(string fur, string species, int gramsWeight, Genders gender, string prey, string purr) : base(fur, species, gramsWeight, gender, prey)
        {
            this.CanPurr = purr;
        }
    }
}
