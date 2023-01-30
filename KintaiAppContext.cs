using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

internal class KintaiAppContext
{
}

namespace Kintaiapp.Models
{
    public class KintaiappContext : DbContext
    {
        public KintaiappContext(DbContextOptions<KintaiappContext> options)
            : base(options)
        {
        }
    }
}