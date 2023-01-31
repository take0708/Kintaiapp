using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kintaiapp.Models;

namespace Kintaiapp.Data
{
    public class KintaiappContext : DbContext
    {
        public KintaiappContext (DbContextOptions<KintaiappContext> options)
            : base(options)
        {
        }

        public DbSet<Kintaiapp.Models.Kintai> Kintai { get; set; } = default!;
    }
}