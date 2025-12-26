namespace Introduction.Middleware
{
    public class LoggingMiddleware
    {
        RequestDelegate _next;

        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {


            var path = context.Request.Path;
            var method = context.Request.Method;
            var timestamp = DateTime.UtcNow;


            Console.WriteLine("********** Request Log **********");
            Console.WriteLine($"Timestamp: {timestamp}");
            Console.WriteLine($"Method: {method}");
            Console.WriteLine($"Path: {path}");
            await _next(context);


        }
    }
}
