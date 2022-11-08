using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gata_Alexandra_Lab2.Data;
using Gata_Alexandra_Lab2.Models;

namespace Gata_Alexandra_Lab2.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Gata_Alexandra_Lab2.Data.Gata_Alexandra_Lab2Context _context;

        public IndexModel(Gata_Alexandra_Lab2.Data.Gata_Alexandra_Lab2Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;


        public async Task OnGetAsync()
        {
            if (_context.Category != null)
            {
                Category = await _context.Category.ToListAsync();
            }
        }
    }
}
