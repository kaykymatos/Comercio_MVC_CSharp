﻿// <auto-generated />
using System;
using Mercado.MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mercado.MVC.Migrations
{
    [DbContext(typeof(MercadoMVCContext))]
    [Migration("20220109164016_AddUnidadeFederalCliente")]
    partial class AddUnidadeFederalCliente
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mercado.MVC.Models.CategoriaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAddCategoria")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Mercado.MVC.Models.ClienteModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Complemento")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome_Fantasia")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("NumeroCasa")
                        .HasColumnType("int");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Razao_Social")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Sexo")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<int>("Uf")
                        .HasColumnType("int");

                    b.Property<DateTime>("UltimaModificacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Whatsapp")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Mercado.MVC.Models.ProdutoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataAddProduto")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecoUnidade")
                        .HasColumnType("decimal(12,2)");

                    b.Property<double>("QuantidadeProduto")
                        .HasColumnType("float");

                    b.Property<int>("UnidadeDeMedida")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoria");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Mercado.MVC.Models.VendaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataVenda")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdProduto")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorVenda")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdProduto");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Mercado.MVC.Models.ProdutoModel", b =>
                {
                    b.HasOne("Mercado.MVC.Models.CategoriaModel", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Mercado.MVC.Models.VendaModel", b =>
                {
                    b.HasOne("Mercado.MVC.Models.ClienteModel", "Cliente")
                        .WithMany("Venda")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mercado.MVC.Models.ProdutoModel", "Produto")
                        .WithMany("Vendas")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Mercado.MVC.Models.CategoriaModel", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Mercado.MVC.Models.ClienteModel", b =>
                {
                    b.Navigation("Venda");
                });

            modelBuilder.Entity("Mercado.MVC.Models.ProdutoModel", b =>
                {
                    b.Navigation("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}
