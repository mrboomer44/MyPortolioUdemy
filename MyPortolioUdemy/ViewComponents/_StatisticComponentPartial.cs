using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.Dal.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext _context;
        public _StatisticComponentPartial(MyPortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
