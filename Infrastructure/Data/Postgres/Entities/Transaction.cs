using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Transaction: Entity<int>
    {
        public int Amount { get; set; } = default!;

        public int SenderCustomerId { get; set; } = default!;

        // user silindiğinde transactionlarda silinmesin diye ilişkiyi kaldırdım
        //public Customer SenderCustomer { get; set; }

        public int ReceiverCustomerId { get; set; } = default!;
    }
}
