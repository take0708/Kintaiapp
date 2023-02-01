using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kintaiapp;
using Kintaiapp.Models;

namespace Kintaiapp.Data
{
    public class KintaiContext : DbContext
    {
        public KintaiContext (DbContextOptions<KintaiContext> options)
            : base(options)
        {
        }

        public DbSet<Kintaiapp.Models.Kintaiapp> Kintai { get; set; } = default!;
    }
}