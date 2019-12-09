using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace LangMulti.Models
{
    public class MyCMSContext:DbContext
    {

        public MyCMSContext(DbContextOptions<MyCMSContext> options):base(options)
        {

        }


        public DbSet<Language> Languages { get; set; }

        public DbSet<News> Newses { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

         // string lang = CultureInfo.CurrentCulture.Name;

        // modelBuilder.Entity<News>().HasQueryFilter(n => n.Language.LanguageTitle == lang);

            base.OnModelCreating(modelBuilder); 
        }
    }
}
