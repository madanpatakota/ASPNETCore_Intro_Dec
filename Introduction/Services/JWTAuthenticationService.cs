using Introduction.Contracts;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Introduction.Services
{
    public class JWTAuthenticationService : IJWTAuthenticatoin
    {



        // issuer , audiance , secret key , cliams  , sing creds

       // claims  user name , role , mail , mobile , postal code  ifn

        //cutomer token  "Madan"

        private readonly string _issuer    = "HDFCBank";
        private readonly string _audience  = "HDFCTellers";
        private readonly string _secret    = "HDFC!23456";



        public string GenerateJWTToken(string username, string password)
        {
            //throw new NotImplementedException();

            var cliams = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, "Customer"),
                new Claim(ClaimTypes.Email, "madan.patakota@mgail.com"),
                new Claim(ClaimTypes.MobilePhone, "123-456-7890"),
                new Claim(ClaimTypes.PostalCode, "500081")
            };

            //Bytes   0-255
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secret));


            //hmac sha256

            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);


            //token
            var token = new JwtSecurityToken(
                issuer : _issuer,
                audience : _audience,
                claims : cliams,
                expires : DateTime.UtcNow.AddMinutes(30),
                signingCredentials : signingCredentials
            );     
            
            
            //object to string  -- ser

            //strint to object -- deseri


            //serializatin fomat   and deseria

            var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);    //eyadasdfasdadfasfasdfa

            return jwtToken;


        }

        public bool ValidateJWTToken(string token)
        {
            throw new NotImplementedException();
        }
    }
}
