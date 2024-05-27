using Business.Abstract;
using DataAccess.MyContext;
using DTO.EntityDTO;
using Microsoft.AspNetCore.Mvc;

namespace News.Asp.net.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPost _post;
        private readonly AppDbContext _context;

		public HomeController(IPost post, AppDbContext context)
		{
			_post = post;
			_context = context;
		}

		public IActionResult Index()
        {
            var values=_post.GetAll();
             return View(values.Take(4));
        }

        public IActionResult Page(int id)
        {
            ViewBag.category=_context.Categories.Where(x=>x.Id==id).Select(y=>y.Name).First();
            var values = _post.GetAllCategory(id);
            return View(values);
        }



    }
}
