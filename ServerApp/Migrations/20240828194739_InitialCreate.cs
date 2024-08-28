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
                    TableId = table.Column<Guid>(type: "TEXT", nullable: true),
                    EvaluationMethodName = table.Column<string>(type: "TEXT", maxLength: 128, nullable: true)
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
                    { new Guid("5133fb16-f530-4949-a442-01025e5a15e0"), 5, "Отклонена" },
                    { new Guid("6fc8a9ce-c155-4c23-a655-f88115efb567"), 3, "В процессе оценки" },
                    { new Guid("85c3a347-f125-4567-8b66-b10cc6e1ad83"), 2, "В ожидании оценки" },
                    { new Guid("960e90d9-3dfb-44cb-9b51-c488a959103d"), 1, "В ожидании заполнения" },
                    { new Guid("e9270362-c517-4246-876d-1e3c65c1ea3a"), 4, "Одобрена" }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("3262f336-1f7d-41b9-8123-ee8b9f2397cb"), "Общая информация", 1 },
                    { new Guid("43ebc997-d57c-47a2-bd19-930cf94844b5"), "Категория участников", 2 },
                    { new Guid("6c790915-357f-4bcb-89e9-0fdb690dc149"), "Деятельность", 5 },
                    { new Guid("ebb88e8e-6005-4f6b-a595-c2b922171f73"), "Деятельность", 4 },
                    { new Guid("fc6ae1dc-8d65-4df8-b228-3e81261ed611"), "Профессиональное развитие", 3 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("62f5d92b-af9f-4e47-a3d1-8e5431c3f40b"), "Методическая деятельность", 3 },
                    { new Guid("87ab9154-842c-4597-b332-8093caf1e1ca"), "Инновационная и иная деятельность", 6 },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("b6c8a191-3bb8-492f-9a8c-650624406bd8"), "Профессиональные показатели", 4 },
                    { new Guid("c5270e79-44fb-4682-924f-a604a9ba276c"), "Основной", 1 },
                    { new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9"), "Образовательная деятельность", 2 },
                    { new Guid("ef15102a-6c09-4fde-ba88-0348d74c1d32"), "Конкурсная работа", 7 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0e5ddfe5-155e-4378-a930-1e032ec3baa3"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("bcf46871-31eb-4ece-abf7-64e0f0a727b0"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("20bba253-9c09-4338-b813-cc1f58eb50d0"), "User 2", "user@mail.ru" },
                    { new Guid("cfd42705-cfb1-46eb-9d66-e0a8e011902b"), "User 1", "admin@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0449aa50-1480-4fb2-b641-b2f450053764"), "int" },
                    { new Guid("49e37e57-e921-4e28-9833-bf189a361827"), "string" },
                    { new Guid("d44bee15-7fd2-4443-99a9-e86ed4d99873"), "bool" },
                    { new Guid("e7962e03-32b8-4fd2-85bd-85bfb96c2c19"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("3262f336-1f7d-41b9-8123-ee8b9f2397cb"), new Guid("0e5ddfe5-155e-4378-a930-1e032ec3baa3") },
                    { new Guid("3262f336-1f7d-41b9-8123-ee8b9f2397cb"), new Guid("bcf46871-31eb-4ece-abf7-64e0f0a727b0") },
                    { new Guid("43ebc997-d57c-47a2-bd19-930cf94844b5"), new Guid("0e5ddfe5-155e-4378-a930-1e032ec3baa3") },
                    { new Guid("43ebc997-d57c-47a2-bd19-930cf94844b5"), new Guid("bcf46871-31eb-4ece-abf7-64e0f0a727b0") },
                    { new Guid("6c790915-357f-4bcb-89e9-0fdb690dc149"), new Guid("bcf46871-31eb-4ece-abf7-64e0f0a727b0") },
                    { new Guid("ebb88e8e-6005-4f6b-a595-c2b922171f73"), new Guid("0e5ddfe5-155e-4378-a930-1e032ec3baa3") },
                    { new Guid("fc6ae1dc-8d65-4df8-b228-3e81261ed611"), new Guid("0e5ddfe5-155e-4378-a930-1e032ec3baa3") },
                    { new Guid("fc6ae1dc-8d65-4df8-b228-3e81261ed611"), new Guid("bcf46871-31eb-4ece-abf7-64e0f0a727b0") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "Name", "Number", "Placeholder", "Required", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("05b4b270-5eed-46bc-843e-6f1605a6adb1"), new Guid("3262f336-1f7d-41b9-8123-ee8b9f2397cb"), null, "Должность", 9, "Введите свою должность в организации", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("0fce9a83-14f0-456e-83fe-98d52bb676e3"), new Guid("6c790915-357f-4bcb-89e9-0fdb690dc149"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", "Защитившиеся кандидаты наук", 24, "Введите количество", true, new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("19b86aea-66ef-485b-8655-d134bda9c9d5"), new Guid("3262f336-1f7d-41b9-8123-ee8b9f2397cb"), null, "Место работы/учебы", 6, "Название организации", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("3bc3b338-20dc-43ca-8dfb-f48e3bf6853d"), new Guid("ebb88e8e-6005-4f6b-a595-c2b922171f73"), "Руководство дипломными проектами за предыдущий учебный год", "Защитившиеся бакалавры", 21, "Введите количество", true, new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("514643dd-5250-494f-b54d-192824efdddc"), new Guid("ebb88e8e-6005-4f6b-a595-c2b922171f73"), null, "Защитившиеся магистры", 23, "Введите количество", true, new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("5ac76f06-36c4-48bc-89c7-a4970ee771b5"), new Guid("3262f336-1f7d-41b9-8123-ee8b9f2397cb"), null, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", true, new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("60d16eae-8f98-4d47-ae20-22b17db772f0"), new Guid("3262f336-1f7d-41b9-8123-ee8b9f2397cb"), null, "Дополнительная информация", 11, "Пример", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("6b3e8a96-8227-411e-8e6a-75cb36c7713c"), new Guid("3262f336-1f7d-41b9-8123-ee8b9f2397cb"), null, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("75a0fb5c-52cb-4189-aa7c-30408c69aa3f"), new Guid("43ebc997-d57c-47a2-bd19-930cf94844b5"), null, "Научная специальность (по классификации ВАК)", 18, "Введите научную специальность (по классификации ВАК)", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("8c448c2b-2be3-4e00-a6af-dc51883e8bf4"), new Guid("ebb88e8e-6005-4f6b-a595-c2b922171f73"), null, "Защитившиеся доктора наук", 20, "Введите количество", true, new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("920e2501-178c-4708-b6ef-f553126525d7"), new Guid("43ebc997-d57c-47a2-bd19-930cf94844b5"), null, "Ученая степень", 17, "Выберите ученую степень", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("a73934a5-ab74-4eb8-93dc-5fe58b1b9752"), new Guid("3262f336-1f7d-41b9-8123-ee8b9f2397cb"), null, "Адрес работы/учебы", 7, "Регион, город, улица, дом", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("b729d1bd-5145-45b7-b05b-69115619f42e"), new Guid("43ebc997-d57c-47a2-bd19-930cf94844b5"), null, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 13, "Выберите категорию участника конкруса", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("c6ca29c9-ecde-4706-9de3-0a0d13e185c7"), new Guid("43ebc997-d57c-47a2-bd19-930cf94844b5"), null, "Название конкурсной работы", 14, "Введите название своей конкурсной работы", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("c9ceee42-378c-4828-a02c-2695f38c29fd"), new Guid("3262f336-1f7d-41b9-8123-ee8b9f2397cb"), null, "Дата рождения", 2, "01.01.2000", true, new Guid("e7962e03-32b8-4fd2-85bd-85bfb96c2c19") },
                    { new Guid("d86dd019-d3f8-43e7-8ae6-bef9af6c4eda"), new Guid("3262f336-1f7d-41b9-8123-ee8b9f2397cb"), null, "ФИО", 1, "Иванов Иван Иванович", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("da679a09-f018-429d-92e4-90a561e473b3"), new Guid("3262f336-1f7d-41b9-8123-ee8b9f2397cb"), null, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("db96ca45-0d2a-4e47-bb25-79f34039be2d"), new Guid("3262f336-1f7d-41b9-8123-ee8b9f2397cb"), null, "Контактный телефон", 4, "+8 (900)-000-00-00", true, new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("db995e60-b165-423b-94db-f57892d0429d"), new Guid("43ebc997-d57c-47a2-bd19-930cf94844b5"), null, "Направление конкурса", 12, "Выберите направление конкурса", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("dd53203a-0f3c-4863-9553-3287d3fdc04b"), new Guid("43ebc997-d57c-47a2-bd19-930cf94844b5"), null, "Ссылка на конкурсную работу", 15, "Введите ссылку своей конкурсной работы", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("e52b2d58-dc60-48c9-ac7c-6e201cac1598"), new Guid("3262f336-1f7d-41b9-8123-ee8b9f2397cb"), null, "Электронная почта", 5, "user@example.com", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("f39586bd-8feb-456a-a81b-185544ac3d19"), new Guid("ebb88e8e-6005-4f6b-a595-c2b922171f73"), null, "Защитившиеся специалисты", 22, "Введите количество", true, new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("f3b425c8-375c-4f58-b328-44425c35885e"), new Guid("6c790915-357f-4bcb-89e9-0fdb690dc149"), null, "Защитившиеся доктора наук", 25, "Введите количество", true, new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("f6f05f30-74ab-4e20-8bed-d3e7a8976034"), new Guid("ebb88e8e-6005-4f6b-a595-c2b922171f73"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", "Защитившиеся кадидаты наук", 19, "Введите количество", true, new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("fb5a6c70-fa22-4586-a991-573bb6b6a0c7"), new Guid("43ebc997-d57c-47a2-bd19-930cf94844b5"), null, "Ученое звание", 16, "Выберите ученое звание", true, new Guid("49e37e57-e921-4e28-9833-bf189a361827") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("62f5d92b-af9f-4e47-a3d1-8e5431c3f40b"), new Guid("0e5ddfe5-155e-4378-a930-1e032ec3baa3") },
                    { new Guid("87ab9154-842c-4597-b332-8093caf1e1ca"), new Guid("bcf46871-31eb-4ece-abf7-64e0f0a727b0") },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), new Guid("bcf46871-31eb-4ece-abf7-64e0f0a727b0") },
                    { new Guid("b6c8a191-3bb8-492f-9a8c-650624406bd8"), new Guid("0e5ddfe5-155e-4378-a930-1e032ec3baa3") },
                    { new Guid("c5270e79-44fb-4682-924f-a604a9ba276c"), new Guid("0e5ddfe5-155e-4378-a930-1e032ec3baa3") },
                    { new Guid("c5270e79-44fb-4682-924f-a604a9ba276c"), new Guid("bcf46871-31eb-4ece-abf7-64e0f0a727b0") },
                    { new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9"), new Guid("0e5ddfe5-155e-4378-a930-1e032ec3baa3") },
                    { new Guid("ef15102a-6c09-4fde-ba88-0348d74c1d32"), new Guid("0e5ddfe5-155e-4378-a930-1e032ec3baa3") },
                    { new Guid("ef15102a-6c09-4fde-ba88-0348d74c1d32"), new Guid("bcf46871-31eb-4ece-abf7-64e0f0a727b0") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0987da84-6c51-4262-a347-dd5edbf40c2a"), new Guid("6c790915-357f-4bcb-89e9-0fdb690dc149"), false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("2d2a1c44-57ed-43eb-9446-7a5c12add509"), new Guid("ebb88e8e-6005-4f6b-a595-c2b922171f73"), false, "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 },
                    { new Guid("315eee96-3f7f-4f41-9ac4-1e71137746a2"), new Guid("ebb88e8e-6005-4f6b-a595-c2b922171f73"), false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("45c1e9b8-1691-44f6-a69b-4710b2df20ec"), new Guid("ebb88e8e-6005-4f6b-a595-c2b922171f73"), false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("4958877f-bcd1-442b-bf9f-21bd0665b1aa"), new Guid("ebb88e8e-6005-4f6b-a595-c2b922171f73"), false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("5802f8be-958b-46da-baea-f6baba8f35fe"), new Guid("6c790915-357f-4bcb-89e9-0fdb690dc149"), false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("59723e2f-bc6b-442f-8570-86978a47f9c0"), new Guid("ebb88e8e-6005-4f6b-a595-c2b922171f73"), false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("8518c094-1195-43e1-9a73-cd224cfa29ae"), new Guid("fc6ae1dc-8d65-4df8-b228-3e81261ed611"), false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("95714ccd-3586-496a-b3ae-e78b286991c7"), new Guid("ebb88e8e-6005-4f6b-a595-c2b922171f73"), false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("9a469748-a61b-4f17-9371-c8ef69e447c1"), new Guid("6c790915-357f-4bcb-89e9-0fdb690dc149"), false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("9c258316-aa8e-44fd-b36b-65cfeab242a5"), new Guid("6c790915-357f-4bcb-89e9-0fdb690dc149"), false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("b3703821-b0da-47b6-ae64-05349c158985"), new Guid("fc6ae1dc-8d65-4df8-b228-3e81261ed611"), false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f"), new Guid("6c790915-357f-4bcb-89e9-0fdb690dc149"), true, "Персональные идентификаторы и показатели", 10 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("03a6984e-386e-40c3-8afd-95fc273f04ea"), "Вид", 1, new Guid("9c258316-aa8e-44fd-b36b-65cfeab242a5"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("0679e985-c30c-4e6c-88b4-4ec7105db9bd"), "Название НИР/НИОКР", 1, new Guid("9a469748-a61b-4f17-9371-c8ef69e447c1"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("18291ef9-66c3-4622-a118-a8c7e007d7b7"), "Лекции (час.)", 3, new Guid("45c1e9b8-1691-44f6-a69b-4710b2df20ec"), new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("19cd3592-ea8e-4aaa-867c-df1cc1fbdd72"), "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("0987da84-6c51-4262-a347-dd5edbf40c2a"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("1e898892-52c0-4b25-b5e7-718c875ee33b"), "Количество публикаций в БАЗЕ", 3, new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f"), new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("1f6360f4-34a8-4280-8d80-5c37dae57411"), "Название организации/должность/ставка", 1, new Guid("315eee96-3f7f-4f41-9ac4-1e71137746a2"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("2659c1ab-94a2-4ed4-9075-fd424c0a1eb4"), "Название", 2, new Guid("2d2a1c44-57ed-43eb-9446-7a5c12add509"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("2697e848-6fc7-4111-8a30-c7498d2ce9c1"), "Вид публикации", 1, new Guid("2d2a1c44-57ed-43eb-9446-7a5c12add509"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("2ad6f488-5005-4ce6-9d79-9d069f6b2293"), "Издание, год", 4, new Guid("0987da84-6c51-4262-a347-dd5edbf40c2a"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("2d6f8edf-3420-498c-bd6c-7eddf743ac5a"), "Сумма финансирования (тыс. руб.)", 2, new Guid("9a469748-a61b-4f17-9371-c8ef69e447c1"), new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("2ffba51a-ce41-4f72-a8f4-2aac59671048"), "Название дисциплины", 1, new Guid("59723e2f-bc6b-442f-8570-86978a47f9c0"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("371c993b-e2dc-4011-b53c-cf497c7add21"), "Название статьи", 1, new Guid("0987da84-6c51-4262-a347-dd5edbf40c2a"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("4b8d974a-8730-495e-a833-b4ea485be0ae"), "Идентификатор", 2, new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("4e30cd4d-239b-4447-b909-d5191d5c420c"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("4958877f-bcd1-442b-bf9f-21bd0665b1aa"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("5071cbf0-eaa3-4c32-a74a-fc6a36f09bd7"), "Практические занятия (час.)", 4, new Guid("45c1e9b8-1691-44f6-a69b-4710b2df20ec"), new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("519f2b3d-f71c-4739-bf23-bc125cd1b468"), "Количество печатных листов", 4, new Guid("2d2a1c44-57ed-43eb-9446-7a5c12add509"), new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("5256d2e2-00d2-4584-9d54-6af1f5b97aa5"), "Количество часов", 4, new Guid("315eee96-3f7f-4f41-9ac4-1e71137746a2"), new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("6634e9d2-4777-4eef-91ca-0d27b58e181c"), "Статус конкурса", 3, new Guid("b3703821-b0da-47b6-ae64-05349c158985"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("681f2965-40e1-4279-9e2d-626962c44467"), "Вид деятельности (преподавательская)", 3, new Guid("315eee96-3f7f-4f41-9ac4-1e71137746a2"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("6975ace0-52e0-4a58-a3c9-29664e43e5de"), "Вид", 1, new Guid("5802f8be-958b-46da-baea-f6baba8f35fe"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("7035f684-69c3-4d47-a895-8e1e3b3d04de"), "Название конкурса", 2, new Guid("b3703821-b0da-47b6-ae64-05349c158985"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("70d7006d-5a90-400e-ac8f-6255fcb3a1a3"), "Название курса", 1, new Guid("95714ccd-3586-496a-b3ae-e78b286991c7"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("71e61752-ccfc-4555-a8b3-aef8daedf315"), "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("315eee96-3f7f-4f41-9ac4-1e71137746a2"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("72acd1c7-0c0c-4ed7-9efb-d7cf5db30ed2"), "Название разработки", 2, new Guid("5802f8be-958b-46da-baea-f6baba8f35fe"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("7931a137-e498-4779-96cf-317bd206e77c"), "Ссылка на платформу", 3, new Guid("95714ccd-3586-496a-b3ae-e78b286991c7"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("7dd450d6-9776-4950-9f79-82e40d771d7e"), "Название конкурса/премии", 2, new Guid("4958877f-bcd1-442b-bf9f-21bd0665b1aa"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("7f384921-e27d-4e44-b28d-983eba03e3a6"), "Год получения документа", 2, new Guid("8518c094-1195-43e1-9a73-cd224cfa29ae"), new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("82783601-5ada-4a26-a90b-f4533b5e4190"), "ФИО", 1, new Guid("4958877f-bcd1-442b-bf9f-21bd0665b1aa"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("86f03f55-4b0c-46dd-9096-af06f7e14b41"), "Статус (руководитель/исполнитель)", 4, new Guid("9a469748-a61b-4f17-9371-c8ef69e447c1"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("9a87a33f-d5a8-448a-af26-d0d168fdcd20"), "Год", 4, new Guid("95714ccd-3586-496a-b3ae-e78b286991c7"), new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("9f6ffac4-7f3b-4d48-a0de-2de53ce359b0"), "Период выполнения", 3, new Guid("9a469748-a61b-4f17-9371-c8ef69e447c1"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("a65deaf7-a076-403d-a2c0-bcf1338db3d8"), "Наименование курса", 1, new Guid("45c1e9b8-1691-44f6-a69b-4710b2df20ec"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("a6f7ed58-29e6-4547-8c93-aee99e2bc973"), "Индекс Хирша (за все время)", 5, new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("ac161dd7-0ccb-4206-997e-0f98d8e54a83"), "Соавторы", 2, new Guid("0987da84-6c51-4262-a347-dd5edbf40c2a"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("accfd2fe-e26b-4df8-89b5-274227831b49"), "Номер РИД", 4, new Guid("9c258316-aa8e-44fd-b36b-65cfeab242a5"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("ad5ff1df-e7e6-4653-b980-cde6ef9ecbd0"), "Год", 1, new Guid("b3703821-b0da-47b6-ae64-05349c158985"), new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("b4ab329a-3124-4d5d-999f-4d04f473706c"), "Наличие грифа", 5, new Guid("2d2a1c44-57ed-43eb-9446-7a5c12add509"), new Guid("d44bee15-7fd2-4443-99a9-e86ed4d99873") },
                    { new Guid("b8c0256c-8caf-41a0-a38c-eae771ede559"), "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("4958877f-bcd1-442b-bf9f-21bd0665b1aa"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("ba18f7e0-9969-4bd6-a37e-76d412ac186f"), "Итого (час.)", 5, new Guid("45c1e9b8-1691-44f6-a69b-4710b2df20ec"), new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("bcab9562-e26b-4804-81f6-30dfceda8973"), "Год", 3, new Guid("4958877f-bcd1-442b-bf9f-21bd0665b1aa"), new Guid("0449aa50-1480-4fb2-b641-b2f450053764") },
                    { new Guid("c68dd76a-dd8c-4f4a-9f5b-3670c70217ac"), "Название", 2, new Guid("9c258316-aa8e-44fd-b36b-65cfeab242a5"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("c85ae131-db33-41fa-9cf0-e647baca0951"), "Соавторы", 2, new Guid("95714ccd-3586-496a-b3ae-e78b286991c7"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("c94d21b1-55e5-467e-bd93-1a53568002e5"), "Название документа, реквизиты", 1, new Guid("8518c094-1195-43e1-9a73-cd224cfa29ae"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("cdf318e5-834c-406d-b04e-1114a835aea8"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("9a469748-a61b-4f17-9371-c8ef69e447c1"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("d7c3dcca-036f-4143-b4c3-a0076285d639"), "Соавторы", 3, new Guid("2d2a1c44-57ed-43eb-9446-7a5c12add509"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("d8bd6819-82d1-4683-a05c-e3460c6a46c7"), "Издательство, год", 6, new Guid("2d2a1c44-57ed-43eb-9446-7a5c12add509"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("dbcc6f75-3e39-40da-9d06-1be641b6787d"), "Награда", 4, new Guid("b3703821-b0da-47b6-ae64-05349c158985"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("dedbcdb5-8ed8-4fcb-af96-71c1cf9fe7be"), "Тип идентификатора", 1, new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("e7add3db-a83e-404c-b837-94c3db5468e8"), "Язык преподавания (русск./англ./др.)", 2, new Guid("45c1e9b8-1691-44f6-a69b-4710b2df20ec"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("eca8e385-6768-4de4-a30a-42e93651f3ff"), "Ссылка", 5, new Guid("b3703821-b0da-47b6-ae64-05349c158985"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("ecd3ce2f-c68c-4daf-9168-c017d14ced9c"), "Название организации в которую внедрена разработка", 3, new Guid("5802f8be-958b-46da-baea-f6baba8f35fe"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("edf33ea7-60df-46e6-8faa-c1550d735c60"), "ФИО соавторов", 3, new Guid("9c258316-aa8e-44fd-b36b-65cfeab242a5"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("f5e9d6cf-97cd-4962-b4c7-931ed5b73dc7"), "Вид (лекции, лабораторные)", 2, new Guid("59723e2f-bc6b-442f-8570-86978a47f9c0"), new Guid("49e37e57-e921-4e28-9833-bf189a361827") },
                    { new Guid("fb61e99f-9e70-4b21-85b7-5d785bb29fb5"), "Количество цитирований", 4, new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f"), new Guid("0449aa50-1480-4fb2-b641-b2f450053764") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("05b4b270-5eed-46bc-843e-6f1605a6adb1"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("0fce9a83-14f0-456e-83fe-98d52bb676e3"), new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171") },
                    { new Guid("19b86aea-66ef-485b-8655-d134bda9c9d5"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("3bc3b338-20dc-43ca-8dfb-f48e3bf6853d"), new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9") },
                    { new Guid("514643dd-5250-494f-b54d-192824efdddc"), new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9") },
                    { new Guid("5ac76f06-36c4-48bc-89c7-a4970ee771b5"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("60d16eae-8f98-4d47-ae20-22b17db772f0"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("6b3e8a96-8227-411e-8e6a-75cb36c7713c"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("75a0fb5c-52cb-4189-aa7c-30408c69aa3f"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("8c448c2b-2be3-4e00-a6af-dc51883e8bf4"), new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9") },
                    { new Guid("920e2501-178c-4708-b6ef-f553126525d7"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("a73934a5-ab74-4eb8-93dc-5fe58b1b9752"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("b729d1bd-5145-45b7-b05b-69115619f42e"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("c6ca29c9-ecde-4706-9de3-0a0d13e185c7"), new Guid("ef15102a-6c09-4fde-ba88-0348d74c1d32") },
                    { new Guid("c9ceee42-378c-4828-a02c-2695f38c29fd"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("d86dd019-d3f8-43e7-8ae6-bef9af6c4eda"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("da679a09-f018-429d-92e4-90a561e473b3"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("db96ca45-0d2a-4e47-bb25-79f34039be2d"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("db995e60-b165-423b-94db-f57892d0429d"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("dd53203a-0f3c-4863-9553-3287d3fdc04b"), new Guid("ef15102a-6c09-4fde-ba88-0348d74c1d32") },
                    { new Guid("e52b2d58-dc60-48c9-ac7c-6e201cac1598"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") },
                    { new Guid("f39586bd-8feb-456a-a81b-185544ac3d19"), new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9") },
                    { new Guid("f3b425c8-375c-4f58-b328-44425c35885e"), new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171") },
                    { new Guid("f6f05f30-74ab-4e20-8bed-d3e7a8976034"), new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9") },
                    { new Guid("fb5a6c70-fa22-4586-a991-573bb6b6a0c7"), new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171") },
                    { new Guid("fb5a6c70-fa22-4586-a991-573bb6b6a0c7"), new Guid("b6c8a191-3bb8-492f-9a8c-650624406bd8") },
                    { new Guid("fb5a6c70-fa22-4586-a991-573bb6b6a0c7"), new Guid("c5270e79-44fb-4682-924f-a604a9ba276c") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("62f5d92b-af9f-4e47-a3d1-8e5431c3f40b"), new Guid("2d2a1c44-57ed-43eb-9446-7a5c12add509") },
                    { new Guid("62f5d92b-af9f-4e47-a3d1-8e5431c3f40b"), new Guid("59723e2f-bc6b-442f-8570-86978a47f9c0") },
                    { new Guid("87ab9154-842c-4597-b332-8093caf1e1ca"), new Guid("5802f8be-958b-46da-baea-f6baba8f35fe") },
                    { new Guid("87ab9154-842c-4597-b332-8093caf1e1ca"), new Guid("8518c094-1195-43e1-9a73-cd224cfa29ae") },
                    { new Guid("87ab9154-842c-4597-b332-8093caf1e1ca"), new Guid("9c258316-aa8e-44fd-b36b-65cfeab242a5") },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), new Guid("0987da84-6c51-4262-a347-dd5edbf40c2a") },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), new Guid("9a469748-a61b-4f17-9371-c8ef69e447c1") },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), new Guid("b3703821-b0da-47b6-ae64-05349c158985") },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f") },
                    { new Guid("b6c8a191-3bb8-492f-9a8c-650624406bd8"), new Guid("8518c094-1195-43e1-9a73-cd224cfa29ae") },
                    { new Guid("b6c8a191-3bb8-492f-9a8c-650624406bd8"), new Guid("b3703821-b0da-47b6-ae64-05349c158985") },
                    { new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9"), new Guid("315eee96-3f7f-4f41-9ac4-1e71137746a2") },
                    { new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9"), new Guid("45c1e9b8-1691-44f6-a69b-4710b2df20ec") },
                    { new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9"), new Guid("4958877f-bcd1-442b-bf9f-21bd0665b1aa") },
                    { new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9"), new Guid("95714ccd-3586-496a-b3ae-e78b286991c7") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("02e732d6-ad75-4e7e-8801-11e3bd411ad7"), "EvaluateMark17", null, true, 5, "Баллы по базе Scopus:", 17, new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f") },
                    { new Guid("0d2c72c9-7a2f-462c-9b8b-bb12a31fbccf"), null, new Guid("dd53203a-0f3c-4863-9553-3287d3fdc04b"), false, 10, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("13bc9347-9f8b-4c86-934a-ec59c8847855"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("9c258316-aa8e-44fd-b36b-65cfeab242a5") },
                    { new Guid("153747d6-b944-49c7-99a8-48c53b9cb5e4"), "EvaluateMark20", new Guid("f3b425c8-375c-4f58-b328-44425c35885e"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("173c4f61-62bd-468e-9df7-eeefaf7c3540"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("2d2a1c44-57ed-43eb-9446-7a5c12add509") },
                    { new Guid("2581e593-1c38-4b23-ae2c-dbb131916cc2"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("9a469748-a61b-4f17-9371-c8ef69e447c1") },
                    { new Guid("28cb734d-cf30-4545-b164-3de78fac0d5d"), "EvaluateMark4", new Guid("f6f05f30-74ab-4e20-8bed-d3e7a8976034"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("29b559c2-9071-44b6-aee8-640bab3a87c4"), null, new Guid("dd53203a-0f3c-4863-9553-3287d3fdc04b"), false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null },
                    { new Guid("34b28ad5-553d-45fd-975e-4283cfc6d0f8"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("9a469748-a61b-4f17-9371-c8ef69e447c1") },
                    { new Guid("3b17b58c-fbdc-4efe-bb66-7340248c9caa"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("5802f8be-958b-46da-baea-f6baba8f35fe") },
                    { new Guid("404c4824-344e-488d-bf0a-77c18cc35dea"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("2d2a1c44-57ed-43eb-9446-7a5c12add509") },
                    { new Guid("68583bd3-357e-49b4-9644-429ee74125b7"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("0987da84-6c51-4262-a347-dd5edbf40c2a") },
                    { new Guid("765e3da5-6d4a-4fc7-b26d-226dfdfb06fc"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("45c1e9b8-1691-44f6-a69b-4710b2df20ec") },
                    { new Guid("8a180871-86ac-4d89-a26e-45d2668771ab"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("4958877f-bcd1-442b-bf9f-21bd0665b1aa") },
                    { new Guid("a301eb31-52c9-4a33-a2f3-f36a88cd52e8"), "EvaluateMark18", null, true, 3, "Баллы по базе РИНЦ:", 18, new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f") },
                    { new Guid("a35eeab7-6284-4701-a79a-2c1d78e16883"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("b3703821-b0da-47b6-ae64-05349c158985") },
                    { new Guid("b286f5eb-80c4-4c87-85d0-7bf63e560615"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("59723e2f-bc6b-442f-8570-86978a47f9c0") },
                    { new Guid("b319de81-e4ec-4c46-bc40-bfdb4fea677c"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("8518c094-1195-43e1-9a73-cd224cfa29ae") },
                    { new Guid("b8dd6055-2c2f-460e-b09f-c4b746bf181d"), "EvaluateMark5", new Guid("8c448c2b-2be3-4e00-a6af-dc51883e8bf4"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("c5d5b695-d4d3-4455-87eb-fcff04c506ac"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("95714ccd-3586-496a-b3ae-e78b286991c7") },
                    { new Guid("c9e9ff72-7e33-431c-8ba8-5b018e8ffe5a"), "EvaluateMark13", new Guid("fb5a6c70-fa22-4586-a991-573bb6b6a0c7"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("cb40234e-8762-4664-b059-a042363650c8"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("2d2a1c44-57ed-43eb-9446-7a5c12add509") },
                    { new Guid("cbb6490b-1b8b-4d4c-a0e0-7c57fb018c27"), "EvaluateMark3", new Guid("514643dd-5250-494f-b54d-192824efdddc"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("e00d31b1-2c91-427a-bb49-9d31625eb6ca"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("2d2a1c44-57ed-43eb-9446-7a5c12add509") },
                    { new Guid("e3a4d1e9-6a75-43ba-9e34-51def74e2942"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("45c1e9b8-1691-44f6-a69b-4710b2df20ec") },
                    { new Guid("f7ced967-024c-495b-8347-f2b34880d91d"), "EvaluateMark19", new Guid("0fce9a83-14f0-456e-83fe-98d52bb676e3"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("2af61f3f-b99e-446e-94e6-44cd28e81556"), true, new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f") },
                    { new Guid("56d51ac4-6f79-4c33-ba5f-54d013761e34"), true, new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f") },
                    { new Guid("5e9e152b-f831-48f3-a473-291676742096"), true, new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f") },
                    { new Guid("68e8a41f-ce2d-4104-b676-8adf4f6ba7be"), true, new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f") },
                    { new Guid("86cd7887-5268-4b4a-bfd3-0edcca7bfd6a"), true, new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f") },
                    { new Guid("9680b569-e257-488e-98b5-8ee8401d6ebc"), true, new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f") },
                    { new Guid("b9de5799-8ae2-4d33-a1aa-a6cd81598453"), true, new Guid("d9bad709-4baf-4b33-9278-eea2d9bc127f") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("26a44f21-feec-4fe6-949b-a6bc8b4ed450"), null, new Guid("db995e60-b165-423b-94db-f57892d0429d"), "АРХИТЕКТУРА" },
                    { new Guid("4aa9f7f7-d9e7-4f0e-a047-8d7e0071a91d"), null, new Guid("b729d1bd-5145-45b7-b05b-69115619f42e"), "Аспиранты, адъюнкты, ординаторы, ассистенты-стажеры, не имеющие ученой степени" },
                    { new Guid("4fad6c3a-1b47-44d4-ab51-b5febd84565a"), null, new Guid("fb5a6c70-fa22-4586-a991-573bb6b6a0c7"), "Профессор" },
                    { new Guid("75064748-60d3-496d-ad62-887e386ccab2"), null, new Guid("db995e60-b165-423b-94db-f57892d0429d"), "ЭЛЕКТРО- И ТЕПЛОЭНЕРГЕТИКА" },
                    { new Guid("8fc62bc7-2ab3-49a6-a33c-a5a02995a16b"), null, new Guid("b729d1bd-5145-45b7-b05b-69115619f42e"), "Имеющие ученую степень доктора наук" },
                    { new Guid("be3074c1-9182-4f84-80db-ff2f09fa35ce"), null, new Guid("fb5a6c70-fa22-4586-a991-573bb6b6a0c7"), "Доцент" },
                    { new Guid("c212c087-3d2b-405c-bd77-d9a98bb244c0"), null, new Guid("fb5a6c70-fa22-4586-a991-573bb6b6a0c7"), "Нет" },
                    { new Guid("cf5f886b-23ab-4f1c-a7a6-b588fe6fe275"), null, new Guid("db995e60-b165-423b-94db-f57892d0429d"), "ПРИКЛАДНАЯ ГЕОЛОГИЯ, ГОРНОЕ ДЕЛО, НЕФТЕГАЗОВОЕ ДЕЛО И ГЕОДЕЗИЯ" },
                    { new Guid("d1e7577d-150e-452d-a7bc-679feac0248c"), null, new Guid("db995e60-b165-423b-94db-f57892d0429d"), "СТРОИТЕЛЬСТВО И АРХИТЕКТУРА" },
                    { new Guid("d5c2a5d2-8385-4899-bfe0-534c514f31c1"), null, new Guid("db995e60-b165-423b-94db-f57892d0429d"), "ТЕХНИКА И ТЕХНОЛОГИИ СТРОИТЕЛЬСТВА" },
                    { new Guid("ec7f108e-c629-46e2-a33d-b27ba5ac4b2b"), null, new Guid("db995e60-b165-423b-94db-f57892d0429d"), "НЕДРОПОЛЬЗОВАНИЕ И ГОРНЫЕ НАУКИ" },
                    { new Guid("f26d5548-1530-448f-9888-79df766e85de"), null, new Guid("b729d1bd-5145-45b7-b05b-69115619f42e"), "Докторанты, имеющие ученую степень кандидата наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("04f7eb36-0cc8-42b2-a8ba-3c24e44128eb"), null, new Guid("a6f7ed58-29e6-4547-8c93-aee99e2bc973"), true, true, new Guid("9680b569-e257-488e-98b5-8ee8401d6ebc"), null },
                    { new Guid("157497c3-0f36-4323-a2cb-4219d62308d4"), null, new Guid("1e898892-52c0-4b25-b5e7-718c875ee33b"), false, true, new Guid("86cd7887-5268-4b4a-bfd3-0edcca7bfd6a"), null },
                    { new Guid("158f1454-5054-4b08-a3e7-12a10107e6f1"), null, new Guid("fb61e99f-9e70-4b21-85b7-5d785bb29fb5"), false, true, new Guid("56d51ac4-6f79-4c33-ba5f-54d013761e34"), null },
                    { new Guid("19b869f8-5d8a-4b0d-89e4-985b1f80f5ab"), null, new Guid("a6f7ed58-29e6-4547-8c93-aee99e2bc973"), true, true, new Guid("2af61f3f-b99e-446e-94e6-44cd28e81556"), null },
                    { new Guid("1e524354-1769-44ad-95e3-376a508bfe30"), null, new Guid("1e898892-52c0-4b25-b5e7-718c875ee33b"), false, true, new Guid("2af61f3f-b99e-446e-94e6-44cd28e81556"), null },
                    { new Guid("20a8a55f-3bc9-46e8-986f-f3cd3ebc88c8"), null, new Guid("fb61e99f-9e70-4b21-85b7-5d785bb29fb5"), false, true, new Guid("68e8a41f-ce2d-4104-b676-8adf4f6ba7be"), null },
                    { new Guid("2dfc9bb9-697a-4641-a940-57531d71a38a"), null, new Guid("dedbcdb5-8ed8-4fcb-af96-71c1cf9fe7be"), true, true, new Guid("5e9e152b-f831-48f3-a473-291676742096"), "РИНЦ AuthorID" },
                    { new Guid("3514c8b3-c4b7-416b-8c98-eae4177e299a"), null, new Guid("1e898892-52c0-4b25-b5e7-718c875ee33b"), false, true, new Guid("9680b569-e257-488e-98b5-8ee8401d6ebc"), null },
                    { new Guid("36569dad-9cb7-4217-a0b9-5e61d084abe1"), null, new Guid("a6f7ed58-29e6-4547-8c93-aee99e2bc973"), false, true, new Guid("b9de5799-8ae2-4d33-a1aa-a6cd81598453"), null },
                    { new Guid("38d26adf-7f26-4793-bf00-f7dc46f6802a"), null, new Guid("1e898892-52c0-4b25-b5e7-718c875ee33b"), false, true, new Guid("68e8a41f-ce2d-4104-b676-8adf4f6ba7be"), null },
                    { new Guid("3fcf2af8-d163-49b8-84fe-d89a1c187ff1"), null, new Guid("a6f7ed58-29e6-4547-8c93-aee99e2bc973"), false, true, new Guid("5e9e152b-f831-48f3-a473-291676742096"), null },
                    { new Guid("40f0f49e-dd6f-4187-973b-a007b201ab12"), null, new Guid("1e898892-52c0-4b25-b5e7-718c875ee33b"), false, true, new Guid("56d51ac4-6f79-4c33-ba5f-54d013761e34"), null },
                    { new Guid("492e6aeb-bdb0-4387-9348-8713c9eef46a"), null, new Guid("4b8d974a-8730-495e-a833-b4ea485be0ae"), false, true, new Guid("86cd7887-5268-4b4a-bfd3-0edcca7bfd6a"), null },
                    { new Guid("4c5dba1b-38e8-40d3-a6c0-9d2869505627"), null, new Guid("fb61e99f-9e70-4b21-85b7-5d785bb29fb5"), false, true, new Guid("86cd7887-5268-4b4a-bfd3-0edcca7bfd6a"), null },
                    { new Guid("4f47576e-83cf-4095-9c28-e7745d223847"), null, new Guid("fb61e99f-9e70-4b21-85b7-5d785bb29fb5"), true, true, new Guid("9680b569-e257-488e-98b5-8ee8401d6ebc"), null },
                    { new Guid("4f9a0f27-cf4a-48ff-80b7-5d0a760faad8"), null, new Guid("fb61e99f-9e70-4b21-85b7-5d785bb29fb5"), false, true, new Guid("b9de5799-8ae2-4d33-a1aa-a6cd81598453"), null },
                    { new Guid("57633b45-b7f7-4ede-8d74-5111b8de8838"), null, new Guid("4b8d974a-8730-495e-a833-b4ea485be0ae"), false, true, new Guid("5e9e152b-f831-48f3-a473-291676742096"), null },
                    { new Guid("5b9ab3ed-eaec-4045-bb1d-090adcecfda7"), null, new Guid("dedbcdb5-8ed8-4fcb-af96-71c1cf9fe7be"), true, true, new Guid("2af61f3f-b99e-446e-94e6-44cd28e81556"), "ORCiD" },
                    { new Guid("5bdfb083-2dc2-4dc4-b904-a3241c13a4c4"), null, new Guid("4b8d974a-8730-495e-a833-b4ea485be0ae"), false, true, new Guid("b9de5799-8ae2-4d33-a1aa-a6cd81598453"), null },
                    { new Guid("5db56017-5cf4-478d-9006-9f90d5555a43"), null, new Guid("fb61e99f-9e70-4b21-85b7-5d785bb29fb5"), false, true, new Guid("5e9e152b-f831-48f3-a473-291676742096"), null },
                    { new Guid("7275c018-40eb-42e7-aa95-27248c00d953"), null, new Guid("4b8d974a-8730-495e-a833-b4ea485be0ae"), false, true, new Guid("68e8a41f-ce2d-4104-b676-8adf4f6ba7be"), null },
                    { new Guid("85687252-4c82-4501-9dd8-791db1b900f0"), null, new Guid("1e898892-52c0-4b25-b5e7-718c875ee33b"), false, true, new Guid("b9de5799-8ae2-4d33-a1aa-a6cd81598453"), null },
                    { new Guid("b5d5cd0e-904f-4d06-886c-d34f26920855"), null, new Guid("fb61e99f-9e70-4b21-85b7-5d785bb29fb5"), true, true, new Guid("2af61f3f-b99e-446e-94e6-44cd28e81556"), null },
                    { new Guid("b6c1cf1e-d96f-4981-87de-a2235adeaee5"), null, new Guid("a6f7ed58-29e6-4547-8c93-aee99e2bc973"), false, true, new Guid("86cd7887-5268-4b4a-bfd3-0edcca7bfd6a"), null },
                    { new Guid("ba934b87-d319-46a7-83ef-83dc16673f37"), null, new Guid("4b8d974a-8730-495e-a833-b4ea485be0ae"), true, true, new Guid("9680b569-e257-488e-98b5-8ee8401d6ebc"), null },
                    { new Guid("c383e82d-6088-4ba9-943b-c8f3ffa84247"), null, new Guid("4b8d974a-8730-495e-a833-b4ea485be0ae"), true, true, new Guid("56d51ac4-6f79-4c33-ba5f-54d013761e34"), null },
                    { new Guid("c5f7b40a-6e10-4502-ac61-7da8d8c90986"), null, new Guid("dedbcdb5-8ed8-4fcb-af96-71c1cf9fe7be"), true, true, new Guid("86cd7887-5268-4b4a-bfd3-0edcca7bfd6a"), "ResearcherID" },
                    { new Guid("c818890b-1117-4ecf-9e22-00c3ddfece89"), null, new Guid("a6f7ed58-29e6-4547-8c93-aee99e2bc973"), true, true, new Guid("56d51ac4-6f79-4c33-ba5f-54d013761e34"), null },
                    { new Guid("d65bcafc-878e-4b9c-bbc9-0fb6a4295680"), null, new Guid("1e898892-52c0-4b25-b5e7-718c875ee33b"), false, true, new Guid("5e9e152b-f831-48f3-a473-291676742096"), null },
                    { new Guid("db799fd2-3545-4b81-9769-eb6e609b7bf4"), null, new Guid("4b8d974a-8730-495e-a833-b4ea485be0ae"), false, true, new Guid("2af61f3f-b99e-446e-94e6-44cd28e81556"), null },
                    { new Guid("de2e983d-e4bc-401f-90f2-e6d567c82d3a"), null, new Guid("dedbcdb5-8ed8-4fcb-af96-71c1cf9fe7be"), true, true, new Guid("9680b569-e257-488e-98b5-8ee8401d6ebc"), "Количество патентов" },
                    { new Guid("e5e812cb-9aec-426a-9819-fb18fb251d19"), null, new Guid("dedbcdb5-8ed8-4fcb-af96-71c1cf9fe7be"), true, true, new Guid("56d51ac4-6f79-4c33-ba5f-54d013761e34"), "Количество монографий/глав в монографии" },
                    { new Guid("ea0a9880-86bb-441e-ab10-bf288ac2f432"), null, new Guid("a6f7ed58-29e6-4547-8c93-aee99e2bc973"), false, true, new Guid("68e8a41f-ce2d-4104-b676-8adf4f6ba7be"), null },
                    { new Guid("f2f4d1ed-7da1-4027-a737-6f96b4962545"), null, new Guid("dedbcdb5-8ed8-4fcb-af96-71c1cf9fe7be"), true, true, new Guid("68e8a41f-ce2d-4104-b676-8adf4f6ba7be"), "ScopusID" },
                    { new Guid("f71ecbdd-6829-4d9e-a1aa-ef431a176be7"), null, new Guid("dedbcdb5-8ed8-4fcb-af96-71c1cf9fe7be"), true, true, new Guid("b9de5799-8ae2-4d33-a1aa-a6cd81598453"), "Google Scholar ID" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("62f5d92b-af9f-4e47-a3d1-8e5431c3f40b"), new Guid("173c4f61-62bd-468e-9df7-eeefaf7c3540") },
                    { new Guid("62f5d92b-af9f-4e47-a3d1-8e5431c3f40b"), new Guid("404c4824-344e-488d-bf0a-77c18cc35dea") },
                    { new Guid("62f5d92b-af9f-4e47-a3d1-8e5431c3f40b"), new Guid("b286f5eb-80c4-4c87-85d0-7bf63e560615") },
                    { new Guid("62f5d92b-af9f-4e47-a3d1-8e5431c3f40b"), new Guid("cb40234e-8762-4664-b059-a042363650c8") },
                    { new Guid("62f5d92b-af9f-4e47-a3d1-8e5431c3f40b"), new Guid("e00d31b1-2c91-427a-bb49-9d31625eb6ca") },
                    { new Guid("87ab9154-842c-4597-b332-8093caf1e1ca"), new Guid("13bc9347-9f8b-4c86-934a-ec59c8847855") },
                    { new Guid("87ab9154-842c-4597-b332-8093caf1e1ca"), new Guid("3b17b58c-fbdc-4efe-bb66-7340248c9caa") },
                    { new Guid("87ab9154-842c-4597-b332-8093caf1e1ca"), new Guid("b319de81-e4ec-4c46-bc40-bfdb4fea677c") },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), new Guid("02e732d6-ad75-4e7e-8801-11e3bd411ad7") },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), new Guid("153747d6-b944-49c7-99a8-48c53b9cb5e4") },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), new Guid("2581e593-1c38-4b23-ae2c-dbb131916cc2") },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), new Guid("34b28ad5-553d-45fd-975e-4283cfc6d0f8") },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), new Guid("68583bd3-357e-49b4-9644-429ee74125b7") },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), new Guid("a301eb31-52c9-4a33-a2f3-f36a88cd52e8") },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), new Guid("a35eeab7-6284-4701-a79a-2c1d78e16883") },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), new Guid("c9e9ff72-7e33-431c-8ba8-5b018e8ffe5a") },
                    { new Guid("8ff2c813-08a0-4753-a4cc-ed6db4776171"), new Guid("f7ced967-024c-495b-8347-f2b34880d91d") },
                    { new Guid("b6c8a191-3bb8-492f-9a8c-650624406bd8"), new Guid("a35eeab7-6284-4701-a79a-2c1d78e16883") },
                    { new Guid("b6c8a191-3bb8-492f-9a8c-650624406bd8"), new Guid("b319de81-e4ec-4c46-bc40-bfdb4fea677c") },
                    { new Guid("b6c8a191-3bb8-492f-9a8c-650624406bd8"), new Guid("c9e9ff72-7e33-431c-8ba8-5b018e8ffe5a") },
                    { new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9"), new Guid("28cb734d-cf30-4545-b164-3de78fac0d5d") },
                    { new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9"), new Guid("765e3da5-6d4a-4fc7-b26d-226dfdfb06fc") },
                    { new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9"), new Guid("8a180871-86ac-4d89-a26e-45d2668771ab") },
                    { new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9"), new Guid("b8dd6055-2c2f-460e-b09f-c4b746bf181d") },
                    { new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9"), new Guid("c5d5b695-d4d3-4455-87eb-fcff04c506ac") },
                    { new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9"), new Guid("cbb6490b-1b8b-4d4c-a0e0-7c57fb018c27") },
                    { new Guid("d1e4407f-390c-422c-97d7-572ca512f6a9"), new Guid("e3a4d1e9-6a75-43ba-9e34-51def74e2942") },
                    { new Guid("ef15102a-6c09-4fde-ba88-0348d74c1d32"), new Guid("0d2c72c9-7a2f-462c-9b8b-bb12a31fbccf") },
                    { new Guid("ef15102a-6c09-4fde-ba88-0348d74c1d32"), new Guid("29b559c2-9071-44b6-aee8-640bab3a87c4") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("194ef528-30a5-4f24-929d-3a1367a22aea"), new Guid("6975ace0-52e0-4a58-a3c9-29664e43e5de"), null, "База данных" },
                    { new Guid("37eae5d1-558f-4cb7-b335-3c7c579ea0b3"), new Guid("2697e848-6fc7-4111-8a30-c7498d2ce9c1"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("4591285c-1dd3-4519-9807-3aeec785b5dc"), new Guid("03a6984e-386e-40c3-8afd-95fc273f04ea"), null, "Полезная модель" },
                    { new Guid("4b1b6e1d-252c-43fc-9406-10a937cae0e3"), new Guid("2697e848-6fc7-4111-8a30-c7498d2ce9c1"), null, "Учебник" },
                    { new Guid("5746d784-6806-416a-b8e5-58c294925c2a"), new Guid("6634e9d2-4777-4eef-91ca-0d27b58e181c"), null, "Региональный" },
                    { new Guid("5fdc45fd-d496-4ba7-9def-78ec7ef5892b"), new Guid("03a6984e-386e-40c3-8afd-95fc273f04ea"), null, "Изобретение" },
                    { new Guid("60b43d11-6ad8-42e5-88cb-278aca09b406"), new Guid("03a6984e-386e-40c3-8afd-95fc273f04ea"), null, "База данных" },
                    { new Guid("7b7a0f74-736c-4836-8b57-b0cf05194d06"), new Guid("2697e848-6fc7-4111-8a30-c7498d2ce9c1"), null, "Монография" },
                    { new Guid("a0f757a1-0411-4067-82b0-91db2210ed62"), new Guid("86f03f55-4b0c-46dd-9096-af06f7e14b41"), null, "Руководитель" },
                    { new Guid("b3440ba5-1aa7-4beb-ad86-f141a2caf6ad"), new Guid("6975ace0-52e0-4a58-a3c9-29664e43e5de"), null, "Полезная модель" },
                    { new Guid("b6d2039f-01e5-4f9c-93c6-578fedec4264"), new Guid("6634e9d2-4777-4eef-91ca-0d27b58e181c"), null, "Международный" },
                    { new Guid("c0ac638e-7bc4-4175-b473-42e26ef254fa"), new Guid("6634e9d2-4777-4eef-91ca-0d27b58e181c"), null, "Всероссийский" },
                    { new Guid("c4228884-5ad6-47b0-90b4-7ddae5843243"), new Guid("f5e9d6cf-97cd-4962-b4c7-931ed5b73dc7"), null, "Лабораторные" },
                    { new Guid("d18a6caf-8cd0-4352-bc6d-04c35ecd8f2c"), new Guid("86f03f55-4b0c-46dd-9096-af06f7e14b41"), null, "Исполнитель" },
                    { new Guid("ef77e3ad-dba7-4a97-94b0-e69eb56cd542"), new Guid("6975ace0-52e0-4a58-a3c9-29664e43e5de"), null, "Изобретение" },
                    { new Guid("fbaeacae-a218-4df3-a3af-b53fdaaf2181"), new Guid("f5e9d6cf-97cd-4962-b4c7-931ed5b73dc7"), null, "Лекции" }
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
