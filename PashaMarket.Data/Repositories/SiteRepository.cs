using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PashaMarket.Data.Context;
using PashaMarket.Domain.Entities.Site;
using PashaMarket.Domain.IRepositories;

namespace PashaMarket.Data.Repositories
{
    public class SiteRepository : ISiteRepository
    {

        #region constructor

        private readonly PashaContext _context;

        public SiteRepository(PashaContext context)
        {
            _context = context;
        }

        #endregion


        public IQueryable<SiteBanner> GetSiteBanner()
        {
            return _context.SiteBanners.AsQueryable();
        }
    }
}
