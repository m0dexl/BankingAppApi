using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class TransactionCreateDto
    {
        public int Amount { get; set; } = default!;
        public int SenderCustomerId { get; set; } = default!;
        public int ReceiverCustomerId { get; set; } = default!;
    }
}
