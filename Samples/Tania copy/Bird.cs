public abstract class Bird : Animal
{

    public Bird(string breed, string color, Genders gender, int ageMonth) : base(breed, color, gender, ageMonth)
    {
    }

    public abstract void DoNoise();
}