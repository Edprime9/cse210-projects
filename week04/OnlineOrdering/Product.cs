public class Product
{
    private string _productName;
    private string _productId;
    private double _priceProduct;
    private int _productQty;

    public Product(string name,string id, double price, int qty)
    {
        _productName=name;
        _productId=id;
        _priceProduct=price;
        _productQty=qty;
    }
    
    public double TotalCost()
    {
        return _productQty*_priceProduct;
    }

    public String Display()
    {
        return $"{_productName} : {_productId}";
    }

}