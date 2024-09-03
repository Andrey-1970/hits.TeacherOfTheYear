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
                    { new Guid("2216f661-4a64-4270-8820-7f7306e4b274"), 3, "В процессе рассмотрения" },
                    { new Guid("4e726fa7-9c0f-419e-9f47-daeb7e0ac931"), 5, "Отклонена" },
                    { new Guid("a6bd44cb-fd0a-4fdb-a2d3-af0c814640f9"), 6, "Оценена" },
                    { new Guid("b45b412a-ec4a-4a40-9d97-be280115582f"), 4, "Одобрена" },
                    { new Guid("ceb30454-02ed-45b6-b4e9-19ebbc57243e"), 2, "В ожидании рассмотрения" },
                    { new Guid("e6d13736-e9bf-4f15-95ff-673088d020bf"), 1, "В ожидании заполнения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4217d2f1-998d-4752-b6d2-42e5da244f2d", null, "Admin", "ADMIN" },
                    { "7da0af8f-129c-41d6-b360-e04b35b3011e", null, "Organiser", "ORGANISER" },
                    { "8d5061b5-6c95-4cda-b342-92d19111267d", null, "Expert", "EXPERT" },
                    { "9aa9eb27-a79a-46a7-aea7-58201527530b", null, "Participant", "PARTICIPANT" },
                    { "f10f17e8-7fa9-45ac-b8af-79cf9d7a27d4", null, "Voter", "VOTER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("568baf80-3319-4d7d-a515-668177549f45"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("920f1ca6-d82b-49d4-9d82-21b1c6f19e65"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0e495b14-627a-4d15-97cd-ef4c1b9c2bdb"), "Категория участников", 2 },
                    { new Guid("0e80f5a3-de17-4a37-8f0c-7160a0778d9e"), "Деятельность", 5 },
                    { new Guid("78e24469-91a6-4129-8d74-f8470bdbdaaf"), "Общая информация", 1 },
                    { new Guid("bc171149-d853-46ab-bb9c-aea1409de2e8"), "Деятельность", 4 },
                    { new Guid("e3601379-49ff-4ac7-ab2f-7aa5b61f67f2"), "Профессиональное развитие", 3 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0c2d5754-2636-48ca-8218-8c367b15a23d"), "Инновационная и иная деятельность", 6 },
                    { new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a"), "Образовательная деятельность", 2 },
                    { new Guid("3fabed82-4b6b-4cdd-8f7d-3a7db418756d"), "Конкурсная работа", 7 },
                    { new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd"), "Основной", 1 },
                    { new Guid("9a89ec8e-b4cc-4825-bc5a-724ef14a3365"), "Профессиональные показатели", 4 },
                    { new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("da4d938d-4ef2-47a3-ae08-f202d78e3ee5"), "Методическая деятельность", 3 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("3bcc7087-f4a2-41be-abf2-2d862a870269"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("6ebbbbb7-c487-4c7f-84d3-2e7155362fc8"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc"), "int" },
                    { new Guid("6b3b21b6-b770-4df0-be24-07617a3f5c4d"), "TextArea" },
                    { new Guid("81080d62-7250-4988-b9ec-a11b725fbb87"), "bool" },
                    { new Guid("9a6b5e74-b4f1-42e1-8b86-195c4381d181"), "DateTime" },
                    { new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49"), "string" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0e495b14-627a-4d15-97cd-ef4c1b9c2bdb"), new Guid("3bcc7087-f4a2-41be-abf2-2d862a870269") },
                    { new Guid("0e495b14-627a-4d15-97cd-ef4c1b9c2bdb"), new Guid("6ebbbbb7-c487-4c7f-84d3-2e7155362fc8") },
                    { new Guid("0e80f5a3-de17-4a37-8f0c-7160a0778d9e"), new Guid("6ebbbbb7-c487-4c7f-84d3-2e7155362fc8") },
                    { new Guid("78e24469-91a6-4129-8d74-f8470bdbdaaf"), new Guid("3bcc7087-f4a2-41be-abf2-2d862a870269") },
                    { new Guid("78e24469-91a6-4129-8d74-f8470bdbdaaf"), new Guid("6ebbbbb7-c487-4c7f-84d3-2e7155362fc8") },
                    { new Guid("bc171149-d853-46ab-bb9c-aea1409de2e8"), new Guid("3bcc7087-f4a2-41be-abf2-2d862a870269") },
                    { new Guid("e3601379-49ff-4ac7-ab2f-7aa5b61f67f2"), new Guid("3bcc7087-f4a2-41be-abf2-2d862a870269") },
                    { new Guid("e3601379-49ff-4ac7-ab2f-7aa5b61f67f2"), new Guid("6ebbbbb7-c487-4c7f-84d3-2e7155362fc8") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("00278116-7f0d-409e-9224-011d419aeee4"), new Guid("bc171149-d853-46ab-bb9c-aea1409de2e8"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("1f0d2214-3e26-4e1c-943f-c40d1ec31802"), new Guid("0e495b14-627a-4d15-97cd-ef4c1b9c2bdb"), null, true, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("242fb983-7377-46f3-845c-854f8b0fc720"), new Guid("78e24469-91a6-4129-8d74-f8470bdbdaaf"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("4b208a9b-de6c-45cd-a6d5-9c8a5c355be2"), new Guid("78e24469-91a6-4129-8d74-f8470bdbdaaf"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("4c0847d9-ed81-4df5-843f-d28fc4a47c61"), new Guid("bc171149-d853-46ab-bb9c-aea1409de2e8"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("54a90f7e-d306-4919-b31d-f738fb65f423"), new Guid("0e495b14-627a-4d15-97cd-ef4c1b9c2bdb"), null, false, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("8b235541-dc33-416c-9ab8-f260552d0947"), new Guid("78e24469-91a6-4129-8d74-f8470bdbdaaf"), null, true, true, "Место работы/учебы", 6, "Название организации", new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("91cbc2dc-4ef6-4372-be9c-6a7e45d54815"), new Guid("0e495b14-627a-4d15-97cd-ef4c1b9c2bdb"), null, true, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("9587a134-12ff-428c-a68b-071794f63518"), new Guid("0e80f5a3-de17-4a37-8f0c-7160a0778d9e"), null, false, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("b0a6b87c-4215-4ed7-b231-152768bebdfc"), new Guid("78e24469-91a6-4129-8d74-f8470bdbdaaf"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("b3c24491-c6da-47a4-801e-6398f01c84ea"), new Guid("78e24469-91a6-4129-8d74-f8470bdbdaaf"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("b63cd50d-6925-4578-ae4c-9cc2c6348404"), new Guid("bc171149-d853-46ab-bb9c-aea1409de2e8"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("c7a1cee9-5574-4bbd-a833-b19f8a1b94bb"), new Guid("78e24469-91a6-4129-8d74-f8470bdbdaaf"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("9a6b5e74-b4f1-42e1-8b86-195c4381d181") },
                    { new Guid("cbe0c196-6f27-4fd5-aa6d-e970a85ba15f"), new Guid("78e24469-91a6-4129-8d74-f8470bdbdaaf"), null, false, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("cd3e1045-03ac-4128-83ec-34a7f60b4c62"), new Guid("78e24469-91a6-4129-8d74-f8470bdbdaaf"), null, false, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("dc816470-261b-4762-bd58-82f2de72eff6"), new Guid("0e80f5a3-de17-4a37-8f0c-7160a0778d9e"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("de30041f-7abf-443c-8cb2-92e4ada98059"), new Guid("78e24469-91a6-4129-8d74-f8470bdbdaaf"), null, true, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("df63cce5-5401-428a-9d15-e52f99423e97"), new Guid("78e24469-91a6-4129-8d74-f8470bdbdaaf"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("ecfac8ee-c355-41cf-bf26-43a6d4f20b96"), new Guid("0e495b14-627a-4d15-97cd-ef4c1b9c2bdb"), null, false, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0c2d5754-2636-48ca-8218-8c367b15a23d"), new Guid("6ebbbbb7-c487-4c7f-84d3-2e7155362fc8") },
                    { new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a"), new Guid("3bcc7087-f4a2-41be-abf2-2d862a870269") },
                    { new Guid("3fabed82-4b6b-4cdd-8f7d-3a7db418756d"), new Guid("3bcc7087-f4a2-41be-abf2-2d862a870269") },
                    { new Guid("3fabed82-4b6b-4cdd-8f7d-3a7db418756d"), new Guid("6ebbbbb7-c487-4c7f-84d3-2e7155362fc8") },
                    { new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd"), new Guid("3bcc7087-f4a2-41be-abf2-2d862a870269") },
                    { new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd"), new Guid("6ebbbbb7-c487-4c7f-84d3-2e7155362fc8") },
                    { new Guid("9a89ec8e-b4cc-4825-bc5a-724ef14a3365"), new Guid("3bcc7087-f4a2-41be-abf2-2d862a870269") },
                    { new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4"), new Guid("6ebbbbb7-c487-4c7f-84d3-2e7155362fc8") },
                    { new Guid("da4d938d-4ef2-47a3-ae08-f202d78e3ee5"), new Guid("3bcc7087-f4a2-41be-abf2-2d862a870269") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("106b5ae5-8850-495b-952e-205e1ca9090c"), new Guid("bc171149-d853-46ab-bb9c-aea1409de2e8"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("2b0a98e0-7704-485b-897e-fc6d44d8f392"), new Guid("bc171149-d853-46ab-bb9c-aea1409de2e8"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("2cce40ae-a066-4c90-b72d-06d947900dd4"), new Guid("e3601379-49ff-4ac7-ab2f-7aa5b61f67f2"), true, true, "Персональные идентификаторы", 10 },
                    { new Guid("420df18e-d092-4ae4-87f5-0cd26fe06cb8"), new Guid("0e495b14-627a-4d15-97cd-ef4c1b9c2bdb"), true, true, "Краткая аннотация конкурсной работы", 14 },
                    { new Guid("4661b87f-6714-4861-85d8-00c252fa8a16"), new Guid("0e80f5a3-de17-4a37-8f0c-7160a0778d9e"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("77eb614a-c11a-47aa-b75e-5e7d9c3fb2ce"), new Guid("bc171149-d853-46ab-bb9c-aea1409de2e8"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("9d8e029d-4e19-4240-918a-7bf33e1c1114"), new Guid("0e80f5a3-de17-4a37-8f0c-7160a0778d9e"), false, false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("a398c8e1-fe9a-44ae-b231-1822a68a00a9"), new Guid("bc171149-d853-46ab-bb9c-aea1409de2e8"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("a501c362-4f48-4249-8267-096b76f2c610"), new Guid("bc171149-d853-46ab-bb9c-aea1409de2e8"), false, false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("af53b5bc-75a4-4187-b58f-09676075c5cf"), new Guid("bc171149-d853-46ab-bb9c-aea1409de2e8"), false, false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("c21c755f-bdad-4091-a5bc-3f5205e416a7"), new Guid("e3601379-49ff-4ac7-ab2f-7aa5b61f67f2"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("e327245f-83d9-4d92-bc26-976e89787346"), new Guid("0e80f5a3-de17-4a37-8f0c-7160a0778d9e"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("fd988499-732b-4255-8f66-93fcef93c48d"), new Guid("e3601379-49ff-4ac7-ab2f-7aa5b61f67f2"), false, false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("fe0bcf0c-159a-4213-88d2-99cce9df0f4e"), new Guid("0e80f5a3-de17-4a37-8f0c-7160a0778d9e"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0031aabf-61f8-4d86-a532-eb6d7a895518"), true, "Год", 4, new Guid("a398c8e1-fe9a-44ae-b231-1822a68a00a9"), new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("01af0b95-c8ac-4283-888f-32885d698f19"), true, "Вид деятельности (преподавательская)", 3, new Guid("af53b5bc-75a4-4187-b58f-09676075c5cf"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("01cfae13-8314-4129-84b4-795e2e4ba417"), true, "Ссылка на платформу", 3, new Guid("a398c8e1-fe9a-44ae-b231-1822a68a00a9"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("0648314a-2a7a-4634-9f5c-b6a3a1082452"), true, "ФИО", 1, new Guid("106b5ae5-8850-495b-952e-205e1ca9090c"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("0bf6ef1b-f80c-4180-bf47-be5fa8762742"), true, "Наименование курса", 1, new Guid("77eb614a-c11a-47aa-b75e-5e7d9c3fb2ce"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("1a247c93-6bec-4b7f-8998-2b09f36529ce"), true, "Название статьи", 1, new Guid("9d8e029d-4e19-4240-918a-7bf33e1c1114"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("23095a63-29d1-4d34-af39-60ee1c2e4f2a"), true, "ФИО соавторов", 3, new Guid("4661b87f-6714-4861-85d8-00c252fa8a16"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("238100db-3b59-4086-8676-042df260119c"), true, "Название дисциплины", 1, new Guid("2b0a98e0-7704-485b-897e-fc6d44d8f392"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("23e24f62-083e-44aa-8086-08e39a3c3524"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("af53b5bc-75a4-4187-b58f-09676075c5cf"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("2844155e-d3bd-424e-a441-fefe911f1742"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("2b0a98e0-7704-485b-897e-fc6d44d8f392"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("2870b9ca-de48-4859-b49d-768c66bd24a0"), true, "Значение", 2, new Guid("420df18e-d092-4ae4-87f5-0cd26fe06cb8"), new Guid("6b3b21b6-b770-4df0-be24-07617a3f5c4d") },
                    { new Guid("2bd78dce-11fe-4106-8e02-daa0a3de2514"), true, "Название конкурса", 2, new Guid("fd988499-732b-4255-8f66-93fcef93c48d"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("3b498ed4-db28-4f2e-a8a8-6c24d6306b1a"), true, "Количество часов", 4, new Guid("af53b5bc-75a4-4187-b58f-09676075c5cf"), new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("3d6fddbb-d927-41b3-9a8d-da9adbc9485e"), true, "Вид", 1, new Guid("4661b87f-6714-4861-85d8-00c252fa8a16"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("3f23956e-4bee-4aa2-a3e1-a2eb0e8956e5"), true, "Название документа, реквизиты", 1, new Guid("c21c755f-bdad-4091-a5bc-3f5205e416a7"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("4319d9ad-7b06-4878-89a3-54a049394780"), true, "Название", 2, new Guid("4661b87f-6714-4861-85d8-00c252fa8a16"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("43a411f6-1aa7-4cd9-b512-f39a98e4fd31"), true, "Номер РИД", 4, new Guid("4661b87f-6714-4861-85d8-00c252fa8a16"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("44eed77f-df38-4a15-b8d6-014bcdf2a2e1"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("77eb614a-c11a-47aa-b75e-5e7d9c3fb2ce"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("46f7bb9e-db2c-464e-85f7-73189d08ed34"), true, "Название курса", 1, new Guid("a398c8e1-fe9a-44ae-b231-1822a68a00a9"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("49c32f41-9ec5-4b4b-8b20-ff5c8c4544cf"), true, "Год", 1, new Guid("fd988499-732b-4255-8f66-93fcef93c48d"), new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("4cb0fe81-61ba-452e-9892-ff1716714a33"), true, "Год получения документа", 2, new Guid("c21c755f-bdad-4091-a5bc-3f5205e416a7"), new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("4d5a1ee6-1d8e-4ccd-ae31-19b18e7fb27e"), true, "Вид (лекции, лабораторные)", 2, new Guid("2b0a98e0-7704-485b-897e-fc6d44d8f392"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("54800d50-ef14-4a1c-89f5-9d4597adcd79"), true, "Издательство, год", 6, new Guid("a501c362-4f48-4249-8267-096b76f2c610"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("6067a92a-f1f5-49c2-87cf-6398f02d70f0"), true, "Вид публикации", 1, new Guid("a501c362-4f48-4249-8267-096b76f2c610"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("6bb0bfcb-68c8-433a-84b5-787b88d7f3e3"), true, "Статус (руководитель/исполнитель)", 4, new Guid("fe0bcf0c-159a-4213-88d2-99cce9df0f4e"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("71bd793f-ef40-43fd-849d-69085af368ab"), false, "Тип идентификатора", 1, new Guid("2cce40ae-a066-4c90-b72d-06d947900dd4"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("7c7c9464-5a86-4bf7-9e6e-2fcc59bdfa86"), true, "Наличие грифа", 5, new Guid("a501c362-4f48-4249-8267-096b76f2c610"), new Guid("81080d62-7250-4988-b9ec-a11b725fbb87") },
                    { new Guid("7d4902cc-1c4b-49aa-8061-c3aee68c065d"), true, "Название разработки", 2, new Guid("e327245f-83d9-4d92-bc26-976e89787346"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("878e322f-7920-4d57-8abc-719a756204ea"), true, "Лекции (час.)", 3, new Guid("77eb614a-c11a-47aa-b75e-5e7d9c3fb2ce"), new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("8d0dfd78-6d16-4694-8a85-244a5df64cea"), true, "Соавторы", 2, new Guid("9d8e029d-4e19-4240-918a-7bf33e1c1114"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("924077c5-d525-405d-b1b0-0ce31f90ddb3"), true, "Название НИР/НИОКР", 1, new Guid("fe0bcf0c-159a-4213-88d2-99cce9df0f4e"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("a1d18b38-c387-4f57-bc37-ef4ec1f73997"), true, "Название организации в которую внедрена разработка", 3, new Guid("e327245f-83d9-4d92-bc26-976e89787346"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("a88d23ed-8218-462f-afda-9f63ba18309b"), false, "Соавторы", 3, new Guid("a501c362-4f48-4249-8267-096b76f2c610"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("ad4d8d8f-f352-44bd-a978-ff125f382e05"), true, "Язык публикации", 7, new Guid("a501c362-4f48-4249-8267-096b76f2c610"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("b012df17-8f98-4624-b267-1ed0255fe3ea"), true, "Количество печатных листов", 4, new Guid("a501c362-4f48-4249-8267-096b76f2c610"), new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("b02e467a-3bb7-425c-886b-20bacfd3af29"), true, "Период выполнения", 3, new Guid("fe0bcf0c-159a-4213-88d2-99cce9df0f4e"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("b846e140-bd1d-4d87-9f1a-83b9b34d7411"), true, "Соавторы", 2, new Guid("a398c8e1-fe9a-44ae-b231-1822a68a00a9"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("bce42912-1f1d-4f42-b628-72ae36fe5372"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("106b5ae5-8850-495b-952e-205e1ca9090c"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("bd72b4f7-ee00-44cb-8bd5-64618469531e"), true, "Название", 1, new Guid("420df18e-d092-4ae4-87f5-0cd26fe06cb8"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("c0526bcf-884d-4f29-9a62-273cf926e971"), true, "Награда", 4, new Guid("fd988499-732b-4255-8f66-93fcef93c48d"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("c95613c7-0480-4dbc-9c56-2b0f35a91195"), true, "Итого (час.)", 5, new Guid("77eb614a-c11a-47aa-b75e-5e7d9c3fb2ce"), new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("cc2c9b55-c9e5-42cf-94cc-2dfd048ccd81"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("9d8e029d-4e19-4240-918a-7bf33e1c1114"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("cf55f509-4e78-4851-ae09-4537e15492b7"), true, "Вид", 1, new Guid("e327245f-83d9-4d92-bc26-976e89787346"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("d312793d-7ef3-440a-90b3-72453cd162bb"), true, "Статус конкурса", 3, new Guid("fd988499-732b-4255-8f66-93fcef93c48d"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("e4e706c4-2212-46e9-ab13-3636eeecd89b"), true, "Название конкурса/премии", 2, new Guid("106b5ae5-8850-495b-952e-205e1ca9090c"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("e619707f-4602-4e4d-9436-f5db6cf543a8"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("106b5ae5-8850-495b-952e-205e1ca9090c"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("ef2f3e49-1bee-4073-b703-398f6aae7e96"), true, "Год", 3, new Guid("106b5ae5-8850-495b-952e-205e1ca9090c"), new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("efa744a3-dd97-4a21-b376-8820c280bfe0"), true, "Название", 2, new Guid("a501c362-4f48-4249-8267-096b76f2c610"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("f291d87a-5d2b-4813-b150-6722a777b830"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("fe0bcf0c-159a-4213-88d2-99cce9df0f4e"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("f2932e62-b3ec-4728-931f-ca02a5197438"), true, "Название организации/должность/ставка", 1, new Guid("af53b5bc-75a4-4187-b58f-09676075c5cf"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("f32f424b-8546-43a0-af0a-c5ac05c20b19"), true, "Практические занятия (час.)", 4, new Guid("77eb614a-c11a-47aa-b75e-5e7d9c3fb2ce"), new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("f38bec2d-365d-40a9-9c57-5813542bd52b"), false, "Идентификатор", 2, new Guid("2cce40ae-a066-4c90-b72d-06d947900dd4"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("f5d5f9db-bc73-4035-8afc-71d6250fe9d2"), true, "Ссылка на открытый доступ", 8, new Guid("a501c362-4f48-4249-8267-096b76f2c610"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("f6016f7d-5517-4cfe-9f23-240bfa4842c0"), true, "Издание, год", 4, new Guid("9d8e029d-4e19-4240-918a-7bf33e1c1114"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") },
                    { new Guid("f6af7299-51e5-41b7-9526-6d21cd6fb4ee"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("fe0bcf0c-159a-4213-88d2-99cce9df0f4e"), new Guid("65f857a3-5bc0-4204-aa6c-9fc07e8662cc") },
                    { new Guid("fbc2e568-9967-4f43-9706-161cf0b0080f"), true, "Ссылка", 5, new Guid("fd988499-732b-4255-8f66-93fcef93c48d"), new Guid("b01ac1b2-814a-4e67-86d6-0f1d6288cc49") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("00278116-7f0d-409e-9224-011d419aeee4"), new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a") },
                    { new Guid("1f0d2214-3e26-4e1c-943f-c40d1ec31802"), new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd") },
                    { new Guid("1f0d2214-3e26-4e1c-943f-c40d1ec31802"), new Guid("9a89ec8e-b4cc-4825-bc5a-724ef14a3365") },
                    { new Guid("1f0d2214-3e26-4e1c-943f-c40d1ec31802"), new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4") },
                    { new Guid("242fb983-7377-46f3-845c-854f8b0fc720"), new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd") },
                    { new Guid("4b208a9b-de6c-45cd-a6d5-9c8a5c355be2"), new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd") },
                    { new Guid("4c0847d9-ed81-4df5-843f-d28fc4a47c61"), new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a") },
                    { new Guid("54a90f7e-d306-4919-b31d-f738fb65f423"), new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd") },
                    { new Guid("8b235541-dc33-416c-9ab8-f260552d0947"), new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd") },
                    { new Guid("91cbc2dc-4ef6-4372-be9c-6a7e45d54815"), new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd") },
                    { new Guid("9587a134-12ff-428c-a68b-071794f63518"), new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4") },
                    { new Guid("b0a6b87c-4215-4ed7-b231-152768bebdfc"), new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd") },
                    { new Guid("b3c24491-c6da-47a4-801e-6398f01c84ea"), new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd") },
                    { new Guid("b63cd50d-6925-4578-ae4c-9cc2c6348404"), new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a") },
                    { new Guid("c7a1cee9-5574-4bbd-a833-b19f8a1b94bb"), new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd") },
                    { new Guid("cbe0c196-6f27-4fd5-aa6d-e970a85ba15f"), new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd") },
                    { new Guid("cd3e1045-03ac-4128-83ec-34a7f60b4c62"), new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd") },
                    { new Guid("dc816470-261b-4762-bd58-82f2de72eff6"), new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4") },
                    { new Guid("de30041f-7abf-443c-8cb2-92e4ada98059"), new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd") },
                    { new Guid("df63cce5-5401-428a-9d15-e52f99423e97"), new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd") },
                    { new Guid("ecfac8ee-c355-41cf-bf26-43a6d4f20b96"), new Guid("7d327318-1b95-4429-a3f4-9b2d27fc8bdd") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("0c2d5754-2636-48ca-8218-8c367b15a23d"), new Guid("4661b87f-6714-4861-85d8-00c252fa8a16") },
                    { new Guid("0c2d5754-2636-48ca-8218-8c367b15a23d"), new Guid("c21c755f-bdad-4091-a5bc-3f5205e416a7") },
                    { new Guid("0c2d5754-2636-48ca-8218-8c367b15a23d"), new Guid("e327245f-83d9-4d92-bc26-976e89787346") },
                    { new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a"), new Guid("106b5ae5-8850-495b-952e-205e1ca9090c") },
                    { new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a"), new Guid("77eb614a-c11a-47aa-b75e-5e7d9c3fb2ce") },
                    { new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a"), new Guid("a398c8e1-fe9a-44ae-b231-1822a68a00a9") },
                    { new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a"), new Guid("af53b5bc-75a4-4187-b58f-09676075c5cf") },
                    { new Guid("3fabed82-4b6b-4cdd-8f7d-3a7db418756d"), new Guid("420df18e-d092-4ae4-87f5-0cd26fe06cb8") },
                    { new Guid("9a89ec8e-b4cc-4825-bc5a-724ef14a3365"), new Guid("c21c755f-bdad-4091-a5bc-3f5205e416a7") },
                    { new Guid("9a89ec8e-b4cc-4825-bc5a-724ef14a3365"), new Guid("fd988499-732b-4255-8f66-93fcef93c48d") },
                    { new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4"), new Guid("2cce40ae-a066-4c90-b72d-06d947900dd4") },
                    { new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4"), new Guid("9d8e029d-4e19-4240-918a-7bf33e1c1114") },
                    { new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4"), new Guid("fd988499-732b-4255-8f66-93fcef93c48d") },
                    { new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4"), new Guid("fe0bcf0c-159a-4213-88d2-99cce9df0f4e") },
                    { new Guid("da4d938d-4ef2-47a3-ae08-f202d78e3ee5"), new Guid("2b0a98e0-7704-485b-897e-fc6d44d8f392") },
                    { new Guid("da4d938d-4ef2-47a3-ae08-f202d78e3ee5"), new Guid("a501c362-4f48-4249-8267-096b76f2c610") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0cfd810b-133d-4777-9a88-90224b7d2769"), "EvaluateMark13", new Guid("1f0d2214-3e26-4e1c-943f-c40d1ec31802"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("0d691f9d-f668-4f4e-8edd-cd3f20165b89"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("fd988499-732b-4255-8f66-93fcef93c48d") },
                    { new Guid("143d8144-bffd-4ef8-b377-167a0865e107"), "EvaluateMark5", new Guid("4c0847d9-ed81-4df5-843f-d28fc4a47c61"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("2403cc33-5b0b-4da5-b7c0-a4545cfdfb03"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("c21c755f-bdad-4091-a5bc-3f5205e416a7") },
                    { new Guid("365af9cd-310a-48da-9eb9-53c90a33f648"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("e327245f-83d9-4d92-bc26-976e89787346") },
                    { new Guid("38c4eeae-6507-49f5-a42b-f2fd9ae21702"), "EvaluateMark3", new Guid("00278116-7f0d-409e-9224-011d419aeee4"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("4a123172-fb20-4fa7-bceb-d2e61cdc9b35"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("a501c362-4f48-4249-8267-096b76f2c610") },
                    { new Guid("4d786230-8090-466c-a526-afd082d59dfc"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("fe0bcf0c-159a-4213-88d2-99cce9df0f4e") },
                    { new Guid("6b7515ae-2e4d-4d11-a3c9-0b4ff25b0268"), "EvaluateMark19", new Guid("dc816470-261b-4762-bd58-82f2de72eff6"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("721f1580-adef-450d-b41b-b62a27b47d5e"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("106b5ae5-8850-495b-952e-205e1ca9090c") },
                    { new Guid("7c11f4a5-8793-46dc-acc7-1272205d3ae0"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("a398c8e1-fe9a-44ae-b231-1822a68a00a9") },
                    { new Guid("8cfc4838-95a5-423f-b167-3f2bcef111a1"), "EvaluateMark4", new Guid("b63cd50d-6925-4578-ae4c-9cc2c6348404"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("95e9a5cd-d463-4c3f-adec-b532fb56b82d"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("2b0a98e0-7704-485b-897e-fc6d44d8f392") },
                    { new Guid("b19c307c-9abd-42c2-8d4c-4c2d13a7491c"), null, null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("420df18e-d092-4ae4-87f5-0cd26fe06cb8") },
                    { new Guid("c26dc76b-4783-4814-8c6d-1c149ddcbf79"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("a501c362-4f48-4249-8267-096b76f2c610") },
                    { new Guid("cbe51dbd-0239-41ae-9acb-07453c8d6dd8"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("a501c362-4f48-4249-8267-096b76f2c610") },
                    { new Guid("d296679e-7f8b-47fb-9413-bf9ac9591ea1"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("a501c362-4f48-4249-8267-096b76f2c610") },
                    { new Guid("d58844d3-5f44-444b-84a5-ed05b0ab3e12"), "EvaluateMark20", new Guid("9587a134-12ff-428c-a68b-071794f63518"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("d919b2a6-2d33-4d63-94fc-20a51af0ae2b"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("77eb614a-c11a-47aa-b75e-5e7d9c3fb2ce") },
                    { new Guid("d9e5ca02-e409-4d74-a43a-fc80cbbc9aa3"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("9d8e029d-4e19-4240-918a-7bf33e1c1114") },
                    { new Guid("dca77c1a-4f8d-48b5-a4f8-991903e1cdb1"), null, null, false, 10, "Оценка уровня предоставленной работы:", 25, new Guid("420df18e-d092-4ae4-87f5-0cd26fe06cb8") },
                    { new Guid("dd2cb777-452b-4904-83fa-50c9b995134d"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("fe0bcf0c-159a-4213-88d2-99cce9df0f4e") },
                    { new Guid("de2122f4-91a8-4083-8b8f-f9c35ce80577"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("77eb614a-c11a-47aa-b75e-5e7d9c3fb2ce") },
                    { new Guid("de755bf0-6526-490a-a36d-d77504490cd5"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("4661b87f-6714-4861-85d8-00c252fa8a16") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("372570d2-b8e5-4159-8cdd-7dc5d07566b1"), true, new Guid("2cce40ae-a066-4c90-b72d-06d947900dd4") },
                    { new Guid("4c9d50e7-881f-460d-8515-9f160a5fde97"), true, new Guid("420df18e-d092-4ae4-87f5-0cd26fe06cb8") },
                    { new Guid("70c4acb7-64aa-46d4-a25a-86c2556acc53"), true, new Guid("2cce40ae-a066-4c90-b72d-06d947900dd4") },
                    { new Guid("7c6d7fbc-b1e2-4832-9751-6971c818b00c"), true, new Guid("2cce40ae-a066-4c90-b72d-06d947900dd4") },
                    { new Guid("7d6f738d-17c8-47da-8a0b-661bfb43b403"), true, new Guid("420df18e-d092-4ae4-87f5-0cd26fe06cb8") },
                    { new Guid("97b9e443-147d-480c-8d03-d5a6c92d4754"), true, new Guid("420df18e-d092-4ae4-87f5-0cd26fe06cb8") },
                    { new Guid("9c22e8f5-d94d-48b1-8cdb-f4eec9bf18b4"), true, new Guid("420df18e-d092-4ae4-87f5-0cd26fe06cb8") },
                    { new Guid("a8d839a5-3fae-420e-8189-bb174f043de0"), true, new Guid("420df18e-d092-4ae4-87f5-0cd26fe06cb8") },
                    { new Guid("ba54e270-9203-43a9-889f-a5eac891d7bb"), true, new Guid("2cce40ae-a066-4c90-b72d-06d947900dd4") },
                    { new Guid("c60d4623-8597-4192-8aa6-fa4368fb23c0"), true, new Guid("420df18e-d092-4ae4-87f5-0cd26fe06cb8") },
                    { new Guid("ce6bce24-b73d-4401-9530-1eada73b5848"), true, new Guid("420df18e-d092-4ae4-87f5-0cd26fe06cb8") },
                    { new Guid("d29115dd-4a34-40f3-bbf1-52c46f909bb0"), true, new Guid("2cce40ae-a066-4c90-b72d-06d947900dd4") },
                    { new Guid("fef86462-e1e6-40a2-8ddc-f5ec0a955980"), true, new Guid("420df18e-d092-4ae4-87f5-0cd26fe06cb8") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("24999737-c581-4a0c-9000-ee1be2f1cfa2"), null, new Guid("1f0d2214-3e26-4e1c-943f-c40d1ec31802"), "Профессор" },
                    { new Guid("4c26eddd-f712-4bf5-8195-1d2af2107c9e"), null, new Guid("ecfac8ee-c355-41cf-bf26-43a6d4f20b96"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("8146a6dd-8323-4caa-b88c-e73960c9ba63"), null, new Guid("1f0d2214-3e26-4e1c-943f-c40d1ec31802"), "Доцент" },
                    { new Guid("9eff6fb1-aa97-43fe-90e0-7584672a3207"), null, new Guid("ecfac8ee-c355-41cf-bf26-43a6d4f20b96"), "Имеющие ученую степень доктора наук" },
                    { new Guid("c6b81e81-f48c-4d0d-b7d1-6027330348db"), null, new Guid("1f0d2214-3e26-4e1c-943f-c40d1ec31802"), "Нет" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("2b66fa5f-21f2-444d-98f7-51aa73ed76cd"), null, new Guid("71bd793f-ef40-43fd-849d-69085af368ab"), true, true, new Guid("ba54e270-9203-43a9-889f-a5eac891d7bb"), "РИНЦ AuthorID" },
                    { new Guid("2c41c499-a3c1-4f12-9f3e-5434eff6ca7c"), null, new Guid("71bd793f-ef40-43fd-849d-69085af368ab"), true, true, new Guid("70c4acb7-64aa-46d4-a25a-86c2556acc53"), "ScopusID" },
                    { new Guid("2f133f64-436e-4cfa-a402-4533217dbfef"), null, new Guid("bd72b4f7-ee00-44cb-8bd5-64618469531e"), true, true, new Guid("9c22e8f5-d94d-48b1-8cdb-f4eec9bf18b4"), "Методология и методы, используемые в работе" },
                    { new Guid("36fbc6bd-7a81-499d-b3f4-2ec4d9888682"), null, new Guid("2870b9ca-de48-4859-b49d-768c66bd24a0"), false, true, new Guid("7d6f738d-17c8-47da-8a0b-661bfb43b403"), null },
                    { new Guid("454a5133-0369-45bc-9f80-3301c32d9c46"), null, new Guid("71bd793f-ef40-43fd-849d-69085af368ab"), true, true, new Guid("372570d2-b8e5-4159-8cdd-7dc5d07566b1"), "ResearcherID" },
                    { new Guid("4edbdfdc-5a02-48f3-8231-99cafd61b60f"), null, new Guid("2870b9ca-de48-4859-b49d-768c66bd24a0"), false, true, new Guid("4c9d50e7-881f-460d-8515-9f160a5fde97"), null },
                    { new Guid("5bcf8be0-f008-4bc4-900f-4900514b6980"), null, new Guid("f38bec2d-365d-40a9-9c57-5813542bd52b"), false, true, new Guid("d29115dd-4a34-40f3-bbf1-52c46f909bb0"), null },
                    { new Guid("611c7996-ffa7-4d44-a1f6-cd3f07c7ed2a"), null, new Guid("bd72b4f7-ee00-44cb-8bd5-64618469531e"), true, true, new Guid("c60d4623-8597-4192-8aa6-fa4368fb23c0"), "Результаты и выводы" },
                    { new Guid("659b1d61-564b-4b17-965f-b47cc697a595"), null, new Guid("2870b9ca-de48-4859-b49d-768c66bd24a0"), false, true, new Guid("97b9e443-147d-480c-8d03-d5a6c92d4754"), null },
                    { new Guid("687dbd80-115c-452a-9020-dc982a8ab0d6"), null, new Guid("bd72b4f7-ee00-44cb-8bd5-64618469531e"), true, true, new Guid("ce6bce24-b73d-4401-9530-1eada73b5848"), "Ссылка на конкурсную работу" },
                    { new Guid("6dfbd7e8-b76a-42c7-8929-9407e41ec132"), null, new Guid("2870b9ca-de48-4859-b49d-768c66bd24a0"), false, true, new Guid("9c22e8f5-d94d-48b1-8cdb-f4eec9bf18b4"), null },
                    { new Guid("745b3a88-73f3-470b-9aae-756c1e327603"), null, new Guid("bd72b4f7-ee00-44cb-8bd5-64618469531e"), true, true, new Guid("97b9e443-147d-480c-8d03-d5a6c92d4754"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("7c21e6fe-15ba-49fe-931f-9c47aed3d4c0"), null, new Guid("bd72b4f7-ee00-44cb-8bd5-64618469531e"), true, true, new Guid("4c9d50e7-881f-460d-8515-9f160a5fde97"), "Актуальность конкурсной работы" },
                    { new Guid("7da728f1-aa25-475a-b707-ebf38052b009"), null, new Guid("bd72b4f7-ee00-44cb-8bd5-64618469531e"), true, true, new Guid("fef86462-e1e6-40a2-8ddc-f5ec0a955980"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("9f888cba-0cb8-4590-9b09-33900f9949ba"), null, new Guid("2870b9ca-de48-4859-b49d-768c66bd24a0"), false, true, new Guid("fef86462-e1e6-40a2-8ddc-f5ec0a955980"), null },
                    { new Guid("9fac8f23-8802-4fdf-8dbe-8e7a13aa9774"), null, new Guid("2870b9ca-de48-4859-b49d-768c66bd24a0"), false, true, new Guid("a8d839a5-3fae-420e-8189-bb174f043de0"), null },
                    { new Guid("ac6a20d0-4dd4-459c-842d-e27fe4669480"), null, new Guid("f38bec2d-365d-40a9-9c57-5813542bd52b"), false, true, new Guid("ba54e270-9203-43a9-889f-a5eac891d7bb"), null },
                    { new Guid("b5a05b0e-bfbe-4e6b-82f4-653440e38d75"), null, new Guid("f38bec2d-365d-40a9-9c57-5813542bd52b"), false, true, new Guid("70c4acb7-64aa-46d4-a25a-86c2556acc53"), null },
                    { new Guid("bc52d03f-7313-421f-afea-f98ece8ebb52"), null, new Guid("bd72b4f7-ee00-44cb-8bd5-64618469531e"), true, true, new Guid("7d6f738d-17c8-47da-8a0b-661bfb43b403"), "Инновационность" },
                    { new Guid("c00b6315-c494-462e-b8e7-587cd1263b17"), null, new Guid("2870b9ca-de48-4859-b49d-768c66bd24a0"), false, true, new Guid("c60d4623-8597-4192-8aa6-fa4368fb23c0"), null },
                    { new Guid("c4ba6d6a-b067-40cf-8a0b-f49c7621c0c8"), null, new Guid("2870b9ca-de48-4859-b49d-768c66bd24a0"), false, true, new Guid("ce6bce24-b73d-4401-9530-1eada73b5848"), null },
                    { new Guid("d0394c59-119b-47a4-b305-c934ff4c0df9"), null, new Guid("71bd793f-ef40-43fd-849d-69085af368ab"), true, true, new Guid("d29115dd-4a34-40f3-bbf1-52c46f909bb0"), "ORCiD" },
                    { new Guid("dd1d259d-9458-4446-ab0d-bb35b27d2f91"), null, new Guid("bd72b4f7-ee00-44cb-8bd5-64618469531e"), true, true, new Guid("a8d839a5-3fae-420e-8189-bb174f043de0"), "Название работы" },
                    { new Guid("f40dc752-9dc9-4694-9e31-76aad68921fa"), null, new Guid("f38bec2d-365d-40a9-9c57-5813542bd52b"), false, true, new Guid("7c6d7fbc-b1e2-4832-9751-6971c818b00c"), null },
                    { new Guid("f6f54e7a-fb4f-4251-b1d0-f24bdb0acb68"), null, new Guid("f38bec2d-365d-40a9-9c57-5813542bd52b"), false, true, new Guid("372570d2-b8e5-4159-8cdd-7dc5d07566b1"), null },
                    { new Guid("fc93729b-81a1-408f-bc5e-a17258b9e44c"), null, new Guid("71bd793f-ef40-43fd-849d-69085af368ab"), true, true, new Guid("7c6d7fbc-b1e2-4832-9751-6971c818b00c"), "Google Scholar ID" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("0c2d5754-2636-48ca-8218-8c367b15a23d"), new Guid("2403cc33-5b0b-4da5-b7c0-a4545cfdfb03") },
                    { new Guid("0c2d5754-2636-48ca-8218-8c367b15a23d"), new Guid("365af9cd-310a-48da-9eb9-53c90a33f648") },
                    { new Guid("0c2d5754-2636-48ca-8218-8c367b15a23d"), new Guid("de755bf0-6526-490a-a36d-d77504490cd5") },
                    { new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a"), new Guid("143d8144-bffd-4ef8-b377-167a0865e107") },
                    { new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a"), new Guid("38c4eeae-6507-49f5-a42b-f2fd9ae21702") },
                    { new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a"), new Guid("721f1580-adef-450d-b41b-b62a27b47d5e") },
                    { new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a"), new Guid("7c11f4a5-8793-46dc-acc7-1272205d3ae0") },
                    { new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a"), new Guid("8cfc4838-95a5-423f-b167-3f2bcef111a1") },
                    { new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a"), new Guid("d919b2a6-2d33-4d63-94fc-20a51af0ae2b") },
                    { new Guid("2a36b144-e5c9-4afc-abca-3f5da981af6a"), new Guid("de2122f4-91a8-4083-8b8f-f9c35ce80577") },
                    { new Guid("3fabed82-4b6b-4cdd-8f7d-3a7db418756d"), new Guid("b19c307c-9abd-42c2-8d4c-4c2d13a7491c") },
                    { new Guid("3fabed82-4b6b-4cdd-8f7d-3a7db418756d"), new Guid("dca77c1a-4f8d-48b5-a4f8-991903e1cdb1") },
                    { new Guid("9a89ec8e-b4cc-4825-bc5a-724ef14a3365"), new Guid("0cfd810b-133d-4777-9a88-90224b7d2769") },
                    { new Guid("9a89ec8e-b4cc-4825-bc5a-724ef14a3365"), new Guid("0d691f9d-f668-4f4e-8edd-cd3f20165b89") },
                    { new Guid("9a89ec8e-b4cc-4825-bc5a-724ef14a3365"), new Guid("2403cc33-5b0b-4da5-b7c0-a4545cfdfb03") },
                    { new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4"), new Guid("0cfd810b-133d-4777-9a88-90224b7d2769") },
                    { new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4"), new Guid("0d691f9d-f668-4f4e-8edd-cd3f20165b89") },
                    { new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4"), new Guid("4d786230-8090-466c-a526-afd082d59dfc") },
                    { new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4"), new Guid("6b7515ae-2e4d-4d11-a3c9-0b4ff25b0268") },
                    { new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4"), new Guid("d58844d3-5f44-444b-84a5-ed05b0ab3e12") },
                    { new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4"), new Guid("d9e5ca02-e409-4d74-a43a-fc80cbbc9aa3") },
                    { new Guid("9bdb2739-4a91-4292-bb2b-7d406b75f8f4"), new Guid("dd2cb777-452b-4904-83fa-50c9b995134d") },
                    { new Guid("da4d938d-4ef2-47a3-ae08-f202d78e3ee5"), new Guid("4a123172-fb20-4fa7-bceb-d2e61cdc9b35") },
                    { new Guid("da4d938d-4ef2-47a3-ae08-f202d78e3ee5"), new Guid("95e9a5cd-d463-4c3f-adec-b532fb56b82d") },
                    { new Guid("da4d938d-4ef2-47a3-ae08-f202d78e3ee5"), new Guid("c26dc76b-4783-4814-8c6d-1c149ddcbf79") },
                    { new Guid("da4d938d-4ef2-47a3-ae08-f202d78e3ee5"), new Guid("cbe51dbd-0239-41ae-9acb-07453c8d6dd8") },
                    { new Guid("da4d938d-4ef2-47a3-ae08-f202d78e3ee5"), new Guid("d296679e-7f8b-47fb-9413-bf9ac9591ea1") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("032b0c8e-572a-4b3e-9060-984c1d845f7a"), new Guid("3d6fddbb-d927-41b3-9a8d-da9adbc9485e"), null, "Изобретение" },
                    { new Guid("251415d7-752c-4371-aef8-b4ff248c2ea0"), new Guid("ad4d8d8f-f352-44bd-a978-ff125f382e05"), null, "Иностранный" },
                    { new Guid("26c9a4ad-4331-418a-9878-fe82e713875f"), new Guid("4d5a1ee6-1d8e-4ccd-ae31-19b18e7fb27e"), null, "Лекции" },
                    { new Guid("2c7dc8c5-0f1e-48bc-9dd2-c38da0c4f671"), new Guid("d312793d-7ef3-440a-90b3-72453cd162bb"), null, "Региональный" },
                    { new Guid("2dbe2414-04b2-42fa-890e-22fb7ba30b5c"), new Guid("6bb0bfcb-68c8-433a-84b5-787b88d7f3e3"), null, "Руководитель" },
                    { new Guid("39f56909-0d09-4702-8355-345797345aa0"), new Guid("6067a92a-f1f5-49c2-87cf-6398f02d70f0"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("5276f96b-d20b-4bef-bbd0-33527eea201c"), new Guid("a88d23ed-8218-462f-afda-9f63ba18309b"), null, "Нет" },
                    { new Guid("57eb10d9-3e91-44f3-b811-4abe44f2aee4"), new Guid("d312793d-7ef3-440a-90b3-72453cd162bb"), null, "Всероссийский" },
                    { new Guid("64faab79-616d-49df-9f25-e36f0e302cd9"), new Guid("6067a92a-f1f5-49c2-87cf-6398f02d70f0"), null, "Учебник" },
                    { new Guid("6f7e1b16-748b-46f2-94d0-31c19cd2474e"), new Guid("3d6fddbb-d927-41b3-9a8d-da9adbc9485e"), null, "База данных" },
                    { new Guid("78778756-0229-40b8-a868-5584dfb3f2e9"), new Guid("6bb0bfcb-68c8-433a-84b5-787b88d7f3e3"), null, "Исполнитель" },
                    { new Guid("88d31a88-576f-4d23-805f-b083e3746a83"), new Guid("cf55f509-4e78-4851-ae09-4537e15492b7"), null, "Изобретение" },
                    { new Guid("8cf7f295-5c3c-4810-a5d4-72af7e2fc56f"), new Guid("6067a92a-f1f5-49c2-87cf-6398f02d70f0"), null, "Монография" },
                    { new Guid("9231e843-4e41-456f-b2a2-f8fc25ccc3ff"), new Guid("3d6fddbb-d927-41b3-9a8d-da9adbc9485e"), null, "Полезная модель" },
                    { new Guid("9caf07e2-5f1e-49dc-9dea-eba0e909c234"), new Guid("ad4d8d8f-f352-44bd-a978-ff125f382e05"), null, "Русский" },
                    { new Guid("b8e52c70-c088-450b-a47a-d78a58ed8365"), new Guid("d312793d-7ef3-440a-90b3-72453cd162bb"), null, "Международный" },
                    { new Guid("bce51400-9029-4c6c-bfd6-7534a6165344"), new Guid("4d5a1ee6-1d8e-4ccd-ae31-19b18e7fb27e"), null, "Лабораторные" },
                    { new Guid("bf3129b3-b3de-4e24-b007-824148dc5789"), new Guid("cf55f509-4e78-4851-ae09-4537e15492b7"), null, "Полезная модель" },
                    { new Guid("c336672d-1f14-43f7-9d01-ddd49f92ab4b"), new Guid("cf55f509-4e78-4851-ae09-4537e15492b7"), null, "База данных" },
                    { new Guid("cff66a2b-b90a-406d-9ab0-236df0468d19"), new Guid("a88d23ed-8218-462f-afda-9f63ba18309b"), null, "Есть" }
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
