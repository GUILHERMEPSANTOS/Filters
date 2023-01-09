
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApi.Filter
{
    public class SampleActionFilterAttribute : ActionFilterAttribute, IOrderedFilter
    {
        public int Order { get; set; }
        private readonly string _name;
        public SampleActionFilterAttribute(string name, int order = 0)
        {
            this._name = name;
            Order = order;
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            System.Console.WriteLine($"OnActionExecuted in {_name}");
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            System.Console.WriteLine($"OnActionExecuting in {_name}");
        }
    }
}