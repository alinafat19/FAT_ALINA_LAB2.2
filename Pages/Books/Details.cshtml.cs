﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FAT_ALINA_LAB2._2.Data;
using FAT_ALINA_LAB2._2.Models;

namespace FAT_ALINA_LAB2._2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly FAT_ALINA_LAB2._2.Data.FAT_ALINA_LAB2_2Context _context;

        public DetailsModel(FAT_ALINA_LAB2._2.Data.FAT_ALINA_LAB2_2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                Book = book;
            }
            return Page();
        }
    }
}
