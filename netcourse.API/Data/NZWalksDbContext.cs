﻿
using Microsoft.EntityFrameworkCore;
using netcourse.API.Models.Domain;

namespace netcourse.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions <NZWalksDbContext> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulties{ get; set; }


    }
}
