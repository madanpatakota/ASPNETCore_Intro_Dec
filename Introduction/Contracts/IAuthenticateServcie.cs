namespace Introduction.Contracts
{
    public interface IAuthenticateServcie
    {



        //Token Generation Method
        string GenerateToken(string username, string password);


        // User Validation Method
        bool ValidateUser(string username, string password);


        bool ValidateToken(string token);
    }
}
