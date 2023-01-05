using CRMProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.BL.Abstract
{
    public interface ISupplierService
    {
        Supplier GetById(int id);
        void Add(Supplier entity);
        void Update(Supplier entity);
        void Delete(Supplier entity);
        IEnumerable<Supplier> Select(Expression<Func<Supplier, bool>> predicate = null);
    }
}
