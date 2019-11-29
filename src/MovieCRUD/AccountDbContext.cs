using Microsoft.AspNet.Identity.EntityFramework;
using MovieCRUD.Web;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieCRUD.Web
{
    public class AccountDbContext : IdentityDbContext<ApplicationUser>
    {
        public AccountDbContext() : base("IdentityDb") {}

        public static AccountDbContext Create()
        {
            return new AccountDbContext();
        }
    }
}