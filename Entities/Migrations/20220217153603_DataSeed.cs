using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "Additional", "City", "Country", "CreatedAt", "ModifiedAt", "Number", "Street", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("145a6946-b260-41b1-8fab-1e83ea1f6594"), null, "Porto Alegre", null, new DateTime(2022, 2, 17, 12, 36, 2, 321, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 123, "Avenida Edvaldo Pereira Paiva", 92810129 },
                    { new Guid("85f1d8d9-8eb1-4a23-9f4a-e8b5bbba383d"), null, "Belo Horizonte", null, new DateTime(2022, 2, 17, 12, 36, 2, 340, DateTimeKind.Local).AddTicks(2040), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 456, "Rua dos Tupis", 92443875 },
                    { new Guid("fe82d660-9775-4000-bb63-663d01571674"), null, "Sao Paulo", null, new DateTime(2022, 2, 17, 12, 36, 2, 340, DateTimeKind.Local).AddTicks(2150), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 789, "Rua Cap. Macedo", 92938729 },
                    { new Guid("815bf372-be32-40ca-ade7-c1f096f575a6"), null, "Rio de Janeiro", null, new DateTime(2022, 2, 17, 12, 36, 2, 340, DateTimeKind.Local).AddTicks(2160), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Rua Teodoro da Silva", 92857129 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "ModifiedAt", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("07a7b5a7-fe39-4831-b6d8-d2f5338b831e"), new DateTime(2022, 2, 17, 12, 36, 2, 349, DateTimeKind.Local).AddTicks(30), "Tamanho: 10cm x 10cm x 10cm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caixa de Papelão 10cm", 2.9900000000000002 },
                    { new Guid("a8266a54-9c79-4667-b105-f5ed5c63026c"), new DateTime(2022, 2, 17, 12, 36, 2, 349, DateTimeKind.Local).AddTicks(100), "Tamanho: 20cm x 20cm x 20cm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caixa de Papelão 20cm", 4.9900000000000002 },
                    { new Guid("a419d907-5632-4255-a4d6-36d52281abd3"), new DateTime(2022, 2, 17, 12, 36, 2, 349, DateTimeKind.Local).AddTicks(110), "Tamanho: 30cm x 30cm x 30cm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caixa de Papelão 30cm", 6.9900000000000002 },
                    { new Guid("b1a14a4a-4649-4473-94f3-a640a32aab7f"), new DateTime(2022, 2, 17, 12, 36, 2, 349, DateTimeKind.Local).AddTicks(110), "Tamanho: 40cm x 40cm x 40cm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caixa de Papelão 40cm", 8.9900000000000002 },
                    { new Guid("0c8662f8-2c8d-4f61-b539-27102fb1f9d0"), new DateTime(2022, 2, 17, 12, 36, 2, 349, DateTimeKind.Local).AddTicks(120), "Tamanho: 50cm x 50cm x 50cm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caixa de Papelão 50cm", 10.99 },
                    { new Guid("4de8ccdd-7274-4328-9fa2-c0eeb6ac9c17"), new DateTime(2022, 2, 17, 12, 36, 2, 349, DateTimeKind.Local).AddTicks(120), "Tamanho: 60cm x 60cm x 60cm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caixa de Papelão 60cm", 11.4 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedAt", "Description", "ModifiedAt", "Name", "VehicleId" },
                values: new object[,]
                {
                    { new Guid("4c07ab00-c5dd-425e-be92-52b66ccbecc2"), new DateTime(2022, 2, 20, 12, 36, 2, 360, DateTimeKind.Local).AddTicks(5050), "Colaboradores com cargo de gerência.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gerentes", null },
                    { new Guid("aa2a5a81-b9d4-483b-9819-36be5fba0f3c"), new DateTime(2022, 2, 18, 1, 36, 2, 360, DateTimeKind.Local).AddTicks(5040), "Colaboradores com principais atribuições relativas a recrutamento e seleção de candidatos. Time de estagiários.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Time de estagiários em desenvolvimento front-end", null },
                    { new Guid("d716e33b-8d41-4f0a-8a52-c0a4871acea8"), new DateTime(2022, 2, 17, 22, 36, 2, 360, DateTimeKind.Local).AddTicks(4910), "Colaboradores com principais atribuições relativas a recrutamento e seleção de candidatos.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Time de recrutamento e seleção", null },
                    { new Guid("73dae3d0-4bdc-4b06-bcc4-ba253ded49d1"), new DateTime(2022, 2, 17, 23, 36, 2, 360, DateTimeKind.Local).AddTicks(5010), "Colaboradores com principais atribuições relativas a recrutamento e seleção de candidatos. Time de estagiários.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Time de estagiários em recrutamento e seleção", null },
                    { new Guid("bf381a5e-f2d3-4478-897e-e3306ed12f52"), new DateTime(2022, 2, 18, 0, 36, 2, 360, DateTimeKind.Local).AddTicks(5020), "Colaboradores com principais atribuições relativas a desenvolvimento de front-end.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Time de desenvolvimento front-end", null }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "Brand", "CreatedAt", "IdentificationPlate", "Model", "ModifiedAt", "TeamId" },
                values: new object[,]
                {
                    { new Guid("e79c9e7d-f0b2-4109-b43d-cb6453407d81"), null, new DateTime(2022, 2, 17, 22, 0, 2, 363, DateTimeKind.Local).AddTicks(540), "EEE-757329", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("e52260f4-e5af-4125-b9cf-3174ba227375"), null, new DateTime(2022, 2, 17, 16, 54, 2, 363, DateTimeKind.Local).AddTicks(460), "AAA-123456", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("bdd46435-1496-432e-bd43-a7aa2a0c3a86"), null, new DateTime(2022, 2, 17, 17, 42, 2, 363, DateTimeKind.Local).AddTicks(530), "BBB-885774", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("8831b388-4fda-40fc-aa80-d576539be0e9"), null, new DateTime(2022, 2, 17, 18, 48, 2, 363, DateTimeKind.Local).AddTicks(530), "CCC-953292", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("b139a172-5609-432e-be3e-4b921dd2c93b"), null, new DateTime(2022, 2, 17, 20, 12, 2, 363, DateTimeKind.Local).AddTicks(540), "DDD-854821", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("3afc19d9-b835-49d1-b0ba-df203d347493"), null, new DateTime(2022, 2, 17, 16, 18, 2, 363, DateTimeKind.Local).AddTicks(550), "FFF-t85302", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("145a6946-b260-41b1-8fab-1e83ea1f6594"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("815bf372-be32-40ca-ade7-c1f096f575a6"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("85f1d8d9-8eb1-4a23-9f4a-e8b5bbba383d"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("fe82d660-9775-4000-bb63-663d01571674"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07a7b5a7-fe39-4831-b6d8-d2f5338b831e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c8662f8-2c8d-4f61-b539-27102fb1f9d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4de8ccdd-7274-4328-9fa2-c0eeb6ac9c17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a419d907-5632-4255-a4d6-36d52281abd3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a8266a54-9c79-4667-b105-f5ed5c63026c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1a14a4a-4649-4473-94f3-a640a32aab7f"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("4c07ab00-c5dd-425e-be92-52b66ccbecc2"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("73dae3d0-4bdc-4b06-bcc4-ba253ded49d1"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("aa2a5a81-b9d4-483b-9819-36be5fba0f3c"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("bf381a5e-f2d3-4478-897e-e3306ed12f52"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: new Guid("d716e33b-8d41-4f0a-8a52-c0a4871acea8"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("3afc19d9-b835-49d1-b0ba-df203d347493"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("8831b388-4fda-40fc-aa80-d576539be0e9"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("b139a172-5609-432e-be3e-4b921dd2c93b"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("bdd46435-1496-432e-bd43-a7aa2a0c3a86"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e52260f4-e5af-4125-b9cf-3174ba227375"));

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: new Guid("e79c9e7d-f0b2-4109-b43d-cb6453407d81"));

            migrationBuilder.AddColumn<Guid>(
                name: "PackageId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
