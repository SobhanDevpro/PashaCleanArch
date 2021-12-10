using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using PashaMarket.Application.Services.Interfaces;
using PashaMarket.Domain.IRepositories;
using PashaMarket.Domain.ViewModels.Account;
using PashaMarket.web.HttpContextAccessories;

namespace PashaMarket.web.Areas.User.Controllers
{
    public class AccountController : UserBaseController
    {
        #region construvtor

        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        #endregion


        #region change password

        [HttpGet("change-password")]
        public IActionResult ChangePassword()
        {
            return View();
        }


        [HttpPost("change-password"), ValidateAntiForgeryToken]
        public IActionResult ChangePassword(ChangePasswordViewModel change)
        {
            if (ModelState.IsValid)
            {
                var res = _userService.ChangeUserPassword(change, User.GetUserId());
                if (res)
                {
                    TempData[SuccessMessage] = "کلمه ی عبور شما تغییر یافت";
                    TempData[InfoMessage] = "لطفا جهت تکمیل فرایند تغییر کلمه ی عبور ، مجددا وارد سایت شوید";
                    HttpContext.SignOutAsync();
                    return RedirectToAction("Login", "Account", new { area = "" });
                }
                else
                {
                    TempData[ErrorMessage] = "لطفا از کلمه ی عبور جدیدی استفاده کنید";
                    ModelState.AddModelError("NewPassword", "لطفا از کلمه ی عبور جدیدی استفاده کنید");
                }
            }
            return View(change);
        }


        #endregion


        #region edit profile

        [HttpGet("edit-profile")]
        public IActionResult EditProfile()
        {
            var userProfile = _userService.GetProfileForEdit(User.GetUserId());
            if (userProfile == null) return null;
            return View(userProfile);
        }

        [HttpPost("edit-profile"), ValidateAntiForgeryToken]
        public IActionResult EditProfile(EditUserViewModel profile, IFormFile avatarImage)
        {
            var result = _userService.EditUserProfile(profile, User.GetUserId(),avatarImage);
            switch (result)
            {
                case EditUserProfileResult.IsBlocked:
                    TempData[ErrorMessage] = "حساب کاربری شما بلاک شده است";
                    break;
                case EditUserProfileResult.IsNotActive:
                    TempData[ErrorMessage] = "حساب کاربری شما فعال نشده است";
                    break;
                case EditUserProfileResult.NotFound:
                    TempData[ErrorMessage] = "کاربری با مشصخات وارد شده یافت نشد";
                    break;
                case EditUserProfileResult.Success:
                    TempData[SuccessMessage] = $" {profile.FirstName} {profile.LastName}، پروفایل شما با موفقیت ویرایش شد";
                    return RedirectToAction("EditProfile");
                    break;
            }


            return View(profile);
        }

        #endregion
    }
}
