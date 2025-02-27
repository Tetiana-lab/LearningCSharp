public abstract class Animal
{
    protected string breed;
    protected string color;
    protected Genders gender;
    protected int ageMonth;

     protected Animal(string breed, string color, Genders gender, int ageMonth)
    {
        this.breed = breed;
        this.color = color;
        this.gender = gender;
        this.ageMonth = ageMonth;
    }

    protected int GetAgeYears()
    {
        return ageMonth / 12;
    }

     public void CelebrateMonthlyBirthday()
    {
        Console.WriteLine("Congrats!");
        ageMonth++;
    }
}