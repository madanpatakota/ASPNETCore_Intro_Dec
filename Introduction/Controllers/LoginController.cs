using Microsoft.AspNetCore.Mvc;

using Introduction.Services;

namespace Introduction.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LoginController: ControllerBase
    {

        IAuthenticateServcie _authenticateServcie;
        public LoginController(IAuthenticateServcie authenticateServcie)
        {
            _authenticateServcie = authenticateServcie;
        }


        [HttpPost("LoginUser")]
        public IActionResult LoginUser([FromBody] LoginRequest request)
        {
            // Placeholder logic for user authentication
            if (request.Username == "Madan" && request.Password == "madan!1234")
            {
                var token = _authenticateServcie.GenerateToken(request.Username, request.Password);
                return Ok(new { Token = token });
            }
            return Unauthorized();
        }


        [HttpPost("ValidateUser")]
        public IActionResult ValidateUser([FromBody] LoginRequest request)
        {
            bool isValid = _authenticateServcie.ValidateUser(request.Username, request.Password);
            if (isValid)
            {
                return Ok(new { Message = "User is valid." });
            }
            return Unauthorized(new { Message = "Invalid user." });
        }


    }


    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
