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
                    { new Guid("09b36f3d-9e08-4c9d-9f7c-2e5e78c7896b"), "Профессиональное развитие", 3 },
                    { new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), "Общая информация", 1 },
                    { new Guid("52ee2861-7adb-4800-a683-a677396af9ba"), "Категория участников", 2 },
                    { new Guid("8eb01d0e-5630-4578-ac7c-e0ad69e970b9"), "Деятельность", 4 },
                    { new Guid("f377852b-8f58-4948-9b0f-dcdd6fa50c6f"), "Деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2"), "Образовательная деятельность", 2 },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("67860afa-07f4-45d4-a4e0-e9ee33bca4bf"), "Профессиональные показатели", 4 },
                    { new Guid("bcb2d10d-820d-45bf-905c-56b3db405ede"), "Методическая деятельность", 3 },
                    { new Guid("bd76bc2e-76bf-4c7b-b8de-c9f03cf42870"), "Итог", 8 },
                    { new Guid("bea1a3d8-583b-4db7-9b9e-b1b6a6fc97ac"), "Инновационная и иная деятельность", 6 },
                    { new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35"), "Основной", 1 },
                    { new Guid("cbeaf8cb-4950-4051-8347-d3a3066d0105"), "Конкурсная работа", 7 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0338ae3f-0481-4905-a456-650857c2d35e"), null, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("e9eb147c-2736-4853-9573-454f4374945f"), null, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("a9602a44-6e7e-4984-8f26-7a77399e0860"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("f0e53511-cf51-4ae8-89a6-c1f20ede291a"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("7f089109-3eef-47f5-8d38-67dc33a60423"), "User 1", "admin@mail.ru" },
                    { new Guid("946916d5-1d57-4605-b98b-8a3502b0f40f"), "User 2", "user@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("09b36f3d-9e08-4c9d-9f7c-2e5e78c7896b"), new Guid("a9602a44-6e7e-4984-8f26-7a77399e0860") },
                    { new Guid("09b36f3d-9e08-4c9d-9f7c-2e5e78c7896b"), new Guid("f0e53511-cf51-4ae8-89a6-c1f20ede291a") },
                    { new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), new Guid("a9602a44-6e7e-4984-8f26-7a77399e0860") },
                    { new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), new Guid("f0e53511-cf51-4ae8-89a6-c1f20ede291a") },
                    { new Guid("52ee2861-7adb-4800-a683-a677396af9ba"), new Guid("a9602a44-6e7e-4984-8f26-7a77399e0860") },
                    { new Guid("52ee2861-7adb-4800-a683-a677396af9ba"), new Guid("f0e53511-cf51-4ae8-89a6-c1f20ede291a") },
                    { new Guid("8eb01d0e-5630-4578-ac7c-e0ad69e970b9"), new Guid("f0e53511-cf51-4ae8-89a6-c1f20ede291a") },
                    { new Guid("f377852b-8f58-4948-9b0f-dcdd6fa50c6f"), new Guid("a9602a44-6e7e-4984-8f26-7a77399e0860") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("00518d78-5b6a-4ff7-941a-424ae4b194d4"), new Guid("8eb01d0e-5630-4578-ac7c-e0ad69e970b9"), "Защитившиеся бакалавры", 21 },
                    { new Guid("1a2d2418-aa5a-4672-9804-f2cce7a69bec"), new Guid("8eb01d0e-5630-4578-ac7c-e0ad69e970b9"), "Защитившиеся доктора наук", 20 },
                    { new Guid("1d989ace-9259-4dd7-930e-371d22fb8288"), new Guid("52ee2861-7adb-4800-a683-a677396af9ba"), "Направление конкурса", 13 },
                    { new Guid("22046c92-aa2f-4f4a-b887-89896e7b9d31"), new Guid("52ee2861-7adb-4800-a683-a677396af9ba"), "Ученое звание", 16 },
                    { new Guid("403ec031-2945-4555-a023-b1712d5e906f"), new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), "Адрес работы/учебы", 8 },
                    { new Guid("46c2218e-26cb-4796-88c8-cf20b8d3708d"), new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), "ФИО", 2 },
                    { new Guid("4c34ffea-d401-44bc-b93b-cbdbd9bbdf62"), new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), "Место работы/учебы", 7 },
                    { new Guid("5883dfa4-f49d-40b6-9193-11d65c24a325"), new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), "Электронная почта", 6 },
                    { new Guid("69f8ef0e-4bd2-4406-8f90-fefefeeb5830"), new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), "Стаж научно-педагогической деятельности по трудовой книжке", 11 },
                    { new Guid("78cd04a3-9772-4825-bc16-eb7efd5c860f"), new Guid("8eb01d0e-5630-4578-ac7c-e0ad69e970b9"), "Защитившиеся магистры", 23 },
                    { new Guid("8dabc025-41c0-4da0-b642-e6c6446bdd76"), new Guid("f377852b-8f58-4948-9b0f-dcdd6fa50c6f"), "Защитившиеся кандидаты наук", 24 },
                    { new Guid("9136481f-ccb3-4067-bf4d-854f7aacc789"), new Guid("52ee2861-7adb-4800-a683-a677396af9ba"), "Категория участника конкурса", 14 },
                    { new Guid("a1ddb78e-3582-4529-b452-56e5fc44a06d"), new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), "Контактный телефон", 5 },
                    { new Guid("a73fc8a0-9b30-47df-80a1-369be00e62e2"), new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), "Домашний адрес", 4 },
                    { new Guid("af52c327-e339-4d2e-b019-327f854fad04"), new Guid("8eb01d0e-5630-4578-ac7c-e0ad69e970b9"), "Защитившиеся кадидаты наук", 19 },
                    { new Guid("b3f287d1-a3d9-4bc3-92f2-0379742c37ed"), new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), "Дата рождения", 3 },
                    { new Guid("b51f8665-833e-4de6-aa01-56ea3f3c7d76"), new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), "Трек конкурса", 1 },
                    { new Guid("bd8161ad-c681-43e6-9a20-53bc86e53383"), new Guid("52ee2861-7adb-4800-a683-a677396af9ba"), "Научная специальность (по классификации ВАК)", 18 },
                    { new Guid("c033f5aa-3bce-4621-95e1-5ef37ce4274f"), new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), "Институт, факультет, кафедра, лаборатория", 9 },
                    { new Guid("c3b2bdaa-fbd1-427c-80c1-37c92413cdca"), new Guid("f377852b-8f58-4948-9b0f-dcdd6fa50c6f"), "Защитившиеся доктора наук", 25 },
                    { new Guid("cddbdb77-fedd-4c44-8e83-581f83482553"), new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), "Дополнительная информация", 12 },
                    { new Guid("cded8e03-9466-42b1-a81e-0d51d6b1b6f9"), new Guid("52ee2861-7adb-4800-a683-a677396af9ba"), "Ученая степень", 17 },
                    { new Guid("d260c8b6-1104-4c2c-af3d-b712c429753e"), new Guid("52ee2861-7adb-4800-a683-a677396af9ba"), "Название конкрусной работы", 15 },
                    { new Guid("ecea35a0-fa3e-43a2-91fe-b1fdebb2d493"), new Guid("3b4d126f-02f8-4bd7-ba72-4ae5be4b845f"), "Должность", 10 },
                    { new Guid("f27f268e-2ace-466f-9e5b-209e9235368a"), new Guid("8eb01d0e-5630-4578-ac7c-e0ad69e970b9"), "Защитившиеся специалисты", 22 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2"), new Guid("f0e53511-cf51-4ae8-89a6-c1f20ede291a") },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), new Guid("a9602a44-6e7e-4984-8f26-7a77399e0860") },
                    { new Guid("67860afa-07f4-45d4-a4e0-e9ee33bca4bf"), new Guid("f0e53511-cf51-4ae8-89a6-c1f20ede291a") },
                    { new Guid("bcb2d10d-820d-45bf-905c-56b3db405ede"), new Guid("f0e53511-cf51-4ae8-89a6-c1f20ede291a") },
                    { new Guid("bd76bc2e-76bf-4c7b-b8de-c9f03cf42870"), new Guid("a9602a44-6e7e-4984-8f26-7a77399e0860") },
                    { new Guid("bd76bc2e-76bf-4c7b-b8de-c9f03cf42870"), new Guid("f0e53511-cf51-4ae8-89a6-c1f20ede291a") },
                    { new Guid("bea1a3d8-583b-4db7-9b9e-b1b6a6fc97ac"), new Guid("a9602a44-6e7e-4984-8f26-7a77399e0860") },
                    { new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35"), new Guid("a9602a44-6e7e-4984-8f26-7a77399e0860") },
                    { new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35"), new Guid("f0e53511-cf51-4ae8-89a6-c1f20ede291a") },
                    { new Guid("cbeaf8cb-4950-4051-8347-d3a3066d0105"), new Guid("a9602a44-6e7e-4984-8f26-7a77399e0860") },
                    { new Guid("cbeaf8cb-4950-4051-8347-d3a3066d0105"), new Guid("f0e53511-cf51-4ae8-89a6-c1f20ede291a") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("bea1a3d8-583b-4db7-9b9e-b1b6a6fc97ac"), new Guid("0338ae3f-0481-4905-a456-650857c2d35e") },
                    { new Guid("bea1a3d8-583b-4db7-9b9e-b1b6a6fc97ac"), new Guid("e9eb147c-2736-4853-9573-454f4374945f") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("03ed6969-7ec6-4f16-a8bc-990a13372de7"), new Guid("8eb01d0e-5630-4578-ac7c-e0ad69e970b9"), "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 },
                    { new Guid("347910a6-123a-4b67-8c6c-88f921c84c89"), new Guid("f377852b-8f58-4948-9b0f-dcdd6fa50c6f"), "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("4a0a27ab-3b75-4868-b8aa-66959a030e51"), new Guid("09b36f3d-9e08-4c9d-9f7c-2e5e78c7896b"), "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("5045e727-83cd-4297-9cd1-f8d029e0ed6b"), new Guid("8eb01d0e-5630-4578-ac7c-e0ad69e970b9"), "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("582158d6-69d2-485f-8d0b-b8fd43c14e74"), new Guid("f377852b-8f58-4948-9b0f-dcdd6fa50c6f"), "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("922cb0ed-159b-4ba4-b391-06b5bcb225d4"), new Guid("f377852b-8f58-4948-9b0f-dcdd6fa50c6f"), "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("a0374092-fd69-4b5d-9edd-680717072291"), new Guid("8eb01d0e-5630-4578-ac7c-e0ad69e970b9"), "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("b2832943-c7a8-4591-87b0-1b08b95ac191"), new Guid("09b36f3d-9e08-4c9d-9f7c-2e5e78c7896b"), "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("b5ff80f5-b1cd-4a2a-98b7-645cc31c3f80"), new Guid("8eb01d0e-5630-4578-ac7c-e0ad69e970b9"), "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("c3e32940-4e64-4437-85c8-2d57bffcda1c"), new Guid("f377852b-8f58-4948-9b0f-dcdd6fa50c6f"), "Персональные идентификаторы и показатели", 10 },
                    { new Guid("d7f0c59a-77b0-4bd8-941e-fb464d157034"), new Guid("8eb01d0e-5630-4578-ac7c-e0ad69e970b9"), "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("d8a7ead1-0693-4582-886c-212559f2a72c"), new Guid("f377852b-8f58-4948-9b0f-dcdd6fa50c6f"), "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("e8506199-7513-465a-a443-8e3058549eeb"), new Guid("8eb01d0e-5630-4578-ac7c-e0ad69e970b9"), "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("04672ce1-575b-4ca1-9376-f9d507e8fb34"), "Издание, год", 4, new Guid("922cb0ed-159b-4ba4-b391-06b5bcb225d4") },
                    { new Guid("05314802-cafc-48ab-8b7d-0704a274d314"), "Наличие грифа", 5, new Guid("03ed6969-7ec6-4f16-a8bc-990a13372de7") },
                    { new Guid("0f0575b0-9d59-4015-880a-4f39c7e03b33"), "Название", 2, new Guid("03ed6969-7ec6-4f16-a8bc-990a13372de7") },
                    { new Guid("15658f87-1ff6-4f3d-8ef9-b1c97fc0e684"), "Название НИР/НИОКР", 1, new Guid("347910a6-123a-4b67-8c6c-88f921c84c89") },
                    { new Guid("16d41ace-da6c-4d0f-ab81-a0f29d55d981"), "Период выполнения", 3, new Guid("347910a6-123a-4b67-8c6c-88f921c84c89") },
                    { new Guid("226b0725-0677-477f-8dbc-22547e7ebc17"), "ФИО", 1, new Guid("b5ff80f5-b1cd-4a2a-98b7-645cc31c3f80") },
                    { new Guid("22fadc02-39ea-4217-9c84-a6328fa2a9bf"), "Идентификатор", 2, new Guid("c3e32940-4e64-4437-85c8-2d57bffcda1c") },
                    { new Guid("2401da4d-fb28-49b2-935b-4ab14a4446f2"), "Сумма финансирования (тыс. руб.)", 2, new Guid("347910a6-123a-4b67-8c6c-88f921c84c89") },
                    { new Guid("25b3d9bd-80f7-4f4d-ade6-8776e35c337b"), "Количество часов", 4, new Guid("e8506199-7513-465a-a443-8e3058549eeb") },
                    { new Guid("25f7581c-d209-4b7d-8675-1944736b6c29"), "Год получения документа", 2, new Guid("b2832943-c7a8-4591-87b0-1b08b95ac191") },
                    { new Guid("27ba2efe-5665-413e-a585-27762fb759ed"), "Наименование курса", 1, new Guid("5045e727-83cd-4297-9cd1-f8d029e0ed6b") },
                    { new Guid("27ce07cb-37f3-4ea9-ab54-38792c1efae6"), "Год", 1, new Guid("4a0a27ab-3b75-4868-b8aa-66959a030e51") },
                    { new Guid("29e67506-d785-470a-acbf-1e75fe7f01c5"), "Язык преподавания (русск./англ./др.)", 2, new Guid("5045e727-83cd-4297-9cd1-f8d029e0ed6b") },
                    { new Guid("2a2d1c68-dc79-4102-a2fe-d89f7b11378d"), "Итого (час.)", 5, new Guid("5045e727-83cd-4297-9cd1-f8d029e0ed6b") },
                    { new Guid("38299785-f8a5-4e38-90f2-ed3526ccd2ff"), "Вид", 1, new Guid("d8a7ead1-0693-4582-886c-212559f2a72c") },
                    { new Guid("3a468656-f5cc-488f-827f-77ccac823170"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("b5ff80f5-b1cd-4a2a-98b7-645cc31c3f80") },
                    { new Guid("3c3743d3-945a-4014-88fb-9173ff0d0eaf"), "Количество печатных листов", 4, new Guid("03ed6969-7ec6-4f16-a8bc-990a13372de7") },
                    { new Guid("459879b0-ed70-43b3-9631-bc431f59e90e"), "Лекции (час.)", 3, new Guid("5045e727-83cd-4297-9cd1-f8d029e0ed6b") },
                    { new Guid("4672ac3c-c877-4405-95a4-6206cf08c84e"), "Номер РИД", 4, new Guid("582158d6-69d2-485f-8d0b-b8fd43c14e74") },
                    { new Guid("5140d657-a366-40ab-a61d-c631e23f23d5"), "Количество публикаций в БАЗЕ", 3, new Guid("c3e32940-4e64-4437-85c8-2d57bffcda1c") },
                    { new Guid("522d08a1-e8a2-4aec-836d-7305d531572f"), "Название", 2, new Guid("582158d6-69d2-485f-8d0b-b8fd43c14e74") },
                    { new Guid("58e9ad61-01c5-4669-883c-34ef72f3dbc5"), "Индекс Хирша (за все время)", 5, new Guid("c3e32940-4e64-4437-85c8-2d57bffcda1c") },
                    { new Guid("5ae7f664-d450-4d8b-8b78-f28aaba83dd1"), "Название дисциплины", 1, new Guid("d7f0c59a-77b0-4bd8-941e-fb464d157034") },
                    { new Guid("615cdd2a-ae6e-43b4-8516-583d73b11afb"), "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("e8506199-7513-465a-a443-8e3058549eeb") },
                    { new Guid("68fe9026-089f-45cc-897c-69d0fbdc47bf"), "Год", 3, new Guid("b5ff80f5-b1cd-4a2a-98b7-645cc31c3f80") },
                    { new Guid("69767641-d896-44d9-b343-c83983cb82a0"), "Соавторы", 2, new Guid("922cb0ed-159b-4ba4-b391-06b5bcb225d4") },
                    { new Guid("6a4c3347-9a34-4a7f-a2dc-402a65ea03a6"), "Ссылка", 5, new Guid("4a0a27ab-3b75-4868-b8aa-66959a030e51") },
                    { new Guid("6e6d49c7-f6d3-4be5-b4cf-28074095ebe2"), "ФИО соавторов", 3, new Guid("582158d6-69d2-485f-8d0b-b8fd43c14e74") },
                    { new Guid("6f0cea62-f545-4b06-af03-c46b300252a4"), "Статус конкурса", 3, new Guid("4a0a27ab-3b75-4868-b8aa-66959a030e51") },
                    { new Guid("6f4b8ed0-c337-4bc7-9f83-387f3b197372"), "Издательство, год", 6, new Guid("03ed6969-7ec6-4f16-a8bc-990a13372de7") },
                    { new Guid("736607b1-22f6-4822-9a85-ceca24533111"), "Название статьи", 1, new Guid("922cb0ed-159b-4ba4-b391-06b5bcb225d4") },
                    { new Guid("7712ed57-068e-4349-9e8e-26d1f3037cc8"), "Практические занятия (час.)", 4, new Guid("5045e727-83cd-4297-9cd1-f8d029e0ed6b") },
                    { new Guid("7f1a6af5-e9fa-45ea-9b74-bf2eb47626ab"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("347910a6-123a-4b67-8c6c-88f921c84c89") },
                    { new Guid("7f268a5f-e9a9-49f8-95dd-f8b291f04957"), "Год", 4, new Guid("a0374092-fd69-4b5d-9edd-680717072291") },
                    { new Guid("835b2d77-d80b-43a7-b3d3-10d4d262076c"), "Вид", 1, new Guid("582158d6-69d2-485f-8d0b-b8fd43c14e74") },
                    { new Guid("853b2d86-9534-4b6b-b243-f018d92d7f40"), "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("922cb0ed-159b-4ba4-b391-06b5bcb225d4") },
                    { new Guid("89eb2188-f78d-4d64-a8eb-9b4c07789103"), "Количество цитирований", 4, new Guid("c3e32940-4e64-4437-85c8-2d57bffcda1c") },
                    { new Guid("902da042-f19e-4461-926b-5f3429bc7f6f"), "Название организации/должность/ставка", 1, new Guid("e8506199-7513-465a-a443-8e3058549eeb") },
                    { new Guid("906db342-081d-4704-b7ba-162b490b4e17"), "Тип идентификатора", 1, new Guid("c3e32940-4e64-4437-85c8-2d57bffcda1c") },
                    { new Guid("9ae035e4-2b55-4c0a-b14b-e5806e61a775"), "Название организации в которую внедрена разработка", 3, new Guid("d8a7ead1-0693-4582-886c-212559f2a72c") },
                    { new Guid("9f5bcba1-e0dd-44c3-b1e9-f2d967b55265"), "Название конкурса", 2, new Guid("4a0a27ab-3b75-4868-b8aa-66959a030e51") },
                    { new Guid("aa4a6d07-0e49-4203-943d-6c5cf0b0de39"), "Ссылка на платформу", 3, new Guid("a0374092-fd69-4b5d-9edd-680717072291") },
                    { new Guid("aaf2f455-109a-461e-b7de-b8bb042a3adb"), "Название курса", 1, new Guid("a0374092-fd69-4b5d-9edd-680717072291") },
                    { new Guid("bf0869cb-9278-45c5-97fb-79a4d799b225"), "Соавторы", 2, new Guid("a0374092-fd69-4b5d-9edd-680717072291") },
                    { new Guid("c275e871-8e68-4efa-b0eb-3fa99ffcb014"), "Награда", 4, new Guid("4a0a27ab-3b75-4868-b8aa-66959a030e51") },
                    { new Guid("c8fec2a7-ae96-4650-aa18-add9ddb9026b"), "Вид публикации", 1, new Guid("03ed6969-7ec6-4f16-a8bc-990a13372de7") },
                    { new Guid("d56b5f5a-aaca-432f-a786-c75651d8c172"), "Вид (лекции, лабораторные)", 2, new Guid("d7f0c59a-77b0-4bd8-941e-fb464d157034") },
                    { new Guid("db5d24f8-4534-4cdc-a58a-f162532d97b2"), "Название документа, реквизиты", 1, new Guid("b2832943-c7a8-4591-87b0-1b08b95ac191") },
                    { new Guid("df74e95a-14c5-4596-a0dc-7113d7827564"), "Название конкурса/премии", 2, new Guid("b5ff80f5-b1cd-4a2a-98b7-645cc31c3f80") },
                    { new Guid("e5a84d43-a409-40c8-8bb6-4f6296ad87ef"), "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("b5ff80f5-b1cd-4a2a-98b7-645cc31c3f80") },
                    { new Guid("e5b60313-2d9c-4801-9802-de9bd47958fa"), "Вид деятельности (преподавательская)", 3, new Guid("e8506199-7513-465a-a443-8e3058549eeb") },
                    { new Guid("ed1fe1f4-4e8b-4e65-be22-800d1f775eae"), "Название разработки", 2, new Guid("d8a7ead1-0693-4582-886c-212559f2a72c") },
                    { new Guid("f461a335-15dc-4b07-8ba3-47702c811846"), "Соавторы", 3, new Guid("03ed6969-7ec6-4f16-a8bc-990a13372de7") },
                    { new Guid("f4b969ff-d2e8-4934-8543-0f54a72e562c"), "Статус (руководитель/исполнитель)", 4, new Guid("347910a6-123a-4b67-8c6c-88f921c84c89") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("00518d78-5b6a-4ff7-941a-424ae4b194d4"), new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2") },
                    { new Guid("1a2d2418-aa5a-4672-9804-f2cce7a69bec"), new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2") },
                    { new Guid("1d989ace-9259-4dd7-930e-371d22fb8288"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("22046c92-aa2f-4f4a-b887-89896e7b9d31"), new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7") },
                    { new Guid("22046c92-aa2f-4f4a-b887-89896e7b9d31"), new Guid("67860afa-07f4-45d4-a4e0-e9ee33bca4bf") },
                    { new Guid("22046c92-aa2f-4f4a-b887-89896e7b9d31"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("403ec031-2945-4555-a023-b1712d5e906f"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("46c2218e-26cb-4796-88c8-cf20b8d3708d"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("4c34ffea-d401-44bc-b93b-cbdbd9bbdf62"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("5883dfa4-f49d-40b6-9193-11d65c24a325"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("69f8ef0e-4bd2-4406-8f90-fefefeeb5830"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("78cd04a3-9772-4825-bc16-eb7efd5c860f"), new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2") },
                    { new Guid("8dabc025-41c0-4da0-b642-e6c6446bdd76"), new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7") },
                    { new Guid("9136481f-ccb3-4067-bf4d-854f7aacc789"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("a1ddb78e-3582-4529-b452-56e5fc44a06d"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("a73fc8a0-9b30-47df-80a1-369be00e62e2"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("af52c327-e339-4d2e-b019-327f854fad04"), new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2") },
                    { new Guid("b3f287d1-a3d9-4bc3-92f2-0379742c37ed"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("b51f8665-833e-4de6-aa01-56ea3f3c7d76"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("bd8161ad-c681-43e6-9a20-53bc86e53383"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("c033f5aa-3bce-4621-95e1-5ef37ce4274f"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("c3b2bdaa-fbd1-427c-80c1-37c92413cdca"), new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7") },
                    { new Guid("cddbdb77-fedd-4c44-8e83-581f83482553"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("cded8e03-9466-42b1-a81e-0d51d6b1b6f9"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("d260c8b6-1104-4c2c-af3d-b712c429753e"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("ecea35a0-fa3e-43a2-91fe-b1fdebb2d493"), new Guid("cb3a7b6b-03d3-4afe-b598-c6c2982e2f35") },
                    { new Guid("f27f268e-2ace-466f-9e5b-209e9235368a"), new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2"), new Guid("5045e727-83cd-4297-9cd1-f8d029e0ed6b") },
                    { new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2"), new Guid("a0374092-fd69-4b5d-9edd-680717072291") },
                    { new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2"), new Guid("b5ff80f5-b1cd-4a2a-98b7-645cc31c3f80") },
                    { new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2"), new Guid("e8506199-7513-465a-a443-8e3058549eeb") },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), new Guid("347910a6-123a-4b67-8c6c-88f921c84c89") },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), new Guid("4a0a27ab-3b75-4868-b8aa-66959a030e51") },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), new Guid("922cb0ed-159b-4ba4-b391-06b5bcb225d4") },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), new Guid("c3e32940-4e64-4437-85c8-2d57bffcda1c") },
                    { new Guid("67860afa-07f4-45d4-a4e0-e9ee33bca4bf"), new Guid("4a0a27ab-3b75-4868-b8aa-66959a030e51") },
                    { new Guid("67860afa-07f4-45d4-a4e0-e9ee33bca4bf"), new Guid("b2832943-c7a8-4591-87b0-1b08b95ac191") },
                    { new Guid("bcb2d10d-820d-45bf-905c-56b3db405ede"), new Guid("03ed6969-7ec6-4f16-a8bc-990a13372de7") },
                    { new Guid("bcb2d10d-820d-45bf-905c-56b3db405ede"), new Guid("d7f0c59a-77b0-4bd8-941e-fb464d157034") },
                    { new Guid("bea1a3d8-583b-4db7-9b9e-b1b6a6fc97ac"), new Guid("582158d6-69d2-485f-8d0b-b8fd43c14e74") },
                    { new Guid("bea1a3d8-583b-4db7-9b9e-b1b6a6fc97ac"), new Guid("b2832943-c7a8-4591-87b0-1b08b95ac191") },
                    { new Guid("bea1a3d8-583b-4db7-9b9e-b1b6a6fc97ac"), new Guid("d8a7ead1-0693-4582-886c-212559f2a72c") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("006c6097-9e4d-411d-bb01-7ff4a9d45946"), new Guid("22046c92-aa2f-4f4a-b887-89896e7b9d31"), "Баллы за ученое звание:", 13, null },
                    { new Guid("0d5962fd-6f41-4be9-93f8-14b01782317b"), new Guid("c3b2bdaa-fbd1-427c-80c1-37c92413cdca"), "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("203e3765-60e1-46be-a156-69ecac152e6d"), null, "Баллы за количество разработок:", 24, new Guid("d8a7ead1-0693-4582-886c-212559f2a72c") },
                    { new Guid("20601223-20d4-4ab0-b989-e3fca863fba4"), null, "Баллы за труды без грифа в соавторстве:", 11, new Guid("03ed6969-7ec6-4f16-a8bc-990a13372de7") },
                    { new Guid("41f2614a-4f79-47bd-878c-5ae9c3c75eaa"), new Guid("af52c327-e339-4d2e-b019-327f854fad04"), "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("4a108bcc-9740-4f6f-b028-3d523d1c43b5"), null, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("d7f0c59a-77b0-4bd8-941e-fb464d157034") },
                    { new Guid("4db020b6-2618-4da6-8fde-57a325e87933"), null, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("347910a6-123a-4b67-8c6c-88f921c84c89") },
                    { new Guid("4e188757-2535-4c55-a9f9-e88e0e55e600"), null, "Баллы за труды с грифом и без соавторства:", 8, new Guid("03ed6969-7ec6-4f16-a8bc-990a13372de7") },
                    { new Guid("5c9998e1-01f5-4746-90de-fe2245b97934"), null, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("a0374092-fd69-4b5d-9edd-680717072291") },
                    { new Guid("5ef1f820-09b0-4394-97be-07ddd989abb7"), null, "Баллы по базе РИНЦ:", 18, new Guid("c3e32940-4e64-4437-85c8-2d57bffcda1c") },
                    { new Guid("640e0c13-f843-461b-806e-84b793ef09e5"), null, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("347910a6-123a-4b67-8c6c-88f921c84c89") },
                    { new Guid("6b035f03-a141-4cce-82c7-6c4f87fdfe47"), new Guid("1a2d2418-aa5a-4672-9804-f2cce7a69bec"), "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("6df5e09e-a8fb-4bfb-948d-fcc22bc01e47"), null, "Баллы за труды без грифа и без соавторства:", 10, new Guid("03ed6969-7ec6-4f16-a8bc-990a13372de7") },
                    { new Guid("6fbbe767-6ed5-415e-88f1-e491658b9104"), null, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("b5ff80f5-b1cd-4a2a-98b7-645cc31c3f80") },
                    { new Guid("7565a6b5-26a3-4e47-b074-d5064c5bd529"), new Guid("78cd04a3-9772-4825-bc16-eb7efd5c860f"), "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("879e6952-0c18-4469-b834-656f7ba1b69e"), null, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("582158d6-69d2-485f-8d0b-b8fd43c14e74") },
                    { new Guid("8807802f-503d-44e7-81e4-2cc6ee0f2d29"), null, "Баллы по базе Scopus:", 17, new Guid("c3e32940-4e64-4437-85c8-2d57bffcda1c") },
                    { new Guid("96ba47fd-8d15-460a-9bba-dd7eb91720da"), null, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("5045e727-83cd-4297-9cd1-f8d029e0ed6b") },
                    { new Guid("a14c0ea9-4159-4d65-800f-e9cdb17191b6"), null, "Баллы за профессиональное развитие:", 15, new Guid("b2832943-c7a8-4591-87b0-1b08b95ac191") },
                    { new Guid("aa51a001-4954-4a35-afb1-cd2477b77a42"), null, "Баллы за объем учебной нагрузки:", 1, new Guid("5045e727-83cd-4297-9cd1-f8d029e0ed6b") },
                    { new Guid("adf0d452-e66e-4ad7-aa97-829dc12a00c3"), null, "Баллы за труды с грифом в соавторстве:", 9, new Guid("03ed6969-7ec6-4f16-a8bc-990a13372de7") },
                    { new Guid("dd818049-835b-4a87-837a-91e5e6a1e44d"), null, "Баллы за награды:", 14, new Guid("4a0a27ab-3b75-4868-b8aa-66959a030e51") },
                    { new Guid("e725e89e-9184-4425-8755-88186e0d3b12"), null, "Баллы за научные публикации:", 16, new Guid("922cb0ed-159b-4ba4-b391-06b5bcb225d4") },
                    { new Guid("ebcb19a8-534a-48a7-bd0d-b01c492ba80b"), new Guid("8dabc025-41c0-4da0-b642-e6c6446bdd76"), "Баллы за количество защитившихся кандидатов наук:", 19, null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2"), new Guid("41f2614a-4f79-47bd-878c-5ae9c3c75eaa") },
                    { new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2"), new Guid("5c9998e1-01f5-4746-90de-fe2245b97934") },
                    { new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2"), new Guid("6b035f03-a141-4cce-82c7-6c4f87fdfe47") },
                    { new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2"), new Guid("6fbbe767-6ed5-415e-88f1-e491658b9104") },
                    { new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2"), new Guid("7565a6b5-26a3-4e47-b074-d5064c5bd529") },
                    { new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2"), new Guid("96ba47fd-8d15-460a-9bba-dd7eb91720da") },
                    { new Guid("08590f39-3c58-45f0-9e9a-5b1b1d92e6d2"), new Guid("aa51a001-4954-4a35-afb1-cd2477b77a42") },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), new Guid("006c6097-9e4d-411d-bb01-7ff4a9d45946") },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), new Guid("0d5962fd-6f41-4be9-93f8-14b01782317b") },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), new Guid("4db020b6-2618-4da6-8fde-57a325e87933") },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), new Guid("5ef1f820-09b0-4394-97be-07ddd989abb7") },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), new Guid("640e0c13-f843-461b-806e-84b793ef09e5") },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), new Guid("8807802f-503d-44e7-81e4-2cc6ee0f2d29") },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), new Guid("dd818049-835b-4a87-837a-91e5e6a1e44d") },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), new Guid("e725e89e-9184-4425-8755-88186e0d3b12") },
                    { new Guid("1b6cab68-9db8-42a4-8efb-a4c237f1ded7"), new Guid("ebcb19a8-534a-48a7-bd0d-b01c492ba80b") },
                    { new Guid("67860afa-07f4-45d4-a4e0-e9ee33bca4bf"), new Guid("006c6097-9e4d-411d-bb01-7ff4a9d45946") },
                    { new Guid("67860afa-07f4-45d4-a4e0-e9ee33bca4bf"), new Guid("a14c0ea9-4159-4d65-800f-e9cdb17191b6") },
                    { new Guid("67860afa-07f4-45d4-a4e0-e9ee33bca4bf"), new Guid("dd818049-835b-4a87-837a-91e5e6a1e44d") },
                    { new Guid("bcb2d10d-820d-45bf-905c-56b3db405ede"), new Guid("20601223-20d4-4ab0-b989-e3fca863fba4") },
                    { new Guid("bcb2d10d-820d-45bf-905c-56b3db405ede"), new Guid("4a108bcc-9740-4f6f-b028-3d523d1c43b5") },
                    { new Guid("bcb2d10d-820d-45bf-905c-56b3db405ede"), new Guid("4e188757-2535-4c55-a9f9-e88e0e55e600") },
                    { new Guid("bcb2d10d-820d-45bf-905c-56b3db405ede"), new Guid("6df5e09e-a8fb-4bfb-948d-fcc22bc01e47") },
                    { new Guid("bcb2d10d-820d-45bf-905c-56b3db405ede"), new Guid("adf0d452-e66e-4ad7-aa97-829dc12a00c3") },
                    { new Guid("bea1a3d8-583b-4db7-9b9e-b1b6a6fc97ac"), new Guid("203e3765-60e1-46be-a156-69ecac152e6d") },
                    { new Guid("bea1a3d8-583b-4db7-9b9e-b1b6a6fc97ac"), new Guid("879e6952-0c18-4469-b834-656f7ba1b69e") },
                    { new Guid("bea1a3d8-583b-4db7-9b9e-b1b6a6fc97ac"), new Guid("a14c0ea9-4159-4d65-800f-e9cdb17191b6") }
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
