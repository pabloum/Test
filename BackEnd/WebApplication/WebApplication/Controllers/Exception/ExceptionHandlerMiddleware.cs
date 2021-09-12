using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExceptionHandlerMiddleware> logger;

        public ExceptionHandlerMiddleware(RequestDelegate next, ILogger<ExceptionHandlerMiddleware> logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                context.Request.EnableBuffering();
                await next(context);
            }
            catch (InvalidOperationException e)
            {
                await HandleExceptionAsync(context, e, HttpStatusCode.BadRequest);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(context, e, HttpStatusCode.InternalServerError);
            }
        }

        private async Task<Task> HandleExceptionAsync(HttpContext context, Exception exception, HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
        {
            var request = await FormatRequest(context.Request);
            string result = new ErrorDetails() { Message = exception.Message, StatusCode = (int)statusCode }.ToString();
            context.Response.StatusCode = (int)statusCode;

            IPHostEntry heserver = Dns.GetHostEntry(Dns.GetHostName());

            var ipAddress = heserver.AddressList.ToList().Where(p => p.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).FirstOrDefault().ToString();

            var dictionary = new Dictionary<string, string>
                {
                    { "ipaddress", ipAddress},
                    {"request",request }
                };

            logger.LogError(exception, request);
            return context.Response.WriteAsync(result);
        }

        private async Task<string> FormatRequest(HttpRequest request)
        {
            if (request.ContentLength != null)
            {
                request.Body.Position = 0;
            }

            var buffer = new byte[Convert.ToInt32(request.ContentLength)];
            await request.Body.ReadAsync(buffer, 0, buffer.Length).ConfigureAwait(false); ;
            var bodyAsText = Encoding.UTF8.GetString(buffer);

            return $"{request.Scheme} {request.Host}{request.Path} {request.QueryString} {bodyAsText}";
        }
    }

    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}