using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FAT_ALINA_LAB2._2.Models;

namespace FAT_ALINA_LAB2._2.Data
{
    public class FAT_ALINA_LAB2_2Context : DbContext
    {
        public FAT_ALINA_LAB2_2Context (DbContextOptions<FAT_ALINA_LAB2_2Context> options)
            : base(options)
        {
        }

        public DbSet<FAT_ALINA_LAB2._2.Models.Book> Book { get; set; } = default!;
        public DbSet<FAT_ALINA_LAB2._2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
