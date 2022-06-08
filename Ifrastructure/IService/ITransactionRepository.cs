using DataStucture;
using DataStucture.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.IService
{
    public interface ITransactionRepository
    {
        Task<bool> AddTransaction(TransactionModelDTO transactionModelDTO);
        Task<ResponseModel> CheckStatus(int tranId);
    }
}
