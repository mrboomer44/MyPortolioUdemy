using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.Dal.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
         MyPortfolioContext myPortfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = myPortfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = myPortfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = myPortfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}
