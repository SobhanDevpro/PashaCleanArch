using PashaMarket.Application.StaticItems;
using PashaMarket.Domain.Entities.Site;

namespace PashaMarket.Application.EntitiesExtensions
{
    public static class BannerExtension
    {
        public static string GetBannerMainImageAddress(this SiteBanner banner)
        {
            return PathTools.BannerOrigin + banner.ImageName;
        }
    }
}
