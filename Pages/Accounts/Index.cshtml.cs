using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kintaiapp.Data;
using Kintaiapp.Models;

namespace Kintaiapp.Pages.Accounts
{
    public class IndexModel : PageModel
    {
        private readonly Kintaiapp.Data.KintaiappContext _context;

        public IndexModel(Kintaiapp.Data.KintaiappContext context)
        {
            _context = context;
        }

        public IList<Account> Account { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Account != null)
            {
                Account = await _context.Account.ToListAsync();
            }
        }
    }
}
