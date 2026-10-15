internal class Name
{
    private string? _surname;
    private string? _firstName;
    private string? _patronymic;

    public Name(string firstName)
    {
        _firstName = firstName;
        _surname = null;
        _patronymic = null;
    }

    public Name(string surname, string firstName)
    {
        _firstName = firstName;
        _surname = surname;
        _patronymic = null;
    }

    public Name(string surname, string firstName, string patronymic)
    {
        _firstName = firstName;
        _surname = surname;
        _patronymic = patronymic;
    }
    
    public string? FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    public string? Surname
    {
        get { return _surname; }
        set { _surname = value; }
    }

    public string? Patronymic
    {
        get { return _patronymic; }
        set { _patronymic = value; }
    }
    
    public override string ToString()
    {
        string fullName = "";
        if (_surname != null)
        {
           fullName = _surname; 
        }

        if (fullName != "")
        {
            fullName += " " + _firstName;

        }

        else
        {
            fullName =  _firstName;
        }
        
        if (_patronymic != null)
        {
            fullName += " " + _patronymic;
        }
        return fullName;
    }
}
