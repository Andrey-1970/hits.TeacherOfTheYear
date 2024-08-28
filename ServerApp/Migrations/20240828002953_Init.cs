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
                    { new Guid("53fafd97-0097-4dae-8cc8-5cd76e7aa218"), 1, "В ожидании заполнения" },
                    { new Guid("799295a8-c1e1-4d50-acde-97f93d930652"), 5, "Отклонена" },
                    { new Guid("79a33e64-dd1a-45f6-b355-409f8fbe29e1"), 4, "Одобрена" },
                    { new Guid("cd20811b-c11a-43a9-a3d5-59291629e1c9"), 3, "В процессе оценки" },
                    { new Guid("ce8d46d4-4487-4586-afed-3656f1d97b0a"), 2, "В ожидании оценки" }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("3ab1cb64-741b-4c64-a527-62424d60488b"), "Категория участников", 2 },
                    { new Guid("7b73eed8-acf7-4b6f-aa1f-10de2d08f538"), "Деятельность", 4 },
                    { new Guid("cb0e515f-a19d-4efd-88c3-ac1abadcaee8"), "Профессиональное развитие", 3 },
                    { new Guid("ed6f8756-d096-4817-9495-59b677e00bfb"), "Деятельность", 5 },
                    { new Guid("f6f208d6-05e4-4177-96e7-1124cc67c1cd"), "Общая информация", 1 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("448d588e-6d55-4444-a6fa-6fc1bf94d73c"), "Методическая деятельность", 3 },
                    { new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76"), "Основной", 1 },
                    { new Guid("8599e9e0-0a48-428a-aeaf-3b6dc78a8eb3"), "Конкурсная работа", 7 },
                    { new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6"), "Образовательная деятельность", 2 },
                    { new Guid("afee9c43-ee38-4153-9061-596062709fe8"), "Профессиональные показатели", 4 },
                    { new Guid("c8e63b5b-ac96-4de8-82b5-0df344c35c6f"), "Инновационная и иная деятельность", 6 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("3fce6540-b38d-4080-9cb6-7156b4f79c51"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("638f22e5-059f-4c13-ad9b-eebc864f860c"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("aa71cc0e-6e85-4cc3-bb6c-3e41c56b3bc1"), "User 1", "admin@mail.ru" },
                    { new Guid("ec898e8c-0ffe-4569-aa5c-abd1f65b2c8b"), "User 2", "user@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00255929-0aca-4307-8ffe-400a1b860bf3"), "bool" },
                    { new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db"), "string" },
                    { new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0"), "int" },
                    { new Guid("750fda1f-a7df-4aee-a625-3712ce6efde9"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("3ab1cb64-741b-4c64-a527-62424d60488b"), new Guid("3fce6540-b38d-4080-9cb6-7156b4f79c51") },
                    { new Guid("3ab1cb64-741b-4c64-a527-62424d60488b"), new Guid("638f22e5-059f-4c13-ad9b-eebc864f860c") },
                    { new Guid("7b73eed8-acf7-4b6f-aa1f-10de2d08f538"), new Guid("638f22e5-059f-4c13-ad9b-eebc864f860c") },
                    { new Guid("cb0e515f-a19d-4efd-88c3-ac1abadcaee8"), new Guid("3fce6540-b38d-4080-9cb6-7156b4f79c51") },
                    { new Guid("cb0e515f-a19d-4efd-88c3-ac1abadcaee8"), new Guid("638f22e5-059f-4c13-ad9b-eebc864f860c") },
                    { new Guid("ed6f8756-d096-4817-9495-59b677e00bfb"), new Guid("3fce6540-b38d-4080-9cb6-7156b4f79c51") },
                    { new Guid("f6f208d6-05e4-4177-96e7-1124cc67c1cd"), new Guid("3fce6540-b38d-4080-9cb6-7156b4f79c51") },
                    { new Guid("f6f208d6-05e4-4177-96e7-1124cc67c1cd"), new Guid("638f22e5-059f-4c13-ad9b-eebc864f860c") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "Name", "Number", "Placeholder", "Required", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("1038291c-d401-4ef7-8da6-26b89bf3d0bd"), new Guid("7b73eed8-acf7-4b6f-aa1f-10de2d08f538"), null, "Защитившиеся магистры", 23, "Введите количество", true, new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("236ccdc8-2ecb-42ed-9d12-4b2991261bdd"), new Guid("7b73eed8-acf7-4b6f-aa1f-10de2d08f538"), "Руководство дипломными проектами за предыдущий учебный год", "Защитившиеся бакалавры", 21, "Введите количество", true, new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("24153a28-3dd9-4dc5-9ecd-b40ac068a829"), new Guid("3ab1cb64-741b-4c64-a527-62424d60488b"), null, "Ученая степень", 17, "Выберите ученую степень", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("25f16c99-3731-4287-9dac-067c376cb26f"), new Guid("f6f208d6-05e4-4177-96e7-1124cc67c1cd"), null, "Должность", 9, "Введите свою должность в организации", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("2bc68211-58a8-4904-9dd6-e734e141c976"), new Guid("f6f208d6-05e4-4177-96e7-1124cc67c1cd"), null, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("3d9f1e55-5cc4-44c8-9d5c-c60e34949368"), new Guid("3ab1cb64-741b-4c64-a527-62424d60488b"), null, "Направление конкурса", 12, "Выберите направление конкурса", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("4c9bc5e8-5d97-48bb-9690-85d4a8c9ba57"), new Guid("f6f208d6-05e4-4177-96e7-1124cc67c1cd"), null, "Дата рождения", 2, "01.01.2000", true, new Guid("750fda1f-a7df-4aee-a625-3712ce6efde9") },
                    { new Guid("53e34663-67cf-4f24-9f84-7ae25885ce45"), new Guid("3ab1cb64-741b-4c64-a527-62424d60488b"), null, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 13, "Выберите категорию участника конкруса", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("60151047-1788-47d1-8c1d-3950077bf7c1"), new Guid("3ab1cb64-741b-4c64-a527-62424d60488b"), null, "Ссылка на конкурсную работу", 15, "Введите ссылку своей конкурсной работы", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("680c8ca9-d78c-468c-9e4f-f349de65b6f4"), new Guid("3ab1cb64-741b-4c64-a527-62424d60488b"), null, "Название конкурсной работы", 14, "Введите название своей конкурсной работы", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("79247708-b1bc-4a7b-a6ce-e18212287494"), new Guid("ed6f8756-d096-4817-9495-59b677e00bfb"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", "Защитившиеся кандидаты наук", 24, "Введите количество", true, new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("83039f24-2d02-43f7-af16-9af12fea01bd"), new Guid("f6f208d6-05e4-4177-96e7-1124cc67c1cd"), null, "Электронная почта", 5, "user@example.com", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("87e1622f-0d54-45ca-be1a-929a80900dfe"), new Guid("f6f208d6-05e4-4177-96e7-1124cc67c1cd"), null, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("a0708591-82d3-4002-a66c-ef450af6ffec"), new Guid("f6f208d6-05e4-4177-96e7-1124cc67c1cd"), null, "ФИО", 1, "Иванов Иван Иванович", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("a0b3598d-5fe6-4e39-b494-428da6ae1dc9"), new Guid("7b73eed8-acf7-4b6f-aa1f-10de2d08f538"), null, "Защитившиеся доктора наук", 20, "Введите количество", true, new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("a6020b7c-3e13-4939-b64f-9c594be851b0"), new Guid("3ab1cb64-741b-4c64-a527-62424d60488b"), null, "Ученое звание", 16, "Выберите ученое звание", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("a61a75f3-81af-422c-9221-70ca1a254690"), new Guid("f6f208d6-05e4-4177-96e7-1124cc67c1cd"), null, "Место работы/учебы", 6, "Название организации", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("aa3afe96-a2c4-423c-ba6f-64227a20e929"), new Guid("7b73eed8-acf7-4b6f-aa1f-10de2d08f538"), null, "Защитившиеся специалисты", 22, "Введите количество", true, new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("b9810768-e49b-44fb-ad22-405f21f420c8"), new Guid("f6f208d6-05e4-4177-96e7-1124cc67c1cd"), null, "Адрес работы/учебы", 7, "Регион, город, улица, дом", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("bb895263-f2bc-4085-97b0-905a9a7528d4"), new Guid("7b73eed8-acf7-4b6f-aa1f-10de2d08f538"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", "Защитившиеся кадидаты наук", 19, "Введите количество", true, new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("bcc1456b-d6c7-4b0f-b86d-660e9f02bc9c"), new Guid("ed6f8756-d096-4817-9495-59b677e00bfb"), null, "Защитившиеся доктора наук", 25, "Введите количество", true, new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("c466f247-3e83-4edf-8f93-246c668aafc2"), new Guid("f6f208d6-05e4-4177-96e7-1124cc67c1cd"), null, "Дополнительная информация", 11, "Пример", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("d2252b24-d6e3-4cd6-8053-1ceeb27b61f0"), new Guid("3ab1cb64-741b-4c64-a527-62424d60488b"), null, "Научная специальность (по классификации ВАК)", 18, "Введите научную специальность (по классификации ВАК)", true, new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("d5933286-57b3-457d-abe9-14508b9744a6"), new Guid("f6f208d6-05e4-4177-96e7-1124cc67c1cd"), null, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", true, new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("e07ec0b3-c45f-4f72-9043-9334a7bad6a6"), new Guid("f6f208d6-05e4-4177-96e7-1124cc67c1cd"), null, "Контактный телефон", 4, "+8 (900)-000-00-00", true, new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), new Guid("3fce6540-b38d-4080-9cb6-7156b4f79c51") },
                    { new Guid("448d588e-6d55-4444-a6fa-6fc1bf94d73c"), new Guid("638f22e5-059f-4c13-ad9b-eebc864f860c") },
                    { new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76"), new Guid("3fce6540-b38d-4080-9cb6-7156b4f79c51") },
                    { new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76"), new Guid("638f22e5-059f-4c13-ad9b-eebc864f860c") },
                    { new Guid("8599e9e0-0a48-428a-aeaf-3b6dc78a8eb3"), new Guid("3fce6540-b38d-4080-9cb6-7156b4f79c51") },
                    { new Guid("8599e9e0-0a48-428a-aeaf-3b6dc78a8eb3"), new Guid("638f22e5-059f-4c13-ad9b-eebc864f860c") },
                    { new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6"), new Guid("638f22e5-059f-4c13-ad9b-eebc864f860c") },
                    { new Guid("afee9c43-ee38-4153-9061-596062709fe8"), new Guid("638f22e5-059f-4c13-ad9b-eebc864f860c") },
                    { new Guid("c8e63b5b-ac96-4de8-82b5-0df344c35c6f"), new Guid("3fce6540-b38d-4080-9cb6-7156b4f79c51") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("049dc36c-4b31-44ec-bab9-d3fb409543a9"), new Guid("7b73eed8-acf7-4b6f-aa1f-10de2d08f538"), false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("0c3bb598-0218-46fa-b24b-53d4a4e46535"), new Guid("cb0e515f-a19d-4efd-88c3-ac1abadcaee8"), false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("3d8bf1f0-fb5d-4142-af8b-c231f1cb296e"), new Guid("7b73eed8-acf7-4b6f-aa1f-10de2d08f538"), false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("4aa4fa56-0bda-4312-8388-3f978031d3ea"), new Guid("7b73eed8-acf7-4b6f-aa1f-10de2d08f538"), false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("549d0439-d7f2-4003-8c86-0dbb0b1e5fec"), new Guid("ed6f8756-d096-4817-9495-59b677e00bfb"), false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("69876ab7-bc4f-43ca-94a6-8db187720dee"), new Guid("cb0e515f-a19d-4efd-88c3-ac1abadcaee8"), false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("7592f6e1-cb5a-4f0a-aaff-b8acc4272fdb"), new Guid("ed6f8756-d096-4817-9495-59b677e00bfb"), false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("77036d62-4f64-42e3-827c-c3099bfe3d14"), new Guid("7b73eed8-acf7-4b6f-aa1f-10de2d08f538"), false, "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 },
                    { new Guid("a3526b25-1f61-4ff0-87c4-71171c0371d1"), new Guid("7b73eed8-acf7-4b6f-aa1f-10de2d08f538"), false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("c67fb5a3-1e7b-4b61-ab7c-edc251944aed"), new Guid("ed6f8756-d096-4817-9495-59b677e00bfb"), false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("c883cc1b-0685-4818-ac51-28fff13b8a12"), new Guid("7b73eed8-acf7-4b6f-aa1f-10de2d08f538"), false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("d965992c-18f9-47a8-a697-6769e455c376"), new Guid("ed6f8756-d096-4817-9495-59b677e00bfb"), false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4"), new Guid("ed6f8756-d096-4817-9495-59b677e00bfb"), true, "Персональные идентификаторы и показатели", 10 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("00f2fe20-620b-4d40-a4d9-f8b1cdd9255e"), "Лекции (час.)", 3, new Guid("049dc36c-4b31-44ec-bab9-d3fb409543a9"), new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("01505f8a-8657-4a9a-b2bb-543d7f7fb3f5"), "Идентификатор", 2, new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("01c00c04-cee2-4565-8436-124cd26bd069"), "Количество часов", 4, new Guid("3d8bf1f0-fb5d-4142-af8b-c231f1cb296e"), new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("01c974ea-0ca9-4547-b568-fd8b7f8e7862"), "Номер РИД", 4, new Guid("d965992c-18f9-47a8-a697-6769e455c376"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("07366a10-866a-463e-911f-cff24a2aad77"), "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("a3526b25-1f61-4ff0-87c4-71171c0371d1"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("0f15ef2d-2318-4a14-b8f7-c8b120315c02"), "Количество публикаций в БАЗЕ", 3, new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4"), new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("1303743c-934c-4c1e-8fbc-98d9770c83c1"), "Вид", 1, new Guid("d965992c-18f9-47a8-a697-6769e455c376"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("145d1bf8-282d-4659-a20c-5e36539a72e3"), "Статус конкурса", 3, new Guid("69876ab7-bc4f-43ca-94a6-8db187720dee"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("2976257f-404f-49f0-ba16-32d90903864d"), "Название", 2, new Guid("77036d62-4f64-42e3-827c-c3099bfe3d14"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("2a215c4b-00aa-4447-876b-fef35c34d738"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("549d0439-d7f2-4003-8c86-0dbb0b1e5fec"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("2c4d67d4-0556-44ef-a18c-eb955626e77c"), "Год", 1, new Guid("69876ab7-bc4f-43ca-94a6-8db187720dee"), new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("2fd5a6bc-d998-4f29-bc8d-4c36610c6d5f"), "Соавторы", 2, new Guid("c883cc1b-0685-4818-ac51-28fff13b8a12"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("325b1081-b720-4a7e-a16f-4e956145f232"), "Награда", 4, new Guid("69876ab7-bc4f-43ca-94a6-8db187720dee"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("3e12c421-00a4-4c62-84b0-e5d0c35455f5"), "Вид (лекции, лабораторные)", 2, new Guid("4aa4fa56-0bda-4312-8388-3f978031d3ea"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("3e1eb288-996d-4114-979c-511ed4aab425"), "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("7592f6e1-cb5a-4f0a-aaff-b8acc4272fdb"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("49efafaa-ce2f-463f-b1c2-e07b7fadb949"), "Сумма финансирования (тыс. руб.)", 2, new Guid("549d0439-d7f2-4003-8c86-0dbb0b1e5fec"), new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("5503d20c-86d6-42ea-b160-f0cef40385d1"), "Практические занятия (час.)", 4, new Guid("049dc36c-4b31-44ec-bab9-d3fb409543a9"), new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("5986aacf-5022-442b-b6dd-b8368da4d862"), "Название конкурса/премии", 2, new Guid("a3526b25-1f61-4ff0-87c4-71171c0371d1"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("60492c2d-5aae-4349-a322-dc7cbf0e9bb9"), "Название статьи", 1, new Guid("7592f6e1-cb5a-4f0a-aaff-b8acc4272fdb"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("60c0b241-4778-4d44-bc70-c2b73a80421e"), "Название разработки", 2, new Guid("c67fb5a3-1e7b-4b61-ab7c-edc251944aed"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("61ceb646-7c2d-4a7b-b9b3-69dd739eaa66"), "Итого (час.)", 5, new Guid("049dc36c-4b31-44ec-bab9-d3fb409543a9"), new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("66b2913f-851d-4c74-b4e1-f60a8daeea13"), "Наличие грифа", 5, new Guid("77036d62-4f64-42e3-827c-c3099bfe3d14"), new Guid("00255929-0aca-4307-8ffe-400a1b860bf3") },
                    { new Guid("6aea5ed3-4560-4ad7-a207-bf6581d12fe2"), "Год", 4, new Guid("c883cc1b-0685-4818-ac51-28fff13b8a12"), new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("6d663b1e-f1a3-42d9-a75d-38851b1062ad"), "Тип идентификатора", 1, new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("6e2bfac7-5072-400e-9d93-498b30a7065f"), "Соавторы", 3, new Guid("77036d62-4f64-42e3-827c-c3099bfe3d14"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("793fe059-c633-478f-a9a5-73d4fc0ed520"), "Количество печатных листов", 4, new Guid("77036d62-4f64-42e3-827c-c3099bfe3d14"), new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("7baa2549-a917-4cbc-bbcf-382788fb2f0e"), "Название организации в которую внедрена разработка", 3, new Guid("c67fb5a3-1e7b-4b61-ab7c-edc251944aed"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("7e236849-ef4f-4d5a-8859-ae203994d0cf"), "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("3d8bf1f0-fb5d-4142-af8b-c231f1cb296e"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("8168192f-e615-4b65-83fb-50d26af4c5b8"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("a3526b25-1f61-4ff0-87c4-71171c0371d1"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("8520b6e7-63a8-4f47-a55b-2e6256e8ede8"), "Ссылка на платформу", 3, new Guid("c883cc1b-0685-4818-ac51-28fff13b8a12"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("899dde80-ad49-4ee7-891e-cd2317363c34"), "ФИО", 1, new Guid("a3526b25-1f61-4ff0-87c4-71171c0371d1"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("8b440393-a184-4cba-9c8f-93ba977bd834"), "Название", 2, new Guid("d965992c-18f9-47a8-a697-6769e455c376"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("8e6a3bce-f385-4249-a9ae-5f43d12f2186"), "Название конкурса", 2, new Guid("69876ab7-bc4f-43ca-94a6-8db187720dee"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("98de022d-26ba-4b9b-bd93-c2604864e1eb"), "Название документа, реквизиты", 1, new Guid("0c3bb598-0218-46fa-b24b-53d4a4e46535"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("9995df9a-09c7-40eb-b874-443b18257340"), "Год", 3, new Guid("a3526b25-1f61-4ff0-87c4-71171c0371d1"), new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("9a2067e1-be79-4fa6-a7d9-8a966b55e140"), "Название дисциплины", 1, new Guid("4aa4fa56-0bda-4312-8388-3f978031d3ea"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("b5feda2c-47a9-4990-b080-c29762acffca"), "Вид деятельности (преподавательская)", 3, new Guid("3d8bf1f0-fb5d-4142-af8b-c231f1cb296e"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("b5ff82b4-1230-4804-bcc2-744a3ad753e1"), "Период выполнения", 3, new Guid("549d0439-d7f2-4003-8c86-0dbb0b1e5fec"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("b9487f31-6e54-479e-b37a-b1c0df06ca03"), "Наименование курса", 1, new Guid("049dc36c-4b31-44ec-bab9-d3fb409543a9"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("cb4393d1-d964-4734-a031-e8ed113ca0d9"), "Год получения документа", 2, new Guid("0c3bb598-0218-46fa-b24b-53d4a4e46535"), new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("cf78f79f-444f-4700-92d2-b3dc53e05439"), "Издательство, год", 6, new Guid("77036d62-4f64-42e3-827c-c3099bfe3d14"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("d6c6f008-a07d-40f2-ab35-f5b952611451"), "Язык преподавания (русск./англ./др.)", 2, new Guid("049dc36c-4b31-44ec-bab9-d3fb409543a9"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("d883b050-f9ca-4f5d-bfe5-9205a31a745d"), "Название курса", 1, new Guid("c883cc1b-0685-4818-ac51-28fff13b8a12"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("d9e8680c-23a5-413a-b70a-162c3b51c2cd"), "Статус (руководитель/исполнитель)", 4, new Guid("549d0439-d7f2-4003-8c86-0dbb0b1e5fec"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("dc799ce1-69db-439d-b6c3-139d12af4d6b"), "Название НИР/НИОКР", 1, new Guid("549d0439-d7f2-4003-8c86-0dbb0b1e5fec"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("e5a7f8d2-2a17-4f1f-848e-37ab7dcd599f"), "Количество цитирований", 4, new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4"), new Guid("72a4639a-b715-4e0b-9db9-0e0437f627c0") },
                    { new Guid("e6d6a875-f4c1-4fc9-9d05-752f43fb0fcf"), "Ссылка", 5, new Guid("69876ab7-bc4f-43ca-94a6-8db187720dee"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("ec090a2b-f734-4feb-9ddf-e72790c21bb3"), "Индекс Хирша (за все время)", 5, new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("efae1d77-237f-4ca3-ab8b-966063822391"), "Название организации/должность/ставка", 1, new Guid("3d8bf1f0-fb5d-4142-af8b-c231f1cb296e"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("f13d9045-f44b-4b5c-817c-ff17a13f978f"), "Издание, год", 4, new Guid("7592f6e1-cb5a-4f0a-aaff-b8acc4272fdb"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("f163e47c-cb99-4f02-91c7-874ff14306aa"), "Соавторы", 2, new Guid("7592f6e1-cb5a-4f0a-aaff-b8acc4272fdb"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("f2f4f4e6-3b61-4319-9065-37d64960c3f9"), "Вид публикации", 1, new Guid("77036d62-4f64-42e3-827c-c3099bfe3d14"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("fd1e1869-3b47-4f9f-b40b-a8a81cf99bd8"), "ФИО соавторов", 3, new Guid("d965992c-18f9-47a8-a697-6769e455c376"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") },
                    { new Guid("fe7d309f-7efa-4797-9a44-8a8b9ca8dc50"), "Вид", 1, new Guid("c67fb5a3-1e7b-4b61-ab7c-edc251944aed"), new Guid("6672c7ec-deca-4cb1-bb9d-2d61a0a557db") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("1038291c-d401-4ef7-8da6-26b89bf3d0bd"), new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6") },
                    { new Guid("236ccdc8-2ecb-42ed-9d12-4b2991261bdd"), new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6") },
                    { new Guid("24153a28-3dd9-4dc5-9ecd-b40ac068a829"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("25f16c99-3731-4287-9dac-067c376cb26f"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("2bc68211-58a8-4904-9dd6-e734e141c976"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("3d9f1e55-5cc4-44c8-9d5c-c60e34949368"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("4c9bc5e8-5d97-48bb-9690-85d4a8c9ba57"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("53e34663-67cf-4f24-9f84-7ae25885ce45"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("60151047-1788-47d1-8c1d-3950077bf7c1"), new Guid("8599e9e0-0a48-428a-aeaf-3b6dc78a8eb3") },
                    { new Guid("680c8ca9-d78c-468c-9e4f-f349de65b6f4"), new Guid("8599e9e0-0a48-428a-aeaf-3b6dc78a8eb3") },
                    { new Guid("79247708-b1bc-4a7b-a6ce-e18212287494"), new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207") },
                    { new Guid("83039f24-2d02-43f7-af16-9af12fea01bd"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("87e1622f-0d54-45ca-be1a-929a80900dfe"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("a0708591-82d3-4002-a66c-ef450af6ffec"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("a0b3598d-5fe6-4e39-b494-428da6ae1dc9"), new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6") },
                    { new Guid("a6020b7c-3e13-4939-b64f-9c594be851b0"), new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207") },
                    { new Guid("a6020b7c-3e13-4939-b64f-9c594be851b0"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("a6020b7c-3e13-4939-b64f-9c594be851b0"), new Guid("afee9c43-ee38-4153-9061-596062709fe8") },
                    { new Guid("a61a75f3-81af-422c-9221-70ca1a254690"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("aa3afe96-a2c4-423c-ba6f-64227a20e929"), new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6") },
                    { new Guid("b9810768-e49b-44fb-ad22-405f21f420c8"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("bb895263-f2bc-4085-97b0-905a9a7528d4"), new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6") },
                    { new Guid("bcc1456b-d6c7-4b0f-b86d-660e9f02bc9c"), new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207") },
                    { new Guid("c466f247-3e83-4edf-8f93-246c668aafc2"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("d2252b24-d6e3-4cd6-8053-1ceeb27b61f0"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("d5933286-57b3-457d-abe9-14508b9744a6"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") },
                    { new Guid("e07ec0b3-c45f-4f72-9043-9334a7bad6a6"), new Guid("53576cc5-e196-454a-9609-1f6ad0a7ea76") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), new Guid("549d0439-d7f2-4003-8c86-0dbb0b1e5fec") },
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), new Guid("69876ab7-bc4f-43ca-94a6-8db187720dee") },
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), new Guid("7592f6e1-cb5a-4f0a-aaff-b8acc4272fdb") },
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4") },
                    { new Guid("448d588e-6d55-4444-a6fa-6fc1bf94d73c"), new Guid("4aa4fa56-0bda-4312-8388-3f978031d3ea") },
                    { new Guid("448d588e-6d55-4444-a6fa-6fc1bf94d73c"), new Guid("77036d62-4f64-42e3-827c-c3099bfe3d14") },
                    { new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6"), new Guid("049dc36c-4b31-44ec-bab9-d3fb409543a9") },
                    { new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6"), new Guid("3d8bf1f0-fb5d-4142-af8b-c231f1cb296e") },
                    { new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6"), new Guid("a3526b25-1f61-4ff0-87c4-71171c0371d1") },
                    { new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6"), new Guid("c883cc1b-0685-4818-ac51-28fff13b8a12") },
                    { new Guid("afee9c43-ee38-4153-9061-596062709fe8"), new Guid("0c3bb598-0218-46fa-b24b-53d4a4e46535") },
                    { new Guid("afee9c43-ee38-4153-9061-596062709fe8"), new Guid("69876ab7-bc4f-43ca-94a6-8db187720dee") },
                    { new Guid("c8e63b5b-ac96-4de8-82b5-0df344c35c6f"), new Guid("0c3bb598-0218-46fa-b24b-53d4a4e46535") },
                    { new Guid("c8e63b5b-ac96-4de8-82b5-0df344c35c6f"), new Guid("c67fb5a3-1e7b-4b61-ab7c-edc251944aed") },
                    { new Guid("c8e63b5b-ac96-4de8-82b5-0df344c35c6f"), new Guid("d965992c-18f9-47a8-a697-6769e455c376") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("096ab423-0559-4d6b-aa8b-ab976b00954a"), null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("d965992c-18f9-47a8-a697-6769e455c376") },
                    { new Guid("1cd86cc8-539e-4799-aad2-e7fd7704141e"), null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("77036d62-4f64-42e3-827c-c3099bfe3d14") },
                    { new Guid("43f494df-c99d-4f82-9ffc-0713fa1d74cf"), new Guid("60151047-1788-47d1-8c1d-3950077bf7c1"), false, 10, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("44dfe9e5-d810-4aa8-b6ea-ac442ec10a90"), null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("77036d62-4f64-42e3-827c-c3099bfe3d14") },
                    { new Guid("49f92943-f7c9-4002-8a19-03178dfb3f34"), null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("0c3bb598-0218-46fa-b24b-53d4a4e46535") },
                    { new Guid("4be287a4-f3bf-4d54-b056-7e7efaec962e"), new Guid("60151047-1788-47d1-8c1d-3950077bf7c1"), false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null },
                    { new Guid("4fcc0300-7943-4b6c-a136-08fc2e913de0"), null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("77036d62-4f64-42e3-827c-c3099bfe3d14") },
                    { new Guid("5c839daf-a544-4e99-bab4-37caef86dc6c"), null, true, 5, "Баллы за количество разработок:", 24, new Guid("c67fb5a3-1e7b-4b61-ab7c-edc251944aed") },
                    { new Guid("5e198322-3fda-4caf-ab25-0bfe25bbdce0"), new Guid("bb895263-f2bc-4085-97b0-905a9a7528d4"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("6342b89d-4929-46b9-a738-38bd985f598c"), null, true, 3, "Баллы по базе РИНЦ:", 18, new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4") },
                    { new Guid("6462ae78-a08c-465f-a790-c21746993cb4"), null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("77036d62-4f64-42e3-827c-c3099bfe3d14") },
                    { new Guid("69c1fd01-14b8-4dc1-8db0-45a1706fc6bc"), new Guid("a6020b7c-3e13-4939-b64f-9c594be851b0"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("69f393c4-53e6-4310-ab7b-663a8da92446"), null, true, 5, "Баллы за научные публикации:", 16, new Guid("7592f6e1-cb5a-4f0a-aaff-b8acc4272fdb") },
                    { new Guid("70e10b54-3408-4522-a747-fc1d114d4bae"), null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("4aa4fa56-0bda-4312-8388-3f978031d3ea") },
                    { new Guid("7f0650f2-af26-4faf-b9a7-0d70c8e52770"), new Guid("bcc1456b-d6c7-4b0f-b86d-660e9f02bc9c"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("879d5f66-37a4-46aa-8bff-470cbf95d79c"), null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("549d0439-d7f2-4003-8c86-0dbb0b1e5fec") },
                    { new Guid("9407309c-164f-4d63-a587-9b1e74906d9c"), null, true, 2, "Баллы за награды:", 14, new Guid("69876ab7-bc4f-43ca-94a6-8db187720dee") },
                    { new Guid("96f3d373-7bc9-4ada-a8c0-1306ab6f87fc"), null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("049dc36c-4b31-44ec-bab9-d3fb409543a9") },
                    { new Guid("b02b312a-c23d-4c3b-9669-d77533960bf1"), new Guid("1038291c-d401-4ef7-8da6-26b89bf3d0bd"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("b267bf90-cd28-4eb6-abda-22915d6043bc"), new Guid("a0b3598d-5fe6-4e39-b494-428da6ae1dc9"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("c40f5636-a237-4d0f-999d-6ce67dd746f3"), null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("c883cc1b-0685-4818-ac51-28fff13b8a12") },
                    { new Guid("c5a8d8df-5a88-4b44-b225-f04040c6e195"), null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("549d0439-d7f2-4003-8c86-0dbb0b1e5fec") },
                    { new Guid("ca44d760-d67c-469d-8e92-4980e0c1b863"), null, true, 5, "Баллы по базе Scopus:", 17, new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4") },
                    { new Guid("dc951339-f822-4928-bf8c-b4b23df10fc3"), null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("049dc36c-4b31-44ec-bab9-d3fb409543a9") },
                    { new Guid("e8d70c40-572f-4f8c-a67e-91c9e01f1c1f"), null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("a3526b25-1f61-4ff0-87c4-71171c0371d1") },
                    { new Guid("f4a3e830-f911-4b4e-82fb-ec95c6524689"), new Guid("79247708-b1bc-4a7b-a6ce-e18212287494"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("0799f7a2-9dda-4aab-b5c8-4703e7dd2bd7"), true, new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4") },
                    { new Guid("0ea9f22f-cb65-4941-914c-91ade32fbd15"), true, new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4") },
                    { new Guid("4bfa703e-df22-48d0-a7dd-3e310b34c39f"), true, new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4") },
                    { new Guid("50e90541-acc0-4d38-beb4-a5dd72557697"), true, new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4") },
                    { new Guid("648e2a02-23ef-4228-a45c-aa151d2c6cd7"), true, new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4") },
                    { new Guid("70602ec1-b379-490d-ac54-23cab0cc35c7"), true, new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4") },
                    { new Guid("7664222c-1a0c-45e7-a629-e50967dd516b"), true, new Guid("e19c73af-d852-4bf9-b1b5-3f70228801d4") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("2f35c84f-4211-4342-8984-0e758d6ac498"), null, new Guid("3d9f1e55-5cc4-44c8-9d5c-c60e34949368"), "АРХИТЕКТУРА" },
                    { new Guid("36718784-bfb1-45bf-b27a-9d1d6dd910b9"), null, new Guid("3d9f1e55-5cc4-44c8-9d5c-c60e34949368"), "ЭЛЕКТРО- И ТЕПЛОЭНЕРГЕТИКА" },
                    { new Guid("56ffb284-e4f9-451a-93b1-42d0145550ff"), null, new Guid("3d9f1e55-5cc4-44c8-9d5c-c60e34949368"), "ПРИКЛАДНАЯ ГЕОЛОГИЯ, ГОРНОЕ ДЕЛО, НЕФТЕГАЗОВОЕ ДЕЛО И ГЕОДЕЗИЯ" },
                    { new Guid("5ca9e8a4-8200-4693-970b-ba13acf94671"), null, new Guid("a6020b7c-3e13-4939-b64f-9c594be851b0"), "Доцент" },
                    { new Guid("6d524d0f-7b90-4834-aa33-5d24999c6b49"), null, new Guid("53e34663-67cf-4f24-9f84-7ae25885ce45"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("8c709f77-d892-40a1-8959-f78469ef1422"), null, new Guid("53e34663-67cf-4f24-9f84-7ae25885ce45"), "Имеющие ученую степень доктора наук" },
                    { new Guid("9ef8d7eb-9efb-4cac-8712-04ebe21b6b6a"), null, new Guid("a6020b7c-3e13-4939-b64f-9c594be851b0"), "Профессор" },
                    { new Guid("a32df049-3817-4aab-8dd5-996eafe88520"), null, new Guid("a6020b7c-3e13-4939-b64f-9c594be851b0"), "Нет" },
                    { new Guid("b8731e5e-70df-4828-8231-7b262aee35b6"), null, new Guid("53e34663-67cf-4f24-9f84-7ae25885ce45"), "Аспиранты, адъюнкты, ординаторы, ассистенты-стажеры, не имеющие ученой степени" },
                    { new Guid("de60cf77-32e5-49e9-b7c7-7e17f790c536"), null, new Guid("3d9f1e55-5cc4-44c8-9d5c-c60e34949368"), "ТЕХНИКА И ТЕХНОЛОГИИ СТРОИТЕЛЬСТВА" },
                    { new Guid("de857314-b24c-4105-b7db-910be8840476"), null, new Guid("3d9f1e55-5cc4-44c8-9d5c-c60e34949368"), "НЕДРОПОЛЬЗОВАНИЕ И ГОРНЫЕ НАУКИ" },
                    { new Guid("fb573cf7-26de-46d5-bda7-76608bfd2205"), null, new Guid("3d9f1e55-5cc4-44c8-9d5c-c60e34949368"), "СТРОИТЕЛЬСТВО И АРХИТЕКТУРА" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("014aea25-33f0-4e2d-bddd-3b1cbfa2ca54"), null, new Guid("01505f8a-8657-4a9a-b2bb-543d7f7fb3f5"), false, true, new Guid("70602ec1-b379-490d-ac54-23cab0cc35c7"), null },
                    { new Guid("0956db95-9f1d-4388-aef0-e3f386fd0c47"), null, new Guid("6d663b1e-f1a3-42d9-a75d-38851b1062ad"), true, true, new Guid("4bfa703e-df22-48d0-a7dd-3e310b34c39f"), "ORCiD" },
                    { new Guid("10075280-0a5a-46d4-b818-0b5b11e1ec5c"), null, new Guid("6d663b1e-f1a3-42d9-a75d-38851b1062ad"), true, true, new Guid("0799f7a2-9dda-4aab-b5c8-4703e7dd2bd7"), "Количество патентов" },
                    { new Guid("19559ed4-e43b-4375-b590-e7a34ca5d860"), null, new Guid("e5a7f8d2-2a17-4f1f-848e-37ab7dcd599f"), false, true, new Guid("7664222c-1a0c-45e7-a629-e50967dd516b"), null },
                    { new Guid("1e9d3863-1fe4-40e3-af66-2944470525da"), null, new Guid("6d663b1e-f1a3-42d9-a75d-38851b1062ad"), true, true, new Guid("50e90541-acc0-4d38-beb4-a5dd72557697"), "Количество монографий/глав в монографии" },
                    { new Guid("322f717c-eb8e-43bd-b058-21b5c4d489e4"), null, new Guid("0f15ef2d-2318-4a14-b8f7-c8b120315c02"), false, true, new Guid("50e90541-acc0-4d38-beb4-a5dd72557697"), null },
                    { new Guid("364f62ae-1de7-48d5-bb58-1c532cd6ce03"), null, new Guid("6d663b1e-f1a3-42d9-a75d-38851b1062ad"), true, true, new Guid("70602ec1-b379-490d-ac54-23cab0cc35c7"), "ResearcherID" },
                    { new Guid("4785a2f1-c30f-4ba2-9347-122a60340dbe"), null, new Guid("ec090a2b-f734-4feb-9ddf-e72790c21bb3"), true, true, new Guid("0799f7a2-9dda-4aab-b5c8-4703e7dd2bd7"), null },
                    { new Guid("47d95954-393b-4b43-b1d4-3d7b7fc293b7"), null, new Guid("6d663b1e-f1a3-42d9-a75d-38851b1062ad"), true, true, new Guid("648e2a02-23ef-4228-a45c-aa151d2c6cd7"), "ScopusID" },
                    { new Guid("48c13524-c78d-4656-acab-72131e5948ad"), null, new Guid("e5a7f8d2-2a17-4f1f-848e-37ab7dcd599f"), false, true, new Guid("0ea9f22f-cb65-4941-914c-91ade32fbd15"), null },
                    { new Guid("50e77ba2-6907-4c59-817f-2cc25a5192ec"), null, new Guid("0f15ef2d-2318-4a14-b8f7-c8b120315c02"), false, true, new Guid("648e2a02-23ef-4228-a45c-aa151d2c6cd7"), null },
                    { new Guid("56d65788-df92-4bcd-9fdb-b9dbf9c523f9"), null, new Guid("e5a7f8d2-2a17-4f1f-848e-37ab7dcd599f"), false, true, new Guid("70602ec1-b379-490d-ac54-23cab0cc35c7"), null },
                    { new Guid("5b2b0e8e-5757-4ce1-83c5-27872e73e91d"), null, new Guid("e5a7f8d2-2a17-4f1f-848e-37ab7dcd599f"), false, true, new Guid("50e90541-acc0-4d38-beb4-a5dd72557697"), null },
                    { new Guid("6f2fac03-41fe-440c-86c5-701c4719c767"), null, new Guid("0f15ef2d-2318-4a14-b8f7-c8b120315c02"), false, true, new Guid("0ea9f22f-cb65-4941-914c-91ade32fbd15"), null },
                    { new Guid("70c2d278-6807-43e7-822a-7fb9e2537947"), null, new Guid("e5a7f8d2-2a17-4f1f-848e-37ab7dcd599f"), false, true, new Guid("648e2a02-23ef-4228-a45c-aa151d2c6cd7"), null },
                    { new Guid("7d812174-ed25-4333-94cd-8f3c4ec51489"), null, new Guid("e5a7f8d2-2a17-4f1f-848e-37ab7dcd599f"), true, true, new Guid("4bfa703e-df22-48d0-a7dd-3e310b34c39f"), null },
                    { new Guid("8041e548-be15-4b58-897c-293e75522354"), null, new Guid("ec090a2b-f734-4feb-9ddf-e72790c21bb3"), true, true, new Guid("4bfa703e-df22-48d0-a7dd-3e310b34c39f"), null },
                    { new Guid("82fbcda5-4935-4e47-ba14-41b94db85ee5"), null, new Guid("01505f8a-8657-4a9a-b2bb-543d7f7fb3f5"), false, true, new Guid("648e2a02-23ef-4228-a45c-aa151d2c6cd7"), null },
                    { new Guid("852b3d3d-ed1a-4e81-bda8-9119fea90e60"), null, new Guid("0f15ef2d-2318-4a14-b8f7-c8b120315c02"), false, true, new Guid("0799f7a2-9dda-4aab-b5c8-4703e7dd2bd7"), null },
                    { new Guid("86ac239b-8aab-4b5f-ae81-cc8326abd67e"), null, new Guid("0f15ef2d-2318-4a14-b8f7-c8b120315c02"), false, true, new Guid("7664222c-1a0c-45e7-a629-e50967dd516b"), null },
                    { new Guid("9429a1c9-0639-401e-82e1-325cf241f0ed"), null, new Guid("01505f8a-8657-4a9a-b2bb-543d7f7fb3f5"), true, true, new Guid("50e90541-acc0-4d38-beb4-a5dd72557697"), null },
                    { new Guid("9a76b4aa-5616-4f20-b3fe-c813d098b2cc"), null, new Guid("0f15ef2d-2318-4a14-b8f7-c8b120315c02"), false, true, new Guid("4bfa703e-df22-48d0-a7dd-3e310b34c39f"), null },
                    { new Guid("a5857341-9308-49fe-b323-fd1b1366fe1e"), null, new Guid("01505f8a-8657-4a9a-b2bb-543d7f7fb3f5"), true, true, new Guid("0799f7a2-9dda-4aab-b5c8-4703e7dd2bd7"), null },
                    { new Guid("a806ca44-fdda-4303-9e51-2afba6463b69"), null, new Guid("01505f8a-8657-4a9a-b2bb-543d7f7fb3f5"), false, true, new Guid("0ea9f22f-cb65-4941-914c-91ade32fbd15"), null },
                    { new Guid("afad90eb-a26b-4044-9865-1fce9bd2043e"), null, new Guid("6d663b1e-f1a3-42d9-a75d-38851b1062ad"), true, true, new Guid("7664222c-1a0c-45e7-a629-e50967dd516b"), "РИНЦ AuthorID" },
                    { new Guid("b018e6db-06bb-44c8-b435-3662742bfaf1"), null, new Guid("e5a7f8d2-2a17-4f1f-848e-37ab7dcd599f"), true, true, new Guid("0799f7a2-9dda-4aab-b5c8-4703e7dd2bd7"), null },
                    { new Guid("b1287547-a377-41d3-ba6b-09e33cad3eb4"), null, new Guid("ec090a2b-f734-4feb-9ddf-e72790c21bb3"), false, true, new Guid("0ea9f22f-cb65-4941-914c-91ade32fbd15"), null },
                    { new Guid("b8deeb61-1b4c-4b58-a02c-3bdf53ebd17f"), null, new Guid("ec090a2b-f734-4feb-9ddf-e72790c21bb3"), false, true, new Guid("648e2a02-23ef-4228-a45c-aa151d2c6cd7"), null },
                    { new Guid("c008134e-5746-45ef-bfc7-418e485ef732"), null, new Guid("0f15ef2d-2318-4a14-b8f7-c8b120315c02"), false, true, new Guid("70602ec1-b379-490d-ac54-23cab0cc35c7"), null },
                    { new Guid("c4c0a24c-c35e-4c18-a838-8cf24b11e1c4"), null, new Guid("01505f8a-8657-4a9a-b2bb-543d7f7fb3f5"), false, true, new Guid("4bfa703e-df22-48d0-a7dd-3e310b34c39f"), null },
                    { new Guid("d79ff022-18be-440c-acb3-1c623ac1145b"), null, new Guid("01505f8a-8657-4a9a-b2bb-543d7f7fb3f5"), false, true, new Guid("7664222c-1a0c-45e7-a629-e50967dd516b"), null },
                    { new Guid("db4cbd32-4323-491a-bf09-29e0169e8d94"), null, new Guid("ec090a2b-f734-4feb-9ddf-e72790c21bb3"), false, true, new Guid("70602ec1-b379-490d-ac54-23cab0cc35c7"), null },
                    { new Guid("e35661b2-4de4-4686-b09f-5def5664ffe3"), null, new Guid("6d663b1e-f1a3-42d9-a75d-38851b1062ad"), true, true, new Guid("0ea9f22f-cb65-4941-914c-91ade32fbd15"), "Google Scholar ID" },
                    { new Guid("f0021bfd-5e90-4ef0-83c1-7a10359378b1"), null, new Guid("ec090a2b-f734-4feb-9ddf-e72790c21bb3"), true, true, new Guid("50e90541-acc0-4d38-beb4-a5dd72557697"), null },
                    { new Guid("fa28bd15-e83d-4ad7-8dcc-3c2ee7e4612b"), null, new Guid("ec090a2b-f734-4feb-9ddf-e72790c21bb3"), false, true, new Guid("7664222c-1a0c-45e7-a629-e50967dd516b"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), new Guid("6342b89d-4929-46b9-a738-38bd985f598c") },
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), new Guid("69c1fd01-14b8-4dc1-8db0-45a1706fc6bc") },
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), new Guid("69f393c4-53e6-4310-ab7b-663a8da92446") },
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), new Guid("7f0650f2-af26-4faf-b9a7-0d70c8e52770") },
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), new Guid("879d5f66-37a4-46aa-8bff-470cbf95d79c") },
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), new Guid("9407309c-164f-4d63-a587-9b1e74906d9c") },
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), new Guid("c5a8d8df-5a88-4b44-b225-f04040c6e195") },
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), new Guid("ca44d760-d67c-469d-8e92-4980e0c1b863") },
                    { new Guid("088a8fad-9856-49cf-b1e2-d1006d7b3207"), new Guid("f4a3e830-f911-4b4e-82fb-ec95c6524689") },
                    { new Guid("448d588e-6d55-4444-a6fa-6fc1bf94d73c"), new Guid("1cd86cc8-539e-4799-aad2-e7fd7704141e") },
                    { new Guid("448d588e-6d55-4444-a6fa-6fc1bf94d73c"), new Guid("44dfe9e5-d810-4aa8-b6ea-ac442ec10a90") },
                    { new Guid("448d588e-6d55-4444-a6fa-6fc1bf94d73c"), new Guid("4fcc0300-7943-4b6c-a136-08fc2e913de0") },
                    { new Guid("448d588e-6d55-4444-a6fa-6fc1bf94d73c"), new Guid("6462ae78-a08c-465f-a790-c21746993cb4") },
                    { new Guid("448d588e-6d55-4444-a6fa-6fc1bf94d73c"), new Guid("70e10b54-3408-4522-a747-fc1d114d4bae") },
                    { new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6"), new Guid("5e198322-3fda-4caf-ab25-0bfe25bbdce0") },
                    { new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6"), new Guid("96f3d373-7bc9-4ada-a8c0-1306ab6f87fc") },
                    { new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6"), new Guid("b02b312a-c23d-4c3b-9669-d77533960bf1") },
                    { new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6"), new Guid("b267bf90-cd28-4eb6-abda-22915d6043bc") },
                    { new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6"), new Guid("c40f5636-a237-4d0f-999d-6ce67dd746f3") },
                    { new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6"), new Guid("dc951339-f822-4928-bf8c-b4b23df10fc3") },
                    { new Guid("913e66ec-4ca3-445c-ad8a-b573d3f610e6"), new Guid("e8d70c40-572f-4f8c-a67e-91c9e01f1c1f") },
                    { new Guid("afee9c43-ee38-4153-9061-596062709fe8"), new Guid("49f92943-f7c9-4002-8a19-03178dfb3f34") },
                    { new Guid("afee9c43-ee38-4153-9061-596062709fe8"), new Guid("69c1fd01-14b8-4dc1-8db0-45a1706fc6bc") },
                    { new Guid("afee9c43-ee38-4153-9061-596062709fe8"), new Guid("9407309c-164f-4d63-a587-9b1e74906d9c") },
                    { new Guid("c8e63b5b-ac96-4de8-82b5-0df344c35c6f"), new Guid("096ab423-0559-4d6b-aa8b-ab976b00954a") },
                    { new Guid("c8e63b5b-ac96-4de8-82b5-0df344c35c6f"), new Guid("43f494df-c99d-4f82-9ffc-0713fa1d74cf") },
                    { new Guid("c8e63b5b-ac96-4de8-82b5-0df344c35c6f"), new Guid("49f92943-f7c9-4002-8a19-03178dfb3f34") },
                    { new Guid("c8e63b5b-ac96-4de8-82b5-0df344c35c6f"), new Guid("4be287a4-f3bf-4d54-b056-7e7efaec962e") },
                    { new Guid("c8e63b5b-ac96-4de8-82b5-0df344c35c6f"), new Guid("5c839daf-a544-4e99-bab4-37caef86dc6c") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0869d911-09d0-46d8-86b2-184ef09e6f02"), new Guid("1303743c-934c-4c1e-8fbc-98d9770c83c1"), null, "Изобретение" },
                    { new Guid("12060b29-1fee-454e-b117-1f5611ddc815"), new Guid("3e12c421-00a4-4c62-84b0-e5d0c35455f5"), null, "Лекции" },
                    { new Guid("1cc46e52-b6aa-47c9-8501-ba89c279bccd"), new Guid("fe7d309f-7efa-4797-9a44-8a8b9ca8dc50"), null, "Изобретение" },
                    { new Guid("2147cb4a-5c4b-4cda-8d34-ebf95d06d8b9"), new Guid("f2f4f4e6-3b61-4319-9065-37d64960c3f9"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("22555851-2da6-4ae6-b30f-fbe88a606411"), new Guid("145d1bf8-282d-4659-a20c-5e36539a72e3"), null, "Региональный" },
                    { new Guid("388b0dd5-8301-4b84-bf4b-0a7c38ccd0bf"), new Guid("145d1bf8-282d-4659-a20c-5e36539a72e3"), null, "Международный" },
                    { new Guid("3c1224c1-f765-4350-800a-9c8cdfef4703"), new Guid("f2f4f4e6-3b61-4319-9065-37d64960c3f9"), null, "Монография" },
                    { new Guid("43db2262-f905-4763-b8f9-e70c30fd4810"), new Guid("d9e8680c-23a5-413a-b70a-162c3b51c2cd"), null, "Исполнитель" },
                    { new Guid("59194030-d98a-4e03-851e-cdb17be84802"), new Guid("d9e8680c-23a5-413a-b70a-162c3b51c2cd"), null, "Руководитель" },
                    { new Guid("614a2f46-8da7-4555-9cda-5f54100a6fca"), new Guid("3e12c421-00a4-4c62-84b0-e5d0c35455f5"), null, "Лабораторные" },
                    { new Guid("667c839b-f0c3-469a-8bed-d1801cdb9070"), new Guid("fe7d309f-7efa-4797-9a44-8a8b9ca8dc50"), null, "База данных" },
                    { new Guid("7980dd8a-206e-41d2-bb64-164f884b99d5"), new Guid("f2f4f4e6-3b61-4319-9065-37d64960c3f9"), null, "Учебник" },
                    { new Guid("831e1992-a094-4439-9f5b-eb612f7ab4da"), new Guid("1303743c-934c-4c1e-8fbc-98d9770c83c1"), null, "Полезная модель" },
                    { new Guid("9b104c36-63a2-41a6-b3eb-9a32ab0dd51e"), new Guid("fe7d309f-7efa-4797-9a44-8a8b9ca8dc50"), null, "Полезная модель" },
                    { new Guid("b8f1ed8d-b03c-4aad-a208-8a556c19fc9e"), new Guid("145d1bf8-282d-4659-a20c-5e36539a72e3"), null, "Всероссийский" },
                    { new Guid("bd3396ea-b3b0-4f77-a8db-44518ac1b6cc"), new Guid("1303743c-934c-4c1e-8fbc-98d9770c83c1"), null, "База данных" }
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
