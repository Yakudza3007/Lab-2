internal class Name
{
    private string? _surname;
    private string? _firstName;
    private string? _patronymic;

    public Name(string firstName)
    {
        this._firstName = firstName;
        this._surname = null;
        this._patronymic = null;
    }

    public Name(string surname, string firstName)
    {
        this._firstName = firstName;
        this._surname = surname;
        this._patronymic = null;
    }

    public Name(string surname, string firstName, string patronymic)
    {
        this._firstName = firstName;
        this._surname = surname;
        this._patronymic = patronymic;
    }
    
    public string? FirstName
    {
        get { return this._firstName; }
        set { this._firstName = value; }
    }

    public string? Surname
    {
        get { return this._surname; }
        set { this._surname = value; }
    }

    public string? Patronymic
    {
        get { return this._patronymic; }
        set { this._patronymic = value; }
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
