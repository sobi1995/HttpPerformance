using System.Diagnostics;  
using System.IO;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Builder;  
using Microsoft.AspNetCore.Http;  
namespace hppt
{
public static class MyMiddlewareExtensions
{
    public static IApplicationBuilder  UseMyMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ResponseTimeMiddleware>();
    }
} 
}