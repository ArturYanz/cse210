public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string _name, string _productID, double _price, int _quantity)
    {

    }
    
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

}