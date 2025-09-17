using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy.ViewComponents
{
    public class _NowbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
