using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.Dal.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext _context;
        public _SkillComponentPartial(MyPortfolioContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }
    }
}
