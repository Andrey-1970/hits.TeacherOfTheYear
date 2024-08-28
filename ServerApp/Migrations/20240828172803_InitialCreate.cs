using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ServerApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    { new Guid("3a591baa-bf7c-48dc-a616-d0e7ae4ee88e"), 2, "В ожидании оценки" },
                    { new Guid("5b38c570-f989-403e-80d8-5a72ec51d305"), 4, "Одобрена" },
                    { new Guid("930e36d3-d5e5-4cd0-841a-1835490a41b3"), 5, "Отклонена" },
                    { new Guid("ac2f6771-1db9-48b1-a702-f9206326f51a"), 3, "В процессе оценки" },
                    { new Guid("b84821c5-1212-4dfc-9972-7fa1e5fc2146"), 1, "В ожидании заполнения" }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("244aa723-8a97-4d0c-b457-c0542e4d15bc"), "Общая информация", 1 },
                    { new Guid("42ea1cc3-5487-449c-a581-02d8686bd21d"), "Профессиональное развитие", 3 },
                    { new Guid("630d745b-5134-4f21-b165-f9104ecb1f35"), "Деятельность", 5 },
                    { new Guid("668e4a6b-e854-4d76-8d9b-5b5d97f07631"), "Категория участников", 2 },
                    { new Guid("7fe280fb-3f72-4cd2-921b-38029e197886"), "Деятельность", 4 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("4f700521-29a7-48ce-b570-b6f8f4ba247b"), "Инновационная и иная деятельность", 6 },
                    { new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe"), "Образовательная деятельность", 2 },
                    { new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f"), "Основной", 1 },
                    { new Guid("bae51a96-b0ca-4c25-b4ab-713dfd3461a8"), "Конкурсная работа", 7 },
                    { new Guid("e3064d0e-15dc-4f37-a870-7b9dc7cd9e56"), "Профессиональные показатели", 4 },
                    { new Guid("ed4a7a57-bbdf-4a99-a1a4-4e293d2f46a4"), "Методическая деятельность", 3 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("82418de5-d677-49fb-ae2c-78589d32d4f9"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("b7097ea6-b019-4ac9-9d9f-5ad58cc3fd82"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("af6b7cd8-100e-41be-8a68-fdec0b610013"), "User 1", "admin@mail.ru" },
                    { new Guid("bd70e714-350e-4d91-b8c6-e0c906e99807"), "User 2", "user@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("72f99d71-26be-4e7d-890e-f01d1752b7a9"), "bool" },
                    { new Guid("a678240f-d1b4-4906-9b83-5bec2b5b3ea7"), "DateTime" },
                    { new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc"), "int" },
                    { new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c"), "string" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("244aa723-8a97-4d0c-b457-c0542e4d15bc"), new Guid("82418de5-d677-49fb-ae2c-78589d32d4f9") },
                    { new Guid("244aa723-8a97-4d0c-b457-c0542e4d15bc"), new Guid("b7097ea6-b019-4ac9-9d9f-5ad58cc3fd82") },
                    { new Guid("42ea1cc3-5487-449c-a581-02d8686bd21d"), new Guid("82418de5-d677-49fb-ae2c-78589d32d4f9") },
                    { new Guid("42ea1cc3-5487-449c-a581-02d8686bd21d"), new Guid("b7097ea6-b019-4ac9-9d9f-5ad58cc3fd82") },
                    { new Guid("630d745b-5134-4f21-b165-f9104ecb1f35"), new Guid("82418de5-d677-49fb-ae2c-78589d32d4f9") },
                    { new Guid("668e4a6b-e854-4d76-8d9b-5b5d97f07631"), new Guid("82418de5-d677-49fb-ae2c-78589d32d4f9") },
                    { new Guid("668e4a6b-e854-4d76-8d9b-5b5d97f07631"), new Guid("b7097ea6-b019-4ac9-9d9f-5ad58cc3fd82") },
                    { new Guid("7fe280fb-3f72-4cd2-921b-38029e197886"), new Guid("b7097ea6-b019-4ac9-9d9f-5ad58cc3fd82") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "Name", "Number", "Placeholder", "Required", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("059969c5-b52d-4ae3-99a7-b36e2f91bf28"), new Guid("7fe280fb-3f72-4cd2-921b-38029e197886"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", "Защитившиеся кадидаты наук", 19, "Введите количество", true, new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("0b7fea8f-231e-49ce-a7a8-263a2efbc1de"), new Guid("630d745b-5134-4f21-b165-f9104ecb1f35"), null, "Защитившиеся доктора наук", 25, "Введите количество", true, new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("1cf3f58c-a8da-47fe-b839-a57b6d1f6078"), new Guid("668e4a6b-e854-4d76-8d9b-5b5d97f07631"), null, "Ссылка на конкурсную работу", 15, "Введите ссылку своей конкурсной работы", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("25f93e6d-70cc-4f59-881c-3d575438363e"), new Guid("244aa723-8a97-4d0c-b457-c0542e4d15bc"), null, "Адрес работы/учебы", 7, "Регион, город, улица, дом", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("3318f041-65b4-4abd-b943-fdd5c03dd2c6"), new Guid("244aa723-8a97-4d0c-b457-c0542e4d15bc"), null, "Дополнительная информация", 11, "Пример", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("33bcc605-c3f0-40e4-a2f3-f99efc069c6b"), new Guid("668e4a6b-e854-4d76-8d9b-5b5d97f07631"), null, "Научная специальность (по классификации ВАК)", 18, "Введите научную специальность (по классификации ВАК)", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("3786a8a6-1233-4ab5-9838-ed588b67d814"), new Guid("7fe280fb-3f72-4cd2-921b-38029e197886"), null, "Защитившиеся магистры", 23, "Введите количество", true, new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("41423741-f167-49fb-9bf6-b9de4a310c45"), new Guid("668e4a6b-e854-4d76-8d9b-5b5d97f07631"), null, "Ученая степень", 17, "Выберите ученую степень", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("46af9650-180a-4700-906c-0fbec45ca9b4"), new Guid("7fe280fb-3f72-4cd2-921b-38029e197886"), null, "Защитившиеся доктора наук", 20, "Введите количество", true, new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("4d7ec284-8ccc-4d3a-b24b-ddaf4fe8df3e"), new Guid("244aa723-8a97-4d0c-b457-c0542e4d15bc"), null, "Электронная почта", 5, "user@example.com", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("526b992c-defb-4b1e-b40e-c091b0be1359"), new Guid("244aa723-8a97-4d0c-b457-c0542e4d15bc"), null, "Контактный телефон", 4, "+8 (900)-000-00-00", true, new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("5564595b-72b1-4f5f-9293-72f22ac7deed"), new Guid("244aa723-8a97-4d0c-b457-c0542e4d15bc"), null, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("562d1be2-164c-4b4f-a5f1-581f88f92abb"), new Guid("244aa723-8a97-4d0c-b457-c0542e4d15bc"), null, "Дата рождения", 2, "01.01.2000", true, new Guid("a678240f-d1b4-4906-9b83-5bec2b5b3ea7") },
                    { new Guid("5e5e9907-ff45-44c0-adc8-4c5de5a1701e"), new Guid("244aa723-8a97-4d0c-b457-c0542e4d15bc"), null, "Место работы/учебы", 6, "Название организации", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("7f0348f1-21c1-4cca-be2d-39c48da434d5"), new Guid("244aa723-8a97-4d0c-b457-c0542e4d15bc"), null, "Должность", 9, "Введите свою должность в организации", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("9529d350-cca8-4de0-aa84-cf555da5da54"), new Guid("668e4a6b-e854-4d76-8d9b-5b5d97f07631"), null, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 13, "Выберите категорию участника конкруса", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("960b2ebf-0a12-47db-b6fc-201d8502174c"), new Guid("630d745b-5134-4f21-b165-f9104ecb1f35"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", "Защитившиеся кандидаты наук", 24, "Введите количество", true, new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("99dc4dc6-6ca6-4051-84b7-22004a74475d"), new Guid("244aa723-8a97-4d0c-b457-c0542e4d15bc"), null, "ФИО", 1, "Иванов Иван Иванович", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("a50dcda9-d4e5-4734-9ac0-a50e4058c6b7"), new Guid("668e4a6b-e854-4d76-8d9b-5b5d97f07631"), null, "Направление конкурса", 12, "Выберите направление конкурса", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("ba0ce598-fae9-4b2f-b9d3-adfb7cd051d3"), new Guid("668e4a6b-e854-4d76-8d9b-5b5d97f07631"), null, "Название конкурсной работы", 14, "Введите название своей конкурсной работы", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("c09106d7-cbcb-4595-9dae-e1e2644c2f9e"), new Guid("244aa723-8a97-4d0c-b457-c0542e4d15bc"), null, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", true, new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("d3f653a7-4c3e-465d-ae6a-bc2d8ab719b3"), new Guid("244aa723-8a97-4d0c-b457-c0542e4d15bc"), null, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("dde7acd9-3a3a-49fd-9b4b-c0a653b57e12"), new Guid("668e4a6b-e854-4d76-8d9b-5b5d97f07631"), null, "Ученое звание", 16, "Выберите ученое звание", true, new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("df1d538a-f638-4cad-a199-b9dac76d4f4c"), new Guid("7fe280fb-3f72-4cd2-921b-38029e197886"), "Руководство дипломными проектами за предыдущий учебный год", "Защитившиеся бакалавры", 21, "Введите количество", true, new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("eadf86b1-513b-488b-b38c-8b5f52d35eb7"), new Guid("7fe280fb-3f72-4cd2-921b-38029e197886"), null, "Защитившиеся специалисты", 22, "Введите количество", true, new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), new Guid("82418de5-d677-49fb-ae2c-78589d32d4f9") },
                    { new Guid("4f700521-29a7-48ce-b570-b6f8f4ba247b"), new Guid("82418de5-d677-49fb-ae2c-78589d32d4f9") },
                    { new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe"), new Guid("b7097ea6-b019-4ac9-9d9f-5ad58cc3fd82") },
                    { new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f"), new Guid("82418de5-d677-49fb-ae2c-78589d32d4f9") },
                    { new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f"), new Guid("b7097ea6-b019-4ac9-9d9f-5ad58cc3fd82") },
                    { new Guid("bae51a96-b0ca-4c25-b4ab-713dfd3461a8"), new Guid("82418de5-d677-49fb-ae2c-78589d32d4f9") },
                    { new Guid("bae51a96-b0ca-4c25-b4ab-713dfd3461a8"), new Guid("b7097ea6-b019-4ac9-9d9f-5ad58cc3fd82") },
                    { new Guid("e3064d0e-15dc-4f37-a870-7b9dc7cd9e56"), new Guid("b7097ea6-b019-4ac9-9d9f-5ad58cc3fd82") },
                    { new Guid("ed4a7a57-bbdf-4a99-a1a4-4e293d2f46a4"), new Guid("b7097ea6-b019-4ac9-9d9f-5ad58cc3fd82") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("1eac5249-d3dd-439f-9558-36e7c642e830"), new Guid("7fe280fb-3f72-4cd2-921b-38029e197886"), false, "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 },
                    { new Guid("534f2fdc-dc1c-4e46-b5ea-5cbf00a10e9b"), new Guid("630d745b-5134-4f21-b165-f9104ecb1f35"), false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("553ac0db-ab48-4949-bfdb-d0fbe0b85fd3"), new Guid("630d745b-5134-4f21-b165-f9104ecb1f35"), false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("63ba0bca-8b82-41c6-b5b8-30ce69443f85"), new Guid("7fe280fb-3f72-4cd2-921b-38029e197886"), false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("9afc1ea9-c6fb-4996-a881-e312ead0ee33"), new Guid("42ea1cc3-5487-449c-a581-02d8686bd21d"), false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("aaa8d818-6f9c-4b16-9a50-18973b8b17f0"), new Guid("630d745b-5134-4f21-b165-f9104ecb1f35"), false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5"), new Guid("630d745b-5134-4f21-b165-f9104ecb1f35"), true, "Персональные идентификаторы и показатели", 10 },
                    { new Guid("c2d6d551-a609-4e01-9643-0537cae9fbb0"), new Guid("7fe280fb-3f72-4cd2-921b-38029e197886"), false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("db09b619-6f1d-4058-beb2-a301f4de7454"), new Guid("42ea1cc3-5487-449c-a581-02d8686bd21d"), false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("dd873f32-7f8e-4ea6-9fc4-99467a4a3b9a"), new Guid("630d745b-5134-4f21-b165-f9104ecb1f35"), false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("e8c6112d-1ee1-487e-a521-fc02ba80652b"), new Guid("7fe280fb-3f72-4cd2-921b-38029e197886"), false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("eaa5e348-ac91-45b3-b200-159a934f5275"), new Guid("7fe280fb-3f72-4cd2-921b-38029e197886"), false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("f0cd4540-c63f-44e7-b047-c3ac83257200"), new Guid("7fe280fb-3f72-4cd2-921b-38029e197886"), false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("06d72dd5-8641-4e47-933e-ba866a5e41a7"), "Название", 2, new Guid("1eac5249-d3dd-439f-9558-36e7c642e830"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("0acb61af-4a8f-4f57-8cfb-f404f4fcbe74"), "Название разработки", 2, new Guid("534f2fdc-dc1c-4e46-b5ea-5cbf00a10e9b"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("0e1c6ba5-1cd4-49c1-abfe-16809dbdc566"), "Вид", 1, new Guid("534f2fdc-dc1c-4e46-b5ea-5cbf00a10e9b"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("144d299c-6166-4ee1-8e92-3b176f55e39f"), "Практические занятия (час.)", 4, new Guid("eaa5e348-ac91-45b3-b200-159a934f5275"), new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("18762e36-e566-4021-adf0-12c4c6203832"), "Название документа, реквизиты", 1, new Guid("9afc1ea9-c6fb-4996-a881-e312ead0ee33"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("27910caf-f260-4650-9f8a-24aa51adc410"), "Соавторы", 2, new Guid("aaa8d818-6f9c-4b16-9a50-18973b8b17f0"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("2a2ed41c-1c24-4ed2-9ef8-83bf2b4a1a7b"), "Номер РИД", 4, new Guid("553ac0db-ab48-4949-bfdb-d0fbe0b85fd3"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("3199fba0-af14-47aa-917a-5b0bb663e014"), "Количество цитирований", 4, new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5"), new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("3732ea42-6e19-43c1-8352-f7eb25724862"), "Вид", 1, new Guid("553ac0db-ab48-4949-bfdb-d0fbe0b85fd3"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("42b21cb3-5b7f-4e91-b2a5-5f1243c9dc4f"), "Статус (руководитель/исполнитель)", 4, new Guid("dd873f32-7f8e-4ea6-9fc4-99467a4a3b9a"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("47220430-761e-4779-bbad-db459473a636"), "Количество печатных листов", 4, new Guid("1eac5249-d3dd-439f-9558-36e7c642e830"), new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("48b7309a-8c8e-4d87-bda6-e43b65568087"), "Наименование курса", 1, new Guid("eaa5e348-ac91-45b3-b200-159a934f5275"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("4c7b8fa8-7bef-4e16-8515-ac0f67b8a0d6"), "Название конкурса/премии", 2, new Guid("63ba0bca-8b82-41c6-b5b8-30ce69443f85"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("4d2b4ca2-b762-47a6-a33a-b73bb9641d9a"), "Год", 4, new Guid("c2d6d551-a609-4e01-9643-0537cae9fbb0"), new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("51066f07-2254-4afa-b9cd-5c774f56d4aa"), "Название курса", 1, new Guid("c2d6d551-a609-4e01-9643-0537cae9fbb0"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("519bff2b-7a44-4be0-96f4-57344239fa51"), "Сумма финансирования (тыс. руб.)", 2, new Guid("dd873f32-7f8e-4ea6-9fc4-99467a4a3b9a"), new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("5404211c-7fe8-4c55-8d70-2f0d27874c36"), "ФИО соавторов", 3, new Guid("553ac0db-ab48-4949-bfdb-d0fbe0b85fd3"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("56485420-386d-47ff-9c8e-dff8eecb405b"), "Год", 1, new Guid("db09b619-6f1d-4058-beb2-a301f4de7454"), new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("5ad1ea37-079f-431b-a2f8-96ab7e12b468"), "Соавторы", 2, new Guid("c2d6d551-a609-4e01-9643-0537cae9fbb0"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("64b3ee80-558a-4588-bd20-d4ab9785261b"), "Количество часов", 4, new Guid("e8c6112d-1ee1-487e-a521-fc02ba80652b"), new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("70824dbb-873f-4852-b601-f3e294f0b59a"), "Наличие грифа", 5, new Guid("1eac5249-d3dd-439f-9558-36e7c642e830"), new Guid("72f99d71-26be-4e7d-890e-f01d1752b7a9") },
                    { new Guid("73653228-8f38-4c0e-a1c4-e583ca59061d"), "Название", 2, new Guid("553ac0db-ab48-4949-bfdb-d0fbe0b85fd3"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("7fa1de20-9794-4d76-b204-85143dc4b91f"), "Тип идентификатора", 1, new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("80d1947b-9d2d-4d22-8064-c7e572c0d6a2"), "Вид (лекции, лабораторные)", 2, new Guid("f0cd4540-c63f-44e7-b047-c3ac83257200"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("80d32880-9592-4dc0-a691-9a2419ae52cf"), "Год", 3, new Guid("63ba0bca-8b82-41c6-b5b8-30ce69443f85"), new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("8357ae79-c03e-48ab-8e0f-ada6323577f7"), "Идентификатор", 2, new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("86bcf3c2-c48a-4da2-b22a-30bed20d6c85"), "Период выполнения", 3, new Guid("dd873f32-7f8e-4ea6-9fc4-99467a4a3b9a"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("8b701905-8b62-43b4-a1e2-6dcee97cf757"), "Название НИР/НИОКР", 1, new Guid("dd873f32-7f8e-4ea6-9fc4-99467a4a3b9a"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("8e339006-52cc-4238-b79d-4de5c4307247"), "Язык преподавания (русск./англ./др.)", 2, new Guid("eaa5e348-ac91-45b3-b200-159a934f5275"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("a3198669-5bf4-4166-b1b7-675a101d733d"), "Ссылка", 5, new Guid("db09b619-6f1d-4058-beb2-a301f4de7454"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("a6eb0719-7395-43ff-8c41-fdb0ea442477"), "Издательство, год", 6, new Guid("1eac5249-d3dd-439f-9558-36e7c642e830"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("a81bd027-8fb1-4515-94ee-dd3d4c7e8aa3"), "Вид деятельности (преподавательская)", 3, new Guid("e8c6112d-1ee1-487e-a521-fc02ba80652b"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("ab6b60ab-bb5b-40d8-98b0-c570db0d1fff"), "Итого (час.)", 5, new Guid("eaa5e348-ac91-45b3-b200-159a934f5275"), new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("ab9606e8-c027-4efc-9fc6-e2185e0abfdf"), "Ссылка на платформу", 3, new Guid("c2d6d551-a609-4e01-9643-0537cae9fbb0"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("b0048747-bd8b-4447-b9d1-80e897c2d70d"), "Вид публикации", 1, new Guid("1eac5249-d3dd-439f-9558-36e7c642e830"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("b08ca137-3b67-40d9-bd9e-04928311d9ff"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("dd873f32-7f8e-4ea6-9fc4-99467a4a3b9a"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("b6684ad6-acd5-46f1-9440-614b103afae7"), "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("63ba0bca-8b82-41c6-b5b8-30ce69443f85"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("b7c72555-5a5d-4690-b10c-c2530141bff3"), "Название дисциплины", 1, new Guid("f0cd4540-c63f-44e7-b047-c3ac83257200"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("b8a3a3cb-1af1-480b-8347-2638bd6ade53"), "Издание, год", 4, new Guid("aaa8d818-6f9c-4b16-9a50-18973b8b17f0"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("beb91fbd-7ded-4b75-a322-e8ee13a18362"), "Название организации в которую внедрена разработка", 3, new Guid("534f2fdc-dc1c-4e46-b5ea-5cbf00a10e9b"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("bfd0158e-5b43-436d-bcfb-f5196cae1541"), "Статус конкурса", 3, new Guid("db09b619-6f1d-4058-beb2-a301f4de7454"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("c32c6b6e-9808-4549-9421-f2cca85364e0"), "Индекс Хирша (за все время)", 5, new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("c567c191-c0a8-4eef-a013-d0bcf894fb78"), "Лекции (час.)", 3, new Guid("eaa5e348-ac91-45b3-b200-159a934f5275"), new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("c6c11c76-822e-40c1-91b1-d97bdde7df43"), "Название статьи", 1, new Guid("aaa8d818-6f9c-4b16-9a50-18973b8b17f0"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("c6e4b611-6316-4b93-b2e6-1d1fe8fe36ca"), "Год получения документа", 2, new Guid("9afc1ea9-c6fb-4996-a881-e312ead0ee33"), new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("d5f58714-7caf-403b-b2c6-362b950ac1ed"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("63ba0bca-8b82-41c6-b5b8-30ce69443f85"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("d9905af7-e9fa-4286-bb33-0a9a507dc271"), "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("e8c6112d-1ee1-487e-a521-fc02ba80652b"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("defa6d9c-20a1-4b2d-978f-71af59c5fcea"), "Название конкурса", 2, new Guid("db09b619-6f1d-4058-beb2-a301f4de7454"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("e0222f22-4077-4037-9ead-b38e0ae54fb6"), "Название организации/должность/ставка", 1, new Guid("e8c6112d-1ee1-487e-a521-fc02ba80652b"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("e05e0e2b-4ec5-47e1-9bfe-4e0a4666da58"), "Количество публикаций в БАЗЕ", 3, new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5"), new Guid("e13dc3df-79c2-4834-91ce-4ed10409d9fc") },
                    { new Guid("edba89e7-b542-4c77-ae3f-7cbe9623f2e0"), "Награда", 4, new Guid("db09b619-6f1d-4058-beb2-a301f4de7454"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("f438b26d-8a32-4bfa-b666-b0f931f55980"), "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("aaa8d818-6f9c-4b16-9a50-18973b8b17f0"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("fbdd7c79-832a-4a69-b0b2-53717de83d3f"), "ФИО", 1, new Guid("63ba0bca-8b82-41c6-b5b8-30ce69443f85"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") },
                    { new Guid("fca99d73-658f-48e3-a465-9d8682bc4369"), "Соавторы", 3, new Guid("1eac5249-d3dd-439f-9558-36e7c642e830"), new Guid("e3dcd4f3-59d3-40b7-8efd-214bee33093c") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("059969c5-b52d-4ae3-99a7-b36e2f91bf28"), new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe") },
                    { new Guid("0b7fea8f-231e-49ce-a7a8-263a2efbc1de"), new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f") },
                    { new Guid("1cf3f58c-a8da-47fe-b839-a57b6d1f6078"), new Guid("bae51a96-b0ca-4c25-b4ab-713dfd3461a8") },
                    { new Guid("25f93e6d-70cc-4f59-881c-3d575438363e"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("3318f041-65b4-4abd-b943-fdd5c03dd2c6"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("33bcc605-c3f0-40e4-a2f3-f99efc069c6b"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("3786a8a6-1233-4ab5-9838-ed588b67d814"), new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe") },
                    { new Guid("41423741-f167-49fb-9bf6-b9de4a310c45"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("46af9650-180a-4700-906c-0fbec45ca9b4"), new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe") },
                    { new Guid("4d7ec284-8ccc-4d3a-b24b-ddaf4fe8df3e"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("526b992c-defb-4b1e-b40e-c091b0be1359"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("5564595b-72b1-4f5f-9293-72f22ac7deed"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("562d1be2-164c-4b4f-a5f1-581f88f92abb"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("5e5e9907-ff45-44c0-adc8-4c5de5a1701e"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("7f0348f1-21c1-4cca-be2d-39c48da434d5"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("9529d350-cca8-4de0-aa84-cf555da5da54"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("960b2ebf-0a12-47db-b6fc-201d8502174c"), new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f") },
                    { new Guid("99dc4dc6-6ca6-4051-84b7-22004a74475d"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("a50dcda9-d4e5-4734-9ac0-a50e4058c6b7"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("ba0ce598-fae9-4b2f-b9d3-adfb7cd051d3"), new Guid("bae51a96-b0ca-4c25-b4ab-713dfd3461a8") },
                    { new Guid("c09106d7-cbcb-4595-9dae-e1e2644c2f9e"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("d3f653a7-4c3e-465d-ae6a-bc2d8ab719b3"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("dde7acd9-3a3a-49fd-9b4b-c0a653b57e12"), new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f") },
                    { new Guid("dde7acd9-3a3a-49fd-9b4b-c0a653b57e12"), new Guid("7a039b1a-6bf7-4332-a9dc-dbcf6c73a23f") },
                    { new Guid("dde7acd9-3a3a-49fd-9b4b-c0a653b57e12"), new Guid("e3064d0e-15dc-4f37-a870-7b9dc7cd9e56") },
                    { new Guid("df1d538a-f638-4cad-a199-b9dac76d4f4c"), new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe") },
                    { new Guid("eadf86b1-513b-488b-b38c-8b5f52d35eb7"), new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), new Guid("aaa8d818-6f9c-4b16-9a50-18973b8b17f0") },
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5") },
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), new Guid("db09b619-6f1d-4058-beb2-a301f4de7454") },
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), new Guid("dd873f32-7f8e-4ea6-9fc4-99467a4a3b9a") },
                    { new Guid("4f700521-29a7-48ce-b570-b6f8f4ba247b"), new Guid("534f2fdc-dc1c-4e46-b5ea-5cbf00a10e9b") },
                    { new Guid("4f700521-29a7-48ce-b570-b6f8f4ba247b"), new Guid("553ac0db-ab48-4949-bfdb-d0fbe0b85fd3") },
                    { new Guid("4f700521-29a7-48ce-b570-b6f8f4ba247b"), new Guid("9afc1ea9-c6fb-4996-a881-e312ead0ee33") },
                    { new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe"), new Guid("63ba0bca-8b82-41c6-b5b8-30ce69443f85") },
                    { new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe"), new Guid("c2d6d551-a609-4e01-9643-0537cae9fbb0") },
                    { new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe"), new Guid("e8c6112d-1ee1-487e-a521-fc02ba80652b") },
                    { new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe"), new Guid("eaa5e348-ac91-45b3-b200-159a934f5275") },
                    { new Guid("e3064d0e-15dc-4f37-a870-7b9dc7cd9e56"), new Guid("9afc1ea9-c6fb-4996-a881-e312ead0ee33") },
                    { new Guid("e3064d0e-15dc-4f37-a870-7b9dc7cd9e56"), new Guid("db09b619-6f1d-4058-beb2-a301f4de7454") },
                    { new Guid("ed4a7a57-bbdf-4a99-a1a4-4e293d2f46a4"), new Guid("1eac5249-d3dd-439f-9558-36e7c642e830") },
                    { new Guid("ed4a7a57-bbdf-4a99-a1a4-4e293d2f46a4"), new Guid("f0cd4540-c63f-44e7-b047-c3ac83257200") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("123b73e2-3734-434b-b370-c940143c5630"), null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("553ac0db-ab48-4949-bfdb-d0fbe0b85fd3") },
                    { new Guid("1b3648a1-625e-4a6b-b88d-79065380e07d"), null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("1eac5249-d3dd-439f-9558-36e7c642e830") },
                    { new Guid("2bbf8971-c205-4a7f-8a88-8ccfa5f4f581"), null, true, 2, "Баллы за награды:", 14, new Guid("db09b619-6f1d-4058-beb2-a301f4de7454") },
                    { new Guid("2f823461-2828-4f9f-89ee-09e1cf162e9b"), null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("dd873f32-7f8e-4ea6-9fc4-99467a4a3b9a") },
                    { new Guid("34a5f1fa-1859-4287-922e-179b40cee4ce"), null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("63ba0bca-8b82-41c6-b5b8-30ce69443f85") },
                    { new Guid("367000e4-2bc6-425f-a78a-056f1537dc7c"), null, true, 5, "Баллы за научные публикации:", 16, new Guid("aaa8d818-6f9c-4b16-9a50-18973b8b17f0") },
                    { new Guid("4005ae02-9121-416f-baa3-3674c19fe89e"), null, true, 5, "Баллы по базе Scopus:", 17, new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5") },
                    { new Guid("41809e75-9e8d-4629-8d6b-a4a3a5a0e19c"), new Guid("059969c5-b52d-4ae3-99a7-b36e2f91bf28"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("42751ccd-1df8-43b6-9a92-361e3b86a93a"), null, true, 3, "Баллы по базе РИНЦ:", 18, new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5") },
                    { new Guid("49789682-e2f0-4049-9188-167f0143250c"), null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("1eac5249-d3dd-439f-9558-36e7c642e830") },
                    { new Guid("507f8cc7-9c24-4086-b8a5-ad6e17978b68"), new Guid("0b7fea8f-231e-49ce-a7a8-263a2efbc1de"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("55d19766-9924-46bb-ac91-da66554a2eba"), new Guid("960b2ebf-0a12-47db-b6fc-201d8502174c"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("5ac16067-ca9d-49f9-9999-15625c2b720d"), null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("1eac5249-d3dd-439f-9558-36e7c642e830") },
                    { new Guid("6b5c71fd-14df-413f-8bfd-b1d96e9d9442"), null, true, 5, "Баллы за количество разработок:", 24, new Guid("534f2fdc-dc1c-4e46-b5ea-5cbf00a10e9b") },
                    { new Guid("6e1ce4fb-a8c7-4f05-9b65-2f6f39f5cf21"), null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("c2d6d551-a609-4e01-9643-0537cae9fbb0") },
                    { new Guid("763130d8-f0f6-4986-abbb-99457fa4af2a"), new Guid("3786a8a6-1233-4ab5-9838-ed588b67d814"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("990e7453-f5a1-470a-998e-ec960a7db2e7"), new Guid("dde7acd9-3a3a-49fd-9b4b-c0a653b57e12"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("9c34caf0-b7d6-4064-8ef0-22fb609a3db5"), new Guid("1cf3f58c-a8da-47fe-b839-a57b6d1f6078"), false, 10, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("b0042889-c9a8-4509-9afd-b35647fdd907"), null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("9afc1ea9-c6fb-4996-a881-e312ead0ee33") },
                    { new Guid("b18c5554-abe6-44e6-b3e7-7058283a2b4c"), null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("1eac5249-d3dd-439f-9558-36e7c642e830") },
                    { new Guid("b897c450-c565-4d4e-9d89-a87629b9f3a8"), null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("eaa5e348-ac91-45b3-b200-159a934f5275") },
                    { new Guid("c40e98f0-3885-4aa5-ba04-cee82c91b79a"), new Guid("46af9650-180a-4700-906c-0fbec45ca9b4"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("c5072d86-82dd-4c2c-b8a5-b790c1cb49c1"), new Guid("1cf3f58c-a8da-47fe-b839-a57b6d1f6078"), false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null },
                    { new Guid("e93f6f73-d5a6-4a50-9761-26d1fe7d5016"), null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("dd873f32-7f8e-4ea6-9fc4-99467a4a3b9a") },
                    { new Guid("ef2ecb03-19a7-42a4-975d-152affb69028"), null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("f0cd4540-c63f-44e7-b047-c3ac83257200") },
                    { new Guid("f1c7d042-abfc-442b-a3d3-d4c796492797"), null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("eaa5e348-ac91-45b3-b200-159a934f5275") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("2cf3a6e4-cecb-43f9-a32c-a1384c6904a4"), true, new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5") },
                    { new Guid("51279d19-b2b4-4b7a-9374-2473a3ac3938"), true, new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5") },
                    { new Guid("80b6f6e9-e2e1-4e16-944e-45d2aae5fac3"), true, new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5") },
                    { new Guid("8421876f-de74-4782-bffb-cb4e62a4d2f4"), true, new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5") },
                    { new Guid("bc287c35-4f11-4794-b678-7232ec4a51e5"), true, new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5") },
                    { new Guid("d1422f09-b7fc-4329-b6a9-cbad93349181"), true, new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5") },
                    { new Guid("daeffb8c-2597-421a-8176-5d64da4f3aa6"), true, new Guid("bedf20c8-293a-44d5-9034-9662ec3cffa5") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("110937a4-ecfa-4029-8b37-a359d778f2ad"), null, new Guid("a50dcda9-d4e5-4734-9ac0-a50e4058c6b7"), "ПРИКЛАДНАЯ ГЕОЛОГИЯ, ГОРНОЕ ДЕЛО, НЕФТЕГАЗОВОЕ ДЕЛО И ГЕОДЕЗИЯ" },
                    { new Guid("11d45fc1-766c-41ce-9818-567f86c28860"), null, new Guid("a50dcda9-d4e5-4734-9ac0-a50e4058c6b7"), "ЭЛЕКТРО- И ТЕПЛОЭНЕРГЕТИКА" },
                    { new Guid("1428f038-a829-453e-a057-206aeec8118c"), null, new Guid("dde7acd9-3a3a-49fd-9b4b-c0a653b57e12"), "Доцент" },
                    { new Guid("17a65873-0ecc-4c88-b654-fb8f42277a83"), null, new Guid("a50dcda9-d4e5-4734-9ac0-a50e4058c6b7"), "СТРОИТЕЛЬСТВО И АРХИТЕКТУРА" },
                    { new Guid("37027407-bef8-4887-b482-3c873aa5c635"), null, new Guid("a50dcda9-d4e5-4734-9ac0-a50e4058c6b7"), "АРХИТЕКТУРА" },
                    { new Guid("5c2279f8-5af8-40df-96e2-29392c49eadc"), null, new Guid("a50dcda9-d4e5-4734-9ac0-a50e4058c6b7"), "ТЕХНИКА И ТЕХНОЛОГИИ СТРОИТЕЛЬСТВА" },
                    { new Guid("6af15b77-0742-4608-90fd-ef1c4ba0f03b"), null, new Guid("9529d350-cca8-4de0-aa84-cf555da5da54"), "Аспиранты, адъюнкты, ординаторы, ассистенты-стажеры, не имеющие ученой степени" },
                    { new Guid("9093d02b-a71c-49e2-a906-aeb6c58a2ddd"), null, new Guid("a50dcda9-d4e5-4734-9ac0-a50e4058c6b7"), "НЕДРОПОЛЬЗОВАНИЕ И ГОРНЫЕ НАУКИ" },
                    { new Guid("a3d83b0c-021f-4f59-99c1-20cf5a011167"), null, new Guid("dde7acd9-3a3a-49fd-9b4b-c0a653b57e12"), "Нет" },
                    { new Guid("ad99ef83-fb58-44ac-86de-c32203377460"), null, new Guid("9529d350-cca8-4de0-aa84-cf555da5da54"), "Имеющие ученую степень доктора наук" },
                    { new Guid("f7618e18-a4d2-40bf-9eae-820e9913bda3"), null, new Guid("dde7acd9-3a3a-49fd-9b4b-c0a653b57e12"), "Профессор" },
                    { new Guid("fafd0f29-55f4-4208-9b32-f7f058cefba9"), null, new Guid("9529d350-cca8-4de0-aa84-cf555da5da54"), "Докторанты, имеющие ученую степень кандидата наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("075c557d-bb1d-4632-86ed-561c41171886"), null, new Guid("3199fba0-af14-47aa-917a-5b0bb663e014"), false, true, new Guid("2cf3a6e4-cecb-43f9-a32c-a1384c6904a4"), null },
                    { new Guid("0bfea39b-8c99-4de9-b465-72423690cd14"), null, new Guid("e05e0e2b-4ec5-47e1-9bfe-4e0a4666da58"), false, true, new Guid("51279d19-b2b4-4b7a-9374-2473a3ac3938"), null },
                    { new Guid("1269b488-e356-4c35-b16a-62577865b606"), null, new Guid("c32c6b6e-9808-4549-9421-f2cca85364e0"), true, true, new Guid("d1422f09-b7fc-4329-b6a9-cbad93349181"), null },
                    { new Guid("1a7e0c69-a640-47f6-82f5-29f716ff01a8"), null, new Guid("3199fba0-af14-47aa-917a-5b0bb663e014"), true, true, new Guid("d1422f09-b7fc-4329-b6a9-cbad93349181"), null },
                    { new Guid("2d8b77d7-ba6e-4cee-b913-b5bf30733456"), null, new Guid("3199fba0-af14-47aa-917a-5b0bb663e014"), false, true, new Guid("daeffb8c-2597-421a-8176-5d64da4f3aa6"), null },
                    { new Guid("3284ae7b-bb5e-4b40-996f-0ae9fa59f0a7"), null, new Guid("8357ae79-c03e-48ab-8e0f-ada6323577f7"), true, true, new Guid("daeffb8c-2597-421a-8176-5d64da4f3aa6"), null },
                    { new Guid("3513ab90-a21d-4f5f-92db-e9f37eac3e45"), null, new Guid("e05e0e2b-4ec5-47e1-9bfe-4e0a4666da58"), false, true, new Guid("d1422f09-b7fc-4329-b6a9-cbad93349181"), null },
                    { new Guid("37f228f4-c93b-4ee7-a0c2-10b98dd929d4"), null, new Guid("8357ae79-c03e-48ab-8e0f-ada6323577f7"), true, true, new Guid("d1422f09-b7fc-4329-b6a9-cbad93349181"), null },
                    { new Guid("3af739a9-293e-4788-b8fc-267fd6c46c13"), null, new Guid("e05e0e2b-4ec5-47e1-9bfe-4e0a4666da58"), false, true, new Guid("daeffb8c-2597-421a-8176-5d64da4f3aa6"), null },
                    { new Guid("46e819af-5d75-495f-bea7-439cd0ef3079"), null, new Guid("e05e0e2b-4ec5-47e1-9bfe-4e0a4666da58"), false, true, new Guid("2cf3a6e4-cecb-43f9-a32c-a1384c6904a4"), null },
                    { new Guid("4eab2ae5-d727-40c3-90f8-17208c0cbc5c"), null, new Guid("3199fba0-af14-47aa-917a-5b0bb663e014"), true, true, new Guid("80b6f6e9-e2e1-4e16-944e-45d2aae5fac3"), null },
                    { new Guid("5c466a60-ac6f-4e16-b9b3-655bc14534fa"), null, new Guid("7fa1de20-9794-4d76-b204-85143dc4b91f"), true, true, new Guid("d1422f09-b7fc-4329-b6a9-cbad93349181"), "Количество патентов" },
                    { new Guid("6118dbbe-e3d6-43b0-8a18-3a96e66e4a6d"), null, new Guid("7fa1de20-9794-4d76-b204-85143dc4b91f"), true, true, new Guid("2cf3a6e4-cecb-43f9-a32c-a1384c6904a4"), "РИНЦ AuthorID" },
                    { new Guid("643dc63f-805f-49da-85f0-2b198b782923"), null, new Guid("c32c6b6e-9808-4549-9421-f2cca85364e0"), true, true, new Guid("daeffb8c-2597-421a-8176-5d64da4f3aa6"), null },
                    { new Guid("65a99b7e-a581-4f8a-b53a-712a34b19467"), null, new Guid("e05e0e2b-4ec5-47e1-9bfe-4e0a4666da58"), false, true, new Guid("8421876f-de74-4782-bffb-cb4e62a4d2f4"), null },
                    { new Guid("6b41257b-598e-4c5b-9988-3b941a6b6519"), null, new Guid("7fa1de20-9794-4d76-b204-85143dc4b91f"), true, true, new Guid("daeffb8c-2597-421a-8176-5d64da4f3aa6"), "Количество монографий/глав в монографии" },
                    { new Guid("71dcf9d8-d5c3-4b78-b2fa-0925bccd1ea0"), null, new Guid("8357ae79-c03e-48ab-8e0f-ada6323577f7"), false, true, new Guid("51279d19-b2b4-4b7a-9374-2473a3ac3938"), null },
                    { new Guid("7e11bae9-04fb-4de8-9747-a42e665db61f"), null, new Guid("3199fba0-af14-47aa-917a-5b0bb663e014"), false, true, new Guid("8421876f-de74-4782-bffb-cb4e62a4d2f4"), null },
                    { new Guid("8b74c911-c832-45d0-acf3-c01edc38e5f4"), null, new Guid("8357ae79-c03e-48ab-8e0f-ada6323577f7"), false, true, new Guid("bc287c35-4f11-4794-b678-7232ec4a51e5"), null },
                    { new Guid("92122bb5-d2cd-48e2-a9d3-429c0d6caebe"), null, new Guid("c32c6b6e-9808-4549-9421-f2cca85364e0"), false, true, new Guid("bc287c35-4f11-4794-b678-7232ec4a51e5"), null },
                    { new Guid("96c33cea-19dd-415a-8c77-b41516365702"), null, new Guid("c32c6b6e-9808-4549-9421-f2cca85364e0"), false, true, new Guid("8421876f-de74-4782-bffb-cb4e62a4d2f4"), null },
                    { new Guid("99446bc0-c338-4cca-84e1-26da9bffe06c"), null, new Guid("7fa1de20-9794-4d76-b204-85143dc4b91f"), true, true, new Guid("bc287c35-4f11-4794-b678-7232ec4a51e5"), "Google Scholar ID" },
                    { new Guid("a6e65dca-5b8a-4d7a-90d5-73e574494f9f"), null, new Guid("c32c6b6e-9808-4549-9421-f2cca85364e0"), false, true, new Guid("51279d19-b2b4-4b7a-9374-2473a3ac3938"), null },
                    { new Guid("bc7796df-123c-4524-a658-f0e9687aaaee"), null, new Guid("c32c6b6e-9808-4549-9421-f2cca85364e0"), true, true, new Guid("80b6f6e9-e2e1-4e16-944e-45d2aae5fac3"), null },
                    { new Guid("bd8c8955-8f13-4823-b4cf-7b48264e0570"), null, new Guid("3199fba0-af14-47aa-917a-5b0bb663e014"), false, true, new Guid("bc287c35-4f11-4794-b678-7232ec4a51e5"), null },
                    { new Guid("bdf0f372-2709-43ba-a21a-198327960ccb"), null, new Guid("7fa1de20-9794-4d76-b204-85143dc4b91f"), true, true, new Guid("51279d19-b2b4-4b7a-9374-2473a3ac3938"), "ScopusID" },
                    { new Guid("c5d6ed1c-b739-4e46-b830-e398617b3204"), null, new Guid("7fa1de20-9794-4d76-b204-85143dc4b91f"), true, true, new Guid("8421876f-de74-4782-bffb-cb4e62a4d2f4"), "ResearcherID" },
                    { new Guid("c85d3f8b-e1e3-4b3e-8aa3-4c1a01bef503"), null, new Guid("c32c6b6e-9808-4549-9421-f2cca85364e0"), false, true, new Guid("2cf3a6e4-cecb-43f9-a32c-a1384c6904a4"), null },
                    { new Guid("ca17313a-b6fa-4dab-af82-83330413409d"), null, new Guid("3199fba0-af14-47aa-917a-5b0bb663e014"), false, true, new Guid("51279d19-b2b4-4b7a-9374-2473a3ac3938"), null },
                    { new Guid("ca85ebba-6d76-4c89-9240-55f31aa8410a"), null, new Guid("e05e0e2b-4ec5-47e1-9bfe-4e0a4666da58"), false, true, new Guid("bc287c35-4f11-4794-b678-7232ec4a51e5"), null },
                    { new Guid("d7412333-7809-4a01-82a9-7bc0cafd104f"), null, new Guid("8357ae79-c03e-48ab-8e0f-ada6323577f7"), false, true, new Guid("80b6f6e9-e2e1-4e16-944e-45d2aae5fac3"), null },
                    { new Guid("d8bdc2aa-73ae-4cd6-a9c1-4a34dddeb9b7"), null, new Guid("8357ae79-c03e-48ab-8e0f-ada6323577f7"), false, true, new Guid("8421876f-de74-4782-bffb-cb4e62a4d2f4"), null },
                    { new Guid("e70c2df9-7c5c-4bf4-b6f4-fc4fab5a2e57"), null, new Guid("8357ae79-c03e-48ab-8e0f-ada6323577f7"), false, true, new Guid("2cf3a6e4-cecb-43f9-a32c-a1384c6904a4"), null },
                    { new Guid("e95b698d-3ebd-4b72-89a0-5e478b0af582"), null, new Guid("7fa1de20-9794-4d76-b204-85143dc4b91f"), true, true, new Guid("80b6f6e9-e2e1-4e16-944e-45d2aae5fac3"), "ORCiD" },
                    { new Guid("fab88969-abca-4ef5-a63d-bfd31653a099"), null, new Guid("e05e0e2b-4ec5-47e1-9bfe-4e0a4666da58"), false, true, new Guid("80b6f6e9-e2e1-4e16-944e-45d2aae5fac3"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), new Guid("2bbf8971-c205-4a7f-8a88-8ccfa5f4f581") },
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), new Guid("2f823461-2828-4f9f-89ee-09e1cf162e9b") },
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), new Guid("367000e4-2bc6-425f-a78a-056f1537dc7c") },
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), new Guid("4005ae02-9121-416f-baa3-3674c19fe89e") },
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), new Guid("42751ccd-1df8-43b6-9a92-361e3b86a93a") },
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), new Guid("507f8cc7-9c24-4086-b8a5-ad6e17978b68") },
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), new Guid("55d19766-9924-46bb-ac91-da66554a2eba") },
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), new Guid("990e7453-f5a1-470a-998e-ec960a7db2e7") },
                    { new Guid("335d24a9-9be2-4193-851c-1a2cbaf51a8f"), new Guid("e93f6f73-d5a6-4a50-9761-26d1fe7d5016") },
                    { new Guid("4f700521-29a7-48ce-b570-b6f8f4ba247b"), new Guid("123b73e2-3734-434b-b370-c940143c5630") },
                    { new Guid("4f700521-29a7-48ce-b570-b6f8f4ba247b"), new Guid("6b5c71fd-14df-413f-8bfd-b1d96e9d9442") },
                    { new Guid("4f700521-29a7-48ce-b570-b6f8f4ba247b"), new Guid("b0042889-c9a8-4509-9afd-b35647fdd907") },
                    { new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe"), new Guid("34a5f1fa-1859-4287-922e-179b40cee4ce") },
                    { new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe"), new Guid("41809e75-9e8d-4629-8d6b-a4a3a5a0e19c") },
                    { new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe"), new Guid("6e1ce4fb-a8c7-4f05-9b65-2f6f39f5cf21") },
                    { new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe"), new Guid("763130d8-f0f6-4986-abbb-99457fa4af2a") },
                    { new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe"), new Guid("b897c450-c565-4d4e-9d89-a87629b9f3a8") },
                    { new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe"), new Guid("c40e98f0-3885-4aa5-ba04-cee82c91b79a") },
                    { new Guid("71d7bee1-b8f7-4e0e-9f65-6061df66adfe"), new Guid("f1c7d042-abfc-442b-a3d3-d4c796492797") },
                    { new Guid("bae51a96-b0ca-4c25-b4ab-713dfd3461a8"), new Guid("9c34caf0-b7d6-4064-8ef0-22fb609a3db5") },
                    { new Guid("bae51a96-b0ca-4c25-b4ab-713dfd3461a8"), new Guid("c5072d86-82dd-4c2c-b8a5-b790c1cb49c1") },
                    { new Guid("e3064d0e-15dc-4f37-a870-7b9dc7cd9e56"), new Guid("2bbf8971-c205-4a7f-8a88-8ccfa5f4f581") },
                    { new Guid("e3064d0e-15dc-4f37-a870-7b9dc7cd9e56"), new Guid("990e7453-f5a1-470a-998e-ec960a7db2e7") },
                    { new Guid("e3064d0e-15dc-4f37-a870-7b9dc7cd9e56"), new Guid("b0042889-c9a8-4509-9afd-b35647fdd907") },
                    { new Guid("ed4a7a57-bbdf-4a99-a1a4-4e293d2f46a4"), new Guid("1b3648a1-625e-4a6b-b88d-79065380e07d") },
                    { new Guid("ed4a7a57-bbdf-4a99-a1a4-4e293d2f46a4"), new Guid("49789682-e2f0-4049-9188-167f0143250c") },
                    { new Guid("ed4a7a57-bbdf-4a99-a1a4-4e293d2f46a4"), new Guid("5ac16067-ca9d-49f9-9999-15625c2b720d") },
                    { new Guid("ed4a7a57-bbdf-4a99-a1a4-4e293d2f46a4"), new Guid("b18c5554-abe6-44e6-b3e7-7058283a2b4c") },
                    { new Guid("ed4a7a57-bbdf-4a99-a1a4-4e293d2f46a4"), new Guid("ef2ecb03-19a7-42a4-975d-152affb69028") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("03dc0b3f-bb06-4b27-8f5d-a5f620ece33f"), new Guid("0e1c6ba5-1cd4-49c1-abfe-16809dbdc566"), null, "Изобретение" },
                    { new Guid("0794890b-1239-4d88-b191-8545e60dafc6"), new Guid("b0048747-bd8b-4447-b9d1-80e897c2d70d"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("24a3d59d-9f22-4b8b-8f90-83a289166f86"), new Guid("42b21cb3-5b7f-4e91-b2a5-5f1243c9dc4f"), null, "Исполнитель" },
                    { new Guid("25d5c9ca-cdda-416f-bd4a-a5510544a12e"), new Guid("0e1c6ba5-1cd4-49c1-abfe-16809dbdc566"), null, "База данных" },
                    { new Guid("38f7d92c-864c-4f5b-a469-94ca2df15abd"), new Guid("0e1c6ba5-1cd4-49c1-abfe-16809dbdc566"), null, "Полезная модель" },
                    { new Guid("50e06e39-cfa7-41b2-a962-9345c0917dc7"), new Guid("bfd0158e-5b43-436d-bcfb-f5196cae1541"), null, "Региональный" },
                    { new Guid("5b177fee-3e89-42bb-97b8-54a0c4d08071"), new Guid("42b21cb3-5b7f-4e91-b2a5-5f1243c9dc4f"), null, "Руководитель" },
                    { new Guid("616614f1-e579-4278-b48d-604c9567eb21"), new Guid("bfd0158e-5b43-436d-bcfb-f5196cae1541"), null, "Международный" },
                    { new Guid("6a1591c0-ee3a-40f9-a0a2-59f8ae2d221a"), new Guid("b0048747-bd8b-4447-b9d1-80e897c2d70d"), null, "Монография" },
                    { new Guid("70fd17cf-5dbe-43e9-a375-aba17580c56e"), new Guid("b0048747-bd8b-4447-b9d1-80e897c2d70d"), null, "Учебник" },
                    { new Guid("7b83f517-d985-4257-be41-78813d514dda"), new Guid("80d1947b-9d2d-4d22-8064-c7e572c0d6a2"), null, "Лабораторные" },
                    { new Guid("7c112782-ed82-4681-8e1a-20ec0a385a59"), new Guid("3732ea42-6e19-43c1-8352-f7eb25724862"), null, "Полезная модель" },
                    { new Guid("9c625306-34f7-45bc-aafd-b6b3896772e2"), new Guid("3732ea42-6e19-43c1-8352-f7eb25724862"), null, "Изобретение" },
                    { new Guid("b9019086-2246-445a-8b18-725b391d2fa8"), new Guid("3732ea42-6e19-43c1-8352-f7eb25724862"), null, "База данных" },
                    { new Guid("d392ab6b-6c34-4aa1-9827-5611b4edeb44"), new Guid("80d1947b-9d2d-4d22-8064-c7e572c0d6a2"), null, "Лекции" },
                    { new Guid("dfb19929-4e36-4d59-a03e-9e264b26a97d"), new Guid("bfd0158e-5b43-436d-bcfb-f5196cae1541"), null, "Всероссийский" }
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
