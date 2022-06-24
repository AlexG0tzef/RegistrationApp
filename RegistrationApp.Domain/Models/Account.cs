using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrationApp.Domain.Models
{
    public class Account : DomainObject
    {
        public User AccountUser { get; set; }

    }
}
