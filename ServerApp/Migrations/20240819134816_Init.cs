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
                name: "DataTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataTypes", x => x.Id);
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
                    Placeholder = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    EditGroup = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ValueTypeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    EditBlockId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fields_DataTypes_ValueTypeId",
                        column: x => x.ValueTypeId,
                        principalTable: "DataTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    ValueTypeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TableId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Columns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Columns_DataTypes_ValueTypeId",
                        column: x => x.ValueTypeId,
                        principalTable: "DataTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "DataTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77"), "int" },
                    { new Guid("533327b4-b45a-40eb-83fd-4f045d839a9d"), "bool" },
                    { new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc"), "string" },
                    { new Guid("f44c7810-0b74-4510-abb5-b2d4898f8662"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("2f6d1322-adec-4762-a55e-1be6fa7d001e"), "Профессиональное развитие", 3 },
                    { new Guid("82dbb908-7b74-4ede-8455-c73a23b11c88"), "Деятельность", 5 },
                    { new Guid("8ad58472-8e8a-4ae9-b718-b143bfe693e0"), "Деятельность", 4 },
                    { new Guid("94ef58c2-2329-462b-9484-767ec98e789b"), "Общая информация", 1 },
                    { new Guid("ff2c0df5-5c5e-4e5f-a435-76f476861beb"), "Категория участников", 2 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("027b7dc8-cbb1-478d-9f86-7b40af56d5d8"), "Методическая деятельность", 3 },
                    { new Guid("25776156-d171-4192-bd2b-00f8739c6649"), "Образовательная деятельность", 2 },
                    { new Guid("28ad83d3-cadd-425a-8224-e0940d3b994a"), "Конкурсная работа", 7 },
                    { new Guid("41c0cbcd-14e0-4087-a355-4bbc2fb6c45a"), "Профессиональные показатели", 4 },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("b4e99c06-3c49-43ab-ab59-3c4f7131a5ed"), "Инновационная и иная деятельность", 6 },
                    { new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e"), "Основной", 1 },
                    { new Guid("fe08550e-3681-4aab-a58b-890e3ac215a6"), "Итог", 8 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("7bb4df6d-3c23-4d68-a02b-8359a022e861"), null, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null },
                    { new Guid("b5da63be-512e-4351-ba57-0700f520b0b4"), null, "Оценка уровня предоставленной работы:", 25, null }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("64099bec-86e4-4fb0-ab65-d478a98eeaf2"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("7f42cda7-76d7-4497-a372-efff3a3f94e9"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("6a413cab-9caf-4380-ab66-916e4219e4f9"), "User 1", "admin@mail.ru" },
                    { new Guid("cabd5c82-cd76-46b9-9669-3a02d763f2d9"), "User 2", "user@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("2f6d1322-adec-4762-a55e-1be6fa7d001e"), new Guid("64099bec-86e4-4fb0-ab65-d478a98eeaf2") },
                    { new Guid("2f6d1322-adec-4762-a55e-1be6fa7d001e"), new Guid("7f42cda7-76d7-4497-a372-efff3a3f94e9") },
                    { new Guid("82dbb908-7b74-4ede-8455-c73a23b11c88"), new Guid("64099bec-86e4-4fb0-ab65-d478a98eeaf2") },
                    { new Guid("8ad58472-8e8a-4ae9-b718-b143bfe693e0"), new Guid("7f42cda7-76d7-4497-a372-efff3a3f94e9") },
                    { new Guid("94ef58c2-2329-462b-9484-767ec98e789b"), new Guid("64099bec-86e4-4fb0-ab65-d478a98eeaf2") },
                    { new Guid("94ef58c2-2329-462b-9484-767ec98e789b"), new Guid("7f42cda7-76d7-4497-a372-efff3a3f94e9") },
                    { new Guid("ff2c0df5-5c5e-4e5f-a435-76f476861beb"), new Guid("64099bec-86e4-4fb0-ab65-d478a98eeaf2") },
                    { new Guid("ff2c0df5-5c5e-4e5f-a435-76f476861beb"), new Guid("7f42cda7-76d7-4497-a372-efff3a3f94e9") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("006fd36f-9541-4d22-9df4-556ad5c622e4"), new Guid("8ad58472-8e8a-4ae9-b718-b143bfe693e0"), null, "Защитившиеся специалисты", 21, "Введите количество", new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("1027e5c2-9fa9-4492-8f27-468bfcc75dea"), new Guid("8ad58472-8e8a-4ae9-b718-b143bfe693e0"), "Руководство дипломными проектами за предыдущий учебный год", "Защитившиеся бакалавры", 20, "Введите количество", new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("239f3435-3e60-4ea0-a7d5-c606d4c1bfd5"), new Guid("94ef58c2-2329-462b-9484-767ec98e789b"), null, "Электронная почта", 5, "user@example.com", new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("2426c27c-4392-4546-9710-d182eb5aaf72"), new Guid("ff2c0df5-5c5e-4e5f-a435-76f476861beb"), null, "Направление конкурса", 12, "Выберите направление конкурса", new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("24774898-0778-4651-901f-91d0665b9dec"), new Guid("ff2c0df5-5c5e-4e5f-a435-76f476861beb"), null, "Научная специальность (по классификации ВАК)", 17, "Введите научную специальность (по классификации ВАК)", new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("31b91825-f773-4492-8404-ce7217183a06"), new Guid("94ef58c2-2329-462b-9484-767ec98e789b"), null, "ФИО", 1, "Иванов Иван Иванович", new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("339e9dfd-0b77-4083-914f-054bc5e218f5"), new Guid("ff2c0df5-5c5e-4e5f-a435-76f476861beb"), null, "Ученая степень", 16, "Выберите ученую степень", new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("4c654bef-4f75-4e3d-a901-1821917be0d5"), new Guid("94ef58c2-2329-462b-9484-767ec98e789b"), null, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("54cd1808-d7f2-414a-8e67-e5dc70a8c4ee"), new Guid("94ef58c2-2329-462b-9484-767ec98e789b"), null, "Место работы/учебы", 6, "Название организации", new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("5e44e1f1-bc55-4511-8698-c0b6ec302c97"), new Guid("8ad58472-8e8a-4ae9-b718-b143bfe693e0"), null, "Защитившиеся доктора наук", 19, "Введите количество", new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("60d346c8-aacd-4c30-82d1-2ebaf2827959"), new Guid("94ef58c2-2329-462b-9484-767ec98e789b"), null, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("733f5938-579b-4393-8c4e-acbf2f48948f"), new Guid("82dbb908-7b74-4ede-8455-c73a23b11c88"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", "Защитившиеся кандидаты наук", 23, "Введите количество", new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("77e46c32-2b56-4d81-b043-ff61c6af4c37"), new Guid("ff2c0df5-5c5e-4e5f-a435-76f476861beb"), null, "Ученое звание", 15, "Выберите ученое звание", new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("78e5f89d-3db2-40b1-be77-89f46ca41c2f"), new Guid("8ad58472-8e8a-4ae9-b718-b143bfe693e0"), null, "Защитившиеся магистры", 22, "Введите количество", new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("942f11fe-a658-4d36-bb27-8d54f05d444d"), new Guid("94ef58c2-2329-462b-9484-767ec98e789b"), null, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("a61e4584-2929-4806-896a-c3a425a868ae"), new Guid("ff2c0df5-5c5e-4e5f-a435-76f476861beb"), null, "Название конкрусной работы", 14, "Введите название своей конкурсной работы", new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("a8c5537e-f68e-4e3d-8a64-a67f97dce2d3"), new Guid("82dbb908-7b74-4ede-8455-c73a23b11c88"), null, "Защитившиеся доктора наук", 24, "Введите количество", new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("b3dc19c2-758c-4488-8b2e-b1693ec88538"), new Guid("94ef58c2-2329-462b-9484-767ec98e789b"), null, "Дополнительная информация", 11, "Пример", new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("c59af803-cc4b-4446-bc7b-44d2a84b7f09"), new Guid("94ef58c2-2329-462b-9484-767ec98e789b"), null, "Должность", 9, "Введите свою должность в организации", new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("cc529adb-c278-4c6b-868e-7ad40ed3aa3c"), new Guid("ff2c0df5-5c5e-4e5f-a435-76f476861beb"), null, "Категория участника конкурса", 13, "Выберите категорию участника конкруса", new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("d22981d8-b18f-4c7d-b070-8b927001de97"), new Guid("8ad58472-8e8a-4ae9-b718-b143bfe693e0"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", "Защитившиеся кадидаты наук", 18, "Введите количество", new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("d806a405-6455-4e96-b505-57db47c812e1"), new Guid("94ef58c2-2329-462b-9484-767ec98e789b"), null, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("da1084d1-6d71-402d-b2df-095d56944317"), new Guid("94ef58c2-2329-462b-9484-767ec98e789b"), null, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("efaa62a3-599c-46d5-b6ec-519170c79596"), new Guid("94ef58c2-2329-462b-9484-767ec98e789b"), null, "Дата рождения", 2, "01.01.2000", new Guid("f44c7810-0b74-4510-abb5-b2d4898f8662") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("027b7dc8-cbb1-478d-9f86-7b40af56d5d8"), new Guid("7f42cda7-76d7-4497-a372-efff3a3f94e9") },
                    { new Guid("25776156-d171-4192-bd2b-00f8739c6649"), new Guid("7f42cda7-76d7-4497-a372-efff3a3f94e9") },
                    { new Guid("28ad83d3-cadd-425a-8224-e0940d3b994a"), new Guid("64099bec-86e4-4fb0-ab65-d478a98eeaf2") },
                    { new Guid("28ad83d3-cadd-425a-8224-e0940d3b994a"), new Guid("7f42cda7-76d7-4497-a372-efff3a3f94e9") },
                    { new Guid("41c0cbcd-14e0-4087-a355-4bbc2fb6c45a"), new Guid("7f42cda7-76d7-4497-a372-efff3a3f94e9") },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), new Guid("64099bec-86e4-4fb0-ab65-d478a98eeaf2") },
                    { new Guid("b4e99c06-3c49-43ab-ab59-3c4f7131a5ed"), new Guid("64099bec-86e4-4fb0-ab65-d478a98eeaf2") },
                    { new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e"), new Guid("64099bec-86e4-4fb0-ab65-d478a98eeaf2") },
                    { new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e"), new Guid("7f42cda7-76d7-4497-a372-efff3a3f94e9") },
                    { new Guid("fe08550e-3681-4aab-a58b-890e3ac215a6"), new Guid("64099bec-86e4-4fb0-ab65-d478a98eeaf2") },
                    { new Guid("fe08550e-3681-4aab-a58b-890e3ac215a6"), new Guid("7f42cda7-76d7-4497-a372-efff3a3f94e9") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("b4e99c06-3c49-43ab-ab59-3c4f7131a5ed"), new Guid("7bb4df6d-3c23-4d68-a02b-8359a022e861") },
                    { new Guid("b4e99c06-3c49-43ab-ab59-3c4f7131a5ed"), new Guid("b5da63be-512e-4351-ba57-0700f520b0b4") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("01420ddd-b623-4064-9304-b5528d7745e2"), new Guid("82dbb908-7b74-4ede-8455-c73a23b11c88"), "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("031d1091-d709-44fb-990e-45ad61c06a67"), new Guid("2f6d1322-adec-4762-a55e-1be6fa7d001e"), "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("1c4fc68d-3409-41f7-809f-cdc3b34a0243"), new Guid("8ad58472-8e8a-4ae9-b718-b143bfe693e0"), "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 },
                    { new Guid("3c4b6ed1-56ea-4f71-a591-1c6f0b10d819"), new Guid("82dbb908-7b74-4ede-8455-c73a23b11c88"), "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("541417e0-1140-44be-b702-4472fb0dc523"), new Guid("2f6d1322-adec-4762-a55e-1be6fa7d001e"), "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("83f54004-1fc8-4c74-8e47-02cf941de0f3"), new Guid("82dbb908-7b74-4ede-8455-c73a23b11c88"), "Персональные идентификаторы и показатели", 10 },
                    { new Guid("9c3849a0-cbf9-4f3a-89d0-00a948d853cb"), new Guid("8ad58472-8e8a-4ae9-b718-b143bfe693e0"), "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("9f7ee56e-fa4a-4b03-a9a4-27fb416851b7"), new Guid("82dbb908-7b74-4ede-8455-c73a23b11c88"), "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("ab611c30-692c-4a76-9e36-8b228db474e7"), new Guid("8ad58472-8e8a-4ae9-b718-b143bfe693e0"), "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("b0ff3bbc-b9c3-41fb-8c31-15fad932da83"), new Guid("8ad58472-8e8a-4ae9-b718-b143bfe693e0"), "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("d17160f7-fa8e-467d-88e8-bbfc32442f20"), new Guid("82dbb908-7b74-4ede-8455-c73a23b11c88"), "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("d299e65d-4ad5-4cee-99dd-1ac6abfe1b2a"), new Guid("8ad58472-8e8a-4ae9-b718-b143bfe693e0"), "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("d392e8bb-d667-4308-a489-8ed071be5d6e"), new Guid("8ad58472-8e8a-4ae9-b718-b143bfe693e0"), "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("03ee75dc-570d-4aa4-83b2-c48c6934c4c1"), "Сумма финансирования (тыс. руб.)", 2, new Guid("d17160f7-fa8e-467d-88e8-bbfc32442f20"), new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("05886fe3-9250-4436-a9b2-ef0bfff75a36"), "Издательство, год", 6, new Guid("1c4fc68d-3409-41f7-809f-cdc3b34a0243"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("078c09e9-4243-43f8-beac-e6e4d61ac3a8"), "Период выполнения", 3, new Guid("d17160f7-fa8e-467d-88e8-bbfc32442f20"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("0b5c0aa3-744a-4e24-aa8f-cc34dc28e79d"), "Статус (руководитель/исполнитель)", 4, new Guid("d17160f7-fa8e-467d-88e8-bbfc32442f20"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("0efba2a6-2f6a-4c16-9b29-b1ac13a7376b"), "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("b0ff3bbc-b9c3-41fb-8c31-15fad932da83"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("0f537b7b-bd6b-4578-8372-3729686a99dc"), "Название конкурса", 2, new Guid("031d1091-d709-44fb-990e-45ad61c06a67"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("118814be-0785-494e-9ef8-e3e3dfda8aa4"), "Индекс Хирша (за все время)", 5, new Guid("83f54004-1fc8-4c74-8e47-02cf941de0f3"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("12d7bdeb-4da1-41c6-9e9a-2dffc90c25c3"), "Название НИР/НИОКР", 1, new Guid("d17160f7-fa8e-467d-88e8-bbfc32442f20"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("18424b62-1675-4b69-9961-6f5c6aaa0311"), "Название организации/должность/ставка", 1, new Guid("ab611c30-692c-4a76-9e36-8b228db474e7"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("1b04dab5-341d-4922-9af0-d0175e823e6e"), "ФИО", 1, new Guid("b0ff3bbc-b9c3-41fb-8c31-15fad932da83"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("1de2369b-4b3c-4ecb-8bd5-aa882b89c410"), "Название разработки", 2, new Guid("3c4b6ed1-56ea-4f71-a591-1c6f0b10d819"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("1f88e786-a018-4a16-84f4-966c5d81b969"), "Язык преподавания (русск./англ./др.)", 2, new Guid("d392e8bb-d667-4308-a489-8ed071be5d6e"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("200b4bf3-48e7-4ed6-aefd-1d08c21a0c88"), "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("01420ddd-b623-4064-9304-b5528d7745e2"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("3444ca4f-dee1-440a-821f-a09944b82337"), "Тип идентификатора", 1, new Guid("83f54004-1fc8-4c74-8e47-02cf941de0f3"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("35a9cbdf-3bef-4766-bd5a-795ab3a1b425"), "Практические занятия (час.)", 4, new Guid("d392e8bb-d667-4308-a489-8ed071be5d6e"), new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("360e9260-ddb4-4990-9aac-d413ba165e63"), "Издание, год", 4, new Guid("01420ddd-b623-4064-9304-b5528d7745e2"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("38441fa8-cd4a-4a40-ad4e-4432536bbe07"), "Вид публикации", 1, new Guid("1c4fc68d-3409-41f7-809f-cdc3b34a0243"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("38f80e4c-63e2-499e-b8ee-9e7cf889bc1c"), "Количество публикаций в БАЗЕ", 3, new Guid("83f54004-1fc8-4c74-8e47-02cf941de0f3"), new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("3a8d0054-4c0a-4139-8f57-659909a92250"), "Награда", 4, new Guid("031d1091-d709-44fb-990e-45ad61c06a67"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("3b0a268b-87e1-4af1-be26-d1842ba2f9d8"), "Название", 2, new Guid("9f7ee56e-fa4a-4b03-a9a4-27fb416851b7"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("42eb6af9-5edc-4102-87f9-bcfc069f11d0"), "Вид", 1, new Guid("3c4b6ed1-56ea-4f71-a591-1c6f0b10d819"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("49568d95-b029-45a4-876b-0e19c8106682"), "Название конкурса/премии", 2, new Guid("b0ff3bbc-b9c3-41fb-8c31-15fad932da83"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("54681f54-e7a1-439d-ad75-92e6ca4e65df"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("b0ff3bbc-b9c3-41fb-8c31-15fad932da83"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("56e3c7ce-c083-4efe-8599-6257d3a0e949"), "Соавторы", 2, new Guid("01420ddd-b623-4064-9304-b5528d7745e2"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("56efda5f-203b-4a8f-bb34-9681233d79a6"), "Ссылка на платформу", 3, new Guid("d299e65d-4ad5-4cee-99dd-1ac6abfe1b2a"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("5b8a5b0f-f8b2-4b11-91b1-d4c571ad32ad"), "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("ab611c30-692c-4a76-9e36-8b228db474e7"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("5f2a95a3-b3a7-46fd-9a35-a917b24dcf9f"), "Соавторы", 3, new Guid("1c4fc68d-3409-41f7-809f-cdc3b34a0243"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("657a8655-a03c-4bff-9a5e-20fe413193d9"), "Вид деятельности (преподавательская)", 3, new Guid("ab611c30-692c-4a76-9e36-8b228db474e7"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("675b3f08-f12f-425b-9513-646ff26673cd"), "Год получения документа", 2, new Guid("541417e0-1140-44be-b702-4472fb0dc523"), new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("7dff98ba-f732-4cd7-80d2-ef5c90777add"), "Номер РИД", 4, new Guid("9f7ee56e-fa4a-4b03-a9a4-27fb416851b7"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("88d2a215-8c8f-47ad-a14d-f586d715f505"), "Название", 2, new Guid("1c4fc68d-3409-41f7-809f-cdc3b34a0243"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("8cda6309-0f66-430a-9d40-e5c9e28b568f"), "Итого (час.)", 5, new Guid("d392e8bb-d667-4308-a489-8ed071be5d6e"), new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("8d0feacb-9e58-49a8-b4d0-6ae81e4028b3"), "Количество печатных листов", 4, new Guid("1c4fc68d-3409-41f7-809f-cdc3b34a0243"), new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("8f9ea001-0f4d-4395-b23a-9d6859532324"), "Вид (лекции, лабораторные)", 2, new Guid("9c3849a0-cbf9-4f3a-89d0-00a948d853cb"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("9628e0ea-cf24-4645-b212-9b51f4f2f18c"), "Год", 4, new Guid("d299e65d-4ad5-4cee-99dd-1ac6abfe1b2a"), new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("a488d213-0a26-45f3-9ad0-0135bc4f1d7b"), "Количество цитирований", 4, new Guid("83f54004-1fc8-4c74-8e47-02cf941de0f3"), new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("a55422c3-089d-4863-a899-1b782e48b37f"), "Наименование курса", 1, new Guid("d392e8bb-d667-4308-a489-8ed071be5d6e"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("ad06a75c-115e-4847-875f-21e7119dd9d3"), "Год", 3, new Guid("b0ff3bbc-b9c3-41fb-8c31-15fad932da83"), new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("ae68de23-55a4-4e3d-b414-cd3dc4fcbead"), "Количество часов", 4, new Guid("ab611c30-692c-4a76-9e36-8b228db474e7"), new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("af0118c1-b24b-40b1-893f-5ab5edab82ca"), "Идентификатор", 2, new Guid("83f54004-1fc8-4c74-8e47-02cf941de0f3"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("b080e143-e950-4404-bcb3-042250a4ae02"), "Статус конкурса", 3, new Guid("031d1091-d709-44fb-990e-45ad61c06a67"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("b5a2c1e0-aa7e-4352-a19a-398a7e79d1e9"), "Наличие грифа", 5, new Guid("1c4fc68d-3409-41f7-809f-cdc3b34a0243"), new Guid("533327b4-b45a-40eb-83fd-4f045d839a9d") },
                    { new Guid("b62a2831-adc2-47ab-90bb-b5c913b0b8dc"), "Название курса", 1, new Guid("d299e65d-4ad5-4cee-99dd-1ac6abfe1b2a"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("b9ebf81b-34d5-4c36-9e2c-8caa76d59756"), "Соавторы", 2, new Guid("d299e65d-4ad5-4cee-99dd-1ac6abfe1b2a"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("beeedf13-8973-4f95-8e63-6b2065a39675"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("d17160f7-fa8e-467d-88e8-bbfc32442f20"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("c4883212-9844-4ae2-a2b6-dd7b566eb55f"), "Название дисциплины", 1, new Guid("9c3849a0-cbf9-4f3a-89d0-00a948d853cb"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("d612875a-df47-4832-8c8e-eb2bab803535"), "Ссылка", 5, new Guid("031d1091-d709-44fb-990e-45ad61c06a67"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("d8753b96-52aa-48c1-a973-2d1a92298eec"), "Год", 1, new Guid("031d1091-d709-44fb-990e-45ad61c06a67"), new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("d8d943a9-24b1-4774-ae75-60eadef32810"), "Название документа, реквизиты", 1, new Guid("541417e0-1140-44be-b702-4472fb0dc523"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("da218964-cc2e-4fd3-bc20-8119043f07e7"), "Вид", 1, new Guid("9f7ee56e-fa4a-4b03-a9a4-27fb416851b7"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("dc822cb5-35bb-4112-bacf-feae4560eb61"), "Название статьи", 1, new Guid("01420ddd-b623-4064-9304-b5528d7745e2"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("e754929a-ff33-492d-90fb-77a396917038"), "ФИО соавторов", 3, new Guid("9f7ee56e-fa4a-4b03-a9a4-27fb416851b7"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") },
                    { new Guid("edc19e24-55b1-4dc5-a8e8-745ec332196d"), "Лекции (час.)", 3, new Guid("d392e8bb-d667-4308-a489-8ed071be5d6e"), new Guid("332df2e2-d063-4b7b-8c80-c86a21fbfe77") },
                    { new Guid("f74c4485-efb7-41d4-8a25-a945659da7f5"), "Название организации в которую внедрена разработка", 3, new Guid("3c4b6ed1-56ea-4f71-a591-1c6f0b10d819"), new Guid("7c7297a8-6df6-446b-9026-f53fcb4060bc") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("006fd36f-9541-4d22-9df4-556ad5c622e4"), new Guid("25776156-d171-4192-bd2b-00f8739c6649") },
                    { new Guid("1027e5c2-9fa9-4492-8f27-468bfcc75dea"), new Guid("25776156-d171-4192-bd2b-00f8739c6649") },
                    { new Guid("239f3435-3e60-4ea0-a7d5-c606d4c1bfd5"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("2426c27c-4392-4546-9710-d182eb5aaf72"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("24774898-0778-4651-901f-91d0665b9dec"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("31b91825-f773-4492-8404-ce7217183a06"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("339e9dfd-0b77-4083-914f-054bc5e218f5"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("4c654bef-4f75-4e3d-a901-1821917be0d5"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("54cd1808-d7f2-414a-8e67-e5dc70a8c4ee"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("5e44e1f1-bc55-4511-8698-c0b6ec302c97"), new Guid("25776156-d171-4192-bd2b-00f8739c6649") },
                    { new Guid("60d346c8-aacd-4c30-82d1-2ebaf2827959"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("733f5938-579b-4393-8c4e-acbf2f48948f"), new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a") },
                    { new Guid("77e46c32-2b56-4d81-b043-ff61c6af4c37"), new Guid("41c0cbcd-14e0-4087-a355-4bbc2fb6c45a") },
                    { new Guid("77e46c32-2b56-4d81-b043-ff61c6af4c37"), new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a") },
                    { new Guid("77e46c32-2b56-4d81-b043-ff61c6af4c37"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("78e5f89d-3db2-40b1-be77-89f46ca41c2f"), new Guid("25776156-d171-4192-bd2b-00f8739c6649") },
                    { new Guid("942f11fe-a658-4d36-bb27-8d54f05d444d"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("a61e4584-2929-4806-896a-c3a425a868ae"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("a8c5537e-f68e-4e3d-8a64-a67f97dce2d3"), new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a") },
                    { new Guid("b3dc19c2-758c-4488-8b2e-b1693ec88538"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("c59af803-cc4b-4446-bc7b-44d2a84b7f09"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("cc529adb-c278-4c6b-868e-7ad40ed3aa3c"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("d22981d8-b18f-4c7d-b070-8b927001de97"), new Guid("25776156-d171-4192-bd2b-00f8739c6649") },
                    { new Guid("d806a405-6455-4e96-b505-57db47c812e1"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("da1084d1-6d71-402d-b2df-095d56944317"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") },
                    { new Guid("efaa62a3-599c-46d5-b6ec-519170c79596"), new Guid("c853da8c-8f98-43d9-8b7c-7aea9d31668e") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("027b7dc8-cbb1-478d-9f86-7b40af56d5d8"), new Guid("1c4fc68d-3409-41f7-809f-cdc3b34a0243") },
                    { new Guid("027b7dc8-cbb1-478d-9f86-7b40af56d5d8"), new Guid("9c3849a0-cbf9-4f3a-89d0-00a948d853cb") },
                    { new Guid("25776156-d171-4192-bd2b-00f8739c6649"), new Guid("ab611c30-692c-4a76-9e36-8b228db474e7") },
                    { new Guid("25776156-d171-4192-bd2b-00f8739c6649"), new Guid("b0ff3bbc-b9c3-41fb-8c31-15fad932da83") },
                    { new Guid("25776156-d171-4192-bd2b-00f8739c6649"), new Guid("d299e65d-4ad5-4cee-99dd-1ac6abfe1b2a") },
                    { new Guid("25776156-d171-4192-bd2b-00f8739c6649"), new Guid("d392e8bb-d667-4308-a489-8ed071be5d6e") },
                    { new Guid("41c0cbcd-14e0-4087-a355-4bbc2fb6c45a"), new Guid("031d1091-d709-44fb-990e-45ad61c06a67") },
                    { new Guid("41c0cbcd-14e0-4087-a355-4bbc2fb6c45a"), new Guid("541417e0-1140-44be-b702-4472fb0dc523") },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), new Guid("01420ddd-b623-4064-9304-b5528d7745e2") },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), new Guid("031d1091-d709-44fb-990e-45ad61c06a67") },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), new Guid("83f54004-1fc8-4c74-8e47-02cf941de0f3") },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), new Guid("d17160f7-fa8e-467d-88e8-bbfc32442f20") },
                    { new Guid("b4e99c06-3c49-43ab-ab59-3c4f7131a5ed"), new Guid("3c4b6ed1-56ea-4f71-a591-1c6f0b10d819") },
                    { new Guid("b4e99c06-3c49-43ab-ab59-3c4f7131a5ed"), new Guid("541417e0-1140-44be-b702-4472fb0dc523") },
                    { new Guid("b4e99c06-3c49-43ab-ab59-3c4f7131a5ed"), new Guid("9f7ee56e-fa4a-4b03-a9a4-27fb416851b7") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0036a46e-5c25-4b38-86ea-1752debc80d0"), null, "Баллы по базе РИНЦ:", 18, new Guid("83f54004-1fc8-4c74-8e47-02cf941de0f3") },
                    { new Guid("0612d964-438d-4e26-843f-b6f008bcf915"), null, "Баллы за научные публикации:", 16, new Guid("01420ddd-b623-4064-9304-b5528d7745e2") },
                    { new Guid("063afdcf-e956-41c4-9cbe-7b28d799a0bb"), null, "Баллы за объем учебной нагрузки:", 1, new Guid("d392e8bb-d667-4308-a489-8ed071be5d6e") },
                    { new Guid("1bfcb989-46c2-4d98-88d7-7b56bbcda8f2"), null, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("d17160f7-fa8e-467d-88e8-bbfc32442f20") },
                    { new Guid("216ac99d-2527-4d59-9108-555774c2410a"), new Guid("d22981d8-b18f-4c7d-b070-8b927001de97"), "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("227988bb-7e96-4864-92ab-7ba65de0cac0"), new Guid("5e44e1f1-bc55-4511-8698-c0b6ec302c97"), "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("2cd940a1-04fa-4f32-817a-7823f3b6022f"), new Guid("78e5f89d-3db2-40b1-be77-89f46ca41c2f"), "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("3fb5631a-dcb0-40c3-9276-ab2bea495ef5"), null, "Баллы за награды:", 14, new Guid("031d1091-d709-44fb-990e-45ad61c06a67") },
                    { new Guid("443f0257-feb8-4408-9b5e-a75c676453f8"), null, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("9c3849a0-cbf9-4f3a-89d0-00a948d853cb") },
                    { new Guid("4fe950b9-227f-4646-b9b1-d46eb357d4ef"), null, "Баллы за труды с грифом в соавторстве:", 9, new Guid("1c4fc68d-3409-41f7-809f-cdc3b34a0243") },
                    { new Guid("5c4b0b26-6e5a-47e3-8b3d-fd69b29d0fd2"), null, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("d299e65d-4ad5-4cee-99dd-1ac6abfe1b2a") },
                    { new Guid("88e4a97c-def0-4a2a-a34f-7ac8637915aa"), new Guid("733f5938-579b-4393-8c4e-acbf2f48948f"), "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("991662b8-a449-45e2-9122-4acb93c0d7bc"), new Guid("77e46c32-2b56-4d81-b043-ff61c6af4c37"), "Баллы за ученое звание:", 13, null },
                    { new Guid("9c683209-2bc0-498a-9322-56471f1a371f"), null, "Баллы за труды без грифа в соавторстве:", 11, new Guid("1c4fc68d-3409-41f7-809f-cdc3b34a0243") },
                    { new Guid("a40819d6-3730-432b-a56e-3c3800ac8c4c"), null, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("d17160f7-fa8e-467d-88e8-bbfc32442f20") },
                    { new Guid("af1c9c12-adc8-4767-a617-8403ab32e3d2"), null, "Баллы за количество разработок:", 24, new Guid("3c4b6ed1-56ea-4f71-a591-1c6f0b10d819") },
                    { new Guid("af327f13-d7f1-4b14-9172-3ec807a15a6c"), null, "Баллы по базе Scopus:", 17, new Guid("83f54004-1fc8-4c74-8e47-02cf941de0f3") },
                    { new Guid("bcca23f5-e353-4d3e-b860-de2810bfe158"), null, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("d392e8bb-d667-4308-a489-8ed071be5d6e") },
                    { new Guid("c51b811c-b0d8-44ff-bbdd-1414209d7870"), null, "Баллы за труды без грифа и без соавторства:", 10, new Guid("1c4fc68d-3409-41f7-809f-cdc3b34a0243") },
                    { new Guid("cf4365a8-e6d1-4ef5-8b86-8d0c4a6f6055"), null, "Баллы за труды с грифом и без соавторства:", 8, new Guid("1c4fc68d-3409-41f7-809f-cdc3b34a0243") },
                    { new Guid("e9ff14cb-b476-4a84-a88e-58dfdf36d117"), null, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("9f7ee56e-fa4a-4b03-a9a4-27fb416851b7") },
                    { new Guid("ecd284df-3ad7-4266-9137-ebbf38f46052"), null, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("b0ff3bbc-b9c3-41fb-8c31-15fad932da83") },
                    { new Guid("f3f88843-f588-4876-a6c5-bb34cf393294"), null, "Баллы за профессиональное развитие:", 15, new Guid("541417e0-1140-44be-b702-4472fb0dc523") },
                    { new Guid("fe3c074d-7f97-4299-ad78-41e4167a41e3"), new Guid("a8c5537e-f68e-4e3d-8a64-a67f97dce2d3"), "Баллы за количество защитившихся докторов наук:", 20, null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("027b7dc8-cbb1-478d-9f86-7b40af56d5d8"), new Guid("443f0257-feb8-4408-9b5e-a75c676453f8") },
                    { new Guid("027b7dc8-cbb1-478d-9f86-7b40af56d5d8"), new Guid("4fe950b9-227f-4646-b9b1-d46eb357d4ef") },
                    { new Guid("027b7dc8-cbb1-478d-9f86-7b40af56d5d8"), new Guid("9c683209-2bc0-498a-9322-56471f1a371f") },
                    { new Guid("027b7dc8-cbb1-478d-9f86-7b40af56d5d8"), new Guid("c51b811c-b0d8-44ff-bbdd-1414209d7870") },
                    { new Guid("027b7dc8-cbb1-478d-9f86-7b40af56d5d8"), new Guid("cf4365a8-e6d1-4ef5-8b86-8d0c4a6f6055") },
                    { new Guid("25776156-d171-4192-bd2b-00f8739c6649"), new Guid("063afdcf-e956-41c4-9cbe-7b28d799a0bb") },
                    { new Guid("25776156-d171-4192-bd2b-00f8739c6649"), new Guid("216ac99d-2527-4d59-9108-555774c2410a") },
                    { new Guid("25776156-d171-4192-bd2b-00f8739c6649"), new Guid("227988bb-7e96-4864-92ab-7ba65de0cac0") },
                    { new Guid("25776156-d171-4192-bd2b-00f8739c6649"), new Guid("2cd940a1-04fa-4f32-817a-7823f3b6022f") },
                    { new Guid("25776156-d171-4192-bd2b-00f8739c6649"), new Guid("5c4b0b26-6e5a-47e3-8b3d-fd69b29d0fd2") },
                    { new Guid("25776156-d171-4192-bd2b-00f8739c6649"), new Guid("bcca23f5-e353-4d3e-b860-de2810bfe158") },
                    { new Guid("25776156-d171-4192-bd2b-00f8739c6649"), new Guid("ecd284df-3ad7-4266-9137-ebbf38f46052") },
                    { new Guid("41c0cbcd-14e0-4087-a355-4bbc2fb6c45a"), new Guid("3fb5631a-dcb0-40c3-9276-ab2bea495ef5") },
                    { new Guid("41c0cbcd-14e0-4087-a355-4bbc2fb6c45a"), new Guid("991662b8-a449-45e2-9122-4acb93c0d7bc") },
                    { new Guid("41c0cbcd-14e0-4087-a355-4bbc2fb6c45a"), new Guid("f3f88843-f588-4876-a6c5-bb34cf393294") },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), new Guid("0036a46e-5c25-4b38-86ea-1752debc80d0") },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), new Guid("0612d964-438d-4e26-843f-b6f008bcf915") },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), new Guid("1bfcb989-46c2-4d98-88d7-7b56bbcda8f2") },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), new Guid("3fb5631a-dcb0-40c3-9276-ab2bea495ef5") },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), new Guid("88e4a97c-def0-4a2a-a34f-7ac8637915aa") },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), new Guid("991662b8-a449-45e2-9122-4acb93c0d7bc") },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), new Guid("a40819d6-3730-432b-a56e-3c3800ac8c4c") },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), new Guid("af327f13-d7f1-4b14-9172-3ec807a15a6c") },
                    { new Guid("49666092-a1e0-4077-bc0a-1612b76ff32a"), new Guid("fe3c074d-7f97-4299-ad78-41e4167a41e3") },
                    { new Guid("b4e99c06-3c49-43ab-ab59-3c4f7131a5ed"), new Guid("af1c9c12-adc8-4767-a617-8403ab32e3d2") },
                    { new Guid("b4e99c06-3c49-43ab-ab59-3c4f7131a5ed"), new Guid("e9ff14cb-b476-4a84-a88e-58dfdf36d117") },
                    { new Guid("b4e99c06-3c49-43ab-ab59-3c4f7131a5ed"), new Guid("f3f88843-f588-4876-a6c5-bb34cf393294") }
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
                name: "IX_Columns_ValueTypeId",
                table: "Columns",
                column: "ValueTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DataTypes_Name",
                table: "DataTypes",
                column: "Name",
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
                name: "IX_Fields_ValueTypeId",
                table: "Fields",
                column: "ValueTypeId");

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
                name: "DataTypes");

            migrationBuilder.DropTable(
                name: "EditBlocks");
        }
    }
}
