using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApi.Filter
{
    public class GloabalActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            System.Console.WriteLine("OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            System.Console.WriteLine("OnActionExecuting");
        }
    }
}