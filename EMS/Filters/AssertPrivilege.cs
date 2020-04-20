using EMS.ManagerRepository.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Controllers;

using System.Web;
using EMS.DbModelRepository.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace EMS.Filters
{
    public class AssertPrivilege : ActionFilterAttribute
    {
        private List<string> _privilege;
        private int CustomerId;
        private IEnumerable<string> CustomerIds;
        public PrivilegeManager _privilegeManager;
        public AssertPrivilege(string privilege)
        {
            this._privilege = privilege.Split(",".ToCharArray()).ToList();
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            CheckPermissionsAsync(context).Wait();
            base.OnActionExecuting(context);
        }




        private Task CheckPermissionsAsync(ActionExecutingContext actionContext)
        {
            CustomerIds = actionContext.HttpContext.Request?.Headers["CustomerId"];
            _privilegeManager = (PrivilegeManager)actionContext.HttpContext.RequestServices.GetService
                (typeof(PrivilegeManager));
            if (CustomerIds.Count() == 0)
            {
                actionContext.Result = new ObjectResult(actionContext.ModelState)
                {
                    Value = "You are not authorised to perform this action, Customer Id header missing",
                    StatusCode = StatusCodes.Status403Forbidden
                };
                return Task.CompletedTask;
            }
            else
            {
                CustomerId = Convert.ToInt32(CustomerIds.FirstOrDefault());
            }
            var listOfPrivileges = Task
               .Run(async () => await _privilegeManager.GetAllPrivileges()).Result;
            var customerPrivileges = Task
                .Run(async () => await _privilegeManager.GetCustomerPrivileges(CustomerId)).Result;
            var customerPrivilegeIds = customerPrivileges.Select(x => x.PrivilegeId).ToList();
            var customerPrivilegesName = listOfPrivileges.Where(x => customerPrivilegeIds.Contains(x.Id)).Select(n => n.PrivilegeName).ToList();
          if(!this._privilege.Any(customerPrivilegesName.Contains))
            {
                actionContext.Result = new ObjectResult(actionContext.ModelState)
                {
                    Value = "You are not authorised to perform this action, Dont have Privilege",
                    StatusCode = StatusCodes.Status403Forbidden
                };
                return Task.CompletedTask;
            }

            return Task.CompletedTask;
        }
    }
}
