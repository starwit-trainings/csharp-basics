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
    public class DeleteModel : PageModel
    {
        private readonly aspnetcoreapp.Data.aspnetcoreappContext _context;

        public DeleteModel(aspnetcoreapp.Data.aspnetcoreappContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubentity = await _context.ClubEntity.FindAsync(id);
            if (clubentity != null)
            {
                ClubEntity = clubentity;
                _context.ClubEntity.Remove(ClubEntity);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
