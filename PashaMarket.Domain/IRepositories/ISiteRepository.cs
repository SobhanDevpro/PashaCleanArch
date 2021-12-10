using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PashaMarket.Domain.Entities.Site;

namespace PashaMarket.Domain.IRepositories
{
  public  interface ISiteRepository
    {
        IQueryable<SiteBanner> GetSiteBanner();
    }
}
