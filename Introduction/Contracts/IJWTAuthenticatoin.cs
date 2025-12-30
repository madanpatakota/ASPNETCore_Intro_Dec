namespace Introduction.Contracts
{
    public interface IJWTAuthenticatoin
    {


        // email , password
        // phone number , password
        // username , password


        string GenerateJWTToken(string username, string password);

        bool ValidateJWTToken(string token);


    }
}
