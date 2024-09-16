using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerApp.Migrations
{
    /// <inheritdoc />
    public partial class Update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationForms_Tracks_TrackId",
                table: "ApplicationForms");

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("0ab636fb-08fc-4d97-b08c-12c05a72b556"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("43613151-2ed4-40be-8a09-d20ebedb05af"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("c4e7064c-45b0-4c2a-a8b4-2174b152ca2d"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("d4c1f6be-1aa9-48ea-b31d-d956abf9cd73"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("e1f1304e-2095-4fea-ad8d-3cb368502d74"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("fb1e845f-e57e-4257-a32a-9f078d296d6e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4908ce3c-46e0-4df3-bd5a-2e8619e59941");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68e62329-639b-45b7-be9a-13355669cd2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3bf2a83-f06e-4e6b-8f6d-11cbfadb5c25");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d46bdea5-c82d-4b67-9607-11c70db8a442");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e43c79a2-41d2-4f64-a7a1-045ed72d2c83");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5048b4f3-291f-421c-801a-0f5ddc56a97c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("608bc03a-ddad-4970-a01f-d609ee9515ea"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("0c145354-9ab8-410f-9ecc-016cf05a4563"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("0c89b28d-e92f-4ea9-988f-6094f7e6fe18"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("29a2930c-0dcf-42e9-a4d1-9af5cba09c74"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("3f1f446b-3055-4b25-8cfa-428556c85669"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("4ccbf775-ec5d-41f4-970c-72048f9a6dd6"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("5cb94647-f954-4ece-9ac3-5b60dd84a76f"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("61d3c9b4-b44b-4477-8d01-7d541c21d522"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("6d85f3c1-d9a7-43da-9dd1-470e7539720a"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("785685ad-7224-4684-80a4-7de53b8e7d94"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("8734264b-9e76-4489-a0b0-4bce0fad87bc"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("9653baff-2828-47d0-8c77-df6a88e60603"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("a52357d8-c670-4a88-8004-5058a0fa2a13"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("aa3af56f-84fe-44e8-b629-48c6510ca1f3"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("baa99643-8930-41cf-a41e-8e88f6fbe587"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("d5b0b764-5459-45e2-8fec-60678d92a387"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("d61e7443-e73f-4b32-aa1e-61b9766c319a"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("dc04c625-07c5-49ac-b283-f1b3891f5701"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("e413f770-3961-44d9-9e94-fc204cb9028d"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("e7298f04-7cd9-4732-9ba3-6bcbd280faf4"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("e97ddd38-a962-42c0-97e4-f66e205c7e86"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("f511d649-7dfa-4b24-a89a-8c4fb0ef36c6"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("f7ba2b6e-5957-4fb1-b621-8023555bc012"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("f81807a0-0275-43e0-9769-178e6fba1095"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("f8ac2cb5-db41-4a0d-86b3-55e3cd083c23"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("fd60a5ff-4385-48ea-8cf1-f089d7d3e34a"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("ff14b458-cf7a-48b6-85ff-cc3cb7789393"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("124e3159-dbe6-4f38-bb52-1629b5b6b312"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("1c86e180-64de-4d99-abf8-3c455cd07403"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("1c92f290-59e3-43a5-8744-caf4255fed05"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("2443bd06-a327-4a0e-9214-ee66b849a43b"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("2d9dcbc9-137f-43c0-ab9b-b086ee8c1f8e"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("2e6b944f-b75e-4744-bc8c-178eb1482a42"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("2eb1dfcd-be07-487a-9a3c-08afbf277f39"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("390e4d87-4657-4e79-b36a-6778487b3c51"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("418804e3-8775-4394-a3d5-9c726c2b4ce8"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("4bb36f26-c226-4bd6-a1d0-5f741b15ec10"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("4cc09bc7-e1cf-4ff7-b2a1-ea277f8f52cd"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("4f1b9510-3e16-46b9-acec-ba33905099d6"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("5604a2d9-73f3-4609-8ff3-7718a4e5bb56"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("58eb8f44-3e61-4b64-bcad-b96fd9c1c0a4"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("644ccc7c-7a81-4c00-8e8d-51dae75a4c27"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("7f9ad4b6-4b35-4350-b7ba-32253d27104f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("836cbbe7-9177-48f3-a002-235bcf1bf705"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("851e8910-8834-40b0-a9d9-eaf045f68627"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("8f1363cb-930f-4225-a9a3-765bbf6b112c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9121932a-b69e-45b2-8534-077d5b8fba02"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9a8e2a9b-0506-4b62-b0fe-24eebc5b61d5"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9ad1349b-6c42-4bd0-ac72-22e53ce1a708"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("aee7da82-8b04-4a92-9556-25ec93c5c1ea"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b02c5347-c73a-4139-84ce-9fddf7e60e23"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b2b40024-06a2-4c47-b8f5-adec704b0700"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("bf635166-9e45-4bc2-ac1f-02f49fe9f148"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("cc05da76-3187-4d2e-844a-11e642321d18"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("ce3ff3ff-006a-4d5c-ac2d-f73c98980e23"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("cf46870c-72bc-434e-8da0-13e4a6044f89"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("d92d242a-f13d-4bd6-9f48-8a18608b8b02"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("e813368a-a6b1-4ce3-b705-361b8963bc36"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("ee7af2b9-63ed-467a-8097-0a793b936775"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("f2acf8dc-bcfe-406d-8dbd-45089644403d"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("f9b99333-4529-47e3-aec2-cc95c2776a66"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("fcf4b207-40b2-43ce-b608-385314995938"));

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("021355c2-28b0-482e-8940-29848ba0e3f7"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("021355c2-28b0-482e-8940-29848ba0e3f7"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("24b8d3a1-9ef5-4cd6-b62b-4e0130649b68"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("24b8d3a1-9ef5-4cd6-b62b-4e0130649b68"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("494aaf71-2e72-4131-a81c-fb30e904f0a5"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("494aaf71-2e72-4131-a81c-fb30e904f0a5"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("4f662606-a956-4f10-9042-443ad2989452"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("df29bfca-db5a-4690-9789-1922afa19723"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("230dc038-45b0-49ed-9237-8fa471c6d27f"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("33df80f6-2c0d-47a0-ac0e-1116fe2fb8f6"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("3ea1dbb9-e8e5-42b9-957f-3450a70b8fd9"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("6faf4a66-de06-413b-871c-a7953033928e"), new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("798b0114-ed4b-4b3f-82f7-6a6b46565d83"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("7edead4d-9be4-4b33-a29d-97000155d38c"), new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("9483e0e8-592a-4966-bfc6-57969c12f3c2"), new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("9add7cdc-2de1-4016-8632-949a5e282d23"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("ad164da7-8d34-4734-ac1d-c19e7fbd1a9c"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("b64d5e46-7960-430b-b4d4-bcc7f2b93928"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("c0c1d00e-7251-4780-8f22-ce0289a91086"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("c4d593a5-5494-44bd-85c5-4d53a5601c82"), new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("d22fc1ff-6e1d-41fa-af8e-a4eede9ff358"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("d2c0b15f-41b4-40f9-9d91-6caac382ec5a"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("daafcaaf-f450-4e37-bbfd-3c7a3d03c2b1"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("daafcaaf-f450-4e37-bbfd-3c7a3d03c2b1"), new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("daafcaaf-f450-4e37-bbfd-3c7a3d03c2b1"), new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("e51fff4f-d19c-449a-a478-05aff9933bed"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("e644002f-1397-454e-8e90-b94187110030"), new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("f1329234-cbb1-4baf-9df8-dfc7463c44ee"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105"), new Guid("deed79c3-64e7-4de2-b51b-76b9487c778d") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("04fa5841-bc5f-4b27-a2bc-e81b7299caf1") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("c94feb10-12d7-46d0-bc44-6a403c8c871c") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("ed6ae8bc-7e2d-4b58-b8ef-3dafb24d7c7e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740"), new Guid("c36749b8-e3d8-4fe3-8cc5-0b8143e4a1ba") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740"), new Guid("c94feb10-12d7-46d0-bc44-6a403c8c871c") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("15f2ca6a-6008-4728-be13-9e10189482b8") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("a4dde68d-df59-48ad-87ee-5689da825566") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("ce3e60ed-9209-4318-8f8b-7ebbe0b29c33") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), new Guid("7f775f07-4b75-4f25-8871-378a128741f0") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), new Guid("9b7c8dd7-7c11-4967-b40e-36115c319e8b") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), new Guid("c36749b8-e3d8-4fe3-8cc5-0b8143e4a1ba") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("7a0fa9be-d40d-4673-9371-248b81367758") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("b4088ac0-0bf5-4466-855d-5176d55d1f86") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("e04a11b6-e134-4d3e-bad3-419fe566b94c"), new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("e04a11b6-e134-4d3e-bad3-419fe566b94c"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("e04a11b6-e134-4d3e-bad3-419fe566b94c"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("32a5d559-bf36-411a-81e7-ed4703712575") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("5163dda5-f512-486f-91d5-3ae5172942ce") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("52acedbd-bb1a-4e3b-a4f8-175d3af93158") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("8dc3dca4-7b56-4846-9aed-e1e5e178a4d2") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("924cb53c-6549-4c62-bb5a-e62ef2e67c66") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("aa0cfab9-25fc-40ec-af86-2e6e48da3b9b") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("aa719c79-70f8-4288-98f1-ea0485e152df") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740"), new Guid("32a5d559-bf36-411a-81e7-ed4703712575") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740"), new Guid("52acedbd-bb1a-4e3b-a4f8-175d3af93158") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740"), new Guid("7f343e91-4b6a-4d96-8ba1-f6d017baca60") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("23df4548-6856-4abd-8e67-cdd10ed0a17a") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("74907aa6-4388-4b94-974a-557dcc52b33f") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("b770b62e-ed58-49a5-bc69-42ece7281efe") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("c5385d47-a9f1-4adb-8162-678b37038971") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("c55b57e1-4b65-4acd-a49d-c1caf707a708") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("d82015dc-8fba-4864-aa5e-71b634fc61c6") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("e7ca8de7-d3c5-4a01-b128-ff8ab284f435") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), new Guid("3e28908e-c0bc-4fd2-bd70-a87c27aeb177") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), new Guid("7f343e91-4b6a-4d96-8ba1-f6d017baca60") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), new Guid("e453061d-cb03-48e4-ae8b-d9de68c47c4c") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("5d7018af-4240-4b31-8566-81d7cc46f076") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("7e8d7df2-58e0-403e-a28c-31d300fc6d9c") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("a7be8687-0e47-4001-be0c-f6105334f18c") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("ae2f89f8-1838-4529-8945-2612916a7dc3") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("e626aad0-2781-4823-a002-61428ed73c8d") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("e04a11b6-e134-4d3e-bad3-419fe566b94c"), new Guid("5e6914aa-a2dd-4931-a7f5-d87d3ce667bc") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("e04a11b6-e134-4d3e-bad3-419fe566b94c"), new Guid("7436d69b-1991-4aea-99e5-a5f31c1869d6") });

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("00f2f84b-2c0f-4065-9575-517eed00822e"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("07b97c14-2e72-4e5a-9c9c-63124c9d2513"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("0b68a4ad-1d3a-4a93-80a4-76b57563ca8a"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("13c95a51-4970-4f96-a6ab-7e05b8f3e4f8"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("1928a4ce-2b42-4bb7-b0ca-978365ec4e85"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("1f346c38-0b27-497b-b9fc-f77379a2fa3f"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("230c6d59-7dda-4e9c-b1c7-fbccdb2d0857"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("2361190a-b91e-459e-9860-839816ae123e"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("30a97e3b-7c95-4ccc-93ba-b0201aa022df"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("3508b889-0a8d-47ec-96ad-45d7fc46c730"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("4679f1a8-7f1b-4ec3-9193-8b9a849a3ac2"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("48bb77c9-e485-4be2-876c-30d01b224c50"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("51f9e184-dc27-4f98-ae37-db67db46bf52"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("54ed37e5-13c7-4dad-934a-02fd97ceb265"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("5cd2e23e-7df4-48a9-9ee1-a29ec06707dd"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("5f9ebb1e-d56c-4630-8195-1b4318382e5a"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("6361cc98-e14e-4087-83d1-19fb6e3053f6"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("7e3b94ca-d063-45a6-99aa-527ae68139db"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("80b1d4b0-be32-4f57-b4ef-6798470a47f4"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("902cb0ca-2261-453a-b325-b28a7237c419"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("9512696f-d806-46c0-8899-e51dcf774341"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("959d4e37-5d87-4aaa-b208-db9aa36e27c8"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("9c01cbda-9c58-4f7b-998e-398819bc092f"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("c98b14f5-c2c7-4381-92d1-16a274461c2d"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("caaf35dc-0e25-49a7-a8bd-0bc1a058526f"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("cd40c5a5-a414-4515-9286-9cffd1d8fc40"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("ce3f434c-59cc-4084-86e4-8e9d4c0a726d"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("d50854bb-bed2-469a-ad8f-e3fd88e9f0b1"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("d872fcb7-71ab-4ebc-a84b-4f1d67d68e6f"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("dc78b9d1-7948-4bf7-b036-b0ec57ca5291"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("df668b3f-dbca-4906-a666-fad5b38f20fe"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("e24cd41e-647b-4dda-afe5-5f5e0870f75b"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("e4109766-a430-4ce3-bc57-fd96663525ce"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("e681a03b-3dbb-4088-92ee-bc04a7305505"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("e7807f9f-e64f-43e1-a112-a76f64a1836d"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("ebf6a503-e52b-45e8-bb29-748ab2e0e9c1"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("ed8a147a-eb8c-4b57-bcd9-1fae211d42fb"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("f3a5b016-abe0-4d7d-a786-d99cc4e545b6"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("f5e387a0-7f17-4f5c-921c-b1e8159a64aa"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("fe5ae102-c3dd-4897-857a-cf100f510da7"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("003f2f8d-ecff-479a-8140-2082fc5f7d3b"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("0bc1f5db-692d-451a-b1dc-1717a49fe58a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("0d82cb01-e97a-4732-93f2-79fd07a74dcf"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("0db10ea0-84d0-468b-b2d9-a71543c6ab9c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("13693374-8d1f-4bdc-8850-f73798e0fb8c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("23fc3786-2c0e-4f1f-966d-b6bc1b29c8f6"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("828c935a-47d9-4403-897d-b71e23fc702f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("84e9cb4d-d481-49a7-a79f-860edbee5437"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("942e08d8-d118-4f7b-8262-94b45d29cc56"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("94bfb9d2-1c6a-45dc-94fa-ea4232c520c6"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("a02a8812-1647-454c-955e-fb5c595a7c79"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("aa207ddf-252c-47c4-aa2f-55a96678ef88"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("aae005a5-7406-4385-815c-aed03a628c31"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b785f8a4-4b63-4d93-ba77-0a296a29b40c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b85a8685-fc43-4d7f-b1d2-d335944e1015"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("ce36f90d-41b1-493f-b16d-0781dd0ab8b3"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("f3f5a7cf-3b71-4646-a340-d53525feb0e9"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("230dc038-45b0-49ed-9237-8fa471c6d27f"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("33df80f6-2c0d-47a0-ac0e-1116fe2fb8f6"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("3ea1dbb9-e8e5-42b9-957f-3450a70b8fd9"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("798b0114-ed4b-4b3f-82f7-6a6b46565d83"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("9add7cdc-2de1-4016-8632-949a5e282d23"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("ad164da7-8d34-4734-ac1d-c19e7fbd1a9c"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("b64d5e46-7960-430b-b4d4-bcc7f2b93928"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("c0c1d00e-7251-4780-8f22-ce0289a91086"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("d22fc1ff-6e1d-41fa-af8e-a4eede9ff358"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("d2c0b15f-41b4-40f9-9d91-6caac382ec5a"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("e51fff4f-d19c-449a-a478-05aff9933bed"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("f1329234-cbb1-4baf-9df8-dfc7463c44ee"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("e04a11b6-e134-4d3e-bad3-419fe566b94c"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("23df4548-6856-4abd-8e67-cdd10ed0a17a"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("32a5d559-bf36-411a-81e7-ed4703712575"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("3e28908e-c0bc-4fd2-bd70-a87c27aeb177"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("5163dda5-f512-486f-91d5-3ae5172942ce"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("52acedbd-bb1a-4e3b-a4f8-175d3af93158"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("5d7018af-4240-4b31-8566-81d7cc46f076"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("5e6914aa-a2dd-4931-a7f5-d87d3ce667bc"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("7436d69b-1991-4aea-99e5-a5f31c1869d6"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("74907aa6-4388-4b94-974a-557dcc52b33f"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("7e8d7df2-58e0-403e-a28c-31d300fc6d9c"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("7f343e91-4b6a-4d96-8ba1-f6d017baca60"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("8dc3dca4-7b56-4846-9aed-e1e5e178a4d2"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("924cb53c-6549-4c62-bb5a-e62ef2e67c66"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("a7be8687-0e47-4001-be0c-f6105334f18c"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("aa0cfab9-25fc-40ec-af86-2e6e48da3b9b"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("aa719c79-70f8-4288-98f1-ea0485e152df"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("ae2f89f8-1838-4529-8945-2612916a7dc3"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("b770b62e-ed58-49a5-bc69-42ece7281efe"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("c5385d47-a9f1-4adb-8162-678b37038971"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("c55b57e1-4b65-4acd-a49d-c1caf707a708"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("d82015dc-8fba-4864-aa5e-71b634fc61c6"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("e453061d-cb03-48e4-ae8b-d9de68c47c4c"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("e626aad0-2781-4823-a002-61428ed73c8d"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("e7ca8de7-d3c5-4a01-b128-ff8ab284f435"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("05f82324-25a8-4aeb-af16-85625f9af5e0"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("0daebd13-6273-4efa-b53d-154a28d7f559"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("14618955-2523-4e94-b629-72a933c180c9"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("24a08ad2-0357-4228-b84a-4855ef51dd00"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("37c1b027-4a14-4bae-980f-ecbd149bfc0a"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("65b5ae7b-ea77-402b-8069-1151737856bf"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("83ca003b-14e8-4a50-9807-268628d01a49"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("a5f2581a-e10a-4d07-99d5-a0eeb739ee6a"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("aac3a94f-9d72-4fc4-8140-dc5f3d7100c0"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("add690d6-ae49-4a9a-a4f8-620fc18b068d"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("c00f538b-0aab-4b49-98e9-b8d67cdb63ac"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("df28c8ce-efa6-4d10-88c2-1b06806ac944"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("fedd03d4-d1cb-43ee-af34-1c9f18b2e340"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("6faf4a66-de06-413b-871c-a7953033928e"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("7edead4d-9be4-4b33-a29d-97000155d38c"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("9483e0e8-592a-4966-bfc6-57969c12f3c2"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("c4d593a5-5494-44bd-85c5-4d53a5601c82"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("daafcaaf-f450-4e37-bbfd-3c7a3d03c2b1"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("e644002f-1397-454e-8e90-b94187110030"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("04fa5841-bc5f-4b27-a2bc-e81b7299caf1"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("15f2ca6a-6008-4728-be13-9e10189482b8"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("7a0fa9be-d40d-4673-9371-248b81367758"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("7f775f07-4b75-4f25-8871-378a128741f0"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("9b7c8dd7-7c11-4967-b40e-36115c319e8b"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("a4dde68d-df59-48ad-87ee-5689da825566"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("b4088ac0-0bf5-4466-855d-5176d55d1f86"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("c36749b8-e3d8-4fe3-8cc5-0b8143e4a1ba"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("c94feb10-12d7-46d0-bc44-6a403c8c871c"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("ce3e60ed-9209-4318-8f8b-7ebbe0b29c33"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("deed79c3-64e7-4de2-b51b-76b9487c778d"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("ed6ae8bc-7e2d-4b58-b8ef-3dafb24d7c7e"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("5dbaf338-a9e8-4e76-acb0-2771af5059a8"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("632cfd27-0c37-4e4c-ac4b-e01b54b35af7"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("7ff04fba-b9ce-4f6f-a95d-c806e045ab47"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("021355c2-28b0-482e-8940-29848ba0e3f7"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("24b8d3a1-9ef5-4cd6-b62b-4e0130649b68"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("494aaf71-2e72-4131-a81c-fb30e904f0a5"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("4f662606-a956-4f10-9042-443ad2989452"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("df29bfca-db5a-4690-9789-1922afa19723"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1"));

            migrationBuilder.AddColumn<Guid>(
                name: "ExpertCategoryId",
                table: "UserInfos",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "TrackId",
                table: "ApplicationForms",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<Guid>(
                name: "CropPhotoId",
                table: "ApplicationForms",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FullPhotoId",
                table: "ApplicationForms",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicationFormId = table.Column<Guid>(type: "uuid", nullable: false),
                    Base64Data = table.Column<string>(type: "text", nullable: false),
                    X = table.Column<int>(type: "integer", nullable: true),
                    Y = table.Column<int>(type: "integer", nullable: true),
                    Width = table.Column<int>(type: "integer", nullable: true),
                    Height = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_ApplicationForms_ApplicationFormId",
                        column: x => x.ApplicationFormId,
                        principalTable: "ApplicationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApplicationStatuses",
                columns: new[] { "Id", "Number", "Status" },
                values: new object[,]
                {
                    { new Guid("2e6a5aaa-494e-44a9-9ecf-4e7fdf3ce7e5"), 6, "Оценена" },
                    { new Guid("589e25e7-2206-4e89-9005-bfd27e199b09"), 1, "В ожидании заполнения" },
                    { new Guid("69ce8ef5-10ab-4e2c-bb3d-043606599f97"), 2, "В ожидании рассмотрения" },
                    { new Guid("6b6e4b56-02af-4d38-8f34-cfa5547a0ee9"), 3, "В процессе рассмотрения" },
                    { new Guid("b7c8b469-d82b-4a61-aeba-26778bef3878"), 5, "Отклонена" },
                    { new Guid("f8adf3fb-78c2-40dd-a86d-f61fec571ee6"), 4, "Одобрена" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "067f9bf5-01f0-4601-ac71-d88a049d4fc6", null, "Voter", "VOTER" },
                    { "0da4181a-593e-4f7d-9767-c6fb5e8a2afd", null, "Expert", "EXPERT" },
                    { "387fa4f1-9a4b-4220-865d-94109ed0c178", null, "Participant", "PARTICIPANT" },
                    { "453860a9-c070-421f-bfab-1e115956a240", null, "Organiser", "ORGANISER" },
                    { "82d72618-b9a1-481a-9b9b-8966605845bb", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("dc70050e-8a0d-4bf7-b000-c28a9e7f4fc8"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("fb3d35b4-0714-4554-bc99-656f6389538e"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("3655b305-9889-466f-ab55-7623874267ee"), "Категория участников", 2 },
                    { new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), "Общая информация", 1 },
                    { new Guid("62731439-799f-4932-9fd1-6036afabec1d"), "Профессиональное развитие", 4 },
                    { new Guid("66fe5b29-a67e-4dfd-a622-81588a032238"), "Конкурсная работа", 3 },
                    { new Guid("9fff5f41-a802-4ece-b7c3-337f78e9d8d7"), "Научно-исследовательская деятельность", 6 },
                    { new Guid("b8be6635-d51e-4508-93c3-2f3a3d5a1d92"), "Научно-педагогическая деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8"), "Основной", 1 },
                    { new Guid("276fbea5-bf07-4b4e-b90c-ba8c14188b5d"), "Конкурсная работа", 7 },
                    { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), "Методическая деятельность", 3 },
                    { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), "Образовательная деятельность", 2 },
                    { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), "Инновационная и иная деятельность", 6 },
                    { new Guid("f601769d-52f1-4b28-868e-3f564746fb81"), "Профессиональные показатели", 4 },
                    { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), "Научно-исследовательская деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("d60671d3-9f36-41f0-80ca-54193de4817e"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("190d5097-837b-4d36-9396-7f4b9a59cbdc"), "TextArea" },
                    { new Guid("256fb01d-4e96-49de-ba9b-a84799255770"), "int" },
                    { new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10"), "string" },
                    { new Guid("e0394b11-de23-4843-9083-8758660670c2"), "bool" },
                    { new Guid("edb72171-8e70-4555-b6be-898d37c10772"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("3655b305-9889-466f-ab55-7623874267ee"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") },
                    { new Guid("3655b305-9889-466f-ab55-7623874267ee"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") },
                    { new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") },
                    { new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") },
                    { new Guid("62731439-799f-4932-9fd1-6036afabec1d"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") },
                    { new Guid("62731439-799f-4932-9fd1-6036afabec1d"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") },
                    { new Guid("66fe5b29-a67e-4dfd-a622-81588a032238"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") },
                    { new Guid("66fe5b29-a67e-4dfd-a622-81588a032238"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") },
                    { new Guid("9fff5f41-a802-4ece-b7c3-337f78e9d8d7"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") },
                    { new Guid("b8be6635-d51e-4508-93c3-2f3a3d5a1d92"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0c70b404-02ea-495b-b8fa-038cbe1c3d57"), new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("1445c4ba-a522-41bd-881b-4134af4fe112"), new Guid("9fff5f41-a802-4ece-b7c3-337f78e9d8d7"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("2b5f4703-2cd5-41cd-a3d5-fba4cb37cefc"), new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("331704d1-3181-4e14-884e-1f40fec48bad"), new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("3d2db7e6-e669-45ee-ad06-025f01864c91"), new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("edb72171-8e70-4555-b6be-898d37c10772") },
                    { new Guid("49ac1af8-5465-4aed-92ec-fe3f8de28f75"), new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("70ea5770-08c0-4288-8dc7-a8703ef99acf"), new Guid("3655b305-9889-466f-ab55-7623874267ee"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("881194b6-56a1-4ade-9012-23a242549b30"), new Guid("9fff5f41-a802-4ece-b7c3-337f78e9d8d7"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("9ec0b684-0a30-43d2-adfa-f8a505d80f3f"), new Guid("b8be6635-d51e-4508-93c3-2f3a3d5a1d92"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("a231a100-9911-4a44-9a4d-c33669adb70a"), new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), null, true, true, "Место работы", 6, "Название организации", new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("a5f95b64-8155-4c21-881d-e7615470acde"), new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("c1caeab1-3aae-41b7-be40-850f2ed44b69"), new Guid("3655b305-9889-466f-ab55-7623874267ee"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("cfdade7a-32c9-478c-8c4f-7d334da45ea3"), new Guid("3655b305-9889-466f-ab55-7623874267ee"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("dc0a09bc-2390-478d-b5ae-f5a010669be0"), new Guid("b8be6635-d51e-4508-93c3-2f3a3d5a1d92"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("e6481124-ec7b-459c-99e1-2f3c98748b4a"), new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("e9378d76-e072-4a42-a35d-1095e9ec8768"), new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("f6a8c825-53bc-44ce-b387-235cc618b9d6"), new Guid("b8be6635-d51e-4508-93c3-2f3a3d5a1d92"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("fecff796-3072-4bbe-82a3-d48baede4407"), new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") },
                    { new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") },
                    { new Guid("276fbea5-bf07-4b4e-b90c-ba8c14188b5d"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") },
                    { new Guid("276fbea5-bf07-4b4e-b90c-ba8c14188b5d"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") },
                    { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") },
                    { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") },
                    { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") },
                    { new Guid("f601769d-52f1-4b28-868e-3f564746fb81"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") },
                    { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0868fc00-49d6-4eb6-b121-20ca952ec858"), new Guid("62731439-799f-4932-9fd1-6036afabec1d"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("30adce4d-d0a5-45fb-a73e-5356004987d3"), new Guid("9fff5f41-a802-4ece-b7c3-337f78e9d8d7"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("36339742-f4eb-4c30-a540-9437896be036"), new Guid("62731439-799f-4932-9fd1-6036afabec1d"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 },
                    { new Guid("3c14d209-bb43-4e71-a67c-0557963b7229"), new Guid("9fff5f41-a802-4ece-b7c3-337f78e9d8d7"), false, false, "Список научных публикаций за последние 5 лет", 10 },
                    { new Guid("45b480d1-ca40-4cc9-a05b-50a6b170e5ea"), new Guid("62731439-799f-4932-9fd1-6036afabec1d"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("53fcd0c6-3993-412b-8be7-606593531a87"), new Guid("b8be6635-d51e-4508-93c3-2f3a3d5a1d92"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc"), new Guid("66fe5b29-a67e-4dfd-a622-81588a032238"), true, true, "Краткая аннотация конкурсной работы", 1 },
                    { new Guid("81a623f2-eb3f-4acb-8b16-28c7da3ea5cb"), new Guid("b8be6635-d51e-4508-93c3-2f3a3d5a1d92"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 },
                    { new Guid("876b4bbb-181f-4965-8fea-051071b6409a"), new Guid("b8be6635-d51e-4508-93c3-2f3a3d5a1d92"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 },
                    { new Guid("9f761e48-8ba2-4de8-90cd-2404498ae940"), new Guid("b8be6635-d51e-4508-93c3-2f3a3d5a1d92"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("ae9f0af6-652d-42a2-8bce-4559f6cc8e9a"), new Guid("9fff5f41-a802-4ece-b7c3-337f78e9d8d7"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("eb84e29f-17be-4ae2-b842-4929b8f65dda"), new Guid("9fff5f41-a802-4ece-b7c3-337f78e9d8d7"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9"), new Guid("b8be6635-d51e-4508-93c3-2f3a3d5a1d92"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0097466c-9a6c-45e6-a9ad-edd28b1bd880"), true, "Ссылка", 5, new Guid("36339742-f4eb-4c30-a540-9437896be036"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("01a6cf7c-8b0c-49a4-abd7-eb98629d36e5"), true, "Статус", 4, new Guid("30adce4d-d0a5-45fb-a73e-5356004987d3"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("01c789cf-17cd-4524-9a70-3232929901db"), true, "Издание, год", 4, new Guid("3c14d209-bb43-4e71-a67c-0557963b7229"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("0267f748-56b4-4ce0-a572-31ea2414decf"), true, "Вид", 1, new Guid("eb84e29f-17be-4ae2-b842-4929b8f65dda"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("0340c06c-5f46-43a9-acf3-c7cbd9846300"), true, "Ссылка на платформу", 3, new Guid("9f761e48-8ba2-4de8-90cd-2404498ae940"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("0c2e1db1-faf9-4a7a-a1e4-5c98c119e712"), true, "ФИО соавторов", 3, new Guid("eb84e29f-17be-4ae2-b842-4929b8f65dda"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("1325d3ad-15ca-43c7-bd3e-3fc52efeac2a"), true, "Язык преподавания", 2, new Guid("53fcd0c6-3993-412b-8be7-606593531a87"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("19ad6681-da2e-4424-81cb-83e32ea55ea7"), true, "Соавторы", 2, new Guid("3c14d209-bb43-4e71-a67c-0557963b7229"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("2b94e1fe-9e00-4b8f-97d1-824203905975"), true, "Итого (час.)", 5, new Guid("53fcd0c6-3993-412b-8be7-606593531a87"), new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("2ccad87f-28f1-4a23-8715-5112968d585c"), true, "ФИО", 1, new Guid("81a623f2-eb3f-4acb-8b16-28c7da3ea5cb"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("38513fd7-cdbf-4d5f-a439-484530ab5302"), true, "Название организации в которую внедрена разработка", 3, new Guid("ae9f0af6-652d-42a2-8bce-4559f6cc8e9a"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("39722eba-75bf-4f6f-bfbc-9db9ed633a67"), true, "Соавторы", 2, new Guid("9f761e48-8ba2-4de8-90cd-2404498ae940"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("3a76dfb3-59a4-4032-bffe-1de0bf44c1d8"), true, "Год", 4, new Guid("9f761e48-8ba2-4de8-90cd-2404498ae940"), new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("3cf0ebf6-abc3-4252-8d73-f0162e944604"), true, "Название", 2, new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("3ea8611a-0ce9-4280-a68b-c79387a05ab5"), true, "Вид", 1, new Guid("ae9f0af6-652d-42a2-8bce-4559f6cc8e9a"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("4011c437-591c-4ea4-ae96-2b851e424b43"), true, "Язык публикации", 7, new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("42f5f763-5360-4bf8-b8ee-90843bcc6606"), true, "Ссылка на открытый доступ", 8, new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("46238373-44b4-4e41-bdc9-2cf866781468"), true, "Значение", 2, new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc"), new Guid("190d5097-837b-4d36-9396-7f4b9a59cbdc") },
                    { new Guid("4a277aef-01ae-4a93-807a-f249aa7b201f"), true, "Название", 1, new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("54457869-0660-4fa8-ab93-03c49b176b2f"), true, "Лекции (час.)", 3, new Guid("53fcd0c6-3993-412b-8be7-606593531a87"), new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("5e1a303c-cf50-4a03-b431-102650091e2a"), true, "Наименование курса", 1, new Guid("53fcd0c6-3993-412b-8be7-606593531a87"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("5ec5c1ea-3380-438f-ae2d-7e7fd1edee29"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("81a623f2-eb3f-4acb-8b16-28c7da3ea5cb"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("61ba9f35-2a66-4915-8f4b-666aa8404420"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("81a623f2-eb3f-4acb-8b16-28c7da3ea5cb"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("6b9c4e09-8a6d-4723-8555-4fad3ebefa6a"), true, "Вид", 2, new Guid("876b4bbb-181f-4965-8fea-051071b6409a"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("6f423038-ceb7-48d6-a9cb-d81c23a21c4a"), true, "Название дисциплины", 1, new Guid("876b4bbb-181f-4965-8fea-051071b6409a"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("702bc705-8407-48eb-bb3f-2785bfa1912c"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("876b4bbb-181f-4965-8fea-051071b6409a"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("75304386-e452-4aff-8f35-4db142533caa"), true, "Название разработки", 2, new Guid("ae9f0af6-652d-42a2-8bce-4559f6cc8e9a"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("75a3c765-ded6-4289-a9cf-fbbaf490c04d"), true, "Практические занятия (час.)", 4, new Guid("53fcd0c6-3993-412b-8be7-606593531a87"), new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("8344dc65-e4fd-40b2-b707-77d1b5953e3b"), true, "Название конкурса/премии", 2, new Guid("81a623f2-eb3f-4acb-8b16-28c7da3ea5cb"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("8ac564ed-8caa-4680-87cb-97aeceaf5d1a"), true, "Наличие грифа", 5, new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9"), new Guid("e0394b11-de23-4843-9083-8758660670c2") },
                    { new Guid("8d9d50a0-1326-4d94-a3d8-b6d857b2a2c2"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("30adce4d-d0a5-45fb-a73e-5356004987d3"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("8f6df6f6-4842-424b-9a42-ccaee3e70fb7"), true, "Название конкурса", 2, new Guid("36339742-f4eb-4c30-a540-9437896be036"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("901cb985-a809-483b-a1c0-945940927751"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("3c14d209-bb43-4e71-a67c-0557963b7229"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("911803d9-bd36-4679-aea1-2814facd5c3e"), true, "Название статьи", 1, new Guid("3c14d209-bb43-4e71-a67c-0557963b7229"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("925bd807-6454-411c-b2eb-64d520217533"), true, "Год получения документа", 2, new Guid("0868fc00-49d6-4eb6-b121-20ca952ec858"), new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("92dcae70-6445-4c76-aecd-2865880fc1f9"), false, "Тип идентификатора", 1, new Guid("45b480d1-ca40-4cc9-a05b-50a6b170e5ea"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("9eebccac-51bd-47d7-b07e-4dce990cdf64"), true, "Год", 1, new Guid("36339742-f4eb-4c30-a540-9437896be036"), new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("9efbfa9d-bfc5-47b0-a591-631898a7af6b"), true, "Название курса", 1, new Guid("9f761e48-8ba2-4de8-90cd-2404498ae940"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("ad27f10e-38f2-4f48-8122-f97c3aa8ed17"), true, "Издательство, год", 6, new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("ae4bf04d-245f-4fdd-a6f8-1a41c83b2604"), true, "Вид публикации", 1, new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("b1a10260-e985-40ee-903a-24be51547c91"), false, "Идентификатор", 2, new Guid("45b480d1-ca40-4cc9-a05b-50a6b170e5ea"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("b3d40368-a1a8-4004-ba6f-b03ad589e5c3"), true, "Год", 3, new Guid("81a623f2-eb3f-4acb-8b16-28c7da3ea5cb"), new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("b826d593-93c4-4212-a547-b9464acbeecf"), true, "Номер РИД", 4, new Guid("eb84e29f-17be-4ae2-b842-4929b8f65dda"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("bc1da0e8-e32d-4eb6-b1ff-38a812f39eac"), true, "Название НИР/НИОКР", 1, new Guid("30adce4d-d0a5-45fb-a73e-5356004987d3"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("c2191777-c244-4eab-a875-428946023a4a"), true, "Статус конкурса", 3, new Guid("36339742-f4eb-4c30-a540-9437896be036"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("c661a885-5da9-4f8a-88f4-53a0aa5b14e0"), true, "Название документа, реквизиты", 1, new Guid("0868fc00-49d6-4eb6-b121-20ca952ec858"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("cd2edf1c-10d0-4bed-9908-a025353ae4a3"), false, "Соавторы", 3, new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("d11b734c-7666-4c86-9d09-d316ddc84aa6"), true, "Период выполнения", 3, new Guid("30adce4d-d0a5-45fb-a73e-5356004987d3"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("e1342acd-727e-4c24-8d4d-ea9a03a52dac"), true, "Количество печатных листов", 4, new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9"), new Guid("256fb01d-4e96-49de-ba9b-a84799255770") },
                    { new Guid("e604de24-a635-440f-9599-f4a25b1aa54c"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("36339742-f4eb-4c30-a540-9437896be036"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("e932fc2d-0b95-4ea6-ae08-2c4ffe59c8d4"), true, "Название", 2, new Guid("eb84e29f-17be-4ae2-b842-4929b8f65dda"), new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10") },
                    { new Guid("ee775c9c-f324-40fb-b268-b2c90c4cc850"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("30adce4d-d0a5-45fb-a73e-5356004987d3"), new Guid("256fb01d-4e96-49de-ba9b-a84799255770") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("0c70b404-02ea-495b-b8fa-038cbe1c3d57"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") },
                    { new Guid("1445c4ba-a522-41bd-881b-4134af4fe112"), new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852") },
                    { new Guid("2b5f4703-2cd5-41cd-a3d5-fba4cb37cefc"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") },
                    { new Guid("331704d1-3181-4e14-884e-1f40fec48bad"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") },
                    { new Guid("3d2db7e6-e669-45ee-ad06-025f01864c91"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") },
                    { new Guid("49ac1af8-5465-4aed-92ec-fe3f8de28f75"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") },
                    { new Guid("70ea5770-08c0-4288-8dc7-a8703ef99acf"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") },
                    { new Guid("70ea5770-08c0-4288-8dc7-a8703ef99acf"), new Guid("f601769d-52f1-4b28-868e-3f564746fb81") },
                    { new Guid("70ea5770-08c0-4288-8dc7-a8703ef99acf"), new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852") },
                    { new Guid("881194b6-56a1-4ade-9012-23a242549b30"), new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852") },
                    { new Guid("9ec0b684-0a30-43d2-adfa-f8a505d80f3f"), new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9") },
                    { new Guid("a231a100-9911-4a44-9a4d-c33669adb70a"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") },
                    { new Guid("a5f95b64-8155-4c21-881d-e7615470acde"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") },
                    { new Guid("c1caeab1-3aae-41b7-be40-850f2ed44b69"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") },
                    { new Guid("cfdade7a-32c9-478c-8c4f-7d334da45ea3"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") },
                    { new Guid("dc0a09bc-2390-478d-b5ae-f5a010669be0"), new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9") },
                    { new Guid("e6481124-ec7b-459c-99e1-2f3c98748b4a"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") },
                    { new Guid("e9378d76-e072-4a42-a35d-1095e9ec8768"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") },
                    { new Guid("f6a8c825-53bc-44ce-b387-235cc618b9d6"), new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9") },
                    { new Guid("fecff796-3072-4bbe-82a3-d48baede4407"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8"), new Guid("45b480d1-ca40-4cc9-a05b-50a6b170e5ea") },
                    { new Guid("276fbea5-bf07-4b4e-b90c-ba8c14188b5d"), new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc") },
                    { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("876b4bbb-181f-4965-8fea-051071b6409a") },
                    { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9") },
                    { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("53fcd0c6-3993-412b-8be7-606593531a87") },
                    { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("81a623f2-eb3f-4acb-8b16-28c7da3ea5cb") },
                    { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("9f761e48-8ba2-4de8-90cd-2404498ae940") },
                    { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), new Guid("0868fc00-49d6-4eb6-b121-20ca952ec858") },
                    { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), new Guid("ae9f0af6-652d-42a2-8bce-4559f6cc8e9a") },
                    { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), new Guid("eb84e29f-17be-4ae2-b842-4929b8f65dda") },
                    { new Guid("f601769d-52f1-4b28-868e-3f564746fb81"), new Guid("0868fc00-49d6-4eb6-b121-20ca952ec858") },
                    { new Guid("f601769d-52f1-4b28-868e-3f564746fb81"), new Guid("36339742-f4eb-4c30-a540-9437896be036") },
                    { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("30adce4d-d0a5-45fb-a73e-5356004987d3") },
                    { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("36339742-f4eb-4c30-a540-9437896be036") },
                    { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("3c14d209-bb43-4e71-a67c-0557963b7229") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("03892237-d852-4c26-afd8-6012443aad77"), "EvaluateMark13", new Guid("70ea5770-08c0-4288-8dc7-a8703ef99acf"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("04b9c43e-c907-4794-ba79-dbeea4b14cd9"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("53fcd0c6-3993-412b-8be7-606593531a87") },
                    { new Guid("07d6b969-6835-46db-948c-1f31ef93e49f"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("0868fc00-49d6-4eb6-b121-20ca952ec858") },
                    { new Guid("1b391031-e591-4a05-b0ee-99f781280257"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом или на иностранном языке в соавторстве:", 9, new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9") },
                    { new Guid("1b8160fb-55b9-487f-b32e-160aa476b449"), "EvaluateMark19", new Guid("881194b6-56a1-4ade-9012-23a242549b30"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("3465675b-c9ec-4ec6-b13f-1f9ccb3ed8c4"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9") },
                    { new Guid("384a71cb-8100-4b22-9600-fd20d5aca9c4"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("81a623f2-eb3f-4acb-8b16-28c7da3ea5cb") },
                    { new Guid("41d09ce3-f5f1-4e63-9e0b-cdd26d16c859"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc") },
                    { new Guid("4cf40dff-5045-4845-bbb1-3d9fb716113f"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc") },
                    { new Guid("58a06d67-4db6-4e55-a71b-79410e6651c6"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9") },
                    { new Guid("58c207dc-cbe4-46c0-a465-3a9d74c9f4f8"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("876b4bbb-181f-4965-8fea-051071b6409a") },
                    { new Guid("6f7dc4d5-fb01-49b6-850e-8b703b36ed5c"), "EvaluateMark20", new Guid("1445c4ba-a522-41bd-881b-4134af4fe112"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("75a3a4d4-7f48-44ed-a820-d3b36b8ace64"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("30adce4d-d0a5-45fb-a73e-5356004987d3") },
                    { new Guid("7f4f3385-8dbb-4416-8453-5ec3d09f0bd1"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом или на иностранном языке и без соавторства:", 8, new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9") },
                    { new Guid("8203fd55-e096-44d0-93b8-617da7c0f4c6"), "EvaluateMark3", new Guid("9ec0b684-0a30-43d2-adfa-f8a505d80f3f"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("82d58435-e19f-47ce-b456-45e42804b6fc"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("9f761e48-8ba2-4de8-90cd-2404498ae940") },
                    { new Guid("93450311-e2e9-4cc0-903f-92e8664b6181"), "EvaluateMark4", new Guid("f6a8c825-53bc-44ce-b387-235cc618b9d6"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("975ce6b0-9486-495b-aaa6-a0291d8f8632"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("36339742-f4eb-4c30-a540-9437896be036") },
                    { new Guid("9b786580-847e-4409-961e-3eba09070458"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("eb84e29f-17be-4ae2-b842-4929b8f65dda") },
                    { new Guid("a2883a47-919a-4b07-ae2c-2d5a2840efca"), "EvaluateMark5", new Guid("dc0a09bc-2390-478d-b5ae-f5a010669be0"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("bfe2b329-2246-4edb-ad31-7f6129317322"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("3c14d209-bb43-4e71-a67c-0557963b7229") },
                    { new Guid("c0d6b14b-f810-4a54-a96e-b624193f93c4"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("53fcd0c6-3993-412b-8be7-606593531a87") },
                    { new Guid("e5a5c8cb-1343-41e2-a659-a630b6323a71"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("30adce4d-d0a5-45fb-a73e-5356004987d3") },
                    { new Guid("f42c7e01-9fa4-486f-8840-f104e29212b2"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("ae9f0af6-652d-42a2-8bce-4559f6cc8e9a") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0870ff75-d6df-4ab8-b8f5-89d0f4dac9e6"), true, 3, new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc") },
                    { new Guid("1a60ce30-3ab1-4da6-9e51-015f0b94fd76"), true, 4, new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc") },
                    { new Guid("1d5d064c-ab3c-4177-8aa7-5cc683eca015"), true, 4, new Guid("45b480d1-ca40-4cc9-a05b-50a6b170e5ea") },
                    { new Guid("1e6b9a57-54f9-4d4a-a394-69ed17b1bc60"), true, 1, new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc") },
                    { new Guid("402c0dcf-8322-486d-a233-c8349f09ce9a"), true, 2, new Guid("45b480d1-ca40-4cc9-a05b-50a6b170e5ea") },
                    { new Guid("4ca15ff2-fe58-4b4b-bbc4-8ae10e4c37db"), true, 8, new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc") },
                    { new Guid("5f8dab2e-85bf-4bd5-9f4c-80290baf43ec"), true, 2, new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc") },
                    { new Guid("80618b41-e40b-4a2c-b282-66263e1ecf74"), true, 6, new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc") },
                    { new Guid("8636e18e-99c9-4f99-9c3f-ffbfd5b57903"), true, 3, new Guid("45b480d1-ca40-4cc9-a05b-50a6b170e5ea") },
                    { new Guid("950b4fef-27b3-4e37-ad24-91bf3582f0a4"), true, 5, new Guid("45b480d1-ca40-4cc9-a05b-50a6b170e5ea") },
                    { new Guid("99357d1f-91f2-4b7d-9e99-3b785e2c9b40"), true, 7, new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc") },
                    { new Guid("c84ee1fc-5f8a-4d98-8b42-bea241311156"), true, 5, new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc") },
                    { new Guid("dc838202-edd5-4228-9137-2785e9f42c10"), true, 1, new Guid("45b480d1-ca40-4cc9-a05b-50a6b170e5ea") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0544bf2c-cac9-48b5-80f5-8e42638f26d9"), null, new Guid("c1caeab1-3aae-41b7-be40-850f2ed44b69"), "Доктор наук" },
                    { new Guid("7fa628ca-8c6a-4f82-bf7d-6708c1f75905"), null, new Guid("c1caeab1-3aae-41b7-be40-850f2ed44b69"), "Кандидат наук" },
                    { new Guid("8199324d-f2f1-4e7b-bcbd-12f98414263b"), null, new Guid("70ea5770-08c0-4288-8dc7-a8703ef99acf"), "Профессор" },
                    { new Guid("9af52107-99ae-4740-96ac-486984818e9f"), null, new Guid("70ea5770-08c0-4288-8dc7-a8703ef99acf"), "Доцент" },
                    { new Guid("c039e4c8-4683-44fc-a491-4c1ca809374c"), null, new Guid("70ea5770-08c0-4288-8dc7-a8703ef99acf"), "Нет" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("06ffbaf8-a11c-4477-bae7-83111a563946"), null, new Guid("4a277aef-01ae-4a93-807a-f249aa7b201f"), true, true, new Guid("99357d1f-91f2-4b7d-9e99-3b785e2c9b40"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("0e20de54-7e63-4570-9046-0d7ce3cd81a1"), null, new Guid("4a277aef-01ae-4a93-807a-f249aa7b201f"), true, true, new Guid("4ca15ff2-fe58-4b4b-bbc4-8ae10e4c37db"), "Результаты и выводы" },
                    { new Guid("1a94ccff-870f-4927-81ce-1b860379ba0c"), null, new Guid("b1a10260-e985-40ee-903a-24be51547c91"), false, true, new Guid("402c0dcf-8322-486d-a233-c8349f09ce9a"), null },
                    { new Guid("1cb629f7-5229-4542-ad61-0fedd23027e2"), null, new Guid("b1a10260-e985-40ee-903a-24be51547c91"), false, true, new Guid("1d5d064c-ab3c-4177-8aa7-5cc683eca015"), null },
                    { new Guid("244372b7-8418-4317-88db-c12d9d7bc707"), null, new Guid("4a277aef-01ae-4a93-807a-f249aa7b201f"), true, true, new Guid("c84ee1fc-5f8a-4d98-8b42-bea241311156"), "Ссылка на конкурсную работу" },
                    { new Guid("2c690fc5-0329-494f-bef3-eb3e489463bc"), null, new Guid("92dcae70-6445-4c76-aecd-2865880fc1f9"), true, true, new Guid("dc838202-edd5-4228-9137-2785e9f42c10"), "ScopusID" },
                    { new Guid("388aaa2e-4114-4beb-94d9-ae816800c257"), null, new Guid("4a277aef-01ae-4a93-807a-f249aa7b201f"), true, true, new Guid("0870ff75-d6df-4ab8-b8f5-89d0f4dac9e6"), "Инновационность" },
                    { new Guid("3e97ceb5-5b27-4eec-bb3e-3b0fa9e810cf"), null, new Guid("b1a10260-e985-40ee-903a-24be51547c91"), false, true, new Guid("8636e18e-99c9-4f99-9c3f-ffbfd5b57903"), null },
                    { new Guid("42042b76-5f4a-4fb8-a135-e940ecb085e9"), null, new Guid("46238373-44b4-4e41-bdc9-2cf866781468"), false, true, new Guid("1a60ce30-3ab1-4da6-9e51-015f0b94fd76"), null },
                    { new Guid("539a916b-4c69-4395-bd86-c661d33a33be"), null, new Guid("46238373-44b4-4e41-bdc9-2cf866781468"), false, true, new Guid("80618b41-e40b-4a2c-b282-66263e1ecf74"), null },
                    { new Guid("72bdf934-1536-42f3-aaa0-b8e55634e61c"), null, new Guid("46238373-44b4-4e41-bdc9-2cf866781468"), false, true, new Guid("0870ff75-d6df-4ab8-b8f5-89d0f4dac9e6"), null },
                    { new Guid("7654e91a-f4c3-4c73-be4a-d561f625b833"), null, new Guid("b1a10260-e985-40ee-903a-24be51547c91"), false, true, new Guid("950b4fef-27b3-4e37-ad24-91bf3582f0a4"), null },
                    { new Guid("7de580ae-5179-46f8-a2cc-47d00722b0a6"), null, new Guid("46238373-44b4-4e41-bdc9-2cf866781468"), false, true, new Guid("c84ee1fc-5f8a-4d98-8b42-bea241311156"), null },
                    { new Guid("80746ce7-1e1a-4c6f-91d4-447747087549"), null, new Guid("4a277aef-01ae-4a93-807a-f249aa7b201f"), true, true, new Guid("5f8dab2e-85bf-4bd5-9f4c-80290baf43ec"), "Актуальность конкурсной работы" },
                    { new Guid("819c20c7-24ec-4863-8769-9728c66aea78"), null, new Guid("92dcae70-6445-4c76-aecd-2865880fc1f9"), true, true, new Guid("402c0dcf-8322-486d-a233-c8349f09ce9a"), "ORCiD" },
                    { new Guid("84173bca-21e5-4d21-a7c5-400dbfacd2a7"), null, new Guid("92dcae70-6445-4c76-aecd-2865880fc1f9"), true, true, new Guid("8636e18e-99c9-4f99-9c3f-ffbfd5b57903"), "ResearcherID" },
                    { new Guid("84db48d3-0705-4733-8c47-baaafb75e077"), null, new Guid("4a277aef-01ae-4a93-807a-f249aa7b201f"), true, true, new Guid("1a60ce30-3ab1-4da6-9e51-015f0b94fd76"), "Методология и методы, используемые в работе" },
                    { new Guid("9db88a6e-6198-4425-ad4a-c5944f23f5d6"), null, new Guid("46238373-44b4-4e41-bdc9-2cf866781468"), false, true, new Guid("1e6b9a57-54f9-4d4a-a394-69ed17b1bc60"), null },
                    { new Guid("ac891551-31ab-4d00-b470-030df6f08ed9"), null, new Guid("46238373-44b4-4e41-bdc9-2cf866781468"), false, true, new Guid("5f8dab2e-85bf-4bd5-9f4c-80290baf43ec"), null },
                    { new Guid("b1256bf4-63a5-4381-9bb0-c79880dd636e"), null, new Guid("4a277aef-01ae-4a93-807a-f249aa7b201f"), true, true, new Guid("1e6b9a57-54f9-4d4a-a394-69ed17b1bc60"), "Название работы" },
                    { new Guid("b3e6e7a5-934c-4b42-99c3-7a92bee81ff0"), null, new Guid("4a277aef-01ae-4a93-807a-f249aa7b201f"), true, true, new Guid("80618b41-e40b-4a2c-b282-66263e1ecf74"), "Апробация" },
                    { new Guid("bc7f9ad1-9e51-4f2b-a300-b7ece4c7233d"), null, new Guid("46238373-44b4-4e41-bdc9-2cf866781468"), false, true, new Guid("4ca15ff2-fe58-4b4b-bbc4-8ae10e4c37db"), null },
                    { new Guid("d1f357da-f778-480e-a3e8-ce76a4d03b81"), null, new Guid("92dcae70-6445-4c76-aecd-2865880fc1f9"), true, true, new Guid("950b4fef-27b3-4e37-ad24-91bf3582f0a4"), "Google Scholar ID" },
                    { new Guid("dcab4dec-cb07-468b-ad25-c6e05413a598"), null, new Guid("46238373-44b4-4e41-bdc9-2cf866781468"), false, true, new Guid("99357d1f-91f2-4b7d-9e99-3b785e2c9b40"), null },
                    { new Guid("e73e4661-413b-4edd-84f0-6519802e1ee4"), null, new Guid("b1a10260-e985-40ee-903a-24be51547c91"), false, true, new Guid("dc838202-edd5-4228-9137-2785e9f42c10"), null },
                    { new Guid("f277867c-5416-4a46-b60a-9c4e57a275fa"), null, new Guid("92dcae70-6445-4c76-aecd-2865880fc1f9"), true, true, new Guid("1d5d064c-ab3c-4177-8aa7-5cc683eca015"), "РИНЦ AuthorID" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("276fbea5-bf07-4b4e-b90c-ba8c14188b5d"), new Guid("41d09ce3-f5f1-4e63-9e0b-cdd26d16c859") },
                    { new Guid("276fbea5-bf07-4b4e-b90c-ba8c14188b5d"), new Guid("4cf40dff-5045-4845-bbb1-3d9fb716113f") },
                    { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("1b391031-e591-4a05-b0ee-99f781280257") },
                    { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("3465675b-c9ec-4ec6-b13f-1f9ccb3ed8c4") },
                    { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("58a06d67-4db6-4e55-a71b-79410e6651c6") },
                    { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("58c207dc-cbe4-46c0-a465-3a9d74c9f4f8") },
                    { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("7f4f3385-8dbb-4416-8453-5ec3d09f0bd1") },
                    { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("04b9c43e-c907-4794-ba79-dbeea4b14cd9") },
                    { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("384a71cb-8100-4b22-9600-fd20d5aca9c4") },
                    { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("8203fd55-e096-44d0-93b8-617da7c0f4c6") },
                    { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("82d58435-e19f-47ce-b456-45e42804b6fc") },
                    { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("93450311-e2e9-4cc0-903f-92e8664b6181") },
                    { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("a2883a47-919a-4b07-ae2c-2d5a2840efca") },
                    { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("c0d6b14b-f810-4a54-a96e-b624193f93c4") },
                    { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), new Guid("07d6b969-6835-46db-948c-1f31ef93e49f") },
                    { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), new Guid("9b786580-847e-4409-961e-3eba09070458") },
                    { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), new Guid("f42c7e01-9fa4-486f-8840-f104e29212b2") },
                    { new Guid("f601769d-52f1-4b28-868e-3f564746fb81"), new Guid("03892237-d852-4c26-afd8-6012443aad77") },
                    { new Guid("f601769d-52f1-4b28-868e-3f564746fb81"), new Guid("07d6b969-6835-46db-948c-1f31ef93e49f") },
                    { new Guid("f601769d-52f1-4b28-868e-3f564746fb81"), new Guid("975ce6b0-9486-495b-aaa6-a0291d8f8632") },
                    { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("03892237-d852-4c26-afd8-6012443aad77") },
                    { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("1b8160fb-55b9-487f-b32e-160aa476b449") },
                    { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("6f7dc4d5-fb01-49b6-850e-8b703b36ed5c") },
                    { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("75a3a4d4-7f48-44ed-a820-d3b36b8ace64") },
                    { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("975ce6b0-9486-495b-aaa6-a0291d8f8632") },
                    { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("bfe2b329-2246-4edb-ad31-7f6129317322") },
                    { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("e5a5c8cb-1343-41e2-a659-a630b6323a71") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0049ac25-a548-4abd-a897-1867fbb1b67e"), new Guid("39722eba-75bf-4f6f-bfbc-9db9ed633a67"), null, "Нет" },
                    { new Guid("0222a1f4-6c33-434b-a4fb-5b17a63d0751"), new Guid("1325d3ad-15ca-43c7-bd3e-3fc52efeac2a"), null, "Другой" },
                    { new Guid("07867169-dda9-4845-816e-6e41135e9063"), new Guid("ae4bf04d-245f-4fdd-a6f8-1a41c83b2604"), null, "Монография" },
                    { new Guid("17032a0c-e323-4ee6-aa28-dedd51b180e4"), new Guid("c2191777-c244-4eab-a875-428946023a4a"), null, "Международный" },
                    { new Guid("17c50aa9-5afb-47da-98d9-529d60e943b5"), new Guid("19ad6681-da2e-4424-81cb-83e32ea55ea7"), null, "Нет" },
                    { new Guid("1ff83e82-d7a3-4883-9cae-e665b6342e61"), new Guid("3ea8611a-0ce9-4280-a68b-c79387a05ab5"), null, "Промышленный образец" },
                    { new Guid("2464152b-2ff0-4d31-9491-2afcda5d99b3"), new Guid("901cb985-a809-483b-a1c0-945940927751"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("2a3b2438-9732-4e27-a896-162d159c672f"), new Guid("0267f748-56b4-4ce0-a572-31ea2414decf"), null, "Промышленный образец" },
                    { new Guid("37398c23-d2b0-4cd4-bccf-9a73658ca8a6"), new Guid("901cb985-a809-483b-a1c0-945940927751"), null, "ВАК (К2-К3)" },
                    { new Guid("373edd21-0f63-4ef3-9cb3-bf859152b6c9"), new Guid("01a6cf7c-8b0c-49a4-abd7-eb98629d36e5"), null, "Руководитель" },
                    { new Guid("3c4cb424-afb0-4a92-80c9-b3f13d7f414f"), new Guid("c2191777-c244-4eab-a875-428946023a4a"), null, "Всероссийский" },
                    { new Guid("4519e656-f41b-41a6-99b8-6b9e92b14d24"), new Guid("8ac564ed-8caa-4680-87cb-97aeceaf5d1a"), null, "Нет" },
                    { new Guid("4f387f40-0e1f-4525-a809-891d66afd1b0"), new Guid("4011c437-591c-4ea4-ae96-2b851e424b43"), null, "Иностранный" },
                    { new Guid("5ee88b7c-8a6c-42b3-a937-a51159d2065b"), new Guid("1325d3ad-15ca-43c7-bd3e-3fc52efeac2a"), null, "Русский" },
                    { new Guid("68f2ea37-9d8b-4e7d-805f-020114962e54"), new Guid("0267f748-56b4-4ce0-a572-31ea2414decf"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("765d671b-5ad2-4b79-97ab-447a4f4fde4d"), new Guid("3ea8611a-0ce9-4280-a68b-c79387a05ab5"), null, "Полезная модель" },
                    { new Guid("7e653ab2-4e2e-4458-b87f-d02f7a68b14e"), new Guid("3ea8611a-0ce9-4280-a68b-c79387a05ab5"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("7e9d2439-9987-41ee-80ee-71c6a528a4f9"), new Guid("901cb985-a809-483b-a1c0-945940927751"), null, "РИНЦ" },
                    { new Guid("8325d568-1a89-4808-bbbe-f215525b2d58"), new Guid("1325d3ad-15ca-43c7-bd3e-3fc52efeac2a"), null, "Английский" },
                    { new Guid("8589b8d0-3b06-412b-af44-8c3e03ad7799"), new Guid("6b9c4e09-8a6d-4723-8555-4fad3ebefa6a"), null, "Лекции" },
                    { new Guid("862c5b5a-b4f7-4175-9be9-6f453766de6b"), new Guid("6b9c4e09-8a6d-4723-8555-4fad3ebefa6a"), null, "Лабораторные" },
                    { new Guid("885a9481-b114-43fb-8fe4-97bf44865b13"), new Guid("3ea8611a-0ce9-4280-a68b-c79387a05ab5"), null, "Изобретение" },
                    { new Guid("9a6a6e26-3753-4ebb-990b-003e82c71ed9"), new Guid("ae4bf04d-245f-4fdd-a6f8-1a41c83b2604"), null, "Учебник" },
                    { new Guid("9f6aa5ea-349b-462e-91eb-e81b809ff421"), new Guid("901cb985-a809-483b-a1c0-945940927751"), null, "МБД (Q3-Q4)" },
                    { new Guid("a46057d7-bd61-4431-9c55-06eca904027f"), new Guid("8ac564ed-8caa-4680-87cb-97aeceaf5d1a"), null, "Есть" },
                    { new Guid("b048460f-1837-4537-9a47-429ffbaade3b"), new Guid("19ad6681-da2e-4424-81cb-83e32ea55ea7"), null, "Есть" },
                    { new Guid("cb425bd7-d2db-413b-a491-0af516a19c36"), new Guid("c2191777-c244-4eab-a875-428946023a4a"), null, "Региональный" },
                    { new Guid("ceaae7e2-cc5b-429f-95a9-0952e412d91e"), new Guid("39722eba-75bf-4f6f-bfbc-9db9ed633a67"), null, "Есть" },
                    { new Guid("d1ca5133-5783-4ed7-902c-c1113b06f4c1"), new Guid("cd2edf1c-10d0-4bed-9908-a025353ae4a3"), null, "Нет" },
                    { new Guid("dffff950-9cce-438d-84c6-1440594c89ee"), new Guid("4011c437-591c-4ea4-ae96-2b851e424b43"), null, "Русский" },
                    { new Guid("ec9c4af0-b67d-43f2-9d42-83b870cedcb8"), new Guid("0267f748-56b4-4ce0-a572-31ea2414decf"), null, "Полезная модель" },
                    { new Guid("ef63a678-a6a9-42a8-9d04-f976554ceeb6"), new Guid("01a6cf7c-8b0c-49a4-abd7-eb98629d36e5"), null, "Исполнитель" },
                    { new Guid("f89e06f9-1490-48e2-8d86-cdd8d05d42c0"), new Guid("cd2edf1c-10d0-4bed-9908-a025353ae4a3"), null, "Есть" },
                    { new Guid("fca2c589-0e9b-423d-8e5d-2d141b610bf5"), new Guid("0267f748-56b4-4ce0-a572-31ea2414decf"), null, "Изобретение" },
                    { new Guid("fef0c01d-09c4-4861-8eaf-3e4c3df80c80"), new Guid("ae4bf04d-245f-4fdd-a6f8-1a41c83b2604"), null, "Учебное и/или учебно-методическое пособие" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_ExpertCategoryId",
                table: "UserInfos",
                column: "ExpertCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_CropPhotoId",
                table: "ApplicationForms",
                column: "CropPhotoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_FullPhotoId",
                table: "ApplicationForms",
                column: "FullPhotoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ApplicationFormId",
                table: "Photos",
                column: "ApplicationFormId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationForms_Photos_CropPhotoId",
                table: "ApplicationForms",
                column: "CropPhotoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationForms_Photos_FullPhotoId",
                table: "ApplicationForms",
                column: "FullPhotoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationForms_Tracks_TrackId",
                table: "ApplicationForms",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserInfos_Categories_ExpertCategoryId",
                table: "UserInfos",
                column: "ExpertCategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationForms_Photos_CropPhotoId",
                table: "ApplicationForms");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationForms_Photos_FullPhotoId",
                table: "ApplicationForms");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationForms_Tracks_TrackId",
                table: "ApplicationForms");

            migrationBuilder.DropForeignKey(
                name: "FK_UserInfos_Categories_ExpertCategoryId",
                table: "UserInfos");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_UserInfos_ExpertCategoryId",
                table: "UserInfos");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationForms_CropPhotoId",
                table: "ApplicationForms");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationForms_FullPhotoId",
                table: "ApplicationForms");

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("2e6a5aaa-494e-44a9-9ecf-4e7fdf3ce7e5"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("589e25e7-2206-4e89-9005-bfd27e199b09"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("69ce8ef5-10ab-4e2c-bb3d-043606599f97"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("6b6e4b56-02af-4d38-8f34-cfa5547a0ee9"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("b7c8b469-d82b-4a61-aeba-26778bef3878"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f8adf3fb-78c2-40dd-a86d-f61fec571ee6"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "067f9bf5-01f0-4601-ac71-d88a049d4fc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0da4181a-593e-4f7d-9767-c6fb5e8a2afd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "387fa4f1-9a4b-4220-865d-94109ed0c178");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "453860a9-c070-421f-bfab-1e115956a240");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82d72618-b9a1-481a-9b9b-8966605845bb");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dc70050e-8a0d-4bf7-b000-c28a9e7f4fc8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb3d35b4-0714-4554-bc99-656f6389538e"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("06ffbaf8-a11c-4477-bae7-83111a563946"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("0e20de54-7e63-4570-9046-0d7ce3cd81a1"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("1a94ccff-870f-4927-81ce-1b860379ba0c"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("1cb629f7-5229-4542-ad61-0fedd23027e2"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("244372b7-8418-4317-88db-c12d9d7bc707"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("2c690fc5-0329-494f-bef3-eb3e489463bc"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("388aaa2e-4114-4beb-94d9-ae816800c257"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("3e97ceb5-5b27-4eec-bb3e-3b0fa9e810cf"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("42042b76-5f4a-4fb8-a135-e940ecb085e9"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("539a916b-4c69-4395-bd86-c661d33a33be"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("72bdf934-1536-42f3-aaa0-b8e55634e61c"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("7654e91a-f4c3-4c73-be4a-d561f625b833"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("7de580ae-5179-46f8-a2cc-47d00722b0a6"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("80746ce7-1e1a-4c6f-91d4-447747087549"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("819c20c7-24ec-4863-8769-9728c66aea78"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("84173bca-21e5-4d21-a7c5-400dbfacd2a7"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("84db48d3-0705-4733-8c47-baaafb75e077"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("9db88a6e-6198-4425-ad4a-c5944f23f5d6"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("ac891551-31ab-4d00-b470-030df6f08ed9"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("b1256bf4-63a5-4381-9bb0-c79880dd636e"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("b3e6e7a5-934c-4b42-99c3-7a92bee81ff0"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("bc7f9ad1-9e51-4f2b-a300-b7ece4c7233d"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("d1f357da-f778-480e-a3e8-ce76a4d03b81"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("dcab4dec-cb07-468b-ad25-c6e05413a598"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("e73e4661-413b-4edd-84f0-6519802e1ee4"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("f277867c-5416-4a46-b60a-9c4e57a275fa"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("0097466c-9a6c-45e6-a9ad-edd28b1bd880"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("01c789cf-17cd-4524-9a70-3232929901db"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("0340c06c-5f46-43a9-acf3-c7cbd9846300"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("0c2e1db1-faf9-4a7a-a1e4-5c98c119e712"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("2b94e1fe-9e00-4b8f-97d1-824203905975"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("2ccad87f-28f1-4a23-8715-5112968d585c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("38513fd7-cdbf-4d5f-a439-484530ab5302"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("3a76dfb3-59a4-4032-bffe-1de0bf44c1d8"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("3cf0ebf6-abc3-4252-8d73-f0162e944604"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("42f5f763-5360-4bf8-b8ee-90843bcc6606"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("54457869-0660-4fa8-ab93-03c49b176b2f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("5e1a303c-cf50-4a03-b431-102650091e2a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("5ec5c1ea-3380-438f-ae2d-7e7fd1edee29"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("61ba9f35-2a66-4915-8f4b-666aa8404420"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("6f423038-ceb7-48d6-a9cb-d81c23a21c4a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("702bc705-8407-48eb-bb3f-2785bfa1912c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("75304386-e452-4aff-8f35-4db142533caa"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("75a3c765-ded6-4289-a9cf-fbbaf490c04d"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("8344dc65-e4fd-40b2-b707-77d1b5953e3b"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("8d9d50a0-1326-4d94-a3d8-b6d857b2a2c2"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("8f6df6f6-4842-424b-9a42-ccaee3e70fb7"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("911803d9-bd36-4679-aea1-2814facd5c3e"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("925bd807-6454-411c-b2eb-64d520217533"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9eebccac-51bd-47d7-b07e-4dce990cdf64"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9efbfa9d-bfc5-47b0-a591-631898a7af6b"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("ad27f10e-38f2-4f48-8122-f97c3aa8ed17"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b3d40368-a1a8-4004-ba6f-b03ad589e5c3"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b826d593-93c4-4212-a547-b9464acbeecf"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("bc1da0e8-e32d-4eb6-b1ff-38a812f39eac"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("c661a885-5da9-4f8a-88f4-53a0aa5b14e0"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("d11b734c-7666-4c86-9d09-d316ddc84aa6"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("e1342acd-727e-4c24-8d4d-ea9a03a52dac"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("e604de24-a635-440f-9599-f4a25b1aa54c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("e932fc2d-0b95-4ea6-ae08-2c4ffe59c8d4"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("ee775c9c-f324-40fb-b268-b2c90c4cc850"));

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("3655b305-9889-466f-ab55-7623874267ee"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("3655b305-9889-466f-ab55-7623874267ee"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("62731439-799f-4932-9fd1-6036afabec1d"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("62731439-799f-4932-9fd1-6036afabec1d"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("66fe5b29-a67e-4dfd-a622-81588a032238"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("66fe5b29-a67e-4dfd-a622-81588a032238"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("9fff5f41-a802-4ece-b7c3-337f78e9d8d7"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("b8be6635-d51e-4508-93c3-2f3a3d5a1d92"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("0c70b404-02ea-495b-b8fa-038cbe1c3d57"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("1445c4ba-a522-41bd-881b-4134af4fe112"), new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("2b5f4703-2cd5-41cd-a3d5-fba4cb37cefc"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("331704d1-3181-4e14-884e-1f40fec48bad"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("3d2db7e6-e669-45ee-ad06-025f01864c91"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("49ac1af8-5465-4aed-92ec-fe3f8de28f75"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("70ea5770-08c0-4288-8dc7-a8703ef99acf"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("70ea5770-08c0-4288-8dc7-a8703ef99acf"), new Guid("f601769d-52f1-4b28-868e-3f564746fb81") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("70ea5770-08c0-4288-8dc7-a8703ef99acf"), new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("881194b6-56a1-4ade-9012-23a242549b30"), new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("9ec0b684-0a30-43d2-adfa-f8a505d80f3f"), new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("a231a100-9911-4a44-9a4d-c33669adb70a"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("a5f95b64-8155-4c21-881d-e7615470acde"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("c1caeab1-3aae-41b7-be40-850f2ed44b69"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("cfdade7a-32c9-478c-8c4f-7d334da45ea3"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("dc0a09bc-2390-478d-b5ae-f5a010669be0"), new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("e6481124-ec7b-459c-99e1-2f3c98748b4a"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("e9378d76-e072-4a42-a35d-1095e9ec8768"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("f6a8c825-53bc-44ce-b387-235cc618b9d6"), new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("fecff796-3072-4bbe-82a3-d48baede4407"), new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8"), new Guid("45b480d1-ca40-4cc9-a05b-50a6b170e5ea") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("276fbea5-bf07-4b4e-b90c-ba8c14188b5d"), new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("876b4bbb-181f-4965-8fea-051071b6409a") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("53fcd0c6-3993-412b-8be7-606593531a87") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("81a623f2-eb3f-4acb-8b16-28c7da3ea5cb") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("9f761e48-8ba2-4de8-90cd-2404498ae940") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), new Guid("0868fc00-49d6-4eb6-b121-20ca952ec858") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), new Guid("ae9f0af6-652d-42a2-8bce-4559f6cc8e9a") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), new Guid("eb84e29f-17be-4ae2-b842-4929b8f65dda") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("f601769d-52f1-4b28-868e-3f564746fb81"), new Guid("0868fc00-49d6-4eb6-b121-20ca952ec858") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("f601769d-52f1-4b28-868e-3f564746fb81"), new Guid("36339742-f4eb-4c30-a540-9437896be036") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("30adce4d-d0a5-45fb-a73e-5356004987d3") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("36339742-f4eb-4c30-a540-9437896be036") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("3c14d209-bb43-4e71-a67c-0557963b7229") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("276fbea5-bf07-4b4e-b90c-ba8c14188b5d"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("276fbea5-bf07-4b4e-b90c-ba8c14188b5d"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("f601769d-52f1-4b28-868e-3f564746fb81"), new Guid("d60671d3-9f36-41f0-80ca-54193de4817e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("276fbea5-bf07-4b4e-b90c-ba8c14188b5d"), new Guid("41d09ce3-f5f1-4e63-9e0b-cdd26d16c859") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("276fbea5-bf07-4b4e-b90c-ba8c14188b5d"), new Guid("4cf40dff-5045-4845-bbb1-3d9fb716113f") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("1b391031-e591-4a05-b0ee-99f781280257") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("3465675b-c9ec-4ec6-b13f-1f9ccb3ed8c4") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("58a06d67-4db6-4e55-a71b-79410e6651c6") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("58c207dc-cbe4-46c0-a465-3a9d74c9f4f8") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"), new Guid("7f4f3385-8dbb-4416-8453-5ec3d09f0bd1") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("04b9c43e-c907-4794-ba79-dbeea4b14cd9") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("384a71cb-8100-4b22-9600-fd20d5aca9c4") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("8203fd55-e096-44d0-93b8-617da7c0f4c6") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("82d58435-e19f-47ce-b456-45e42804b6fc") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("93450311-e2e9-4cc0-903f-92e8664b6181") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("a2883a47-919a-4b07-ae2c-2d5a2840efca") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"), new Guid("c0d6b14b-f810-4a54-a96e-b624193f93c4") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), new Guid("07d6b969-6835-46db-948c-1f31ef93e49f") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), new Guid("9b786580-847e-4409-961e-3eba09070458") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"), new Guid("f42c7e01-9fa4-486f-8840-f104e29212b2") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("f601769d-52f1-4b28-868e-3f564746fb81"), new Guid("03892237-d852-4c26-afd8-6012443aad77") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("f601769d-52f1-4b28-868e-3f564746fb81"), new Guid("07d6b969-6835-46db-948c-1f31ef93e49f") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("f601769d-52f1-4b28-868e-3f564746fb81"), new Guid("975ce6b0-9486-495b-aaa6-a0291d8f8632") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("03892237-d852-4c26-afd8-6012443aad77") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("1b8160fb-55b9-487f-b32e-160aa476b449") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("6f7dc4d5-fb01-49b6-850e-8b703b36ed5c") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("75a3a4d4-7f48-44ed-a820-d3b36b8ace64") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("975ce6b0-9486-495b-aaa6-a0291d8f8632") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("bfe2b329-2246-4edb-ad31-7f6129317322") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"), new Guid("e5a5c8cb-1343-41e2-a659-a630b6323a71") });

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("0049ac25-a548-4abd-a897-1867fbb1b67e"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("0222a1f4-6c33-434b-a4fb-5b17a63d0751"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("0544bf2c-cac9-48b5-80f5-8e42638f26d9"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("07867169-dda9-4845-816e-6e41135e9063"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("17032a0c-e323-4ee6-aa28-dedd51b180e4"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("17c50aa9-5afb-47da-98d9-529d60e943b5"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("1ff83e82-d7a3-4883-9cae-e665b6342e61"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("2464152b-2ff0-4d31-9491-2afcda5d99b3"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("2a3b2438-9732-4e27-a896-162d159c672f"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("37398c23-d2b0-4cd4-bccf-9a73658ca8a6"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("373edd21-0f63-4ef3-9cb3-bf859152b6c9"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("3c4cb424-afb0-4a92-80c9-b3f13d7f414f"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("4519e656-f41b-41a6-99b8-6b9e92b14d24"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("4f387f40-0e1f-4525-a809-891d66afd1b0"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("5ee88b7c-8a6c-42b3-a937-a51159d2065b"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("68f2ea37-9d8b-4e7d-805f-020114962e54"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("765d671b-5ad2-4b79-97ab-447a4f4fde4d"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("7e653ab2-4e2e-4458-b87f-d02f7a68b14e"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("7e9d2439-9987-41ee-80ee-71c6a528a4f9"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("7fa628ca-8c6a-4f82-bf7d-6708c1f75905"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("8199324d-f2f1-4e7b-bcbd-12f98414263b"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("8325d568-1a89-4808-bbbe-f215525b2d58"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("8589b8d0-3b06-412b-af44-8c3e03ad7799"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("862c5b5a-b4f7-4175-9be9-6f453766de6b"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("885a9481-b114-43fb-8fe4-97bf44865b13"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("9a6a6e26-3753-4ebb-990b-003e82c71ed9"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("9af52107-99ae-4740-96ac-486984818e9f"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("9f6aa5ea-349b-462e-91eb-e81b809ff421"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("a46057d7-bd61-4431-9c55-06eca904027f"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("b048460f-1837-4537-9a47-429ffbaade3b"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("c039e4c8-4683-44fc-a491-4c1ca809374c"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("cb425bd7-d2db-413b-a491-0af516a19c36"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("ceaae7e2-cc5b-429f-95a9-0952e412d91e"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("d1ca5133-5783-4ed7-902c-c1113b06f4c1"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("dffff950-9cce-438d-84c6-1440594c89ee"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("ec9c4af0-b67d-43f2-9d42-83b870cedcb8"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("ef63a678-a6a9-42a8-9d04-f976554ceeb6"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("f89e06f9-1490-48e2-8d86-cdd8d05d42c0"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("fca2c589-0e9b-423d-8e5d-2d141b610bf5"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("fef0c01d-09c4-4861-8eaf-3e4c3df80c80"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("01a6cf7c-8b0c-49a4-abd7-eb98629d36e5"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("0267f748-56b4-4ce0-a572-31ea2414decf"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("1325d3ad-15ca-43c7-bd3e-3fc52efeac2a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("19ad6681-da2e-4424-81cb-83e32ea55ea7"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("39722eba-75bf-4f6f-bfbc-9db9ed633a67"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("3ea8611a-0ce9-4280-a68b-c79387a05ab5"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("4011c437-591c-4ea4-ae96-2b851e424b43"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("46238373-44b4-4e41-bdc9-2cf866781468"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("4a277aef-01ae-4a93-807a-f249aa7b201f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("6b9c4e09-8a6d-4723-8555-4fad3ebefa6a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("8ac564ed-8caa-4680-87cb-97aeceaf5d1a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("901cb985-a809-483b-a1c0-945940927751"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("92dcae70-6445-4c76-aecd-2865880fc1f9"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("ae4bf04d-245f-4fdd-a6f8-1a41c83b2604"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b1a10260-e985-40ee-903a-24be51547c91"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("c2191777-c244-4eab-a875-428946023a4a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("cd2edf1c-10d0-4bed-9908-a025353ae4a3"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("0c70b404-02ea-495b-b8fa-038cbe1c3d57"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("2b5f4703-2cd5-41cd-a3d5-fba4cb37cefc"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("331704d1-3181-4e14-884e-1f40fec48bad"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("3d2db7e6-e669-45ee-ad06-025f01864c91"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("49ac1af8-5465-4aed-92ec-fe3f8de28f75"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("a231a100-9911-4a44-9a4d-c33669adb70a"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("a5f95b64-8155-4c21-881d-e7615470acde"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("c1caeab1-3aae-41b7-be40-850f2ed44b69"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("cfdade7a-32c9-478c-8c4f-7d334da45ea3"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("e6481124-ec7b-459c-99e1-2f3c98748b4a"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("e9378d76-e072-4a42-a35d-1095e9ec8768"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("fecff796-3072-4bbe-82a3-d48baede4407"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("11cfb273-a9a4-4dcc-988e-df6bc48ae8e8"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("276fbea5-bf07-4b4e-b90c-ba8c14188b5d"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("89cc18ce-c4d2-4dfc-bdc9-91179e71ac80"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("cc9af131-0082-4dcd-b883-a52a8c435aa9"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("eb97d985-136b-44e9-b840-6ba480401b0c"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("f601769d-52f1-4b28-868e-3f564746fb81"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("fc0fdb42-6565-4141-96c8-5e492b32d852"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("03892237-d852-4c26-afd8-6012443aad77"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("04b9c43e-c907-4794-ba79-dbeea4b14cd9"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("07d6b969-6835-46db-948c-1f31ef93e49f"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("1b391031-e591-4a05-b0ee-99f781280257"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("1b8160fb-55b9-487f-b32e-160aa476b449"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("3465675b-c9ec-4ec6-b13f-1f9ccb3ed8c4"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("384a71cb-8100-4b22-9600-fd20d5aca9c4"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("41d09ce3-f5f1-4e63-9e0b-cdd26d16c859"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("4cf40dff-5045-4845-bbb1-3d9fb716113f"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("58a06d67-4db6-4e55-a71b-79410e6651c6"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("58c207dc-cbe4-46c0-a465-3a9d74c9f4f8"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("6f7dc4d5-fb01-49b6-850e-8b703b36ed5c"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("75a3a4d4-7f48-44ed-a820-d3b36b8ace64"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("7f4f3385-8dbb-4416-8453-5ec3d09f0bd1"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("8203fd55-e096-44d0-93b8-617da7c0f4c6"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("82d58435-e19f-47ce-b456-45e42804b6fc"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("93450311-e2e9-4cc0-903f-92e8664b6181"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("975ce6b0-9486-495b-aaa6-a0291d8f8632"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("9b786580-847e-4409-961e-3eba09070458"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("a2883a47-919a-4b07-ae2c-2d5a2840efca"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("bfe2b329-2246-4edb-ad31-7f6129317322"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("c0d6b14b-f810-4a54-a96e-b624193f93c4"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("e5a5c8cb-1343-41e2-a659-a630b6323a71"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("f42c7e01-9fa4-486f-8840-f104e29212b2"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("0870ff75-d6df-4ab8-b8f5-89d0f4dac9e6"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("1a60ce30-3ab1-4da6-9e51-015f0b94fd76"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("1d5d064c-ab3c-4177-8aa7-5cc683eca015"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("1e6b9a57-54f9-4d4a-a394-69ed17b1bc60"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("402c0dcf-8322-486d-a233-c8349f09ce9a"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("4ca15ff2-fe58-4b4b-bbc4-8ae10e4c37db"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("5f8dab2e-85bf-4bd5-9f4c-80290baf43ec"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("80618b41-e40b-4a2c-b282-66263e1ecf74"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("8636e18e-99c9-4f99-9c3f-ffbfd5b57903"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("950b4fef-27b3-4e37-ad24-91bf3582f0a4"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("99357d1f-91f2-4b7d-9e99-3b785e2c9b40"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("c84ee1fc-5f8a-4d98-8b42-bea241311156"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("dc838202-edd5-4228-9137-2785e9f42c10"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("7eebb55e-c1dd-4eae-8ce5-6e936d30741a"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d60671d3-9f36-41f0-80ca-54193de4817e"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("4bbaae6c-707a-42a1-9e11-1de1aeb75ae6"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("1445c4ba-a522-41bd-881b-4134af4fe112"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("70ea5770-08c0-4288-8dc7-a8703ef99acf"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("881194b6-56a1-4ade-9012-23a242549b30"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("9ec0b684-0a30-43d2-adfa-f8a505d80f3f"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("dc0a09bc-2390-478d-b5ae-f5a010669be0"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("f6a8c825-53bc-44ce-b387-235cc618b9d6"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0868fc00-49d6-4eb6-b121-20ca952ec858"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("30adce4d-d0a5-45fb-a73e-5356004987d3"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("36339742-f4eb-4c30-a540-9437896be036"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("3c14d209-bb43-4e71-a67c-0557963b7229"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("45b480d1-ca40-4cc9-a05b-50a6b170e5ea"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("53fcd0c6-3993-412b-8be7-606593531a87"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("6c85a69b-aeeb-4e85-aece-2111ee3f21cc"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("81a623f2-eb3f-4acb-8b16-28c7da3ea5cb"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("876b4bbb-181f-4965-8fea-051071b6409a"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("9f761e48-8ba2-4de8-90cd-2404498ae940"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("ae9f0af6-652d-42a2-8bce-4559f6cc8e9a"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("eb84e29f-17be-4ae2-b842-4929b8f65dda"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("edd9d9d9-9b87-4f2d-83cc-5ffc73c51ba9"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("190d5097-837b-4d36-9396-7f4b9a59cbdc"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("e0394b11-de23-4843-9083-8758660670c2"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("edb72171-8e70-4555-b6be-898d37c10772"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("3655b305-9889-466f-ab55-7623874267ee"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("62731439-799f-4932-9fd1-6036afabec1d"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("66fe5b29-a67e-4dfd-a622-81588a032238"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("9fff5f41-a802-4ece-b7c3-337f78e9d8d7"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("b8be6635-d51e-4508-93c3-2f3a3d5a1d92"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("256fb01d-4e96-49de-ba9b-a84799255770"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("4dabe178-165a-4ac1-9e13-cf7617a05d10"));

            migrationBuilder.DropColumn(
                name: "ExpertCategoryId",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "CropPhotoId",
                table: "ApplicationForms");

            migrationBuilder.DropColumn(
                name: "FullPhotoId",
                table: "ApplicationForms");

            migrationBuilder.AlterColumn<Guid>(
                name: "TrackId",
                table: "ApplicationForms",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "ApplicationStatuses",
                columns: new[] { "Id", "Number", "Status" },
                values: new object[,]
                {
                    { new Guid("0ab636fb-08fc-4d97-b08c-12c05a72b556"), 4, "Одобрена" },
                    { new Guid("43613151-2ed4-40be-8a09-d20ebedb05af"), 2, "В ожидании рассмотрения" },
                    { new Guid("c4e7064c-45b0-4c2a-a8b4-2174b152ca2d"), 3, "В процессе рассмотрения" },
                    { new Guid("d4c1f6be-1aa9-48ea-b31d-d956abf9cd73"), 6, "Оценена" },
                    { new Guid("e1f1304e-2095-4fea-ad8d-3cb368502d74"), 5, "Отклонена" },
                    { new Guid("fb1e845f-e57e-4257-a32a-9f078d296d6e"), 1, "В ожидании заполнения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4908ce3c-46e0-4df3-bd5a-2e8619e59941", null, "Admin", "ADMIN" },
                    { "68e62329-639b-45b7-be9a-13355669cd2e", null, "Organiser", "ORGANISER" },
                    { "d3bf2a83-f06e-4e6b-8f6d-11cbfadb5c25", null, "Participant", "PARTICIPANT" },
                    { "d46bdea5-c82d-4b67-9607-11c70db8a442", null, "Expert", "EXPERT" },
                    { "e43c79a2-41d2-4f64-a7a1-045ed72d2c83", null, "Voter", "VOTER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("5048b4f3-291f-421c-801a-0f5ddc56a97c"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("608bc03a-ddad-4970-a01f-d609ee9515ea"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("021355c2-28b0-482e-8940-29848ba0e3f7"), "Категория участников", 2 },
                    { new Guid("24b8d3a1-9ef5-4cd6-b62b-4e0130649b68"), "Профессиональное развитие", 4 },
                    { new Guid("494aaf71-2e72-4131-a81c-fb30e904f0a5"), "Конкурсная работа", 3 },
                    { new Guid("4f662606-a956-4f10-9042-443ad2989452"), "Научно-педагогическая деятельность", 5 },
                    { new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), "Общая информация", 1 },
                    { new Guid("df29bfca-db5a-4690-9789-1922afa19723"), "Научно-исследовательская деятельность", 6 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105"), "Основной", 1 },
                    { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740"), "Профессиональные показатели", 4 },
                    { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), "Образовательная деятельность", 2 },
                    { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), "Инновационная и иная деятельность", 6 },
                    { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), "Методическая деятельность", 3 },
                    { new Guid("e04a11b6-e134-4d3e-bad3-419fe566b94c"), "Конкурсная работа", 7 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876"), "string" },
                    { new Guid("5dbaf338-a9e8-4e76-acb0-2771af5059a8"), "DateTime" },
                    { new Guid("632cfd27-0c37-4e4c-ac4b-e01b54b35af7"), "bool" },
                    { new Guid("7ff04fba-b9ce-4f6f-a95d-c806e045ab47"), "TextArea" },
                    { new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1"), "int" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("021355c2-28b0-482e-8940-29848ba0e3f7"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") },
                    { new Guid("021355c2-28b0-482e-8940-29848ba0e3f7"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") },
                    { new Guid("24b8d3a1-9ef5-4cd6-b62b-4e0130649b68"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") },
                    { new Guid("24b8d3a1-9ef5-4cd6-b62b-4e0130649b68"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") },
                    { new Guid("494aaf71-2e72-4131-a81c-fb30e904f0a5"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") },
                    { new Guid("494aaf71-2e72-4131-a81c-fb30e904f0a5"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") },
                    { new Guid("4f662606-a956-4f10-9042-443ad2989452"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") },
                    { new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") },
                    { new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") },
                    { new Guid("df29bfca-db5a-4690-9789-1922afa19723"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("230dc038-45b0-49ed-9237-8fa471c6d27f"), new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("33df80f6-2c0d-47a0-ac0e-1116fe2fb8f6"), new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("3ea1dbb9-e8e5-42b9-957f-3450a70b8fd9"), new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("6faf4a66-de06-413b-871c-a7953033928e"), new Guid("4f662606-a956-4f10-9042-443ad2989452"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("798b0114-ed4b-4b3f-82f7-6a6b46565d83"), new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("5dbaf338-a9e8-4e76-acb0-2771af5059a8") },
                    { new Guid("7edead4d-9be4-4b33-a29d-97000155d38c"), new Guid("df29bfca-db5a-4690-9789-1922afa19723"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("9483e0e8-592a-4966-bfc6-57969c12f3c2"), new Guid("4f662606-a956-4f10-9042-443ad2989452"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("9add7cdc-2de1-4016-8632-949a5e282d23"), new Guid("021355c2-28b0-482e-8940-29848ba0e3f7"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("ad164da7-8d34-4734-ac1d-c19e7fbd1a9c"), new Guid("021355c2-28b0-482e-8940-29848ba0e3f7"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("b64d5e46-7960-430b-b4d4-bcc7f2b93928"), new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), null, true, true, "Место работы", 6, "Название организации", new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("c0c1d00e-7251-4780-8f22-ce0289a91086"), new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("c4d593a5-5494-44bd-85c5-4d53a5601c82"), new Guid("df29bfca-db5a-4690-9789-1922afa19723"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("d22fc1ff-6e1d-41fa-af8e-a4eede9ff358"), new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("d2c0b15f-41b4-40f9-9d91-6caac382ec5a"), new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("daafcaaf-f450-4e37-bbfd-3c7a3d03c2b1"), new Guid("021355c2-28b0-482e-8940-29848ba0e3f7"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("e51fff4f-d19c-449a-a478-05aff9933bed"), new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("e644002f-1397-454e-8e90-b94187110030"), new Guid("4f662606-a956-4f10-9042-443ad2989452"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("f1329234-cbb1-4baf-9df8-dfc7463c44ee"), new Guid("d96f0f82-e1d1-42c2-9889-45a69dbcbd4b"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") },
                    { new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") },
                    { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") },
                    { new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") },
                    { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") },
                    { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") },
                    { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") },
                    { new Guid("e04a11b6-e134-4d3e-bad3-419fe566b94c"), new Guid("1d74cfca-b595-4262-9f5f-3495fa1dd5ef") },
                    { new Guid("e04a11b6-e134-4d3e-bad3-419fe566b94c"), new Guid("8240ac67-ddae-4712-b1cf-50fdbcbec657") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("04fa5841-bc5f-4b27-a2bc-e81b7299caf1"), new Guid("df29bfca-db5a-4690-9789-1922afa19723"), false, false, "Список научных публикаций за последние 5 лет", 10 },
                    { new Guid("15f2ca6a-6008-4728-be13-9e10189482b8"), new Guid("4f662606-a956-4f10-9042-443ad2989452"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 },
                    { new Guid("7a0fa9be-d40d-4673-9371-248b81367758"), new Guid("4f662606-a956-4f10-9042-443ad2989452"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 },
                    { new Guid("7f775f07-4b75-4f25-8871-378a128741f0"), new Guid("df29bfca-db5a-4690-9789-1922afa19723"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("9b7c8dd7-7c11-4967-b40e-36115c319e8b"), new Guid("df29bfca-db5a-4690-9789-1922afa19723"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("a4dde68d-df59-48ad-87ee-5689da825566"), new Guid("4f662606-a956-4f10-9042-443ad2989452"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("b4088ac0-0bf5-4466-855d-5176d55d1f86"), new Guid("4f662606-a956-4f10-9042-443ad2989452"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 },
                    { new Guid("c36749b8-e3d8-4fe3-8cc5-0b8143e4a1ba"), new Guid("24b8d3a1-9ef5-4cd6-b62b-4e0130649b68"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("c94feb10-12d7-46d0-bc44-6a403c8c871c"), new Guid("24b8d3a1-9ef5-4cd6-b62b-4e0130649b68"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 },
                    { new Guid("ce3e60ed-9209-4318-8f8b-7ebbe0b29c33"), new Guid("4f662606-a956-4f10-9042-443ad2989452"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("deed79c3-64e7-4de2-b51b-76b9487c778d"), new Guid("24b8d3a1-9ef5-4cd6-b62b-4e0130649b68"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("ed6ae8bc-7e2d-4b58-b8ef-3dafb24d7c7e"), new Guid("df29bfca-db5a-4690-9789-1922afa19723"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a"), new Guid("494aaf71-2e72-4131-a81c-fb30e904f0a5"), true, true, "Краткая аннотация конкурсной работы", 1 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("003f2f8d-ecff-479a-8140-2082fc5f7d3b"), false, "Идентификатор", 2, new Guid("deed79c3-64e7-4de2-b51b-76b9487c778d"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("0bc1f5db-692d-451a-b1dc-1717a49fe58a"), false, "Тип идентификатора", 1, new Guid("deed79c3-64e7-4de2-b51b-76b9487c778d"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("0d82cb01-e97a-4732-93f2-79fd07a74dcf"), true, "Вид", 1, new Guid("9b7c8dd7-7c11-4967-b40e-36115c319e8b"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("0db10ea0-84d0-468b-b2d9-a71543c6ab9c"), true, "Язык публикации", 7, new Guid("7a0fa9be-d40d-4673-9371-248b81367758"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("124e3159-dbe6-4f38-bb52-1629b5b6b312"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("ed6ae8bc-7e2d-4b58-b8ef-3dafb24d7c7e"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("13693374-8d1f-4bdc-8850-f73798e0fb8c"), true, "Статус конкурса", 3, new Guid("c94feb10-12d7-46d0-bc44-6a403c8c871c"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("1c86e180-64de-4d99-abf8-3c455cd07403"), true, "ФИО соавторов", 3, new Guid("7f775f07-4b75-4f25-8871-378a128741f0"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("1c92f290-59e3-43a5-8744-caf4255fed05"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("ed6ae8bc-7e2d-4b58-b8ef-3dafb24d7c7e"), new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("23fc3786-2c0e-4f1f-966d-b6bc1b29c8f6"), true, "Вид публикации", 1, new Guid("7a0fa9be-d40d-4673-9371-248b81367758"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("2443bd06-a327-4a0e-9214-ee66b849a43b"), true, "Название разработки", 2, new Guid("9b7c8dd7-7c11-4967-b40e-36115c319e8b"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("2d9dcbc9-137f-43c0-ab9b-b086ee8c1f8e"), true, "Год получения документа", 2, new Guid("c36749b8-e3d8-4fe3-8cc5-0b8143e4a1ba"), new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("2e6b944f-b75e-4744-bc8c-178eb1482a42"), true, "Название", 2, new Guid("7a0fa9be-d40d-4673-9371-248b81367758"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("2eb1dfcd-be07-487a-9a3c-08afbf277f39"), true, "ФИО", 1, new Guid("15f2ca6a-6008-4728-be13-9e10189482b8"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("390e4d87-4657-4e79-b36a-6778487b3c51"), true, "Издательство, год", 6, new Guid("7a0fa9be-d40d-4673-9371-248b81367758"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("418804e3-8775-4394-a3d5-9c726c2b4ce8"), true, "Год", 4, new Guid("a4dde68d-df59-48ad-87ee-5689da825566"), new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("4bb36f26-c226-4bd6-a1d0-5f741b15ec10"), true, "Название конкурса/премии", 2, new Guid("15f2ca6a-6008-4728-be13-9e10189482b8"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("4cc09bc7-e1cf-4ff7-b2a1-ea277f8f52cd"), true, "Количество печатных листов", 4, new Guid("7a0fa9be-d40d-4673-9371-248b81367758"), new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("4f1b9510-3e16-46b9-acec-ba33905099d6"), true, "Название НИР/НИОКР", 1, new Guid("ed6ae8bc-7e2d-4b58-b8ef-3dafb24d7c7e"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("5604a2d9-73f3-4609-8ff3-7718a4e5bb56"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("15f2ca6a-6008-4728-be13-9e10189482b8"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("58eb8f44-3e61-4b64-bcad-b96fd9c1c0a4"), true, "Название документа, реквизиты", 1, new Guid("c36749b8-e3d8-4fe3-8cc5-0b8143e4a1ba"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("644ccc7c-7a81-4c00-8e8d-51dae75a4c27"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("15f2ca6a-6008-4728-be13-9e10189482b8"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("7f9ad4b6-4b35-4350-b7ba-32253d27104f"), true, "Название дисциплины", 1, new Guid("b4088ac0-0bf5-4466-855d-5176d55d1f86"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("828c935a-47d9-4403-897d-b71e23fc702f"), true, "Название", 1, new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("836cbbe7-9177-48f3-a002-235bcf1bf705"), true, "Название курса", 1, new Guid("a4dde68d-df59-48ad-87ee-5689da825566"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("84e9cb4d-d481-49a7-a79f-860edbee5437"), true, "Вид", 2, new Guid("b4088ac0-0bf5-4466-855d-5176d55d1f86"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("851e8910-8834-40b0-a9d9-eaf045f68627"), true, "Название конкурса", 2, new Guid("c94feb10-12d7-46d0-bc44-6a403c8c871c"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("8f1363cb-930f-4225-a9a3-765bbf6b112c"), true, "Ссылка на платформу", 3, new Guid("a4dde68d-df59-48ad-87ee-5689da825566"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("9121932a-b69e-45b2-8534-077d5b8fba02"), true, "Название организации в которую внедрена разработка", 3, new Guid("9b7c8dd7-7c11-4967-b40e-36115c319e8b"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("942e08d8-d118-4f7b-8262-94b45d29cc56"), false, "Соавторы", 3, new Guid("7a0fa9be-d40d-4673-9371-248b81367758"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("94bfb9d2-1c6a-45dc-94fa-ea4232c520c6"), true, "Вид", 1, new Guid("7f775f07-4b75-4f25-8871-378a128741f0"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("9a8e2a9b-0506-4b62-b0fe-24eebc5b61d5"), true, "Издание, год", 4, new Guid("04fa5841-bc5f-4b27-a2bc-e81b7299caf1"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("9ad1349b-6c42-4bd0-ac72-22e53ce1a708"), true, "Итого (час.)", 5, new Guid("ce3e60ed-9209-4318-8f8b-7ebbe0b29c33"), new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("a02a8812-1647-454c-955e-fb5c595a7c79"), true, "Наличие грифа", 5, new Guid("7a0fa9be-d40d-4673-9371-248b81367758"), new Guid("632cfd27-0c37-4e4c-ac4b-e01b54b35af7") },
                    { new Guid("aa207ddf-252c-47c4-aa2f-55a96678ef88"), true, "Соавторы", 2, new Guid("04fa5841-bc5f-4b27-a2bc-e81b7299caf1"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("aae005a5-7406-4385-815c-aed03a628c31"), true, "Статус", 4, new Guid("ed6ae8bc-7e2d-4b58-b8ef-3dafb24d7c7e"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("aee7da82-8b04-4a92-9556-25ec93c5c1ea"), true, "Наименование курса", 1, new Guid("ce3e60ed-9209-4318-8f8b-7ebbe0b29c33"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("b02c5347-c73a-4139-84ce-9fddf7e60e23"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("b4088ac0-0bf5-4466-855d-5176d55d1f86"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("b2b40024-06a2-4c47-b8f5-adec704b0700"), true, "Ссылка", 5, new Guid("c94feb10-12d7-46d0-bc44-6a403c8c871c"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("b785f8a4-4b63-4d93-ba77-0a296a29b40c"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("04fa5841-bc5f-4b27-a2bc-e81b7299caf1"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("b85a8685-fc43-4d7f-b1d2-d335944e1015"), true, "Значение", 2, new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a"), new Guid("7ff04fba-b9ce-4f6f-a95d-c806e045ab47") },
                    { new Guid("bf635166-9e45-4bc2-ac1f-02f49fe9f148"), true, "Ссылка на открытый доступ", 8, new Guid("7a0fa9be-d40d-4673-9371-248b81367758"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("cc05da76-3187-4d2e-844a-11e642321d18"), true, "Год", 3, new Guid("15f2ca6a-6008-4728-be13-9e10189482b8"), new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("ce36f90d-41b1-493f-b16d-0781dd0ab8b3"), true, "Язык преподавания", 2, new Guid("ce3e60ed-9209-4318-8f8b-7ebbe0b29c33"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("ce3ff3ff-006a-4d5c-ac2d-f73c98980e23"), true, "Период выполнения", 3, new Guid("ed6ae8bc-7e2d-4b58-b8ef-3dafb24d7c7e"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("cf46870c-72bc-434e-8da0-13e4a6044f89"), true, "Год", 1, new Guid("c94feb10-12d7-46d0-bc44-6a403c8c871c"), new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("d92d242a-f13d-4bd6-9f48-8a18608b8b02"), true, "Лекции (час.)", 3, new Guid("ce3e60ed-9209-4318-8f8b-7ebbe0b29c33"), new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("e813368a-a6b1-4ce3-b705-361b8963bc36"), true, "Номер РИД", 4, new Guid("7f775f07-4b75-4f25-8871-378a128741f0"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("ee7af2b9-63ed-467a-8097-0a793b936775"), true, "Практические занятия (час.)", 4, new Guid("ce3e60ed-9209-4318-8f8b-7ebbe0b29c33"), new Guid("b7e41199-b1e5-49be-b4a4-9ef19ffc8db1") },
                    { new Guid("f2acf8dc-bcfe-406d-8dbd-45089644403d"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("c94feb10-12d7-46d0-bc44-6a403c8c871c"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("f3f5a7cf-3b71-4646-a340-d53525feb0e9"), true, "Соавторы", 2, new Guid("a4dde68d-df59-48ad-87ee-5689da825566"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("f9b99333-4529-47e3-aec2-cc95c2776a66"), true, "Название статьи", 1, new Guid("04fa5841-bc5f-4b27-a2bc-e81b7299caf1"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") },
                    { new Guid("fcf4b207-40b2-43ce-b608-385314995938"), true, "Название", 2, new Guid("7f775f07-4b75-4f25-8871-378a128741f0"), new Guid("4e7806ec-2c88-4bc5-8011-ae16af801876") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("230dc038-45b0-49ed-9237-8fa471c6d27f"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") },
                    { new Guid("33df80f6-2c0d-47a0-ac0e-1116fe2fb8f6"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") },
                    { new Guid("3ea1dbb9-e8e5-42b9-957f-3450a70b8fd9"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") },
                    { new Guid("6faf4a66-de06-413b-871c-a7953033928e"), new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14") },
                    { new Guid("798b0114-ed4b-4b3f-82f7-6a6b46565d83"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") },
                    { new Guid("7edead4d-9be4-4b33-a29d-97000155d38c"), new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7") },
                    { new Guid("9483e0e8-592a-4966-bfc6-57969c12f3c2"), new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14") },
                    { new Guid("9add7cdc-2de1-4016-8632-949a5e282d23"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") },
                    { new Guid("ad164da7-8d34-4734-ac1d-c19e7fbd1a9c"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") },
                    { new Guid("b64d5e46-7960-430b-b4d4-bcc7f2b93928"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") },
                    { new Guid("c0c1d00e-7251-4780-8f22-ce0289a91086"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") },
                    { new Guid("c4d593a5-5494-44bd-85c5-4d53a5601c82"), new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7") },
                    { new Guid("d22fc1ff-6e1d-41fa-af8e-a4eede9ff358"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") },
                    { new Guid("d2c0b15f-41b4-40f9-9d91-6caac382ec5a"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") },
                    { new Guid("daafcaaf-f450-4e37-bbfd-3c7a3d03c2b1"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") },
                    { new Guid("daafcaaf-f450-4e37-bbfd-3c7a3d03c2b1"), new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7") },
                    { new Guid("daafcaaf-f450-4e37-bbfd-3c7a3d03c2b1"), new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740") },
                    { new Guid("e51fff4f-d19c-449a-a478-05aff9933bed"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") },
                    { new Guid("e644002f-1397-454e-8e90-b94187110030"), new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14") },
                    { new Guid("f1329234-cbb1-4baf-9df8-dfc7463c44ee"), new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("2333b215-3eb0-439a-acf9-0bfbdd7a3105"), new Guid("deed79c3-64e7-4de2-b51b-76b9487c778d") },
                    { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("04fa5841-bc5f-4b27-a2bc-e81b7299caf1") },
                    { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("c94feb10-12d7-46d0-bc44-6a403c8c871c") },
                    { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("ed6ae8bc-7e2d-4b58-b8ef-3dafb24d7c7e") },
                    { new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740"), new Guid("c36749b8-e3d8-4fe3-8cc5-0b8143e4a1ba") },
                    { new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740"), new Guid("c94feb10-12d7-46d0-bc44-6a403c8c871c") },
                    { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("15f2ca6a-6008-4728-be13-9e10189482b8") },
                    { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("a4dde68d-df59-48ad-87ee-5689da825566") },
                    { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("ce3e60ed-9209-4318-8f8b-7ebbe0b29c33") },
                    { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), new Guid("7f775f07-4b75-4f25-8871-378a128741f0") },
                    { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), new Guid("9b7c8dd7-7c11-4967-b40e-36115c319e8b") },
                    { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), new Guid("c36749b8-e3d8-4fe3-8cc5-0b8143e4a1ba") },
                    { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("7a0fa9be-d40d-4673-9371-248b81367758") },
                    { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("b4088ac0-0bf5-4466-855d-5176d55d1f86") },
                    { new Guid("e04a11b6-e134-4d3e-bad3-419fe566b94c"), new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("23df4548-6856-4abd-8e67-cdd10ed0a17a"), "EvaluateMark5", new Guid("e644002f-1397-454e-8e90-b94187110030"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("32a5d559-bf36-411a-81e7-ed4703712575"), "EvaluateMark13", new Guid("daafcaaf-f450-4e37-bbfd-3c7a3d03c2b1"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("3e28908e-c0bc-4fd2-bd70-a87c27aeb177"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("7f775f07-4b75-4f25-8871-378a128741f0") },
                    { new Guid("5163dda5-f512-486f-91d5-3ae5172942ce"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("ed6ae8bc-7e2d-4b58-b8ef-3dafb24d7c7e") },
                    { new Guid("52acedbd-bb1a-4e3b-a4f8-175d3af93158"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("c94feb10-12d7-46d0-bc44-6a403c8c871c") },
                    { new Guid("5d7018af-4240-4b31-8566-81d7cc46f076"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом или на иностранном языке в соавторстве:", 9, new Guid("7a0fa9be-d40d-4673-9371-248b81367758") },
                    { new Guid("5e6914aa-a2dd-4931-a7f5-d87d3ce667bc"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a") },
                    { new Guid("7436d69b-1991-4aea-99e5-a5f31c1869d6"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a") },
                    { new Guid("74907aa6-4388-4b94-974a-557dcc52b33f"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("ce3e60ed-9209-4318-8f8b-7ebbe0b29c33") },
                    { new Guid("7e8d7df2-58e0-403e-a28c-31d300fc6d9c"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("7a0fa9be-d40d-4673-9371-248b81367758") },
                    { new Guid("7f343e91-4b6a-4d96-8ba1-f6d017baca60"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("c36749b8-e3d8-4fe3-8cc5-0b8143e4a1ba") },
                    { new Guid("8dc3dca4-7b56-4846-9aed-e1e5e178a4d2"), "EvaluateMark19", new Guid("c4d593a5-5494-44bd-85c5-4d53a5601c82"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("924cb53c-6549-4c62-bb5a-e62ef2e67c66"), "EvaluateMark20", new Guid("7edead4d-9be4-4b33-a29d-97000155d38c"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("a7be8687-0e47-4001-be0c-f6105334f18c"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("b4088ac0-0bf5-4466-855d-5176d55d1f86") },
                    { new Guid("aa0cfab9-25fc-40ec-af86-2e6e48da3b9b"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("04fa5841-bc5f-4b27-a2bc-e81b7299caf1") },
                    { new Guid("aa719c79-70f8-4288-98f1-ea0485e152df"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("ed6ae8bc-7e2d-4b58-b8ef-3dafb24d7c7e") },
                    { new Guid("ae2f89f8-1838-4529-8945-2612916a7dc3"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("7a0fa9be-d40d-4673-9371-248b81367758") },
                    { new Guid("b770b62e-ed58-49a5-bc69-42ece7281efe"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("a4dde68d-df59-48ad-87ee-5689da825566") },
                    { new Guid("c5385d47-a9f1-4adb-8162-678b37038971"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("ce3e60ed-9209-4318-8f8b-7ebbe0b29c33") },
                    { new Guid("c55b57e1-4b65-4acd-a49d-c1caf707a708"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("15f2ca6a-6008-4728-be13-9e10189482b8") },
                    { new Guid("d82015dc-8fba-4864-aa5e-71b634fc61c6"), "EvaluateMark3", new Guid("9483e0e8-592a-4966-bfc6-57969c12f3c2"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("e453061d-cb03-48e4-ae8b-d9de68c47c4c"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("9b7c8dd7-7c11-4967-b40e-36115c319e8b") },
                    { new Guid("e626aad0-2781-4823-a002-61428ed73c8d"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом или на иностранном языке и без соавторства:", 8, new Guid("7a0fa9be-d40d-4673-9371-248b81367758") },
                    { new Guid("e7ca8de7-d3c5-4a01-b128-ff8ab284f435"), "EvaluateMark4", new Guid("6faf4a66-de06-413b-871c-a7953033928e"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("05f82324-25a8-4aeb-af16-85625f9af5e0"), true, 3, new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a") },
                    { new Guid("0daebd13-6273-4efa-b53d-154a28d7f559"), true, 2, new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a") },
                    { new Guid("14618955-2523-4e94-b629-72a933c180c9"), true, 7, new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a") },
                    { new Guid("24a08ad2-0357-4228-b84a-4855ef51dd00"), true, 8, new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a") },
                    { new Guid("37c1b027-4a14-4bae-980f-ecbd149bfc0a"), true, 5, new Guid("deed79c3-64e7-4de2-b51b-76b9487c778d") },
                    { new Guid("65b5ae7b-ea77-402b-8069-1151737856bf"), true, 1, new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a") },
                    { new Guid("83ca003b-14e8-4a50-9807-268628d01a49"), true, 3, new Guid("deed79c3-64e7-4de2-b51b-76b9487c778d") },
                    { new Guid("a5f2581a-e10a-4d07-99d5-a0eeb739ee6a"), true, 2, new Guid("deed79c3-64e7-4de2-b51b-76b9487c778d") },
                    { new Guid("aac3a94f-9d72-4fc4-8140-dc5f3d7100c0"), true, 6, new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a") },
                    { new Guid("add690d6-ae49-4a9a-a4f8-620fc18b068d"), true, 5, new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a") },
                    { new Guid("c00f538b-0aab-4b49-98e9-b8d67cdb63ac"), true, 4, new Guid("deed79c3-64e7-4de2-b51b-76b9487c778d") },
                    { new Guid("df28c8ce-efa6-4d10-88c2-1b06806ac944"), true, 1, new Guid("deed79c3-64e7-4de2-b51b-76b9487c778d") },
                    { new Guid("fedd03d4-d1cb-43ee-af34-1c9f18b2e340"), true, 4, new Guid("f1b6b87a-a6ca-45b2-9e0d-914fb601919a") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0b68a4ad-1d3a-4a93-80a4-76b57563ca8a"), null, new Guid("daafcaaf-f450-4e37-bbfd-3c7a3d03c2b1"), "Доцент" },
                    { new Guid("1f346c38-0b27-497b-b9fc-f77379a2fa3f"), null, new Guid("9add7cdc-2de1-4016-8632-949a5e282d23"), "Кандидат наук" },
                    { new Guid("3508b889-0a8d-47ec-96ad-45d7fc46c730"), null, new Guid("9add7cdc-2de1-4016-8632-949a5e282d23"), "Доктор наук" },
                    { new Guid("6361cc98-e14e-4087-83d1-19fb6e3053f6"), null, new Guid("daafcaaf-f450-4e37-bbfd-3c7a3d03c2b1"), "Нет" },
                    { new Guid("ebf6a503-e52b-45e8-bb29-748ab2e0e9c1"), null, new Guid("daafcaaf-f450-4e37-bbfd-3c7a3d03c2b1"), "Профессор" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("0c145354-9ab8-410f-9ecc-016cf05a4563"), null, new Guid("003f2f8d-ecff-479a-8140-2082fc5f7d3b"), false, true, new Guid("83ca003b-14e8-4a50-9807-268628d01a49"), null },
                    { new Guid("0c89b28d-e92f-4ea9-988f-6094f7e6fe18"), null, new Guid("b85a8685-fc43-4d7f-b1d2-d335944e1015"), false, true, new Guid("65b5ae7b-ea77-402b-8069-1151737856bf"), null },
                    { new Guid("29a2930c-0dcf-42e9-a4d1-9af5cba09c74"), null, new Guid("003f2f8d-ecff-479a-8140-2082fc5f7d3b"), false, true, new Guid("c00f538b-0aab-4b49-98e9-b8d67cdb63ac"), null },
                    { new Guid("3f1f446b-3055-4b25-8cfa-428556c85669"), null, new Guid("b85a8685-fc43-4d7f-b1d2-d335944e1015"), false, true, new Guid("24a08ad2-0357-4228-b84a-4855ef51dd00"), null },
                    { new Guid("4ccbf775-ec5d-41f4-970c-72048f9a6dd6"), null, new Guid("828c935a-47d9-4403-897d-b71e23fc702f"), true, true, new Guid("14618955-2523-4e94-b629-72a933c180c9"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("5cb94647-f954-4ece-9ac3-5b60dd84a76f"), null, new Guid("828c935a-47d9-4403-897d-b71e23fc702f"), true, true, new Guid("24a08ad2-0357-4228-b84a-4855ef51dd00"), "Результаты и выводы" },
                    { new Guid("61d3c9b4-b44b-4477-8d01-7d541c21d522"), null, new Guid("0bc1f5db-692d-451a-b1dc-1717a49fe58a"), true, true, new Guid("83ca003b-14e8-4a50-9807-268628d01a49"), "ResearcherID" },
                    { new Guid("6d85f3c1-d9a7-43da-9dd1-470e7539720a"), null, new Guid("b85a8685-fc43-4d7f-b1d2-d335944e1015"), false, true, new Guid("aac3a94f-9d72-4fc4-8140-dc5f3d7100c0"), null },
                    { new Guid("785685ad-7224-4684-80a4-7de53b8e7d94"), null, new Guid("003f2f8d-ecff-479a-8140-2082fc5f7d3b"), false, true, new Guid("df28c8ce-efa6-4d10-88c2-1b06806ac944"), null },
                    { new Guid("8734264b-9e76-4489-a0b0-4bce0fad87bc"), null, new Guid("0bc1f5db-692d-451a-b1dc-1717a49fe58a"), true, true, new Guid("a5f2581a-e10a-4d07-99d5-a0eeb739ee6a"), "ORCiD" },
                    { new Guid("9653baff-2828-47d0-8c77-df6a88e60603"), null, new Guid("b85a8685-fc43-4d7f-b1d2-d335944e1015"), false, true, new Guid("fedd03d4-d1cb-43ee-af34-1c9f18b2e340"), null },
                    { new Guid("a52357d8-c670-4a88-8004-5058a0fa2a13"), null, new Guid("828c935a-47d9-4403-897d-b71e23fc702f"), true, true, new Guid("0daebd13-6273-4efa-b53d-154a28d7f559"), "Актуальность конкурсной работы" },
                    { new Guid("aa3af56f-84fe-44e8-b629-48c6510ca1f3"), null, new Guid("828c935a-47d9-4403-897d-b71e23fc702f"), true, true, new Guid("aac3a94f-9d72-4fc4-8140-dc5f3d7100c0"), "Апробация" },
                    { new Guid("baa99643-8930-41cf-a41e-8e88f6fbe587"), null, new Guid("b85a8685-fc43-4d7f-b1d2-d335944e1015"), false, true, new Guid("0daebd13-6273-4efa-b53d-154a28d7f559"), null },
                    { new Guid("d5b0b764-5459-45e2-8fec-60678d92a387"), null, new Guid("003f2f8d-ecff-479a-8140-2082fc5f7d3b"), false, true, new Guid("37c1b027-4a14-4bae-980f-ecbd149bfc0a"), null },
                    { new Guid("d61e7443-e73f-4b32-aa1e-61b9766c319a"), null, new Guid("003f2f8d-ecff-479a-8140-2082fc5f7d3b"), false, true, new Guid("a5f2581a-e10a-4d07-99d5-a0eeb739ee6a"), null },
                    { new Guid("dc04c625-07c5-49ac-b283-f1b3891f5701"), null, new Guid("0bc1f5db-692d-451a-b1dc-1717a49fe58a"), true, true, new Guid("df28c8ce-efa6-4d10-88c2-1b06806ac944"), "ScopusID" },
                    { new Guid("e413f770-3961-44d9-9e94-fc204cb9028d"), null, new Guid("b85a8685-fc43-4d7f-b1d2-d335944e1015"), false, true, new Guid("14618955-2523-4e94-b629-72a933c180c9"), null },
                    { new Guid("e7298f04-7cd9-4732-9ba3-6bcbd280faf4"), null, new Guid("b85a8685-fc43-4d7f-b1d2-d335944e1015"), false, true, new Guid("add690d6-ae49-4a9a-a4f8-620fc18b068d"), null },
                    { new Guid("e97ddd38-a962-42c0-97e4-f66e205c7e86"), null, new Guid("828c935a-47d9-4403-897d-b71e23fc702f"), true, true, new Guid("fedd03d4-d1cb-43ee-af34-1c9f18b2e340"), "Методология и методы, используемые в работе" },
                    { new Guid("f511d649-7dfa-4b24-a89a-8c4fb0ef36c6"), null, new Guid("0bc1f5db-692d-451a-b1dc-1717a49fe58a"), true, true, new Guid("37c1b027-4a14-4bae-980f-ecbd149bfc0a"), "Google Scholar ID" },
                    { new Guid("f7ba2b6e-5957-4fb1-b621-8023555bc012"), null, new Guid("828c935a-47d9-4403-897d-b71e23fc702f"), true, true, new Guid("05f82324-25a8-4aeb-af16-85625f9af5e0"), "Инновационность" },
                    { new Guid("f81807a0-0275-43e0-9769-178e6fba1095"), null, new Guid("0bc1f5db-692d-451a-b1dc-1717a49fe58a"), true, true, new Guid("c00f538b-0aab-4b49-98e9-b8d67cdb63ac"), "РИНЦ AuthorID" },
                    { new Guid("f8ac2cb5-db41-4a0d-86b3-55e3cd083c23"), null, new Guid("828c935a-47d9-4403-897d-b71e23fc702f"), true, true, new Guid("add690d6-ae49-4a9a-a4f8-620fc18b068d"), "Ссылка на конкурсную работу" },
                    { new Guid("fd60a5ff-4385-48ea-8cf1-f089d7d3e34a"), null, new Guid("828c935a-47d9-4403-897d-b71e23fc702f"), true, true, new Guid("65b5ae7b-ea77-402b-8069-1151737856bf"), "Название работы" },
                    { new Guid("ff14b458-cf7a-48b6-85ff-cc3cb7789393"), null, new Guid("b85a8685-fc43-4d7f-b1d2-d335944e1015"), false, true, new Guid("05f82324-25a8-4aeb-af16-85625f9af5e0"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("32a5d559-bf36-411a-81e7-ed4703712575") },
                    { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("5163dda5-f512-486f-91d5-3ae5172942ce") },
                    { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("52acedbd-bb1a-4e3b-a4f8-175d3af93158") },
                    { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("8dc3dca4-7b56-4846-9aed-e1e5e178a4d2") },
                    { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("924cb53c-6549-4c62-bb5a-e62ef2e67c66") },
                    { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("aa0cfab9-25fc-40ec-af86-2e6e48da3b9b") },
                    { new Guid("5857dfea-ddfd-4191-adee-f3c11e9a74f7"), new Guid("aa719c79-70f8-4288-98f1-ea0485e152df") },
                    { new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740"), new Guid("32a5d559-bf36-411a-81e7-ed4703712575") },
                    { new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740"), new Guid("52acedbd-bb1a-4e3b-a4f8-175d3af93158") },
                    { new Guid("80e53ad6-eb2a-42bc-8a63-08380290e740"), new Guid("7f343e91-4b6a-4d96-8ba1-f6d017baca60") },
                    { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("23df4548-6856-4abd-8e67-cdd10ed0a17a") },
                    { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("74907aa6-4388-4b94-974a-557dcc52b33f") },
                    { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("b770b62e-ed58-49a5-bc69-42ece7281efe") },
                    { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("c5385d47-a9f1-4adb-8162-678b37038971") },
                    { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("c55b57e1-4b65-4acd-a49d-c1caf707a708") },
                    { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("d82015dc-8fba-4864-aa5e-71b634fc61c6") },
                    { new Guid("81562e43-d2e3-45f5-9592-bcb3ec405e14"), new Guid("e7ca8de7-d3c5-4a01-b128-ff8ab284f435") },
                    { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), new Guid("3e28908e-c0bc-4fd2-bd70-a87c27aeb177") },
                    { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), new Guid("7f343e91-4b6a-4d96-8ba1-f6d017baca60") },
                    { new Guid("a3145a8d-8469-47b7-a5c0-90325e48204f"), new Guid("e453061d-cb03-48e4-ae8b-d9de68c47c4c") },
                    { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("5d7018af-4240-4b31-8566-81d7cc46f076") },
                    { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("7e8d7df2-58e0-403e-a28c-31d300fc6d9c") },
                    { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("a7be8687-0e47-4001-be0c-f6105334f18c") },
                    { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("ae2f89f8-1838-4529-8945-2612916a7dc3") },
                    { new Guid("dd6c673f-2273-4598-ab0c-c58ed4f68490"), new Guid("e626aad0-2781-4823-a002-61428ed73c8d") },
                    { new Guid("e04a11b6-e134-4d3e-bad3-419fe566b94c"), new Guid("5e6914aa-a2dd-4931-a7f5-d87d3ce667bc") },
                    { new Guid("e04a11b6-e134-4d3e-bad3-419fe566b94c"), new Guid("7436d69b-1991-4aea-99e5-a5f31c1869d6") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("00f2f84b-2c0f-4065-9575-517eed00822e"), new Guid("a02a8812-1647-454c-955e-fb5c595a7c79"), null, "Нет" },
                    { new Guid("07b97c14-2e72-4e5a-9c9c-63124c9d2513"), new Guid("13693374-8d1f-4bdc-8850-f73798e0fb8c"), null, "Региональный" },
                    { new Guid("13c95a51-4970-4f96-a6ab-7e05b8f3e4f8"), new Guid("94bfb9d2-1c6a-45dc-94fa-ea4232c520c6"), null, "Промышленный образец" },
                    { new Guid("1928a4ce-2b42-4bb7-b0ca-978365ec4e85"), new Guid("84e9cb4d-d481-49a7-a79f-860edbee5437"), null, "Лекции" },
                    { new Guid("230c6d59-7dda-4e9c-b1c7-fbccdb2d0857"), new Guid("0db10ea0-84d0-468b-b2d9-a71543c6ab9c"), null, "Иностранный" },
                    { new Guid("2361190a-b91e-459e-9860-839816ae123e"), new Guid("ce36f90d-41b1-493f-b16d-0781dd0ab8b3"), null, "Другой" },
                    { new Guid("30a97e3b-7c95-4ccc-93ba-b0201aa022df"), new Guid("942e08d8-d118-4f7b-8262-94b45d29cc56"), null, "Нет" },
                    { new Guid("4679f1a8-7f1b-4ec3-9193-8b9a849a3ac2"), new Guid("b785f8a4-4b63-4d93-ba77-0a296a29b40c"), null, "ВАК (К2-К3)" },
                    { new Guid("48bb77c9-e485-4be2-876c-30d01b224c50"), new Guid("23fc3786-2c0e-4f1f-966d-b6bc1b29c8f6"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("51f9e184-dc27-4f98-ae37-db67db46bf52"), new Guid("13693374-8d1f-4bdc-8850-f73798e0fb8c"), null, "Международный" },
                    { new Guid("54ed37e5-13c7-4dad-934a-02fd97ceb265"), new Guid("ce36f90d-41b1-493f-b16d-0781dd0ab8b3"), null, "Русский" },
                    { new Guid("5cd2e23e-7df4-48a9-9ee1-a29ec06707dd"), new Guid("84e9cb4d-d481-49a7-a79f-860edbee5437"), null, "Лабораторные" },
                    { new Guid("5f9ebb1e-d56c-4630-8195-1b4318382e5a"), new Guid("13693374-8d1f-4bdc-8850-f73798e0fb8c"), null, "Всероссийский" },
                    { new Guid("7e3b94ca-d063-45a6-99aa-527ae68139db"), new Guid("942e08d8-d118-4f7b-8262-94b45d29cc56"), null, "Есть" },
                    { new Guid("80b1d4b0-be32-4f57-b4ef-6798470a47f4"), new Guid("b785f8a4-4b63-4d93-ba77-0a296a29b40c"), null, "МБД (Q3-Q4)" },
                    { new Guid("902cb0ca-2261-453a-b325-b28a7237c419"), new Guid("94bfb9d2-1c6a-45dc-94fa-ea4232c520c6"), null, "Изобретение" },
                    { new Guid("9512696f-d806-46c0-8899-e51dcf774341"), new Guid("0db10ea0-84d0-468b-b2d9-a71543c6ab9c"), null, "Русский" },
                    { new Guid("959d4e37-5d87-4aaa-b208-db9aa36e27c8"), new Guid("f3f5a7cf-3b71-4646-a340-d53525feb0e9"), null, "Есть" },
                    { new Guid("9c01cbda-9c58-4f7b-998e-398819bc092f"), new Guid("ce36f90d-41b1-493f-b16d-0781dd0ab8b3"), null, "Английский" },
                    { new Guid("c98b14f5-c2c7-4381-92d1-16a274461c2d"), new Guid("aae005a5-7406-4385-815c-aed03a628c31"), null, "Руководитель" },
                    { new Guid("caaf35dc-0e25-49a7-a8bd-0bc1a058526f"), new Guid("f3f5a7cf-3b71-4646-a340-d53525feb0e9"), null, "Нет" },
                    { new Guid("cd40c5a5-a414-4515-9286-9cffd1d8fc40"), new Guid("aae005a5-7406-4385-815c-aed03a628c31"), null, "Исполнитель" },
                    { new Guid("ce3f434c-59cc-4084-86e4-8e9d4c0a726d"), new Guid("0d82cb01-e97a-4732-93f2-79fd07a74dcf"), null, "Полезная модель" },
                    { new Guid("d50854bb-bed2-469a-ad8f-e3fd88e9f0b1"), new Guid("0d82cb01-e97a-4732-93f2-79fd07a74dcf"), null, "Изобретение" },
                    { new Guid("d872fcb7-71ab-4ebc-a84b-4f1d67d68e6f"), new Guid("b785f8a4-4b63-4d93-ba77-0a296a29b40c"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("dc78b9d1-7948-4bf7-b036-b0ec57ca5291"), new Guid("aa207ddf-252c-47c4-aa2f-55a96678ef88"), null, "Нет" },
                    { new Guid("df668b3f-dbca-4906-a666-fad5b38f20fe"), new Guid("0d82cb01-e97a-4732-93f2-79fd07a74dcf"), null, "Промышленный образец" },
                    { new Guid("e24cd41e-647b-4dda-afe5-5f5e0870f75b"), new Guid("23fc3786-2c0e-4f1f-966d-b6bc1b29c8f6"), null, "Монография" },
                    { new Guid("e4109766-a430-4ce3-bc57-fd96663525ce"), new Guid("b785f8a4-4b63-4d93-ba77-0a296a29b40c"), null, "РИНЦ" },
                    { new Guid("e681a03b-3dbb-4088-92ee-bc04a7305505"), new Guid("0d82cb01-e97a-4732-93f2-79fd07a74dcf"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("e7807f9f-e64f-43e1-a112-a76f64a1836d"), new Guid("23fc3786-2c0e-4f1f-966d-b6bc1b29c8f6"), null, "Учебник" },
                    { new Guid("ed8a147a-eb8c-4b57-bcd9-1fae211d42fb"), new Guid("94bfb9d2-1c6a-45dc-94fa-ea4232c520c6"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("f3a5b016-abe0-4d7d-a786-d99cc4e545b6"), new Guid("aa207ddf-252c-47c4-aa2f-55a96678ef88"), null, "Есть" },
                    { new Guid("f5e387a0-7f17-4f5c-921c-b1e8159a64aa"), new Guid("a02a8812-1647-454c-955e-fb5c595a7c79"), null, "Есть" },
                    { new Guid("fe5ae102-c3dd-4897-857a-cf100f510da7"), new Guid("94bfb9d2-1c6a-45dc-94fa-ea4232c520c6"), null, "Полезная модель" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationForms_Tracks_TrackId",
                table: "ApplicationForms",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
