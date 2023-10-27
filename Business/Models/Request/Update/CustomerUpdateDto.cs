using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class CustomerUpdateDto
    {
        public string Phone_Number { get; set; }
        public string Address { get; set; }
        public int Balance { get; set; }
        public int CustomerUser_Id { get; set; }
    }
}
