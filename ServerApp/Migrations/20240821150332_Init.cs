using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerApp.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EditBlocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditBlocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarkBlocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkBlocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 400, nullable: true),
                    EditBlockId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fields_EditBlocks_EditBlockId",
                        column: x => x.EditBlockId,
                        principalTable: "EditBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    EditBlockId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tables_EditBlocks_EditBlockId",
                        column: x => x.EditBlockId,
                        principalTable: "EditBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EditBlockTrack",
                columns: table => new
                {
                    EditBlocksId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TracksId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditBlockTrack", x => new { x.EditBlocksId, x.TracksId });
                    table.ForeignKey(
                        name: "FK_EditBlockTrack_EditBlocks_EditBlocksId",
                        column: x => x.EditBlocksId,
                        principalTable: "EditBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditBlockTrack_Tracks_TracksId",
                        column: x => x.TracksId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarkBlockTrack",
                columns: table => new
                {
                    MarkBlocksId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TracksId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkBlockTrack", x => new { x.MarkBlocksId, x.TracksId });
                    table.ForeignKey(
                        name: "FK_MarkBlockTrack_MarkBlocks_MarkBlocksId",
                        column: x => x.MarkBlocksId,
                        principalTable: "MarkBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarkBlockTrack_Tracks_TracksId",
                        column: x => x.TracksId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationForms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserInfoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TrackId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationForms_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationForms_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FieldMarkBlock",
                columns: table => new
                {
                    FieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MarkBlocksId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldMarkBlock", x => new { x.FieldsId, x.MarkBlocksId });
                    table.ForeignKey(
                        name: "FK_FieldMarkBlock_Fields_FieldsId",
                        column: x => x.FieldsId,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FieldMarkBlock_MarkBlocks_MarkBlocksId",
                        column: x => x.MarkBlocksId,
                        principalTable: "MarkBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Columns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    TableId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Columns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Columns_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarkBlockTable",
                columns: table => new
                {
                    MarkBlocksId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TablesId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkBlockTable", x => new { x.MarkBlocksId, x.TablesId });
                    table.ForeignKey(
                        name: "FK_MarkBlockTable_MarkBlocks_MarkBlocksId",
                        column: x => x.MarkBlocksId,
                        principalTable: "MarkBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarkBlockTable_Tables_TablesId",
                        column: x => x.TablesId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    FieldId = table.Column<Guid>(type: "TEXT", nullable: true),
                    TableId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marks_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Fields",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Marks_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TableId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rows_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FieldVals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ApplicationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    FieldId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldVals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FieldVals_ApplicationForms_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "ApplicationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FieldVals_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarkMarkBlock",
                columns: table => new
                {
                    MarkBlocksId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MarksId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkMarkBlock", x => new { x.MarkBlocksId, x.MarksId });
                    table.ForeignKey(
                        name: "FK_MarkMarkBlock_MarkBlocks_MarkBlocksId",
                        column: x => x.MarkBlocksId,
                        principalTable: "MarkBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarkMarkBlock_Marks_MarksId",
                        column: x => x.MarksId,
                        principalTable: "Marks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarkVals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Value = table.Column<int>(type: "INTEGER", maxLength: 255, nullable: true),
                    ApplicationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MarkId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkVals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarkVals_ApplicationForms_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "ApplicationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MarkVals_Marks_MarkId",
                        column: x => x.MarkId,
                        principalTable: "Marks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CellVals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ApplicationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RowId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ColumnId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellVals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CellVals_ApplicationForms_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "ApplicationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CellVals_Columns_ColumnId",
                        column: x => x.ColumnId,
                        principalTable: "Columns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CellVals_Rows_RowId",
                        column: x => x.RowId,
                        principalTable: "Rows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("31169eaa-7cde-4f69-9de7-9d34fa854605"), "Профессиональное развитие", 3 },
                    { new Guid("513ccb1c-1875-480d-8f9f-ec880ec95e72"), "Деятельность", 5 },
                    { new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), "Общая информация", 1 },
                    { new Guid("c6859102-0639-43df-ae20-df18d690245f"), "Деятельность", 4 },
                    { new Guid("e9ac9588-27e7-47ec-ae3d-d6f889386f17"), "Категория участников", 2 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("18a81a99-7af4-4aa0-b826-538d84345d24"), "Конкурсная работа", 7 },
                    { new Guid("35705dc7-cb36-4a8e-9d44-ebccd8bc7b8d"), "Профессиональные показатели", 4 },
                    { new Guid("55cbefe1-dc80-4860-af74-8a9048e7135f"), "Методическая деятельность", 3 },
                    { new Guid("583822d3-4a09-4f64-8601-1b6f67a35773"), "Образовательная деятельность", 2 },
                    { new Guid("690509e0-a77c-4c54-a7f5-16782c06623e"), "Инновационная и иная деятельность", 6 },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("c25f5aa9-21a8-49cd-966a-d98165c732ef"), "Итог", 8 },
                    { new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b"), "Основной", 1 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("a003da79-fe55-417a-9225-658dbe25b9f7"), null, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null },
                    { new Guid("ea2e3730-6b28-4c17-9630-0a10c0f15565"), null, "Оценка уровня предоставленной работы:", 25, null }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("7e8aeabf-ba29-49f4-b097-0c93db346ea5"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("b908de0e-a6e1-4699-bfc4-54853f552739"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("233c9bd6-ed40-4ae0-93dc-03ed5cb27aa3"), "User 1", "admin@mail.ru" },
                    { new Guid("fe11f5ea-1d27-4b78-8deb-59014c32d267"), "User 2", "user@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("31169eaa-7cde-4f69-9de7-9d34fa854605"), new Guid("7e8aeabf-ba29-49f4-b097-0c93db346ea5") },
                    { new Guid("31169eaa-7cde-4f69-9de7-9d34fa854605"), new Guid("b908de0e-a6e1-4699-bfc4-54853f552739") },
                    { new Guid("513ccb1c-1875-480d-8f9f-ec880ec95e72"), new Guid("7e8aeabf-ba29-49f4-b097-0c93db346ea5") },
                    { new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), new Guid("7e8aeabf-ba29-49f4-b097-0c93db346ea5") },
                    { new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), new Guid("b908de0e-a6e1-4699-bfc4-54853f552739") },
                    { new Guid("c6859102-0639-43df-ae20-df18d690245f"), new Guid("b908de0e-a6e1-4699-bfc4-54853f552739") },
                    { new Guid("e9ac9588-27e7-47ec-ae3d-d6f889386f17"), new Guid("7e8aeabf-ba29-49f4-b097-0c93db346ea5") },
                    { new Guid("e9ac9588-27e7-47ec-ae3d-d6f889386f17"), new Guid("b908de0e-a6e1-4699-bfc4-54853f552739") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("17580ff7-a1b0-4e99-afad-ff315cc30978"), new Guid("c6859102-0639-43df-ae20-df18d690245f"), "Защитившиеся доктора наук", 20 },
                    { new Guid("362ab3e8-227b-4a2a-81ea-b9cff26d7fa5"), new Guid("e9ac9588-27e7-47ec-ae3d-d6f889386f17"), "Ученая степень", 17 },
                    { new Guid("42d804c8-1774-46a3-a6c9-393594e55e08"), new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), "ФИО", 2 },
                    { new Guid("49dfa1e1-4a3a-4f43-b799-b6c80662c8a1"), new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), "Электронная почта", 6 },
                    { new Guid("4dee9c1a-7243-4643-8ae8-96f4c7d736a3"), new Guid("e9ac9588-27e7-47ec-ae3d-d6f889386f17"), "Ученое звание", 16 },
                    { new Guid("572a11a5-a7d2-45cc-8f48-ca7f912fd4fe"), new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), "Дополнительная информация", 12 },
                    { new Guid("65ce6d39-a0a8-431a-9540-e7b52a907d7f"), new Guid("c6859102-0639-43df-ae20-df18d690245f"), "Защитившиеся бакалавры", 21 },
                    { new Guid("683a7c80-d26b-45ec-a5cf-d94b16139caa"), new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), "Адрес работы/учебы", 8 },
                    { new Guid("871a7b30-c027-4c0c-a51e-96a3d878b980"), new Guid("c6859102-0639-43df-ae20-df18d690245f"), "Защитившиеся специалисты", 22 },
                    { new Guid("8c9cdba6-c1c5-4840-97f5-8042cc14cf2c"), new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), "Стаж научно-педагогической деятельности по трудовой книжке", 11 },
                    { new Guid("94bd25d8-d12a-4f6e-910b-5336833d8c76"), new Guid("e9ac9588-27e7-47ec-ae3d-d6f889386f17"), "Категория участника конкурса", 14 },
                    { new Guid("97adae5c-dff2-43b7-8ec5-b91fb33e2e82"), new Guid("513ccb1c-1875-480d-8f9f-ec880ec95e72"), "Защитившиеся доктора наук", 25 },
                    { new Guid("a63cf466-751d-4da5-bd07-e953996b6ce3"), new Guid("513ccb1c-1875-480d-8f9f-ec880ec95e72"), "Защитившиеся кандидаты наук", 24 },
                    { new Guid("adb5a93a-ad25-4c22-9e70-efa86dd2bdd5"), new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), "Должность", 10 },
                    { new Guid("c5a6a54b-1cb7-42fe-9d24-fe2f8dacc8c9"), new Guid("c6859102-0639-43df-ae20-df18d690245f"), "Защитившиеся кадидаты наук", 19 },
                    { new Guid("c7f7a655-e90f-4810-a0b0-4c73aa94dad0"), new Guid("e9ac9588-27e7-47ec-ae3d-d6f889386f17"), "Научная специальность (по классификации ВАК)", 18 },
                    { new Guid("c8b88934-23cc-46d6-be3c-3f0a53a6bf1a"), new Guid("e9ac9588-27e7-47ec-ae3d-d6f889386f17"), "Направление конкурса", 13 },
                    { new Guid("ca889531-fa07-490e-8cc2-2bd6d4cd97f8"), new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), "Трек конкурса", 1 },
                    { new Guid("ce1deef0-7563-43ab-a3df-7ab742832fdb"), new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), "Институт, факультет, кафедра, лаборатория", 9 },
                    { new Guid("d43f7d97-9b43-4902-801f-2c8e11d5b738"), new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), "Домашний адрес", 4 },
                    { new Guid("dc7684ff-bd9d-4360-b7ff-f42ab359fce7"), new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), "Место работы/учебы", 7 },
                    { new Guid("ee57c7df-ec3e-4847-83fa-8827688efbe7"), new Guid("e9ac9588-27e7-47ec-ae3d-d6f889386f17"), "Название конкрусной работы", 15 },
                    { new Guid("efe6b69f-d675-49ba-9eed-d5483076e887"), new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), "Дата рождения", 3 },
                    { new Guid("f4621a47-6444-4f96-9bff-b7247a64a901"), new Guid("a9caecec-3b3e-4a97-908f-f00f0331de4d"), "Контактный телефон", 5 },
                    { new Guid("fd725233-ad5c-4e1f-ae67-dcc0da16173a"), new Guid("c6859102-0639-43df-ae20-df18d690245f"), "Защитившиеся магистры", 23 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("18a81a99-7af4-4aa0-b826-538d84345d24"), new Guid("7e8aeabf-ba29-49f4-b097-0c93db346ea5") },
                    { new Guid("18a81a99-7af4-4aa0-b826-538d84345d24"), new Guid("b908de0e-a6e1-4699-bfc4-54853f552739") },
                    { new Guid("35705dc7-cb36-4a8e-9d44-ebccd8bc7b8d"), new Guid("b908de0e-a6e1-4699-bfc4-54853f552739") },
                    { new Guid("55cbefe1-dc80-4860-af74-8a9048e7135f"), new Guid("b908de0e-a6e1-4699-bfc4-54853f552739") },
                    { new Guid("583822d3-4a09-4f64-8601-1b6f67a35773"), new Guid("b908de0e-a6e1-4699-bfc4-54853f552739") },
                    { new Guid("690509e0-a77c-4c54-a7f5-16782c06623e"), new Guid("7e8aeabf-ba29-49f4-b097-0c93db346ea5") },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), new Guid("7e8aeabf-ba29-49f4-b097-0c93db346ea5") },
                    { new Guid("c25f5aa9-21a8-49cd-966a-d98165c732ef"), new Guid("7e8aeabf-ba29-49f4-b097-0c93db346ea5") },
                    { new Guid("c25f5aa9-21a8-49cd-966a-d98165c732ef"), new Guid("b908de0e-a6e1-4699-bfc4-54853f552739") },
                    { new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b"), new Guid("7e8aeabf-ba29-49f4-b097-0c93db346ea5") },
                    { new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b"), new Guid("b908de0e-a6e1-4699-bfc4-54853f552739") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("690509e0-a77c-4c54-a7f5-16782c06623e"), new Guid("a003da79-fe55-417a-9225-658dbe25b9f7") },
                    { new Guid("690509e0-a77c-4c54-a7f5-16782c06623e"), new Guid("ea2e3730-6b28-4c17-9630-0a10c0f15565") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("170884c4-b6ef-430e-8abf-7647295dfcd9"), new Guid("c6859102-0639-43df-ae20-df18d690245f"), "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("178b1558-72dd-46bd-a6d1-3d224d3374ba"), new Guid("c6859102-0639-43df-ae20-df18d690245f"), "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("3448642b-93b4-4925-bff3-927ccec9508f"), new Guid("513ccb1c-1875-480d-8f9f-ec880ec95e72"), "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("3a05bb8e-ef11-4372-9cff-f449058e3f1e"), new Guid("513ccb1c-1875-480d-8f9f-ec880ec95e72"), "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("51c81764-8043-4471-8720-ac28f0123f82"), new Guid("c6859102-0639-43df-ae20-df18d690245f"), "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("5609f554-a020-47af-8d31-538bdf931432"), new Guid("31169eaa-7cde-4f69-9de7-9d34fa854605"), "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("5704b5a8-c77d-41a3-bf9f-de4509cf4843"), new Guid("c6859102-0639-43df-ae20-df18d690245f"), "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("b45f7783-db8c-4474-8eeb-6d786c98ec82"), new Guid("513ccb1c-1875-480d-8f9f-ec880ec95e72"), "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("c5a43f11-dfcc-4eb0-af99-bce732ef9f8d"), new Guid("513ccb1c-1875-480d-8f9f-ec880ec95e72"), "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("cbd6bbe5-1408-4a60-b65b-362fc9a38b9e"), new Guid("c6859102-0639-43df-ae20-df18d690245f"), "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("ec20dcca-cd30-4025-9975-9075ad7dc69b"), new Guid("c6859102-0639-43df-ae20-df18d690245f"), "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 },
                    { new Guid("f19f9973-189e-4d22-aba8-d37afd86f58f"), new Guid("31169eaa-7cde-4f69-9de7-9d34fa854605"), "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("f3a864cd-4912-47c1-8f11-d836924ac1fc"), new Guid("513ccb1c-1875-480d-8f9f-ec880ec95e72"), "Персональные идентификаторы и показатели", 10 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("00a3350a-a8fb-4292-995d-a7e7b236b994"), "Ссылка на платформу", 3, new Guid("178b1558-72dd-46bd-a6d1-3d224d3374ba") },
                    { new Guid("074c9174-c839-473f-80c2-82b49c74dd61"), "Соавторы", 2, new Guid("3a05bb8e-ef11-4372-9cff-f449058e3f1e") },
                    { new Guid("09d61457-53c5-4f8b-9bb0-11b9d0652886"), "ФИО соавторов", 3, new Guid("b45f7783-db8c-4474-8eeb-6d786c98ec82") },
                    { new Guid("0f2ab8e7-4306-49ea-af0b-bdbcc709b3a6"), "Вид деятельности (преподавательская)", 3, new Guid("5704b5a8-c77d-41a3-bf9f-de4509cf4843") },
                    { new Guid("167c920e-6f58-49ab-bdb5-cf4465a4a68e"), "Количество печатных листов", 4, new Guid("ec20dcca-cd30-4025-9975-9075ad7dc69b") },
                    { new Guid("1fa6d57c-94df-4fb0-9972-792cf4644c8e"), "Соавторы", 2, new Guid("178b1558-72dd-46bd-a6d1-3d224d3374ba") },
                    { new Guid("203ef34d-a7d4-4519-b45b-492a83dbbc91"), "Количество цитирований", 4, new Guid("f3a864cd-4912-47c1-8f11-d836924ac1fc") },
                    { new Guid("2316f31f-0aaa-4dd5-88d7-65368924a0f6"), "Период выполнения", 3, new Guid("3448642b-93b4-4925-bff3-927ccec9508f") },
                    { new Guid("26086dde-84c8-45cd-bfad-03191a19ff58"), "Лекции (час.)", 3, new Guid("cbd6bbe5-1408-4a60-b65b-362fc9a38b9e") },
                    { new Guid("2a9e6655-5efa-48bb-bdde-461f5217bf14"), "Сумма финансирования (тыс. руб.)", 2, new Guid("3448642b-93b4-4925-bff3-927ccec9508f") },
                    { new Guid("363c09ab-d799-4a4c-8678-82489b3053c0"), "Индекс Хирша (за все время)", 5, new Guid("f3a864cd-4912-47c1-8f11-d836924ac1fc") },
                    { new Guid("381c0c59-1056-4bed-9026-78401c963e29"), "Вид", 1, new Guid("c5a43f11-dfcc-4eb0-af99-bce732ef9f8d") },
                    { new Guid("5364f91f-963f-4638-8c4e-c5007a3a5805"), "Практические занятия (час.)", 4, new Guid("cbd6bbe5-1408-4a60-b65b-362fc9a38b9e") },
                    { new Guid("57f259cc-a63c-432b-bea3-b9bd567ce5c2"), "Название статьи", 1, new Guid("3a05bb8e-ef11-4372-9cff-f449058e3f1e") },
                    { new Guid("58d7b85b-b431-443e-9a8b-93c94eefaa9f"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("3448642b-93b4-4925-bff3-927ccec9508f") },
                    { new Guid("5c202379-0086-42c1-ae04-776a6bfbeb72"), "ФИО", 1, new Guid("170884c4-b6ef-430e-8abf-7647295dfcd9") },
                    { new Guid("5d767f73-55ac-40b6-993e-b0482c05d265"), "Издание, год", 4, new Guid("3a05bb8e-ef11-4372-9cff-f449058e3f1e") },
                    { new Guid("600f5a79-3162-4aec-a755-1aba5af786ba"), "Количество публикаций в БАЗЕ", 3, new Guid("f3a864cd-4912-47c1-8f11-d836924ac1fc") },
                    { new Guid("609b83b0-b4ee-49aa-adc9-a6051b5d89d2"), "Название НИР/НИОКР", 1, new Guid("3448642b-93b4-4925-bff3-927ccec9508f") },
                    { new Guid("61d24ca6-ddf8-49f3-8534-e4715b8a0718"), "Название", 2, new Guid("b45f7783-db8c-4474-8eeb-6d786c98ec82") },
                    { new Guid("6debb536-dd7f-4bd5-9034-6ec6201afca3"), "Название дисциплины", 1, new Guid("51c81764-8043-4471-8720-ac28f0123f82") },
                    { new Guid("6f4052ef-47a6-4abe-b882-6a1e4b0760bf"), "Название", 2, new Guid("ec20dcca-cd30-4025-9975-9075ad7dc69b") },
                    { new Guid("7480cd93-ee40-4095-8d5b-9c73ed9746a1"), "Статус конкурса", 3, new Guid("f19f9973-189e-4d22-aba8-d37afd86f58f") },
                    { new Guid("751323ce-ad1f-4fd2-8ea4-45e482dfd0e6"), "Награда", 4, new Guid("f19f9973-189e-4d22-aba8-d37afd86f58f") },
                    { new Guid("771d0210-dd5d-465a-bcab-7c52ea66c348"), "Номер РИД", 4, new Guid("b45f7783-db8c-4474-8eeb-6d786c98ec82") },
                    { new Guid("7acbb316-c9a2-4a1d-9523-fd12d17eee15"), "Идентификатор", 2, new Guid("f3a864cd-4912-47c1-8f11-d836924ac1fc") },
                    { new Guid("7fe1c467-54e5-481b-ae0f-88985cc56932"), "Название организации/должность/ставка", 1, new Guid("5704b5a8-c77d-41a3-bf9f-de4509cf4843") },
                    { new Guid("8213e160-1164-4afb-acdb-3116ad2811ba"), "Статус (руководитель/исполнитель)", 4, new Guid("3448642b-93b4-4925-bff3-927ccec9508f") },
                    { new Guid("84c674bb-6432-44c2-ac77-3bdaafa7c056"), "Год", 3, new Guid("170884c4-b6ef-430e-8abf-7647295dfcd9") },
                    { new Guid("8855ff90-1908-42f7-b87c-53d78c949096"), "Соавторы", 3, new Guid("ec20dcca-cd30-4025-9975-9075ad7dc69b") },
                    { new Guid("8cb056a6-35e0-4b9e-b21a-64805d5f7e7c"), "Наличие грифа", 5, new Guid("ec20dcca-cd30-4025-9975-9075ad7dc69b") },
                    { new Guid("8e010354-fe1f-43ce-959d-15021d046a1e"), "Вид публикации", 1, new Guid("ec20dcca-cd30-4025-9975-9075ad7dc69b") },
                    { new Guid("925fbcf5-5350-4252-8be2-99edb221004b"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("170884c4-b6ef-430e-8abf-7647295dfcd9") },
                    { new Guid("93f24f5f-93c8-4899-b514-dbd83aea1196"), "Итого (час.)", 5, new Guid("cbd6bbe5-1408-4a60-b65b-362fc9a38b9e") },
                    { new Guid("98f17ba2-e86c-41e3-847e-e3df251a9c58"), "Количество часов", 4, new Guid("5704b5a8-c77d-41a3-bf9f-de4509cf4843") },
                    { new Guid("99820d46-f494-4cd6-a110-55498cc3e930"), "Название разработки", 2, new Guid("c5a43f11-dfcc-4eb0-af99-bce732ef9f8d") },
                    { new Guid("99bce237-7d3d-499c-8095-0771a539b051"), "Год получения документа", 2, new Guid("5609f554-a020-47af-8d31-538bdf931432") },
                    { new Guid("9d639eb9-f91b-486a-a974-52cfced3d54c"), "Вид", 1, new Guid("b45f7783-db8c-4474-8eeb-6d786c98ec82") },
                    { new Guid("a0711f49-cbfc-4310-ac13-9e0842fb1592"), "Название конкурса", 2, new Guid("f19f9973-189e-4d22-aba8-d37afd86f58f") },
                    { new Guid("a6c039b2-1199-4928-a73c-d70568dff3a1"), "Год", 1, new Guid("f19f9973-189e-4d22-aba8-d37afd86f58f") },
                    { new Guid("a7d118fa-72cc-4bbd-8d92-d4ccdcc542ee"), "Название конкурса/премии", 2, new Guid("170884c4-b6ef-430e-8abf-7647295dfcd9") },
                    { new Guid("b99f382c-224d-4eb1-ab75-1f808a0bfe41"), "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("170884c4-b6ef-430e-8abf-7647295dfcd9") },
                    { new Guid("be79b397-7b1b-48b6-a606-e451b76a97f4"), "Язык преподавания (русск./англ./др.)", 2, new Guid("cbd6bbe5-1408-4a60-b65b-362fc9a38b9e") },
                    { new Guid("beeaf71a-bb17-4013-a81b-eb62710df058"), "Ссылка", 5, new Guid("f19f9973-189e-4d22-aba8-d37afd86f58f") },
                    { new Guid("c23d6ff4-7343-434a-9880-172f43df9369"), "Вид (лекции, лабораторные)", 2, new Guid("51c81764-8043-4471-8720-ac28f0123f82") },
                    { new Guid("c8772a8b-6a24-462a-a5dc-d064e008b8f3"), "Наименование курса", 1, new Guid("cbd6bbe5-1408-4a60-b65b-362fc9a38b9e") },
                    { new Guid("cbb790a8-b856-4d4e-b66d-3bfdb960c17e"), "Название документа, реквизиты", 1, new Guid("5609f554-a020-47af-8d31-538bdf931432") },
                    { new Guid("ce315791-0123-49b9-b638-f983eaa9a67a"), "Год", 4, new Guid("178b1558-72dd-46bd-a6d1-3d224d3374ba") },
                    { new Guid("d81a4f20-72db-4506-bbac-76bbc5592cef"), "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("5704b5a8-c77d-41a3-bf9f-de4509cf4843") },
                    { new Guid("df3a0e23-1ce5-438c-a247-3f084bc3449f"), "Название организации в которую внедрена разработка", 3, new Guid("c5a43f11-dfcc-4eb0-af99-bce732ef9f8d") },
                    { new Guid("dfcab5db-7640-4a1a-827e-340b2d1aa17f"), "Название курса", 1, new Guid("178b1558-72dd-46bd-a6d1-3d224d3374ba") },
                    { new Guid("edddf8be-abcf-4edd-b173-7cb087265e66"), "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("3a05bb8e-ef11-4372-9cff-f449058e3f1e") },
                    { new Guid("fdbd9ec1-f20a-4ea9-ba15-3b3b446b26c3"), "Тип идентификатора", 1, new Guid("f3a864cd-4912-47c1-8f11-d836924ac1fc") },
                    { new Guid("fe738f30-4009-4579-9b41-6d7cc7415bc7"), "Издательство, год", 6, new Guid("ec20dcca-cd30-4025-9975-9075ad7dc69b") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("17580ff7-a1b0-4e99-afad-ff315cc30978"), new Guid("583822d3-4a09-4f64-8601-1b6f67a35773") },
                    { new Guid("362ab3e8-227b-4a2a-81ea-b9cff26d7fa5"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("42d804c8-1774-46a3-a6c9-393594e55e08"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("49dfa1e1-4a3a-4f43-b799-b6c80662c8a1"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("4dee9c1a-7243-4643-8ae8-96f4c7d736a3"), new Guid("35705dc7-cb36-4a8e-9d44-ebccd8bc7b8d") },
                    { new Guid("4dee9c1a-7243-4643-8ae8-96f4c7d736a3"), new Guid("93adc53b-979f-45c0-bd00-539787bf3f24") },
                    { new Guid("4dee9c1a-7243-4643-8ae8-96f4c7d736a3"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("572a11a5-a7d2-45cc-8f48-ca7f912fd4fe"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("65ce6d39-a0a8-431a-9540-e7b52a907d7f"), new Guid("583822d3-4a09-4f64-8601-1b6f67a35773") },
                    { new Guid("683a7c80-d26b-45ec-a5cf-d94b16139caa"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("871a7b30-c027-4c0c-a51e-96a3d878b980"), new Guid("583822d3-4a09-4f64-8601-1b6f67a35773") },
                    { new Guid("8c9cdba6-c1c5-4840-97f5-8042cc14cf2c"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("94bd25d8-d12a-4f6e-910b-5336833d8c76"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("97adae5c-dff2-43b7-8ec5-b91fb33e2e82"), new Guid("93adc53b-979f-45c0-bd00-539787bf3f24") },
                    { new Guid("a63cf466-751d-4da5-bd07-e953996b6ce3"), new Guid("93adc53b-979f-45c0-bd00-539787bf3f24") },
                    { new Guid("adb5a93a-ad25-4c22-9e70-efa86dd2bdd5"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("c5a6a54b-1cb7-42fe-9d24-fe2f8dacc8c9"), new Guid("583822d3-4a09-4f64-8601-1b6f67a35773") },
                    { new Guid("c7f7a655-e90f-4810-a0b0-4c73aa94dad0"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("c8b88934-23cc-46d6-be3c-3f0a53a6bf1a"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("ca889531-fa07-490e-8cc2-2bd6d4cd97f8"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("ce1deef0-7563-43ab-a3df-7ab742832fdb"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("d43f7d97-9b43-4902-801f-2c8e11d5b738"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("dc7684ff-bd9d-4360-b7ff-f42ab359fce7"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("ee57c7df-ec3e-4847-83fa-8827688efbe7"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("efe6b69f-d675-49ba-9eed-d5483076e887"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("f4621a47-6444-4f96-9bff-b7247a64a901"), new Guid("c9bdd2cd-0ff7-4b01-b095-e5b405f96d6b") },
                    { new Guid("fd725233-ad5c-4e1f-ae67-dcc0da16173a"), new Guid("583822d3-4a09-4f64-8601-1b6f67a35773") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("35705dc7-cb36-4a8e-9d44-ebccd8bc7b8d"), new Guid("5609f554-a020-47af-8d31-538bdf931432") },
                    { new Guid("35705dc7-cb36-4a8e-9d44-ebccd8bc7b8d"), new Guid("f19f9973-189e-4d22-aba8-d37afd86f58f") },
                    { new Guid("55cbefe1-dc80-4860-af74-8a9048e7135f"), new Guid("51c81764-8043-4471-8720-ac28f0123f82") },
                    { new Guid("55cbefe1-dc80-4860-af74-8a9048e7135f"), new Guid("ec20dcca-cd30-4025-9975-9075ad7dc69b") },
                    { new Guid("583822d3-4a09-4f64-8601-1b6f67a35773"), new Guid("170884c4-b6ef-430e-8abf-7647295dfcd9") },
                    { new Guid("583822d3-4a09-4f64-8601-1b6f67a35773"), new Guid("178b1558-72dd-46bd-a6d1-3d224d3374ba") },
                    { new Guid("583822d3-4a09-4f64-8601-1b6f67a35773"), new Guid("5704b5a8-c77d-41a3-bf9f-de4509cf4843") },
                    { new Guid("583822d3-4a09-4f64-8601-1b6f67a35773"), new Guid("cbd6bbe5-1408-4a60-b65b-362fc9a38b9e") },
                    { new Guid("690509e0-a77c-4c54-a7f5-16782c06623e"), new Guid("5609f554-a020-47af-8d31-538bdf931432") },
                    { new Guid("690509e0-a77c-4c54-a7f5-16782c06623e"), new Guid("b45f7783-db8c-4474-8eeb-6d786c98ec82") },
                    { new Guid("690509e0-a77c-4c54-a7f5-16782c06623e"), new Guid("c5a43f11-dfcc-4eb0-af99-bce732ef9f8d") },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), new Guid("3448642b-93b4-4925-bff3-927ccec9508f") },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), new Guid("3a05bb8e-ef11-4372-9cff-f449058e3f1e") },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), new Guid("f19f9973-189e-4d22-aba8-d37afd86f58f") },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), new Guid("f3a864cd-4912-47c1-8f11-d836924ac1fc") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0f7ca2d5-bd72-4664-8e30-9d65f56c6b04"), null, "Баллы за объем учебной нагрузки:", 1, new Guid("cbd6bbe5-1408-4a60-b65b-362fc9a38b9e") },
                    { new Guid("0fa6a535-377b-46c6-ba04-eeecb036fae1"), null, "Баллы за труды с грифом и без соавторства:", 8, new Guid("ec20dcca-cd30-4025-9975-9075ad7dc69b") },
                    { new Guid("4931815f-e698-4bb6-8cc5-60b4706368b3"), null, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("170884c4-b6ef-430e-8abf-7647295dfcd9") },
                    { new Guid("4ef66e0f-9435-4928-9898-08382587843b"), new Guid("c5a6a54b-1cb7-42fe-9d24-fe2f8dacc8c9"), "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("50495d2a-7621-487e-a42f-a558c615d587"), null, "Баллы за награды:", 14, new Guid("f19f9973-189e-4d22-aba8-d37afd86f58f") },
                    { new Guid("55a770c1-ffbd-49be-abe2-036f89685c6f"), new Guid("a63cf466-751d-4da5-bd07-e953996b6ce3"), "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("5991cc39-91c9-43a4-8fab-e70557796bf4"), null, "Баллы по базе РИНЦ:", 18, new Guid("f3a864cd-4912-47c1-8f11-d836924ac1fc") },
                    { new Guid("5dbad1b8-0e89-4987-9680-c60db1e08f59"), null, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("3448642b-93b4-4925-bff3-927ccec9508f") },
                    { new Guid("60822c86-306e-4e24-954a-ad488a393635"), null, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("178b1558-72dd-46bd-a6d1-3d224d3374ba") },
                    { new Guid("71b9f20d-eccc-4944-bc52-b22e7c5961e3"), new Guid("97adae5c-dff2-43b7-8ec5-b91fb33e2e82"), "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("738ccea7-95e7-432d-8c62-cb3d06247eec"), new Guid("4dee9c1a-7243-4643-8ae8-96f4c7d736a3"), "Баллы за ученое звание:", 13, null },
                    { new Guid("83ebdfca-6a0b-4c95-8cf1-3e62482219aa"), null, "Баллы за труды без грифа в соавторстве:", 11, new Guid("ec20dcca-cd30-4025-9975-9075ad7dc69b") },
                    { new Guid("8d3ccb83-6de5-4f37-91bd-919b04f31961"), null, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("cbd6bbe5-1408-4a60-b65b-362fc9a38b9e") },
                    { new Guid("b74d1cf4-3ff4-4b7e-980a-d8ebd5d91726"), null, "Баллы за научные публикации:", 16, new Guid("3a05bb8e-ef11-4372-9cff-f449058e3f1e") },
                    { new Guid("b98cda92-80c4-489f-a48f-9394cf8c87a0"), null, "Баллы за профессиональное развитие:", 15, new Guid("5609f554-a020-47af-8d31-538bdf931432") },
                    { new Guid("bd189f97-b73e-444a-8587-a715bdc15f00"), null, "Баллы за количество разработок:", 24, new Guid("c5a43f11-dfcc-4eb0-af99-bce732ef9f8d") },
                    { new Guid("bd23ea12-6465-4f27-bb70-744a1f2e8424"), new Guid("fd725233-ad5c-4e1f-ae67-dcc0da16173a"), "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("bdd6da5a-b061-4e3e-9456-e9bcf148f27c"), null, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("3448642b-93b4-4925-bff3-927ccec9508f") },
                    { new Guid("c639e574-21cd-4f29-9062-f67a572c6b9c"), null, "Баллы за труды с грифом в соавторстве:", 9, new Guid("ec20dcca-cd30-4025-9975-9075ad7dc69b") },
                    { new Guid("d8bf5466-6302-4e6e-916a-93c395baefd7"), null, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("51c81764-8043-4471-8720-ac28f0123f82") },
                    { new Guid("e55a2495-3a0d-462f-a4fd-521ea0d33cd7"), null, "Баллы по базе Scopus:", 17, new Guid("f3a864cd-4912-47c1-8f11-d836924ac1fc") },
                    { new Guid("e691de53-2d1b-4397-b4b4-9b73b9a05806"), null, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("b45f7783-db8c-4474-8eeb-6d786c98ec82") },
                    { new Guid("eea59e0e-b341-4657-8125-b2e54ce26961"), null, "Баллы за труды без грифа и без соавторства:", 10, new Guid("ec20dcca-cd30-4025-9975-9075ad7dc69b") },
                    { new Guid("f489ef30-cd59-422f-b82d-d6dbe30c063e"), new Guid("17580ff7-a1b0-4e99-afad-ff315cc30978"), "Баллы за количество защитившихся докторов наук:", 5, null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("35705dc7-cb36-4a8e-9d44-ebccd8bc7b8d"), new Guid("50495d2a-7621-487e-a42f-a558c615d587") },
                    { new Guid("35705dc7-cb36-4a8e-9d44-ebccd8bc7b8d"), new Guid("738ccea7-95e7-432d-8c62-cb3d06247eec") },
                    { new Guid("35705dc7-cb36-4a8e-9d44-ebccd8bc7b8d"), new Guid("b98cda92-80c4-489f-a48f-9394cf8c87a0") },
                    { new Guid("55cbefe1-dc80-4860-af74-8a9048e7135f"), new Guid("0fa6a535-377b-46c6-ba04-eeecb036fae1") },
                    { new Guid("55cbefe1-dc80-4860-af74-8a9048e7135f"), new Guid("83ebdfca-6a0b-4c95-8cf1-3e62482219aa") },
                    { new Guid("55cbefe1-dc80-4860-af74-8a9048e7135f"), new Guid("c639e574-21cd-4f29-9062-f67a572c6b9c") },
                    { new Guid("55cbefe1-dc80-4860-af74-8a9048e7135f"), new Guid("d8bf5466-6302-4e6e-916a-93c395baefd7") },
                    { new Guid("55cbefe1-dc80-4860-af74-8a9048e7135f"), new Guid("eea59e0e-b341-4657-8125-b2e54ce26961") },
                    { new Guid("583822d3-4a09-4f64-8601-1b6f67a35773"), new Guid("0f7ca2d5-bd72-4664-8e30-9d65f56c6b04") },
                    { new Guid("583822d3-4a09-4f64-8601-1b6f67a35773"), new Guid("4931815f-e698-4bb6-8cc5-60b4706368b3") },
                    { new Guid("583822d3-4a09-4f64-8601-1b6f67a35773"), new Guid("4ef66e0f-9435-4928-9898-08382587843b") },
                    { new Guid("583822d3-4a09-4f64-8601-1b6f67a35773"), new Guid("60822c86-306e-4e24-954a-ad488a393635") },
                    { new Guid("583822d3-4a09-4f64-8601-1b6f67a35773"), new Guid("8d3ccb83-6de5-4f37-91bd-919b04f31961") },
                    { new Guid("583822d3-4a09-4f64-8601-1b6f67a35773"), new Guid("bd23ea12-6465-4f27-bb70-744a1f2e8424") },
                    { new Guid("583822d3-4a09-4f64-8601-1b6f67a35773"), new Guid("f489ef30-cd59-422f-b82d-d6dbe30c063e") },
                    { new Guid("690509e0-a77c-4c54-a7f5-16782c06623e"), new Guid("b98cda92-80c4-489f-a48f-9394cf8c87a0") },
                    { new Guid("690509e0-a77c-4c54-a7f5-16782c06623e"), new Guid("bd189f97-b73e-444a-8587-a715bdc15f00") },
                    { new Guid("690509e0-a77c-4c54-a7f5-16782c06623e"), new Guid("e691de53-2d1b-4397-b4b4-9b73b9a05806") },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), new Guid("50495d2a-7621-487e-a42f-a558c615d587") },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), new Guid("55a770c1-ffbd-49be-abe2-036f89685c6f") },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), new Guid("5991cc39-91c9-43a4-8fab-e70557796bf4") },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), new Guid("5dbad1b8-0e89-4987-9680-c60db1e08f59") },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), new Guid("71b9f20d-eccc-4944-bc52-b22e7c5961e3") },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), new Guid("738ccea7-95e7-432d-8c62-cb3d06247eec") },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), new Guid("b74d1cf4-3ff4-4b7e-980a-d8ebd5d91726") },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), new Guid("bdd6da5a-b061-4e3e-9456-e9bcf148f27c") },
                    { new Guid("93adc53b-979f-45c0-bd00-539787bf3f24"), new Guid("e55a2495-3a0d-462f-a4fd-521ea0d33cd7") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_TrackId",
                table: "ApplicationForms",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_UserInfoId",
                table: "ApplicationForms",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CellVals_ApplicationId_RowId_ColumnId",
                table: "CellVals",
                columns: new[] { "ApplicationId", "RowId", "ColumnId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CellVals_ColumnId",
                table: "CellVals",
                column: "ColumnId");

            migrationBuilder.CreateIndex(
                name: "IX_CellVals_RowId",
                table: "CellVals",
                column: "RowId");

            migrationBuilder.CreateIndex(
                name: "IX_Columns_TableId_Name",
                table: "Columns",
                columns: new[] { "TableId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Columns_TableId_Number",
                table: "Columns",
                columns: new[] { "TableId", "Number" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EditBlocks_Number",
                table: "EditBlocks",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EditBlockTrack_TracksId",
                table: "EditBlockTrack",
                column: "TracksId");

            migrationBuilder.CreateIndex(
                name: "IX_FieldMarkBlock_MarkBlocksId",
                table: "FieldMarkBlock",
                column: "MarkBlocksId");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_EditBlockId_Name",
                table: "Fields",
                columns: new[] { "EditBlockId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fields_Number",
                table: "Fields",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FieldVals_ApplicationId_FieldId",
                table: "FieldVals",
                columns: new[] { "ApplicationId", "FieldId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FieldVals_FieldId",
                table: "FieldVals",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkBlocks_Name",
                table: "MarkBlocks",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MarkBlocks_Number",
                table: "MarkBlocks",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MarkBlockTable_TablesId",
                table: "MarkBlockTable",
                column: "TablesId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkBlockTrack_TracksId",
                table: "MarkBlockTrack",
                column: "TracksId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkMarkBlock_MarksId",
                table: "MarkMarkBlock",
                column: "MarksId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_FieldId",
                table: "Marks",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_Number",
                table: "Marks",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Marks_TableId",
                table: "Marks",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkVals_ApplicationId_MarkId",
                table: "MarkVals",
                columns: new[] { "ApplicationId", "MarkId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MarkVals_MarkId",
                table: "MarkVals",
                column: "MarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_TableId",
                table: "Rows",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_EditBlockId_Name",
                table: "Tables",
                columns: new[] { "EditBlockId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tables_Number",
                table: "Tables",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_Name",
                table: "Tracks",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_Number",
                table: "Tracks",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserInfos_Username",
                table: "UserInfos",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CellVals");

            migrationBuilder.DropTable(
                name: "EditBlockTrack");

            migrationBuilder.DropTable(
                name: "FieldMarkBlock");

            migrationBuilder.DropTable(
                name: "FieldVals");

            migrationBuilder.DropTable(
                name: "MarkBlockTable");

            migrationBuilder.DropTable(
                name: "MarkBlockTrack");

            migrationBuilder.DropTable(
                name: "MarkMarkBlock");

            migrationBuilder.DropTable(
                name: "MarkVals");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Columns");

            migrationBuilder.DropTable(
                name: "Rows");

            migrationBuilder.DropTable(
                name: "MarkBlocks");

            migrationBuilder.DropTable(
                name: "ApplicationForms");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "EditBlocks");
        }
    }
}
