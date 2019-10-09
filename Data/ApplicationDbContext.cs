﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CRUD2._1.Data;

namespace CRUD2._1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CRUD2._1.Data.Cars> Cars { get; set; }
        public DbSet<CRUD2._1.Data.Manufactures> Manufactures { get; set; }
    }
}
