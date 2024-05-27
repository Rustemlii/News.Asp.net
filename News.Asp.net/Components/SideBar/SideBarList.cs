using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace News.Asp.net.Components.SideBar
{
	public class SideBarList : ViewComponent
	{
		private readonly IPost _post;

		public SideBarList(IPost post)
		{
			_post = post;
		}

		public IViewComponentResult Invoke()
		{
			var values = _post.GetAll();
			return View(values.OrderByDescending(x => x.Title).Take(2));
		}
	}
}
