﻿using web7.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace web7.Components
{

    public class CategoryViewComponent : ViewComponent
    {
        private readonly AppDBContext _context;
        public CategoryViewComponent(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cateList = await this._context.Categories.ToListAsync();
            return View(cateList);
        }
    }
}