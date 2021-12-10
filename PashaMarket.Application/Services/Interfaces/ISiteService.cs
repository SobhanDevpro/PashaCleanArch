using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PashaMarket.Domain.Entities.Site;

namespace PashaMarket.Application.Services.Interfaces
{
    public interface ISiteService

    {
        List<SiteBanner> GetSiteBannersByPlacement(List<BannerPlacement> placements);
    }
}
