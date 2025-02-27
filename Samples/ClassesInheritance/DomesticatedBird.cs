public abstract class DomesticatedBird : Bird
{
    protected string name;
    public DomesticatedBird(string breed, string color, Genders gender, int ageMonth, string sound, string name) : base(breed, color, gender, ageMonth, sound)
    {
        this.name = name;
    }

    public void GiveNewName(string newName)
    {
        name = newName;
    }
}