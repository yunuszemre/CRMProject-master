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
    public class SuppplierService : ISupplierService
    {
        private ISupplierRepository repo;
        public SuppplierService(ISupplierRepository _repo)
        {
            this.repo = _repo;
        }
        public void Add(Supplier entity)
        {
           repo.Add(entity);
        }

        public void Delete(Supplier entity)
        {
            repo.Delete(entity);
        }

        public Supplier GetById(int id)
        {
            return repo.GetById(id);
        }

        public IEnumerable<Supplier> Select(Expression<Func<Supplier, bool>> predicate = null)
        {
            return repo.Select(predicate);
        }

        public void Update(Supplier entity)
        {
            repo.Update(entity);
        }
    }
}
