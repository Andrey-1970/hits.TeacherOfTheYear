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
                    Name = table.Column<string>(type: "TEXT", maxLength: 400, nullable: true),
                    MarkBlockId = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Fields_MarkBlocks_MarkBlockId",
                        column: x => x.MarkBlockId,
                        principalTable: "MarkBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    MarkBlockId = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Tables_MarkBlocks_MarkBlockId",
                        column: x => x.MarkBlockId,
                        principalTable: "MarkBlocks",
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
                name: "Columns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
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
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    MarkBlockId = table.Column<Guid>(type: "TEXT", nullable: false),
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
                        name: "FK_Marks_MarkBlocks_MarkBlockId",
                        column: x => x.MarkBlockId,
                        principalTable: "MarkBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    { new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), "Общая информация", 1 },
                    { new Guid("2cc07a88-fd52-4227-a93e-77676af3ce87"), "Категория участников", 2 },
                    { new Guid("9e6d7aea-7a73-4df9-959d-3f3ee8affb62"), "Деятельность", 4 },
                    { new Guid("b405d09b-3510-43b1-a896-d57a92d42d7f"), "Деятельность", 5 },
                    { new Guid("c8f2b243-db59-4a20-bb7e-4aeb11e94c04"), "Профессиональное развитие", 3 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Образовательная деятельность", 2 },
                    { new Guid("162c8a59-6597-4ac9-b844-a140bf128511"), "Итог", 8 },
                    { new Guid("2e0e37a8-5be9-4660-bc2a-f58721e14462"), "Профессиональные показатели", 4 },
                    { new Guid("2f33d0f3-f989-4fe6-99a9-cbc4bc8bc502"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("54f9e0e4-e87a-44d2-ad03-6d0c8fd7337d"), "Инновационная и иная деятельность", 6 },
                    { new Guid("5a681c5f-5ada-4122-94f5-c5a492eaa330"), "Конкурсная работа", 7 },
                    { new Guid("899dd24d-ace6-4345-85aa-79247ed4f1b9"), "Методическая деятельность", 3 },
                    { new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Основной", 1 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("4ca97ddb-3e20-4167-b063-d250ca0f4308"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("9ae40e52-b063-43a8-bae3-16f0a69d277d"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), new Guid("4ca97ddb-3e20-4167-b063-d250ca0f4308") },
                    { new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), new Guid("9ae40e52-b063-43a8-bae3-16f0a69d277d") },
                    { new Guid("2cc07a88-fd52-4227-a93e-77676af3ce87"), new Guid("4ca97ddb-3e20-4167-b063-d250ca0f4308") },
                    { new Guid("2cc07a88-fd52-4227-a93e-77676af3ce87"), new Guid("9ae40e52-b063-43a8-bae3-16f0a69d277d") },
                    { new Guid("9e6d7aea-7a73-4df9-959d-3f3ee8affb62"), new Guid("9ae40e52-b063-43a8-bae3-16f0a69d277d") },
                    { new Guid("b405d09b-3510-43b1-a896-d57a92d42d7f"), new Guid("4ca97ddb-3e20-4167-b063-d250ca0f4308") },
                    { new Guid("c8f2b243-db59-4a20-bb7e-4aeb11e94c04"), new Guid("4ca97ddb-3e20-4167-b063-d250ca0f4308") },
                    { new Guid("c8f2b243-db59-4a20-bb7e-4aeb11e94c04"), new Guid("9ae40e52-b063-43a8-bae3-16f0a69d277d") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "MarkBlockId", "Name" },
                values: new object[,]
                {
                    { new Guid("00a89bf5-7551-4525-b1a3-5d95c275d311"), new Guid("b405d09b-3510-43b1-a896-d57a92d42d7f"), new Guid("2f33d0f3-f989-4fe6-99a9-cbc4bc8bc502"), "Защитившиеся кандидаты наук" },
                    { new Guid("02008624-0f88-47db-8f1c-f15ac45af385"), new Guid("9e6d7aea-7a73-4df9-959d-3f3ee8affb62"), new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Защитившиеся бакалавры" },
                    { new Guid("20470e70-e6c9-4e28-84cd-162dbc06dd21"), new Guid("2cc07a88-fd52-4227-a93e-77676af3ce87"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Направление конкурса" },
                    { new Guid("243c430e-2b1f-4e8b-a5eb-c8bf3f716f1e"), new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Домашний адрес" },
                    { new Guid("2b323515-82e2-4cfb-a09b-7769cacd3da0"), new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Электронная почта" },
                    { new Guid("364c0636-753e-425f-89a2-31b63058c27e"), new Guid("9e6d7aea-7a73-4df9-959d-3f3ee8affb62"), new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Защитившиеся специалисты" },
                    { new Guid("378c38a6-a79f-4550-a182-5848b8151b8a"), new Guid("9e6d7aea-7a73-4df9-959d-3f3ee8affb62"), new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Защитившиеся доктора наук" },
                    { new Guid("38ae2f0a-b39c-48b0-a9a6-d1db83d1af71"), new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Дата рождения" },
                    { new Guid("3cfd2d79-a53d-44bd-876e-b4fa15dfba1c"), new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "ФИО" },
                    { new Guid("3ec062f7-800a-443a-8b0d-1edf58697b1e"), new Guid("2cc07a88-fd52-4227-a93e-77676af3ce87"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Категория участника конкурса" },
                    { new Guid("6388741e-5dfb-4cb6-af6a-7e0dd6253b63"), new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Адрес работы/учебы" },
                    { new Guid("672b95bd-af64-4fb8-9e89-3ae216865cd8"), new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Контактный телефон" },
                    { new Guid("678d58f4-3787-4438-9c48-57900d637680"), new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Институт, факультет, кафедра, лаборатория" },
                    { new Guid("712e17d9-6f7c-4b8e-a420-aafabd4c36cc"), new Guid("2cc07a88-fd52-4227-a93e-77676af3ce87"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Научная специальность (по классификации ВАК)" },
                    { new Guid("76b3c147-c38f-4f0a-9392-b948434579ed"), new Guid("2cc07a88-fd52-4227-a93e-77676af3ce87"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Ученая степень" },
                    { new Guid("8f1d3fed-f7de-49aa-8a76-c1690809a7b9"), new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Стаж научно-педагогической деятельности по трудовой книжке" },
                    { new Guid("94e33eb7-9766-472f-975b-43c4e0667e21"), new Guid("2cc07a88-fd52-4227-a93e-77676af3ce87"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Название конкрусной работы" },
                    { new Guid("a27d0655-42f6-4741-b007-cedb77befc79"), new Guid("2cc07a88-fd52-4227-a93e-77676af3ce87"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Ученое звание" },
                    { new Guid("b7f99c06-57a1-4fa3-80f9-32bed7e1240f"), new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Должность" },
                    { new Guid("c16065fe-2912-468b-a687-d856b31c0e3d"), new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Трек конкурса" },
                    { new Guid("c392f6f8-af53-47bd-a53c-f47411127bc9"), new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Дополнительная информация" },
                    { new Guid("c983eb4a-6c7b-46b2-b1d3-58e9511bbc08"), new Guid("9e6d7aea-7a73-4df9-959d-3f3ee8affb62"), new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Защитившиеся кадидаты наук" },
                    { new Guid("d524b9b8-70cd-4fb2-a59e-a0e0efcb69f3"), new Guid("b405d09b-3510-43b1-a896-d57a92d42d7f"), new Guid("2f33d0f3-f989-4fe6-99a9-cbc4bc8bc502"), "Защитившиеся доктора наук" },
                    { new Guid("d58656cf-5a6c-420f-9781-907555f35d82"), new Guid("9e6d7aea-7a73-4df9-959d-3f3ee8affb62"), new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Защитившиеся магистры" },
                    { new Guid("ebbed87a-cb76-4d1d-94d5-1c0a1e542f21"), new Guid("23cc70f3-5da6-47a6-ae3a-10c5dcd7a0f7"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Место работы/учебы" }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), new Guid("9ae40e52-b063-43a8-bae3-16f0a69d277d") },
                    { new Guid("162c8a59-6597-4ac9-b844-a140bf128511"), new Guid("4ca97ddb-3e20-4167-b063-d250ca0f4308") },
                    { new Guid("162c8a59-6597-4ac9-b844-a140bf128511"), new Guid("9ae40e52-b063-43a8-bae3-16f0a69d277d") },
                    { new Guid("2e0e37a8-5be9-4660-bc2a-f58721e14462"), new Guid("9ae40e52-b063-43a8-bae3-16f0a69d277d") },
                    { new Guid("2f33d0f3-f989-4fe6-99a9-cbc4bc8bc502"), new Guid("4ca97ddb-3e20-4167-b063-d250ca0f4308") },
                    { new Guid("54f9e0e4-e87a-44d2-ad03-6d0c8fd7337d"), new Guid("4ca97ddb-3e20-4167-b063-d250ca0f4308") },
                    { new Guid("5a681c5f-5ada-4122-94f5-c5a492eaa330"), new Guid("4ca97ddb-3e20-4167-b063-d250ca0f4308") },
                    { new Guid("5a681c5f-5ada-4122-94f5-c5a492eaa330"), new Guid("9ae40e52-b063-43a8-bae3-16f0a69d277d") },
                    { new Guid("899dd24d-ace6-4345-85aa-79247ed4f1b9"), new Guid("9ae40e52-b063-43a8-bae3-16f0a69d277d") },
                    { new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), new Guid("4ca97ddb-3e20-4167-b063-d250ca0f4308") },
                    { new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), new Guid("9ae40e52-b063-43a8-bae3-16f0a69d277d") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "MarkBlockId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("37e5e162-d639-41a8-9cfb-a6a4558be120"), null, new Guid("54f9e0e4-e87a-44d2-ad03-6d0c8fd7337d"), "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null },
                    { new Guid("72921ab5-1705-4acd-aaac-90c1e3e3915e"), null, new Guid("54f9e0e4-e87a-44d2-ad03-6d0c8fd7337d"), "Оценка уровня предоставленной работы:", 25, null }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "MarkBlockId", "Name" },
                values: new object[,]
                {
                    { new Guid("2b2a704c-5e9a-440a-bda1-71c2e5ec94ee"), new Guid("9e6d7aea-7a73-4df9-959d-3f3ee8affb62"), new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание" },
                    { new Guid("34aa30e4-93a9-403a-a97a-d8fc3638d20a"), new Guid("b405d09b-3510-43b1-a896-d57a92d42d7f"), new Guid("54f9e0e4-e87a-44d2-ad03-6d0c8fd7337d"), "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)" },
                    { new Guid("572f689b-f5f5-4971-8303-4f7119161687"), new Guid("b405d09b-3510-43b1-a896-d57a92d42d7f"), new Guid("2f33d0f3-f989-4fe6-99a9-cbc4bc8bc502"), "Список научных публикаций за последние 5 лет" },
                    { new Guid("5f774819-f6c9-453e-810d-ee768d8b0374"), new Guid("b405d09b-3510-43b1-a896-d57a92d42d7f"), new Guid("2f33d0f3-f989-4fe6-99a9-cbc4bc8bc502"), "Персональные идентификаторы и показатели" },
                    { new Guid("6835546c-c9f3-4ffa-be6d-df2f18f2c2d6"), new Guid("9e6d7aea-7a73-4df9-959d-3f3ee8affb62"), new Guid("899dd24d-ace6-4345-85aa-79247ed4f1b9"), "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет" },
                    { new Guid("6e118ee8-f67f-4710-be6c-d870bc9a4abd"), new Guid("b405d09b-3510-43b1-a896-d57a92d42d7f"), new Guid("2f33d0f3-f989-4fe6-99a9-cbc4bc8bc502"), "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет" },
                    { new Guid("7a935b34-8cc8-4e74-ada1-6b1b7f7f5e26"), new Guid("9e6d7aea-7a73-4df9-959d-3f3ee8affb62"), new Guid("899dd24d-ace6-4345-85aa-79247ed4f1b9"), "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет" },
                    { new Guid("b70fe207-dd4c-4352-8177-b3739ea0ef90"), new Guid("9e6d7aea-7a73-4df9-959d-3f3ee8affb62"), new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год" },
                    { new Guid("d7028b90-0ea6-4bcc-b88b-bace9f6efdeb"), new Guid("b405d09b-3510-43b1-a896-d57a92d42d7f"), new Guid("54f9e0e4-e87a-44d2-ad03-6d0c8fd7337d"), "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)" },
                    { new Guid("d825c252-10ee-45fa-9f22-6c7b8bb36e6a"), new Guid("c8f2b243-db59-4a20-bb7e-4aeb11e94c04"), new Guid("2e0e37a8-5be9-4660-bc2a-f58721e14462"), "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)" },
                    { new Guid("da665c50-d8f5-4bbf-9794-5ba015df64a4"), new Guid("9e6d7aea-7a73-4df9-959d-3f3ee8affb62"), new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет" },
                    { new Guid("df29df8e-ef21-4a6b-b25c-d125bc41e37c"), new Guid("9e6d7aea-7a73-4df9-959d-3f3ee8affb62"), new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Учебная нагрузка за предыдущий учебный год (за исключением методической)" },
                    { new Guid("fa8e146f-dfc9-4a8d-940a-62ba6e27d9ea"), new Guid("c8f2b243-db59-4a20-bb7e-4aeb11e94c04"), new Guid("2e0e37a8-5be9-4660-bc2a-f58721e14462"), "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности" }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "TableId" },
                values: new object[,]
                {
                    { new Guid("0505b291-281a-4b89-b630-79dbf50e9f3e"), "Название документа, реквизиты", new Guid("d825c252-10ee-45fa-9f22-6c7b8bb36e6a") },
                    { new Guid("0a3bc47c-2d60-4faa-9572-f92911f35e46"), "Количество печатных листов", new Guid("6835546c-c9f3-4ffa-be6d-df2f18f2c2d6") },
                    { new Guid("0d3bbb3f-bed8-4a15-a10c-b686d17b92d3"), "Место нахождения (субъект РФ, зарубежье)", new Guid("b70fe207-dd4c-4352-8177-b3739ea0ef90") },
                    { new Guid("10204e78-7293-4170-8575-fb162d247a90"), "Награда", new Guid("fa8e146f-dfc9-4a8d-940a-62ba6e27d9ea") },
                    { new Guid("1d38a6c9-aa40-4391-aef7-e98a4c188de5"), "Итого (час.)", new Guid("df29df8e-ef21-4a6b-b25c-d125bc41e37c") },
                    { new Guid("1db16741-71a6-4904-bb71-55f77736f047"), "Название конкурса", new Guid("fa8e146f-dfc9-4a8d-940a-62ba6e27d9ea") },
                    { new Guid("21634506-51fc-4279-b4aa-dc800b8e675c"), "ФИО соавторов", new Guid("d7028b90-0ea6-4bcc-b88b-bace9f6efdeb") },
                    { new Guid("31e7d836-2454-4838-aab0-2eec9906d30c"), "Количество публикаций в БАЗЕ", new Guid("5f774819-f6c9-453e-810d-ee768d8b0374") },
                    { new Guid("33a0cb5d-3fa1-49da-a39b-e3b28b7e106a"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", new Guid("6e118ee8-f67f-4710-be6c-d870bc9a4abd") },
                    { new Guid("41a1b54b-cd86-4229-b08e-571bbf4ae848"), "Название курса", new Guid("da665c50-d8f5-4bbf-9794-5ba015df64a4") },
                    { new Guid("448ad829-ef09-4379-bfa3-11bcbbcc81c2"), "Название", new Guid("d7028b90-0ea6-4bcc-b88b-bace9f6efdeb") },
                    { new Guid("475068dc-8eec-48af-9383-ff10c6fd3d85"), "Идентификатор", new Guid("5f774819-f6c9-453e-810d-ee768d8b0374") },
                    { new Guid("52a3c213-3417-4bcd-99a3-e2280e913f7f"), "Практические занятия (час.)", new Guid("df29df8e-ef21-4a6b-b25c-d125bc41e37c") },
                    { new Guid("537fff4a-5221-4382-ac66-c047aaea255e"), "Количество цитирований", new Guid("5f774819-f6c9-453e-810d-ee768d8b0374") },
                    { new Guid("55152a27-035f-4b35-84cd-5c5636948dc1"), "Награда/премия (медаль, диплом с указанием степени)", new Guid("2b2a704c-5e9a-440a-bda1-71c2e5ec94ee") },
                    { new Guid("58ab6ff7-695f-42b6-9a20-0878f8a16f1a"), "Индекс Хирша (за все время)", new Guid("5f774819-f6c9-453e-810d-ee768d8b0374") },
                    { new Guid("5b421188-39a1-4a1f-aa39-dc76b0b46366"), "Статус конкурса", new Guid("fa8e146f-dfc9-4a8d-940a-62ba6e27d9ea") },
                    { new Guid("6139a69b-fac5-4a8a-94d5-f835fbecfc45"), "Год получения документа", new Guid("d825c252-10ee-45fa-9f22-6c7b8bb36e6a") },
                    { new Guid("6240b5f0-4dcb-4944-b3a1-9d747d6c78f6"), "Название конкурса/премии", new Guid("2b2a704c-5e9a-440a-bda1-71c2e5ec94ee") },
                    { new Guid("634e4fb9-82b7-4d43-8e93-7deafa5b90ab"), "Язык преподавания (русск./англ./др.)", new Guid("df29df8e-ef21-4a6b-b25c-d125bc41e37c") },
                    { new Guid("6da5e54d-bbd9-48e8-9be8-f4f0c15db1dc"), "Сумма финансирования (тыс. руб.)", new Guid("6e118ee8-f67f-4710-be6c-d870bc9a4abd") },
                    { new Guid("6df6b4c2-293a-4eda-bf7c-a0d8752a609c"), "Статус (руководитель/исполнитель)", new Guid("6e118ee8-f67f-4710-be6c-d870bc9a4abd") },
                    { new Guid("754779cd-6099-4489-a774-e9d808ed8d45"), "Название", new Guid("6835546c-c9f3-4ffa-be6d-df2f18f2c2d6") },
                    { new Guid("7c000344-b5b3-445f-8d88-d515d9662933"), "Название дисциплины", new Guid("7a935b34-8cc8-4e74-ada1-6b1b7f7f5e26") },
                    { new Guid("7da80b1f-c0b9-483a-b689-480e0f11918b"), "Год", new Guid("2b2a704c-5e9a-440a-bda1-71c2e5ec94ee") },
                    { new Guid("7f836060-61b4-4221-a7bd-fbff96956f1f"), "Соавторы", new Guid("6835546c-c9f3-4ffa-be6d-df2f18f2c2d6") },
                    { new Guid("83115527-bdc3-41fa-9754-1dba9e208538"), "Название разработки", new Guid("34aa30e4-93a9-403a-a97a-d8fc3638d20a") },
                    { new Guid("852db7b2-a022-48b4-8e95-9c8ea83ffe50"), "Количество часов", new Guid("b70fe207-dd4c-4352-8177-b3739ea0ef90") },
                    { new Guid("8569adb5-95dc-40be-a412-7acd6ad7b84e"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", new Guid("2b2a704c-5e9a-440a-bda1-71c2e5ec94ee") },
                    { new Guid("8785d145-40c2-4005-b6c1-21f71276ac5d"), "ФИО", new Guid("2b2a704c-5e9a-440a-bda1-71c2e5ec94ee") },
                    { new Guid("88441840-3bfb-489b-8c11-cf57bd567dfc"), "Ссылка", new Guid("fa8e146f-dfc9-4a8d-940a-62ba6e27d9ea") },
                    { new Guid("8ef8f63c-1aa1-4225-9bc6-7d6beb7a5f04"), "Наименование курса", new Guid("df29df8e-ef21-4a6b-b25c-d125bc41e37c") },
                    { new Guid("925653f5-3259-4e62-90b0-40b71606b001"), "Ссылка на платформу", new Guid("da665c50-d8f5-4bbf-9794-5ba015df64a4") },
                    { new Guid("98771aa9-40d3-4292-bb74-cfce515f52bb"), "Год", new Guid("fa8e146f-dfc9-4a8d-940a-62ba6e27d9ea") },
                    { new Guid("99de1fb3-e136-468c-a229-4027406f1c4c"), "Издательство, год", new Guid("6835546c-c9f3-4ffa-be6d-df2f18f2c2d6") },
                    { new Guid("a1032897-21d3-4c0d-b9be-ab7affe37056"), "Вид деятельности (преподавательская)", new Guid("b70fe207-dd4c-4352-8177-b3739ea0ef90") },
                    { new Guid("a527117f-7a21-456f-ab6c-511eb846a24d"), "Название организации в которую внедрена разработка", new Guid("34aa30e4-93a9-403a-a97a-d8fc3638d20a") },
                    { new Guid("b23161db-bc46-4fda-85cb-82e1fd0818dd"), "Наличие грифа", new Guid("6835546c-c9f3-4ffa-be6d-df2f18f2c2d6") },
                    { new Guid("bff7030e-663a-4deb-84ff-e4db04d40e54"), "Вид публикации", new Guid("6835546c-c9f3-4ffa-be6d-df2f18f2c2d6") },
                    { new Guid("c159c6f9-98ea-46d8-b8fd-717515fc8c6b"), "Соавторы", new Guid("da665c50-d8f5-4bbf-9794-5ba015df64a4") },
                    { new Guid("c6c7243b-b1a7-438d-9f94-716eb228c18f"), "Вид (лекции, лабораторные)", new Guid("7a935b34-8cc8-4e74-ada1-6b1b7f7f5e26") },
                    { new Guid("cb64dfc9-4f03-47eb-87e4-06f93f653eee"), "Лекции (час.)", new Guid("df29df8e-ef21-4a6b-b25c-d125bc41e37c") },
                    { new Guid("d3809ebe-d03e-4a3c-bc28-fae698129713"), "Издание, год", new Guid("572f689b-f5f5-4971-8303-4f7119161687") },
                    { new Guid("d575a176-4bf8-46b9-a040-b171ed6ed00a"), "Период выполнения", new Guid("6e118ee8-f67f-4710-be6c-d870bc9a4abd") },
                    { new Guid("d769de10-b66f-4587-b62d-dd11792927a6"), "Соавторы", new Guid("572f689b-f5f5-4971-8303-4f7119161687") },
                    { new Guid("da3d7be1-3383-4058-92f1-4c926dcb1348"), "Тип публикации (категория ВАК/квартиль МБД)", new Guid("572f689b-f5f5-4971-8303-4f7119161687") },
                    { new Guid("dc94b7ec-748c-4fdd-bdfa-9a771f43d1ff"), "Название НИР/НИОКР", new Guid("6e118ee8-f67f-4710-be6c-d870bc9a4abd") },
                    { new Guid("e5ed5650-6049-438c-807c-2f35708439f4"), "Номер РИД", new Guid("d7028b90-0ea6-4bcc-b88b-bace9f6efdeb") },
                    { new Guid("ec0462fa-0bf1-43b8-8f90-002f89105bf4"), "Вид", new Guid("34aa30e4-93a9-403a-a97a-d8fc3638d20a") },
                    { new Guid("ef641628-3c51-4681-adde-59ff6f171ea4"), "Название организации/должность/ставка", new Guid("b70fe207-dd4c-4352-8177-b3739ea0ef90") },
                    { new Guid("f3b28fc2-bc1e-4a19-9f13-9b22a8efe82c"), "Тип идентификатора", new Guid("5f774819-f6c9-453e-810d-ee768d8b0374") },
                    { new Guid("f46bfb70-12cc-469b-a350-9528a9d240f6"), "Название статьи", new Guid("572f689b-f5f5-4971-8303-4f7119161687") },
                    { new Guid("f63db8d9-b3d9-4b2d-9c2d-ea6cc1684636"), "Вид", new Guid("d7028b90-0ea6-4bcc-b88b-bace9f6efdeb") },
                    { new Guid("ff4d650f-675c-48d0-9735-2915e2db6032"), "Год", new Guid("da665c50-d8f5-4bbf-9794-5ba015df64a4") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "MarkBlockId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0a813591-35f4-47cb-b2b0-4a9c4f1b741c"), null, new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("df29df8e-ef21-4a6b-b25c-d125bc41e37c") },
                    { new Guid("36e5c72c-1f31-4ac4-855e-42ec79f4eb98"), new Guid("d524b9b8-70cd-4fb2-a59e-a0e0efcb69f3"), new Guid("2f33d0f3-f989-4fe6-99a9-cbc4bc8bc502"), "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("3f70ae10-bc98-4a35-b95f-a206a07e805a"), null, new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Баллы за объем учебной нагрузки:", 1, new Guid("df29df8e-ef21-4a6b-b25c-d125bc41e37c") },
                    { new Guid("447eb529-37fd-4ecc-8c29-b979dc0019d8"), null, new Guid("54f9e0e4-e87a-44d2-ad03-6d0c8fd7337d"), "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("d7028b90-0ea6-4bcc-b88b-bace9f6efdeb") },
                    { new Guid("479583ea-3427-4643-8dc6-34dcbe0cf422"), null, new Guid("54f9e0e4-e87a-44d2-ad03-6d0c8fd7337d"), "Баллы за количество разработок:", 24, new Guid("34aa30e4-93a9-403a-a97a-d8fc3638d20a") },
                    { new Guid("4b2d20a0-35a7-4f26-8372-77978a99d2bd"), new Guid("c983eb4a-6c7b-46b2-b1d3-58e9511bbc08"), new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("580a29ed-d43f-4830-8f80-a7eb8a800581"), null, new Guid("2f33d0f3-f989-4fe6-99a9-cbc4bc8bc502"), "Баллы по базе Scopus:", 17, new Guid("5f774819-f6c9-453e-810d-ee768d8b0374") },
                    { new Guid("6768a2e4-3534-4e80-9c26-f379560418d8"), null, new Guid("2f33d0f3-f989-4fe6-99a9-cbc4bc8bc502"), "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("6e118ee8-f67f-4710-be6c-d870bc9a4abd") },
                    { new Guid("76418445-8256-4ef1-b096-664e6b249b5a"), new Guid("00a89bf5-7551-4525-b1a3-5d95c275d311"), new Guid("2f33d0f3-f989-4fe6-99a9-cbc4bc8bc502"), "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("852184f3-181b-4a31-a166-2ad84af2115a"), null, new Guid("899dd24d-ace6-4345-85aa-79247ed4f1b9"), "Баллы за труды с грифом и без соавторства:", 8, new Guid("6835546c-c9f3-4ffa-be6d-df2f18f2c2d6") },
                    { new Guid("86a4c888-fe13-459b-9feb-1e37977ff868"), new Guid("a27d0655-42f6-4741-b007-cedb77befc79"), new Guid("c531885a-0887-488d-9b8c-eb01f84f2b0a"), "Баллы за ученое звание:", 13, null },
                    { new Guid("86e7de18-6ebd-44ba-8171-ccb59cabd05c"), null, new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("da665c50-d8f5-4bbf-9794-5ba015df64a4") },
                    { new Guid("aad83f6a-83e0-49d7-8b0c-05aec3341941"), new Guid("d58656cf-5a6c-420f-9781-907555f35d82"), new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("b1892257-183e-49ce-923f-b774eb97e007"), null, new Guid("899dd24d-ace6-4345-85aa-79247ed4f1b9"), "Баллы за труды без грифа в соавторстве:", 11, new Guid("6835546c-c9f3-4ffa-be6d-df2f18f2c2d6") },
                    { new Guid("b9fdbb9b-1062-441c-8a91-e0c7ed62bec8"), new Guid("378c38a6-a79f-4550-a182-5848b8151b8a"), new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("c75b285d-ee33-4079-a453-9021a4fc9e9e"), null, new Guid("2e0e37a8-5be9-4660-bc2a-f58721e14462"), "Баллы за награды:", 14, new Guid("fa8e146f-dfc9-4a8d-940a-62ba6e27d9ea") },
                    { new Guid("d0ee1520-8a79-4ddc-a0d7-3be5283563ae"), null, new Guid("0445c0f1-5d4b-4943-a35c-38000a74a6e1"), "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("2b2a704c-5e9a-440a-bda1-71c2e5ec94ee") },
                    { new Guid("d6f1d1a0-7791-464f-a4f8-801e2126f76a"), null, new Guid("2e0e37a8-5be9-4660-bc2a-f58721e14462"), "Баллы за профессиональное развитие:", 15, new Guid("d825c252-10ee-45fa-9f22-6c7b8bb36e6a") },
                    { new Guid("e1de257d-1025-4579-83c7-5b0a2b6acadb"), null, new Guid("2f33d0f3-f989-4fe6-99a9-cbc4bc8bc502"), "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("6e118ee8-f67f-4710-be6c-d870bc9a4abd") },
                    { new Guid("edc91066-4e93-4103-a7fa-583024771720"), null, new Guid("899dd24d-ace6-4345-85aa-79247ed4f1b9"), "Баллы за труды без грифа и без соавторства:", 10, new Guid("6835546c-c9f3-4ffa-be6d-df2f18f2c2d6") },
                    { new Guid("ef67da7e-4420-4e2d-847f-3c70a5f86042"), null, new Guid("2f33d0f3-f989-4fe6-99a9-cbc4bc8bc502"), "Баллы за научные публикации:", 16, new Guid("572f689b-f5f5-4971-8303-4f7119161687") },
                    { new Guid("f5db7d1f-fac4-4f2b-9348-3a6df636660f"), null, new Guid("899dd24d-ace6-4345-85aa-79247ed4f1b9"), "Баллы за количество практикумов и курсов лекций:", 12, new Guid("7a935b34-8cc8-4e74-ada1-6b1b7f7f5e26") },
                    { new Guid("fa4536ba-f2e2-4f28-a692-57f38184abea"), null, new Guid("2f33d0f3-f989-4fe6-99a9-cbc4bc8bc502"), "Баллы по базе РИНЦ:", 18, new Guid("5f774819-f6c9-453e-810d-ee768d8b0374") },
                    { new Guid("fdbc6081-be50-4278-82b6-3f3a0fdbc833"), null, new Guid("899dd24d-ace6-4345-85aa-79247ed4f1b9"), "Баллы за труды с грифом в соавторстве:", 9, new Guid("6835546c-c9f3-4ffa-be6d-df2f18f2c2d6") }
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
                name: "IX_EditBlocks_Number",
                table: "EditBlocks",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EditBlocks_Number_Name",
                table: "EditBlocks",
                columns: new[] { "Number", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EditBlockTrack_TracksId",
                table: "EditBlockTrack",
                column: "TracksId");

            migrationBuilder.CreateIndex(
                name: "IX_Fields_EditBlockId_Name",
                table: "Fields",
                columns: new[] { "EditBlockId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fields_MarkBlockId_Name",
                table: "Fields",
                columns: new[] { "MarkBlockId", "Name" },
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
                name: "IX_MarkBlockTrack_TracksId",
                table: "MarkBlockTrack",
                column: "TracksId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_FieldId",
                table: "Marks",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_MarkBlockId_Name",
                table: "Marks",
                columns: new[] { "MarkBlockId", "Name" },
                unique: true);

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
                name: "IX_Tables_EditBlockId",
                table: "Tables",
                column: "EditBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_MarkBlockId",
                table: "Tables",
                column: "MarkBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Tables_Name",
                table: "Tables",
                column: "Name",
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
                name: "FieldVals");

            migrationBuilder.DropTable(
                name: "MarkBlockTrack");

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

            migrationBuilder.DropTable(
                name: "MarkBlocks");
        }
    }
}
