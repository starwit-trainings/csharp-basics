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
    public class IndexModel : PageModel
    {
        private readonly FootballManager.Data.FootballManagerContext _context;

        public IndexModel(FootballManager.Data.FootballManagerContext context)
        {
            _context = context;
        }

        public IList<ClubEntity> ClubEntity { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ClubEntity = await _context.ClubEntity.ToListAsync();
        }
    }
}
