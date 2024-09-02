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
                    { new Guid("16bf4634-c2db-42b2-b030-7f87dbe35a4b"), 1, "В ожидании заполнения" },
                    { new Guid("3e24c349-5d4c-4b6f-bf03-3f506502990e"), 4, "Одобрена" },
                    { new Guid("7376ca79-e3e4-4757-903a-588ebd6f9f53"), 5, "Отклонена" },
                    { new Guid("785ed1d3-eebf-4c26-bb31-059d4391e423"), 2, "В ожидании рассмотрения" },
                    { new Guid("78e29f30-2b9b-4e7b-981d-5a8cabb04e96"), 6, "Оценена" },
                    { new Guid("b235602f-ac21-466f-85b4-a52c5f3d5712"), 3, "В процессе рассмотрения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1508130a-5f51-4385-b3cf-09d00ff0aa56", null, "Organiser", "ORGANISER" },
                    { "1a26c783-ee4e-4fa2-80ac-402122dab879", null, "Participant", "PARTICIPANT" },
                    { "682c307d-6ea7-4c08-9ef9-19b1dadb91da", null, "Admin", "ADMIN" },
                    { "6b798d8a-044c-4881-af61-bd5d4e4fdd55", null, "Voter", "VOTER" },
                    { "c264836d-cb5e-4392-9d05-a47de8fd6b0b", null, "Expert", "EXPERT" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("ea781c6b-441d-4ac6-8501-6d58089e0317"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("fdf2cccc-44a7-4235-b5ca-3f29d30c28cb"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("65b1e836-6225-45d0-98bf-fae2fa414aeb"), "Категория участников", 2 },
                    { new Guid("7a84b636-4327-4c39-851e-1258f7149167"), "Деятельность", 4 },
                    { new Guid("a8046683-88f1-441f-a68e-c39f9090fe32"), "Деятельность", 5 },
                    { new Guid("b41a4320-f52b-4c9f-ada2-a42ae0b14db8"), "Профессиональное развитие", 3 },
                    { new Guid("d18547cf-8f6f-421b-8c34-2376d7625a3d"), "Общая информация", 1 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("2d609b7c-6855-4d5e-a7fb-fb485fa4dc98"), "Методическая деятельность", 3 },
                    { new Guid("44b539cc-5665-4c6a-88f1-4a26d17fc15f"), "Конкурсная работа", 7 },
                    { new Guid("9c51a23e-9ac5-4a5d-8134-4e6488027358"), "Профессиональные показатели", 4 },
                    { new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931"), "Образовательная деятельность", 2 },
                    { new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946"), "Основной", 1 },
                    { new Guid("e03fad0f-4c07-4b08-92ad-a14bcc7c75d4"), "Инновационная и иная деятельность", 6 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("92a55c26-bd17-4cfd-9049-959d9831b22f"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("a5c144b0-6d69-4504-9b7a-253c31569089"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd"), "int" },
                    { new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f"), "string" },
                    { new Guid("6fce3ccd-06cb-4b46-9951-fbe245aa0b4b"), "bool" },
                    { new Guid("c39985f6-86c4-49f5-ac6f-e8e8d41430a1"), "DateTime" },
                    { new Guid("db4e477b-cb9c-4edb-88ba-2bcfe319f860"), "TextArea" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("65b1e836-6225-45d0-98bf-fae2fa414aeb"), new Guid("92a55c26-bd17-4cfd-9049-959d9831b22f") },
                    { new Guid("65b1e836-6225-45d0-98bf-fae2fa414aeb"), new Guid("a5c144b0-6d69-4504-9b7a-253c31569089") },
                    { new Guid("7a84b636-4327-4c39-851e-1258f7149167"), new Guid("92a55c26-bd17-4cfd-9049-959d9831b22f") },
                    { new Guid("a8046683-88f1-441f-a68e-c39f9090fe32"), new Guid("a5c144b0-6d69-4504-9b7a-253c31569089") },
                    { new Guid("b41a4320-f52b-4c9f-ada2-a42ae0b14db8"), new Guid("92a55c26-bd17-4cfd-9049-959d9831b22f") },
                    { new Guid("b41a4320-f52b-4c9f-ada2-a42ae0b14db8"), new Guid("a5c144b0-6d69-4504-9b7a-253c31569089") },
                    { new Guid("d18547cf-8f6f-421b-8c34-2376d7625a3d"), new Guid("92a55c26-bd17-4cfd-9049-959d9831b22f") },
                    { new Guid("d18547cf-8f6f-421b-8c34-2376d7625a3d"), new Guid("a5c144b0-6d69-4504-9b7a-253c31569089") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("14fbb388-dac0-45a1-a658-42a1b8c2c592"), new Guid("d18547cf-8f6f-421b-8c34-2376d7625a3d"), null, true, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("20745819-ddcf-4426-aa8c-0e97a8073432"), new Guid("d18547cf-8f6f-421b-8c34-2376d7625a3d"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("2397ba4e-1f9d-40b8-b20b-caa5c826f998"), new Guid("65b1e836-6225-45d0-98bf-fae2fa414aeb"), null, true, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("288e5044-5d10-477f-b19d-f828e2f74cfd"), new Guid("d18547cf-8f6f-421b-8c34-2376d7625a3d"), null, false, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("2addba9d-337f-4feb-8954-561d2d04bbdf"), new Guid("7a84b636-4327-4c39-851e-1258f7149167"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("321a128f-576c-4e82-91d3-ce8327a225bf"), new Guid("a8046683-88f1-441f-a68e-c39f9090fe32"), null, false, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("33dcad3c-c746-46d1-aac8-265edb286e65"), new Guid("65b1e836-6225-45d0-98bf-fae2fa414aeb"), null, true, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("43591779-e109-4d5d-a32d-c192ce494f91"), new Guid("d18547cf-8f6f-421b-8c34-2376d7625a3d"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("4a7e1b72-2143-442a-82a9-f4c480e76f0d"), new Guid("d18547cf-8f6f-421b-8c34-2376d7625a3d"), null, true, true, "Место работы/учебы", 6, "Название организации", new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("667a5fe9-f7a7-4bea-9b0a-a4af46df7c51"), new Guid("7a84b636-4327-4c39-851e-1258f7149167"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("781ff860-3103-402e-9626-6e4a33ff72f2"), new Guid("d18547cf-8f6f-421b-8c34-2376d7625a3d"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("c39985f6-86c4-49f5-ac6f-e8e8d41430a1") },
                    { new Guid("8aaebaac-ec31-4e30-a2a0-213d6c665f7c"), new Guid("65b1e836-6225-45d0-98bf-fae2fa414aeb"), null, false, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("a0b6a59e-c476-46dc-88c3-c2eed537c852"), new Guid("d18547cf-8f6f-421b-8c34-2376d7625a3d"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("d00428b6-2676-4ca1-bc78-53334e74d475"), new Guid("a8046683-88f1-441f-a68e-c39f9090fe32"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("db94d2d4-3bc7-4fdc-8687-49ff8110514e"), new Guid("d18547cf-8f6f-421b-8c34-2376d7625a3d"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("e8d4c912-afcf-42db-835e-0a5796d13c82"), new Guid("7a84b636-4327-4c39-851e-1258f7149167"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("e9b5433f-0212-45a7-adee-1184ed374fd3"), new Guid("65b1e836-6225-45d0-98bf-fae2fa414aeb"), null, false, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("eb2713d1-7c99-45d9-914d-1566cff0c69b"), new Guid("d18547cf-8f6f-421b-8c34-2376d7625a3d"), null, false, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("f3acc764-27d9-47c8-9912-8e4743e0cb9c"), new Guid("d18547cf-8f6f-421b-8c34-2376d7625a3d"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda"), new Guid("a5c144b0-6d69-4504-9b7a-253c31569089") },
                    { new Guid("2d609b7c-6855-4d5e-a7fb-fb485fa4dc98"), new Guid("92a55c26-bd17-4cfd-9049-959d9831b22f") },
                    { new Guid("44b539cc-5665-4c6a-88f1-4a26d17fc15f"), new Guid("92a55c26-bd17-4cfd-9049-959d9831b22f") },
                    { new Guid("44b539cc-5665-4c6a-88f1-4a26d17fc15f"), new Guid("a5c144b0-6d69-4504-9b7a-253c31569089") },
                    { new Guid("9c51a23e-9ac5-4a5d-8134-4e6488027358"), new Guid("92a55c26-bd17-4cfd-9049-959d9831b22f") },
                    { new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931"), new Guid("92a55c26-bd17-4cfd-9049-959d9831b22f") },
                    { new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946"), new Guid("92a55c26-bd17-4cfd-9049-959d9831b22f") },
                    { new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946"), new Guid("a5c144b0-6d69-4504-9b7a-253c31569089") },
                    { new Guid("e03fad0f-4c07-4b08-92ad-a14bcc7c75d4"), new Guid("a5c144b0-6d69-4504-9b7a-253c31569089") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0489818b-a189-4670-934b-d373d37be979"), new Guid("a8046683-88f1-441f-a68e-c39f9090fe32"), true, true, "Персональные идентификаторы", 10 },
                    { new Guid("04e46bb3-964f-4e25-903f-07bed1af7c69"), new Guid("a8046683-88f1-441f-a68e-c39f9090fe32"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("0658ac3a-6678-476c-bb58-c4a531fc11c2"), new Guid("7a84b636-4327-4c39-851e-1258f7149167"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("20ac892e-3901-48a4-88fa-1d7d0d753cf8"), new Guid("a8046683-88f1-441f-a68e-c39f9090fe32"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("2bb68702-b894-4bdd-a66b-71098acb0ae6"), new Guid("b41a4320-f52b-4c9f-ada2-a42ae0b14db8"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("389fc2ca-8bf8-4a89-bc92-d0e033f7c80b"), new Guid("7a84b636-4327-4c39-851e-1258f7149167"), false, false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("51b889c6-ed32-4f84-9d31-cb085e311607"), new Guid("b41a4320-f52b-4c9f-ada2-a42ae0b14db8"), false, false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("7dd3e212-cff4-4098-8a1b-3de2d104ff39"), new Guid("65b1e836-6225-45d0-98bf-fae2fa414aeb"), true, true, "Краткая аннотация конкурсной работы", 14 },
                    { new Guid("d06ca757-5eda-4bb2-a6dc-a2d844328c22"), new Guid("7a84b636-4327-4c39-851e-1258f7149167"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("d725a717-91f1-4080-bc96-ec9f552ec491"), new Guid("a8046683-88f1-441f-a68e-c39f9090fe32"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("d7c23daa-89cc-4f12-90bb-948bea58e284"), new Guid("7a84b636-4327-4c39-851e-1258f7149167"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("d9d085b1-1fba-4b83-b5ed-ad1192a1c00c"), new Guid("a8046683-88f1-441f-a68e-c39f9090fe32"), false, false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("e7d12b9c-73a9-4134-8034-4d3ea6f9e59d"), new Guid("7a84b636-4327-4c39-851e-1258f7149167"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("f6694a72-0ba3-44b6-ab07-5e84f7fc94da"), new Guid("7a84b636-4327-4c39-851e-1258f7149167"), false, false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("02bcf1fb-a261-474e-8ac4-cf828a031887"), true, "Ссылка на открытый доступ", 8, new Guid("f6694a72-0ba3-44b6-ab07-5e84f7fc94da"), new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("0624fef2-7034-4ab1-9650-12094515b05f"), true, "Год получения документа", 2, new Guid("2bb68702-b894-4bdd-a66b-71098acb0ae6"), new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("07880db8-cfd4-4300-818b-dda26b368935"), true, "Издание, год", 4, new Guid("d9d085b1-1fba-4b83-b5ed-ad1192a1c00c"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("080c7992-ff22-4048-8601-8d4d04b0c849"), true, "Год", 1, new Guid("51b889c6-ed32-4f84-9d31-cb085e311607"), new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("0c77875f-70c7-4901-900c-d6aaee44f8ca"), true, "Награда", 4, new Guid("51b889c6-ed32-4f84-9d31-cb085e311607"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("0dd22a46-3f20-43ee-9873-108ddee65535"), true, "Количество печатных листов", 4, new Guid("f6694a72-0ba3-44b6-ab07-5e84f7fc94da"), new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("0eb4a679-67a0-49d5-96de-4d010801a10d"), true, "Статус (руководитель/исполнитель)", 4, new Guid("20ac892e-3901-48a4-88fa-1d7d0d753cf8"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("0f9599d5-2fea-4ac1-beb5-8a788466f7d0"), true, "Соавторы", 2, new Guid("d9d085b1-1fba-4b83-b5ed-ad1192a1c00c"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("0f9c2953-01ce-4342-8f1e-70d10f3787c6"), true, "Название статьи", 1, new Guid("d9d085b1-1fba-4b83-b5ed-ad1192a1c00c"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("1a850a6b-979c-4781-8c54-1f1ece684813"), true, "Вид (лекции, лабораторные)", 2, new Guid("e7d12b9c-73a9-4134-8034-4d3ea6f9e59d"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("27fb9af0-88f0-4a51-8cd6-bfd3d99e78cf"), true, "Вид", 1, new Guid("d725a717-91f1-4080-bc96-ec9f552ec491"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("3f85b228-e8f3-457a-a32a-c8122ac3e013"), true, "Вид деятельности (преподавательская)", 3, new Guid("389fc2ca-8bf8-4a89-bc92-d0e033f7c80b"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("42d367df-dd84-488e-aafe-f3f190c837ba"), true, "Название курса", 1, new Guid("0658ac3a-6678-476c-bb58-c4a531fc11c2"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("462d3f30-52a9-47d2-8ca9-e2659d28131a"), false, "Идентификатор", 2, new Guid("0489818b-a189-4670-934b-d373d37be979"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("46b36ae0-6664-4ab9-b4aa-f0b4ae0757e4"), true, "Практические занятия (час.)", 4, new Guid("d06ca757-5eda-4bb2-a6dc-a2d844328c22"), new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("488c472c-3753-4950-9b66-dbd84f800a31"), true, "Название организации/должность/ставка", 1, new Guid("389fc2ca-8bf8-4a89-bc92-d0e033f7c80b"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("506e7678-7c24-4069-8d43-d573c2c60c99"), true, "Год", 3, new Guid("d7c23daa-89cc-4f12-90bb-948bea58e284"), new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("559dd498-ebe4-4b62-b876-99499d4046a7"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("d7c23daa-89cc-4f12-90bb-948bea58e284"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("59c8e126-e97e-4309-aa49-c71f80228585"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("20ac892e-3901-48a4-88fa-1d7d0d753cf8"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("5a81d2d7-72ca-4f79-9239-1ce12fcdc8ca"), true, "Соавторы", 2, new Guid("0658ac3a-6678-476c-bb58-c4a531fc11c2"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("5d14fb5a-e5d6-479d-9db9-c9293f17fd4f"), true, "Название документа, реквизиты", 1, new Guid("2bb68702-b894-4bdd-a66b-71098acb0ae6"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("5d623444-e76c-419e-ab3d-0a05574cc266"), false, "Соавторы", 3, new Guid("f6694a72-0ba3-44b6-ab07-5e84f7fc94da"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("640b761f-29bd-483b-a3d7-d31e6a045558"), true, "Лекции (час.)", 3, new Guid("d06ca757-5eda-4bb2-a6dc-a2d844328c22"), new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("6a8385c6-8bbf-4ff0-943a-535402e487b6"), true, "Наличие грифа", 5, new Guid("f6694a72-0ba3-44b6-ab07-5e84f7fc94da"), new Guid("6fce3ccd-06cb-4b46-9951-fbe245aa0b4b") },
                    { new Guid("6b9340dc-754c-4066-9f88-831c633247ce"), true, "Название организации в которую внедрена разработка", 3, new Guid("04e46bb3-964f-4e25-903f-07bed1af7c69"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("73a8baf9-c386-44fa-8463-4a73a4546001"), true, "Итого (час.)", 5, new Guid("d06ca757-5eda-4bb2-a6dc-a2d844328c22"), new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("7608aa0a-e76c-4aa3-b3c4-61068619cb07"), true, "Период выполнения", 3, new Guid("20ac892e-3901-48a4-88fa-1d7d0d753cf8"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("7ae3dda8-3385-4a6f-a160-64062dfef51a"), true, "Вид публикации", 1, new Guid("f6694a72-0ba3-44b6-ab07-5e84f7fc94da"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("8024a9a4-7638-42a1-9f76-73c6b22610de"), true, "Ссылка на платформу", 3, new Guid("0658ac3a-6678-476c-bb58-c4a531fc11c2"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("80557df3-a701-4573-b901-480d5042fdda"), true, "Название дисциплины", 1, new Guid("e7d12b9c-73a9-4134-8034-4d3ea6f9e59d"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("894c203a-8fb8-4216-b836-56ead82181fc"), true, "Название конкурса/премии", 2, new Guid("d7c23daa-89cc-4f12-90bb-948bea58e284"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("8a3b2570-6afe-4d3f-bf16-49029f2802bd"), true, "Наименование курса", 1, new Guid("d06ca757-5eda-4bb2-a6dc-a2d844328c22"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("8e3e8452-a196-40e2-a71e-7d679aa7b996"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("d9d085b1-1fba-4b83-b5ed-ad1192a1c00c"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("9447cf9b-427d-45ec-a25f-209818067970"), true, "Название конкурса", 2, new Guid("51b889c6-ed32-4f84-9d31-cb085e311607"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("9514792b-6949-4e6b-96a6-7ca0b14f9a65"), true, "Статус конкурса", 3, new Guid("51b889c6-ed32-4f84-9d31-cb085e311607"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("955df40b-71f9-4320-9565-dc68fcdf2d22"), true, "Название", 2, new Guid("f6694a72-0ba3-44b6-ab07-5e84f7fc94da"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("96c78516-d91f-41f6-8acb-b6ce6426f356"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("d06ca757-5eda-4bb2-a6dc-a2d844328c22"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("9abe2b37-f256-474c-be79-2fd35841e609"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("20ac892e-3901-48a4-88fa-1d7d0d753cf8"), new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("9c96d8a4-e753-43e8-8d3d-699485113d73"), true, "Название НИР/НИОКР", 1, new Guid("20ac892e-3901-48a4-88fa-1d7d0d753cf8"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("9f4be3aa-7be2-4767-96b7-2997bc9acd3d"), true, "Название разработки", 2, new Guid("04e46bb3-964f-4e25-903f-07bed1af7c69"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("a5ddc26f-1c8d-410d-8817-edc0b4bea15c"), true, "ФИО", 1, new Guid("d7c23daa-89cc-4f12-90bb-948bea58e284"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("a9f176a7-2ff4-4dd4-99e0-1866065adac3"), true, "Вид", 1, new Guid("04e46bb3-964f-4e25-903f-07bed1af7c69"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("afe712bf-7e44-4834-a75b-eaa8525608b7"), true, "Издательство, год", 6, new Guid("f6694a72-0ba3-44b6-ab07-5e84f7fc94da"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("b2b5f5d7-256c-46cf-9295-9ff9b013c764"), true, "Номер РИД", 4, new Guid("d725a717-91f1-4080-bc96-ec9f552ec491"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("b3fdfbe0-446d-4d6e-98a1-2c3c6e666221"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("e7d12b9c-73a9-4134-8034-4d3ea6f9e59d"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("bb9c44f1-c526-45f3-83cc-54413fb58801"), true, "ФИО соавторов", 3, new Guid("d725a717-91f1-4080-bc96-ec9f552ec491"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("c376d73f-b11f-43b0-a52a-be17f6403496"), false, "Тип идентификатора", 1, new Guid("0489818b-a189-4670-934b-d373d37be979"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("d14767c7-660b-4c61-805d-2a2ee1511741"), true, "Название", 2, new Guid("d725a717-91f1-4080-bc96-ec9f552ec491"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("d29c7e95-bced-4d74-ae32-7094001385ac"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("389fc2ca-8bf8-4a89-bc92-d0e033f7c80b"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("e3621e8f-6e5c-409e-b9b1-99e00a383734"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("d7c23daa-89cc-4f12-90bb-948bea58e284"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("eac05188-5f31-4ebe-824b-b559b13c4845"), true, "Год", 4, new Guid("0658ac3a-6678-476c-bb58-c4a531fc11c2"), new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("ebfd4eca-6c20-46a9-90e7-f0f15b46a99f"), true, "Ссылка", 5, new Guid("51b889c6-ed32-4f84-9d31-cb085e311607"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("ee0cc318-5ae7-4739-8da3-fa033ac700fe"), true, "Название", 1, new Guid("7dd3e212-cff4-4098-8a1b-3de2d104ff39"), new Guid("31979aa8-602a-4d37-9b50-65bf5d80732f") },
                    { new Guid("f0ac3d33-233b-41c5-8ba5-0fdf237bbbb1"), true, "Значение", 2, new Guid("7dd3e212-cff4-4098-8a1b-3de2d104ff39"), new Guid("db4e477b-cb9c-4edb-88ba-2bcfe319f860") },
                    { new Guid("f4e4a5cd-5470-4087-9aa7-edec301cc10d"), true, "Язык публикации", 7, new Guid("f6694a72-0ba3-44b6-ab07-5e84f7fc94da"), new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") },
                    { new Guid("fdbc47f7-6386-41ef-b9f2-3b3286396cf4"), true, "Количество часов", 4, new Guid("389fc2ca-8bf8-4a89-bc92-d0e033f7c80b"), new Guid("23d4d2dc-cec1-4645-9e74-81880967f4dd") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("14fbb388-dac0-45a1-a658-42a1b8c2c592"), new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946") },
                    { new Guid("20745819-ddcf-4426-aa8c-0e97a8073432"), new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946") },
                    { new Guid("2397ba4e-1f9d-40b8-b20b-caa5c826f998"), new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda") },
                    { new Guid("2397ba4e-1f9d-40b8-b20b-caa5c826f998"), new Guid("9c51a23e-9ac5-4a5d-8134-4e6488027358") },
                    { new Guid("2397ba4e-1f9d-40b8-b20b-caa5c826f998"), new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946") },
                    { new Guid("288e5044-5d10-477f-b19d-f828e2f74cfd"), new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946") },
                    { new Guid("2addba9d-337f-4feb-8954-561d2d04bbdf"), new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931") },
                    { new Guid("321a128f-576c-4e82-91d3-ce8327a225bf"), new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda") },
                    { new Guid("33dcad3c-c746-46d1-aac8-265edb286e65"), new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946") },
                    { new Guid("43591779-e109-4d5d-a32d-c192ce494f91"), new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946") },
                    { new Guid("4a7e1b72-2143-442a-82a9-f4c480e76f0d"), new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946") },
                    { new Guid("667a5fe9-f7a7-4bea-9b0a-a4af46df7c51"), new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931") },
                    { new Guid("781ff860-3103-402e-9626-6e4a33ff72f2"), new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946") },
                    { new Guid("8aaebaac-ec31-4e30-a2a0-213d6c665f7c"), new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946") },
                    { new Guid("a0b6a59e-c476-46dc-88c3-c2eed537c852"), new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946") },
                    { new Guid("d00428b6-2676-4ca1-bc78-53334e74d475"), new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda") },
                    { new Guid("db94d2d4-3bc7-4fdc-8687-49ff8110514e"), new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946") },
                    { new Guid("e8d4c912-afcf-42db-835e-0a5796d13c82"), new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931") },
                    { new Guid("e9b5433f-0212-45a7-adee-1184ed374fd3"), new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946") },
                    { new Guid("eb2713d1-7c99-45d9-914d-1566cff0c69b"), new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946") },
                    { new Guid("f3acc764-27d9-47c8-9912-8e4743e0cb9c"), new Guid("c68a89d0-5cb5-459b-bd4e-9dcf5c89b946") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda"), new Guid("0489818b-a189-4670-934b-d373d37be979") },
                    { new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda"), new Guid("20ac892e-3901-48a4-88fa-1d7d0d753cf8") },
                    { new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda"), new Guid("51b889c6-ed32-4f84-9d31-cb085e311607") },
                    { new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda"), new Guid("d9d085b1-1fba-4b83-b5ed-ad1192a1c00c") },
                    { new Guid("2d609b7c-6855-4d5e-a7fb-fb485fa4dc98"), new Guid("e7d12b9c-73a9-4134-8034-4d3ea6f9e59d") },
                    { new Guid("2d609b7c-6855-4d5e-a7fb-fb485fa4dc98"), new Guid("f6694a72-0ba3-44b6-ab07-5e84f7fc94da") },
                    { new Guid("44b539cc-5665-4c6a-88f1-4a26d17fc15f"), new Guid("7dd3e212-cff4-4098-8a1b-3de2d104ff39") },
                    { new Guid("9c51a23e-9ac5-4a5d-8134-4e6488027358"), new Guid("2bb68702-b894-4bdd-a66b-71098acb0ae6") },
                    { new Guid("9c51a23e-9ac5-4a5d-8134-4e6488027358"), new Guid("51b889c6-ed32-4f84-9d31-cb085e311607") },
                    { new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931"), new Guid("0658ac3a-6678-476c-bb58-c4a531fc11c2") },
                    { new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931"), new Guid("389fc2ca-8bf8-4a89-bc92-d0e033f7c80b") },
                    { new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931"), new Guid("d06ca757-5eda-4bb2-a6dc-a2d844328c22") },
                    { new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931"), new Guid("d7c23daa-89cc-4f12-90bb-948bea58e284") },
                    { new Guid("e03fad0f-4c07-4b08-92ad-a14bcc7c75d4"), new Guid("04e46bb3-964f-4e25-903f-07bed1af7c69") },
                    { new Guid("e03fad0f-4c07-4b08-92ad-a14bcc7c75d4"), new Guid("2bb68702-b894-4bdd-a66b-71098acb0ae6") },
                    { new Guid("e03fad0f-4c07-4b08-92ad-a14bcc7c75d4"), new Guid("d725a717-91f1-4080-bc96-ec9f552ec491") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("05adb403-8bbf-4fc1-814a-987ba382a270"), "EvaluateMark4", new Guid("2addba9d-337f-4feb-8954-561d2d04bbdf"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("092c2512-d873-4c5b-84fa-083b9e58a123"), "EvaluateMark19", new Guid("d00428b6-2676-4ca1-bc78-53334e74d475"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("175ea51c-c828-4f43-a7d2-8c09efa48d31"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("f6694a72-0ba3-44b6-ab07-5e84f7fc94da") },
                    { new Guid("1f75e6af-09af-49da-8141-795133420824"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("d725a717-91f1-4080-bc96-ec9f552ec491") },
                    { new Guid("22fe6343-629c-40c5-8165-d7edc4061f84"), "EvaluateMark3", new Guid("667a5fe9-f7a7-4bea-9b0a-a4af46df7c51"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("276856a4-e394-4e13-9a43-4486e62e79e4"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("f6694a72-0ba3-44b6-ab07-5e84f7fc94da") },
                    { new Guid("2cf35850-ced4-41af-b8a7-64bb4a420b00"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("d9d085b1-1fba-4b83-b5ed-ad1192a1c00c") },
                    { new Guid("5d8a2ec1-9d0d-43aa-a636-e0cb288d8722"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("d06ca757-5eda-4bb2-a6dc-a2d844328c22") },
                    { new Guid("5f01c809-cc61-4359-a213-e54d18156cd4"), null, null, false, 10, "Оценка уровня предоставленной работы:", 25, new Guid("7dd3e212-cff4-4098-8a1b-3de2d104ff39") },
                    { new Guid("67aa62eb-355b-4c0d-ac60-09869c52298e"), "EvaluateMark13", new Guid("2397ba4e-1f9d-40b8-b20b-caa5c826f998"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("681f1e1f-29cd-4914-b70a-c24c607830ca"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("04e46bb3-964f-4e25-903f-07bed1af7c69") },
                    { new Guid("7ac07d54-5f7f-4ca0-b9a7-d176ad878718"), "EvaluateMark20", new Guid("321a128f-576c-4e82-91d3-ce8327a225bf"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("7f78b446-6492-41b0-ae63-152bb5484f77"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("f6694a72-0ba3-44b6-ab07-5e84f7fc94da") },
                    { new Guid("8158ee78-be9d-484f-94ba-f9a7a72dee7a"), null, null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("7dd3e212-cff4-4098-8a1b-3de2d104ff39") },
                    { new Guid("8dadf573-ad84-465a-8b8b-8fc5ca90e915"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("e7d12b9c-73a9-4134-8034-4d3ea6f9e59d") },
                    { new Guid("9b0ec3d4-3827-4e51-bde4-414d7150debe"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("d7c23daa-89cc-4f12-90bb-948bea58e284") },
                    { new Guid("9d82981c-8438-4eca-90d9-7e24d2b43ad1"), "EvaluateMark5", new Guid("e8d4c912-afcf-42db-835e-0a5796d13c82"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("be5a0e95-e6c4-418e-9222-2dc2295a2695"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("20ac892e-3901-48a4-88fa-1d7d0d753cf8") },
                    { new Guid("e1520add-45e6-481c-b680-d8c0c37ad602"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("2bb68702-b894-4bdd-a66b-71098acb0ae6") },
                    { new Guid("e864a005-e336-4345-b740-c1eeb004b3b0"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("f6694a72-0ba3-44b6-ab07-5e84f7fc94da") },
                    { new Guid("e9682bc4-3a63-4afd-8eaa-73b4096b0d8e"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("0658ac3a-6678-476c-bb58-c4a531fc11c2") },
                    { new Guid("ea206d2f-e257-4cf7-aae2-f1bdd77f3ef3"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("51b889c6-ed32-4f84-9d31-cb085e311607") },
                    { new Guid("ebbbf435-e021-4dab-b464-62e4e8f2400c"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("20ac892e-3901-48a4-88fa-1d7d0d753cf8") },
                    { new Guid("ed98d7cd-8f14-472c-b725-7d1adf23b7f0"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("d06ca757-5eda-4bb2-a6dc-a2d844328c22") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("1e351632-bfe7-4229-a429-509bb457ed7e"), true, new Guid("0489818b-a189-4670-934b-d373d37be979") },
                    { new Guid("3edfb324-54b3-4e96-894f-358c21d9d44a"), true, new Guid("0489818b-a189-4670-934b-d373d37be979") },
                    { new Guid("427a6c1e-079d-473d-aa98-3eb6bd214ddb"), true, new Guid("7dd3e212-cff4-4098-8a1b-3de2d104ff39") },
                    { new Guid("4eac6312-5e12-4781-9653-5a6d54a043ae"), true, new Guid("7dd3e212-cff4-4098-8a1b-3de2d104ff39") },
                    { new Guid("76cdb0f0-32c1-470c-980a-cc0db0fe5c22"), true, new Guid("7dd3e212-cff4-4098-8a1b-3de2d104ff39") },
                    { new Guid("7cc23c97-ce82-40f0-aa87-fcdece045cef"), true, new Guid("0489818b-a189-4670-934b-d373d37be979") },
                    { new Guid("86eaf612-110f-4e39-b296-94623985e5c8"), true, new Guid("7dd3e212-cff4-4098-8a1b-3de2d104ff39") },
                    { new Guid("8f65a8cb-cceb-4053-8368-f9249c0554bf"), true, new Guid("7dd3e212-cff4-4098-8a1b-3de2d104ff39") },
                    { new Guid("91797474-6ec3-4ab7-bab7-b378b725baf3"), true, new Guid("7dd3e212-cff4-4098-8a1b-3de2d104ff39") },
                    { new Guid("c9066d9a-0fa8-4b9d-b588-fb789d37fe56"), true, new Guid("0489818b-a189-4670-934b-d373d37be979") },
                    { new Guid("f16f0e19-6fe6-495e-96c4-a90f8ee4f0e5"), true, new Guid("0489818b-a189-4670-934b-d373d37be979") },
                    { new Guid("ff5e00c0-75ae-44fc-9325-6461d95b0241"), true, new Guid("7dd3e212-cff4-4098-8a1b-3de2d104ff39") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("58972e79-1bfa-459e-8f4b-037113fcd595"), null, new Guid("2397ba4e-1f9d-40b8-b20b-caa5c826f998"), "Нет" },
                    { new Guid("86b05b7e-b27a-43b3-a807-dcb6be33a797"), null, new Guid("e9b5433f-0212-45a7-adee-1184ed374fd3"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("9a8c285d-3e7a-4653-85ca-a170d8aabc5c"), null, new Guid("2397ba4e-1f9d-40b8-b20b-caa5c826f998"), "Профессор" },
                    { new Guid("b8d0e79c-7781-4e45-9c34-7024f0a95c41"), null, new Guid("2397ba4e-1f9d-40b8-b20b-caa5c826f998"), "Доцент" },
                    { new Guid("ee5d9314-8639-4fd3-86e7-ee6bdda9c717"), null, new Guid("e9b5433f-0212-45a7-adee-1184ed374fd3"), "Имеющие ученую степень доктора наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("06909968-185d-46be-80db-e28c32e379c5"), null, new Guid("ee0cc318-5ae7-4739-8da3-fa033ac700fe"), true, true, new Guid("427a6c1e-079d-473d-aa98-3eb6bd214ddb"), "Инновационность" },
                    { new Guid("0c5c8425-9427-43f9-b6e1-324b18fe5a37"), null, new Guid("c376d73f-b11f-43b0-a52a-be17f6403496"), true, true, new Guid("3edfb324-54b3-4e96-894f-358c21d9d44a"), "Google Scholar ID" },
                    { new Guid("0c9bf7a2-2c8c-4798-891c-16e4f5955851"), null, new Guid("ee0cc318-5ae7-4739-8da3-fa033ac700fe"), true, true, new Guid("4eac6312-5e12-4781-9653-5a6d54a043ae"), "Актуальность конкурсной работы" },
                    { new Guid("2b1114c0-479a-4463-8d72-2365f1255f39"), null, new Guid("ee0cc318-5ae7-4739-8da3-fa033ac700fe"), true, true, new Guid("86eaf612-110f-4e39-b296-94623985e5c8"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("3dbec125-538b-433e-800a-5d714f90218e"), null, new Guid("f0ac3d33-233b-41c5-8ba5-0fdf237bbbb1"), false, true, new Guid("8f65a8cb-cceb-4053-8368-f9249c0554bf"), null },
                    { new Guid("5077d645-c87e-495c-b465-ef7aa8605cdb"), null, new Guid("ee0cc318-5ae7-4739-8da3-fa033ac700fe"), true, true, new Guid("76cdb0f0-32c1-470c-980a-cc0db0fe5c22"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("5d7f8f6a-a728-49e1-9612-d854664cc4ac"), null, new Guid("ee0cc318-5ae7-4739-8da3-fa033ac700fe"), true, true, new Guid("91797474-6ec3-4ab7-bab7-b378b725baf3"), "Методология и методы, используемые в работе" },
                    { new Guid("5e99f4fa-e1d6-4124-9f23-f16a1120072c"), null, new Guid("f0ac3d33-233b-41c5-8ba5-0fdf237bbbb1"), false, true, new Guid("76cdb0f0-32c1-470c-980a-cc0db0fe5c22"), null },
                    { new Guid("705d969e-20fc-45a2-a3d3-619dd2b2266d"), null, new Guid("ee0cc318-5ae7-4739-8da3-fa033ac700fe"), true, true, new Guid("8f65a8cb-cceb-4053-8368-f9249c0554bf"), "Название работы" },
                    { new Guid("78f70788-fb64-434c-8378-591f682b279f"), null, new Guid("462d3f30-52a9-47d2-8ca9-e2659d28131a"), false, true, new Guid("1e351632-bfe7-4229-a429-509bb457ed7e"), null },
                    { new Guid("8065f7d7-1480-4a82-b10d-97a7d423e653"), null, new Guid("f0ac3d33-233b-41c5-8ba5-0fdf237bbbb1"), false, true, new Guid("ff5e00c0-75ae-44fc-9325-6461d95b0241"), null },
                    { new Guid("811ae8c9-7ff7-4e29-ae57-d24d0ecbede5"), null, new Guid("c376d73f-b11f-43b0-a52a-be17f6403496"), true, true, new Guid("7cc23c97-ce82-40f0-aa87-fcdece045cef"), "РИНЦ AuthorID" },
                    { new Guid("9b0af40f-74a5-4f5f-a04d-68d132114425"), null, new Guid("462d3f30-52a9-47d2-8ca9-e2659d28131a"), false, true, new Guid("c9066d9a-0fa8-4b9d-b588-fb789d37fe56"), null },
                    { new Guid("b363fe85-b1a9-41a4-b0b9-5691e0cf9b17"), null, new Guid("462d3f30-52a9-47d2-8ca9-e2659d28131a"), false, true, new Guid("7cc23c97-ce82-40f0-aa87-fcdece045cef"), null },
                    { new Guid("b53f7dca-6416-4394-a6f9-93f9f7cebee9"), null, new Guid("f0ac3d33-233b-41c5-8ba5-0fdf237bbbb1"), false, true, new Guid("91797474-6ec3-4ab7-bab7-b378b725baf3"), null },
                    { new Guid("b99f3ddc-e822-4868-9979-4ea4959bed88"), null, new Guid("462d3f30-52a9-47d2-8ca9-e2659d28131a"), false, true, new Guid("f16f0e19-6fe6-495e-96c4-a90f8ee4f0e5"), null },
                    { new Guid("bd1ea790-1f12-4193-946d-019455cacd48"), null, new Guid("f0ac3d33-233b-41c5-8ba5-0fdf237bbbb1"), false, true, new Guid("86eaf612-110f-4e39-b296-94623985e5c8"), null },
                    { new Guid("d35bc2ed-1e75-4831-80e1-96918185f3ed"), null, new Guid("ee0cc318-5ae7-4739-8da3-fa033ac700fe"), true, true, new Guid("ff5e00c0-75ae-44fc-9325-6461d95b0241"), "Результаты и выводы" },
                    { new Guid("d695d1c1-3972-4ccb-9e54-cb7ddab450ab"), null, new Guid("c376d73f-b11f-43b0-a52a-be17f6403496"), true, true, new Guid("f16f0e19-6fe6-495e-96c4-a90f8ee4f0e5"), "ORCiD" },
                    { new Guid("d7376611-f2dc-45f3-b921-6d6b14fab562"), null, new Guid("f0ac3d33-233b-41c5-8ba5-0fdf237bbbb1"), false, true, new Guid("427a6c1e-079d-473d-aa98-3eb6bd214ddb"), null },
                    { new Guid("dc0de23f-06df-4a5b-9e48-616488a7cbf8"), null, new Guid("c376d73f-b11f-43b0-a52a-be17f6403496"), true, true, new Guid("c9066d9a-0fa8-4b9d-b588-fb789d37fe56"), "ScopusID" },
                    { new Guid("e3f9350d-d5c6-48b8-b611-963a0cf4dad9"), null, new Guid("c376d73f-b11f-43b0-a52a-be17f6403496"), true, true, new Guid("1e351632-bfe7-4229-a429-509bb457ed7e"), "ResearcherID" },
                    { new Guid("e810d2e4-0cc3-4571-9137-6f2386de4d85"), null, new Guid("462d3f30-52a9-47d2-8ca9-e2659d28131a"), false, true, new Guid("3edfb324-54b3-4e96-894f-358c21d9d44a"), null },
                    { new Guid("f0d931f3-0447-42f5-8139-1edb63135d4d"), null, new Guid("f0ac3d33-233b-41c5-8ba5-0fdf237bbbb1"), false, true, new Guid("4eac6312-5e12-4781-9653-5a6d54a043ae"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda"), new Guid("092c2512-d873-4c5b-84fa-083b9e58a123") },
                    { new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda"), new Guid("2cf35850-ced4-41af-b8a7-64bb4a420b00") },
                    { new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda"), new Guid("67aa62eb-355b-4c0d-ac60-09869c52298e") },
                    { new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda"), new Guid("7ac07d54-5f7f-4ca0-b9a7-d176ad878718") },
                    { new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda"), new Guid("be5a0e95-e6c4-418e-9222-2dc2295a2695") },
                    { new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda"), new Guid("ea206d2f-e257-4cf7-aae2-f1bdd77f3ef3") },
                    { new Guid("28cefca6-6bf2-4db7-9863-dffd10db4eda"), new Guid("ebbbf435-e021-4dab-b464-62e4e8f2400c") },
                    { new Guid("2d609b7c-6855-4d5e-a7fb-fb485fa4dc98"), new Guid("175ea51c-c828-4f43-a7d2-8c09efa48d31") },
                    { new Guid("2d609b7c-6855-4d5e-a7fb-fb485fa4dc98"), new Guid("276856a4-e394-4e13-9a43-4486e62e79e4") },
                    { new Guid("2d609b7c-6855-4d5e-a7fb-fb485fa4dc98"), new Guid("7f78b446-6492-41b0-ae63-152bb5484f77") },
                    { new Guid("2d609b7c-6855-4d5e-a7fb-fb485fa4dc98"), new Guid("8dadf573-ad84-465a-8b8b-8fc5ca90e915") },
                    { new Guid("2d609b7c-6855-4d5e-a7fb-fb485fa4dc98"), new Guid("e864a005-e336-4345-b740-c1eeb004b3b0") },
                    { new Guid("44b539cc-5665-4c6a-88f1-4a26d17fc15f"), new Guid("5f01c809-cc61-4359-a213-e54d18156cd4") },
                    { new Guid("44b539cc-5665-4c6a-88f1-4a26d17fc15f"), new Guid("8158ee78-be9d-484f-94ba-f9a7a72dee7a") },
                    { new Guid("9c51a23e-9ac5-4a5d-8134-4e6488027358"), new Guid("67aa62eb-355b-4c0d-ac60-09869c52298e") },
                    { new Guid("9c51a23e-9ac5-4a5d-8134-4e6488027358"), new Guid("e1520add-45e6-481c-b680-d8c0c37ad602") },
                    { new Guid("9c51a23e-9ac5-4a5d-8134-4e6488027358"), new Guid("ea206d2f-e257-4cf7-aae2-f1bdd77f3ef3") },
                    { new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931"), new Guid("05adb403-8bbf-4fc1-814a-987ba382a270") },
                    { new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931"), new Guid("22fe6343-629c-40c5-8165-d7edc4061f84") },
                    { new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931"), new Guid("5d8a2ec1-9d0d-43aa-a636-e0cb288d8722") },
                    { new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931"), new Guid("9b0ec3d4-3827-4e51-bde4-414d7150debe") },
                    { new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931"), new Guid("9d82981c-8438-4eca-90d9-7e24d2b43ad1") },
                    { new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931"), new Guid("e9682bc4-3a63-4afd-8eaa-73b4096b0d8e") },
                    { new Guid("a992fefe-d9fb-43e6-bab9-c80a3a9f8931"), new Guid("ed98d7cd-8f14-472c-b725-7d1adf23b7f0") },
                    { new Guid("e03fad0f-4c07-4b08-92ad-a14bcc7c75d4"), new Guid("1f75e6af-09af-49da-8141-795133420824") },
                    { new Guid("e03fad0f-4c07-4b08-92ad-a14bcc7c75d4"), new Guid("681f1e1f-29cd-4914-b70a-c24c607830ca") },
                    { new Guid("e03fad0f-4c07-4b08-92ad-a14bcc7c75d4"), new Guid("e1520add-45e6-481c-b680-d8c0c37ad602") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("03541a4d-775d-4f16-b8f3-a93b1d8ab9ea"), new Guid("5d623444-e76c-419e-ab3d-0a05574cc266"), null, "Да" },
                    { new Guid("076b72a9-b0a9-4324-bfb5-3e7de09a7fd9"), new Guid("7ae3dda8-3385-4a6f-a160-64062dfef51a"), null, "Учебник" },
                    { new Guid("0b6173a8-9fb3-4f71-acb4-644115d361a6"), new Guid("a9f176a7-2ff4-4dd4-99e0-1866065adac3"), null, "Полезная модель" },
                    { new Guid("0c2fdd18-1170-49c8-b552-c1b10be0b660"), new Guid("7ae3dda8-3385-4a6f-a160-64062dfef51a"), null, "Монография" },
                    { new Guid("1d42284b-bf80-443a-90cf-c1af79ecac05"), new Guid("7ae3dda8-3385-4a6f-a160-64062dfef51a"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("252b0dbd-7d41-475a-996a-8c0ff0d6a084"), new Guid("0eb4a679-67a0-49d5-96de-4d010801a10d"), null, "Исполнитель" },
                    { new Guid("2f53926f-b36e-413c-b519-e0de74cf36bf"), new Guid("1a850a6b-979c-4781-8c54-1f1ece684813"), null, "Лабораторные" },
                    { new Guid("2ff77d6b-f536-4722-b377-7e97385d6b17"), new Guid("1a850a6b-979c-4781-8c54-1f1ece684813"), null, "Лекции" },
                    { new Guid("3ce48012-79cd-4918-bf74-43ba54a13082"), new Guid("27fb9af0-88f0-4a51-8cd6-bfd3d99e78cf"), null, "База данных" },
                    { new Guid("5664b315-9c2e-44fd-bd26-7c59b68e5662"), new Guid("27fb9af0-88f0-4a51-8cd6-bfd3d99e78cf"), null, "Изобретение" },
                    { new Guid("5d37a117-70e2-4b12-b220-440a41bfc937"), new Guid("9514792b-6949-4e6b-96a6-7ca0b14f9a65"), null, "Международный" },
                    { new Guid("6741961a-2d57-4d41-af13-f1f243939559"), new Guid("f4e4a5cd-5470-4087-9aa7-edec301cc10d"), null, "Иностранный" },
                    { new Guid("6dbfdd34-bae1-4b3b-b28b-fb81bd831eb3"), new Guid("a9f176a7-2ff4-4dd4-99e0-1866065adac3"), null, "База данных" },
                    { new Guid("8bedb49e-137d-4aad-bc1a-4b7eec2503ba"), new Guid("5d623444-e76c-419e-ab3d-0a05574cc266"), null, "Нет" },
                    { new Guid("a61e8518-d691-4546-9c72-6d07252a7d52"), new Guid("9514792b-6949-4e6b-96a6-7ca0b14f9a65"), null, "Всероссийский" },
                    { new Guid("a6f7ddc8-7327-477b-b801-1007526ff8c4"), new Guid("0eb4a679-67a0-49d5-96de-4d010801a10d"), null, "Руководитель" },
                    { new Guid("add48b77-cc15-4dab-8207-5a1679b228c8"), new Guid("27fb9af0-88f0-4a51-8cd6-bfd3d99e78cf"), null, "Полезная модель" },
                    { new Guid("b523c587-d137-4b6d-8e39-b3d52bcff0ac"), new Guid("f4e4a5cd-5470-4087-9aa7-edec301cc10d"), null, "Русский" },
                    { new Guid("d1d149b2-be8f-4789-8678-27b58204c296"), new Guid("a9f176a7-2ff4-4dd4-99e0-1866065adac3"), null, "Изобретение" },
                    { new Guid("f81e55a5-8dc9-4e28-a67b-a59c5b8d98c8"), new Guid("9514792b-6949-4e6b-96a6-7ca0b14f9a65"), null, "Региональный" }
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
