using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoldovanIoana_Lab2.Models;

namespace MoldovanIoana_Lab2.Data
{
    public class MoldovanIoana_Lab2Context : DbContext
    {
        public MoldovanIoana_Lab2Context (DbContextOptions<MoldovanIoana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<MoldovanIoana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<MoldovanIoana_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<MoldovanIoana_Lab2.Models.Category> Category { get; set; }
    }
}
