// <auto-generated />
using System;
using Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(DashboardContext))]
    [Migration("20220217153603_DataSeed")]
    partial class DataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entities.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Additional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("145a6946-b260-41b1-8fab-1e83ea1f6594"),
                            City = "Porto Alegre",
                            CreatedAt = new DateTime(2022, 2, 17, 12, 36, 2, 321, DateTimeKind.Local).AddTicks(8000),
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = 123,
                            Street = "Avenida Edvaldo Pereira Paiva",
                            ZipCode = 92810129
                        },
                        new
                        {
                            Id = new Guid("85f1d8d9-8eb1-4a23-9f4a-e8b5bbba383d"),
                            City = "Belo Horizonte",
                            CreatedAt = new DateTime(2022, 2, 17, 12, 36, 2, 340, DateTimeKind.Local).AddTicks(2040),
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = 456,
                            Street = "Rua dos Tupis",
                            ZipCode = 92443875
                        },
                        new
                        {
                            Id = new Guid("fe82d660-9775-4000-bb63-663d01571674"),
                            City = "Sao Paulo",
                            CreatedAt = new DateTime(2022, 2, 17, 12, 36, 2, 340, DateTimeKind.Local).AddTicks(2150),
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = 789,
                            Street = "Rua Cap. Macedo",
                            ZipCode = 92938729
                        },
                        new
                        {
                            Id = new Guid("815bf372-be32-40ca-ade7-c1f096f575a6"),
                            City = "Rio de Janeiro",
                            CreatedAt = new DateTime(2022, 2, 17, 12, 36, 2, 340, DateTimeKind.Local).AddTicks(2160),
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Number = 12,
                            Street = "Rua Teodoro da Silva",
                            ZipCode = 92857129
                        });
                });

            modelBuilder.Entity("Entities.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeliveredAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("TeamId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Entities.Models.OrderProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("07a7b5a7-fe39-4831-b6d8-d2f5338b831e"),
                            CreatedAt = new DateTime(2022, 2, 17, 12, 36, 2, 349, DateTimeKind.Local).AddTicks(30),
                            Description = "Tamanho: 10cm x 10cm x 10cm",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Caixa de Papelão 10cm",
                            Price = 2.9900000000000002
                        },
                        new
                        {
                            Id = new Guid("a8266a54-9c79-4667-b105-f5ed5c63026c"),
                            CreatedAt = new DateTime(2022, 2, 17, 12, 36, 2, 349, DateTimeKind.Local).AddTicks(100),
                            Description = "Tamanho: 20cm x 20cm x 20cm",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Caixa de Papelão 20cm",
                            Price = 4.9900000000000002
                        },
                        new
                        {
                            Id = new Guid("a419d907-5632-4255-a4d6-36d52281abd3"),
                            CreatedAt = new DateTime(2022, 2, 17, 12, 36, 2, 349, DateTimeKind.Local).AddTicks(110),
                            Description = "Tamanho: 30cm x 30cm x 30cm",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Caixa de Papelão 30cm",
                            Price = 6.9900000000000002
                        },
                        new
                        {
                            Id = new Guid("b1a14a4a-4649-4473-94f3-a640a32aab7f"),
                            CreatedAt = new DateTime(2022, 2, 17, 12, 36, 2, 349, DateTimeKind.Local).AddTicks(110),
                            Description = "Tamanho: 40cm x 40cm x 40cm",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Caixa de Papelão 40cm",
                            Price = 8.9900000000000002
                        },
                        new
                        {
                            Id = new Guid("0c8662f8-2c8d-4f61-b539-27102fb1f9d0"),
                            CreatedAt = new DateTime(2022, 2, 17, 12, 36, 2, 349, DateTimeKind.Local).AddTicks(120),
                            Description = "Tamanho: 50cm x 50cm x 50cm",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Caixa de Papelão 50cm",
                            Price = 10.99
                        },
                        new
                        {
                            Id = new Guid("4de8ccdd-7274-4328-9fa2-c0eeb6ac9c17"),
                            CreatedAt = new DateTime(2022, 2, 17, 12, 36, 2, 349, DateTimeKind.Local).AddTicks(120),
                            Description = "Tamanho: 60cm x 60cm x 60cm",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Caixa de Papelão 60cm",
                            Price = 11.4
                        });
                });

            modelBuilder.Entity("Entities.Models.Team", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("VehicleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId")
                        .IsUnique()
                        .HasFilter("[VehicleId] IS NOT NULL");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d716e33b-8d41-4f0a-8a52-c0a4871acea8"),
                            CreatedAt = new DateTime(2022, 2, 17, 22, 36, 2, 360, DateTimeKind.Local).AddTicks(4910),
                            Description = "Colaboradores com principais atribuições relativas a recrutamento e seleção de candidatos.",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Time de recrutamento e seleção"
                        },
                        new
                        {
                            Id = new Guid("73dae3d0-4bdc-4b06-bcc4-ba253ded49d1"),
                            CreatedAt = new DateTime(2022, 2, 17, 23, 36, 2, 360, DateTimeKind.Local).AddTicks(5010),
                            Description = "Colaboradores com principais atribuições relativas a recrutamento e seleção de candidatos. Time de estagiários.",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Time de estagiários em recrutamento e seleção"
                        },
                        new
                        {
                            Id = new Guid("bf381a5e-f2d3-4478-897e-e3306ed12f52"),
                            CreatedAt = new DateTime(2022, 2, 18, 0, 36, 2, 360, DateTimeKind.Local).AddTicks(5020),
                            Description = "Colaboradores com principais atribuições relativas a desenvolvimento de front-end.",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Time de desenvolvimento front-end"
                        },
                        new
                        {
                            Id = new Guid("aa2a5a81-b9d4-483b-9819-36be5fba0f3c"),
                            CreatedAt = new DateTime(2022, 2, 18, 1, 36, 2, 360, DateTimeKind.Local).AddTicks(5040),
                            Description = "Colaboradores com principais atribuições relativas a recrutamento e seleção de candidatos. Time de estagiários.",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Time de estagiários em desenvolvimento front-end"
                        },
                        new
                        {
                            Id = new Guid("4c07ab00-c5dd-425e-be92-52b66ccbecc2"),
                            CreatedAt = new DateTime(2022, 2, 20, 12, 36, 2, 360, DateTimeKind.Local).AddTicks(5050),
                            Description = "Colaboradores com cargo de gerência.",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Gerentes"
                        });
                });

            modelBuilder.Entity("Entities.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Models.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentificationPlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e52260f4-e5af-4125-b9cf-3174ba227375"),
                            CreatedAt = new DateTime(2022, 2, 17, 16, 54, 2, 363, DateTimeKind.Local).AddTicks(460),
                            IdentificationPlate = "AAA-123456",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("bdd46435-1496-432e-bd43-a7aa2a0c3a86"),
                            CreatedAt = new DateTime(2022, 2, 17, 17, 42, 2, 363, DateTimeKind.Local).AddTicks(530),
                            IdentificationPlate = "BBB-885774",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("8831b388-4fda-40fc-aa80-d576539be0e9"),
                            CreatedAt = new DateTime(2022, 2, 17, 18, 48, 2, 363, DateTimeKind.Local).AddTicks(530),
                            IdentificationPlate = "CCC-953292",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("b139a172-5609-432e-be3e-4b921dd2c93b"),
                            CreatedAt = new DateTime(2022, 2, 17, 20, 12, 2, 363, DateTimeKind.Local).AddTicks(540),
                            IdentificationPlate = "DDD-854821",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("e79c9e7d-f0b2-4109-b43d-cb6453407d81"),
                            CreatedAt = new DateTime(2022, 2, 17, 22, 0, 2, 363, DateTimeKind.Local).AddTicks(540),
                            IdentificationPlate = "EEE-757329",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("3afc19d9-b835-49d1-b0ba-df203d347493"),
                            CreatedAt = new DateTime(2022, 2, 17, 16, 18, 2, 363, DateTimeKind.Local).AddTicks(550),
                            IdentificationPlate = "FFF-t85302",
                            ModifiedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Entities.Models.Order", b =>
                {
                    b.HasOne("Entities.Models.Address", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressId");

                    b.HasOne("Entities.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");

                    b.Navigation("Address");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Entities.Models.OrderProduct", b =>
                {
                    b.HasOne("Entities.Models.Order", "Order")
                        .WithMany("OrdersProducts")
                        .HasForeignKey("OrderId");

                    b.HasOne("Entities.Models.Product", "Product")
                        .WithMany("OrdersProducts")
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Entities.Models.Team", b =>
                {
                    b.HasOne("Entities.Models.Vehicle", "Vehicle")
                        .WithOne("Team")
                        .HasForeignKey("Entities.Models.Team", "VehicleId");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Entities.Models.Address", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Entities.Models.Order", b =>
                {
                    b.Navigation("OrdersProducts");
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Navigation("OrdersProducts");
                });

            modelBuilder.Entity("Entities.Models.Vehicle", b =>
                {
                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
