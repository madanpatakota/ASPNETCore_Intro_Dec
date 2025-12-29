
using Introduction.Middleware;

namespace Introduction.Extensions
{
    public static class MiddlewareExtenions
    {

        public static IApplicationBuilder UseHttpContextMiddlewareDemo(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpContextMiddleware>();
        }


        public static IApplicationBuilder UseLoggingContextMiddlewareDemo(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }



    }



    //public static class methodExtensionProgram
    //{
    //    public static int WordCount(this string str)
    //    {
    //        if (string.IsNullOrWhiteSpace(str))
    //        {
    //            return 0;
    //        }
    //        string[] words = str.Split(' ');   //2
    //        return words.Length;
    //    }

    //}



    //public class program
    //{
    //    public static void Main(string[] args)
    //    {
    //        string str = "hello world from middleware";
    //        int count = str.WordCount();
    //        Console.WriteLine($"Word Count: {count}");
    //    }
    //}
}




