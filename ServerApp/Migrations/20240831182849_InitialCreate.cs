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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
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
                    CategoryId = table.Column<Guid>(type: "TEXT", nullable: true),
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
                        name: "FK_ApplicationForms_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
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
                    IsRequired = table.Column<bool>(type: "INTEGER", nullable: false),
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
                    IsRequired = table.Column<bool>(type: "INTEGER", nullable: false),
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
                    { new Guid("57ada0f7-8ce1-4a8d-9b3e-2704a4c3c9ed"), 5, "Отклонена" },
                    { new Guid("8bd065d1-9ed6-4efa-881a-1ba583d0b2e8"), 3, "В процессе рассмотрения" },
                    { new Guid("8e89f78d-1ecb-43ca-bb82-374ce7609e37"), 6, "Оценена" },
                    { new Guid("cf62fe48-9347-4eab-b4b5-bdb2bfb9fa7b"), 4, "Одобрена" },
                    { new Guid("d5b30fb7-180c-41cb-a182-01c0051e407b"), 2, "В ожидании рассмотрения" },
                    { new Guid("f6588c1d-90e5-44c3-8f59-af6e6c50f030"), 1, "В ожидании заполнения" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("2543067d-bd5d-4818-a75e-e382a64a5fec"), "Строительство и архитектура", 1 },
                    { new Guid("5d7b0e4c-d3f0-4840-ba6d-7fe4aec2ad53"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("3b6cb258-4e86-44ef-9cbe-dc29e0d2b154"), "Деятельность", 5 },
                    { new Guid("71ad9c25-dbac-4a82-81cc-95f94ad36715"), "Деятельность", 4 },
                    { new Guid("a8451fae-180d-4f0b-8651-c41d4a8cde60"), "Профессиональное развитие", 3 },
                    { new Guid("c7c56f5e-d9f8-4ff2-aa78-b7688a2a1ee6"), "Категория участников", 2 },
                    { new Guid("e50945b6-f490-4592-8343-8ac840552bb0"), "Общая информация", 1 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("2f6b0182-3a47-40b9-be91-f8f94f371c24"), "Методическая деятельность", 3 },
                    { new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e"), "Образовательная деятельность", 2 },
                    { new Guid("995848e7-3b94-442e-9e3c-f09b41718c77"), "Основной", 1 },
                    { new Guid("ab649fe1-ea2f-48b9-abf4-b5dfc551356c"), "Инновационная и иная деятельность", 6 },
                    { new Guid("b6d74014-2823-40a4-a380-0257cf43084b"), "Конкурсная работа", 7 },
                    { new Guid("e8e78abb-d51d-45c4-ac17-1e4804c47d68"), "Профессиональные показатели", 4 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("6bd33d06-b38a-409a-a31e-88696071968b"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("ad74a202-e9f4-4918-b735-290d3715277f"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("9d9de597-3fa1-47a0-a81c-b9b5b37d0e37"), "User 2", "user@mail.ru" },
                    { new Guid("ef2e6094-7283-4bd8-bba9-ef034775a448"), "User 1", "admin@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3a22da0d-80d9-4621-9c1f-f86e170f7fe3"), "DateTime" },
                    { new Guid("76529b15-5416-4a8a-b568-4d62194330eb"), "string" },
                    { new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1"), "int" },
                    { new Guid("dc0ca3d8-68f4-41b8-b3be-92061f60453b"), "bool" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("3b6cb258-4e86-44ef-9cbe-dc29e0d2b154"), new Guid("ad74a202-e9f4-4918-b735-290d3715277f") },
                    { new Guid("71ad9c25-dbac-4a82-81cc-95f94ad36715"), new Guid("6bd33d06-b38a-409a-a31e-88696071968b") },
                    { new Guid("a8451fae-180d-4f0b-8651-c41d4a8cde60"), new Guid("6bd33d06-b38a-409a-a31e-88696071968b") },
                    { new Guid("a8451fae-180d-4f0b-8651-c41d4a8cde60"), new Guid("ad74a202-e9f4-4918-b735-290d3715277f") },
                    { new Guid("c7c56f5e-d9f8-4ff2-aa78-b7688a2a1ee6"), new Guid("6bd33d06-b38a-409a-a31e-88696071968b") },
                    { new Guid("c7c56f5e-d9f8-4ff2-aa78-b7688a2a1ee6"), new Guid("ad74a202-e9f4-4918-b735-290d3715277f") },
                    { new Guid("e50945b6-f490-4592-8343-8ac840552bb0"), new Guid("6bd33d06-b38a-409a-a31e-88696071968b") },
                    { new Guid("e50945b6-f490-4592-8343-8ac840552bb0"), new Guid("ad74a202-e9f4-4918-b735-290d3715277f") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("01705476-13e3-4aea-b2c9-230cfa0d1b12"), new Guid("e50945b6-f490-4592-8343-8ac840552bb0"), null, true, "Место работы/учебы", 6, "Название организации", new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("09d68976-0b43-49cc-84ff-971bd3dc765a"), new Guid("e50945b6-f490-4592-8343-8ac840552bb0"), null, true, "Должность", 9, "Введите свою должность в организации", new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("0e2204d0-a8d5-4365-871d-3bd475d35a61"), new Guid("e50945b6-f490-4592-8343-8ac840552bb0"), null, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("1623d556-5df0-49db-aefb-a734b581edda"), new Guid("c7c56f5e-d9f8-4ff2-aa78-b7688a2a1ee6"), null, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("171f414e-4615-47a5-8794-d70ce06a9f4f"), new Guid("c7c56f5e-d9f8-4ff2-aa78-b7688a2a1ee6"), null, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("1e117d44-ab26-45fd-b494-ead3b1cb79ad"), new Guid("c7c56f5e-d9f8-4ff2-aa78-b7688a2a1ee6"), null, true, "Ссылка на конкурсную работу", 13, "Введите ссылку своей конкурсной работы", new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("2d6cb6b5-0a78-42ec-9955-8530c76b7a77"), new Guid("e50945b6-f490-4592-8343-8ac840552bb0"), null, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("4317ab69-fefb-4995-998c-dfae5159c894"), new Guid("e50945b6-f490-4592-8343-8ac840552bb0"), null, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("44ab130a-ccd8-426e-ae65-970b08fea4f3"), new Guid("71ad9c25-dbac-4a82-81cc-95f94ad36715"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("57293cf7-2cea-4965-8c66-5b2f6ea158bd"), new Guid("e50945b6-f490-4592-8343-8ac840552bb0"), null, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("6c85da0d-4059-4519-98f7-931a60f1a13f"), new Guid("e50945b6-f490-4592-8343-8ac840552bb0"), null, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("704234f6-8f0d-4060-bc0c-1b9a6b6202f8"), new Guid("71ad9c25-dbac-4a82-81cc-95f94ad36715"), "Руководство дипломными проектами за предыдущий учебный год", true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("71191a86-d9b7-49a6-88ad-5450267546ba"), new Guid("c7c56f5e-d9f8-4ff2-aa78-b7688a2a1ee6"), null, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("8195554a-96df-43bd-bd91-481ef2fef86a"), new Guid("3b6cb258-4e86-44ef-9cbe-dc29e0d2b154"), null, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("8a0658b6-4fb2-4cf8-afd0-a5555dcc8dcc"), new Guid("e50945b6-f490-4592-8343-8ac840552bb0"), null, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("8a7f1b4e-1d2d-406e-8476-cbbb9abed560"), new Guid("3b6cb258-4e86-44ef-9cbe-dc29e0d2b154"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("8e4e721f-46ca-4629-b16a-4c69938cee69"), new Guid("e50945b6-f490-4592-8343-8ac840552bb0"), null, true, "Электронная почта", 5, "user@example.com", new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("a0788d4e-1b28-4bbe-9ec6-13d7605baa8b"), new Guid("c7c56f5e-d9f8-4ff2-aa78-b7688a2a1ee6"), null, true, "Название конкурсной работы", 12, "Введите название своей конкурсной работы", new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("d23f2adf-9679-411f-be0f-46f7749be6fd"), new Guid("71ad9c25-dbac-4a82-81cc-95f94ad36715"), null, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("ef686a67-36ba-4f5e-a4b4-844d3c6b23a1"), new Guid("e50945b6-f490-4592-8343-8ac840552bb0"), null, true, "Дата рождения", 2, "01.01.2000", new Guid("3a22da0d-80d9-4621-9c1f-f86e170f7fe3") },
                    { new Guid("f08218d6-2c54-4a3f-96ec-377266048786"), new Guid("c7c56f5e-d9f8-4ff2-aa78-b7688a2a1ee6"), null, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("76529b15-5416-4a8a-b568-4d62194330eb") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1"), new Guid("ad74a202-e9f4-4918-b735-290d3715277f") },
                    { new Guid("2f6b0182-3a47-40b9-be91-f8f94f371c24"), new Guid("6bd33d06-b38a-409a-a31e-88696071968b") },
                    { new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e"), new Guid("6bd33d06-b38a-409a-a31e-88696071968b") },
                    { new Guid("995848e7-3b94-442e-9e3c-f09b41718c77"), new Guid("6bd33d06-b38a-409a-a31e-88696071968b") },
                    { new Guid("995848e7-3b94-442e-9e3c-f09b41718c77"), new Guid("ad74a202-e9f4-4918-b735-290d3715277f") },
                    { new Guid("ab649fe1-ea2f-48b9-abf4-b5dfc551356c"), new Guid("ad74a202-e9f4-4918-b735-290d3715277f") },
                    { new Guid("b6d74014-2823-40a4-a380-0257cf43084b"), new Guid("6bd33d06-b38a-409a-a31e-88696071968b") },
                    { new Guid("b6d74014-2823-40a4-a380-0257cf43084b"), new Guid("ad74a202-e9f4-4918-b735-290d3715277f") },
                    { new Guid("e8e78abb-d51d-45c4-ac17-1e4804c47d68"), new Guid("6bd33d06-b38a-409a-a31e-88696071968b") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("1783a927-4cb2-4aed-859b-46ec02fe8ddd"), new Guid("3b6cb258-4e86-44ef-9cbe-dc29e0d2b154"), true, "Персональные идентификаторы", 10 },
                    { new Guid("5ffe480a-0f3f-4a83-abe4-479c11b74091"), new Guid("a8451fae-180d-4f0b-8651-c41d4a8cde60"), false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("687672a7-7991-4415-b5cd-a3885b75b9e0"), new Guid("71ad9c25-dbac-4a82-81cc-95f94ad36715"), false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("939e3cc6-3a46-4c79-b1cd-5556cbd7161b"), new Guid("3b6cb258-4e86-44ef-9cbe-dc29e0d2b154"), false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("b32d42fc-5018-41af-bfe5-2f74a0d1994a"), new Guid("71ad9c25-dbac-4a82-81cc-95f94ad36715"), false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("ba0eb36c-860f-409e-9eb2-f1f14e9d3f67"), new Guid("71ad9c25-dbac-4a82-81cc-95f94ad36715"), false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("c2398fe9-6a10-49a5-b7f5-dc7f8546b456"), new Guid("3b6cb258-4e86-44ef-9cbe-dc29e0d2b154"), false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("c9978c55-8fac-4a3c-ac3a-2961da3918ca"), new Guid("71ad9c25-dbac-4a82-81cc-95f94ad36715"), false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("d3f57ba5-e9b4-4568-ab1b-049f3a76a56c"), new Guid("a8451fae-180d-4f0b-8651-c41d4a8cde60"), false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("dafd9b16-efad-48ca-9d89-ffc5e2052a3c"), new Guid("71ad9c25-dbac-4a82-81cc-95f94ad36715"), false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("e983487a-8a7d-46b1-be81-7c0fcf23b381"), new Guid("3b6cb258-4e86-44ef-9cbe-dc29e0d2b154"), false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("eea80838-f915-40d7-808f-66c38f510336"), new Guid("71ad9c25-dbac-4a82-81cc-95f94ad36715"), false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("ef3f6bc9-b899-416b-bde9-056b1c40fe6f"), new Guid("3b6cb258-4e86-44ef-9cbe-dc29e0d2b154"), false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("1667c9f9-c9b8-4515-a93c-aae148a1e01a"), true, "Год", 3, new Guid("687672a7-7991-4415-b5cd-a3885b75b9e0"), new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("182113e6-da85-4b5d-9043-19f05dcd400b"), true, "Название", 2, new Guid("dafd9b16-efad-48ca-9d89-ffc5e2052a3c"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("21727fc6-9da0-4fc1-b536-35499cdd9dfa"), true, "Название НИР/НИОКР", 1, new Guid("939e3cc6-3a46-4c79-b1cd-5556cbd7161b"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("21e44aa8-a6d0-434a-a867-79189ae81e0e"), true, "Вид деятельности (преподавательская)", 3, new Guid("c9978c55-8fac-4a3c-ac3a-2961da3918ca"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("29afeea6-df5f-4116-9806-817f49f6191d"), true, "Наименование курса", 1, new Guid("b32d42fc-5018-41af-bfe5-2f74a0d1994a"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("2fb475fa-5b8d-4aef-881c-233a55993bcc"), true, "Год", 1, new Guid("d3f57ba5-e9b4-4568-ab1b-049f3a76a56c"), new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("31534846-2ed5-43c4-9637-10fd7053c693"), true, "Вид", 1, new Guid("e983487a-8a7d-46b1-be81-7c0fcf23b381"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("46aac30b-67ac-4101-884f-115d10a53fa7"), true, "Год получения документа", 2, new Guid("5ffe480a-0f3f-4a83-abe4-479c11b74091"), new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("498d64ff-22af-4713-8156-cb1e447631be"), true, "Практические занятия (час.)", 4, new Guid("b32d42fc-5018-41af-bfe5-2f74a0d1994a"), new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("503096e0-6064-4901-83fd-00328a2d3c98"), true, "Итого (час.)", 5, new Guid("b32d42fc-5018-41af-bfe5-2f74a0d1994a"), new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("50a55657-57ea-466c-a724-f6f5a7dc8f28"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("687672a7-7991-4415-b5cd-a3885b75b9e0"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("525d7e71-1ced-4d54-9cc2-5c4586b2ddf1"), true, "Название организации/должность/ставка", 1, new Guid("c9978c55-8fac-4a3c-ac3a-2961da3918ca"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("551d7639-c932-4978-9096-94e9f643cb5b"), true, "Вид (лекции, лабораторные)", 2, new Guid("ba0eb36c-860f-409e-9eb2-f1f14e9d3f67"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("56769c9f-b1d3-42b9-b5c1-4e54543e45fe"), true, "Вид", 1, new Guid("ef3f6bc9-b899-416b-bde9-056b1c40fe6f"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("5ba175d5-3697-4f36-a9ea-87c1af4fce8b"), true, "Номер РИД", 4, new Guid("ef3f6bc9-b899-416b-bde9-056b1c40fe6f"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("600b79b9-627b-4401-8096-fba616138684"), true, "Издательство, год", 6, new Guid("dafd9b16-efad-48ca-9d89-ffc5e2052a3c"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("6019c5d7-48f9-4409-a8cc-bc7ba6512bb3"), false, "Тип идентификатора", 1, new Guid("1783a927-4cb2-4aed-859b-46ec02fe8ddd"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("603e19d5-2bef-46b6-b3ae-c31317184ae8"), true, "Название документа, реквизиты", 1, new Guid("5ffe480a-0f3f-4a83-abe4-479c11b74091"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("64e847cf-5ea6-47e5-bf07-1f6c60e26859"), true, "Статус конкурса", 3, new Guid("d3f57ba5-e9b4-4568-ab1b-049f3a76a56c"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("687e994b-26b1-411a-994c-32dc374562d6"), true, "Название разработки", 2, new Guid("e983487a-8a7d-46b1-be81-7c0fcf23b381"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("6f44de91-6d7a-4ae1-91fc-41629d11aa18"), true, "ФИО", 1, new Guid("687672a7-7991-4415-b5cd-a3885b75b9e0"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("79499466-6f90-4c3a-af88-e179222b3e00"), true, "Название", 2, new Guid("ef3f6bc9-b899-416b-bde9-056b1c40fe6f"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("87903667-5aeb-4816-b4cf-21c2389eeb39"), false, "Соавторы", 3, new Guid("dafd9b16-efad-48ca-9d89-ffc5e2052a3c"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("87ab4ab6-4d93-4dec-83ff-18c0a3495f7f"), true, "Вид публикации", 1, new Guid("dafd9b16-efad-48ca-9d89-ffc5e2052a3c"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("8ea7b9af-24ef-4706-90ce-861efb96ae8d"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("939e3cc6-3a46-4c79-b1cd-5556cbd7161b"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("947b9878-6877-4f54-ac27-c9964194b10c"), true, "Соавторы", 2, new Guid("c2398fe9-6a10-49a5-b7f5-dc7f8546b456"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("971d01e8-8fb1-47ef-8a19-2bc9114ce15a"), true, "Лекции (час.)", 3, new Guid("b32d42fc-5018-41af-bfe5-2f74a0d1994a"), new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("99509a75-e09c-4e28-980c-1690cf499772"), true, "Ссылка", 5, new Guid("d3f57ba5-e9b4-4568-ab1b-049f3a76a56c"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("a222f09b-556a-4359-ad74-d02d791d22cc"), true, "Название конкурса", 2, new Guid("d3f57ba5-e9b4-4568-ab1b-049f3a76a56c"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("a28fa750-54b1-45f0-8e87-6f16d1e7222a"), true, "Название дисциплины", 1, new Guid("ba0eb36c-860f-409e-9eb2-f1f14e9d3f67"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("a58d06d3-48c1-4135-91ce-7943101528bc"), true, "Количество часов", 4, new Guid("c9978c55-8fac-4a3c-ac3a-2961da3918ca"), new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("acf13628-fbae-44a3-b426-0f8bd6e28d9d"), true, "Количество печатных листов", 4, new Guid("dafd9b16-efad-48ca-9d89-ffc5e2052a3c"), new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("adcb8447-10e4-491d-81f1-affa2ce5713a"), false, "Идентификатор", 2, new Guid("1783a927-4cb2-4aed-859b-46ec02fe8ddd"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("b30e00df-13bf-4f16-baae-28f9fe908736"), true, "Год", 4, new Guid("eea80838-f915-40d7-808f-66c38f510336"), new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("b36bb234-2d8d-4e23-95a9-30c69513414f"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("939e3cc6-3a46-4c79-b1cd-5556cbd7161b"), new Guid("a1104cbd-bfff-41cf-8782-4062dc9e7fd1") },
                    { new Guid("c3a8516f-c32f-4afa-8523-3142e755a422"), true, "Название организации в которую внедрена разработка", 3, new Guid("e983487a-8a7d-46b1-be81-7c0fcf23b381"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("c46f4d7b-b106-4f0f-9cef-17ad97aa9bc3"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("c9978c55-8fac-4a3c-ac3a-2961da3918ca"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("c4c85f44-2836-4ddf-b36e-b97f932ae77d"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("b32d42fc-5018-41af-bfe5-2f74a0d1994a"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("c9a567a2-d8f0-4c65-9cd8-ffe983203211"), true, "Название курса", 1, new Guid("eea80838-f915-40d7-808f-66c38f510336"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("da4795dc-4ce8-43e0-b566-ce6ec0e9a4bf"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("c2398fe9-6a10-49a5-b7f5-dc7f8546b456"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("de305386-df97-4131-a575-a71f0f3dce95"), true, "Название статьи", 1, new Guid("c2398fe9-6a10-49a5-b7f5-dc7f8546b456"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("dea9d77b-e47b-4b38-9854-a9c51224cd9f"), true, "Ссылка на платформу", 3, new Guid("eea80838-f915-40d7-808f-66c38f510336"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("e2996728-32e0-44bb-8cda-982161de4a8b"), true, "Соавторы", 2, new Guid("eea80838-f915-40d7-808f-66c38f510336"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("e5a86250-16f4-4224-90b1-163cee613f02"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("687672a7-7991-4415-b5cd-a3885b75b9e0"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("ee4c1384-986e-4ada-bcb7-b66f74dbfef1"), true, "Издание, год", 4, new Guid("c2398fe9-6a10-49a5-b7f5-dc7f8546b456"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("ef43c6d4-9e5c-45af-acaa-09c1eed08fed"), true, "Период выполнения", 3, new Guid("939e3cc6-3a46-4c79-b1cd-5556cbd7161b"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("f20b9002-77bf-4492-ac26-c1bfe33f986f"), true, "Награда", 4, new Guid("d3f57ba5-e9b4-4568-ab1b-049f3a76a56c"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("f2cfa204-5ff2-4d4d-b2ab-8bbad5376d1d"), true, "Название конкурса/премии", 2, new Guid("687672a7-7991-4415-b5cd-a3885b75b9e0"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("fa7b68e8-b08f-4205-b8ce-0e46de0da60e"), true, "Наличие грифа", 5, new Guid("dafd9b16-efad-48ca-9d89-ffc5e2052a3c"), new Guid("dc0ca3d8-68f4-41b8-b3be-92061f60453b") },
                    { new Guid("fb6e4234-e33a-4721-a2d5-4cbf3088a3b2"), true, "ФИО соавторов", 3, new Guid("ef3f6bc9-b899-416b-bde9-056b1c40fe6f"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") },
                    { new Guid("ff36729a-e1ed-4332-bd54-14e036c2f0c9"), true, "Статус (руководитель/исполнитель)", 4, new Guid("939e3cc6-3a46-4c79-b1cd-5556cbd7161b"), new Guid("76529b15-5416-4a8a-b568-4d62194330eb") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("01705476-13e3-4aea-b2c9-230cfa0d1b12"), new Guid("995848e7-3b94-442e-9e3c-f09b41718c77") },
                    { new Guid("09d68976-0b43-49cc-84ff-971bd3dc765a"), new Guid("995848e7-3b94-442e-9e3c-f09b41718c77") },
                    { new Guid("0e2204d0-a8d5-4365-871d-3bd475d35a61"), new Guid("995848e7-3b94-442e-9e3c-f09b41718c77") },
                    { new Guid("1623d556-5df0-49db-aefb-a734b581edda"), new Guid("995848e7-3b94-442e-9e3c-f09b41718c77") },
                    { new Guid("171f414e-4615-47a5-8794-d70ce06a9f4f"), new Guid("995848e7-3b94-442e-9e3c-f09b41718c77") },
                    { new Guid("1e117d44-ab26-45fd-b494-ead3b1cb79ad"), new Guid("b6d74014-2823-40a4-a380-0257cf43084b") },
                    { new Guid("2d6cb6b5-0a78-42ec-9955-8530c76b7a77"), new Guid("995848e7-3b94-442e-9e3c-f09b41718c77") },
                    { new Guid("4317ab69-fefb-4995-998c-dfae5159c894"), new Guid("995848e7-3b94-442e-9e3c-f09b41718c77") },
                    { new Guid("44ab130a-ccd8-426e-ae65-970b08fea4f3"), new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e") },
                    { new Guid("57293cf7-2cea-4965-8c66-5b2f6ea158bd"), new Guid("995848e7-3b94-442e-9e3c-f09b41718c77") },
                    { new Guid("6c85da0d-4059-4519-98f7-931a60f1a13f"), new Guid("995848e7-3b94-442e-9e3c-f09b41718c77") },
                    { new Guid("704234f6-8f0d-4060-bc0c-1b9a6b6202f8"), new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e") },
                    { new Guid("71191a86-d9b7-49a6-88ad-5450267546ba"), new Guid("995848e7-3b94-442e-9e3c-f09b41718c77") },
                    { new Guid("8195554a-96df-43bd-bd91-481ef2fef86a"), new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1") },
                    { new Guid("8a0658b6-4fb2-4cf8-afd0-a5555dcc8dcc"), new Guid("995848e7-3b94-442e-9e3c-f09b41718c77") },
                    { new Guid("8a7f1b4e-1d2d-406e-8476-cbbb9abed560"), new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1") },
                    { new Guid("8e4e721f-46ca-4629-b16a-4c69938cee69"), new Guid("995848e7-3b94-442e-9e3c-f09b41718c77") },
                    { new Guid("a0788d4e-1b28-4bbe-9ec6-13d7605baa8b"), new Guid("b6d74014-2823-40a4-a380-0257cf43084b") },
                    { new Guid("d23f2adf-9679-411f-be0f-46f7749be6fd"), new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e") },
                    { new Guid("ef686a67-36ba-4f5e-a4b4-844d3c6b23a1"), new Guid("995848e7-3b94-442e-9e3c-f09b41718c77") },
                    { new Guid("f08218d6-2c54-4a3f-96ec-377266048786"), new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1") },
                    { new Guid("f08218d6-2c54-4a3f-96ec-377266048786"), new Guid("995848e7-3b94-442e-9e3c-f09b41718c77") },
                    { new Guid("f08218d6-2c54-4a3f-96ec-377266048786"), new Guid("e8e78abb-d51d-45c4-ac17-1e4804c47d68") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1"), new Guid("939e3cc6-3a46-4c79-b1cd-5556cbd7161b") },
                    { new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1"), new Guid("c2398fe9-6a10-49a5-b7f5-dc7f8546b456") },
                    { new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1"), new Guid("d3f57ba5-e9b4-4568-ab1b-049f3a76a56c") },
                    { new Guid("2f6b0182-3a47-40b9-be91-f8f94f371c24"), new Guid("ba0eb36c-860f-409e-9eb2-f1f14e9d3f67") },
                    { new Guid("2f6b0182-3a47-40b9-be91-f8f94f371c24"), new Guid("dafd9b16-efad-48ca-9d89-ffc5e2052a3c") },
                    { new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e"), new Guid("687672a7-7991-4415-b5cd-a3885b75b9e0") },
                    { new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e"), new Guid("b32d42fc-5018-41af-bfe5-2f74a0d1994a") },
                    { new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e"), new Guid("c9978c55-8fac-4a3c-ac3a-2961da3918ca") },
                    { new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e"), new Guid("eea80838-f915-40d7-808f-66c38f510336") },
                    { new Guid("ab649fe1-ea2f-48b9-abf4-b5dfc551356c"), new Guid("5ffe480a-0f3f-4a83-abe4-479c11b74091") },
                    { new Guid("ab649fe1-ea2f-48b9-abf4-b5dfc551356c"), new Guid("e983487a-8a7d-46b1-be81-7c0fcf23b381") },
                    { new Guid("ab649fe1-ea2f-48b9-abf4-b5dfc551356c"), new Guid("ef3f6bc9-b899-416b-bde9-056b1c40fe6f") },
                    { new Guid("e8e78abb-d51d-45c4-ac17-1e4804c47d68"), new Guid("5ffe480a-0f3f-4a83-abe4-479c11b74091") },
                    { new Guid("e8e78abb-d51d-45c4-ac17-1e4804c47d68"), new Guid("d3f57ba5-e9b4-4568-ab1b-049f3a76a56c") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("00d4586a-f35d-46b4-aa60-279af316f626"), null, new Guid("1e117d44-ab26-45fd-b494-ead3b1cb79ad"), false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null },
                    { new Guid("052d993c-e07c-409f-a339-d6bf6ea5051b"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("d3f57ba5-e9b4-4568-ab1b-049f3a76a56c") },
                    { new Guid("16cbd1c7-3d9e-49bb-a17d-67d8d6ecbb99"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("dafd9b16-efad-48ca-9d89-ffc5e2052a3c") },
                    { new Guid("17c1c056-4db6-4fdf-8bdd-6eabd6b4a55a"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("c2398fe9-6a10-49a5-b7f5-dc7f8546b456") },
                    { new Guid("17d1f0de-aca0-4a85-a2d2-ec9257d165d1"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("e983487a-8a7d-46b1-be81-7c0fcf23b381") },
                    { new Guid("1a283c9d-25b2-499c-a72b-d40aa81eff57"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("eea80838-f915-40d7-808f-66c38f510336") },
                    { new Guid("20a3c16f-0a73-4e6e-a964-9df1e32b5632"), "EvaluateMark4", new Guid("44ab130a-ccd8-426e-ae65-970b08fea4f3"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("46c3f985-a166-4c30-8955-28d1078e5356"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("dafd9b16-efad-48ca-9d89-ffc5e2052a3c") },
                    { new Guid("50794a5e-2542-4650-870f-e72718e79a26"), "EvaluateMark20", new Guid("8195554a-96df-43bd-bd91-481ef2fef86a"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("5b2430db-d84d-444b-afe4-2b8ebf303b04"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("dafd9b16-efad-48ca-9d89-ffc5e2052a3c") },
                    { new Guid("693444b0-c3a5-463c-8663-08c3654e46ba"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("dafd9b16-efad-48ca-9d89-ffc5e2052a3c") },
                    { new Guid("7417d244-88c1-4baf-b719-c01f042b0a4b"), "EvaluateMark13", new Guid("f08218d6-2c54-4a3f-96ec-377266048786"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("819a15e2-539c-4700-b403-13a52e683373"), "EvaluateMark5", new Guid("d23f2adf-9679-411f-be0f-46f7749be6fd"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("87e9457b-b3f8-429c-8983-039696e82e90"), "EvaluateMark3", new Guid("704234f6-8f0d-4060-bc0c-1b9a6b6202f8"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("88184a0f-d84b-484a-805e-a6852c1a23e7"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("ef3f6bc9-b899-416b-bde9-056b1c40fe6f") },
                    { new Guid("881b4279-6ea8-45af-b679-a2d4b38a8f1c"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("5ffe480a-0f3f-4a83-abe4-479c11b74091") },
                    { new Guid("8f4023ea-0bca-4742-86b3-c58306ad8af3"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("939e3cc6-3a46-4c79-b1cd-5556cbd7161b") },
                    { new Guid("9872fe8c-2d8a-4986-8d39-e9ed484c0c3b"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("939e3cc6-3a46-4c79-b1cd-5556cbd7161b") },
                    { new Guid("ab047713-018d-4b45-b334-0c77bc1d2389"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("b32d42fc-5018-41af-bfe5-2f74a0d1994a") },
                    { new Guid("ad2cbf84-5c17-4b52-af0e-7760f9fb8387"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("687672a7-7991-4415-b5cd-a3885b75b9e0") },
                    { new Guid("c475f7ed-2271-4016-b30c-4e63a691f28e"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("ba0eb36c-860f-409e-9eb2-f1f14e9d3f67") },
                    { new Guid("d4d5d26b-23de-45fc-b38a-dde4cddbbaa1"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("b32d42fc-5018-41af-bfe5-2f74a0d1994a") },
                    { new Guid("dd391558-1056-47f8-9a5e-09b3a7afd204"), null, new Guid("1e117d44-ab26-45fd-b494-ead3b1cb79ad"), false, 10, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("edaf35f9-1b22-4309-84cf-7103a53c1b27"), "EvaluateMark19", new Guid("8a7f1b4e-1d2d-406e-8476-cbbb9abed560"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("0e08a263-9fe8-4e16-9153-3c1f1367b2a0"), true, new Guid("1783a927-4cb2-4aed-859b-46ec02fe8ddd") },
                    { new Guid("53fd66e7-9f03-40e7-aa18-cc25e92eb53a"), true, new Guid("1783a927-4cb2-4aed-859b-46ec02fe8ddd") },
                    { new Guid("596f4ecb-08e2-47b7-9341-2d30b855f9c1"), true, new Guid("1783a927-4cb2-4aed-859b-46ec02fe8ddd") },
                    { new Guid("70fd23fc-8880-4fde-98ae-a3b6751cdb32"), true, new Guid("1783a927-4cb2-4aed-859b-46ec02fe8ddd") },
                    { new Guid("eab2b87d-4417-46ef-a747-75060122e8aa"), true, new Guid("1783a927-4cb2-4aed-859b-46ec02fe8ddd") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("45df1ab0-f6d5-4266-8071-0617fbdf2b5b"), null, new Guid("f08218d6-2c54-4a3f-96ec-377266048786"), "Доцент" },
                    { new Guid("708d30d8-b76c-4d87-a4d3-dc62b38eb6f2"), null, new Guid("71191a86-d9b7-49a6-88ad-5450267546ba"), "Имеющие ученую степень доктора наук" },
                    { new Guid("788d418f-2810-41ef-8189-4ba250f8c396"), null, new Guid("71191a86-d9b7-49a6-88ad-5450267546ba"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("952b109c-5da3-4b18-bf61-28133b063563"), null, new Guid("f08218d6-2c54-4a3f-96ec-377266048786"), "Профессор" },
                    { new Guid("f9506186-ab0f-4722-9294-7e1c1247cd2d"), null, new Guid("f08218d6-2c54-4a3f-96ec-377266048786"), "Нет" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("63ca8d63-323d-4bef-803c-fdf95f17920e"), null, new Guid("6019c5d7-48f9-4409-a8cc-bc7ba6512bb3"), true, true, new Guid("596f4ecb-08e2-47b7-9341-2d30b855f9c1"), "ResearcherID" },
                    { new Guid("6d84ca21-94c1-4c73-8a34-197b1eb414d8"), null, new Guid("adcb8447-10e4-491d-81f1-affa2ce5713a"), false, true, new Guid("eab2b87d-4417-46ef-a747-75060122e8aa"), null },
                    { new Guid("7484bd40-711c-481d-99c5-a2fb427c5aac"), null, new Guid("6019c5d7-48f9-4409-a8cc-bc7ba6512bb3"), true, true, new Guid("53fd66e7-9f03-40e7-aa18-cc25e92eb53a"), "ScopusID" },
                    { new Guid("8a939c20-4517-41f8-b354-00ecb05073ed"), null, new Guid("adcb8447-10e4-491d-81f1-affa2ce5713a"), false, true, new Guid("0e08a263-9fe8-4e16-9153-3c1f1367b2a0"), null },
                    { new Guid("94674499-ea17-4ddf-a9ad-7702dcc5e19b"), null, new Guid("6019c5d7-48f9-4409-a8cc-bc7ba6512bb3"), true, true, new Guid("70fd23fc-8880-4fde-98ae-a3b6751cdb32"), "Google Scholar ID" },
                    { new Guid("97bb27b3-3594-4330-87fe-f2e328699541"), null, new Guid("6019c5d7-48f9-4409-a8cc-bc7ba6512bb3"), true, true, new Guid("eab2b87d-4417-46ef-a747-75060122e8aa"), "РИНЦ AuthorID" },
                    { new Guid("98870490-619c-4223-a10f-435728306f20"), null, new Guid("adcb8447-10e4-491d-81f1-affa2ce5713a"), false, true, new Guid("53fd66e7-9f03-40e7-aa18-cc25e92eb53a"), null },
                    { new Guid("b4e5f9a4-b570-4d5d-a4b6-389e199a746b"), null, new Guid("adcb8447-10e4-491d-81f1-affa2ce5713a"), false, true, new Guid("596f4ecb-08e2-47b7-9341-2d30b855f9c1"), null },
                    { new Guid("b5fd1f82-58ff-4e49-b5da-5062292186c3"), null, new Guid("adcb8447-10e4-491d-81f1-affa2ce5713a"), false, true, new Guid("70fd23fc-8880-4fde-98ae-a3b6751cdb32"), null },
                    { new Guid("bee355cb-60b6-4115-8396-8201f5733dd5"), null, new Guid("6019c5d7-48f9-4409-a8cc-bc7ba6512bb3"), true, true, new Guid("0e08a263-9fe8-4e16-9153-3c1f1367b2a0"), "ORCiD" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1"), new Guid("052d993c-e07c-409f-a339-d6bf6ea5051b") },
                    { new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1"), new Guid("17c1c056-4db6-4fdf-8bdd-6eabd6b4a55a") },
                    { new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1"), new Guid("50794a5e-2542-4650-870f-e72718e79a26") },
                    { new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1"), new Guid("7417d244-88c1-4baf-b719-c01f042b0a4b") },
                    { new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1"), new Guid("8f4023ea-0bca-4742-86b3-c58306ad8af3") },
                    { new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1"), new Guid("9872fe8c-2d8a-4986-8d39-e9ed484c0c3b") },
                    { new Guid("1deb580c-0a2c-4de1-a7c2-cffcb89989a1"), new Guid("edaf35f9-1b22-4309-84cf-7103a53c1b27") },
                    { new Guid("2f6b0182-3a47-40b9-be91-f8f94f371c24"), new Guid("16cbd1c7-3d9e-49bb-a17d-67d8d6ecbb99") },
                    { new Guid("2f6b0182-3a47-40b9-be91-f8f94f371c24"), new Guid("46c3f985-a166-4c30-8955-28d1078e5356") },
                    { new Guid("2f6b0182-3a47-40b9-be91-f8f94f371c24"), new Guid("5b2430db-d84d-444b-afe4-2b8ebf303b04") },
                    { new Guid("2f6b0182-3a47-40b9-be91-f8f94f371c24"), new Guid("693444b0-c3a5-463c-8663-08c3654e46ba") },
                    { new Guid("2f6b0182-3a47-40b9-be91-f8f94f371c24"), new Guid("c475f7ed-2271-4016-b30c-4e63a691f28e") },
                    { new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e"), new Guid("1a283c9d-25b2-499c-a72b-d40aa81eff57") },
                    { new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e"), new Guid("20a3c16f-0a73-4e6e-a964-9df1e32b5632") },
                    { new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e"), new Guid("819a15e2-539c-4700-b403-13a52e683373") },
                    { new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e"), new Guid("87e9457b-b3f8-429c-8983-039696e82e90") },
                    { new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e"), new Guid("ab047713-018d-4b45-b334-0c77bc1d2389") },
                    { new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e"), new Guid("ad2cbf84-5c17-4b52-af0e-7760f9fb8387") },
                    { new Guid("65e772fc-2525-4b18-9eca-ca56442c3b2e"), new Guid("d4d5d26b-23de-45fc-b38a-dde4cddbbaa1") },
                    { new Guid("ab649fe1-ea2f-48b9-abf4-b5dfc551356c"), new Guid("17d1f0de-aca0-4a85-a2d2-ec9257d165d1") },
                    { new Guid("ab649fe1-ea2f-48b9-abf4-b5dfc551356c"), new Guid("88184a0f-d84b-484a-805e-a6852c1a23e7") },
                    { new Guid("ab649fe1-ea2f-48b9-abf4-b5dfc551356c"), new Guid("881b4279-6ea8-45af-b679-a2d4b38a8f1c") },
                    { new Guid("b6d74014-2823-40a4-a380-0257cf43084b"), new Guid("00d4586a-f35d-46b4-aa60-279af316f626") },
                    { new Guid("b6d74014-2823-40a4-a380-0257cf43084b"), new Guid("dd391558-1056-47f8-9a5e-09b3a7afd204") },
                    { new Guid("e8e78abb-d51d-45c4-ac17-1e4804c47d68"), new Guid("052d993c-e07c-409f-a339-d6bf6ea5051b") },
                    { new Guid("e8e78abb-d51d-45c4-ac17-1e4804c47d68"), new Guid("7417d244-88c1-4baf-b719-c01f042b0a4b") },
                    { new Guid("e8e78abb-d51d-45c4-ac17-1e4804c47d68"), new Guid("881b4279-6ea8-45af-b679-a2d4b38a8f1c") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("022ddcb9-2914-48f9-a6c9-5637393a83da"), new Guid("64e847cf-5ea6-47e5-bf07-1f6c60e26859"), null, "Региональный" },
                    { new Guid("225afe33-99aa-4271-8d64-ddad0ad80173"), new Guid("64e847cf-5ea6-47e5-bf07-1f6c60e26859"), null, "Всероссийский" },
                    { new Guid("25725f00-795c-4eb1-a307-871fe276041b"), new Guid("31534846-2ed5-43c4-9637-10fd7053c693"), null, "Полезная модель" },
                    { new Guid("28d11d2d-44c9-4e3c-b4b9-dcd6b23437de"), new Guid("551d7639-c932-4978-9096-94e9f643cb5b"), null, "Лекции" },
                    { new Guid("38360d60-ab67-4d33-a4c5-a7f15c876c34"), new Guid("31534846-2ed5-43c4-9637-10fd7053c693"), null, "Изобретение" },
                    { new Guid("3a94bfc0-29ff-42b4-8346-9f387951dae4"), new Guid("87ab4ab6-4d93-4dec-83ff-18c0a3495f7f"), null, "Монография" },
                    { new Guid("5e385b91-49b6-499c-92d4-c78cf2b1a581"), new Guid("551d7639-c932-4978-9096-94e9f643cb5b"), null, "Лабораторные" },
                    { new Guid("84aec9d1-34bb-4bb1-92e1-70165cab536a"), new Guid("56769c9f-b1d3-42b9-b5c1-4e54543e45fe"), null, "Полезная модель" },
                    { new Guid("8d99a42a-c0d2-4dd5-94fe-0d1b7cc21e34"), new Guid("31534846-2ed5-43c4-9637-10fd7053c693"), null, "База данных" },
                    { new Guid("91a531c1-704d-4ede-b900-1a9116755a98"), new Guid("87ab4ab6-4d93-4dec-83ff-18c0a3495f7f"), null, "Учебник" },
                    { new Guid("a30052c9-3715-4146-9408-ed3c18530515"), new Guid("56769c9f-b1d3-42b9-b5c1-4e54543e45fe"), null, "База данных" },
                    { new Guid("c448efc5-86b1-40c8-9c29-4feec9f3cead"), new Guid("56769c9f-b1d3-42b9-b5c1-4e54543e45fe"), null, "Изобретение" },
                    { new Guid("d3519c9b-1919-4208-9c90-d2c1137b00b8"), new Guid("ff36729a-e1ed-4332-bd54-14e036c2f0c9"), null, "Исполнитель" },
                    { new Guid("dab44a9b-0d33-4b4f-8ef3-00c32978bec3"), new Guid("87ab4ab6-4d93-4dec-83ff-18c0a3495f7f"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("f572444a-a317-47ae-9c31-81f47fe400e0"), new Guid("ff36729a-e1ed-4332-bd54-14e036c2f0c9"), null, "Руководитель" },
                    { new Guid("f7aa86af-6c58-402c-a978-f61e0da5aa83"), new Guid("64e847cf-5ea6-47e5-bf07-1f6c60e26859"), null, "Международный" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_ApplicationStatusId",
                table: "ApplicationForms",
                column: "ApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_CategoryId",
                table: "ApplicationForms",
                column: "CategoryId");

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
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Number",
                table: "Categories",
                column: "Number",
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
                name: "Categories");

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
