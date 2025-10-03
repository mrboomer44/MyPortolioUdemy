using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.Dal.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext _context;
        public _FeatureComponentPartial(MyPortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Features.FirstOrDefault();
            return View(values);
        }
    }
}
