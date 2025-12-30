using Introduction.Contracts;

namespace Introduction.Middleware
{
    public class AuthenticationMiddleware
    {
        //Code will be added tomorrow

        RequestDelegate _next;
        IAuthenticateServcie authencationService;

        public AuthenticationMiddleware(RequestDelegate next, IAuthenticateServcie authenticateServcie)
        {
            _next = next;
            authencationService = authenticateServcie;
        }



        //httpcontet , header , path , body , querystring , params

        public async Task InvokeAsync(HttpContext context)
        {
            //Extract Token from Header
            var token = context.Request.Headers["Authorization"].ToString(); // token from Autherizon heaer
            if (token != null)
            {

                bool isTokenValid = authencationService.ValidateToken(token);

                if (isTokenValid)
                {
                    //Token is valid, proceed to the next middleware
                    await _next(context);
                    return;
                }


                //Validate the Token
                //This is just a placeholder logic for validation
                //if (token == "madan34##%%%#!#!@#@$@$@%@%@%@%$#HHHVF&*&&")
                //{
                //    //Token is valid, proceed to the next middleware
                //    await _next(context);
                //    return;
                //}
            }
            //If token is invalid or missing, return 401 Unauthorized
            context.Response.StatusCode = 401; // Unauthorized
            context.Response.Headers["TokenStatus"] = "Invalid or Missing Token";
        }


    }
}
