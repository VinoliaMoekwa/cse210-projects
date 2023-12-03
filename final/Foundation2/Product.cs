using System;
using System.Collections.Generic;
using System.Numerics;

public class Product{
    private string  _productId;
    private decimal _productPrice;
    private int _ProductQuantity;
    private string _productName;

     public Product(string name, string productId, decimal price, int quantity)
    {
        this._productName = name;
        this._productId = productId;
        this._productPrice = price;
        this._ProductQuantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return _productPrice * _ProductQuantity;
    }

    public string GetName()
    {
        return _productName;
    }

public string GetProductId()
    {
        return _productId;
    }

    public int GetQuantity()
    {
        return _ProductQuantity;
    }
}

    
