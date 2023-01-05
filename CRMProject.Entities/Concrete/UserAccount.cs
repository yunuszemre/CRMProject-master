using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.Entities.Concrete
{
    using Abstract;

    public class UserAccount : BaseEntity
    {
        /// <summary>
        /// Kullanıcı Id
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// Kullanıcı Adı
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Şifre
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Tam Adı
        /// </summary>
        public string Fullname { get; set; }
    }
}
