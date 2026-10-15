namespace ConsoleApp1;

internal class People
{
    private Name _name;
    private int _height;
    private People? _father;

    public People(Name name, int height)
    {
        _name = name;
        _height = height;
    }
    
    public People(Name name, int height, People? father)
    {
        _name = name;
        _height = height;
        _father = father;
    }
    
    public Name Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Height
    {
        get { return _height; }
        set { _height = value; }
    }

    public People? Father
    {
        get { return _father; }
        set { _father = value; }
    }
    
    
    public override string ToString()
    {
        if (_father != null)
        {
            if (_name.Surname == null && _father.Name.Surname != null)
            {
                _name.Surname = _father.Name.Surname;
            }

            if (_name.Patronymic == null && _father.Name.FirstName != null)
            {
                _name.Patronymic = _father.Name.FirstName + "ович";
            }
        }
        
        return $"{_name}, рост: {_height}";  
        
    }
}
