

//MIddleware is nothing but kind of gate keeper of your every request and response.





// weapons you have to use


//RequestDelegate 


// httpcontext



namespace Introduction.Middleware
{



    public class HttpContextMiddleware
    {

        RequestDelegate _next;

        public HttpContextMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        // Logic 
        // i want to write the logic for get the headers of the context , path , body etc
        // i want to wrotte the logoc for to append the headers to the response

        public async Task InvokeAsync(HttpContext context)
        {
            //var context = HttpContext;


            var headers = context.Request.Headers;
            var body = context.Request.Body;
            var path = context.Request.Path;



            Console.WriteLine("********** Incoming Request **********");
            Console.WriteLine($"Path: {path}");
            Console.WriteLine($"Headers: {headers}");


            await _next(context);


           // var abc = 120;


            //context.Response.OnStarting(() =>
            //{
            //   // context.Response.Headers.Append("x-demo-response", "This is from Asp.netCore Middleware");
            //    //context.Response.Headers.Append("x-demo-MessageStatu", "Successful from Middleware");

            //    Console.WriteLine("********** Outgoing Response Start **********");
            //    //context.Response.Headers["x-demo-response"]  = "This is from Asp.netCore Middleware";
            //    //context.Response.Headers["x-demo-MessageStatu"] = "Successful from Middleware";

            //    Console.WriteLine($"Headers: {context.Response.Headers}");

            //    Console.WriteLine("********** Outgoing Response End**********");

            //    return Task.CompletedTask;
            //});


            //  HttpContext.Response.Headers.Append("x-demo-response", "This is from Asp.netCore");
            // HttpContext.Response.Headers.Append("x-demo-MessageStatu", "Scussfull");



        }




    }
}
