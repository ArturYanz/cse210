public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer _customer)
    {

    }

    public void AddProduct(Product _product)
    {
        _products.Add(_product);
    }

    public double GetTotalPrice()
    {
        return 1 + 1;
    }

    public string GetPackingLabel()
    {
        return "Yo";
    }

    public string GetShippingLabel()
    {
        return "yo";
    }







}