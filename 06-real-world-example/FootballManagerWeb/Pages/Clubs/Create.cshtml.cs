using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FootballManager.Data;
using FootballManager.Models;

namespace FootballManagerWeb.Pages.Clubs
{
    public class CreateModel : PageModel
    {
        private readonly FootballManager.Data.FootballManagerContext _context;

        public CreateModel(FootballManager.Data.FootballManagerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ClubEntity ClubEntity { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ClubEntity.Add(ClubEntity);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
