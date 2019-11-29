using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieCRUD.Web.ViewModels
{
    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        public bool RememberBrowser { get; set; }
        public bool RememberMe { get; set; }
    }
}