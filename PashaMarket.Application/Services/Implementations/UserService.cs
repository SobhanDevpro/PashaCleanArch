using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using PashaMarket.Application.Extensions;
using PashaMarket.Application.Services.Interfaces;
using PashaMarket.Application.StaticItems;
using PashaMarket.Application.Utils;
using PashaMarket.Domain.Entities.Account;
using PashaMarket.Domain.IRepositories;
using PashaMarket.Domain.ViewModels.Account;

namespace PashaMarket.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        #region constructor

        private readonly IUserRepository _userRepository;
        private readonly IPasswordHelper _passwordHelper;

        public UserService(IUserRepository userRepository, IPasswordHelper passwordHelper)
        {
            _userRepository = userRepository;
            _passwordHelper = passwordHelper;
        }




        #endregion

        #region account

        public RegisterUserResult RegisterUser(RegisterUserViewModel register)
        {
            if (!IsUserExistsByMobileNumber(register.Mobile))
            {
                var user = new User
                {
                    FirstName = register.FirstName.SanitizeText(),
                    LastName = register.LastName.SanitizeText(),
                    Mobile = register.Mobile.SanitizeText(),
                    Password = register.Password.SanitizeText(),
                    MobileActiveCode = new Random().Next(10000, 999999).ToString(),
                    EmailActiveCode = Guid.NewGuid().ToString("N")
                };
                _userRepository.AddUser(user);
                _userRepository.SaveChanges();

                //todo: Send activation mobile code to user
                return RegisterUserResult.Success;
            }

            return RegisterUserResult.MobileExists;
        }


        public bool IsUserExistsByMobileNumber(string mobile)
        {
            return _userRepository.GetUsers().AsQueryable().Any(s => s.Mobile == mobile);
        }

        public LoginUserResult GetUserForLogin(LoginUserViewModel login)
        {
            var user = GetUserByMobile(login.Mobile);

            if (user == null) return LoginUserResult.NotFound;

            if (!user.IsMobileActive) return LoginUserResult.NotActivated;

            if (user.Password != login.Password) return LoginUserResult.NotFound;

            return LoginUserResult.Success;

        }

        public User GetUserByMobile(string mobile)
        {
            return _userRepository.GetUsers().AsQueryable()
                .SingleOrDefault(s => s.Mobile == mobile);
        }

        public ForgotPasswordResult RecoverUserPassword(ForgotPasswordViewModel forgot)
        {
            var user = _userRepository.GetUsers().AsQueryable()
                .SingleOrDefault(s => s.Mobile == forgot.Mobile);

            if (user == null) return ForgotPasswordResult.NotFound;
            var newPassword = new Random().Next(1000000, 999999999).ToString();
            user.Password = newPassword;
            _userRepository.EditUser(user);
            //todo: send new password to user with sms
            _userRepository.SaveChanges();
            return ForgotPasswordResult.Success;
        }

        public bool ChangeUserPassword(ChangePasswordViewModel changePass, int currentUserId)
        {
            var user = _userRepository.GetUserById(currentUserId);
            if (user != null)
            {
                var newPassword = changePass.NewPassword;
                if (newPassword != user.Password)
                {
                    user.Password = newPassword;
                    _userRepository.EditUser(user);
                    _userRepository.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        public EditUserViewModel GetProfileForEdit(int userId)
        {
            var user = _userRepository.GetUserById(userId);
            if (user == null) return null;

            return new EditUserViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Avatar = user.Avatar
            };
        }

        public EditUserProfileResult EditUserProfile(EditUserViewModel profile, int userId, IFormFile avatarImage)
        {
            var user = _userRepository.GetUserById(userId);
            if (user == null) return EditUserProfileResult.NotFound;
            if (user.IsBlocked) return EditUserProfileResult.IsBlocked;
            if (!user.IsMobileActive) return EditUserProfileResult.IsNotActive;

            user.FirstName = profile.FirstName;
            user.LastName = profile.LastName;

            if (avatarImage != null && avatarImage.IsImage())
            {
                var imageName = Guid.NewGuid().ToString("N") + Path.GetExtension(avatarImage.FileName);

                avatarImage.AddImageToServer(imageName, PathTools.UserAvatarOriginServer,
                    100,100,PathTools.UserAvatarThumbServer,user.Avatar);
                user.Avatar = imageName;
            }
            
            _userRepository.EditUser(user);
            _userRepository.SaveChanges();

            return EditUserProfileResult.Success;
        }

        #endregion

    }
}
