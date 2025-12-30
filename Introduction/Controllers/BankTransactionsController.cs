using Introduction.Contracts;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Introduction.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class BankTransactionsController : ControllerBase
    {

        IJWTAuthenticatoin _jWTAuthenticatoin;

        public BankTransactionsController(IJWTAuthenticatoin jWTAuthenticatoin)
        {
            _jWTAuthenticatoin = jWTAuthenticatoin;
        }

        [HttpGet]
        [Route("/gettransactions")]
        public IActionResult GetTransactions()
        {
            return Ok(new { Message = "Bank Transactions are 10" });
        }
    }
}
