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
    public class DetailsModel : PageModel
    {
        private readonly Kintaiapp.Data.KintaiappContext _context;

        public DetailsModel(Kintaiapp.Data.KintaiappContext context)
        {
            _context = context;
        }

      public Kintai Kintai { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Kintai == null)
            {
                return NotFound();
            }

            var kintai = await _context.Kintai.FirstOrDefaultAsync(m => m.Id == id);
            if (kintai == null)
            {
                return NotFound();
            }
            else 
            {
                Kintai = kintai;
            }
            return Page();
        }
    }
}
