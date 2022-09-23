// See https://aka.ms/new-console-template for more information
public class People
{
    public string Name { get; private set; } 
    public string Surname { get; private set; }
    public string Street { get; private set; }
    public string City { get; private set; }
    public string Province { get; private set; }
    public int ZIP { get; private set; }

    public People(string _name, string _surname, string _street, string _city, string _province, int _zip = -1)
    {
        if(_name == "")
        {
            throw new Exception("Il campo \"nome\" non può essere vuoto");
        } else
        {
            this.Name = _name;
        }
        if (_surname == "")
        {
            throw new Exception("Il campo \"cognome\" non può essere vuoto");
        }
        else
        {
            this.Surname = _surname;
        }
        if (_street == "")
        {
            throw new Exception("Il campo \"strada\" non può essere vuoto");
        } else
        {
            this.Street = _street;
        }
        if (_city == "")
        {
            throw new Exception("Il campo \"città\" non può essere vuoto");
        } else
        {
            this.City = _city;
        }
        if (_province == "")
        {
            throw new Exception("Il campo \"provincia\" non può essere vuoto");
        } else
        {
            this.Province = _province;
        }
        if (_zip == -1)
        {
            throw new Exception("Il campo \"CAP\" non può essere vuoto");
        } else
        {
            this.ZIP = _zip;
        }
    }
}