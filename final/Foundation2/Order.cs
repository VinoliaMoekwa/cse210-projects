using System;
using System.Collections.Generic;

public class Order{
private List<Product> _products;
private Customer _customer;

public Order(Customer customer)
{
    this._customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalPrice()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }

        
        decimal  shippingCost = _customer.IsInUSA() ? 5 : 35;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()} - Product ID: {product.GetProductId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {_customer.GetName()}\nAddress: {_customer.GetAddress().GetFullAddress()}";
    }
}

