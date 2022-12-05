using HotelListing.API.Exceptions;
using Newtonsoft.Json;
using System.Net;

namespace HotelListing.API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandelExceptionAsync(context, ex);
            }
        }

        private Task HandelExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
            var errorDetails = new ErrorDetails { 
                ErrorType = "Failure",
                ErrorMessage= ex.Message
            };
            switch (ex)
            {
                case NotFoundException notFoundException:
                    statusCode = HttpStatusCode.NotFound;
                    errorDetails.ErrorType= "Not Found";
                    break;
                default:
                    break;
            }

            //serialize our error 
            string response = JsonConvert.SerializeObject(errorDetails);
            context.Response.StatusCode=(int)statusCode;
            return context.Response.WriteAsync(response);
        }
    }
}
