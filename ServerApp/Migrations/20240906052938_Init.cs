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
                    IsDisplayedOnVotingPage = table.Column<bool>(type: "INTEGER", nullable: false),
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
                    IsDisplayedOnVotingPage = table.Column<bool>(type: "INTEGER", nullable: false),
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
                    { new Guid("1529a422-7f01-4279-9fe5-e3f86bd12ab6"), 1, "В ожидании заполнения" },
                    { new Guid("479ce919-a385-4a15-968f-5202c991ed00"), 6, "Оценена" },
                    { new Guid("50d27cea-b450-4040-9929-5b64908cd92a"), 3, "В процессе рассмотрения" },
                    { new Guid("52459e0d-9251-408f-992f-dba24f98659f"), 5, "Отклонена" },
                    { new Guid("67333527-b026-4f90-b2ff-f87d3cbc74d3"), 2, "В ожидании рассмотрения" },
                    { new Guid("691d72ff-db3c-4049-ba9e-e2f709ebb1d7"), 4, "Одобрена" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e3c4475-60b3-4626-a968-e2c44cc6fe03", null, "Expert", "EXPERT" },
                    { "1d6eb925-7d6c-47d4-969a-8e0cb46b0553", null, "Voter", "VOTER" },
                    { "4e17b5e0-06d3-45de-8430-707f1c6fef52", null, "Organiser", "ORGANISER" },
                    { "8b47843e-3183-46d7-8a08-bea1326ab6d6", null, "Participant", "PARTICIPANT" },
                    { "c549f981-2dd2-42c4-a09f-3b5393e2f051", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("386ca438-ba7e-46cb-8716-0627d0085177"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("740f986c-6096-4d1d-ab1e-9f99bb5405c2"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("37e09e2b-fbee-4c56-b1bc-c32bc4ac26c8"), "Деятельность", 4 },
                    { new Guid("429eec46-34d6-42e8-9e8e-af538d0539ca"), "Общая информация", 1 },
                    { new Guid("62537414-e226-4d60-9cda-3ed883a073fc"), "Категория участников", 2 },
                    { new Guid("8596528a-fdb2-4195-946e-098137a7a764"), "Деятельность", 5 },
                    { new Guid("f758f000-07df-4d61-a6e9-ea2ce0c60f38"), "Профессиональное развитие", 3 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb"), "Основной", 1 },
                    { new Guid("7236832c-a363-4ac0-a153-d95c2455c9c0"), "Инновационная и иная деятельность", 6 },
                    { new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032"), "Образовательная деятельность", 2 },
                    { new Guid("8f545139-22a4-41a1-b69d-f34ff6f54f1c"), "Конкурсная работа", 7 },
                    { new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("b6c0dd4e-5502-4243-b476-7c0b4a2b1504"), "Методическая деятельность", 3 },
                    { new Guid("dfa78d8a-3d0c-468c-8c4b-728994ef6ad0"), "Профессиональные показатели", 4 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("39b2f714-0f7c-4758-afcf-a0a2fb894512"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("a3580228-866d-4569-90d6-a30a82a59713"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("69da5b2b-313c-40d2-99e4-f0693c7d2316"), "bool" },
                    { new Guid("8400b4f0-7f30-44b9-b8a3-9476e4289d5e"), "DateTime" },
                    { new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a"), "string" },
                    { new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e"), "int" },
                    { new Guid("f2fd6e1e-fe97-4b44-aac9-a80082d45b40"), "TextArea" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("37e09e2b-fbee-4c56-b1bc-c32bc4ac26c8"), new Guid("a3580228-866d-4569-90d6-a30a82a59713") },
                    { new Guid("429eec46-34d6-42e8-9e8e-af538d0539ca"), new Guid("39b2f714-0f7c-4758-afcf-a0a2fb894512") },
                    { new Guid("429eec46-34d6-42e8-9e8e-af538d0539ca"), new Guid("a3580228-866d-4569-90d6-a30a82a59713") },
                    { new Guid("62537414-e226-4d60-9cda-3ed883a073fc"), new Guid("39b2f714-0f7c-4758-afcf-a0a2fb894512") },
                    { new Guid("62537414-e226-4d60-9cda-3ed883a073fc"), new Guid("a3580228-866d-4569-90d6-a30a82a59713") },
                    { new Guid("8596528a-fdb2-4195-946e-098137a7a764"), new Guid("39b2f714-0f7c-4758-afcf-a0a2fb894512") },
                    { new Guid("f758f000-07df-4d61-a6e9-ea2ce0c60f38"), new Guid("39b2f714-0f7c-4758-afcf-a0a2fb894512") },
                    { new Guid("f758f000-07df-4d61-a6e9-ea2ce0c60f38"), new Guid("a3580228-866d-4569-90d6-a30a82a59713") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("01527c4b-a1d8-4620-91da-60a867ae538e"), new Guid("429eec46-34d6-42e8-9e8e-af538d0539ca"), null, false, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("0fa97f28-f919-430f-9afb-574519ccee08"), new Guid("37e09e2b-fbee-4c56-b1bc-c32bc4ac26c8"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("1e7b1124-c460-4e71-9dd2-1a93e6cc24e9"), new Guid("429eec46-34d6-42e8-9e8e-af538d0539ca"), null, true, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("34e49a88-ccb6-4248-8a4e-3c82c6cd80c1"), new Guid("62537414-e226-4d60-9cda-3ed883a073fc"), null, true, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("37a82009-2a46-46ae-8319-ed476a4e740d"), new Guid("62537414-e226-4d60-9cda-3ed883a073fc"), null, false, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("3fd96e96-ef9d-4efe-9edd-9acfc035da7e"), new Guid("62537414-e226-4d60-9cda-3ed883a073fc"), null, true, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("56abbb10-2bba-4bc9-b26c-9d38aff6994f"), new Guid("8596528a-fdb2-4195-946e-098137a7a764"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("62c99fc4-b287-4f82-9ece-939ba4cd6e94"), new Guid("429eec46-34d6-42e8-9e8e-af538d0539ca"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("79bc1a50-a845-4502-9889-cd39e668e016"), new Guid("8596528a-fdb2-4195-946e-098137a7a764"), null, false, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("80dc5ec4-2ce7-4e53-b2ec-d2923a0c46cc"), new Guid("429eec46-34d6-42e8-9e8e-af538d0539ca"), null, true, true, "Место работы/учебы", 6, "Название организации", new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("943863f4-7daf-4da9-876e-33e377c0bc52"), new Guid("37e09e2b-fbee-4c56-b1bc-c32bc4ac26c8"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("a7513e78-1e94-48ec-bbd1-47efeb6f3bea"), new Guid("429eec46-34d6-42e8-9e8e-af538d0539ca"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("a96e1cbb-3bcd-4a44-b342-71127949ccfc"), new Guid("37e09e2b-fbee-4c56-b1bc-c32bc4ac26c8"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("bb903c46-6ffd-42a1-9ab0-6256ae438d6e"), new Guid("429eec46-34d6-42e8-9e8e-af538d0539ca"), null, false, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("c6d0f695-73dd-48fb-b3ed-b3421cd7c79f"), new Guid("429eec46-34d6-42e8-9e8e-af538d0539ca"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("d0271f62-c2c6-4a6f-bbb2-f3b40f388ba3"), new Guid("429eec46-34d6-42e8-9e8e-af538d0539ca"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("8400b4f0-7f30-44b9-b8a3-9476e4289d5e") },
                    { new Guid("d5072e5c-6ef9-4b62-a0f4-ca92343d093d"), new Guid("429eec46-34d6-42e8-9e8e-af538d0539ca"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("d8ef5c3c-8af5-4cc1-87e4-8742c7a1a7fc"), new Guid("62537414-e226-4d60-9cda-3ed883a073fc"), null, false, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("f991abda-a04e-4648-8468-b54ca968953a"), new Guid("429eec46-34d6-42e8-9e8e-af538d0539ca"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb"), new Guid("39b2f714-0f7c-4758-afcf-a0a2fb894512") },
                    { new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb"), new Guid("a3580228-866d-4569-90d6-a30a82a59713") },
                    { new Guid("7236832c-a363-4ac0-a153-d95c2455c9c0"), new Guid("39b2f714-0f7c-4758-afcf-a0a2fb894512") },
                    { new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032"), new Guid("a3580228-866d-4569-90d6-a30a82a59713") },
                    { new Guid("8f545139-22a4-41a1-b69d-f34ff6f54f1c"), new Guid("39b2f714-0f7c-4758-afcf-a0a2fb894512") },
                    { new Guid("8f545139-22a4-41a1-b69d-f34ff6f54f1c"), new Guid("a3580228-866d-4569-90d6-a30a82a59713") },
                    { new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4"), new Guid("39b2f714-0f7c-4758-afcf-a0a2fb894512") },
                    { new Guid("b6c0dd4e-5502-4243-b476-7c0b4a2b1504"), new Guid("a3580228-866d-4569-90d6-a30a82a59713") },
                    { new Guid("dfa78d8a-3d0c-468c-8c4b-728994ef6ad0"), new Guid("a3580228-866d-4569-90d6-a30a82a59713") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0274ee5a-71c9-44e6-85d3-8ba460305dd9"), new Guid("f758f000-07df-4d61-a6e9-ea2ce0c60f38"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("1074edfa-ce63-40f5-a420-fcc710c9f622"), new Guid("f758f000-07df-4d61-a6e9-ea2ce0c60f38"), true, true, "Персональные идентификаторы", 10 },
                    { new Guid("1337ef68-de01-4c7f-8098-8095d0caf006"), new Guid("8596528a-fdb2-4195-946e-098137a7a764"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("21cfa27d-cf7f-45c5-ace8-88f79228206b"), new Guid("37e09e2b-fbee-4c56-b1bc-c32bc4ac26c8"), false, false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("25ba0fec-00ba-42a5-b367-0e5156948447"), new Guid("37e09e2b-fbee-4c56-b1bc-c32bc4ac26c8"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("5e5f460c-8337-419f-bd85-02f24c27cf5f"), new Guid("37e09e2b-fbee-4c56-b1bc-c32bc4ac26c8"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("74f9a1bf-e0e1-4652-81f1-2e1923068478"), new Guid("8596528a-fdb2-4195-946e-098137a7a764"), false, false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("7af28c1f-93bc-456d-8c6f-094d9ec9595f"), new Guid("37e09e2b-fbee-4c56-b1bc-c32bc4ac26c8"), false, false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("81a2b62d-b6d1-4c38-ab46-2590330cb9b4"), new Guid("62537414-e226-4d60-9cda-3ed883a073fc"), true, true, "Краткая аннотация конкурсной работы", 14 },
                    { new Guid("8be0c586-f545-4f1b-8a87-a360122b036c"), new Guid("8596528a-fdb2-4195-946e-098137a7a764"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("8cfb8a44-c157-4a10-98d2-022085b73d12"), new Guid("37e09e2b-fbee-4c56-b1bc-c32bc4ac26c8"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("aeb46344-193d-44f4-b4fe-8772b64bf0d1"), new Guid("37e09e2b-fbee-4c56-b1bc-c32bc4ac26c8"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("b4d9994f-3dc5-4ca3-8f21-dbc06d14e9c0"), new Guid("f758f000-07df-4d61-a6e9-ea2ce0c60f38"), false, false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("e9b59ee3-8af6-4342-9732-62b99d8c7d63"), new Guid("8596528a-fdb2-4195-946e-098137a7a764"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("155d11a9-6a46-41be-bd14-45048adb301a"), true, "Название документа, реквизиты", 1, new Guid("0274ee5a-71c9-44e6-85d3-8ba460305dd9"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("170f4fdd-f81e-4f9f-ac56-6b2800292d90"), true, "Название конкурса/премии", 2, new Guid("aeb46344-193d-44f4-b4fe-8772b64bf0d1"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("1a00417d-c158-48e5-94ac-0a7b856945bf"), true, "Ссылка на открытый доступ", 8, new Guid("21cfa27d-cf7f-45c5-ace8-88f79228206b"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("1c489277-c0dc-45b5-9975-83463b6f2290"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("8be0c586-f545-4f1b-8a87-a360122b036c"), new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("1f3fed94-d290-4346-8ac6-39442574d198"), true, "Название", 2, new Guid("21cfa27d-cf7f-45c5-ace8-88f79228206b"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("248d9b1b-2936-4599-a5d1-704ccf2e0ba7"), true, "Название организации/должность/ставка", 1, new Guid("7af28c1f-93bc-456d-8c6f-094d9ec9595f"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("25ef1fe5-3a05-4ed6-8793-366fdb4c1d10"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("8be0c586-f545-4f1b-8a87-a360122b036c"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("26628df0-f805-4055-8d47-26afeaa5897f"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("25ba0fec-00ba-42a5-b367-0e5156948447"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("266b90e6-d282-4fc7-b796-d88a4c48dd72"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("7af28c1f-93bc-456d-8c6f-094d9ec9595f"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("2af733d6-ce1a-4369-b993-0ef08debef78"), true, "Количество печатных листов", 4, new Guid("21cfa27d-cf7f-45c5-ace8-88f79228206b"), new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("2b724e53-bd7c-46b4-9987-c481af694961"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("aeb46344-193d-44f4-b4fe-8772b64bf0d1"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("2f49a8e6-d8bf-4407-93ea-041d62554047"), true, "Название", 2, new Guid("1337ef68-de01-4c7f-8098-8095d0caf006"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("32449d98-f987-43c3-9d32-815d38afa377"), true, "Номер РИД", 4, new Guid("1337ef68-de01-4c7f-8098-8095d0caf006"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("3ea514c8-d762-43f7-a0d1-5456c0d1ba5c"), true, "ФИО соавторов", 3, new Guid("1337ef68-de01-4c7f-8098-8095d0caf006"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("3fa34bb4-e8e3-4ce3-819d-625c5004138d"), true, "Статус конкурса", 3, new Guid("b4d9994f-3dc5-4ca3-8f21-dbc06d14e9c0"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("4a18aae3-e832-4ddc-a539-43f2915fd5f2"), true, "ФИО", 1, new Guid("aeb46344-193d-44f4-b4fe-8772b64bf0d1"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("4dbcacd5-c655-4f39-a91d-1a2b9dddc304"), true, "Вид (лекции, лабораторные)", 2, new Guid("25ba0fec-00ba-42a5-b367-0e5156948447"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("53819de7-2edb-4150-a55c-c0c55973618b"), true, "Награда", 4, new Guid("b4d9994f-3dc5-4ca3-8f21-dbc06d14e9c0"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("5d88dc76-c96a-4098-913a-21af60e3fb74"), true, "Год", 3, new Guid("aeb46344-193d-44f4-b4fe-8772b64bf0d1"), new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("5d8e9b47-dc95-4b71-a233-d0dfd960c5dc"), true, "Вид", 1, new Guid("e9b59ee3-8af6-4342-9732-62b99d8c7d63"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("5f62091f-5216-412b-8181-08ddf9c3f84d"), true, "Название курса", 1, new Guid("5e5f460c-8337-419f-bd85-02f24c27cf5f"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("640ebdee-77eb-48f2-bb6f-a25d2f26a648"), true, "Период выполнения", 3, new Guid("8be0c586-f545-4f1b-8a87-a360122b036c"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("6e1ceadf-d1fd-48f2-aea5-547c7b417f04"), true, "Практические занятия (час.)", 4, new Guid("8cfb8a44-c157-4a10-98d2-022085b73d12"), new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("6e79f0a6-e451-409a-8e59-f527a694bf2a"), true, "Вид публикации", 1, new Guid("21cfa27d-cf7f-45c5-ace8-88f79228206b"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("710913ea-9461-4526-8969-471ea4b11e56"), true, "Количество часов", 4, new Guid("7af28c1f-93bc-456d-8c6f-094d9ec9595f"), new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("71f94b84-aa14-4a16-924c-859175df8957"), true, "Издательство, год", 6, new Guid("21cfa27d-cf7f-45c5-ace8-88f79228206b"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("721c789d-a9eb-4941-8148-e5936f6399b7"), true, "Название статьи", 1, new Guid("74f9a1bf-e0e1-4652-81f1-2e1923068478"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("739539cb-8d58-40cb-9131-69d59f6bcbf0"), true, "Название дисциплины", 1, new Guid("25ba0fec-00ba-42a5-b367-0e5156948447"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("77e9ac21-4b3c-42e6-897e-0a644f64dc29"), true, "Значение", 2, new Guid("81a2b62d-b6d1-4c38-ab46-2590330cb9b4"), new Guid("f2fd6e1e-fe97-4b44-aac9-a80082d45b40") },
                    { new Guid("7a3693fb-1196-4839-9e04-d300f9eb3361"), true, "Название конкурса", 2, new Guid("b4d9994f-3dc5-4ca3-8f21-dbc06d14e9c0"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("7b16868c-a72c-4e29-b9af-275c18825887"), true, "Соавторы", 2, new Guid("74f9a1bf-e0e1-4652-81f1-2e1923068478"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("83ba46b9-b283-4842-9c47-947c1caaee91"), true, "Название НИР/НИОКР", 1, new Guid("8be0c586-f545-4f1b-8a87-a360122b036c"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("8640bfcb-e8c3-404c-a119-77c98b83aeed"), true, "Вид", 1, new Guid("1337ef68-de01-4c7f-8098-8095d0caf006"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("868064c1-1c64-4c5c-8966-b35bbcbde4f6"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("74f9a1bf-e0e1-4652-81f1-2e1923068478"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("883df62f-2b2e-4924-b137-8da36319b39f"), true, "Название", 1, new Guid("81a2b62d-b6d1-4c38-ab46-2590330cb9b4"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("9329cd97-ee01-4f99-8002-3e7c3cb40486"), true, "Статус (руководитель/исполнитель)", 4, new Guid("8be0c586-f545-4f1b-8a87-a360122b036c"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("a007eff4-b568-4c1d-a194-e9d074559842"), true, "Ссылка", 5, new Guid("b4d9994f-3dc5-4ca3-8f21-dbc06d14e9c0"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("a1ad8002-4702-41e3-80a9-2ba79bc147bb"), true, "Название организации в которую внедрена разработка", 3, new Guid("e9b59ee3-8af6-4342-9732-62b99d8c7d63"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("a328d1f8-c167-4290-8d56-b716cf98e963"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("aeb46344-193d-44f4-b4fe-8772b64bf0d1"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("a80fc7df-7bae-4ae8-9723-27ce2ce69156"), true, "Год получения документа", 2, new Guid("0274ee5a-71c9-44e6-85d3-8ba460305dd9"), new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("a9b1597c-4b66-4b2b-bc50-432cfbf68276"), true, "Наличие грифа", 5, new Guid("21cfa27d-cf7f-45c5-ace8-88f79228206b"), new Guid("69da5b2b-313c-40d2-99e4-f0693c7d2316") },
                    { new Guid("af0452bd-53fb-4f24-8656-9736fc023894"), true, "Язык публикации", 7, new Guid("21cfa27d-cf7f-45c5-ace8-88f79228206b"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("b3202812-403f-430b-9fc0-4e7c4b3584ba"), true, "Издание, год", 4, new Guid("74f9a1bf-e0e1-4652-81f1-2e1923068478"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("b6b9e6dd-5950-4471-999c-c0ee0a4cb94b"), true, "Итого (час.)", 5, new Guid("8cfb8a44-c157-4a10-98d2-022085b73d12"), new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("be138ae2-bcad-4492-bf36-eb70598bb674"), true, "Название разработки", 2, new Guid("e9b59ee3-8af6-4342-9732-62b99d8c7d63"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("c138b5cd-7aaf-49ca-998d-e4e2edd54723"), true, "Год", 1, new Guid("b4d9994f-3dc5-4ca3-8f21-dbc06d14e9c0"), new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("c27d40d1-929e-468d-82fe-a6a538543e9d"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("8cfb8a44-c157-4a10-98d2-022085b73d12"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("c5608311-4d6b-4d54-a009-edf1212eeacc"), true, "Ссылка на платформу", 3, new Guid("5e5f460c-8337-419f-bd85-02f24c27cf5f"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("c80f65a9-8fd1-4bab-a6e5-50c46e512c72"), true, "Соавторы", 2, new Guid("5e5f460c-8337-419f-bd85-02f24c27cf5f"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("cf2646ca-07e8-47bd-b6cc-6a03d7cc094e"), false, "Тип идентификатора", 1, new Guid("1074edfa-ce63-40f5-a420-fcc710c9f622"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("db77bfef-2b61-4a1d-a7f1-efc5fccdfd54"), true, "Вид деятельности (преподавательская)", 3, new Guid("7af28c1f-93bc-456d-8c6f-094d9ec9595f"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("e3de3096-73f2-42fb-938e-de07eb33e06d"), true, "Год", 4, new Guid("5e5f460c-8337-419f-bd85-02f24c27cf5f"), new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("ececcf35-2d5f-4e50-9c8f-4d21b1d9f6be"), false, "Соавторы", 3, new Guid("21cfa27d-cf7f-45c5-ace8-88f79228206b"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("ee8f11d8-2431-4c3b-9696-4aba4001e848"), false, "Идентификатор", 2, new Guid("1074edfa-ce63-40f5-a420-fcc710c9f622"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") },
                    { new Guid("eff6ce80-7716-4862-aa29-c3edce70176d"), true, "Лекции (час.)", 3, new Guid("8cfb8a44-c157-4a10-98d2-022085b73d12"), new Guid("cd3de894-7fab-41bc-98bd-1bad8391415e") },
                    { new Guid("f10844e9-1121-44fb-a69f-ef0adeb2ef5e"), true, "Наименование курса", 1, new Guid("8cfb8a44-c157-4a10-98d2-022085b73d12"), new Guid("9b607d1a-046a-4a76-a036-3e2f17e7f34a") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("01527c4b-a1d8-4620-91da-60a867ae538e"), new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb") },
                    { new Guid("0fa97f28-f919-430f-9afb-574519ccee08"), new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032") },
                    { new Guid("1e7b1124-c460-4e71-9dd2-1a93e6cc24e9"), new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb") },
                    { new Guid("34e49a88-ccb6-4248-8a4e-3c82c6cd80c1"), new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb") },
                    { new Guid("34e49a88-ccb6-4248-8a4e-3c82c6cd80c1"), new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4") },
                    { new Guid("34e49a88-ccb6-4248-8a4e-3c82c6cd80c1"), new Guid("dfa78d8a-3d0c-468c-8c4b-728994ef6ad0") },
                    { new Guid("37a82009-2a46-46ae-8319-ed476a4e740d"), new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb") },
                    { new Guid("3fd96e96-ef9d-4efe-9edd-9acfc035da7e"), new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb") },
                    { new Guid("56abbb10-2bba-4bc9-b26c-9d38aff6994f"), new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4") },
                    { new Guid("62c99fc4-b287-4f82-9ece-939ba4cd6e94"), new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb") },
                    { new Guid("79bc1a50-a845-4502-9889-cd39e668e016"), new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4") },
                    { new Guid("80dc5ec4-2ce7-4e53-b2ec-d2923a0c46cc"), new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb") },
                    { new Guid("943863f4-7daf-4da9-876e-33e377c0bc52"), new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032") },
                    { new Guid("a7513e78-1e94-48ec-bbd1-47efeb6f3bea"), new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb") },
                    { new Guid("a96e1cbb-3bcd-4a44-b342-71127949ccfc"), new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032") },
                    { new Guid("bb903c46-6ffd-42a1-9ab0-6256ae438d6e"), new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb") },
                    { new Guid("c6d0f695-73dd-48fb-b3ed-b3421cd7c79f"), new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb") },
                    { new Guid("d0271f62-c2c6-4a6f-bbb2-f3b40f388ba3"), new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb") },
                    { new Guid("d5072e5c-6ef9-4b62-a0f4-ca92343d093d"), new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb") },
                    { new Guid("d8ef5c3c-8af5-4cc1-87e4-8742c7a1a7fc"), new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb") },
                    { new Guid("f991abda-a04e-4648-8468-b54ca968953a"), new Guid("38dd650c-10cf-4145-ba7b-1acf79bb6fbb") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("7236832c-a363-4ac0-a153-d95c2455c9c0"), new Guid("0274ee5a-71c9-44e6-85d3-8ba460305dd9") },
                    { new Guid("7236832c-a363-4ac0-a153-d95c2455c9c0"), new Guid("1337ef68-de01-4c7f-8098-8095d0caf006") },
                    { new Guid("7236832c-a363-4ac0-a153-d95c2455c9c0"), new Guid("e9b59ee3-8af6-4342-9732-62b99d8c7d63") },
                    { new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032"), new Guid("5e5f460c-8337-419f-bd85-02f24c27cf5f") },
                    { new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032"), new Guid("7af28c1f-93bc-456d-8c6f-094d9ec9595f") },
                    { new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032"), new Guid("8cfb8a44-c157-4a10-98d2-022085b73d12") },
                    { new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032"), new Guid("aeb46344-193d-44f4-b4fe-8772b64bf0d1") },
                    { new Guid("8f545139-22a4-41a1-b69d-f34ff6f54f1c"), new Guid("81a2b62d-b6d1-4c38-ab46-2590330cb9b4") },
                    { new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4"), new Guid("1074edfa-ce63-40f5-a420-fcc710c9f622") },
                    { new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4"), new Guid("74f9a1bf-e0e1-4652-81f1-2e1923068478") },
                    { new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4"), new Guid("8be0c586-f545-4f1b-8a87-a360122b036c") },
                    { new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4"), new Guid("b4d9994f-3dc5-4ca3-8f21-dbc06d14e9c0") },
                    { new Guid("b6c0dd4e-5502-4243-b476-7c0b4a2b1504"), new Guid("21cfa27d-cf7f-45c5-ace8-88f79228206b") },
                    { new Guid("b6c0dd4e-5502-4243-b476-7c0b4a2b1504"), new Guid("25ba0fec-00ba-42a5-b367-0e5156948447") },
                    { new Guid("dfa78d8a-3d0c-468c-8c4b-728994ef6ad0"), new Guid("0274ee5a-71c9-44e6-85d3-8ba460305dd9") },
                    { new Guid("dfa78d8a-3d0c-468c-8c4b-728994ef6ad0"), new Guid("b4d9994f-3dc5-4ca3-8f21-dbc06d14e9c0") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("01ad9f5f-2cd1-457c-a32c-80374d7690ea"), "EvaluateMark3", new Guid("a96e1cbb-3bcd-4a44-b342-71127949ccfc"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("0813ef5e-8039-4550-b898-0a7124b2333f"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("25ba0fec-00ba-42a5-b367-0e5156948447") },
                    { new Guid("0a446e1a-5070-4178-b536-a6642cfef147"), "EvaluateMark5", new Guid("0fa97f28-f919-430f-9afb-574519ccee08"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("2392f306-ae85-4c8e-9921-9e42dcef6f78"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("8cfb8a44-c157-4a10-98d2-022085b73d12") },
                    { new Guid("251fc1db-92d2-4e79-bbdb-51adb5d13348"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("21cfa27d-cf7f-45c5-ace8-88f79228206b") },
                    { new Guid("254c223b-407c-49bb-a739-349b29bd783d"), "EvaluateMark4", new Guid("943863f4-7daf-4da9-876e-33e377c0bc52"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("380ab4e7-b960-4580-b67d-9cfd953294ab"), "EvaluateMark19", new Guid("56abbb10-2bba-4bc9-b26c-9d38aff6994f"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("39a73a01-4427-47e2-98a3-0e1049e88c5e"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("0274ee5a-71c9-44e6-85d3-8ba460305dd9") },
                    { new Guid("3c7a73d5-64e7-4374-a49f-c97215c16942"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("8be0c586-f545-4f1b-8a87-a360122b036c") },
                    { new Guid("448a2580-4ce8-4a9c-8f70-3dc8c684bc4b"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("21cfa27d-cf7f-45c5-ace8-88f79228206b") },
                    { new Guid("5ef1daa7-bad3-4653-b616-5096c265791e"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("74f9a1bf-e0e1-4652-81f1-2e1923068478") },
                    { new Guid("71c44532-2629-496b-83e9-945b1c8ab2d4"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("21cfa27d-cf7f-45c5-ace8-88f79228206b") },
                    { new Guid("83c0af3b-eee4-4907-b698-5b270232680d"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("5e5f460c-8337-419f-bd85-02f24c27cf5f") },
                    { new Guid("8b9cc6ff-0a47-4f6b-8e86-7b74129611fc"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("8cfb8a44-c157-4a10-98d2-022085b73d12") },
                    { new Guid("8f82a4d7-fe6c-4fa3-a74e-2f4a7fd3e812"), "EvaluateMark20", new Guid("79bc1a50-a845-4502-9889-cd39e668e016"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("91facc13-0bd4-4c13-944b-a3930ffb5aea"), null, null, false, 10, "Оценка уровня предоставленной работы:", 25, new Guid("81a2b62d-b6d1-4c38-ab46-2590330cb9b4") },
                    { new Guid("9bd6dc52-7dd8-4c50-8c23-c2f8a5867156"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("1337ef68-de01-4c7f-8098-8095d0caf006") },
                    { new Guid("a72e38c6-99e1-4c0e-8346-7d7f6cf788d3"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("e9b59ee3-8af6-4342-9732-62b99d8c7d63") },
                    { new Guid("ac6f4843-e7f7-4070-8c64-0ea74805cf98"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("21cfa27d-cf7f-45c5-ace8-88f79228206b") },
                    { new Guid("b9a8f63f-b9e9-4fa2-bbba-7c3140f6d929"), null, null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("81a2b62d-b6d1-4c38-ab46-2590330cb9b4") },
                    { new Guid("d4772854-c2a4-49c2-bd8b-90d17f4add45"), "EvaluateMark13", new Guid("34e49a88-ccb6-4248-8a4e-3c82c6cd80c1"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("e1bc0c43-7c31-40d7-84c9-7cd5983b4068"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("b4d9994f-3dc5-4ca3-8f21-dbc06d14e9c0") },
                    { new Guid("ef454eaf-ab8b-4bd5-a189-5dc5ae4b4981"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("8be0c586-f545-4f1b-8a87-a360122b036c") },
                    { new Guid("fcd720d0-53eb-4359-89ae-6ca19ead77ae"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("aeb46344-193d-44f4-b4fe-8772b64bf0d1") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("040ce041-3cb4-4dd4-beab-ccfd18c7628f"), true, new Guid("81a2b62d-b6d1-4c38-ab46-2590330cb9b4") },
                    { new Guid("119e1ddc-14e3-4011-961d-52accc6fa718"), true, new Guid("1074edfa-ce63-40f5-a420-fcc710c9f622") },
                    { new Guid("1f3732f1-2550-4acd-83f2-194b5e4cce95"), true, new Guid("81a2b62d-b6d1-4c38-ab46-2590330cb9b4") },
                    { new Guid("286044f0-1f3a-4c5f-9232-0c06267b8929"), true, new Guid("81a2b62d-b6d1-4c38-ab46-2590330cb9b4") },
                    { new Guid("4fb828d3-92fb-4f59-ae84-a053ffc5f25c"), true, new Guid("81a2b62d-b6d1-4c38-ab46-2590330cb9b4") },
                    { new Guid("5e663f6f-2f5b-4ab1-946d-c80d02c72b7e"), true, new Guid("81a2b62d-b6d1-4c38-ab46-2590330cb9b4") },
                    { new Guid("73bd8d55-1d9a-4d3d-86cf-cc44c8874495"), true, new Guid("81a2b62d-b6d1-4c38-ab46-2590330cb9b4") },
                    { new Guid("7d8d4d33-0d2a-49cd-9304-4d7b0fa7f409"), true, new Guid("1074edfa-ce63-40f5-a420-fcc710c9f622") },
                    { new Guid("970e688a-5b6b-4136-b10c-2ed3b37a61e1"), true, new Guid("81a2b62d-b6d1-4c38-ab46-2590330cb9b4") },
                    { new Guid("bf098fcc-7a8f-4e9c-bbf3-cf40d018b0ad"), true, new Guid("81a2b62d-b6d1-4c38-ab46-2590330cb9b4") },
                    { new Guid("cbd6ae59-b950-4bb2-b4d7-bb6b64a8c19a"), true, new Guid("1074edfa-ce63-40f5-a420-fcc710c9f622") },
                    { new Guid("db2b084a-bdcc-451b-816b-2fcbdbf21fab"), true, new Guid("1074edfa-ce63-40f5-a420-fcc710c9f622") },
                    { new Guid("ec736c7c-c9c0-4b74-a1f3-741d60b021aa"), true, new Guid("1074edfa-ce63-40f5-a420-fcc710c9f622") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("3efce5fb-d854-4a86-b1f0-ac985dd5bc5f"), null, new Guid("3fd96e96-ef9d-4efe-9edd-9acfc035da7e"), "Доктор наук" },
                    { new Guid("90480910-8dcc-4527-88a7-38d0819f8175"), null, new Guid("34e49a88-ccb6-4248-8a4e-3c82c6cd80c1"), "Доцент" },
                    { new Guid("a758f7fc-8dd7-47b5-94da-4fef9ac5521d"), null, new Guid("34e49a88-ccb6-4248-8a4e-3c82c6cd80c1"), "Нет" },
                    { new Guid("b396379f-7c89-40b2-a8a2-99b8fb16532a"), null, new Guid("34e49a88-ccb6-4248-8a4e-3c82c6cd80c1"), "Профессор" },
                    { new Guid("d795d22d-317a-4865-81d0-b6866f48e94d"), null, new Guid("d8ef5c3c-8af5-4cc1-87e4-8742c7a1a7fc"), "Имеющие ученую степень доктора наук" },
                    { new Guid("fbeb464f-18ed-48ea-a935-bf3025202220"), null, new Guid("3fd96e96-ef9d-4efe-9edd-9acfc035da7e"), "Кандидат наук" },
                    { new Guid("fdffffd7-b045-4843-a781-39e4a284f616"), null, new Guid("d8ef5c3c-8af5-4cc1-87e4-8742c7a1a7fc"), "Докторанты, имеющие ученую степень кандидата наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("11c18527-1454-4386-bd2b-77b75ee53701"), null, new Guid("883df62f-2b2e-4924-b137-8da36319b39f"), true, true, new Guid("286044f0-1f3a-4c5f-9232-0c06267b8929"), "Название работы" },
                    { new Guid("17025ccc-2299-4320-94e0-5713acaefd6b"), null, new Guid("ee8f11d8-2431-4c3b-9696-4aba4001e848"), false, true, new Guid("7d8d4d33-0d2a-49cd-9304-4d7b0fa7f409"), null },
                    { new Guid("19033c50-3a5a-443a-bac8-05f79ef38aa4"), null, new Guid("77e9ac21-4b3c-42e6-897e-0a644f64dc29"), false, true, new Guid("286044f0-1f3a-4c5f-9232-0c06267b8929"), null },
                    { new Guid("21eed1ae-80d8-4bae-a6f2-624cfa3a12ea"), null, new Guid("883df62f-2b2e-4924-b137-8da36319b39f"), true, true, new Guid("040ce041-3cb4-4dd4-beab-ccfd18c7628f"), "Инновационность" },
                    { new Guid("2fa437bf-bdaf-4238-a607-176d73aad4ec"), null, new Guid("ee8f11d8-2431-4c3b-9696-4aba4001e848"), false, true, new Guid("ec736c7c-c9c0-4b74-a1f3-741d60b021aa"), null },
                    { new Guid("31712a67-4b7c-4d0e-87fd-240cd71097b0"), null, new Guid("cf2646ca-07e8-47bd-b6cc-6a03d7cc094e"), true, true, new Guid("db2b084a-bdcc-451b-816b-2fcbdbf21fab"), "ResearcherID" },
                    { new Guid("483d341d-f53e-4e10-8bd9-214d9c2c7a71"), null, new Guid("cf2646ca-07e8-47bd-b6cc-6a03d7cc094e"), true, true, new Guid("119e1ddc-14e3-4011-961d-52accc6fa718"), "ORCiD" },
                    { new Guid("4848de01-19df-4a85-b11a-18631ea2586d"), null, new Guid("883df62f-2b2e-4924-b137-8da36319b39f"), true, true, new Guid("4fb828d3-92fb-4f59-ae84-a053ffc5f25c"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("502017dc-b417-4a8e-955b-8b30768bb71c"), null, new Guid("883df62f-2b2e-4924-b137-8da36319b39f"), true, true, new Guid("5e663f6f-2f5b-4ab1-946d-c80d02c72b7e"), "Ссылка на конкурсную работу" },
                    { new Guid("520c13f5-d3ee-458b-bcb4-14d38fffa647"), null, new Guid("883df62f-2b2e-4924-b137-8da36319b39f"), true, true, new Guid("bf098fcc-7a8f-4e9c-bbf3-cf40d018b0ad"), "Результаты и выводы" },
                    { new Guid("5ecd3e51-3c4f-4514-9a1b-2acd55aaf9f6"), null, new Guid("77e9ac21-4b3c-42e6-897e-0a644f64dc29"), false, true, new Guid("970e688a-5b6b-4136-b10c-2ed3b37a61e1"), null },
                    { new Guid("67766fc5-43e6-49a1-9035-e2a2672b537d"), null, new Guid("883df62f-2b2e-4924-b137-8da36319b39f"), true, true, new Guid("73bd8d55-1d9a-4d3d-86cf-cc44c8874495"), "Методология и методы, используемые в работе" },
                    { new Guid("73d3e91e-f11e-46f6-9043-17f044790f5b"), null, new Guid("883df62f-2b2e-4924-b137-8da36319b39f"), true, true, new Guid("1f3732f1-2550-4acd-83f2-194b5e4cce95"), "Актуальность конкурсной работы" },
                    { new Guid("7deb72ea-dfb3-488a-b19d-c11b96da09c7"), null, new Guid("cf2646ca-07e8-47bd-b6cc-6a03d7cc094e"), true, true, new Guid("7d8d4d33-0d2a-49cd-9304-4d7b0fa7f409"), "Google Scholar ID" },
                    { new Guid("8df4895f-d44a-4773-abbe-98afd0b56c0d"), null, new Guid("77e9ac21-4b3c-42e6-897e-0a644f64dc29"), false, true, new Guid("bf098fcc-7a8f-4e9c-bbf3-cf40d018b0ad"), null },
                    { new Guid("9ee66fbc-e345-4172-9d2e-e971584b424b"), null, new Guid("ee8f11d8-2431-4c3b-9696-4aba4001e848"), false, true, new Guid("119e1ddc-14e3-4011-961d-52accc6fa718"), null },
                    { new Guid("aba2b9c8-e311-4bc2-a59f-31d0fecc4045"), null, new Guid("ee8f11d8-2431-4c3b-9696-4aba4001e848"), false, true, new Guid("cbd6ae59-b950-4bb2-b4d7-bb6b64a8c19a"), null },
                    { new Guid("abc4de1a-aa48-42da-853b-f8ec122251a3"), null, new Guid("cf2646ca-07e8-47bd-b6cc-6a03d7cc094e"), true, true, new Guid("ec736c7c-c9c0-4b74-a1f3-741d60b021aa"), "ScopusID" },
                    { new Guid("b0e9fc02-a695-44af-ad11-d96fdd0959b1"), null, new Guid("883df62f-2b2e-4924-b137-8da36319b39f"), true, true, new Guid("970e688a-5b6b-4136-b10c-2ed3b37a61e1"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("b6e1ce52-15a2-4da4-bab0-d10b887f1d7d"), null, new Guid("77e9ac21-4b3c-42e6-897e-0a644f64dc29"), false, true, new Guid("1f3732f1-2550-4acd-83f2-194b5e4cce95"), null },
                    { new Guid("c459efaf-a002-46c2-bf4e-beff3a058412"), null, new Guid("cf2646ca-07e8-47bd-b6cc-6a03d7cc094e"), true, true, new Guid("cbd6ae59-b950-4bb2-b4d7-bb6b64a8c19a"), "РИНЦ AuthorID" },
                    { new Guid("d490ca9a-958e-4b3e-93f8-f281d2942de4"), null, new Guid("77e9ac21-4b3c-42e6-897e-0a644f64dc29"), false, true, new Guid("040ce041-3cb4-4dd4-beab-ccfd18c7628f"), null },
                    { new Guid("def7d13b-3b3d-4ff6-8b7f-58b8faadaa8d"), null, new Guid("77e9ac21-4b3c-42e6-897e-0a644f64dc29"), false, true, new Guid("73bd8d55-1d9a-4d3d-86cf-cc44c8874495"), null },
                    { new Guid("df00e3e5-b762-4004-b484-24699944e89e"), null, new Guid("ee8f11d8-2431-4c3b-9696-4aba4001e848"), false, true, new Guid("db2b084a-bdcc-451b-816b-2fcbdbf21fab"), null },
                    { new Guid("f4f5b10d-c978-4c3a-9028-830d22002df4"), null, new Guid("77e9ac21-4b3c-42e6-897e-0a644f64dc29"), false, true, new Guid("4fb828d3-92fb-4f59-ae84-a053ffc5f25c"), null },
                    { new Guid("fce33b43-7e77-44e4-a40e-2925f5c8ec3b"), null, new Guid("77e9ac21-4b3c-42e6-897e-0a644f64dc29"), false, true, new Guid("5e663f6f-2f5b-4ab1-946d-c80d02c72b7e"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("7236832c-a363-4ac0-a153-d95c2455c9c0"), new Guid("39a73a01-4427-47e2-98a3-0e1049e88c5e") },
                    { new Guid("7236832c-a363-4ac0-a153-d95c2455c9c0"), new Guid("9bd6dc52-7dd8-4c50-8c23-c2f8a5867156") },
                    { new Guid("7236832c-a363-4ac0-a153-d95c2455c9c0"), new Guid("a72e38c6-99e1-4c0e-8346-7d7f6cf788d3") },
                    { new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032"), new Guid("01ad9f5f-2cd1-457c-a32c-80374d7690ea") },
                    { new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032"), new Guid("0a446e1a-5070-4178-b536-a6642cfef147") },
                    { new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032"), new Guid("2392f306-ae85-4c8e-9921-9e42dcef6f78") },
                    { new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032"), new Guid("254c223b-407c-49bb-a739-349b29bd783d") },
                    { new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032"), new Guid("83c0af3b-eee4-4907-b698-5b270232680d") },
                    { new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032"), new Guid("8b9cc6ff-0a47-4f6b-8e86-7b74129611fc") },
                    { new Guid("7595ca9c-8b66-4c57-8fe4-4512b194f032"), new Guid("fcd720d0-53eb-4359-89ae-6ca19ead77ae") },
                    { new Guid("8f545139-22a4-41a1-b69d-f34ff6f54f1c"), new Guid("91facc13-0bd4-4c13-944b-a3930ffb5aea") },
                    { new Guid("8f545139-22a4-41a1-b69d-f34ff6f54f1c"), new Guid("b9a8f63f-b9e9-4fa2-bbba-7c3140f6d929") },
                    { new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4"), new Guid("380ab4e7-b960-4580-b67d-9cfd953294ab") },
                    { new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4"), new Guid("3c7a73d5-64e7-4374-a49f-c97215c16942") },
                    { new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4"), new Guid("5ef1daa7-bad3-4653-b616-5096c265791e") },
                    { new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4"), new Guid("8f82a4d7-fe6c-4fa3-a74e-2f4a7fd3e812") },
                    { new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4"), new Guid("d4772854-c2a4-49c2-bd8b-90d17f4add45") },
                    { new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4"), new Guid("e1bc0c43-7c31-40d7-84c9-7cd5983b4068") },
                    { new Guid("adb7c7b5-955d-4b26-815b-52022f5cfbb4"), new Guid("ef454eaf-ab8b-4bd5-a189-5dc5ae4b4981") },
                    { new Guid("b6c0dd4e-5502-4243-b476-7c0b4a2b1504"), new Guid("0813ef5e-8039-4550-b898-0a7124b2333f") },
                    { new Guid("b6c0dd4e-5502-4243-b476-7c0b4a2b1504"), new Guid("251fc1db-92d2-4e79-bbdb-51adb5d13348") },
                    { new Guid("b6c0dd4e-5502-4243-b476-7c0b4a2b1504"), new Guid("448a2580-4ce8-4a9c-8f70-3dc8c684bc4b") },
                    { new Guid("b6c0dd4e-5502-4243-b476-7c0b4a2b1504"), new Guid("71c44532-2629-496b-83e9-945b1c8ab2d4") },
                    { new Guid("b6c0dd4e-5502-4243-b476-7c0b4a2b1504"), new Guid("ac6f4843-e7f7-4070-8c64-0ea74805cf98") },
                    { new Guid("dfa78d8a-3d0c-468c-8c4b-728994ef6ad0"), new Guid("39a73a01-4427-47e2-98a3-0e1049e88c5e") },
                    { new Guid("dfa78d8a-3d0c-468c-8c4b-728994ef6ad0"), new Guid("d4772854-c2a4-49c2-bd8b-90d17f4add45") },
                    { new Guid("dfa78d8a-3d0c-468c-8c4b-728994ef6ad0"), new Guid("e1bc0c43-7c31-40d7-84c9-7cd5983b4068") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("020ac2c6-316a-4886-aaf6-f104aedee3bd"), new Guid("af0452bd-53fb-4f24-8656-9736fc023894"), null, "Иностранный" },
                    { new Guid("07e24967-e83b-433c-9358-be14edb2da7e"), new Guid("ececcf35-2d5f-4e50-9c8f-4d21b1d9f6be"), null, "Нет" },
                    { new Guid("218468d1-5eb0-47b3-8f2a-63f1f030c5f2"), new Guid("9329cd97-ee01-4f99-8002-3e7c3cb40486"), null, "Руководитель" },
                    { new Guid("2314e5e9-4728-45ef-86c5-9907dc19debc"), new Guid("8640bfcb-e8c3-404c-a119-77c98b83aeed"), null, "База данных" },
                    { new Guid("2d5bea32-9130-4ac3-811b-b0d261c2aed1"), new Guid("ececcf35-2d5f-4e50-9c8f-4d21b1d9f6be"), null, "Есть" },
                    { new Guid("464864b2-3c2b-482e-9573-8629c2d672a7"), new Guid("6e79f0a6-e451-409a-8e59-f527a694bf2a"), null, "Монография" },
                    { new Guid("4cf862d9-08af-4ff4-8f6c-c44582ffc039"), new Guid("3fa34bb4-e8e3-4ce3-819d-625c5004138d"), null, "Международный" },
                    { new Guid("520c2a47-05ea-4f1d-99e3-b1efdbcf9e40"), new Guid("6e79f0a6-e451-409a-8e59-f527a694bf2a"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("52434757-ed48-4cda-9020-c927b24809c6"), new Guid("5d8e9b47-dc95-4b71-a233-d0dfd960c5dc"), null, "Изобретение" },
                    { new Guid("55e0d39c-4de8-4949-8092-08383cb5554e"), new Guid("6e79f0a6-e451-409a-8e59-f527a694bf2a"), null, "Учебник" },
                    { new Guid("56cf33e1-779b-40aa-943c-50bcb98c71c0"), new Guid("4dbcacd5-c655-4f39-a91d-1a2b9dddc304"), null, "Лекции" },
                    { new Guid("69bcfc6c-f813-4960-b4c3-6651117fb8de"), new Guid("5d8e9b47-dc95-4b71-a233-d0dfd960c5dc"), null, "Полезная модель" },
                    { new Guid("85db189e-d463-4265-80b3-4b6c02a9dce8"), new Guid("3fa34bb4-e8e3-4ce3-819d-625c5004138d"), null, "Всероссийский" },
                    { new Guid("8b5531c7-23a9-4877-8131-ee307385bf6d"), new Guid("8640bfcb-e8c3-404c-a119-77c98b83aeed"), null, "Полезная модель" },
                    { new Guid("948a45df-8d8c-4bf3-b61b-8c322d397879"), new Guid("7b16868c-a72c-4e29-b9af-275c18825887"), null, "Нет" },
                    { new Guid("bd61c87a-889d-448e-9ab8-90466d369994"), new Guid("3fa34bb4-e8e3-4ce3-819d-625c5004138d"), null, "Региональный" },
                    { new Guid("bfe9b4bf-29b6-4098-ae36-bdf57c93d617"), new Guid("af0452bd-53fb-4f24-8656-9736fc023894"), null, "Русский" },
                    { new Guid("c8d62d58-12d4-474a-baca-5e665103bb76"), new Guid("5d8e9b47-dc95-4b71-a233-d0dfd960c5dc"), null, "База данных" },
                    { new Guid("c9c64c18-2e01-44f8-b248-ab34455c396e"), new Guid("8640bfcb-e8c3-404c-a119-77c98b83aeed"), null, "Изобретение" },
                    { new Guid("daf3a079-7add-47f9-bd71-0f196c318656"), new Guid("4dbcacd5-c655-4f39-a91d-1a2b9dddc304"), null, "Лабораторные" },
                    { new Guid("e14cbf21-74c9-46fb-a381-c7745fcc4b2d"), new Guid("9329cd97-ee01-4f99-8002-3e7c3cb40486"), null, "Исполнитель" },
                    { new Guid("feee9e2a-a120-45ec-8ed0-654f02b11ecd"), new Guid("7b16868c-a72c-4e29-b9af-275c18825887"), null, "Есть" }
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
