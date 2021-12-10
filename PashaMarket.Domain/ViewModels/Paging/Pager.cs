using System;

namespace PashaMarket.Domain.ViewModels.Paging
{
    public class Pager
    {
        public static BasePaging Build(int page, int allEntitiesCount, int take, int howManyShowAfterBefore)
        {
            var allPagesCount = (int)Math.Ceiling(allEntitiesCount / (double)take);

            var pageNumber = page > allPagesCount ? allPagesCount : page;

            return new BasePaging
            {
                Page = pageNumber,
                AllEntitiesCount = allEntitiesCount,
                AllPagesCount = allPagesCount,
                HowManyPagesShowAfterBefore = howManyShowAfterBefore,
                Take = take,
                Skip = (pageNumber - 1) * take,
                StartPage = pageNumber > howManyShowAfterBefore ? pageNumber - howManyShowAfterBefore : 1,
                EndPage = page + howManyShowAfterBefore > allPagesCount ? allPagesCount : page + howManyShowAfterBefore
            };
        }
    }
}
