using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.Dal.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext _context;
        public _PortfolioComponentPartial(MyPortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Portfolios.ToList();
            return View(values);
        }
    }
}
