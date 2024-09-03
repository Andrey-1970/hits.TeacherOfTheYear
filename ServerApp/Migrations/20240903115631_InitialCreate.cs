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
                    { new Guid("1a20b7a9-cefd-4cb6-b2af-12bdaeeb4159"), 3, "В процессе рассмотрения" },
                    { new Guid("32d73456-85ee-4b30-9931-2bd556a2332d"), 4, "Одобрена" },
                    { new Guid("88acf778-130a-4f13-908e-71df1f683a45"), 1, "В ожидании заполнения" },
                    { new Guid("bf304131-55e2-4f94-8798-534b0f7a3c71"), 2, "В ожидании рассмотрения" },
                    { new Guid("f06fa74e-750f-4f97-af6a-c5083b95917c"), 5, "Отклонена" },
                    { new Guid("ff017a4f-5dab-408b-bf74-deef89cb18d7"), 6, "Оценена" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17872699-4e88-4b12-bfb5-6f77780b0b1c", null, "Voter", "VOTER" },
                    { "246a632b-fbc8-409a-abfb-5543889f31fd", null, "Expert", "EXPERT" },
                    { "b8efe516-ac2c-4807-9b4b-86b9796f93ff", null, "Admin", "ADMIN" },
                    { "f2dc6fcc-8041-4b52-bd80-d9ffd46ffc87", null, "Participant", "PARTICIPANT" },
                    { "f683300c-64c7-4b6b-9704-74c582ab1cdb", null, "Organiser", "ORGANISER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("37227023-e899-460e-9f26-6270d1eb2138"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("4819eef1-7e41-4f4e-8b23-e510582a84e4"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("064bbf25-b565-42e5-8853-2c7166494c3f"), "Деятельность", 4 },
                    { new Guid("29e7c879-4cf4-402f-b5ef-b1216608c66b"), "Профессиональное развитие", 3 },
                    { new Guid("5fa162dd-d5c0-4d64-8f61-545f4130b86f"), "Категория участников", 2 },
                    { new Guid("c112de76-1b07-49e7-92c3-718ec1ddf9ab"), "Общая информация", 1 },
                    { new Guid("c1f2b89b-9a29-4b35-85a5-e009de96169e"), "Деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0fdb1541-18ce-4b40-a2ba-de1bd23dc989"), "Конкурсная работа", 7 },
                    { new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("2b175ac0-1680-4f62-9867-b0f2e6a374d3"), "Профессиональные показатели", 4 },
                    { new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf"), "Образовательная деятельность", 2 },
                    { new Guid("8f99002a-9475-4e3a-a642-36cfe3658fd2"), "Инновационная и иная деятельность", 6 },
                    { new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a"), "Основной", 1 },
                    { new Guid("fb29b0be-05e6-4de1-a1ff-6a188b40208a"), "Методическая деятельность", 3 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("d573d72e-b3f0-4cc1-8d1d-91e965469bea"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("ef3dad55-17e2-4f71-b47e-3060123ddb4a"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84"), "int" },
                    { new Guid("bd396c8f-144c-4f7b-a7aa-f253e902002b"), "DateTime" },
                    { new Guid("cc96e880-450f-4516-8c0e-ff8b89ffaa8d"), "TextArea" },
                    { new Guid("de202e33-9eec-411e-bcdc-99a95229d952"), "bool" },
                    { new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd"), "string" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("064bbf25-b565-42e5-8853-2c7166494c3f"), new Guid("ef3dad55-17e2-4f71-b47e-3060123ddb4a") },
                    { new Guid("29e7c879-4cf4-402f-b5ef-b1216608c66b"), new Guid("d573d72e-b3f0-4cc1-8d1d-91e965469bea") },
                    { new Guid("29e7c879-4cf4-402f-b5ef-b1216608c66b"), new Guid("ef3dad55-17e2-4f71-b47e-3060123ddb4a") },
                    { new Guid("5fa162dd-d5c0-4d64-8f61-545f4130b86f"), new Guid("d573d72e-b3f0-4cc1-8d1d-91e965469bea") },
                    { new Guid("5fa162dd-d5c0-4d64-8f61-545f4130b86f"), new Guid("ef3dad55-17e2-4f71-b47e-3060123ddb4a") },
                    { new Guid("c112de76-1b07-49e7-92c3-718ec1ddf9ab"), new Guid("d573d72e-b3f0-4cc1-8d1d-91e965469bea") },
                    { new Guid("c112de76-1b07-49e7-92c3-718ec1ddf9ab"), new Guid("ef3dad55-17e2-4f71-b47e-3060123ddb4a") },
                    { new Guid("c1f2b89b-9a29-4b35-85a5-e009de96169e"), new Guid("d573d72e-b3f0-4cc1-8d1d-91e965469bea") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("037ffe69-2f4f-4102-ac86-01d22617e018"), new Guid("5fa162dd-d5c0-4d64-8f61-545f4130b86f"), null, true, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("0ad91db4-05ed-4721-b3f2-0c76acb0d1e5"), new Guid("c112de76-1b07-49e7-92c3-718ec1ddf9ab"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("bd396c8f-144c-4f7b-a7aa-f253e902002b") },
                    { new Guid("10dca74a-6f33-41d3-abb1-5c7b1f57e69b"), new Guid("c112de76-1b07-49e7-92c3-718ec1ddf9ab"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("1f4c3124-3a47-477f-a1b0-e25db1b29f01"), new Guid("c112de76-1b07-49e7-92c3-718ec1ddf9ab"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("24201caf-3b53-42d4-9479-fe6e2c4ff779"), new Guid("c112de76-1b07-49e7-92c3-718ec1ddf9ab"), null, false, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("343788de-62ee-4e5f-9e73-42c97f29c1f9"), new Guid("c112de76-1b07-49e7-92c3-718ec1ddf9ab"), null, false, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("631b243d-cac9-4af6-955f-97cd2840e1db"), new Guid("c112de76-1b07-49e7-92c3-718ec1ddf9ab"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("80956ea4-f9a0-4161-beba-f6c40fdac773"), new Guid("c112de76-1b07-49e7-92c3-718ec1ddf9ab"), null, true, true, "Место работы/учебы", 6, "Название организации", new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("81167086-9122-423f-a6d0-9dd9fd7a89c0"), new Guid("c112de76-1b07-49e7-92c3-718ec1ddf9ab"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("8702e8c5-303d-47d3-b472-ad5b45786985"), new Guid("064bbf25-b565-42e5-8853-2c7166494c3f"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("8df1c6e3-379f-43bd-bbed-8fa7dc047f2a"), new Guid("c1f2b89b-9a29-4b35-85a5-e009de96169e"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("91537e73-d1c4-4791-ad69-ec451d32c4fc"), new Guid("064bbf25-b565-42e5-8853-2c7166494c3f"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("9f7ff670-ec8b-4308-8381-4601db0457dc"), new Guid("5fa162dd-d5c0-4d64-8f61-545f4130b86f"), null, false, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("9fa3f2ae-fd00-48bc-829f-2c67170ecfc7"), new Guid("c112de76-1b07-49e7-92c3-718ec1ddf9ab"), null, true, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("9ff22936-3848-4c05-a2e7-ac8a44c4792c"), new Guid("5fa162dd-d5c0-4d64-8f61-545f4130b86f"), null, false, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("a1ae16dc-349c-40df-a91c-ec2750df573b"), new Guid("5fa162dd-d5c0-4d64-8f61-545f4130b86f"), null, true, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("a3411054-66c1-426c-893c-071b04ee470c"), new Guid("c112de76-1b07-49e7-92c3-718ec1ddf9ab"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("a48a3022-773b-409d-b5b7-a9dce98746fe"), new Guid("c1f2b89b-9a29-4b35-85a5-e009de96169e"), null, false, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("ecf5fba8-8c18-4001-a8b1-253eeab96053"), new Guid("064bbf25-b565-42e5-8853-2c7166494c3f"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0fdb1541-18ce-4b40-a2ba-de1bd23dc989"), new Guid("d573d72e-b3f0-4cc1-8d1d-91e965469bea") },
                    { new Guid("0fdb1541-18ce-4b40-a2ba-de1bd23dc989"), new Guid("ef3dad55-17e2-4f71-b47e-3060123ddb4a") },
                    { new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9"), new Guid("d573d72e-b3f0-4cc1-8d1d-91e965469bea") },
                    { new Guid("2b175ac0-1680-4f62-9867-b0f2e6a374d3"), new Guid("ef3dad55-17e2-4f71-b47e-3060123ddb4a") },
                    { new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf"), new Guid("ef3dad55-17e2-4f71-b47e-3060123ddb4a") },
                    { new Guid("8f99002a-9475-4e3a-a642-36cfe3658fd2"), new Guid("d573d72e-b3f0-4cc1-8d1d-91e965469bea") },
                    { new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a"), new Guid("d573d72e-b3f0-4cc1-8d1d-91e965469bea") },
                    { new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a"), new Guid("ef3dad55-17e2-4f71-b47e-3060123ddb4a") },
                    { new Guid("fb29b0be-05e6-4de1-a1ff-6a188b40208a"), new Guid("ef3dad55-17e2-4f71-b47e-3060123ddb4a") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("03b2ad2d-3556-4939-b65c-d860d3e9f9ed"), new Guid("c1f2b89b-9a29-4b35-85a5-e009de96169e"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("1052665c-8548-4a6c-8b07-e6ecd2ea45d6"), new Guid("c1f2b89b-9a29-4b35-85a5-e009de96169e"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("2028a2fc-2e91-48d1-acb4-7c6416e8cf6b"), new Guid("064bbf25-b565-42e5-8853-2c7166494c3f"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("4ac48d76-f89c-4514-ac20-14723b9a1e07"), new Guid("c1f2b89b-9a29-4b35-85a5-e009de96169e"), true, true, "Персональные идентификаторы", 10 },
                    { new Guid("4c073d33-8a67-4342-a41e-5fb8c8a5b754"), new Guid("064bbf25-b565-42e5-8853-2c7166494c3f"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("4e6d348a-a320-4db1-893f-5701a4daa06a"), new Guid("064bbf25-b565-42e5-8853-2c7166494c3f"), false, false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("8a190894-ccb9-4292-a556-a17002bbcea6"), new Guid("29e7c879-4cf4-402f-b5ef-b1216608c66b"), false, false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("9e1a2e19-f54b-4bfe-aac2-ce2b597133ea"), new Guid("5fa162dd-d5c0-4d64-8f61-545f4130b86f"), true, true, "Краткая аннотация конкурсной работы", 14 },
                    { new Guid("9fb4d7e3-8f53-4c28-af80-c43b3626345d"), new Guid("c1f2b89b-9a29-4b35-85a5-e009de96169e"), false, false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("aca2a3db-13ad-45e0-9aa4-4291eefe90fc"), new Guid("064bbf25-b565-42e5-8853-2c7166494c3f"), false, false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("cb9b85f3-3913-4cec-a586-8af4eef7428a"), new Guid("29e7c879-4cf4-402f-b5ef-b1216608c66b"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("cd4cc8f0-0f03-4267-9670-6c3cbf2edac8"), new Guid("064bbf25-b565-42e5-8853-2c7166494c3f"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("d0f2183b-695c-4624-b8c3-9ee58349cca3"), new Guid("c1f2b89b-9a29-4b35-85a5-e009de96169e"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("e2018f08-fc66-4580-b66c-a42a0a76557a"), new Guid("064bbf25-b565-42e5-8853-2c7166494c3f"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0162d752-f759-422b-9836-5fa1ece0e955"), true, "ФИО", 1, new Guid("cd4cc8f0-0f03-4267-9670-6c3cbf2edac8"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("04ea0a9d-c6d1-452a-bfd1-0177c1586377"), true, "Итого (час.)", 5, new Guid("2028a2fc-2e91-48d1-acb4-7c6416e8cf6b"), new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("06ab7e3e-1cac-41c5-9d68-7bf28d9b0c98"), true, "Статус конкурса", 3, new Guid("8a190894-ccb9-4292-a556-a17002bbcea6"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("083f2975-339e-4ab4-8c5a-52a4fe9d6152"), true, "Название конкурса/премии", 2, new Guid("cd4cc8f0-0f03-4267-9670-6c3cbf2edac8"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("090421ec-ca5c-461d-b673-b4250c9c0e3d"), true, "Значение", 2, new Guid("9e1a2e19-f54b-4bfe-aac2-ce2b597133ea"), new Guid("cc96e880-450f-4516-8c0e-ff8b89ffaa8d") },
                    { new Guid("0932c219-fabf-4f35-a997-53241d64086f"), true, "Издание, год", 4, new Guid("9fb4d7e3-8f53-4c28-af80-c43b3626345d"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("1f36c50d-51bb-474a-90f2-85bfd5403200"), true, "Вид деятельности (преподавательская)", 3, new Guid("4e6d348a-a320-4db1-893f-5701a4daa06a"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("25cb9032-32b2-4ae4-a446-0324b8fd2de0"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("d0f2183b-695c-4624-b8c3-9ee58349cca3"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("30dfb60c-1689-4989-83d8-13b56efb466b"), true, "Количество часов", 4, new Guid("4e6d348a-a320-4db1-893f-5701a4daa06a"), new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("364cebd8-1e7d-4e08-80fa-f67612937be4"), true, "Соавторы", 2, new Guid("9fb4d7e3-8f53-4c28-af80-c43b3626345d"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("3ccb7929-b8fd-401f-a15e-b664c3e060fa"), true, "Наличие грифа", 5, new Guid("aca2a3db-13ad-45e0-9aa4-4291eefe90fc"), new Guid("de202e33-9eec-411e-bcdc-99a95229d952") },
                    { new Guid("3ce465ae-7bfe-4345-a46c-9bca7270b41a"), true, "Год", 3, new Guid("cd4cc8f0-0f03-4267-9670-6c3cbf2edac8"), new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("42d9106d-f5e9-45dd-a639-5b6861fc00f7"), true, "ФИО соавторов", 3, new Guid("03b2ad2d-3556-4939-b65c-d860d3e9f9ed"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("432291e5-d58b-4bcb-8c33-8380eb25abda"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("4e6d348a-a320-4db1-893f-5701a4daa06a"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("43d73009-c27c-4daf-8f10-6cbd26dca600"), true, "Год получения документа", 2, new Guid("cb9b85f3-3913-4cec-a586-8af4eef7428a"), new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("4595c0aa-30e2-4dd6-a428-1df2d656023d"), false, "Тип идентификатора", 1, new Guid("4ac48d76-f89c-4514-ac20-14723b9a1e07"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("4abc5d78-7f9a-4d10-8e33-a16301c497fc"), true, "Количество печатных листов", 4, new Guid("aca2a3db-13ad-45e0-9aa4-4291eefe90fc"), new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("4c3e7468-780f-4160-a865-fc76f0484273"), true, "Название", 2, new Guid("aca2a3db-13ad-45e0-9aa4-4291eefe90fc"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("4c66a2fd-5468-4029-af16-e65161dd3716"), true, "Название организации в которую внедрена разработка", 3, new Guid("1052665c-8548-4a6c-8b07-e6ecd2ea45d6"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("526ecdf6-85f5-431d-923e-4492c087d29b"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("e2018f08-fc66-4580-b66c-a42a0a76557a"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("5c9543bd-89da-4133-ad0f-8b655473b790"), true, "Название НИР/НИОКР", 1, new Guid("d0f2183b-695c-4624-b8c3-9ee58349cca3"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("637fed84-6b66-444a-bab6-8167070aae61"), true, "Период выполнения", 3, new Guid("d0f2183b-695c-4624-b8c3-9ee58349cca3"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("6494ba3d-50b4-41f8-9307-c48c6f27b78c"), true, "Название статьи", 1, new Guid("9fb4d7e3-8f53-4c28-af80-c43b3626345d"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("6fe8ea0b-8b70-47c2-bb21-579a53d0fe4b"), true, "Лекции (час.)", 3, new Guid("2028a2fc-2e91-48d1-acb4-7c6416e8cf6b"), new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("731c1d49-ae16-4806-8ccb-a1743b6a2e10"), true, "Название конкурса", 2, new Guid("8a190894-ccb9-4292-a556-a17002bbcea6"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("7660fae2-9ca0-401e-bb57-03e4b4d90123"), true, "Вид", 1, new Guid("1052665c-8548-4a6c-8b07-e6ecd2ea45d6"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("79460182-9379-47f9-94e0-db61069e0f1c"), true, "Название дисциплины", 1, new Guid("e2018f08-fc66-4580-b66c-a42a0a76557a"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("7d09cc1d-e2ef-4d5e-acd1-c8678aeb8357"), true, "Практические занятия (час.)", 4, new Guid("2028a2fc-2e91-48d1-acb4-7c6416e8cf6b"), new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("8535fd25-7560-4b4f-b8e7-322872c8d902"), true, "Вид (лекции, лабораторные)", 2, new Guid("e2018f08-fc66-4580-b66c-a42a0a76557a"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("8b7645a4-acbf-43f6-ad80-d4e4484000a6"), true, "Вид", 1, new Guid("03b2ad2d-3556-4939-b65c-d860d3e9f9ed"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("9100ab93-b749-46ed-86c5-83d7353a4612"), false, "Соавторы", 3, new Guid("aca2a3db-13ad-45e0-9aa4-4291eefe90fc"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("9af716f3-8d04-4326-880b-dfbc158b0e24"), false, "Идентификатор", 2, new Guid("4ac48d76-f89c-4514-ac20-14723b9a1e07"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("9ce5dcf0-8689-4155-aa58-b62184538abf"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("d0f2183b-695c-4624-b8c3-9ee58349cca3"), new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("a70f4642-914c-4b8f-a2ba-596b7528c79e"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("9fb4d7e3-8f53-4c28-af80-c43b3626345d"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("aea56f79-bec4-4b0e-a5a2-88e8fecbd385"), true, "Язык публикации", 7, new Guid("aca2a3db-13ad-45e0-9aa4-4291eefe90fc"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("af3402ef-4fc5-4b1e-b97e-0039739fb5a4"), true, "Название курса", 1, new Guid("4c073d33-8a67-4342-a41e-5fb8c8a5b754"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("b2a00a88-62cd-4450-b997-f086a35306a4"), true, "Издательство, год", 6, new Guid("aca2a3db-13ad-45e0-9aa4-4291eefe90fc"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("b55170ca-eed5-47ee-9437-e2a11988fe98"), true, "Название", 2, new Guid("03b2ad2d-3556-4939-b65c-d860d3e9f9ed"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("b922ea0f-b4b5-4c8f-9e79-e6e12f437da8"), true, "Ссылка", 5, new Guid("8a190894-ccb9-4292-a556-a17002bbcea6"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("bea0ee24-ca2b-4f87-89af-4cc93f434cde"), true, "Ссылка на открытый доступ", 8, new Guid("aca2a3db-13ad-45e0-9aa4-4291eefe90fc"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("c34414d5-f248-4e9e-869f-ae2d7bb878e0"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("cd4cc8f0-0f03-4267-9670-6c3cbf2edac8"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("c6e5c26b-c6aa-471e-b9c8-7040333e0c66"), true, "Номер РИД", 4, new Guid("03b2ad2d-3556-4939-b65c-d860d3e9f9ed"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("c90cdf9c-7a8d-41b5-903b-f68e3a84ae54"), true, "Год", 1, new Guid("8a190894-ccb9-4292-a556-a17002bbcea6"), new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("c93433bc-ad30-4a60-8cc6-96ae8d9f463f"), true, "Год", 4, new Guid("4c073d33-8a67-4342-a41e-5fb8c8a5b754"), new Guid("81e6eda1-1efe-4661-a269-07bfdb719f84") },
                    { new Guid("cb64be59-2a67-44c5-8f7d-f37cb1ee4796"), true, "Наименование курса", 1, new Guid("2028a2fc-2e91-48d1-acb4-7c6416e8cf6b"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("cb9c6ed2-3dac-4b73-8d7e-133ad3338275"), true, "Название документа, реквизиты", 1, new Guid("cb9b85f3-3913-4cec-a586-8af4eef7428a"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("cce4bd69-5046-4ed5-9731-68911c3f2b65"), true, "Название организации/должность/ставка", 1, new Guid("4e6d348a-a320-4db1-893f-5701a4daa06a"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("cf42064e-b1ed-478e-af8d-b64452ad4655"), true, "Соавторы", 2, new Guid("4c073d33-8a67-4342-a41e-5fb8c8a5b754"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("d00cac5f-6df6-4f23-9efc-3a41827da24e"), true, "Награда", 4, new Guid("8a190894-ccb9-4292-a556-a17002bbcea6"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("dccfc750-4c78-41c1-bd4e-80e7573caf4b"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("cd4cc8f0-0f03-4267-9670-6c3cbf2edac8"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("e9967d7c-aa33-42a3-bed2-0aa4a5196aa9"), true, "Вид публикации", 1, new Guid("aca2a3db-13ad-45e0-9aa4-4291eefe90fc"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("f2031781-1a63-4cde-b1e7-24755e77176f"), true, "Статус (руководитель/исполнитель)", 4, new Guid("d0f2183b-695c-4624-b8c3-9ee58349cca3"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("f274a888-24ad-40e8-9b10-2730632c9a6d"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("2028a2fc-2e91-48d1-acb4-7c6416e8cf6b"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("f6acb423-8d8c-4a75-a741-0e38a5b30a56"), true, "Название", 1, new Guid("9e1a2e19-f54b-4bfe-aac2-ce2b597133ea"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("fb99dcc5-aab5-4d2b-b603-a47e8faa2748"), true, "Ссылка на платформу", 3, new Guid("4c073d33-8a67-4342-a41e-5fb8c8a5b754"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") },
                    { new Guid("fd2f5362-db1f-4d54-818c-a2b759ed47f2"), true, "Название разработки", 2, new Guid("1052665c-8548-4a6c-8b07-e6ecd2ea45d6"), new Guid("de69ea2a-076a-489a-9ff9-275d8a6ee0cd") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("037ffe69-2f4f-4102-ac86-01d22617e018"), new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9") },
                    { new Guid("037ffe69-2f4f-4102-ac86-01d22617e018"), new Guid("2b175ac0-1680-4f62-9867-b0f2e6a374d3") },
                    { new Guid("037ffe69-2f4f-4102-ac86-01d22617e018"), new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a") },
                    { new Guid("0ad91db4-05ed-4721-b3f2-0c76acb0d1e5"), new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a") },
                    { new Guid("10dca74a-6f33-41d3-abb1-5c7b1f57e69b"), new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a") },
                    { new Guid("1f4c3124-3a47-477f-a1b0-e25db1b29f01"), new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a") },
                    { new Guid("24201caf-3b53-42d4-9479-fe6e2c4ff779"), new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a") },
                    { new Guid("343788de-62ee-4e5f-9e73-42c97f29c1f9"), new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a") },
                    { new Guid("631b243d-cac9-4af6-955f-97cd2840e1db"), new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a") },
                    { new Guid("80956ea4-f9a0-4161-beba-f6c40fdac773"), new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a") },
                    { new Guid("81167086-9122-423f-a6d0-9dd9fd7a89c0"), new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a") },
                    { new Guid("8702e8c5-303d-47d3-b472-ad5b45786985"), new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf") },
                    { new Guid("8df1c6e3-379f-43bd-bbed-8fa7dc047f2a"), new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9") },
                    { new Guid("91537e73-d1c4-4791-ad69-ec451d32c4fc"), new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf") },
                    { new Guid("9f7ff670-ec8b-4308-8381-4601db0457dc"), new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a") },
                    { new Guid("9fa3f2ae-fd00-48bc-829f-2c67170ecfc7"), new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a") },
                    { new Guid("9ff22936-3848-4c05-a2e7-ac8a44c4792c"), new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a") },
                    { new Guid("a1ae16dc-349c-40df-a91c-ec2750df573b"), new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a") },
                    { new Guid("a3411054-66c1-426c-893c-071b04ee470c"), new Guid("e55ceac2-1dda-43a3-a45a-2a0c27af587a") },
                    { new Guid("a48a3022-773b-409d-b5b7-a9dce98746fe"), new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9") },
                    { new Guid("ecf5fba8-8c18-4001-a8b1-253eeab96053"), new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("0fdb1541-18ce-4b40-a2ba-de1bd23dc989"), new Guid("9e1a2e19-f54b-4bfe-aac2-ce2b597133ea") },
                    { new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9"), new Guid("4ac48d76-f89c-4514-ac20-14723b9a1e07") },
                    { new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9"), new Guid("8a190894-ccb9-4292-a556-a17002bbcea6") },
                    { new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9"), new Guid("9fb4d7e3-8f53-4c28-af80-c43b3626345d") },
                    { new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9"), new Guid("d0f2183b-695c-4624-b8c3-9ee58349cca3") },
                    { new Guid("2b175ac0-1680-4f62-9867-b0f2e6a374d3"), new Guid("8a190894-ccb9-4292-a556-a17002bbcea6") },
                    { new Guid("2b175ac0-1680-4f62-9867-b0f2e6a374d3"), new Guid("cb9b85f3-3913-4cec-a586-8af4eef7428a") },
                    { new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf"), new Guid("2028a2fc-2e91-48d1-acb4-7c6416e8cf6b") },
                    { new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf"), new Guid("4c073d33-8a67-4342-a41e-5fb8c8a5b754") },
                    { new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf"), new Guid("4e6d348a-a320-4db1-893f-5701a4daa06a") },
                    { new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf"), new Guid("cd4cc8f0-0f03-4267-9670-6c3cbf2edac8") },
                    { new Guid("8f99002a-9475-4e3a-a642-36cfe3658fd2"), new Guid("03b2ad2d-3556-4939-b65c-d860d3e9f9ed") },
                    { new Guid("8f99002a-9475-4e3a-a642-36cfe3658fd2"), new Guid("1052665c-8548-4a6c-8b07-e6ecd2ea45d6") },
                    { new Guid("8f99002a-9475-4e3a-a642-36cfe3658fd2"), new Guid("cb9b85f3-3913-4cec-a586-8af4eef7428a") },
                    { new Guid("fb29b0be-05e6-4de1-a1ff-6a188b40208a"), new Guid("aca2a3db-13ad-45e0-9aa4-4291eefe90fc") },
                    { new Guid("fb29b0be-05e6-4de1-a1ff-6a188b40208a"), new Guid("e2018f08-fc66-4580-b66c-a42a0a76557a") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("09db73df-e9a1-4b32-a090-29664580a431"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("cd4cc8f0-0f03-4267-9670-6c3cbf2edac8") },
                    { new Guid("0f7de586-1492-4fef-94fd-b16414ea8929"), null, null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("9e1a2e19-f54b-4bfe-aac2-ce2b597133ea") },
                    { new Guid("145ab529-7b6f-4b98-9ff5-5d5fa00330e0"), null, null, false, 10, "Оценка уровня предоставленной работы:", 25, new Guid("9e1a2e19-f54b-4bfe-aac2-ce2b597133ea") },
                    { new Guid("246fce9f-144a-493f-9a52-bbb36e568ed4"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("aca2a3db-13ad-45e0-9aa4-4291eefe90fc") },
                    { new Guid("293ad3c4-dee0-472e-b51f-e91681114a49"), "EvaluateMark5", new Guid("8702e8c5-303d-47d3-b472-ad5b45786985"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("2e3abe88-033b-4390-a768-07c7f52cf3ab"), "EvaluateMark20", new Guid("a48a3022-773b-409d-b5b7-a9dce98746fe"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("31478264-5c85-483b-b16f-67aa286222df"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("4c073d33-8a67-4342-a41e-5fb8c8a5b754") },
                    { new Guid("3306a9ba-7d2b-4e4f-b588-75c5ed44eead"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("2028a2fc-2e91-48d1-acb4-7c6416e8cf6b") },
                    { new Guid("3670ebf9-2c0e-4404-adb0-08c50df117d4"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("03b2ad2d-3556-4939-b65c-d860d3e9f9ed") },
                    { new Guid("385e4268-d3cb-44df-8eac-067ee9d730a8"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("1052665c-8548-4a6c-8b07-e6ecd2ea45d6") },
                    { new Guid("53216d16-e0d4-449b-9766-308c062639f9"), "EvaluateMark4", new Guid("91537e73-d1c4-4791-ad69-ec451d32c4fc"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("59842114-ef9c-4197-b94c-2128552d914a"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("e2018f08-fc66-4580-b66c-a42a0a76557a") },
                    { new Guid("61b06b2c-de4f-4a19-9793-9046536ebc9c"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("d0f2183b-695c-4624-b8c3-9ee58349cca3") },
                    { new Guid("6fca925d-1f50-45f6-a8d1-503338f9a8f1"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("9fb4d7e3-8f53-4c28-af80-c43b3626345d") },
                    { new Guid("85a3522f-24a7-438c-908a-105ad6b70eea"), "EvaluateMark3", new Guid("ecf5fba8-8c18-4001-a8b1-253eeab96053"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("97abd78d-4cfe-49f9-bc37-3e137a297220"), "EvaluateMark19", new Guid("8df1c6e3-379f-43bd-bbed-8fa7dc047f2a"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("b154476b-480b-4145-8104-2d8e9fb97bbc"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("2028a2fc-2e91-48d1-acb4-7c6416e8cf6b") },
                    { new Guid("b947a1e6-afff-4da2-af17-29671729f71a"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("d0f2183b-695c-4624-b8c3-9ee58349cca3") },
                    { new Guid("be855681-20b7-4b0c-90c5-904c40b739af"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("aca2a3db-13ad-45e0-9aa4-4291eefe90fc") },
                    { new Guid("c2714bb9-444b-452b-821f-5985b925332f"), "EvaluateMark13", new Guid("037ffe69-2f4f-4102-ac86-01d22617e018"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("e0315d40-6406-49af-8553-cb9955f6416a"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("aca2a3db-13ad-45e0-9aa4-4291eefe90fc") },
                    { new Guid("e0773e70-6f4f-42ba-8423-45e5685e0258"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("aca2a3db-13ad-45e0-9aa4-4291eefe90fc") },
                    { new Guid("e6a7fbb9-4f23-4124-811e-d75721c23571"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("8a190894-ccb9-4292-a556-a17002bbcea6") },
                    { new Guid("fac08a25-afad-4143-a5c1-dd9a9804f34a"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("cb9b85f3-3913-4cec-a586-8af4eef7428a") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("06c1e3ce-e8bb-4364-b212-95f0e6ece200"), true, new Guid("9e1a2e19-f54b-4bfe-aac2-ce2b597133ea") },
                    { new Guid("12b696bc-de1d-41be-9387-ee671a364d46"), true, new Guid("9e1a2e19-f54b-4bfe-aac2-ce2b597133ea") },
                    { new Guid("21179f12-c30f-4a57-9608-a4ac9c15d530"), true, new Guid("9e1a2e19-f54b-4bfe-aac2-ce2b597133ea") },
                    { new Guid("59fb410d-0db2-47e8-b1de-cc13291599b6"), true, new Guid("4ac48d76-f89c-4514-ac20-14723b9a1e07") },
                    { new Guid("6f38fc13-6cbb-434d-8491-26e2b8130689"), true, new Guid("4ac48d76-f89c-4514-ac20-14723b9a1e07") },
                    { new Guid("708da983-125f-41ef-979b-f0fb1a4d2872"), true, new Guid("9e1a2e19-f54b-4bfe-aac2-ce2b597133ea") },
                    { new Guid("860f812d-45f3-488b-a348-e8e3acf6ac0e"), true, new Guid("4ac48d76-f89c-4514-ac20-14723b9a1e07") },
                    { new Guid("ac6ff4fe-0f69-4e35-8e65-c1bb5d4fee14"), true, new Guid("9e1a2e19-f54b-4bfe-aac2-ce2b597133ea") },
                    { new Guid("b3f9a55d-f59e-4195-b4d9-f241774b56a7"), true, new Guid("9e1a2e19-f54b-4bfe-aac2-ce2b597133ea") },
                    { new Guid("b8fbbd52-f28a-4b7d-827e-b357b48a8c35"), true, new Guid("4ac48d76-f89c-4514-ac20-14723b9a1e07") },
                    { new Guid("d141c8ed-da89-454d-941e-af4dc68866af"), true, new Guid("4ac48d76-f89c-4514-ac20-14723b9a1e07") },
                    { new Guid("ed5c9c10-912d-401c-975b-61b17aa65ed9"), true, new Guid("9e1a2e19-f54b-4bfe-aac2-ce2b597133ea") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0ce88541-0057-4f0d-8036-7ba8e3781f05"), null, new Guid("037ffe69-2f4f-4102-ac86-01d22617e018"), "Профессор" },
                    { new Guid("2bd3d3a9-b76e-4b5b-a99e-f9d14345343f"), null, new Guid("037ffe69-2f4f-4102-ac86-01d22617e018"), "Доцент" },
                    { new Guid("80481ac9-3232-4699-84b0-0a506e9f5d3d"), null, new Guid("037ffe69-2f4f-4102-ac86-01d22617e018"), "Нет" },
                    { new Guid("d9c68634-8805-416d-a95e-47256199a931"), null, new Guid("9f7ff670-ec8b-4308-8381-4601db0457dc"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("f441d79b-7f16-485b-b9f3-2db4d3b91d98"), null, new Guid("9f7ff670-ec8b-4308-8381-4601db0457dc"), "Имеющие ученую степень доктора наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("121b8ffa-3f6f-404d-a985-c336dca642eb"), null, new Guid("4595c0aa-30e2-4dd6-a428-1df2d656023d"), true, true, new Guid("d141c8ed-da89-454d-941e-af4dc68866af"), "ResearcherID" },
                    { new Guid("27527fd7-91aa-4705-a44e-1cf25e6368ef"), null, new Guid("f6acb423-8d8c-4a75-a741-0e38a5b30a56"), true, true, new Guid("21179f12-c30f-4a57-9608-a4ac9c15d530"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("30a9022d-c6e5-4a71-8377-10d9cabfada3"), null, new Guid("090421ec-ca5c-461d-b673-b4250c9c0e3d"), false, true, new Guid("21179f12-c30f-4a57-9608-a4ac9c15d530"), null },
                    { new Guid("3aa9eaab-8ece-4b0a-bc99-4b6ba96dc592"), null, new Guid("9af716f3-8d04-4326-880b-dfbc158b0e24"), false, true, new Guid("860f812d-45f3-488b-a348-e8e3acf6ac0e"), null },
                    { new Guid("4a4452d3-5ff0-4d0f-b636-db9dfabea659"), null, new Guid("f6acb423-8d8c-4a75-a741-0e38a5b30a56"), true, true, new Guid("b3f9a55d-f59e-4195-b4d9-f241774b56a7"), "Название работы" },
                    { new Guid("4ac286de-ee94-4287-9f8b-eb0edca51bf4"), null, new Guid("f6acb423-8d8c-4a75-a741-0e38a5b30a56"), true, true, new Guid("06c1e3ce-e8bb-4364-b212-95f0e6ece200"), "Методология и методы, используемые в работе" },
                    { new Guid("515d6537-7b37-471d-a782-9a4edc45cf6f"), null, new Guid("9af716f3-8d04-4326-880b-dfbc158b0e24"), false, true, new Guid("59fb410d-0db2-47e8-b1de-cc13291599b6"), null },
                    { new Guid("557b25a3-17c5-43a7-aa9c-32c79acf2d0a"), null, new Guid("090421ec-ca5c-461d-b673-b4250c9c0e3d"), false, true, new Guid("708da983-125f-41ef-979b-f0fb1a4d2872"), null },
                    { new Guid("5a1ae7f9-d75b-438c-a892-9ef468bd6a44"), null, new Guid("090421ec-ca5c-461d-b673-b4250c9c0e3d"), false, true, new Guid("06c1e3ce-e8bb-4364-b212-95f0e6ece200"), null },
                    { new Guid("5a871c97-5464-405e-b1ab-849366d9982c"), null, new Guid("090421ec-ca5c-461d-b673-b4250c9c0e3d"), false, true, new Guid("ac6ff4fe-0f69-4e35-8e65-c1bb5d4fee14"), null },
                    { new Guid("5a979841-1a05-4453-aa5d-5cc1e055ac0b"), null, new Guid("090421ec-ca5c-461d-b673-b4250c9c0e3d"), false, true, new Guid("12b696bc-de1d-41be-9387-ee671a364d46"), null },
                    { new Guid("68771169-8f53-4912-a862-c9eeeb0a9df6"), null, new Guid("f6acb423-8d8c-4a75-a741-0e38a5b30a56"), true, true, new Guid("ac6ff4fe-0f69-4e35-8e65-c1bb5d4fee14"), "Инновационность" },
                    { new Guid("720f5f0a-0acf-47bd-83c5-52666ab317c3"), null, new Guid("f6acb423-8d8c-4a75-a741-0e38a5b30a56"), true, true, new Guid("ed5c9c10-912d-401c-975b-61b17aa65ed9"), "Актуальность конкурсной работы" },
                    { new Guid("75103712-dc4d-4553-bed5-52b15342df7a"), null, new Guid("4595c0aa-30e2-4dd6-a428-1df2d656023d"), true, true, new Guid("860f812d-45f3-488b-a348-e8e3acf6ac0e"), "ScopusID" },
                    { new Guid("92b8d278-cbc1-449e-bb84-69a47183ec9b"), null, new Guid("090421ec-ca5c-461d-b673-b4250c9c0e3d"), false, true, new Guid("ed5c9c10-912d-401c-975b-61b17aa65ed9"), null },
                    { new Guid("ad5fedf7-ad40-4868-8081-a8004dc9b8fa"), null, new Guid("090421ec-ca5c-461d-b673-b4250c9c0e3d"), false, true, new Guid("b3f9a55d-f59e-4195-b4d9-f241774b56a7"), null },
                    { new Guid("b48782a4-0a00-4cc5-9f74-070dba9ef884"), null, new Guid("9af716f3-8d04-4326-880b-dfbc158b0e24"), false, true, new Guid("b8fbbd52-f28a-4b7d-827e-b357b48a8c35"), null },
                    { new Guid("c906abc8-737b-449d-87ac-61b30191a9fe"), null, new Guid("f6acb423-8d8c-4a75-a741-0e38a5b30a56"), true, true, new Guid("12b696bc-de1d-41be-9387-ee671a364d46"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("c92d376f-e07a-436e-962e-d9fa46920ed1"), null, new Guid("4595c0aa-30e2-4dd6-a428-1df2d656023d"), true, true, new Guid("b8fbbd52-f28a-4b7d-827e-b357b48a8c35"), "Google Scholar ID" },
                    { new Guid("cec23e68-1fa4-41af-95ad-3336c00a8f91"), null, new Guid("4595c0aa-30e2-4dd6-a428-1df2d656023d"), true, true, new Guid("6f38fc13-6cbb-434d-8491-26e2b8130689"), "ORCiD" },
                    { new Guid("d80084c5-8a2e-4d1a-8e70-5ada0815562c"), null, new Guid("9af716f3-8d04-4326-880b-dfbc158b0e24"), false, true, new Guid("6f38fc13-6cbb-434d-8491-26e2b8130689"), null },
                    { new Guid("e3eaa56f-da65-4300-9888-4dea9a1d8fe3"), null, new Guid("4595c0aa-30e2-4dd6-a428-1df2d656023d"), true, true, new Guid("59fb410d-0db2-47e8-b1de-cc13291599b6"), "РИНЦ AuthorID" },
                    { new Guid("e56a25a1-abfd-4522-bb9d-4e713b3fad33"), null, new Guid("9af716f3-8d04-4326-880b-dfbc158b0e24"), false, true, new Guid("d141c8ed-da89-454d-941e-af4dc68866af"), null },
                    { new Guid("e60cc376-cbb3-449d-80c5-9831f05ef452"), null, new Guid("f6acb423-8d8c-4a75-a741-0e38a5b30a56"), true, true, new Guid("708da983-125f-41ef-979b-f0fb1a4d2872"), "Результаты и выводы" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("0fdb1541-18ce-4b40-a2ba-de1bd23dc989"), new Guid("0f7de586-1492-4fef-94fd-b16414ea8929") },
                    { new Guid("0fdb1541-18ce-4b40-a2ba-de1bd23dc989"), new Guid("145ab529-7b6f-4b98-9ff5-5d5fa00330e0") },
                    { new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9"), new Guid("2e3abe88-033b-4390-a768-07c7f52cf3ab") },
                    { new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9"), new Guid("61b06b2c-de4f-4a19-9793-9046536ebc9c") },
                    { new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9"), new Guid("6fca925d-1f50-45f6-a8d1-503338f9a8f1") },
                    { new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9"), new Guid("97abd78d-4cfe-49f9-bc37-3e137a297220") },
                    { new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9"), new Guid("b947a1e6-afff-4da2-af17-29671729f71a") },
                    { new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9"), new Guid("c2714bb9-444b-452b-821f-5985b925332f") },
                    { new Guid("191b9022-9bc1-4f5a-b156-3bb16e5adae9"), new Guid("e6a7fbb9-4f23-4124-811e-d75721c23571") },
                    { new Guid("2b175ac0-1680-4f62-9867-b0f2e6a374d3"), new Guid("c2714bb9-444b-452b-821f-5985b925332f") },
                    { new Guid("2b175ac0-1680-4f62-9867-b0f2e6a374d3"), new Guid("e6a7fbb9-4f23-4124-811e-d75721c23571") },
                    { new Guid("2b175ac0-1680-4f62-9867-b0f2e6a374d3"), new Guid("fac08a25-afad-4143-a5c1-dd9a9804f34a") },
                    { new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf"), new Guid("09db73df-e9a1-4b32-a090-29664580a431") },
                    { new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf"), new Guid("293ad3c4-dee0-472e-b51f-e91681114a49") },
                    { new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf"), new Guid("31478264-5c85-483b-b16f-67aa286222df") },
                    { new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf"), new Guid("3306a9ba-7d2b-4e4f-b588-75c5ed44eead") },
                    { new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf"), new Guid("53216d16-e0d4-449b-9766-308c062639f9") },
                    { new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf"), new Guid("85a3522f-24a7-438c-908a-105ad6b70eea") },
                    { new Guid("46b1f31c-020a-46e7-b190-b906a3bf5caf"), new Guid("b154476b-480b-4145-8104-2d8e9fb97bbc") },
                    { new Guid("8f99002a-9475-4e3a-a642-36cfe3658fd2"), new Guid("3670ebf9-2c0e-4404-adb0-08c50df117d4") },
                    { new Guid("8f99002a-9475-4e3a-a642-36cfe3658fd2"), new Guid("385e4268-d3cb-44df-8eac-067ee9d730a8") },
                    { new Guid("8f99002a-9475-4e3a-a642-36cfe3658fd2"), new Guid("fac08a25-afad-4143-a5c1-dd9a9804f34a") },
                    { new Guid("fb29b0be-05e6-4de1-a1ff-6a188b40208a"), new Guid("246fce9f-144a-493f-9a52-bbb36e568ed4") },
                    { new Guid("fb29b0be-05e6-4de1-a1ff-6a188b40208a"), new Guid("59842114-ef9c-4197-b94c-2128552d914a") },
                    { new Guid("fb29b0be-05e6-4de1-a1ff-6a188b40208a"), new Guid("be855681-20b7-4b0c-90c5-904c40b739af") },
                    { new Guid("fb29b0be-05e6-4de1-a1ff-6a188b40208a"), new Guid("e0315d40-6406-49af-8553-cb9955f6416a") },
                    { new Guid("fb29b0be-05e6-4de1-a1ff-6a188b40208a"), new Guid("e0773e70-6f4f-42ba-8423-45e5685e0258") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("27381c58-9e79-45a3-9e8a-bc19a8fa4b45"), new Guid("9100ab93-b749-46ed-86c5-83d7353a4612"), null, "Нет" },
                    { new Guid("2f933710-66aa-4886-af65-4adbbf2f9f11"), new Guid("7660fae2-9ca0-401e-bb57-03e4b4d90123"), null, "База данных" },
                    { new Guid("31b3b631-5138-4fa7-bfb4-8ba451a8ad97"), new Guid("06ab7e3e-1cac-41c5-9d68-7bf28d9b0c98"), null, "Всероссийский" },
                    { new Guid("45fb8917-ceed-4910-b0e4-36a99c286045"), new Guid("8535fd25-7560-4b4f-b8e7-322872c8d902"), null, "Лабораторные" },
                    { new Guid("4f71bcd4-4ec5-4196-8ecb-a0cba4bdecc2"), new Guid("06ab7e3e-1cac-41c5-9d68-7bf28d9b0c98"), null, "Региональный" },
                    { new Guid("5b65582c-7aa2-4b29-9e5b-4d33f753985f"), new Guid("8b7645a4-acbf-43f6-ad80-d4e4484000a6"), null, "Полезная модель" },
                    { new Guid("5ce0423e-4a7f-46d0-ad38-9d030c141f07"), new Guid("e9967d7c-aa33-42a3-bed2-0aa4a5196aa9"), null, "Монография" },
                    { new Guid("5eba9f06-b970-472b-8cba-cb0a64f0063a"), new Guid("9100ab93-b749-46ed-86c5-83d7353a4612"), null, "Есть" },
                    { new Guid("6a7792e3-65d7-4017-a76f-e833abe5e24f"), new Guid("06ab7e3e-1cac-41c5-9d68-7bf28d9b0c98"), null, "Международный" },
                    { new Guid("6d13bbcb-7a4b-4704-9db8-63949a6dd6f1"), new Guid("aea56f79-bec4-4b0e-a5a2-88e8fecbd385"), null, "Иностранный" },
                    { new Guid("7a66dcfb-dfaf-4ccc-9ce9-d7d83dffb949"), new Guid("f2031781-1a63-4cde-b1e7-24755e77176f"), null, "Исполнитель" },
                    { new Guid("8201e6b9-bbf0-46f3-854e-2c8be60a4b70"), new Guid("8535fd25-7560-4b4f-b8e7-322872c8d902"), null, "Лекции" },
                    { new Guid("98751118-624f-4ab2-a7a3-b1192821d268"), new Guid("e9967d7c-aa33-42a3-bed2-0aa4a5196aa9"), null, "Учебник" },
                    { new Guid("b13af4cd-f623-4c02-8593-c187bfe56f1e"), new Guid("8b7645a4-acbf-43f6-ad80-d4e4484000a6"), null, "Изобретение" },
                    { new Guid("c5ef229e-9656-4214-9e3a-65478e84d451"), new Guid("aea56f79-bec4-4b0e-a5a2-88e8fecbd385"), null, "Русский" },
                    { new Guid("c8646a79-52a9-4900-bdaf-18f774190ee5"), new Guid("8b7645a4-acbf-43f6-ad80-d4e4484000a6"), null, "База данных" },
                    { new Guid("ca46f6a6-010b-41b1-8ac6-07b1dee9785e"), new Guid("e9967d7c-aa33-42a3-bed2-0aa4a5196aa9"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("d0f5a4c0-2186-4a80-8d7c-2b03a4387218"), new Guid("7660fae2-9ca0-401e-bb57-03e4b4d90123"), null, "Полезная модель" },
                    { new Guid("def0853b-4452-4850-97ca-4c793a579d23"), new Guid("f2031781-1a63-4cde-b1e7-24755e77176f"), null, "Руководитель" },
                    { new Guid("f44a7451-65a4-4ae8-af8c-ef002fcfd96a"), new Guid("7660fae2-9ca0-401e-bb57-03e4b4d90123"), null, "Изобретение" }
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
