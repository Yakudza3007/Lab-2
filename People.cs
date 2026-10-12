namespace ConsoleApp1;

internal class People
{
    private Name name;
    private int height;

    public People(Name name, int height)
    {
        this.name = name;
        this.height = height;
    }
    
    public Name Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Height
    {
        get { return this.height; }
        set { this.height = value; }
    }
    
    
    public override string ToString()
    {
        return $"{this.name}, рост: {this.height}";
    }
}

