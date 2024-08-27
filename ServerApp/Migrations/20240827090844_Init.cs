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
                name: "ApplicationStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationStatuses", x => x.Id);
                });

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
                    IsPrefilled = table.Column<bool>(type: "INTEGER", nullable: false),
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
                    ApplicationStatusId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserInfoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TrackId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ReviewerId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationForms_ApplicationStatuses_ApplicationStatusId",
                        column: x => x.ApplicationStatusId,
                        principalTable: "ApplicationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationForms_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationForms_UserInfos_ReviewerId",
                        column: x => x.ReviewerId,
                        principalTable: "UserInfos",
                        principalColumn: "Id");
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
                    Required = table.Column<bool>(type: "INTEGER", nullable: false),
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
                    IsPrefilled = table.Column<bool>(type: "INTEGER", nullable: false),
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
                name: "BlockReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false),
                    Commentary = table.Column<string>(type: "TEXT", maxLength: 2048, nullable: true),
                    MarkBlockId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlockReviews_ApplicationForms_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "ApplicationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlockReviews_MarkBlocks_MarkBlockId",
                        column: x => x.MarkBlockId,
                        principalTable: "MarkBlocks",
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
                    IsAuto = table.Column<bool>(type: "INTEGER", nullable: false),
                    MaxValue = table.Column<int>(type: "INTEGER", nullable: false),
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
                    IsPrefilled = table.Column<bool>(type: "INTEGER", nullable: false),
                    Disable = table.Column<bool>(type: "INTEGER", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "TEXT", nullable: true),
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
                        principalColumn: "Id");
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
                table: "ApplicationStatuses",
                columns: new[] { "Id", "Number", "Status" },
                values: new object[,]
                {
                    { new Guid("50b2ef8b-3728-4fe1-b020-1a72cf492316"), 3, "В процессе оценки" },
                    { new Guid("62affb94-6c91-4b70-8fdb-3cf411f9c0ef"), 2, "В ожидании оценки" },
                    { new Guid("854ad383-bd5f-4038-a782-82325df486e4"), 1, "В ожидании заполнения" },
                    { new Guid("e03b34d1-3a04-42bb-8283-40469e6f79c3"), 4, "Одобрена" },
                    { new Guid("e6259677-42bb-4bb8-aa5a-84351c67a9e8"), 5, "Отклонена" }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0095665a-ba49-4d2a-a10b-e00c665c2ce4"), "Деятельность", 4 },
                    { new Guid("5e66d320-b43e-48e1-87ab-31cae394d372"), "Общая информация", 1 },
                    { new Guid("6e4cf998-f78b-44c8-af41-5a483fd43c58"), "Деятельность", 5 },
                    { new Guid("74eb00d5-1d0d-4e6f-8e72-b0f0837d3f1f"), "Категория участников", 2 },
                    { new Guid("c90287a2-c0db-421c-b4a7-54b4f0ddac87"), "Профессиональное развитие", 3 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("28738105-a8b0-424f-a769-212708c93b34"), "Образовательная деятельность", 2 },
                    { new Guid("45a4ce7a-cfdd-41c1-890b-9763e91a71c8"), "Методическая деятельность", 3 },
                    { new Guid("6f60dbec-fc8d-4ae3-8db7-669f5e559b84"), "Конкурсная работа", 7 },
                    { new Guid("92de5e8d-b107-4053-a25b-f7827f15a274"), "Профессиональные показатели", 4 },
                    { new Guid("c3d2e270-ed84-42ce-9c67-268f5239151f"), "Инновационная и иная деятельность", 6 },
                    { new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e"), "Основной", 1 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("5b13e4ad-ec5d-4b0c-a5bb-aed8d4192b8f"), null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null },
                    { new Guid("eacac388-49bb-4f6e-95cc-3b2877f99d1e"), null, false, 10, "Оценка уровня предоставленной работы:", 25, null }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("2e08cabf-740f-4722-8e3f-af2e2d52394a"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("bbeb1cb4-353c-4b75-8598-ac3054d2de84"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("2a4ed966-4725-4dcd-a838-1f938b920e7a"), "User 2", "user@mail.ru" },
                    { new Guid("8679c8c8-300c-4735-80a4-70ab888a746c"), "User 1", "admin@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0a082c69-7567-45cf-b95d-21a49bba091a"), "bool" },
                    { new Guid("1731457d-afaf-4cc9-adf6-bbdfb13acee3"), "DateTime" },
                    { new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4"), "string" },
                    { new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994"), "int" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0095665a-ba49-4d2a-a10b-e00c665c2ce4"), new Guid("bbeb1cb4-353c-4b75-8598-ac3054d2de84") },
                    { new Guid("5e66d320-b43e-48e1-87ab-31cae394d372"), new Guid("2e08cabf-740f-4722-8e3f-af2e2d52394a") },
                    { new Guid("5e66d320-b43e-48e1-87ab-31cae394d372"), new Guid("bbeb1cb4-353c-4b75-8598-ac3054d2de84") },
                    { new Guid("6e4cf998-f78b-44c8-af41-5a483fd43c58"), new Guid("2e08cabf-740f-4722-8e3f-af2e2d52394a") },
                    { new Guid("74eb00d5-1d0d-4e6f-8e72-b0f0837d3f1f"), new Guid("2e08cabf-740f-4722-8e3f-af2e2d52394a") },
                    { new Guid("74eb00d5-1d0d-4e6f-8e72-b0f0837d3f1f"), new Guid("bbeb1cb4-353c-4b75-8598-ac3054d2de84") },
                    { new Guid("c90287a2-c0db-421c-b4a7-54b4f0ddac87"), new Guid("2e08cabf-740f-4722-8e3f-af2e2d52394a") },
                    { new Guid("c90287a2-c0db-421c-b4a7-54b4f0ddac87"), new Guid("bbeb1cb4-353c-4b75-8598-ac3054d2de84") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "Name", "Number", "Placeholder", "Required", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("028ea5ba-49a9-47a2-bf9f-e1968fe9abe2"), new Guid("74eb00d5-1d0d-4e6f-8e72-b0f0837d3f1f"), null, "Научная специальность (по классификации ВАК)", 18, "Введите научную специальность (по классификации ВАК)", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("02b91a72-fe64-433b-8d83-7ff480e24db5"), new Guid("0095665a-ba49-4d2a-a10b-e00c665c2ce4"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", "Защитившиеся кадидаты наук", 19, "Введите количество", true, new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("269fe0ba-8f0a-471c-8a22-1596cda13a83"), new Guid("74eb00d5-1d0d-4e6f-8e72-b0f0837d3f1f"), null, "Ссылка на конкурсную работу", 15, "Введите ссылку своей конкурсной работы", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("2b9c4f97-40ee-4aee-9459-09082858aa56"), new Guid("5e66d320-b43e-48e1-87ab-31cae394d372"), null, "Дата рождения", 2, "01.01.2000", true, new Guid("1731457d-afaf-4cc9-adf6-bbdfb13acee3") },
                    { new Guid("2c12554f-83b8-44a0-a63d-2ac23de401d5"), new Guid("0095665a-ba49-4d2a-a10b-e00c665c2ce4"), null, "Защитившиеся доктора наук", 20, "Введите количество", true, new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("486fe20a-80d5-41ae-a08a-f1e2d84a5db5"), new Guid("5e66d320-b43e-48e1-87ab-31cae394d372"), null, "Место работы/учебы", 6, "Название организации", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("4f7398bf-2cb9-43dd-9f10-dacaeb122fbe"), new Guid("5e66d320-b43e-48e1-87ab-31cae394d372"), null, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("59f17939-dbf1-4650-8a1a-d6eea67f494f"), new Guid("5e66d320-b43e-48e1-87ab-31cae394d372"), null, "ФИО", 1, "Иванов Иван Иванович", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("5abbc9bd-a7bf-4f18-9e67-76ce93283798"), new Guid("74eb00d5-1d0d-4e6f-8e72-b0f0837d3f1f"), null, "Название конкурсной работы", 14, "Введите название своей конкурсной работы", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("5b2140db-d0a7-47a5-bc3c-412cc2e52528"), new Guid("5e66d320-b43e-48e1-87ab-31cae394d372"), null, "Электронная почта", 5, "user@example.com", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("5d472461-2200-4d2a-82c4-8801fd878835"), new Guid("5e66d320-b43e-48e1-87ab-31cae394d372"), null, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", true, new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("61c76373-3d5e-4e13-bd40-3898961b64e9"), new Guid("0095665a-ba49-4d2a-a10b-e00c665c2ce4"), "Руководство дипломными проектами за предыдущий учебный год", "Защитившиеся бакалавры", 21, "Введите количество", true, new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("643f6133-3970-40ba-a3d1-9f3f11fb1973"), new Guid("0095665a-ba49-4d2a-a10b-e00c665c2ce4"), null, "Защитившиеся магистры", 23, "Введите количество", true, new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("6d8d378a-005c-445c-934c-d0e9cc08faab"), new Guid("74eb00d5-1d0d-4e6f-8e72-b0f0837d3f1f"), null, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 13, "Выберите категорию участника конкруса", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("740d3b1e-5dad-4264-9d24-2cac4161b49a"), new Guid("6e4cf998-f78b-44c8-af41-5a483fd43c58"), null, "Защитившиеся доктора наук", 25, "Введите количество", true, new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("88a5d3d7-b0b8-4845-b663-33622f19a82e"), new Guid("5e66d320-b43e-48e1-87ab-31cae394d372"), null, "Должность", 9, "Введите свою должность в организации", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("927ffbd5-710f-4532-b772-44db6aca2fc6"), new Guid("74eb00d5-1d0d-4e6f-8e72-b0f0837d3f1f"), null, "Направление конкурса", 12, "Выберите направление конкурса", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("94b4864a-3139-48cc-8888-e8fbef8c694a"), new Guid("6e4cf998-f78b-44c8-af41-5a483fd43c58"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", "Защитившиеся кандидаты наук", 24, "Введите количество", true, new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("afd310d9-b98e-4afa-afb0-daf4c748877c"), new Guid("5e66d320-b43e-48e1-87ab-31cae394d372"), null, "Контактный телефон", 4, "+8 (900)-000-00-00", true, new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("bb152a1e-a236-439d-bb3f-1cb8e14233e9"), new Guid("5e66d320-b43e-48e1-87ab-31cae394d372"), null, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("bcad71ac-b989-42ae-9641-af4f9138f8c6"), new Guid("74eb00d5-1d0d-4e6f-8e72-b0f0837d3f1f"), null, "Ученая степень", 17, "Выберите ученую степень", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("c883f75d-266b-48f8-8325-4faae705d492"), new Guid("5e66d320-b43e-48e1-87ab-31cae394d372"), null, "Адрес работы/учебы", 7, "Регион, город, улица, дом", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("cba68fa0-99f2-44ae-924f-38cd87cdee52"), new Guid("0095665a-ba49-4d2a-a10b-e00c665c2ce4"), null, "Защитившиеся специалисты", 22, "Введите количество", true, new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("d28a422a-d183-4017-b731-4c225fe451a5"), new Guid("74eb00d5-1d0d-4e6f-8e72-b0f0837d3f1f"), null, "Ученое звание", 16, "Выберите ученое звание", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("ee2ff6ff-dcc3-469c-a77a-7bb8cdcaff9d"), new Guid("5e66d320-b43e-48e1-87ab-31cae394d372"), null, "Дополнительная информация", 11, "Пример", true, new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), new Guid("2e08cabf-740f-4722-8e3f-af2e2d52394a") },
                    { new Guid("28738105-a8b0-424f-a769-212708c93b34"), new Guid("bbeb1cb4-353c-4b75-8598-ac3054d2de84") },
                    { new Guid("45a4ce7a-cfdd-41c1-890b-9763e91a71c8"), new Guid("bbeb1cb4-353c-4b75-8598-ac3054d2de84") },
                    { new Guid("6f60dbec-fc8d-4ae3-8db7-669f5e559b84"), new Guid("2e08cabf-740f-4722-8e3f-af2e2d52394a") },
                    { new Guid("6f60dbec-fc8d-4ae3-8db7-669f5e559b84"), new Guid("bbeb1cb4-353c-4b75-8598-ac3054d2de84") },
                    { new Guid("92de5e8d-b107-4053-a25b-f7827f15a274"), new Guid("bbeb1cb4-353c-4b75-8598-ac3054d2de84") },
                    { new Guid("c3d2e270-ed84-42ce-9c67-268f5239151f"), new Guid("2e08cabf-740f-4722-8e3f-af2e2d52394a") },
                    { new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e"), new Guid("2e08cabf-740f-4722-8e3f-af2e2d52394a") },
                    { new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e"), new Guid("bbeb1cb4-353c-4b75-8598-ac3054d2de84") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("c3d2e270-ed84-42ce-9c67-268f5239151f"), new Guid("5b13e4ad-ec5d-4b0c-a5bb-aed8d4192b8f") },
                    { new Guid("c3d2e270-ed84-42ce-9c67-268f5239151f"), new Guid("eacac388-49bb-4f6e-95cc-3b2877f99d1e") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("002db9b0-1457-4875-9988-ab3c7cc79d4c"), new Guid("6e4cf998-f78b-44c8-af41-5a483fd43c58"), false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("013c5276-a779-41ce-ae9b-3078f58b1962"), new Guid("0095665a-ba49-4d2a-a10b-e00c665c2ce4"), false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("28f4cabc-4cee-4bcc-b204-3af754147e2b"), new Guid("0095665a-ba49-4d2a-a10b-e00c665c2ce4"), false, "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 },
                    { new Guid("45354f6f-5e09-4726-b7b3-ad5a376442a3"), new Guid("0095665a-ba49-4d2a-a10b-e00c665c2ce4"), false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("764adf61-1ed9-40f7-be6a-75e9f058a793"), new Guid("c90287a2-c0db-421c-b4a7-54b4f0ddac87"), false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("81d4437d-011f-4345-bc1a-b27b7251fe73"), new Guid("c90287a2-c0db-421c-b4a7-54b4f0ddac87"), false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("c73d162b-68b8-4f76-a738-6bfd04689efb"), new Guid("0095665a-ba49-4d2a-a10b-e00c665c2ce4"), false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("cbae38e1-a427-4873-b754-671c469a0304"), new Guid("6e4cf998-f78b-44c8-af41-5a483fd43c58"), true, "Персональные идентификаторы и показатели", 10 },
                    { new Guid("da9e3386-452d-409e-860c-e65f06168e72"), new Guid("6e4cf998-f78b-44c8-af41-5a483fd43c58"), false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("ebf9af55-ba4e-4469-8e3a-85c3fb1d22fa"), new Guid("0095665a-ba49-4d2a-a10b-e00c665c2ce4"), false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("f57f6826-4751-4400-ba99-451b5a1ed1e1"), new Guid("0095665a-ba49-4d2a-a10b-e00c665c2ce4"), false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("f9c3bf69-2aa3-49ec-9fbb-23c6563754f4"), new Guid("6e4cf998-f78b-44c8-af41-5a483fd43c58"), false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("fd16f080-df0e-4c9f-b3de-4c829718aadc"), new Guid("6e4cf998-f78b-44c8-af41-5a483fd43c58"), false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0270e21a-ab10-4351-8998-c0e60a4f0f92"), "Название статьи", 1, new Guid("002db9b0-1457-4875-9988-ab3c7cc79d4c"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("0a666f5e-2b47-463d-a5e2-04054d10c93c"), "Издание, год", 4, new Guid("002db9b0-1457-4875-9988-ab3c7cc79d4c"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("0df10e33-f389-4d48-a87a-3db098b72d2c"), "Год получения документа", 2, new Guid("764adf61-1ed9-40f7-be6a-75e9f058a793"), new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("115bcec8-b077-4d92-99fc-b4b1c95aac28"), "Количество печатных листов", 4, new Guid("28f4cabc-4cee-4bcc-b204-3af754147e2b"), new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("14b10c7f-8a3d-41ef-a748-de4d3773f62a"), "Соавторы", 2, new Guid("002db9b0-1457-4875-9988-ab3c7cc79d4c"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("14d43f3f-b46e-40db-bfa1-2eb89ab6d875"), "Количество часов", 4, new Guid("f57f6826-4751-4400-ba99-451b5a1ed1e1"), new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("1a4fac46-afb5-4f7f-8b00-ac540b7986f7"), "Вид (лекции, лабораторные)", 2, new Guid("45354f6f-5e09-4726-b7b3-ad5a376442a3"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("2569b656-cae8-4af0-8226-fe55a3e979c3"), "Наличие грифа", 5, new Guid("28f4cabc-4cee-4bcc-b204-3af754147e2b"), new Guid("0a082c69-7567-45cf-b95d-21a49bba091a") },
                    { new Guid("340eceb5-5f17-4e52-92a7-9e700bc2d9d8"), "Лекции (час.)", 3, new Guid("ebf9af55-ba4e-4469-8e3a-85c3fb1d22fa"), new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("371f6e74-442d-415c-83b7-25252c771ddb"), "Период выполнения", 3, new Guid("da9e3386-452d-409e-860c-e65f06168e72"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("39827149-182c-4f23-8243-1083a38f2efb"), "Соавторы", 2, new Guid("013c5276-a779-41ce-ae9b-3078f58b1962"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("3f9c7b52-08ca-40d5-91f0-b323bcf261ee"), "Награда", 4, new Guid("81d4437d-011f-4345-bc1a-b27b7251fe73"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("44bdc9b8-5d61-4ab4-8fa1-2868dd252eae"), "Вид", 1, new Guid("f9c3bf69-2aa3-49ec-9fbb-23c6563754f4"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("5801dd5a-b629-4696-8b0a-4bc0d51b6a36"), "Год", 3, new Guid("c73d162b-68b8-4f76-a738-6bfd04689efb"), new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("5bff18cd-8e95-4ad1-b22a-1c4d73c7ddfe"), "Количество цитирований", 4, new Guid("cbae38e1-a427-4873-b754-671c469a0304"), new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("5d76b515-912e-4b21-abd0-dc8fd67e72a9"), "Ссылка", 5, new Guid("81d4437d-011f-4345-bc1a-b27b7251fe73"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("62e07370-de38-4df3-bda0-017c61cb9683"), "Название", 2, new Guid("28f4cabc-4cee-4bcc-b204-3af754147e2b"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("67373828-1926-4ea2-86c1-29a9b6d80cf7"), "Индекс Хирша (за все время)", 5, new Guid("cbae38e1-a427-4873-b754-671c469a0304"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("6b615f87-a781-40da-8005-876b418631b6"), "Язык преподавания (русск./англ./др.)", 2, new Guid("ebf9af55-ba4e-4469-8e3a-85c3fb1d22fa"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("7247ee9d-c052-41d6-abc1-06ee52db33d9"), "Вид деятельности (преподавательская)", 3, new Guid("f57f6826-4751-4400-ba99-451b5a1ed1e1"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("72d859c8-f484-4b45-acc6-5527802d7768"), "Вид", 1, new Guid("fd16f080-df0e-4c9f-b3de-4c829718aadc"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("7bbe3876-5d3c-4e5b-b6c7-5eddd142b4a6"), "Год", 1, new Guid("81d4437d-011f-4345-bc1a-b27b7251fe73"), new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("807f8a80-a061-401a-944d-0ec50b930417"), "Издательство, год", 6, new Guid("28f4cabc-4cee-4bcc-b204-3af754147e2b"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("85b3f8c3-6b6f-4278-8c09-a4ba822865f7"), "Статус конкурса", 3, new Guid("81d4437d-011f-4345-bc1a-b27b7251fe73"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("8abda747-e0fc-4637-8d8c-80a39596305c"), "Вид публикации", 1, new Guid("28f4cabc-4cee-4bcc-b204-3af754147e2b"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("8b5270c2-92ac-4907-b36f-ad679949e4f1"), "Название конкурса", 2, new Guid("81d4437d-011f-4345-bc1a-b27b7251fe73"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("8f7a6263-abd4-4258-ab16-f381c8760e91"), "Название организации/должность/ставка", 1, new Guid("f57f6826-4751-4400-ba99-451b5a1ed1e1"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("93728924-1f66-445d-b5cd-7305717776e4"), "Идентификатор", 2, new Guid("cbae38e1-a427-4873-b754-671c469a0304"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("93f97341-44b2-4c6e-a26d-5852e6c138c0"), "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("002db9b0-1457-4875-9988-ab3c7cc79d4c"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("9da25b3c-d28a-49d0-a2ba-7ad3522d8b16"), "Статус (руководитель/исполнитель)", 4, new Guid("da9e3386-452d-409e-860c-e65f06168e72"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("9de623e4-5a13-42dd-bebb-bd174ecf5106"), "Название", 2, new Guid("f9c3bf69-2aa3-49ec-9fbb-23c6563754f4"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("a51f997d-19a3-4e15-a4b3-98eac19738de"), "Год", 4, new Guid("013c5276-a779-41ce-ae9b-3078f58b1962"), new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("a7161494-5835-4a4a-a1e2-683b54df22e5"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("c73d162b-68b8-4f76-a738-6bfd04689efb"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("ae2787c8-1c05-4ef8-bfef-7a51a18a1341"), "ФИО", 1, new Guid("c73d162b-68b8-4f76-a738-6bfd04689efb"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("af6397ed-725a-4953-8d53-7b8f79cfb05a"), "Номер РИД", 4, new Guid("f9c3bf69-2aa3-49ec-9fbb-23c6563754f4"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("b9abdc78-36a0-4f9a-b49a-3c9ee4c0f65d"), "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("c73d162b-68b8-4f76-a738-6bfd04689efb"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("bba91b97-f5cb-4126-a6ff-7d172bbd58b2"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("da9e3386-452d-409e-860c-e65f06168e72"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("bc209802-9fe7-4938-9666-cb6fbba051f0"), "Соавторы", 3, new Guid("28f4cabc-4cee-4bcc-b204-3af754147e2b"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("bd0c42a3-a164-4ed7-b5c3-1fe57ff1dfc9"), "Сумма финансирования (тыс. руб.)", 2, new Guid("da9e3386-452d-409e-860c-e65f06168e72"), new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("bd3a2856-a695-43df-b877-6f4dc59664ff"), "Название НИР/НИОКР", 1, new Guid("da9e3386-452d-409e-860c-e65f06168e72"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("c667aea7-369d-4dfc-b8c6-876ffdd4baeb"), "Название курса", 1, new Guid("013c5276-a779-41ce-ae9b-3078f58b1962"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("cdc14840-6fed-4b09-b443-d3e4f9455683"), "Название дисциплины", 1, new Guid("45354f6f-5e09-4726-b7b3-ad5a376442a3"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("d8980ce7-aefc-4ef4-8be1-bfc58cf22ad1"), "Название конкурса/премии", 2, new Guid("c73d162b-68b8-4f76-a738-6bfd04689efb"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("deb1f399-0665-49aa-94ee-b0141469b2df"), "Название разработки", 2, new Guid("fd16f080-df0e-4c9f-b3de-4c829718aadc"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("e042d5e2-0a5f-4591-aa8a-ae6c2999f5c1"), "Практические занятия (час.)", 4, new Guid("ebf9af55-ba4e-4469-8e3a-85c3fb1d22fa"), new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("e60dce1d-3cb7-4335-9d6f-0e61c7865258"), "Итого (час.)", 5, new Guid("ebf9af55-ba4e-4469-8e3a-85c3fb1d22fa"), new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("e9d48990-9068-4bbc-9132-7a0aa7b0b55f"), "Ссылка на платформу", 3, new Guid("013c5276-a779-41ce-ae9b-3078f58b1962"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("ebcdd84d-805f-4e68-a9fa-c293184d5341"), "ФИО соавторов", 3, new Guid("f9c3bf69-2aa3-49ec-9fbb-23c6563754f4"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("ed888e7c-fd24-486d-9671-678f2c44b637"), "Тип идентификатора", 1, new Guid("cbae38e1-a427-4873-b754-671c469a0304"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("ef0d015f-50b7-4bff-b238-3b5c83780c9f"), "Количество публикаций в БАЗЕ", 3, new Guid("cbae38e1-a427-4873-b754-671c469a0304"), new Guid("b4e9a55c-19fb-44a8-822c-0a0cae552994") },
                    { new Guid("f2f98add-f67b-42c5-b8dd-24aa8b06c530"), "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("f57f6826-4751-4400-ba99-451b5a1ed1e1"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("fb8eb704-4d76-4933-af3c-f412c145d88a"), "Название документа, реквизиты", 1, new Guid("764adf61-1ed9-40f7-be6a-75e9f058a793"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("fe1b23cc-5e2f-4418-ba63-ae0dcf33dc47"), "Название организации в которую внедрена разработка", 3, new Guid("fd16f080-df0e-4c9f-b3de-4c829718aadc"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") },
                    { new Guid("fedffb6f-9a3b-497b-bc81-61bf66a48a07"), "Наименование курса", 1, new Guid("ebf9af55-ba4e-4469-8e3a-85c3fb1d22fa"), new Guid("a335b9a6-cb12-4c92-bc95-3d051f78fff4") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("028ea5ba-49a9-47a2-bf9f-e1968fe9abe2"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("02b91a72-fe64-433b-8d83-7ff480e24db5"), new Guid("28738105-a8b0-424f-a769-212708c93b34") },
                    { new Guid("269fe0ba-8f0a-471c-8a22-1596cda13a83"), new Guid("6f60dbec-fc8d-4ae3-8db7-669f5e559b84") },
                    { new Guid("2b9c4f97-40ee-4aee-9459-09082858aa56"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("2c12554f-83b8-44a0-a63d-2ac23de401d5"), new Guid("28738105-a8b0-424f-a769-212708c93b34") },
                    { new Guid("486fe20a-80d5-41ae-a08a-f1e2d84a5db5"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("4f7398bf-2cb9-43dd-9f10-dacaeb122fbe"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("59f17939-dbf1-4650-8a1a-d6eea67f494f"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("5abbc9bd-a7bf-4f18-9e67-76ce93283798"), new Guid("6f60dbec-fc8d-4ae3-8db7-669f5e559b84") },
                    { new Guid("5b2140db-d0a7-47a5-bc3c-412cc2e52528"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("5d472461-2200-4d2a-82c4-8801fd878835"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("61c76373-3d5e-4e13-bd40-3898961b64e9"), new Guid("28738105-a8b0-424f-a769-212708c93b34") },
                    { new Guid("643f6133-3970-40ba-a3d1-9f3f11fb1973"), new Guid("28738105-a8b0-424f-a769-212708c93b34") },
                    { new Guid("6d8d378a-005c-445c-934c-d0e9cc08faab"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("740d3b1e-5dad-4264-9d24-2cac4161b49a"), new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9") },
                    { new Guid("88a5d3d7-b0b8-4845-b663-33622f19a82e"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("927ffbd5-710f-4532-b772-44db6aca2fc6"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("94b4864a-3139-48cc-8888-e8fbef8c694a"), new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9") },
                    { new Guid("afd310d9-b98e-4afa-afb0-daf4c748877c"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("bb152a1e-a236-439d-bb3f-1cb8e14233e9"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("bcad71ac-b989-42ae-9641-af4f9138f8c6"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("c883f75d-266b-48f8-8325-4faae705d492"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("cba68fa0-99f2-44ae-924f-38cd87cdee52"), new Guid("28738105-a8b0-424f-a769-212708c93b34") },
                    { new Guid("d28a422a-d183-4017-b731-4c225fe451a5"), new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9") },
                    { new Guid("d28a422a-d183-4017-b731-4c225fe451a5"), new Guid("92de5e8d-b107-4053-a25b-f7827f15a274") },
                    { new Guid("d28a422a-d183-4017-b731-4c225fe451a5"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") },
                    { new Guid("ee2ff6ff-dcc3-469c-a77a-7bb8cdcaff9d"), new Guid("c76590a4-f07c-44e0-8ce8-ea2d0ececa2e") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), new Guid("002db9b0-1457-4875-9988-ab3c7cc79d4c") },
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), new Guid("81d4437d-011f-4345-bc1a-b27b7251fe73") },
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), new Guid("cbae38e1-a427-4873-b754-671c469a0304") },
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), new Guid("da9e3386-452d-409e-860c-e65f06168e72") },
                    { new Guid("28738105-a8b0-424f-a769-212708c93b34"), new Guid("013c5276-a779-41ce-ae9b-3078f58b1962") },
                    { new Guid("28738105-a8b0-424f-a769-212708c93b34"), new Guid("c73d162b-68b8-4f76-a738-6bfd04689efb") },
                    { new Guid("28738105-a8b0-424f-a769-212708c93b34"), new Guid("ebf9af55-ba4e-4469-8e3a-85c3fb1d22fa") },
                    { new Guid("28738105-a8b0-424f-a769-212708c93b34"), new Guid("f57f6826-4751-4400-ba99-451b5a1ed1e1") },
                    { new Guid("45a4ce7a-cfdd-41c1-890b-9763e91a71c8"), new Guid("28f4cabc-4cee-4bcc-b204-3af754147e2b") },
                    { new Guid("45a4ce7a-cfdd-41c1-890b-9763e91a71c8"), new Guid("45354f6f-5e09-4726-b7b3-ad5a376442a3") },
                    { new Guid("92de5e8d-b107-4053-a25b-f7827f15a274"), new Guid("764adf61-1ed9-40f7-be6a-75e9f058a793") },
                    { new Guid("92de5e8d-b107-4053-a25b-f7827f15a274"), new Guid("81d4437d-011f-4345-bc1a-b27b7251fe73") },
                    { new Guid("c3d2e270-ed84-42ce-9c67-268f5239151f"), new Guid("764adf61-1ed9-40f7-be6a-75e9f058a793") },
                    { new Guid("c3d2e270-ed84-42ce-9c67-268f5239151f"), new Guid("f9c3bf69-2aa3-49ec-9fbb-23c6563754f4") },
                    { new Guid("c3d2e270-ed84-42ce-9c67-268f5239151f"), new Guid("fd16f080-df0e-4c9f-b3de-4c829718aadc") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0375eea8-d3d5-4102-93fb-85b58817829b"), null, true, 10, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("da9e3386-452d-409e-860c-e65f06168e72") },
                    { new Guid("07ceb1be-0b03-4908-a90a-9c8a8cc94012"), new Guid("d28a422a-d183-4017-b731-4c225fe451a5"), true, 10, "Баллы за ученое звание:", 13, null },
                    { new Guid("0e37f100-5dc8-4887-bda0-d0ca71fd29c6"), null, true, 10, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("013c5276-a779-41ce-ae9b-3078f58b1962") },
                    { new Guid("18d6a359-f609-4ecb-866c-c35743400c8e"), null, true, 10, "Баллы по базе РИНЦ:", 18, new Guid("cbae38e1-a427-4873-b754-671c469a0304") },
                    { new Guid("2ab143b9-7d2f-4e91-ad44-d2b9fccc9d20"), new Guid("643f6133-3970-40ba-a3d1-9f3f11fb1973"), true, 10, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("2ada0f24-03c9-408f-b2ca-48c11faf9594"), new Guid("94b4864a-3139-48cc-8888-e8fbef8c694a"), true, 10, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("2c654393-11f8-489a-9c75-954d31ff97cf"), null, true, 10, "Баллы за объем учебной нагрузки:", 1, new Guid("ebf9af55-ba4e-4469-8e3a-85c3fb1d22fa") },
                    { new Guid("30d06184-48e6-437f-ab9f-f5ff0f984bc9"), null, true, 10, "Баллы за научные публикации:", 16, new Guid("002db9b0-1457-4875-9988-ab3c7cc79d4c") },
                    { new Guid("338bc376-50dc-45aa-936e-1acefbc4212c"), null, true, 10, "Баллы за количество разработок:", 24, new Guid("fd16f080-df0e-4c9f-b3de-4c829718aadc") },
                    { new Guid("3441ae6a-75d4-4988-ac97-58c0da24e320"), new Guid("2c12554f-83b8-44a0-a63d-2ac23de401d5"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("480bdef2-8e88-44bc-8591-46b85a32fa21"), null, true, 10, "Баллы за труды с грифом в соавторстве:", 9, new Guid("28f4cabc-4cee-4bcc-b204-3af754147e2b") },
                    { new Guid("7b27b3f4-f22a-4bdf-95ba-97cb4814e945"), null, true, 10, "Баллы за труды с грифом и без соавторства:", 8, new Guid("28f4cabc-4cee-4bcc-b204-3af754147e2b") },
                    { new Guid("80c201b3-7662-4ec5-a5c4-afac44c60eca"), null, true, 10, "Баллы за труды без грифа и без соавторства:", 10, new Guid("28f4cabc-4cee-4bcc-b204-3af754147e2b") },
                    { new Guid("920b007d-83d2-4c3e-9a01-c98e7abf142f"), null, true, 10, "Баллы по базе Scopus:", 17, new Guid("cbae38e1-a427-4873-b754-671c469a0304") },
                    { new Guid("931a3639-8c0c-4d2e-94d9-62dacee0b22b"), null, true, 10, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("f9c3bf69-2aa3-49ec-9fbb-23c6563754f4") },
                    { new Guid("9e323af0-c75a-429b-9fc4-cacb9e74aaf7"), null, true, 10, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("da9e3386-452d-409e-860c-e65f06168e72") },
                    { new Guid("a74290a6-3854-4083-81b5-a7ae4e5738b2"), null, true, 10, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("ebf9af55-ba4e-4469-8e3a-85c3fb1d22fa") },
                    { new Guid("ac481082-2ad8-4311-8e64-b7e09f7cb69a"), null, true, 10, "Баллы за профессиональное развитие:", 15, new Guid("764adf61-1ed9-40f7-be6a-75e9f058a793") },
                    { new Guid("c5d3fa52-4dd2-4644-8900-b4f754e7f3d5"), null, true, 10, "Баллы за награды:", 14, new Guid("81d4437d-011f-4345-bc1a-b27b7251fe73") },
                    { new Guid("dad8d92d-1e15-4886-97cd-00ec5d0d373d"), null, true, 10, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("45354f6f-5e09-4726-b7b3-ad5a376442a3") },
                    { new Guid("e1ac3234-54a0-40ca-ade1-c83005733a95"), null, true, 10, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("c73d162b-68b8-4f76-a738-6bfd04689efb") },
                    { new Guid("ef36d637-703a-4c39-bca4-726d0feef4c1"), null, true, 10, "Баллы за труды без грифа в соавторстве:", 11, new Guid("28f4cabc-4cee-4bcc-b204-3af754147e2b") },
                    { new Guid("f31387d1-100c-4e3e-904e-7c68b2d0cbd9"), new Guid("740d3b1e-5dad-4264-9d24-2cac4161b49a"), true, 10, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("fc91f625-0365-489e-a857-ac9b06e67b15"), new Guid("02b91a72-fe64-433b-8d83-7ff480e24db5"), true, 10, "Баллы за количество защитившихся кандидатов наук:", 4, null }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("06e7963e-9713-451c-9374-ff5498acd0b2"), true, new Guid("cbae38e1-a427-4873-b754-671c469a0304") },
                    { new Guid("0d822c64-1146-4580-82db-d298a54abbdd"), true, new Guid("cbae38e1-a427-4873-b754-671c469a0304") },
                    { new Guid("0d933de6-a850-4542-b639-2c992d4a140b"), true, new Guid("cbae38e1-a427-4873-b754-671c469a0304") },
                    { new Guid("17a87551-141b-4080-9b38-32887639fcba"), true, new Guid("cbae38e1-a427-4873-b754-671c469a0304") },
                    { new Guid("99f2cc81-0c2d-480a-85e4-b3ad98ccb816"), true, new Guid("cbae38e1-a427-4873-b754-671c469a0304") },
                    { new Guid("ab4c2736-cc14-4b7a-86e3-aeadb4a315de"), true, new Guid("cbae38e1-a427-4873-b754-671c469a0304") },
                    { new Guid("ef7518a0-dbdc-45eb-b80f-5f42c70e038f"), true, new Guid("cbae38e1-a427-4873-b754-671c469a0304") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0d09c1f1-c083-4ccf-bcce-0462ee6ff423"), null, new Guid("927ffbd5-710f-4532-b772-44db6aca2fc6"), "ТЕХНИКА И ТЕХНОЛОГИИ СТРОИТЕЛЬСТВА" },
                    { new Guid("3042be61-22f2-4c59-87f2-d5b645a6d571"), null, new Guid("927ffbd5-710f-4532-b772-44db6aca2fc6"), "СТРОИТЕЛЬСТВО И АРХИТЕКТУРА" },
                    { new Guid("509b4935-0af7-4526-90cf-2aa673af1299"), null, new Guid("6d8d378a-005c-445c-934c-d0e9cc08faab"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("58e05290-58d9-4fd6-a23f-638bf56df0a0"), null, new Guid("927ffbd5-710f-4532-b772-44db6aca2fc6"), "АРХИТЕКТУРА" },
                    { new Guid("73afb809-c4f6-4e4f-9b29-01a558ec49de"), null, new Guid("927ffbd5-710f-4532-b772-44db6aca2fc6"), "НЕДРОПОЛЬЗОВАНИЕ И ГОРНЫЕ НАУКИ" },
                    { new Guid("749fdff9-c1f2-4d9b-90a4-8c4ff98c28e9"), null, new Guid("d28a422a-d183-4017-b731-4c225fe451a5"), "Доцент" },
                    { new Guid("88b387aa-1deb-403c-a1d5-be1626fced5e"), null, new Guid("d28a422a-d183-4017-b731-4c225fe451a5"), "Профессор" },
                    { new Guid("a1cd04ff-2f5c-47e6-ad96-3e4caf7b8cdf"), null, new Guid("6d8d378a-005c-445c-934c-d0e9cc08faab"), "Аспиранты, адъюнкты, ординаторы, ассистенты-стажеры, не имеющие ученой степени" },
                    { new Guid("abf28bc8-12b7-4f23-9882-399061198e75"), null, new Guid("927ffbd5-710f-4532-b772-44db6aca2fc6"), "ПРИКЛАДНАЯ ГЕОЛОГИЯ, ГОРНОЕ ДЕЛО, НЕФТЕГАЗОВОЕ ДЕЛО И ГЕОДЕЗИЯ" },
                    { new Guid("ac334c95-625a-4991-b594-f1f437e0e239"), null, new Guid("d28a422a-d183-4017-b731-4c225fe451a5"), "Нет" },
                    { new Guid("cb79746e-2f60-4f25-9489-255a7ecbd3ed"), null, new Guid("6d8d378a-005c-445c-934c-d0e9cc08faab"), "Имеющие ученую степень доктора наук" },
                    { new Guid("e4f261f2-5b8b-4efc-a992-c5b6b53e9e9d"), null, new Guid("927ffbd5-710f-4532-b772-44db6aca2fc6"), "ЭЛЕКТРО- И ТЕПЛОЭНЕРГЕТИКА" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("02749450-9cf6-4524-8592-01c55a157f72"), null, new Guid("ed888e7c-fd24-486d-9671-678f2c44b637"), true, true, new Guid("0d822c64-1146-4580-82db-d298a54abbdd"), "ResearcherID" },
                    { new Guid("0c34eb37-44bc-4468-be11-9073ed462d53"), null, new Guid("67373828-1926-4ea2-86c1-29a9b6d80cf7"), false, true, new Guid("0d933de6-a850-4542-b639-2c992d4a140b"), null },
                    { new Guid("1340997b-cde6-49b4-9392-98e5ce84f4a7"), null, new Guid("ed888e7c-fd24-486d-9671-678f2c44b637"), true, true, new Guid("0d933de6-a850-4542-b639-2c992d4a140b"), "ScopusID" },
                    { new Guid("134b676e-265d-4047-9965-061c041e32f4"), null, new Guid("93728924-1f66-445d-b5cd-7305717776e4"), true, true, new Guid("17a87551-141b-4080-9b38-32887639fcba"), null },
                    { new Guid("15725a18-71c8-445b-afa5-cc893ad0ed12"), null, new Guid("ed888e7c-fd24-486d-9671-678f2c44b637"), true, true, new Guid("ef7518a0-dbdc-45eb-b80f-5f42c70e038f"), "Google Scholar ID" },
                    { new Guid("1940b72f-51f1-4f30-8de8-2cb0e489d3d2"), null, new Guid("ed888e7c-fd24-486d-9671-678f2c44b637"), true, true, new Guid("06e7963e-9713-451c-9374-ff5498acd0b2"), "РИНЦ AuthorID" },
                    { new Guid("2492ebcd-c269-4c65-bc68-ec36b31d0cda"), null, new Guid("ef0d015f-50b7-4bff-b238-3b5c83780c9f"), false, true, new Guid("ef7518a0-dbdc-45eb-b80f-5f42c70e038f"), null },
                    { new Guid("2c18f3ab-3683-45a8-8bc0-7bda321c72d1"), null, new Guid("5bff18cd-8e95-4ad1-b22a-1c4d73c7ddfe"), true, true, new Guid("17a87551-141b-4080-9b38-32887639fcba"), null },
                    { new Guid("2f58139b-f062-4d42-878e-92f880535fba"), null, new Guid("67373828-1926-4ea2-86c1-29a9b6d80cf7"), true, true, new Guid("ab4c2736-cc14-4b7a-86e3-aeadb4a315de"), null },
                    { new Guid("4694aa2c-f7fa-4330-a005-eb7520f2dd1f"), null, new Guid("ef0d015f-50b7-4bff-b238-3b5c83780c9f"), false, true, new Guid("ab4c2736-cc14-4b7a-86e3-aeadb4a315de"), null },
                    { new Guid("4920c25f-5b64-4d1a-820b-8fe0eff32862"), null, new Guid("67373828-1926-4ea2-86c1-29a9b6d80cf7"), true, true, new Guid("99f2cc81-0c2d-480a-85e4-b3ad98ccb816"), null },
                    { new Guid("5005a955-f197-4ad3-a1cf-1397ff7460dd"), null, new Guid("5bff18cd-8e95-4ad1-b22a-1c4d73c7ddfe"), false, true, new Guid("0d822c64-1146-4580-82db-d298a54abbdd"), null },
                    { new Guid("580ae8a5-d092-49b9-8451-20af960869ae"), null, new Guid("5bff18cd-8e95-4ad1-b22a-1c4d73c7ddfe"), false, true, new Guid("99f2cc81-0c2d-480a-85e4-b3ad98ccb816"), null },
                    { new Guid("62c6ba05-4e1f-4969-9062-dc4d21596668"), null, new Guid("ef0d015f-50b7-4bff-b238-3b5c83780c9f"), false, true, new Guid("99f2cc81-0c2d-480a-85e4-b3ad98ccb816"), null },
                    { new Guid("6a6cd643-4275-435a-993b-3434fd3e2b3b"), null, new Guid("93728924-1f66-445d-b5cd-7305717776e4"), false, true, new Guid("ef7518a0-dbdc-45eb-b80f-5f42c70e038f"), null },
                    { new Guid("7037920c-a948-428c-a80b-1ac6ec551541"), null, new Guid("67373828-1926-4ea2-86c1-29a9b6d80cf7"), true, true, new Guid("17a87551-141b-4080-9b38-32887639fcba"), null },
                    { new Guid("75ccd908-b935-4721-964c-ea1c6c99b7a6"), null, new Guid("5bff18cd-8e95-4ad1-b22a-1c4d73c7ddfe"), false, true, new Guid("0d933de6-a850-4542-b639-2c992d4a140b"), null },
                    { new Guid("81986635-2d99-4bdc-89be-79992bc45c39"), null, new Guid("67373828-1926-4ea2-86c1-29a9b6d80cf7"), false, true, new Guid("06e7963e-9713-451c-9374-ff5498acd0b2"), null },
                    { new Guid("81ec1765-57bc-4082-a4f1-9b01da4691fc"), null, new Guid("93728924-1f66-445d-b5cd-7305717776e4"), false, true, new Guid("0d822c64-1146-4580-82db-d298a54abbdd"), null },
                    { new Guid("83c1fcd5-95b6-4531-8572-69030fce002f"), null, new Guid("93728924-1f66-445d-b5cd-7305717776e4"), false, true, new Guid("0d933de6-a850-4542-b639-2c992d4a140b"), null },
                    { new Guid("841643fa-134f-4c06-a6fe-a956e7a6f6c3"), null, new Guid("ed888e7c-fd24-486d-9671-678f2c44b637"), true, true, new Guid("ab4c2736-cc14-4b7a-86e3-aeadb4a315de"), "ORCiD" },
                    { new Guid("890fe8fd-56b1-444b-ae22-abc53a4b1f6b"), null, new Guid("5bff18cd-8e95-4ad1-b22a-1c4d73c7ddfe"), true, true, new Guid("ab4c2736-cc14-4b7a-86e3-aeadb4a315de"), null },
                    { new Guid("89db6a3f-4ec7-4df9-aedb-bdbf5cbd78f4"), null, new Guid("93728924-1f66-445d-b5cd-7305717776e4"), false, true, new Guid("06e7963e-9713-451c-9374-ff5498acd0b2"), null },
                    { new Guid("ad1a653c-1d51-48d7-8198-d96dfe409e89"), null, new Guid("5bff18cd-8e95-4ad1-b22a-1c4d73c7ddfe"), false, true, new Guid("ef7518a0-dbdc-45eb-b80f-5f42c70e038f"), null },
                    { new Guid("b46f6ee4-484c-4fe7-b5d9-7c4a0f816ce4"), null, new Guid("67373828-1926-4ea2-86c1-29a9b6d80cf7"), false, true, new Guid("ef7518a0-dbdc-45eb-b80f-5f42c70e038f"), null },
                    { new Guid("c96b37b9-efab-49b8-b95e-7506cfee7608"), null, new Guid("67373828-1926-4ea2-86c1-29a9b6d80cf7"), false, true, new Guid("0d822c64-1146-4580-82db-d298a54abbdd"), null },
                    { new Guid("cd48cee2-2048-4412-80f1-b6453ebb97b4"), null, new Guid("ed888e7c-fd24-486d-9671-678f2c44b637"), true, true, new Guid("99f2cc81-0c2d-480a-85e4-b3ad98ccb816"), "Количество монографий/глав в монографии" },
                    { new Guid("d4653400-f836-462f-9718-65b58a0db290"), null, new Guid("ef0d015f-50b7-4bff-b238-3b5c83780c9f"), false, true, new Guid("0d822c64-1146-4580-82db-d298a54abbdd"), null },
                    { new Guid("da388110-6325-480c-a893-d3fe28e8626b"), null, new Guid("ef0d015f-50b7-4bff-b238-3b5c83780c9f"), false, true, new Guid("17a87551-141b-4080-9b38-32887639fcba"), null },
                    { new Guid("e346a07b-3fe9-4a46-9e9b-c200e0e0f667"), null, new Guid("ef0d015f-50b7-4bff-b238-3b5c83780c9f"), false, true, new Guid("0d933de6-a850-4542-b639-2c992d4a140b"), null },
                    { new Guid("e726e0b0-57b9-4031-afee-678ca3deff25"), null, new Guid("ef0d015f-50b7-4bff-b238-3b5c83780c9f"), false, true, new Guid("06e7963e-9713-451c-9374-ff5498acd0b2"), null },
                    { new Guid("f1a09d2b-7e30-4ded-8f47-7e778dde2258"), null, new Guid("5bff18cd-8e95-4ad1-b22a-1c4d73c7ddfe"), false, true, new Guid("06e7963e-9713-451c-9374-ff5498acd0b2"), null },
                    { new Guid("fad7093d-ab79-4340-ac71-7a332667b9a7"), null, new Guid("93728924-1f66-445d-b5cd-7305717776e4"), true, true, new Guid("99f2cc81-0c2d-480a-85e4-b3ad98ccb816"), null },
                    { new Guid("faec8c6e-2138-4aae-9c41-9aec7fdec920"), null, new Guid("93728924-1f66-445d-b5cd-7305717776e4"), false, true, new Guid("ab4c2736-cc14-4b7a-86e3-aeadb4a315de"), null },
                    { new Guid("fd99a590-cb0b-4abd-956a-ed5c08ce5ad9"), null, new Guid("ed888e7c-fd24-486d-9671-678f2c44b637"), true, true, new Guid("17a87551-141b-4080-9b38-32887639fcba"), "Количество патентов" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), new Guid("0375eea8-d3d5-4102-93fb-85b58817829b") },
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), new Guid("07ceb1be-0b03-4908-a90a-9c8a8cc94012") },
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), new Guid("18d6a359-f609-4ecb-866c-c35743400c8e") },
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), new Guid("2ada0f24-03c9-408f-b2ca-48c11faf9594") },
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), new Guid("30d06184-48e6-437f-ab9f-f5ff0f984bc9") },
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), new Guid("920b007d-83d2-4c3e-9a01-c98e7abf142f") },
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), new Guid("9e323af0-c75a-429b-9fc4-cacb9e74aaf7") },
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), new Guid("c5d3fa52-4dd2-4644-8900-b4f754e7f3d5") },
                    { new Guid("160dad1c-a11a-4fd2-9c2a-1752426f50f9"), new Guid("f31387d1-100c-4e3e-904e-7c68b2d0cbd9") },
                    { new Guid("28738105-a8b0-424f-a769-212708c93b34"), new Guid("0e37f100-5dc8-4887-bda0-d0ca71fd29c6") },
                    { new Guid("28738105-a8b0-424f-a769-212708c93b34"), new Guid("2ab143b9-7d2f-4e91-ad44-d2b9fccc9d20") },
                    { new Guid("28738105-a8b0-424f-a769-212708c93b34"), new Guid("2c654393-11f8-489a-9c75-954d31ff97cf") },
                    { new Guid("28738105-a8b0-424f-a769-212708c93b34"), new Guid("3441ae6a-75d4-4988-ac97-58c0da24e320") },
                    { new Guid("28738105-a8b0-424f-a769-212708c93b34"), new Guid("a74290a6-3854-4083-81b5-a7ae4e5738b2") },
                    { new Guid("28738105-a8b0-424f-a769-212708c93b34"), new Guid("e1ac3234-54a0-40ca-ade1-c83005733a95") },
                    { new Guid("28738105-a8b0-424f-a769-212708c93b34"), new Guid("fc91f625-0365-489e-a857-ac9b06e67b15") },
                    { new Guid("45a4ce7a-cfdd-41c1-890b-9763e91a71c8"), new Guid("480bdef2-8e88-44bc-8591-46b85a32fa21") },
                    { new Guid("45a4ce7a-cfdd-41c1-890b-9763e91a71c8"), new Guid("7b27b3f4-f22a-4bdf-95ba-97cb4814e945") },
                    { new Guid("45a4ce7a-cfdd-41c1-890b-9763e91a71c8"), new Guid("80c201b3-7662-4ec5-a5c4-afac44c60eca") },
                    { new Guid("45a4ce7a-cfdd-41c1-890b-9763e91a71c8"), new Guid("dad8d92d-1e15-4886-97cd-00ec5d0d373d") },
                    { new Guid("45a4ce7a-cfdd-41c1-890b-9763e91a71c8"), new Guid("ef36d637-703a-4c39-bca4-726d0feef4c1") },
                    { new Guid("92de5e8d-b107-4053-a25b-f7827f15a274"), new Guid("07ceb1be-0b03-4908-a90a-9c8a8cc94012") },
                    { new Guid("92de5e8d-b107-4053-a25b-f7827f15a274"), new Guid("ac481082-2ad8-4311-8e64-b7e09f7cb69a") },
                    { new Guid("92de5e8d-b107-4053-a25b-f7827f15a274"), new Guid("c5d3fa52-4dd2-4644-8900-b4f754e7f3d5") },
                    { new Guid("c3d2e270-ed84-42ce-9c67-268f5239151f"), new Guid("338bc376-50dc-45aa-936e-1acefbc4212c") },
                    { new Guid("c3d2e270-ed84-42ce-9c67-268f5239151f"), new Guid("931a3639-8c0c-4d2e-94d9-62dacee0b22b") },
                    { new Guid("c3d2e270-ed84-42ce-9c67-268f5239151f"), new Guid("ac481082-2ad8-4311-8e64-b7e09f7cb69a") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("12b8fe00-8a77-4975-8330-73a9bef84ffa"), new Guid("72d859c8-f484-4b45-acc6-5527802d7768"), null, "Изобретение" },
                    { new Guid("249dcc9d-8146-4225-929e-f77246c5b7de"), new Guid("8abda747-e0fc-4637-8d8c-80a39596305c"), null, "Учебник" },
                    { new Guid("30b05e55-7612-431b-9600-d663e67a3979"), new Guid("85b3f8c3-6b6f-4278-8c09-a4ba822865f7"), null, "Международный" },
                    { new Guid("3bca7368-af97-4df0-9782-14e76e50fa2b"), new Guid("1a4fac46-afb5-4f7f-8b00-ac540b7986f7"), null, "Лекции" },
                    { new Guid("3f3ad4c8-5360-4fb3-9dfb-34886263d9df"), new Guid("72d859c8-f484-4b45-acc6-5527802d7768"), null, "База данных" },
                    { new Guid("4e0d48ce-0f94-4a41-9c75-ba157bab7404"), new Guid("85b3f8c3-6b6f-4278-8c09-a4ba822865f7"), null, "Всероссийский" },
                    { new Guid("51e47e24-a096-45d6-b025-421d0b6e3a96"), new Guid("44bdc9b8-5d61-4ab4-8fa1-2868dd252eae"), null, "Изобретение" },
                    { new Guid("670e8424-1f4e-4cf0-9aa2-cf9ebeb73fc6"), new Guid("85b3f8c3-6b6f-4278-8c09-a4ba822865f7"), null, "Региональный" },
                    { new Guid("775bd283-3fc5-42d8-a86c-5421fa248c81"), new Guid("44bdc9b8-5d61-4ab4-8fa1-2868dd252eae"), null, "База данных" },
                    { new Guid("7c6c4fc3-bc01-427a-9642-c8b56eae4be3"), new Guid("1a4fac46-afb5-4f7f-8b00-ac540b7986f7"), null, "Лабораторные" },
                    { new Guid("a632f414-7880-451d-a130-205fbe2d5350"), new Guid("44bdc9b8-5d61-4ab4-8fa1-2868dd252eae"), null, "Полезная модель" },
                    { new Guid("b6512f85-56cf-4001-adcc-1dc3866e1958"), new Guid("9da25b3c-d28a-49d0-a2ba-7ad3522d8b16"), null, "Исполнитель" },
                    { new Guid("c4fabaec-de71-4548-9be4-593740406a42"), new Guid("8abda747-e0fc-4637-8d8c-80a39596305c"), null, "Монография" },
                    { new Guid("da567823-1736-4188-b0e8-92371b70d2d6"), new Guid("9da25b3c-d28a-49d0-a2ba-7ad3522d8b16"), null, "Руководитель" },
                    { new Guid("ea0cbd5b-9115-41ac-87a4-e08171eda557"), new Guid("8abda747-e0fc-4637-8d8c-80a39596305c"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("ee359eb3-df8b-4f56-9a85-56a52ef2c280"), new Guid("72d859c8-f484-4b45-acc6-5527802d7768"), null, "Полезная модель" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_ApplicationStatusId",
                table: "ApplicationForms",
                column: "ApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_ReviewerId",
                table: "ApplicationForms",
                column: "ReviewerId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_TrackId",
                table: "ApplicationForms",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_UserInfoId",
                table: "ApplicationForms",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationStatuses_Status",
                table: "ApplicationStatuses",
                column: "Status",
                unique: true);

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
                name: "IX_BlockReviews_ApplicationId",
                table: "BlockReviews",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_BlockReviews_MarkBlockId",
                table: "BlockReviews",
                column: "MarkBlockId");

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
                name: "BlockReviews");

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
                name: "ApplicationStatuses");

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
