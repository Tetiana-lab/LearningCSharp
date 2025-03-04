using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    internal class DomesticCat : Cats
    {
        protected string Owner;

       public DomesticCat(string fur, string species, int gramsWeight, Genders gender, string prey, string purr, string ownersName) : base(fur, species, gramsWeight, gender, prey, purr)
        {
            this.Owner = ownersName;
        }

        public void WhatDoWeKnow()
        {
            Console.WriteLine($"This is a {this.Owner}'s cat. It is a {gender}.Its weight is {GetWeightKg()} kg. It has {fur} and hants {FavoritePrey}.");
        }
    }
}
