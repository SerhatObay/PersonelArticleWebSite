﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDemo.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SERHATOBAY\\SQLEXPRESS;database=DemoApiDb; integrated security=true");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
