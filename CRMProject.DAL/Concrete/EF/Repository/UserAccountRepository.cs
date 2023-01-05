using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.DAL.Concrete.EF.Repository
{
    using Abstract;
    using Concrete.EF.Context;
    using Entities.Concrete;

    public class UserAccountRepository : GenericRepository<UserAccount>, IUserAccountRepository
    {
        private CRMContext _dbContext;

        public UserAccountRepository(CRMContext dbContext) : base(dbContext)
        {
            _dbContext= dbContext;
        }

        public UserAccount GetUser(string username, string password)
        {
            return _dbContext.UserAccount.FirstOrDefault(e=>e.UserName == username && e.Password == password);
        }
    }
}
