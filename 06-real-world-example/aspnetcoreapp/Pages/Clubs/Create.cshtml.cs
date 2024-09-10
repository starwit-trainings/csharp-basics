using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using aspnetcoreapp.Data;
using aspnetcoreapp.Models;

namespace aspnetcoreapp.Pages.Clubs
{
    public class CreateModel : PageModel
    {
        private readonly aspnetcoreapp.Data.aspnetcoreappContext _context;

        public CreateModel(aspnetcoreapp.Data.aspnetcoreappContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ClubEntity ClubEntity { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
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
