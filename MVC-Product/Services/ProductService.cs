using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_Product.Models;

namespace MVC_Product.Services
{
    interface ProductService
    {
        Product CreateProduct(Product product);
        List<Product> GetListProduct(int page, int limit);
        Product GetProductDetail(int id);
        Product UpdateProduct(int id, Product product);
        bool DeleteProduct(int id);
    }
}
