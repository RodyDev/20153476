using System.Net;
using DogKeepers.Server.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DogKeepers.Server.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception.GetType() == typeof(BusinessException))
            {
                var exception = (BusinessException)context.Exception;
                var validation = new 
                {
                    status = 400,
                    title = "Business Exception",
                    detail = exception.Message
                };

                var jsonData = new
                {
                    errors = new[]{ validation }
                };

                context.Result = new BadRequestObjectResult(jsonData);
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.ExceptionHandled = true;
            }
        }
    }
}