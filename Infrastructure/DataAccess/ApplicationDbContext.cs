using Microsoft.EntityFrameworkCore;
using Practice_UnitTest.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_UnitTest.Infrastructure.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DacmeTcgCard> DacmeTcgCards { get; set; }
    }
}
