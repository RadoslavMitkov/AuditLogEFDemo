using AuditLogAPI.Models;
using AuditLogAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AuditLogAPI.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        // GET products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            var users = productService.GetAll().ToArray();

            return users;
        }

        // GET products/5
        [HttpGet("{id:int}")]
        public ActionResult<Product> Get(int id)
        {
            return null;
        }

        // POST products
        [HttpPost]
        public ActionResult<Product> Create([FromBody] Product product)
        {
            return null;
        }

        // PUT products/5
        [HttpPut("{id:int}")]
        public ActionResult<Product> Update(int id, [FromBody] Product product)
        {
            return null;
        }

        // DELETE products/5
        [HttpDelete("{id:int}")]
        public ActionResult<Product> Delete(int id)
        {
            return null;
        }
    }
}
