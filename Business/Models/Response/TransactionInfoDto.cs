using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class TransactionInfoDto
    {
        public int Id { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
        public int Amount { get; set; } = default!;

        public int SenderCustomerId { get; set; } = default!;
        public int ReceiverCustomerId { get; set; } = default!;

    }
}
