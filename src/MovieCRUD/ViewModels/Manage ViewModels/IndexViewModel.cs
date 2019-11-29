using Microsoft.AspNet.Identity;
using System.Collections.Generic;

namespace MovieCRUD.Web.ViewModels
{
    public class IndexViewModel
    {
        public bool HasPassword { get; set; }
        public IList<UserLoginInfo> Logins { get; set; }
        public string PhoneNumber { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public bool BrowserRemembered { get; set; }
    }
}