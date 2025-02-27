public abstract class Bird : Animal
{
    protected string soundMaking;

    public Bird(string breed, string color, Genders gender, int ageMonth, string sound) : base(breed, color, gender, ageMonth)
    {
        this.soundMaking = sound;
    }

    public void DoNoise()
    {
        Console.WriteLine(soundMaking);
    }
}