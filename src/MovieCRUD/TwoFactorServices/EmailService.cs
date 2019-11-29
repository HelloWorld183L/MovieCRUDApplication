using Microsoft.AspNet.Identity;
using System.Threading.Tasks;

namespace MovieCRUD.TwoFactorServices
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // TODO: Create email service
            return Task.FromResult(0);
        }
    }
}