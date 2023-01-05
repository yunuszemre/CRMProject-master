using CRMProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.Entities.Concrete
{
    public class Product:BaseEntity
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } 
        
        public string ProductDescription { get; set; }

        public int UnitsInStock { get; set; }

        public int UnitsInOrder { get; set; }

        public int CrtitcalLevel { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int SupplierId { get; set; }

        public  virtual Supplier Supplier { get; set; }
    }
}
