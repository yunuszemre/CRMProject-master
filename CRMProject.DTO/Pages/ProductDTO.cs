using CRMProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.DTO.Pages
{
    public class ProductDTO
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public int UnitsInStock { get; set; }

        public int UnitsInOrder { get; set; }

        public int CrtitcalLevel { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public Product Category { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        public DateTime? RecordDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
