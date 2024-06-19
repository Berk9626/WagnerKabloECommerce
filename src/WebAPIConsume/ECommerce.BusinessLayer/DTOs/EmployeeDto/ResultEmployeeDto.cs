using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.DTOs.EmployeeDto
{
    public class ResultEmployeeDto
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeComment { get; set; }
        public string Title { get; set; }
    }
}
