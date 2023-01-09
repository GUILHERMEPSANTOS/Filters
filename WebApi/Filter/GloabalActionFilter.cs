using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApi.Filter
{
    public class GloabalActionFilter : IActionFilter, IOrderedFilter
    {
        public int Order { get; set; }

        private readonly string _name;

        public GloabalActionFilter(string name, int order = 0)
        {
            Order = order;
            _name = name;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            System.Console.WriteLine($"name filter {_name} OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            System.Console.WriteLine($"name filter {_name} OnActionExecuting");
        }
    }
}