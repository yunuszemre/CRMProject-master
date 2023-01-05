using CRMProject.BL.Abstract;
using CRMProject.DAL.Abstract;
using CRMProject.DAL.Concrete.EF.Context;
using CRMProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.BL.Concrete
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository repo;
        private CRMContext _context;
        public CategoryService(ICategoryRepository _repo, CRMContext context)
        {
            this._context= context;
            this.repo = _repo;
        }
        public void Add(Product entity)
        {
            repo.Add(entity);
        }

        public void Delete(Product entity)
        {
            repo.Delete(entity);
        }

        public Product GetById(int id)
        {
            return _context.Products.Include(x => x.Supplier).FirstOrDefault(x => x.SupplierId == x.ProductId);
           return repo.GetById(id);
        }

        public IEnumerable<Product> Select(Expression<Func<Product, bool>> predicate = null)
        {
            return repo.Select(predicate);
        }

        public void Update(Product entity)
        {
            repo.Update(entity);
        }
    }
}
