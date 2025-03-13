public abstract class Animal
{
    private string color;
    protected Genders gender;
    protected int ageMonth;

     protected Animal(string breed, string color, Genders gender, int ageMonth)
    {
        this.Breed = breed;
        this.color = color;
        this.gender = gender;
        this.ageMonth = ageMonth;
    }

    public string Breed { get; private set; }

    public string Color {get {
        return "The wonderfull bright "+ color;
    } set {
        if(color == "red" || color == "green")
            throw new ArgumentException("There are no such colored animals in the world!");
        color = value;
    }}

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