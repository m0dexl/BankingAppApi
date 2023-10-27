using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class CustomerCreateDto
    {
        public string Phone_Number { get; set; } = default!;
        public string Address { get; set; } = default!;
        public int Balance { get; set; } = default!;
        public int CustomerUser_Id { get; set; } = default!;
    }
}
