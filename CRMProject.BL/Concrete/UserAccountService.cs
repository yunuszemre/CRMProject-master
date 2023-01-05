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
    public class UserAccountService : IUserAccountService
    {
        private IUserAccountRepository repo;

        public UserAccountService(IUserAccountRepository _repo)
        {
            repo = _repo;
        }

        public void Add(UserAccount entity)
        {
            repo.Add(entity);
        }

        public void Delete(UserAccount entity)
        {
            repo.Delete(entity);
        }

        public UserAccount GetById(int id)
        {
            return repo.GetById(id);
        }

        public UserAccount GetUser(string username, string password)
        {
            return repo.GetUser(username, password);
        }

        public IEnumerable<UserAccount> Select(Expression<Func<UserAccount, bool>> predicate = null)
        {
            return repo.Select(predicate);
        }

        public void Update(UserAccount entity)
        {
            repo.Update(entity);
        }
    }
}
