using CRMProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.BL.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        void Add(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        IEnumerable<Product> Select(Expression<Func<Product, bool>> predicate=null);
        
    }
}
