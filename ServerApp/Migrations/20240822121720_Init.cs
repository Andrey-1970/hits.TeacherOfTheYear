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
                name: "BlockReviewStatus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    ReviewStatus = table.Column<bool>(type: "INTEGER", nullable: false),
                    Commentary = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    ApplicationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MarkBlockId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ReviewerId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockReviewStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlockReviewStatus_ApplicationForms_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "ApplicationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlockReviewStatus_MarkBlocks_MarkBlockId",
                        column: x => x.MarkBlockId,
                        principalTable: "MarkBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlockReviewStatus_UserInfos_ReviewerId",
                        column: x => x.ReviewerId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EditBlockStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    EditBlockId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditBlockStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EditBlockStatuses_ApplicationForms_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "ApplicationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditBlockStatuses_EditBlocks_EditBlockId",
                        column: x => x.EditBlockId,
                        principalTable: "EditBlocks",
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
                    { new Guid("1e55ba1b-0dcf-4f02-a532-f369c97a7404"), "Профессиональное развитие", 3 },
                    { new Guid("83161399-1997-4df8-bfe4-cd68d5ca8b8a"), "Деятельность", 5 },
                    { new Guid("971c515b-25ad-4d6f-b7d8-e7f1bc84a34c"), "Деятельность", 4 },
                    { new Guid("99a18210-4e6e-4863-9d78-e2c4ad968842"), "Общая информация", 1 },
                    { new Guid("fec83673-0cd0-44c7-9328-8060d6a67945"), "Категория участников", 2 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f"), "Образовательная деятельность", 2 },
                    { new Guid("469f5632-c849-4f97-ae58-c53733f05236"), "Конкурсная работа", 7 },
                    { new Guid("49f5f48b-c5bc-48fd-ae1a-03f7239dfbcd"), "Инновационная и иная деятельность", 6 },
                    { new Guid("8b8e178e-a913-4054-a26b-b675182b079d"), "Методическая деятельность", 3 },
                    { new Guid("a6d2c0ab-909d-4008-960e-5c0f1fa70347"), "Профессиональные показатели", 4 },
                    { new Guid("b4e80db1-9db3-4446-9774-71131750ba12"), "Итог", 8 },
                    { new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce"), "Основной", 1 },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), "Научно-исследовательская деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("3de89d62-bdf7-44aa-ac8c-772ec20a67ea"), null, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("d057343c-5abf-4b74-aab2-9ffbbfd83f45"), null, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("432c6f0a-bdcd-481f-b262-421ecf7f2b0c"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("c8b24990-fb90-413d-a59c-b6fcac76ce3a"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("a14e4c85-9ab9-4a3c-9df4-e52d815b966f"), "User 2", "user@mail.ru" },
                    { new Guid("dcd3cd6a-8e60-4b50-8081-62e593cd280f"), "User 1", "admin@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("10d3a7f2-1949-4f32-b671-c55ba77a8753"), "bool" },
                    { new Guid("5c069965-0971-47f4-834b-ef551d76e601"), "DateTime" },
                    { new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10"), "int" },
                    { new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8"), "string" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("1e55ba1b-0dcf-4f02-a532-f369c97a7404"), new Guid("432c6f0a-bdcd-481f-b262-421ecf7f2b0c") },
                    { new Guid("1e55ba1b-0dcf-4f02-a532-f369c97a7404"), new Guid("c8b24990-fb90-413d-a59c-b6fcac76ce3a") },
                    { new Guid("83161399-1997-4df8-bfe4-cd68d5ca8b8a"), new Guid("432c6f0a-bdcd-481f-b262-421ecf7f2b0c") },
                    { new Guid("971c515b-25ad-4d6f-b7d8-e7f1bc84a34c"), new Guid("c8b24990-fb90-413d-a59c-b6fcac76ce3a") },
                    { new Guid("99a18210-4e6e-4863-9d78-e2c4ad968842"), new Guid("432c6f0a-bdcd-481f-b262-421ecf7f2b0c") },
                    { new Guid("99a18210-4e6e-4863-9d78-e2c4ad968842"), new Guid("c8b24990-fb90-413d-a59c-b6fcac76ce3a") },
                    { new Guid("fec83673-0cd0-44c7-9328-8060d6a67945"), new Guid("432c6f0a-bdcd-481f-b262-421ecf7f2b0c") },
                    { new Guid("fec83673-0cd0-44c7-9328-8060d6a67945"), new Guid("c8b24990-fb90-413d-a59c-b6fcac76ce3a") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("027c4334-1c9e-4b77-ac57-54230190df62"), new Guid("99a18210-4e6e-4863-9d78-e2c4ad968842"), null, "Место работы/учебы", 6, "Название организации", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("05776e0b-86dd-4c86-848a-39d121292c50"), new Guid("971c515b-25ad-4d6f-b7d8-e7f1bc84a34c"), null, "Защитившиеся магистры", 23, "Введите количество", new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("0ee2cde7-8ee8-41de-a38b-790db60243b7"), new Guid("fec83673-0cd0-44c7-9328-8060d6a67945"), null, "Направление конкурса", 12, "Выберите направление конкурса", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("12680cdb-6baa-4f07-959e-45c06a3c1b43"), new Guid("fec83673-0cd0-44c7-9328-8060d6a67945"), null, "Научная специальность (по классификации ВАК)", 18, "Введите научную специальность (по классификации ВАК)", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("21883794-274e-44e8-8082-595ba1f2e878"), new Guid("971c515b-25ad-4d6f-b7d8-e7f1bc84a34c"), null, "Защитившиеся доктора наук", 20, "Введите количество", new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("2548b2e9-9926-456e-a3a2-e891afdd213e"), new Guid("99a18210-4e6e-4863-9d78-e2c4ad968842"), null, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("2d4dd3f7-053f-4de3-9e60-d1f0f4fdbd02"), new Guid("fec83673-0cd0-44c7-9328-8060d6a67945"), null, "Ученое звание", 16, "Выберите ученое звание", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("2f580712-3b7f-4c49-82bb-446eab11e85d"), new Guid("fec83673-0cd0-44c7-9328-8060d6a67945"), null, "Название конкурсной работы", 14, "Введите название своей конкурсной работы", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("41b57971-2130-409a-a983-dba25621fd2d"), new Guid("99a18210-4e6e-4863-9d78-e2c4ad968842"), null, "Электронная почта", 5, "user@example.com", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("4b37db7b-b52a-46e5-847f-a4fd6cb84f2a"), new Guid("99a18210-4e6e-4863-9d78-e2c4ad968842"), null, "Дата рождения", 2, "01.01.2000", new Guid("5c069965-0971-47f4-834b-ef551d76e601") },
                    { new Guid("55bc1415-1931-4765-ac8c-9fe3d9269269"), new Guid("83161399-1997-4df8-bfe4-cd68d5ca8b8a"), null, "Защитившиеся доктора наук", 25, "Введите количество", new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("6f663593-b00d-4147-943c-234e4e08c96c"), new Guid("99a18210-4e6e-4863-9d78-e2c4ad968842"), null, "Должность", 9, "Введите свою должность в организации", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("72a79f12-3af5-4d35-9b39-12ba288ddeeb"), new Guid("971c515b-25ad-4d6f-b7d8-e7f1bc84a34c"), "Руководство дипломными проектами за предыдущий учебный год", "Защитившиеся бакалавры", 21, "Введите количество", new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("7cd531e6-b532-48ea-885d-362a2a7a1346"), new Guid("fec83673-0cd0-44c7-9328-8060d6a67945"), null, "Ссылка на конкурсную работу", 15, "Введите ссылку своей конкурсной работы", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("8694b52c-31dd-4f5b-a513-811ddf1c5e4c"), new Guid("fec83673-0cd0-44c7-9328-8060d6a67945"), null, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 13, "Выберите категорию участника конкруса", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("966c636e-5322-46b1-9554-9442240ddb63"), new Guid("83161399-1997-4df8-bfe4-cd68d5ca8b8a"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", "Защитившиеся кандидаты наук", 24, "Введите количество", new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("99fa60be-2fd0-407c-8599-8fb0da749ae9"), new Guid("99a18210-4e6e-4863-9d78-e2c4ad968842"), null, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("9dc2897f-c48e-4867-997e-35a03d7140c1"), new Guid("971c515b-25ad-4d6f-b7d8-e7f1bc84a34c"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", "Защитившиеся кадидаты наук", 19, "Введите количество", new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("a4590bb4-bf66-4f1e-b2dd-baf74ec48544"), new Guid("99a18210-4e6e-4863-9d78-e2c4ad968842"), null, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("acde6fa0-0df2-4836-a46b-6cc48fdf97e8"), new Guid("99a18210-4e6e-4863-9d78-e2c4ad968842"), null, "ФИО", 1, "Иванов Иван Иванович", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("b7960abf-655d-438a-973d-23cd7ca6f633"), new Guid("99a18210-4e6e-4863-9d78-e2c4ad968842"), null, "Дополнительная информация", 11, "Пример", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("b7db4185-d168-4c19-90fd-f1a3c4fc9b04"), new Guid("fec83673-0cd0-44c7-9328-8060d6a67945"), null, "Ученая степень", 17, "Выберите ученую степень", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("bc2d1751-e37d-4175-8833-1bf1b5f3e4ea"), new Guid("971c515b-25ad-4d6f-b7d8-e7f1bc84a34c"), null, "Защитившиеся специалисты", 22, "Введите количество", new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("c25964fc-75ba-43f6-a6e0-9e1dc3ed12a4"), new Guid("99a18210-4e6e-4863-9d78-e2c4ad968842"), null, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("e85783ad-b55a-40fb-b175-609aec2201b8"), new Guid("99a18210-4e6e-4863-9d78-e2c4ad968842"), null, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f"), new Guid("c8b24990-fb90-413d-a59c-b6fcac76ce3a") },
                    { new Guid("469f5632-c849-4f97-ae58-c53733f05236"), new Guid("432c6f0a-bdcd-481f-b262-421ecf7f2b0c") },
                    { new Guid("469f5632-c849-4f97-ae58-c53733f05236"), new Guid("c8b24990-fb90-413d-a59c-b6fcac76ce3a") },
                    { new Guid("49f5f48b-c5bc-48fd-ae1a-03f7239dfbcd"), new Guid("432c6f0a-bdcd-481f-b262-421ecf7f2b0c") },
                    { new Guid("8b8e178e-a913-4054-a26b-b675182b079d"), new Guid("c8b24990-fb90-413d-a59c-b6fcac76ce3a") },
                    { new Guid("a6d2c0ab-909d-4008-960e-5c0f1fa70347"), new Guid("c8b24990-fb90-413d-a59c-b6fcac76ce3a") },
                    { new Guid("b4e80db1-9db3-4446-9774-71131750ba12"), new Guid("432c6f0a-bdcd-481f-b262-421ecf7f2b0c") },
                    { new Guid("b4e80db1-9db3-4446-9774-71131750ba12"), new Guid("c8b24990-fb90-413d-a59c-b6fcac76ce3a") },
                    { new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce"), new Guid("432c6f0a-bdcd-481f-b262-421ecf7f2b0c") },
                    { new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce"), new Guid("c8b24990-fb90-413d-a59c-b6fcac76ce3a") },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), new Guid("432c6f0a-bdcd-481f-b262-421ecf7f2b0c") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("49f5f48b-c5bc-48fd-ae1a-03f7239dfbcd"), new Guid("3de89d62-bdf7-44aa-ac8c-772ec20a67ea") },
                    { new Guid("49f5f48b-c5bc-48fd-ae1a-03f7239dfbcd"), new Guid("d057343c-5abf-4b74-aab2-9ffbbfd83f45") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("2face741-ac3d-4866-8a32-fcf8c5897dca"), new Guid("971c515b-25ad-4d6f-b7d8-e7f1bc84a34c"), "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 },
                    { new Guid("3c911560-0416-45e1-bb68-c928962e5233"), new Guid("83161399-1997-4df8-bfe4-cd68d5ca8b8a"), "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("47ef4c5e-50cb-4a4d-84b2-562856409ee7"), new Guid("971c515b-25ad-4d6f-b7d8-e7f1bc84a34c"), "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("5de8013b-e3f8-4679-989e-45994f59920c"), new Guid("83161399-1997-4df8-bfe4-cd68d5ca8b8a"), "Персональные идентификаторы и показатели", 10 },
                    { new Guid("6309600a-eb41-4741-87af-0b3c9ca86849"), new Guid("971c515b-25ad-4d6f-b7d8-e7f1bc84a34c"), "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("68a69f8e-4a1c-4025-aaee-98b9f9d4191b"), new Guid("1e55ba1b-0dcf-4f02-a532-f369c97a7404"), "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("7cfec383-f404-411f-bfbb-5d814362fe39"), new Guid("971c515b-25ad-4d6f-b7d8-e7f1bc84a34c"), "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("927c041c-1329-4f85-89f3-520d4282c2ad"), new Guid("83161399-1997-4df8-bfe4-cd68d5ca8b8a"), "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("b3680832-298c-498b-b7a7-88f667ab9e95"), new Guid("971c515b-25ad-4d6f-b7d8-e7f1bc84a34c"), "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("bbbc1091-405a-489a-b141-5a91137653fe"), new Guid("1e55ba1b-0dcf-4f02-a532-f369c97a7404"), "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("bc0ad19a-5e8f-4164-bcd1-21661b498819"), new Guid("83161399-1997-4df8-bfe4-cd68d5ca8b8a"), "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("bc51b00b-c3ba-4440-b180-5cdeed24c4e3"), new Guid("83161399-1997-4df8-bfe4-cd68d5ca8b8a"), "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("eebe339f-e89e-49bc-8bdf-645682993520"), new Guid("971c515b-25ad-4d6f-b7d8-e7f1bc84a34c"), "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0173f1b6-1a91-4885-853b-66e52f69ce03"), "Название организации/должность/ставка", 1, new Guid("47ef4c5e-50cb-4a4d-84b2-562856409ee7"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("0c71ea20-af89-48b0-b03e-b044168cd269"), "Год", 1, new Guid("68a69f8e-4a1c-4025-aaee-98b9f9d4191b"), new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("0dfa2b0c-58cd-4027-ad29-6a59a1564a10"), "ФИО соавторов", 3, new Guid("927c041c-1329-4f85-89f3-520d4282c2ad"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("17b79bee-cb3a-4d03-8b7d-d77d94315398"), "Год", 3, new Guid("7cfec383-f404-411f-bfbb-5d814362fe39"), new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("1fa10ea8-403e-4418-a488-2bd1ba635c66"), "Номер РИД", 4, new Guid("927c041c-1329-4f85-89f3-520d4282c2ad"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("2c584d87-98d0-4502-acc3-0da0b64d826c"), "Лекции (час.)", 3, new Guid("6309600a-eb41-4741-87af-0b3c9ca86849"), new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("2e51eb5b-2e50-4c8e-9016-1278533ac66c"), "Название организации в которую внедрена разработка", 3, new Guid("bc0ad19a-5e8f-4164-bcd1-21661b498819"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("31fbcbc3-cd82-426d-8a53-294561a6a6ac"), "Соавторы", 2, new Guid("bc51b00b-c3ba-4440-b180-5cdeed24c4e3"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("32d7ad17-070c-4ba5-b421-84400b194485"), "Статус (руководитель/исполнитель)", 4, new Guid("3c911560-0416-45e1-bb68-c928962e5233"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("3d47338e-3220-48da-a964-d9b9157bbf57"), "Название НИР/НИОКР", 1, new Guid("3c911560-0416-45e1-bb68-c928962e5233"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("3e4e1d84-4c3e-48f5-a8bc-85a6d2a9b796"), "Количество печатных листов", 4, new Guid("2face741-ac3d-4866-8a32-fcf8c5897dca"), new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("3ef60dbf-6f08-47e6-8d1f-57598f2182ac"), "Название", 2, new Guid("2face741-ac3d-4866-8a32-fcf8c5897dca"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("42e698f4-70a3-4c48-afe0-e84dd448a1eb"), "Количество публикаций в БАЗЕ", 3, new Guid("5de8013b-e3f8-4679-989e-45994f59920c"), new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("4639c3e6-af80-4106-a60e-f8186253bb1e"), "Период выполнения", 3, new Guid("3c911560-0416-45e1-bb68-c928962e5233"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("4cc80729-b7a8-4787-8c53-db68a9e123ba"), "Сумма финансирования (тыс. руб.)", 2, new Guid("3c911560-0416-45e1-bb68-c928962e5233"), new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("599a1d76-0713-4180-a897-f4309a559e03"), "Тип идентификатора", 1, new Guid("5de8013b-e3f8-4679-989e-45994f59920c"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("5eca2ca2-b37d-4c01-a3a2-18b6b4dd2b69"), "Ссылка на платформу", 3, new Guid("b3680832-298c-498b-b7a7-88f667ab9e95"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("645c4484-d10c-4cee-816e-0d9710cf6881"), "Количество часов", 4, new Guid("47ef4c5e-50cb-4a4d-84b2-562856409ee7"), new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("64d631fa-01c9-480a-bf09-df074b24d32f"), "Название", 2, new Guid("927c041c-1329-4f85-89f3-520d4282c2ad"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("675ec6d1-4e98-4e31-bf8d-78648a810096"), "Итого (час.)", 5, new Guid("6309600a-eb41-4741-87af-0b3c9ca86849"), new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("6c33129f-41ba-4cc2-8dd3-69d9e2eb25cb"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("7cfec383-f404-411f-bfbb-5d814362fe39"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("6dd0daf6-d1a6-430b-89cf-f255801779e9"), "Практические занятия (час.)", 4, new Guid("6309600a-eb41-4741-87af-0b3c9ca86849"), new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("707c5724-413e-4705-b44e-b42f68b8119f"), "Статус конкурса", 3, new Guid("68a69f8e-4a1c-4025-aaee-98b9f9d4191b"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("7fd8aa75-188d-406f-9f41-e4f6a96c1fb0"), "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("7cfec383-f404-411f-bfbb-5d814362fe39"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("803e9bbc-0d7b-4704-af38-856a3ee9fae9"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("3c911560-0416-45e1-bb68-c928962e5233"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("81a52eee-57e7-4349-bf83-5d0e396ee2fa"), "Название курса", 1, new Guid("b3680832-298c-498b-b7a7-88f667ab9e95"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("84ef4610-606a-4622-993a-6bae70b9b72c"), "Название статьи", 1, new Guid("bc51b00b-c3ba-4440-b180-5cdeed24c4e3"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("89cfb5b5-d492-448b-b4ea-3b5a4cc5b4d0"), "Название документа, реквизиты", 1, new Guid("bbbc1091-405a-489a-b141-5a91137653fe"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("89e9e4b1-a42a-4d62-8a86-f8c6ab2afe02"), "Индекс Хирша (за все время)", 5, new Guid("5de8013b-e3f8-4679-989e-45994f59920c"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("8fbf882a-1b9b-4610-9543-bc0b2a6a041c"), "Вид (лекции, лабораторные)", 2, new Guid("eebe339f-e89e-49bc-8bdf-645682993520"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("947ae2bb-1899-4daf-959d-257f54c40d42"), "Вид деятельности (преподавательская)", 3, new Guid("47ef4c5e-50cb-4a4d-84b2-562856409ee7"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("95dd9cbe-bdb4-4dc4-a1ea-21670d03202e"), "Ссылка", 5, new Guid("68a69f8e-4a1c-4025-aaee-98b9f9d4191b"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("99b50c8e-9aab-465f-8a77-6571604578a2"), "Количество цитирований", 4, new Guid("5de8013b-e3f8-4679-989e-45994f59920c"), new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("9cc90b5b-04da-4c35-940c-125e8ec2381f"), "Вид", 1, new Guid("bc0ad19a-5e8f-4164-bcd1-21661b498819"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("9e45ea33-08e0-4cf8-8459-cb165be5065a"), "Идентификатор", 2, new Guid("5de8013b-e3f8-4679-989e-45994f59920c"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("9eaebfde-956b-4c25-a616-77623d6ed567"), "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("bc51b00b-c3ba-4440-b180-5cdeed24c4e3"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("a23102f3-f186-4f83-a74f-3285b221144c"), "Название конкурса", 2, new Guid("68a69f8e-4a1c-4025-aaee-98b9f9d4191b"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("a4c0ed80-5de4-4544-8e8a-524319aa754b"), "Вид публикации", 1, new Guid("2face741-ac3d-4866-8a32-fcf8c5897dca"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("a6bbcd7a-3b54-4881-995d-59d084dc3490"), "Соавторы", 2, new Guid("b3680832-298c-498b-b7a7-88f667ab9e95"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("b098b84d-98a9-4fec-b0d5-1a3c8bd4b5d1"), "Издательство, год", 6, new Guid("2face741-ac3d-4866-8a32-fcf8c5897dca"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("b7330e0a-bc62-49e5-ae7f-0bf0aed7e743"), "Год получения документа", 2, new Guid("bbbc1091-405a-489a-b141-5a91137653fe"), new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("b76d9003-3e94-4221-be93-e92b6d276b4f"), "ФИО", 1, new Guid("7cfec383-f404-411f-bfbb-5d814362fe39"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("b9cd68bf-fb48-4765-9510-b5640bffefe6"), "Соавторы", 3, new Guid("2face741-ac3d-4866-8a32-fcf8c5897dca"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("bc3e1850-0265-49eb-ac5f-9d084171acb5"), "Наличие грифа", 5, new Guid("2face741-ac3d-4866-8a32-fcf8c5897dca"), new Guid("10d3a7f2-1949-4f32-b671-c55ba77a8753") },
                    { new Guid("c28f3fc0-975f-4f52-93ac-f932aa4ec782"), "Название дисциплины", 1, new Guid("eebe339f-e89e-49bc-8bdf-645682993520"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("c9ae0279-9f05-4167-9de1-518164a7b3a3"), "Год", 4, new Guid("b3680832-298c-498b-b7a7-88f667ab9e95"), new Guid("5fc472c7-2f3b-4ed5-a94a-0fff0f5b3f10") },
                    { new Guid("cb2836a3-f800-495e-89a1-440731ff9068"), "Награда", 4, new Guid("68a69f8e-4a1c-4025-aaee-98b9f9d4191b"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("cb8ca501-15af-404e-86c9-4fa1b2c6db5a"), "Вид", 1, new Guid("927c041c-1329-4f85-89f3-520d4282c2ad"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("cd837ea8-86d6-4c53-830c-30fad639e597"), "Издание, год", 4, new Guid("bc51b00b-c3ba-4440-b180-5cdeed24c4e3"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("da86355d-1bb7-4663-b556-5f06e1e717de"), "Наименование курса", 1, new Guid("6309600a-eb41-4741-87af-0b3c9ca86849"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("dd8d420c-2cc0-421c-928c-c6720e43bab4"), "Название конкурса/премии", 2, new Guid("7cfec383-f404-411f-bfbb-5d814362fe39"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("e15e33b0-501d-4cd5-ac6f-cd7fa17e1d5a"), "Язык преподавания (русск./англ./др.)", 2, new Guid("6309600a-eb41-4741-87af-0b3c9ca86849"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("f79c8273-2386-4016-8ec0-d690e4d9b5dc"), "Название разработки", 2, new Guid("bc0ad19a-5e8f-4164-bcd1-21661b498819"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") },
                    { new Guid("fb482171-711b-42a8-aaa6-85a5ce4c2503"), "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("47ef4c5e-50cb-4a4d-84b2-562856409ee7"), new Guid("748e60e5-3731-453e-9bd7-7f96852a34d8") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("027c4334-1c9e-4b77-ac57-54230190df62"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("05776e0b-86dd-4c86-848a-39d121292c50"), new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f") },
                    { new Guid("0ee2cde7-8ee8-41de-a38b-790db60243b7"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("12680cdb-6baa-4f07-959e-45c06a3c1b43"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("21883794-274e-44e8-8082-595ba1f2e878"), new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f") },
                    { new Guid("2548b2e9-9926-456e-a3a2-e891afdd213e"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("2d4dd3f7-053f-4de3-9e60-d1f0f4fdbd02"), new Guid("a6d2c0ab-909d-4008-960e-5c0f1fa70347") },
                    { new Guid("2d4dd3f7-053f-4de3-9e60-d1f0f4fdbd02"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("2d4dd3f7-053f-4de3-9e60-d1f0f4fdbd02"), new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce") },
                    { new Guid("2f580712-3b7f-4c49-82bb-446eab11e85d"), new Guid("469f5632-c849-4f97-ae58-c53733f05236") },
                    { new Guid("41b57971-2130-409a-a983-dba25621fd2d"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("4b37db7b-b52a-46e5-847f-a4fd6cb84f2a"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("55bc1415-1931-4765-ac8c-9fe3d9269269"), new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce") },
                    { new Guid("6f663593-b00d-4147-943c-234e4e08c96c"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("72a79f12-3af5-4d35-9b39-12ba288ddeeb"), new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f") },
                    { new Guid("7cd531e6-b532-48ea-885d-362a2a7a1346"), new Guid("469f5632-c849-4f97-ae58-c53733f05236") },
                    { new Guid("8694b52c-31dd-4f5b-a513-811ddf1c5e4c"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("966c636e-5322-46b1-9554-9442240ddb63"), new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce") },
                    { new Guid("99fa60be-2fd0-407c-8599-8fb0da749ae9"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("9dc2897f-c48e-4867-997e-35a03d7140c1"), new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f") },
                    { new Guid("a4590bb4-bf66-4f1e-b2dd-baf74ec48544"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("acde6fa0-0df2-4836-a46b-6cc48fdf97e8"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("b7960abf-655d-438a-973d-23cd7ca6f633"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("b7db4185-d168-4c19-90fd-f1a3c4fc9b04"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("bc2d1751-e37d-4175-8833-1bf1b5f3e4ea"), new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f") },
                    { new Guid("c25964fc-75ba-43f6-a6e0-9e1dc3ed12a4"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") },
                    { new Guid("e85783ad-b55a-40fb-b175-609aec2201b8"), new Guid("c7781518-c04e-4034-a3d5-5bc44f2000ce") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f"), new Guid("47ef4c5e-50cb-4a4d-84b2-562856409ee7") },
                    { new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f"), new Guid("6309600a-eb41-4741-87af-0b3c9ca86849") },
                    { new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f"), new Guid("7cfec383-f404-411f-bfbb-5d814362fe39") },
                    { new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f"), new Guid("b3680832-298c-498b-b7a7-88f667ab9e95") },
                    { new Guid("49f5f48b-c5bc-48fd-ae1a-03f7239dfbcd"), new Guid("927c041c-1329-4f85-89f3-520d4282c2ad") },
                    { new Guid("49f5f48b-c5bc-48fd-ae1a-03f7239dfbcd"), new Guid("bbbc1091-405a-489a-b141-5a91137653fe") },
                    { new Guid("49f5f48b-c5bc-48fd-ae1a-03f7239dfbcd"), new Guid("bc0ad19a-5e8f-4164-bcd1-21661b498819") },
                    { new Guid("8b8e178e-a913-4054-a26b-b675182b079d"), new Guid("2face741-ac3d-4866-8a32-fcf8c5897dca") },
                    { new Guid("8b8e178e-a913-4054-a26b-b675182b079d"), new Guid("eebe339f-e89e-49bc-8bdf-645682993520") },
                    { new Guid("a6d2c0ab-909d-4008-960e-5c0f1fa70347"), new Guid("68a69f8e-4a1c-4025-aaee-98b9f9d4191b") },
                    { new Guid("a6d2c0ab-909d-4008-960e-5c0f1fa70347"), new Guid("bbbc1091-405a-489a-b141-5a91137653fe") },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), new Guid("3c911560-0416-45e1-bb68-c928962e5233") },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), new Guid("5de8013b-e3f8-4679-989e-45994f59920c") },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), new Guid("68a69f8e-4a1c-4025-aaee-98b9f9d4191b") },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), new Guid("bc51b00b-c3ba-4440-b180-5cdeed24c4e3") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("15b473e4-48a6-44f9-bb85-1fced92a7a00"), null, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("927c041c-1329-4f85-89f3-520d4282c2ad") },
                    { new Guid("2b9ed696-3e5e-4b88-81dc-6504e3f7347f"), null, "Баллы за профессиональное развитие:", 15, new Guid("bbbc1091-405a-489a-b141-5a91137653fe") },
                    { new Guid("3953d8f2-c321-4446-863b-7e186f0715c8"), null, "Баллы за труды без грифа и без соавторства:", 10, new Guid("2face741-ac3d-4866-8a32-fcf8c5897dca") },
                    { new Guid("52684c23-b6bd-4308-a043-4e3f6d5d40b8"), null, "Баллы за объем учебной нагрузки:", 1, new Guid("6309600a-eb41-4741-87af-0b3c9ca86849") },
                    { new Guid("5825354a-129b-4a60-93aa-7f3b09508f51"), null, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("7cfec383-f404-411f-bfbb-5d814362fe39") },
                    { new Guid("5a8f575d-49f2-4b8d-aa40-4aa75d9ac39e"), new Guid("2d4dd3f7-053f-4de3-9e60-d1f0f4fdbd02"), "Баллы за ученое звание:", 13, null },
                    { new Guid("69a9b553-ce47-483a-8ee5-2848e2bb16f8"), null, "Баллы за научные публикации:", 16, new Guid("bc51b00b-c3ba-4440-b180-5cdeed24c4e3") },
                    { new Guid("6b8a6709-91a0-40e8-8f83-dac7316cc715"), null, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("b3680832-298c-498b-b7a7-88f667ab9e95") },
                    { new Guid("6ce7aecd-d96f-4262-b5db-646007eb1d30"), null, "Баллы за награды:", 14, new Guid("68a69f8e-4a1c-4025-aaee-98b9f9d4191b") },
                    { new Guid("7a30a046-b25f-49ff-88a7-eb60aefd57b7"), null, "Баллы за труды с грифом и без соавторства:", 8, new Guid("2face741-ac3d-4866-8a32-fcf8c5897dca") },
                    { new Guid("80e6fe47-3ece-4b4c-978f-b58206427183"), null, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("6309600a-eb41-4741-87af-0b3c9ca86849") },
                    { new Guid("833d4c65-7fa1-4091-8c11-a66a1814ccf6"), null, "Баллы за труды без грифа в соавторстве:", 11, new Guid("2face741-ac3d-4866-8a32-fcf8c5897dca") },
                    { new Guid("88a1dead-9a06-4051-b1be-b132d0d50691"), new Guid("21883794-274e-44e8-8082-595ba1f2e878"), "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("8d105131-0112-4dea-8521-a597eda968e0"), new Guid("05776e0b-86dd-4c86-848a-39d121292c50"), "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("92322e8f-34fd-4a09-b99e-09228ace26e3"), null, "Баллы за количество разработок:", 24, new Guid("bc0ad19a-5e8f-4164-bcd1-21661b498819") },
                    { new Guid("9c2a47d1-73ad-4c08-bfc8-02272d0e1169"), null, "Баллы по базе РИНЦ:", 18, new Guid("5de8013b-e3f8-4679-989e-45994f59920c") },
                    { new Guid("9f2f4a41-bf9a-444b-8505-e56872671620"), null, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("3c911560-0416-45e1-bb68-c928962e5233") },
                    { new Guid("b9e2e4ae-85df-488b-99a0-fa17e8369e13"), null, "Баллы за труды с грифом в соавторстве:", 9, new Guid("2face741-ac3d-4866-8a32-fcf8c5897dca") },
                    { new Guid("cab92c0e-51d7-4feb-855f-2eb4ad218771"), new Guid("966c636e-5322-46b1-9554-9442240ddb63"), "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("e558a693-74a4-403a-87d5-ecc0c8604c5b"), new Guid("9dc2897f-c48e-4867-997e-35a03d7140c1"), "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("e720d85f-9f0b-449f-87d8-2b6960e122f0"), null, "Баллы по базе Scopus:", 17, new Guid("5de8013b-e3f8-4679-989e-45994f59920c") },
                    { new Guid("e94793df-ae93-41c2-9a60-ebdd6ec8eddb"), null, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("eebe339f-e89e-49bc-8bdf-645682993520") },
                    { new Guid("ec9760c6-a8b3-47d1-91d9-b0ca3bd1be77"), null, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("3c911560-0416-45e1-bb68-c928962e5233") },
                    { new Guid("f5f609a3-e857-4ff9-822a-e773c41f28e2"), new Guid("55bc1415-1931-4765-ac8c-9fe3d9269269"), "Баллы за количество защитившихся докторов наук:", 20, null }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("019bded7-5060-4727-8a1b-2dc7e31abc49"), null, new Guid("2d4dd3f7-053f-4de3-9e60-d1f0f4fdbd02"), "Нет" },
                    { new Guid("0352ba02-b1e8-4fdd-9aaf-0b32a108729c"), null, new Guid("0ee2cde7-8ee8-41de-a38b-790db60243b7"), "ПРИКЛАДНАЯ ГЕОЛОГИЯ, ГОРНОЕ ДЕЛО, НЕФТЕГАЗОВОЕ ДЕЛО И ГЕОДЕЗИЯ" },
                    { new Guid("2a81d72a-b342-46e7-8340-b61b942ae4eb"), null, new Guid("2d4dd3f7-053f-4de3-9e60-d1f0f4fdbd02"), "Профессор" },
                    { new Guid("5b265009-590d-4687-8935-edd7883ec1af"), null, new Guid("0ee2cde7-8ee8-41de-a38b-790db60243b7"), "АРХИТЕКТУРА" },
                    { new Guid("5c724b10-8fc2-4173-96bb-2bb9ba973fe2"), null, new Guid("2d4dd3f7-053f-4de3-9e60-d1f0f4fdbd02"), "Доцент" },
                    { new Guid("60812a0d-d376-4533-8194-b33aca0b62f7"), null, new Guid("0ee2cde7-8ee8-41de-a38b-790db60243b7"), "СТРОИТЕЛЬСТВО И АРХИТЕКТУРА" },
                    { new Guid("63ee8062-ab0a-402e-806b-7a31455db2f1"), null, new Guid("8694b52c-31dd-4f5b-a513-811ddf1c5e4c"), "Имеющие ученую степень доктора наук" },
                    { new Guid("6b2d31bd-be4c-44e5-90cd-3db963d984eb"), null, new Guid("8694b52c-31dd-4f5b-a513-811ddf1c5e4c"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("9e49f764-2e15-401e-8db9-f2ddc9c291e3"), null, new Guid("0ee2cde7-8ee8-41de-a38b-790db60243b7"), "ЭЛЕКТРО- И ТЕПЛОЭНЕРГЕТИКА" },
                    { new Guid("b2ab1344-c1e3-4a50-a07a-e488390138d2"), null, new Guid("0ee2cde7-8ee8-41de-a38b-790db60243b7"), "ТЕХНИКА И ТЕХНОЛОГИИ СТРОИТЕЛЬСТВА" },
                    { new Guid("e4fd9be5-e5a2-4e50-a672-f491e303d05c"), null, new Guid("8694b52c-31dd-4f5b-a513-811ddf1c5e4c"), "Аспиранты, адъюнкты, ординаторы, ассистенты-стажеры, не имеющие ученой степени" },
                    { new Guid("fe1ded5d-a97f-44b0-8875-d115391acbf4"), null, new Guid("0ee2cde7-8ee8-41de-a38b-790db60243b7"), "НЕДРОПОЛЬЗОВАНИЕ И ГОРНЫЕ НАУКИ" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f"), new Guid("52684c23-b6bd-4308-a043-4e3f6d5d40b8") },
                    { new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f"), new Guid("5825354a-129b-4a60-93aa-7f3b09508f51") },
                    { new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f"), new Guid("6b8a6709-91a0-40e8-8f83-dac7316cc715") },
                    { new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f"), new Guid("80e6fe47-3ece-4b4c-978f-b58206427183") },
                    { new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f"), new Guid("88a1dead-9a06-4051-b1be-b132d0d50691") },
                    { new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f"), new Guid("8d105131-0112-4dea-8521-a597eda968e0") },
                    { new Guid("163a5029-9ef6-4dc9-8def-d712064ea12f"), new Guid("e558a693-74a4-403a-87d5-ecc0c8604c5b") },
                    { new Guid("49f5f48b-c5bc-48fd-ae1a-03f7239dfbcd"), new Guid("15b473e4-48a6-44f9-bb85-1fced92a7a00") },
                    { new Guid("49f5f48b-c5bc-48fd-ae1a-03f7239dfbcd"), new Guid("2b9ed696-3e5e-4b88-81dc-6504e3f7347f") },
                    { new Guid("49f5f48b-c5bc-48fd-ae1a-03f7239dfbcd"), new Guid("92322e8f-34fd-4a09-b99e-09228ace26e3") },
                    { new Guid("8b8e178e-a913-4054-a26b-b675182b079d"), new Guid("3953d8f2-c321-4446-863b-7e186f0715c8") },
                    { new Guid("8b8e178e-a913-4054-a26b-b675182b079d"), new Guid("7a30a046-b25f-49ff-88a7-eb60aefd57b7") },
                    { new Guid("8b8e178e-a913-4054-a26b-b675182b079d"), new Guid("833d4c65-7fa1-4091-8c11-a66a1814ccf6") },
                    { new Guid("8b8e178e-a913-4054-a26b-b675182b079d"), new Guid("b9e2e4ae-85df-488b-99a0-fa17e8369e13") },
                    { new Guid("8b8e178e-a913-4054-a26b-b675182b079d"), new Guid("e94793df-ae93-41c2-9a60-ebdd6ec8eddb") },
                    { new Guid("a6d2c0ab-909d-4008-960e-5c0f1fa70347"), new Guid("2b9ed696-3e5e-4b88-81dc-6504e3f7347f") },
                    { new Guid("a6d2c0ab-909d-4008-960e-5c0f1fa70347"), new Guid("5a8f575d-49f2-4b8d-aa40-4aa75d9ac39e") },
                    { new Guid("a6d2c0ab-909d-4008-960e-5c0f1fa70347"), new Guid("6ce7aecd-d96f-4262-b5db-646007eb1d30") },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), new Guid("5a8f575d-49f2-4b8d-aa40-4aa75d9ac39e") },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), new Guid("69a9b553-ce47-483a-8ee5-2848e2bb16f8") },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), new Guid("6ce7aecd-d96f-4262-b5db-646007eb1d30") },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), new Guid("9c2a47d1-73ad-4c08-bfc8-02272d0e1169") },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), new Guid("9f2f4a41-bf9a-444b-8505-e56872671620") },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), new Guid("cab92c0e-51d7-4feb-855f-2eb4ad218771") },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), new Guid("e720d85f-9f0b-449f-87d8-2b6960e122f0") },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), new Guid("ec9760c6-a8b3-47d1-91d9-b0ca3bd1be77") },
                    { new Guid("f4e9cdfe-1b1a-4604-b9ef-50619051dbce"), new Guid("f5f609a3-e857-4ff9-822a-e773c41f28e2") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("1508b4d8-08f9-4fc5-90d8-3be1e267721a"), new Guid("707c5724-413e-4705-b44e-b42f68b8119f"), null, "Региональный" },
                    { new Guid("1dc0e87e-bbfa-46fa-b90e-5ed5b67e4b87"), new Guid("a4c0ed80-5de4-4544-8e8a-524319aa754b"), null, "Монография" },
                    { new Guid("264e0fda-130e-4976-8ca3-507ab88dfc0c"), new Guid("cb8ca501-15af-404e-86c9-4fa1b2c6db5a"), null, "Изобретение" },
                    { new Guid("30af88c5-d426-496f-89e2-390074d3c161"), new Guid("cb8ca501-15af-404e-86c9-4fa1b2c6db5a"), null, "База данных" },
                    { new Guid("48becfcb-16c0-444e-96a3-7025f34d8f53"), new Guid("8fbf882a-1b9b-4610-9543-bc0b2a6a041c"), null, "Лабораторные" },
                    { new Guid("65a928ce-49b4-447f-b984-efdfb19189c1"), new Guid("cb8ca501-15af-404e-86c9-4fa1b2c6db5a"), null, "Полезная модель" },
                    { new Guid("672923a0-0ad7-4e0b-b861-966aa3a55d1b"), new Guid("8fbf882a-1b9b-4610-9543-bc0b2a6a041c"), null, "Лекции" },
                    { new Guid("6f45ba6d-a1c8-41eb-adfe-3e2883b38fe5"), new Guid("a4c0ed80-5de4-4544-8e8a-524319aa754b"), null, "Учебник" },
                    { new Guid("841977c8-bc1c-450e-909b-bfceffd99149"), new Guid("707c5724-413e-4705-b44e-b42f68b8119f"), null, "Международный" },
                    { new Guid("88a8e0bc-bf84-41da-9f86-0a7d2a7b5068"), new Guid("9cc90b5b-04da-4c35-940c-125e8ec2381f"), null, "Изобретение" },
                    { new Guid("892cd223-cc92-4c9d-aedf-72ae59f5f7ac"), new Guid("32d7ad17-070c-4ba5-b421-84400b194485"), null, "Исполнитель" },
                    { new Guid("97404de6-3e39-4762-8742-abaa68408d6f"), new Guid("a4c0ed80-5de4-4544-8e8a-524319aa754b"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("991e056b-fb98-4670-9347-f93f820193e9"), new Guid("9cc90b5b-04da-4c35-940c-125e8ec2381f"), null, "База данных" },
                    { new Guid("be94882d-9a50-4a7a-8e6a-4e8d42091d23"), new Guid("707c5724-413e-4705-b44e-b42f68b8119f"), null, "Всероссийский" },
                    { new Guid("e67fcb70-ec96-48b2-8352-a3eac33a4b2d"), new Guid("9cc90b5b-04da-4c35-940c-125e8ec2381f"), null, "Полезная модель" },
                    { new Guid("f5d10a56-2bcd-4a73-a68f-092177dcf0d1"), new Guid("32d7ad17-070c-4ba5-b421-84400b194485"), null, "Руководитель" }
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
                name: "IX_BlockReviewStatus_ApplicationId",
                table: "BlockReviewStatus",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockReviewStatus_MarkBlockId",
                table: "BlockReviewStatus",
                column: "MarkBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockReviewStatus_ReviewerId",
                table: "BlockReviewStatus",
                column: "ReviewerId");

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
                name: "IX_EditBlockStatuses_ApplicationId",
                table: "EditBlockStatuses",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_EditBlockStatuses_EditBlockId",
                table: "EditBlockStatuses",
                column: "EditBlockId");

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
                name: "BlockReviewStatus");

            migrationBuilder.DropTable(
                name: "CellVals");

            migrationBuilder.DropTable(
                name: "EditBlockStatuses");

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
