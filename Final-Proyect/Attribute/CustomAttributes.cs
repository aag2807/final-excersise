
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Web;
using System.Web.Mvc;

namespace Final_Proyect.Attribute
{
    public class CustomAttributes: AuthorizeAttribute, Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            object user = context.HttpContext.Session.GetString("Session");
            if (user != null)
            {
                
            }
            else
            {
                context.HttpContext.Response.Redirect("/Login");
            }
        }
    }
    
}
