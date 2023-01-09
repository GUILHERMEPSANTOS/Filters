
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApi.Filter
{
    public class SampleActionFilterAttribute : ActionFilterAttribute
    {
        private readonly string _name;
        public SampleActionFilterAttribute(string name)
        {
            this._name = name;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            System.Console.WriteLine("OnActionExecuted in SampleActionFilterAttribute");
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            System.Console.WriteLine("OnActionExecuting in SampleActionFilterAttribute");
        }
    }
}