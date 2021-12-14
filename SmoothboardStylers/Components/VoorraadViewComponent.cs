using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmoothboardStylers.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmoothboardStylers.Components
{
    public class VoorraadViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public VoorraadViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<IViewComponentResult> InvokeAsync(int? id)
        {
            var voorraad = await _context.Voorraad.Include(v => v.Surfboard).Include(v => v.Filiaal).Where(v => v.FiliaalId == id).ToListAsync();

            return View(voorraad);
        }
    }
}
