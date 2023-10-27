using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Customer : Entity<int>
    {
        public string Phone_Number { get; set; } = default!;
        public string Address { get; set; } = default!;
        public int Balance { get; set; } = default!;


        public int CustomerUser_Id { get; set; }
        public User CustomerUser { get; set; }

        //public ICollection<Transaction> CustomerTransactions { get; set; }
    }
}
