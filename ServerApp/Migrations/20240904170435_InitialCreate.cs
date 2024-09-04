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
                    { new Guid("2a76e94f-2546-4396-b736-22ebe111b88a"), 1, "В ожидании заполнения" },
                    { new Guid("40636cd6-e8ae-4b5b-bc06-f29adf1b30e3"), 5, "Отклонена" },
                    { new Guid("59b23276-76d2-470b-9a4c-1cbb29e00d9d"), 6, "Оценена" },
                    { new Guid("5d765973-071c-40cc-8558-db10009b5024"), 4, "Одобрена" },
                    { new Guid("7b625e48-beee-4ee8-a506-10036a5e65a4"), 2, "В ожидании рассмотрения" },
                    { new Guid("9f4eb9c3-d6b5-4e95-99a6-65ca0e5f9797"), 3, "В процессе рассмотрения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "303798bc-123d-4d29-a90b-bd5e01894b35", null, "Expert", "EXPERT" },
                    { "5b669d73-7508-4763-8cf0-32cd83eced24", null, "Admin", "ADMIN" },
                    { "7bbf4c5e-1f09-4e7b-989e-38da706ae389", null, "Voter", "VOTER" },
                    { "97055bad-06da-498a-988e-7a75d1b09459", null, "Organiser", "ORGANISER" },
                    { "d412f2db-c470-48c4-af6b-48cb526c9a48", null, "Participant", "PARTICIPANT" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("6cd1e44f-3e5a-4be7-bbbf-60efdb976454"), "Строительство и архитектура", 1 },
                    { new Guid("ca7e113b-0f70-4ea4-be0e-0c9ca7403f23"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("2633d2f7-9d3e-42fc-997d-e102e0358ed7"), "Деятельность", 5 },
                    { new Guid("3261204d-6cee-47c7-8720-d0b1094ab99a"), "Категория участников", 2 },
                    { new Guid("75471bdc-c4f7-4c1a-bcfe-dcd552a66325"), "Профессиональное развитие", 3 },
                    { new Guid("912b46ce-2a54-4496-889c-92cf69749b39"), "Деятельность", 4 },
                    { new Guid("f84f1f1a-140d-4304-9c3c-2b18436f01f4"), "Общая информация", 1 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("018546a7-1999-4648-8494-cef7ae2a41a4"), "Образовательная деятельность", 2 },
                    { new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("8c82806f-46ec-477c-b0c2-edec8f105c8b"), "Профессиональные показатели", 4 },
                    { new Guid("b2c56947-3193-4a85-86c9-e4225acb6c13"), "Методическая деятельность", 3 },
                    { new Guid("b78d4cd3-c30d-4336-8b32-6db3b072b0a7"), "Инновационная и иная деятельность", 6 },
                    { new Guid("deb64947-8cca-4cc6-b2d7-aa068876d1f0"), "Конкурсная работа", 7 },
                    { new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8"), "Основной", 1 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("42490083-2b0a-4fb7-968e-783f3059e926"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("87208b10-2eba-4975-978e-1a8a3e929876"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6"), "string" },
                    { new Guid("7a248a1e-1a44-4c90-b761-a2354275ec1d"), "bool" },
                    { new Guid("a29c10b5-e74c-454c-b284-4bb03e023da7"), "TextArea" },
                    { new Guid("a3d4d7de-5d4a-4e2f-b7b4-47c1b320b38a"), "DateTime" },
                    { new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa"), "int" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("2633d2f7-9d3e-42fc-997d-e102e0358ed7"), new Guid("87208b10-2eba-4975-978e-1a8a3e929876") },
                    { new Guid("3261204d-6cee-47c7-8720-d0b1094ab99a"), new Guid("42490083-2b0a-4fb7-968e-783f3059e926") },
                    { new Guid("3261204d-6cee-47c7-8720-d0b1094ab99a"), new Guid("87208b10-2eba-4975-978e-1a8a3e929876") },
                    { new Guid("75471bdc-c4f7-4c1a-bcfe-dcd552a66325"), new Guid("42490083-2b0a-4fb7-968e-783f3059e926") },
                    { new Guid("75471bdc-c4f7-4c1a-bcfe-dcd552a66325"), new Guid("87208b10-2eba-4975-978e-1a8a3e929876") },
                    { new Guid("912b46ce-2a54-4496-889c-92cf69749b39"), new Guid("42490083-2b0a-4fb7-968e-783f3059e926") },
                    { new Guid("f84f1f1a-140d-4304-9c3c-2b18436f01f4"), new Guid("42490083-2b0a-4fb7-968e-783f3059e926") },
                    { new Guid("f84f1f1a-140d-4304-9c3c-2b18436f01f4"), new Guid("87208b10-2eba-4975-978e-1a8a3e929876") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("066c0316-8a53-4a63-966a-2fb92c5e6942"), new Guid("f84f1f1a-140d-4304-9c3c-2b18436f01f4"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("1aa3dd0a-d5c3-4707-8b76-bdd6f281608f"), new Guid("f84f1f1a-140d-4304-9c3c-2b18436f01f4"), null, false, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("1e80c81a-0f98-4c6d-8c1b-366729adcadc"), new Guid("912b46ce-2a54-4496-889c-92cf69749b39"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("2f00c35b-196e-4220-8e05-e41f470b1faa"), new Guid("3261204d-6cee-47c7-8720-d0b1094ab99a"), null, true, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("366e943f-f9fb-49b9-b97a-fd45785211d1"), new Guid("f84f1f1a-140d-4304-9c3c-2b18436f01f4"), null, false, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("386b4d0c-415a-44ae-b0ff-96d0664208b9"), new Guid("3261204d-6cee-47c7-8720-d0b1094ab99a"), null, false, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("3d261b2d-5712-47db-a982-d51b7eb76aa5"), new Guid("f84f1f1a-140d-4304-9c3c-2b18436f01f4"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("448191f3-500f-4fdf-8c94-4423da92a999"), new Guid("f84f1f1a-140d-4304-9c3c-2b18436f01f4"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("4dcd7230-b9b3-4386-9df7-8de1dc999e66"), new Guid("3261204d-6cee-47c7-8720-d0b1094ab99a"), null, false, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("539522a2-3453-4500-94aa-74b66a9a6fca"), new Guid("3261204d-6cee-47c7-8720-d0b1094ab99a"), null, true, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("6972e48f-2e19-4003-a817-c19816093218"), new Guid("f84f1f1a-140d-4304-9c3c-2b18436f01f4"), null, true, true, "Место работы/учебы", 6, "Название организации", new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("790ab317-974a-4d72-92b6-1b7447853a8d"), new Guid("912b46ce-2a54-4496-889c-92cf69749b39"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("799a6c2c-a463-436b-8114-e74751db3567"), new Guid("f84f1f1a-140d-4304-9c3c-2b18436f01f4"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("b82d32e4-78c1-4370-b6bc-1e986295b8b8"), new Guid("2633d2f7-9d3e-42fc-997d-e102e0358ed7"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("c08ec9d8-54c3-4953-b8d8-83da6b84c391"), new Guid("912b46ce-2a54-4496-889c-92cf69749b39"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("c3bc5252-b4a8-4770-8600-4fcc879f5931"), new Guid("f84f1f1a-140d-4304-9c3c-2b18436f01f4"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("a3d4d7de-5d4a-4e2f-b7b4-47c1b320b38a") },
                    { new Guid("c889e901-2a92-4870-b4d5-83cc7f768468"), new Guid("f84f1f1a-140d-4304-9c3c-2b18436f01f4"), null, true, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("dec7c50e-159c-4a33-8c10-6ae7eab9cef5"), new Guid("f84f1f1a-140d-4304-9c3c-2b18436f01f4"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("ef5d92b2-3f99-4373-ae42-c332ada51e9d"), new Guid("2633d2f7-9d3e-42fc-997d-e102e0358ed7"), null, false, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("018546a7-1999-4648-8494-cef7ae2a41a4"), new Guid("42490083-2b0a-4fb7-968e-783f3059e926") },
                    { new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204"), new Guid("87208b10-2eba-4975-978e-1a8a3e929876") },
                    { new Guid("8c82806f-46ec-477c-b0c2-edec8f105c8b"), new Guid("42490083-2b0a-4fb7-968e-783f3059e926") },
                    { new Guid("b2c56947-3193-4a85-86c9-e4225acb6c13"), new Guid("42490083-2b0a-4fb7-968e-783f3059e926") },
                    { new Guid("b78d4cd3-c30d-4336-8b32-6db3b072b0a7"), new Guid("87208b10-2eba-4975-978e-1a8a3e929876") },
                    { new Guid("deb64947-8cca-4cc6-b2d7-aa068876d1f0"), new Guid("42490083-2b0a-4fb7-968e-783f3059e926") },
                    { new Guid("deb64947-8cca-4cc6-b2d7-aa068876d1f0"), new Guid("87208b10-2eba-4975-978e-1a8a3e929876") },
                    { new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8"), new Guid("42490083-2b0a-4fb7-968e-783f3059e926") },
                    { new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8"), new Guid("87208b10-2eba-4975-978e-1a8a3e929876") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("18f5e8e8-0edf-48f7-92f3-56e41b1a6033"), new Guid("912b46ce-2a54-4496-889c-92cf69749b39"), false, false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("2029b074-fd67-43de-b5a9-59e6c2777022"), new Guid("2633d2f7-9d3e-42fc-997d-e102e0358ed7"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("383f5eaf-7fbf-4971-85cf-e62bd37dee02"), new Guid("912b46ce-2a54-4496-889c-92cf69749b39"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("3d9ded89-cb5a-43fa-88ea-bf561c5bd0c0"), new Guid("75471bdc-c4f7-4c1a-bcfe-dcd552a66325"), false, false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("47455c8e-ff7c-457f-a3d0-56713242210b"), new Guid("2633d2f7-9d3e-42fc-997d-e102e0358ed7"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("50a2302d-6a17-46fc-b8d4-ece0df6381ef"), new Guid("3261204d-6cee-47c7-8720-d0b1094ab99a"), true, true, "Краткая аннотация конкурсной работы", 14 },
                    { new Guid("56eba3e8-2e73-47dd-b9d2-673e4bde0627"), new Guid("912b46ce-2a54-4496-889c-92cf69749b39"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("59308806-313b-4d9a-8e70-d99114b35bc6"), new Guid("2633d2f7-9d3e-42fc-997d-e102e0358ed7"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("6970f8e4-c3b2-4fe5-b90b-e5b9e07f3db2"), new Guid("75471bdc-c4f7-4c1a-bcfe-dcd552a66325"), true, true, "Персональные идентификаторы", 10 },
                    { new Guid("9a259727-1e5a-4b2a-9d9f-a34ba39a3b02"), new Guid("912b46ce-2a54-4496-889c-92cf69749b39"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("a3a6fe17-71c2-406d-9b51-0f6164c4279a"), new Guid("912b46ce-2a54-4496-889c-92cf69749b39"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("a6bdfdf4-fe5f-47b1-93b3-a40e738c454e"), new Guid("2633d2f7-9d3e-42fc-997d-e102e0358ed7"), false, false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("cb4c120c-f010-4377-b1cf-09ce7154f04a"), new Guid("75471bdc-c4f7-4c1a-bcfe-dcd552a66325"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("d5a7193f-2d99-4116-bac2-8a1905c0765c"), new Guid("912b46ce-2a54-4496-889c-92cf69749b39"), false, false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0316691c-fdf3-428e-be02-b1d3744426d2"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("59308806-313b-4d9a-8e70-d99114b35bc6"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("031e4aef-7c11-4679-95a2-8df63f04f7cd"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("d5a7193f-2d99-4116-bac2-8a1905c0765c"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("034cad1a-6e84-4801-a456-40f1f5efe2aa"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("59308806-313b-4d9a-8e70-d99114b35bc6"), new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("04b8e9a5-ef53-4481-80da-da0d8fae6cc6"), true, "Вид", 1, new Guid("2029b074-fd67-43de-b5a9-59e6c2777022"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("092a8001-fa46-4812-967d-5326b445fce9"), true, "Год", 4, new Guid("a3a6fe17-71c2-406d-9b51-0f6164c4279a"), new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("128244e6-a819-4c06-806c-b4848f14632c"), true, "Соавторы", 2, new Guid("a3a6fe17-71c2-406d-9b51-0f6164c4279a"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("17157ba7-4297-4555-8b70-369dc1cbae0d"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("383f5eaf-7fbf-4971-85cf-e62bd37dee02"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("2153a756-d463-437a-8dfd-76ab075286cf"), true, "Практические занятия (час.)", 4, new Guid("56eba3e8-2e73-47dd-b9d2-673e4bde0627"), new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("240fa670-91a1-4b1b-a71f-66dd6b4ebc6b"), true, "Название конкурса", 2, new Guid("3d9ded89-cb5a-43fa-88ea-bf561c5bd0c0"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("24f683dd-7f63-44cd-b1f0-fec5fb7de11e"), true, "Издание, год", 4, new Guid("a6bdfdf4-fe5f-47b1-93b3-a40e738c454e"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("2a163d1c-e900-4cc2-b6b5-46b011624792"), true, "Ссылка на платформу", 3, new Guid("a3a6fe17-71c2-406d-9b51-0f6164c4279a"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("2ed3b8ec-4511-4365-8f17-077a01139d07"), true, "Язык публикации", 7, new Guid("18f5e8e8-0edf-48f7-92f3-56e41b1a6033"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("2fbc48b7-d5cc-4806-9d5d-8e926b131687"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("a6bdfdf4-fe5f-47b1-93b3-a40e738c454e"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("32f68b52-be5b-42de-b475-d043649ba488"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("56eba3e8-2e73-47dd-b9d2-673e4bde0627"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("3c9ac657-94c1-4c30-9885-ecdf98e0ba18"), true, "Название статьи", 1, new Guid("a6bdfdf4-fe5f-47b1-93b3-a40e738c454e"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("3e5831b7-8cf0-4b52-be1f-56d148bf9065"), true, "Название", 1, new Guid("50a2302d-6a17-46fc-b8d4-ece0df6381ef"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("5243d1f2-be6e-4f43-80a6-29050c4f9808"), true, "Ссылка", 5, new Guid("3d9ded89-cb5a-43fa-88ea-bf561c5bd0c0"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("58ad34d8-d732-42c3-8817-12d1f457f3d4"), false, "Тип идентификатора", 1, new Guid("6970f8e4-c3b2-4fe5-b90b-e5b9e07f3db2"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("5a9b906e-d838-4a8a-8471-a7cda330bd69"), true, "Вид деятельности (преподавательская)", 3, new Guid("d5a7193f-2d99-4116-bac2-8a1905c0765c"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("5d9bd5b9-1fce-4cc6-a35e-b73ad8238d89"), true, "Номер РИД", 4, new Guid("2029b074-fd67-43de-b5a9-59e6c2777022"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("5e61e78a-1f1e-4e19-bd2b-ee3c1bf7475a"), true, "Название организации/должность/ставка", 1, new Guid("d5a7193f-2d99-4116-bac2-8a1905c0765c"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("72a73d9b-5811-4bd4-a1e7-c904a4d492ca"), true, "Наличие грифа", 5, new Guid("18f5e8e8-0edf-48f7-92f3-56e41b1a6033"), new Guid("7a248a1e-1a44-4c90-b761-a2354275ec1d") },
                    { new Guid("76a011d8-6868-456e-96a0-09ac336e05e8"), true, "Количество часов", 4, new Guid("d5a7193f-2d99-4116-bac2-8a1905c0765c"), new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("78fe2232-f5d5-41af-a378-ab2b3f73dcf2"), true, "Название конкурса/премии", 2, new Guid("383f5eaf-7fbf-4971-85cf-e62bd37dee02"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("78fef200-c2ff-4d2b-b6c7-3c0850d5f964"), true, "Итого (час.)", 5, new Guid("56eba3e8-2e73-47dd-b9d2-673e4bde0627"), new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("7b176b10-1311-4c2b-999d-62ed097e2561"), true, "Название курса", 1, new Guid("a3a6fe17-71c2-406d-9b51-0f6164c4279a"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("8b5c9022-009d-4e8b-9d4a-553e85790fa5"), true, "Год", 1, new Guid("3d9ded89-cb5a-43fa-88ea-bf561c5bd0c0"), new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("8dcf67f3-aa01-4887-a7a8-3b12f21397f3"), true, "ФИО", 1, new Guid("383f5eaf-7fbf-4971-85cf-e62bd37dee02"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("902428fa-53d4-4d97-9851-9aae0f3030a1"), true, "Название НИР/НИОКР", 1, new Guid("59308806-313b-4d9a-8e70-d99114b35bc6"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("912b422e-3f21-4c14-bba9-3ada9287f8a4"), true, "Название организации в которую внедрена разработка", 3, new Guid("47455c8e-ff7c-457f-a3d0-56713242210b"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("91dd13e5-e646-4d2f-af65-f950b458df83"), true, "Год", 3, new Guid("383f5eaf-7fbf-4971-85cf-e62bd37dee02"), new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("938cb110-a064-48dc-bdc4-165ec871d2b0"), true, "Значение", 2, new Guid("50a2302d-6a17-46fc-b8d4-ece0df6381ef"), new Guid("a29c10b5-e74c-454c-b284-4bb03e023da7") },
                    { new Guid("952cb942-7ba5-413e-97b4-0644607fd751"), false, "Идентификатор", 2, new Guid("6970f8e4-c3b2-4fe5-b90b-e5b9e07f3db2"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("95ab4c33-5f49-4869-885f-ebaf8c716a8c"), true, "Название разработки", 2, new Guid("47455c8e-ff7c-457f-a3d0-56713242210b"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("96c155df-ed12-4b6d-a564-62708cc9329e"), true, "Лекции (час.)", 3, new Guid("56eba3e8-2e73-47dd-b9d2-673e4bde0627"), new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("979072dd-8e1d-452e-8b3d-87a8c478e7e8"), true, "Награда", 4, new Guid("3d9ded89-cb5a-43fa-88ea-bf561c5bd0c0"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("992795f8-24a4-483a-b653-8fd8cfca517f"), true, "Вид (лекции, лабораторные)", 2, new Guid("9a259727-1e5a-4b2a-9d9f-a34ba39a3b02"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("9a844693-a658-4557-87ae-5db35af5fcfb"), true, "Название", 2, new Guid("2029b074-fd67-43de-b5a9-59e6c2777022"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("a14943c0-143b-4a26-b016-d49cbc0e0cb9"), true, "Вид публикации", 1, new Guid("18f5e8e8-0edf-48f7-92f3-56e41b1a6033"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("ac3f6654-e276-460f-8041-f469adfdacd7"), true, "Вид", 1, new Guid("47455c8e-ff7c-457f-a3d0-56713242210b"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("adbedf1d-84af-4e34-b7ea-21ebf778ea5b"), true, "Название дисциплины", 1, new Guid("9a259727-1e5a-4b2a-9d9f-a34ba39a3b02"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("b95d8c1e-4e59-47e7-ac2c-a3671fbc2982"), false, "Соавторы", 3, new Guid("18f5e8e8-0edf-48f7-92f3-56e41b1a6033"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("bba9c0f0-2ee6-41be-96dc-80c50873ab85"), true, "Название документа, реквизиты", 1, new Guid("cb4c120c-f010-4377-b1cf-09ce7154f04a"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("c3c72a8f-e6b2-47df-970e-8de5bf48b594"), true, "ФИО соавторов", 3, new Guid("2029b074-fd67-43de-b5a9-59e6c2777022"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("cf485c92-7295-4e7e-8617-70560cc3392f"), true, "Издательство, год", 6, new Guid("18f5e8e8-0edf-48f7-92f3-56e41b1a6033"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("d1326e90-55c8-46d7-b809-30121eb1cb22"), true, "Наименование курса", 1, new Guid("56eba3e8-2e73-47dd-b9d2-673e4bde0627"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("d193ae17-9cd1-40de-8b5b-f697ceadc227"), true, "Количество печатных листов", 4, new Guid("18f5e8e8-0edf-48f7-92f3-56e41b1a6033"), new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("d31b724c-f15a-4917-9338-a5fbf964e8cd"), true, "Соавторы", 2, new Guid("a6bdfdf4-fe5f-47b1-93b3-a40e738c454e"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("d4ccb932-671c-4588-90fd-f1ccd9593652"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("383f5eaf-7fbf-4971-85cf-e62bd37dee02"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("d59ef7db-7a0e-488e-87e2-7fe38857724d"), true, "Название", 2, new Guid("18f5e8e8-0edf-48f7-92f3-56e41b1a6033"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("d9c94ea9-1562-42e4-91ba-86aa694502b2"), true, "Период выполнения", 3, new Guid("59308806-313b-4d9a-8e70-d99114b35bc6"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("e5fffa64-1afd-47d9-84b2-8ec5a47a9688"), true, "Статус конкурса", 3, new Guid("3d9ded89-cb5a-43fa-88ea-bf561c5bd0c0"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("e781c0f9-4459-43cd-b13a-a72d9bb43576"), true, "Год получения документа", 2, new Guid("cb4c120c-f010-4377-b1cf-09ce7154f04a"), new Guid("a52aabd5-9950-4fa3-8d6b-aa2d1e3cddfa") },
                    { new Guid("f5cb45c0-0a4b-45f8-9c09-097e8728b11f"), true, "Статус (руководитель/исполнитель)", 4, new Guid("59308806-313b-4d9a-8e70-d99114b35bc6"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("f6c16329-ae75-4aa9-bb1d-117e7d1e0d1f"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("9a259727-1e5a-4b2a-9d9f-a34ba39a3b02"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") },
                    { new Guid("f937d905-7379-4d93-b5ba-cd1fd3eea41a"), true, "Ссылка на открытый доступ", 8, new Guid("18f5e8e8-0edf-48f7-92f3-56e41b1a6033"), new Guid("13c5141f-1803-4281-b7cf-2e06f7131ba6") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("066c0316-8a53-4a63-966a-2fb92c5e6942"), new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8") },
                    { new Guid("1aa3dd0a-d5c3-4707-8b76-bdd6f281608f"), new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8") },
                    { new Guid("1e80c81a-0f98-4c6d-8c1b-366729adcadc"), new Guid("018546a7-1999-4648-8494-cef7ae2a41a4") },
                    { new Guid("2f00c35b-196e-4220-8e05-e41f470b1faa"), new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8") },
                    { new Guid("366e943f-f9fb-49b9-b97a-fd45785211d1"), new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8") },
                    { new Guid("386b4d0c-415a-44ae-b0ff-96d0664208b9"), new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8") },
                    { new Guid("3d261b2d-5712-47db-a982-d51b7eb76aa5"), new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8") },
                    { new Guid("448191f3-500f-4fdf-8c94-4423da92a999"), new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8") },
                    { new Guid("4dcd7230-b9b3-4386-9df7-8de1dc999e66"), new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8") },
                    { new Guid("539522a2-3453-4500-94aa-74b66a9a6fca"), new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204") },
                    { new Guid("539522a2-3453-4500-94aa-74b66a9a6fca"), new Guid("8c82806f-46ec-477c-b0c2-edec8f105c8b") },
                    { new Guid("539522a2-3453-4500-94aa-74b66a9a6fca"), new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8") },
                    { new Guid("6972e48f-2e19-4003-a817-c19816093218"), new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8") },
                    { new Guid("790ab317-974a-4d72-92b6-1b7447853a8d"), new Guid("018546a7-1999-4648-8494-cef7ae2a41a4") },
                    { new Guid("799a6c2c-a463-436b-8114-e74751db3567"), new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8") },
                    { new Guid("b82d32e4-78c1-4370-b6bc-1e986295b8b8"), new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204") },
                    { new Guid("c08ec9d8-54c3-4953-b8d8-83da6b84c391"), new Guid("018546a7-1999-4648-8494-cef7ae2a41a4") },
                    { new Guid("c3bc5252-b4a8-4770-8600-4fcc879f5931"), new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8") },
                    { new Guid("c889e901-2a92-4870-b4d5-83cc7f768468"), new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8") },
                    { new Guid("dec7c50e-159c-4a33-8c10-6ae7eab9cef5"), new Guid("f57699dc-f591-4c43-be17-bdb3e54407d8") },
                    { new Guid("ef5d92b2-3f99-4373-ae42-c332ada51e9d"), new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("018546a7-1999-4648-8494-cef7ae2a41a4"), new Guid("383f5eaf-7fbf-4971-85cf-e62bd37dee02") },
                    { new Guid("018546a7-1999-4648-8494-cef7ae2a41a4"), new Guid("56eba3e8-2e73-47dd-b9d2-673e4bde0627") },
                    { new Guid("018546a7-1999-4648-8494-cef7ae2a41a4"), new Guid("a3a6fe17-71c2-406d-9b51-0f6164c4279a") },
                    { new Guid("018546a7-1999-4648-8494-cef7ae2a41a4"), new Guid("d5a7193f-2d99-4116-bac2-8a1905c0765c") },
                    { new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204"), new Guid("3d9ded89-cb5a-43fa-88ea-bf561c5bd0c0") },
                    { new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204"), new Guid("59308806-313b-4d9a-8e70-d99114b35bc6") },
                    { new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204"), new Guid("6970f8e4-c3b2-4fe5-b90b-e5b9e07f3db2") },
                    { new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204"), new Guid("a6bdfdf4-fe5f-47b1-93b3-a40e738c454e") },
                    { new Guid("8c82806f-46ec-477c-b0c2-edec8f105c8b"), new Guid("3d9ded89-cb5a-43fa-88ea-bf561c5bd0c0") },
                    { new Guid("8c82806f-46ec-477c-b0c2-edec8f105c8b"), new Guid("cb4c120c-f010-4377-b1cf-09ce7154f04a") },
                    { new Guid("b2c56947-3193-4a85-86c9-e4225acb6c13"), new Guid("18f5e8e8-0edf-48f7-92f3-56e41b1a6033") },
                    { new Guid("b2c56947-3193-4a85-86c9-e4225acb6c13"), new Guid("9a259727-1e5a-4b2a-9d9f-a34ba39a3b02") },
                    { new Guid("b78d4cd3-c30d-4336-8b32-6db3b072b0a7"), new Guid("2029b074-fd67-43de-b5a9-59e6c2777022") },
                    { new Guid("b78d4cd3-c30d-4336-8b32-6db3b072b0a7"), new Guid("47455c8e-ff7c-457f-a3d0-56713242210b") },
                    { new Guid("b78d4cd3-c30d-4336-8b32-6db3b072b0a7"), new Guid("cb4c120c-f010-4377-b1cf-09ce7154f04a") },
                    { new Guid("deb64947-8cca-4cc6-b2d7-aa068876d1f0"), new Guid("50a2302d-6a17-46fc-b8d4-ece0df6381ef") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("052d7de8-84dc-4272-b11e-e175658c89ed"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("2029b074-fd67-43de-b5a9-59e6c2777022") },
                    { new Guid("1df82884-b2e3-4bef-8df6-3dfb6d256d38"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("59308806-313b-4d9a-8e70-d99114b35bc6") },
                    { new Guid("1f6f6273-ee1f-4c21-8da2-7b278fe2d5a9"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("18f5e8e8-0edf-48f7-92f3-56e41b1a6033") },
                    { new Guid("21242f99-fe94-4af7-909f-a90c3921121c"), "EvaluateMark5", new Guid("790ab317-974a-4d72-92b6-1b7447853a8d"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("266fe377-ffdb-4f3d-854d-727f25a38559"), "EvaluateMark13", new Guid("539522a2-3453-4500-94aa-74b66a9a6fca"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("29d803f9-0c97-4ab3-9f96-d0956e0fd904"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("cb4c120c-f010-4377-b1cf-09ce7154f04a") },
                    { new Guid("2ec4594f-fec6-4f64-94de-d4038be47b35"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("a3a6fe17-71c2-406d-9b51-0f6164c4279a") },
                    { new Guid("343d9e29-0c85-4efc-94b2-8ca5b22246b7"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("56eba3e8-2e73-47dd-b9d2-673e4bde0627") },
                    { new Guid("3ae5a79c-8f1e-41e2-a358-92778583be9d"), "EvaluateMark4", new Guid("1e80c81a-0f98-4c6d-8c1b-366729adcadc"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("482076aa-859b-45ee-a710-75848bacc3bc"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("383f5eaf-7fbf-4971-85cf-e62bd37dee02") },
                    { new Guid("6e94f099-3820-4b80-82ec-748ad0907cef"), null, null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("50a2302d-6a17-46fc-b8d4-ece0df6381ef") },
                    { new Guid("851f2eda-4b50-43e2-9a41-ea66aa408c84"), "EvaluateMark20", new Guid("ef5d92b2-3f99-4373-ae42-c332ada51e9d"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("93be4bfe-bdf6-40ee-a84a-7880dde12772"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("18f5e8e8-0edf-48f7-92f3-56e41b1a6033") },
                    { new Guid("97f01ee3-5f54-4f6b-aae2-721ddc4ff279"), null, null, false, 10, "Оценка уровня предоставленной работы:", 25, new Guid("50a2302d-6a17-46fc-b8d4-ece0df6381ef") },
                    { new Guid("9ffbda46-c558-416b-b41e-f8179139802b"), "EvaluateMark3", new Guid("c08ec9d8-54c3-4953-b8d8-83da6b84c391"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("a84005eb-1779-4496-b7d4-79cf9d5c6f61"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("56eba3e8-2e73-47dd-b9d2-673e4bde0627") },
                    { new Guid("aa8b667b-6133-4c13-bda9-7e2e38230f8d"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("59308806-313b-4d9a-8e70-d99114b35bc6") },
                    { new Guid("c1a455df-a6ee-440d-9d80-1071af65f3a8"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("a6bdfdf4-fe5f-47b1-93b3-a40e738c454e") },
                    { new Guid("cc67a686-d5ec-4242-8278-a28419fb8ea2"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("9a259727-1e5a-4b2a-9d9f-a34ba39a3b02") },
                    { new Guid("e01f2eb4-f5ec-4cf7-8509-8aa7fd324e89"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("3d9ded89-cb5a-43fa-88ea-bf561c5bd0c0") },
                    { new Guid("e447b18c-c592-46e1-94f6-352673750f42"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("47455c8e-ff7c-457f-a3d0-56713242210b") },
                    { new Guid("f1b03f4c-0ad4-4597-bbd5-a478c0fd57d1"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("18f5e8e8-0edf-48f7-92f3-56e41b1a6033") },
                    { new Guid("f84c0231-2709-4501-bdc2-c6e5d92b5419"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("18f5e8e8-0edf-48f7-92f3-56e41b1a6033") },
                    { new Guid("fec459ca-d0c1-4164-b568-334999f414f3"), "EvaluateMark19", new Guid("b82d32e4-78c1-4370-b6bc-1e986295b8b8"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("3c46ded4-d623-4ab9-9032-0a2e927b2dd7"), true, new Guid("50a2302d-6a17-46fc-b8d4-ece0df6381ef") },
                    { new Guid("402b5da1-e546-48d3-a529-e5ae52f54d1e"), true, new Guid("6970f8e4-c3b2-4fe5-b90b-e5b9e07f3db2") },
                    { new Guid("40f22299-5c5a-49d9-8539-d0cfa4ec1a39"), true, new Guid("50a2302d-6a17-46fc-b8d4-ece0df6381ef") },
                    { new Guid("4624369a-47bb-4e1c-8382-9af732c6b532"), true, new Guid("50a2302d-6a17-46fc-b8d4-ece0df6381ef") },
                    { new Guid("4699176d-ee88-4d28-b760-36c41d0eaee9"), true, new Guid("6970f8e4-c3b2-4fe5-b90b-e5b9e07f3db2") },
                    { new Guid("8d600746-6328-4a27-82cc-9ad37258abbd"), true, new Guid("50a2302d-6a17-46fc-b8d4-ece0df6381ef") },
                    { new Guid("a07bf6ea-47c5-4705-b653-5b3dfc5386f5"), true, new Guid("50a2302d-6a17-46fc-b8d4-ece0df6381ef") },
                    { new Guid("c82e5949-f6b4-4724-a1b3-b439d8a3c30c"), true, new Guid("50a2302d-6a17-46fc-b8d4-ece0df6381ef") },
                    { new Guid("cbad16e6-3792-48af-8cee-4266aa879caa"), true, new Guid("6970f8e4-c3b2-4fe5-b90b-e5b9e07f3db2") },
                    { new Guid("de535381-df07-407c-8503-99925e7b3ab2"), true, new Guid("50a2302d-6a17-46fc-b8d4-ece0df6381ef") },
                    { new Guid("ec9d3934-94a5-41a2-9469-558a9432d81f"), true, new Guid("6970f8e4-c3b2-4fe5-b90b-e5b9e07f3db2") },
                    { new Guid("fcb9a4f1-c2cc-486c-9b48-c0378d9195a5"), true, new Guid("50a2302d-6a17-46fc-b8d4-ece0df6381ef") },
                    { new Guid("fd822556-7cce-4728-a1c6-2aeac15ae4d8"), true, new Guid("6970f8e4-c3b2-4fe5-b90b-e5b9e07f3db2") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("2c5103ad-ef50-4968-9ce6-f00864804e9f"), null, new Guid("4dcd7230-b9b3-4386-9df7-8de1dc999e66"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("5b50eb8a-a674-41a2-814b-69d2b721b9c8"), null, new Guid("539522a2-3453-4500-94aa-74b66a9a6fca"), "Профессор" },
                    { new Guid("602aa267-1836-4fd2-a34a-07f042a12990"), null, new Guid("2f00c35b-196e-4220-8e05-e41f470b1faa"), "Доктор наук" },
                    { new Guid("644512d2-a8ac-4660-938b-799d381cf6d5"), null, new Guid("539522a2-3453-4500-94aa-74b66a9a6fca"), "Доцент" },
                    { new Guid("719248d1-b720-41b8-98c5-73643a5245c5"), null, new Guid("4dcd7230-b9b3-4386-9df7-8de1dc999e66"), "Имеющие ученую степень доктора наук" },
                    { new Guid("a72fd8b6-b2df-4da7-9dc2-fcfde2672240"), null, new Guid("2f00c35b-196e-4220-8e05-e41f470b1faa"), "Кандидат наук" },
                    { new Guid("e2db9f05-175c-42b8-a0c9-61479937bd10"), null, new Guid("539522a2-3453-4500-94aa-74b66a9a6fca"), "Нет" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("0823127c-6cf8-4cbf-9edf-43ca0548ecb8"), null, new Guid("58ad34d8-d732-42c3-8817-12d1f457f3d4"), true, true, new Guid("402b5da1-e546-48d3-a529-e5ae52f54d1e"), "РИНЦ AuthorID" },
                    { new Guid("0de192bd-d66d-476c-b6e2-14fd3e6d1153"), null, new Guid("938cb110-a064-48dc-bdc4-165ec871d2b0"), false, true, new Guid("a07bf6ea-47c5-4705-b653-5b3dfc5386f5"), null },
                    { new Guid("145312c3-2335-40c2-b4e2-93512eaa0a58"), null, new Guid("952cb942-7ba5-413e-97b4-0644607fd751"), false, true, new Guid("ec9d3934-94a5-41a2-9469-558a9432d81f"), null },
                    { new Guid("160fa53f-dae2-4905-921d-1c5c6692e901"), null, new Guid("938cb110-a064-48dc-bdc4-165ec871d2b0"), false, true, new Guid("4624369a-47bb-4e1c-8382-9af732c6b532"), null },
                    { new Guid("17154216-8e73-4516-9f09-9a7b82666033"), null, new Guid("58ad34d8-d732-42c3-8817-12d1f457f3d4"), true, true, new Guid("fd822556-7cce-4728-a1c6-2aeac15ae4d8"), "ORCiD" },
                    { new Guid("28bf6b08-0a44-458f-878d-8da31f0dcdf1"), null, new Guid("3e5831b7-8cf0-4b52-be1f-56d148bf9065"), true, true, new Guid("8d600746-6328-4a27-82cc-9ad37258abbd"), "Ссылка на конкурсную работу" },
                    { new Guid("2cc6202d-319b-47f3-94d9-aec4462ae9cf"), null, new Guid("938cb110-a064-48dc-bdc4-165ec871d2b0"), false, true, new Guid("40f22299-5c5a-49d9-8539-d0cfa4ec1a39"), null },
                    { new Guid("31337694-18a9-4ff1-901b-c20d16f6a0b3"), null, new Guid("952cb942-7ba5-413e-97b4-0644607fd751"), false, true, new Guid("cbad16e6-3792-48af-8cee-4266aa879caa"), null },
                    { new Guid("3219923e-bf00-491d-835d-508b2ce401e5"), null, new Guid("3e5831b7-8cf0-4b52-be1f-56d148bf9065"), true, true, new Guid("4624369a-47bb-4e1c-8382-9af732c6b532"), "Результаты и выводы" },
                    { new Guid("3aef29c7-eb81-4191-bd87-fbccf88c980f"), null, new Guid("3e5831b7-8cf0-4b52-be1f-56d148bf9065"), true, true, new Guid("3c46ded4-d623-4ab9-9032-0a2e927b2dd7"), "Инновационность" },
                    { new Guid("4dced5e1-f634-47fb-9915-c2384b601be1"), null, new Guid("3e5831b7-8cf0-4b52-be1f-56d148bf9065"), true, true, new Guid("c82e5949-f6b4-4724-a1b3-b439d8a3c30c"), "Актуальность конкурсной работы" },
                    { new Guid("569a3a77-374f-46e0-a942-564abf2cc540"), null, new Guid("938cb110-a064-48dc-bdc4-165ec871d2b0"), false, true, new Guid("3c46ded4-d623-4ab9-9032-0a2e927b2dd7"), null },
                    { new Guid("686c10d0-8b20-418b-80d1-99ce2ad0793d"), null, new Guid("3e5831b7-8cf0-4b52-be1f-56d148bf9065"), true, true, new Guid("fcb9a4f1-c2cc-486c-9b48-c0378d9195a5"), "Методология и методы, используемые в работе" },
                    { new Guid("6b7bc4a4-4c1e-453f-a256-00dc08edf63c"), null, new Guid("3e5831b7-8cf0-4b52-be1f-56d148bf9065"), true, true, new Guid("40f22299-5c5a-49d9-8539-d0cfa4ec1a39"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("748f3d80-0a2b-4a7f-a5ba-0f47c487a73f"), null, new Guid("3e5831b7-8cf0-4b52-be1f-56d148bf9065"), true, true, new Guid("de535381-df07-407c-8503-99925e7b3ab2"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("752c0c5a-1db2-49d7-81fa-d41ab8063d7c"), null, new Guid("952cb942-7ba5-413e-97b4-0644607fd751"), false, true, new Guid("fd822556-7cce-4728-a1c6-2aeac15ae4d8"), null },
                    { new Guid("9288735c-170d-4a33-ba18-511f9801dcf0"), null, new Guid("938cb110-a064-48dc-bdc4-165ec871d2b0"), false, true, new Guid("8d600746-6328-4a27-82cc-9ad37258abbd"), null },
                    { new Guid("9c5f8d33-c658-463d-b6f5-63e3c31dc371"), null, new Guid("58ad34d8-d732-42c3-8817-12d1f457f3d4"), true, true, new Guid("cbad16e6-3792-48af-8cee-4266aa879caa"), "ResearcherID" },
                    { new Guid("ab3713ab-8cca-4472-953d-0d2c3d17b96a"), null, new Guid("952cb942-7ba5-413e-97b4-0644607fd751"), false, true, new Guid("402b5da1-e546-48d3-a529-e5ae52f54d1e"), null },
                    { new Guid("cfbc7c4d-f3b2-4b2b-80d6-ee2f5342ca96"), null, new Guid("952cb942-7ba5-413e-97b4-0644607fd751"), false, true, new Guid("4699176d-ee88-4d28-b760-36c41d0eaee9"), null },
                    { new Guid("d1bb0090-6057-456a-8e40-100a809dbb82"), null, new Guid("938cb110-a064-48dc-bdc4-165ec871d2b0"), false, true, new Guid("de535381-df07-407c-8503-99925e7b3ab2"), null },
                    { new Guid("ed38e704-3623-492c-8cb0-330b327c2061"), null, new Guid("938cb110-a064-48dc-bdc4-165ec871d2b0"), false, true, new Guid("c82e5949-f6b4-4724-a1b3-b439d8a3c30c"), null },
                    { new Guid("f0623258-1dab-468e-88a2-df5da04f3b9d"), null, new Guid("58ad34d8-d732-42c3-8817-12d1f457f3d4"), true, true, new Guid("4699176d-ee88-4d28-b760-36c41d0eaee9"), "ScopusID" },
                    { new Guid("f1dd36a4-36a6-4de7-80b9-548d42517ade"), null, new Guid("58ad34d8-d732-42c3-8817-12d1f457f3d4"), true, true, new Guid("ec9d3934-94a5-41a2-9469-558a9432d81f"), "Google Scholar ID" },
                    { new Guid("fc9a44eb-4ac9-4457-bf2c-1b504911514f"), null, new Guid("3e5831b7-8cf0-4b52-be1f-56d148bf9065"), true, true, new Guid("a07bf6ea-47c5-4705-b653-5b3dfc5386f5"), "Название работы" },
                    { new Guid("fd17168c-b333-4c6b-ab17-9ec732153d60"), null, new Guid("938cb110-a064-48dc-bdc4-165ec871d2b0"), false, true, new Guid("fcb9a4f1-c2cc-486c-9b48-c0378d9195a5"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("018546a7-1999-4648-8494-cef7ae2a41a4"), new Guid("21242f99-fe94-4af7-909f-a90c3921121c") },
                    { new Guid("018546a7-1999-4648-8494-cef7ae2a41a4"), new Guid("2ec4594f-fec6-4f64-94de-d4038be47b35") },
                    { new Guid("018546a7-1999-4648-8494-cef7ae2a41a4"), new Guid("343d9e29-0c85-4efc-94b2-8ca5b22246b7") },
                    { new Guid("018546a7-1999-4648-8494-cef7ae2a41a4"), new Guid("3ae5a79c-8f1e-41e2-a358-92778583be9d") },
                    { new Guid("018546a7-1999-4648-8494-cef7ae2a41a4"), new Guid("482076aa-859b-45ee-a710-75848bacc3bc") },
                    { new Guid("018546a7-1999-4648-8494-cef7ae2a41a4"), new Guid("9ffbda46-c558-416b-b41e-f8179139802b") },
                    { new Guid("018546a7-1999-4648-8494-cef7ae2a41a4"), new Guid("a84005eb-1779-4496-b7d4-79cf9d5c6f61") },
                    { new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204"), new Guid("1df82884-b2e3-4bef-8df6-3dfb6d256d38") },
                    { new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204"), new Guid("266fe377-ffdb-4f3d-854d-727f25a38559") },
                    { new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204"), new Guid("851f2eda-4b50-43e2-9a41-ea66aa408c84") },
                    { new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204"), new Guid("aa8b667b-6133-4c13-bda9-7e2e38230f8d") },
                    { new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204"), new Guid("c1a455df-a6ee-440d-9d80-1071af65f3a8") },
                    { new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204"), new Guid("e01f2eb4-f5ec-4cf7-8509-8aa7fd324e89") },
                    { new Guid("42c01d27-3edd-4871-ac8c-dc10c05c9204"), new Guid("fec459ca-d0c1-4164-b568-334999f414f3") },
                    { new Guid("8c82806f-46ec-477c-b0c2-edec8f105c8b"), new Guid("266fe377-ffdb-4f3d-854d-727f25a38559") },
                    { new Guid("8c82806f-46ec-477c-b0c2-edec8f105c8b"), new Guid("29d803f9-0c97-4ab3-9f96-d0956e0fd904") },
                    { new Guid("8c82806f-46ec-477c-b0c2-edec8f105c8b"), new Guid("e01f2eb4-f5ec-4cf7-8509-8aa7fd324e89") },
                    { new Guid("b2c56947-3193-4a85-86c9-e4225acb6c13"), new Guid("1f6f6273-ee1f-4c21-8da2-7b278fe2d5a9") },
                    { new Guid("b2c56947-3193-4a85-86c9-e4225acb6c13"), new Guid("93be4bfe-bdf6-40ee-a84a-7880dde12772") },
                    { new Guid("b2c56947-3193-4a85-86c9-e4225acb6c13"), new Guid("cc67a686-d5ec-4242-8278-a28419fb8ea2") },
                    { new Guid("b2c56947-3193-4a85-86c9-e4225acb6c13"), new Guid("f1b03f4c-0ad4-4597-bbd5-a478c0fd57d1") },
                    { new Guid("b2c56947-3193-4a85-86c9-e4225acb6c13"), new Guid("f84c0231-2709-4501-bdc2-c6e5d92b5419") },
                    { new Guid("b78d4cd3-c30d-4336-8b32-6db3b072b0a7"), new Guid("052d7de8-84dc-4272-b11e-e175658c89ed") },
                    { new Guid("b78d4cd3-c30d-4336-8b32-6db3b072b0a7"), new Guid("29d803f9-0c97-4ab3-9f96-d0956e0fd904") },
                    { new Guid("b78d4cd3-c30d-4336-8b32-6db3b072b0a7"), new Guid("e447b18c-c592-46e1-94f6-352673750f42") },
                    { new Guid("deb64947-8cca-4cc6-b2d7-aa068876d1f0"), new Guid("6e94f099-3820-4b80-82ec-748ad0907cef") },
                    { new Guid("deb64947-8cca-4cc6-b2d7-aa068876d1f0"), new Guid("97f01ee3-5f54-4f6b-aae2-721ddc4ff279") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("1226f498-e3c9-412c-bdbc-86061a1a32cf"), new Guid("e5fffa64-1afd-47d9-84b2-8ec5a47a9688"), null, "Региональный" },
                    { new Guid("1244bfd3-4a41-459b-83ea-d5352a0977cb"), new Guid("e5fffa64-1afd-47d9-84b2-8ec5a47a9688"), null, "Всероссийский" },
                    { new Guid("1faf2980-619c-4997-800d-45ffd81e2b86"), new Guid("d31b724c-f15a-4917-9338-a5fbf964e8cd"), null, "Есть" },
                    { new Guid("269fe772-81ac-49e8-a107-38fa6abfef7e"), new Guid("e5fffa64-1afd-47d9-84b2-8ec5a47a9688"), null, "Международный" },
                    { new Guid("2f58785f-6720-4758-a07e-3cb244723684"), new Guid("992795f8-24a4-483a-b653-8fd8cfca517f"), null, "Лабораторные" },
                    { new Guid("2fc60c81-8213-49ff-8af4-30fc2234175d"), new Guid("992795f8-24a4-483a-b653-8fd8cfca517f"), null, "Лекции" },
                    { new Guid("3cf4b9a2-839e-4fbd-90bd-bae80d47ab49"), new Guid("04b8e9a5-ef53-4481-80da-da0d8fae6cc6"), null, "Изобретение" },
                    { new Guid("4f2d61a3-7d9e-45ae-b3d0-0455b08780a0"), new Guid("ac3f6654-e276-460f-8041-f469adfdacd7"), null, "Полезная модель" },
                    { new Guid("6a499123-640d-4682-bfca-8db3947858a6"), new Guid("2ed3b8ec-4511-4365-8f17-077a01139d07"), null, "Иностранный" },
                    { new Guid("8e6b696b-9243-462a-b782-2776d309b878"), new Guid("04b8e9a5-ef53-4481-80da-da0d8fae6cc6"), null, "База данных" },
                    { new Guid("956f58f4-61c6-4c7c-949e-3b89cc8cbb8b"), new Guid("d31b724c-f15a-4917-9338-a5fbf964e8cd"), null, "Нет" },
                    { new Guid("97f6675c-70ef-4f7f-8a43-c6e6f406e788"), new Guid("ac3f6654-e276-460f-8041-f469adfdacd7"), null, "База данных" },
                    { new Guid("981cfba2-68d2-440d-9b46-0a028f92f6de"), new Guid("f5cb45c0-0a4b-45f8-9c09-097e8728b11f"), null, "Исполнитель" },
                    { new Guid("997dbdb2-67bf-4230-8ab6-df441647257a"), new Guid("a14943c0-143b-4a26-b016-d49cbc0e0cb9"), null, "Монография" },
                    { new Guid("9a7e3d84-e2e1-4131-82b5-09c6d1f38665"), new Guid("ac3f6654-e276-460f-8041-f469adfdacd7"), null, "Изобретение" },
                    { new Guid("a91ebddd-f383-4afc-9131-490228c233f8"), new Guid("b95d8c1e-4e59-47e7-ac2c-a3671fbc2982"), null, "Есть" },
                    { new Guid("ab231df2-815f-4df6-9c62-c063651a98ce"), new Guid("f5cb45c0-0a4b-45f8-9c09-097e8728b11f"), null, "Руководитель" },
                    { new Guid("b056f941-8b0f-4f09-9051-7fcb855ee381"), new Guid("04b8e9a5-ef53-4481-80da-da0d8fae6cc6"), null, "Полезная модель" },
                    { new Guid("c3f78573-bc54-4840-bd65-6d21c7cafbf8"), new Guid("a14943c0-143b-4a26-b016-d49cbc0e0cb9"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("cd2e388d-ad86-44a1-a7a5-ca37b994673d"), new Guid("b95d8c1e-4e59-47e7-ac2c-a3671fbc2982"), null, "Нет" },
                    { new Guid("e55d1792-c1ce-419f-8309-9ba870c00f58"), new Guid("a14943c0-143b-4a26-b016-d49cbc0e0cb9"), null, "Учебник" },
                    { new Guid("fc570c34-1e1b-4863-813c-06a889fc8925"), new Guid("2ed3b8ec-4511-4365-8f17-077a01139d07"), null, "Русский" }
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
