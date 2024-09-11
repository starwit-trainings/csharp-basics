using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FootballManager.Data;
using FootballManager.Models;

namespace FootballManagerWeb.Pages.Clubs
{
    public class DeleteModel : PageModel
    {
        private readonly FootballManager.Data.FootballManagerContext _context;

        public DeleteModel(FootballManager.Data.FootballManagerContext context)
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
