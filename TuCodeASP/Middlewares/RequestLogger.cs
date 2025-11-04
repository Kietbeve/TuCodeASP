using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace TuCodeASP.Middlewares
{
    public class RequestLogger
    {
        private readonly RequestDelegate _next;
        public RequestLogger(RequestDelegate next) { _next = next; }
        public async Task Invoke(HttpContext context)
        {
            Console.WriteLine($"---Request den: {context.Request.Path}  Method: {context.Request.Method}---");
            await _next(context);
            Console.WriteLine($"---> Response for: {context.Request.Path} Method: {context.Request.Method}" +
                $" with status: {context.Response.StatusCode}");
            Console.WriteLine("------------------------------");
        }
    }
}
