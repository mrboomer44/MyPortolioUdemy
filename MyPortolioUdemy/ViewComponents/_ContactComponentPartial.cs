using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.Dal.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext _context;
        public _ContactComponentPartial(MyPortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Contacts.ToList();
            return View(values);
        }
    }
}
