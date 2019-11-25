using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using MVC_Product.Models;

namespace MVC_Product.Services
{
    public class InMemoryProductService : ProductService
    {
        private static List<Product> _listProducts;

        public InMemoryProductService()
        {
            if (_listProducts == null)
            {
                _listProducts = new List<Product>();
            }
        }
        public Product CreateProduct(Product product)
        {
            _listProducts.Add(product);
            return product;
        }

        public List<Product> GetListProduct(int page, int limit)
        {
            return _listProducts;
        }

        public Product GetProductDetail(int id)
        {
            for (int i = 0; i < _listProducts.Count; i++)
            {
                if (_listProducts[i].Id.Equals(id))
                {
                    return _listProducts[i];
                }
            }
            return null;
        }

        public Product UpdateProduct(int id, Product product)
        {
            for(int i = 0; i < _listProducts.Count; i++)
            {
                if (_listProducts[i].Id.Equals(id))
                {
                    _listProducts[i].Id = product.Id;
                    _listProducts[i].Name = product.Name;
                    _listProducts[i].Price = product.Price;
                    _listProducts[i].Description = product.Description;
                    _listProducts[i].Image = product.Image;
                    _listProducts[i].CreatedAt = product.CreatedAt;
                    _listProducts[i].UpdatedAt = product.UpdatedAt;
                }

                return _listProducts[i];
            }
            return null;
        }

        public bool DeleteProduct(int id)
        {
            for (int i = 0; i < _listProducts.Count; i++)
            {
                if (_listProducts[i].Id.Equals(id))
                {
                    _listProducts.Remove(_listProducts[i]);
                    return true;
                }
            }
            return false;
        }
    }
}