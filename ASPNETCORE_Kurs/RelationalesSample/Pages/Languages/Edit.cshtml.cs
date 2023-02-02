﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RelationalesSample.Data;
using RelationalesSample.Models;

namespace RelationalesSample.Pages.Languages
{
    public class EditModel : PageModel
    {
        private readonly RelationalesSample.Data.GeoDbContext _context;

        public EditModel(RelationalesSample.Data.GeoDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Language Language { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Languages == null)
            {
                return NotFound();
            }

            var language =  await _context.Languages.FirstOrDefaultAsync(m => m.Id == id);
            if (language == null)
            {
                return NotFound();
            }
            Language = language;
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

            _context.Attach(Language).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LanguageExists(Language.Id))
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

        private bool LanguageExists(int id)
        {
          return (_context.Languages?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
