using System;

using Microsoft.EntityFrameworkCore;
using LoveSlipper.Models;

namespace LoveSlipper.Data
{
    public class LoveSlipperContext : DbContext
    {
        public LoveSlipperContext(DbContextOptions<LoveSlipperContext> options)
           : base(options)
        {
        }

        public DbSet<Slipper> Movie { get; set; }
    }
}
