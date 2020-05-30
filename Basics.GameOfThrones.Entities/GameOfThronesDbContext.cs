using Basics.GameOfThrones.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Basics.GameOfThrones.Domain
{
    public class GameOfThronesDbContext : DbContext
    {
        public GameOfThronesDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<House> Houses { get; set; }
    }
}
