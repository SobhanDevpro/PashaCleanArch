using Microsoft.AspNetCore.Http;
using PashaMarket.Domain.Entities.Account;
using PashaMarket.Domain.ViewModels.Account;

namespace PashaMarket.Application.Services.Interfaces
{
    public interface IUserService
    {
        RegisterUserResult RegisterUser(RegisterUserViewModel register);
        bool IsUserExistsByMobileNumber(string mobile);

        LoginUserResult GetUserForLogin(LoginUserViewModel login);

        User GetUserByMobile(string mobile);

        ForgotPasswordResult RecoverUserPassword(ForgotPasswordViewModel forgot);

        bool ChangeUserPassword(ChangePasswordViewModel changePass, int currentUserId);

        EditUserViewModel GetProfileForEdit(int userId);

        EditUserProfileResult EditUserProfile(EditUserViewModel profile , int userId, IFormFile avatarImage);

    }
}