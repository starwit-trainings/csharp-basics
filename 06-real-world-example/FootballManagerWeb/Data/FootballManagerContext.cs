using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FootballManager.Models;

namespace FootballManager.Data
{
    public class FootballManagerContext : DbContext
    {
        public FootballManagerContext (DbContextOptions<FootballManagerContext> options)
            : base(options)
        {
        }

        public DbSet<FootballManager.Models.ClubEntity> ClubEntity { get; set; } = default!;
    }
}
