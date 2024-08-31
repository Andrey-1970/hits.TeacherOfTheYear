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
                    { new Guid("5eec3d78-b18a-4e1f-9319-bb2a011b1f11"), 6, "Оценена" },
                    { new Guid("6557ad5b-b1ea-4609-92e3-b55bdf76cefb"), 3, "В процессе рассмотрения" },
                    { new Guid("70b4446f-3028-4a59-8bbb-73d906ef670a"), 5, "Отклонена" },
                    { new Guid("92ff5c21-6d02-4724-800c-c5b3e734e17c"), 2, "В ожидании рассмотрения" },
                    { new Guid("a5e4adda-a210-4aa4-8845-6816b1019dff"), 4, "Одобрена" },
                    { new Guid("f57b919f-114c-47ea-9450-a86bbc1d802f"), 1, "В ожидании заполнения" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("48408019-e00e-4dd3-b398-0a04d0473172"), "Строительство и архитектура", 1 },
                    { new Guid("d5d6ced7-087e-4096-8fd4-81122c236419"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0a4a83f0-8acd-46a8-bdf2-9da32876d192"), "Деятельность", 5 },
                    { new Guid("539c0aa4-b3ea-4ef7-bb6c-264e064dabd2"), "Профессиональное развитие", 3 },
                    { new Guid("822c3154-9f58-4d6d-b499-5b185474726f"), "Категория участников", 2 },
                    { new Guid("cc45c134-851b-409c-bb25-103e7cb74792"), "Общая информация", 1 },
                    { new Guid("d74659cf-c6bd-4dbf-8684-f934b3fd03d6"), "Деятельность", 4 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("1aa5a36b-6c54-4aa3-a244-b63e7d9b1949"), "Профессиональные показатели", 4 },
                    { new Guid("3b0d1d7f-2b46-4b9b-9f04-ca262c41ce12"), "Инновационная и иная деятельность", 6 },
                    { new Guid("538037b2-ed4f-46da-9ca1-8b6ec103f4cb"), "Методическая деятельность", 3 },
                    { new Guid("57185318-9cd0-44d9-83c9-03997ba9d341"), "Основной", 1 },
                    { new Guid("7480b9d0-5330-4367-9678-f44df826ea53"), "Образовательная деятельность", 2 },
                    { new Guid("78e4307e-edfd-4712-88a7-52af60d878c2"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("eccb5078-7bde-4960-a68e-763e453184b9"), "Конкурсная работа", 7 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("1e2a3985-6a17-410e-8483-d49fb8282ec4"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("c8c803bc-6b78-4408-a48e-d804b299bbbd"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("6c00194d-d990-4710-b454-d3f556d3b503"), "User 1", "admin@mail.ru" },
                    { new Guid("77fe5ab5-8b5b-47be-a3c5-2ab9b4ee3904"), "User 2", "user@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35"), "int" },
                    { new Guid("614ff430-7064-4691-a370-ef5a118daf9b"), "string" },
                    { new Guid("6a9a5d06-3081-4ddd-80ae-fc8f015120ec"), "bool" },
                    { new Guid("b3e926e5-8934-42af-96e6-bb1a7d2b6bc0"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0a4a83f0-8acd-46a8-bdf2-9da32876d192"), new Guid("c8c803bc-6b78-4408-a48e-d804b299bbbd") },
                    { new Guid("539c0aa4-b3ea-4ef7-bb6c-264e064dabd2"), new Guid("1e2a3985-6a17-410e-8483-d49fb8282ec4") },
                    { new Guid("539c0aa4-b3ea-4ef7-bb6c-264e064dabd2"), new Guid("c8c803bc-6b78-4408-a48e-d804b299bbbd") },
                    { new Guid("822c3154-9f58-4d6d-b499-5b185474726f"), new Guid("1e2a3985-6a17-410e-8483-d49fb8282ec4") },
                    { new Guid("822c3154-9f58-4d6d-b499-5b185474726f"), new Guid("c8c803bc-6b78-4408-a48e-d804b299bbbd") },
                    { new Guid("cc45c134-851b-409c-bb25-103e7cb74792"), new Guid("1e2a3985-6a17-410e-8483-d49fb8282ec4") },
                    { new Guid("cc45c134-851b-409c-bb25-103e7cb74792"), new Guid("c8c803bc-6b78-4408-a48e-d804b299bbbd") },
                    { new Guid("d74659cf-c6bd-4dbf-8684-f934b3fd03d6"), new Guid("1e2a3985-6a17-410e-8483-d49fb8282ec4") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("18865aa3-8d33-4078-87bc-686104c7b6b4"), new Guid("cc45c134-851b-409c-bb25-103e7cb74792"), null, true, "Должность", 9, "Введите свою должность в организации", new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("1c6b3a72-89a3-4fb3-bddc-da7e46e9da34"), new Guid("0a4a83f0-8acd-46a8-bdf2-9da32876d192"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("1ff77572-ddeb-44ba-a7e5-42728786b241"), new Guid("cc45c134-851b-409c-bb25-103e7cb74792"), null, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("231a1abf-d250-4803-9ae9-36c7f094bb82"), new Guid("822c3154-9f58-4d6d-b499-5b185474726f"), null, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("240415f6-ec4b-407f-833e-4eea9d3f3c8c"), new Guid("822c3154-9f58-4d6d-b499-5b185474726f"), null, true, "Ссылка на конкурсную работу", 13, "Введите ссылку своей конкурсной работы", new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("33880d65-2942-4ffb-abd6-3287925700aa"), new Guid("d74659cf-c6bd-4dbf-8684-f934b3fd03d6"), "Руководство дипломными проектами за предыдущий учебный год", true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("3a811ab9-b949-404d-b6fa-3285de7f1c03"), new Guid("cc45c134-851b-409c-bb25-103e7cb74792"), null, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("4422e57a-829b-45e1-af55-87f78291a482"), new Guid("cc45c134-851b-409c-bb25-103e7cb74792"), null, true, "Дата рождения", 2, "01.01.2000", new Guid("b3e926e5-8934-42af-96e6-bb1a7d2b6bc0") },
                    { new Guid("46e19fb3-0b51-4821-8d5a-13f1fec31ac8"), new Guid("cc45c134-851b-409c-bb25-103e7cb74792"), null, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("4b4d6203-7e86-4009-81ce-14a411f1d9a7"), new Guid("822c3154-9f58-4d6d-b499-5b185474726f"), null, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("5b1a48a9-8780-4c8a-9dc4-92660272750f"), new Guid("cc45c134-851b-409c-bb25-103e7cb74792"), null, true, "Место работы/учебы", 6, "Название организации", new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("5c6882ba-bbba-468b-9081-f90769147664"), new Guid("cc45c134-851b-409c-bb25-103e7cb74792"), null, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("5d7cf0cd-6fd5-4f96-824f-d666e14444f2"), new Guid("0a4a83f0-8acd-46a8-bdf2-9da32876d192"), null, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("76c87a49-ee3c-483e-8c27-8a540da0153b"), new Guid("822c3154-9f58-4d6d-b499-5b185474726f"), null, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("76c8d2bf-6eb6-411d-87e4-4c18d08a8c75"), new Guid("cc45c134-851b-409c-bb25-103e7cb74792"), null, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("8ef24f91-8788-4427-9084-4ab32d838643"), new Guid("d74659cf-c6bd-4dbf-8684-f934b3fd03d6"), null, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("a17228e1-5beb-4096-869f-6bae9211a22b"), new Guid("822c3154-9f58-4d6d-b499-5b185474726f"), null, true, "Название конкурсной работы", 12, "Введите название своей конкурсной работы", new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("ae2f63a3-4ac0-477c-bdf6-def159daae5e"), new Guid("822c3154-9f58-4d6d-b499-5b185474726f"), null, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("b31f9ce8-2a5b-4b28-9799-07af758f5598"), new Guid("cc45c134-851b-409c-bb25-103e7cb74792"), null, true, "Электронная почта", 5, "user@example.com", new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("b751b13e-c06f-4210-8877-af6f62c1ebef"), new Guid("cc45c134-851b-409c-bb25-103e7cb74792"), null, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("c84b064b-f703-49aa-8feb-3c6d8d0dd66b"), new Guid("d74659cf-c6bd-4dbf-8684-f934b3fd03d6"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("1aa5a36b-6c54-4aa3-a244-b63e7d9b1949"), new Guid("1e2a3985-6a17-410e-8483-d49fb8282ec4") },
                    { new Guid("3b0d1d7f-2b46-4b9b-9f04-ca262c41ce12"), new Guid("c8c803bc-6b78-4408-a48e-d804b299bbbd") },
                    { new Guid("538037b2-ed4f-46da-9ca1-8b6ec103f4cb"), new Guid("1e2a3985-6a17-410e-8483-d49fb8282ec4") },
                    { new Guid("57185318-9cd0-44d9-83c9-03997ba9d341"), new Guid("1e2a3985-6a17-410e-8483-d49fb8282ec4") },
                    { new Guid("57185318-9cd0-44d9-83c9-03997ba9d341"), new Guid("c8c803bc-6b78-4408-a48e-d804b299bbbd") },
                    { new Guid("7480b9d0-5330-4367-9678-f44df826ea53"), new Guid("1e2a3985-6a17-410e-8483-d49fb8282ec4") },
                    { new Guid("78e4307e-edfd-4712-88a7-52af60d878c2"), new Guid("c8c803bc-6b78-4408-a48e-d804b299bbbd") },
                    { new Guid("eccb5078-7bde-4960-a68e-763e453184b9"), new Guid("1e2a3985-6a17-410e-8483-d49fb8282ec4") },
                    { new Guid("eccb5078-7bde-4960-a68e-763e453184b9"), new Guid("c8c803bc-6b78-4408-a48e-d804b299bbbd") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("024f549f-e6d7-4c1f-8029-83ebb2d550b9"), new Guid("d74659cf-c6bd-4dbf-8684-f934b3fd03d6"), false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("1ac699cd-e4da-4e65-ab6c-d1f53d9c711a"), new Guid("d74659cf-c6bd-4dbf-8684-f934b3fd03d6"), false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("1da1da32-67b6-4b51-9067-af24170053f4"), new Guid("d74659cf-c6bd-4dbf-8684-f934b3fd03d6"), false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("25528442-cfa7-4166-9a4e-2d47af512050"), new Guid("0a4a83f0-8acd-46a8-bdf2-9da32876d192"), true, "Персональные идентификаторы", 10 },
                    { new Guid("49500e47-c27a-4cf8-a00e-163c02a8c4e9"), new Guid("d74659cf-c6bd-4dbf-8684-f934b3fd03d6"), false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("52c5b3ea-8079-40f8-ad5b-ab26d68d917e"), new Guid("0a4a83f0-8acd-46a8-bdf2-9da32876d192"), false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("7068bebc-5366-47bf-9d94-34dbad647f39"), new Guid("0a4a83f0-8acd-46a8-bdf2-9da32876d192"), false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("778a01ec-17de-450c-abdc-67be26aa5237"), new Guid("539c0aa4-b3ea-4ef7-bb6c-264e064dabd2"), false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("860cf7d7-d44d-42d1-8332-fa9870971847"), new Guid("539c0aa4-b3ea-4ef7-bb6c-264e064dabd2"), false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("a36767c8-c1ae-4556-aacd-820c1382538d"), new Guid("0a4a83f0-8acd-46a8-bdf2-9da32876d192"), false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("b8abd972-aa72-45dc-9514-b301d9e8e86c"), new Guid("d74659cf-c6bd-4dbf-8684-f934b3fd03d6"), false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("c0e3dd9f-86aa-4d8a-8cf2-80f8577cd91a"), new Guid("d74659cf-c6bd-4dbf-8684-f934b3fd03d6"), false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("f493eb1f-2036-4e6e-b803-a90663570db2"), new Guid("0a4a83f0-8acd-46a8-bdf2-9da32876d192"), false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0398a03c-28b9-4238-b95e-c0a9fa54940f"), true, "Название разработки", 2, new Guid("f493eb1f-2036-4e6e-b803-a90663570db2"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("07bd0bc4-4b31-4f84-9b65-bacc97c6dc9a"), true, "Наличие грифа", 5, new Guid("1da1da32-67b6-4b51-9067-af24170053f4"), new Guid("6a9a5d06-3081-4ddd-80ae-fc8f015120ec") },
                    { new Guid("09b8a964-6538-4b7a-9d45-4c5f55ef3915"), true, "Название конкурса/премии", 2, new Guid("49500e47-c27a-4cf8-a00e-163c02a8c4e9"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("0f60ae81-ed91-44ff-89e9-fe70802e4fce"), true, "Название дисциплины", 1, new Guid("024f549f-e6d7-4c1f-8029-83ebb2d550b9"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("1a3683e3-e55e-4c27-9858-43d22d3b3eeb"), true, "Издательство, год", 6, new Guid("1da1da32-67b6-4b51-9067-af24170053f4"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("209840ed-1aff-450d-9482-a1417ee3c943"), true, "Вид", 1, new Guid("f493eb1f-2036-4e6e-b803-a90663570db2"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("27631e54-bf0f-4a74-8d28-5a6531ea30ca"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("49500e47-c27a-4cf8-a00e-163c02a8c4e9"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("2bb12708-f7b0-442a-8dc8-f500804babe3"), true, "Ссылка на платформу", 3, new Guid("b8abd972-aa72-45dc-9514-b301d9e8e86c"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("48facd9d-21d7-441a-ba69-687ed1d84593"), true, "Год", 4, new Guid("b8abd972-aa72-45dc-9514-b301d9e8e86c"), new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("4f42d2fc-5c7c-46fb-b7e7-8fb02f00890d"), true, "Итого (час.)", 5, new Guid("1ac699cd-e4da-4e65-ab6c-d1f53d9c711a"), new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("52f8362f-6321-49e5-a637-27a39e683a81"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("52c5b3ea-8079-40f8-ad5b-ab26d68d917e"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("54b3b26e-9606-4831-9daa-d15731c574e7"), true, "Количество печатных листов", 4, new Guid("1da1da32-67b6-4b51-9067-af24170053f4"), new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("5e041b48-706f-4a3a-9db5-19327b515e10"), true, "Количество часов", 4, new Guid("c0e3dd9f-86aa-4d8a-8cf2-80f8577cd91a"), new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("633a2882-bfc8-4775-8434-a10452cde296"), false, "Тип идентификатора", 1, new Guid("25528442-cfa7-4166-9a4e-2d47af512050"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("6634c1f5-d81d-45e0-8e6a-8ba2e87a41b2"), true, "Язык публикации", 7, new Guid("1da1da32-67b6-4b51-9067-af24170053f4"), new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("6d0f99b1-6793-4237-b854-4e6b683f1f06"), true, "Название", 2, new Guid("a36767c8-c1ae-4556-aacd-820c1382538d"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("6d5c3cb0-52a4-4981-a352-2375e4cccfa4"), true, "Название НИР/НИОКР", 1, new Guid("52c5b3ea-8079-40f8-ad5b-ab26d68d917e"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("773f9004-859b-4993-9544-a9779b69ab32"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("52c5b3ea-8079-40f8-ad5b-ab26d68d917e"), new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("78339566-e8da-4746-8cae-dedf46b05108"), true, "Название", 2, new Guid("1da1da32-67b6-4b51-9067-af24170053f4"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("7970cd01-8b2e-411a-a4d3-066893bd389f"), true, "ФИО", 1, new Guid("49500e47-c27a-4cf8-a00e-163c02a8c4e9"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("79fca59b-2dad-4ab7-b1c2-dacd374caab8"), true, "Год", 1, new Guid("860cf7d7-d44d-42d1-8332-fa9870971847"), new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("7b35d21c-7daf-49da-86d2-1af4c497c8c1"), true, "Период выполнения", 3, new Guid("52c5b3ea-8079-40f8-ad5b-ab26d68d917e"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("80ea4d22-3bd3-4169-8d2d-8f7ff8dc2a0e"), true, "Номер РИД", 4, new Guid("a36767c8-c1ae-4556-aacd-820c1382538d"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("87ac3df8-0a3f-488c-b91d-fa6df3cb35e5"), true, "Название организации/должность/ставка", 1, new Guid("c0e3dd9f-86aa-4d8a-8cf2-80f8577cd91a"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("8961c9fd-36c0-47c3-95d0-afc10ba41d9b"), true, "Вид (лекции, лабораторные)", 2, new Guid("024f549f-e6d7-4c1f-8029-83ebb2d550b9"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("8b8fb155-2080-4ca6-8163-09d9169d6c0a"), false, "Идентификатор", 2, new Guid("25528442-cfa7-4166-9a4e-2d47af512050"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("91f1c1cb-8da4-4631-b386-84f277adfd3b"), true, "Ссылка", 5, new Guid("860cf7d7-d44d-42d1-8332-fa9870971847"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("96b2ea8f-ed91-43c1-a2b5-416006706018"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("c0e3dd9f-86aa-4d8a-8cf2-80f8577cd91a"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("9709f193-239f-4fbe-bbc1-98054ea071cf"), true, "ФИО соавторов", 3, new Guid("a36767c8-c1ae-4556-aacd-820c1382538d"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("982efe87-6041-46bc-b672-8ed0fc6b4cf1"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("1ac699cd-e4da-4e65-ab6c-d1f53d9c711a"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("9f9ed1d7-cec3-4b1f-b64f-9a5705b01c61"), true, "Практические занятия (час.)", 4, new Guid("1ac699cd-e4da-4e65-ab6c-d1f53d9c711a"), new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("a1c998c0-78b2-482d-bd2e-1fae0a6e7180"), true, "Наименование курса", 1, new Guid("1ac699cd-e4da-4e65-ab6c-d1f53d9c711a"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("a49a4bed-e450-42d3-b037-83253b2ed62e"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("49500e47-c27a-4cf8-a00e-163c02a8c4e9"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("abc83e4e-e8e4-419e-8253-dd700c36b249"), true, "Вид публикации", 1, new Guid("1da1da32-67b6-4b51-9067-af24170053f4"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("bf92cbe7-cbc8-479d-958f-8950d7570870"), true, "Год", 3, new Guid("49500e47-c27a-4cf8-a00e-163c02a8c4e9"), new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("bfd438ed-1112-4956-8dfa-65fdd1907f71"), true, "Вид деятельности (преподавательская)", 3, new Guid("c0e3dd9f-86aa-4d8a-8cf2-80f8577cd91a"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("c21965d6-873b-4a9f-b812-4212a62b5d0e"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("7068bebc-5366-47bf-9d94-34dbad647f39"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("c3c44ce4-18d6-4df1-b892-9544ffb8a2d9"), true, "Название организации в которую внедрена разработка", 3, new Guid("f493eb1f-2036-4e6e-b803-a90663570db2"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("ca14ce38-e6ca-419e-b1a0-ab1822d28e70"), true, "Название курса", 1, new Guid("b8abd972-aa72-45dc-9514-b301d9e8e86c"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("d0dff28d-52dc-48d0-941d-876d48d4ec04"), false, "Соавторы", 3, new Guid("1da1da32-67b6-4b51-9067-af24170053f4"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("d595c169-6f91-409a-8a08-8dffeb170f47"), true, "Статус (руководитель/исполнитель)", 4, new Guid("52c5b3ea-8079-40f8-ad5b-ab26d68d917e"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("d805e776-6dc1-4661-8f76-e319fa9ab88a"), true, "Название конкурса", 2, new Guid("860cf7d7-d44d-42d1-8332-fa9870971847"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("da344cab-c1bd-40f7-b04e-e5d8eac8036f"), true, "Лекции (час.)", 3, new Guid("1ac699cd-e4da-4e65-ab6c-d1f53d9c711a"), new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("e066c842-b57e-4222-8263-f89b6567467e"), true, "Год получения документа", 2, new Guid("778a01ec-17de-450c-abdc-67be26aa5237"), new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("e1624eac-17d0-41da-8a18-bdbbfbd62147"), true, "Награда", 4, new Guid("860cf7d7-d44d-42d1-8332-fa9870971847"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("e326a2e9-4ed0-4809-ba1c-6d6da4e3a072"), true, "Соавторы", 2, new Guid("b8abd972-aa72-45dc-9514-b301d9e8e86c"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("e49b0999-71b3-419b-af22-ea69be28008e"), true, "Ссылка на открытый доступ", 8, new Guid("1da1da32-67b6-4b51-9067-af24170053f4"), new Guid("181c273c-d450-4c03-b8a5-f57aa3ef5f35") },
                    { new Guid("eb1752b2-9db1-4ce9-8bb3-48f04b239db7"), true, "Вид", 1, new Guid("a36767c8-c1ae-4556-aacd-820c1382538d"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("ed2dc31a-6b39-424c-b696-5fd0666e4a99"), true, "Издание, год", 4, new Guid("7068bebc-5366-47bf-9d94-34dbad647f39"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("f34f512d-ccc2-45dc-98e1-144a62ef729c"), true, "Статус конкурса", 3, new Guid("860cf7d7-d44d-42d1-8332-fa9870971847"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("faf07c01-cd72-401d-b6b9-7a1b6b43bfaa"), true, "Соавторы", 2, new Guid("7068bebc-5366-47bf-9d94-34dbad647f39"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("fb5766d6-22d1-4b6c-9e49-f478717025fd"), true, "Название статьи", 1, new Guid("7068bebc-5366-47bf-9d94-34dbad647f39"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") },
                    { new Guid("ff98ff3c-8908-47f4-b0ab-2e47920c99dc"), true, "Название документа, реквизиты", 1, new Guid("778a01ec-17de-450c-abdc-67be26aa5237"), new Guid("614ff430-7064-4691-a370-ef5a118daf9b") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("18865aa3-8d33-4078-87bc-686104c7b6b4"), new Guid("57185318-9cd0-44d9-83c9-03997ba9d341") },
                    { new Guid("1c6b3a72-89a3-4fb3-bddc-da7e46e9da34"), new Guid("78e4307e-edfd-4712-88a7-52af60d878c2") },
                    { new Guid("1ff77572-ddeb-44ba-a7e5-42728786b241"), new Guid("57185318-9cd0-44d9-83c9-03997ba9d341") },
                    { new Guid("231a1abf-d250-4803-9ae9-36c7f094bb82"), new Guid("57185318-9cd0-44d9-83c9-03997ba9d341") },
                    { new Guid("240415f6-ec4b-407f-833e-4eea9d3f3c8c"), new Guid("eccb5078-7bde-4960-a68e-763e453184b9") },
                    { new Guid("33880d65-2942-4ffb-abd6-3287925700aa"), new Guid("7480b9d0-5330-4367-9678-f44df826ea53") },
                    { new Guid("3a811ab9-b949-404d-b6fa-3285de7f1c03"), new Guid("57185318-9cd0-44d9-83c9-03997ba9d341") },
                    { new Guid("4422e57a-829b-45e1-af55-87f78291a482"), new Guid("57185318-9cd0-44d9-83c9-03997ba9d341") },
                    { new Guid("46e19fb3-0b51-4821-8d5a-13f1fec31ac8"), new Guid("57185318-9cd0-44d9-83c9-03997ba9d341") },
                    { new Guid("4b4d6203-7e86-4009-81ce-14a411f1d9a7"), new Guid("57185318-9cd0-44d9-83c9-03997ba9d341") },
                    { new Guid("5b1a48a9-8780-4c8a-9dc4-92660272750f"), new Guid("57185318-9cd0-44d9-83c9-03997ba9d341") },
                    { new Guid("5c6882ba-bbba-468b-9081-f90769147664"), new Guid("57185318-9cd0-44d9-83c9-03997ba9d341") },
                    { new Guid("5d7cf0cd-6fd5-4f96-824f-d666e14444f2"), new Guid("78e4307e-edfd-4712-88a7-52af60d878c2") },
                    { new Guid("76c87a49-ee3c-483e-8c27-8a540da0153b"), new Guid("1aa5a36b-6c54-4aa3-a244-b63e7d9b1949") },
                    { new Guid("76c87a49-ee3c-483e-8c27-8a540da0153b"), new Guid("57185318-9cd0-44d9-83c9-03997ba9d341") },
                    { new Guid("76c87a49-ee3c-483e-8c27-8a540da0153b"), new Guid("78e4307e-edfd-4712-88a7-52af60d878c2") },
                    { new Guid("76c8d2bf-6eb6-411d-87e4-4c18d08a8c75"), new Guid("57185318-9cd0-44d9-83c9-03997ba9d341") },
                    { new Guid("8ef24f91-8788-4427-9084-4ab32d838643"), new Guid("7480b9d0-5330-4367-9678-f44df826ea53") },
                    { new Guid("a17228e1-5beb-4096-869f-6bae9211a22b"), new Guid("eccb5078-7bde-4960-a68e-763e453184b9") },
                    { new Guid("ae2f63a3-4ac0-477c-bdf6-def159daae5e"), new Guid("57185318-9cd0-44d9-83c9-03997ba9d341") },
                    { new Guid("b31f9ce8-2a5b-4b28-9799-07af758f5598"), new Guid("57185318-9cd0-44d9-83c9-03997ba9d341") },
                    { new Guid("b751b13e-c06f-4210-8877-af6f62c1ebef"), new Guid("57185318-9cd0-44d9-83c9-03997ba9d341") },
                    { new Guid("c84b064b-f703-49aa-8feb-3c6d8d0dd66b"), new Guid("7480b9d0-5330-4367-9678-f44df826ea53") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("1aa5a36b-6c54-4aa3-a244-b63e7d9b1949"), new Guid("778a01ec-17de-450c-abdc-67be26aa5237") },
                    { new Guid("1aa5a36b-6c54-4aa3-a244-b63e7d9b1949"), new Guid("860cf7d7-d44d-42d1-8332-fa9870971847") },
                    { new Guid("3b0d1d7f-2b46-4b9b-9f04-ca262c41ce12"), new Guid("778a01ec-17de-450c-abdc-67be26aa5237") },
                    { new Guid("3b0d1d7f-2b46-4b9b-9f04-ca262c41ce12"), new Guid("a36767c8-c1ae-4556-aacd-820c1382538d") },
                    { new Guid("3b0d1d7f-2b46-4b9b-9f04-ca262c41ce12"), new Guid("f493eb1f-2036-4e6e-b803-a90663570db2") },
                    { new Guid("538037b2-ed4f-46da-9ca1-8b6ec103f4cb"), new Guid("024f549f-e6d7-4c1f-8029-83ebb2d550b9") },
                    { new Guid("538037b2-ed4f-46da-9ca1-8b6ec103f4cb"), new Guid("1da1da32-67b6-4b51-9067-af24170053f4") },
                    { new Guid("7480b9d0-5330-4367-9678-f44df826ea53"), new Guid("1ac699cd-e4da-4e65-ab6c-d1f53d9c711a") },
                    { new Guid("7480b9d0-5330-4367-9678-f44df826ea53"), new Guid("49500e47-c27a-4cf8-a00e-163c02a8c4e9") },
                    { new Guid("7480b9d0-5330-4367-9678-f44df826ea53"), new Guid("b8abd972-aa72-45dc-9514-b301d9e8e86c") },
                    { new Guid("7480b9d0-5330-4367-9678-f44df826ea53"), new Guid("c0e3dd9f-86aa-4d8a-8cf2-80f8577cd91a") },
                    { new Guid("78e4307e-edfd-4712-88a7-52af60d878c2"), new Guid("52c5b3ea-8079-40f8-ad5b-ab26d68d917e") },
                    { new Guid("78e4307e-edfd-4712-88a7-52af60d878c2"), new Guid("7068bebc-5366-47bf-9d94-34dbad647f39") },
                    { new Guid("78e4307e-edfd-4712-88a7-52af60d878c2"), new Guid("860cf7d7-d44d-42d1-8332-fa9870971847") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("00cde3f5-bae9-4046-b1ae-b070af93b837"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("52c5b3ea-8079-40f8-ad5b-ab26d68d917e") },
                    { new Guid("06147156-6d11-4b6f-b0ad-15633afbf1b4"), "EvaluateMark5", new Guid("8ef24f91-8788-4427-9084-4ab32d838643"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("173a78fd-750a-4b66-adc1-bf56f2f9133d"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("1da1da32-67b6-4b51-9067-af24170053f4") },
                    { new Guid("34f8ff15-ccb6-4384-a947-8487cd8198e9"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("f493eb1f-2036-4e6e-b803-a90663570db2") },
                    { new Guid("3faad36f-fe97-4bd8-9262-3487a17bd125"), "EvaluateMark3", new Guid("33880d65-2942-4ffb-abd6-3287925700aa"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("4187042a-03ca-43f4-b750-81fbd2f4c7eb"), "EvaluateMark20", new Guid("5d7cf0cd-6fd5-4f96-824f-d666e14444f2"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("422fbc51-cbd4-423e-92b3-bc00965a8282"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("1da1da32-67b6-4b51-9067-af24170053f4") },
                    { new Guid("4306857a-17e9-4592-99d1-bd7d5928ccd9"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("860cf7d7-d44d-42d1-8332-fa9870971847") },
                    { new Guid("43406a17-f56c-4786-b147-c26a471474e7"), null, new Guid("240415f6-ec4b-407f-833e-4eea9d3f3c8c"), false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null },
                    { new Guid("4ae89c03-d12f-4c32-b39a-d87783ef5bf1"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("52c5b3ea-8079-40f8-ad5b-ab26d68d917e") },
                    { new Guid("55ff3134-6029-4cda-91f5-a5fc47e24ab8"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("024f549f-e6d7-4c1f-8029-83ebb2d550b9") },
                    { new Guid("5ac90f5d-f4da-41dc-b9bc-9483344c9b39"), "EvaluateMark4", new Guid("c84b064b-f703-49aa-8feb-3c6d8d0dd66b"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("631a3d3c-65cb-43e0-afb8-cec175559266"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("778a01ec-17de-450c-abdc-67be26aa5237") },
                    { new Guid("6929e9d3-970e-4927-9de9-a3a608cd8759"), "EvaluateMark19", new Guid("1c6b3a72-89a3-4fb3-bddc-da7e46e9da34"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("6d7aae53-84e9-41c4-adec-6bb843ffdb4e"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("1ac699cd-e4da-4e65-ab6c-d1f53d9c711a") },
                    { new Guid("86102120-9d0a-4a63-8bc6-d11f2bc505c0"), null, new Guid("240415f6-ec4b-407f-833e-4eea9d3f3c8c"), false, 10, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("8a010216-3072-4532-9c9e-0e19cd8aeae3"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("49500e47-c27a-4cf8-a00e-163c02a8c4e9") },
                    { new Guid("9b989651-6818-472a-b2f1-0ed4dcb804a3"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("b8abd972-aa72-45dc-9514-b301d9e8e86c") },
                    { new Guid("a657173b-6faf-4d6a-bcca-5461ad081046"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("a36767c8-c1ae-4556-aacd-820c1382538d") },
                    { new Guid("b63ce748-195c-4b93-9512-661c9826546c"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("1da1da32-67b6-4b51-9067-af24170053f4") },
                    { new Guid("b842fdd8-de6d-4181-bf0d-60a55fc1bad3"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("7068bebc-5366-47bf-9d94-34dbad647f39") },
                    { new Guid("c9dcd70f-024f-4a8f-b80e-c579f20709ac"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("1ac699cd-e4da-4e65-ab6c-d1f53d9c711a") },
                    { new Guid("dab4ba78-7451-4d82-997f-cc195ea42869"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("1da1da32-67b6-4b51-9067-af24170053f4") },
                    { new Guid("fc6d7978-0784-422c-ae24-09e5adc75527"), "EvaluateMark13", new Guid("76c87a49-ee3c-483e-8c27-8a540da0153b"), true, 5, "Баллы за ученое звание:", 13, null }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("014ad11b-026c-40c9-acde-b6091102c02f"), true, new Guid("25528442-cfa7-4166-9a4e-2d47af512050") },
                    { new Guid("232d4486-09bb-4987-879d-8d2a8e09a5f3"), true, new Guid("25528442-cfa7-4166-9a4e-2d47af512050") },
                    { new Guid("3f9461ef-7a13-461b-a4d5-48f30bfa44da"), true, new Guid("25528442-cfa7-4166-9a4e-2d47af512050") },
                    { new Guid("77abbe48-3219-4da0-bc43-fe69f025779e"), true, new Guid("25528442-cfa7-4166-9a4e-2d47af512050") },
                    { new Guid("8ac25860-d7e6-4475-a4c2-779046abc376"), true, new Guid("25528442-cfa7-4166-9a4e-2d47af512050") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("603ae54e-fec6-4d2e-a1d5-057dc92bd72a"), null, new Guid("76c87a49-ee3c-483e-8c27-8a540da0153b"), "Нет" },
                    { new Guid("a0b4f320-73c3-4424-9f0c-400dd3dbe50f"), null, new Guid("76c87a49-ee3c-483e-8c27-8a540da0153b"), "Доцент" },
                    { new Guid("a1f20cd4-786f-48f0-ae39-0f1e6e7da563"), null, new Guid("76c87a49-ee3c-483e-8c27-8a540da0153b"), "Профессор" },
                    { new Guid("c0a0044e-8113-46ab-be52-8953644fc7a5"), null, new Guid("4b4d6203-7e86-4009-81ce-14a411f1d9a7"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("e4b2b26b-05b5-48a6-859c-654135f034c0"), null, new Guid("4b4d6203-7e86-4009-81ce-14a411f1d9a7"), "Имеющие ученую степень доктора наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("39cdd5d5-0a31-4066-a148-55844d8d24a6"), null, new Guid("633a2882-bfc8-4775-8434-a10452cde296"), true, true, new Guid("3f9461ef-7a13-461b-a4d5-48f30bfa44da"), "РИНЦ AuthorID" },
                    { new Guid("4863d798-5cda-4500-ac85-8a5333e49528"), null, new Guid("8b8fb155-2080-4ca6-8163-09d9169d6c0a"), false, true, new Guid("8ac25860-d7e6-4475-a4c2-779046abc376"), null },
                    { new Guid("5e8799bf-f0e3-4b6d-8e4d-4f36f5e537e6"), null, new Guid("8b8fb155-2080-4ca6-8163-09d9169d6c0a"), false, true, new Guid("77abbe48-3219-4da0-bc43-fe69f025779e"), null },
                    { new Guid("68953ff1-4b38-4c28-9468-95f33c0699bb"), null, new Guid("633a2882-bfc8-4775-8434-a10452cde296"), true, true, new Guid("232d4486-09bb-4987-879d-8d2a8e09a5f3"), "ScopusID" },
                    { new Guid("6ef896d3-43fe-401b-b19a-29023bb09330"), null, new Guid("633a2882-bfc8-4775-8434-a10452cde296"), true, true, new Guid("8ac25860-d7e6-4475-a4c2-779046abc376"), "Google Scholar ID" },
                    { new Guid("7c8f74ed-92a3-4d5c-9cac-777cf8df0ef0"), null, new Guid("8b8fb155-2080-4ca6-8163-09d9169d6c0a"), false, true, new Guid("014ad11b-026c-40c9-acde-b6091102c02f"), null },
                    { new Guid("81f8fd8f-fa56-4cc0-8c10-00cb841b9d25"), null, new Guid("8b8fb155-2080-4ca6-8163-09d9169d6c0a"), false, true, new Guid("232d4486-09bb-4987-879d-8d2a8e09a5f3"), null },
                    { new Guid("9002f267-39a8-4d91-9d8c-dcc4a3dc3284"), null, new Guid("633a2882-bfc8-4775-8434-a10452cde296"), true, true, new Guid("014ad11b-026c-40c9-acde-b6091102c02f"), "ResearcherID" },
                    { new Guid("a237d59b-24fc-44d8-84d2-9ad3489ba783"), null, new Guid("8b8fb155-2080-4ca6-8163-09d9169d6c0a"), false, true, new Guid("3f9461ef-7a13-461b-a4d5-48f30bfa44da"), null },
                    { new Guid("c2acf009-cf44-4167-9ebe-64ad8c13bb8b"), null, new Guid("633a2882-bfc8-4775-8434-a10452cde296"), true, true, new Guid("77abbe48-3219-4da0-bc43-fe69f025779e"), "ORCiD" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("1aa5a36b-6c54-4aa3-a244-b63e7d9b1949"), new Guid("4306857a-17e9-4592-99d1-bd7d5928ccd9") },
                    { new Guid("1aa5a36b-6c54-4aa3-a244-b63e7d9b1949"), new Guid("631a3d3c-65cb-43e0-afb8-cec175559266") },
                    { new Guid("1aa5a36b-6c54-4aa3-a244-b63e7d9b1949"), new Guid("fc6d7978-0784-422c-ae24-09e5adc75527") },
                    { new Guid("3b0d1d7f-2b46-4b9b-9f04-ca262c41ce12"), new Guid("34f8ff15-ccb6-4384-a947-8487cd8198e9") },
                    { new Guid("3b0d1d7f-2b46-4b9b-9f04-ca262c41ce12"), new Guid("631a3d3c-65cb-43e0-afb8-cec175559266") },
                    { new Guid("3b0d1d7f-2b46-4b9b-9f04-ca262c41ce12"), new Guid("a657173b-6faf-4d6a-bcca-5461ad081046") },
                    { new Guid("538037b2-ed4f-46da-9ca1-8b6ec103f4cb"), new Guid("173a78fd-750a-4b66-adc1-bf56f2f9133d") },
                    { new Guid("538037b2-ed4f-46da-9ca1-8b6ec103f4cb"), new Guid("422fbc51-cbd4-423e-92b3-bc00965a8282") },
                    { new Guid("538037b2-ed4f-46da-9ca1-8b6ec103f4cb"), new Guid("55ff3134-6029-4cda-91f5-a5fc47e24ab8") },
                    { new Guid("538037b2-ed4f-46da-9ca1-8b6ec103f4cb"), new Guid("b63ce748-195c-4b93-9512-661c9826546c") },
                    { new Guid("538037b2-ed4f-46da-9ca1-8b6ec103f4cb"), new Guid("dab4ba78-7451-4d82-997f-cc195ea42869") },
                    { new Guid("7480b9d0-5330-4367-9678-f44df826ea53"), new Guid("06147156-6d11-4b6f-b0ad-15633afbf1b4") },
                    { new Guid("7480b9d0-5330-4367-9678-f44df826ea53"), new Guid("3faad36f-fe97-4bd8-9262-3487a17bd125") },
                    { new Guid("7480b9d0-5330-4367-9678-f44df826ea53"), new Guid("5ac90f5d-f4da-41dc-b9bc-9483344c9b39") },
                    { new Guid("7480b9d0-5330-4367-9678-f44df826ea53"), new Guid("6d7aae53-84e9-41c4-adec-6bb843ffdb4e") },
                    { new Guid("7480b9d0-5330-4367-9678-f44df826ea53"), new Guid("8a010216-3072-4532-9c9e-0e19cd8aeae3") },
                    { new Guid("7480b9d0-5330-4367-9678-f44df826ea53"), new Guid("9b989651-6818-472a-b2f1-0ed4dcb804a3") },
                    { new Guid("7480b9d0-5330-4367-9678-f44df826ea53"), new Guid("c9dcd70f-024f-4a8f-b80e-c579f20709ac") },
                    { new Guid("78e4307e-edfd-4712-88a7-52af60d878c2"), new Guid("00cde3f5-bae9-4046-b1ae-b070af93b837") },
                    { new Guid("78e4307e-edfd-4712-88a7-52af60d878c2"), new Guid("4187042a-03ca-43f4-b750-81fbd2f4c7eb") },
                    { new Guid("78e4307e-edfd-4712-88a7-52af60d878c2"), new Guid("4306857a-17e9-4592-99d1-bd7d5928ccd9") },
                    { new Guid("78e4307e-edfd-4712-88a7-52af60d878c2"), new Guid("4ae89c03-d12f-4c32-b39a-d87783ef5bf1") },
                    { new Guid("78e4307e-edfd-4712-88a7-52af60d878c2"), new Guid("6929e9d3-970e-4927-9de9-a3a608cd8759") },
                    { new Guid("78e4307e-edfd-4712-88a7-52af60d878c2"), new Guid("b842fdd8-de6d-4181-bf0d-60a55fc1bad3") },
                    { new Guid("78e4307e-edfd-4712-88a7-52af60d878c2"), new Guid("fc6d7978-0784-422c-ae24-09e5adc75527") },
                    { new Guid("eccb5078-7bde-4960-a68e-763e453184b9"), new Guid("43406a17-f56c-4786-b147-c26a471474e7") },
                    { new Guid("eccb5078-7bde-4960-a68e-763e453184b9"), new Guid("86102120-9d0a-4a63-8bc6-d11f2bc505c0") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("245b0437-8f76-49ff-93b1-b4df440e3538"), new Guid("d595c169-6f91-409a-8a08-8dffeb170f47"), null, "Руководитель" },
                    { new Guid("2837b41f-9e70-49e0-a6cd-9ee7883ed01e"), new Guid("f34f512d-ccc2-45dc-98e1-144a62ef729c"), null, "Всероссийский" },
                    { new Guid("2dab5391-8616-4271-8b39-217e04ddd728"), new Guid("d0dff28d-52dc-48d0-941d-876d48d4ec04"), null, "Нет" },
                    { new Guid("2e08cea0-2f36-4dd5-b809-024aba1eb44c"), new Guid("6634c1f5-d81d-45e0-8e6a-8ba2e87a41b2"), null, "Русский" },
                    { new Guid("425e9054-311c-4b2c-86db-7ee5ea69518e"), new Guid("209840ed-1aff-450d-9482-a1417ee3c943"), null, "Полезная модель" },
                    { new Guid("67108e79-e7ed-468a-8573-f5404171c28b"), new Guid("8961c9fd-36c0-47c3-95d0-afc10ba41d9b"), null, "Лекции" },
                    { new Guid("67772d6a-3b6d-40c3-9c90-10e0edd25984"), new Guid("eb1752b2-9db1-4ce9-8bb3-48f04b239db7"), null, "Изобретение" },
                    { new Guid("6c112ea9-1a8d-47ae-815e-30b6bbb46105"), new Guid("209840ed-1aff-450d-9482-a1417ee3c943"), null, "Изобретение" },
                    { new Guid("a475b09d-e464-4dc7-be04-deffa12f12f0"), new Guid("d0dff28d-52dc-48d0-941d-876d48d4ec04"), null, "Да" },
                    { new Guid("ab35154a-1d29-4ac9-a416-4076de23d4d0"), new Guid("f34f512d-ccc2-45dc-98e1-144a62ef729c"), null, "Международный" },
                    { new Guid("c28b9137-393b-4783-aa7f-ca0565978094"), new Guid("eb1752b2-9db1-4ce9-8bb3-48f04b239db7"), null, "База данных" },
                    { new Guid("d128863e-dea7-416a-9306-751e12303885"), new Guid("d595c169-6f91-409a-8a08-8dffeb170f47"), null, "Исполнитель" },
                    { new Guid("d50a9357-425a-4a46-ba7a-f45e51a1e4c8"), new Guid("6634c1f5-d81d-45e0-8e6a-8ba2e87a41b2"), null, "Иностранный" },
                    { new Guid("d7c63b76-cd06-48c7-b6d7-bbeabc00228b"), new Guid("f34f512d-ccc2-45dc-98e1-144a62ef729c"), null, "Региональный" },
                    { new Guid("df5bdc33-bd66-40e7-89bb-f95946c95c42"), new Guid("abc83e4e-e8e4-419e-8253-dd700c36b249"), null, "Монография" },
                    { new Guid("e1d46459-79ab-4524-b15a-bd7903cc0e38"), new Guid("eb1752b2-9db1-4ce9-8bb3-48f04b239db7"), null, "Полезная модель" },
                    { new Guid("eb44c182-78f1-455b-95ba-6db9406b665a"), new Guid("abc83e4e-e8e4-419e-8253-dd700c36b249"), null, "Учебник" },
                    { new Guid("f02879a9-9445-4232-ad13-66e91daa02ba"), new Guid("209840ed-1aff-450d-9482-a1417ee3c943"), null, "База данных" },
                    { new Guid("f6ae870e-fb19-4340-af18-5316a12b07fc"), new Guid("8961c9fd-36c0-47c3-95d0-afc10ba41d9b"), null, "Лабораторные" },
                    { new Guid("fca44148-f1a5-4175-b5d2-dbcaf5c1fc8a"), new Guid("abc83e4e-e8e4-419e-8253-dd700c36b249"), null, "Учебное и/или учебно-методическое пособие" }
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
