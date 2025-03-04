using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public abstract class Carnivore : Mammal
    {
        protected string FavoritePrey;

        protected Carnivore(string fur, string species, int gramsWeight, Genders gender, string prey) : base(fur, species, gramsWeight, gender)

        {
            this.FavoritePrey = prey;
        }
    }
}
