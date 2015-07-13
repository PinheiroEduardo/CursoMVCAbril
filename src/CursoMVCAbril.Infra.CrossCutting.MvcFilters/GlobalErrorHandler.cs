using System.Web.Mvc;

namespace CursoMVCAbril.Infra.CrossCutting.MvcFilters
{
    public class GlobalErrorHandler : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);

            //Grava log
            if (filterContext.Exception != null)
            {
                filterContext.Controller.TempData["ErrorMessage"] = filterContext.Exception.Message;
            }
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
    }
}