using Business.Abstract;
using DataAccess.MyContext;
using Microsoft.AspNetCore.Mvc;

namespace News.Asp.net.Components.NewListTexno
{
	public class TexnologyList : ViewComponent
	{
		private readonly IPost _post;
		private readonly AppDbContext _dbContext;

		public TexnologyList(IPost post, AppDbContext dbContext)
		{
			_post = post;
			_dbContext = dbContext;
		}

		public IViewComponentResult Invoke()
		{
			var values = _post.GetAllInclude();
			ViewBag.idman = _post.GetAllInclude().Where(x => x.CategoryID == 5);
			ViewBag.medeniyyet = _post.GetAllInclude().Where(x => x.CategoryID == 6);
			return View(values.Take(1));
		}
	}
}
