using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Kintaiapp.Data;
using Kintaiapp.Models;

namespace Kintaiapp.Pages.Kintais
{
    public class CreateModel : PageModel
    {
        private readonly Kintaiapp.Data.KintaiappContext _context;

        public CreateModel(Kintaiapp.Data.KintaiappContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Kintai Kintai { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Kintai == null || Kintai == null)
            {
                return Page();
            }

            _context.Kintai.Add(Kintai);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
