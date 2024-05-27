using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace News.Asp.net.Components.Slider
{
	public class SliderList : ViewComponent
	{
		private readonly IPost _post;

		public SliderList(IPost post)
		{
			_post = post;
		}

		public IViewComponentResult Invoke()
		{
			var values = _post.GetAll();
			return View(values);
		}
	}
}
