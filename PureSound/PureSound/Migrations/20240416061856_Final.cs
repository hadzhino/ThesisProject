using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PureSound.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistTrack",
                keyColumn: "Id",
                keyValue: new Guid("1dd13004-b65e-4c81-90ff-bc37ae8f1c7f"));

            migrationBuilder.DeleteData(
                table: "ArtistTrack",
                keyColumn: "Id",
                keyValue: new Guid("33b0dbfc-9317-4fd4-87b8-3fd3f0803d70"));

            migrationBuilder.DeleteData(
                table: "ArtistTrack",
                keyColumn: "Id",
                keyValue: new Guid("42262c94-95a0-4e87-a4db-697c4582f1b2"));

            migrationBuilder.DeleteData(
                table: "ArtistTrack",
                keyColumn: "Id",
                keyValue: new Guid("66081109-7f77-4d4f-a978-11775e2b0cb7"));

            migrationBuilder.DeleteData(
                table: "ArtistTrack",
                keyColumn: "Id",
                keyValue: new Guid("9801f3e4-2cc6-462f-acc0-12c0a2de4f0c"));

            migrationBuilder.DeleteData(
                table: "ArtistTrack",
                keyColumn: "Id",
                keyValue: new Guid("a4253423-6233-4c4f-8702-088285dc6d5b"));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4d1215aa-20bb-400b-bdbe-bb0bb13a9f2b"),
                column: "Date",
                value: new DateTime(2024, 4, 16, 9, 18, 55, 950, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9c28287a-0179-441f-802d-85f55ee7d03b"),
                column: "Date",
                value: new DateTime(2024, 4, 16, 9, 18, 55, 950, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a68766f8-da87-4672-a3d0-8cf8bd49ab60"),
                column: "Date",
                value: new DateTime(2024, 4, 16, 9, 18, 55, 950, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bf78f1bc-6246-4ebb-ade4-5361f6686e41"),
                column: "Date",
                value: new DateTime(2024, 4, 16, 9, 18, 55, 950, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("fef49f2e-ae2b-4769-a10b-1ea542db6526"),
                column: "Date",
                value: new DateTime(2024, 4, 16, 9, 18, 55, 950, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.InsertData(
                table: "ArtistTrack",
                columns: new[] { "Id", "ArtistId", "TrackId" },
                values: new object[,]
                {
                    { new Guid("25a56057-160d-4393-a7e4-dcfcb0471b9b"), new Guid("e6bed5b4-70e9-48d4-b887-5c8339e088bd"), new Guid("2f725c58-72d6-4201-848c-b3cb521dfa9d") },
                    { new Guid("694666b7-8d77-4323-b15d-dfa13119be2a"), new Guid("fccdb498-2db4-4d0a-a7ee-85b61398a2cb"), new Guid("2f725c58-72d6-4201-848c-b3cb521dfa9d") },
                    { new Guid("7be1e508-0f45-47c8-9529-f933378a62eb"), new Guid("1189c2f4-96b9-41fa-aead-2de6e8f2b4b5"), new Guid("ebf7c421-7148-4f78-9c53-1600572c441f") },
                    { new Guid("847cc722-2fcd-427c-8de5-408ac203ef21"), new Guid("1e0677d5-29af-4ba5-b535-312c2b377d46"), new Guid("140931b6-1b86-4203-92fa-8e6c8558bbfa") },
                    { new Guid("bf90a765-b3c1-4714-927d-f2458e7502d7"), new Guid("231ff15f-d918-4aa4-8eb7-ad056f6130af"), new Guid("788944dc-fe8a-4c72-95a0-f2e7242a8a24") },
                    { new Guid("e35d03b1-94d5-4b27-a3e1-9eba3b427943"), new Guid("3032d205-1ade-4e21-91f7-d15845cbeff5"), new Guid("29edf751-e100-41b2-97eb-c517b0ba806f") }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "389e650a-775f-4d7b-a9ac-30cfd960fa37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e374d140-0a3c-4cad-a6c2-ba8ba433fb5e", "AQAAAAIAAYagAAAAEG7NGvDPVMx/aYevR0xgNEu5+8OEtPq0pg/EzkEhOdbdUejCXU0EsMvpj74Hjk9/Og==", "df6fe90e-ebb2-4b19-9bea-248c8f51e79c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArtistTrack",
                keyColumn: "Id",
                keyValue: new Guid("25a56057-160d-4393-a7e4-dcfcb0471b9b"));

            migrationBuilder.DeleteData(
                table: "ArtistTrack",
                keyColumn: "Id",
                keyValue: new Guid("694666b7-8d77-4323-b15d-dfa13119be2a"));

            migrationBuilder.DeleteData(
                table: "ArtistTrack",
                keyColumn: "Id",
                keyValue: new Guid("7be1e508-0f45-47c8-9529-f933378a62eb"));

            migrationBuilder.DeleteData(
                table: "ArtistTrack",
                keyColumn: "Id",
                keyValue: new Guid("847cc722-2fcd-427c-8de5-408ac203ef21"));

            migrationBuilder.DeleteData(
                table: "ArtistTrack",
                keyColumn: "Id",
                keyValue: new Guid("bf90a765-b3c1-4714-927d-f2458e7502d7"));

            migrationBuilder.DeleteData(
                table: "ArtistTrack",
                keyColumn: "Id",
                keyValue: new Guid("e35d03b1-94d5-4b27-a3e1-9eba3b427943"));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4d1215aa-20bb-400b-bdbe-bb0bb13a9f2b"),
                column: "Date",
                value: new DateTime(2024, 4, 10, 12, 35, 50, 732, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("9c28287a-0179-441f-802d-85f55ee7d03b"),
                column: "Date",
                value: new DateTime(2024, 4, 10, 12, 35, 50, 732, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a68766f8-da87-4672-a3d0-8cf8bd49ab60"),
                column: "Date",
                value: new DateTime(2024, 4, 10, 12, 35, 50, 732, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bf78f1bc-6246-4ebb-ade4-5361f6686e41"),
                column: "Date",
                value: new DateTime(2024, 4, 10, 12, 35, 50, 732, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("fef49f2e-ae2b-4769-a10b-1ea542db6526"),
                column: "Date",
                value: new DateTime(2024, 4, 10, 12, 35, 50, 732, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.InsertData(
                table: "ArtistTrack",
                columns: new[] { "Id", "ArtistId", "TrackId" },
                values: new object[,]
                {
                    { new Guid("1dd13004-b65e-4c81-90ff-bc37ae8f1c7f"), new Guid("1189c2f4-96b9-41fa-aead-2de6e8f2b4b5"), new Guid("ebf7c421-7148-4f78-9c53-1600572c441f") },
                    { new Guid("33b0dbfc-9317-4fd4-87b8-3fd3f0803d70"), new Guid("3032d205-1ade-4e21-91f7-d15845cbeff5"), new Guid("29edf751-e100-41b2-97eb-c517b0ba806f") },
                    { new Guid("42262c94-95a0-4e87-a4db-697c4582f1b2"), new Guid("231ff15f-d918-4aa4-8eb7-ad056f6130af"), new Guid("788944dc-fe8a-4c72-95a0-f2e7242a8a24") },
                    { new Guid("66081109-7f77-4d4f-a978-11775e2b0cb7"), new Guid("e6bed5b4-70e9-48d4-b887-5c8339e088bd"), new Guid("2f725c58-72d6-4201-848c-b3cb521dfa9d") },
                    { new Guid("9801f3e4-2cc6-462f-acc0-12c0a2de4f0c"), new Guid("1e0677d5-29af-4ba5-b535-312c2b377d46"), new Guid("140931b6-1b86-4203-92fa-8e6c8558bbfa") },
                    { new Guid("a4253423-6233-4c4f-8702-088285dc6d5b"), new Guid("fccdb498-2db4-4d0a-a7ee-85b61398a2cb"), new Guid("2f725c58-72d6-4201-848c-b3cb521dfa9d") }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "389e650a-775f-4d7b-a9ac-30cfd960fa37",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8152a766-fdcc-4244-9192-d47ea7bd2c7f", "AQAAAAIAAYagAAAAEPULS8g2OBgcxSGe2HE5wnlmTbEacHNJgSwWYv4fswXxNWCn6nLf6+pNuqAAW/bUvA==", "5b562117-8003-4bd5-822d-c3f9daa486f1" });
        }
    }
}
