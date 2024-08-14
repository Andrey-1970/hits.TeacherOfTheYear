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
                    { new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), "Общая информация", 1 },
                    { new Guid("be53a9b7-1077-45f2-a98a-519de649ba45"), "Деятельность", 5 },
                    { new Guid("c9e44221-8cc1-40c2-94ce-cf4cef8079bb"), "Деятельность", 4 },
                    { new Guid("e60c1b17-53a8-41ef-bda6-c87150775f2f"), "Профессиональное развитие", 3 },
                    { new Guid("eb903dca-629d-4ca3-8273-d01c4092f507"), "Категория участников", 2 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("2decad65-f50b-4f10-a808-1c84481bc2db"), "Образовательная деятельность", 2 },
                    { new Guid("34a61449-cd30-4bed-8bfe-796c0c4cc5d8"), "Конкурсная работа", 7 },
                    { new Guid("575d385c-af86-4f3e-bdad-2f646b65416c"), "Итог", 8 },
                    { new Guid("9251bf4f-33ec-48d8-9dc9-ba8ba583f18b"), "Инновационная и иная деятельность", 6 },
                    { new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558"), "Основной", 1 },
                    { new Guid("a26be941-b582-4db4-8523-65e03ba599d6"), "Методическая деятельность", 3 },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("ffbc6ec1-8106-4b4d-9e2a-27de1b6511e7"), "Профессиональные показатели", 4 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("186d8fd9-237e-47d3-b6c9-3901c89718f1"), null, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null },
                    { new Guid("df25077f-32a3-4f45-be0d-2b55a63c3911"), null, "Оценка уровня предоставленной работы:", 25, null }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("4be0890b-3929-49d9-9ca9-54a3bfa5431d"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("f4ea384a-471f-4889-836d-a8c07fbe6217"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("492de33f-5ea2-45ee-b28c-35c958fe5d13"), "User 2", "user@mail.ru" },
                    { new Guid("62aa620e-8503-4cc4-82db-636ba4a91cb6"), "User 1", "admin@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), new Guid("4be0890b-3929-49d9-9ca9-54a3bfa5431d") },
                    { new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), new Guid("f4ea384a-471f-4889-836d-a8c07fbe6217") },
                    { new Guid("be53a9b7-1077-45f2-a98a-519de649ba45"), new Guid("4be0890b-3929-49d9-9ca9-54a3bfa5431d") },
                    { new Guid("c9e44221-8cc1-40c2-94ce-cf4cef8079bb"), new Guid("f4ea384a-471f-4889-836d-a8c07fbe6217") },
                    { new Guid("e60c1b17-53a8-41ef-bda6-c87150775f2f"), new Guid("4be0890b-3929-49d9-9ca9-54a3bfa5431d") },
                    { new Guid("e60c1b17-53a8-41ef-bda6-c87150775f2f"), new Guid("f4ea384a-471f-4889-836d-a8c07fbe6217") },
                    { new Guid("eb903dca-629d-4ca3-8273-d01c4092f507"), new Guid("4be0890b-3929-49d9-9ca9-54a3bfa5431d") },
                    { new Guid("eb903dca-629d-4ca3-8273-d01c4092f507"), new Guid("f4ea384a-471f-4889-836d-a8c07fbe6217") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "Name" },
                values: new object[,]
                {
                    { new Guid("0e178e7c-5da7-4216-8430-4b6e549bd828"), new Guid("eb903dca-629d-4ca3-8273-d01c4092f507"), "Ученая степень" },
                    { new Guid("10a2b74a-c52e-4080-a130-babd45d12c1f"), new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), "Место работы/учебы" },
                    { new Guid("189c548e-f10d-4a96-9521-a953416596c5"), new Guid("eb903dca-629d-4ca3-8273-d01c4092f507"), "Название конкрусной работы" },
                    { new Guid("1ebd60cb-a46d-432b-b600-0a3ed32928ce"), new Guid("c9e44221-8cc1-40c2-94ce-cf4cef8079bb"), "Защитившиеся специалисты" },
                    { new Guid("20549a44-39f4-4292-8da2-a758f1b5d1f0"), new Guid("eb903dca-629d-4ca3-8273-d01c4092f507"), "Направление конкурса" },
                    { new Guid("2b9f5e91-75e0-4adc-aedc-b26d529d8e3c"), new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), "Должность" },
                    { new Guid("338fb84a-0c9e-4457-8635-ab9b849a1aca"), new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), "ФИО" },
                    { new Guid("47ba2af5-31ed-4853-8038-abed661880db"), new Guid("eb903dca-629d-4ca3-8273-d01c4092f507"), "Категория участника конкурса" },
                    { new Guid("4e94f172-9e1a-4dfe-b562-ecf9e1ca1711"), new Guid("c9e44221-8cc1-40c2-94ce-cf4cef8079bb"), "Защитившиеся кадидаты наук" },
                    { new Guid("6c2315cf-73b5-4b22-8419-c3f8d92a4b12"), new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), "Дополнительная информация" },
                    { new Guid("73d6dacb-9f35-4ed0-81fd-13b65e2c7ae3"), new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), "Контактный телефон" },
                    { new Guid("83b13b96-3229-40c4-b8db-895bed68a045"), new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), "Стаж научно-педагогической деятельности по трудовой книжке" },
                    { new Guid("89ea4bf9-a55b-4cb6-a9dc-22d1729d02fd"), new Guid("eb903dca-629d-4ca3-8273-d01c4092f507"), "Научная специальность (по классификации ВАК)" },
                    { new Guid("8a04e363-a91e-49c2-87c9-539e92936adb"), new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), "Трек конкурса" },
                    { new Guid("947fa01c-1120-4a54-93cb-678f78db3bf4"), new Guid("be53a9b7-1077-45f2-a98a-519de649ba45"), "Защитившиеся кандидаты наук" },
                    { new Guid("b1579d57-0f2d-4dc8-b972-156b5d90f329"), new Guid("be53a9b7-1077-45f2-a98a-519de649ba45"), "Защитившиеся доктора наук" },
                    { new Guid("c26c4cbf-7180-48f1-88ef-b892a92ed550"), new Guid("c9e44221-8cc1-40c2-94ce-cf4cef8079bb"), "Защитившиеся магистры" },
                    { new Guid("c46d4100-73af-4ad4-a593-72777efa2517"), new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), "Электронная почта" },
                    { new Guid("cb093415-e415-447f-a295-f600609c3caf"), new Guid("c9e44221-8cc1-40c2-94ce-cf4cef8079bb"), "Защитившиеся бакалавры" },
                    { new Guid("d42900f5-c457-4a43-9c00-6326881d2a7c"), new Guid("eb903dca-629d-4ca3-8273-d01c4092f507"), "Ученое звание" },
                    { new Guid("d6a018b6-e1a7-4c07-bb69-4e2a1ac764c2"), new Guid("c9e44221-8cc1-40c2-94ce-cf4cef8079bb"), "Защитившиеся доктора наук" },
                    { new Guid("df9c1083-4fb5-40c2-a006-fb4c21d55033"), new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), "Домашний адрес" },
                    { new Guid("e6b61874-067c-4ede-b640-e841f15175b4"), new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), "Институт, факультет, кафедра, лаборатория" },
                    { new Guid("e9b198c3-ded0-4c8b-846d-9936704b3c70"), new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), "Адрес работы/учебы" },
                    { new Guid("f44aa3f5-cdd1-4d1d-adbb-b04cd848c85b"), new Guid("66e562ba-e327-4a6a-9ce1-9e24fd13e0d9"), "Дата рождения" }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("2decad65-f50b-4f10-a808-1c84481bc2db"), new Guid("f4ea384a-471f-4889-836d-a8c07fbe6217") },
                    { new Guid("34a61449-cd30-4bed-8bfe-796c0c4cc5d8"), new Guid("4be0890b-3929-49d9-9ca9-54a3bfa5431d") },
                    { new Guid("34a61449-cd30-4bed-8bfe-796c0c4cc5d8"), new Guid("f4ea384a-471f-4889-836d-a8c07fbe6217") },
                    { new Guid("575d385c-af86-4f3e-bdad-2f646b65416c"), new Guid("4be0890b-3929-49d9-9ca9-54a3bfa5431d") },
                    { new Guid("575d385c-af86-4f3e-bdad-2f646b65416c"), new Guid("f4ea384a-471f-4889-836d-a8c07fbe6217") },
                    { new Guid("9251bf4f-33ec-48d8-9dc9-ba8ba583f18b"), new Guid("4be0890b-3929-49d9-9ca9-54a3bfa5431d") },
                    { new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558"), new Guid("4be0890b-3929-49d9-9ca9-54a3bfa5431d") },
                    { new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558"), new Guid("f4ea384a-471f-4889-836d-a8c07fbe6217") },
                    { new Guid("a26be941-b582-4db4-8523-65e03ba599d6"), new Guid("f4ea384a-471f-4889-836d-a8c07fbe6217") },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), new Guid("4be0890b-3929-49d9-9ca9-54a3bfa5431d") },
                    { new Guid("ffbc6ec1-8106-4b4d-9e2a-27de1b6511e7"), new Guid("f4ea384a-471f-4889-836d-a8c07fbe6217") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("9251bf4f-33ec-48d8-9dc9-ba8ba583f18b"), new Guid("186d8fd9-237e-47d3-b6c9-3901c89718f1") },
                    { new Guid("9251bf4f-33ec-48d8-9dc9-ba8ba583f18b"), new Guid("df25077f-32a3-4f45-be0d-2b55a63c3911") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "Name" },
                values: new object[,]
                {
                    { new Guid("03f01a21-a1db-44d4-b626-3d4294e0dae8"), new Guid("be53a9b7-1077-45f2-a98a-519de649ba45"), "Персональные идентификаторы и показатели" },
                    { new Guid("33628ce2-3249-44bc-908f-1f83073fcf0e"), new Guid("c9e44221-8cc1-40c2-94ce-cf4cef8079bb"), "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год" },
                    { new Guid("4431fb00-3c12-4bbe-898d-89a7eb12f3a1"), new Guid("c9e44221-8cc1-40c2-94ce-cf4cef8079bb"), "Учебная нагрузка за предыдущий учебный год (за исключением методической)" },
                    { new Guid("44a2645d-9f84-4e1f-b102-de3f56c88608"), new Guid("c9e44221-8cc1-40c2-94ce-cf4cef8079bb"), "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание" },
                    { new Guid("7a1253ee-dfb2-4ea4-ad81-18554a50c679"), new Guid("c9e44221-8cc1-40c2-94ce-cf4cef8079bb"), "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет" },
                    { new Guid("8f2a9d8a-d985-4933-9126-b32f30046fff"), new Guid("be53a9b7-1077-45f2-a98a-519de649ba45"), "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет" },
                    { new Guid("ad33d55f-b245-48f1-83f5-8f6da86c430f"), new Guid("e60c1b17-53a8-41ef-bda6-c87150775f2f"), "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)" },
                    { new Guid("b17ab907-db9a-42ca-8256-061b9d54901e"), new Guid("be53a9b7-1077-45f2-a98a-519de649ba45"), "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)" },
                    { new Guid("bc9ecde1-ca33-497e-a8cf-bd4d8ff51eb1"), new Guid("c9e44221-8cc1-40c2-94ce-cf4cef8079bb"), "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет" },
                    { new Guid("c7fbad2d-2251-4c30-abbe-dda700d0ed01"), new Guid("be53a9b7-1077-45f2-a98a-519de649ba45"), "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)" },
                    { new Guid("d284f120-f032-43a0-a2a1-c822e85187d8"), new Guid("e60c1b17-53a8-41ef-bda6-c87150775f2f"), "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности" },
                    { new Guid("da8ec277-522c-455d-8049-74161d372420"), new Guid("c9e44221-8cc1-40c2-94ce-cf4cef8079bb"), "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет" },
                    { new Guid("fcf0afb6-abea-4017-81ff-f0a0e13ff4ee"), new Guid("be53a9b7-1077-45f2-a98a-519de649ba45"), "Список научных публикаций за последние 5 лет" }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "TableId" },
                values: new object[,]
                {
                    { new Guid("1284171a-01c5-449a-bfc9-a07a35996430"), "Соавторы", new Guid("bc9ecde1-ca33-497e-a8cf-bd4d8ff51eb1") },
                    { new Guid("149017e9-7cb4-476a-a3f3-d192b40677f5"), "Вид", new Guid("c7fbad2d-2251-4c30-abbe-dda700d0ed01") },
                    { new Guid("18c5f23f-dbd1-4f8a-87b7-9201782ce3ba"), "Название организации/должность/ставка", new Guid("33628ce2-3249-44bc-908f-1f83073fcf0e") },
                    { new Guid("1d64eb4c-b578-49f4-9434-5ad858672b08"), "Количество публикаций в БАЗЕ", new Guid("03f01a21-a1db-44d4-b626-3d4294e0dae8") },
                    { new Guid("1e55df56-495f-41df-9c9b-42f992096176"), "Название курса", new Guid("da8ec277-522c-455d-8049-74161d372420") },
                    { new Guid("2029b445-7cd1-42d3-8bf5-64d46d8c5f53"), "Статус конкурса", new Guid("d284f120-f032-43a0-a2a1-c822e85187d8") },
                    { new Guid("24799812-c92c-4668-904c-f888e99ce85d"), "Статус (руководитель/исполнитель)", new Guid("8f2a9d8a-d985-4933-9126-b32f30046fff") },
                    { new Guid("24b14436-b2a1-4433-90ca-0a08bd82340b"), "Вид (лекции, лабораторные)", new Guid("7a1253ee-dfb2-4ea4-ad81-18554a50c679") },
                    { new Guid("29492011-6527-48b2-b9f8-fd2870e897e1"), "Название конкурса/премии", new Guid("44a2645d-9f84-4e1f-b102-de3f56c88608") },
                    { new Guid("33d0a8dd-2d93-4337-b986-316957883d76"), "Лекции (час.)", new Guid("4431fb00-3c12-4bbe-898d-89a7eb12f3a1") },
                    { new Guid("37c29bb3-a969-44ef-9d6a-33766dc329c1"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", new Guid("8f2a9d8a-d985-4933-9126-b32f30046fff") },
                    { new Guid("3942139e-556a-401a-9780-a847aabdd1ab"), "Итого (час.)", new Guid("4431fb00-3c12-4bbe-898d-89a7eb12f3a1") },
                    { new Guid("3b6c4f41-44a5-4b9e-a8f1-3b9be6b5b1d0"), "Номер РИД", new Guid("c7fbad2d-2251-4c30-abbe-dda700d0ed01") },
                    { new Guid("4a26a3eb-5b2e-4056-96fd-4794b3e782de"), "Соавторы", new Guid("fcf0afb6-abea-4017-81ff-f0a0e13ff4ee") },
                    { new Guid("637ab11c-6adc-4c49-94a7-7a0e28bca6a2"), "Вид публикации", new Guid("bc9ecde1-ca33-497e-a8cf-bd4d8ff51eb1") },
                    { new Guid("6cfbc568-a749-441f-8bf7-4284157b1793"), "Название", new Guid("bc9ecde1-ca33-497e-a8cf-bd4d8ff51eb1") },
                    { new Guid("707b742b-f3a3-452d-a854-cecf1dd8df0b"), "Индекс Хирша (за все время)", new Guid("03f01a21-a1db-44d4-b626-3d4294e0dae8") },
                    { new Guid("7245923b-ff5e-44ad-b391-ac50c08d77ac"), "Сумма финансирования (тыс. руб.)", new Guid("8f2a9d8a-d985-4933-9126-b32f30046fff") },
                    { new Guid("7456befe-9400-44c7-af9a-354160581d4a"), "Тип публикации (категория ВАК/квартиль МБД)", new Guid("fcf0afb6-abea-4017-81ff-f0a0e13ff4ee") },
                    { new Guid("74e26aea-aca5-4011-8e70-4ef53921deaf"), "Наличие грифа", new Guid("bc9ecde1-ca33-497e-a8cf-bd4d8ff51eb1") },
                    { new Guid("75052542-c38d-46fe-867e-dade52b8ceb3"), "Название статьи", new Guid("fcf0afb6-abea-4017-81ff-f0a0e13ff4ee") },
                    { new Guid("78e329ce-e5cb-4f8e-b49f-50d0606ca1a5"), "Год получения документа", new Guid("ad33d55f-b245-48f1-83f5-8f6da86c430f") },
                    { new Guid("7ab92f3c-6182-44ab-abd1-19fd52607008"), "Издательство, год", new Guid("bc9ecde1-ca33-497e-a8cf-bd4d8ff51eb1") },
                    { new Guid("7afee4fc-dee8-4f67-95d3-297f2ce44047"), "Название", new Guid("c7fbad2d-2251-4c30-abbe-dda700d0ed01") },
                    { new Guid("842c796f-7687-4cc6-a6b2-f42fc1c73fbe"), "Название НИР/НИОКР", new Guid("8f2a9d8a-d985-4933-9126-b32f30046fff") },
                    { new Guid("85df1818-fb84-458f-9105-b69dc1b0ed64"), "Издание, год", new Guid("fcf0afb6-abea-4017-81ff-f0a0e13ff4ee") },
                    { new Guid("968e1993-5705-480f-9fb6-0cb8e6c7812b"), "Название разработки", new Guid("b17ab907-db9a-42ca-8256-061b9d54901e") },
                    { new Guid("98f8364f-e536-43a0-ad3a-317abbbdf82b"), "Практические занятия (час.)", new Guid("4431fb00-3c12-4bbe-898d-89a7eb12f3a1") },
                    { new Guid("9cd8302a-b9cd-4bf7-951a-46a447f14c76"), "ФИО", new Guid("44a2645d-9f84-4e1f-b102-de3f56c88608") },
                    { new Guid("a3254fa9-305b-419b-b0af-5ef89f946df3"), "Награда/премия (медаль, диплом с указанием степени)", new Guid("44a2645d-9f84-4e1f-b102-de3f56c88608") },
                    { new Guid("a73edc8c-9dba-4645-8d42-68871ef6f2c0"), "Период выполнения", new Guid("8f2a9d8a-d985-4933-9126-b32f30046fff") },
                    { new Guid("a8020d42-10b7-49b9-b0b5-d98f285e992b"), "Название организации в которую внедрена разработка", new Guid("b17ab907-db9a-42ca-8256-061b9d54901e") },
                    { new Guid("ac655514-7c70-4ee5-bf5f-dcc31a8f64fb"), "Наименование курса", new Guid("4431fb00-3c12-4bbe-898d-89a7eb12f3a1") },
                    { new Guid("ad2fac7c-5f53-41bf-a0ec-8d59bd55f9fa"), "Название конкурса", new Guid("d284f120-f032-43a0-a2a1-c822e85187d8") },
                    { new Guid("afcbd092-75cf-4619-9f29-073e9fc96f94"), "Год", new Guid("44a2645d-9f84-4e1f-b102-de3f56c88608") },
                    { new Guid("b0707cde-32c2-413d-98db-c5692e2b78bb"), "Вид деятельности (преподавательская)", new Guid("33628ce2-3249-44bc-908f-1f83073fcf0e") },
                    { new Guid("b14fa938-8ff0-4c03-8c02-fdb1a3fa652f"), "Тип идентификатора", new Guid("03f01a21-a1db-44d4-b626-3d4294e0dae8") },
                    { new Guid("c981029b-4d02-46bb-8e27-242a96837df3"), "Название дисциплины", new Guid("7a1253ee-dfb2-4ea4-ad81-18554a50c679") },
                    { new Guid("d01fda78-da38-4bc4-8c0f-c74ba4996780"), "ФИО соавторов", new Guid("c7fbad2d-2251-4c30-abbe-dda700d0ed01") },
                    { new Guid("d313024e-2b43-43ea-9f74-6607f6f8f96e"), "Название документа, реквизиты", new Guid("ad33d55f-b245-48f1-83f5-8f6da86c430f") },
                    { new Guid("d36fb57c-6dc8-437a-be80-7b4a8013370e"), "Место нахождения (субъект РФ, зарубежье)", new Guid("33628ce2-3249-44bc-908f-1f83073fcf0e") },
                    { new Guid("d6282df2-4787-4c0a-8d04-c42c2917b4d0"), "Количество печатных листов", new Guid("bc9ecde1-ca33-497e-a8cf-bd4d8ff51eb1") },
                    { new Guid("d9e59948-6a4b-46c1-a2e3-39a71267968f"), "Язык преподавания (русск./англ./др.)", new Guid("4431fb00-3c12-4bbe-898d-89a7eb12f3a1") },
                    { new Guid("de768af3-2b13-442c-aa04-8c8cb611f44c"), "Ссылка", new Guid("d284f120-f032-43a0-a2a1-c822e85187d8") },
                    { new Guid("eef7b277-8cf3-4441-9d7d-acb323843bbf"), "Ссылка на платформу", new Guid("da8ec277-522c-455d-8049-74161d372420") },
                    { new Guid("f1f6524d-1c24-41f2-9a9f-b303aaaa6d1e"), "Количество цитирований", new Guid("03f01a21-a1db-44d4-b626-3d4294e0dae8") },
                    { new Guid("f2037cc5-adbd-4d90-8939-9f76bd2a6dd1"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", new Guid("44a2645d-9f84-4e1f-b102-de3f56c88608") },
                    { new Guid("f2177310-3f85-49c7-a83f-ca3a48f66888"), "Год", new Guid("da8ec277-522c-455d-8049-74161d372420") },
                    { new Guid("f44f75ee-c3b4-45eb-b40b-93c52f473ff5"), "Идентификатор", new Guid("03f01a21-a1db-44d4-b626-3d4294e0dae8") },
                    { new Guid("f74cea98-3c00-47a9-a278-e8e742d98d8e"), "Вид", new Guid("b17ab907-db9a-42ca-8256-061b9d54901e") },
                    { new Guid("f751ff89-4f46-42df-b831-bbc3c7ef6399"), "Год", new Guid("d284f120-f032-43a0-a2a1-c822e85187d8") },
                    { new Guid("fabfdb71-51cc-4236-9f9e-bba46e4fe746"), "Количество часов", new Guid("33628ce2-3249-44bc-908f-1f83073fcf0e") },
                    { new Guid("facd0262-d6d7-4600-ae7b-6242f7a4b1a9"), "Награда", new Guid("d284f120-f032-43a0-a2a1-c822e85187d8") },
                    { new Guid("fc27587d-0c06-49a3-a450-29d0716038f9"), "Соавторы", new Guid("da8ec277-522c-455d-8049-74161d372420") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("0e178e7c-5da7-4216-8430-4b6e549bd828"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("10a2b74a-c52e-4080-a130-babd45d12c1f"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("189c548e-f10d-4a96-9521-a953416596c5"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("1ebd60cb-a46d-432b-b600-0a3ed32928ce"), new Guid("2decad65-f50b-4f10-a808-1c84481bc2db") },
                    { new Guid("20549a44-39f4-4292-8da2-a758f1b5d1f0"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("2b9f5e91-75e0-4adc-aedc-b26d529d8e3c"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("338fb84a-0c9e-4457-8635-ab9b849a1aca"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("47ba2af5-31ed-4853-8038-abed661880db"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("4e94f172-9e1a-4dfe-b562-ecf9e1ca1711"), new Guid("2decad65-f50b-4f10-a808-1c84481bc2db") },
                    { new Guid("6c2315cf-73b5-4b22-8419-c3f8d92a4b12"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("73d6dacb-9f35-4ed0-81fd-13b65e2c7ae3"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("83b13b96-3229-40c4-b8db-895bed68a045"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("89ea4bf9-a55b-4cb6-a9dc-22d1729d02fd"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("8a04e363-a91e-49c2-87c9-539e92936adb"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("947fa01c-1120-4a54-93cb-678f78db3bf4"), new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44") },
                    { new Guid("b1579d57-0f2d-4dc8-b972-156b5d90f329"), new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44") },
                    { new Guid("c26c4cbf-7180-48f1-88ef-b892a92ed550"), new Guid("2decad65-f50b-4f10-a808-1c84481bc2db") },
                    { new Guid("c46d4100-73af-4ad4-a593-72777efa2517"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("cb093415-e415-447f-a295-f600609c3caf"), new Guid("2decad65-f50b-4f10-a808-1c84481bc2db") },
                    { new Guid("d42900f5-c457-4a43-9c00-6326881d2a7c"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("d42900f5-c457-4a43-9c00-6326881d2a7c"), new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44") },
                    { new Guid("d42900f5-c457-4a43-9c00-6326881d2a7c"), new Guid("ffbc6ec1-8106-4b4d-9e2a-27de1b6511e7") },
                    { new Guid("d6a018b6-e1a7-4c07-bb69-4e2a1ac764c2"), new Guid("2decad65-f50b-4f10-a808-1c84481bc2db") },
                    { new Guid("df9c1083-4fb5-40c2-a006-fb4c21d55033"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("e6b61874-067c-4ede-b640-e841f15175b4"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("e9b198c3-ded0-4c8b-846d-9936704b3c70"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") },
                    { new Guid("f44aa3f5-cdd1-4d1d-adbb-b04cd848c85b"), new Guid("9e859e4d-960b-454d-b9cc-cbabd7051558") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("2decad65-f50b-4f10-a808-1c84481bc2db"), new Guid("33628ce2-3249-44bc-908f-1f83073fcf0e") },
                    { new Guid("2decad65-f50b-4f10-a808-1c84481bc2db"), new Guid("4431fb00-3c12-4bbe-898d-89a7eb12f3a1") },
                    { new Guid("2decad65-f50b-4f10-a808-1c84481bc2db"), new Guid("44a2645d-9f84-4e1f-b102-de3f56c88608") },
                    { new Guid("2decad65-f50b-4f10-a808-1c84481bc2db"), new Guid("da8ec277-522c-455d-8049-74161d372420") },
                    { new Guid("9251bf4f-33ec-48d8-9dc9-ba8ba583f18b"), new Guid("ad33d55f-b245-48f1-83f5-8f6da86c430f") },
                    { new Guid("9251bf4f-33ec-48d8-9dc9-ba8ba583f18b"), new Guid("b17ab907-db9a-42ca-8256-061b9d54901e") },
                    { new Guid("9251bf4f-33ec-48d8-9dc9-ba8ba583f18b"), new Guid("c7fbad2d-2251-4c30-abbe-dda700d0ed01") },
                    { new Guid("a26be941-b582-4db4-8523-65e03ba599d6"), new Guid("7a1253ee-dfb2-4ea4-ad81-18554a50c679") },
                    { new Guid("a26be941-b582-4db4-8523-65e03ba599d6"), new Guid("bc9ecde1-ca33-497e-a8cf-bd4d8ff51eb1") },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), new Guid("03f01a21-a1db-44d4-b626-3d4294e0dae8") },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), new Guid("8f2a9d8a-d985-4933-9126-b32f30046fff") },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), new Guid("d284f120-f032-43a0-a2a1-c822e85187d8") },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), new Guid("fcf0afb6-abea-4017-81ff-f0a0e13ff4ee") },
                    { new Guid("ffbc6ec1-8106-4b4d-9e2a-27de1b6511e7"), new Guid("ad33d55f-b245-48f1-83f5-8f6da86c430f") },
                    { new Guid("ffbc6ec1-8106-4b4d-9e2a-27de1b6511e7"), new Guid("d284f120-f032-43a0-a2a1-c822e85187d8") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0600fca8-2eec-4cb9-8671-81b4303ef2fe"), null, "Баллы за награды:", 14, new Guid("d284f120-f032-43a0-a2a1-c822e85187d8") },
                    { new Guid("0eafbd43-731b-4fee-9ddb-bb48b241b815"), null, "Баллы за труды без грифа и без соавторства:", 10, new Guid("bc9ecde1-ca33-497e-a8cf-bd4d8ff51eb1") },
                    { new Guid("10b1ef00-7c69-453a-b84b-5c7e0b0b5189"), null, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("c7fbad2d-2251-4c30-abbe-dda700d0ed01") },
                    { new Guid("2011d9c2-74eb-4240-81e0-9a1ae49b35e2"), new Guid("4e94f172-9e1a-4dfe-b562-ecf9e1ca1711"), "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("20d6a93a-f88e-4295-abfd-74c30ee94d2c"), null, "Баллы за труды с грифом и без соавторства:", 8, new Guid("bc9ecde1-ca33-497e-a8cf-bd4d8ff51eb1") },
                    { new Guid("386c1780-054a-4859-8864-42338f4baf8c"), null, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("44a2645d-9f84-4e1f-b102-de3f56c88608") },
                    { new Guid("5f68f803-2528-4fb2-8ac0-26f22ace5b48"), null, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("4431fb00-3c12-4bbe-898d-89a7eb12f3a1") },
                    { new Guid("65b94465-5dfd-4cba-956c-2e3d76132f4a"), null, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("7a1253ee-dfb2-4ea4-ad81-18554a50c679") },
                    { new Guid("6c0f6fe7-e2ae-40fc-91d1-e98a3d3b1e8d"), null, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("8f2a9d8a-d985-4933-9126-b32f30046fff") },
                    { new Guid("978e11ba-7d80-4b9a-87cc-457c8d9c2c5a"), null, "Баллы за объем учебной нагрузки:", 1, new Guid("4431fb00-3c12-4bbe-898d-89a7eb12f3a1") },
                    { new Guid("9d7955f9-4c28-4bea-90c7-8c1cbe8dc04a"), null, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("8f2a9d8a-d985-4933-9126-b32f30046fff") },
                    { new Guid("9ec8ef4c-aa13-4e25-9068-a855be8a570b"), null, "Баллы по базе РИНЦ:", 18, new Guid("03f01a21-a1db-44d4-b626-3d4294e0dae8") },
                    { new Guid("a6fc3cf8-4471-43f4-953d-f5b0e39bb277"), null, "Баллы по базе Scopus:", 17, new Guid("03f01a21-a1db-44d4-b626-3d4294e0dae8") },
                    { new Guid("aad21056-e149-4b3d-9796-e44393dea66d"), null, "Баллы за научные публикации:", 16, new Guid("fcf0afb6-abea-4017-81ff-f0a0e13ff4ee") },
                    { new Guid("adadb3e6-d06e-49fa-bfec-7b5b58836a08"), null, "Баллы за труды без грифа в соавторстве:", 11, new Guid("bc9ecde1-ca33-497e-a8cf-bd4d8ff51eb1") },
                    { new Guid("b492cced-66e1-4177-8e8f-ce87df130627"), new Guid("d42900f5-c457-4a43-9c00-6326881d2a7c"), "Баллы за ученое звание:", 13, null },
                    { new Guid("bd327c8d-c694-4c4e-a750-41b703476ddd"), new Guid("c26c4cbf-7180-48f1-88ef-b892a92ed550"), "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("d430b644-6b65-44c0-a7af-086f27aafd33"), null, "Баллы за количество разработок:", 24, new Guid("b17ab907-db9a-42ca-8256-061b9d54901e") },
                    { new Guid("dfbe70b3-abbd-4cf3-8105-3bf0c00ae971"), new Guid("b1579d57-0f2d-4dc8-b972-156b5d90f329"), "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("e28d09db-4872-43ee-aa5e-7a2d9a3d7739"), null, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("da8ec277-522c-455d-8049-74161d372420") },
                    { new Guid("e73bf404-9609-4354-b7d5-b00ef1b6282b"), new Guid("947fa01c-1120-4a54-93cb-678f78db3bf4"), "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("e9bf9dae-577b-4010-ab99-ebbbdc632f7c"), null, "Баллы за труды с грифом в соавторстве:", 9, new Guid("bc9ecde1-ca33-497e-a8cf-bd4d8ff51eb1") },
                    { new Guid("efdf30f8-02ac-4c99-bbec-b797700c4746"), new Guid("d6a018b6-e1a7-4c07-bb69-4e2a1ac764c2"), "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("f05aebfd-0b12-4972-9120-05bb36509c53"), null, "Баллы за профессиональное развитие:", 15, new Guid("ad33d55f-b245-48f1-83f5-8f6da86c430f") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("2decad65-f50b-4f10-a808-1c84481bc2db"), new Guid("2011d9c2-74eb-4240-81e0-9a1ae49b35e2") },
                    { new Guid("2decad65-f50b-4f10-a808-1c84481bc2db"), new Guid("386c1780-054a-4859-8864-42338f4baf8c") },
                    { new Guid("2decad65-f50b-4f10-a808-1c84481bc2db"), new Guid("5f68f803-2528-4fb2-8ac0-26f22ace5b48") },
                    { new Guid("2decad65-f50b-4f10-a808-1c84481bc2db"), new Guid("978e11ba-7d80-4b9a-87cc-457c8d9c2c5a") },
                    { new Guid("2decad65-f50b-4f10-a808-1c84481bc2db"), new Guid("bd327c8d-c694-4c4e-a750-41b703476ddd") },
                    { new Guid("2decad65-f50b-4f10-a808-1c84481bc2db"), new Guid("e28d09db-4872-43ee-aa5e-7a2d9a3d7739") },
                    { new Guid("2decad65-f50b-4f10-a808-1c84481bc2db"), new Guid("efdf30f8-02ac-4c99-bbec-b797700c4746") },
                    { new Guid("9251bf4f-33ec-48d8-9dc9-ba8ba583f18b"), new Guid("10b1ef00-7c69-453a-b84b-5c7e0b0b5189") },
                    { new Guid("9251bf4f-33ec-48d8-9dc9-ba8ba583f18b"), new Guid("d430b644-6b65-44c0-a7af-086f27aafd33") },
                    { new Guid("9251bf4f-33ec-48d8-9dc9-ba8ba583f18b"), new Guid("f05aebfd-0b12-4972-9120-05bb36509c53") },
                    { new Guid("a26be941-b582-4db4-8523-65e03ba599d6"), new Guid("0eafbd43-731b-4fee-9ddb-bb48b241b815") },
                    { new Guid("a26be941-b582-4db4-8523-65e03ba599d6"), new Guid("20d6a93a-f88e-4295-abfd-74c30ee94d2c") },
                    { new Guid("a26be941-b582-4db4-8523-65e03ba599d6"), new Guid("65b94465-5dfd-4cba-956c-2e3d76132f4a") },
                    { new Guid("a26be941-b582-4db4-8523-65e03ba599d6"), new Guid("adadb3e6-d06e-49fa-bfec-7b5b58836a08") },
                    { new Guid("a26be941-b582-4db4-8523-65e03ba599d6"), new Guid("e9bf9dae-577b-4010-ab99-ebbbdc632f7c") },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), new Guid("0600fca8-2eec-4cb9-8671-81b4303ef2fe") },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), new Guid("6c0f6fe7-e2ae-40fc-91d1-e98a3d3b1e8d") },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), new Guid("9d7955f9-4c28-4bea-90c7-8c1cbe8dc04a") },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), new Guid("9ec8ef4c-aa13-4e25-9068-a855be8a570b") },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), new Guid("a6fc3cf8-4471-43f4-953d-f5b0e39bb277") },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), new Guid("aad21056-e149-4b3d-9796-e44393dea66d") },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), new Guid("b492cced-66e1-4177-8e8f-ce87df130627") },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), new Guid("dfbe70b3-abbd-4cf3-8105-3bf0c00ae971") },
                    { new Guid("fc5a8671-a825-4901-88c0-dce6fbb9da44"), new Guid("e73bf404-9609-4354-b7d5-b00ef1b6282b") },
                    { new Guid("ffbc6ec1-8106-4b4d-9e2a-27de1b6511e7"), new Guid("0600fca8-2eec-4cb9-8671-81b4303ef2fe") },
                    { new Guid("ffbc6ec1-8106-4b4d-9e2a-27de1b6511e7"), new Guid("b492cced-66e1-4177-8e8f-ce87df130627") },
                    { new Guid("ffbc6ec1-8106-4b4d-9e2a-27de1b6511e7"), new Guid("f05aebfd-0b12-4972-9120-05bb36509c53") }
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
