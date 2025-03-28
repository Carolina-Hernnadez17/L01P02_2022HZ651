﻿using Microsoft.EntityFrameworkCore;

namespace L01P02_2022HZ651.Models
{
    public class NotasContext: DbContext
    {
        public NotasContext(DbContextOptions options) : base(options)
        { }

        public DbSet<facultades> facultades { get; set; }
        public DbSet<materias> materias { get; set; }
        public DbSet<departamentos> departamentos { get; set; }
        public DbSet<alumnos> alumnos { get; set; }

    }
}
