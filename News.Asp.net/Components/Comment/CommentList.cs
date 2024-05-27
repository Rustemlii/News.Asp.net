﻿using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace News.Asp.net.Components.Comment
{
	public class CommentList:ViewComponent
	{
		private readonly IComment _comment;

		public CommentList(IComment comment)
		{
			_comment = comment;
		}
		public IViewComponentResult Invoke()
		{
			var values = _comment.GetAll();
			return View(values);
		}
	}
}
