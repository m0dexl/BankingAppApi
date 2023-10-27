using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class TransactionConfiguration : BaseConfiguration<Transaction, int>
    {
        public override void Configure(EntityTypeBuilder<Transaction> builder)
        {
            base.Configure(builder);

            builder.Property(t => t.Amount).IsRequired();
            builder.Property(t => t.ReceiverCustomerId).IsRequired();

            // user silindiğinde transactionlarda silinmesin diye ilişkiyi kaldırdım

            //builder.HasOne(t => t.SenderCustomer)
            //    .WithMany(sc => sc.CustomerTransactions)
            //    .HasForeignKey(t => t.SenderCustomerId);
        }
    }
}
