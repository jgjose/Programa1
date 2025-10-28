﻿namespace webappacademica.models
{
    using Microsoft.EntityFrameworkCore;

    public class MyDbContext : DbContext {
    public MyDbContext() { }

    public MyDbContext(DbContextOptions<MyDbContext> option) : base(option) { }
    public DbSet<Alumno>Alumnos { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity <Alumno>().HasKey(a => a.idAlumno);
    }



}
}

    

