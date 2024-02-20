using MarketYönetimSistemi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYönetimSistemi.Entity.Interface
{
    internal class ProductCrud : ICrud<Product>
    {
        DataContext db = new DataContext();
        public bool Add(Product entity)
        {
            if (entity != null && !String.IsNullOrWhiteSpace(entity.Name))
            {
                db.Product.Add(entity);
                db.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            var product = db.Product.Find(id);
            if (product != null)
            {
                product.IsDelete = true;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Product> GetAll()
        {
            return db.Product.Where(x => x.IsDelete == false).ToList();
        }

        public Product GetById(int id)
        {
            var product = db.Product.Find(id);
            if (product != null)
            {
                return product;
            }
            return null;
        }

        public bool Update(Product entity, int id)
        {
            var existingProduct = db.Product.Find(id);

            if (existingProduct != null && entity != null) { 

                existingProduct.Name = entity.Name;
                existingProduct.Description = entity.Description;
                existingProduct.Price = entity.Price;
                existingProduct.Stock = entity.Stock;
                existingProduct.CategoryId = entity.CategoryId;
                existingProduct.IsStatus = entity.IsStatus;
                existingProduct.Image = entity.Image;

                db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
