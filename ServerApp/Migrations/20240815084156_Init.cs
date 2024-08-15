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
                    { new Guid("26e08253-d156-4a0c-b4e5-dca9de906494"), "Профессиональное развитие", 3 },
                    { new Guid("63d36cd4-d950-459f-8ccd-d322e96802fc"), "Деятельность", 5 },
                    { new Guid("8020be28-ff2d-47ac-9ea1-e2dbf0609f3a"), "Категория участников", 2 },
                    { new Guid("8ef17813-4109-4d57-8e5d-305e5e6c4451"), "Деятельность", 4 },
                    { new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), "Общая информация", 1 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e"), "Образовательная деятельность", 2 },
                    { new Guid("388e85bd-736c-498c-94b8-9b3d6e11a7de"), "Конкурсная работа", 7 },
                    { new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac"), "Основной", 1 },
                    { new Guid("7502619e-4f9c-4055-8318-41d9c97ea2cc"), "Профессиональные показатели", 4 },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("b7584824-418e-40c0-88e0-4ed980b399f9"), "Итог", 8 },
                    { new Guid("e943d4fe-7108-4a02-bd2b-d8f740d82dd6"), "Методическая деятельность", 3 },
                    { new Guid("fdcdcc79-c97c-4353-8957-7875798f3559"), "Инновационная и иная деятельность", 6 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0fa3b22a-2843-4f4f-9a40-f12baa75cdb1"), null, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("b25a66eb-1107-47df-93b3-b1400e408604"), null, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("93d111b2-3f2c-414e-851e-1c1cb329ad00"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("e5f2de80-eaca-489e-ac8b-10a18d092c28"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("66367b1e-a036-4732-bce9-1257c293c7da"), "User 1", "admin@mail.ru" },
                    { new Guid("cf72d6c9-ab84-48b5-9407-ff9f22eb55ff"), "User 2", "user@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("26e08253-d156-4a0c-b4e5-dca9de906494"), new Guid("93d111b2-3f2c-414e-851e-1c1cb329ad00") },
                    { new Guid("26e08253-d156-4a0c-b4e5-dca9de906494"), new Guid("e5f2de80-eaca-489e-ac8b-10a18d092c28") },
                    { new Guid("63d36cd4-d950-459f-8ccd-d322e96802fc"), new Guid("93d111b2-3f2c-414e-851e-1c1cb329ad00") },
                    { new Guid("8020be28-ff2d-47ac-9ea1-e2dbf0609f3a"), new Guid("93d111b2-3f2c-414e-851e-1c1cb329ad00") },
                    { new Guid("8020be28-ff2d-47ac-9ea1-e2dbf0609f3a"), new Guid("e5f2de80-eaca-489e-ac8b-10a18d092c28") },
                    { new Guid("8ef17813-4109-4d57-8e5d-305e5e6c4451"), new Guid("e5f2de80-eaca-489e-ac8b-10a18d092c28") },
                    { new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), new Guid("93d111b2-3f2c-414e-851e-1c1cb329ad00") },
                    { new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), new Guid("e5f2de80-eaca-489e-ac8b-10a18d092c28") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("04568b26-f758-497c-b895-f0c8dd2e0a7d"), new Guid("63d36cd4-d950-459f-8ccd-d322e96802fc"), "Защитившиеся доктора наук", 25 },
                    { new Guid("1a314c1b-e926-45b3-a695-12df1d237c13"), new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), "Стаж научно-педагогической деятельности по трудовой книжке", 11 },
                    { new Guid("1db89be5-fc68-4a04-973d-62676f453550"), new Guid("8020be28-ff2d-47ac-9ea1-e2dbf0609f3a"), "Ученое звание", 16 },
                    { new Guid("1f4c398f-28a4-47a1-99cc-7b8386496566"), new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), "Трек конкурса", 1 },
                    { new Guid("29b4a310-1c37-49a0-aae8-bcca502b500f"), new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), "Домашний адрес", 4 },
                    { new Guid("58d6543a-ec3e-4687-8012-a1dee0156099"), new Guid("8020be28-ff2d-47ac-9ea1-e2dbf0609f3a"), "Ученая степень", 17 },
                    { new Guid("5c16da5c-b9f1-4f40-ad5b-9d0548c793ae"), new Guid("8ef17813-4109-4d57-8e5d-305e5e6c4451"), "Защитившиеся магистры", 23 },
                    { new Guid("60fcb60f-5c1f-4a16-a20e-fd71ee25ae54"), new Guid("8ef17813-4109-4d57-8e5d-305e5e6c4451"), "Защитившиеся кадидаты наук", 19 },
                    { new Guid("65bad0b0-2995-4791-a324-42e237cac770"), new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), "Место работы/учебы", 7 },
                    { new Guid("77bcb6a4-1369-462a-8d4c-95940ea3bd3c"), new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), "ФИО", 2 },
                    { new Guid("7d2e8571-2577-4700-9414-35259b71ebe3"), new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), "Дата рождения", 3 },
                    { new Guid("7fe544e0-a5a0-427c-8cd4-c4fdc84fad98"), new Guid("8020be28-ff2d-47ac-9ea1-e2dbf0609f3a"), "Научная специальность (по классификации ВАК)", 18 },
                    { new Guid("91950ec9-87d6-4703-a946-f455d72f3b01"), new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), "Контактный телефон", 5 },
                    { new Guid("a1bfc8a0-654c-4299-b49c-432c5a3b3dbb"), new Guid("8ef17813-4109-4d57-8e5d-305e5e6c4451"), "Защитившиеся бакалавры", 21 },
                    { new Guid("a3ef526f-1673-4b63-ac72-1df74c31814d"), new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), "Институт, факультет, кафедра, лаборатория", 9 },
                    { new Guid("a59fd96f-1665-44f7-b2f5-c5f6561ceb79"), new Guid("8ef17813-4109-4d57-8e5d-305e5e6c4451"), "Защитившиеся доктора наук", 20 },
                    { new Guid("ae9e053b-4cc0-48be-9a24-553c1496a5de"), new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), "Должность", 10 },
                    { new Guid("b5167228-45a8-451b-9cc2-1c30b022bcfd"), new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), "Адрес работы/учебы", 8 },
                    { new Guid("c1d31301-3bab-4a61-95c9-891ed5a64a3d"), new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), "Дополнительная информация", 12 },
                    { new Guid("c3a9285d-e143-4843-9a96-23a4621f24d5"), new Guid("8ef17813-4109-4d57-8e5d-305e5e6c4451"), "Защитившиеся специалисты", 22 },
                    { new Guid("e0bff50a-5bff-4269-9f45-a717534ac494"), new Guid("8020be28-ff2d-47ac-9ea1-e2dbf0609f3a"), "Направление конкурса", 13 },
                    { new Guid("e3fba1a3-b4ae-4fd2-87ec-7dfd67221a6e"), new Guid("8020be28-ff2d-47ac-9ea1-e2dbf0609f3a"), "Название конкрусной работы", 15 },
                    { new Guid("eeba3031-853c-4b79-9fdf-dcee4d7a1e42"), new Guid("63d36cd4-d950-459f-8ccd-d322e96802fc"), "Защитившиеся кандидаты наук", 24 },
                    { new Guid("f0ba2f58-c0a5-4c87-8564-5fc268aebb79"), new Guid("a3e3ede1-5e43-4d61-91fe-c408f808cfef"), "Электронная почта", 6 },
                    { new Guid("ff104d50-51bd-4444-a669-7fc71ba38d56"), new Guid("8020be28-ff2d-47ac-9ea1-e2dbf0609f3a"), "Категория участника конкурса", 14 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e"), new Guid("e5f2de80-eaca-489e-ac8b-10a18d092c28") },
                    { new Guid("388e85bd-736c-498c-94b8-9b3d6e11a7de"), new Guid("93d111b2-3f2c-414e-851e-1c1cb329ad00") },
                    { new Guid("388e85bd-736c-498c-94b8-9b3d6e11a7de"), new Guid("e5f2de80-eaca-489e-ac8b-10a18d092c28") },
                    { new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac"), new Guid("93d111b2-3f2c-414e-851e-1c1cb329ad00") },
                    { new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac"), new Guid("e5f2de80-eaca-489e-ac8b-10a18d092c28") },
                    { new Guid("7502619e-4f9c-4055-8318-41d9c97ea2cc"), new Guid("e5f2de80-eaca-489e-ac8b-10a18d092c28") },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), new Guid("93d111b2-3f2c-414e-851e-1c1cb329ad00") },
                    { new Guid("b7584824-418e-40c0-88e0-4ed980b399f9"), new Guid("93d111b2-3f2c-414e-851e-1c1cb329ad00") },
                    { new Guid("b7584824-418e-40c0-88e0-4ed980b399f9"), new Guid("e5f2de80-eaca-489e-ac8b-10a18d092c28") },
                    { new Guid("e943d4fe-7108-4a02-bd2b-d8f740d82dd6"), new Guid("e5f2de80-eaca-489e-ac8b-10a18d092c28") },
                    { new Guid("fdcdcc79-c97c-4353-8957-7875798f3559"), new Guid("93d111b2-3f2c-414e-851e-1c1cb329ad00") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("fdcdcc79-c97c-4353-8957-7875798f3559"), new Guid("0fa3b22a-2843-4f4f-9a40-f12baa75cdb1") },
                    { new Guid("fdcdcc79-c97c-4353-8957-7875798f3559"), new Guid("b25a66eb-1107-47df-93b3-b1400e408604") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0cf36fef-af1e-4424-8eca-5c7d3166f01d"), new Guid("63d36cd4-d950-459f-8ccd-d322e96802fc"), "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("0df3f623-601b-462e-95cc-e3a97331980f"), new Guid("26e08253-d156-4a0c-b4e5-dca9de906494"), "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("13111c2b-e7ae-439f-8fde-e5462d3616cd"), new Guid("63d36cd4-d950-459f-8ccd-d322e96802fc"), "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("16684938-c87e-43d0-82df-50156168324f"), new Guid("8ef17813-4109-4d57-8e5d-305e5e6c4451"), "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("1c4ee49f-2575-4f6e-8528-f0c080ea3ee5"), new Guid("8ef17813-4109-4d57-8e5d-305e5e6c4451"), "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("21e14f60-95ac-44c5-9c29-337812234c8d"), new Guid("8ef17813-4109-4d57-8e5d-305e5e6c4451"), "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("3fb2076b-4d42-4c13-b2f5-97032273da53"), new Guid("8ef17813-4109-4d57-8e5d-305e5e6c4451"), "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("449f9dee-be7a-4831-90ac-c3070827fe9b"), new Guid("8ef17813-4109-4d57-8e5d-305e5e6c4451"), "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("72479481-80b7-4458-9c72-c402755a8ebc"), new Guid("8ef17813-4109-4d57-8e5d-305e5e6c4451"), "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 },
                    { new Guid("aad09686-5488-43eb-942a-0efc3dbea728"), new Guid("26e08253-d156-4a0c-b4e5-dca9de906494"), "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("ce1b3d8e-9988-4079-91be-b448b86cfd06"), new Guid("63d36cd4-d950-459f-8ccd-d322e96802fc"), "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("e6da3db2-cfbf-487e-8185-a738b9b0c600"), new Guid("63d36cd4-d950-459f-8ccd-d322e96802fc"), "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("fddf60e5-3be0-46c4-8827-4f6a810fd918"), new Guid("63d36cd4-d950-459f-8ccd-d322e96802fc"), "Персональные идентификаторы и показатели", 10 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("054f88ca-bfdf-487c-a3eb-4074a2f729c2"), "Название организации в которую внедрена разработка", 3, new Guid("ce1b3d8e-9988-4079-91be-b448b86cfd06") },
                    { new Guid("0989382c-6c72-4336-b84d-601087a4b8eb"), "Итого (час.)", 5, new Guid("16684938-c87e-43d0-82df-50156168324f") },
                    { new Guid("0d9d1b18-4bee-4ac4-b780-6e6656a62a49"), "Наличие грифа", 5, new Guid("72479481-80b7-4458-9c72-c402755a8ebc") },
                    { new Guid("0dcd6a56-c71a-40e9-ba72-1a692f1eea31"), "Соавторы", 2, new Guid("0cf36fef-af1e-4424-8eca-5c7d3166f01d") },
                    { new Guid("0e1d6643-b26c-442a-8faf-74b9c9dac015"), "Лекции (час.)", 3, new Guid("16684938-c87e-43d0-82df-50156168324f") },
                    { new Guid("10844b2f-52dd-4f90-a8eb-f4289297c7f1"), "Номер РИД", 4, new Guid("13111c2b-e7ae-439f-8fde-e5462d3616cd") },
                    { new Guid("13e3d5cc-e8a6-4eca-ba56-c475324526ec"), "Вид деятельности (преподавательская)", 3, new Guid("3fb2076b-4d42-4c13-b2f5-97032273da53") },
                    { new Guid("1491c1ba-d713-4496-a3c1-33ac81e1a5f7"), "Сумма финансирования (тыс. руб.)", 2, new Guid("e6da3db2-cfbf-487e-8185-a738b9b0c600") },
                    { new Guid("1767b7a7-ad27-4b5f-827b-59267d878098"), "Название организации/должность/ставка", 1, new Guid("3fb2076b-4d42-4c13-b2f5-97032273da53") },
                    { new Guid("29eb8b6f-f5a2-48db-92fb-4ce8313fd2e5"), "Ссылка", 5, new Guid("aad09686-5488-43eb-942a-0efc3dbea728") },
                    { new Guid("2a71ae63-fd8f-4eb3-a40c-e049a3bb6b87"), "Количество часов", 4, new Guid("3fb2076b-4d42-4c13-b2f5-97032273da53") },
                    { new Guid("31b2b5d8-664b-4cff-b658-02fef41e54ae"), "Издание, год", 4, new Guid("0cf36fef-af1e-4424-8eca-5c7d3166f01d") },
                    { new Guid("34cfc20c-ba18-478a-bb81-1fddf5d42ca3"), "Тип идентификатора", 1, new Guid("fddf60e5-3be0-46c4-8827-4f6a810fd918") },
                    { new Guid("353ac2df-efad-4e9c-87b4-cab920c8c15b"), "Название курса", 1, new Guid("21e14f60-95ac-44c5-9c29-337812234c8d") },
                    { new Guid("3932ef7e-f8fa-4a0d-913a-6efc17d3b2ab"), "Статус конкурса", 3, new Guid("aad09686-5488-43eb-942a-0efc3dbea728") },
                    { new Guid("3d1faed3-3514-40df-86e2-8e59fc1d48fd"), "Количество публикаций в БАЗЕ", 3, new Guid("fddf60e5-3be0-46c4-8827-4f6a810fd918") },
                    { new Guid("47dbe4d7-bda8-414f-9a45-605b1b5502e4"), "Год", 4, new Guid("21e14f60-95ac-44c5-9c29-337812234c8d") },
                    { new Guid("489585d7-006e-433f-b642-76fd114b5413"), "ФИО соавторов", 3, new Guid("13111c2b-e7ae-439f-8fde-e5462d3616cd") },
                    { new Guid("4c737a51-855a-44ab-9aee-303dc3e8cf8f"), "Название", 2, new Guid("13111c2b-e7ae-439f-8fde-e5462d3616cd") },
                    { new Guid("4ebd5c20-bc78-40fd-ba28-db5d174e623a"), "Практические занятия (час.)", 4, new Guid("16684938-c87e-43d0-82df-50156168324f") },
                    { new Guid("5b4f839f-3946-4f19-9d95-e8c0b362ed9f"), "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("449f9dee-be7a-4831-90ac-c3070827fe9b") },
                    { new Guid("5cc93d19-a99e-4350-ac89-b7b258ebabb3"), "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("3fb2076b-4d42-4c13-b2f5-97032273da53") },
                    { new Guid("635d6106-2673-488a-ab4c-a16b52a88049"), "ФИО", 1, new Guid("449f9dee-be7a-4831-90ac-c3070827fe9b") },
                    { new Guid("6398ec69-b42f-4bdb-b743-4193d6fdd826"), "Название разработки", 2, new Guid("ce1b3d8e-9988-4079-91be-b448b86cfd06") },
                    { new Guid("68a4b69f-18de-4cb1-a62d-078e4da05da2"), "Год", 3, new Guid("449f9dee-be7a-4831-90ac-c3070827fe9b") },
                    { new Guid("6aec5847-a436-43bd-9095-f1171dda83cb"), "Язык преподавания (русск./англ./др.)", 2, new Guid("16684938-c87e-43d0-82df-50156168324f") },
                    { new Guid("73e7b72e-f5fb-4afa-a7fe-1bd595f5cbec"), "Вид", 1, new Guid("13111c2b-e7ae-439f-8fde-e5462d3616cd") },
                    { new Guid("7ed38b13-8eca-4c6c-93e5-dcef7e5e6dbd"), "Название конкурса", 2, new Guid("aad09686-5488-43eb-942a-0efc3dbea728") },
                    { new Guid("8045022e-b21e-466e-bb10-f8af1a6610fb"), "Вид", 1, new Guid("ce1b3d8e-9988-4079-91be-b448b86cfd06") },
                    { new Guid("82b30a0b-dc8e-412a-a80e-26c9c64f36b0"), "Название документа, реквизиты", 1, new Guid("0df3f623-601b-462e-95cc-e3a97331980f") },
                    { new Guid("86a1d5b6-afdf-4f17-b3a7-02225e22afcc"), "Индекс Хирша (за все время)", 5, new Guid("fddf60e5-3be0-46c4-8827-4f6a810fd918") },
                    { new Guid("8a25a044-0f11-4f1b-ad4b-db63da70aa63"), "Период выполнения", 3, new Guid("e6da3db2-cfbf-487e-8185-a738b9b0c600") },
                    { new Guid("8ce6e5b3-72ad-4104-a7f1-4fc4a1588b55"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("449f9dee-be7a-4831-90ac-c3070827fe9b") },
                    { new Guid("923cc5e0-5209-4db7-937e-b313b2663828"), "Статус (руководитель/исполнитель)", 4, new Guid("e6da3db2-cfbf-487e-8185-a738b9b0c600") },
                    { new Guid("b063b4eb-1c3b-45bf-a3ea-a631676a7d56"), "Награда", 4, new Guid("aad09686-5488-43eb-942a-0efc3dbea728") },
                    { new Guid("b198f0d8-3124-456e-8495-a3d393f7bfb9"), "Соавторы", 3, new Guid("72479481-80b7-4458-9c72-c402755a8ebc") },
                    { new Guid("b252c831-7818-4e8b-89a1-1cf8c27bc061"), "Название", 2, new Guid("72479481-80b7-4458-9c72-c402755a8ebc") },
                    { new Guid("b260b800-89b9-4c5b-a9a8-bddb9da7de77"), "Ссылка на платформу", 3, new Guid("21e14f60-95ac-44c5-9c29-337812234c8d") },
                    { new Guid("bbc0ec5a-348d-4f34-b92a-7f46b89a26b2"), "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("0cf36fef-af1e-4424-8eca-5c7d3166f01d") },
                    { new Guid("bbf9e407-f8ea-4efc-9adf-f0f54862ee90"), "Название статьи", 1, new Guid("0cf36fef-af1e-4424-8eca-5c7d3166f01d") },
                    { new Guid("bc85ada5-7774-4d62-9918-ae06c94d1d11"), "Количество цитирований", 4, new Guid("fddf60e5-3be0-46c4-8827-4f6a810fd918") },
                    { new Guid("be21ad6a-d994-4307-9fec-9ba7651f402f"), "Издательство, год", 6, new Guid("72479481-80b7-4458-9c72-c402755a8ebc") },
                    { new Guid("c6b90966-e1e9-450a-9747-608f9d191e21"), "Идентификатор", 2, new Guid("fddf60e5-3be0-46c4-8827-4f6a810fd918") },
                    { new Guid("ca350c21-b0c3-4567-b160-25274cd9d3cb"), "Соавторы", 2, new Guid("21e14f60-95ac-44c5-9c29-337812234c8d") },
                    { new Guid("cc35f93d-d936-4fbb-a965-3683714e9bd7"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("e6da3db2-cfbf-487e-8185-a738b9b0c600") },
                    { new Guid("cdd06ce4-b090-4735-894a-f69805c4c869"), "Год", 1, new Guid("aad09686-5488-43eb-942a-0efc3dbea728") },
                    { new Guid("cf2b6266-0514-40df-aea5-97306f466a66"), "Год получения документа", 2, new Guid("0df3f623-601b-462e-95cc-e3a97331980f") },
                    { new Guid("d2902769-c82a-4d09-a091-3c3777dcc3a7"), "Название дисциплины", 1, new Guid("1c4ee49f-2575-4f6e-8528-f0c080ea3ee5") },
                    { new Guid("d33ce737-8f32-419e-b51f-47dc36676d3f"), "Наименование курса", 1, new Guid("16684938-c87e-43d0-82df-50156168324f") },
                    { new Guid("d69bbe14-7714-4fc4-8019-06282590c1ff"), "Вид (лекции, лабораторные)", 2, new Guid("1c4ee49f-2575-4f6e-8528-f0c080ea3ee5") },
                    { new Guid("e22ac476-b5dc-4145-96ed-e3afa961e3bb"), "Название НИР/НИОКР", 1, new Guid("e6da3db2-cfbf-487e-8185-a738b9b0c600") },
                    { new Guid("e4869870-81cb-46ae-97c5-c36c5f75a063"), "Название конкурса/премии", 2, new Guid("449f9dee-be7a-4831-90ac-c3070827fe9b") },
                    { new Guid("ebbb99f4-e9a7-4458-84fd-d22d64722681"), "Количество печатных листов", 4, new Guid("72479481-80b7-4458-9c72-c402755a8ebc") },
                    { new Guid("f5ce9be2-40a7-4b72-89b6-27dfad1adad9"), "Вид публикации", 1, new Guid("72479481-80b7-4458-9c72-c402755a8ebc") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("04568b26-f758-497c-b895-f0c8dd2e0a7d"), new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1") },
                    { new Guid("1a314c1b-e926-45b3-a695-12df1d237c13"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("1db89be5-fc68-4a04-973d-62676f453550"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("1db89be5-fc68-4a04-973d-62676f453550"), new Guid("7502619e-4f9c-4055-8318-41d9c97ea2cc") },
                    { new Guid("1db89be5-fc68-4a04-973d-62676f453550"), new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1") },
                    { new Guid("1f4c398f-28a4-47a1-99cc-7b8386496566"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("29b4a310-1c37-49a0-aae8-bcca502b500f"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("58d6543a-ec3e-4687-8012-a1dee0156099"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("5c16da5c-b9f1-4f40-ad5b-9d0548c793ae"), new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e") },
                    { new Guid("60fcb60f-5c1f-4a16-a20e-fd71ee25ae54"), new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e") },
                    { new Guid("65bad0b0-2995-4791-a324-42e237cac770"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("77bcb6a4-1369-462a-8d4c-95940ea3bd3c"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("7d2e8571-2577-4700-9414-35259b71ebe3"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("7fe544e0-a5a0-427c-8cd4-c4fdc84fad98"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("91950ec9-87d6-4703-a946-f455d72f3b01"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("a1bfc8a0-654c-4299-b49c-432c5a3b3dbb"), new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e") },
                    { new Guid("a3ef526f-1673-4b63-ac72-1df74c31814d"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("a59fd96f-1665-44f7-b2f5-c5f6561ceb79"), new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e") },
                    { new Guid("ae9e053b-4cc0-48be-9a24-553c1496a5de"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("b5167228-45a8-451b-9cc2-1c30b022bcfd"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("c1d31301-3bab-4a61-95c9-891ed5a64a3d"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("c3a9285d-e143-4843-9a96-23a4621f24d5"), new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e") },
                    { new Guid("e0bff50a-5bff-4269-9f45-a717534ac494"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("e3fba1a3-b4ae-4fd2-87ec-7dfd67221a6e"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("eeba3031-853c-4b79-9fdf-dcee4d7a1e42"), new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1") },
                    { new Guid("f0ba2f58-c0a5-4c87-8564-5fc268aebb79"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") },
                    { new Guid("ff104d50-51bd-4444-a669-7fc71ba38d56"), new Guid("4028e6c6-278c-4b5b-9dde-8a78901ce4ac") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e"), new Guid("16684938-c87e-43d0-82df-50156168324f") },
                    { new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e"), new Guid("21e14f60-95ac-44c5-9c29-337812234c8d") },
                    { new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e"), new Guid("3fb2076b-4d42-4c13-b2f5-97032273da53") },
                    { new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e"), new Guid("449f9dee-be7a-4831-90ac-c3070827fe9b") },
                    { new Guid("7502619e-4f9c-4055-8318-41d9c97ea2cc"), new Guid("0df3f623-601b-462e-95cc-e3a97331980f") },
                    { new Guid("7502619e-4f9c-4055-8318-41d9c97ea2cc"), new Guid("aad09686-5488-43eb-942a-0efc3dbea728") },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), new Guid("0cf36fef-af1e-4424-8eca-5c7d3166f01d") },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), new Guid("aad09686-5488-43eb-942a-0efc3dbea728") },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), new Guid("e6da3db2-cfbf-487e-8185-a738b9b0c600") },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), new Guid("fddf60e5-3be0-46c4-8827-4f6a810fd918") },
                    { new Guid("e943d4fe-7108-4a02-bd2b-d8f740d82dd6"), new Guid("1c4ee49f-2575-4f6e-8528-f0c080ea3ee5") },
                    { new Guid("e943d4fe-7108-4a02-bd2b-d8f740d82dd6"), new Guid("72479481-80b7-4458-9c72-c402755a8ebc") },
                    { new Guid("fdcdcc79-c97c-4353-8957-7875798f3559"), new Guid("0df3f623-601b-462e-95cc-e3a97331980f") },
                    { new Guid("fdcdcc79-c97c-4353-8957-7875798f3559"), new Guid("13111c2b-e7ae-439f-8fde-e5462d3616cd") },
                    { new Guid("fdcdcc79-c97c-4353-8957-7875798f3559"), new Guid("ce1b3d8e-9988-4079-91be-b448b86cfd06") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("072fd708-17a2-4267-9b0c-2e79881183db"), new Guid("1db89be5-fc68-4a04-973d-62676f453550"), "Баллы за ученое звание:", 13, null },
                    { new Guid("0d35de47-af7b-4d2d-ba80-d4fb9e76ac5d"), null, "Баллы по базе РИНЦ:", 18, new Guid("fddf60e5-3be0-46c4-8827-4f6a810fd918") },
                    { new Guid("1c7255a6-9e14-48e3-976a-1fd048d5e73d"), null, "Баллы за труды с грифом и без соавторства:", 8, new Guid("72479481-80b7-4458-9c72-c402755a8ebc") },
                    { new Guid("2b89e38f-a6db-4eb5-bc68-d3f6375006ba"), new Guid("a59fd96f-1665-44f7-b2f5-c5f6561ceb79"), "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("3667af7f-87f2-493e-818a-3ee0103984e0"), null, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("21e14f60-95ac-44c5-9c29-337812234c8d") },
                    { new Guid("3cffba1c-8a5c-49c1-8611-2f6f86677c28"), null, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("1c4ee49f-2575-4f6e-8528-f0c080ea3ee5") },
                    { new Guid("478d4edb-5631-4296-af48-955ee92749ed"), null, "Баллы за объем учебной нагрузки:", 1, new Guid("16684938-c87e-43d0-82df-50156168324f") },
                    { new Guid("4ac61d6d-1de4-435e-82c8-1a657bb758ce"), null, "Баллы за труды без грифа в соавторстве:", 11, new Guid("72479481-80b7-4458-9c72-c402755a8ebc") },
                    { new Guid("4db083e9-2f21-4fc3-8ca6-bf681ad19f24"), null, "Баллы по базе Scopus:", 17, new Guid("fddf60e5-3be0-46c4-8827-4f6a810fd918") },
                    { new Guid("65e73d56-85dc-47cd-bfbf-ae24d2391a3d"), null, "Баллы за научные публикации:", 16, new Guid("0cf36fef-af1e-4424-8eca-5c7d3166f01d") },
                    { new Guid("6c623e6e-d8d9-45bd-b95d-a04e2fbdac4a"), new Guid("5c16da5c-b9f1-4f40-ad5b-9d0548c793ae"), "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("7b842512-e5c7-4c79-88e1-8c3025663096"), null, "Баллы за труды с грифом в соавторстве:", 9, new Guid("72479481-80b7-4458-9c72-c402755a8ebc") },
                    { new Guid("8441675f-951a-4e89-99ee-52904e717c9a"), null, "Баллы за количество разработок:", 24, new Guid("ce1b3d8e-9988-4079-91be-b448b86cfd06") },
                    { new Guid("84899ed4-d549-47db-ae70-00830e77b8c2"), null, "Баллы за награды:", 14, new Guid("aad09686-5488-43eb-942a-0efc3dbea728") },
                    { new Guid("86388cb9-b085-4af8-b0e1-39f61598b069"), null, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("e6da3db2-cfbf-487e-8185-a738b9b0c600") },
                    { new Guid("95be84b8-f5ea-4119-bb37-932bdd0d1ffb"), null, "Баллы за профессиональное развитие:", 15, new Guid("0df3f623-601b-462e-95cc-e3a97331980f") },
                    { new Guid("9c16c3a0-d558-427b-922b-d1ccb9939d86"), null, "Баллы за труды без грифа и без соавторства:", 10, new Guid("72479481-80b7-4458-9c72-c402755a8ebc") },
                    { new Guid("a284a176-3d0b-40be-8dc1-c0d718811574"), null, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("449f9dee-be7a-4831-90ac-c3070827fe9b") },
                    { new Guid("a6b495c6-2356-40ac-8698-7535cb0ed159"), null, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("13111c2b-e7ae-439f-8fde-e5462d3616cd") },
                    { new Guid("b937d80d-d771-48bd-944a-c8cb93d09164"), new Guid("04568b26-f758-497c-b895-f0c8dd2e0a7d"), "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("cfee6e78-e588-48d5-bcc9-e708c50a1534"), new Guid("60fcb60f-5c1f-4a16-a20e-fd71ee25ae54"), "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("d5976d72-53d9-4b61-8ffd-f1beeafed95d"), null, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("e6da3db2-cfbf-487e-8185-a738b9b0c600") },
                    { new Guid("d5ab3d0d-fd2d-4334-b79d-72ed7652bf2d"), new Guid("eeba3031-853c-4b79-9fdf-dcee4d7a1e42"), "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("def93b42-eb98-4596-9bf9-10c70aac7b21"), null, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("16684938-c87e-43d0-82df-50156168324f") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e"), new Guid("2b89e38f-a6db-4eb5-bc68-d3f6375006ba") },
                    { new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e"), new Guid("3667af7f-87f2-493e-818a-3ee0103984e0") },
                    { new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e"), new Guid("478d4edb-5631-4296-af48-955ee92749ed") },
                    { new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e"), new Guid("6c623e6e-d8d9-45bd-b95d-a04e2fbdac4a") },
                    { new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e"), new Guid("a284a176-3d0b-40be-8dc1-c0d718811574") },
                    { new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e"), new Guid("cfee6e78-e588-48d5-bcc9-e708c50a1534") },
                    { new Guid("106cc9d0-2d64-4777-b184-86b0b2c1983e"), new Guid("def93b42-eb98-4596-9bf9-10c70aac7b21") },
                    { new Guid("7502619e-4f9c-4055-8318-41d9c97ea2cc"), new Guid("072fd708-17a2-4267-9b0c-2e79881183db") },
                    { new Guid("7502619e-4f9c-4055-8318-41d9c97ea2cc"), new Guid("84899ed4-d549-47db-ae70-00830e77b8c2") },
                    { new Guid("7502619e-4f9c-4055-8318-41d9c97ea2cc"), new Guid("95be84b8-f5ea-4119-bb37-932bdd0d1ffb") },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), new Guid("072fd708-17a2-4267-9b0c-2e79881183db") },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), new Guid("0d35de47-af7b-4d2d-ba80-d4fb9e76ac5d") },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), new Guid("4db083e9-2f21-4fc3-8ca6-bf681ad19f24") },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), new Guid("65e73d56-85dc-47cd-bfbf-ae24d2391a3d") },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), new Guid("84899ed4-d549-47db-ae70-00830e77b8c2") },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), new Guid("86388cb9-b085-4af8-b0e1-39f61598b069") },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), new Guid("b937d80d-d771-48bd-944a-c8cb93d09164") },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), new Guid("d5976d72-53d9-4b61-8ffd-f1beeafed95d") },
                    { new Guid("9e5fa490-ebd8-475e-9463-455cb4b441a1"), new Guid("d5ab3d0d-fd2d-4334-b79d-72ed7652bf2d") },
                    { new Guid("e943d4fe-7108-4a02-bd2b-d8f740d82dd6"), new Guid("1c7255a6-9e14-48e3-976a-1fd048d5e73d") },
                    { new Guid("e943d4fe-7108-4a02-bd2b-d8f740d82dd6"), new Guid("3cffba1c-8a5c-49c1-8611-2f6f86677c28") },
                    { new Guid("e943d4fe-7108-4a02-bd2b-d8f740d82dd6"), new Guid("4ac61d6d-1de4-435e-82c8-1a657bb758ce") },
                    { new Guid("e943d4fe-7108-4a02-bd2b-d8f740d82dd6"), new Guid("7b842512-e5c7-4c79-88e1-8c3025663096") },
                    { new Guid("e943d4fe-7108-4a02-bd2b-d8f740d82dd6"), new Guid("9c16c3a0-d558-427b-922b-d1ccb9939d86") },
                    { new Guid("fdcdcc79-c97c-4353-8957-7875798f3559"), new Guid("8441675f-951a-4e89-99ee-52904e717c9a") },
                    { new Guid("fdcdcc79-c97c-4353-8957-7875798f3559"), new Guid("95be84b8-f5ea-4119-bb37-932bdd0d1ffb") },
                    { new Guid("fdcdcc79-c97c-4353-8957-7875798f3559"), new Guid("a6b495c6-2356-40ac-8698-7535cb0ed159") }
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
