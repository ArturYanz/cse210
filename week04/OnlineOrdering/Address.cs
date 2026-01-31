using System.Runtime.CompilerServices;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string state, string country, string city)
    {
        _street = street;
        _state = state;
        _country = country;
        _city = city;
    }

    public bool IsInUSA()
    {

        if (_country.ToLower() == "usa" || _country.ToLower() == "united states")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {

        return $"{_street}\n{_city},{_state}\n{_country}";

    }

}