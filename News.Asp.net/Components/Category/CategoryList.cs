using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace News.Asp.net.ViewsComponents.Category
{
	public class CategoryList : ViewComponent
	{
		private readonly ICategory _category;

		public CategoryList(ICategory category)
		{
			_category = category;
		}
		public IViewComponentResult Invoke()
		{
			var values = _category.GetAll();
			return View(values);
		}
	}
}
