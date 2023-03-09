﻿// <auto-generated />
using CRUDTarefas.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUDTarefas.Migrations
{
    [DbContext(typeof(TarefaContext))]
    [Migration("20230309005444_atualizandoEnum3")]
    partial class atualizandoEnum3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CRUDTarefas.models.Tarefa", b =>
                {
                    b.Property<int>("idTarefa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("descricaoTarefa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nomeTarefa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("idTarefa");

                    b.ToTable("Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
