using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using aspnetcoreapp.Data;
using aspnetcoreapp.Models;

namespace aspnetcoreapp.Pages.Clubs
{
    public class DetailsModel : PageModel
    {
        private readonly aspnetcoreapp.Data.aspnetcoreappContext _context;

        public DetailsModel(aspnetcoreapp.Data.aspnetcoreappContext context)
        {
            _context = context;
        }

        public ClubEntity ClubEntity { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubentity = await _context.ClubEntity.FirstOrDefaultAsync(m => m.Id == id);
            if (clubentity == null)
            {
                return NotFound();
            }
            else
            {
                ClubEntity = clubentity;
            }
            return Page();
        }
    }
}
