using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GamesModel.Models;

    public class GstoreContext : DbContext
    {
        public GstoreContext (DbContextOptions<GstoreContext> options)
            : base(options)
        {
        }

        public DbSet<GamesModel.Models.Game> Game { get; set; } = default!;
    }
