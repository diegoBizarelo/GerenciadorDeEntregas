﻿// <auto-generated />
using System;
using Entregas.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entregas.API.Migrations
{
    [DbContext(typeof(EntregasContext))]
    partial class EntregasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entregas.Dominio.Models.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Entregas.Dominio.Models.Entrega", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EnderecoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EntregadorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EstabelecimentoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("EntregadorId");

                    b.HasIndex("EstabelecimentoId");

                    b.ToTable("Entregas");
                });

            modelBuilder.Entity("Entregas.Dominio.Models.Entregador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Transporte")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Entregadores");
                });

            modelBuilder.Entity("Entregas.Dominio.Models.Estabelecimento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Estabelecimentos");
                });

            modelBuilder.Entity("Entregas.Dominio.Models.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("varchar(500)");

                    b.Property<Guid>("EstabelecimentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("EstabelecimentoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Entregas.Dominio.Models.ProdutosEntrega", b =>
                {
                    b.Property<Guid>("EntregaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EntregaId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ProdutosEntrega");
                });

            modelBuilder.Entity("Entregas.Dominio.Models.Entrega", b =>
                {
                    b.HasOne("Entregas.Dominio.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .IsRequired();

                    b.HasOne("Entregas.Dominio.Models.Entregador", "Entregador")
                        .WithMany("Entregas")
                        .HasForeignKey("EntregadorId")
                        .IsRequired();

                    b.HasOne("Entregas.Dominio.Models.Estabelecimento", "Estabelecimento")
                        .WithMany("Entregas")
                        .HasForeignKey("EstabelecimentoId")
                        .IsRequired();
                });

            modelBuilder.Entity("Entregas.Dominio.Models.Produto", b =>
                {
                    b.HasOne("Entregas.Dominio.Models.Estabelecimento", "Estabelecimento")
                        .WithMany("Produtos")
                        .HasForeignKey("EstabelecimentoId")
                        .IsRequired();
                });

            modelBuilder.Entity("Entregas.Dominio.Models.ProdutosEntrega", b =>
                {
                    b.HasOne("Entregas.Dominio.Models.Entrega", "Entrega")
                        .WithMany("Produtos")
                        .HasForeignKey("EntregaId")
                        .IsRequired();

                    b.HasOne("Entregas.Dominio.Models.Produto", "Produto")
                        .WithMany("Entregas")
                        .HasForeignKey("ProdutoId")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
