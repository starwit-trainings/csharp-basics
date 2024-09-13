using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FootballManager.Data;
using FootballManager.Models;

namespace FootballManagerWeb.Pages.Clubs
{
    public class EditModel : PageModel
    {
        private readonly FootballManager.Data.FootballManagerContext _context;

        public EditModel(FootballManager.Data.FootballManagerContext context)
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

            var clubentity =  await _context.ClubEntity.FirstOrDefaultAsync(m => m.Id == id);
            if (clubentity == null)
            {
                return NotFound();
            }
            ClubEntity = clubentity;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ClubEntity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClubEntityExists(ClubEntity.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ClubEntityExists(int id)
        {
            return _context.ClubEntity.Any(e => e.Id == id);
        }
    }
}
