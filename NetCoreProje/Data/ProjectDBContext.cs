using Microsoft.EntityFrameworkCore;
using NetCoreProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreProje.Data
{
    public class ProjectDBContext:DbContext
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base(options)
        {

        }

        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<Reyonlar> Reyonlars { get; set; }
        public virtual DbSet<Urunler> Urunlers { get; set; }
    }
}
