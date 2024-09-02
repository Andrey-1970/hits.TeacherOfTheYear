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
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    VoteTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VoterId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ApplicationFormId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votes_ApplicationForms_ApplicationFormId",
                        column: x => x.ApplicationFormId,
                        principalTable: "ApplicationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Votes_UserInfos_VoterId",
                        column: x => x.VoterId,
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
                    { new Guid("26e0e20e-c270-4748-8ec5-e61c63972031"), 2, "В ожидании рассмотрения" },
                    { new Guid("29420d58-31f9-4a32-b967-0e9f151799ce"), 1, "В ожидании заполнения" },
                    { new Guid("6f0c14eb-249d-4c96-b077-d7dffeb4f6a8"), 3, "В процессе рассмотрения" },
                    { new Guid("9f1bfa7c-d635-49b1-8666-38a2d8fe389e"), 4, "Одобрена" },
                    { new Guid("9fea36c0-55e5-4f87-af53-f233bf9fd376"), 6, "Оценена" },
                    { new Guid("bdab3491-0873-42fd-b1a6-f8fb80216c73"), 5, "Отклонена" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("7fac4c05-7de3-41f2-939f-f1ee5a9cd7cf"), "Строительство и архитектура", 1 },
                    { new Guid("9e13a7f3-770f-4aaf-85ed-1d34dacc9ec0"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("31656f54-967e-4b97-844f-e338d6cd2e37"), "Профессиональное развитие", 3 },
                    { new Guid("6289ecdb-8251-410b-a528-d67f5fea0ada"), "Общая информация", 1 },
                    { new Guid("74bb175f-d2ea-4307-9d0b-17b6c55317be"), "Деятельность", 5 },
                    { new Guid("87e8b2ed-b2f7-40b4-82b2-a47bfb22c2db"), "Деятельность", 4 },
                    { new Guid("b0777302-a4fb-4367-b7ae-eacd8bed54f1"), "Категория участников", 2 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0487eeef-3104-4191-b46a-98a02274014e"), "Профессиональные показатели", 4 },
                    { new Guid("0ba26cef-bc3a-46bd-a42c-225a7f56e2c9"), "Конкурсная работа", 7 },
                    { new Guid("12afaacd-ad1f-4fc4-b30f-a312b7259bb6"), "Методическая деятельность", 3 },
                    { new Guid("387d9f7d-3a39-41a8-9f07-7c300520d085"), "Инновационная и иная деятельность", 6 },
                    { new Guid("4ca1764a-81e2-4103-8502-f87602af0a29"), "Образовательная деятельность", 2 },
                    { new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb"), "Основной", 1 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("1f16b883-2b2f-4668-8c27-c4de7f9ad74f"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("474fa6e1-6b0c-4f7b-97bc-b669ce227b55"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("5f452e23-083d-454c-af2a-4063308b8ea4"), "User 1", "admin@mail.ru" },
                    { new Guid("f4cf0be1-728d-4c5c-9f56-a1ac342ca42d"), "User 2", "user@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("37aafa95-f656-493d-9083-d3f0c28f5ee3"), "DateTime" },
                    { new Guid("53afa585-7e73-4d8b-bf27-ad9d2f905ae8"), "bool" },
                    { new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e"), "int" },
                    { new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737"), "string" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("31656f54-967e-4b97-844f-e338d6cd2e37"), new Guid("1f16b883-2b2f-4668-8c27-c4de7f9ad74f") },
                    { new Guid("31656f54-967e-4b97-844f-e338d6cd2e37"), new Guid("474fa6e1-6b0c-4f7b-97bc-b669ce227b55") },
                    { new Guid("6289ecdb-8251-410b-a528-d67f5fea0ada"), new Guid("1f16b883-2b2f-4668-8c27-c4de7f9ad74f") },
                    { new Guid("6289ecdb-8251-410b-a528-d67f5fea0ada"), new Guid("474fa6e1-6b0c-4f7b-97bc-b669ce227b55") },
                    { new Guid("74bb175f-d2ea-4307-9d0b-17b6c55317be"), new Guid("1f16b883-2b2f-4668-8c27-c4de7f9ad74f") },
                    { new Guid("87e8b2ed-b2f7-40b4-82b2-a47bfb22c2db"), new Guid("474fa6e1-6b0c-4f7b-97bc-b669ce227b55") },
                    { new Guid("b0777302-a4fb-4367-b7ae-eacd8bed54f1"), new Guid("1f16b883-2b2f-4668-8c27-c4de7f9ad74f") },
                    { new Guid("b0777302-a4fb-4367-b7ae-eacd8bed54f1"), new Guid("474fa6e1-6b0c-4f7b-97bc-b669ce227b55") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("23dea0f3-06b7-4eca-83c2-848db0273ccf"), new Guid("6289ecdb-8251-410b-a528-d67f5fea0ada"), null, true, "Место работы/учебы", 6, "Название организации", new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("3b6f10ca-cc78-4d49-aeb4-81129680ba6c"), new Guid("6289ecdb-8251-410b-a528-d67f5fea0ada"), null, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("41b09f99-2195-4322-8864-bd6b94211330"), new Guid("6289ecdb-8251-410b-a528-d67f5fea0ada"), null, true, "Дата рождения", 2, "01.01.2000", new Guid("37aafa95-f656-493d-9083-d3f0c28f5ee3") },
                    { new Guid("56f42679-849e-4516-b5ee-47ef2fcd6eee"), new Guid("6289ecdb-8251-410b-a528-d67f5fea0ada"), null, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("6161dc90-8acb-4ffb-b9ef-a0b20137cd1c"), new Guid("b0777302-a4fb-4367-b7ae-eacd8bed54f1"), null, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("8eae9c5f-ee8d-47bb-95cc-9c58c325a1b7"), new Guid("6289ecdb-8251-410b-a528-d67f5fea0ada"), null, true, "Электронная почта", 5, "user@example.com", new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("91001e70-e4ae-4dae-b6d2-cdcd092b9eca"), new Guid("87e8b2ed-b2f7-40b4-82b2-a47bfb22c2db"), null, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("9115911e-1da6-465e-b927-212c33082e6e"), new Guid("87e8b2ed-b2f7-40b4-82b2-a47bfb22c2db"), "Руководство дипломными проектами за предыдущий учебный год", true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("956f28e3-1487-43c1-9091-d44578228d68"), new Guid("6289ecdb-8251-410b-a528-d67f5fea0ada"), null, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("96af9982-f3dc-4318-a3b7-fe00ec7faf9a"), new Guid("6289ecdb-8251-410b-a528-d67f5fea0ada"), null, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("a5aed116-4253-4cff-911f-78e544e2c55c"), new Guid("74bb175f-d2ea-4307-9d0b-17b6c55317be"), null, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("ab37ce68-6c88-4739-a22d-9648ff3ccdd3"), new Guid("74bb175f-d2ea-4307-9d0b-17b6c55317be"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("bc74df33-87c9-4b84-802f-5b42b0f11b39"), new Guid("b0777302-a4fb-4367-b7ae-eacd8bed54f1"), null, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("bc83e844-728d-499e-b2d1-82d4f1ee43ad"), new Guid("87e8b2ed-b2f7-40b4-82b2-a47bfb22c2db"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("c1e83612-1c88-47b4-bddd-5e3eb7a654fb"), new Guid("6289ecdb-8251-410b-a528-d67f5fea0ada"), null, true, "Должность", 9, "Введите свою должность в организации", new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("c31c864e-ddae-430a-8a0b-44a870413bd0"), new Guid("6289ecdb-8251-410b-a528-d67f5fea0ada"), null, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("c4f39e5e-c78e-49a3-a6f8-2b68ff14221f"), new Guid("b0777302-a4fb-4367-b7ae-eacd8bed54f1"), null, true, "Название конкурсной работы", 12, "Введите название своей конкурсной работы", new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("cab3f7f6-bca9-4fa2-954b-b9679ac8e13c"), new Guid("b0777302-a4fb-4367-b7ae-eacd8bed54f1"), null, true, "Ссылка на конкурсную работу", 13, "Введите ссылку своей конкурсной работы", new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("d90f5912-f467-4c2d-ac4e-4d79552661f5"), new Guid("b0777302-a4fb-4367-b7ae-eacd8bed54f1"), null, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("ea10b698-efef-4ca0-9d86-bccc2665bd22"), new Guid("b0777302-a4fb-4367-b7ae-eacd8bed54f1"), null, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("f331b55c-7502-454f-810b-434a571fd742"), new Guid("6289ecdb-8251-410b-a528-d67f5fea0ada"), null, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0487eeef-3104-4191-b46a-98a02274014e"), new Guid("474fa6e1-6b0c-4f7b-97bc-b669ce227b55") },
                    { new Guid("0ba26cef-bc3a-46bd-a42c-225a7f56e2c9"), new Guid("1f16b883-2b2f-4668-8c27-c4de7f9ad74f") },
                    { new Guid("0ba26cef-bc3a-46bd-a42c-225a7f56e2c9"), new Guid("474fa6e1-6b0c-4f7b-97bc-b669ce227b55") },
                    { new Guid("12afaacd-ad1f-4fc4-b30f-a312b7259bb6"), new Guid("474fa6e1-6b0c-4f7b-97bc-b669ce227b55") },
                    { new Guid("387d9f7d-3a39-41a8-9f07-7c300520d085"), new Guid("1f16b883-2b2f-4668-8c27-c4de7f9ad74f") },
                    { new Guid("4ca1764a-81e2-4103-8502-f87602af0a29"), new Guid("474fa6e1-6b0c-4f7b-97bc-b669ce227b55") },
                    { new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855"), new Guid("1f16b883-2b2f-4668-8c27-c4de7f9ad74f") },
                    { new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb"), new Guid("1f16b883-2b2f-4668-8c27-c4de7f9ad74f") },
                    { new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb"), new Guid("474fa6e1-6b0c-4f7b-97bc-b669ce227b55") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("101f2e8b-e4a5-4c69-8b3a-cd747eb88e47"), new Guid("31656f54-967e-4b97-844f-e338d6cd2e37"), false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("3a4a12b8-58c6-4d7f-aff4-8a89283df763"), new Guid("74bb175f-d2ea-4307-9d0b-17b6c55317be"), false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("4e8866f2-28af-47d0-b2ba-1c201c133dbc"), new Guid("87e8b2ed-b2f7-40b4-82b2-a47bfb22c2db"), false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("5eb57df2-6626-434f-8f0e-29c801633173"), new Guid("87e8b2ed-b2f7-40b4-82b2-a47bfb22c2db"), false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("7e95e1c3-953b-4644-b945-aaa391860783"), new Guid("87e8b2ed-b2f7-40b4-82b2-a47bfb22c2db"), false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("9f3bd229-59e9-4552-8b35-edb92ad129db"), new Guid("31656f54-967e-4b97-844f-e338d6cd2e37"), false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("ab46db0b-1757-4b03-9754-55757a2ea1fd"), new Guid("74bb175f-d2ea-4307-9d0b-17b6c55317be"), false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("b4659bd8-8cab-4c5e-9267-d34b5c8aad38"), new Guid("74bb175f-d2ea-4307-9d0b-17b6c55317be"), true, "Персональные идентификаторы", 10 },
                    { new Guid("bb1eb9fc-4629-493e-b98c-204a7e6b16e9"), new Guid("74bb175f-d2ea-4307-9d0b-17b6c55317be"), false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("bdee68a4-c3a0-43eb-8a5f-d65f1baeef22"), new Guid("87e8b2ed-b2f7-40b4-82b2-a47bfb22c2db"), false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("d0175fd9-c96f-4984-bfc5-9530caf4e910"), new Guid("74bb175f-d2ea-4307-9d0b-17b6c55317be"), false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("dcf45ceb-fb36-440a-a3cf-3017a273b8d1"), new Guid("87e8b2ed-b2f7-40b4-82b2-a47bfb22c2db"), false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("ffa90a23-1ba0-42f9-b068-1f0e8b61f7f7"), new Guid("87e8b2ed-b2f7-40b4-82b2-a47bfb22c2db"), false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("006c9849-eeb4-40d0-a0fa-067ccdf0fbfc"), true, "Практические занятия (час.)", 4, new Guid("7e95e1c3-953b-4644-b945-aaa391860783"), new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("00e15960-7eba-4a1a-8056-971a85371bb2"), false, "Соавторы", 3, new Guid("bdee68a4-c3a0-43eb-8a5f-d65f1baeef22"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("01507286-30f0-458f-b1d1-20d1dd6fa388"), true, "Название курса", 1, new Guid("dcf45ceb-fb36-440a-a3cf-3017a273b8d1"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("048957c7-de46-4e8a-9cb7-6ed3dae9f740"), true, "Название организации в которую внедрена разработка", 3, new Guid("3a4a12b8-58c6-4d7f-aff4-8a89283df763"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("0492b6d7-2d18-47bc-b82d-fb86673ff6b0"), true, "Название организации/должность/ставка", 1, new Guid("ffa90a23-1ba0-42f9-b068-1f0e8b61f7f7"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("070fe5d5-48a9-41d9-b9c3-40f553562ff3"), true, "Вид", 1, new Guid("3a4a12b8-58c6-4d7f-aff4-8a89283df763"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("0749a794-2e82-4aa9-a901-c09e55e08351"), true, "Вид", 1, new Guid("bb1eb9fc-4629-493e-b98c-204a7e6b16e9"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("14399098-c9e3-459b-a19a-a2b3206cae36"), true, "Год", 1, new Guid("9f3bd229-59e9-4552-8b35-edb92ad129db"), new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("143bb287-d767-4d8e-8168-622d26ab1182"), true, "Количество печатных листов", 4, new Guid("bdee68a4-c3a0-43eb-8a5f-d65f1baeef22"), new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("1b2c56d4-0036-4368-b188-54130b403f7e"), true, "Год получения документа", 2, new Guid("101f2e8b-e4a5-4c69-8b3a-cd747eb88e47"), new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("1e64f7eb-c676-4911-a466-e9e791456e7a"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("ffa90a23-1ba0-42f9-b068-1f0e8b61f7f7"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("24f1f674-7f91-456b-8b82-e11b2bfdaa51"), true, "Издание, год", 4, new Guid("d0175fd9-c96f-4984-bfc5-9530caf4e910"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("38ba8eee-7b39-4411-84da-2beb4310ccab"), true, "Язык публикации", 7, new Guid("bdee68a4-c3a0-43eb-8a5f-d65f1baeef22"), new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("3c5c00c7-db27-4ef1-b68a-05f791cbc60e"), true, "Номер РИД", 4, new Guid("bb1eb9fc-4629-493e-b98c-204a7e6b16e9"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("437094bd-f1a5-4a73-a5f4-591c2508076b"), true, "Название конкурса", 2, new Guid("9f3bd229-59e9-4552-8b35-edb92ad129db"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("484e3ff1-0f74-4df1-9f7b-0c78a1bc6183"), true, "Статус (руководитель/исполнитель)", 4, new Guid("ab46db0b-1757-4b03-9754-55757a2ea1fd"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("519ca72a-1d91-4267-8e6f-941c43c353a8"), true, "Вид (лекции, лабораторные)", 2, new Guid("4e8866f2-28af-47d0-b2ba-1c201c133dbc"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("56d93969-642c-4d7a-88f1-d43852bb8b08"), true, "Издательство, год", 6, new Guid("bdee68a4-c3a0-43eb-8a5f-d65f1baeef22"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("5c3df951-572a-4bc9-aa5f-5a3d3784844e"), true, "Название", 2, new Guid("bdee68a4-c3a0-43eb-8a5f-d65f1baeef22"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("646a6251-c770-4cfa-97f2-19ee0764b01f"), true, "Название НИР/НИОКР", 1, new Guid("ab46db0b-1757-4b03-9754-55757a2ea1fd"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("67db44f5-a71f-4395-83e5-4227501e4e6b"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("ab46db0b-1757-4b03-9754-55757a2ea1fd"), new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("6a0b4e24-7c0f-476c-9ffb-b80ac1eeba05"), true, "ФИО", 1, new Guid("5eb57df2-6626-434f-8f0e-29c801633173"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("6e8fd8ea-ceb2-4276-90bf-cc15afbd6818"), true, "Соавторы", 2, new Guid("dcf45ceb-fb36-440a-a3cf-3017a273b8d1"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("7255c67b-7b15-4392-9364-371fe47ad80e"), true, "Итого (час.)", 5, new Guid("7e95e1c3-953b-4644-b945-aaa391860783"), new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("7aceedff-71fa-4b38-b508-e97b43e77dca"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("5eb57df2-6626-434f-8f0e-29c801633173"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("7e0f160a-7784-46fd-9426-0aa42164af9f"), true, "Вид публикации", 1, new Guid("bdee68a4-c3a0-43eb-8a5f-d65f1baeef22"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("888669ae-d92e-4222-88cc-f6c08502e5f7"), false, "Идентификатор", 2, new Guid("b4659bd8-8cab-4c5e-9267-d34b5c8aad38"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("90628f58-d1e9-487e-aa18-1decb3c6321f"), true, "Период выполнения", 3, new Guid("ab46db0b-1757-4b03-9754-55757a2ea1fd"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("923bf2b0-b24f-45ac-b38f-f2113718fef9"), true, "Название статьи", 1, new Guid("d0175fd9-c96f-4984-bfc5-9530caf4e910"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("94b0764b-5fa8-4b15-958a-d068e4b5a829"), true, "Наличие грифа", 5, new Guid("bdee68a4-c3a0-43eb-8a5f-d65f1baeef22"), new Guid("53afa585-7e73-4d8b-bf27-ad9d2f905ae8") },
                    { new Guid("96b0fd53-6fb3-4b29-af04-be57de61947a"), true, "Количество часов", 4, new Guid("ffa90a23-1ba0-42f9-b068-1f0e8b61f7f7"), new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("970eef25-8ad9-4a96-a3ee-a28884656ae8"), true, "Наименование курса", 1, new Guid("7e95e1c3-953b-4644-b945-aaa391860783"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("99d501bc-c9bb-494c-a846-1942b8e13974"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("ab46db0b-1757-4b03-9754-55757a2ea1fd"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("9b9185d9-77cb-4973-b729-32c421c25f42"), true, "Ссылка на открытый доступ", 8, new Guid("bdee68a4-c3a0-43eb-8a5f-d65f1baeef22"), new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("9e0ba3b7-2ccf-46ac-bb47-127ef385fca2"), true, "Статус конкурса", 3, new Guid("9f3bd229-59e9-4552-8b35-edb92ad129db"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("a720623e-cd0d-483c-a8f5-d0df98b38f89"), false, "Тип идентификатора", 1, new Guid("b4659bd8-8cab-4c5e-9267-d34b5c8aad38"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("aa8ecfda-ed09-40e0-98c0-78ccc1c2f51c"), true, "Название", 2, new Guid("bb1eb9fc-4629-493e-b98c-204a7e6b16e9"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("b103a367-1ffa-47ad-bfe6-c30ee2ea1074"), true, "Соавторы", 2, new Guid("d0175fd9-c96f-4984-bfc5-9530caf4e910"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("b194ff71-16da-4ceb-a33a-dd6e013a56f9"), true, "Название документа, реквизиты", 1, new Guid("101f2e8b-e4a5-4c69-8b3a-cd747eb88e47"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("b7cd1b27-43b9-465e-8ac5-eb3c32956ca6"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("5eb57df2-6626-434f-8f0e-29c801633173"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("bac8bf87-cc20-4324-b09c-32babc031d64"), true, "Название разработки", 2, new Guid("3a4a12b8-58c6-4d7f-aff4-8a89283df763"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("bda94ef8-ccf4-4e93-a71b-bc5848d90c19"), true, "Ссылка", 5, new Guid("9f3bd229-59e9-4552-8b35-edb92ad129db"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("c118051b-0f01-4af8-97dd-d2c609e20538"), true, "Год", 3, new Guid("5eb57df2-6626-434f-8f0e-29c801633173"), new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("c2876fd8-76db-45b5-bdb7-35c7fc5cf22c"), true, "Название дисциплины", 1, new Guid("4e8866f2-28af-47d0-b2ba-1c201c133dbc"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("c64e328d-0826-4885-8a6b-7a69653af9e0"), true, "Лекции (час.)", 3, new Guid("7e95e1c3-953b-4644-b945-aaa391860783"), new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("d0b5fd01-308c-42d9-9fde-97632e44d7d7"), true, "ФИО соавторов", 3, new Guid("bb1eb9fc-4629-493e-b98c-204a7e6b16e9"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("d5a287a8-b67f-44f6-971c-6aad3c5f4275"), true, "Название конкурса/премии", 2, new Guid("5eb57df2-6626-434f-8f0e-29c801633173"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("d5d618b4-2e3a-437d-bb59-421266bca11d"), true, "Год", 4, new Guid("dcf45ceb-fb36-440a-a3cf-3017a273b8d1"), new Guid("6e4bdf88-b9ac-49d8-b182-d96edc0bf37e") },
                    { new Guid("d7eff4b9-f61d-4a51-a152-61ded6b1496a"), true, "Ссылка на платформу", 3, new Guid("dcf45ceb-fb36-440a-a3cf-3017a273b8d1"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("e05d9fec-9d56-424f-a1b7-9c5ebf72fc98"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("4e8866f2-28af-47d0-b2ba-1c201c133dbc"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("e0e29023-3db4-4dd6-863d-6b522843b3c7"), true, "Награда", 4, new Guid("9f3bd229-59e9-4552-8b35-edb92ad129db"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("e901eee2-1439-4ec7-bea7-b7c3bf9a80f3"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("7e95e1c3-953b-4644-b945-aaa391860783"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("ec5cd6cc-8093-4e44-929c-4ddd35c92ce0"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("d0175fd9-c96f-4984-bfc5-9530caf4e910"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") },
                    { new Guid("f377c5ca-6443-45a0-8bae-700b30ec2a6d"), true, "Вид деятельности (преподавательская)", 3, new Guid("ffa90a23-1ba0-42f9-b068-1f0e8b61f7f7"), new Guid("82d80f40-40d8-4047-881b-7ff75d0c1737") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("23dea0f3-06b7-4eca-83c2-848db0273ccf"), new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb") },
                    { new Guid("3b6f10ca-cc78-4d49-aeb4-81129680ba6c"), new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb") },
                    { new Guid("41b09f99-2195-4322-8864-bd6b94211330"), new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb") },
                    { new Guid("56f42679-849e-4516-b5ee-47ef2fcd6eee"), new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb") },
                    { new Guid("6161dc90-8acb-4ffb-b9ef-a0b20137cd1c"), new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb") },
                    { new Guid("8eae9c5f-ee8d-47bb-95cc-9c58c325a1b7"), new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb") },
                    { new Guid("91001e70-e4ae-4dae-b6d2-cdcd092b9eca"), new Guid("4ca1764a-81e2-4103-8502-f87602af0a29") },
                    { new Guid("9115911e-1da6-465e-b927-212c33082e6e"), new Guid("4ca1764a-81e2-4103-8502-f87602af0a29") },
                    { new Guid("956f28e3-1487-43c1-9091-d44578228d68"), new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb") },
                    { new Guid("96af9982-f3dc-4318-a3b7-fe00ec7faf9a"), new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb") },
                    { new Guid("a5aed116-4253-4cff-911f-78e544e2c55c"), new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855") },
                    { new Guid("ab37ce68-6c88-4739-a22d-9648ff3ccdd3"), new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855") },
                    { new Guid("bc74df33-87c9-4b84-802f-5b42b0f11b39"), new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb") },
                    { new Guid("bc83e844-728d-499e-b2d1-82d4f1ee43ad"), new Guid("4ca1764a-81e2-4103-8502-f87602af0a29") },
                    { new Guid("c1e83612-1c88-47b4-bddd-5e3eb7a654fb"), new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb") },
                    { new Guid("c31c864e-ddae-430a-8a0b-44a870413bd0"), new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb") },
                    { new Guid("c4f39e5e-c78e-49a3-a6f8-2b68ff14221f"), new Guid("0ba26cef-bc3a-46bd-a42c-225a7f56e2c9") },
                    { new Guid("cab3f7f6-bca9-4fa2-954b-b9679ac8e13c"), new Guid("0ba26cef-bc3a-46bd-a42c-225a7f56e2c9") },
                    { new Guid("d90f5912-f467-4c2d-ac4e-4d79552661f5"), new Guid("0487eeef-3104-4191-b46a-98a02274014e") },
                    { new Guid("d90f5912-f467-4c2d-ac4e-4d79552661f5"), new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855") },
                    { new Guid("d90f5912-f467-4c2d-ac4e-4d79552661f5"), new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb") },
                    { new Guid("ea10b698-efef-4ca0-9d86-bccc2665bd22"), new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb") },
                    { new Guid("f331b55c-7502-454f-810b-434a571fd742"), new Guid("50c12c99-adfb-436f-b6aa-5e7e8fc3a7cb") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("0487eeef-3104-4191-b46a-98a02274014e"), new Guid("101f2e8b-e4a5-4c69-8b3a-cd747eb88e47") },
                    { new Guid("0487eeef-3104-4191-b46a-98a02274014e"), new Guid("9f3bd229-59e9-4552-8b35-edb92ad129db") },
                    { new Guid("12afaacd-ad1f-4fc4-b30f-a312b7259bb6"), new Guid("4e8866f2-28af-47d0-b2ba-1c201c133dbc") },
                    { new Guid("12afaacd-ad1f-4fc4-b30f-a312b7259bb6"), new Guid("bdee68a4-c3a0-43eb-8a5f-d65f1baeef22") },
                    { new Guid("387d9f7d-3a39-41a8-9f07-7c300520d085"), new Guid("101f2e8b-e4a5-4c69-8b3a-cd747eb88e47") },
                    { new Guid("387d9f7d-3a39-41a8-9f07-7c300520d085"), new Guid("3a4a12b8-58c6-4d7f-aff4-8a89283df763") },
                    { new Guid("387d9f7d-3a39-41a8-9f07-7c300520d085"), new Guid("bb1eb9fc-4629-493e-b98c-204a7e6b16e9") },
                    { new Guid("4ca1764a-81e2-4103-8502-f87602af0a29"), new Guid("5eb57df2-6626-434f-8f0e-29c801633173") },
                    { new Guid("4ca1764a-81e2-4103-8502-f87602af0a29"), new Guid("7e95e1c3-953b-4644-b945-aaa391860783") },
                    { new Guid("4ca1764a-81e2-4103-8502-f87602af0a29"), new Guid("dcf45ceb-fb36-440a-a3cf-3017a273b8d1") },
                    { new Guid("4ca1764a-81e2-4103-8502-f87602af0a29"), new Guid("ffa90a23-1ba0-42f9-b068-1f0e8b61f7f7") },
                    { new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855"), new Guid("9f3bd229-59e9-4552-8b35-edb92ad129db") },
                    { new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855"), new Guid("ab46db0b-1757-4b03-9754-55757a2ea1fd") },
                    { new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855"), new Guid("d0175fd9-c96f-4984-bfc5-9530caf4e910") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("082d6711-5c41-4fe9-972c-fe82618bbcdb"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("bdee68a4-c3a0-43eb-8a5f-d65f1baeef22") },
                    { new Guid("0b168258-ba11-4f45-815c-747c844ac9a7"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("bb1eb9fc-4629-493e-b98c-204a7e6b16e9") },
                    { new Guid("18f03a99-603c-4077-8736-8adfe1a857be"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("7e95e1c3-953b-4644-b945-aaa391860783") },
                    { new Guid("1916cf06-6775-4dbf-9abe-3333d18e917c"), "EvaluateMark19", new Guid("ab37ce68-6c88-4739-a22d-9648ff3ccdd3"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("1b9a0a7f-d899-4501-a20b-8cd73a8abfba"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("101f2e8b-e4a5-4c69-8b3a-cd747eb88e47") },
                    { new Guid("1dd3bfe6-7e4d-41cf-bf95-7bfbb5326e1d"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("bdee68a4-c3a0-43eb-8a5f-d65f1baeef22") },
                    { new Guid("28d49975-ab4f-405d-992c-156bd36c8e90"), null, new Guid("cab3f7f6-bca9-4fa2-954b-b9679ac8e13c"), false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null },
                    { new Guid("2eb2027c-4115-438e-9562-436e961a92aa"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("dcf45ceb-fb36-440a-a3cf-3017a273b8d1") },
                    { new Guid("40e045b6-3d01-4547-96b0-bbbf6cfb6e18"), "EvaluateMark4", new Guid("bc83e844-728d-499e-b2d1-82d4f1ee43ad"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("41fa3a0a-0e1f-48e6-a452-d81736af7d68"), "EvaluateMark13", new Guid("d90f5912-f467-4c2d-ac4e-4d79552661f5"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("507a8d64-3c96-4888-a504-59e669faa2f1"), "EvaluateMark5", new Guid("91001e70-e4ae-4dae-b6d2-cdcd092b9eca"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("56f922c3-a3b6-4e4e-a71a-258ff4bf6ba7"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("ab46db0b-1757-4b03-9754-55757a2ea1fd") },
                    { new Guid("61a90278-076d-468f-a86b-d8e3d96b0c24"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("7e95e1c3-953b-4644-b945-aaa391860783") },
                    { new Guid("6f357ff6-0e61-4e60-b236-4e998684f482"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("4e8866f2-28af-47d0-b2ba-1c201c133dbc") },
                    { new Guid("73ca166b-d4fa-4d86-93bd-f07494c91e71"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("bdee68a4-c3a0-43eb-8a5f-d65f1baeef22") },
                    { new Guid("800e464c-d13c-4652-be28-1e675dd972ab"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("d0175fd9-c96f-4984-bfc5-9530caf4e910") },
                    { new Guid("9d5cdf28-345a-454f-81ee-5f04a1f2cfb1"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("bdee68a4-c3a0-43eb-8a5f-d65f1baeef22") },
                    { new Guid("b6318c71-ebd7-4773-bf93-be3eaf0a1c17"), "EvaluateMark3", new Guid("9115911e-1da6-465e-b927-212c33082e6e"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("b81378c8-c485-4c56-bf1e-9a440eb367b4"), null, new Guid("cab3f7f6-bca9-4fa2-954b-b9679ac8e13c"), false, 10, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("c421ddc2-b170-43f7-8bc6-e2c0e86e9acf"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("ab46db0b-1757-4b03-9754-55757a2ea1fd") },
                    { new Guid("cf4c6072-3551-4c92-9447-2cf1ca9f5231"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("9f3bd229-59e9-4552-8b35-edb92ad129db") },
                    { new Guid("d8a4ffb3-9027-4dce-a1e6-d84b1d764999"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("5eb57df2-6626-434f-8f0e-29c801633173") },
                    { new Guid("e14092a2-1986-4dc9-adad-1a9134ad78f9"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("3a4a12b8-58c6-4d7f-aff4-8a89283df763") },
                    { new Guid("e43bbfef-71c3-417f-852e-87c2b712f672"), "EvaluateMark20", new Guid("a5aed116-4253-4cff-911f-78e544e2c55c"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("53214603-7cff-4cec-a12d-909a2102d243"), true, new Guid("b4659bd8-8cab-4c5e-9267-d34b5c8aad38") },
                    { new Guid("5d15d4a2-9a9f-4908-8cc1-c3e1d8f2996d"), true, new Guid("b4659bd8-8cab-4c5e-9267-d34b5c8aad38") },
                    { new Guid("6d69e636-4db5-41b9-9cbe-ca2769279a6a"), true, new Guid("b4659bd8-8cab-4c5e-9267-d34b5c8aad38") },
                    { new Guid("9ed6adb2-1916-42be-86ac-261562f2602a"), true, new Guid("b4659bd8-8cab-4c5e-9267-d34b5c8aad38") },
                    { new Guid("ac0cb7b0-3977-436f-acff-76d46a175c51"), true, new Guid("b4659bd8-8cab-4c5e-9267-d34b5c8aad38") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("07b1ce99-27aa-430b-bde2-a9317db92854"), null, new Guid("d90f5912-f467-4c2d-ac4e-4d79552661f5"), "Нет" },
                    { new Guid("483c7931-167b-4a87-b9b8-748a8c40d019"), null, new Guid("bc74df33-87c9-4b84-802f-5b42b0f11b39"), "Имеющие ученую степень доктора наук" },
                    { new Guid("6a914e7a-725f-4349-b01b-d8e3c77868c4"), null, new Guid("d90f5912-f467-4c2d-ac4e-4d79552661f5"), "Доцент" },
                    { new Guid("c16a3a9a-a953-4000-83fb-af4386570760"), null, new Guid("d90f5912-f467-4c2d-ac4e-4d79552661f5"), "Профессор" },
                    { new Guid("d77711c5-2e1f-4b70-908a-d1b5f7e2445c"), null, new Guid("bc74df33-87c9-4b84-802f-5b42b0f11b39"), "Докторанты, имеющие ученую степень кандидата наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("04168f32-0a07-4c1f-bd01-a7e5a3fe3062"), null, new Guid("888669ae-d92e-4222-88cc-f6c08502e5f7"), false, true, new Guid("6d69e636-4db5-41b9-9cbe-ca2769279a6a"), null },
                    { new Guid("15370c6d-047a-4121-88f0-8b0bf8b7827e"), null, new Guid("a720623e-cd0d-483c-a8f5-d0df98b38f89"), true, true, new Guid("ac0cb7b0-3977-436f-acff-76d46a175c51"), "ORCiD" },
                    { new Guid("43986a4f-691e-4fc8-9004-e312543182ae"), null, new Guid("a720623e-cd0d-483c-a8f5-d0df98b38f89"), true, true, new Guid("6d69e636-4db5-41b9-9cbe-ca2769279a6a"), "ScopusID" },
                    { new Guid("46d032d4-0756-4b30-b76b-50588b18623c"), null, new Guid("888669ae-d92e-4222-88cc-f6c08502e5f7"), false, true, new Guid("ac0cb7b0-3977-436f-acff-76d46a175c51"), null },
                    { new Guid("4d9cc115-d618-4036-9841-a86a21c030c0"), null, new Guid("888669ae-d92e-4222-88cc-f6c08502e5f7"), false, true, new Guid("53214603-7cff-4cec-a12d-909a2102d243"), null },
                    { new Guid("56a291b7-1d7c-4d22-834e-e444e007e312"), null, new Guid("a720623e-cd0d-483c-a8f5-d0df98b38f89"), true, true, new Guid("9ed6adb2-1916-42be-86ac-261562f2602a"), "Google Scholar ID" },
                    { new Guid("57adedf4-1a79-44a5-9d72-a2f3443bc99e"), null, new Guid("888669ae-d92e-4222-88cc-f6c08502e5f7"), false, true, new Guid("9ed6adb2-1916-42be-86ac-261562f2602a"), null },
                    { new Guid("829ae04d-b2cc-4a26-b42a-8c3794dac3ac"), null, new Guid("a720623e-cd0d-483c-a8f5-d0df98b38f89"), true, true, new Guid("53214603-7cff-4cec-a12d-909a2102d243"), "ResearcherID" },
                    { new Guid("a0f82535-024b-49f8-a39c-beb711054b9c"), null, new Guid("888669ae-d92e-4222-88cc-f6c08502e5f7"), false, true, new Guid("5d15d4a2-9a9f-4908-8cc1-c3e1d8f2996d"), null },
                    { new Guid("c99bef62-d2fa-47b8-be93-a2c402bd41a6"), null, new Guid("a720623e-cd0d-483c-a8f5-d0df98b38f89"), true, true, new Guid("5d15d4a2-9a9f-4908-8cc1-c3e1d8f2996d"), "РИНЦ AuthorID" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("0487eeef-3104-4191-b46a-98a02274014e"), new Guid("1b9a0a7f-d899-4501-a20b-8cd73a8abfba") },
                    { new Guid("0487eeef-3104-4191-b46a-98a02274014e"), new Guid("41fa3a0a-0e1f-48e6-a452-d81736af7d68") },
                    { new Guid("0487eeef-3104-4191-b46a-98a02274014e"), new Guid("cf4c6072-3551-4c92-9447-2cf1ca9f5231") },
                    { new Guid("0ba26cef-bc3a-46bd-a42c-225a7f56e2c9"), new Guid("28d49975-ab4f-405d-992c-156bd36c8e90") },
                    { new Guid("0ba26cef-bc3a-46bd-a42c-225a7f56e2c9"), new Guid("b81378c8-c485-4c56-bf1e-9a440eb367b4") },
                    { new Guid("12afaacd-ad1f-4fc4-b30f-a312b7259bb6"), new Guid("082d6711-5c41-4fe9-972c-fe82618bbcdb") },
                    { new Guid("12afaacd-ad1f-4fc4-b30f-a312b7259bb6"), new Guid("1dd3bfe6-7e4d-41cf-bf95-7bfbb5326e1d") },
                    { new Guid("12afaacd-ad1f-4fc4-b30f-a312b7259bb6"), new Guid("6f357ff6-0e61-4e60-b236-4e998684f482") },
                    { new Guid("12afaacd-ad1f-4fc4-b30f-a312b7259bb6"), new Guid("73ca166b-d4fa-4d86-93bd-f07494c91e71") },
                    { new Guid("12afaacd-ad1f-4fc4-b30f-a312b7259bb6"), new Guid("9d5cdf28-345a-454f-81ee-5f04a1f2cfb1") },
                    { new Guid("387d9f7d-3a39-41a8-9f07-7c300520d085"), new Guid("0b168258-ba11-4f45-815c-747c844ac9a7") },
                    { new Guid("387d9f7d-3a39-41a8-9f07-7c300520d085"), new Guid("1b9a0a7f-d899-4501-a20b-8cd73a8abfba") },
                    { new Guid("387d9f7d-3a39-41a8-9f07-7c300520d085"), new Guid("e14092a2-1986-4dc9-adad-1a9134ad78f9") },
                    { new Guid("4ca1764a-81e2-4103-8502-f87602af0a29"), new Guid("18f03a99-603c-4077-8736-8adfe1a857be") },
                    { new Guid("4ca1764a-81e2-4103-8502-f87602af0a29"), new Guid("2eb2027c-4115-438e-9562-436e961a92aa") },
                    { new Guid("4ca1764a-81e2-4103-8502-f87602af0a29"), new Guid("40e045b6-3d01-4547-96b0-bbbf6cfb6e18") },
                    { new Guid("4ca1764a-81e2-4103-8502-f87602af0a29"), new Guid("507a8d64-3c96-4888-a504-59e669faa2f1") },
                    { new Guid("4ca1764a-81e2-4103-8502-f87602af0a29"), new Guid("61a90278-076d-468f-a86b-d8e3d96b0c24") },
                    { new Guid("4ca1764a-81e2-4103-8502-f87602af0a29"), new Guid("b6318c71-ebd7-4773-bf93-be3eaf0a1c17") },
                    { new Guid("4ca1764a-81e2-4103-8502-f87602af0a29"), new Guid("d8a4ffb3-9027-4dce-a1e6-d84b1d764999") },
                    { new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855"), new Guid("1916cf06-6775-4dbf-9abe-3333d18e917c") },
                    { new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855"), new Guid("41fa3a0a-0e1f-48e6-a452-d81736af7d68") },
                    { new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855"), new Guid("56f922c3-a3b6-4e4e-a71a-258ff4bf6ba7") },
                    { new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855"), new Guid("800e464c-d13c-4652-be28-1e675dd972ab") },
                    { new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855"), new Guid("c421ddc2-b170-43f7-8bc6-e2c0e86e9acf") },
                    { new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855"), new Guid("cf4c6072-3551-4c92-9447-2cf1ca9f5231") },
                    { new Guid("4fb1aca2-921e-4e55-a2e4-5bdcbd908855"), new Guid("e43bbfef-71c3-417f-852e-87c2b712f672") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("07386a78-3d5b-4cce-b0f3-3e147bc8a9e2"), new Guid("0749a794-2e82-4aa9-a901-c09e55e08351"), null, "Полезная модель" },
                    { new Guid("09b971e6-a78d-44cb-abdf-840aadae4dcf"), new Guid("0749a794-2e82-4aa9-a901-c09e55e08351"), null, "Изобретение" },
                    { new Guid("1732d22b-9661-4e09-af6d-941b5aa60c26"), new Guid("9e0ba3b7-2ccf-46ac-bb47-127ef385fca2"), null, "Всероссийский" },
                    { new Guid("29b696b6-c013-4662-92b9-97441cf3e22b"), new Guid("484e3ff1-0f74-4df1-9f7b-0c78a1bc6183"), null, "Руководитель" },
                    { new Guid("2c0efa94-a9ea-4c53-bc55-789f6118d55e"), new Guid("7e0f160a-7784-46fd-9426-0aa42164af9f"), null, "Монография" },
                    { new Guid("2cd757ff-bbbe-481f-adef-ea4307120b80"), new Guid("38ba8eee-7b39-4411-84da-2beb4310ccab"), null, "Иностранный" },
                    { new Guid("30fc5eb5-da4d-44db-94fe-d90a2e718643"), new Guid("7e0f160a-7784-46fd-9426-0aa42164af9f"), null, "Учебник" },
                    { new Guid("766d9cf3-b5e3-45b3-9c31-083186e8eacb"), new Guid("070fe5d5-48a9-41d9-b9c3-40f553562ff3"), null, "Изобретение" },
                    { new Guid("79f473f8-6418-4cd4-8ab9-65d774305377"), new Guid("00e15960-7eba-4a1a-8056-971a85371bb2"), null, "Нет" },
                    { new Guid("81b1848a-8f33-44bd-a055-4e3db394d18f"), new Guid("9e0ba3b7-2ccf-46ac-bb47-127ef385fca2"), null, "Региональный" },
                    { new Guid("858ec46f-9b7a-4080-8cbb-800d8590cb26"), new Guid("070fe5d5-48a9-41d9-b9c3-40f553562ff3"), null, "Полезная модель" },
                    { new Guid("8d532dba-b5cf-4879-a6ad-dcc2b91acdc5"), new Guid("519ca72a-1d91-4267-8e6f-941c43c353a8"), null, "Лекции" },
                    { new Guid("928ac75f-00f2-4e70-a7b8-0c9e6c5a2a87"), new Guid("9e0ba3b7-2ccf-46ac-bb47-127ef385fca2"), null, "Международный" },
                    { new Guid("b5896a0d-5cd6-40bb-94e7-3a369e65481b"), new Guid("7e0f160a-7784-46fd-9426-0aa42164af9f"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("bc2e6750-c3f2-4033-b3cf-2154fcdd8f69"), new Guid("519ca72a-1d91-4267-8e6f-941c43c353a8"), null, "Лабораторные" },
                    { new Guid("be719e6c-da07-463d-a864-c831d327cd97"), new Guid("00e15960-7eba-4a1a-8056-971a85371bb2"), null, "Да" },
                    { new Guid("cb70b697-f6a2-4ef1-a784-07f97326c027"), new Guid("484e3ff1-0f74-4df1-9f7b-0c78a1bc6183"), null, "Исполнитель" },
                    { new Guid("cd7a4671-b678-4c67-a0a1-03d9770030eb"), new Guid("38ba8eee-7b39-4411-84da-2beb4310ccab"), null, "Русский" },
                    { new Guid("cfd68f64-0629-4629-9cbe-94d6ae49bb1e"), new Guid("0749a794-2e82-4aa9-a901-c09e55e08351"), null, "База данных" },
                    { new Guid("f7b767f2-b965-4822-9ebf-e68941b1aae0"), new Guid("070fe5d5-48a9-41d9-b9c3-40f553562ff3"), null, "База данных" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Votes_ApplicationFormId",
                table: "Votes",
                column: "ApplicationFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Votes_VoterId",
                table: "Votes",
                column: "VoterId");
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
                name: "Votes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Rows");

            migrationBuilder.DropTable(
                name: "MarkBlocks");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Columns");

            migrationBuilder.DropTable(
                name: "ApplicationForms");

            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "ApplicationStatuses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "ValueTypes");

            migrationBuilder.DropTable(
                name: "EditBlocks");
        }
    }
}
