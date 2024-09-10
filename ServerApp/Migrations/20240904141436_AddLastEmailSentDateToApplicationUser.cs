using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddLastEmailSentDateToApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("0db8e2f5-6fc8-4fc1-97f2-b90b5a23a42c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("1d82ca7d-fa2d-4d14-bd63-e634978535e2"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("1fe5d1d1-ea8d-43c5-a1d6-4fcb021932be"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("21d4de64-4019-40da-bfd6-979799c87b46"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("36cf26da-ed0c-48c1-addd-e6f36011eddc"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("42415f08-3c19-46f5-bc96-076e19e58b94"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("51255486-b0f3-45f7-9d23-7388ed1095dd"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("52078266-6be4-4c39-aad0-9946e4898f9f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("58a29801-d5e7-48d7-8802-0bdb61d0a9d0"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("5f9568cd-5a8b-4e17-ab10-b29ead005cd4"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("659dc1de-b7c6-49f3-82f4-9603086bcbec"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("6dc27acf-77c2-48b2-af81-6d5eca69f93a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("72250b1a-f5c0-49cc-8580-b23191179e9a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("72461200-bd55-4dd6-859d-de077988bb7c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("781a57fa-7e04-4ca3-ab31-e170ba6aa7c7"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("885dba0c-bc7b-403a-a01f-fe994088c022"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("8d8387b3-1e7e-44ec-9131-a72c95af6621"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("8ecd005f-a780-4e6c-b339-f66a8e85e398"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9d3bf5f9-bfd2-4eaa-8a45-7452645dd59f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("a19c9d70-5a6e-479e-886a-53ed214d066f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("a91a5ba1-691d-4531-8cd9-b3925a5a45ab"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b0579ce3-c185-44f3-b529-5573cc77e8c0"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b1918f2e-d2f7-4d16-9653-90b5908eb548"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b4515353-3345-4962-98d0-0d4c3a9e396f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b6acdbc6-a1af-4d3a-bd3a-9aba3aa097ee"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("baae5761-40b5-4752-a963-4ee255436a3f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("bc5f13f5-66e8-4799-88e2-175357dc001c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("bfabc20b-e965-460d-b818-b5f816e6fa3c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("c0249435-e0bd-48dc-b2b6-f1ceb2bb3eea"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("c25740e4-b353-486a-b0fa-0d649f1e9418"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("c3158ccb-c593-4af6-b96a-64d2d60c9e30"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("c338be79-3a70-400b-ade1-4238cfc98234"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("c6f9b210-fd10-4519-a908-c669634b16b9"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("c7eb27eb-5ecd-4530-b201-9e6249947ec5"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("d0ae3468-a70b-491e-a221-aae679fb34ea"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("d16fe35a-9fe0-4ddd-93dc-c7685e7a77ac"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("d5d006b1-9f4c-43c0-a85d-aec04bb21651"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("d6477913-1f09-41cb-8c5b-de8bb4381657"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("dcb47384-32d7-405d-99f2-377c0b5a2699"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("e186453f-1d86-41f5-a9a8-ee0388be06b1"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("e2bc417d-b008-4d90-a9d3-f1675d7a826f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("e3ecf46c-9414-42f2-ace0-d6ea9c570efa"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("ea0997d4-f4f7-4d2f-bec7-2876ba9bf9b6"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("f00ad8c2-3004-489a-ab4d-4610ebf58dc7"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("f63ea870-9caa-4ab8-883a-dfa6d871d988"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("f91b9bd9-f4a4-4c8e-bb45-05cf7d25d535"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("fb32cadb-8d3a-4d18-b679-63e2f127236f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("fc67b6bc-bfc5-494b-97dc-5a9b0f5da0e6"));

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("0c8808c7-4274-4f10-a38c-486d0a76de75"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("0c8808c7-4274-4f10-a38c-486d0a76de75"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("8cd73dd8-f545-49d2-ad4b-94a184825a74"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("bc562ed0-6d15-4ade-9f74-04bd750aa57e"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("bc562ed0-6d15-4ade-9f74-04bd750aa57e"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("08917d36-0269-4ec1-9bbe-ed785fcca6ab"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("0b6450c5-e4c6-4b1b-84ae-2d78742877fb"), new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("13f3e524-d4da-4162-9bdc-9718b1ead6d3"), new Guid("40851c9f-314e-4e30-a21c-c622a10eae25") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("188c621f-4cbe-4bf2-9756-dbe6ee0bd342"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("3a38d456-742f-4276-aee9-a2ec3c4c0208"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("3e8f7559-5ca1-447a-ba8d-4da205094844"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("490302f1-fae1-4d36-9b85-434aaa53c48f"), new Guid("40851c9f-314e-4e30-a21c-c622a10eae25") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("6a180669-e5f1-40be-b0f2-e78b89fd611e"), new Guid("40851c9f-314e-4e30-a21c-c622a10eae25") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("711c807d-77d1-4650-9b54-19041412aaf6"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("78b46f99-65b0-4710-98a6-cfcf5de78be2"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("7e4f2ad7-8c00-4cbf-816d-081bebbfc85c"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("7e4f2ad7-8c00-4cbf-816d-081bebbfc85c"), new Guid("41a63948-a198-43c1-90f1-bec3431f613a") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("7e4f2ad7-8c00-4cbf-816d-081bebbfc85c"), new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("8e66ddcc-5794-4cc0-ac09-4e3672479480"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("a4f88551-f6e4-4672-a7dc-9066cf191cf8"), new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("a791611e-f88a-44c4-aafb-eb794c05a19c"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("ca05e077-020e-4236-af1a-c9f06a04f1e1"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("d783c5d5-49b1-43e9-af69-8392acb7d55c"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("d9537168-0d7d-4016-9a75-1e846d6a7bbe"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("e1a76ce9-4f49-4eb2-a8af-c2698205f94e"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("e47d73a7-7ea9-41e6-8073-e98bf154dd5e"), new Guid("40851c9f-314e-4e30-a21c-c622a10eae25") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("ed7a901c-9173-425b-8003-0e6c6de496cb"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("ef4616fe-b66c-428a-a645-bd128eaadb6c"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("f5e2f50e-8ca6-43c2-908f-b5f498e0877d"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("f663cc7f-ff3b-4806-af3f-3a157c543075"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("f9864029-ceca-4c09-9f09-2a7d1739055a"), new Guid("40851c9f-314e-4e30-a21c-c622a10eae25") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("619f4717-73bf-4652-859c-4d3a3da8049d") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("b64f67fd-3f9d-4a06-ba87-55d1a709b453") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("c4458d87-cb60-4e72-ae85-0b03efc08be3") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("143a4d76-6814-44a4-ad06-4ca9a1ba61ff") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("71f5775c-55bf-47db-a79a-9713b1f6d492") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("9b781db3-a8cb-4e94-8114-8a44ce6420f9") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("a326230f-e103-4657-8cc0-72941957fda1") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("41a63948-a198-43c1-90f1-bec3431f613a"), new Guid("b64f67fd-3f9d-4a06-ba87-55d1a709b453") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("41a63948-a198-43c1-90f1-bec3431f613a"), new Guid("edc350bc-82f6-41d8-92e0-7d7d2e7452e8") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("b274a947-530f-47bb-b8e8-f3626fcbccf2") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("eebaa703-33b2-48a0-b7fd-c833cb0eb3f8") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("35802550-4f0a-49c7-8604-7ae5cd60e43c") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("4fb349bf-cd0f-4048-8ca5-17f51d1e4c41") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("64c81acf-686b-4da6-b465-ebb79839edc4") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("edc350bc-82f6-41d8-92e0-7d7d2e7452e8") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("0165f555-0787-4a87-8f3c-cf368193bab1"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("0165f555-0787-4a87-8f3c-cf368193bab1"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("41a63948-a198-43c1-90f1-bec3431f613a"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("4ec27e93-178c-479c-be65-21bedb251290"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("4ec27e93-178c-479c-be65-21bedb251290"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("77419d63-f392-4eae-baf0-4b85fe8e8d45"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("77419d63-f392-4eae-baf0-4b85fe8e8d45"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("04e6730f-e10d-4b05-b52e-c3ae4c1b9e6f") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("2dae456c-1c94-4766-9740-3c06fca82865") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("49abead9-7b50-4596-b3dd-91d565059db2") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("8d5bdde4-bd84-471f-bd9f-21f0bb071cef") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("9526fe7a-4a84-4491-84c5-398199b4e40b") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("3b54a3b8-be83-416e-a012-5a847c0b18c7") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("428a9254-0c1e-468b-92fe-19a3111d4c3d") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("807ae89d-d24e-441c-bc8f-2c7d122abc60") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("a97b5ed6-7799-4824-a5df-5786b39fce67") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("b80cdbde-f153-4d24-b8b2-4f2977d8064a") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("f4814bfe-3b61-4fa1-9f6e-4417543157e0") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("f94f0d5a-e57e-4628-83f6-e1778f1cb160") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("41a63948-a198-43c1-90f1-bec3431f613a"), new Guid("2dae456c-1c94-4766-9740-3c06fca82865") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("41a63948-a198-43c1-90f1-bec3431f613a"), new Guid("372af6b8-ee21-490a-a821-e95252ed5b6b") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("41a63948-a198-43c1-90f1-bec3431f613a"), new Guid("cd455721-cb3b-4d4b-957d-b1018b8c849a") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("29b3f439-6d56-4d27-8e04-9a5492b5ba28") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("32e81cda-6b15-478f-b762-b022bf94f646") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("5def831c-620e-438a-a5cc-3f221b46d91d") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("7b542f2b-2683-4a54-a418-bc46c852eb6c") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("f8400e52-5a10-43e1-a652-d656f215a75d") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("1bbae866-be86-4ef7-b920-9ce1b913c075") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("26ca7e10-8dd3-4966-9f6c-2bf8cfe1bd0d") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("372af6b8-ee21-490a-a821-e95252ed5b6b") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("3c5301e4-acab-4fe3-afc8-feca3384d352") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("6956ba82-4392-4c98-aa51-4c88509a782e") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("ba52d1ef-079b-47d6-a392-9d9ace48b8d4") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("cd455721-cb3b-4d4b-957d-b1018b8c849a") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("d4624fdf-f2ca-4b02-8153-df7f38ab23e8") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("f8f090ac-0084-436c-86f0-0b9dc9443798") });

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("00ddbee1-1009-4511-8e4f-451cddb3a0c6"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("09126e00-094e-4d77-8196-e1db9a322d27"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("195f606b-8893-435d-8467-ef2942d464c8"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("22d120a8-5818-4d36-8e3f-e0c4ad58877b"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("33cee135-1341-4b15-ab89-3147fe3eeba0"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("34b63049-7cac-496c-8c30-db38d5cfdba4"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("45695db0-0693-412c-a896-e53b9c82cfb5"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("578cb3f8-75a9-4b9b-af63-d8563767867e"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("660cd2ec-96b1-4b60-95ef-c648e21a5a93"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("663571a7-119f-4d6f-b3de-7c138a1d9e95"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("6a60ce08-23c0-4b95-9393-bb14a2600933"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("7419cee8-c60b-4406-8c17-fcf17cb996c1"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("75eb3aa6-2faa-4d4d-8e63-46763e323d56"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("81809d0b-697f-43f0-a4b4-8882cd550c2c"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("993cb145-c72d-4bad-a245-7d9dc0edc376"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("a62d1632-163b-4fe7-8a3f-054596057682"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("aab88d5b-52ed-44a2-b60f-d8b0eab0e784"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("b162f8ed-e0df-44b2-b2a8-b2a0a7ae5374"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("c0c1be3d-b103-4af8-8709-9172bfc321e8"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("c7818e7b-e1c4-432e-9257-8239644ed9da"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("d15c65f9-3796-4926-816b-b422b0c93e9d"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("d40d7cfa-1b9d-4f65-9a75-98905a85eb93"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("d5723961-f2e6-4c35-bef2-81cec8397313"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("da482456-d0e3-4cf4-899e-0e8d76fdda70"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("e5f9a4c1-2277-4d2f-9604-bf5e87c89729"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("e61d2983-eb6d-4427-85bd-d19f7881d59d"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("e7a0ad3c-72ae-441d-90fa-85b8e9982fff"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("e8383c82-e16d-4d5a-820c-760362d9bf89"));

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("db758034-f57a-4ad1-9f5a-7c8cf1236693"));

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("f62bf5c0-a626-41cc-9c2f-232a0fbe1dd8"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("49693feb-b595-4e66-b7bd-33c583093e6b"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("5384e4f1-493f-49c7-bbd4-9921f2e3aec1"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("86f6d1ed-9481-45bd-b9db-e5b93f6e6a26"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9e2c4fc0-720f-4766-bd9d-98056517f191"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b9488aa1-7cfe-4c6e-95fb-09268bb4483b"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("f113e9d6-86da-41c2-94c3-04f561faf76d"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("08917d36-0269-4ec1-9bbe-ed785fcca6ab"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("13f3e524-d4da-4162-9bdc-9718b1ead6d3"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("188c621f-4cbe-4bf2-9756-dbe6ee0bd342"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("3a38d456-742f-4276-aee9-a2ec3c4c0208"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("3e8f7559-5ca1-447a-ba8d-4da205094844"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("711c807d-77d1-4650-9b54-19041412aaf6"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("78b46f99-65b0-4710-98a6-cfcf5de78be2"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("8e66ddcc-5794-4cc0-ac09-4e3672479480"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("a791611e-f88a-44c4-aafb-eb794c05a19c"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("ca05e077-020e-4236-af1a-c9f06a04f1e1"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("d783c5d5-49b1-43e9-af69-8392acb7d55c"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("d9537168-0d7d-4016-9a75-1e846d6a7bbe"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("e1a76ce9-4f49-4eb2-a8af-c2698205f94e"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("ed7a901c-9173-425b-8003-0e6c6de496cb"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("ef4616fe-b66c-428a-a645-bd128eaadb6c"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("f5e2f50e-8ca6-43c2-908f-b5f498e0877d"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("f663cc7f-ff3b-4806-af3f-3a157c543075"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("f9864029-ceca-4c09-9f09-2a7d1739055a"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("0165f555-0787-4a87-8f3c-cf368193bab1"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("41a63948-a198-43c1-90f1-bec3431f613a"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("4ec27e93-178c-479c-be65-21bedb251290"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("6bf55534-4783-4787-973c-6b110f1d9949"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("77419d63-f392-4eae-baf0-4b85fe8e8d45"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("04e6730f-e10d-4b05-b52e-c3ae4c1b9e6f"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("1bbae866-be86-4ef7-b920-9ce1b913c075"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("26ca7e10-8dd3-4966-9f6c-2bf8cfe1bd0d"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("29b3f439-6d56-4d27-8e04-9a5492b5ba28"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("2dae456c-1c94-4766-9740-3c06fca82865"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("32e81cda-6b15-478f-b762-b022bf94f646"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("372af6b8-ee21-490a-a821-e95252ed5b6b"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("3b54a3b8-be83-416e-a012-5a847c0b18c7"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("3c5301e4-acab-4fe3-afc8-feca3384d352"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("428a9254-0c1e-468b-92fe-19a3111d4c3d"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("49abead9-7b50-4596-b3dd-91d565059db2"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("5def831c-620e-438a-a5cc-3f221b46d91d"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("6956ba82-4392-4c98-aa51-4c88509a782e"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("7b542f2b-2683-4a54-a418-bc46c852eb6c"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("807ae89d-d24e-441c-bc8f-2c7d122abc60"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("8d5bdde4-bd84-471f-bd9f-21f0bb071cef"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("9526fe7a-4a84-4491-84c5-398199b4e40b"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("a97b5ed6-7799-4824-a5df-5786b39fce67"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("b80cdbde-f153-4d24-b8b2-4f2977d8064a"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("ba52d1ef-079b-47d6-a392-9d9ace48b8d4"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("cd455721-cb3b-4d4b-957d-b1018b8c849a"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("d4624fdf-f2ca-4b02-8153-df7f38ab23e8"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("f4814bfe-3b61-4fa1-9f6e-4417543157e0"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("f8400e52-5a10-43e1-a652-d656f215a75d"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("f8f090ac-0084-436c-86f0-0b9dc9443798"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("f94f0d5a-e57e-4628-83f6-e1778f1cb160"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("a326230f-e103-4657-8cc0-72941957fda1"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("d8e89007-76bf-41a3-9794-576a71e73732"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("c40b5318-c500-4ffc-8665-7278b64c5340"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("1dda1080-e035-4e29-ac88-02420ca82062"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("0b6450c5-e4c6-4b1b-84ae-2d78742877fb"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("490302f1-fae1-4d36-9b85-434aaa53c48f"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("6a180669-e5f1-40be-b0f2-e78b89fd611e"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("7e4f2ad7-8c00-4cbf-816d-081bebbfc85c"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("a4f88551-f6e4-4672-a7dc-9066cf191cf8"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("e47d73a7-7ea9-41e6-8073-e98bf154dd5e"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("143a4d76-6814-44a4-ad06-4ca9a1ba61ff"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("35802550-4f0a-49c7-8604-7ae5cd60e43c"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("4fb349bf-cd0f-4048-8ca5-17f51d1e4c41"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("619f4717-73bf-4652-859c-4d3a3da8049d"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("64c81acf-686b-4da6-b465-ebb79839edc4"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("71f5775c-55bf-47db-a79a-9713b1f6d492"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("9b781db3-a8cb-4e94-8114-8a44ce6420f9"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("b274a947-530f-47bb-b8e8-f3626fcbccf2"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("b64f67fd-3f9d-4a06-ba87-55d1a709b453"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("c4458d87-cb60-4e72-ae85-0b03efc08be3"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("edc350bc-82f6-41d8-92e0-7d7d2e7452e8"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("eebaa703-33b2-48a0-b7fd-c833cb0eb3f8"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("27caa7b7-2d30-44c3-86a5-8d665877ea55"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("0c8808c7-4274-4f10-a38c-486d0a76de75"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("8cd73dd8-f545-49d2-ad4b-94a184825a74"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("bc562ed0-6d15-4ade-9f74-04bd750aa57e"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("00229da4-ec96-4232-97e1-d63e3d40a036"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033"));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastEmailSentDate",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("4cfe3b46-0b4a-4e5b-acd2-de25a84d8890"), "Деятельность", 5 },
                    { new Guid("5c7954fe-4de3-4e02-b50a-28a7913d1494"), "Профессиональное развитие", 3 },
                    { new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), "Общая информация", 1 },
                    { new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"), "Деятельность", 4 },
                    { new Guid("c70a6377-6f01-4e51-9712-ae0091c20735"), "Категория участников", 2 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("3f20f455-02c2-4732-89e8-bd4fc906e3c0"), "Конкурсная работа", 7 },
                    { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), "Образовательная деятельность", 2 },
                    { new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2"), "Профессиональные показатели", 4 },
                    { new Guid("a778d3ea-0f14-476b-a871-1d7959a98873"), "Основной", 1 },
                    { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), "Инновационная и иная деятельность", 6 },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("d8db424c-55fd-4139-8526-7a6bb3e7851d"), "Итог", 8 },
                    { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), "Методическая деятельность", 3 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("387e4122-1139-4d62-846e-bbac8ecf9a5b"), null, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("ee91728c-e171-4983-b240-012b3c619675"), null, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("010cda4f-c838-45e5-b907-8663fb9c550f"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("e77c4be3-d425-473c-981f-c42b1cbc9975"), "User 2", "user@mail.ru" },
                    { new Guid("ffe3925f-656b-410c-8d38-a095bb6502ea"), "User 1", "admin@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9"), "string" },
                    { new Guid("7aa56c88-0c1c-4740-87ad-27bed2fa1f39"), "bool" },
                    { new Guid("949950d2-f19f-4dde-92b5-7459198f5977"), "int" },
                    { new Guid("b1f824fe-4ae7-48de-addc-d6111b1f04c8"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("4cfe3b46-0b4a-4e5b-acd2-de25a84d8890"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") },
                    { new Guid("5c7954fe-4de3-4e02-b50a-28a7913d1494"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") },
                    { new Guid("5c7954fe-4de3-4e02-b50a-28a7913d1494"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") },
                    { new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") },
                    { new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") },
                    { new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") },
                    { new Guid("c70a6377-6f01-4e51-9712-ae0091c20735"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") },
                    { new Guid("c70a6377-6f01-4e51-9712-ae0091c20735"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("00fc07ae-ee3b-4170-ac2e-92a884f93af8"), new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), null, "Дополнительная информация", 11, "Пример", new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("0a7f40a6-bec6-4fbe-9e1b-c838b3f05b01"), new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), null, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("15ebde32-243b-461e-aff6-d99289966b51"), new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), null, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("1e32053a-1da4-485e-8f79-e33e1acea171"), new Guid("c70a6377-6f01-4e51-9712-ae0091c20735"), null, "Название конкрусной работы", 14, "Введите название своей конкурсной работы", new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("2a4b4b10-eacc-46f9-b8c8-9e8f066609eb"), new Guid("c70a6377-6f01-4e51-9712-ae0091c20735"), null, "Направление конкурса", 12, "Выберите направление конкурса", new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("2f716f8b-5530-4028-b45c-c1d9e2caefdc"), new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), null, "Дата рождения", 2, "01.01.2000", new Guid("b1f824fe-4ae7-48de-addc-d6111b1f04c8") },
                    { new Guid("37b7b6c1-a0d9-43d7-b085-765aef60b4de"), new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), null, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("3b46b9cf-1eeb-4c55-9b63-74c351e0baee"), new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"), "Руководство дипломными проектами за предыдущий учебный год", "Защитившиеся бакалавры", 20, "Введите количество", new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("3ba4d37c-554a-497a-ba6d-c28bf30a5d2d"), new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), null, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("43a085ca-f3f0-4e35-972b-2c6aa03caf60"), new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"), null, "Защитившиеся магистры", 22, "Введите количество", new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("4c7f221f-861d-43e3-adb7-b71e571fba85"), new Guid("c70a6377-6f01-4e51-9712-ae0091c20735"), null, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 13, "Выберите категорию участника конкруса", new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("514ff213-8435-4250-ab50-a7ffc827615f"), new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), null, "Место работы/учебы", 6, "Название организации", new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("5e1f62a7-077d-4be2-873d-1f25fcb28e49"), new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), null, "ФИО", 1, "Иванов Иван Иванович", new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("67d8bf97-d21b-4201-b24b-4d3120125188"), new Guid("c70a6377-6f01-4e51-9712-ae0091c20735"), null, "Научная специальность (по классификации ВАК)", 17, "Введите научную специальность (по классификации ВАК)", new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("8e541440-3a07-4a19-b2a4-662acf9962ae"), new Guid("c70a6377-6f01-4e51-9712-ae0091c20735"), null, "Ученое звание", 15, "Выберите ученое звание", new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("a9893f83-e3a4-4838-a737-cc7f3fc23b1a"), new Guid("c70a6377-6f01-4e51-9712-ae0091c20735"), null, "Ученая степень", 16, "Выберите ученую степень", new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("aad9c6f3-c4a6-45f1-9d27-880c320bfdf8"), new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", "Защитившиеся кадидаты наук", 18, "Введите количество", new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("b7ab48b3-3bca-4a34-bd35-dfcf37a20e56"), new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), null, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("bc37c186-7915-4ded-9d01-97ad41fed6f7"), new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), null, "Электронная почта", 5, "user@example.com", new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("bd012f39-f090-4e02-9b4d-74af749e26ee"), new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"), null, "Защитившиеся специалисты", 21, "Введите количество", new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("c607cc48-08ff-4d77-a964-b09e7d519958"), new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), null, "Должность", 9, "Введите свою должность в организации", new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("c9631aa3-d248-49ef-bdff-caf3f5ca9c87"), new Guid("4cfe3b46-0b4a-4e5b-acd2-de25a84d8890"), null, "Защитившиеся доктора наук", 24, "Введите количество", new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("d1c7d4f9-6a7c-4026-9344-8f57f89941c2"), new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"), null, "Защитившиеся доктора наук", 19, "Введите количество", new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("d1f6648a-1ef0-4d1c-a04c-730c8ed6ecf5"), new Guid("4cfe3b46-0b4a-4e5b-acd2-de25a84d8890"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", "Защитившиеся кандидаты наук", 23, "Введите количество", new Guid("949950d2-f19f-4dde-92b5-7459198f5977") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("3f20f455-02c2-4732-89e8-bd4fc906e3c0"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") },
                    { new Guid("3f20f455-02c2-4732-89e8-bd4fc906e3c0"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") },
                    { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") },
                    { new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") },
                    { new Guid("a778d3ea-0f14-476b-a871-1d7959a98873"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") },
                    { new Guid("a778d3ea-0f14-476b-a871-1d7959a98873"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") },
                    { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") },
                    { new Guid("d8db424c-55fd-4139-8526-7a6bb3e7851d"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") },
                    { new Guid("d8db424c-55fd-4139-8526-7a6bb3e7851d"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") },
                    { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("387e4122-1139-4d62-846e-bbac8ecf9a5b") },
                    { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("ee91728c-e171-4983-b240-012b3c619675") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0b93bf18-38bb-4f00-844a-1631b6ec3da1"), new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"), "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("25251225-46b0-4fd7-af00-96ab43f52e4d"), new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"), "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 },
                    { new Guid("2dded36e-bb55-4ecb-86d0-2e0cdb7c28b0"), new Guid("4cfe3b46-0b4a-4e5b-acd2-de25a84d8890"), "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("3e212b16-db45-43f4-91a3-301516b860b0"), new Guid("5c7954fe-4de3-4e02-b50a-28a7913d1494"), "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("410b3734-1ae7-4fbe-84c2-a2db6bc07775"), new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"), "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("559e192f-a642-48c9-8130-f0bfad382c5e"), new Guid("4cfe3b46-0b4a-4e5b-acd2-de25a84d8890"), "Персональные идентификаторы и показатели", 10 },
                    { new Guid("ae7f2d02-e119-482a-a4d3-d32b625f3abe"), new Guid("4cfe3b46-0b4a-4e5b-acd2-de25a84d8890"), "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("b3161850-35ce-4bc3-a172-f6c94ef2544d"), new Guid("4cfe3b46-0b4a-4e5b-acd2-de25a84d8890"), "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("d3af0819-e1da-4add-a7b1-be5d79fcddc0"), new Guid("5c7954fe-4de3-4e02-b50a-28a7913d1494"), "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("da700baf-0cde-46b0-bfd9-4e7474e1d61b"), new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"), "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("dc927d3e-935e-48ec-9b6c-7800cd2e30ce"), new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"), "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("f04db9cf-5172-4b43-975e-a791057e9c84"), new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"), "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("f762c787-82cf-4ba1-9d28-12ebcc732cc1"), new Guid("4cfe3b46-0b4a-4e5b-acd2-de25a84d8890"), "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("04f93fac-064e-4826-bab9-a91d223999f9"), "Название конкурса/премии", 2, new Guid("da700baf-0cde-46b0-bfd9-4e7474e1d61b"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("0edeb934-3423-4d91-8fca-cb0493b6c353"), "Практические занятия (час.)", 4, new Guid("410b3734-1ae7-4fbe-84c2-a2db6bc07775"), new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("16a3266c-40c4-4351-8df5-1efaf3468474"), "Издательство, год", 6, new Guid("25251225-46b0-4fd7-af00-96ab43f52e4d"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("1f8e9528-98b3-41bc-9534-1458018194f2"), "Награда", 4, new Guid("3e212b16-db45-43f4-91a3-301516b860b0"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("23a86912-cea3-46af-8ae4-ee8901c086a9"), "Статус (руководитель/исполнитель)", 4, new Guid("ae7f2d02-e119-482a-a4d3-d32b625f3abe"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("2a83b5be-2523-4805-8ca4-a4d11e8bd2fd"), "Вид (лекции, лабораторные)", 2, new Guid("0b93bf18-38bb-4f00-844a-1631b6ec3da1"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("3302c50f-3652-49de-88f1-a9916a0be733"), "Год", 3, new Guid("da700baf-0cde-46b0-bfd9-4e7474e1d61b"), new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("3e25e19f-6798-42ac-b619-960cc5305dd6"), "Название дисциплины", 1, new Guid("0b93bf18-38bb-4f00-844a-1631b6ec3da1"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("3e9cb301-3c7a-4b8e-b4a1-40ccba124c80"), "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("da700baf-0cde-46b0-bfd9-4e7474e1d61b"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("3fee8691-e925-45a6-be5d-33d9c70d4fce"), "Номер РИД", 4, new Guid("2dded36e-bb55-4ecb-86d0-2e0cdb7c28b0"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("44331387-0714-4808-886f-2e9a24e4f99e"), "Год", 4, new Guid("dc927d3e-935e-48ec-9b6c-7800cd2e30ce"), new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("4488fbc6-073f-4d6b-b9bf-df8726dc70f7"), "Название курса", 1, new Guid("dc927d3e-935e-48ec-9b6c-7800cd2e30ce"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("464f2f11-cf44-446d-9d58-aa86aefc4da9"), "Язык преподавания (русск./англ./др.)", 2, new Guid("410b3734-1ae7-4fbe-84c2-a2db6bc07775"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("4f5c4fc9-7b31-4053-a552-1313e032573a"), "Наименование курса", 1, new Guid("410b3734-1ae7-4fbe-84c2-a2db6bc07775"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("508d1d33-dbf5-4d21-9ca7-3240cb5301b2"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("ae7f2d02-e119-482a-a4d3-d32b625f3abe"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("54e3326a-caad-44eb-b4ff-dd9640369d1a"), "Год", 1, new Guid("3e212b16-db45-43f4-91a3-301516b860b0"), new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("55fd0d1d-4532-4445-8331-3f6eea5a1e0a"), "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("f04db9cf-5172-4b43-975e-a791057e9c84"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("5dd8eeca-b357-4fb3-bad2-b198a48f1dfd"), "Соавторы", 3, new Guid("25251225-46b0-4fd7-af00-96ab43f52e4d"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("5e7c7edb-f268-47af-be14-a4136d4e6e02"), "Количество часов", 4, new Guid("f04db9cf-5172-4b43-975e-a791057e9c84"), new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("63eb8648-25c2-48c5-8b9e-49b3e8cb8861"), "ФИО", 1, new Guid("da700baf-0cde-46b0-bfd9-4e7474e1d61b"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("65b1a474-81ac-4058-a53e-70ab52daae57"), "Название статьи", 1, new Guid("b3161850-35ce-4bc3-a172-f6c94ef2544d"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("6d4937bc-93ce-472e-adf1-10327f6424a9"), "Название организации в которую внедрена разработка", 3, new Guid("f762c787-82cf-4ba1-9d28-12ebcc732cc1"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("777327ec-3094-4b98-ad47-1cca1f089d3e"), "Статус конкурса", 3, new Guid("3e212b16-db45-43f4-91a3-301516b860b0"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("7e017f64-12b0-46ce-9b3b-8c5e7d34637e"), "Название разработки", 2, new Guid("f762c787-82cf-4ba1-9d28-12ebcc732cc1"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("7e7073b0-b9b8-4522-97c7-becef935e221"), "Индекс Хирша (за все время)", 5, new Guid("559e192f-a642-48c9-8130-f0bfad382c5e"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("7f376237-660e-4ebc-b7d2-077688e1d2b6"), "Издание, год", 4, new Guid("b3161850-35ce-4bc3-a172-f6c94ef2544d"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("825f3c89-8e6e-4f8a-9c2e-c2999b91aae7"), "Количество печатных листов", 4, new Guid("25251225-46b0-4fd7-af00-96ab43f52e4d"), new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("87950d2f-2ac6-4fa9-b5bc-342f2afcbcf8"), "Количество цитирований", 4, new Guid("559e192f-a642-48c9-8130-f0bfad382c5e"), new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("88a0a28a-7abc-4bff-a5e9-0d8464a6e86f"), "Вид", 1, new Guid("2dded36e-bb55-4ecb-86d0-2e0cdb7c28b0"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("92c0f73a-3885-4bbb-99c8-6a1fbc0a8bb4"), "Лекции (час.)", 3, new Guid("410b3734-1ae7-4fbe-84c2-a2db6bc07775"), new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("97058987-6a0e-470c-9f45-16b2263bcfaa"), "Вид деятельности (преподавательская)", 3, new Guid("f04db9cf-5172-4b43-975e-a791057e9c84"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("9789cbb1-49c6-4d27-be49-74e93cbd7e69"), "Вид", 1, new Guid("f762c787-82cf-4ba1-9d28-12ebcc732cc1"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("99ec6ad2-4d4b-418e-9029-42787a8351a6"), "Название документа, реквизиты", 1, new Guid("d3af0819-e1da-4add-a7b1-be5d79fcddc0"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("9d1243bb-aa12-4082-9dea-e06bbb4602fa"), "Сумма финансирования (тыс. руб.)", 2, new Guid("ae7f2d02-e119-482a-a4d3-d32b625f3abe"), new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("a79db530-9a86-4797-8155-c5836e718bca"), "Соавторы", 2, new Guid("dc927d3e-935e-48ec-9b6c-7800cd2e30ce"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("afd02925-e8ee-4eec-9e16-33cd7a9787f0"), "Название организации/должность/ставка", 1, new Guid("f04db9cf-5172-4b43-975e-a791057e9c84"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("b30201ef-8d45-4940-856b-d689eb07446b"), "Вид публикации", 1, new Guid("25251225-46b0-4fd7-af00-96ab43f52e4d"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("b581361f-3371-434f-878e-a5da5b440e15"), "Наличие грифа", 5, new Guid("25251225-46b0-4fd7-af00-96ab43f52e4d"), new Guid("7aa56c88-0c1c-4740-87ad-27bed2fa1f39") },
                    { new Guid("b73a7491-6973-4a9b-a5f7-a6431d936972"), "Ссылка", 5, new Guid("3e212b16-db45-43f4-91a3-301516b860b0"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("c19b80dd-9428-4c34-ac6a-7a7386f72b38"), "Ссылка на платформу", 3, new Guid("dc927d3e-935e-48ec-9b6c-7800cd2e30ce"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("c1c6c9d0-a21d-4832-9707-41435dffeb32"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("da700baf-0cde-46b0-bfd9-4e7474e1d61b"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("c20a72a2-b55e-47dd-b7e9-46d613ed432f"), "Количество публикаций в БАЗЕ", 3, new Guid("559e192f-a642-48c9-8130-f0bfad382c5e"), new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("cef066a7-38c6-4f27-a96a-0ac87c171f6c"), "Год получения документа", 2, new Guid("d3af0819-e1da-4add-a7b1-be5d79fcddc0"), new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("cf1049ef-0ebd-4a8d-b35a-f917fbf6a1e7"), "Название НИР/НИОКР", 1, new Guid("ae7f2d02-e119-482a-a4d3-d32b625f3abe"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("d1164ef2-3275-40bc-aa7b-6fdeb670fc19"), "Название", 2, new Guid("2dded36e-bb55-4ecb-86d0-2e0cdb7c28b0"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("d6d1ad37-9266-421f-a170-eb20cece8883"), "ФИО соавторов", 3, new Guid("2dded36e-bb55-4ecb-86d0-2e0cdb7c28b0"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("df34a8d2-b2b4-4951-8b81-0b81ef22668c"), "Название конкурса", 2, new Guid("3e212b16-db45-43f4-91a3-301516b860b0"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("e4cb315f-e615-47f0-94af-255adfbbec3d"), "Идентификатор", 2, new Guid("559e192f-a642-48c9-8130-f0bfad382c5e"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("e51edb87-74e9-43e6-a428-01ddc4004549"), "Период выполнения", 3, new Guid("ae7f2d02-e119-482a-a4d3-d32b625f3abe"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("f390b27f-0bc4-4f5a-846b-0d36f53d8d33"), "Соавторы", 2, new Guid("b3161850-35ce-4bc3-a172-f6c94ef2544d"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("f3910695-535e-489e-a5eb-9d5db9ad417f"), "Тип идентификатора", 1, new Guid("559e192f-a642-48c9-8130-f0bfad382c5e"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("f7827f0e-94cf-4549-838b-3918619fbfdc"), "Название", 2, new Guid("25251225-46b0-4fd7-af00-96ab43f52e4d"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") },
                    { new Guid("feedcafb-0c7f-4cec-a6b0-e05af1c85b05"), "Итого (час.)", 5, new Guid("410b3734-1ae7-4fbe-84c2-a2db6bc07775"), new Guid("949950d2-f19f-4dde-92b5-7459198f5977") },
                    { new Guid("ffa47711-6897-4d9f-99f1-2e3de8eff27e"), "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("b3161850-35ce-4bc3-a172-f6c94ef2544d"), new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("00fc07ae-ee3b-4170-ac2e-92a884f93af8"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("0a7f40a6-bec6-4fbe-9e1b-c838b3f05b01"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("15ebde32-243b-461e-aff6-d99289966b51"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("1e32053a-1da4-485e-8f79-e33e1acea171"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("2a4b4b10-eacc-46f9-b8c8-9e8f066609eb"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("2f716f8b-5530-4028-b45c-c1d9e2caefdc"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("37b7b6c1-a0d9-43d7-b085-765aef60b4de"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("3b46b9cf-1eeb-4c55-9b63-74c351e0baee"), new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c") },
                    { new Guid("3ba4d37c-554a-497a-ba6d-c28bf30a5d2d"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("43a085ca-f3f0-4e35-972b-2c6aa03caf60"), new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c") },
                    { new Guid("4c7f221f-861d-43e3-adb7-b71e571fba85"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("514ff213-8435-4250-ab50-a7ffc827615f"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("5e1f62a7-077d-4be2-873d-1f25fcb28e49"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("67d8bf97-d21b-4201-b24b-4d3120125188"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("8e541440-3a07-4a19-b2a4-662acf9962ae"), new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2") },
                    { new Guid("8e541440-3a07-4a19-b2a4-662acf9962ae"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("8e541440-3a07-4a19-b2a4-662acf9962ae"), new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8") },
                    { new Guid("a9893f83-e3a4-4838-a737-cc7f3fc23b1a"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("aad9c6f3-c4a6-45f1-9d27-880c320bfdf8"), new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c") },
                    { new Guid("b7ab48b3-3bca-4a34-bd35-dfcf37a20e56"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("bc37c186-7915-4ded-9d01-97ad41fed6f7"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("bd012f39-f090-4e02-9b4d-74af749e26ee"), new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c") },
                    { new Guid("c607cc48-08ff-4d77-a964-b09e7d519958"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") },
                    { new Guid("c9631aa3-d248-49ef-bdff-caf3f5ca9c87"), new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8") },
                    { new Guid("d1c7d4f9-6a7c-4026-9344-8f57f89941c2"), new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c") },
                    { new Guid("d1f6648a-1ef0-4d1c-a04c-730c8ed6ecf5"), new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("410b3734-1ae7-4fbe-84c2-a2db6bc07775") },
                    { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("da700baf-0cde-46b0-bfd9-4e7474e1d61b") },
                    { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("dc927d3e-935e-48ec-9b6c-7800cd2e30ce") },
                    { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("f04db9cf-5172-4b43-975e-a791057e9c84") },
                    { new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2"), new Guid("3e212b16-db45-43f4-91a3-301516b860b0") },
                    { new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2"), new Guid("d3af0819-e1da-4add-a7b1-be5d79fcddc0") },
                    { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("2dded36e-bb55-4ecb-86d0-2e0cdb7c28b0") },
                    { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("d3af0819-e1da-4add-a7b1-be5d79fcddc0") },
                    { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("f762c787-82cf-4ba1-9d28-12ebcc732cc1") },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("3e212b16-db45-43f4-91a3-301516b860b0") },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("559e192f-a642-48c9-8130-f0bfad382c5e") },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("ae7f2d02-e119-482a-a4d3-d32b625f3abe") },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("b3161850-35ce-4bc3-a172-f6c94ef2544d") },
                    { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("0b93bf18-38bb-4f00-844a-1631b6ec3da1") },
                    { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("25251225-46b0-4fd7-af00-96ab43f52e4d") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("18615aeb-b454-4868-85e9-5797538ed87a"), null, "Баллы за труды без грифа и без соавторства:", 10, new Guid("25251225-46b0-4fd7-af00-96ab43f52e4d") },
                    { new Guid("289dd3e9-0c05-4128-9943-54c63a9a597e"), null, "Баллы за научные публикации:", 16, new Guid("b3161850-35ce-4bc3-a172-f6c94ef2544d") },
                    { new Guid("3b444141-0d8c-4493-a6a6-8993eb6ba2a1"), null, "Баллы за труды с грифом и без соавторства:", 8, new Guid("25251225-46b0-4fd7-af00-96ab43f52e4d") },
                    { new Guid("3f37876e-a2ee-430d-b075-09e4e01ced6c"), null, "Баллы по базе РИНЦ:", 18, new Guid("559e192f-a642-48c9-8130-f0bfad382c5e") },
                    { new Guid("48b8ce69-8ee6-4b8d-9018-467664160cd4"), new Guid("d1c7d4f9-6a7c-4026-9344-8f57f89941c2"), "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("5b6cad43-01bd-4d93-ac8c-38a09ad735ca"), new Guid("aad9c6f3-c4a6-45f1-9d27-880c320bfdf8"), "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("5f38e6fa-cca5-4c4a-9040-f596829e9497"), new Guid("8e541440-3a07-4a19-b2a4-662acf9962ae"), "Баллы за ученое звание:", 13, null },
                    { new Guid("748dcc3d-ced5-44da-a574-4a91b1310a05"), new Guid("c9631aa3-d248-49ef-bdff-caf3f5ca9c87"), "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("7bd64436-8fee-4e38-a1c3-47191850a380"), null, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("0b93bf18-38bb-4f00-844a-1631b6ec3da1") },
                    { new Guid("8017a83f-cdcd-4fb6-96ee-9b378986b2f5"), null, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("dc927d3e-935e-48ec-9b6c-7800cd2e30ce") },
                    { new Guid("8dd7c90d-3627-4d47-9677-7ab750e64dc3"), null, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("da700baf-0cde-46b0-bfd9-4e7474e1d61b") },
                    { new Guid("95649e51-a165-47b1-b0f8-8b097cd838d0"), null, "Баллы за количество разработок:", 24, new Guid("f762c787-82cf-4ba1-9d28-12ebcc732cc1") },
                    { new Guid("9e45928e-8164-4c60-9d60-b49448eaf3b2"), null, "Баллы за награды:", 14, new Guid("3e212b16-db45-43f4-91a3-301516b860b0") },
                    { new Guid("b4d1a35b-1adf-45e6-b024-ecc5edc5f4aa"), null, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("2dded36e-bb55-4ecb-86d0-2e0cdb7c28b0") },
                    { new Guid("b8243114-17b0-4b55-aca7-24a828b44eb7"), null, "Баллы за труды с грифом в соавторстве:", 9, new Guid("25251225-46b0-4fd7-af00-96ab43f52e4d") },
                    { new Guid("c213528e-9bf0-42e8-87dc-9859fb9c3f06"), null, "Баллы за профессиональное развитие:", 15, new Guid("d3af0819-e1da-4add-a7b1-be5d79fcddc0") },
                    { new Guid("c5e96a3f-5994-409f-84d9-d793a625f10a"), null, "Баллы за труды без грифа в соавторстве:", 11, new Guid("25251225-46b0-4fd7-af00-96ab43f52e4d") },
                    { new Guid("cd0e4c54-0e79-4ba7-bc92-26899e10cff6"), null, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("ae7f2d02-e119-482a-a4d3-d32b625f3abe") },
                    { new Guid("cd1dc253-c7a2-4f31-9347-aa978d9cf8d1"), null, "Баллы по базе Scopus:", 17, new Guid("559e192f-a642-48c9-8130-f0bfad382c5e") },
                    { new Guid("e2c5b831-fd49-4917-9816-6d47fd719f90"), new Guid("d1f6648a-1ef0-4d1c-a04c-730c8ed6ecf5"), "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("ea8d3556-6730-4140-8c7f-e0c1d9f127c1"), null, "Баллы за объем учебной нагрузки:", 1, new Guid("410b3734-1ae7-4fbe-84c2-a2db6bc07775") },
                    { new Guid("eb282122-e827-4e26-af18-325bbe0766b8"), null, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("ae7f2d02-e119-482a-a4d3-d32b625f3abe") },
                    { new Guid("eda7c9c2-0016-4cec-b724-feabadcf6141"), null, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("410b3734-1ae7-4fbe-84c2-a2db6bc07775") },
                    { new Guid("ede72596-4da4-4261-8294-0d1d6a9c88c7"), new Guid("43a085ca-f3f0-4e35-972b-2c6aa03caf60"), "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("1ddae28a-cb38-429a-b53a-1f5650b316fa"), null, new Guid("8e541440-3a07-4a19-b2a4-662acf9962ae"), "Профессор" },
                    { new Guid("1e5b7e40-5c0f-4bb3-8df2-943cc1399600"), null, new Guid("4c7f221f-861d-43e3-adb7-b71e571fba85"), "Аспиранты, адъюнкты, ординаторы, ассистенты-стажеры, не имеющие ученой степени" },
                    { new Guid("464faf9a-c56f-474f-8df4-818ad6b9837d"), null, new Guid("8e541440-3a07-4a19-b2a4-662acf9962ae"), "Доцент" },
                    { new Guid("6852cb7d-df71-4873-8ed3-7ce934dee07a"), null, new Guid("2a4b4b10-eacc-46f9-b8c8-9e8f066609eb"), "НЕДРОПОЛЬЗОВАНИЕ И ГОРНЫЕ НАУКИ" },
                    { new Guid("7547586c-4674-44f2-913a-319d2cd04016"), null, new Guid("2a4b4b10-eacc-46f9-b8c8-9e8f066609eb"), "ПРИКЛАДНАЯ ГЕОЛОГИЯ, ГОРНОЕ ДЕЛО, НЕФТЕГАЗОВОЕ ДЕЛО И ГЕОДЕЗИЯ" },
                    { new Guid("80e092b5-39c5-4733-ab39-ff634b94090a"), null, new Guid("2a4b4b10-eacc-46f9-b8c8-9e8f066609eb"), "АРХИТЕКТУРА" },
                    { new Guid("8b1896fd-263c-414e-94e7-4c9e96f30892"), null, new Guid("2a4b4b10-eacc-46f9-b8c8-9e8f066609eb"), "ЭЛЕКТРО- И ТЕПЛОЭНЕРГЕТИКА" },
                    { new Guid("8cdc0bfd-971f-49ce-9bd9-715f867ad667"), null, new Guid("8e541440-3a07-4a19-b2a4-662acf9962ae"), "Нет" },
                    { new Guid("92979e51-1297-4bda-8576-95acf7d64475"), null, new Guid("2a4b4b10-eacc-46f9-b8c8-9e8f066609eb"), "ТЕХНИКА И ТЕХНОЛОГИИ СТРОИТЕЛЬСТВА" },
                    { new Guid("b962f608-875a-4be8-81b3-40983d3712d3"), null, new Guid("4c7f221f-861d-43e3-adb7-b71e571fba85"), "Имеющие ученую степень доктора наук" },
                    { new Guid("bc3e1a44-1669-46e7-9084-d52f8344c779"), null, new Guid("2a4b4b10-eacc-46f9-b8c8-9e8f066609eb"), "СТРОИТЕЛЬСТВО И АРХИТЕКТУРА" },
                    { new Guid("dfa33f5b-63f3-41fa-b38b-7f33bbf2b732"), null, new Guid("4c7f221f-861d-43e3-adb7-b71e571fba85"), "Докторанты, имеющие ученую степень кандидата наук" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("48b8ce69-8ee6-4b8d-9018-467664160cd4") },
                    { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("5b6cad43-01bd-4d93-ac8c-38a09ad735ca") },
                    { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("8017a83f-cdcd-4fb6-96ee-9b378986b2f5") },
                    { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("8dd7c90d-3627-4d47-9677-7ab750e64dc3") },
                    { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("ea8d3556-6730-4140-8c7f-e0c1d9f127c1") },
                    { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("eda7c9c2-0016-4cec-b724-feabadcf6141") },
                    { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("ede72596-4da4-4261-8294-0d1d6a9c88c7") },
                    { new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2"), new Guid("5f38e6fa-cca5-4c4a-9040-f596829e9497") },
                    { new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2"), new Guid("9e45928e-8164-4c60-9d60-b49448eaf3b2") },
                    { new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2"), new Guid("c213528e-9bf0-42e8-87dc-9859fb9c3f06") },
                    { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("95649e51-a165-47b1-b0f8-8b097cd838d0") },
                    { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("b4d1a35b-1adf-45e6-b024-ecc5edc5f4aa") },
                    { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("c213528e-9bf0-42e8-87dc-9859fb9c3f06") },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("289dd3e9-0c05-4128-9943-54c63a9a597e") },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("3f37876e-a2ee-430d-b075-09e4e01ced6c") },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("5f38e6fa-cca5-4c4a-9040-f596829e9497") },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("748dcc3d-ced5-44da-a574-4a91b1310a05") },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("9e45928e-8164-4c60-9d60-b49448eaf3b2") },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("cd0e4c54-0e79-4ba7-bc92-26899e10cff6") },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("cd1dc253-c7a2-4f31-9347-aa978d9cf8d1") },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("e2c5b831-fd49-4917-9816-6d47fd719f90") },
                    { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("eb282122-e827-4e26-af18-325bbe0766b8") },
                    { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("18615aeb-b454-4868-85e9-5797538ed87a") },
                    { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("3b444141-0d8c-4493-a6a6-8993eb6ba2a1") },
                    { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("7bd64436-8fee-4e38-a1c3-47191850a380") },
                    { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("b8243114-17b0-4b55-aca7-24a828b44eb7") },
                    { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("c5e96a3f-5994-409f-84d9-d793a625f10a") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("1ba38f1e-c007-47a1-abd9-a78885446012"), new Guid("88a0a28a-7abc-4bff-a5e9-0d8464a6e86f"), null, "Изобретение" },
                    { new Guid("60957dd3-fa55-4983-8d5d-b2d3b0f64bdf"), new Guid("9789cbb1-49c6-4d27-be49-74e93cbd7e69"), null, "База данных" },
                    { new Guid("78590a4a-04ed-45ec-9ad4-f49075462492"), new Guid("777327ec-3094-4b98-ad47-1cca1f089d3e"), null, "Международный" },
                    { new Guid("80930cc5-c2b7-4c1d-88ce-fd6ce0a85b7a"), new Guid("88a0a28a-7abc-4bff-a5e9-0d8464a6e86f"), null, "База данных" },
                    { new Guid("824ff928-28f0-4f66-8a04-94890abb761a"), new Guid("2a83b5be-2523-4805-8ca4-a4d11e8bd2fd"), null, "Лабораторные" },
                    { new Guid("98de9ce3-81d9-4f54-b0d0-b1b8db00f6ba"), new Guid("23a86912-cea3-46af-8ae4-ee8901c086a9"), null, "Исполнитель" },
                    { new Guid("a6d6a8fc-05f1-42ef-bdd0-55943b51965b"), new Guid("9789cbb1-49c6-4d27-be49-74e93cbd7e69"), null, "Полезная модель" },
                    { new Guid("ab910530-cc8f-4db1-a37a-0f984df84c0c"), new Guid("777327ec-3094-4b98-ad47-1cca1f089d3e"), null, "Всероссийский" },
                    { new Guid("b1466f38-bd26-456d-bb1d-e7b427e1345d"), new Guid("9789cbb1-49c6-4d27-be49-74e93cbd7e69"), null, "Изобретение" },
                    { new Guid("c9b59430-19ed-4ceb-89f5-69d0c00137b8"), new Guid("88a0a28a-7abc-4bff-a5e9-0d8464a6e86f"), null, "Полезная модель" },
                    { new Guid("e4024ff8-a688-43f2-acea-3ef15ba73d0b"), new Guid("b30201ef-8d45-4940-856b-d689eb07446b"), null, "Учебник" },
                    { new Guid("e675da6f-a162-4710-bbfe-1882e8b95acf"), new Guid("2a83b5be-2523-4805-8ca4-a4d11e8bd2fd"), null, "Лекции" },
                    { new Guid("eb16f173-fd2c-4161-9311-8778fb147845"), new Guid("777327ec-3094-4b98-ad47-1cca1f089d3e"), null, "Региональный" },
                    { new Guid("ec6e176b-43d7-41c5-b7b6-87f6ab94e01b"), new Guid("b30201ef-8d45-4940-856b-d689eb07446b"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("f32ae4c6-2559-488d-a002-35026c033e4c"), new Guid("b30201ef-8d45-4940-856b-d689eb07446b"), null, "Монография" },
                    { new Guid("f734ad5e-81ef-42f7-9c25-4d028557c908"), new Guid("23a86912-cea3-46af-8ae4-ee8901c086a9"), null, "Руководитель" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("04f93fac-064e-4826-bab9-a91d223999f9"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("0edeb934-3423-4d91-8fca-cb0493b6c353"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("16a3266c-40c4-4351-8df5-1efaf3468474"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("1f8e9528-98b3-41bc-9534-1458018194f2"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("3302c50f-3652-49de-88f1-a9916a0be733"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("3e25e19f-6798-42ac-b619-960cc5305dd6"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("3e9cb301-3c7a-4b8e-b4a1-40ccba124c80"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("3fee8691-e925-45a6-be5d-33d9c70d4fce"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("44331387-0714-4808-886f-2e9a24e4f99e"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("4488fbc6-073f-4d6b-b9bf-df8726dc70f7"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("464f2f11-cf44-446d-9d58-aa86aefc4da9"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("4f5c4fc9-7b31-4053-a552-1313e032573a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("508d1d33-dbf5-4d21-9ca7-3240cb5301b2"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("54e3326a-caad-44eb-b4ff-dd9640369d1a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("55fd0d1d-4532-4445-8331-3f6eea5a1e0a"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("5dd8eeca-b357-4fb3-bad2-b198a48f1dfd"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("5e7c7edb-f268-47af-be14-a4136d4e6e02"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("63eb8648-25c2-48c5-8b9e-49b3e8cb8861"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("65b1a474-81ac-4058-a53e-70ab52daae57"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("6d4937bc-93ce-472e-adf1-10327f6424a9"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("7e017f64-12b0-46ce-9b3b-8c5e7d34637e"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("7e7073b0-b9b8-4522-97c7-becef935e221"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("7f376237-660e-4ebc-b7d2-077688e1d2b6"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("825f3c89-8e6e-4f8a-9c2e-c2999b91aae7"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("87950d2f-2ac6-4fa9-b5bc-342f2afcbcf8"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("92c0f73a-3885-4bbb-99c8-6a1fbc0a8bb4"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("97058987-6a0e-470c-9f45-16b2263bcfaa"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("99ec6ad2-4d4b-418e-9029-42787a8351a6"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9d1243bb-aa12-4082-9dea-e06bbb4602fa"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("a79db530-9a86-4797-8155-c5836e718bca"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("afd02925-e8ee-4eec-9e16-33cd7a9787f0"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b581361f-3371-434f-878e-a5da5b440e15"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b73a7491-6973-4a9b-a5f7-a6431d936972"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("c19b80dd-9428-4c34-ac6a-7a7386f72b38"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("c1c6c9d0-a21d-4832-9707-41435dffeb32"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("c20a72a2-b55e-47dd-b7e9-46d613ed432f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("cef066a7-38c6-4f27-a96a-0ac87c171f6c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("cf1049ef-0ebd-4a8d-b35a-f917fbf6a1e7"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("d1164ef2-3275-40bc-aa7b-6fdeb670fc19"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("d6d1ad37-9266-421f-a170-eb20cece8883"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("df34a8d2-b2b4-4951-8b81-0b81ef22668c"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("e4cb315f-e615-47f0-94af-255adfbbec3d"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("e51edb87-74e9-43e6-a428-01ddc4004549"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("f390b27f-0bc4-4f5a-846b-0d36f53d8d33"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("f3910695-535e-489e-a5eb-9d5db9ad417f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("f7827f0e-94cf-4549-838b-3918619fbfdc"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("feedcafb-0c7f-4cec-a6b0-e05af1c85b05"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("ffa47711-6897-4d9f-99f1-2e3de8eff27e"));

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("4cfe3b46-0b4a-4e5b-acd2-de25a84d8890"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("5c7954fe-4de3-4e02-b50a-28a7913d1494"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("5c7954fe-4de3-4e02-b50a-28a7913d1494"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("c70a6377-6f01-4e51-9712-ae0091c20735"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") });

            migrationBuilder.DeleteData(
                table: "EditBlockTrack",
                keyColumns: new[] { "EditBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("c70a6377-6f01-4e51-9712-ae0091c20735"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("00fc07ae-ee3b-4170-ac2e-92a884f93af8"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("0a7f40a6-bec6-4fbe-9e1b-c838b3f05b01"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("15ebde32-243b-461e-aff6-d99289966b51"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("1e32053a-1da4-485e-8f79-e33e1acea171"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("2a4b4b10-eacc-46f9-b8c8-9e8f066609eb"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("2f716f8b-5530-4028-b45c-c1d9e2caefdc"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("37b7b6c1-a0d9-43d7-b085-765aef60b4de"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("3b46b9cf-1eeb-4c55-9b63-74c351e0baee"), new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("3ba4d37c-554a-497a-ba6d-c28bf30a5d2d"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("43a085ca-f3f0-4e35-972b-2c6aa03caf60"), new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("4c7f221f-861d-43e3-adb7-b71e571fba85"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("514ff213-8435-4250-ab50-a7ffc827615f"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("5e1f62a7-077d-4be2-873d-1f25fcb28e49"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("67d8bf97-d21b-4201-b24b-4d3120125188"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("8e541440-3a07-4a19-b2a4-662acf9962ae"), new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("8e541440-3a07-4a19-b2a4-662acf9962ae"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("8e541440-3a07-4a19-b2a4-662acf9962ae"), new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("a9893f83-e3a4-4838-a737-cc7f3fc23b1a"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("aad9c6f3-c4a6-45f1-9d27-880c320bfdf8"), new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("b7ab48b3-3bca-4a34-bd35-dfcf37a20e56"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("bc37c186-7915-4ded-9d01-97ad41fed6f7"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("bd012f39-f090-4e02-9b4d-74af749e26ee"), new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("c607cc48-08ff-4d77-a964-b09e7d519958"), new Guid("a778d3ea-0f14-476b-a871-1d7959a98873") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("c9631aa3-d248-49ef-bdff-caf3f5ca9c87"), new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("d1c7d4f9-6a7c-4026-9344-8f57f89941c2"), new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c") });

            migrationBuilder.DeleteData(
                table: "FieldMarkBlock",
                keyColumns: new[] { "FieldsId", "MarkBlocksId" },
                keyValues: new object[] { new Guid("d1f6648a-1ef0-4d1c-a04c-730c8ed6ecf5"), new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("410b3734-1ae7-4fbe-84c2-a2db6bc07775") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("da700baf-0cde-46b0-bfd9-4e7474e1d61b") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("dc927d3e-935e-48ec-9b6c-7800cd2e30ce") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("f04db9cf-5172-4b43-975e-a791057e9c84") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2"), new Guid("3e212b16-db45-43f4-91a3-301516b860b0") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2"), new Guid("d3af0819-e1da-4add-a7b1-be5d79fcddc0") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("2dded36e-bb55-4ecb-86d0-2e0cdb7c28b0") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("d3af0819-e1da-4add-a7b1-be5d79fcddc0") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("f762c787-82cf-4ba1-9d28-12ebcc732cc1") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("3e212b16-db45-43f4-91a3-301516b860b0") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("559e192f-a642-48c9-8130-f0bfad382c5e") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("ae7f2d02-e119-482a-a4d3-d32b625f3abe") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("b3161850-35ce-4bc3-a172-f6c94ef2544d") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("0b93bf18-38bb-4f00-844a-1631b6ec3da1") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTable",
                keyColumns: new[] { "MarkBlocksId", "TablesId" },
                keyValues: new object[] { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("25251225-46b0-4fd7-af00-96ab43f52e4d") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("3f20f455-02c2-4732-89e8-bd4fc906e3c0"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("3f20f455-02c2-4732-89e8-bd4fc906e3c0"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("a778d3ea-0f14-476b-a871-1d7959a98873"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("a778d3ea-0f14-476b-a871-1d7959a98873"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("d8db424c-55fd-4139-8526-7a6bb3e7851d"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("d8db424c-55fd-4139-8526-7a6bb3e7851d"), new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76") });

            migrationBuilder.DeleteData(
                table: "MarkBlockTrack",
                keyColumns: new[] { "MarkBlocksId", "TracksId" },
                keyValues: new object[] { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("010cda4f-c838-45e5-b907-8663fb9c550f") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("48b8ce69-8ee6-4b8d-9018-467664160cd4") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("5b6cad43-01bd-4d93-ac8c-38a09ad735ca") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("8017a83f-cdcd-4fb6-96ee-9b378986b2f5") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("8dd7c90d-3627-4d47-9677-7ab750e64dc3") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("ea8d3556-6730-4140-8c7f-e0c1d9f127c1") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("eda7c9c2-0016-4cec-b724-feabadcf6141") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"), new Guid("ede72596-4da4-4261-8294-0d1d6a9c88c7") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2"), new Guid("5f38e6fa-cca5-4c4a-9040-f596829e9497") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2"), new Guid("9e45928e-8164-4c60-9d60-b49448eaf3b2") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2"), new Guid("c213528e-9bf0-42e8-87dc-9859fb9c3f06") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("387e4122-1139-4d62-846e-bbac8ecf9a5b") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("95649e51-a165-47b1-b0f8-8b097cd838d0") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("b4d1a35b-1adf-45e6-b024-ecc5edc5f4aa") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("c213528e-9bf0-42e8-87dc-9859fb9c3f06") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("b1dee06a-4188-492c-84ce-7913f372c685"), new Guid("ee91728c-e171-4983-b240-012b3c619675") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("289dd3e9-0c05-4128-9943-54c63a9a597e") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("3f37876e-a2ee-430d-b075-09e4e01ced6c") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("5f38e6fa-cca5-4c4a-9040-f596829e9497") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("748dcc3d-ced5-44da-a574-4a91b1310a05") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("9e45928e-8164-4c60-9d60-b49448eaf3b2") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("cd0e4c54-0e79-4ba7-bc92-26899e10cff6") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("cd1dc253-c7a2-4f31-9347-aa978d9cf8d1") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("e2c5b831-fd49-4917-9816-6d47fd719f90") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"), new Guid("eb282122-e827-4e26-af18-325bbe0766b8") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("18615aeb-b454-4868-85e9-5797538ed87a") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("3b444141-0d8c-4493-a6a6-8993eb6ba2a1") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("7bd64436-8fee-4e38-a1c3-47191850a380") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("b8243114-17b0-4b55-aca7-24a828b44eb7") });

            migrationBuilder.DeleteData(
                table: "MarkMarkBlock",
                keyColumns: new[] { "MarkBlocksId", "MarksId" },
                keyValues: new object[] { new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"), new Guid("c5e96a3f-5994-409f-84d9-d793a625f10a") });

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("1ba38f1e-c007-47a1-abd9-a78885446012"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("1ddae28a-cb38-429a-b53a-1f5650b316fa"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("1e5b7e40-5c0f-4bb3-8df2-943cc1399600"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("464faf9a-c56f-474f-8df4-818ad6b9837d"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("60957dd3-fa55-4983-8d5d-b2d3b0f64bdf"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("6852cb7d-df71-4873-8ed3-7ce934dee07a"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("7547586c-4674-44f2-913a-319d2cd04016"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("78590a4a-04ed-45ec-9ad4-f49075462492"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("80930cc5-c2b7-4c1d-88ce-fd6ce0a85b7a"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("80e092b5-39c5-4733-ab39-ff634b94090a"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("824ff928-28f0-4f66-8a04-94890abb761a"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("8b1896fd-263c-414e-94e7-4c9e96f30892"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("8cdc0bfd-971f-49ce-9bd9-715f867ad667"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("92979e51-1297-4bda-8576-95acf7d64475"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("98de9ce3-81d9-4f54-b0d0-b1b8db00f6ba"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("a6d6a8fc-05f1-42ef-bdd0-55943b51965b"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("ab910530-cc8f-4db1-a37a-0f984df84c0c"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("b1466f38-bd26-456d-bb1d-e7b427e1345d"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("b962f608-875a-4be8-81b3-40983d3712d3"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("bc3e1a44-1669-46e7-9084-d52f8344c779"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("c9b59430-19ed-4ceb-89f5-69d0c00137b8"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("dfa33f5b-63f3-41fa-b38b-7f33bbf2b732"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("e4024ff8-a688-43f2-acea-3ef15ba73d0b"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("e675da6f-a162-4710-bbfe-1882e8b95acf"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("eb16f173-fd2c-4161-9311-8778fb147845"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("ec6e176b-43d7-41c5-b7b6-87f6ab94e01b"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("f32ae4c6-2559-488d-a002-35026c033e4c"));

            migrationBuilder.DeleteData(
                table: "SelectValues",
                keyColumn: "Id",
                keyValue: new Guid("f734ad5e-81ef-42f7-9c25-4d028557c908"));

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("e77c4be3-d425-473c-981f-c42b1cbc9975"));

            migrationBuilder.DeleteData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: new Guid("ffe3925f-656b-410c-8d38-a095bb6502ea"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("23a86912-cea3-46af-8ae4-ee8901c086a9"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("2a83b5be-2523-4805-8ca4-a4d11e8bd2fd"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("777327ec-3094-4b98-ad47-1cca1f089d3e"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("88a0a28a-7abc-4bff-a5e9-0d8464a6e86f"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("9789cbb1-49c6-4d27-be49-74e93cbd7e69"));

            migrationBuilder.DeleteData(
                table: "Columns",
                keyColumn: "Id",
                keyValue: new Guid("b30201ef-8d45-4940-856b-d689eb07446b"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("00fc07ae-ee3b-4170-ac2e-92a884f93af8"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("0a7f40a6-bec6-4fbe-9e1b-c838b3f05b01"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("15ebde32-243b-461e-aff6-d99289966b51"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("1e32053a-1da4-485e-8f79-e33e1acea171"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("2a4b4b10-eacc-46f9-b8c8-9e8f066609eb"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("2f716f8b-5530-4028-b45c-c1d9e2caefdc"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("37b7b6c1-a0d9-43d7-b085-765aef60b4de"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("3b46b9cf-1eeb-4c55-9b63-74c351e0baee"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("3ba4d37c-554a-497a-ba6d-c28bf30a5d2d"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("4c7f221f-861d-43e3-adb7-b71e571fba85"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("514ff213-8435-4250-ab50-a7ffc827615f"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("5e1f62a7-077d-4be2-873d-1f25fcb28e49"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("67d8bf97-d21b-4201-b24b-4d3120125188"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("a9893f83-e3a4-4838-a737-cc7f3fc23b1a"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("b7ab48b3-3bca-4a34-bd35-dfcf37a20e56"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("bc37c186-7915-4ded-9d01-97ad41fed6f7"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("bd012f39-f090-4e02-9b4d-74af749e26ee"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("c607cc48-08ff-4d77-a964-b09e7d519958"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("3f20f455-02c2-4732-89e8-bd4fc906e3c0"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("3f79240b-e499-4fc8-99c1-31ffe16b445c"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("8c61bb87-2a54-4a56-98d0-a85055e185f2"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("a778d3ea-0f14-476b-a871-1d7959a98873"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("b1dee06a-4188-492c-84ce-7913f372c685"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("bffe2502-8592-4cb6-8d37-fbea84f37bf8"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("d8db424c-55fd-4139-8526-7a6bb3e7851d"));

            migrationBuilder.DeleteData(
                table: "MarkBlocks",
                keyColumn: "Id",
                keyValue: new Guid("eb46bd9a-5ba8-4bae-999b-cb811d2c68ba"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("18615aeb-b454-4868-85e9-5797538ed87a"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("289dd3e9-0c05-4128-9943-54c63a9a597e"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("387e4122-1139-4d62-846e-bbac8ecf9a5b"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("3b444141-0d8c-4493-a6a6-8993eb6ba2a1"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("3f37876e-a2ee-430d-b075-09e4e01ced6c"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("48b8ce69-8ee6-4b8d-9018-467664160cd4"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("5b6cad43-01bd-4d93-ac8c-38a09ad735ca"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("5f38e6fa-cca5-4c4a-9040-f596829e9497"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("748dcc3d-ced5-44da-a574-4a91b1310a05"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("7bd64436-8fee-4e38-a1c3-47191850a380"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("8017a83f-cdcd-4fb6-96ee-9b378986b2f5"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("8dd7c90d-3627-4d47-9677-7ab750e64dc3"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("95649e51-a165-47b1-b0f8-8b097cd838d0"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("9e45928e-8164-4c60-9d60-b49448eaf3b2"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("b4d1a35b-1adf-45e6-b024-ecc5edc5f4aa"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("b8243114-17b0-4b55-aca7-24a828b44eb7"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("c213528e-9bf0-42e8-87dc-9859fb9c3f06"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("c5e96a3f-5994-409f-84d9-d793a625f10a"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("cd0e4c54-0e79-4ba7-bc92-26899e10cff6"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("cd1dc253-c7a2-4f31-9347-aa978d9cf8d1"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("e2c5b831-fd49-4917-9816-6d47fd719f90"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("ea8d3556-6730-4140-8c7f-e0c1d9f127c1"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("eb282122-e827-4e26-af18-325bbe0766b8"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("eda7c9c2-0016-4cec-b724-feabadcf6141"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("ede72596-4da4-4261-8294-0d1d6a9c88c7"));

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: new Guid("ee91728c-e171-4983-b240-012b3c619675"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("f04db9cf-5172-4b43-975e-a791057e9c84"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("010cda4f-c838-45e5-b907-8663fb9c550f"));

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: new Guid("9fe6316e-eecc-4d5b-97c6-08e7a5635f76"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("7aa56c88-0c1c-4740-87ad-27bed2fa1f39"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("7c8cddf5-1ca9-48ad-8ee9-efbb5c8b6da2"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("43a085ca-f3f0-4e35-972b-2c6aa03caf60"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("8e541440-3a07-4a19-b2a4-662acf9962ae"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("aad9c6f3-c4a6-45f1-9d27-880c320bfdf8"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("c9631aa3-d248-49ef-bdff-caf3f5ca9c87"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("d1c7d4f9-6a7c-4026-9344-8f57f89941c2"));

            migrationBuilder.DeleteData(
                table: "Fields",
                keyColumn: "Id",
                keyValue: new Guid("d1f6648a-1ef0-4d1c-a04c-730c8ed6ecf5"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0b93bf18-38bb-4f00-844a-1631b6ec3da1"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("25251225-46b0-4fd7-af00-96ab43f52e4d"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("2dded36e-bb55-4ecb-86d0-2e0cdb7c28b0"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("3e212b16-db45-43f4-91a3-301516b860b0"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("410b3734-1ae7-4fbe-84c2-a2db6bc07775"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("559e192f-a642-48c9-8130-f0bfad382c5e"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("ae7f2d02-e119-482a-a4d3-d32b625f3abe"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("b3161850-35ce-4bc3-a172-f6c94ef2544d"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("d3af0819-e1da-4add-a7b1-be5d79fcddc0"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("da700baf-0cde-46b0-bfd9-4e7474e1d61b"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("dc927d3e-935e-48ec-9b6c-7800cd2e30ce"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("f762c787-82cf-4ba1-9d28-12ebcc732cc1"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("b1f824fe-4ae7-48de-addc-d6111b1f04c8"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("4cfe3b46-0b4a-4e5b-acd2-de25a84d8890"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("5c7954fe-4de3-4e02-b50a-28a7913d1494"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("965c0833-ba26-4668-a049-3addf8eb13c0"));

            migrationBuilder.DeleteData(
                table: "EditBlocks",
                keyColumn: "Id",
                keyValue: new Guid("c70a6377-6f01-4e51-9712-ae0091c20735"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("3af7e6fd-8a2c-4bbd-8f02-f0ae7ae7edb9"));

            migrationBuilder.DeleteData(
                table: "ValueTypes",
                keyColumn: "Id",
                keyValue: new Guid("949950d2-f19f-4dde-92b5-7459198f5977"));

            migrationBuilder.DropColumn(
                name: "LastEmailSentDate",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0c8808c7-4274-4f10-a38c-486d0a76de75"), "Категория участников", 2 },
                    { new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), "Общая информация", 1 },
                    { new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"), "Деятельность", 4 },
                    { new Guid("8cd73dd8-f545-49d2-ad4b-94a184825a74"), "Деятельность", 5 },
                    { new Guid("bc562ed0-6d15-4ade-9f74-04bd750aa57e"), "Профессиональное развитие", 3 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0165f555-0787-4a87-8f3c-cf368193bab1"), "Основной", 1 },
                    { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), "Инновационная и иная деятельность", 6 },
                    { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), "Образовательная деятельность", 2 },
                    { new Guid("41a63948-a198-43c1-90f1-bec3431f613a"), "Профессиональные показатели", 4 },
                    { new Guid("4ec27e93-178c-479c-be65-21bedb251290"), "Итог", 8 },
                    { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), "Методическая деятельность", 3 },
                    { new Guid("77419d63-f392-4eae-baf0-4b85fe8e8d45"), "Конкурсная работа", 7 },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), "Научно-исследовательская деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("8d5bdde4-bd84-471f-bd9f-21f0bb071cef"), null, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("9526fe7a-4a84-4491-84c5-398199b4e40b"), null, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("d8e89007-76bf-41a3-9794-576a71e73732"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("db758034-f57a-4ad1-9f5a-7c8cf1236693"), "User 1", "admin@mail.ru" },
                    { new Guid("f62bf5c0-a626-41cc-9c2f-232a0fbe1dd8"), "User 2", "user@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00229da4-ec96-4232-97e1-d63e3d40a036"), "string" },
                    { new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033"), "int" },
                    { new Guid("27caa7b7-2d30-44c3-86a5-8d665877ea55"), "DateTime" },
                    { new Guid("c40b5318-c500-4ffc-8665-7278b64c5340"), "bool" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0c8808c7-4274-4f10-a38c-486d0a76de75"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") },
                    { new Guid("0c8808c7-4274-4f10-a38c-486d0a76de75"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") },
                    { new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") },
                    { new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") },
                    { new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") },
                    { new Guid("8cd73dd8-f545-49d2-ad4b-94a184825a74"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") },
                    { new Guid("bc562ed0-6d15-4ade-9f74-04bd750aa57e"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") },
                    { new Guid("bc562ed0-6d15-4ade-9f74-04bd750aa57e"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("08917d36-0269-4ec1-9bbe-ed785fcca6ab"), new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), null, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("0b6450c5-e4c6-4b1b-84ae-2d78742877fb"), new Guid("8cd73dd8-f545-49d2-ad4b-94a184825a74"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", "Защитившиеся кандидаты наук", 23, "Введите количество", new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("13f3e524-d4da-4162-9bdc-9718b1ead6d3"), new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"), null, "Защитившиеся специалисты", 21, "Введите количество", new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("188c621f-4cbe-4bf2-9756-dbe6ee0bd342"), new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), null, "Должность", 9, "Введите свою должность в организации", new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("3a38d456-742f-4276-aee9-a2ec3c4c0208"), new Guid("0c8808c7-4274-4f10-a38c-486d0a76de75"), null, "Научная специальность (по классификации ВАК)", 17, "Введите научную специальность (по классификации ВАК)", new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("3e8f7559-5ca1-447a-ba8d-4da205094844"), new Guid("0c8808c7-4274-4f10-a38c-486d0a76de75"), null, "Название конкрусной работы", 14, "Введите название своей конкурсной работы", new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("490302f1-fae1-4d36-9b85-434aaa53c48f"), new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"), null, "Защитившиеся магистры", 22, "Введите количество", new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("6a180669-e5f1-40be-b0f2-e78b89fd611e"), new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"), null, "Защитившиеся доктора наук", 19, "Введите количество", new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("711c807d-77d1-4650-9b54-19041412aaf6"), new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), null, "Место работы/учебы", 6, "Название организации", new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("78b46f99-65b0-4710-98a6-cfcf5de78be2"), new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), null, "Электронная почта", 5, "user@example.com", new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("7e4f2ad7-8c00-4cbf-816d-081bebbfc85c"), new Guid("0c8808c7-4274-4f10-a38c-486d0a76de75"), null, "Ученое звание", 15, "Выберите ученое звание", new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("8e66ddcc-5794-4cc0-ac09-4e3672479480"), new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), null, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("a4f88551-f6e4-4672-a7dc-9066cf191cf8"), new Guid("8cd73dd8-f545-49d2-ad4b-94a184825a74"), null, "Защитившиеся доктора наук", 24, "Введите количество", new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("a791611e-f88a-44c4-aafb-eb794c05a19c"), new Guid("0c8808c7-4274-4f10-a38c-486d0a76de75"), null, "Направление конкурса", 12, "Выберите направление конкурса", new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("ca05e077-020e-4236-af1a-c9f06a04f1e1"), new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), null, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("d783c5d5-49b1-43e9-af69-8392acb7d55c"), new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), null, "ФИО", 1, "Иванов Иван Иванович", new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("d9537168-0d7d-4016-9a75-1e846d6a7bbe"), new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), null, "Дополнительная информация", 11, "Пример", new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("e1a76ce9-4f49-4eb2-a8af-c2698205f94e"), new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), null, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("e47d73a7-7ea9-41e6-8073-e98bf154dd5e"), new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", "Защитившиеся кадидаты наук", 18, "Введите количество", new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("ed7a901c-9173-425b-8003-0e6c6de496cb"), new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), null, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("ef4616fe-b66c-428a-a645-bd128eaadb6c"), new Guid("0c8808c7-4274-4f10-a38c-486d0a76de75"), null, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 13, "Выберите категорию участника конкруса", new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("f5e2f50e-8ca6-43c2-908f-b5f498e0877d"), new Guid("0c8808c7-4274-4f10-a38c-486d0a76de75"), null, "Ученая степень", 16, "Выберите ученую степень", new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("f663cc7f-ff3b-4806-af3f-3a157c543075"), new Guid("1dda1080-e035-4e29-ac88-02420ca82062"), null, "Дата рождения", 2, "01.01.2000", new Guid("27caa7b7-2d30-44c3-86a5-8d665877ea55") },
                    { new Guid("f9864029-ceca-4c09-9f09-2a7d1739055a"), new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"), "Руководство дипломными проектами за предыдущий учебный год", "Защитившиеся бакалавры", 20, "Введите количество", new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0165f555-0787-4a87-8f3c-cf368193bab1"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") },
                    { new Guid("0165f555-0787-4a87-8f3c-cf368193bab1"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") },
                    { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") },
                    { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") },
                    { new Guid("41a63948-a198-43c1-90f1-bec3431f613a"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") },
                    { new Guid("4ec27e93-178c-479c-be65-21bedb251290"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") },
                    { new Guid("4ec27e93-178c-479c-be65-21bedb251290"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") },
                    { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") },
                    { new Guid("77419d63-f392-4eae-baf0-4b85fe8e8d45"), new Guid("10ff6132-63ea-482f-8000-2ad682d4dca3") },
                    { new Guid("77419d63-f392-4eae-baf0-4b85fe8e8d45"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("d8e89007-76bf-41a3-9794-576a71e73732") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("8d5bdde4-bd84-471f-bd9f-21f0bb071cef") },
                    { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("9526fe7a-4a84-4491-84c5-398199b4e40b") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("143a4d76-6814-44a4-ad06-4ca9a1ba61ff"), new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"), "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("35802550-4f0a-49c7-8604-7ae5cd60e43c"), new Guid("8cd73dd8-f545-49d2-ad4b-94a184825a74"), "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("4fb349bf-cd0f-4048-8ca5-17f51d1e4c41"), new Guid("8cd73dd8-f545-49d2-ad4b-94a184825a74"), "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("619f4717-73bf-4652-859c-4d3a3da8049d"), new Guid("8cd73dd8-f545-49d2-ad4b-94a184825a74"), "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("64c81acf-686b-4da6-b465-ebb79839edc4"), new Guid("8cd73dd8-f545-49d2-ad4b-94a184825a74"), "Персональные идентификаторы и показатели", 10 },
                    { new Guid("71f5775c-55bf-47db-a79a-9713b1f6d492"), new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"), "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("9b781db3-a8cb-4e94-8114-8a44ce6420f9"), new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"), "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("a326230f-e103-4657-8cc0-72941957fda1"), new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"), "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("b274a947-530f-47bb-b8e8-f3626fcbccf2"), new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"), "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("b64f67fd-3f9d-4a06-ba87-55d1a709b453"), new Guid("bc562ed0-6d15-4ade-9f74-04bd750aa57e"), "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("c4458d87-cb60-4e72-ae85-0b03efc08be3"), new Guid("8cd73dd8-f545-49d2-ad4b-94a184825a74"), "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("edc350bc-82f6-41d8-92e0-7d7d2e7452e8"), new Guid("bc562ed0-6d15-4ade-9f74-04bd750aa57e"), "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("eebaa703-33b2-48a0-b7fd-c833cb0eb3f8"), new Guid("62d5afea-95cb-49bc-91cd-77af995ebb7c"), "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0db8e2f5-6fc8-4fc1-97f2-b90b5a23a42c"), "Год", 3, new Guid("143a4d76-6814-44a4-ad06-4ca9a1ba61ff"), new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("1d82ca7d-fa2d-4d14-bd63-e634978535e2"), "Название статьи", 1, new Guid("4fb349bf-cd0f-4048-8ca5-17f51d1e4c41"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("1fe5d1d1-ea8d-43c5-a1d6-4fcb021932be"), "Название разработки", 2, new Guid("c4458d87-cb60-4e72-ae85-0b03efc08be3"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("21d4de64-4019-40da-bfd6-979799c87b46"), "Название", 2, new Guid("eebaa703-33b2-48a0-b7fd-c833cb0eb3f8"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("36cf26da-ed0c-48c1-addd-e6f36011eddc"), "Название конкурса/премии", 2, new Guid("143a4d76-6814-44a4-ad06-4ca9a1ba61ff"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("42415f08-3c19-46f5-bc96-076e19e58b94"), "Вид деятельности (преподавательская)", 3, new Guid("a326230f-e103-4657-8cc0-72941957fda1"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("49693feb-b595-4e66-b7bd-33c583093e6b"), "Вид (лекции, лабораторные)", 2, new Guid("b274a947-530f-47bb-b8e8-f3626fcbccf2"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("51255486-b0f3-45f7-9d23-7388ed1095dd"), "Количество печатных листов", 4, new Guid("eebaa703-33b2-48a0-b7fd-c833cb0eb3f8"), new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("52078266-6be4-4c39-aad0-9946e4898f9f"), "ФИО соавторов", 3, new Guid("619f4717-73bf-4652-859c-4d3a3da8049d"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("5384e4f1-493f-49c7-bbd4-9921f2e3aec1"), "Вид", 1, new Guid("619f4717-73bf-4652-859c-4d3a3da8049d"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("58a29801-d5e7-48d7-8802-0bdb61d0a9d0"), "Период выполнения", 3, new Guid("35802550-4f0a-49c7-8604-7ae5cd60e43c"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("5f9568cd-5a8b-4e17-ab10-b29ead005cd4"), "Год", 4, new Guid("9b781db3-a8cb-4e94-8114-8a44ce6420f9"), new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("659dc1de-b7c6-49f3-82f4-9603086bcbec"), "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("4fb349bf-cd0f-4048-8ca5-17f51d1e4c41"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("6dc27acf-77c2-48b2-af81-6d5eca69f93a"), "Наименование курса", 1, new Guid("71f5775c-55bf-47db-a79a-9713b1f6d492"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("72250b1a-f5c0-49cc-8580-b23191179e9a"), "Индекс Хирша (за все время)", 5, new Guid("64c81acf-686b-4da6-b465-ebb79839edc4"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("72461200-bd55-4dd6-859d-de077988bb7c"), "Ссылка на платформу", 3, new Guid("9b781db3-a8cb-4e94-8114-8a44ce6420f9"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("781a57fa-7e04-4ca3-ab31-e170ba6aa7c7"), "Тип идентификатора", 1, new Guid("64c81acf-686b-4da6-b465-ebb79839edc4"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("86f6d1ed-9481-45bd-b9db-e5b93f6e6a26"), "Статус (руководитель/исполнитель)", 4, new Guid("35802550-4f0a-49c7-8604-7ae5cd60e43c"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("885dba0c-bc7b-403a-a01f-fe994088c022"), "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("143a4d76-6814-44a4-ad06-4ca9a1ba61ff"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("8d8387b3-1e7e-44ec-9131-a72c95af6621"), "Наличие грифа", 5, new Guid("eebaa703-33b2-48a0-b7fd-c833cb0eb3f8"), new Guid("c40b5318-c500-4ffc-8665-7278b64c5340") },
                    { new Guid("8ecd005f-a780-4e6c-b339-f66a8e85e398"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("35802550-4f0a-49c7-8604-7ae5cd60e43c"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("9d3bf5f9-bfd2-4eaa-8a45-7452645dd59f"), "Награда", 4, new Guid("edc350bc-82f6-41d8-92e0-7d7d2e7452e8"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("9e2c4fc0-720f-4766-bd9d-98056517f191"), "Статус конкурса", 3, new Guid("edc350bc-82f6-41d8-92e0-7d7d2e7452e8"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("a19c9d70-5a6e-479e-886a-53ed214d066f"), "Соавторы", 2, new Guid("9b781db3-a8cb-4e94-8114-8a44ce6420f9"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("a91a5ba1-691d-4531-8cd9-b3925a5a45ab"), "Количество цитирований", 4, new Guid("64c81acf-686b-4da6-b465-ebb79839edc4"), new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("b0579ce3-c185-44f3-b529-5573cc77e8c0"), "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("a326230f-e103-4657-8cc0-72941957fda1"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("b1918f2e-d2f7-4d16-9653-90b5908eb548"), "ФИО", 1, new Guid("143a4d76-6814-44a4-ad06-4ca9a1ba61ff"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("b4515353-3345-4962-98d0-0d4c3a9e396f"), "Год получения документа", 2, new Guid("b64f67fd-3f9d-4a06-ba87-55d1a709b453"), new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("b6acdbc6-a1af-4d3a-bd3a-9aba3aa097ee"), "Название организации/должность/ставка", 1, new Guid("a326230f-e103-4657-8cc0-72941957fda1"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("b9488aa1-7cfe-4c6e-95fb-09268bb4483b"), "Вид", 1, new Guid("c4458d87-cb60-4e72-ae85-0b03efc08be3"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("baae5761-40b5-4752-a963-4ee255436a3f"), "Название", 2, new Guid("619f4717-73bf-4652-859c-4d3a3da8049d"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("bc5f13f5-66e8-4799-88e2-175357dc001c"), "Название конкурса", 2, new Guid("edc350bc-82f6-41d8-92e0-7d7d2e7452e8"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("bfabc20b-e965-460d-b818-b5f816e6fa3c"), "Практические занятия (час.)", 4, new Guid("71f5775c-55bf-47db-a79a-9713b1f6d492"), new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("c0249435-e0bd-48dc-b2b6-f1ceb2bb3eea"), "Соавторы", 2, new Guid("4fb349bf-cd0f-4048-8ca5-17f51d1e4c41"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("c25740e4-b353-486a-b0fa-0d649f1e9418"), "Название документа, реквизиты", 1, new Guid("b64f67fd-3f9d-4a06-ba87-55d1a709b453"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("c3158ccb-c593-4af6-b96a-64d2d60c9e30"), "Итого (час.)", 5, new Guid("71f5775c-55bf-47db-a79a-9713b1f6d492"), new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("c338be79-3a70-400b-ade1-4238cfc98234"), "Название дисциплины", 1, new Guid("b274a947-530f-47bb-b8e8-f3626fcbccf2"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("c6f9b210-fd10-4519-a908-c669634b16b9"), "Номер РИД", 4, new Guid("619f4717-73bf-4652-859c-4d3a3da8049d"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("c7eb27eb-5ecd-4530-b201-9e6249947ec5"), "Количество часов", 4, new Guid("a326230f-e103-4657-8cc0-72941957fda1"), new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("d0ae3468-a70b-491e-a221-aae679fb34ea"), "Название курса", 1, new Guid("9b781db3-a8cb-4e94-8114-8a44ce6420f9"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("d16fe35a-9fe0-4ddd-93dc-c7685e7a77ac"), "Название организации в которую внедрена разработка", 3, new Guid("c4458d87-cb60-4e72-ae85-0b03efc08be3"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("d5d006b1-9f4c-43c0-a85d-aec04bb21651"), "Издательство, год", 6, new Guid("eebaa703-33b2-48a0-b7fd-c833cb0eb3f8"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("d6477913-1f09-41cb-8c5b-de8bb4381657"), "Ссылка", 5, new Guid("edc350bc-82f6-41d8-92e0-7d7d2e7452e8"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("dcb47384-32d7-405d-99f2-377c0b5a2699"), "Количество публикаций в БАЗЕ", 3, new Guid("64c81acf-686b-4da6-b465-ebb79839edc4"), new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("e186453f-1d86-41f5-a9a8-ee0388be06b1"), "Идентификатор", 2, new Guid("64c81acf-686b-4da6-b465-ebb79839edc4"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("e2bc417d-b008-4d90-a9d3-f1675d7a826f"), "Название НИР/НИОКР", 1, new Guid("35802550-4f0a-49c7-8604-7ae5cd60e43c"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("e3ecf46c-9414-42f2-ace0-d6ea9c570efa"), "Лекции (час.)", 3, new Guid("71f5775c-55bf-47db-a79a-9713b1f6d492"), new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("ea0997d4-f4f7-4d2f-bec7-2876ba9bf9b6"), "Год", 1, new Guid("edc350bc-82f6-41d8-92e0-7d7d2e7452e8"), new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("f00ad8c2-3004-489a-ab4d-4610ebf58dc7"), "Язык преподавания (русск./англ./др.)", 2, new Guid("71f5775c-55bf-47db-a79a-9713b1f6d492"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("f113e9d6-86da-41c2-94c3-04f561faf76d"), "Вид публикации", 1, new Guid("eebaa703-33b2-48a0-b7fd-c833cb0eb3f8"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("f63ea870-9caa-4ab8-883a-dfa6d871d988"), "Издание, год", 4, new Guid("4fb349bf-cd0f-4048-8ca5-17f51d1e4c41"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("f91b9bd9-f4a4-4c8e-bb45-05cf7d25d535"), "Сумма финансирования (тыс. руб.)", 2, new Guid("35802550-4f0a-49c7-8604-7ae5cd60e43c"), new Guid("2212270c-2b39-4bc2-bb54-3fc50b87c033") },
                    { new Guid("fb32cadb-8d3a-4d18-b679-63e2f127236f"), "Соавторы", 3, new Guid("eebaa703-33b2-48a0-b7fd-c833cb0eb3f8"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") },
                    { new Guid("fc67b6bc-bfc5-494b-97dc-5a9b0f5da0e6"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("143a4d76-6814-44a4-ad06-4ca9a1ba61ff"), new Guid("00229da4-ec96-4232-97e1-d63e3d40a036") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("08917d36-0269-4ec1-9bbe-ed785fcca6ab"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("0b6450c5-e4c6-4b1b-84ae-2d78742877fb"), new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815") },
                    { new Guid("13f3e524-d4da-4162-9bdc-9718b1ead6d3"), new Guid("40851c9f-314e-4e30-a21c-c622a10eae25") },
                    { new Guid("188c621f-4cbe-4bf2-9756-dbe6ee0bd342"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("3a38d456-742f-4276-aee9-a2ec3c4c0208"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("3e8f7559-5ca1-447a-ba8d-4da205094844"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("490302f1-fae1-4d36-9b85-434aaa53c48f"), new Guid("40851c9f-314e-4e30-a21c-c622a10eae25") },
                    { new Guid("6a180669-e5f1-40be-b0f2-e78b89fd611e"), new Guid("40851c9f-314e-4e30-a21c-c622a10eae25") },
                    { new Guid("711c807d-77d1-4650-9b54-19041412aaf6"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("78b46f99-65b0-4710-98a6-cfcf5de78be2"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("7e4f2ad7-8c00-4cbf-816d-081bebbfc85c"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("7e4f2ad7-8c00-4cbf-816d-081bebbfc85c"), new Guid("41a63948-a198-43c1-90f1-bec3431f613a") },
                    { new Guid("7e4f2ad7-8c00-4cbf-816d-081bebbfc85c"), new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815") },
                    { new Guid("8e66ddcc-5794-4cc0-ac09-4e3672479480"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("a4f88551-f6e4-4672-a7dc-9066cf191cf8"), new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815") },
                    { new Guid("a791611e-f88a-44c4-aafb-eb794c05a19c"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("ca05e077-020e-4236-af1a-c9f06a04f1e1"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("d783c5d5-49b1-43e9-af69-8392acb7d55c"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("d9537168-0d7d-4016-9a75-1e846d6a7bbe"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("e1a76ce9-4f49-4eb2-a8af-c2698205f94e"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("e47d73a7-7ea9-41e6-8073-e98bf154dd5e"), new Guid("40851c9f-314e-4e30-a21c-c622a10eae25") },
                    { new Guid("ed7a901c-9173-425b-8003-0e6c6de496cb"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("ef4616fe-b66c-428a-a645-bd128eaadb6c"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("f5e2f50e-8ca6-43c2-908f-b5f498e0877d"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("f663cc7f-ff3b-4806-af3f-3a157c543075"), new Guid("0165f555-0787-4a87-8f3c-cf368193bab1") },
                    { new Guid("f9864029-ceca-4c09-9f09-2a7d1739055a"), new Guid("40851c9f-314e-4e30-a21c-c622a10eae25") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("619f4717-73bf-4652-859c-4d3a3da8049d") },
                    { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("b64f67fd-3f9d-4a06-ba87-55d1a709b453") },
                    { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("c4458d87-cb60-4e72-ae85-0b03efc08be3") },
                    { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("143a4d76-6814-44a4-ad06-4ca9a1ba61ff") },
                    { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("71f5775c-55bf-47db-a79a-9713b1f6d492") },
                    { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("9b781db3-a8cb-4e94-8114-8a44ce6420f9") },
                    { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("a326230f-e103-4657-8cc0-72941957fda1") },
                    { new Guid("41a63948-a198-43c1-90f1-bec3431f613a"), new Guid("b64f67fd-3f9d-4a06-ba87-55d1a709b453") },
                    { new Guid("41a63948-a198-43c1-90f1-bec3431f613a"), new Guid("edc350bc-82f6-41d8-92e0-7d7d2e7452e8") },
                    { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("b274a947-530f-47bb-b8e8-f3626fcbccf2") },
                    { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("eebaa703-33b2-48a0-b7fd-c833cb0eb3f8") },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("35802550-4f0a-49c7-8604-7ae5cd60e43c") },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("4fb349bf-cd0f-4048-8ca5-17f51d1e4c41") },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("64c81acf-686b-4da6-b465-ebb79839edc4") },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("edc350bc-82f6-41d8-92e0-7d7d2e7452e8") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("04e6730f-e10d-4b05-b52e-c3ae4c1b9e6f"), null, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("619f4717-73bf-4652-859c-4d3a3da8049d") },
                    { new Guid("1bbae866-be86-4ef7-b920-9ce1b913c075"), null, "Баллы за научные публикации:", 16, new Guid("4fb349bf-cd0f-4048-8ca5-17f51d1e4c41") },
                    { new Guid("26ca7e10-8dd3-4966-9f6c-2bf8cfe1bd0d"), null, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("35802550-4f0a-49c7-8604-7ae5cd60e43c") },
                    { new Guid("29b3f439-6d56-4d27-8e04-9a5492b5ba28"), null, "Баллы за труды с грифом и без соавторства:", 8, new Guid("eebaa703-33b2-48a0-b7fd-c833cb0eb3f8") },
                    { new Guid("2dae456c-1c94-4766-9740-3c06fca82865"), null, "Баллы за профессиональное развитие:", 15, new Guid("b64f67fd-3f9d-4a06-ba87-55d1a709b453") },
                    { new Guid("32e81cda-6b15-478f-b762-b022bf94f646"), null, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("b274a947-530f-47bb-b8e8-f3626fcbccf2") },
                    { new Guid("372af6b8-ee21-490a-a821-e95252ed5b6b"), null, "Баллы за награды:", 14, new Guid("edc350bc-82f6-41d8-92e0-7d7d2e7452e8") },
                    { new Guid("3b54a3b8-be83-416e-a012-5a847c0b18c7"), null, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("143a4d76-6814-44a4-ad06-4ca9a1ba61ff") },
                    { new Guid("3c5301e4-acab-4fe3-afc8-feca3384d352"), null, "Баллы по базе Scopus:", 17, new Guid("64c81acf-686b-4da6-b465-ebb79839edc4") },
                    { new Guid("428a9254-0c1e-468b-92fe-19a3111d4c3d"), null, "Баллы за объем учебной нагрузки:", 1, new Guid("71f5775c-55bf-47db-a79a-9713b1f6d492") },
                    { new Guid("49abead9-7b50-4596-b3dd-91d565059db2"), null, "Баллы за количество разработок:", 24, new Guid("c4458d87-cb60-4e72-ae85-0b03efc08be3") },
                    { new Guid("5def831c-620e-438a-a5cc-3f221b46d91d"), null, "Баллы за труды без грифа и без соавторства:", 10, new Guid("eebaa703-33b2-48a0-b7fd-c833cb0eb3f8") },
                    { new Guid("6956ba82-4392-4c98-aa51-4c88509a782e"), null, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("35802550-4f0a-49c7-8604-7ae5cd60e43c") },
                    { new Guid("7b542f2b-2683-4a54-a418-bc46c852eb6c"), null, "Баллы за труды с грифом в соавторстве:", 9, new Guid("eebaa703-33b2-48a0-b7fd-c833cb0eb3f8") },
                    { new Guid("807ae89d-d24e-441c-bc8f-2c7d122abc60"), null, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("9b781db3-a8cb-4e94-8114-8a44ce6420f9") },
                    { new Guid("a97b5ed6-7799-4824-a5df-5786b39fce67"), new Guid("490302f1-fae1-4d36-9b85-434aaa53c48f"), "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("b80cdbde-f153-4d24-b8b2-4f2977d8064a"), new Guid("e47d73a7-7ea9-41e6-8073-e98bf154dd5e"), "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("ba52d1ef-079b-47d6-a392-9d9ace48b8d4"), new Guid("a4f88551-f6e4-4672-a7dc-9066cf191cf8"), "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("cd455721-cb3b-4d4b-957d-b1018b8c849a"), new Guid("7e4f2ad7-8c00-4cbf-816d-081bebbfc85c"), "Баллы за ученое звание:", 13, null },
                    { new Guid("d4624fdf-f2ca-4b02-8153-df7f38ab23e8"), new Guid("0b6450c5-e4c6-4b1b-84ae-2d78742877fb"), "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("f4814bfe-3b61-4fa1-9f6e-4417543157e0"), new Guid("6a180669-e5f1-40be-b0f2-e78b89fd611e"), "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("f8400e52-5a10-43e1-a652-d656f215a75d"), null, "Баллы за труды без грифа в соавторстве:", 11, new Guid("eebaa703-33b2-48a0-b7fd-c833cb0eb3f8") },
                    { new Guid("f8f090ac-0084-436c-86f0-0b9dc9443798"), null, "Баллы по базе РИНЦ:", 18, new Guid("64c81acf-686b-4da6-b465-ebb79839edc4") },
                    { new Guid("f94f0d5a-e57e-4628-83f6-e1778f1cb160"), null, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("71f5775c-55bf-47db-a79a-9713b1f6d492") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("22d120a8-5818-4d36-8e3f-e0c4ad58877b"), null, new Guid("ef4616fe-b66c-428a-a645-bd128eaadb6c"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("34b63049-7cac-496c-8c30-db38d5cfdba4"), null, new Guid("a791611e-f88a-44c4-aafb-eb794c05a19c"), "СТРОИТЕЛЬСТВО И АРХИТЕКТУРА" },
                    { new Guid("578cb3f8-75a9-4b9b-af63-d8563767867e"), null, new Guid("a791611e-f88a-44c4-aafb-eb794c05a19c"), "НЕДРОПОЛЬЗОВАНИЕ И ГОРНЫЕ НАУКИ" },
                    { new Guid("6a60ce08-23c0-4b95-9393-bb14a2600933"), null, new Guid("7e4f2ad7-8c00-4cbf-816d-081bebbfc85c"), "Нет" },
                    { new Guid("81809d0b-697f-43f0-a4b4-8882cd550c2c"), null, new Guid("a791611e-f88a-44c4-aafb-eb794c05a19c"), "ЭЛЕКТРО- И ТЕПЛОЭНЕРГЕТИКА" },
                    { new Guid("993cb145-c72d-4bad-a245-7d9dc0edc376"), null, new Guid("7e4f2ad7-8c00-4cbf-816d-081bebbfc85c"), "Профессор" },
                    { new Guid("c0c1be3d-b103-4af8-8709-9172bfc321e8"), null, new Guid("7e4f2ad7-8c00-4cbf-816d-081bebbfc85c"), "Доцент" },
                    { new Guid("d15c65f9-3796-4926-816b-b422b0c93e9d"), null, new Guid("a791611e-f88a-44c4-aafb-eb794c05a19c"), "ПРИКЛАДНАЯ ГЕОЛОГИЯ, ГОРНОЕ ДЕЛО, НЕФТЕГАЗОВОЕ ДЕЛО И ГЕОДЕЗИЯ" },
                    { new Guid("d40d7cfa-1b9d-4f65-9a75-98905a85eb93"), null, new Guid("a791611e-f88a-44c4-aafb-eb794c05a19c"), "АРХИТЕКТУРА" },
                    { new Guid("d5723961-f2e6-4c35-bef2-81cec8397313"), null, new Guid("ef4616fe-b66c-428a-a645-bd128eaadb6c"), "Имеющие ученую степень доктора наук" },
                    { new Guid("da482456-d0e3-4cf4-899e-0e8d76fdda70"), null, new Guid("a791611e-f88a-44c4-aafb-eb794c05a19c"), "ТЕХНИКА И ТЕХНОЛОГИИ СТРОИТЕЛЬСТВА" },
                    { new Guid("e7a0ad3c-72ae-441d-90fa-85b8e9982fff"), null, new Guid("ef4616fe-b66c-428a-a645-bd128eaadb6c"), "Аспиранты, адъюнкты, ординаторы, ассистенты-стажеры, не имеющие ученой степени" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("04e6730f-e10d-4b05-b52e-c3ae4c1b9e6f") },
                    { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("2dae456c-1c94-4766-9740-3c06fca82865") },
                    { new Guid("0c00f3f3-8736-4285-947b-bcc9dad43220"), new Guid("49abead9-7b50-4596-b3dd-91d565059db2") },
                    { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("3b54a3b8-be83-416e-a012-5a847c0b18c7") },
                    { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("428a9254-0c1e-468b-92fe-19a3111d4c3d") },
                    { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("807ae89d-d24e-441c-bc8f-2c7d122abc60") },
                    { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("a97b5ed6-7799-4824-a5df-5786b39fce67") },
                    { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("b80cdbde-f153-4d24-b8b2-4f2977d8064a") },
                    { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("f4814bfe-3b61-4fa1-9f6e-4417543157e0") },
                    { new Guid("40851c9f-314e-4e30-a21c-c622a10eae25"), new Guid("f94f0d5a-e57e-4628-83f6-e1778f1cb160") },
                    { new Guid("41a63948-a198-43c1-90f1-bec3431f613a"), new Guid("2dae456c-1c94-4766-9740-3c06fca82865") },
                    { new Guid("41a63948-a198-43c1-90f1-bec3431f613a"), new Guid("372af6b8-ee21-490a-a821-e95252ed5b6b") },
                    { new Guid("41a63948-a198-43c1-90f1-bec3431f613a"), new Guid("cd455721-cb3b-4d4b-957d-b1018b8c849a") },
                    { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("29b3f439-6d56-4d27-8e04-9a5492b5ba28") },
                    { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("32e81cda-6b15-478f-b762-b022bf94f646") },
                    { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("5def831c-620e-438a-a5cc-3f221b46d91d") },
                    { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("7b542f2b-2683-4a54-a418-bc46c852eb6c") },
                    { new Guid("6bf55534-4783-4787-973c-6b110f1d9949"), new Guid("f8400e52-5a10-43e1-a652-d656f215a75d") },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("1bbae866-be86-4ef7-b920-9ce1b913c075") },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("26ca7e10-8dd3-4966-9f6c-2bf8cfe1bd0d") },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("372af6b8-ee21-490a-a821-e95252ed5b6b") },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("3c5301e4-acab-4fe3-afc8-feca3384d352") },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("6956ba82-4392-4c98-aa51-4c88509a782e") },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("ba52d1ef-079b-47d6-a392-9d9ace48b8d4") },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("cd455721-cb3b-4d4b-957d-b1018b8c849a") },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("d4624fdf-f2ca-4b02-8153-df7f38ab23e8") },
                    { new Guid("da62f8eb-04c3-4fcf-a8a8-c00931f1f815"), new Guid("f8f090ac-0084-436c-86f0-0b9dc9443798") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("00ddbee1-1009-4511-8e4f-451cddb3a0c6"), new Guid("b9488aa1-7cfe-4c6e-95fb-09268bb4483b"), null, "Полезная модель" },
                    { new Guid("09126e00-094e-4d77-8196-e1db9a322d27"), new Guid("b9488aa1-7cfe-4c6e-95fb-09268bb4483b"), null, "Изобретение" },
                    { new Guid("195f606b-8893-435d-8467-ef2942d464c8"), new Guid("49693feb-b595-4e66-b7bd-33c583093e6b"), null, "Лабораторные" },
                    { new Guid("33cee135-1341-4b15-ab89-3147fe3eeba0"), new Guid("f113e9d6-86da-41c2-94c3-04f561faf76d"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("45695db0-0693-412c-a896-e53b9c82cfb5"), new Guid("f113e9d6-86da-41c2-94c3-04f561faf76d"), null, "Учебник" },
                    { new Guid("660cd2ec-96b1-4b60-95ef-c648e21a5a93"), new Guid("49693feb-b595-4e66-b7bd-33c583093e6b"), null, "Лекции" },
                    { new Guid("663571a7-119f-4d6f-b3de-7c138a1d9e95"), new Guid("9e2c4fc0-720f-4766-bd9d-98056517f191"), null, "Региональный" },
                    { new Guid("7419cee8-c60b-4406-8c17-fcf17cb996c1"), new Guid("5384e4f1-493f-49c7-bbd4-9921f2e3aec1"), null, "Полезная модель" },
                    { new Guid("75eb3aa6-2faa-4d4d-8e63-46763e323d56"), new Guid("86f6d1ed-9481-45bd-b9db-e5b93f6e6a26"), null, "Руководитель" },
                    { new Guid("a62d1632-163b-4fe7-8a3f-054596057682"), new Guid("b9488aa1-7cfe-4c6e-95fb-09268bb4483b"), null, "База данных" },
                    { new Guid("aab88d5b-52ed-44a2-b60f-d8b0eab0e784"), new Guid("5384e4f1-493f-49c7-bbd4-9921f2e3aec1"), null, "Изобретение" },
                    { new Guid("b162f8ed-e0df-44b2-b2a8-b2a0a7ae5374"), new Guid("f113e9d6-86da-41c2-94c3-04f561faf76d"), null, "Монография" },
                    { new Guid("c7818e7b-e1c4-432e-9257-8239644ed9da"), new Guid("9e2c4fc0-720f-4766-bd9d-98056517f191"), null, "Международный" },
                    { new Guid("e5f9a4c1-2277-4d2f-9604-bf5e87c89729"), new Guid("5384e4f1-493f-49c7-bbd4-9921f2e3aec1"), null, "База данных" },
                    { new Guid("e61d2983-eb6d-4427-85bd-d19f7881d59d"), new Guid("9e2c4fc0-720f-4766-bd9d-98056517f191"), null, "Всероссийский" },
                    { new Guid("e8383c82-e16d-4d5a-820c-760362d9bf89"), new Guid("86f6d1ed-9481-45bd-b9db-e5b93f6e6a26"), null, "Исполнитель" }
                });
        }
    }
}
