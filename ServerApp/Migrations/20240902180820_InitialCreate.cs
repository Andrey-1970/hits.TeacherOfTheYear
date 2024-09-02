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
                    { new Guid("2611e3e7-be00-4424-b41f-0e429cf96fb5"), 4, "Одобрена" },
                    { new Guid("5868674f-06c9-414f-a68b-6955c9f7bb9c"), 6, "Оценена" },
                    { new Guid("af3a9062-e08f-4edf-a43a-295f60e18702"), 3, "В процессе рассмотрения" },
                    { new Guid("b05d13e8-16e8-4607-afbb-dba248c86e08"), 2, "В ожидании рассмотрения" },
                    { new Guid("c47ebfce-7595-42d0-b0e5-cf820b7301c4"), 1, "В ожидании заполнения" },
                    { new Guid("cebda2d3-a4c5-4cbd-a0dd-40869c95a70d"), 5, "Отклонена" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5ce74b37-4adb-4ac5-a267-c25155404bdd", null, "Admin", "ADMIN" },
                    { "c60d2e36-0152-4137-9dee-cb7e0591298e", null, "Participant", "PARTICIPANT" },
                    { "d238a2b6-31b3-4176-953d-7656062b000c", null, "Voter", "VOTER" },
                    { "e9193b25-20fa-435e-95d3-b40cd9ebd827", null, "Expert", "EXPERT" },
                    { "f1d6c110-691d-429f-b229-b11159a75f97", null, "Organiser", "ORGANISER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("3bae6bbf-db58-477c-9430-13bb51764d9b"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("ffd5775c-f93e-4e22-b678-4744ebd394d0"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("43604bb4-bdf7-41da-a916-6e6a4829dd17"), "Профессиональное развитие", 3 },
                    { new Guid("4f0c8eda-27d4-4931-9512-4e485c75dd2c"), "Деятельность", 4 },
                    { new Guid("8db3dba8-fa09-45ee-85b6-47f7efe629db"), "Категория участников", 2 },
                    { new Guid("a090318f-0d7a-4cb6-9d4b-3fd46847790f"), "Общая информация", 1 },
                    { new Guid("dfebf4da-7064-465b-a5d0-b2af2b5edf04"), "Деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("15e717d1-f179-44d0-91c1-e924aa383eac"), "Методическая деятельность", 3 },
                    { new Guid("b4942f11-d20d-463d-b190-d3554179239b"), "Основной", 1 },
                    { new Guid("ba8d3001-e9c9-415a-81ea-530fa885e059"), "Профессиональные показатели", 4 },
                    { new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6"), "Образовательная деятельность", 2 },
                    { new Guid("ddb1a07a-bc76-433f-be23-e29be7b7112d"), "Инновационная и иная деятельность", 6 },
                    { new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("fcee23d9-5155-4412-8ae7-da45187ac603"), "Конкурсная работа", 7 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("9687b89d-18b9-415d-a1ef-f9c2a47a9acb"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("99a7318c-bfc0-49f3-9bf8-6af400d591f6"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("60b3d355-d660-4f61-b64b-193f97bf0279"), "bool" },
                    { new Guid("7c6df8dc-f1ea-4425-86a2-9ab2a08327a2"), "TextArea" },
                    { new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11"), "int" },
                    { new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb"), "string" },
                    { new Guid("f2a8640c-1754-4995-9f2f-181b2c5ed5aa"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("43604bb4-bdf7-41da-a916-6e6a4829dd17"), new Guid("9687b89d-18b9-415d-a1ef-f9c2a47a9acb") },
                    { new Guid("43604bb4-bdf7-41da-a916-6e6a4829dd17"), new Guid("99a7318c-bfc0-49f3-9bf8-6af400d591f6") },
                    { new Guid("4f0c8eda-27d4-4931-9512-4e485c75dd2c"), new Guid("9687b89d-18b9-415d-a1ef-f9c2a47a9acb") },
                    { new Guid("8db3dba8-fa09-45ee-85b6-47f7efe629db"), new Guid("9687b89d-18b9-415d-a1ef-f9c2a47a9acb") },
                    { new Guid("8db3dba8-fa09-45ee-85b6-47f7efe629db"), new Guid("99a7318c-bfc0-49f3-9bf8-6af400d591f6") },
                    { new Guid("a090318f-0d7a-4cb6-9d4b-3fd46847790f"), new Guid("9687b89d-18b9-415d-a1ef-f9c2a47a9acb") },
                    { new Guid("a090318f-0d7a-4cb6-9d4b-3fd46847790f"), new Guid("99a7318c-bfc0-49f3-9bf8-6af400d591f6") },
                    { new Guid("dfebf4da-7064-465b-a5d0-b2af2b5edf04"), new Guid("99a7318c-bfc0-49f3-9bf8-6af400d591f6") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("20948ddc-ceb5-4a94-a061-b945653efdad"), new Guid("8db3dba8-fa09-45ee-85b6-47f7efe629db"), null, false, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("22f84944-f547-4426-8581-10316e1fe684"), new Guid("8db3dba8-fa09-45ee-85b6-47f7efe629db"), null, true, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("2f8d2484-8325-466c-b59c-b1a9244d4e2e"), new Guid("4f0c8eda-27d4-4931-9512-4e485c75dd2c"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("3b041356-b886-442f-81ae-a9f259941685"), new Guid("a090318f-0d7a-4cb6-9d4b-3fd46847790f"), null, true, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("44a3ce53-9e9f-49d8-bd5c-ddc4ef4c170a"), new Guid("a090318f-0d7a-4cb6-9d4b-3fd46847790f"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("4d0a6b67-30d4-4f95-9e7e-e57e9df61b90"), new Guid("a090318f-0d7a-4cb6-9d4b-3fd46847790f"), null, false, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("661695d0-707f-462a-b63c-8dcf5ad23dd2"), new Guid("a090318f-0d7a-4cb6-9d4b-3fd46847790f"), null, false, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("8b9095b4-2cdf-4586-a452-c29373037521"), new Guid("dfebf4da-7064-465b-a5d0-b2af2b5edf04"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("90b743bf-c333-44ee-9192-d7644c86fb64"), new Guid("a090318f-0d7a-4cb6-9d4b-3fd46847790f"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("9136520d-aa85-4f9c-8e5b-7ffc2ee08ac2"), new Guid("a090318f-0d7a-4cb6-9d4b-3fd46847790f"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("92701b78-dd5c-4c46-bd20-5cd4edb9c768"), new Guid("a090318f-0d7a-4cb6-9d4b-3fd46847790f"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("97b38f30-1d02-4f9e-971d-2009539f58a4"), new Guid("4f0c8eda-27d4-4931-9512-4e485c75dd2c"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("9801c728-715d-4480-afcd-3b1347f093d5"), new Guid("4f0c8eda-27d4-4931-9512-4e485c75dd2c"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("a0750fb2-09c4-4901-affc-dddac5f0a27f"), new Guid("a090318f-0d7a-4cb6-9d4b-3fd46847790f"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("a5dd011a-3f16-4f02-be72-2ad782449968"), new Guid("8db3dba8-fa09-45ee-85b6-47f7efe629db"), null, true, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("b047af38-2820-4dda-bcda-1750c42d1fbb"), new Guid("8db3dba8-fa09-45ee-85b6-47f7efe629db"), null, false, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("c94b5a85-82e7-4c38-abcb-aafb76aef471"), new Guid("dfebf4da-7064-465b-a5d0-b2af2b5edf04"), null, false, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("d66ae91e-84c1-4493-a8ee-bef8ecc1ec33"), new Guid("a090318f-0d7a-4cb6-9d4b-3fd46847790f"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("f2a8640c-1754-4995-9f2f-181b2c5ed5aa") },
                    { new Guid("f29dd457-b804-41ee-b246-638b7e042921"), new Guid("a090318f-0d7a-4cb6-9d4b-3fd46847790f"), null, true, true, "Место работы/учебы", 6, "Название организации", new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("15e717d1-f179-44d0-91c1-e924aa383eac"), new Guid("9687b89d-18b9-415d-a1ef-f9c2a47a9acb") },
                    { new Guid("b4942f11-d20d-463d-b190-d3554179239b"), new Guid("9687b89d-18b9-415d-a1ef-f9c2a47a9acb") },
                    { new Guid("b4942f11-d20d-463d-b190-d3554179239b"), new Guid("99a7318c-bfc0-49f3-9bf8-6af400d591f6") },
                    { new Guid("ba8d3001-e9c9-415a-81ea-530fa885e059"), new Guid("9687b89d-18b9-415d-a1ef-f9c2a47a9acb") },
                    { new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6"), new Guid("9687b89d-18b9-415d-a1ef-f9c2a47a9acb") },
                    { new Guid("ddb1a07a-bc76-433f-be23-e29be7b7112d"), new Guid("99a7318c-bfc0-49f3-9bf8-6af400d591f6") },
                    { new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac"), new Guid("99a7318c-bfc0-49f3-9bf8-6af400d591f6") },
                    { new Guid("fcee23d9-5155-4412-8ae7-da45187ac603"), new Guid("9687b89d-18b9-415d-a1ef-f9c2a47a9acb") },
                    { new Guid("fcee23d9-5155-4412-8ae7-da45187ac603"), new Guid("99a7318c-bfc0-49f3-9bf8-6af400d591f6") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0861098b-fa0b-4532-9880-b0d907f6268b"), new Guid("4f0c8eda-27d4-4931-9512-4e485c75dd2c"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("08a6af70-0673-4046-9260-26c0e7228df7"), new Guid("4f0c8eda-27d4-4931-9512-4e485c75dd2c"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("0b872eb2-8a52-4ca1-af26-db9b41667128"), new Guid("4f0c8eda-27d4-4931-9512-4e485c75dd2c"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("1816654e-ceaa-4724-a550-dd3725794d41"), new Guid("dfebf4da-7064-465b-a5d0-b2af2b5edf04"), false, false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("1d7806d2-6ceb-4a8b-b1ba-51f462256f4e"), new Guid("43604bb4-bdf7-41da-a916-6e6a4829dd17"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("4b0c0176-59f8-4034-8cc3-e57cdaac20cc"), new Guid("dfebf4da-7064-465b-a5d0-b2af2b5edf04"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("4fee1a60-b468-4399-a6e0-af098342aed2"), new Guid("dfebf4da-7064-465b-a5d0-b2af2b5edf04"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("740fb31b-3dd5-4083-875f-68d70a0d40d8"), new Guid("43604bb4-bdf7-41da-a916-6e6a4829dd17"), false, false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("88cdc459-bfff-4549-b0c3-2fd1d04ac358"), new Guid("dfebf4da-7064-465b-a5d0-b2af2b5edf04"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("96143ff1-e724-4290-b28e-6cd9afa4dd1d"), new Guid("8db3dba8-fa09-45ee-85b6-47f7efe629db"), true, true, "Краткая аннотация конкурсной работы", 14 },
                    { new Guid("9a095aa7-b6e6-460d-a37a-93b32d165713"), new Guid("4f0c8eda-27d4-4931-9512-4e485c75dd2c"), false, false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("b7895997-687b-4792-a362-9b8048154f0e"), new Guid("4f0c8eda-27d4-4931-9512-4e485c75dd2c"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("d233f740-8097-4dfc-8ffa-c88dc518b521"), new Guid("dfebf4da-7064-465b-a5d0-b2af2b5edf04"), true, true, "Персональные идентификаторы", 10 },
                    { new Guid("efb87940-9025-4ef0-884e-b07e5ba323c7"), new Guid("4f0c8eda-27d4-4931-9512-4e485c75dd2c"), false, false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("01a5a3d5-8b5b-4502-9d53-800478393eea"), true, "Название курса", 1, new Guid("b7895997-687b-4792-a362-9b8048154f0e"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("0d57c9d9-5c6c-46c0-9576-199c4534cfe7"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("4fee1a60-b468-4399-a6e0-af098342aed2"), new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("1311b426-86a3-4916-a16a-380d16547064"), true, "Название организации в которую внедрена разработка", 3, new Guid("88cdc459-bfff-4549-b0c3-2fd1d04ac358"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("14e94979-6dc0-449e-9d9c-e4b16e833a9c"), true, "Ссылка на платформу", 3, new Guid("b7895997-687b-4792-a362-9b8048154f0e"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("161f60d6-0fa1-4c79-afeb-77d2d7ce8500"), false, "Соавторы", 3, new Guid("9a095aa7-b6e6-460d-a37a-93b32d165713"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("1842819c-1135-4b47-8b93-153b615a7226"), true, "Название дисциплины", 1, new Guid("08a6af70-0673-4046-9260-26c0e7228df7"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("228cc0e9-db63-4e77-ad83-45ade9a9c72d"), true, "Период выполнения", 3, new Guid("4fee1a60-b468-4399-a6e0-af098342aed2"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("2714332c-5045-4344-b8ea-6e50b2042c71"), true, "Итого (час.)", 5, new Guid("0861098b-fa0b-4532-9880-b0d907f6268b"), new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("287d7480-9cdd-4c54-9ff5-17253f1fab94"), true, "Наименование курса", 1, new Guid("0861098b-fa0b-4532-9880-b0d907f6268b"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("29143a74-2087-4de0-a22f-82761ae3e9eb"), true, "Год", 3, new Guid("0b872eb2-8a52-4ca1-af26-db9b41667128"), new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("2bf71c70-5def-494c-acca-38cfd0685ae8"), true, "Год", 4, new Guid("b7895997-687b-4792-a362-9b8048154f0e"), new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("2d4bf1a3-32b7-4e98-8358-bddfdddebe6f"), true, "Соавторы", 2, new Guid("1816654e-ceaa-4724-a550-dd3725794d41"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("3287311d-ae12-46a4-9f1b-ab9df5a0d8cf"), true, "Количество печатных листов", 4, new Guid("9a095aa7-b6e6-460d-a37a-93b32d165713"), new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("3b1aa819-5d8b-4fe6-9d12-eee11a7f014e"), true, "Название", 2, new Guid("4b0c0176-59f8-4034-8cc3-e57cdaac20cc"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("3e4f5c27-e450-48e9-8092-aa49e800286f"), true, "Номер РИД", 4, new Guid("4b0c0176-59f8-4034-8cc3-e57cdaac20cc"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("4062e4e9-d7d7-4231-96b0-8838319070b2"), true, "Статус (руководитель/исполнитель)", 4, new Guid("4fee1a60-b468-4399-a6e0-af098342aed2"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("472b7f0a-37f8-4a9f-b0c8-604a4b3a2e09"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("0b872eb2-8a52-4ca1-af26-db9b41667128"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("47adef9c-2ed9-4ad2-a7e1-a4a42e98089c"), true, "Значение", 2, new Guid("96143ff1-e724-4290-b28e-6cd9afa4dd1d"), new Guid("7c6df8dc-f1ea-4425-86a2-9ab2a08327a2") },
                    { new Guid("4827d9f9-8295-415c-962b-d89f3808163d"), true, "Соавторы", 2, new Guid("b7895997-687b-4792-a362-9b8048154f0e"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("51006453-d222-46e0-bd58-79aa18f59b41"), true, "Вид", 1, new Guid("4b0c0176-59f8-4034-8cc3-e57cdaac20cc"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("51183e04-16d0-4414-8e99-ab71de21f67c"), true, "Количество часов", 4, new Guid("efb87940-9025-4ef0-884e-b07e5ba323c7"), new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("54055ebf-c2cf-42e6-bccc-8fb132187f48"), true, "Год получения документа", 2, new Guid("1d7806d2-6ceb-4a8b-b1ba-51f462256f4e"), new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("5cf8a2b0-4ba9-4047-9668-0420f29247fa"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("0861098b-fa0b-4532-9880-b0d907f6268b"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("657c8bee-23f1-4a60-8706-45ec8ca55e65"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("efb87940-9025-4ef0-884e-b07e5ba323c7"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("663346cf-3ba2-416e-b442-f75aaf6ff533"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("0b872eb2-8a52-4ca1-af26-db9b41667128"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("691ad354-035c-4fbe-8173-0b998ee78eee"), true, "Награда", 4, new Guid("740fb31b-3dd5-4083-875f-68d70a0d40d8"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("6996d119-8489-4473-9d14-629ef8a2c417"), true, "Издание, год", 4, new Guid("1816654e-ceaa-4724-a550-dd3725794d41"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("6b0cc757-e054-43e5-afa8-c38b8be3ed9c"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("4fee1a60-b468-4399-a6e0-af098342aed2"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("716de2a1-5a57-4cac-a992-37b048df3401"), true, "ФИО соавторов", 3, new Guid("4b0c0176-59f8-4034-8cc3-e57cdaac20cc"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("72ef5613-fa0a-462e-b85c-7ed57fa88b12"), true, "Вид публикации", 1, new Guid("9a095aa7-b6e6-460d-a37a-93b32d165713"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("8441f2c1-57df-4294-a437-6e9330c37970"), true, "Год", 1, new Guid("740fb31b-3dd5-4083-875f-68d70a0d40d8"), new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("8618129b-8350-47f4-bbda-52ad5aec8f9f"), true, "Ссылка на открытый доступ", 8, new Guid("9a095aa7-b6e6-460d-a37a-93b32d165713"), new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("8bc3f629-8933-4362-82df-da517e55684f"), true, "Ссылка", 5, new Guid("740fb31b-3dd5-4083-875f-68d70a0d40d8"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("8cb776be-fb61-45bb-b0e2-d3ce5a2744cb"), true, "Вид", 1, new Guid("88cdc459-bfff-4549-b0c3-2fd1d04ac358"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("9767cdf2-235c-43eb-91f2-e9ccdb0d6639"), true, "Статус конкурса", 3, new Guid("740fb31b-3dd5-4083-875f-68d70a0d40d8"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("a3511a48-e17d-4fcd-9393-9301396cbfca"), true, "Название", 1, new Guid("96143ff1-e724-4290-b28e-6cd9afa4dd1d"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("a37eeedc-9e80-4b64-afa9-488fb62fd93c"), true, "Вид (лекции, лабораторные)", 2, new Guid("08a6af70-0673-4046-9260-26c0e7228df7"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("a3c564b8-4434-4999-b6c1-caf237ceb8fa"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("1816654e-ceaa-4724-a550-dd3725794d41"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("a42d03fd-c65f-4798-850d-f76791e44caf"), true, "Издательство, год", 6, new Guid("9a095aa7-b6e6-460d-a37a-93b32d165713"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("aa513860-db8e-4f39-ba50-e5697547353a"), true, "Практические занятия (час.)", 4, new Guid("0861098b-fa0b-4532-9880-b0d907f6268b"), new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("ae120d73-4c11-4a27-be3a-d43b6ed38597"), true, "Наличие грифа", 5, new Guid("9a095aa7-b6e6-460d-a37a-93b32d165713"), new Guid("60b3d355-d660-4f61-b64b-193f97bf0279") },
                    { new Guid("ae92e203-5851-4075-9261-864d6dcdd632"), true, "Название разработки", 2, new Guid("88cdc459-bfff-4549-b0c3-2fd1d04ac358"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("bcb6289b-3d7a-463b-bebf-7a74b45985fe"), true, "Вид деятельности (преподавательская)", 3, new Guid("efb87940-9025-4ef0-884e-b07e5ba323c7"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("c174bd5e-5741-4fa5-813e-5a25fe48ef1e"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("08a6af70-0673-4046-9260-26c0e7228df7"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("c60150d4-badb-4da2-b6e2-a3a6c2cd433f"), true, "Название организации/должность/ставка", 1, new Guid("efb87940-9025-4ef0-884e-b07e5ba323c7"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("cdcbdfaf-6813-48ed-877d-36875bbf957e"), false, "Тип идентификатора", 1, new Guid("d233f740-8097-4dfc-8ffa-c88dc518b521"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("ce2119a2-c711-4942-bfa2-adad8838d5e7"), true, "ФИО", 1, new Guid("0b872eb2-8a52-4ca1-af26-db9b41667128"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("d5bc883f-8f2a-4914-8007-8c2d08b6b634"), true, "Название конкурса/премии", 2, new Guid("0b872eb2-8a52-4ca1-af26-db9b41667128"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("d792058b-6de9-4814-8dfe-d71e00ba9514"), true, "Лекции (час.)", 3, new Guid("0861098b-fa0b-4532-9880-b0d907f6268b"), new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("da552583-3d7d-4a3c-9fac-9a96239b3cf3"), false, "Идентификатор", 2, new Guid("d233f740-8097-4dfc-8ffa-c88dc518b521"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("db3188ef-8c7c-4c0b-a136-399e6808fd59"), true, "Название НИР/НИОКР", 1, new Guid("4fee1a60-b468-4399-a6e0-af098342aed2"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("e00edaec-16fd-4402-a553-272b49d477b8"), true, "Название статьи", 1, new Guid("1816654e-ceaa-4724-a550-dd3725794d41"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("e9b210dd-354b-4cd1-82f3-2adf40e003c3"), true, "Название", 2, new Guid("9a095aa7-b6e6-460d-a37a-93b32d165713"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("eece0062-6915-476e-b6bc-28b68d9183a2"), true, "Язык публикации", 7, new Guid("9a095aa7-b6e6-460d-a37a-93b32d165713"), new Guid("b9ceb364-b12c-4147-ba21-381f81bf6d11") },
                    { new Guid("ef7bb40f-21d4-48ae-8282-ed63a459d9c5"), true, "Название документа, реквизиты", 1, new Guid("1d7806d2-6ceb-4a8b-b1ba-51f462256f4e"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") },
                    { new Guid("effbfc76-94fb-47e7-ade0-8b99051a6696"), true, "Название конкурса", 2, new Guid("740fb31b-3dd5-4083-875f-68d70a0d40d8"), new Guid("e5a7be3d-0a6d-4193-8df8-6b1e7edbc6eb") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("20948ddc-ceb5-4a94-a061-b945653efdad"), new Guid("b4942f11-d20d-463d-b190-d3554179239b") },
                    { new Guid("22f84944-f547-4426-8581-10316e1fe684"), new Guid("b4942f11-d20d-463d-b190-d3554179239b") },
                    { new Guid("2f8d2484-8325-466c-b59c-b1a9244d4e2e"), new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6") },
                    { new Guid("3b041356-b886-442f-81ae-a9f259941685"), new Guid("b4942f11-d20d-463d-b190-d3554179239b") },
                    { new Guid("44a3ce53-9e9f-49d8-bd5c-ddc4ef4c170a"), new Guid("b4942f11-d20d-463d-b190-d3554179239b") },
                    { new Guid("4d0a6b67-30d4-4f95-9e7e-e57e9df61b90"), new Guid("b4942f11-d20d-463d-b190-d3554179239b") },
                    { new Guid("661695d0-707f-462a-b63c-8dcf5ad23dd2"), new Guid("b4942f11-d20d-463d-b190-d3554179239b") },
                    { new Guid("8b9095b4-2cdf-4586-a452-c29373037521"), new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac") },
                    { new Guid("90b743bf-c333-44ee-9192-d7644c86fb64"), new Guid("b4942f11-d20d-463d-b190-d3554179239b") },
                    { new Guid("9136520d-aa85-4f9c-8e5b-7ffc2ee08ac2"), new Guid("b4942f11-d20d-463d-b190-d3554179239b") },
                    { new Guid("92701b78-dd5c-4c46-bd20-5cd4edb9c768"), new Guid("b4942f11-d20d-463d-b190-d3554179239b") },
                    { new Guid("97b38f30-1d02-4f9e-971d-2009539f58a4"), new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6") },
                    { new Guid("9801c728-715d-4480-afcd-3b1347f093d5"), new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6") },
                    { new Guid("a0750fb2-09c4-4901-affc-dddac5f0a27f"), new Guid("b4942f11-d20d-463d-b190-d3554179239b") },
                    { new Guid("a5dd011a-3f16-4f02-be72-2ad782449968"), new Guid("b4942f11-d20d-463d-b190-d3554179239b") },
                    { new Guid("a5dd011a-3f16-4f02-be72-2ad782449968"), new Guid("ba8d3001-e9c9-415a-81ea-530fa885e059") },
                    { new Guid("a5dd011a-3f16-4f02-be72-2ad782449968"), new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac") },
                    { new Guid("b047af38-2820-4dda-bcda-1750c42d1fbb"), new Guid("b4942f11-d20d-463d-b190-d3554179239b") },
                    { new Guid("c94b5a85-82e7-4c38-abcb-aafb76aef471"), new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac") },
                    { new Guid("d66ae91e-84c1-4493-a8ee-bef8ecc1ec33"), new Guid("b4942f11-d20d-463d-b190-d3554179239b") },
                    { new Guid("f29dd457-b804-41ee-b246-638b7e042921"), new Guid("b4942f11-d20d-463d-b190-d3554179239b") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("15e717d1-f179-44d0-91c1-e924aa383eac"), new Guid("08a6af70-0673-4046-9260-26c0e7228df7") },
                    { new Guid("15e717d1-f179-44d0-91c1-e924aa383eac"), new Guid("9a095aa7-b6e6-460d-a37a-93b32d165713") },
                    { new Guid("ba8d3001-e9c9-415a-81ea-530fa885e059"), new Guid("1d7806d2-6ceb-4a8b-b1ba-51f462256f4e") },
                    { new Guid("ba8d3001-e9c9-415a-81ea-530fa885e059"), new Guid("740fb31b-3dd5-4083-875f-68d70a0d40d8") },
                    { new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6"), new Guid("0861098b-fa0b-4532-9880-b0d907f6268b") },
                    { new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6"), new Guid("0b872eb2-8a52-4ca1-af26-db9b41667128") },
                    { new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6"), new Guid("b7895997-687b-4792-a362-9b8048154f0e") },
                    { new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6"), new Guid("efb87940-9025-4ef0-884e-b07e5ba323c7") },
                    { new Guid("ddb1a07a-bc76-433f-be23-e29be7b7112d"), new Guid("1d7806d2-6ceb-4a8b-b1ba-51f462256f4e") },
                    { new Guid("ddb1a07a-bc76-433f-be23-e29be7b7112d"), new Guid("4b0c0176-59f8-4034-8cc3-e57cdaac20cc") },
                    { new Guid("ddb1a07a-bc76-433f-be23-e29be7b7112d"), new Guid("88cdc459-bfff-4549-b0c3-2fd1d04ac358") },
                    { new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac"), new Guid("1816654e-ceaa-4724-a550-dd3725794d41") },
                    { new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac"), new Guid("4fee1a60-b468-4399-a6e0-af098342aed2") },
                    { new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac"), new Guid("740fb31b-3dd5-4083-875f-68d70a0d40d8") },
                    { new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac"), new Guid("d233f740-8097-4dfc-8ffa-c88dc518b521") },
                    { new Guid("fcee23d9-5155-4412-8ae7-da45187ac603"), new Guid("96143ff1-e724-4290-b28e-6cd9afa4dd1d") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0313cada-818b-412a-b592-d6a12cf37b57"), "EvaluateMark3", new Guid("2f8d2484-8325-466c-b59c-b1a9244d4e2e"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("0db6cbc2-fb54-4192-a88c-230846f9dfad"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("88cdc459-bfff-4549-b0c3-2fd1d04ac358") },
                    { new Guid("1fe12f68-c19d-4296-9f32-627bf317989f"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("0b872eb2-8a52-4ca1-af26-db9b41667128") },
                    { new Guid("2e45397a-eccf-4ab5-a6a0-1d6fd512f1f2"), null, null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("96143ff1-e724-4290-b28e-6cd9afa4dd1d") },
                    { new Guid("34c1b0ef-0ac9-4ee1-8e90-39e6e5868c3d"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("9a095aa7-b6e6-460d-a37a-93b32d165713") },
                    { new Guid("35a4359e-a34f-4b1b-9dc4-65732f874564"), "EvaluateMark5", new Guid("97b38f30-1d02-4f9e-971d-2009539f58a4"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("4fe87c9d-08c2-434e-b922-d9d0adb76812"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("0861098b-fa0b-4532-9880-b0d907f6268b") },
                    { new Guid("51b5f555-2f00-465f-9af5-8731021cc397"), "EvaluateMark19", new Guid("8b9095b4-2cdf-4586-a452-c29373037521"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("57dd6484-6fca-4101-8c86-6037aecad79c"), null, null, false, 10, "Оценка уровня предоставленной работы:", 25, new Guid("96143ff1-e724-4290-b28e-6cd9afa4dd1d") },
                    { new Guid("5f88246c-4b96-4a96-93b0-140d49bfe31b"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("9a095aa7-b6e6-460d-a37a-93b32d165713") },
                    { new Guid("61d2b720-93c3-4f02-b855-904bafbd7302"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("4fee1a60-b468-4399-a6e0-af098342aed2") },
                    { new Guid("64ce9d34-4fbf-425b-9890-d70a493e3c39"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("b7895997-687b-4792-a362-9b8048154f0e") },
                    { new Guid("6910a0d3-6c97-4ba4-bb60-31145c6d096c"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("740fb31b-3dd5-4083-875f-68d70a0d40d8") },
                    { new Guid("6baa4feb-1b6b-457f-80f9-b33d98617804"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("4fee1a60-b468-4399-a6e0-af098342aed2") },
                    { new Guid("71e5f084-0335-45ae-9809-f3b111a71ee9"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("08a6af70-0673-4046-9260-26c0e7228df7") },
                    { new Guid("72d9fc34-9d93-4e62-ad68-d2c0309b6569"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("9a095aa7-b6e6-460d-a37a-93b32d165713") },
                    { new Guid("74fc4f2e-e4c3-4401-9b2e-83e911ddc0db"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("0861098b-fa0b-4532-9880-b0d907f6268b") },
                    { new Guid("8b0e4ed1-6e50-406b-aad3-449acc0af49f"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("4b0c0176-59f8-4034-8cc3-e57cdaac20cc") },
                    { new Guid("940380c2-55c9-40d5-96de-aee296535b94"), "EvaluateMark13", new Guid("a5dd011a-3f16-4f02-be72-2ad782449968"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("a014dfc2-888c-4fc6-8e13-03002a093117"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("1816654e-ceaa-4724-a550-dd3725794d41") },
                    { new Guid("c9e551ba-9e83-4f9b-b2de-e6fdb48ea69e"), "EvaluateMark4", new Guid("9801c728-715d-4480-afcd-3b1347f093d5"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("cfd109da-7f2f-4821-a61a-f65a08677221"), "EvaluateMark20", new Guid("c94b5a85-82e7-4c38-abcb-aafb76aef471"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("d006b440-6e68-4cfd-b805-3d72aed23edb"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("9a095aa7-b6e6-460d-a37a-93b32d165713") },
                    { new Guid("eab29e03-b0b2-4b04-9106-47b9d6b3e96c"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("1d7806d2-6ceb-4a8b-b1ba-51f462256f4e") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("01a9ab91-6fe4-4747-a3ff-8ef923e1df71"), true, new Guid("d233f740-8097-4dfc-8ffa-c88dc518b521") },
                    { new Guid("06d7203a-fae9-4223-8e89-b080cd0e06b8"), true, new Guid("96143ff1-e724-4290-b28e-6cd9afa4dd1d") },
                    { new Guid("08ecb284-e85d-40f1-9238-215d079d2cdc"), true, new Guid("96143ff1-e724-4290-b28e-6cd9afa4dd1d") },
                    { new Guid("175f1ba2-cdea-4ee7-9acc-1773e8aaf9f4"), true, new Guid("96143ff1-e724-4290-b28e-6cd9afa4dd1d") },
                    { new Guid("389b3b26-4f92-4fa2-ac47-0ba3cb86d82f"), true, new Guid("d233f740-8097-4dfc-8ffa-c88dc518b521") },
                    { new Guid("3df89dcc-86ac-439a-a1ea-34239e1242ec"), true, new Guid("96143ff1-e724-4290-b28e-6cd9afa4dd1d") },
                    { new Guid("5fc3dd70-c2f8-4c58-8cf7-bf1cf43b412c"), true, new Guid("d233f740-8097-4dfc-8ffa-c88dc518b521") },
                    { new Guid("82b7ec84-2bde-4fc9-897c-b7acc9f67f9d"), true, new Guid("96143ff1-e724-4290-b28e-6cd9afa4dd1d") },
                    { new Guid("902ec2ed-d57a-46ac-ba04-91eb28c2225e"), true, new Guid("d233f740-8097-4dfc-8ffa-c88dc518b521") },
                    { new Guid("9633fbc6-c7d0-47fe-9c98-b157206e1a3a"), true, new Guid("d233f740-8097-4dfc-8ffa-c88dc518b521") },
                    { new Guid("9c0bcd31-3fef-45ea-9404-c397a23b9d3e"), true, new Guid("96143ff1-e724-4290-b28e-6cd9afa4dd1d") },
                    { new Guid("e21c5791-147c-4907-9ee9-557a4d902d30"), true, new Guid("96143ff1-e724-4290-b28e-6cd9afa4dd1d") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("501b9e47-6be6-4e70-9688-4a5b20f3e6ce"), null, new Guid("b047af38-2820-4dda-bcda-1750c42d1fbb"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("51cca623-7852-4341-af80-75e9aa01ba57"), null, new Guid("a5dd011a-3f16-4f02-be72-2ad782449968"), "Нет" },
                    { new Guid("a887c84d-0d04-4298-bb32-b4fa1e468e3d"), null, new Guid("a5dd011a-3f16-4f02-be72-2ad782449968"), "Доцент" },
                    { new Guid("ad28f7ae-a9c5-437f-9910-e21f0a54662f"), null, new Guid("b047af38-2820-4dda-bcda-1750c42d1fbb"), "Имеющие ученую степень доктора наук" },
                    { new Guid("af388352-a1ef-4d5e-b30c-3ed6503c2423"), null, new Guid("a5dd011a-3f16-4f02-be72-2ad782449968"), "Профессор" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("1da060d0-189e-417b-aea1-c0d4d1b0a375"), null, new Guid("a3511a48-e17d-4fcd-9393-9301396cbfca"), true, true, new Guid("175f1ba2-cdea-4ee7-9acc-1773e8aaf9f4"), "Методология и методы, используемые в работе" },
                    { new Guid("22f0d04e-dc52-4a7c-9e36-0c1ff9cc1257"), null, new Guid("47adef9c-2ed9-4ad2-a7e1-a4a42e98089c"), false, true, new Guid("06d7203a-fae9-4223-8e89-b080cd0e06b8"), null },
                    { new Guid("3516d387-8823-401d-bb1c-5b1665f897d6"), null, new Guid("cdcbdfaf-6813-48ed-877d-36875bbf957e"), true, true, new Guid("902ec2ed-d57a-46ac-ba04-91eb28c2225e"), "РИНЦ AuthorID" },
                    { new Guid("3519ff58-9c5d-4af0-bea3-248fc2fdbcad"), null, new Guid("a3511a48-e17d-4fcd-9393-9301396cbfca"), true, true, new Guid("08ecb284-e85d-40f1-9238-215d079d2cdc"), "Актуальность конкурсной работы" },
                    { new Guid("3ba70bc7-4410-49a6-b7b9-c464d886db85"), null, new Guid("a3511a48-e17d-4fcd-9393-9301396cbfca"), true, true, new Guid("82b7ec84-2bde-4fc9-897c-b7acc9f67f9d"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("4a004ca2-0254-4cb6-845c-3815b152ff43"), null, new Guid("a3511a48-e17d-4fcd-9393-9301396cbfca"), true, true, new Guid("e21c5791-147c-4907-9ee9-557a4d902d30"), "Результаты и выводы" },
                    { new Guid("5252672e-ef8a-4936-90a6-e0ac3b66c9a2"), null, new Guid("cdcbdfaf-6813-48ed-877d-36875bbf957e"), true, true, new Guid("5fc3dd70-c2f8-4c58-8cf7-bf1cf43b412c"), "ResearcherID" },
                    { new Guid("638d05ac-f5b0-43d2-bc4a-b8e6ee64cc29"), null, new Guid("cdcbdfaf-6813-48ed-877d-36875bbf957e"), true, true, new Guid("389b3b26-4f92-4fa2-ac47-0ba3cb86d82f"), "ORCiD" },
                    { new Guid("672362fb-fca7-46da-9b85-b72cc92f44f1"), null, new Guid("47adef9c-2ed9-4ad2-a7e1-a4a42e98089c"), false, true, new Guid("82b7ec84-2bde-4fc9-897c-b7acc9f67f9d"), null },
                    { new Guid("6b6f0f6a-d967-4142-9c30-f6a851bd3a66"), null, new Guid("da552583-3d7d-4a3c-9fac-9a96239b3cf3"), false, true, new Guid("5fc3dd70-c2f8-4c58-8cf7-bf1cf43b412c"), null },
                    { new Guid("6bce6c11-ce72-4928-b7f3-1c479fb24cde"), null, new Guid("da552583-3d7d-4a3c-9fac-9a96239b3cf3"), false, true, new Guid("01a9ab91-6fe4-4747-a3ff-8ef923e1df71"), null },
                    { new Guid("6e33b28b-3dfe-4fe4-b713-f7438affd5fe"), null, new Guid("47adef9c-2ed9-4ad2-a7e1-a4a42e98089c"), false, true, new Guid("9c0bcd31-3fef-45ea-9404-c397a23b9d3e"), null },
                    { new Guid("81b1e0f0-8cd2-4c8a-85c9-4dc7a82f88e5"), null, new Guid("cdcbdfaf-6813-48ed-877d-36875bbf957e"), true, true, new Guid("9633fbc6-c7d0-47fe-9c98-b157206e1a3a"), "Google Scholar ID" },
                    { new Guid("8ea55a92-8c2a-4ed7-aba3-2c667928dd26"), null, new Guid("da552583-3d7d-4a3c-9fac-9a96239b3cf3"), false, true, new Guid("902ec2ed-d57a-46ac-ba04-91eb28c2225e"), null },
                    { new Guid("98e6567d-8218-48fd-8d10-08de24243fd0"), null, new Guid("cdcbdfaf-6813-48ed-877d-36875bbf957e"), true, true, new Guid("01a9ab91-6fe4-4747-a3ff-8ef923e1df71"), "ScopusID" },
                    { new Guid("9c215836-b208-44cf-97df-a6c4fef47d6a"), null, new Guid("da552583-3d7d-4a3c-9fac-9a96239b3cf3"), false, true, new Guid("9633fbc6-c7d0-47fe-9c98-b157206e1a3a"), null },
                    { new Guid("a748097a-f06f-46c9-9eed-b47c386cc3d0"), null, new Guid("a3511a48-e17d-4fcd-9393-9301396cbfca"), true, true, new Guid("9c0bcd31-3fef-45ea-9404-c397a23b9d3e"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("b838d7f5-f074-4f2a-b3b0-2f6e8c1da9bf"), null, new Guid("47adef9c-2ed9-4ad2-a7e1-a4a42e98089c"), false, true, new Guid("e21c5791-147c-4907-9ee9-557a4d902d30"), null },
                    { new Guid("baaf4258-ec28-4f0f-8dd5-a0deb70b1445"), null, new Guid("a3511a48-e17d-4fcd-9393-9301396cbfca"), true, true, new Guid("06d7203a-fae9-4223-8e89-b080cd0e06b8"), "Инновационность" },
                    { new Guid("bcac04c9-8009-49f0-8d10-4f5bcdb66c97"), null, new Guid("da552583-3d7d-4a3c-9fac-9a96239b3cf3"), false, true, new Guid("389b3b26-4f92-4fa2-ac47-0ba3cb86d82f"), null },
                    { new Guid("bd9876ad-3064-42bf-b376-ae96f233e4e1"), null, new Guid("a3511a48-e17d-4fcd-9393-9301396cbfca"), true, true, new Guid("3df89dcc-86ac-439a-a1ea-34239e1242ec"), "Название работы" },
                    { new Guid("d85157a4-36a1-44a6-94d3-1f96c6f94a75"), null, new Guid("47adef9c-2ed9-4ad2-a7e1-a4a42e98089c"), false, true, new Guid("175f1ba2-cdea-4ee7-9acc-1773e8aaf9f4"), null },
                    { new Guid("eb659c29-9f36-4c5d-ae9a-87167341345b"), null, new Guid("47adef9c-2ed9-4ad2-a7e1-a4a42e98089c"), false, true, new Guid("08ecb284-e85d-40f1-9238-215d079d2cdc"), null },
                    { new Guid("f98c22e8-dbe0-48b2-956d-cd657ef5ec71"), null, new Guid("47adef9c-2ed9-4ad2-a7e1-a4a42e98089c"), false, true, new Guid("3df89dcc-86ac-439a-a1ea-34239e1242ec"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("15e717d1-f179-44d0-91c1-e924aa383eac"), new Guid("34c1b0ef-0ac9-4ee1-8e90-39e6e5868c3d") },
                    { new Guid("15e717d1-f179-44d0-91c1-e924aa383eac"), new Guid("5f88246c-4b96-4a96-93b0-140d49bfe31b") },
                    { new Guid("15e717d1-f179-44d0-91c1-e924aa383eac"), new Guid("71e5f084-0335-45ae-9809-f3b111a71ee9") },
                    { new Guid("15e717d1-f179-44d0-91c1-e924aa383eac"), new Guid("72d9fc34-9d93-4e62-ad68-d2c0309b6569") },
                    { new Guid("15e717d1-f179-44d0-91c1-e924aa383eac"), new Guid("d006b440-6e68-4cfd-b805-3d72aed23edb") },
                    { new Guid("ba8d3001-e9c9-415a-81ea-530fa885e059"), new Guid("6910a0d3-6c97-4ba4-bb60-31145c6d096c") },
                    { new Guid("ba8d3001-e9c9-415a-81ea-530fa885e059"), new Guid("940380c2-55c9-40d5-96de-aee296535b94") },
                    { new Guid("ba8d3001-e9c9-415a-81ea-530fa885e059"), new Guid("eab29e03-b0b2-4b04-9106-47b9d6b3e96c") },
                    { new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6"), new Guid("0313cada-818b-412a-b592-d6a12cf37b57") },
                    { new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6"), new Guid("1fe12f68-c19d-4296-9f32-627bf317989f") },
                    { new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6"), new Guid("35a4359e-a34f-4b1b-9dc4-65732f874564") },
                    { new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6"), new Guid("4fe87c9d-08c2-434e-b922-d9d0adb76812") },
                    { new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6"), new Guid("64ce9d34-4fbf-425b-9890-d70a493e3c39") },
                    { new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6"), new Guid("74fc4f2e-e4c3-4401-9b2e-83e911ddc0db") },
                    { new Guid("cdc74695-ad7d-4fdf-a7b3-ff60d20ed1b6"), new Guid("c9e551ba-9e83-4f9b-b2de-e6fdb48ea69e") },
                    { new Guid("ddb1a07a-bc76-433f-be23-e29be7b7112d"), new Guid("0db6cbc2-fb54-4192-a88c-230846f9dfad") },
                    { new Guid("ddb1a07a-bc76-433f-be23-e29be7b7112d"), new Guid("8b0e4ed1-6e50-406b-aad3-449acc0af49f") },
                    { new Guid("ddb1a07a-bc76-433f-be23-e29be7b7112d"), new Guid("eab29e03-b0b2-4b04-9106-47b9d6b3e96c") },
                    { new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac"), new Guid("51b5f555-2f00-465f-9af5-8731021cc397") },
                    { new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac"), new Guid("61d2b720-93c3-4f02-b855-904bafbd7302") },
                    { new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac"), new Guid("6910a0d3-6c97-4ba4-bb60-31145c6d096c") },
                    { new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac"), new Guid("6baa4feb-1b6b-457f-80f9-b33d98617804") },
                    { new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac"), new Guid("940380c2-55c9-40d5-96de-aee296535b94") },
                    { new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac"), new Guid("a014dfc2-888c-4fc6-8e13-03002a093117") },
                    { new Guid("df27bbd5-feb5-4e74-9710-c7e5adf3acac"), new Guid("cfd109da-7f2f-4821-a61a-f65a08677221") },
                    { new Guid("fcee23d9-5155-4412-8ae7-da45187ac603"), new Guid("2e45397a-eccf-4ab5-a6a0-1d6fd512f1f2") },
                    { new Guid("fcee23d9-5155-4412-8ae7-da45187ac603"), new Guid("57dd6484-6fca-4101-8c86-6037aecad79c") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("005c0222-1ed3-4e0c-aebf-27e419a4199f"), new Guid("8cb776be-fb61-45bb-b0e2-d3ce5a2744cb"), null, "База данных" },
                    { new Guid("0a845f1d-d498-473c-8aea-19440b157c6e"), new Guid("8cb776be-fb61-45bb-b0e2-d3ce5a2744cb"), null, "Изобретение" },
                    { new Guid("10ffcfdb-8479-4628-9186-64d9509b37e1"), new Guid("8cb776be-fb61-45bb-b0e2-d3ce5a2744cb"), null, "Полезная модель" },
                    { new Guid("1fc3da21-361f-4182-b1da-376547323610"), new Guid("9767cdf2-235c-43eb-91f2-e9ccdb0d6639"), null, "Международный" },
                    { new Guid("20ad3bc7-05e9-4d62-82db-0c018b963c5c"), new Guid("4062e4e9-d7d7-4231-96b0-8838319070b2"), null, "Исполнитель" },
                    { new Guid("43e21c8c-83cf-4839-8df9-2bf4bc04fa26"), new Guid("9767cdf2-235c-43eb-91f2-e9ccdb0d6639"), null, "Всероссийский" },
                    { new Guid("5ae0b184-cf6d-4b4d-ac5a-fce9d3bc1183"), new Guid("a37eeedc-9e80-4b64-afa9-488fb62fd93c"), null, "Лабораторные" },
                    { new Guid("65f82561-b734-4614-9ca5-491255b02b22"), new Guid("9767cdf2-235c-43eb-91f2-e9ccdb0d6639"), null, "Региональный" },
                    { new Guid("737d89e3-b2e3-4eaf-80b1-aae370b5802f"), new Guid("161f60d6-0fa1-4c79-afeb-77d2d7ce8500"), null, "Нет" },
                    { new Guid("7ba20932-3e5f-4649-b2cf-8ded03318e4e"), new Guid("72ef5613-fa0a-462e-b85c-7ed57fa88b12"), null, "Учебник" },
                    { new Guid("7c335ac6-4456-4922-83db-1b22084c2db7"), new Guid("eece0062-6915-476e-b6bc-28b68d9183a2"), null, "Иностранный" },
                    { new Guid("7ccce403-46fd-4a62-819e-2b114d5a0e99"), new Guid("51006453-d222-46e0-bd58-79aa18f59b41"), null, "Полезная модель" },
                    { new Guid("b07b2a49-b065-48ff-aec3-b2711f002c19"), new Guid("eece0062-6915-476e-b6bc-28b68d9183a2"), null, "Русский" },
                    { new Guid("b1021213-a8aa-432c-b5e4-a5b28940d332"), new Guid("4062e4e9-d7d7-4231-96b0-8838319070b2"), null, "Руководитель" },
                    { new Guid("c3fd712b-db88-44ee-9d99-203ba05d6009"), new Guid("51006453-d222-46e0-bd58-79aa18f59b41"), null, "База данных" },
                    { new Guid("ddb20149-826a-473f-bdec-5d1e34523378"), new Guid("72ef5613-fa0a-462e-b85c-7ed57fa88b12"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("e37c454d-75da-4500-a142-559a528e178d"), new Guid("51006453-d222-46e0-bd58-79aa18f59b41"), null, "Изобретение" },
                    { new Guid("e6ba8ce6-24e4-4fb6-aefe-3f437f555766"), new Guid("a37eeedc-9e80-4b64-afa9-488fb62fd93c"), null, "Лекции" },
                    { new Guid("fa71c2f0-ffbb-47e6-95d6-ee7a01a02a69"), new Guid("161f60d6-0fa1-4c79-afeb-77d2d7ce8500"), null, "Да" },
                    { new Guid("ff333572-18ec-4834-9b0a-096b3963258a"), new Guid("72ef5613-fa0a-462e-b85c-7ed57fa88b12"), null, "Монография" }
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
