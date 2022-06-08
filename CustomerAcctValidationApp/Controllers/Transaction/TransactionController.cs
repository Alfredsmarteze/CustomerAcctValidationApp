using DataStucture;
using Infrastructure.IService;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAcctValidationApp.Controllers.Transaction
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionRepository transaction;

        public TransactionController(ITransactionRepository transaction)
        {
            this.transaction = transaction;
        }

        [HttpPost, Route("Create Transaction")]
        public async Task<IActionResult> Create(TransactionModelDTO transactionDTO)
        {
            try
            {
                if (string.IsNullOrEmpty(transactionDTO.Surname))
                {
                    return BadRequest("Surname is needed");
                }
                if (string.IsNullOrEmpty(transactionDTO.AccountNumber))
                {
                    return BadRequest("Please provide an account number");
                }
                var createTrn = await transaction.AddTransaction(transactionDTO);
                if (createTrn == false)
                {
                    return NotFound($"Transaction not successful: {createTrn}");
                }
                var res = await transaction.CheckStatus(transactionDTO.Id);
                return Ok(res);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpGet, Route("Check Transaction Status")]
        public async Task<IActionResult> CheckStatus(int transactionId)
        {
            var checkStatus = await transaction.CheckStatus(transactionId);
            if (checkStatus == null)
            { 
                return NotFound();
            }
            return Ok(checkStatus);
        
        }
    }
}
