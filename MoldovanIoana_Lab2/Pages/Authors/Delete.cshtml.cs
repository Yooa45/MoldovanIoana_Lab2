﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoldovanIoana_Lab2.Data;
using MoldovanIoana_Lab2.Models;

namespace MoldovanIoana_Lab2.Pages.Authors
{
    public class DeleteModel : PageModel
    {
        private readonly MoldovanIoana_Lab2.Data.MoldovanIoana_Lab2Context _context;

        public DeleteModel(MoldovanIoana_Lab2.Data.MoldovanIoana_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Author Author { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author_1 == null)
            {
                return NotFound();
            }

            var author = await _context.Author_1.FirstOrDefaultAsync(m => m.ID == id);

            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Author_1 == null)
            {
                return NotFound();
            }
            var author = await _context.Author_1.FindAsync(id);

            if (author != null)
            {
                Author = author;
                _context.Author_1.Remove(Author);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}