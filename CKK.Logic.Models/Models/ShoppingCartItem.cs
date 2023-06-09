﻿namespace CKK.Logic.Models;
using System;

public class ShoppingCartItem
{
    private Product _product;
    private int _quantity;

    public ShoppingCartItem(Product product, int quantity)
    {
        _product = product;
        _quantity = quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public Product GetProduct()
    {
        return _product;
    }

    public SetProduct(Product product)
    {
        _product = product;
    }

    public decimal GetTotal()
    {
        return (_quantity * _price);
    }
}
