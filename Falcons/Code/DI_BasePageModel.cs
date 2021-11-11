using Falcons.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Falcons.Code
{
    public class DI_BasePageModel:PageModel
    {
        protected ApplicationDbContext Context { get; }
        protected IAuthorizationService AuthorizationService { get; }
        protected UserManager<IdentityUser> UserManager { get; }
        protected RoleManager<IdentityRole> RoleManager { get; }

        public DI_BasePageModel(
            ApplicationDbContext authcontext,
            IAuthorizationService authorizationService,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager) : base()
        {
            Context = authcontext;
            UserManager = userManager;
            RoleManager = roleManager;
            AuthorizationService = authorizationService;
        }

    }
}
