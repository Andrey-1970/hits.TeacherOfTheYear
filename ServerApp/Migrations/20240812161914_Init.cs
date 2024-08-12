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
                    { new Guid("34477e0b-6dd3-495b-a1ba-b7e34cfe87de"), "Профессиональное развитие", 3 },
                    { new Guid("70f75df0-1218-4a64-b025-938d15c54dc1"), "Деятельность", 5 },
                    { new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), "Общая информация", 1 },
                    { new Guid("950d9b95-7924-45b8-ba68-bd8d8940a195"), "Деятельность", 4 },
                    { new Guid("afc7db01-42b0-4d9c-8e63-8de2b27fbcca"), "Категория участников", 2 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("18f9a4e2-9b21-4038-ad2b-db1622c16a68"), "Итог", 8 },
                    { new Guid("2d34e4df-d41d-4e12-80a4-0a5e98155535"), "Методическая деятельность", 3 },
                    { new Guid("47d8b318-512b-41e6-901e-8501f69c3192"), "Конкурсная работа", 7 },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("995c21d6-b018-4ecf-bf78-a4dc2db42e78"), "Профессиональные показатели", 4 },
                    { new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81"), "Образовательная деятельность", 2 },
                    { new Guid("f3857d25-df47-4b75-a417-45e14cafe467"), "Инновационная и иная деятельность", 6 },
                    { new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73"), "Основной", 1 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("69749738-0dc1-47c3-be26-5801ac555546"), null, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("7d154ba3-fd84-4ef8-8322-06cdbed67f99"), null, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("46ffec34-bea9-4a4d-ab63-797dfa23fe28"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("da0bc58d-4994-4cef-9c29-0b610d0f4496"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("34477e0b-6dd3-495b-a1ba-b7e34cfe87de"), new Guid("46ffec34-bea9-4a4d-ab63-797dfa23fe28") },
                    { new Guid("34477e0b-6dd3-495b-a1ba-b7e34cfe87de"), new Guid("da0bc58d-4994-4cef-9c29-0b610d0f4496") },
                    { new Guid("70f75df0-1218-4a64-b025-938d15c54dc1"), new Guid("46ffec34-bea9-4a4d-ab63-797dfa23fe28") },
                    { new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), new Guid("46ffec34-bea9-4a4d-ab63-797dfa23fe28") },
                    { new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), new Guid("da0bc58d-4994-4cef-9c29-0b610d0f4496") },
                    { new Guid("950d9b95-7924-45b8-ba68-bd8d8940a195"), new Guid("da0bc58d-4994-4cef-9c29-0b610d0f4496") },
                    { new Guid("afc7db01-42b0-4d9c-8e63-8de2b27fbcca"), new Guid("46ffec34-bea9-4a4d-ab63-797dfa23fe28") },
                    { new Guid("afc7db01-42b0-4d9c-8e63-8de2b27fbcca"), new Guid("da0bc58d-4994-4cef-9c29-0b610d0f4496") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "Name" },
                values: new object[,]
                {
                    { new Guid("23348e04-0687-45b5-8f18-0a89fa519e48"), new Guid("afc7db01-42b0-4d9c-8e63-8de2b27fbcca"), "Название конкрусной работы" },
                    { new Guid("42b1767d-3925-448d-b380-6c5efc5c7583"), new Guid("950d9b95-7924-45b8-ba68-bd8d8940a195"), "Защитившиеся специалисты" },
                    { new Guid("5f7c37d8-1bc8-4d0d-bf60-9b2175695ace"), new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), "Стаж научно-педагогической деятельности по трудовой книжке" },
                    { new Guid("72cc4aa7-9ba7-4514-b2e9-1e6164e00fff"), new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), "Место работы/учебы" },
                    { new Guid("7d7f1df9-2b61-40bb-9462-05d85fc2b723"), new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), "Институт, факультет, кафедра, лаборатория" },
                    { new Guid("80574462-e904-41b1-af58-3e8a02cba2d4"), new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), "Дополнительная информация" },
                    { new Guid("81c29122-9272-4718-b454-a6a589c2a2ba"), new Guid("afc7db01-42b0-4d9c-8e63-8de2b27fbcca"), "Научная специальность (по классификации ВАК)" },
                    { new Guid("822ba81c-22c6-49f0-9899-7db98eb77a5a"), new Guid("70f75df0-1218-4a64-b025-938d15c54dc1"), "Защитившиеся доктора наук" },
                    { new Guid("83441c44-796e-4dbb-aead-056159c2dce1"), new Guid("950d9b95-7924-45b8-ba68-bd8d8940a195"), "Защитившиеся доктора наук" },
                    { new Guid("90e53935-15ca-4433-a770-87622da25149"), new Guid("afc7db01-42b0-4d9c-8e63-8de2b27fbcca"), "Ученое звание" },
                    { new Guid("93677443-a142-4d85-83a5-49a3f079a469"), new Guid("950d9b95-7924-45b8-ba68-bd8d8940a195"), "Защитившиеся бакалавры" },
                    { new Guid("980d7a62-fb79-4a46-af71-263f219d8b04"), new Guid("afc7db01-42b0-4d9c-8e63-8de2b27fbcca"), "Ученая степень" },
                    { new Guid("a1475b85-bce2-4d4e-bf6e-a55d73142af3"), new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), "Электронная почта" },
                    { new Guid("a6593314-2484-4bc3-91ec-f35e48b8c053"), new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), "ФИО" },
                    { new Guid("aa3fabf0-f20d-482d-bfea-212f91ff8a07"), new Guid("950d9b95-7924-45b8-ba68-bd8d8940a195"), "Защитившиеся кадидаты наук" },
                    { new Guid("c13b4ee9-a5e8-49ca-850a-7d4c96531f13"), new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), "Адрес работы/учебы" },
                    { new Guid("c1edc6c1-6e81-4cd6-8e11-b1ab1456038b"), new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), "Контактный телефон" },
                    { new Guid("cfec285a-b0da-4193-9ba9-80b8994bab5e"), new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), "Дата рождения" },
                    { new Guid("d04d5fda-2526-4d63-b07f-c767f6b51e49"), new Guid("afc7db01-42b0-4d9c-8e63-8de2b27fbcca"), "Категория участника конкурса" },
                    { new Guid("d103df4a-f97d-4598-a531-3b23514bb98b"), new Guid("70f75df0-1218-4a64-b025-938d15c54dc1"), "Защитившиеся кандидаты наук" },
                    { new Guid("d3877fb5-3a66-449d-8cf4-9c112a5bc441"), new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), "Домашний адрес" },
                    { new Guid("e12bb6e2-2780-4658-965e-2a014516fcff"), new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), "Должность" },
                    { new Guid("e8469c5c-8eae-4a60-8f09-0a89ead12a91"), new Guid("afc7db01-42b0-4d9c-8e63-8de2b27fbcca"), "Направление конкурса" },
                    { new Guid("eb800ad6-bb42-4678-a248-b851b0f8c5be"), new Guid("950d9b95-7924-45b8-ba68-bd8d8940a195"), "Защитившиеся магистры" },
                    { new Guid("f98e1731-97c7-4654-9374-84bf22a85775"), new Guid("71b54aa4-819a-4d62-b91a-19546a653b44"), "Трек конкурса" }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("18f9a4e2-9b21-4038-ad2b-db1622c16a68"), new Guid("46ffec34-bea9-4a4d-ab63-797dfa23fe28") },
                    { new Guid("18f9a4e2-9b21-4038-ad2b-db1622c16a68"), new Guid("da0bc58d-4994-4cef-9c29-0b610d0f4496") },
                    { new Guid("2d34e4df-d41d-4e12-80a4-0a5e98155535"), new Guid("da0bc58d-4994-4cef-9c29-0b610d0f4496") },
                    { new Guid("47d8b318-512b-41e6-901e-8501f69c3192"), new Guid("46ffec34-bea9-4a4d-ab63-797dfa23fe28") },
                    { new Guid("47d8b318-512b-41e6-901e-8501f69c3192"), new Guid("da0bc58d-4994-4cef-9c29-0b610d0f4496") },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), new Guid("46ffec34-bea9-4a4d-ab63-797dfa23fe28") },
                    { new Guid("995c21d6-b018-4ecf-bf78-a4dc2db42e78"), new Guid("da0bc58d-4994-4cef-9c29-0b610d0f4496") },
                    { new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81"), new Guid("da0bc58d-4994-4cef-9c29-0b610d0f4496") },
                    { new Guid("f3857d25-df47-4b75-a417-45e14cafe467"), new Guid("46ffec34-bea9-4a4d-ab63-797dfa23fe28") },
                    { new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73"), new Guid("46ffec34-bea9-4a4d-ab63-797dfa23fe28") },
                    { new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73"), new Guid("da0bc58d-4994-4cef-9c29-0b610d0f4496") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("f3857d25-df47-4b75-a417-45e14cafe467"), new Guid("69749738-0dc1-47c3-be26-5801ac555546") },
                    { new Guid("f3857d25-df47-4b75-a417-45e14cafe467"), new Guid("7d154ba3-fd84-4ef8-8322-06cdbed67f99") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "Name" },
                values: new object[,]
                {
                    { new Guid("0d478bd6-c5de-4bfa-86a6-0732027d785b"), new Guid("70f75df0-1218-4a64-b025-938d15c54dc1"), "Персональные идентификаторы и показатели" },
                    { new Guid("2b1500d6-07d4-413a-a77a-5a869e3f1bf3"), new Guid("70f75df0-1218-4a64-b025-938d15c54dc1"), "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)" },
                    { new Guid("4e93d1bf-3903-4fc6-9a13-aaba9449dde3"), new Guid("950d9b95-7924-45b8-ba68-bd8d8940a195"), "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год" },
                    { new Guid("585b3d0a-316e-4fbc-a431-b9d3716c5cbd"), new Guid("950d9b95-7924-45b8-ba68-bd8d8940a195"), "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет" },
                    { new Guid("8785c8fe-4be9-44b8-bc18-322ac329e289"), new Guid("950d9b95-7924-45b8-ba68-bd8d8940a195"), "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет" },
                    { new Guid("8e9af628-f992-4203-b1f7-3dcdf5df703f"), new Guid("950d9b95-7924-45b8-ba68-bd8d8940a195"), "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание" },
                    { new Guid("91bbc6cc-8408-48a3-895f-c67230aeb96d"), new Guid("70f75df0-1218-4a64-b025-938d15c54dc1"), "Список научных публикаций за последние 5 лет" },
                    { new Guid("b13e73c1-96c9-491e-92c5-17c2dc6db1e3"), new Guid("950d9b95-7924-45b8-ba68-bd8d8940a195"), "Учебная нагрузка за предыдущий учебный год (за исключением методической)" },
                    { new Guid("c1dc8519-6ede-4a0f-91a8-83695a048a02"), new Guid("70f75df0-1218-4a64-b025-938d15c54dc1"), "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет" },
                    { new Guid("e5ce75ca-f48a-43a1-aa5d-129e8be5fb1a"), new Guid("34477e0b-6dd3-495b-a1ba-b7e34cfe87de"), "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности" },
                    { new Guid("f631c791-de01-4ca4-888a-e3f4d1f9f78f"), new Guid("950d9b95-7924-45b8-ba68-bd8d8940a195"), "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет" },
                    { new Guid("f8877ea3-11d3-44de-a4fd-0fd53a340233"), new Guid("70f75df0-1218-4a64-b025-938d15c54dc1"), "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)" },
                    { new Guid("f9784464-9672-447a-9b2c-799f2ed87539"), new Guid("34477e0b-6dd3-495b-a1ba-b7e34cfe87de"), "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)" }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "TableId" },
                values: new object[,]
                {
                    { new Guid("025250e3-53f1-475b-af19-6264c1299dde"), "Год", new Guid("585b3d0a-316e-4fbc-a431-b9d3716c5cbd") },
                    { new Guid("041748cd-c484-4152-b278-a4a2d8fad644"), "Год получения документа", new Guid("f9784464-9672-447a-9b2c-799f2ed87539") },
                    { new Guid("0c62c792-f677-4d60-84d3-704a136ba4fc"), "Количество цитирований", new Guid("0d478bd6-c5de-4bfa-86a6-0732027d785b") },
                    { new Guid("0e5d9f98-92b9-4bb6-ab73-7f582baf6f32"), "Количество публикаций в БАЗЕ", new Guid("0d478bd6-c5de-4bfa-86a6-0732027d785b") },
                    { new Guid("14ac116f-5777-4ef2-a47f-ef7ff0510137"), "Ссылка на платформу", new Guid("585b3d0a-316e-4fbc-a431-b9d3716c5cbd") },
                    { new Guid("266ea8bf-ab71-40a8-b867-7c8e416af7b2"), "Название конкурса", new Guid("e5ce75ca-f48a-43a1-aa5d-129e8be5fb1a") },
                    { new Guid("2c89b7db-319e-4eed-a618-ce0a8cecc2ee"), "Вид", new Guid("f8877ea3-11d3-44de-a4fd-0fd53a340233") },
                    { new Guid("2d7034dd-9eea-457d-bbbb-9e541857f393"), "Название", new Guid("2b1500d6-07d4-413a-a77a-5a869e3f1bf3") },
                    { new Guid("2dd70cd4-d1bd-46eb-9727-dbb53753acdf"), "Тип публикации (категория ВАК/квартиль МБД)", new Guid("91bbc6cc-8408-48a3-895f-c67230aeb96d") },
                    { new Guid("2e777e4f-bcfe-4cb3-a9cf-8c63f021cfec"), "ФИО", new Guid("8e9af628-f992-4203-b1f7-3dcdf5df703f") },
                    { new Guid("349628de-057d-41ff-a557-ee5ac02b86c6"), "Период выполнения", new Guid("c1dc8519-6ede-4a0f-91a8-83695a048a02") },
                    { new Guid("361833ca-bf89-4abe-9307-9325952073e7"), "Название курса", new Guid("585b3d0a-316e-4fbc-a431-b9d3716c5cbd") },
                    { new Guid("38fe442e-5399-4acd-9444-3c81c7521f4f"), "Год", new Guid("8e9af628-f992-4203-b1f7-3dcdf5df703f") },
                    { new Guid("3a692d43-f99f-4a73-9eff-d05f97817edf"), "Награда", new Guid("e5ce75ca-f48a-43a1-aa5d-129e8be5fb1a") },
                    { new Guid("3e1652ec-1f28-4b9a-a9c4-9cf4baa15e97"), "Ссылка", new Guid("e5ce75ca-f48a-43a1-aa5d-129e8be5fb1a") },
                    { new Guid("41b31f74-1d36-432c-8196-3743d1e34d8c"), "Название документа, реквизиты", new Guid("f9784464-9672-447a-9b2c-799f2ed87539") },
                    { new Guid("47164431-34ba-40d1-a5a7-1fd0c826f9eb"), "Место нахождения (субъект РФ, зарубежье)", new Guid("4e93d1bf-3903-4fc6-9a13-aaba9449dde3") },
                    { new Guid("4fdf1309-c8e8-4018-a48a-0716338dd7f1"), "Название статьи", new Guid("91bbc6cc-8408-48a3-895f-c67230aeb96d") },
                    { new Guid("4ffca42f-f66e-49a7-8064-645f82581f81"), "Количество печатных листов", new Guid("8785c8fe-4be9-44b8-bc18-322ac329e289") },
                    { new Guid("530881fc-be01-410f-b350-e9585f945ff1"), "Лекции (час.)", new Guid("b13e73c1-96c9-491e-92c5-17c2dc6db1e3") },
                    { new Guid("546be5e5-89d8-482a-a037-4d3b1338d11e"), "Название", new Guid("8785c8fe-4be9-44b8-bc18-322ac329e289") },
                    { new Guid("5f586430-9289-4095-bfea-3c6f77c3d9b7"), "ФИО соавторов", new Guid("2b1500d6-07d4-413a-a77a-5a869e3f1bf3") },
                    { new Guid("666d586b-d749-4043-a93c-479696dc0eeb"), "Практические занятия (час.)", new Guid("b13e73c1-96c9-491e-92c5-17c2dc6db1e3") },
                    { new Guid("6912d81f-5e4c-41b4-9011-d8d324e8c7ac"), "Год", new Guid("e5ce75ca-f48a-43a1-aa5d-129e8be5fb1a") },
                    { new Guid("6f9063b2-48d2-4595-9bfc-46bd0fe787c7"), "Сумма финансирования (тыс. руб.)", new Guid("c1dc8519-6ede-4a0f-91a8-83695a048a02") },
                    { new Guid("723bac0e-c4f3-4768-aee8-f2b172eb7ba0"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", new Guid("c1dc8519-6ede-4a0f-91a8-83695a048a02") },
                    { new Guid("72cefb68-9d1b-4ca2-9141-acbc4eca7f13"), "Издание, год", new Guid("91bbc6cc-8408-48a3-895f-c67230aeb96d") },
                    { new Guid("799edb64-c533-4f6f-98fd-fe93d9baecc2"), "Количество часов", new Guid("4e93d1bf-3903-4fc6-9a13-aaba9449dde3") },
                    { new Guid("7c956812-22ed-43da-8b3c-3cb5190f2049"), "Наличие грифа", new Guid("8785c8fe-4be9-44b8-bc18-322ac329e289") },
                    { new Guid("7e41c8ac-28d4-47d7-9439-ac0562c076e6"), "Название конкурса/премии", new Guid("8e9af628-f992-4203-b1f7-3dcdf5df703f") },
                    { new Guid("7e4410ed-042c-47fb-826a-6410db010244"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", new Guid("8e9af628-f992-4203-b1f7-3dcdf5df703f") },
                    { new Guid("81aeb59e-9a9a-44e9-beea-c8752f455745"), "Соавторы", new Guid("8785c8fe-4be9-44b8-bc18-322ac329e289") },
                    { new Guid("899baa66-c4df-44bd-a025-de7fc125858b"), "Вид публикации", new Guid("8785c8fe-4be9-44b8-bc18-322ac329e289") },
                    { new Guid("94ed90d2-5167-4f1a-9720-4c1d7b0cae41"), "Язык преподавания (русск./англ./др.)", new Guid("b13e73c1-96c9-491e-92c5-17c2dc6db1e3") },
                    { new Guid("98091ea9-afc5-4764-bc4d-35ca257234d2"), "Статус конкурса", new Guid("e5ce75ca-f48a-43a1-aa5d-129e8be5fb1a") },
                    { new Guid("9f33c074-b208-4cdc-bfef-21f50ed32c43"), "Вид деятельности (преподавательская)", new Guid("4e93d1bf-3903-4fc6-9a13-aaba9449dde3") },
                    { new Guid("a588df04-d08c-46b2-93ab-a9871700b73a"), "Название организации в которую внедрена разработка", new Guid("f8877ea3-11d3-44de-a4fd-0fd53a340233") },
                    { new Guid("a5e6a85f-8793-4f5c-a871-4da9be3b7781"), "Идентификатор", new Guid("0d478bd6-c5de-4bfa-86a6-0732027d785b") },
                    { new Guid("a682d6b2-6c8c-4442-a1ac-29b8654775d7"), "Тип идентификатора", new Guid("0d478bd6-c5de-4bfa-86a6-0732027d785b") },
                    { new Guid("aaac91cc-85cc-44cf-9b8d-54584daf8741"), "Статус (руководитель/исполнитель)", new Guid("c1dc8519-6ede-4a0f-91a8-83695a048a02") },
                    { new Guid("aee91b9a-add7-4a3f-b063-f8ea4c621b9a"), "Издательство, год", new Guid("8785c8fe-4be9-44b8-bc18-322ac329e289") },
                    { new Guid("b1161c6f-aa72-433b-8c58-9c41b59115a3"), "Название НИР/НИОКР", new Guid("c1dc8519-6ede-4a0f-91a8-83695a048a02") },
                    { new Guid("b1c4799f-bf6f-4ace-94a8-30773383c7ed"), "Номер РИД", new Guid("2b1500d6-07d4-413a-a77a-5a869e3f1bf3") },
                    { new Guid("b2ddfa8a-cbdd-41fc-898b-78272f208e6a"), "Соавторы", new Guid("585b3d0a-316e-4fbc-a431-b9d3716c5cbd") },
                    { new Guid("b9a377a9-f79e-4c61-9079-6281b069cd00"), "Вид", new Guid("2b1500d6-07d4-413a-a77a-5a869e3f1bf3") },
                    { new Guid("be010434-8e3a-4444-bdcf-9b41eac3a772"), "Название организации/должность/ставка", new Guid("4e93d1bf-3903-4fc6-9a13-aaba9449dde3") },
                    { new Guid("bead8b0c-c03f-4da4-86ef-9eb254d4610f"), "Итого (час.)", new Guid("b13e73c1-96c9-491e-92c5-17c2dc6db1e3") },
                    { new Guid("ddb08533-f990-4039-a075-488669ba20d6"), "Вид (лекции, лабораторные)", new Guid("f631c791-de01-4ca4-888a-e3f4d1f9f78f") },
                    { new Guid("e057e647-f324-4748-8a5b-8a7adebc04f6"), "Наименование курса", new Guid("b13e73c1-96c9-491e-92c5-17c2dc6db1e3") },
                    { new Guid("e09f8c18-73f2-4ea3-a4fc-e5f096e1daeb"), "Название дисциплины", new Guid("f631c791-de01-4ca4-888a-e3f4d1f9f78f") },
                    { new Guid("e306dedf-25f6-4f0d-afed-aa92c2ca81ed"), "Название разработки", new Guid("f8877ea3-11d3-44de-a4fd-0fd53a340233") },
                    { new Guid("e40ceb70-40a1-4ad3-a043-fe85af3d702e"), "Соавторы", new Guid("91bbc6cc-8408-48a3-895f-c67230aeb96d") },
                    { new Guid("e805cc60-4ec6-47f9-9c1b-5734b93c74f8"), "Награда/премия (медаль, диплом с указанием степени)", new Guid("8e9af628-f992-4203-b1f7-3dcdf5df703f") },
                    { new Guid("f4e487d1-0881-4667-8015-0bb2487dffaa"), "Индекс Хирша (за все время)", new Guid("0d478bd6-c5de-4bfa-86a6-0732027d785b") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("23348e04-0687-45b5-8f18-0a89fa519e48"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("42b1767d-3925-448d-b380-6c5efc5c7583"), new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81") },
                    { new Guid("5f7c37d8-1bc8-4d0d-bf60-9b2175695ace"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("72cc4aa7-9ba7-4514-b2e9-1e6164e00fff"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("7d7f1df9-2b61-40bb-9462-05d85fc2b723"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("80574462-e904-41b1-af58-3e8a02cba2d4"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("81c29122-9272-4718-b454-a6a589c2a2ba"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("822ba81c-22c6-49f0-9899-7db98eb77a5a"), new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f") },
                    { new Guid("83441c44-796e-4dbb-aead-056159c2dce1"), new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81") },
                    { new Guid("90e53935-15ca-4433-a770-87622da25149"), new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f") },
                    { new Guid("90e53935-15ca-4433-a770-87622da25149"), new Guid("995c21d6-b018-4ecf-bf78-a4dc2db42e78") },
                    { new Guid("90e53935-15ca-4433-a770-87622da25149"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("93677443-a142-4d85-83a5-49a3f079a469"), new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81") },
                    { new Guid("980d7a62-fb79-4a46-af71-263f219d8b04"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("a1475b85-bce2-4d4e-bf6e-a55d73142af3"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("a6593314-2484-4bc3-91ec-f35e48b8c053"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("aa3fabf0-f20d-482d-bfea-212f91ff8a07"), new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81") },
                    { new Guid("c13b4ee9-a5e8-49ca-850a-7d4c96531f13"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("c1edc6c1-6e81-4cd6-8e11-b1ab1456038b"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("cfec285a-b0da-4193-9ba9-80b8994bab5e"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("d04d5fda-2526-4d63-b07f-c767f6b51e49"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("d103df4a-f97d-4598-a531-3b23514bb98b"), new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f") },
                    { new Guid("d3877fb5-3a66-449d-8cf4-9c112a5bc441"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("e12bb6e2-2780-4658-965e-2a014516fcff"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("e8469c5c-8eae-4a60-8f09-0a89ead12a91"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") },
                    { new Guid("eb800ad6-bb42-4678-a248-b851b0f8c5be"), new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81") },
                    { new Guid("f98e1731-97c7-4654-9374-84bf22a85775"), new Guid("f3dc9e61-25fa-475b-b3a2-217797552f73") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("2d34e4df-d41d-4e12-80a4-0a5e98155535"), new Guid("8785c8fe-4be9-44b8-bc18-322ac329e289") },
                    { new Guid("2d34e4df-d41d-4e12-80a4-0a5e98155535"), new Guid("f631c791-de01-4ca4-888a-e3f4d1f9f78f") },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), new Guid("0d478bd6-c5de-4bfa-86a6-0732027d785b") },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), new Guid("91bbc6cc-8408-48a3-895f-c67230aeb96d") },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), new Guid("c1dc8519-6ede-4a0f-91a8-83695a048a02") },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), new Guid("e5ce75ca-f48a-43a1-aa5d-129e8be5fb1a") },
                    { new Guid("995c21d6-b018-4ecf-bf78-a4dc2db42e78"), new Guid("e5ce75ca-f48a-43a1-aa5d-129e8be5fb1a") },
                    { new Guid("995c21d6-b018-4ecf-bf78-a4dc2db42e78"), new Guid("f9784464-9672-447a-9b2c-799f2ed87539") },
                    { new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81"), new Guid("4e93d1bf-3903-4fc6-9a13-aaba9449dde3") },
                    { new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81"), new Guid("585b3d0a-316e-4fbc-a431-b9d3716c5cbd") },
                    { new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81"), new Guid("8e9af628-f992-4203-b1f7-3dcdf5df703f") },
                    { new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81"), new Guid("b13e73c1-96c9-491e-92c5-17c2dc6db1e3") },
                    { new Guid("f3857d25-df47-4b75-a417-45e14cafe467"), new Guid("2b1500d6-07d4-413a-a77a-5a869e3f1bf3") },
                    { new Guid("f3857d25-df47-4b75-a417-45e14cafe467"), new Guid("f8877ea3-11d3-44de-a4fd-0fd53a340233") },
                    { new Guid("f3857d25-df47-4b75-a417-45e14cafe467"), new Guid("f9784464-9672-447a-9b2c-799f2ed87539") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("038ad527-92ae-4093-ba74-82f1f831f1de"), new Guid("90e53935-15ca-4433-a770-87622da25149"), "Баллы за ученое звание:", 13, null },
                    { new Guid("11e75a53-35a9-4621-8340-89ffe110842a"), null, "Баллы за труды с грифом в соавторстве:", 9, new Guid("8785c8fe-4be9-44b8-bc18-322ac329e289") },
                    { new Guid("1d8767a7-fa10-42f5-9e3c-63168f2229e0"), null, "Баллы по базе Scopus:", 17, new Guid("0d478bd6-c5de-4bfa-86a6-0732027d785b") },
                    { new Guid("31e67ac8-504a-4421-bd53-adbeb1e76c85"), null, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("c1dc8519-6ede-4a0f-91a8-83695a048a02") },
                    { new Guid("381e8a50-58df-45db-afa5-774779a651eb"), new Guid("83441c44-796e-4dbb-aead-056159c2dce1"), "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("4040e7c8-e77d-4de9-baa0-152971cc0e12"), null, "Баллы за труды без грифа в соавторстве:", 11, new Guid("8785c8fe-4be9-44b8-bc18-322ac329e289") },
                    { new Guid("43b81216-0a90-4a1e-a086-99a40554f861"), null, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("f631c791-de01-4ca4-888a-e3f4d1f9f78f") },
                    { new Guid("4d7184a8-e42c-4bcd-a684-005def2257c9"), null, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("8e9af628-f992-4203-b1f7-3dcdf5df703f") },
                    { new Guid("578f49ae-4253-4dc5-ba03-2d0b41c2bacc"), null, "Баллы за научные публикации:", 16, new Guid("91bbc6cc-8408-48a3-895f-c67230aeb96d") },
                    { new Guid("68f7eddd-3eb4-42df-a145-edbfdef698db"), new Guid("aa3fabf0-f20d-482d-bfea-212f91ff8a07"), "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("6fd814f2-f710-4060-b362-6a9c042eeb57"), null, "Баллы за награды:", 14, new Guid("e5ce75ca-f48a-43a1-aa5d-129e8be5fb1a") },
                    { new Guid("7c1fcde7-2097-4ec0-bdcf-8f99ec2a34b6"), null, "Баллы за объем учебной нагрузки:", 1, new Guid("b13e73c1-96c9-491e-92c5-17c2dc6db1e3") },
                    { new Guid("7e5dc082-5465-4abd-8a34-0a795fe0df92"), new Guid("eb800ad6-bb42-4678-a248-b851b0f8c5be"), "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("905ec597-0cda-40ef-99c1-5da6f98db254"), null, "Баллы по базе РИНЦ:", 18, new Guid("0d478bd6-c5de-4bfa-86a6-0732027d785b") },
                    { new Guid("9f71b183-bb78-4463-a407-32d33c4b4a62"), null, "Баллы за труды с грифом и без соавторства:", 8, new Guid("8785c8fe-4be9-44b8-bc18-322ac329e289") },
                    { new Guid("b47fcc53-d007-438f-938b-4e7b26d816ec"), null, "Баллы за труды без грифа и без соавторства:", 10, new Guid("8785c8fe-4be9-44b8-bc18-322ac329e289") },
                    { new Guid("c0b9b880-2818-4fa7-beb7-8cc5aa21bf25"), null, "Баллы за профессиональное развитие:", 15, new Guid("f9784464-9672-447a-9b2c-799f2ed87539") },
                    { new Guid("ccd04047-9098-4307-8552-bfbaa59b8d4b"), null, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("b13e73c1-96c9-491e-92c5-17c2dc6db1e3") },
                    { new Guid("d95cc0e6-1d4a-4e75-94e5-025484f4afef"), null, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("c1dc8519-6ede-4a0f-91a8-83695a048a02") },
                    { new Guid("da4716fb-5100-4754-98ea-3d15d8ac9fe9"), null, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("2b1500d6-07d4-413a-a77a-5a869e3f1bf3") },
                    { new Guid("deb8665f-09dc-4629-9f3e-33e416f21fde"), new Guid("822ba81c-22c6-49f0-9899-7db98eb77a5a"), "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("e408f3aa-e319-4db4-9055-b001f5b14124"), null, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("585b3d0a-316e-4fbc-a431-b9d3716c5cbd") },
                    { new Guid("ed31daa8-dd1c-46c5-b51b-032f5db80abc"), null, "Баллы за количество разработок:", 24, new Guid("f8877ea3-11d3-44de-a4fd-0fd53a340233") },
                    { new Guid("f1e76658-8db1-4a46-bf3f-124e3b323262"), new Guid("d103df4a-f97d-4598-a531-3b23514bb98b"), "Баллы за количество защитившихся кандидатов наук:", 19, null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("2d34e4df-d41d-4e12-80a4-0a5e98155535"), new Guid("11e75a53-35a9-4621-8340-89ffe110842a") },
                    { new Guid("2d34e4df-d41d-4e12-80a4-0a5e98155535"), new Guid("4040e7c8-e77d-4de9-baa0-152971cc0e12") },
                    { new Guid("2d34e4df-d41d-4e12-80a4-0a5e98155535"), new Guid("43b81216-0a90-4a1e-a086-99a40554f861") },
                    { new Guid("2d34e4df-d41d-4e12-80a4-0a5e98155535"), new Guid("9f71b183-bb78-4463-a407-32d33c4b4a62") },
                    { new Guid("2d34e4df-d41d-4e12-80a4-0a5e98155535"), new Guid("b47fcc53-d007-438f-938b-4e7b26d816ec") },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), new Guid("038ad527-92ae-4093-ba74-82f1f831f1de") },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), new Guid("1d8767a7-fa10-42f5-9e3c-63168f2229e0") },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), new Guid("31e67ac8-504a-4421-bd53-adbeb1e76c85") },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), new Guid("578f49ae-4253-4dc5-ba03-2d0b41c2bacc") },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), new Guid("6fd814f2-f710-4060-b362-6a9c042eeb57") },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), new Guid("905ec597-0cda-40ef-99c1-5da6f98db254") },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), new Guid("d95cc0e6-1d4a-4e75-94e5-025484f4afef") },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), new Guid("deb8665f-09dc-4629-9f3e-33e416f21fde") },
                    { new Guid("985f0b55-0984-4873-bb8c-44f0dc83cc0f"), new Guid("f1e76658-8db1-4a46-bf3f-124e3b323262") },
                    { new Guid("995c21d6-b018-4ecf-bf78-a4dc2db42e78"), new Guid("038ad527-92ae-4093-ba74-82f1f831f1de") },
                    { new Guid("995c21d6-b018-4ecf-bf78-a4dc2db42e78"), new Guid("6fd814f2-f710-4060-b362-6a9c042eeb57") },
                    { new Guid("995c21d6-b018-4ecf-bf78-a4dc2db42e78"), new Guid("c0b9b880-2818-4fa7-beb7-8cc5aa21bf25") },
                    { new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81"), new Guid("381e8a50-58df-45db-afa5-774779a651eb") },
                    { new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81"), new Guid("4d7184a8-e42c-4bcd-a684-005def2257c9") },
                    { new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81"), new Guid("68f7eddd-3eb4-42df-a145-edbfdef698db") },
                    { new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81"), new Guid("7c1fcde7-2097-4ec0-bdcf-8f99ec2a34b6") },
                    { new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81"), new Guid("7e5dc082-5465-4abd-8a34-0a795fe0df92") },
                    { new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81"), new Guid("ccd04047-9098-4307-8552-bfbaa59b8d4b") },
                    { new Guid("e484505b-4f2c-499f-b393-8e6ca717fd81"), new Guid("e408f3aa-e319-4db4-9055-b001f5b14124") },
                    { new Guid("f3857d25-df47-4b75-a417-45e14cafe467"), new Guid("c0b9b880-2818-4fa7-beb7-8cc5aa21bf25") },
                    { new Guid("f3857d25-df47-4b75-a417-45e14cafe467"), new Guid("da4716fb-5100-4754-98ea-3d15d8ac9fe9") },
                    { new Guid("f3857d25-df47-4b75-a417-45e14cafe467"), new Guid("ed31daa8-dd1c-46c5-b51b-032f5db80abc") }
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
                name: "IX_Tables_EditBlockId",
                table: "Tables",
                column: "EditBlockId");

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
