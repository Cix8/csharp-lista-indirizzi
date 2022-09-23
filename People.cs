// See https://aka.ms/new-console-template for more information
public class People
{
    public string Name { get; private set; } 
    public string Surname { get; private set; }
    public string Street { get; private set; }
    public string City { get; private set; }
    public string Province { get; private set; }
    public int ZIP { get; private set; }

    public People(string _name, string _surname, string _street, string _city, string _province, int _zip)
    {
        this.Name = _name;
        this.Surname = _surname;
        this.Street = _street;
        this.City = _city;
        this.Province = _province;
        this.ZIP = _zip;
    }
}