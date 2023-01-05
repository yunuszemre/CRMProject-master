using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.Entities.Abstract
{
    public class BaseEntity
    {
        /// <summary>
        /// Kayıt Tarihi
        /// </summary>
        public DateTime RecordDate { get; set; }
        /// <summary>
        /// Güncelleme Tarihi
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }
}
