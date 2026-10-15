namespace ConsoleApp1;

internal class People
{
    private Name _name;
    private int _height;
    private People? _father;

    public People(Name name, int height)
    {
        this._name = name;
        this._height = height;
    }
    
    public People(Name name, int height, People? father)
    {
        this._name = name;
        this._height = height;
        this._father = father;
    }
    
    public Name Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public int Height
    {
        get { return this._height; }
        set { this._height = value; }
    }

    public People? Father
    {
        get { return this._father; }
        set { this._father = value; }
    }
    
    
    public override string ToString()
    {
        if (this._father != null)
        {
            if (_name.Surname == null && this._father.Name.Surname != null)
            {
                _name.Surname = this._father.Name.Surname;
            }

            if (_name.Patronymic == null && this._father.Name.FirstName != null)
            {
                _name.Patronymic = this._father.Name.FirstName + "ович";
            }
        }
        
        return $"{this._name}, рост: {this._height}";  
        
    }
}
