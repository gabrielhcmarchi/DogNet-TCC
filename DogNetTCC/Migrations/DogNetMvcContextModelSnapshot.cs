﻿// <auto-generated />
using System;
using DogNet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DogNet.Migrations
{
    [DbContext(typeof(DogNetMvcContext))]
    partial class DogNetMvcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("TEXT");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("TEXT");

                b.Property<string>("Name")
                    .HasColumnType("TEXT")
                    .HasMaxLength(256);

                b.Property<string>("NormalizedName")
                    .HasColumnType("TEXT")
                    .HasMaxLength(256);

                b.HasKey("Id");

                b.HasIndex("NormalizedName")
                    .IsUnique()
                    .HasName("RoleNameIndex");

                b.ToTable("AspNetRoles");
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("ClaimType")
                    .HasColumnType("TEXT");

                b.Property<string>("ClaimValue")
                    .HasColumnType("TEXT");

                b.Property<string>("RoleId")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.ToTable("AspNetRoleClaims");
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("ClaimType")
                    .HasColumnType("TEXT");

                b.Property<string>("ClaimValue")
                    .HasColumnType("TEXT");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserClaims");
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
            {
                b.Property<string>("LoginProvider")
                    .HasColumnType("TEXT");

                b.Property<string>("ProviderKey")
                    .HasColumnType("TEXT");

                b.Property<string>("ProviderDisplayName")
                    .HasColumnType("TEXT");

                b.Property<string>("UserId")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("LoginProvider", "ProviderKey");

                b.HasIndex("UserId");

                b.ToTable("AspNetUserLogins");
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("TEXT");

                b.Property<string>("RoleId")
                    .HasColumnType("TEXT");

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.ToTable("AspNetUserRoles");
            });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
            {
                b.Property<string>("UserId")
                    .HasColumnType("TEXT");

                b.Property<string>("LoginProvider")
                    .HasColumnType("TEXT");

                b.Property<string>("Name")
                    .HasColumnType("TEXT");

                b.Property<string>("Value")
                    .HasColumnType("TEXT");

                b.HasKey("UserId", "LoginProvider", "Name");

                b.ToTable("AspNetUserTokens");
            });

            modelBuilder.Entity("QuitandaOnline.Models.AppUser", b =>
            {
                b.Property<string>("Id")
                    .HasColumnType("TEXT");

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("INTEGER");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .HasColumnType("TEXT");

                b.Property<string>("Email")
                    .HasColumnType("TEXT")
                    .HasMaxLength(256);

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("INTEGER");

                b.Property<bool>("LockoutEnabled")
                    .HasColumnType("INTEGER");

                b.Property<DateTimeOffset?>("LockoutEnd")
                    .HasColumnType("TEXT");

                b.Property<string>("Nome")
                    .HasColumnType("TEXT");

                b.Property<string>("NormalizedEmail")
                    .HasColumnType("TEXT")
                    .HasMaxLength(256);

                b.Property<string>("NormalizedUserName")
                    .HasColumnType("TEXT")
                    .HasMaxLength(256);

                b.Property<string>("PasswordHash")
                    .HasColumnType("TEXT");

                b.Property<string>("PhoneNumber")
                    .HasColumnType("TEXT");

                b.Property<bool>("PhoneNumberConfirmed")
                    .HasColumnType("INTEGER");

                b.Property<string>("SecurityStamp")
                    .HasColumnType("TEXT");

                b.Property<bool>("TwoFactorEnabled")
                    .HasColumnType("INTEGER");

                b.Property<string>("UserName")
                    .HasColumnType("TEXT")
                    .HasMaxLength(256);

                b.HasKey("Id");

                b.HasIndex("NormalizedEmail")
                    .HasName("EmailIndex");

                b.HasIndex("NormalizedUserName")
                    .IsUnique()
                    .HasName("UserNameIndex");

                b.ToTable("AspNetUsers");
            });

            modelBuilder.Entity("DogNet.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(11);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<int>("Situacao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(11);

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("DogNet.Models.Instituicoes", b =>
                {
                    b.Property<int>("IdInstituicoes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(14);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Pix")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(11);

                    b.HasKey("IdInstituicoes");

                    b.ToTable("Instituicoes");
                });

            modelBuilder.Entity("DogNet.Models.ItemPedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdProduto")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Quantidade")
                        .HasColumnType("REAL");

                    b.Property<double>("ValorUnitario")
                        .HasColumnType("REAL");

                    b.HasKey("IdPedido", "IdProduto");

                    b.HasIndex("IdProduto");

                    b.ToTable("ItensPedido");
                });

            modelBuilder.Entity("DogNet.Models.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataHoraPedido")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdCarrinho")
                        .HasColumnType("TEXT");

                    b.Property<int?>("IdCliente")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Situacao")
                        .HasColumnType("INTEGER");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("REAL");

                    b.HasKey("IdPedido");

                    b.HasIndex("IdCliente");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("DogNet.Models.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(1000);

                    b.Property<int?>("Estoque")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<double?>("Preco")
                        .IsRequired()
                        .HasColumnType("REAL");

                    b.HasKey("IdProduto");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("DogNet.Models.Cliente", b =>
                {
                    b.OwnsOne("DogNet.Models.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<int>("ClienteIdCliente")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Bairro")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(50);

                            b1.Property<string>("CEP")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(8);

                            b1.Property<string>("Cidade")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(50);

                            b1.Property<string>("Complemento")
                                .HasColumnType("TEXT")
                                .HasMaxLength(100);

                            b1.Property<string>("Estado")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(2);

                            b1.Property<string>("Logradouro")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(100);

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(10);

                            b1.Property<string>("Referencia")
                                .HasColumnType("TEXT")
                                .HasMaxLength(100);

                            b1.HasKey("ClienteIdCliente");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteIdCliente");
                        });
                });

            modelBuilder.Entity("DogNet.Models.Instituicoes", b =>
                {
                    b.OwnsOne("DogNet.Models.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<int>("InstituicoesIdInstituicoes")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Bairro")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(50);

                            b1.Property<string>("CEP")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(8);

                            b1.Property<string>("Cidade")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(50);

                            b1.Property<string>("Complemento")
                                .HasColumnType("TEXT")
                                .HasMaxLength(100);

                            b1.Property<string>("Estado")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(2);

                            b1.Property<string>("Logradouro")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(100);

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(10);

                            b1.Property<string>("Referencia")
                                .HasColumnType("TEXT")
                                .HasMaxLength(100);

                            b1.HasKey("InstituicoesIdInstituicoes");

                            b1.ToTable("Instituicoes");

                            b1.WithOwner()
                                .HasForeignKey("InstituicoesIdInstituicoes");
                        });
                });

            modelBuilder.Entity("DogNet.Models.ItemPedido", b =>
                {
                    b.HasOne("DogNet.Models.Pedido", "Pedido")
                        .WithMany("ItensPedido")
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DogNet.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("DogNet.Models.Pedido", b =>
                {
                    b.HasOne("DogNet.Models.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.OwnsOne("DogNet.Models.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<int>("PedidoIdPedido")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Bairro")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(50);

                            b1.Property<string>("CEP")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(8);

                            b1.Property<string>("Cidade")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(50);

                            b1.Property<string>("Complemento")
                                .HasColumnType("TEXT")
                                .HasMaxLength(100);

                            b1.Property<string>("Estado")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(2);

                            b1.Property<string>("Logradouro")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(100);

                            b1.Property<string>("Numero")
                                .IsRequired()
                                .HasColumnType("TEXT")
                                .HasMaxLength(10);

                            b1.Property<string>("Referencia")
                                .HasColumnType("TEXT")
                                .HasMaxLength(100);

                            b1.HasKey("PedidoIdPedido");

                            b1.ToTable("Pedidos");

                            b1.WithOwner()
                                .HasForeignKey("PedidoIdPedido");
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
