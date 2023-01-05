using CRMProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public Category()
        {
            this.Products = new List<Product>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
