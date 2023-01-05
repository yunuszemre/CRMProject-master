using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace CRMProject.BL.Abstract
{
    using Entities.Concrete;

    public interface IUserAccountService
    {
        UserAccount GetById(int id);
        void Add(UserAccount entity);
        void Update(UserAccount entity);
        void Delete(UserAccount entity);
        IEnumerable<UserAccount> Select(Expression<Func<UserAccount, bool>> predicate = null);
        UserAccount GetUser(string username, string password);
    }
}
