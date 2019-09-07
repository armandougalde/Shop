using Microsoft.AspNetCore.Identity;
using Shop.Web.Data.Entities;
using Shop.Web.Models;
using System.Threading.Tasks;

namespace Shop.Web.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserByEmailAsync(string mail);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<SignInResult> LogingAsync(LoginViewModel model);

        Task LogoutAsync();

        Task<IdentityResult> UpdateUserAsync(User user);

        Task<IdentityResult> ChangePasswordAsync(User user, string oldPassword, string newPassword);

        Task<SignInResult> ValidatePasswordAsync(User user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        //ss
        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task GenerateEmailConfirmationTokenAsync(User user);

        Task ConfirmEmailAsync(User user, object token);
    }
}
