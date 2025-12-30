using Microsoft.AspNetCore.Mvc;
using Introduction.Contracts;

namespace Introduction.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LoginController: ControllerBase
    {

        IAuthenticateServcie _authenticateServcie;
        IJWTAuthenticatoin _jWTAuthenticatoin;
        public LoginController(IAuthenticateServcie authenticateServcie , IJWTAuthenticatoin jWTAuthenticatoin)
        {
            _authenticateServcie = authenticateServcie;
            _jWTAuthenticatoin = jWTAuthenticatoin;
        }


        [HttpPost("LoginUser")]
        public IActionResult LoginUser([FromBody] LoginRequest request)
        {
            // Placeholder logic for user authentication
            if (request.Username == "Madan" && request.Password == "madan!1234")
            {
                //var token = _authenticateServcie.GenerateToken(request.Username, request.Password);
                var token   = _jWTAuthenticatoin.GenerateJWTToken(request.Username, request.Password);
                return Ok(new { Token = token });
            }
            return Unauthorized();
        }



        //endpoint : https://localhost:7246/api/login/getcustomers
        [HttpGet]
        [Route("GetCustomers")]

        public IActionResult GetCustomers()
        {
            return Ok("Customers are 5");
        }

        //[HttpPost("ValidateUser")]
        //public IActionResult ValidateUser([FromBody] LoginRequest request)
        //{
        //    bool isValid = _authenticateServcie.ValidateUser(request.Username, request.Password);
        //    if (isValid)
        //    {
        //        return Ok(new { Message = "User is valid." });
        //    }
        //    return Unauthorized(new { Message = "Invalid user." });
        //}


    }


    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
