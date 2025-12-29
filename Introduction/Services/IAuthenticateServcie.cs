namespace Introduction.Services
{
    public interface IAuthenticateServcie
    {



        //Token Generation Method
        string GenerateToken(string username, string password);


        // User Validation Method
        bool ValidateUser(string username, string password);
    }
}
