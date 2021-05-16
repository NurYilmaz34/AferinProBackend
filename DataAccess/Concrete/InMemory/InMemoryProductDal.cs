using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //global değişken olduğu için _

        public InMemoryProductDal() //InMemoryProductDal class'ı new'lendiği an çalışacak constractor.
        {
            //veritabanından geliyormuş gibi simüle ettik burda.
            _products = new List<Product> {
                new Product{ProductId=1,CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product) //silinecek ürünün önce referansına ulaşmalıyım.(referans tip çünkü)
        {
            //productToDelete'i new'lemeye gerek yok. çünkü sadece referans numarası atıycam !
            Product productToDelete = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.FirstOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
