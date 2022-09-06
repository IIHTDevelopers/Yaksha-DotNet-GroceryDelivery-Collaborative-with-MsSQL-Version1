using GroceryDelivery.BusinessLayer.Persistence;
using GroceryDelivery.DataLayer;
using GroceryDelivery.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryDelivery.BusinessLayer.Repositories
{
    public class GroceryRepository : IGroceryRepository
    {
        private readonly GroceryDbContext _dbContext;
        public GroceryRepository(GroceryDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public async Task<Product> AddProduct(Product product)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<ApplicationUser> PlaceOrder(ApplicationUser user)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Product> GetProductById(int ProductId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> ProductByName(string name)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IList<Menubar>> MenuList()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductOrder>> OrderByuserId(int UserId)
        {
             //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
