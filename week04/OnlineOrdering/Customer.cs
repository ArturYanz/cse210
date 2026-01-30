public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string _name, Address _address)
    {

    }
    
    public bool LivesInUSA()
    {
        return true;
    }
}