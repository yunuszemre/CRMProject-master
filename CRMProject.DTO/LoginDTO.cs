using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.DTO
{
    public class LoginDTO
    {
        /// <summary>
        /// Kulanıcı Adı
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Şifre
        /// </summary>
        public string Password { get; set; }

        public string FullName { get; set; }
    }
}
