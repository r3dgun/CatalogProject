using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogProject.Global;
using Models;

namespace CatalogProject.Servise.Product
{

    public interface IProductService
    {
        int FindNextId();
        List<Models.Product> GetAllProducts();
        IEnumerable<Models.Product> GetProductsByFilter(string parameter);
        Models.Product GetProductById(int productId);
        int InsertProduct(Models.Product product);
        bool UpdateProduct(Models.Product product);
        bool DeleteProduct(Models.Product product);
        bool DeleteProduct(int productId);
        List<Models.Product> GetProductWithCategoryId(int categoryId);
        bool DeleteProductWithCategoryId(int categoryId);
        string GetProductNameWithCategoryId(int categoryId);




    }
    public class ProductService : IProductService
    {
        private readonly ILiteCollection<Models.Product> _collection;
        private readonly DatabaseContext _dbContext=DatabaseContext.Instance;

        public ProductService()
        {
            _collection = _dbContext.Products;
        }

        public int FindNextId()
        {
            int nextId = (_collection.Query().OrderByDescending(x => x.Id).FirstOrDefault()?.Id ?? 0) + 1;
            return nextId;
        }

        public List<Models.Product> GetAllProducts()
        {
            return _collection.FindAll().ToList();
        }

        public IEnumerable<Models.Product> GetProductsByFilter(string parameter)
        {
            return _collection.Find(c => c.Name == parameter);
        }

        public Models.Product GetProductById(int productId)
        {
            return _collection.FindById(productId);
        }

        public int InsertProduct(Models.Product product)
        {
            try
            {
                var newId = FindNextId();
                product.Id = newId;
                _collection.Insert(new BsonValue(newId), product);
                return product.Id;
            }
            catch (InvalidCastException)
            {
                // Log if needed
                return 0;
            }
        }

        public bool UpdateProduct(Models.Product product)
        {
            return _collection.Update(product);

        }

        public bool DeleteProduct(Models.Product product)
        {
            try
            {
                return _collection.Delete(product.Id);
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteProduct(int productId)
        {
            try
            {
                return _collection.Delete(productId);
            }
            catch
            {
                return false;
            }
        }

        public List<Models.Product> GetProductWithCategoryId(int categoryId)
        {
           return _collection.Find(p => p.CategoryId == categoryId).ToList();
        }

        public bool DeleteProductWithCategoryId(int categoryId)
        {
            try
            {
                var products= GetProductWithCategoryId(categoryId);
                foreach (var product in products)
                {
                    DeleteProduct(product);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string GetProductNameWithCategoryId(int categoryId)
        {
            var products = GetProductWithCategoryId(categoryId).Select(c=>c.Name);
            var res = string.Join(",", products);
            return res;
        }
    }
}

