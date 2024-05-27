using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace News.Asp.net.ViewsComponents.BreakingNews
{
    public class BreakingNewsList : ViewComponent
    {
        private readonly IPost _post;

        public BreakingNewsList(IPost post)
        {
            _post = post;
        }

        public IViewComponentResult Invoke()
        {
            var values = _post.GetAll();
            return View(values.OrderByDescending(x=>x.Title));
        }
    }
}
