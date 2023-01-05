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
    public class CategoryRepository : GenericRepository<Product>, ICategoryRepository
    {
        private CRMContext _dbContext;
        public CategoryRepository(CRMContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
