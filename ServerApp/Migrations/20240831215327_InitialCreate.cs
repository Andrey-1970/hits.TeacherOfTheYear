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
                    { new Guid("0d66b948-da4d-48c3-86a8-173e3f79f0d5"), 6, "Оценена" },
                    { new Guid("162b07df-4fad-4e03-9821-d49c1077754a"), 5, "Отклонена" },
                    { new Guid("3f8974e9-e23a-4722-9d04-73eb03e858e9"), 4, "Одобрена" },
                    { new Guid("992245af-d8bc-40a0-99a0-b29644173822"), 3, "В процессе рассмотрения" },
                    { new Guid("b10d1289-07bd-44c0-944e-ac79bdb72d27"), 2, "В ожидании рассмотрения" },
                    { new Guid("d99bd0bc-e5c1-4b52-bd74-33e5a80fe12b"), 1, "В ожидании заполнения" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("728a098d-5795-41da-908f-0166b33f6e42"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("7d168936-4f47-464d-980c-dbaed18235c9"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("20697110-73bc-40a8-8768-642e8f7f288d"), "Профессиональное развитие", 3 },
                    { new Guid("5f6ab265-54f5-4997-895c-df43c221ad30"), "Деятельность", 5 },
                    { new Guid("6f47a218-90ac-4b2a-a631-0525c6aa8faf"), "Деятельность", 4 },
                    { new Guid("aaba6089-2ca0-4f7a-bb92-a178814c4184"), "Категория участников", 2 },
                    { new Guid("dde29e50-070f-4ae9-87cd-9d456004c3e3"), "Общая информация", 1 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b"), "Образовательная деятельность", 2 },
                    { new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("2f434a82-59ae-46f0-98b1-23dcb468927a"), "Профессиональные показатели", 4 },
                    { new Guid("3ba3aa02-e931-4e9e-a4f6-17d924dae332"), "Инновационная и иная деятельность", 6 },
                    { new Guid("987d59a6-22a0-48fa-b5b4-702c6f98831e"), "Конкурсная работа", 7 },
                    { new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb"), "Основной", 1 },
                    { new Guid("ce2388b3-90f3-4eb6-99f0-99b7f5c48718"), "Методическая деятельность", 3 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("696ca9a4-2800-49cc-8e49-a422670666cb"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("883ea679-d41c-484a-ae74-d40d4aadb936"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("0184e7fc-9688-4f1f-9013-debe79f1b6db"), "User 1", "admin@mail.ru" },
                    { new Guid("706d3b18-bb99-45ca-aac8-0cdf232f18ae"), "User 2", "user@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45"), "string" },
                    { new Guid("39dce0e4-9558-4de6-b661-e0cc65ab8d1e"), "bool" },
                    { new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8"), "int" },
                    { new Guid("970c4e64-40a3-4eab-a28f-a41dd5fb3d26"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("20697110-73bc-40a8-8768-642e8f7f288d"), new Guid("696ca9a4-2800-49cc-8e49-a422670666cb") },
                    { new Guid("20697110-73bc-40a8-8768-642e8f7f288d"), new Guid("883ea679-d41c-484a-ae74-d40d4aadb936") },
                    { new Guid("5f6ab265-54f5-4997-895c-df43c221ad30"), new Guid("883ea679-d41c-484a-ae74-d40d4aadb936") },
                    { new Guid("6f47a218-90ac-4b2a-a631-0525c6aa8faf"), new Guid("696ca9a4-2800-49cc-8e49-a422670666cb") },
                    { new Guid("aaba6089-2ca0-4f7a-bb92-a178814c4184"), new Guid("696ca9a4-2800-49cc-8e49-a422670666cb") },
                    { new Guid("aaba6089-2ca0-4f7a-bb92-a178814c4184"), new Guid("883ea679-d41c-484a-ae74-d40d4aadb936") },
                    { new Guid("dde29e50-070f-4ae9-87cd-9d456004c3e3"), new Guid("696ca9a4-2800-49cc-8e49-a422670666cb") },
                    { new Guid("dde29e50-070f-4ae9-87cd-9d456004c3e3"), new Guid("883ea679-d41c-484a-ae74-d40d4aadb936") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("053ddb4f-69c7-4e6b-a65f-f1f78bcb84d1"), new Guid("aaba6089-2ca0-4f7a-bb92-a178814c4184"), null, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("0930879f-c6a4-4d8f-9a8e-6d1f5c5aa585"), new Guid("6f47a218-90ac-4b2a-a631-0525c6aa8faf"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("31ed5a3d-7357-4df5-8d66-327e4315a2fb"), new Guid("aaba6089-2ca0-4f7a-bb92-a178814c4184"), null, true, "Название конкурсной работы", 12, "Введите название своей конкурсной работы", new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("344de230-10b3-4f42-bc34-13616247ffdd"), new Guid("dde29e50-070f-4ae9-87cd-9d456004c3e3"), null, true, "Место работы/учебы", 6, "Название организации", new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("3d6eafa6-2198-4114-aabb-2631078cb92f"), new Guid("aaba6089-2ca0-4f7a-bb92-a178814c4184"), null, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("3e1d4387-d577-466c-b649-1218f4d59896"), new Guid("dde29e50-070f-4ae9-87cd-9d456004c3e3"), null, true, "Дата рождения", 2, "01.01.2000", new Guid("970c4e64-40a3-4eab-a28f-a41dd5fb3d26") },
                    { new Guid("3e707679-f8a5-4583-b21e-7d27c5e3f52b"), new Guid("dde29e50-070f-4ae9-87cd-9d456004c3e3"), null, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("512d7df1-7328-4df3-8c2a-5313a29cad7b"), new Guid("dde29e50-070f-4ae9-87cd-9d456004c3e3"), null, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("67bfb3ad-93e5-4d77-8d76-0d56707318bb"), new Guid("dde29e50-070f-4ae9-87cd-9d456004c3e3"), null, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("71232eb2-01ed-4567-8eef-ecb3d7b145e2"), new Guid("6f47a218-90ac-4b2a-a631-0525c6aa8faf"), null, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("7be357ec-5f72-45d0-bc3c-a645047dbbda"), new Guid("5f6ab265-54f5-4997-895c-df43c221ad30"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("80ae696a-c065-476a-85d1-6c4fb2abd0dc"), new Guid("5f6ab265-54f5-4997-895c-df43c221ad30"), null, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("822364f8-ec98-4397-9978-b9d31edac8ec"), new Guid("aaba6089-2ca0-4f7a-bb92-a178814c4184"), null, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("b5f6df84-5105-4d7e-a382-ebd610d4c6cf"), new Guid("dde29e50-070f-4ae9-87cd-9d456004c3e3"), null, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("b7d851ab-e515-4437-bb64-fbeb7eb832f1"), new Guid("dde29e50-070f-4ae9-87cd-9d456004c3e3"), null, true, "Электронная почта", 5, "user@example.com", new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("cc29a10f-0493-450e-b6f3-d9b15e600b46"), new Guid("aaba6089-2ca0-4f7a-bb92-a178814c4184"), null, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("cf16529d-b5c7-41db-b4b1-8373f88772ed"), new Guid("aaba6089-2ca0-4f7a-bb92-a178814c4184"), null, true, "Ссылка на конкурсную работу", 13, "Введите ссылку своей конкурсной работы", new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("d9a1bfd6-7fef-4be4-870c-ba9a023aad7a"), new Guid("6f47a218-90ac-4b2a-a631-0525c6aa8faf"), "Руководство дипломными проектами за предыдущий учебный год", true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("e08ba74a-6d71-498f-b65d-a2eaba26c3c5"), new Guid("dde29e50-070f-4ae9-87cd-9d456004c3e3"), null, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("e6c1cfc1-72b3-4ccf-a47d-078aaa472586"), new Guid("dde29e50-070f-4ae9-87cd-9d456004c3e3"), null, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("f5a3768f-805b-4135-927e-af8f6e84e96f"), new Guid("dde29e50-070f-4ae9-87cd-9d456004c3e3"), null, true, "Должность", 9, "Введите свою должность в организации", new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b"), new Guid("696ca9a4-2800-49cc-8e49-a422670666cb") },
                    { new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8"), new Guid("883ea679-d41c-484a-ae74-d40d4aadb936") },
                    { new Guid("2f434a82-59ae-46f0-98b1-23dcb468927a"), new Guid("696ca9a4-2800-49cc-8e49-a422670666cb") },
                    { new Guid("3ba3aa02-e931-4e9e-a4f6-17d924dae332"), new Guid("883ea679-d41c-484a-ae74-d40d4aadb936") },
                    { new Guid("987d59a6-22a0-48fa-b5b4-702c6f98831e"), new Guid("696ca9a4-2800-49cc-8e49-a422670666cb") },
                    { new Guid("987d59a6-22a0-48fa-b5b4-702c6f98831e"), new Guid("883ea679-d41c-484a-ae74-d40d4aadb936") },
                    { new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb"), new Guid("696ca9a4-2800-49cc-8e49-a422670666cb") },
                    { new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb"), new Guid("883ea679-d41c-484a-ae74-d40d4aadb936") },
                    { new Guid("ce2388b3-90f3-4eb6-99f0-99b7f5c48718"), new Guid("696ca9a4-2800-49cc-8e49-a422670666cb") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("031ae2d7-3ff8-4705-8a2f-772a70130942"), new Guid("6f47a218-90ac-4b2a-a631-0525c6aa8faf"), false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("09e62d13-5869-410d-8053-df430ef151b4"), new Guid("6f47a218-90ac-4b2a-a631-0525c6aa8faf"), false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("13c37ffc-107b-4163-b870-2de246d2008a"), new Guid("5f6ab265-54f5-4997-895c-df43c221ad30"), true, "Персональные идентификаторы", 10 },
                    { new Guid("1c9fce72-3d6e-4899-9898-f707515d3ca8"), new Guid("20697110-73bc-40a8-8768-642e8f7f288d"), false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("31533b88-e48f-48d7-ba6c-cae9a2ffd5ae"), new Guid("5f6ab265-54f5-4997-895c-df43c221ad30"), false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("319038d8-3e2b-4e01-8c53-3690d49f6b36"), new Guid("5f6ab265-54f5-4997-895c-df43c221ad30"), false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("3adfd1fd-a110-4ed8-b858-9dc347d8e350"), new Guid("20697110-73bc-40a8-8768-642e8f7f288d"), false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("5d55396a-b3ac-4d6d-8805-ae627ab81879"), new Guid("5f6ab265-54f5-4997-895c-df43c221ad30"), false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("6e40fa53-6109-4152-b2af-57b2229dfe5c"), new Guid("6f47a218-90ac-4b2a-a631-0525c6aa8faf"), false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("7a61b130-805a-4e6c-848e-407f31ccb270"), new Guid("6f47a218-90ac-4b2a-a631-0525c6aa8faf"), false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("b10d06fa-ca95-47c6-96c1-19714fa22a2b"), new Guid("5f6ab265-54f5-4997-895c-df43c221ad30"), false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("bd988279-dcd5-47de-b823-eaf97201f365"), new Guid("6f47a218-90ac-4b2a-a631-0525c6aa8faf"), false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("f260b792-5580-49a5-8e72-cfec2d740749"), new Guid("6f47a218-90ac-4b2a-a631-0525c6aa8faf"), false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("078dd60d-b50e-402d-a54e-09b109449b6b"), true, "Ссылка", 5, new Guid("1c9fce72-3d6e-4899-9898-f707515d3ca8"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("0a070659-69ba-4673-9f78-bde39510f99b"), true, "Вид деятельности (преподавательская)", 3, new Guid("09e62d13-5869-410d-8053-df430ef151b4"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("1b68afb5-4f6a-4bdd-8871-7a8cc1329569"), true, "Год", 3, new Guid("bd988279-dcd5-47de-b823-eaf97201f365"), new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("1f14cde6-5b7a-4341-af60-f0b65e580924"), true, "Издание, год", 4, new Guid("31533b88-e48f-48d7-ba6c-cae9a2ffd5ae"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("1f984af0-8221-4875-915f-a91a3018d0a2"), true, "Вид", 1, new Guid("b10d06fa-ca95-47c6-96c1-19714fa22a2b"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("23eff023-4e19-4dfc-ac4a-e1d6f143bff6"), true, "Практические занятия (час.)", 4, new Guid("f260b792-5580-49a5-8e72-cfec2d740749"), new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("2461b946-2e5d-4d7c-b9e6-fccd5d434cf3"), true, "Язык публикации", 7, new Guid("7a61b130-805a-4e6c-848e-407f31ccb270"), new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("2ef15d31-411f-4a0d-a69e-58c03a565302"), true, "Количество печатных листов", 4, new Guid("7a61b130-805a-4e6c-848e-407f31ccb270"), new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("30541e51-9438-48fb-8e60-101cd132a859"), true, "Название организации в которую внедрена разработка", 3, new Guid("b10d06fa-ca95-47c6-96c1-19714fa22a2b"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("3b89eb54-981f-4eda-9e8d-ea2568fb5dfa"), true, "Вид", 1, new Guid("5d55396a-b3ac-4d6d-8805-ae627ab81879"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("3f5593b0-39d0-4631-a8f0-9dfd59799637"), true, "Лекции (час.)", 3, new Guid("f260b792-5580-49a5-8e72-cfec2d740749"), new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("42e481bc-c357-4c22-a034-d523726a41f6"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("319038d8-3e2b-4e01-8c53-3690d49f6b36"), new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("44670ea6-ae3e-4de0-9e11-f997cfadab02"), true, "Соавторы", 2, new Guid("31533b88-e48f-48d7-ba6c-cae9a2ffd5ae"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("4fcd2426-7570-44eb-ba59-cebae27830c9"), true, "Название разработки", 2, new Guid("b10d06fa-ca95-47c6-96c1-19714fa22a2b"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("50c66689-3a2e-429c-bc5f-b599f6cf5033"), true, "Статус конкурса", 3, new Guid("1c9fce72-3d6e-4899-9898-f707515d3ca8"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("568736c3-76ee-447c-9a4d-d78abab843a7"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("bd988279-dcd5-47de-b823-eaf97201f365"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("5a3c4726-df8c-41ca-900e-dc14406f6292"), true, "Издательство, год", 6, new Guid("7a61b130-805a-4e6c-848e-407f31ccb270"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("5df6e5c7-e5de-4427-b167-2ceedcf8f4c3"), true, "Название документа, реквизиты", 1, new Guid("3adfd1fd-a110-4ed8-b858-9dc347d8e350"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("5e45de4f-856d-4485-8410-94d76c11471e"), true, "Название конкурса/премии", 2, new Guid("bd988279-dcd5-47de-b823-eaf97201f365"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("60141197-1d62-41af-b844-931298e624e0"), true, "Название дисциплины", 1, new Guid("031ae2d7-3ff8-4705-8a2f-772a70130942"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("6b6891cb-35b3-47a8-8476-efcfb941f8fd"), true, "Название курса", 1, new Guid("6e40fa53-6109-4152-b2af-57b2229dfe5c"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("6ba6c3a0-583a-4984-93a3-1a68eff7a8d4"), true, "Название", 2, new Guid("5d55396a-b3ac-4d6d-8805-ae627ab81879"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("726dfe8b-4a6b-4545-9a89-4c2ac069051c"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("bd988279-dcd5-47de-b823-eaf97201f365"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("73ebb769-6127-47c4-ac55-7aecbbdd20f1"), true, "Наличие грифа", 5, new Guid("7a61b130-805a-4e6c-848e-407f31ccb270"), new Guid("39dce0e4-9558-4de6-b661-e0cc65ab8d1e") },
                    { new Guid("7e85f3b1-785b-49d1-a66f-a0d564db00a5"), true, "Название конкурса", 2, new Guid("1c9fce72-3d6e-4899-9898-f707515d3ca8"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("7f5decf0-c5a8-4143-a3df-45b1006c4148"), false, "Идентификатор", 2, new Guid("13c37ffc-107b-4163-b870-2de246d2008a"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("82ad74c5-cd0c-4a96-b68a-57cc7f580e32"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("09e62d13-5869-410d-8053-df430ef151b4"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("8558addf-02f4-4715-bc5e-e79c60047df6"), true, "Вид (лекции, лабораторные)", 2, new Guid("031ae2d7-3ff8-4705-8a2f-772a70130942"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("857710fa-1661-401f-90a1-235fd8878bad"), true, "Количество часов", 4, new Guid("09e62d13-5869-410d-8053-df430ef151b4"), new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("8951ff3a-0af8-4e67-a141-83d71727c12b"), true, "Номер РИД", 4, new Guid("5d55396a-b3ac-4d6d-8805-ae627ab81879"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("8cced159-2a5d-470f-9574-348f49116a71"), true, "Год получения документа", 2, new Guid("3adfd1fd-a110-4ed8-b858-9dc347d8e350"), new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("91cba198-e3c8-43c3-ac83-34d24002c85e"), true, "Награда", 4, new Guid("1c9fce72-3d6e-4899-9898-f707515d3ca8"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("93fe25d3-685b-433f-9319-dc757496e547"), true, "Название статьи", 1, new Guid("31533b88-e48f-48d7-ba6c-cae9a2ffd5ae"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("94137b82-875f-4c45-95fc-f389be83a01b"), true, "Ссылка на открытый доступ", 8, new Guid("7a61b130-805a-4e6c-848e-407f31ccb270"), new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("94d02a0f-6649-43dd-87f6-74796a751bdb"), true, "Период выполнения", 3, new Guid("319038d8-3e2b-4e01-8c53-3690d49f6b36"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("94d802ee-6c90-427d-9e0c-7d6c668061ea"), true, "ФИО соавторов", 3, new Guid("5d55396a-b3ac-4d6d-8805-ae627ab81879"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("97374b5a-6719-405f-84f3-3a6eaaea3e8c"), false, "Тип идентификатора", 1, new Guid("13c37ffc-107b-4163-b870-2de246d2008a"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("9b153dc5-e601-4348-883f-49ed80012cde"), true, "Год", 1, new Guid("1c9fce72-3d6e-4899-9898-f707515d3ca8"), new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("a23c2d3a-144c-449b-9677-625fb5a52dd9"), true, "Итого (час.)", 5, new Guid("f260b792-5580-49a5-8e72-cfec2d740749"), new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") },
                    { new Guid("a6d0ab6f-686d-4784-a436-ee0867bf8ce8"), true, "Название НИР/НИОКР", 1, new Guid("319038d8-3e2b-4e01-8c53-3690d49f6b36"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("aa2de89c-3f8f-472d-bce2-861f8cc4b4e2"), true, "Наименование курса", 1, new Guid("f260b792-5580-49a5-8e72-cfec2d740749"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("abc711fc-18f5-454d-917e-f177a558eaa1"), true, "Название", 2, new Guid("7a61b130-805a-4e6c-848e-407f31ccb270"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("b8ae2184-3762-49b7-93ff-87085a5aa0b0"), true, "Статус (руководитель/исполнитель)", 4, new Guid("319038d8-3e2b-4e01-8c53-3690d49f6b36"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("bd123b1b-6637-4003-b2b4-75058aeff3bc"), true, "Вид публикации", 1, new Guid("7a61b130-805a-4e6c-848e-407f31ccb270"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("c3b2bcdd-243a-4ba0-a6d7-c7c9f2caf714"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("31533b88-e48f-48d7-ba6c-cae9a2ffd5ae"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("c88059b0-02d7-4576-a156-ec43debc6c67"), true, "Соавторы", 2, new Guid("6e40fa53-6109-4152-b2af-57b2229dfe5c"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("c9c9bef2-e62e-4095-938c-50582fb3d0bf"), true, "ФИО", 1, new Guid("bd988279-dcd5-47de-b823-eaf97201f365"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("d382d829-7582-4182-95ff-4f58dab4d5b1"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("319038d8-3e2b-4e01-8c53-3690d49f6b36"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("d6495849-c324-4d35-b816-eae2ef497338"), true, "Название организации/должность/ставка", 1, new Guid("09e62d13-5869-410d-8053-df430ef151b4"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("dcf73805-38e1-4898-a02b-6e22f04dcea2"), false, "Соавторы", 3, new Guid("7a61b130-805a-4e6c-848e-407f31ccb270"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("eb13dce8-ccdf-424a-a11d-a64809605f0c"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("f260b792-5580-49a5-8e72-cfec2d740749"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("eff043b2-73ea-4e74-a9b8-f4ce25a3c1e8"), true, "Ссылка на платформу", 3, new Guid("6e40fa53-6109-4152-b2af-57b2229dfe5c"), new Guid("1342696c-f7ce-4be9-a3d3-2cad14e1fd45") },
                    { new Guid("f008ee14-ce77-44e1-9ca1-57783302a056"), true, "Год", 4, new Guid("6e40fa53-6109-4152-b2af-57b2229dfe5c"), new Guid("64591d85-9a25-4651-8044-3a4fcd7bffd8") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("053ddb4f-69c7-4e6b-a65f-f1f78bcb84d1"), new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8") },
                    { new Guid("053ddb4f-69c7-4e6b-a65f-f1f78bcb84d1"), new Guid("2f434a82-59ae-46f0-98b1-23dcb468927a") },
                    { new Guid("053ddb4f-69c7-4e6b-a65f-f1f78bcb84d1"), new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb") },
                    { new Guid("0930879f-c6a4-4d8f-9a8e-6d1f5c5aa585"), new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b") },
                    { new Guid("31ed5a3d-7357-4df5-8d66-327e4315a2fb"), new Guid("987d59a6-22a0-48fa-b5b4-702c6f98831e") },
                    { new Guid("344de230-10b3-4f42-bc34-13616247ffdd"), new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb") },
                    { new Guid("3d6eafa6-2198-4114-aabb-2631078cb92f"), new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb") },
                    { new Guid("3e1d4387-d577-466c-b649-1218f4d59896"), new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb") },
                    { new Guid("3e707679-f8a5-4583-b21e-7d27c5e3f52b"), new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb") },
                    { new Guid("512d7df1-7328-4df3-8c2a-5313a29cad7b"), new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb") },
                    { new Guid("67bfb3ad-93e5-4d77-8d76-0d56707318bb"), new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb") },
                    { new Guid("71232eb2-01ed-4567-8eef-ecb3d7b145e2"), new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b") },
                    { new Guid("7be357ec-5f72-45d0-bc3c-a645047dbbda"), new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8") },
                    { new Guid("80ae696a-c065-476a-85d1-6c4fb2abd0dc"), new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8") },
                    { new Guid("822364f8-ec98-4397-9978-b9d31edac8ec"), new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb") },
                    { new Guid("b5f6df84-5105-4d7e-a382-ebd610d4c6cf"), new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb") },
                    { new Guid("b7d851ab-e515-4437-bb64-fbeb7eb832f1"), new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb") },
                    { new Guid("cc29a10f-0493-450e-b6f3-d9b15e600b46"), new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb") },
                    { new Guid("cf16529d-b5c7-41db-b4b1-8373f88772ed"), new Guid("987d59a6-22a0-48fa-b5b4-702c6f98831e") },
                    { new Guid("d9a1bfd6-7fef-4be4-870c-ba9a023aad7a"), new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b") },
                    { new Guid("e08ba74a-6d71-498f-b65d-a2eaba26c3c5"), new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb") },
                    { new Guid("e6c1cfc1-72b3-4ccf-a47d-078aaa472586"), new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb") },
                    { new Guid("f5a3768f-805b-4135-927e-af8f6e84e96f"), new Guid("c486fecb-b1f9-42eb-b58f-baa5d39254cb") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b"), new Guid("09e62d13-5869-410d-8053-df430ef151b4") },
                    { new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b"), new Guid("6e40fa53-6109-4152-b2af-57b2229dfe5c") },
                    { new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b"), new Guid("bd988279-dcd5-47de-b823-eaf97201f365") },
                    { new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b"), new Guid("f260b792-5580-49a5-8e72-cfec2d740749") },
                    { new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8"), new Guid("1c9fce72-3d6e-4899-9898-f707515d3ca8") },
                    { new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8"), new Guid("31533b88-e48f-48d7-ba6c-cae9a2ffd5ae") },
                    { new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8"), new Guid("319038d8-3e2b-4e01-8c53-3690d49f6b36") },
                    { new Guid("2f434a82-59ae-46f0-98b1-23dcb468927a"), new Guid("1c9fce72-3d6e-4899-9898-f707515d3ca8") },
                    { new Guid("2f434a82-59ae-46f0-98b1-23dcb468927a"), new Guid("3adfd1fd-a110-4ed8-b858-9dc347d8e350") },
                    { new Guid("3ba3aa02-e931-4e9e-a4f6-17d924dae332"), new Guid("3adfd1fd-a110-4ed8-b858-9dc347d8e350") },
                    { new Guid("3ba3aa02-e931-4e9e-a4f6-17d924dae332"), new Guid("5d55396a-b3ac-4d6d-8805-ae627ab81879") },
                    { new Guid("3ba3aa02-e931-4e9e-a4f6-17d924dae332"), new Guid("b10d06fa-ca95-47c6-96c1-19714fa22a2b") },
                    { new Guid("ce2388b3-90f3-4eb6-99f0-99b7f5c48718"), new Guid("031ae2d7-3ff8-4705-8a2f-772a70130942") },
                    { new Guid("ce2388b3-90f3-4eb6-99f0-99b7f5c48718"), new Guid("7a61b130-805a-4e6c-848e-407f31ccb270") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("06aede52-9ad4-4f38-958a-2d6e254a848e"), "EvaluateMark20", new Guid("80ae696a-c065-476a-85d1-6c4fb2abd0dc"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("12162f13-260e-4006-b157-56f9353e962c"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("31533b88-e48f-48d7-ba6c-cae9a2ffd5ae") },
                    { new Guid("17f4733d-7424-4768-b4a3-2f5dd5bde6d4"), "EvaluateMark13", new Guid("053ddb4f-69c7-4e6b-a65f-f1f78bcb84d1"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("1c23c127-f898-4831-a126-e7fed9b8ac20"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("3adfd1fd-a110-4ed8-b858-9dc347d8e350") },
                    { new Guid("2c39b7a9-adcd-4671-844c-a085f5971448"), "EvaluateMark3", new Guid("d9a1bfd6-7fef-4be4-870c-ba9a023aad7a"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("462c5b50-0d6a-4a0c-9039-7b622537cdcc"), "EvaluateMark5", new Guid("71232eb2-01ed-4567-8eef-ecb3d7b145e2"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("48b20d66-e694-4665-a82e-87fcaa6a4ed3"), null, new Guid("cf16529d-b5c7-41db-b4b1-8373f88772ed"), false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null },
                    { new Guid("4ed5d451-893f-4336-be86-364933a52059"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("bd988279-dcd5-47de-b823-eaf97201f365") },
                    { new Guid("5a8d8dd8-6701-4def-8154-ea6a7d7e6758"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("1c9fce72-3d6e-4899-9898-f707515d3ca8") },
                    { new Guid("7da8168c-608a-46f3-a0c9-dc81e437af42"), "EvaluateMark4", new Guid("0930879f-c6a4-4d8f-9a8e-6d1f5c5aa585"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("833c371a-5a42-4d51-8cb4-4c95256182e4"), null, new Guid("cf16529d-b5c7-41db-b4b1-8373f88772ed"), false, 10, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("9441dfbe-7aa5-49d0-9d17-df3bc3cd4e24"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("319038d8-3e2b-4e01-8c53-3690d49f6b36") },
                    { new Guid("962e9e56-d536-421d-baa3-93b7d99735a3"), "EvaluateMark19", new Guid("7be357ec-5f72-45d0-bc3c-a645047dbbda"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("9b0a2a7e-9ac1-4d91-afa8-bc3f0afef999"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("7a61b130-805a-4e6c-848e-407f31ccb270") },
                    { new Guid("9f9a3735-e000-4299-9d96-0fa7ff973da8"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("6e40fa53-6109-4152-b2af-57b2229dfe5c") },
                    { new Guid("a957355d-a915-4846-a8c6-b2804b1d83f6"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("b10d06fa-ca95-47c6-96c1-19714fa22a2b") },
                    { new Guid("b247d9d6-6c22-426c-83c2-d55ee7396f9c"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("f260b792-5580-49a5-8e72-cfec2d740749") },
                    { new Guid("b32feaa2-402f-4ba1-a562-e69d68db8e7d"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("7a61b130-805a-4e6c-848e-407f31ccb270") },
                    { new Guid("cb5d1fe8-2b39-4dea-8d24-c8edae1ba250"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("f260b792-5580-49a5-8e72-cfec2d740749") },
                    { new Guid("e3a70a76-747f-41af-b5ea-086b3c007305"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("7a61b130-805a-4e6c-848e-407f31ccb270") },
                    { new Guid("e3c05874-2632-4e65-a8c0-bcff096663f7"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("031ae2d7-3ff8-4705-8a2f-772a70130942") },
                    { new Guid("f1c7e45e-17b5-415b-8b52-039f62e13850"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("7a61b130-805a-4e6c-848e-407f31ccb270") },
                    { new Guid("f23871ef-7548-427b-9216-bc2f559449ae"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("5d55396a-b3ac-4d6d-8805-ae627ab81879") },
                    { new Guid("f55775dd-fb88-4c51-9423-c96f0d986762"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("319038d8-3e2b-4e01-8c53-3690d49f6b36") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("22c88ef3-347b-4a71-83f6-64ffc6498647"), true, new Guid("13c37ffc-107b-4163-b870-2de246d2008a") },
                    { new Guid("3a7eb3e6-ee36-4de5-9a07-dea8870b2335"), true, new Guid("13c37ffc-107b-4163-b870-2de246d2008a") },
                    { new Guid("4dcc7326-4043-42ab-8346-2cd563a3aeba"), true, new Guid("13c37ffc-107b-4163-b870-2de246d2008a") },
                    { new Guid("aaf6af61-4dd4-478d-a8c7-960f17926713"), true, new Guid("13c37ffc-107b-4163-b870-2de246d2008a") },
                    { new Guid("f44bba94-5fe1-4424-9fae-35689813a047"), true, new Guid("13c37ffc-107b-4163-b870-2de246d2008a") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("2f209209-be5a-49ea-be8d-619459f451ff"), null, new Guid("3d6eafa6-2198-4114-aabb-2631078cb92f"), "Имеющие ученую степень доктора наук" },
                    { new Guid("322489ef-ebea-4767-8d0c-14d85c5e1454"), null, new Guid("053ddb4f-69c7-4e6b-a65f-f1f78bcb84d1"), "Доцент" },
                    { new Guid("4e947298-19cb-40c9-8ed6-b4a3c95e93cb"), null, new Guid("3d6eafa6-2198-4114-aabb-2631078cb92f"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("5dfd95f5-e0fb-43d3-a160-59d2400a3932"), null, new Guid("053ddb4f-69c7-4e6b-a65f-f1f78bcb84d1"), "Нет" },
                    { new Guid("aabe9056-7958-4047-9cc6-71cbffc185df"), null, new Guid("053ddb4f-69c7-4e6b-a65f-f1f78bcb84d1"), "Профессор" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("235b3e6b-f99e-46fe-a1b5-9b9f682d5ce4"), null, new Guid("7f5decf0-c5a8-4143-a3df-45b1006c4148"), false, true, new Guid("aaf6af61-4dd4-478d-a8c7-960f17926713"), null },
                    { new Guid("56906bef-6534-46c3-aabc-22f64d701d3c"), null, new Guid("7f5decf0-c5a8-4143-a3df-45b1006c4148"), false, true, new Guid("3a7eb3e6-ee36-4de5-9a07-dea8870b2335"), null },
                    { new Guid("69aae9c9-a692-41c7-89d4-c1a2c1a5a480"), null, new Guid("97374b5a-6719-405f-84f3-3a6eaaea3e8c"), true, true, new Guid("f44bba94-5fe1-4424-9fae-35689813a047"), "ScopusID" },
                    { new Guid("73838233-3c04-43f4-beca-19cbd835f7b4"), null, new Guid("7f5decf0-c5a8-4143-a3df-45b1006c4148"), false, true, new Guid("4dcc7326-4043-42ab-8346-2cd563a3aeba"), null },
                    { new Guid("9a88b016-14db-4799-9219-20efe078d438"), null, new Guid("97374b5a-6719-405f-84f3-3a6eaaea3e8c"), true, true, new Guid("4dcc7326-4043-42ab-8346-2cd563a3aeba"), "ORCiD" },
                    { new Guid("b07ece37-aa77-4fd7-8a30-e0f2b6c2256f"), null, new Guid("97374b5a-6719-405f-84f3-3a6eaaea3e8c"), true, true, new Guid("3a7eb3e6-ee36-4de5-9a07-dea8870b2335"), "ResearcherID" },
                    { new Guid("b8f103d4-017a-4258-9e97-5e3d909dd02d"), null, new Guid("97374b5a-6719-405f-84f3-3a6eaaea3e8c"), true, true, new Guid("22c88ef3-347b-4a71-83f6-64ffc6498647"), "РИНЦ AuthorID" },
                    { new Guid("d0657eea-930d-43fe-9fad-19797fb6ed94"), null, new Guid("7f5decf0-c5a8-4143-a3df-45b1006c4148"), false, true, new Guid("22c88ef3-347b-4a71-83f6-64ffc6498647"), null },
                    { new Guid("dbb38aca-9fc4-4cb2-badd-7c934ae621d5"), null, new Guid("7f5decf0-c5a8-4143-a3df-45b1006c4148"), false, true, new Guid("f44bba94-5fe1-4424-9fae-35689813a047"), null },
                    { new Guid("e4feaa26-4ce9-46b2-bb0a-2ff9d5fdc02a"), null, new Guid("97374b5a-6719-405f-84f3-3a6eaaea3e8c"), true, true, new Guid("aaf6af61-4dd4-478d-a8c7-960f17926713"), "Google Scholar ID" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b"), new Guid("2c39b7a9-adcd-4671-844c-a085f5971448") },
                    { new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b"), new Guid("462c5b50-0d6a-4a0c-9039-7b622537cdcc") },
                    { new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b"), new Guid("4ed5d451-893f-4336-be86-364933a52059") },
                    { new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b"), new Guid("7da8168c-608a-46f3-a0c9-dc81e437af42") },
                    { new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b"), new Guid("9f9a3735-e000-4299-9d96-0fa7ff973da8") },
                    { new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b"), new Guid("b247d9d6-6c22-426c-83c2-d55ee7396f9c") },
                    { new Guid("085f6d30-1fdc-4eed-8457-bc1324b4ce9b"), new Guid("cb5d1fe8-2b39-4dea-8d24-c8edae1ba250") },
                    { new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8"), new Guid("06aede52-9ad4-4f38-958a-2d6e254a848e") },
                    { new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8"), new Guid("12162f13-260e-4006-b157-56f9353e962c") },
                    { new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8"), new Guid("17f4733d-7424-4768-b4a3-2f5dd5bde6d4") },
                    { new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8"), new Guid("5a8d8dd8-6701-4def-8154-ea6a7d7e6758") },
                    { new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8"), new Guid("9441dfbe-7aa5-49d0-9d17-df3bc3cd4e24") },
                    { new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8"), new Guid("962e9e56-d536-421d-baa3-93b7d99735a3") },
                    { new Guid("267e7677-ab52-47ad-87f2-22d85f2ccaa8"), new Guid("f55775dd-fb88-4c51-9423-c96f0d986762") },
                    { new Guid("2f434a82-59ae-46f0-98b1-23dcb468927a"), new Guid("17f4733d-7424-4768-b4a3-2f5dd5bde6d4") },
                    { new Guid("2f434a82-59ae-46f0-98b1-23dcb468927a"), new Guid("1c23c127-f898-4831-a126-e7fed9b8ac20") },
                    { new Guid("2f434a82-59ae-46f0-98b1-23dcb468927a"), new Guid("5a8d8dd8-6701-4def-8154-ea6a7d7e6758") },
                    { new Guid("3ba3aa02-e931-4e9e-a4f6-17d924dae332"), new Guid("1c23c127-f898-4831-a126-e7fed9b8ac20") },
                    { new Guid("3ba3aa02-e931-4e9e-a4f6-17d924dae332"), new Guid("a957355d-a915-4846-a8c6-b2804b1d83f6") },
                    { new Guid("3ba3aa02-e931-4e9e-a4f6-17d924dae332"), new Guid("f23871ef-7548-427b-9216-bc2f559449ae") },
                    { new Guid("987d59a6-22a0-48fa-b5b4-702c6f98831e"), new Guid("48b20d66-e694-4665-a82e-87fcaa6a4ed3") },
                    { new Guid("987d59a6-22a0-48fa-b5b4-702c6f98831e"), new Guid("833c371a-5a42-4d51-8cb4-4c95256182e4") },
                    { new Guid("ce2388b3-90f3-4eb6-99f0-99b7f5c48718"), new Guid("9b0a2a7e-9ac1-4d91-afa8-bc3f0afef999") },
                    { new Guid("ce2388b3-90f3-4eb6-99f0-99b7f5c48718"), new Guid("b32feaa2-402f-4ba1-a562-e69d68db8e7d") },
                    { new Guid("ce2388b3-90f3-4eb6-99f0-99b7f5c48718"), new Guid("e3a70a76-747f-41af-b5ea-086b3c007305") },
                    { new Guid("ce2388b3-90f3-4eb6-99f0-99b7f5c48718"), new Guid("e3c05874-2632-4e65-a8c0-bcff096663f7") },
                    { new Guid("ce2388b3-90f3-4eb6-99f0-99b7f5c48718"), new Guid("f1c7e45e-17b5-415b-8b52-039f62e13850") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("04820df9-a9d1-4d71-9474-d8003f9aab31"), new Guid("1f984af0-8221-4875-915f-a91a3018d0a2"), null, "Полезная модель" },
                    { new Guid("0b886e8c-743d-4427-b3ca-e9943263c936"), new Guid("dcf73805-38e1-4898-a02b-6e22f04dcea2"), null, "Да" },
                    { new Guid("21d62862-5d3a-4a05-8939-ec8a11b79b64"), new Guid("3b89eb54-981f-4eda-9e8d-ea2568fb5dfa"), null, "Полезная модель" },
                    { new Guid("26702748-307e-4858-b3b9-4638dd41af79"), new Guid("1f984af0-8221-4875-915f-a91a3018d0a2"), null, "База данных" },
                    { new Guid("2953ab88-0e26-4a89-b63b-7b40464c8d5a"), new Guid("b8ae2184-3762-49b7-93ff-87085a5aa0b0"), null, "Исполнитель" },
                    { new Guid("35198a69-2767-4ca0-9fd2-535159621d33"), new Guid("8558addf-02f4-4715-bc5e-e79c60047df6"), null, "Лекции" },
                    { new Guid("354030ce-4dbf-46ff-89b2-40851e4fd5d8"), new Guid("2461b946-2e5d-4d7c-b9e6-fccd5d434cf3"), null, "Иностранный" },
                    { new Guid("3949b9a6-ceec-49bd-b240-765fd5dd4f61"), new Guid("dcf73805-38e1-4898-a02b-6e22f04dcea2"), null, "Нет" },
                    { new Guid("4a12a7c5-f903-46b0-9900-88231ccd2103"), new Guid("1f984af0-8221-4875-915f-a91a3018d0a2"), null, "Изобретение" },
                    { new Guid("63944467-68f9-430c-a25b-b1ab6a97c6e9"), new Guid("50c66689-3a2e-429c-bc5f-b599f6cf5033"), null, "Всероссийский" },
                    { new Guid("64fccd35-f614-4471-b219-acc5331371fa"), new Guid("50c66689-3a2e-429c-bc5f-b599f6cf5033"), null, "Международный" },
                    { new Guid("6a52362f-50fb-42e6-a418-adf55a5c8acc"), new Guid("bd123b1b-6637-4003-b2b4-75058aeff3bc"), null, "Учебник" },
                    { new Guid("75839b1e-d91a-41cc-9004-eaf55f9b9bb8"), new Guid("bd123b1b-6637-4003-b2b4-75058aeff3bc"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("831c1b74-4555-406a-941e-4f96ba46f9c2"), new Guid("3b89eb54-981f-4eda-9e8d-ea2568fb5dfa"), null, "Изобретение" },
                    { new Guid("9e3e7a18-5ede-47a5-bc25-da5a73e3d775"), new Guid("8558addf-02f4-4715-bc5e-e79c60047df6"), null, "Лабораторные" },
                    { new Guid("dbd738dc-0df5-4e2c-9ca7-c0fa85d36d04"), new Guid("b8ae2184-3762-49b7-93ff-87085a5aa0b0"), null, "Руководитель" },
                    { new Guid("e89f60d8-7987-4fef-ab16-f2811ea58c15"), new Guid("3b89eb54-981f-4eda-9e8d-ea2568fb5dfa"), null, "База данных" },
                    { new Guid("efa2a4e6-0dd6-411e-bac9-93f4e719ecd4"), new Guid("50c66689-3a2e-429c-bc5f-b599f6cf5033"), null, "Региональный" },
                    { new Guid("f8e505a6-320b-40e7-91a9-236e79f3f87c"), new Guid("bd123b1b-6637-4003-b2b4-75058aeff3bc"), null, "Монография" },
                    { new Guid("ffe3c3bb-1182-4204-ac76-f27eb9678b20"), new Guid("2461b946-2e5d-4d7c-b9e6-fccd5d434cf3"), null, "Русский" }
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
