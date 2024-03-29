using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kintaiapp.Data;
using Kintaiapp.Models;

namespace Kintaiapp.Pages.Kintais
{
    public class IndexModel : PageModel
    {
        private readonly Kintaiapp.Data.KintaiappContext _context;

        public IndexModel(Kintaiapp.Data.KintaiappContext context)
        {
            _context = context;
        }

        public IList<Kintai> Kintai { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Kintai != null)
            {
                Kintai = await _context.Kintai.OrderBy(i => i.Start).ToListAsync();
            }
        }
    }
}
