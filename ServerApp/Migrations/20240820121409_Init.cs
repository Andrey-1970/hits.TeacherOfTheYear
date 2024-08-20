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
