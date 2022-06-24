using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrationApp.Domain.Models
{
    public class User : DomainObject
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
