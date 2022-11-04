using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gata_Alexandra_Lab2.Models;

namespace Gata_Alexandra_Lab2.Data
{
    public class Gata_Alexandra_Lab2Context : DbContext
    {
        public Gata_Alexandra_Lab2Context (DbContextOptions<Gata_Alexandra_Lab2Context> options)
            : base(options)
        {
        }
        /// <summary>
        /// toate entitatiile create
        /// </summary>
        public DbSet<Gata_Alexandra_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Gata_Alexandra_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Gata_Alexandra_Lab2.Models.Author> Author { get; set; }

        public DbSet<Gata_Alexandra_Lab2.Models.Category> Category { get; set; }
    }
}
