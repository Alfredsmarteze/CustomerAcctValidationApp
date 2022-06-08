using DataStucture.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataContextStructure
{
    public class TransactionContext: DbContext
    {
        public TransactionContext(DbContextOptions<TransactionContext> options): base(options)
        { 
        
        }

        public DbSet<TransactionModel> transactionTbl { get; set; }

    }
}