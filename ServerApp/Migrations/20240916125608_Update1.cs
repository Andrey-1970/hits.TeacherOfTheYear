using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerApp.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("31b7f136-b6e9-4358-b3bd-1e8cd359acee"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("69278ad8-3fca-47f9-9a96-e84751a662a3"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("7036d9e1-98e3-47ae-8ede-a1b4ad297fa6"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("90aa7566-91c3-43ee-9b4f-9adf5798a3b8"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("a17750a1-c3e9-4524-8e20-d741348580a1"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("b302bffc-a0f9-4492-9ab6-681052f48063"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38bb985b-dec4-421a-b1f1-c04ae4741935");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53b2d16b-1b99-4d9e-9e58-277bb3ab8b90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f46b418-8d2f-4900-86b8-d0d39315a96f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2864396-d079-4ea5-979e-9e6064520825");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8929977-9b78-4c00-bee0-50fb55819d62");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4830978d-ceed-4a1e-a0f0-e96c5080ea98"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f43eda36-1d98-4b6b-80c9-fd5b42d040f6"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("0176aeb5-4d1c-42a2-bfb7-197d7514ad36"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("07216cd6-685d-4448-8dc4-bcb35eb4c57c"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("0dd08024-cbeb-4147-b800-1d042386da4a"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("0e2e0f54-a00e-46ba-a05d-470d38670d8a"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("19801b4e-ab6b-4324-9588-2b3663f0e560"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("2478c504-8204-4494-a47e-794ce0bdf742"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("253e3ba0-b2ed-4927-8059-336414947acb"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("32af5b34-9576-49cb-bf3d-8c552e04d7cf"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("3adc02a3-dfec-4282-842a-94dbb4cd6b09"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("55001ba0-3bcf-4736-8986-72df37163487"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("64e1fbe0-a821-42b1-b5dd-72e1762e8f4d"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("66e53646-d39d-484c-a2ef-72dbf86df729"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("7f60b3a3-ff50-4b60-8b71-906e12ead667"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("85cc5213-6ddb-4142-a2ed-7557728e35e9"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("8748b7c5-c781-49ae-b4fc-35937e90bcc2"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("8be7aba7-5bbc-4230-a7e2-bb191751bf57"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("93edd7cd-1aca-4163-8830-5689d0231d23"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("b93e16c2-1aef-466b-ade2-49a834f84cdb"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("bca1a84a-836b-4f53-be6a-241f63dcef14"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("bead9c52-6dfa-4e0a-aeb6-0c2b67bed25e"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("cb9a999d-d604-49ee-8661-8fb0ecddb96d"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("cdadec0b-ea18-4a0b-91f3-c79fc36011e5"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("d4189538-8f1a-4718-8a80-3492a42d55e7"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("de72d846-01d1-4608-ade5-a9110b76a99b"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("ed10c5a5-ee9c-4d4f-9861-43b0f29acb92"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("ef82e49f-8ab5-4e38-856c-f8f7d99b1c09"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("039c9e1d-0966-4b3d-ae0d-0effc327c9d1"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("03aa1578-1f5c-46f2-9dc8-1e54a0c36828"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("0e3c6a41-d9be-465e-8f1c-db0103f86295"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("2db5422d-aa7d-4384-a3c7-89c71191ba70"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("2f48f06f-2c40-42cc-b82b-f2e8cf92393f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("3771cf04-09f3-4b58-abd2-f006512d234d"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("3dad72e7-3926-4364-b78f-505ed37b9245"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("430b55f5-cd48-460e-bf02-d2ad1e37205f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("445ec93c-8e61-42c9-b7a0-8f18e76b00c1"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("44633c93-f4ea-4bf8-9e83-3782545d0553"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("4466f7ad-6b86-4958-a3db-23618fe55530"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("494d86fb-bada-45ab-9a1f-ae5013d01961"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("4c5cabc9-0c61-46e8-9724-583437de8bfc"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("512fde20-307e-469e-b265-4f95375c0c1f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("5e357a82-4986-407f-a18a-8cf61361932f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("686f349f-1c78-4f96-9339-788998b4f476"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("6cf36b5a-7e73-4b38-87e9-48879651a120"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("78241748-438d-4f86-a5a1-774d3922a3a5"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("83c9a1f6-af24-47f6-83ce-4dc2af45600a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("96473636-564b-4eb8-89aa-73ae2bb19da1"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9e4a9a78-27ca-4f6f-a69d-868c35513c84"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9e90dc00-6ab6-48c1-a973-eaa812a17771"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9fe89c8c-5250-4a53-93c3-f8c793dfbb60"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("a0108ea0-41ca-4d06-b69e-0d42e6df1543"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("a12cdc8d-783e-43f5-a845-3793342fe4f1"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("a33f9c70-a883-4ab7-ae28-3256a581954b"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("aa6deed9-1744-46ae-ae6c-75150c98b331"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b12cae10-eabe-4685-92ca-9aa0ff464bdd"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b30f3b2b-7eef-47b4-9812-826aac2ef167"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b649879d-b81b-464b-9940-5aa5bcf0b268"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b6c32f6e-79d6-4cf9-a8b6-7ea3d61455b1"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("c7b39b02-e13a-4833-8618-7556f7957f03"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("cc15dcb4-5577-4377-b9fd-57134f0cc2c1"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("eba0c1fa-d397-495d-82f8-4f004e33b4ab"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("f7cc557f-1d7a-42ec-8857-4b7539e8458b"));

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("a64f3e23-e949-482b-9aff-ae583a47e248"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("a64f3e23-e949-482b-9aff-ae583a47e248"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") });

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: new Guid("1b1ff588-19c1-4b91-ba4b-63fbf593d5c6"));

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("1cab6d78-2a80-41e0-8ea3-2e1db7ee6e48"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("3b97e544-cba5-450b-957f-a80ff4a72365"), new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("4610a55e-968f-40b1-85e5-01448b968819"), new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("4faf17ee-3feb-454e-ad6b-d7ff4369ddc3"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("7fa13c92-a4ee-4c68-9702-f439e380a050"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("84b047dd-251c-4652-9044-f5cb64bd1de9"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("87c9a3d2-ee5d-4374-bb80-67b31e9afdae"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("9841de6b-7ed4-40a3-97f1-c82ac5466455"), new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("9e1e83cf-18a1-40eb-adac-49799e913d92"), new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("a28c4190-b0ad-445b-b967-05b943d9d536"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("b3be7eef-3aba-4b0c-8bdd-f6974999c02c"), new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("c34361b9-88b6-418a-ac1f-63d94e63d647"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("c38b35b5-1e66-42d1-bd84-9a589d79a407"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("c4d26f9e-117b-4bb8-ae87-f6bec5f1a591"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("d6a9f624-8610-4668-8ace-8eb455bdc924"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("e7b09488-1a82-4f45-a4fc-a1d96ac736af"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("ed5e778e-1c26-43fb-be9c-595cc97d5ea6"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("5b946941-2de7-41d0-80c0-956c98109d5b") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("b1beb533-0148-4fb4-8583-7404245bf510") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5"), new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("03578da2-2afc-45ff-88c8-e2e8b2a467af") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("119bc69d-6943-4f3a-82aa-dad403bd1cfe") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("31805c88-e5d5-4206-95e9-77e3323ce315") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("54591336-9dd6-4cd2-8ae8-d5aa61bfa0fb") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("b697fae5-e4b9-491a-97ec-c952dff212c0") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("c18bac77-3759-40f8-84e6-148d172a4a78") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("d340ce13-534b-491a-ae2b-bc70acf5bd8d") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("eb7353cc-da32-4af4-8300-f6e03380296e") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("0c1d163a-c4f3-4f3a-b332-b31a7d450c56") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("5c9159e7-8856-45b9-9831-295ff470140f") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("879d05e5-0be1-4631-a9b0-04a84ae1dc54") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("18c164c9-4a97-49e6-bf43-c1c4dde7c5e4") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("c11c58a4-9919-4fb5-aad6-4e997e21b5e0") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("3a735671-f0b5-454c-a686-bbcc1bf90caf") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("a2d4a97f-ee90-4167-9162-ef8aff3f34ac") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("ad730fe6-d0ae-4dfb-a73f-d448aa062c37") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("cc23f918-3108-4b54-8f6a-e57565899a10") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("cef4c968-643e-45d5-a29d-77601f00a506") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("484a0ea6-1c6e-4ce6-9394-d31cee4be3c0") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("547916f4-a0eb-478a-8d11-997adb500129") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("5c9159e7-8856-45b9-9831-295ff470140f") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("8077572e-3e83-4e14-84ab-0082f43e308e") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("879d05e5-0be1-4631-a9b0-04a84ae1dc54") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("a3095d58-bc65-4b73-98f0-f938f990557e") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("c334e415-32d3-4d8a-9890-2109aacedb9a") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("0c1d163a-c4f3-4f3a-b332-b31a7d450c56") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("5c2f0af9-4062-4a20-8c08-78694d421f4d") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("66a8770c-7c68-4e96-b821-da55102598e9") });

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("08266c95-0a6f-4bcc-a8d4-2fd6305d1e04"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("0891316c-66ae-414b-b4e1-f3a487c3dfa1"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("0996444a-1835-40e2-9c25-2cd6544c2054"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("0e0168f4-2073-45c5-bbb1-e45236ed9ea6"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("11916bb7-d803-4f9e-8129-c7d37b1e1169"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("14d115ec-cf3c-4ace-98e9-82547abd950f"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("1f27b159-f20a-4958-a1c4-021d2d5b8d62"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("28fdbb34-cd1f-4ac8-a04e-ee2e66c787b0"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("2d346421-c6f9-4641-b197-af718a046d6c"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("2def3639-84d1-4c25-ac38-207c734a4762"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("332c747d-f942-4370-808b-7c050696a9db"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("3555b073-eb5a-41d9-be24-bf67cc04e86a"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("3bbd75c1-516d-43c1-ad3b-34843d044d42"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("430886ca-10c4-477c-92fb-d57c1cc56e90"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("437af78f-5d2e-4dfe-9d4e-831154fe9587"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("43f297fb-d46e-4478-aa6d-5aae190765b8"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("59517b42-a706-4b75-89ff-4806a49da2c3"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("6365520b-034c-45b6-bfbd-669a892c64e6"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("64ca4b1b-94b4-487b-b196-6048c31efec9"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("6c34cccc-f313-4670-9118-b6fbbbc62ac7"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("6d8c95ba-bd68-48ae-927f-3336b9418f98"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("73f52e65-44bb-4c94-bc99-3aec8416c382"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("740c0e7f-c176-43fd-8b71-85e7535fe287"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("75aa2163-a82d-4c99-8036-a4903c547021"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("832a2501-853f-474a-af2a-199d2feef15d"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("92818018-653b-4d10-be50-d07cc73d350b"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("9905e288-6700-421b-a9e7-211cb2385a58"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("a6561831-8075-40b6-b35a-b74782f9e47c"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("af88f202-d981-4877-8fa5-61d8e3c37226"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("b06a8d46-4d50-428d-a21c-d5b6a46579bf"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("cb0b7a46-b570-453e-bd99-58b662f7754c"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("d8ce7f74-1481-4d63-97a1-08a697dfa986"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("daf8c602-f0cd-4b8e-b2b3-42771a743d96"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("db02d5d4-9e93-4c5b-ba74-cabb7063e1a1"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("ddb2e30f-73fe-49d3-b417-4fbdfa817dee"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("e101723b-83f3-4bb5-b4f7-db39af6c206d"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("eb541076-5000-4850-af0a-1ca3e4405179"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("eb5c72ff-054b-4fef-92e2-942c24772963"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("ee463f6e-14a2-4d41-accb-4b9d09bb32c6"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("f8a026bf-a239-4ba3-ade2-2bb64b681fda"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("02a3c59e-ba61-4e30-b209-944ccbf285d5"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("06c278de-4473-4c93-9f70-df520bc830a7"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("0c2bc25c-cdbc-4335-965e-f388d1598472"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("2233e705-760b-4d9b-b524-c787175f8759"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("33b64d67-f389-4a5b-9a56-315140599cc7"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("35420fd4-a385-42a1-9beb-40f97c2f122b"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("3e66e51c-9807-4936-b045-22ee478015ad"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("7a06ca6e-240e-49fc-887f-f1102224fc6e"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9667f004-f7c7-4080-b1ad-83cc98d7d31f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("991c0655-0666-494b-9845-110b902a263f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("c298d248-3c2b-4f9e-b5bd-aa229720b375"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("d7df1ff7-2428-49cc-8c22-6267f451f1cc"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("de74d92d-666d-4b5d-80a8-bf29df326bcc"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("ec6c6816-24f3-4ff7-ad8f-22ce736c0caf"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("edfc1a70-c91f-4cab-bc29-26c0f4dd6c8e"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("1cab6d78-2a80-41e0-8ea3-2e1db7ee6e48"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("4faf17ee-3feb-454e-ad6b-d7ff4369ddc3"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("7fa13c92-a4ee-4c68-9702-f439e380a050"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("84b047dd-251c-4652-9044-f5cb64bd1de9"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("87c9a3d2-ee5d-4374-bb80-67b31e9afdae"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("a28c4190-b0ad-445b-b967-05b943d9d536"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("c34361b9-88b6-418a-ac1f-63d94e63d647"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("c38b35b5-1e66-42d1-bd84-9a589d79a407"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("c4d26f9e-117b-4bb8-ae87-f6bec5f1a591"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("d6a9f624-8610-4668-8ace-8eb455bdc924"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("e7b09488-1a82-4f45-a4fc-a1d96ac736af"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("ed5e778e-1c26-43fb-be9c-595cc97d5ea6"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("0c1d163a-c4f3-4f3a-b332-b31a7d450c56"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("119bc69d-6943-4f3a-82aa-dad403bd1cfe"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("18c164c9-4a97-49e6-bf43-c1c4dde7c5e4"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("31805c88-e5d5-4206-95e9-77e3323ce315"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("3a735671-f0b5-454c-a686-bbcc1bf90caf"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("484a0ea6-1c6e-4ce6-9394-d31cee4be3c0"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("54591336-9dd6-4cd2-8ae8-d5aa61bfa0fb"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("547916f4-a0eb-478a-8d11-997adb500129"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("5c2f0af9-4062-4a20-8c08-78694d421f4d"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("5c9159e7-8856-45b9-9831-295ff470140f"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("66a8770c-7c68-4e96-b821-da55102598e9"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("8077572e-3e83-4e14-84ab-0082f43e308e"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("879d05e5-0be1-4631-a9b0-04a84ae1dc54"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("a2d4a97f-ee90-4167-9162-ef8aff3f34ac"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("a3095d58-bc65-4b73-98f0-f938f990557e"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("ad730fe6-d0ae-4dfb-a73f-d448aa062c37"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("b697fae5-e4b9-491a-97ec-c952dff212c0"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("c11c58a4-9919-4fb5-aad6-4e997e21b5e0"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("c18bac77-3759-40f8-84e6-148d172a4a78"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("c334e415-32d3-4d8a-9890-2109aacedb9a"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("cc23f918-3108-4b54-8f6a-e57565899a10"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("cef4c968-643e-45d5-a29d-77601f00a506"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("d340ce13-534b-491a-ae2b-bc70acf5bd8d"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("eb7353cc-da32-4af4-8300-f6e03380296e"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("10a4402f-d8c7-40f7-a144-a771f110ac29"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("2e6fccfa-4f1a-4caa-9c33-6245363ce29e"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("4c16cbe2-e625-4d6b-8c13-8201325a050a"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("5ecec201-29f5-4bd6-a393-e9cdd95772a0"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("62509994-6766-4407-a138-0b40a66fb27f"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("6349177a-7fb6-4dbf-97f0-7313f27c6589"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("6a8951a2-7160-43ad-8799-7b50a861731e"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("7ef0269d-4a15-49a7-b9ae-2d4518844493"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("91ae8af9-3497-4328-b7fa-b79764ecd7b9"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("b05f4e34-ee05-4330-9e4a-eba522945135"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("b407f75b-1ce1-4faa-9aac-477f4be49a3b"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("b97ba8b2-64ee-4c90-8572-e15aad8972f2"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("ddb077e2-34e8-4bdc-a6e8-643c30e913a4"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("3b97e544-cba5-450b-957f-a80ff4a72365"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("4610a55e-968f-40b1-85e5-01448b968819"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("9841de6b-7ed4-40a3-97f1-c82ac5466455"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("9e1e83cf-18a1-40eb-adac-49799e913d92"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("b3be7eef-3aba-4b0c-8bdd-f6974999c02c"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("03578da2-2afc-45ff-88c8-e2e8b2a467af"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("b1beb533-0148-4fb4-8583-7404245bf510"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("0bc34fa1-c605-4c83-b091-fa54ba8794c5"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("72ce5a0a-e60a-4bcf-b092-cb54124c8c75"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("92c94a40-8fb7-4a6a-939c-034dcab0c559"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("41373ff4-c015-4291-b2cf-8159db79a202"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("a64f3e23-e949-482b-9aff-ae583a47e248"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("547d8991-7e8d-4494-ae11-a52e16c49516"));

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "FieldVals",
                type: "character varying(512)",
                maxLength: 512,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "CellVals",
                type: "character varying(8000)",
                maxLength: 8000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "FieldVals",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(512)",
                oldMaxLength: 512,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "CellVals",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(8000)",
                oldMaxLength: 8000,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "ApplicationStatuses",
                columns: new[] { "Id", "Number", "Status" },
                values: new object[,]
                {
                    { new Guid("31b7f136-b6e9-4358-b3bd-1e8cd359acee"), 4, "Одобрена" },
                    { new Guid("69278ad8-3fca-47f9-9a96-e84751a662a3"), 5, "Отклонена" },
                    { new Guid("7036d9e1-98e3-47ae-8ede-a1b4ad297fa6"), 1, "В ожидании заполнения" },
                    { new Guid("90aa7566-91c3-43ee-9b4f-9adf5798a3b8"), 2, "В ожидании рассмотрения" },
                    { new Guid("a17750a1-c3e9-4524-8e20-d741348580a1"), 3, "В процессе рассмотрения" },
                    { new Guid("b302bffc-a0f9-4492-9ab6-681052f48063"), 6, "Оценена" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38bb985b-dec4-421a-b1f1-c04ae4741935", null, "Expert", "EXPERT" },
                    { "53b2d16b-1b99-4d9e-9e58-277bb3ab8b90", null, "Admin", "ADMIN" },
                    { "9f46b418-8d2f-4900-86b8-d0d39315a96f", null, "Voter", "VOTER" },
                    { "a2864396-d079-4ea5-979e-9e6064520825", null, "Organiser", "ORGANISER" },
                    { "b8929977-9b78-4c00-bee0-50fb55819d62", null, "Participant", "PARTICIPANT" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("4830978d-ceed-4a1e-a0f0-e96c5080ea98"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("f43eda36-1d98-4b6b-80c9-fd5b42d040f6"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), "Научно-исследовательская деятельность", 6 },
                    { new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), "Научно-педагогическая деятельность", 5 },
                    { new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"), "Категория участников", 2 },
                    { new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"), "Профессиональное развитие", 4 },
                    { new Guid("a64f3e23-e949-482b-9aff-ae583a47e248"), "Конкурсная работа", 3 },
                    { new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), "Общая информация", 1 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Checked", "Email", "Message", "Name" },
                values: new object[] { new Guid("1b1ff588-19c1-4b91-ba4b-63fbf593d5c6"), false, "system@system.ru", "Test Message for System", "SYSTEM" });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), "Образовательная деятельность", 2 },
                    { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), "Профессиональные показатели", 4 },
                    { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), "Конкурсная работа", 7 },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), "Методическая деятельность", 3 },
                    { new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5"), "Основной", 1 },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), "Инновационная и иная деятельность", 6 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0bc34fa1-c605-4c83-b091-fa54ba8794c5"), "bool" },
                    { new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026"), "int" },
                    { new Guid("547d8991-7e8d-4494-ae11-a52e16c49516"), "string" },
                    { new Guid("72ce5a0a-e60a-4bcf-b092-cb54124c8c75"), "TextArea" },
                    { new Guid("92c94a40-8fb7-4a6a-939c-034dcab0c559"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("a64f3e23-e949-482b-9aff-ae583a47e248"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("a64f3e23-e949-482b-9aff-ae583a47e248"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("1cab6d78-2a80-41e0-8ea3-2e1db7ee6e48"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("3b97e544-cba5-450b-957f-a80ff4a72365"), new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("4610a55e-968f-40b1-85e5-01448b968819"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("4faf17ee-3feb-454e-ad6b-d7ff4369ddc3"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("7fa13c92-a4ee-4c68-9702-f439e380a050"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("92c94a40-8fb7-4a6a-939c-034dcab0c559") },
                    { new Guid("84b047dd-251c-4652-9044-f5cb64bd1de9"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, true, true, "Место работы", 6, "Название организации", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("87c9a3d2-ee5d-4374-bb80-67b31e9afdae"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("9841de6b-7ed4-40a3-97f1-c82ac5466455"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("9e1e83cf-18a1-40eb-adac-49799e913d92"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("a28c4190-b0ad-445b-b967-05b943d9d536"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("b3be7eef-3aba-4b0c-8bdd-f6974999c02c"), new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("c34361b9-88b6-418a-ac1f-63d94e63d647"), new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("c38b35b5-1e66-42d1-bd84-9a589d79a407"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("c4d26f9e-117b-4bb8-ae87-f6bec5f1a591"), new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("d6a9f624-8610-4668-8ace-8eb455bdc924"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("e7b09488-1a82-4f45-a4fc-a1d96ac736af"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("ed5e778e-1c26-43fb-be9c-595cc97d5ea6"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("03578da2-2afc-45ff-88c8-e2e8b2a467af"), new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054"), new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d"), new Guid("a64f3e23-e949-482b-9aff-ae583a47e248"), true, true, "Краткая аннотация конкурсной работы", 1 },
                    { new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 },
                    { new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac"), new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), false, false, "Список научных публикаций за последние 5 лет", 10 },
                    { new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 },
                    { new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6"), new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("b1beb533-0148-4fb4-8583-7404245bf510"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 },
                    { new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540"), new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e"), new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4"), new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("02a3c59e-ba61-4e30-b209-944ccbf285d5"), true, "Наличие грифа", 5, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("0bc34fa1-c605-4c83-b091-fa54ba8794c5") },
                    { new Guid("039c9e1d-0966-4b3d-ae0d-0effc327c9d1"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("b1beb533-0148-4fb4-8583-7404245bf510"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("03aa1578-1f5c-46f2-9dc8-1e54a0c36828"), true, "Практические занятия (час.)", 4, new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("06c278de-4473-4c93-9f70-df520bc830a7"), true, "Соавторы", 2, new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("0c2bc25c-cdbc-4335-965e-f388d1598472"), true, "Статус", 4, new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("0e3c6a41-d9be-465e-8f1c-db0103f86295"), true, "Лекции (час.)", 3, new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), true, "Значение", 2, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d"), new Guid("72ce5a0a-e60a-4bcf-b092-cb54124c8c75") },
                    { new Guid("2233e705-760b-4d9b-b524-c787175f8759"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, "Название", 1, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("2db5422d-aa7d-4384-a3c7-89c71191ba70"), true, "Издание, год", 4, new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("2f48f06f-2c40-42cc-b82b-f2e8cf92393f"), true, "Ссылка на открытый доступ", 8, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("33b64d67-f389-4a5b-9a56-315140599cc7"), true, "Вид", 2, new Guid("b1beb533-0148-4fb4-8583-7404245bf510"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("35420fd4-a385-42a1-9beb-40f97c2f122b"), false, "Тип идентификатора", 1, new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("3771cf04-09f3-4b58-abd2-f006512d234d"), true, "Название конкурса", 2, new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("3dad72e7-3926-4364-b78f-505ed37b9245"), true, "Название", 2, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("3e66e51c-9807-4936-b045-22ee478015ad"), true, "Вид", 1, new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("430b55f5-cd48-460e-bf02-d2ad1e37205f"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("445ec93c-8e61-42c9-b7a0-8f18e76b00c1"), true, "Название дисциплины", 1, new Guid("b1beb533-0148-4fb4-8583-7404245bf510"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("44633c93-f4ea-4bf8-9e83-3782545d0553"), true, "Год", 4, new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("4466f7ad-6b86-4958-a3db-23618fe55530"), true, "Название", 2, new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("494d86fb-bada-45ab-9a1f-ae5013d01961"), true, "Итого (час.)", 5, new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("4c5cabc9-0c61-46e8-9724-583437de8bfc"), true, "Название курса", 1, new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("512fde20-307e-469e-b265-4f95375c0c1f"), true, "Название организации в которую внедрена разработка", 3, new Guid("03578da2-2afc-45ff-88c8-e2e8b2a467af"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("5e357a82-4986-407f-a18a-8cf61361932f"), true, "Название разработки", 2, new Guid("03578da2-2afc-45ff-88c8-e2e8b2a467af"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("686f349f-1c78-4f96-9339-788998b4f476"), true, "Ссылка на платформу", 3, new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("6cf36b5a-7e73-4b38-87e9-48879651a120"), true, "Ссылка", 5, new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("78241748-438d-4f86-a5a1-774d3922a3a5"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("7a06ca6e-240e-49fc-887f-f1102224fc6e"), true, "Вид публикации", 1, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("83c9a1f6-af24-47f6-83ce-4dc2af45600a"), true, "Название документа, реквизиты", 1, new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("96473636-564b-4eb8-89aa-73ae2bb19da1"), true, "Название статьи", 1, new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("9667f004-f7c7-4080-b1ad-83cc98d7d31f"), false, "Идентификатор", 2, new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("991c0655-0666-494b-9845-110b902a263f"), false, "Соавторы", 3, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("9e4a9a78-27ca-4f6f-a69d-868c35513c84"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("9e90dc00-6ab6-48c1-a973-eaa812a17771"), true, "ФИО соавторов", 3, new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("9fe89c8c-5250-4a53-93c3-f8c793dfbb60"), true, "Название конкурса/премии", 2, new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("a0108ea0-41ca-4d06-b69e-0d42e6df1543"), true, "Год", 1, new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("a12cdc8d-783e-43f5-a845-3793342fe4f1"), true, "Количество печатных листов", 4, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("a33f9c70-a883-4ab7-ae28-3256a581954b"), true, "Издательство, год", 6, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("aa6deed9-1744-46ae-ae6c-75150c98b331"), true, "Период выполнения", 3, new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("b12cae10-eabe-4685-92ca-9aa0ff464bdd"), true, "Год", 3, new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("b30f3b2b-7eef-47b4-9812-826aac2ef167"), true, "Год получения документа", 2, new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("b649879d-b81b-464b-9940-5aa5bcf0b268"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("b6c32f6e-79d6-4cf9-a8b6-7ea3d61455b1"), true, "ФИО", 1, new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("c298d248-3c2b-4f9e-b5bd-aa229720b375"), true, "Вид", 1, new Guid("03578da2-2afc-45ff-88c8-e2e8b2a467af"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("c7b39b02-e13a-4833-8618-7556f7957f03"), true, "Название НИР/НИОКР", 1, new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("cc15dcb4-5577-4377-b9fd-57134f0cc2c1"), true, "Наименование курса", 1, new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("d7df1ff7-2428-49cc-8c22-6267f451f1cc"), true, "Язык преподавания", 2, new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("de74d92d-666d-4b5d-80a8-bf29df326bcc"), true, "Соавторы", 2, new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("eba0c1fa-d397-495d-82f8-4f004e33b4ab"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("ec6c6816-24f3-4ff7-ad8f-22ce736c0caf"), true, "Статус конкурса", 3, new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("edfc1a70-c91f-4cab-bc29-26c0f4dd6c8e"), true, "Язык публикации", 7, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("f7cc557f-1d7a-42ec-8857-4b7539e8458b"), true, "Номер РИД", 4, new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("1cab6d78-2a80-41e0-8ea3-2e1db7ee6e48"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("3b97e544-cba5-450b-957f-a80ff4a72365"), new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283") },
                    { new Guid("4610a55e-968f-40b1-85e5-01448b968819"), new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0") },
                    { new Guid("4faf17ee-3feb-454e-ad6b-d7ff4369ddc3"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("7fa13c92-a4ee-4c68-9702-f439e380a050"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("84b047dd-251c-4652-9044-f5cb64bd1de9"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("87c9a3d2-ee5d-4374-bb80-67b31e9afdae"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("9841de6b-7ed4-40a3-97f1-c82ac5466455"), new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0") },
                    { new Guid("9e1e83cf-18a1-40eb-adac-49799e913d92"), new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0") },
                    { new Guid("a28c4190-b0ad-445b-b967-05b943d9d536"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("b3be7eef-3aba-4b0c-8bdd-f6974999c02c"), new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283") },
                    { new Guid("c34361b9-88b6-418a-ac1f-63d94e63d647"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("c38b35b5-1e66-42d1-bd84-9a589d79a407"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("c4d26f9e-117b-4bb8-ae87-f6bec5f1a591"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f") },
                    { new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283") },
                    { new Guid("d6a9f624-8610-4668-8ace-8eb455bdc924"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("e7b09488-1a82-4f45-a4fc-a1d96ac736af"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("ed5e778e-1c26-43fb-be9c-595cc97d5ea6"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510") },
                    { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540") },
                    { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4") },
                    { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("5b946941-2de7-41d0-80c0-956c98109d5b") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("b1beb533-0148-4fb4-8583-7404245bf510") },
                    { new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5"), new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4") },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("03578da2-2afc-45ff-88c8-e2e8b2a467af") },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6") },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0c1d163a-c4f3-4f3a-b332-b31a7d450c56"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540") },
                    { new Guid("119bc69d-6943-4f3a-82aa-dad403bd1cfe"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9") },
                    { new Guid("18c164c9-4a97-49e6-bf43-c1c4dde7c5e4"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("31805c88-e5d5-4206-95e9-77e3323ce315"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9") },
                    { new Guid("3a735671-f0b5-454c-a686-bbcc1bf90caf"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b") },
                    { new Guid("484a0ea6-1c6e-4ce6-9394-d31cee4be3c0"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054") },
                    { new Guid("54591336-9dd6-4cd2-8ae8-d5aa61bfa0fb"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510") },
                    { new Guid("547916f4-a0eb-478a-8d11-997adb500129"), "EvaluateMark19", new Guid("b3be7eef-3aba-4b0c-8bdd-f6974999c02c"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("5c2f0af9-4062-4a20-8c08-78694d421f4d"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("03578da2-2afc-45ff-88c8-e2e8b2a467af") },
                    { new Guid("5c9159e7-8856-45b9-9831-295ff470140f"), "EvaluateMark13", new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("66a8770c-7c68-4e96-b821-da55102598e9"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6") },
                    { new Guid("8077572e-3e83-4e14-84ab-0082f43e308e"), "EvaluateMark20", new Guid("3b97e544-cba5-450b-957f-a80ff4a72365"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("879d05e5-0be1-4631-a9b0-04a84ae1dc54"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4") },
                    { new Guid("a2d4a97f-ee90-4167-9162-ef8aff3f34ac"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("b1beb533-0148-4fb4-8583-7404245bf510") },
                    { new Guid("a3095d58-bc65-4b73-98f0-f938f990557e"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054") },
                    { new Guid("ad730fe6-d0ae-4dfb-a73f-d448aa062c37"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом или на иностранном языке в соавторстве:", 9, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b") },
                    { new Guid("b697fae5-e4b9-491a-97ec-c952dff212c0"), "EvaluateMark4", new Guid("9e1e83cf-18a1-40eb-adac-49799e913d92"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("c11c58a4-9919-4fb5-aad6-4e997e21b5e0"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("c18bac77-3759-40f8-84e6-148d172a4a78"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a") },
                    { new Guid("c334e415-32d3-4d8a-9890-2109aacedb9a"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac") },
                    { new Guid("cc23f918-3108-4b54-8f6a-e57565899a10"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом или на иностранном языке и без соавторства:", 8, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b") },
                    { new Guid("cef4c968-643e-45d5-a29d-77601f00a506"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b") },
                    { new Guid("d340ce13-534b-491a-ae2b-bc70acf5bd8d"), "EvaluateMark5", new Guid("9841de6b-7ed4-40a3-97f1-c82ac5466455"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("eb7353cc-da32-4af4-8300-f6e03380296e"), "EvaluateMark3", new Guid("4610a55e-968f-40b1-85e5-01448b968819"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("10a4402f-d8c7-40f7-a144-a771f110ac29"), true, 8, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("2e6fccfa-4f1a-4caa-9c33-6245363ce29e"), true, 1, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("4c16cbe2-e625-4d6b-8c13-8201325a050a"), true, 5, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("5ecec201-29f5-4bd6-a393-e9cdd95772a0"), true, 4, new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e") },
                    { new Guid("62509994-6766-4407-a138-0b40a66fb27f"), true, 3, new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e") },
                    { new Guid("6349177a-7fb6-4dbf-97f0-7313f27c6589"), true, 5, new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e") },
                    { new Guid("6a8951a2-7160-43ad-8799-7b50a861731e"), true, 4, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("7ef0269d-4a15-49a7-b9ae-2d4518844493"), true, 7, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("91ae8af9-3497-4328-b7fa-b79764ecd7b9"), true, 3, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("b05f4e34-ee05-4330-9e4a-eba522945135"), true, 2, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("b407f75b-1ce1-4faa-9aac-477f4be49a3b"), true, 6, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("b97ba8b2-64ee-4c90-8572-e15aad8972f2"), true, 2, new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e") },
                    { new Guid("ddb077e2-34e8-4bdc-a6e8-643c30e913a4"), true, 1, new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0891316c-66ae-414b-b4e1-f3a487c3dfa1"), null, new Guid("c4d26f9e-117b-4bb8-ae87-f6bec5f1a591"), "Кандидат наук" },
                    { new Guid("332c747d-f942-4370-808b-7c050696a9db"), null, new Guid("c4d26f9e-117b-4bb8-ae87-f6bec5f1a591"), "Доктор наук" },
                    { new Guid("430886ca-10c4-477c-92fb-d57c1cc56e90"), null, new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), "Доцент" },
                    { new Guid("59517b42-a706-4b75-89ff-4806a49da2c3"), null, new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), "Профессор" },
                    { new Guid("eb5c72ff-054b-4fef-92e2-942c24772963"), null, new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), "Нет" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("0176aeb5-4d1c-42a2-bfb7-197d7514ad36"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("b407f75b-1ce1-4faa-9aac-477f4be49a3b"), "Апробация" },
                    { new Guid("07216cd6-685d-4448-8dc4-bcb35eb4c57c"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("2e6fccfa-4f1a-4caa-9c33-6245363ce29e"), null },
                    { new Guid("0dd08024-cbeb-4147-b800-1d042386da4a"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("b407f75b-1ce1-4faa-9aac-477f4be49a3b"), null },
                    { new Guid("0e2e0f54-a00e-46ba-a05d-470d38670d8a"), null, new Guid("35420fd4-a385-42a1-9beb-40f97c2f122b"), true, true, new Guid("ddb077e2-34e8-4bdc-a6e8-643c30e913a4"), "ScopusID" },
                    { new Guid("19801b4e-ab6b-4324-9588-2b3663f0e560"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("91ae8af9-3497-4328-b7fa-b79764ecd7b9"), "Инновационность" },
                    { new Guid("2478c504-8204-4494-a47e-794ce0bdf742"), null, new Guid("9667f004-f7c7-4080-b1ad-83cc98d7d31f"), false, true, new Guid("6349177a-7fb6-4dbf-97f0-7313f27c6589"), null },
                    { new Guid("253e3ba0-b2ed-4927-8059-336414947acb"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("6a8951a2-7160-43ad-8799-7b50a861731e"), null },
                    { new Guid("32af5b34-9576-49cb-bf3d-8c552e04d7cf"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("6a8951a2-7160-43ad-8799-7b50a861731e"), "Методология и методы, используемые в работе" },
                    { new Guid("3adc02a3-dfec-4282-842a-94dbb4cd6b09"), null, new Guid("35420fd4-a385-42a1-9beb-40f97c2f122b"), true, true, new Guid("6349177a-7fb6-4dbf-97f0-7313f27c6589"), "Google Scholar ID" },
                    { new Guid("55001ba0-3bcf-4736-8986-72df37163487"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("7ef0269d-4a15-49a7-b9ae-2d4518844493"), null },
                    { new Guid("64e1fbe0-a821-42b1-b5dd-72e1762e8f4d"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("4c16cbe2-e625-4d6b-8c13-8201325a050a"), "Ссылка на конкурсную работу" },
                    { new Guid("66e53646-d39d-484c-a2ef-72dbf86df729"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("7ef0269d-4a15-49a7-b9ae-2d4518844493"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("7f60b3a3-ff50-4b60-8b71-906e12ead667"), null, new Guid("9667f004-f7c7-4080-b1ad-83cc98d7d31f"), false, true, new Guid("ddb077e2-34e8-4bdc-a6e8-643c30e913a4"), null },
                    { new Guid("85cc5213-6ddb-4142-a2ed-7557728e35e9"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("2e6fccfa-4f1a-4caa-9c33-6245363ce29e"), "Название работы" },
                    { new Guid("8748b7c5-c781-49ae-b4fc-35937e90bcc2"), null, new Guid("9667f004-f7c7-4080-b1ad-83cc98d7d31f"), false, true, new Guid("62509994-6766-4407-a138-0b40a66fb27f"), null },
                    { new Guid("8be7aba7-5bbc-4230-a7e2-bb191751bf57"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("b05f4e34-ee05-4330-9e4a-eba522945135"), "Актуальность конкурсной работы" },
                    { new Guid("93edd7cd-1aca-4163-8830-5689d0231d23"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("91ae8af9-3497-4328-b7fa-b79764ecd7b9"), null },
                    { new Guid("b93e16c2-1aef-466b-ade2-49a834f84cdb"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("4c16cbe2-e625-4d6b-8c13-8201325a050a"), null },
                    { new Guid("bca1a84a-836b-4f53-be6a-241f63dcef14"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("b05f4e34-ee05-4330-9e4a-eba522945135"), null },
                    { new Guid("bead9c52-6dfa-4e0a-aeb6-0c2b67bed25e"), null, new Guid("35420fd4-a385-42a1-9beb-40f97c2f122b"), true, true, new Guid("62509994-6766-4407-a138-0b40a66fb27f"), "ResearcherID" },
                    { new Guid("cb9a999d-d604-49ee-8661-8fb0ecddb96d"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("10a4402f-d8c7-40f7-a144-a771f110ac29"), "Результаты и выводы" },
                    { new Guid("cdadec0b-ea18-4a0b-91f3-c79fc36011e5"), null, new Guid("35420fd4-a385-42a1-9beb-40f97c2f122b"), true, true, new Guid("b97ba8b2-64ee-4c90-8572-e15aad8972f2"), "ORCiD" },
                    { new Guid("d4189538-8f1a-4718-8a80-3492a42d55e7"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("10a4402f-d8c7-40f7-a144-a771f110ac29"), null },
                    { new Guid("de72d846-01d1-4608-ade5-a9110b76a99b"), null, new Guid("9667f004-f7c7-4080-b1ad-83cc98d7d31f"), false, true, new Guid("b97ba8b2-64ee-4c90-8572-e15aad8972f2"), null },
                    { new Guid("ed10c5a5-ee9c-4d4f-9861-43b0f29acb92"), null, new Guid("9667f004-f7c7-4080-b1ad-83cc98d7d31f"), false, true, new Guid("5ecec201-29f5-4bd6-a393-e9cdd95772a0"), null },
                    { new Guid("ef82e49f-8ab5-4e38-856c-f8f7d99b1c09"), null, new Guid("35420fd4-a385-42a1-9beb-40f97c2f122b"), true, true, new Guid("5ecec201-29f5-4bd6-a393-e9cdd95772a0"), "РИНЦ AuthorID" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("119bc69d-6943-4f3a-82aa-dad403bd1cfe") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("31805c88-e5d5-4206-95e9-77e3323ce315") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("54591336-9dd6-4cd2-8ae8-d5aa61bfa0fb") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("b697fae5-e4b9-491a-97ec-c952dff212c0") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("c18bac77-3759-40f8-84e6-148d172a4a78") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("d340ce13-534b-491a-ae2b-bc70acf5bd8d") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("eb7353cc-da32-4af4-8300-f6e03380296e") },
                    { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("0c1d163a-c4f3-4f3a-b332-b31a7d450c56") },
                    { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("5c9159e7-8856-45b9-9831-295ff470140f") },
                    { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("879d05e5-0be1-4631-a9b0-04a84ae1dc54") },
                    { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("18c164c9-4a97-49e6-bf43-c1c4dde7c5e4") },
                    { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("c11c58a4-9919-4fb5-aad6-4e997e21b5e0") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("3a735671-f0b5-454c-a686-bbcc1bf90caf") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("a2d4a97f-ee90-4167-9162-ef8aff3f34ac") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("ad730fe6-d0ae-4dfb-a73f-d448aa062c37") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("cc23f918-3108-4b54-8f6a-e57565899a10") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("cef4c968-643e-45d5-a29d-77601f00a506") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("484a0ea6-1c6e-4ce6-9394-d31cee4be3c0") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("547916f4-a0eb-478a-8d11-997adb500129") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("5c9159e7-8856-45b9-9831-295ff470140f") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("8077572e-3e83-4e14-84ab-0082f43e308e") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("879d05e5-0be1-4631-a9b0-04a84ae1dc54") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("a3095d58-bc65-4b73-98f0-f938f990557e") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("c334e415-32d3-4d8a-9890-2109aacedb9a") },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("0c1d163a-c4f3-4f3a-b332-b31a7d450c56") },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("5c2f0af9-4062-4a20-8c08-78694d421f4d") },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("66a8770c-7c68-4e96-b821-da55102598e9") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("08266c95-0a6f-4bcc-a8d4-2fd6305d1e04"), new Guid("de74d92d-666d-4b5d-80a8-bf29df326bcc"), null, "Нет" },
                    { new Guid("0996444a-1835-40e2-9c25-2cd6544c2054"), new Guid("0c2bc25c-cdbc-4335-965e-f388d1598472"), null, "Исполнитель" },
                    { new Guid("0e0168f4-2073-45c5-bbb1-e45236ed9ea6"), new Guid("02a3c59e-ba61-4e30-b209-944ccbf285d5"), null, "Нет" },
                    { new Guid("11916bb7-d803-4f9e-8129-c7d37b1e1169"), new Guid("edfc1a70-c91f-4cab-bc29-26c0f4dd6c8e"), null, "Русский" },
                    { new Guid("14d115ec-cf3c-4ace-98e9-82547abd950f"), new Guid("3e66e51c-9807-4936-b045-22ee478015ad"), null, "Промышленный образец" },
                    { new Guid("1f27b159-f20a-4958-a1c4-021d2d5b8d62"), new Guid("d7df1ff7-2428-49cc-8c22-6267f451f1cc"), null, "Английский" },
                    { new Guid("28fdbb34-cd1f-4ac8-a04e-ee2e66c787b0"), new Guid("3e66e51c-9807-4936-b045-22ee478015ad"), null, "Изобретение" },
                    { new Guid("2d346421-c6f9-4641-b197-af718a046d6c"), new Guid("02a3c59e-ba61-4e30-b209-944ccbf285d5"), null, "Есть" },
                    { new Guid("2def3639-84d1-4c25-ac38-207c734a4762"), new Guid("7a06ca6e-240e-49fc-887f-f1102224fc6e"), null, "Учебник" },
                    { new Guid("3555b073-eb5a-41d9-be24-bf67cc04e86a"), new Guid("ec6c6816-24f3-4ff7-ad8f-22ce736c0caf"), null, "Всероссийский" },
                    { new Guid("3bbd75c1-516d-43c1-ad3b-34843d044d42"), new Guid("2233e705-760b-4d9b-b524-c787175f8759"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("437af78f-5d2e-4dfe-9d4e-831154fe9587"), new Guid("3e66e51c-9807-4936-b045-22ee478015ad"), null, "Полезная модель" },
                    { new Guid("43f297fb-d46e-4478-aa6d-5aae190765b8"), new Guid("0c2bc25c-cdbc-4335-965e-f388d1598472"), null, "Руководитель" },
                    { new Guid("6365520b-034c-45b6-bfbd-669a892c64e6"), new Guid("edfc1a70-c91f-4cab-bc29-26c0f4dd6c8e"), null, "Иностранный" },
                    { new Guid("64ca4b1b-94b4-487b-b196-6048c31efec9"), new Guid("de74d92d-666d-4b5d-80a8-bf29df326bcc"), null, "Есть" },
                    { new Guid("6c34cccc-f313-4670-9118-b6fbbbc62ac7"), new Guid("991c0655-0666-494b-9845-110b902a263f"), null, "Есть" },
                    { new Guid("6d8c95ba-bd68-48ae-927f-3336b9418f98"), new Guid("33b64d67-f389-4a5b-9a56-315140599cc7"), null, "Лабораторные" },
                    { new Guid("73f52e65-44bb-4c94-bc99-3aec8416c382"), new Guid("ec6c6816-24f3-4ff7-ad8f-22ce736c0caf"), null, "Региональный" },
                    { new Guid("740c0e7f-c176-43fd-8b71-85e7535fe287"), new Guid("d7df1ff7-2428-49cc-8c22-6267f451f1cc"), null, "Другой" },
                    { new Guid("75aa2163-a82d-4c99-8036-a4903c547021"), new Guid("2233e705-760b-4d9b-b524-c787175f8759"), null, "МБД (Q3-Q4)" },
                    { new Guid("832a2501-853f-474a-af2a-199d2feef15d"), new Guid("33b64d67-f389-4a5b-9a56-315140599cc7"), null, "Лекции" },
                    { new Guid("92818018-653b-4d10-be50-d07cc73d350b"), new Guid("3e66e51c-9807-4936-b045-22ee478015ad"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("9905e288-6700-421b-a9e7-211cb2385a58"), new Guid("991c0655-0666-494b-9845-110b902a263f"), null, "Нет" },
                    { new Guid("a6561831-8075-40b6-b35a-b74782f9e47c"), new Guid("2233e705-760b-4d9b-b524-c787175f8759"), null, "РИНЦ" },
                    { new Guid("af88f202-d981-4877-8fa5-61d8e3c37226"), new Guid("c298d248-3c2b-4f9e-b5bd-aa229720b375"), null, "Полезная модель" },
                    { new Guid("b06a8d46-4d50-428d-a21c-d5b6a46579bf"), new Guid("c298d248-3c2b-4f9e-b5bd-aa229720b375"), null, "Изобретение" },
                    { new Guid("cb0b7a46-b570-453e-bd99-58b662f7754c"), new Guid("c298d248-3c2b-4f9e-b5bd-aa229720b375"), null, "Промышленный образец" },
                    { new Guid("d8ce7f74-1481-4d63-97a1-08a697dfa986"), new Guid("c298d248-3c2b-4f9e-b5bd-aa229720b375"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("daf8c602-f0cd-4b8e-b2b3-42771a743d96"), new Guid("7a06ca6e-240e-49fc-887f-f1102224fc6e"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("db02d5d4-9e93-4c5b-ba74-cabb7063e1a1"), new Guid("2233e705-760b-4d9b-b524-c787175f8759"), null, "ВАК (К2-К3)" },
                    { new Guid("ddb2e30f-73fe-49d3-b417-4fbdfa817dee"), new Guid("ec6c6816-24f3-4ff7-ad8f-22ce736c0caf"), null, "Международный" },
                    { new Guid("e101723b-83f3-4bb5-b4f7-db39af6c206d"), new Guid("06c278de-4473-4c93-9f70-df520bc830a7"), null, "Нет" },
                    { new Guid("eb541076-5000-4850-af0a-1ca3e4405179"), new Guid("d7df1ff7-2428-49cc-8c22-6267f451f1cc"), null, "Русский" },
                    { new Guid("ee463f6e-14a2-4d41-accb-4b9d09bb32c6"), new Guid("06c278de-4473-4c93-9f70-df520bc830a7"), null, "Есть" },
                    { new Guid("f8a026bf-a239-4ba3-ade2-2bb64b681fda"), new Guid("7a06ca6e-240e-49fc-887f-f1102224fc6e"), null, "Монография" }
                });
        }
    }
}
