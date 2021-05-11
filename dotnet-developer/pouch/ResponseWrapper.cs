using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace api
{
    public class ResponseWrapper
    {
        private readonly RequestDelegate _next;

        public ResponseWrapper(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var currentBody = context.Response.Body;

            using (var memoryStream = new MemoryStream())
            {
                //set the current response to the memorystream.
                context.Response.Body = memoryStream;

                await _next(context);

                //reset the body 
                context.Response.Body = currentBody;
                memoryStream.Seek(0, SeekOrigin.Begin);

                var readToEnd = new StreamReader(memoryStream).ReadToEnd();
                var objResult = JsonConvert.DeserializeObject(readToEnd);
                var result = CommonApiResponse.Create((HttpStatusCode)context.Response.StatusCode, objResult, null);
                await context.Response.WriteAsync(JsonConvert.SerializeObject(result));
            }
        }

    }

    public static class ResponseWrapperExtensions
    {
        public static IApplicationBuilder UseResponseWrapper(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ResponseWrapper>();
        }
    }


    public class CommonApiResponse
    {
        public static CommonApiResponse Create(HttpStatusCode statusCode, object result = null, string errorMessage = null)
        {
            return new CommonApiResponse(statusCode, result, errorMessage);
        }


    
        public int Code { get; set; }
         
        public string Message { get; set; }
 
        public object Data { get; set; }

   
        public bool Status { get; set; }

        protected CommonApiResponse(HttpStatusCode statusCode, object result = null, string errorMessage = null)
        {

            Code = (int)statusCode;
            Status = (int)statusCode >= 200 && (int)statusCode < 300;
            Data = result;
            Message = errorMessage;
        }
    }
}
