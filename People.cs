namespace ConsoleApp1;

internal class People
{
    private Name name;
    private int height;
    private People? father;

    public People(Name name, int height)
    {
        this.name = name;
        this.height = height;
    }
    
    public People(Name name, int height, People? father)
    {
        this.name = name;
        this.height = height;
        this.father = father;
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

    public People? Father
    {
        get { return this.father; }
        set { this.father = value; }
    }
    
    
    public override string ToString()
    {
        if (this.father != null)
        {
            if (name.Surname == null && this.father.Name.Surname != null)
            {
                name.Surname = this.father.Name.Surname;
            }

            if (name.Patronymic == null && this.father.Name.FirstName != null)
            {
                name.Patronymic = this.father.Name.FirstName + "ович";
            }
        }
        
        return $"{this.name}, рост: {this.height}";  
        
    }
}
