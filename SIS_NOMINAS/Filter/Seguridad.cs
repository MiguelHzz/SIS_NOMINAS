
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
//using CapaEntidad;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TMGROUP.Filter
{
    public class Seguridad : IPageFilter
    {
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            //throw new NotImplementedException();
        }


        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            string usu = context.HttpContext.Session.GetString("persona");

            if (usu == null && !context.HttpContext.Request.Path.StartsWithSegments("/LoginTmg/Login"))
            {
                context.Result = new RedirectResult("/LoginTmg/Login");
            }
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            //throw new NotImplementedException();
        }
    }
}
