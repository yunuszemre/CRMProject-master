using CRMProject.DAL.Abstract;
using CRMProject.DAL.Concrete.EF.Context;
using CRMProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.DAL.Concrete.EF.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepositoroy
    {
        private CRMContext _dbContext;
        public ProductRepository(CRMContext dbContext) : base(dbContext)
        {
            _dbContext= dbContext;
        }

        
    }

   
}
