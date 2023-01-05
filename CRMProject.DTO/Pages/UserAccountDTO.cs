﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProject.DTO.Pages
{
    public class UserAccountDTO
    {
        public int UserId { get; set; }
      
        public string UserName { get; set; }
      
        public string Password { get; set; }

        public string FullName { get; set; }

        public DateTime? RecordDate { get; set; }

        public DateTime? ModifiedDate { get; set; }



    }
}
