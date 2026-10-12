internal class Name
{
    // поля
    private string? surname;
    private string? firstName;
    private string? patronymic;

    // конструкторы
    // с параметрами
    public Name(string firstName)
    {
        this.firstName = firstName;
        this.surname = null;
        this.patronymic = null;
    }

    public Name(string surname, string firstName)
    {
        this.firstName = firstName;
        this.surname = surname;
        this.patronymic = null;
    }

    public Name(string surname, string firstName, string patronymic)
    {
        this.firstName = firstName;
        this.surname = surname;
        this.patronymic = patronymic;
    }
    
    // свойства
    public string? FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }

    public string? Surname
    {
        get { return this.surname; }
        set { this.surname = value; }
    }

    public string? Patronymic
    {
        get { return this.patronymic; }
        set { this.patronymic = value; }
    }
    
    // перегруженный метод
    public override string ToString()
    {
        string fullName = "";
        if (surname != null)
        {
           fullName = surname; 
        }

        if (fullName != "")
        {
            fullName += " " + firstName;

        }

        else
        {
            fullName =  firstName;
        }
        
        if (patronymic != null)
        {
            fullName += " " + patronymic;
        }
        return fullName;
    }
}
