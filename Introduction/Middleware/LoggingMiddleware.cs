namespace Introduction.Middleware
{
    public class LoggingMiddleware
    {

        private readonly RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("********** Incoming Request **********");
            Console.WriteLine($"Method: {context.Request.Method}");
            Console.WriteLine($"Path: {context.Request.Path}");
            Console.WriteLine($"Headers: {context.Request.Headers}");

            await _next(context);

            Console.WriteLine("********** Outgoing Response **********");
            Console.WriteLine($"Status Code: {context.Response.StatusCode}");
        }

    }
}



//Techparks  -- gate keeprs           --- person --- guide ---, that building 

// project -- muliple middleware