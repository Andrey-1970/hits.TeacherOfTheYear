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
                name: "ValueTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValueTypes", x => x.Id);
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
                        name: "FK_Fields_EditBlocks_EditBlockId",
                        column: x => x.EditBlockId,
                        principalTable: "EditBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fields_ValueTypes_ValueTypeId",
                        column: x => x.ValueTypeId,
                        principalTable: "ValueTypes",
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
                        name: "FK_Columns_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Columns_ValueTypes_ValueTypeId",
                        column: x => x.ValueTypeId,
                        principalTable: "ValueTypes",
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
                name: "SelectValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    FieldId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ColumnId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectValues_Columns_ColumnId",
                        column: x => x.ColumnId,
                        principalTable: "Columns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SelectValues_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Fields",
                        principalColumn: "Id");
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

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("09532e26-2d28-4877-9f04-6e7a710ed05f"), "Деятельность", 5 },
                    { new Guid("1841f718-f40c-4df9-9ebf-b2bc21fb9514"), "Деятельность", 4 },
                    { new Guid("9a4f902c-a939-4d44-9f47-27dc2ee7c721"), "Категория участников", 2 },
                    { new Guid("ce56e7d5-446d-43ff-8272-bb2c669de1e9"), "Профессиональное развитие", 3 },
                    { new Guid("e0db3a1a-958e-4d42-a0a7-27e2ebd3500e"), "Общая информация", 1 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("1230511b-f7db-408b-a611-8964cc2fbcf1"), "Конкурсная работа", 7 },
                    { new Guid("38bf0bde-9687-4697-ae43-271441aa8323"), "Инновационная и иная деятельность", 6 },
                    { new Guid("51c5bdb8-f9ca-4bb1-a61c-8c9814f6532e"), "Методическая деятельность", 3 },
                    { new Guid("ac5284ae-7889-45a5-8274-35365db2e3f1"), "Итог", 8 },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("d710a6c3-4f51-4556-960a-af0ee3c09ac4"), "Профессиональные показатели", 4 },
                    { new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061"), "Основной", 1 },
                    { new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e"), "Образовательная деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("e839e3bb-dfac-4707-8788-ae0dca814205"), null, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("f9fd728e-ea92-49db-9f42-456319e8f043"), null, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("1e62019a-fde5-4cd0-90c2-a4629cdfa00d"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("8a011dae-7d45-476a-9710-39cd6e4cd5bf"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("33a68cec-d017-4f91-89ec-9dc34ee7771e"), "User 2", "user@mail.ru" },
                    { new Guid("6a2288f8-baea-40f9-8aef-d3f883d11706"), "User 1", "admin@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1036f8af-9386-4332-8de2-126399de5aec"), "string" },
                    { new Guid("18d4a1dd-5e77-4887-958a-4dd767394779"), "int" },
                    { new Guid("8cdabb26-e943-453e-b7f7-4ca9dc0c9b8a"), "bool" },
                    { new Guid("cfa2eea3-e14e-4493-8da5-c5a81aa0096f"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("09532e26-2d28-4877-9f04-6e7a710ed05f"), new Guid("8a011dae-7d45-476a-9710-39cd6e4cd5bf") },
                    { new Guid("1841f718-f40c-4df9-9ebf-b2bc21fb9514"), new Guid("1e62019a-fde5-4cd0-90c2-a4629cdfa00d") },
                    { new Guid("9a4f902c-a939-4d44-9f47-27dc2ee7c721"), new Guid("1e62019a-fde5-4cd0-90c2-a4629cdfa00d") },
                    { new Guid("9a4f902c-a939-4d44-9f47-27dc2ee7c721"), new Guid("8a011dae-7d45-476a-9710-39cd6e4cd5bf") },
                    { new Guid("ce56e7d5-446d-43ff-8272-bb2c669de1e9"), new Guid("1e62019a-fde5-4cd0-90c2-a4629cdfa00d") },
                    { new Guid("ce56e7d5-446d-43ff-8272-bb2c669de1e9"), new Guid("8a011dae-7d45-476a-9710-39cd6e4cd5bf") },
                    { new Guid("e0db3a1a-958e-4d42-a0a7-27e2ebd3500e"), new Guid("1e62019a-fde5-4cd0-90c2-a4629cdfa00d") },
                    { new Guid("e0db3a1a-958e-4d42-a0a7-27e2ebd3500e"), new Guid("8a011dae-7d45-476a-9710-39cd6e4cd5bf") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0dad3e48-09ff-4fe8-a3dc-4e25e204fba7"), new Guid("e0db3a1a-958e-4d42-a0a7-27e2ebd3500e"), null, "Место работы/учебы", 6, "Название организации", new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("393da3a1-0483-4c21-8df6-9299246354a9"), new Guid("9a4f902c-a939-4d44-9f47-27dc2ee7c721"), null, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 13, "Выберите категорию участника конкруса", new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("39a539eb-a82a-4858-b5f3-1b23822bcea7"), new Guid("9a4f902c-a939-4d44-9f47-27dc2ee7c721"), null, "Название конкрусной работы", 14, "Введите название своей конкурсной работы", new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("3e5bfb56-78ab-4b62-8c73-18e4fd1f4ea0"), new Guid("9a4f902c-a939-4d44-9f47-27dc2ee7c721"), null, "Направление конкурса", 12, "Выберите направление конкурса", new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("40da641f-bc14-4cd0-ae4e-0e2985df0ad3"), new Guid("e0db3a1a-958e-4d42-a0a7-27e2ebd3500e"), null, "Должность", 9, "Введите свою должность в организации", new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("4370237b-cb19-4eef-b9ef-fd62178eb224"), new Guid("09532e26-2d28-4877-9f04-6e7a710ed05f"), null, "Защитившиеся доктора наук", 24, "Введите количество", new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("588a5a3f-a39b-4952-8a2d-0cfeb36f0c69"), new Guid("e0db3a1a-958e-4d42-a0a7-27e2ebd3500e"), null, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("591ef9c2-a85d-4d40-a658-43fab6e73656"), new Guid("e0db3a1a-958e-4d42-a0a7-27e2ebd3500e"), null, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("5bfce4e2-d1ac-4abe-877a-c04676e1c25f"), new Guid("e0db3a1a-958e-4d42-a0a7-27e2ebd3500e"), null, "ФИО", 1, "Иванов Иван Иванович", new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("7277b79c-d78d-49ac-82f6-4647d5a8aae8"), new Guid("9a4f902c-a939-4d44-9f47-27dc2ee7c721"), null, "Научная специальность (по классификации ВАК)", 17, "Введите научную специальность (по классификации ВАК)", new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("8c7dee90-4d75-481c-bfcc-c23849bf6745"), new Guid("1841f718-f40c-4df9-9ebf-b2bc21fb9514"), "Руководство дипломными проектами за предыдущий учебный год", "Защитившиеся бакалавры", 20, "Введите количество", new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("92cbb652-818d-4b84-8513-eabf8e6545e0"), new Guid("9a4f902c-a939-4d44-9f47-27dc2ee7c721"), null, "Ученая степень", 16, "Выберите ученую степень", new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("9a9cf9db-5ab8-4d8d-8971-4c9d4ac9e4ed"), new Guid("9a4f902c-a939-4d44-9f47-27dc2ee7c721"), null, "Ученое звание", 15, "Выберите ученое звание", new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("9ca64c68-2d63-4405-96e9-72de243a1971"), new Guid("1841f718-f40c-4df9-9ebf-b2bc21fb9514"), null, "Защитившиеся магистры", 22, "Введите количество", new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("9decef32-e026-4a31-97e0-d278c168d9a8"), new Guid("1841f718-f40c-4df9-9ebf-b2bc21fb9514"), null, "Защитившиеся доктора наук", 19, "Введите количество", new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("a6f0948a-e2d1-4aa5-aef5-7529c1093fe5"), new Guid("09532e26-2d28-4877-9f04-6e7a710ed05f"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", "Защитившиеся кандидаты наук", 23, "Введите количество", new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("ae5f4dca-c293-44c1-a55b-cc19189bd394"), new Guid("e0db3a1a-958e-4d42-a0a7-27e2ebd3500e"), null, "Дополнительная информация", 11, "Пример", new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("b6c8cafb-bea0-43c0-afa6-7ee01b47c1ca"), new Guid("e0db3a1a-958e-4d42-a0a7-27e2ebd3500e"), null, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("c29e276d-c9bc-46e7-bf0c-ce06c3a6c984"), new Guid("e0db3a1a-958e-4d42-a0a7-27e2ebd3500e"), null, "Дата рождения", 2, "01.01.2000", new Guid("cfa2eea3-e14e-4493-8da5-c5a81aa0096f") },
                    { new Guid("c649c228-0457-4c5e-aa55-9d45bcdeadb5"), new Guid("1841f718-f40c-4df9-9ebf-b2bc21fb9514"), null, "Защитившиеся специалисты", 21, "Введите количество", new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("e52f4fb7-ce33-40de-9edd-9f5f8fefc3d3"), new Guid("1841f718-f40c-4df9-9ebf-b2bc21fb9514"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", "Защитившиеся кадидаты наук", 18, "Введите количество", new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("f33818b4-4f03-4be4-92cd-0589772c131c"), new Guid("e0db3a1a-958e-4d42-a0a7-27e2ebd3500e"), null, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("f78dc198-26a7-4f07-8808-d9392c7b55e3"), new Guid("e0db3a1a-958e-4d42-a0a7-27e2ebd3500e"), null, "Электронная почта", 5, "user@example.com", new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("ffe38875-bb66-41be-8858-35636e2a17e5"), new Guid("e0db3a1a-958e-4d42-a0a7-27e2ebd3500e"), null, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("1230511b-f7db-408b-a611-8964cc2fbcf1"), new Guid("1e62019a-fde5-4cd0-90c2-a4629cdfa00d") },
                    { new Guid("1230511b-f7db-408b-a611-8964cc2fbcf1"), new Guid("8a011dae-7d45-476a-9710-39cd6e4cd5bf") },
                    { new Guid("38bf0bde-9687-4697-ae43-271441aa8323"), new Guid("8a011dae-7d45-476a-9710-39cd6e4cd5bf") },
                    { new Guid("51c5bdb8-f9ca-4bb1-a61c-8c9814f6532e"), new Guid("1e62019a-fde5-4cd0-90c2-a4629cdfa00d") },
                    { new Guid("ac5284ae-7889-45a5-8274-35365db2e3f1"), new Guid("1e62019a-fde5-4cd0-90c2-a4629cdfa00d") },
                    { new Guid("ac5284ae-7889-45a5-8274-35365db2e3f1"), new Guid("8a011dae-7d45-476a-9710-39cd6e4cd5bf") },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), new Guid("8a011dae-7d45-476a-9710-39cd6e4cd5bf") },
                    { new Guid("d710a6c3-4f51-4556-960a-af0ee3c09ac4"), new Guid("1e62019a-fde5-4cd0-90c2-a4629cdfa00d") },
                    { new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061"), new Guid("1e62019a-fde5-4cd0-90c2-a4629cdfa00d") },
                    { new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061"), new Guid("8a011dae-7d45-476a-9710-39cd6e4cd5bf") },
                    { new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e"), new Guid("1e62019a-fde5-4cd0-90c2-a4629cdfa00d") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("38bf0bde-9687-4697-ae43-271441aa8323"), new Guid("e839e3bb-dfac-4707-8788-ae0dca814205") },
                    { new Guid("38bf0bde-9687-4697-ae43-271441aa8323"), new Guid("f9fd728e-ea92-49db-9f42-456319e8f043") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("01525d5a-d4a0-4e1a-94c7-056d7dac68b2"), new Guid("09532e26-2d28-4877-9f04-6e7a710ed05f"), "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("3c5cb8fb-936b-4bcc-8a3f-a7bad0a00bc0"), new Guid("1841f718-f40c-4df9-9ebf-b2bc21fb9514"), "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("6c8d2bb9-fd47-4c3b-8524-539aad009bf3"), new Guid("09532e26-2d28-4877-9f04-6e7a710ed05f"), "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("78d11403-f2b6-4295-a283-69f8e57d87ab"), new Guid("1841f718-f40c-4df9-9ebf-b2bc21fb9514"), "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("7de4de08-2ab3-4108-8d37-578e8e5e6a82"), new Guid("1841f718-f40c-4df9-9ebf-b2bc21fb9514"), "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("9a5ed757-4049-4b9a-8bf2-d9022b29135c"), new Guid("09532e26-2d28-4877-9f04-6e7a710ed05f"), "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("a41adff7-9ca5-453a-aba9-cdfae07bfaa8"), new Guid("1841f718-f40c-4df9-9ebf-b2bc21fb9514"), "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("c520ffcd-97c6-4d22-818c-067e8ac83184"), new Guid("09532e26-2d28-4877-9f04-6e7a710ed05f"), "Персональные идентификаторы и показатели", 10 },
                    { new Guid("c672ba6e-3028-46e1-af58-74279355e171"), new Guid("1841f718-f40c-4df9-9ebf-b2bc21fb9514"), "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("d3e03f86-f01a-4e24-9678-b3d225364157"), new Guid("1841f718-f40c-4df9-9ebf-b2bc21fb9514"), "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 },
                    { new Guid("e6962ea4-b9e8-42c7-95b0-87af64391ca9"), new Guid("ce56e7d5-446d-43ff-8272-bb2c669de1e9"), "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("f3d224ae-f6d1-4af4-958b-8bc0014bd840"), new Guid("09532e26-2d28-4877-9f04-6e7a710ed05f"), "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("fb960f02-8add-4c73-8eed-0a08bcdb7e06"), new Guid("ce56e7d5-446d-43ff-8272-bb2c669de1e9"), "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("03a8d508-5f97-4e0d-8160-06265eb75739"), "Название разработки", 2, new Guid("f3d224ae-f6d1-4af4-958b-8bc0014bd840"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("078e9f18-ee30-40bb-90bf-4b8c8cae4003"), "Количество публикаций в БАЗЕ", 3, new Guid("c520ffcd-97c6-4d22-818c-067e8ac83184"), new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("07d9d6b3-9fd0-413e-a4f2-b1625e9cca62"), "Название курса", 1, new Guid("c672ba6e-3028-46e1-af58-74279355e171"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("106dd7d1-df03-4a83-a162-891b0422ee2e"), "Наименование курса", 1, new Guid("a41adff7-9ca5-453a-aba9-cdfae07bfaa8"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("186d22f6-7ffa-4659-bacd-29d97506c752"), "Соавторы", 2, new Guid("6c8d2bb9-fd47-4c3b-8524-539aad009bf3"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("2c93717d-6803-4e2f-a977-bca3748fcfc3"), "Название статьи", 1, new Guid("6c8d2bb9-fd47-4c3b-8524-539aad009bf3"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("2eeaf0a5-7276-4e5e-a0ba-19151c98bae6"), "Количество часов", 4, new Guid("7de4de08-2ab3-4108-8d37-578e8e5e6a82"), new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("399423c9-62e4-4aa4-a768-d6d66a65e8ab"), "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("78d11403-f2b6-4295-a283-69f8e57d87ab"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("3eddd1be-8dfe-4127-8aaf-a17e3d089f40"), "Вид", 1, new Guid("9a5ed757-4049-4b9a-8bf2-d9022b29135c"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("46aa2ea6-88c2-4827-84cd-81df0fde7c4c"), "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("6c8d2bb9-fd47-4c3b-8524-539aad009bf3"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("475b0293-091b-415b-bcaa-6d294c4326f6"), "Название документа, реквизиты", 1, new Guid("fb960f02-8add-4c73-8eed-0a08bcdb7e06"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("4f2f5869-90f9-4dc3-bdbe-889bcf20306a"), "Название НИР/НИОКР", 1, new Guid("01525d5a-d4a0-4e1a-94c7-056d7dac68b2"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("52d3ef34-2f23-45e3-a9fa-da68b43d470f"), "Наличие грифа", 5, new Guid("d3e03f86-f01a-4e24-9678-b3d225364157"), new Guid("8cdabb26-e943-453e-b7f7-4ca9dc0c9b8a") },
                    { new Guid("585a1d90-7675-48fc-9707-2f0f18a1375c"), "Период выполнения", 3, new Guid("01525d5a-d4a0-4e1a-94c7-056d7dac68b2"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("58bfb7d8-534a-45dd-a2a6-fdedee3d9a78"), "Награда", 4, new Guid("e6962ea4-b9e8-42c7-95b0-87af64391ca9"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("658647db-4261-4ed8-8cf8-994ef4b94134"), "Год", 3, new Guid("78d11403-f2b6-4295-a283-69f8e57d87ab"), new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("670882fc-8fda-4fd7-8a19-079fc3f1df54"), "ФИО", 1, new Guid("78d11403-f2b6-4295-a283-69f8e57d87ab"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("67456d04-4c01-4629-b1d1-09ef7ac0ec1d"), "Ссылка на платформу", 3, new Guid("c672ba6e-3028-46e1-af58-74279355e171"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("69e6b74a-cd75-4972-9186-9dfc91cdc365"), "Номер РИД", 4, new Guid("9a5ed757-4049-4b9a-8bf2-d9022b29135c"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("6c89319a-5493-4002-8c38-4693b5cf3405"), "Практические занятия (час.)", 4, new Guid("a41adff7-9ca5-453a-aba9-cdfae07bfaa8"), new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("712012d1-6abc-46f7-9cd9-5fbc44a3390e"), "Количество цитирований", 4, new Guid("c520ffcd-97c6-4d22-818c-067e8ac83184"), new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("7620d988-bab2-4b89-a2d2-55da6c6ce7a1"), "Вид (лекции, лабораторные)", 2, new Guid("3c5cb8fb-936b-4bcc-8a3f-a7bad0a00bc0"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("7996878b-c7a2-4c04-9fa6-4da98ce36fa7"), "Издание, год", 4, new Guid("6c8d2bb9-fd47-4c3b-8524-539aad009bf3"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("80b78371-a1a5-4afb-87c0-74cbf057f659"), "Издательство, год", 6, new Guid("d3e03f86-f01a-4e24-9678-b3d225364157"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("81b3b8c1-620f-4add-bcaf-20b2dae73a6c"), "Название дисциплины", 1, new Guid("3c5cb8fb-936b-4bcc-8a3f-a7bad0a00bc0"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("868bc78d-7e82-4342-b945-4ca9442b8867"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("78d11403-f2b6-4295-a283-69f8e57d87ab"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("889ecc9a-8300-4659-ae5e-648d15dd2925"), "Лекции (час.)", 3, new Guid("a41adff7-9ca5-453a-aba9-cdfae07bfaa8"), new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("9006e30b-49d2-4a3f-b7e8-46f8877174d0"), "Год", 4, new Guid("c672ba6e-3028-46e1-af58-74279355e171"), new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("928cd406-7dd6-48f1-8df3-d0e13e6b7fe0"), "Вид деятельности (преподавательская)", 3, new Guid("7de4de08-2ab3-4108-8d37-578e8e5e6a82"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("93ef822e-725c-4dee-a324-124d52ffd7a1"), "Соавторы", 3, new Guid("d3e03f86-f01a-4e24-9678-b3d225364157"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("976eddb3-7d79-428c-846b-5e5a10374b51"), "Название", 2, new Guid("d3e03f86-f01a-4e24-9678-b3d225364157"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("99b4773f-1c96-4ba6-a180-54123398e50e"), "Год получения документа", 2, new Guid("fb960f02-8add-4c73-8eed-0a08bcdb7e06"), new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("a583915e-113d-4ebc-93d0-0cd4ddd433b6"), "Язык преподавания (русск./англ./др.)", 2, new Guid("a41adff7-9ca5-453a-aba9-cdfae07bfaa8"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("a695c48c-aa2a-4083-9308-cd59d2fdae2b"), "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("7de4de08-2ab3-4108-8d37-578e8e5e6a82"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("a70e48aa-4da8-4b75-8fb7-a30f5003d578"), "Сумма финансирования (тыс. руб.)", 2, new Guid("01525d5a-d4a0-4e1a-94c7-056d7dac68b2"), new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("a8d40d89-1a4b-4230-8fa4-54c34f679876"), "Название", 2, new Guid("9a5ed757-4049-4b9a-8bf2-d9022b29135c"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("ad8ab7bc-d785-4c32-8ad4-6be387a9c94c"), "ФИО соавторов", 3, new Guid("9a5ed757-4049-4b9a-8bf2-d9022b29135c"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("add70215-51b9-442b-b47d-7f91e8803d67"), "Ссылка", 5, new Guid("e6962ea4-b9e8-42c7-95b0-87af64391ca9"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("af493375-5a6e-4499-aa6b-3f64bcf5468b"), "Итого (час.)", 5, new Guid("a41adff7-9ca5-453a-aba9-cdfae07bfaa8"), new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("b7cb5f78-c394-4b6f-86af-35ea8d2b53e3"), "Название конкурса", 2, new Guid("e6962ea4-b9e8-42c7-95b0-87af64391ca9"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("bb7b0a1a-98ca-4992-aeec-9c9ac42b2d58"), "Тип идентификатора", 1, new Guid("c520ffcd-97c6-4d22-818c-067e8ac83184"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("bd7bc9c3-dd28-45cb-a4e0-a716d9b3b01a"), "Название конкурса/премии", 2, new Guid("78d11403-f2b6-4295-a283-69f8e57d87ab"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("bf345d57-7170-453f-a337-d5d8428c44a0"), "Название организации в которую внедрена разработка", 3, new Guid("f3d224ae-f6d1-4af4-958b-8bc0014bd840"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("c4a35f72-ea9c-4ff8-a6d2-3cf60faa4b8e"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("01525d5a-d4a0-4e1a-94c7-056d7dac68b2"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("c58824ac-f095-4aa3-b21f-114e736489f4"), "Соавторы", 2, new Guid("c672ba6e-3028-46e1-af58-74279355e171"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("c74c0825-e277-4c41-b1e3-dbfe7cad5656"), "Вид", 1, new Guid("f3d224ae-f6d1-4af4-958b-8bc0014bd840"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("c7cc4801-e1f0-48cd-a7f0-18404c6d069d"), "Статус конкурса", 3, new Guid("e6962ea4-b9e8-42c7-95b0-87af64391ca9"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("cf2258ed-9a08-443c-8fc8-2328480f1264"), "Вид публикации", 1, new Guid("d3e03f86-f01a-4e24-9678-b3d225364157"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("cf7ef57a-2ebf-4d40-adae-57b965ae40af"), "Идентификатор", 2, new Guid("c520ffcd-97c6-4d22-818c-067e8ac83184"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("d3f3aba2-a3a0-4323-805d-6865ad24c652"), "Название организации/должность/ставка", 1, new Guid("7de4de08-2ab3-4108-8d37-578e8e5e6a82"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("dcc471c5-8a86-421f-b0e2-3b078100399c"), "Индекс Хирша (за все время)", 5, new Guid("c520ffcd-97c6-4d22-818c-067e8ac83184"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("deb9788e-5b66-4666-9c92-d5cf9351231f"), "Статус (руководитель/исполнитель)", 4, new Guid("01525d5a-d4a0-4e1a-94c7-056d7dac68b2"), new Guid("1036f8af-9386-4332-8de2-126399de5aec") },
                    { new Guid("fca0e6fa-df27-4336-a01a-c8fa272a6d65"), "Год", 1, new Guid("e6962ea4-b9e8-42c7-95b0-87af64391ca9"), new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") },
                    { new Guid("fefba724-70b7-4c9d-ad21-d965ff60a401"), "Количество печатных листов", 4, new Guid("d3e03f86-f01a-4e24-9678-b3d225364157"), new Guid("18d4a1dd-5e77-4887-958a-4dd767394779") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("0dad3e48-09ff-4fe8-a3dc-4e25e204fba7"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("393da3a1-0483-4c21-8df6-9299246354a9"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("39a539eb-a82a-4858-b5f3-1b23822bcea7"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("3e5bfb56-78ab-4b62-8c73-18e4fd1f4ea0"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("40da641f-bc14-4cd0-ae4e-0e2985df0ad3"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("4370237b-cb19-4eef-b9ef-fd62178eb224"), new Guid("d394e72f-66b1-4f08-be40-feb742527f3f") },
                    { new Guid("588a5a3f-a39b-4952-8a2d-0cfeb36f0c69"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("591ef9c2-a85d-4d40-a658-43fab6e73656"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("5bfce4e2-d1ac-4abe-877a-c04676e1c25f"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("7277b79c-d78d-49ac-82f6-4647d5a8aae8"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("8c7dee90-4d75-481c-bfcc-c23849bf6745"), new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e") },
                    { new Guid("92cbb652-818d-4b84-8513-eabf8e6545e0"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("9a9cf9db-5ab8-4d8d-8971-4c9d4ac9e4ed"), new Guid("d394e72f-66b1-4f08-be40-feb742527f3f") },
                    { new Guid("9a9cf9db-5ab8-4d8d-8971-4c9d4ac9e4ed"), new Guid("d710a6c3-4f51-4556-960a-af0ee3c09ac4") },
                    { new Guid("9a9cf9db-5ab8-4d8d-8971-4c9d4ac9e4ed"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("9ca64c68-2d63-4405-96e9-72de243a1971"), new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e") },
                    { new Guid("9decef32-e026-4a31-97e0-d278c168d9a8"), new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e") },
                    { new Guid("a6f0948a-e2d1-4aa5-aef5-7529c1093fe5"), new Guid("d394e72f-66b1-4f08-be40-feb742527f3f") },
                    { new Guid("ae5f4dca-c293-44c1-a55b-cc19189bd394"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("b6c8cafb-bea0-43c0-afa6-7ee01b47c1ca"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("c29e276d-c9bc-46e7-bf0c-ce06c3a6c984"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("c649c228-0457-4c5e-aa55-9d45bcdeadb5"), new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e") },
                    { new Guid("e52f4fb7-ce33-40de-9edd-9f5f8fefc3d3"), new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e") },
                    { new Guid("f33818b4-4f03-4be4-92cd-0589772c131c"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("f78dc198-26a7-4f07-8808-d9392c7b55e3"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") },
                    { new Guid("ffe38875-bb66-41be-8858-35636e2a17e5"), new Guid("f5a5f191-6c78-4499-b895-5ee0e6b54061") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("38bf0bde-9687-4697-ae43-271441aa8323"), new Guid("9a5ed757-4049-4b9a-8bf2-d9022b29135c") },
                    { new Guid("38bf0bde-9687-4697-ae43-271441aa8323"), new Guid("f3d224ae-f6d1-4af4-958b-8bc0014bd840") },
                    { new Guid("38bf0bde-9687-4697-ae43-271441aa8323"), new Guid("fb960f02-8add-4c73-8eed-0a08bcdb7e06") },
                    { new Guid("51c5bdb8-f9ca-4bb1-a61c-8c9814f6532e"), new Guid("3c5cb8fb-936b-4bcc-8a3f-a7bad0a00bc0") },
                    { new Guid("51c5bdb8-f9ca-4bb1-a61c-8c9814f6532e"), new Guid("d3e03f86-f01a-4e24-9678-b3d225364157") },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), new Guid("01525d5a-d4a0-4e1a-94c7-056d7dac68b2") },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), new Guid("6c8d2bb9-fd47-4c3b-8524-539aad009bf3") },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), new Guid("c520ffcd-97c6-4d22-818c-067e8ac83184") },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), new Guid("e6962ea4-b9e8-42c7-95b0-87af64391ca9") },
                    { new Guid("d710a6c3-4f51-4556-960a-af0ee3c09ac4"), new Guid("e6962ea4-b9e8-42c7-95b0-87af64391ca9") },
                    { new Guid("d710a6c3-4f51-4556-960a-af0ee3c09ac4"), new Guid("fb960f02-8add-4c73-8eed-0a08bcdb7e06") },
                    { new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e"), new Guid("78d11403-f2b6-4295-a283-69f8e57d87ab") },
                    { new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e"), new Guid("7de4de08-2ab3-4108-8d37-578e8e5e6a82") },
                    { new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e"), new Guid("a41adff7-9ca5-453a-aba9-cdfae07bfaa8") },
                    { new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e"), new Guid("c672ba6e-3028-46e1-af58-74279355e171") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0933b7ab-7ede-41e0-b769-6ef4010be2c7"), null, "Баллы по базе Scopus:", 17, new Guid("c520ffcd-97c6-4d22-818c-067e8ac83184") },
                    { new Guid("0958ac4b-05a0-4884-8032-3e1fde3953cf"), null, "Баллы по базе РИНЦ:", 18, new Guid("c520ffcd-97c6-4d22-818c-067e8ac83184") },
                    { new Guid("0ab3f8c6-9f50-4694-a3da-f0b06ee318dc"), null, "Баллы за профессиональное развитие:", 15, new Guid("fb960f02-8add-4c73-8eed-0a08bcdb7e06") },
                    { new Guid("1e74357e-bbc2-4c5a-9238-74c38397ab4d"), null, "Баллы за труды с грифом в соавторстве:", 9, new Guid("d3e03f86-f01a-4e24-9678-b3d225364157") },
                    { new Guid("1eff8874-c4ee-4ecd-9287-43b0f8568287"), null, "Баллы за труды без грифа и без соавторства:", 10, new Guid("d3e03f86-f01a-4e24-9678-b3d225364157") },
                    { new Guid("31deefbc-698a-4d57-850c-4a2b008ef833"), null, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("3c5cb8fb-936b-4bcc-8a3f-a7bad0a00bc0") },
                    { new Guid("41d58669-0c42-4ad6-835f-538a3e647274"), null, "Баллы за труды без грифа в соавторстве:", 11, new Guid("d3e03f86-f01a-4e24-9678-b3d225364157") },
                    { new Guid("4303b008-802c-4cbb-878a-6c9b8991a56a"), null, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("78d11403-f2b6-4295-a283-69f8e57d87ab") },
                    { new Guid("4706b05c-aa15-4bd6-8850-89a44dcab086"), null, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("01525d5a-d4a0-4e1a-94c7-056d7dac68b2") },
                    { new Guid("541cc36d-ce4c-49ce-994a-525097028857"), null, "Баллы за награды:", 14, new Guid("e6962ea4-b9e8-42c7-95b0-87af64391ca9") },
                    { new Guid("55884316-aa03-4838-8c30-f4e6fb83cc38"), new Guid("e52f4fb7-ce33-40de-9edd-9f5f8fefc3d3"), "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("5d77f987-bfa5-4145-ad8e-e75c71bfb486"), null, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("c672ba6e-3028-46e1-af58-74279355e171") },
                    { new Guid("6048f22a-e133-4333-b09c-6ad7a1857704"), new Guid("4370237b-cb19-4eef-b9ef-fd62178eb224"), "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("6542eb48-0302-4180-b546-bff6207b490b"), null, "Баллы за труды с грифом и без соавторства:", 8, new Guid("d3e03f86-f01a-4e24-9678-b3d225364157") },
                    { new Guid("6582b4f9-a973-4404-9301-b2678401faad"), new Guid("a6f0948a-e2d1-4aa5-aef5-7529c1093fe5"), "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("8bb7b1e2-5368-4d05-8047-f625d0c39cfd"), null, "Баллы за объем учебной нагрузки:", 1, new Guid("a41adff7-9ca5-453a-aba9-cdfae07bfaa8") },
                    { new Guid("a90f21ab-0da0-4171-8418-fcb8cb62c4be"), null, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("a41adff7-9ca5-453a-aba9-cdfae07bfaa8") },
                    { new Guid("ac049182-d7a3-4974-831b-b44bd8f0fef1"), new Guid("9a9cf9db-5ab8-4d8d-8971-4c9d4ac9e4ed"), "Баллы за ученое звание:", 13, null },
                    { new Guid("ac3d3a89-f86c-42c1-928d-1d4b0eef7d89"), new Guid("9ca64c68-2d63-4405-96e9-72de243a1971"), "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("aeb8aeff-caa5-4545-8c97-c71699aec934"), null, "Баллы за научные публикации:", 16, new Guid("6c8d2bb9-fd47-4c3b-8524-539aad009bf3") },
                    { new Guid("bbb6a0a8-9c2a-4be5-82d5-0d6f5f8d1437"), null, "Баллы за количество разработок:", 24, new Guid("f3d224ae-f6d1-4af4-958b-8bc0014bd840") },
                    { new Guid("db5a8fd6-1fd9-4f47-9764-e79ae83cd2a0"), null, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("01525d5a-d4a0-4e1a-94c7-056d7dac68b2") },
                    { new Guid("de9c4b40-5869-43e3-9f08-c11ddf963d8b"), new Guid("9decef32-e026-4a31-97e0-d278c168d9a8"), "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("ecb43a9b-724e-4a90-a0f0-e7b13214b378"), null, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("9a5ed757-4049-4b9a-8bf2-d9022b29135c") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("179f9bce-2b9e-421f-bf9a-9793245ce992"), null, new Guid("3e5bfb56-78ab-4b62-8c73-18e4fd1f4ea0"), "АРХИТЕКТУРА" },
                    { new Guid("1956c9e0-e1d2-4c15-921a-bc712e7a1cca"), null, new Guid("3e5bfb56-78ab-4b62-8c73-18e4fd1f4ea0"), "ПРИКЛАДНАЯ ГЕОЛОГИЯ, ГОРНОЕ ДЕЛО, НЕФТЕГАЗОВОЕ ДЕЛО И ГЕОДЕЗИЯ" },
                    { new Guid("20b69325-a189-42c2-927a-53d1b4ff124c"), null, new Guid("393da3a1-0483-4c21-8df6-9299246354a9"), "Имеющие ученую степень доктора наук" },
                    { new Guid("3aef07ae-055d-49b9-9648-7f0335bb26bb"), null, new Guid("3e5bfb56-78ab-4b62-8c73-18e4fd1f4ea0"), "ЭЛЕКТРО- И ТЕПЛОЭНЕРГЕТИКА" },
                    { new Guid("3e9df638-d069-4b36-9322-e6c4a7ab207f"), null, new Guid("3e5bfb56-78ab-4b62-8c73-18e4fd1f4ea0"), "ТЕХНИКА И ТЕХНОЛОГИИ СТРОИТЕЛЬСТВА" },
                    { new Guid("3ee35f42-9d7e-42a8-b2de-682adff8d13e"), null, new Guid("393da3a1-0483-4c21-8df6-9299246354a9"), "Аспиранты, адъюнкты, ординаторы, ассистенты-стажеры, не имеющие ученой степени" },
                    { new Guid("44a41881-58e4-41c8-b91a-169e1f48943e"), null, new Guid("393da3a1-0483-4c21-8df6-9299246354a9"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("5244aa6e-d5ec-4c16-910e-487fcb8a5269"), null, new Guid("3e5bfb56-78ab-4b62-8c73-18e4fd1f4ea0"), "НЕДРОПОЛЬЗОВАНИЕ И ГОРНЫЕ НАУКИ" },
                    { new Guid("6fca2e38-f024-46f4-8d69-11c98a7ae519"), null, new Guid("9a9cf9db-5ab8-4d8d-8971-4c9d4ac9e4ed"), "Доцент" },
                    { new Guid("b909448b-dad1-425f-af11-24df6e343146"), null, new Guid("3e5bfb56-78ab-4b62-8c73-18e4fd1f4ea0"), "СТРОИТЕЛЬСТВО И АРХИТЕКТУРА" },
                    { new Guid("de707aae-a749-4191-ba79-720d745e7208"), null, new Guid("9a9cf9db-5ab8-4d8d-8971-4c9d4ac9e4ed"), "Нет" },
                    { new Guid("e90a15d7-211a-4223-957d-fcc50499962e"), null, new Guid("9a9cf9db-5ab8-4d8d-8971-4c9d4ac9e4ed"), "Профессор" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("38bf0bde-9687-4697-ae43-271441aa8323"), new Guid("0ab3f8c6-9f50-4694-a3da-f0b06ee318dc") },
                    { new Guid("38bf0bde-9687-4697-ae43-271441aa8323"), new Guid("bbb6a0a8-9c2a-4be5-82d5-0d6f5f8d1437") },
                    { new Guid("38bf0bde-9687-4697-ae43-271441aa8323"), new Guid("ecb43a9b-724e-4a90-a0f0-e7b13214b378") },
                    { new Guid("51c5bdb8-f9ca-4bb1-a61c-8c9814f6532e"), new Guid("1e74357e-bbc2-4c5a-9238-74c38397ab4d") },
                    { new Guid("51c5bdb8-f9ca-4bb1-a61c-8c9814f6532e"), new Guid("1eff8874-c4ee-4ecd-9287-43b0f8568287") },
                    { new Guid("51c5bdb8-f9ca-4bb1-a61c-8c9814f6532e"), new Guid("31deefbc-698a-4d57-850c-4a2b008ef833") },
                    { new Guid("51c5bdb8-f9ca-4bb1-a61c-8c9814f6532e"), new Guid("41d58669-0c42-4ad6-835f-538a3e647274") },
                    { new Guid("51c5bdb8-f9ca-4bb1-a61c-8c9814f6532e"), new Guid("6542eb48-0302-4180-b546-bff6207b490b") },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), new Guid("0933b7ab-7ede-41e0-b769-6ef4010be2c7") },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), new Guid("0958ac4b-05a0-4884-8032-3e1fde3953cf") },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), new Guid("4706b05c-aa15-4bd6-8850-89a44dcab086") },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), new Guid("541cc36d-ce4c-49ce-994a-525097028857") },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), new Guid("6048f22a-e133-4333-b09c-6ad7a1857704") },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), new Guid("6582b4f9-a973-4404-9301-b2678401faad") },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), new Guid("ac049182-d7a3-4974-831b-b44bd8f0fef1") },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), new Guid("aeb8aeff-caa5-4545-8c97-c71699aec934") },
                    { new Guid("d394e72f-66b1-4f08-be40-feb742527f3f"), new Guid("db5a8fd6-1fd9-4f47-9764-e79ae83cd2a0") },
                    { new Guid("d710a6c3-4f51-4556-960a-af0ee3c09ac4"), new Guid("0ab3f8c6-9f50-4694-a3da-f0b06ee318dc") },
                    { new Guid("d710a6c3-4f51-4556-960a-af0ee3c09ac4"), new Guid("541cc36d-ce4c-49ce-994a-525097028857") },
                    { new Guid("d710a6c3-4f51-4556-960a-af0ee3c09ac4"), new Guid("ac049182-d7a3-4974-831b-b44bd8f0fef1") },
                    { new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e"), new Guid("4303b008-802c-4cbb-878a-6c9b8991a56a") },
                    { new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e"), new Guid("55884316-aa03-4838-8c30-f4e6fb83cc38") },
                    { new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e"), new Guid("5d77f987-bfa5-4145-ad8e-e75c71bfb486") },
                    { new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e"), new Guid("8bb7b1e2-5368-4d05-8047-f625d0c39cfd") },
                    { new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e"), new Guid("a90f21ab-0da0-4171-8418-fcb8cb62c4be") },
                    { new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e"), new Guid("ac3d3a89-f86c-42c1-928d-1d4b0eef7d89") },
                    { new Guid("fe83e54d-ca38-459f-ae3b-a18ef80aba5e"), new Guid("de9c4b40-5869-43e3-9f08-c11ddf963d8b") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0d355024-d7a1-4b6c-b3ba-806f2dd5a964"), new Guid("deb9788e-5b66-4666-9c92-d5cf9351231f"), null, "Руководитель" },
                    { new Guid("127fdfb4-8f0f-469b-a8d5-f08b8be0241e"), new Guid("cf2258ed-9a08-443c-8fc8-2328480f1264"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("2062f0b3-65f5-4d15-9f11-bbd69857f01b"), new Guid("deb9788e-5b66-4666-9c92-d5cf9351231f"), null, "Исполнитель" },
                    { new Guid("315a0996-1a54-4209-992b-eaadad896fde"), new Guid("3eddd1be-8dfe-4127-8aaf-a17e3d089f40"), null, "Изобретение" },
                    { new Guid("6606a79e-3622-417e-93c0-3a81b62a8ff5"), new Guid("7620d988-bab2-4b89-a2d2-55da6c6ce7a1"), null, "Лекции" },
                    { new Guid("7eb34e56-fafc-49a6-91ac-1dae7850cc42"), new Guid("c74c0825-e277-4c41-b1e3-dbfe7cad5656"), null, "База данных" },
                    { new Guid("806673b5-738d-46b4-b5df-6fc474fe8674"), new Guid("c7cc4801-e1f0-48cd-a7f0-18404c6d069d"), null, "Всероссийский" },
                    { new Guid("84821c7e-8ea4-4f97-9b65-8d7957852c47"), new Guid("3eddd1be-8dfe-4127-8aaf-a17e3d089f40"), null, "Полезная модель" },
                    { new Guid("953e3be4-66de-4bea-8b7d-22decbe97a3f"), new Guid("c7cc4801-e1f0-48cd-a7f0-18404c6d069d"), null, "Международный" },
                    { new Guid("95909036-94b6-4676-a541-f32373c3666b"), new Guid("c74c0825-e277-4c41-b1e3-dbfe7cad5656"), null, "Полезная модель" },
                    { new Guid("97273b7d-ba72-4530-b36c-325da2976347"), new Guid("7620d988-bab2-4b89-a2d2-55da6c6ce7a1"), null, "Лабораторные" },
                    { new Guid("ac9a0e08-be7a-40c2-95b5-902fb64783ec"), new Guid("c7cc4801-e1f0-48cd-a7f0-18404c6d069d"), null, "Региональный" },
                    { new Guid("b6e2ddaf-b64e-40ae-aadb-cc3aae884ea6"), new Guid("c74c0825-e277-4c41-b1e3-dbfe7cad5656"), null, "Изобретение" },
                    { new Guid("be729fa9-2621-493b-89a2-d985904d88ac"), new Guid("3eddd1be-8dfe-4127-8aaf-a17e3d089f40"), null, "База данных" },
                    { new Guid("e7e40a74-ba29-4332-9be3-c143a12b94cd"), new Guid("cf2258ed-9a08-443c-8fc8-2328480f1264"), null, "Монография" },
                    { new Guid("f0d6a777-32a1-418d-866c-0b4e1c3f14c6"), new Guid("cf2258ed-9a08-443c-8fc8-2328480f1264"), null, "Учебник" }
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
                name: "IX_SelectValues_ColumnId",
                table: "SelectValues",
                column: "ColumnId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectValues_FieldId",
                table: "SelectValues",
                column: "FieldId");

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

            migrationBuilder.CreateIndex(
                name: "IX_ValueTypes_Name",
                table: "ValueTypes",
                column: "Name",
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
                name: "SelectValues");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Rows");

            migrationBuilder.DropTable(
                name: "MarkBlocks");

            migrationBuilder.DropTable(
                name: "ApplicationForms");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Columns");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "ValueTypes");

            migrationBuilder.DropTable(
                name: "EditBlocks");
        }
    }
}
