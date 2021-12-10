using System.IO;
using System.Security;

namespace PashaMarket.Application.StaticItems
{
    public static class PathTools
    {
        #region default

        public static string DefaultImagePath = "/images/defaults/NoImage.png";

        #endregion

        #region product

        public static string ProductImagePath = "/images/products/main/";

        public static string ProductImageUploadPath =
            Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot/images/products/main/");

        public static string ProductThumbImagePath = "/images/products/thumb/";

        public static string ProductThumbImageUploadPath =
            Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot/images/products/thumb/");

        #endregion


        #region user avatar

        public static string DefaultAvatar = "/images/man.png";

        #endregion


        #region user avatar

        public static string UserAvatarOrigin = "/Content/Images/UserAvatar/origin";
        public static string UserAvatarOriginServer =
            Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Images/UserAvatar/origin");


        public static string UserAvatarThumb = "/Content/Images/UserAvatar/Thumb";
        public static string UserAvatarThumbServer = 
            Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Content/Images/UserAvatar/Thumb");

        #endregion


        #region banner

        public static string BannerOrigin = "/images/slider-main/";

        #endregion
    }
}
