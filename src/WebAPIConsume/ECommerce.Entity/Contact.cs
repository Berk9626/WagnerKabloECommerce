using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Entity
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FullName { get; set; }
        public string  Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
