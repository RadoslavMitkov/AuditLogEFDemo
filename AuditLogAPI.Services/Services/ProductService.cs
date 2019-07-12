using System.Collections.Generic;
using AuditLogAPI.Models;
using AuditLogAPI.Services.Interfaces;

namespace AuditLogAPI.Services.Services
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Create(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
