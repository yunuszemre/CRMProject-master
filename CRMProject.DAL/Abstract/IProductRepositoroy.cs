using CRMProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.DAL.Abstract
{
    using Entities.Concrete;
    public interface IProductRepositoroy: IGenericRepository<Product> 
    {
        
    }
}
