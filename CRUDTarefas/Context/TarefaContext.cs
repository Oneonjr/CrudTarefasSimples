using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDTarefas.models;


namespace CRUDTarefas.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas {get; set;}

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);

        //     modelBuilder.Entity<Tarefa>()
        //         .Property(t => t.Status)
        //         .HasConversion<string>();
        // }
    }
}