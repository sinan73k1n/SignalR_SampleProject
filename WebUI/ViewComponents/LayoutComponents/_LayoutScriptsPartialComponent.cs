﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.LayoutComponents
{
	public class _LayoutScriptsPartialComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
		
	}
}

