using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.Dal.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext _context;
        public _FooterComponentPartial(MyPortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
