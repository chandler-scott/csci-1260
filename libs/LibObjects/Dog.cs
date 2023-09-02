namespace LibObjects;

public class Dog
{
    private string name = string.Empty;

    public Dog(string name)
    {
        this.name = name;
    }

    public override string ToString() 
    {
        return name;
    }
}
