using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PashaMarket.Application.Services.Interfaces;
using PashaMarket.Domain.Entities.Site;
using PashaMarket.Domain.IRepositories;

namespace PashaMarket.Application.Services.Implementations
{
    public class SiteService : ISiteService

    {
        #region constructor

        private readonly ISiteRepository _siteRepository;

        public SiteService(ISiteRepository siteRepository)
        {
            _siteRepository = siteRepository;
        }

        #endregion

        public List<SiteBanner> GetSiteBannersByPlacement(List<BannerPlacement> placements)
        {
            return _siteRepository.GetSiteBanner().AsQueryable()
                .Where(s => placements.Contains(s.BannerPlacement)).ToList();
        }
    }
}
