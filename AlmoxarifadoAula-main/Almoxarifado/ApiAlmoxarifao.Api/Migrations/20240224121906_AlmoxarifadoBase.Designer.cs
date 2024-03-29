﻿// <auto-generated />
using System;
using ApiAlmoxarifao.Api.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiAlmoxarifao.Api.Migrations
{
    [DbContext(typeof(AlmoxarifadoContext))]
    [Migration("20240224121906_AlmoxarifadoBase")]
    partial class AlmoxarifadoBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ApiAlmoxarifao.Api.Models.Produto", b =>
                {
                    b.Property<int>("ProId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("pro_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProId"), 1L, 1);

                    b.Property<int?>("ProEstoque")
                        .HasColumnType("int")
                        .HasColumnName("pro_estoque");

                    b.Property<string>("ProImg")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("pro_img");

                    b.Property<string>("ProNome")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("pro_nome");

                    b.HasKey("ProId")
                        .HasName("PK__produtos__335E4CA6D5258034");

                    b.ToTable("produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
