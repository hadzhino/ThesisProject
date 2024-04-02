using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PureSound.Migrations
{
    /// <inheritdoc />
    public partial class Mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4bb7ea19-d5e7-425e-975f-d1ff8c821505"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5a404d01-59b0-467f-aa0c-b784965f925c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c13f4755-8c79-46be-aa27-7b1505eab3ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ecc0c732-51bf-45d0-a646-785e578b92ed"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("0cc47a8b-fa7b-4a2f-8976-dbfd317408c6"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("1b99263a-f107-46ca-9130-1671a8b8e674"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("20b699af-cdf9-4d6c-83f7-7273d52403ae"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("510fbafe-4d46-43f3-b9ee-d4e3273ee160"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("80961a64-8c18-4cc8-9476-d4d5637c6466"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("864665ff-ed41-4f80-9fb9-ae7ff997f550"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("adbdd114-7d5f-49c6-883c-4134428f491b"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("112673bc-f145-4bcd-8329-1b10b7fe1084"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("18ff037f-9216-4144-acd8-34afbc7b0ec4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("290f1082-0449-49cd-86d1-0059a99be0ec"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2dcafb5c-498e-4e0e-907c-00ea009c01a4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("5b225ec7-fb5d-4228-acb6-d9a14be0bbe1"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("63faaca2-7b5c-463a-b76b-a784b4ed36e2"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8d13d374-998d-4394-ac14-2e7d416791ec"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("95f8df2d-e7fb-4aa5-8bf9-0f8b8ee7587e"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("a1f4c1b9-3670-4be8-bdee-8334ec7165f4"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c8b05d04-4d24-4967-9d3b-499209f67358"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c8f91217-3925-420a-8350-a3eb74e2ceec"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("dd6d8c55-12bd-411d-8707-afa7ce8f252c"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("e9f403cc-e3de-4864-842b-62b3b90968db"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "389e650a-775f-4d7b-a9ac-30cfd960fa37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da9f09f9-1065-4120-9dbd-3c50cd62ae43", "AQAAAAIAAYagAAAAEHmXTtm1czFVsaKNLg5dd+jgMYeA/DGyJiDXmNSnOGPfJM0oxqkN8Hd3BVJriFb4ng==", "1a2b1755-da71-4736-96e1-5c2016ffecb1" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1457249d-fb94-4676-9af0-6bcd6ca824d7"), "All" },
                    { new Guid("a43cf53b-01e2-4df7-a0a4-7eae942bd0b2"), "BREAKING" },
                    { new Guid("b73215f7-65e2-43f4-b518-5ba071f6cb66"), "Lifestyle" },
                    { new Guid("c9d0e94f-4801-49dd-b3d0-b08fd4189574"), "Rising stars" },
                    { new Guid("f2ed0932-d209-43df-bbac-123397577896"), "New production" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("361e9025-92f3-4f89-b5ad-beb29dc8982b"), "Rap" },
                    { new Guid("460eb626-5b66-4005-90d8-05cd171f9886"), "House" },
                    { new Guid("5695dd23-4b01-4ace-aa3e-3932bf360ebe"), "Phonk" },
                    { new Guid("666f203c-a739-4cae-9bdf-7ca5d2b0688a"), "Techno" },
                    { new Guid("9b39b8fa-f3ed-41d3-a0c4-b185998c0443"), "Raeggeton" },
                    { new Guid("b0b686d1-3e14-4447-a823-2e3c01d401c5"), "Drill" },
                    { new Guid("f83ed182-56b8-43fc-9b2e-bfd2f3365d06"), "R&B" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01b5cabe-912c-4bf6-9541-937e09abaac5"), "South America" },
                    { new Guid("087281f3-1df8-4f44-8ee1-546d56f453e8"), "East Coast (NORTH AMERICA)" },
                    { new Guid("1125367f-e490-4735-bd1f-ee71633bb3d1"), "Oceania" },
                    { new Guid("1686a9ac-0644-4bef-b2b5-a31a12d400e0"), "West Asia" },
                    { new Guid("57fe94c9-cbd6-4d85-acdd-a04e430155cd"), "East Asia" },
                    { new Guid("781b6c1c-7018-4451-a06e-1b7d66bc5d3a"), "West Coast (NORTH AMERICA)" },
                    { new Guid("85ab7741-af16-4e17-86cf-682559d7bd3d"), "West Europe" },
                    { new Guid("887e05bf-2446-40e6-a46a-2318aeff8350"), "Balkans (EUROPE)" },
                    { new Guid("8c9bd28b-d680-4d0e-ad84-8d529625d2b5"), "East Europe" },
                    { new Guid("c440c301-beff-4302-af23-d79ecc582df1"), "Africa" },
                    { new Guid("cc839185-e022-4d01-8b77-ad499d1a9e37"), "Middle Asia" },
                    { new Guid("cea44e00-7d2c-498f-bd26-daeed7e240b5"), "Latin America" },
                    { new Guid("d34ecf01-6308-4c77-82cc-abd762f2418a"), "Middle East (ASIA)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1457249d-fb94-4676-9af0-6bcd6ca824d7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a43cf53b-01e2-4df7-a0a4-7eae942bd0b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b73215f7-65e2-43f4-b518-5ba071f6cb66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9d0e94f-4801-49dd-b3d0-b08fd4189574"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2ed0932-d209-43df-bbac-123397577896"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("361e9025-92f3-4f89-b5ad-beb29dc8982b"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("460eb626-5b66-4005-90d8-05cd171f9886"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("5695dd23-4b01-4ace-aa3e-3932bf360ebe"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("666f203c-a739-4cae-9bdf-7ca5d2b0688a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9b39b8fa-f3ed-41d3-a0c4-b185998c0443"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b0b686d1-3e14-4447-a823-2e3c01d401c5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f83ed182-56b8-43fc-9b2e-bfd2f3365d06"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("01b5cabe-912c-4bf6-9541-937e09abaac5"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("087281f3-1df8-4f44-8ee1-546d56f453e8"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1125367f-e490-4735-bd1f-ee71633bb3d1"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("1686a9ac-0644-4bef-b2b5-a31a12d400e0"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("57fe94c9-cbd6-4d85-acdd-a04e430155cd"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("781b6c1c-7018-4451-a06e-1b7d66bc5d3a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("85ab7741-af16-4e17-86cf-682559d7bd3d"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("887e05bf-2446-40e6-a46a-2318aeff8350"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("8c9bd28b-d680-4d0e-ad84-8d529625d2b5"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c440c301-beff-4302-af23-d79ecc582df1"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cc839185-e022-4d01-8b77-ad499d1a9e37"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("cea44e00-7d2c-498f-bd26-daeed7e240b5"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("d34ecf01-6308-4c77-82cc-abd762f2418a"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "389e650a-775f-4d7b-a9ac-30cfd960fa37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30337ff6-9bfd-42dc-a608-c0e82675dccd", "AQAAAAIAAYagAAAAEJPpNmMc9YLHeCQnjSeGO0Uc50/S8otMVLKsyhrhTN/Iz9uoZH3N4D7e6SR/hGdlVA==", "13ed8cd2-3eda-4a6d-9276-738db82a7511" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4bb7ea19-d5e7-425e-975f-d1ff8c821505"), "New production" },
                    { new Guid("5a404d01-59b0-467f-aa0c-b784965f925c"), "Rising stars" },
                    { new Guid("c13f4755-8c79-46be-aa27-7b1505eab3ac"), "BREAKING" },
                    { new Guid("ecc0c732-51bf-45d0-a646-785e578b92ed"), "Lifestyle" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0cc47a8b-fa7b-4a2f-8976-dbfd317408c6"), "House" },
                    { new Guid("1b99263a-f107-46ca-9130-1671a8b8e674"), "Drill" },
                    { new Guid("20b699af-cdf9-4d6c-83f7-7273d52403ae"), "Phonk" },
                    { new Guid("510fbafe-4d46-43f3-b9ee-d4e3273ee160"), "R&B" },
                    { new Guid("80961a64-8c18-4cc8-9476-d4d5637c6466"), "Raeggeton" },
                    { new Guid("864665ff-ed41-4f80-9fb9-ae7ff997f550"), "Techno" },
                    { new Guid("adbdd114-7d5f-49c6-883c-4134428f491b"), "Rap" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("112673bc-f145-4bcd-8329-1b10b7fe1084"), "West Europe" },
                    { new Guid("18ff037f-9216-4144-acd8-34afbc7b0ec4"), "West Coast (NORTH AMERICA)" },
                    { new Guid("290f1082-0449-49cd-86d1-0059a99be0ec"), "East Asia" },
                    { new Guid("2dcafb5c-498e-4e0e-907c-00ea009c01a4"), "East Coast (NORTH AMERICA)" },
                    { new Guid("5b225ec7-fb5d-4228-acb6-d9a14be0bbe1"), "West Asia" },
                    { new Guid("63faaca2-7b5c-463a-b76b-a784b4ed36e2"), "Middle East (ASIA)" },
                    { new Guid("8d13d374-998d-4394-ac14-2e7d416791ec"), "South America" },
                    { new Guid("95f8df2d-e7fb-4aa5-8bf9-0f8b8ee7587e"), "Balkans (EUROPE)" },
                    { new Guid("a1f4c1b9-3670-4be8-bdee-8334ec7165f4"), "Middle Asia" },
                    { new Guid("c8b05d04-4d24-4967-9d3b-499209f67358"), "Latin America" },
                    { new Guid("c8f91217-3925-420a-8350-a3eb74e2ceec"), "East Europe" },
                    { new Guid("dd6d8c55-12bd-411d-8707-afa7ce8f252c"), "Oceania" },
                    { new Guid("e9f403cc-e3de-4864-842b-62b3b90968db"), "Africa" }
                });
        }
    }
}
