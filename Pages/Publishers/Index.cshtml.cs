using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FAT_ALINA_LAB2._2.Data;
using FAT_ALINA_LAB2._2.Models;

namespace FAT_ALINA_LAB2._2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly FAT_ALINA_LAB2._2.Data.FAT_ALINA_LAB2_2Context _context;

        public IndexModel(FAT_ALINA_LAB2._2.Data.FAT_ALINA_LAB2_2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
