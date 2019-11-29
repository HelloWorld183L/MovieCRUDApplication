using System.ComponentModel.DataAnnotations;

namespace MovieCRUD.Web.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        public string Email { get; set; }
    }
}