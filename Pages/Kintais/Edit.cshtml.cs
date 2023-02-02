using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kintaiapp.Data;
using Kintaiapp.Models;

namespace Kintaiapp.Pages.Kintais
{
    public class EditModel : PageModel
    {
        private readonly Kintaiapp.Data.KintaiappContext _context;

        public EditModel(Kintaiapp.Data.KintaiappContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Kintai Kintai { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Kintai == null)
            {
                return NotFound();
            }

            var kintai =  await _context.Kintai.FirstOrDefaultAsync(m => m.Id == id);
            if (kintai == null)
            {
                return NotFound();
            }
            Kintai = kintai;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Kintai).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KintaiExists(Kintai.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool KintaiExists(int id)
        {
          return (_context.Kintai?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
