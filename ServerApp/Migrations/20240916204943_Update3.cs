using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerApp.Migrations
{
    /// <inheritdoc />
    public partial class Update3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "ApplicationStatuses",
                columns: new[] { "Id", "Number", "Status" },
                values: new object[,]
                {
                    { new Guid("0e8394fc-c8d0-4313-994a-ff9c178a3682"), 6, "Оценена" },
                    { new Guid("43b25816-f53e-4008-9fde-2f28f7964805"), 4, "Одобрена" },
                    { new Guid("4762b5b3-fa8f-4b93-8605-5285ff8f8f44"), 1, "В ожидании заполнения" },
                    { new Guid("8005a686-3ea3-4c9a-8288-785ee5c2fa3f"), 2, "В ожидании рассмотрения" },
                    { new Guid("87c18ce2-30f8-426d-abf5-624511d9d421"), 5, "Отклонена" },
                    { new Guid("f02cf7e0-c8e5-48cb-9a6a-86d89c91f457"), 3, "В процессе рассмотрения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2faa169d-a63f-43e2-ae18-3f1245189a3d", null, "Participant", "PARTICIPANT" },
                    { "80fe7082-65c0-4a6b-af89-acd9fc265729", null, "Organiser", "ORGANISER" },
                    { "84f6a664-6b5e-40b1-8e04-f64be9b4d307", null, "Expert", "EXPERT" },
                    { "899dc015-87cf-4557-8af5-79ed06de84ba", null, "Admin", "ADMIN" },
                    { "e5ec9139-b3af-4115-b585-3c375898e67d", null, "Voter", "VOTER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("118a0f8d-9439-40ff-bc51-349a6e527b9e"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("8617b191-af29-4ecb-a417-ffefd779cc1b"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("59fee98a-e4ff-4de6-abe3-64e3502ff433"), "Научно-педагогическая деятельность", 5 },
                    { new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), "Общая информация", 1 },
                    { new Guid("b80c9c2b-ed65-4544-80d2-6fa5491b7070"), "Научно-исследовательская деятельность", 6 },
                    { new Guid("c632289c-502e-41b3-a89d-16ac6f094746"), "Профессиональное развитие", 4 },
                    { new Guid("cc26592a-d57f-4e01-802c-0e9ab92c1498"), "Категория участников", 2 },
                    { new Guid("f6d9383d-495d-4af5-b7c5-0ba9936841a5"), "Конкурсная работа", 3 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8"), "Основной", 1 },
                    { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("404fe079-eff7-43cf-8180-08e9470a544d"), "Профессиональные показатели", 4 },
                    { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), "Методическая деятельность", 3 },
                    { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), "Образовательная деятельность", 2 },
                    { new Guid("be0683a1-aff4-4cfa-8103-9b30e140037c"), "Конкурсная работа", 7 },
                    { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), "Инновационная и иная деятельность", 6 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("018645a1-f2e2-47ab-a3cc-73d73095633d"), "DateTime" },
                    { new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387"), "int" },
                    { new Guid("59523d30-8aa9-47e2-9510-6214e86f771a"), "bool" },
                    { new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97"), "string" },
                    { new Guid("d4be5078-efbb-4351-be89-324d543a5cc9"), "TextArea" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("59fee98a-e4ff-4de6-abe3-64e3502ff433"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") },
                    { new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") },
                    { new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") },
                    { new Guid("b80c9c2b-ed65-4544-80d2-6fa5491b7070"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") },
                    { new Guid("c632289c-502e-41b3-a89d-16ac6f094746"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") },
                    { new Guid("c632289c-502e-41b3-a89d-16ac6f094746"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") },
                    { new Guid("cc26592a-d57f-4e01-802c-0e9ab92c1498"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") },
                    { new Guid("cc26592a-d57f-4e01-802c-0e9ab92c1498"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") },
                    { new Guid("f6d9383d-495d-4af5-b7c5-0ba9936841a5"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") },
                    { new Guid("f6d9383d-495d-4af5-b7c5-0ba9936841a5"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("03cfef95-8250-44c7-a3fd-a7ae47ae2ce8"), new Guid("cc26592a-d57f-4e01-802c-0e9ab92c1498"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("07612b69-c3e4-4123-89bb-1b33e65b5254"), new Guid("cc26592a-d57f-4e01-802c-0e9ab92c1498"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("1e35e8ed-7984-4286-9ba4-183af1ae62cb"), new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("1f40f0b0-aafa-48cf-81ad-3d9743f7c8a2"), new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("3397d22f-5dd0-434b-8d8e-68b72cf81ba2"), new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") },
                    { new Guid("635777ad-cb0d-4909-ab4f-eff0376fce2c"), new Guid("b80c9c2b-ed65-4544-80d2-6fa5491b7070"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") },
                    { new Guid("81777154-a657-45c6-8ef4-f9cff5a0c100"), new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("85a611bd-fdb6-4e58-bd14-d1247b3400ad"), new Guid("59fee98a-e4ff-4de6-abe3-64e3502ff433"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") },
                    { new Guid("8f7d38b6-a6cf-4c5d-8e03-b78cbb2aa81b"), new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") },
                    { new Guid("9237f975-ef99-44aa-8cc9-5fac68559582"), new Guid("59fee98a-e4ff-4de6-abe3-64e3502ff433"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") },
                    { new Guid("9c24e3af-6a30-494a-8827-e2c815c3f8f3"), new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("b020a3c6-99cd-4c29-b039-c8701db8f798"), new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("018645a1-f2e2-47ab-a3cc-73d73095633d") },
                    { new Guid("b517350a-b6f1-4bf8-8348-a2727c7f1eed"), new Guid("cc26592a-d57f-4e01-802c-0e9ab92c1498"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("d9e5dc4a-886c-46b2-bb27-2e249e4cae3b"), new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("da50a6f1-9db2-466c-b165-726ac3bbaa7b"), new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), null, true, true, "Место работы", 6, "Название организации", new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("ebfea5aa-f6df-4e8b-aa04-0efe9489afe9"), new Guid("b80c9c2b-ed65-4544-80d2-6fa5491b7070"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") },
                    { new Guid("f0ed3dd3-d357-41b1-8f5e-803b01a319b4"), new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("f6901305-74f8-4a5a-8ec1-095f9c53b7b9"), new Guid("59fee98a-e4ff-4de6-abe3-64e3502ff433"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") },
                    { new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") },
                    { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") },
                    { new Guid("404fe079-eff7-43cf-8180-08e9470a544d"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") },
                    { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") },
                    { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") },
                    { new Guid("be0683a1-aff4-4cfa-8103-9b30e140037c"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") },
                    { new Guid("be0683a1-aff4-4cfa-8103-9b30e140037c"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") },
                    { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("156d0440-7d96-4034-9362-467618fe4117"), new Guid("59fee98a-e4ff-4de6-abe3-64e3502ff433"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("43709cbd-e47e-48f7-9de0-6bba70d0bf39"), new Guid("b80c9c2b-ed65-4544-80d2-6fa5491b7070"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("57602c01-c785-478d-9551-9f4ff23f7ce2"), new Guid("59fee98a-e4ff-4de6-abe3-64e3502ff433"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 },
                    { new Guid("6e463686-4018-4b46-9c5a-00a44aff6e77"), new Guid("c632289c-502e-41b3-a89d-16ac6f094746"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("7175339e-ff5f-4a32-b8e1-b4776e99b78c"), new Guid("c632289c-502e-41b3-a89d-16ac6f094746"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 },
                    { new Guid("719e2dd1-a32c-49c6-9671-dc3ede841e58"), new Guid("59fee98a-e4ff-4de6-abe3-64e3502ff433"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("7f295636-cbb1-49b9-a543-55f3d9706553"), new Guid("b80c9c2b-ed65-4544-80d2-6fa5491b7070"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("8e8f8289-2433-4254-8c81-ac5b290576b7"), new Guid("b80c9c2b-ed65-4544-80d2-6fa5491b7070"), false, false, "Список научных публикаций за последние 5 лет", 10 },
                    { new Guid("c84da322-b588-4cef-bf78-937ab11c54e8"), new Guid("f6d9383d-495d-4af5-b7c5-0ba9936841a5"), true, true, "Краткая аннотация конкурсной работы", 1 },
                    { new Guid("d64a2008-a1b3-4eca-bfd3-1c039b74affb"), new Guid("c632289c-502e-41b3-a89d-16ac6f094746"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("d8b5152e-91fe-4cd3-9c49-56c9c8f9ab70"), new Guid("b80c9c2b-ed65-4544-80d2-6fa5491b7070"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f"), new Guid("59fee98a-e4ff-4de6-abe3-64e3502ff433"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 },
                    { new Guid("f3b2e492-8970-4e02-86d9-ad912cdfb670"), new Guid("59fee98a-e4ff-4de6-abe3-64e3502ff433"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0cd82ce3-fc88-4172-b0d6-d53800d00cc1"), true, "Количество печатных листов", 4, new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f"), new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") },
                    { new Guid("107b1b40-0bcb-4060-ae2e-aa28648287a0"), true, "Лекции (час.)", 3, new Guid("719e2dd1-a32c-49c6-9671-dc3ede841e58"), new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") },
                    { new Guid("11f67a00-10a1-41b4-bb54-dcad556ed56a"), true, "Ссылка", 5, new Guid("7175339e-ff5f-4a32-b8e1-b4776e99b78c"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("1435ab8c-e799-49b2-83ea-3e00e725134c"), true, "Наименование курса", 1, new Guid("719e2dd1-a32c-49c6-9671-dc3ede841e58"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("17b5b24c-3c89-465e-b293-cef4b33bd876"), true, "Ссылка на платформу", 3, new Guid("156d0440-7d96-4034-9362-467618fe4117"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("1aa002fc-490f-4a15-aa9f-1b39b054e37c"), false, "Тип идентификатора", 1, new Guid("d64a2008-a1b3-4eca-bfd3-1c039b74affb"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("229b29de-f54a-4d23-bdab-4732f3db339d"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("43709cbd-e47e-48f7-9de0-6bba70d0bf39"), new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") },
                    { new Guid("29172de1-16a0-4ee8-be15-dba03a2dcecc"), false, "Соавторы", 3, new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("2974068e-ec58-4a31-a834-ac27edf03165"), true, "Соавторы", 2, new Guid("156d0440-7d96-4034-9362-467618fe4117"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("3108c5f0-5108-4c61-a9af-f7f2e8ad9b06"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("8e8f8289-2433-4254-8c81-ac5b290576b7"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("31cae352-46e7-433d-b0c1-56c9c3f07980"), true, "Итого (час.)", 5, new Guid("719e2dd1-a32c-49c6-9671-dc3ede841e58"), new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") },
                    { new Guid("34f5e02a-b939-4e6c-95cd-d4a650c0860f"), true, "Ссылка на открытый доступ", 8, new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("359f255d-459b-406c-af5e-5a71278de1ad"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("57602c01-c785-478d-9551-9f4ff23f7ce2"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("373ca755-7be2-40d1-8355-c47340507294"), true, "Язык преподавания", 2, new Guid("719e2dd1-a32c-49c6-9671-dc3ede841e58"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("3b3be36b-a037-46cc-b633-bee655eb7bae"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("43709cbd-e47e-48f7-9de0-6bba70d0bf39"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("3d97f70d-e969-4ded-9172-dfdf1c4a2fd6"), true, "Соавторы", 2, new Guid("8e8f8289-2433-4254-8c81-ac5b290576b7"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("46385f21-7c4e-41fe-805f-19ea74eb6506"), true, "Вид", 1, new Guid("7f295636-cbb1-49b9-a543-55f3d9706553"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("49455b7d-6706-4954-9c58-90f8c00650bd"), true, "Название НИР/НИОКР", 1, new Guid("43709cbd-e47e-48f7-9de0-6bba70d0bf39"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("4e0c8317-5743-4801-bbda-e2942a53d373"), true, "Статус конкурса", 3, new Guid("7175339e-ff5f-4a32-b8e1-b4776e99b78c"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("5156e5db-d6d3-4a11-b11f-43f0e3052848"), true, "Номер РИД", 4, new Guid("d8b5152e-91fe-4cd3-9c49-56c9c8f9ab70"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("5e70b16b-7121-4d15-bb3e-380afa440701"), true, "Название организации в которую внедрена разработка", 3, new Guid("7f295636-cbb1-49b9-a543-55f3d9706553"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("6173f0ed-b2ac-4f8d-9c99-ba32b3c36198"), true, "Название конкурса/премии", 2, new Guid("f3b2e492-8970-4e02-86d9-ad912cdfb670"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("6197d128-ec4c-4490-b3df-44625a31880a"), true, "Издание, год", 4, new Guid("8e8f8289-2433-4254-8c81-ac5b290576b7"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("70c001e0-0159-45b0-a95b-5149ffa52643"), true, "Статус", 4, new Guid("43709cbd-e47e-48f7-9de0-6bba70d0bf39"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("74eaa7b8-e44c-4c4e-a97c-f767c511d53a"), true, "Период выполнения", 3, new Guid("43709cbd-e47e-48f7-9de0-6bba70d0bf39"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("86437198-7be7-45a4-b289-7239c16f7f10"), true, "ФИО соавторов", 3, new Guid("d8b5152e-91fe-4cd3-9c49-56c9c8f9ab70"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("87ea0625-b066-48e2-b134-89055825dfdf"), true, "Значение", 2, new Guid("c84da322-b588-4cef-bf78-937ab11c54e8"), new Guid("d4be5078-efbb-4351-be89-324d543a5cc9") },
                    { new Guid("8e0fe263-7e5a-452e-8cc1-59d649f0b6c0"), true, "Год", 1, new Guid("7175339e-ff5f-4a32-b8e1-b4776e99b78c"), new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") },
                    { new Guid("9080704f-b3ba-4dee-87f1-42f0dc083a11"), true, "ФИО", 1, new Guid("f3b2e492-8970-4e02-86d9-ad912cdfb670"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("9a7661e3-d22d-4075-80b9-586bdfa88d5b"), true, "Год", 3, new Guid("f3b2e492-8970-4e02-86d9-ad912cdfb670"), new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") },
                    { new Guid("9aa1bb3b-ecdc-4b22-a4d5-4cf8abafecea"), true, "Вид", 1, new Guid("d8b5152e-91fe-4cd3-9c49-56c9c8f9ab70"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("9fe2c85b-c24f-48af-9cc8-80e97420009a"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("7175339e-ff5f-4a32-b8e1-b4776e99b78c"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("ac6a6bbe-b084-462a-8c3d-39db2fa52bea"), true, "Название", 2, new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("adb0e996-0c5e-4f42-a7f1-e29fa9fc86b8"), true, "Название", 2, new Guid("d8b5152e-91fe-4cd3-9c49-56c9c8f9ab70"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("b15ccf80-a42a-424a-a38a-378be76c7fed"), true, "Название конкурса", 2, new Guid("7175339e-ff5f-4a32-b8e1-b4776e99b78c"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("b19f8163-1190-4991-a46a-0273132f35be"), true, "Название", 1, new Guid("c84da322-b588-4cef-bf78-937ab11c54e8"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("b2a25513-bd1b-48fc-8313-188d4f44db1f"), true, "Вид публикации", 1, new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("b5f46577-a20e-4e4d-a99f-f4368311ae69"), true, "Название курса", 1, new Guid("156d0440-7d96-4034-9362-467618fe4117"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("b704c0de-ec3e-4444-898a-e3f4ee1ce5b9"), true, "Издательство, год", 6, new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("b879510e-234f-46ac-870a-621ce979c785"), true, "Название разработки", 2, new Guid("7f295636-cbb1-49b9-a543-55f3d9706553"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("b8be5a76-fb82-45a2-92f3-9c46ea6f8af1"), true, "Язык публикации", 7, new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("bccb102e-2157-48bc-a73f-461422aaab8e"), true, "Название документа, реквизиты", 1, new Guid("6e463686-4018-4b46-9c5a-00a44aff6e77"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("d440cc2d-8700-40d8-bde4-95db7be8451e"), true, "Название статьи", 1, new Guid("8e8f8289-2433-4254-8c81-ac5b290576b7"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("d570fdef-b055-4c69-8f8b-6bd3ead967b9"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("f3b2e492-8970-4e02-86d9-ad912cdfb670"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("d6faee8f-e216-4a09-95b7-9bc81148c6ae"), true, "Название дисциплины", 1, new Guid("57602c01-c785-478d-9551-9f4ff23f7ce2"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("d91d23a2-fa9a-4140-b8ed-693b62fa6d8c"), false, "Идентификатор", 2, new Guid("d64a2008-a1b3-4eca-bfd3-1c039b74affb"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("e67b00db-3668-4d5b-8f75-b4a309fb3a7a"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("f3b2e492-8970-4e02-86d9-ad912cdfb670"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("edd6f599-0956-49f4-8975-c98b273271c8"), true, "Год получения документа", 2, new Guid("6e463686-4018-4b46-9c5a-00a44aff6e77"), new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") },
                    { new Guid("fb2e69e7-18b6-427a-8352-2e2897dc2f54"), true, "Вид", 2, new Guid("57602c01-c785-478d-9551-9f4ff23f7ce2"), new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97") },
                    { new Guid("fcaa5618-805e-4e63-90c1-0c430f1c2a56"), true, "Наличие грифа", 5, new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f"), new Guid("59523d30-8aa9-47e2-9510-6214e86f771a") },
                    { new Guid("fe600a8f-0539-4442-997c-136d2905b4fc"), true, "Год", 4, new Guid("156d0440-7d96-4034-9362-467618fe4117"), new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") },
                    { new Guid("ff1137c3-2303-4e9c-9e4c-bc8c14b93513"), true, "Практические занятия (час.)", 4, new Guid("719e2dd1-a32c-49c6-9671-dc3ede841e58"), new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("03cfef95-8250-44c7-a3fd-a7ae47ae2ce8"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") },
                    { new Guid("03cfef95-8250-44c7-a3fd-a7ae47ae2ce8"), new Guid("215b5631-b702-4fd5-8a6c-ec880892114b") },
                    { new Guid("03cfef95-8250-44c7-a3fd-a7ae47ae2ce8"), new Guid("404fe079-eff7-43cf-8180-08e9470a544d") },
                    { new Guid("07612b69-c3e4-4123-89bb-1b33e65b5254"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") },
                    { new Guid("1e35e8ed-7984-4286-9ba4-183af1ae62cb"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") },
                    { new Guid("1f40f0b0-aafa-48cf-81ad-3d9743f7c8a2"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") },
                    { new Guid("3397d22f-5dd0-434b-8d8e-68b72cf81ba2"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") },
                    { new Guid("635777ad-cb0d-4909-ab4f-eff0376fce2c"), new Guid("215b5631-b702-4fd5-8a6c-ec880892114b") },
                    { new Guid("81777154-a657-45c6-8ef4-f9cff5a0c100"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") },
                    { new Guid("85a611bd-fdb6-4e58-bd14-d1247b3400ad"), new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4") },
                    { new Guid("8f7d38b6-a6cf-4c5d-8e03-b78cbb2aa81b"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") },
                    { new Guid("9237f975-ef99-44aa-8cc9-5fac68559582"), new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4") },
                    { new Guid("9c24e3af-6a30-494a-8827-e2c815c3f8f3"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") },
                    { new Guid("b020a3c6-99cd-4c29-b039-c8701db8f798"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") },
                    { new Guid("b517350a-b6f1-4bf8-8348-a2727c7f1eed"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") },
                    { new Guid("d9e5dc4a-886c-46b2-bb27-2e249e4cae3b"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") },
                    { new Guid("da50a6f1-9db2-466c-b165-726ac3bbaa7b"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") },
                    { new Guid("ebfea5aa-f6df-4e8b-aa04-0efe9489afe9"), new Guid("215b5631-b702-4fd5-8a6c-ec880892114b") },
                    { new Guid("f0ed3dd3-d357-41b1-8f5e-803b01a319b4"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") },
                    { new Guid("f6901305-74f8-4a5a-8ec1-095f9c53b7b9"), new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8"), new Guid("d64a2008-a1b3-4eca-bfd3-1c039b74affb") },
                    { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("43709cbd-e47e-48f7-9de0-6bba70d0bf39") },
                    { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("7175339e-ff5f-4a32-b8e1-b4776e99b78c") },
                    { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("8e8f8289-2433-4254-8c81-ac5b290576b7") },
                    { new Guid("404fe079-eff7-43cf-8180-08e9470a544d"), new Guid("6e463686-4018-4b46-9c5a-00a44aff6e77") },
                    { new Guid("404fe079-eff7-43cf-8180-08e9470a544d"), new Guid("7175339e-ff5f-4a32-b8e1-b4776e99b78c") },
                    { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("57602c01-c785-478d-9551-9f4ff23f7ce2") },
                    { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f") },
                    { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("156d0440-7d96-4034-9362-467618fe4117") },
                    { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("719e2dd1-a32c-49c6-9671-dc3ede841e58") },
                    { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("f3b2e492-8970-4e02-86d9-ad912cdfb670") },
                    { new Guid("be0683a1-aff4-4cfa-8103-9b30e140037c"), new Guid("c84da322-b588-4cef-bf78-937ab11c54e8") },
                    { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), new Guid("6e463686-4018-4b46-9c5a-00a44aff6e77") },
                    { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), new Guid("7f295636-cbb1-49b9-a543-55f3d9706553") },
                    { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), new Guid("d8b5152e-91fe-4cd3-9c49-56c9c8f9ab70") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("03f8845e-041f-4205-9faf-2e7e617a6c01"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("43709cbd-e47e-48f7-9de0-6bba70d0bf39") },
                    { new Guid("14e504d2-383d-4e31-9d66-be95617c035b"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("c84da322-b588-4cef-bf78-937ab11c54e8") },
                    { new Guid("277c2d2b-5519-438d-aa7a-98378a52a586"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("6e463686-4018-4b46-9c5a-00a44aff6e77") },
                    { new Guid("44a31f4f-4f7d-4991-8a9f-7a735a52f41a"), "EvaluateMark4", new Guid("f6901305-74f8-4a5a-8ec1-095f9c53b7b9"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("49811271-b92c-411b-b45d-a569ab8d86c2"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом или на иностранном языке и без соавторства:", 8, new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f") },
                    { new Guid("502ecdfd-71ea-4ed7-a0b2-0fce971271c5"), "EvaluateMark20", new Guid("635777ad-cb0d-4909-ab4f-eff0376fce2c"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("5a84a546-4d2d-4bb8-b850-0df69d4db191"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("7f295636-cbb1-49b9-a543-55f3d9706553") },
                    { new Guid("66727a22-584b-4530-a6f6-0e8733bf3d25"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("d8b5152e-91fe-4cd3-9c49-56c9c8f9ab70") },
                    { new Guid("66b84870-7dd2-4055-858a-29ad778165c8"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("719e2dd1-a32c-49c6-9671-dc3ede841e58") },
                    { new Guid("675c79d0-a2f0-4d68-9bf9-5b383c326ad3"), "EvaluateMark5", new Guid("85a611bd-fdb6-4e58-bd14-d1247b3400ad"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("692eb0fe-834c-47e4-91c6-98a1ad44f345"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("43709cbd-e47e-48f7-9de0-6bba70d0bf39") },
                    { new Guid("7e9d8eb3-5a0e-4245-ad29-1dd4f0a5c6ff"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("7175339e-ff5f-4a32-b8e1-b4776e99b78c") },
                    { new Guid("864ec7d2-bd8c-474d-bc78-80d42b1f219a"), "EvaluateMark3", new Guid("9237f975-ef99-44aa-8cc9-5fac68559582"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("96eb5c6d-41f1-4bd9-88f8-05bf2c894b65"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("57602c01-c785-478d-9551-9f4ff23f7ce2") },
                    { new Guid("ac8fa087-8793-4dee-915c-1c2eb1f3b56b"), "EvaluateMark13", new Guid("03cfef95-8250-44c7-a3fd-a7ae47ae2ce8"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("b65b3465-29e6-4c5f-b1d9-8660e22f3f25"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f") },
                    { new Guid("bf22f156-46fd-446e-84ff-10a8b9635275"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("719e2dd1-a32c-49c6-9671-dc3ede841e58") },
                    { new Guid("bf3da495-3916-4eb9-ab4c-a11ca5d66b52"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("f3b2e492-8970-4e02-86d9-ad912cdfb670") },
                    { new Guid("c34daf77-dcde-446b-90ef-02bf4a8c0244"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f") },
                    { new Guid("c6e86fc3-32a2-44ae-8455-e58dff8cde8b"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом или на иностранном языке в соавторстве:", 9, new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f") },
                    { new Guid("da288433-e821-41b8-9e6e-90d4d00e0923"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("156d0440-7d96-4034-9362-467618fe4117") },
                    { new Guid("e0ca1761-78bd-4516-8efd-c4c3d029a5ca"), "EvaluateMark19", new Guid("ebfea5aa-f6df-4e8b-aa04-0efe9489afe9"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("eb23c5b3-8729-41cf-a3e0-49bbc9481e1a"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("c84da322-b588-4cef-bf78-937ab11c54e8") },
                    { new Guid("eb80ed87-4db6-48a2-acc1-af68f769a186"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("8e8f8289-2433-4254-8c81-ac5b290576b7") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("06781231-8acf-4e5f-add4-559b4a521951"), true, 1, new Guid("d64a2008-a1b3-4eca-bfd3-1c039b74affb") },
                    { new Guid("152da749-fa45-4888-a20b-7c721c0c2fdb"), true, 2, new Guid("d64a2008-a1b3-4eca-bfd3-1c039b74affb") },
                    { new Guid("3dd436b3-eb8a-4ad7-8924-02bf457f2999"), true, 3, new Guid("d64a2008-a1b3-4eca-bfd3-1c039b74affb") },
                    { new Guid("47791747-f23d-43bc-a753-80eac93e138c"), true, 5, new Guid("d64a2008-a1b3-4eca-bfd3-1c039b74affb") },
                    { new Guid("57feb7ed-98b6-4f37-a0bb-b1c4026bd200"), true, 8, new Guid("c84da322-b588-4cef-bf78-937ab11c54e8") },
                    { new Guid("5f4f3636-3280-4603-a39a-670cb7d3422b"), true, 6, new Guid("c84da322-b588-4cef-bf78-937ab11c54e8") },
                    { new Guid("6e4f6320-3880-4024-8a08-86104d869d50"), true, 3, new Guid("c84da322-b588-4cef-bf78-937ab11c54e8") },
                    { new Guid("713cb0c8-0b70-4d8e-92f4-d390ab557b0a"), true, 7, new Guid("c84da322-b588-4cef-bf78-937ab11c54e8") },
                    { new Guid("8229d870-8db2-4cdf-b6bd-0428e2681c81"), true, 5, new Guid("c84da322-b588-4cef-bf78-937ab11c54e8") },
                    { new Guid("99af3d55-d531-4457-b48f-3a61f0e5029a"), true, 2, new Guid("c84da322-b588-4cef-bf78-937ab11c54e8") },
                    { new Guid("ccc85dbe-b258-4d72-958f-10b26b2facb4"), true, 4, new Guid("d64a2008-a1b3-4eca-bfd3-1c039b74affb") },
                    { new Guid("d0f5f666-6149-4a37-900e-9f3a6e0fac2b"), true, 4, new Guid("c84da322-b588-4cef-bf78-937ab11c54e8") },
                    { new Guid("f86ceda9-d679-49c1-b454-5cc1429c0de0"), true, 1, new Guid("c84da322-b588-4cef-bf78-937ab11c54e8") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("124ed4bb-412e-4402-a01f-e197502967b6"), null, new Guid("03cfef95-8250-44c7-a3fd-a7ae47ae2ce8"), "Нет" },
                    { new Guid("3ccde546-06ef-4821-b451-9a00e5cce30e"), null, new Guid("b517350a-b6f1-4bf8-8348-a2727c7f1eed"), "Кандидат наук" },
                    { new Guid("57250608-59e3-4b3a-8704-aebfa2b12e79"), null, new Guid("03cfef95-8250-44c7-a3fd-a7ae47ae2ce8"), "Доцент" },
                    { new Guid("c5bd3f0f-134f-4027-924e-8b90f7e17d09"), null, new Guid("03cfef95-8250-44c7-a3fd-a7ae47ae2ce8"), "Профессор" },
                    { new Guid("fd9094e0-8a31-478f-bcae-04b1a15a6584"), null, new Guid("b517350a-b6f1-4bf8-8348-a2727c7f1eed"), "Доктор наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("01dd20b5-a610-412c-bf1f-3309e0a4b529"), null, new Guid("1aa002fc-490f-4a15-aa9f-1b39b054e37c"), true, true, new Guid("47791747-f23d-43bc-a753-80eac93e138c"), "Google Scholar ID" },
                    { new Guid("07ef818a-9feb-4d39-bf05-a027c688c03b"), null, new Guid("87ea0625-b066-48e2-b134-89055825dfdf"), false, true, new Guid("6e4f6320-3880-4024-8a08-86104d869d50"), null },
                    { new Guid("0f0511de-f0a9-4484-ba53-5f8e30f921ee"), null, new Guid("d91d23a2-fa9a-4140-b8ed-693b62fa6d8c"), false, true, new Guid("06781231-8acf-4e5f-add4-559b4a521951"), null },
                    { new Guid("0fd862f7-9e6a-4899-8501-d17b15a93f66"), null, new Guid("87ea0625-b066-48e2-b134-89055825dfdf"), false, true, new Guid("8229d870-8db2-4cdf-b6bd-0428e2681c81"), null },
                    { new Guid("1057e35f-436b-4910-985e-24a26c0d7fb7"), null, new Guid("d91d23a2-fa9a-4140-b8ed-693b62fa6d8c"), false, true, new Guid("152da749-fa45-4888-a20b-7c721c0c2fdb"), null },
                    { new Guid("18e78d01-a09e-4952-a91e-8ca75ca58e66"), null, new Guid("87ea0625-b066-48e2-b134-89055825dfdf"), false, true, new Guid("713cb0c8-0b70-4d8e-92f4-d390ab557b0a"), null },
                    { new Guid("18f1cd8e-634f-40f8-9c8d-a0604ebda7ff"), null, new Guid("d91d23a2-fa9a-4140-b8ed-693b62fa6d8c"), false, true, new Guid("47791747-f23d-43bc-a753-80eac93e138c"), null },
                    { new Guid("280717fa-3715-4592-91b6-03b395e5d7df"), null, new Guid("b19f8163-1190-4991-a46a-0273132f35be"), true, true, new Guid("6e4f6320-3880-4024-8a08-86104d869d50"), "Инновационность" },
                    { new Guid("2e39eb33-7426-4f74-a919-0671b2af72ca"), null, new Guid("b19f8163-1190-4991-a46a-0273132f35be"), true, true, new Guid("57feb7ed-98b6-4f37-a0bb-b1c4026bd200"), "Результаты и выводы" },
                    { new Guid("32e498d8-b57b-468e-b85d-8a968b5794e5"), null, new Guid("d91d23a2-fa9a-4140-b8ed-693b62fa6d8c"), false, true, new Guid("3dd436b3-eb8a-4ad7-8924-02bf457f2999"), null },
                    { new Guid("3c00f730-ff9a-4d9d-8337-7126bf75f335"), null, new Guid("87ea0625-b066-48e2-b134-89055825dfdf"), false, true, new Guid("f86ceda9-d679-49c1-b454-5cc1429c0de0"), null },
                    { new Guid("42bbe453-9dda-454b-ac81-196125b6f2e3"), null, new Guid("d91d23a2-fa9a-4140-b8ed-693b62fa6d8c"), false, true, new Guid("ccc85dbe-b258-4d72-958f-10b26b2facb4"), null },
                    { new Guid("48701d44-e840-403e-b656-2b67f27e1d65"), null, new Guid("b19f8163-1190-4991-a46a-0273132f35be"), true, true, new Guid("d0f5f666-6149-4a37-900e-9f3a6e0fac2b"), "Методология и методы, используемые в работе" },
                    { new Guid("4f612b9e-1054-430e-bc77-d14eae457ebd"), null, new Guid("1aa002fc-490f-4a15-aa9f-1b39b054e37c"), true, true, new Guid("ccc85dbe-b258-4d72-958f-10b26b2facb4"), "РИНЦ AuthorID" },
                    { new Guid("5aae0e44-c386-4424-b10c-1287c63a70e3"), null, new Guid("87ea0625-b066-48e2-b134-89055825dfdf"), false, true, new Guid("99af3d55-d531-4457-b48f-3a61f0e5029a"), null },
                    { new Guid("9ba1feb6-bd54-45da-ba94-ed49cecb71ec"), null, new Guid("87ea0625-b066-48e2-b134-89055825dfdf"), false, true, new Guid("5f4f3636-3280-4603-a39a-670cb7d3422b"), null },
                    { new Guid("a5beacf2-2b93-4af9-84bb-85b7c9aac017"), null, new Guid("1aa002fc-490f-4a15-aa9f-1b39b054e37c"), true, true, new Guid("152da749-fa45-4888-a20b-7c721c0c2fdb"), "ORCiD" },
                    { new Guid("ae7ba25b-0f17-4228-b5a0-6b52f5b9f302"), null, new Guid("b19f8163-1190-4991-a46a-0273132f35be"), true, true, new Guid("f86ceda9-d679-49c1-b454-5cc1429c0de0"), "Название работы" },
                    { new Guid("b329a76e-3b62-4cd4-a9bd-f37d95d5f606"), null, new Guid("1aa002fc-490f-4a15-aa9f-1b39b054e37c"), true, true, new Guid("06781231-8acf-4e5f-add4-559b4a521951"), "ScopusID" },
                    { new Guid("b36ab3a3-060c-4eb9-86a1-7f3baa439082"), null, new Guid("b19f8163-1190-4991-a46a-0273132f35be"), true, true, new Guid("5f4f3636-3280-4603-a39a-670cb7d3422b"), "Апробация" },
                    { new Guid("c573e7ed-fc23-44b1-83d7-1d302a3c0cd8"), null, new Guid("b19f8163-1190-4991-a46a-0273132f35be"), true, true, new Guid("99af3d55-d531-4457-b48f-3a61f0e5029a"), "Актуальность конкурсной работы" },
                    { new Guid("daa50a52-bf89-4390-aa49-b3f48a85fbf0"), null, new Guid("b19f8163-1190-4991-a46a-0273132f35be"), true, true, new Guid("713cb0c8-0b70-4d8e-92f4-d390ab557b0a"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("dc09f0a6-9bf2-4163-861d-3dedb3a5e784"), null, new Guid("87ea0625-b066-48e2-b134-89055825dfdf"), false, true, new Guid("57feb7ed-98b6-4f37-a0bb-b1c4026bd200"), null },
                    { new Guid("e7e844b9-5e93-4d2e-9ef9-b688d52d1ebe"), null, new Guid("87ea0625-b066-48e2-b134-89055825dfdf"), false, true, new Guid("d0f5f666-6149-4a37-900e-9f3a6e0fac2b"), null },
                    { new Guid("e8f23608-ffc5-4ef0-8b5f-8c9f5b61e11f"), null, new Guid("b19f8163-1190-4991-a46a-0273132f35be"), true, true, new Guid("8229d870-8db2-4cdf-b6bd-0428e2681c81"), "Ссылка на конкурсную работу" },
                    { new Guid("f8d483da-bdf0-4a1c-a01d-67020feafd5f"), null, new Guid("1aa002fc-490f-4a15-aa9f-1b39b054e37c"), true, true, new Guid("3dd436b3-eb8a-4ad7-8924-02bf457f2999"), "ResearcherID" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("03f8845e-041f-4205-9faf-2e7e617a6c01") },
                    { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("502ecdfd-71ea-4ed7-a0b2-0fce971271c5") },
                    { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("692eb0fe-834c-47e4-91c6-98a1ad44f345") },
                    { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("7e9d8eb3-5a0e-4245-ad29-1dd4f0a5c6ff") },
                    { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("ac8fa087-8793-4dee-915c-1c2eb1f3b56b") },
                    { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("e0ca1761-78bd-4516-8efd-c4c3d029a5ca") },
                    { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("eb80ed87-4db6-48a2-acc1-af68f769a186") },
                    { new Guid("404fe079-eff7-43cf-8180-08e9470a544d"), new Guid("277c2d2b-5519-438d-aa7a-98378a52a586") },
                    { new Guid("404fe079-eff7-43cf-8180-08e9470a544d"), new Guid("7e9d8eb3-5a0e-4245-ad29-1dd4f0a5c6ff") },
                    { new Guid("404fe079-eff7-43cf-8180-08e9470a544d"), new Guid("ac8fa087-8793-4dee-915c-1c2eb1f3b56b") },
                    { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("49811271-b92c-411b-b45d-a569ab8d86c2") },
                    { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("96eb5c6d-41f1-4bd9-88f8-05bf2c894b65") },
                    { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("b65b3465-29e6-4c5f-b1d9-8660e22f3f25") },
                    { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("c34daf77-dcde-446b-90ef-02bf4a8c0244") },
                    { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("c6e86fc3-32a2-44ae-8455-e58dff8cde8b") },
                    { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("44a31f4f-4f7d-4991-8a9f-7a735a52f41a") },
                    { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("66b84870-7dd2-4055-858a-29ad778165c8") },
                    { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("675c79d0-a2f0-4d68-9bf9-5b383c326ad3") },
                    { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("864ec7d2-bd8c-474d-bc78-80d42b1f219a") },
                    { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("bf22f156-46fd-446e-84ff-10a8b9635275") },
                    { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("bf3da495-3916-4eb9-ab4c-a11ca5d66b52") },
                    { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("da288433-e821-41b8-9e6e-90d4d00e0923") },
                    { new Guid("be0683a1-aff4-4cfa-8103-9b30e140037c"), new Guid("14e504d2-383d-4e31-9d66-be95617c035b") },
                    { new Guid("be0683a1-aff4-4cfa-8103-9b30e140037c"), new Guid("eb23c5b3-8729-41cf-a3e0-49bbc9481e1a") },
                    { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), new Guid("277c2d2b-5519-438d-aa7a-98378a52a586") },
                    { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), new Guid("5a84a546-4d2d-4bb8-b850-0df69d4db191") },
                    { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), new Guid("66727a22-584b-4530-a6f6-0e8733bf3d25") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("04998dbe-a12b-44c3-b432-23651e8bb8c4"), new Guid("b8be5a76-fb82-45a2-92f3-9c46ea6f8af1"), null, "Иностранный" },
                    { new Guid("0bc203c1-244e-4857-aace-92960f55d63d"), new Guid("373ca755-7be2-40d1-8355-c47340507294"), null, "Другой" },
                    { new Guid("1d265ab5-bf94-4d00-97e4-62199843f11a"), new Guid("3d97f70d-e969-4ded-9172-dfdf1c4a2fd6"), null, "Есть" },
                    { new Guid("1db4b221-6084-4553-8f56-51ea06b27266"), new Guid("fb2e69e7-18b6-427a-8352-2e2897dc2f54"), null, "Лекции" },
                    { new Guid("2a8ed0a2-150a-4f10-8edc-6800e61f890d"), new Guid("b2a25513-bd1b-48fc-8313-188d4f44db1f"), null, "Учебник" },
                    { new Guid("2a9eee34-b3fd-4f0f-942a-c5a471db35fa"), new Guid("b8be5a76-fb82-45a2-92f3-9c46ea6f8af1"), null, "Русский" },
                    { new Guid("343cd908-fbf2-4402-9c02-2f034fff42f0"), new Guid("b2a25513-bd1b-48fc-8313-188d4f44db1f"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("347018e9-f279-408c-bf81-ade526ac71cb"), new Guid("70c001e0-0159-45b0-a95b-5149ffa52643"), null, "Руководитель" },
                    { new Guid("46d23948-862c-4cda-8544-9aebca5091f1"), new Guid("4e0c8317-5743-4801-bbda-e2942a53d373"), null, "Региональный" },
                    { new Guid("4d16d748-82ee-4e19-a2c2-4a64420fcd9c"), new Guid("46385f21-7c4e-41fe-805f-19ea74eb6506"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("52bfa1ff-b6a8-412e-bb5f-932522e911fd"), new Guid("373ca755-7be2-40d1-8355-c47340507294"), null, "Русский" },
                    { new Guid("606b3153-81e2-463c-be5b-a10caa4ef80a"), new Guid("373ca755-7be2-40d1-8355-c47340507294"), null, "Английский" },
                    { new Guid("640c28c0-fb63-4acd-9fd3-2732d21bdf6b"), new Guid("fcaa5618-805e-4e63-90c1-0c430f1c2a56"), null, "Нет" },
                    { new Guid("6acdb566-8d10-45b4-bfa5-32dd0f232f38"), new Guid("2974068e-ec58-4a31-a834-ac27edf03165"), null, "Есть" },
                    { new Guid("6eeaaeb7-5e40-473d-8f37-1da88447d750"), new Guid("9aa1bb3b-ecdc-4b22-a4d5-4cf8abafecea"), null, "Промышленный образец" },
                    { new Guid("767a5a62-4c69-46c7-9f14-14797b2f1eeb"), new Guid("46385f21-7c4e-41fe-805f-19ea74eb6506"), null, "Полезная модель" },
                    { new Guid("769390f2-457e-46b6-92fc-18f25ba7924a"), new Guid("46385f21-7c4e-41fe-805f-19ea74eb6506"), null, "Промышленный образец" },
                    { new Guid("84ba0d9b-5e83-4d23-b594-3c0f968b0b23"), new Guid("9aa1bb3b-ecdc-4b22-a4d5-4cf8abafecea"), null, "Изобретение" },
                    { new Guid("9194c67c-f90e-46d6-ae9b-193d1444668d"), new Guid("fb2e69e7-18b6-427a-8352-2e2897dc2f54"), null, "Лабораторные" },
                    { new Guid("921d50bd-3bf5-49b3-bed2-b42f8d020358"), new Guid("4e0c8317-5743-4801-bbda-e2942a53d373"), null, "Международный" },
                    { new Guid("99621d44-a6eb-439e-ab5f-1b8a19c58c5a"), new Guid("fcaa5618-805e-4e63-90c1-0c430f1c2a56"), null, "Есть" },
                    { new Guid("9af3fc0e-0516-4af8-b73a-64cfaf53bf1a"), new Guid("29172de1-16a0-4ee8-be15-dba03a2dcecc"), null, "Есть" },
                    { new Guid("9fa06e99-f29c-4175-9683-f804d022b042"), new Guid("70c001e0-0159-45b0-a95b-5149ffa52643"), null, "Исполнитель" },
                    { new Guid("aa33c2a8-d3ca-4686-865b-9163b8c5eeea"), new Guid("9aa1bb3b-ecdc-4b22-a4d5-4cf8abafecea"), null, "Полезная модель" },
                    { new Guid("acf88de0-0fa0-42d6-8d9f-cae3db88c958"), new Guid("3108c5f0-5108-4c61-a9af-f7f2e8ad9b06"), null, "МБД (Q3-Q4)" },
                    { new Guid("b15448cc-59a9-401a-b71f-00daf8c836f2"), new Guid("2974068e-ec58-4a31-a834-ac27edf03165"), null, "Нет" },
                    { new Guid("c2eef0df-88bd-4f9b-b167-e43eeef5b27d"), new Guid("3108c5f0-5108-4c61-a9af-f7f2e8ad9b06"), null, "РИНЦ" },
                    { new Guid("cecec929-4908-46d5-9f52-b243e53c1679"), new Guid("29172de1-16a0-4ee8-be15-dba03a2dcecc"), null, "Нет" },
                    { new Guid("cf2bdfa2-fb3a-427e-8449-77f504125985"), new Guid("b2a25513-bd1b-48fc-8313-188d4f44db1f"), null, "Монография" },
                    { new Guid("d106e90f-bc6e-4ef1-a14e-13dd1769a473"), new Guid("9aa1bb3b-ecdc-4b22-a4d5-4cf8abafecea"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("d5052de9-7298-47e2-a0bf-896bd475dc4f"), new Guid("4e0c8317-5743-4801-bbda-e2942a53d373"), null, "Всероссийский" },
                    { new Guid("d809fb13-ec63-4d7e-89c6-6141bd30e8db"), new Guid("3108c5f0-5108-4c61-a9af-f7f2e8ad9b06"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("db4f11f8-ca36-4c92-8600-10354ff8d508"), new Guid("3d97f70d-e969-4ded-9172-dfdf1c4a2fd6"), null, "Нет" },
                    { new Guid("e1afd457-6281-40f1-a5b5-9bf8f815f495"), new Guid("46385f21-7c4e-41fe-805f-19ea74eb6506"), null, "Изобретение" },
                    { new Guid("f147fdbe-58e9-4aa9-9f85-ad35a64cf6d4"), new Guid("3108c5f0-5108-4c61-a9af-f7f2e8ad9b06"), null, "ВАК (К2-К3)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("0e8394fc-c8d0-4313-994a-ff9c178a3682"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("43b25816-f53e-4008-9fde-2f28f7964805"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("4762b5b3-fa8f-4b93-8605-5285ff8f8f44"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("8005a686-3ea3-4c9a-8288-785ee5c2fa3f"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("87c18ce2-30f8-426d-abf5-624511d9d421"));

            migrationBuilder.DeleteData(
                table: "ApplicationStatuses",
                keyColumn: "Id",
                keyValue: new Guid("f02cf7e0-c8e5-48cb-9a6a-86d89c91f457"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2faa169d-a63f-43e2-ae18-3f1245189a3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80fe7082-65c0-4a6b-af89-acd9fc265729");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84f6a664-6b5e-40b1-8e04-f64be9b4d307");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "899dc015-87cf-4557-8af5-79ed06de84ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5ec9139-b3af-4115-b585-3c375898e67d");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("118a0f8d-9439-40ff-bc51-349a6e527b9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8617b191-af29-4ecb-a417-ffefd779cc1b"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("01dd20b5-a610-412c-bf1f-3309e0a4b529"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("07ef818a-9feb-4d39-bf05-a027c688c03b"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("0f0511de-f0a9-4484-ba53-5f8e30f921ee"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("0fd862f7-9e6a-4899-8501-d17b15a93f66"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("1057e35f-436b-4910-985e-24a26c0d7fb7"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("18e78d01-a09e-4952-a91e-8ca75ca58e66"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("18f1cd8e-634f-40f8-9c8d-a0604ebda7ff"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("280717fa-3715-4592-91b6-03b395e5d7df"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("2e39eb33-7426-4f74-a919-0671b2af72ca"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("32e498d8-b57b-468e-b85d-8a968b5794e5"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("3c00f730-ff9a-4d9d-8337-7126bf75f335"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("42bbe453-9dda-454b-ac81-196125b6f2e3"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("48701d44-e840-403e-b656-2b67f27e1d65"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("4f612b9e-1054-430e-bc77-d14eae457ebd"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("5aae0e44-c386-4424-b10c-1287c63a70e3"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("9ba1feb6-bd54-45da-ba94-ed49cecb71ec"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("a5beacf2-2b93-4af9-84bb-85b7c9aac017"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("ae7ba25b-0f17-4228-b5a0-6b52f5b9f302"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("b329a76e-3b62-4cd4-a9bd-f37d95d5f606"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("b36ab3a3-060c-4eb9-86a1-7f3baa439082"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("c573e7ed-fc23-44b1-83d7-1d302a3c0cd8"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("daa50a52-bf89-4390-aa49-b3f48a85fbf0"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("dc09f0a6-9bf2-4163-861d-3dedb3a5e784"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("e7e844b9-5e93-4d2e-9ef9-b688d52d1ebe"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("e8f23608-ffc5-4ef0-8b5f-8c9f5b61e11f"));

            migrationBuilder.DeleteData(
                table: "CellVals",
                keyColumn: "Id",
                keyValue: new Guid("f8d483da-bdf0-4a1c-a01d-67020feafd5f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("0cd82ce3-fc88-4172-b0d6-d53800d00cc1"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("107b1b40-0bcb-4060-ae2e-aa28648287a0"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("11f67a00-10a1-41b4-bb54-dcad556ed56a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("1435ab8c-e799-49b2-83ea-3e00e725134c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("17b5b24c-3c89-465e-b293-cef4b33bd876"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("229b29de-f54a-4d23-bdab-4732f3db339d"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("31cae352-46e7-433d-b0c1-56c9c3f07980"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("34f5e02a-b939-4e6c-95cd-d4a650c0860f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("359f255d-459b-406c-af5e-5a71278de1ad"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("3b3be36b-a037-46cc-b633-bee655eb7bae"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("49455b7d-6706-4954-9c58-90f8c00650bd"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("5156e5db-d6d3-4a11-b11f-43f0e3052848"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("5e70b16b-7121-4d15-bb3e-380afa440701"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("6173f0ed-b2ac-4f8d-9c99-ba32b3c36198"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("6197d128-ec4c-4490-b3df-44625a31880a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("74eaa7b8-e44c-4c4e-a97c-f767c511d53a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("86437198-7be7-45a4-b289-7239c16f7f10"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("8e0fe263-7e5a-452e-8cc1-59d649f0b6c0"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9080704f-b3ba-4dee-87f1-42f0dc083a11"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9a7661e3-d22d-4075-80b9-586bdfa88d5b"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9fe2c85b-c24f-48af-9cc8-80e97420009a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("ac6a6bbe-b084-462a-8c3d-39db2fa52bea"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("adb0e996-0c5e-4f42-a7f1-e29fa9fc86b8"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b15ccf80-a42a-424a-a38a-378be76c7fed"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b5f46577-a20e-4e4d-a99f-f4368311ae69"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b704c0de-ec3e-4444-898a-e3f4ee1ce5b9"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b879510e-234f-46ac-870a-621ce979c785"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("bccb102e-2157-48bc-a73f-461422aaab8e"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("d440cc2d-8700-40d8-bde4-95db7be8451e"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("d570fdef-b055-4c69-8f8b-6bd3ead967b9"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("d6faee8f-e216-4a09-95b7-9bc81148c6ae"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("e67b00db-3668-4d5b-8f75-b4a309fb3a7a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("edd6f599-0956-49f4-8975-c98b273271c8"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("fe600a8f-0539-4442-997c-136d2905b4fc"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("ff1137c3-2303-4e9c-9e4c-bc8c14b93513"));

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("59fee98a-e4ff-4de6-abe3-64e3502ff433"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("b80c9c2b-ed65-4544-80d2-6fa5491b7070"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("c632289c-502e-41b3-a89d-16ac6f094746"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("c632289c-502e-41b3-a89d-16ac6f094746"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("cc26592a-d57f-4e01-802c-0e9ab92c1498"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("cc26592a-d57f-4e01-802c-0e9ab92c1498"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("f6d9383d-495d-4af5-b7c5-0ba9936841a5"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("f6d9383d-495d-4af5-b7c5-0ba9936841a5"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("03cfef95-8250-44c7-a3fd-a7ae47ae2ce8"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("03cfef95-8250-44c7-a3fd-a7ae47ae2ce8"), new Guid("215b5631-b702-4fd5-8a6c-ec880892114b") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("03cfef95-8250-44c7-a3fd-a7ae47ae2ce8"), new Guid("404fe079-eff7-43cf-8180-08e9470a544d") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("07612b69-c3e4-4123-89bb-1b33e65b5254"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("1e35e8ed-7984-4286-9ba4-183af1ae62cb"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("1f40f0b0-aafa-48cf-81ad-3d9743f7c8a2"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("3397d22f-5dd0-434b-8d8e-68b72cf81ba2"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("635777ad-cb0d-4909-ab4f-eff0376fce2c"), new Guid("215b5631-b702-4fd5-8a6c-ec880892114b") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("81777154-a657-45c6-8ef4-f9cff5a0c100"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("85a611bd-fdb6-4e58-bd14-d1247b3400ad"), new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("8f7d38b6-a6cf-4c5d-8e03-b78cbb2aa81b"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("9237f975-ef99-44aa-8cc9-5fac68559582"), new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("9c24e3af-6a30-494a-8827-e2c815c3f8f3"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("b020a3c6-99cd-4c29-b039-c8701db8f798"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("b517350a-b6f1-4bf8-8348-a2727c7f1eed"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("d9e5dc4a-886c-46b2-bb27-2e249e4cae3b"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("da50a6f1-9db2-466c-b165-726ac3bbaa7b"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("ebfea5aa-f6df-4e8b-aa04-0efe9489afe9"), new Guid("215b5631-b702-4fd5-8a6c-ec880892114b") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("f0ed3dd3-d357-41b1-8f5e-803b01a319b4"), new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("f6901305-74f8-4a5a-8ec1-095f9c53b7b9"), new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8"), new Guid("d64a2008-a1b3-4eca-bfd3-1c039b74affb") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("43709cbd-e47e-48f7-9de0-6bba70d0bf39") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("7175339e-ff5f-4a32-b8e1-b4776e99b78c") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("8e8f8289-2433-4254-8c81-ac5b290576b7") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("404fe079-eff7-43cf-8180-08e9470a544d"), new Guid("6e463686-4018-4b46-9c5a-00a44aff6e77") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("404fe079-eff7-43cf-8180-08e9470a544d"), new Guid("7175339e-ff5f-4a32-b8e1-b4776e99b78c") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("57602c01-c785-478d-9551-9f4ff23f7ce2") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("156d0440-7d96-4034-9362-467618fe4117") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("719e2dd1-a32c-49c6-9671-dc3ede841e58") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("f3b2e492-8970-4e02-86d9-ad912cdfb670") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("be0683a1-aff4-4cfa-8103-9b30e140037c"), new Guid("c84da322-b588-4cef-bf78-937ab11c54e8") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), new Guid("6e463686-4018-4b46-9c5a-00a44aff6e77") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), new Guid("7f295636-cbb1-49b9-a543-55f3d9706553") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), new Guid("d8b5152e-91fe-4cd3-9c49-56c9c8f9ab70") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("404fe079-eff7-43cf-8180-08e9470a544d"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("be0683a1-aff4-4cfa-8103-9b30e140037c"), new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("be0683a1-aff4-4cfa-8103-9b30e140037c"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("03f8845e-041f-4205-9faf-2e7e617a6c01") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("502ecdfd-71ea-4ed7-a0b2-0fce971271c5") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("692eb0fe-834c-47e4-91c6-98a1ad44f345") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("7e9d8eb3-5a0e-4245-ad29-1dd4f0a5c6ff") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("ac8fa087-8793-4dee-915c-1c2eb1f3b56b") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("e0ca1761-78bd-4516-8efd-c4c3d029a5ca") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"), new Guid("eb80ed87-4db6-48a2-acc1-af68f769a186") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("404fe079-eff7-43cf-8180-08e9470a544d"), new Guid("277c2d2b-5519-438d-aa7a-98378a52a586") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("404fe079-eff7-43cf-8180-08e9470a544d"), new Guid("7e9d8eb3-5a0e-4245-ad29-1dd4f0a5c6ff") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("404fe079-eff7-43cf-8180-08e9470a544d"), new Guid("ac8fa087-8793-4dee-915c-1c2eb1f3b56b") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("49811271-b92c-411b-b45d-a569ab8d86c2") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("96eb5c6d-41f1-4bd9-88f8-05bf2c894b65") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("b65b3465-29e6-4c5f-b1d9-8660e22f3f25") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("c34daf77-dcde-446b-90ef-02bf4a8c0244") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"), new Guid("c6e86fc3-32a2-44ae-8455-e58dff8cde8b") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("44a31f4f-4f7d-4991-8a9f-7a735a52f41a") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("66b84870-7dd2-4055-858a-29ad778165c8") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("675c79d0-a2f0-4d68-9bf9-5b383c326ad3") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("864ec7d2-bd8c-474d-bc78-80d42b1f219a") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("bf22f156-46fd-446e-84ff-10a8b9635275") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("bf3da495-3916-4eb9-ab4c-a11ca5d66b52") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"), new Guid("da288433-e821-41b8-9e6e-90d4d00e0923") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("be0683a1-aff4-4cfa-8103-9b30e140037c"), new Guid("14e504d2-383d-4e31-9d66-be95617c035b") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("be0683a1-aff4-4cfa-8103-9b30e140037c"), new Guid("eb23c5b3-8729-41cf-a3e0-49bbc9481e1a") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), new Guid("277c2d2b-5519-438d-aa7a-98378a52a586") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), new Guid("5a84a546-4d2d-4bb8-b850-0df69d4db191") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"), new Guid("66727a22-584b-4530-a6f6-0e8733bf3d25") });

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("04998dbe-a12b-44c3-b432-23651e8bb8c4"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("0bc203c1-244e-4857-aace-92960f55d63d"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("124ed4bb-412e-4402-a01f-e197502967b6"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("1d265ab5-bf94-4d00-97e4-62199843f11a"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("1db4b221-6084-4553-8f56-51ea06b27266"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("2a8ed0a2-150a-4f10-8edc-6800e61f890d"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("2a9eee34-b3fd-4f0f-942a-c5a471db35fa"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("343cd908-fbf2-4402-9c02-2f034fff42f0"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("347018e9-f279-408c-bf81-ade526ac71cb"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("3ccde546-06ef-4821-b451-9a00e5cce30e"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("46d23948-862c-4cda-8544-9aebca5091f1"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("4d16d748-82ee-4e19-a2c2-4a64420fcd9c"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("52bfa1ff-b6a8-412e-bb5f-932522e911fd"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("57250608-59e3-4b3a-8704-aebfa2b12e79"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("606b3153-81e2-463c-be5b-a10caa4ef80a"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("640c28c0-fb63-4acd-9fd3-2732d21bdf6b"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("6acdb566-8d10-45b4-bfa5-32dd0f232f38"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("6eeaaeb7-5e40-473d-8f37-1da88447d750"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("767a5a62-4c69-46c7-9f14-14797b2f1eeb"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("769390f2-457e-46b6-92fc-18f25ba7924a"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("84ba0d9b-5e83-4d23-b594-3c0f968b0b23"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("9194c67c-f90e-46d6-ae9b-193d1444668d"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("921d50bd-3bf5-49b3-bed2-b42f8d020358"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("99621d44-a6eb-439e-ab5f-1b8a19c58c5a"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("9af3fc0e-0516-4af8-b73a-64cfaf53bf1a"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("9fa06e99-f29c-4175-9683-f804d022b042"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("aa33c2a8-d3ca-4686-865b-9163b8c5eeea"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("acf88de0-0fa0-42d6-8d9f-cae3db88c958"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("b15448cc-59a9-401a-b71f-00daf8c836f2"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("c2eef0df-88bd-4f9b-b167-e43eeef5b27d"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("c5bd3f0f-134f-4027-924e-8b90f7e17d09"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("cecec929-4908-46d5-9f52-b243e53c1679"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("cf2bdfa2-fb3a-427e-8449-77f504125985"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("d106e90f-bc6e-4ef1-a14e-13dd1769a473"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("d5052de9-7298-47e2-a0bf-896bd475dc4f"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("d809fb13-ec63-4d7e-89c6-6141bd30e8db"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("db4f11f8-ca36-4c92-8600-10354ff8d508"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("e1afd457-6281-40f1-a5b5-9bf8f815f495"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("f147fdbe-58e9-4aa9-9f85-ad35a64cf6d4"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("fd9094e0-8a31-478f-bcae-04b1a15a6584"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("1aa002fc-490f-4a15-aa9f-1b39b054e37c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("29172de1-16a0-4ee8-be15-dba03a2dcecc"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("2974068e-ec58-4a31-a834-ac27edf03165"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("3108c5f0-5108-4c61-a9af-f7f2e8ad9b06"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("373ca755-7be2-40d1-8355-c47340507294"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("3d97f70d-e969-4ded-9172-dfdf1c4a2fd6"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("46385f21-7c4e-41fe-805f-19ea74eb6506"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("4e0c8317-5743-4801-bbda-e2942a53d373"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("70c001e0-0159-45b0-a95b-5149ffa52643"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("87ea0625-b066-48e2-b134-89055825dfdf"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9aa1bb3b-ecdc-4b22-a4d5-4cf8abafecea"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b19f8163-1190-4991-a46a-0273132f35be"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b2a25513-bd1b-48fc-8313-188d4f44db1f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b8be5a76-fb82-45a2-92f3-9c46ea6f8af1"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("d91d23a2-fa9a-4140-b8ed-693b62fa6d8c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("fb2e69e7-18b6-427a-8352-2e2897dc2f54"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("fcaa5618-805e-4e63-90c1-0c430f1c2a56"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("07612b69-c3e4-4123-89bb-1b33e65b5254"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("1e35e8ed-7984-4286-9ba4-183af1ae62cb"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("1f40f0b0-aafa-48cf-81ad-3d9743f7c8a2"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("3397d22f-5dd0-434b-8d8e-68b72cf81ba2"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("81777154-a657-45c6-8ef4-f9cff5a0c100"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("8f7d38b6-a6cf-4c5d-8e03-b78cbb2aa81b"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("9c24e3af-6a30-494a-8827-e2c815c3f8f3"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("b020a3c6-99cd-4c29-b039-c8701db8f798"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("b517350a-b6f1-4bf8-8348-a2727c7f1eed"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("d9e5dc4a-886c-46b2-bb27-2e249e4cae3b"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("da50a6f1-9db2-466c-b165-726ac3bbaa7b"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("f0ed3dd3-d357-41b1-8f5e-803b01a319b4"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("1f4c4c54-9f20-4a76-97c5-3b9caf45f2d8"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("215b5631-b702-4fd5-8a6c-ec880892114b"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("404fe079-eff7-43cf-8180-08e9470a544d"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("6dc7f7d5-f5f0-4102-80db-e387ccd89bac"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("950ece3b-165f-4e79-acbd-2d7aa8f917f4"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("be0683a1-aff4-4cfa-8103-9b30e140037c"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("dff243f3-3333-4cb2-98d3-62d65b80afce"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("03f8845e-041f-4205-9faf-2e7e617a6c01"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("14e504d2-383d-4e31-9d66-be95617c035b"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("277c2d2b-5519-438d-aa7a-98378a52a586"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("44a31f4f-4f7d-4991-8a9f-7a735a52f41a"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("49811271-b92c-411b-b45d-a569ab8d86c2"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("502ecdfd-71ea-4ed7-a0b2-0fce971271c5"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("5a84a546-4d2d-4bb8-b850-0df69d4db191"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("66727a22-584b-4530-a6f6-0e8733bf3d25"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("66b84870-7dd2-4055-858a-29ad778165c8"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("675c79d0-a2f0-4d68-9bf9-5b383c326ad3"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("692eb0fe-834c-47e4-91c6-98a1ad44f345"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("7e9d8eb3-5a0e-4245-ad29-1dd4f0a5c6ff"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("864ec7d2-bd8c-474d-bc78-80d42b1f219a"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("96eb5c6d-41f1-4bd9-88f8-05bf2c894b65"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("ac8fa087-8793-4dee-915c-1c2eb1f3b56b"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("b65b3465-29e6-4c5f-b1d9-8660e22f3f25"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("bf22f156-46fd-446e-84ff-10a8b9635275"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("bf3da495-3916-4eb9-ab4c-a11ca5d66b52"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("c34daf77-dcde-446b-90ef-02bf4a8c0244"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("c6e86fc3-32a2-44ae-8455-e58dff8cde8b"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("da288433-e821-41b8-9e6e-90d4d00e0923"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("e0ca1761-78bd-4516-8efd-c4c3d029a5ca"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("eb23c5b3-8729-41cf-a3e0-49bbc9481e1a"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("eb80ed87-4db6-48a2-acc1-af68f769a186"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("06781231-8acf-4e5f-add4-559b4a521951"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("152da749-fa45-4888-a20b-7c721c0c2fdb"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("3dd436b3-eb8a-4ad7-8924-02bf457f2999"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("47791747-f23d-43bc-a753-80eac93e138c"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("57feb7ed-98b6-4f37-a0bb-b1c4026bd200"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("5f4f3636-3280-4603-a39a-670cb7d3422b"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("6e4f6320-3880-4024-8a08-86104d869d50"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("713cb0c8-0b70-4d8e-92f4-d390ab557b0a"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("8229d870-8db2-4cdf-b6bd-0428e2681c81"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("99af3d55-d531-4457-b48f-3a61f0e5029a"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("ccc85dbe-b258-4d72-958f-10b26b2facb4"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("d0f5f666-6149-4a37-900e-9f3a6e0fac2b"));

            migrationBuilder.DeleteData(
                table: "Rows",
                keyColumn: "Id",
                keyValue: new Guid("f86ceda9-d679-49c1-b454-5cc1429c0de0"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("87b9416e-c313-4c08-8a28-74d31d2ee8d9"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("99fd548f-b45e-4ecc-8bb9-ca2647973dae"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("add005bb-c09e-4d36-b517-75731bf3a4b6"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("03cfef95-8250-44c7-a3fd-a7ae47ae2ce8"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("635777ad-cb0d-4909-ab4f-eff0376fce2c"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("85a611bd-fdb6-4e58-bd14-d1247b3400ad"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("9237f975-ef99-44aa-8cc9-5fac68559582"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("ebfea5aa-f6df-4e8b-aa04-0efe9489afe9"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("f6901305-74f8-4a5a-8ec1-095f9c53b7b9"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("156d0440-7d96-4034-9362-467618fe4117"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("43709cbd-e47e-48f7-9de0-6bba70d0bf39"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("57602c01-c785-478d-9551-9f4ff23f7ce2"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("6e463686-4018-4b46-9c5a-00a44aff6e77"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("7175339e-ff5f-4a32-b8e1-b4776e99b78c"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("719e2dd1-a32c-49c6-9671-dc3ede841e58"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("7f295636-cbb1-49b9-a543-55f3d9706553"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("8e8f8289-2433-4254-8c81-ac5b290576b7"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("c84da322-b588-4cef-bf78-937ab11c54e8"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("d64a2008-a1b3-4eca-bfd3-1c039b74affb"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("d8b5152e-91fe-4cd3-9c49-56c9c8f9ab70"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("ef8c3ef0-39e9-4911-8744-4eb0fcbf1c5f"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("f3b2e492-8970-4e02-86d9-ad912cdfb670"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("018645a1-f2e2-47ab-a3cc-73d73095633d"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("59523d30-8aa9-47e2-9510-6214e86f771a"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("d4be5078-efbb-4351-be89-324d543a5cc9"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("59fee98a-e4ff-4de6-abe3-64e3502ff433"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("b80c9c2b-ed65-4544-80d2-6fa5491b7070"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("c632289c-502e-41b3-a89d-16ac6f094746"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("cc26592a-d57f-4e01-802c-0e9ab92c1498"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("f6d9383d-495d-4af5-b7c5-0ba9936841a5"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("03e18f15-7d08-4d30-be31-0aa02d64b387"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("9a0eaf4e-5a48-4624-b657-fd4d77a8fe97"));

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
        }
    }
}
