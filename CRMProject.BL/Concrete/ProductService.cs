using CRMProject.BL.Abstract;
using CRMProject.DAL.Abstract;
using CRMProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.BL.Concrete
{
    public class ProductService : IProductService
    {
        private IProductRepositoroy repo;
        public ProductService(IProductRepositoroy _repo)
        {
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
