public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {

        double _totalPrice = 0;

        foreach (Product product in _products)
        {
            _totalPrice += product.GetTotalCost();
        }

        if (_customer.LivesInUSA() == false)
        {
            return _totalPrice + 35;
        }
        else
        {
            return _totalPrice + 5;
        }

    }

    public string GetPackingLabel()
    {
        string _label = "";

        foreach (Product product in _products)
        {
            _label += $"Product: {product.GetProductName()} - ID: {product.GetProductID()}\n";
        }

        return _label;
    }

    public string GetShippingLabel()
    {
        return $"Name: {_customer.GetName()} \n{_customer.GetAddress()}";
    }







}