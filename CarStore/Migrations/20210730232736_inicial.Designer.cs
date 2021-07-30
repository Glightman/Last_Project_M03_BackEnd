﻿// <auto-generated />
using CarStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarStore.Migrations
{
    [DbContext(typeof(CarStoreContext))]
    [Migration("20210730232736_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarStore.Models.Carro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ano")
                        .HasColumnType("int");

                    b.Property<string>("descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("modelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("preco")
                        .HasColumnType("float");

                    b.Property<string>("url1")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Carro");
                });
#pragma warning restore 612, 618
        }
    }
}
