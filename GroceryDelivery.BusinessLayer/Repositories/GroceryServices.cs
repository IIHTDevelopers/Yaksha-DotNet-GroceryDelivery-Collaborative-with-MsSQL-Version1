using GroceryDelivery.BusinessLayer.Persistence;
using GroceryDelivery.BusinessLayer.Persistence.Services;
using GroceryDelivery.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GroceryDelivery.BusinessLayer.Repositories
{
    public class GroceryServices : IGroceryServices
    {
        /// <summary>
        /// Creating Referancce variable of IGroceryRepository
        /// and injecting Referance into constructor
        /// </summary>
        private readonly IGroceryRepository _grocery;
        public GroceryServices(IGroceryRepository groceryRepository)
        {
            _grocery = groceryRepository;
        }
        /// <summary>
        /// Add new product in InMemoryDb
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public async Task<Product> AddProduct(Product product)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get All product from Db and using id also
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get Product by Id
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns></returns>
        public async Task<Product> GetProductById(int ProductId)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// get menu list
        /// </summary>
        /// <returns></returns>
        public async Task<IList<Menubar>> MenuList()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Place order using product order
        /// </summary>
        /// <param name="ProductId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<ApplicationUser> PlaceOrder(ApplicationUser user)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Find Product by Product name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> ProductByName(string name)
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