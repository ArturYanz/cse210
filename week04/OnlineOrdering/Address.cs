using System.Runtime.CompilerServices;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string _street, string _state, string _country, string _city)
    {

    }

    public bool IsInUSA()
    {

        return true;
    }

    public string GetAddress()
    {

        return "yo";

    }

}