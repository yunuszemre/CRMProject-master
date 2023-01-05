using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.Entities.Concrete
{
    public class Supplier
    {
        public Supplier()
        {
            this.Products = new List<Product>();
        }
        public int SupplierId { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
