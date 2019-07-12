using AuditLogAPI.Models;
using System.Collections.Generic;

namespace AuditLogAPI.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();

        Product GetById(int id);

        void Create(Product product);

        void Delete(int id);
    }
}
