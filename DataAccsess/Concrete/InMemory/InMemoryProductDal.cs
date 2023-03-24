using DataAccsess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _Products;

        //Constrocter Bellekte referans malınca çalışır.
        public InMemoryProductDal()
        {
            _Products = new List<Product> 
            {
            new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitInStock=15 },
            new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitInStock=3 },
            new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=15,UnitInStock=2 },
            new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=15,UnitInStock=65 },
            new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=15,UnitInStock=1 }
            };
        }
        public void Add(Product product)
        {
            _Products.Add(product);

        }
        //LINQ - Laguage Integrated Query.
        //Lambda - =>
        public void Delete(Product product)
        {
            Product productToDelete = _Products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _Products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _Products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            
            return _Products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _Products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _Products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitInStock = product.UnitInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
        }
    }
}
