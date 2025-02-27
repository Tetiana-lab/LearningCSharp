public sealed class ParrotDomesticated : DomesticatedBird
{
    private bool canSpeak;

    public ParrotDomesticated(string breed, string color, Genders gender, int ageMonth, string sound, string name, bool canSpeak = false) : base(breed, color, gender, ageMonth, sound, name)
    {
        this.canSpeak = canSpeak;
    }

    public void LearnToSpeak()
    {
        canSpeak = true;
    }

    public void Introduce()
    {
        if(canSpeak)
        {
            System.Console.WriteLine($"Look at me, i am the parrot named {this.name} I am {this.ageMonth}month ({GetAgeYears()} years) old.");
        }
        else
        {
            System.Console.WriteLine(soundMaking);
        }
    }
}

