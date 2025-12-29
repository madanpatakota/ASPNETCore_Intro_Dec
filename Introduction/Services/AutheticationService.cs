namespace Introduction.Services
{
    public class AutheticationService : IAuthenticateServcie
    {


        //This will be we will concentrate on tomorrow
        private static readonly string myToken = "madan34##%%%#!#!@#@$@$@%@%@%@%$#HHHVF&*&&";


        public string GenerateToken(string username, string password)
        {
            if(username == "Madan" && password == "madan!1234")
            {
                return myToken;
            }
            else
            {
                return "Invalid User";
            }

           // return myToken;
            //throw new NotImplementedException();
        }

        public bool ValidateUser(string username, string password)
        {

            bool isValid = myToken.Contains(username);

            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }


              //  throw new NotImplementedException();
        }
    }
}
