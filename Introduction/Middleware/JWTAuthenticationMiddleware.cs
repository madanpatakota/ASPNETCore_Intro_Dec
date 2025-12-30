namespace Introduction.Middleware
{
    public class JWTAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        public JWTAuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {

            bool isLoginPath = context.Request.Path.ToString().Contains("Login");
            if (isLoginPath)
            {
                // If the request is for the login path, skip JWT authentication
                await _next(context);
                return;
            }
            else
            {



                //PLease give your JWT Token
            }




            // Middleware logic for JWT authentication can be added here
            // Call the next middleware in the pipeline
            //await _next(context);
        }

    }
}
