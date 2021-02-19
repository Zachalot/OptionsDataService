using Microsoft.EntityFrameworkCore;
using OptionsDataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using System.Data.Entity;

namespace OptionsDataService.Infrastructure
{
    public class DataContext: DbContext
    {
        DbSet<Option> Options { get; set; }
        DbSet<Equity> Equities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=capitalbacktesterLocalDev; Integrated Security=True");
        }
    }
}
