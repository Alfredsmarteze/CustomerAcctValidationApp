using DataContextStructure;
using DataStucture;
using DataStucture.Entity;
using DataStucture.ResponseModel;
using Infrastructure.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly TransactionContext _context;

        public TransactionRepository(TransactionContext context)
        {
            this._context = context;
        }
        public async Task<bool> AddTransaction(TransactionModelDTO model)
        {
            bool result;

            var tran = new TransactionModel
            {
                Surname = model.Surname,
                Firstname = model.Firstname,
                AccountName = model.AccountName,
                AccountNumber = model.AccountNumber,
                TransactionAmount = model.TransactionAmount,
            };
            _context.transactionTbl.Add(tran);
            result = await _context.SaveChangesAsync() > 0;

            if (result)
            {
                bool success = true;
                var tranId = _context.transactionTbl.FirstOrDefault(s => s.Id == tran.Id);
                if (tranId != null)
                {
                    tranId.TransactionStatus = success;
                }
                result = await _context.SaveChangesAsync() > 0;
            }
            return result;
        }

        public async Task<ResponseModel> CheckStatus(int tranId)
        {
            var chkStatus = _context.transactionTbl.FirstOrDefault(_w => _w.TransactionStatus == true && _w.Id == tranId);
            if (chkStatus !=null)
            {
                return (new ResponseModel { Msg = "Transaction Successful" });
            }
            return (new ResponseModel { Msg = "Transaction Decline" });
        }
    }
}
