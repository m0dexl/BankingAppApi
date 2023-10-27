using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class TransactionUpdateDto
    {
        public int Amount { get; set; }
        public int SenderCustomerId { get; set; }
        public int ReceiverCustomerId { get; set; }
    }
}
