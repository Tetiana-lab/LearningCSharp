namespace InheritancePractice

{
    internal class Program
    {
        static void Main(string[] argd)
        {
            var cat = new DomesticCat("grey fur", "just cat", 2300, Genders.girl, "mice", "can purr", "Kate");

            cat.WhatDoWeKnow();
        }
    }
}
//DomesticCat(string fur, string species, int gramsWeight, Genders gender, string prey, string purr, string ownersName) : base(fur, species, gramsWeight, gender, prey, purr)