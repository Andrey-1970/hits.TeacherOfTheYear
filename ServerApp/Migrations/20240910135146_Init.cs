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
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Message = table.Column<string>(type: "TEXT", nullable: true),
                    Checked = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
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
                    { new Guid("850afdd2-71a3-45eb-9d35-ef1bd719174a"), 5, "Отклонена" },
                    { new Guid("90b4a42f-0a9e-43be-9380-ace4d439d5d4"), 2, "В ожидании рассмотрения" },
                    { new Guid("c70ebf63-6f1d-439c-bcbd-e532f0f81893"), 1, "В ожидании заполнения" },
                    { new Guid("c7dd3a47-fc8f-42cf-85f4-2464f1f00192"), 4, "Одобрена" },
                    { new Guid("db619d64-e526-40d9-bce5-b57f8e214c29"), 3, "В процессе рассмотрения" },
                    { new Guid("e07a5f0f-bfb7-4695-af5e-110ae85f5579"), 6, "Оценена" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0fd8dc40-17c5-419b-8742-9b8240b8c85c", null, "Admin", "ADMIN" },
                    { "2c81beb7-93e1-4383-a48e-a2a101163102", null, "Expert", "EXPERT" },
                    { "641afc39-1942-4cef-bb5d-ab75ac721141", null, "Participant", "PARTICIPANT" },
                    { "69d549db-0c36-4962-905e-066e43654abf", null, "Organiser", "ORGANISER" },
                    { "bad4ce07-aedb-490e-82b1-05bca1b0e5b2", null, "Voter", "VOTER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("2ed06e45-4acd-4591-ac89-624434b778cd"), "Строительство и архитектура", 1 },
                    { new Guid("943b5277-a85c-4bab-b8c0-c90ef0a036df"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("01612f4e-97fd-456c-82b0-27b44b54f565"), "Деятельность", 4 },
                    { new Guid("421b1845-5ad8-4b1f-a6c2-3a302e1f18a8"), "Категория участников", 2 },
                    { new Guid("bf7d61b0-6590-4959-810d-b7f30b49e996"), "Профессиональное развитие", 3 },
                    { new Guid("d38aa548-7b1e-4448-a74f-595e2bb4a51e"), "Общая информация", 1 },
                    { new Guid("fd99a8cd-69df-484a-b210-5fdfe8885820"), "Деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Checked", "Email", "Message", "Name" },
                values: new object[] { new Guid("9e8f2d62-0e2b-4aec-9647-4aa0d089b1e6"), false, "system@system.ru", "Test Message for System", "SYSTEM" });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046"), "Образовательная деятельность", 2 },
                    { new Guid("27fb7a70-167c-40ff-86ba-9c5653124888"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("b195cca1-47a6-4956-b40a-07709088a8eb"), "Инновационная и иная деятельность", 6 },
                    { new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344"), "Основной", 1 },
                    { new Guid("cb0db337-a7d1-472b-b0d0-017af20f9987"), "Конкурсная работа", 7 },
                    { new Guid("cc8a9b5e-5e80-49bb-ada6-9f3e463dd5b5"), "Профессиональные показатели", 4 },
                    { new Guid("dc545ee8-4417-423d-b76b-6fb123570b15"), "Методическая деятельность", 3 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("27dd1a5a-f746-4388-9d7b-22b5ce691fc4"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("7aa927cb-6012-4c7a-8ba9-6e745de64f2f"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2105dfd6-a71e-49f5-9da2-d84f47437b32"), "bool" },
                    { new Guid("3bece2b8-5daa-456b-b664-e477e79615c6"), "DateTime" },
                    { new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4"), "string" },
                    { new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8"), "int" },
                    { new Guid("f92cd2e7-5eed-4950-9949-f46c7729de92"), "TextArea" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("01612f4e-97fd-456c-82b0-27b44b54f565"), new Guid("27dd1a5a-f746-4388-9d7b-22b5ce691fc4") },
                    { new Guid("421b1845-5ad8-4b1f-a6c2-3a302e1f18a8"), new Guid("27dd1a5a-f746-4388-9d7b-22b5ce691fc4") },
                    { new Guid("421b1845-5ad8-4b1f-a6c2-3a302e1f18a8"), new Guid("7aa927cb-6012-4c7a-8ba9-6e745de64f2f") },
                    { new Guid("bf7d61b0-6590-4959-810d-b7f30b49e996"), new Guid("27dd1a5a-f746-4388-9d7b-22b5ce691fc4") },
                    { new Guid("bf7d61b0-6590-4959-810d-b7f30b49e996"), new Guid("7aa927cb-6012-4c7a-8ba9-6e745de64f2f") },
                    { new Guid("d38aa548-7b1e-4448-a74f-595e2bb4a51e"), new Guid("27dd1a5a-f746-4388-9d7b-22b5ce691fc4") },
                    { new Guid("d38aa548-7b1e-4448-a74f-595e2bb4a51e"), new Guid("7aa927cb-6012-4c7a-8ba9-6e745de64f2f") },
                    { new Guid("fd99a8cd-69df-484a-b210-5fdfe8885820"), new Guid("7aa927cb-6012-4c7a-8ba9-6e745de64f2f") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("07a6a9b2-7916-4b40-ae2d-0d7f7a2cd59d"), new Guid("d38aa548-7b1e-4448-a74f-595e2bb4a51e"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("24f644b8-d2bb-48d2-9cbb-92881fab217e"), new Guid("421b1845-5ad8-4b1f-a6c2-3a302e1f18a8"), null, true, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("2acc2aeb-f5aa-41c6-9a86-99cb2eb3dc30"), new Guid("01612f4e-97fd-456c-82b0-27b44b54f565"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("2f7a7475-1d1e-4d54-96f4-e9183a910e0a"), new Guid("421b1845-5ad8-4b1f-a6c2-3a302e1f18a8"), null, false, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("3d02e513-d5d4-4c4a-a74b-dae357c72389"), new Guid("d38aa548-7b1e-4448-a74f-595e2bb4a51e"), null, true, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("630f78c8-5b67-401f-92bb-306848ac275f"), new Guid("fd99a8cd-69df-484a-b210-5fdfe8885820"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("7cfd8f05-a1b7-499c-96bd-1773fbe67730"), new Guid("d38aa548-7b1e-4448-a74f-595e2bb4a51e"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("8493b7c8-1271-49c6-a2d2-0de79fb546ee"), new Guid("d38aa548-7b1e-4448-a74f-595e2bb4a51e"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("3bece2b8-5daa-456b-b664-e477e79615c6") },
                    { new Guid("8833e2db-7bec-4ded-ba3d-0036b7529fa6"), new Guid("01612f4e-97fd-456c-82b0-27b44b54f565"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("8abdee5a-19e7-4ec0-af08-2c9d88844a46"), new Guid("421b1845-5ad8-4b1f-a6c2-3a302e1f18a8"), null, false, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("a5b9c797-d3f0-4d6e-968b-d7d4bc0e8733"), new Guid("d38aa548-7b1e-4448-a74f-595e2bb4a51e"), null, false, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("b56c31f3-b126-4ce6-b7c0-3dcc22e1228d"), new Guid("01612f4e-97fd-456c-82b0-27b44b54f565"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("bf2cde37-b9de-4739-a0be-64dc3918a931"), new Guid("d38aa548-7b1e-4448-a74f-595e2bb4a51e"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("d54bc427-c324-4ab6-bf7e-95cdb900890d"), new Guid("d38aa548-7b1e-4448-a74f-595e2bb4a51e"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("d5591869-90c6-45f8-bac6-355cf87d464d"), new Guid("d38aa548-7b1e-4448-a74f-595e2bb4a51e"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("e13e9fff-3510-46ff-8329-17dfc7557161"), new Guid("421b1845-5ad8-4b1f-a6c2-3a302e1f18a8"), null, true, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("eba011c1-10f1-476d-b255-4eac986b3e05"), new Guid("fd99a8cd-69df-484a-b210-5fdfe8885820"), null, false, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("f03af6b7-d3cf-49f8-b3ac-2e9691732a72"), new Guid("d38aa548-7b1e-4448-a74f-595e2bb4a51e"), null, true, true, "Место работы/учебы", 6, "Название организации", new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("f9141d3f-66d7-4bea-9f75-d864eeaa0740"), new Guid("d38aa548-7b1e-4448-a74f-595e2bb4a51e"), null, false, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046"), new Guid("27dd1a5a-f746-4388-9d7b-22b5ce691fc4") },
                    { new Guid("27fb7a70-167c-40ff-86ba-9c5653124888"), new Guid("7aa927cb-6012-4c7a-8ba9-6e745de64f2f") },
                    { new Guid("b195cca1-47a6-4956-b40a-07709088a8eb"), new Guid("7aa927cb-6012-4c7a-8ba9-6e745de64f2f") },
                    { new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344"), new Guid("27dd1a5a-f746-4388-9d7b-22b5ce691fc4") },
                    { new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344"), new Guid("7aa927cb-6012-4c7a-8ba9-6e745de64f2f") },
                    { new Guid("cb0db337-a7d1-472b-b0d0-017af20f9987"), new Guid("27dd1a5a-f746-4388-9d7b-22b5ce691fc4") },
                    { new Guid("cb0db337-a7d1-472b-b0d0-017af20f9987"), new Guid("7aa927cb-6012-4c7a-8ba9-6e745de64f2f") },
                    { new Guid("cc8a9b5e-5e80-49bb-ada6-9f3e463dd5b5"), new Guid("27dd1a5a-f746-4388-9d7b-22b5ce691fc4") },
                    { new Guid("dc545ee8-4417-423d-b76b-6fb123570b15"), new Guid("27dd1a5a-f746-4388-9d7b-22b5ce691fc4") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("02a509bb-6a9a-4982-93e0-9a1217da81ad"), new Guid("421b1845-5ad8-4b1f-a6c2-3a302e1f18a8"), true, true, "Краткая аннотация конкурсной работы", 14 },
                    { new Guid("21946e83-3c62-40a1-b724-e1f7e4cbf352"), new Guid("fd99a8cd-69df-484a-b210-5fdfe8885820"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("75874988-29ca-4b03-88dd-158483a577db"), new Guid("01612f4e-97fd-456c-82b0-27b44b54f565"), false, false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("7954dce9-b3ab-4145-8700-93cbdba4b5cd"), new Guid("01612f4e-97fd-456c-82b0-27b44b54f565"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("8dc37210-6e69-4288-bfbe-4050c2d1164f"), new Guid("01612f4e-97fd-456c-82b0-27b44b54f565"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("96835141-e62f-4cea-ba74-6fcd7a2d14a9"), new Guid("01612f4e-97fd-456c-82b0-27b44b54f565"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("a8202e6a-c89d-4631-98a5-7db5490a6335"), new Guid("fd99a8cd-69df-484a-b210-5fdfe8885820"), false, false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("c5f5a2de-f3be-47b5-910a-f3494d5c1a5f"), new Guid("01612f4e-97fd-456c-82b0-27b44b54f565"), false, false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("ebfd4a20-ae4f-4e29-8f56-71213dd1687a"), new Guid("fd99a8cd-69df-484a-b210-5fdfe8885820"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("f06867dc-a522-45c1-abb7-45d74c25e95f"), new Guid("bf7d61b0-6590-4959-810d-b7f30b49e996"), false, false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("f0f1891a-72a8-4de5-87b5-33111e1aa16b"), new Guid("01612f4e-97fd-456c-82b0-27b44b54f565"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("f47ea8f1-8d76-446e-995b-1d3e966d72cd"), new Guid("fd99a8cd-69df-484a-b210-5fdfe8885820"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("f60950f5-80de-4965-9905-4ac1bda2a81d"), new Guid("bf7d61b0-6590-4959-810d-b7f30b49e996"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("ff874513-9b33-4942-95b5-ff6d15819dd0"), new Guid("bf7d61b0-6590-4959-810d-b7f30b49e996"), true, true, "Персональные идентификаторы", 10 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("017d3c14-9469-40e7-95a7-91be30de1244"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("7954dce9-b3ab-4145-8700-93cbdba4b5cd"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("01f1805a-48a2-41be-bf02-c1064628f4dd"), false, "Соавторы", 3, new Guid("75874988-29ca-4b03-88dd-158483a577db"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("048c2e6a-8994-4af8-87b1-7b60d38c75f4"), false, "Тип идентификатора", 1, new Guid("ff874513-9b33-4942-95b5-ff6d15819dd0"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("062b7c5e-640d-424f-96ff-603084f24a9f"), true, "Количество часов", 4, new Guid("c5f5a2de-f3be-47b5-910a-f3494d5c1a5f"), new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("06e8fc24-c5e3-43fe-90bc-0b5a63a9d342"), true, "Практические занятия (час.)", 4, new Guid("96835141-e62f-4cea-ba74-6fcd7a2d14a9"), new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("098ffa30-08db-429a-949c-6650cfcee0c8"), true, "ФИО", 1, new Guid("7954dce9-b3ab-4145-8700-93cbdba4b5cd"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("0ac06204-b76f-443f-8ea9-b42fc863d01b"), true, "Язык публикации", 7, new Guid("75874988-29ca-4b03-88dd-158483a577db"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("0c587bda-abd4-4412-bc0c-268ebdaf4764"), true, "Период выполнения", 3, new Guid("21946e83-3c62-40a1-b724-e1f7e4cbf352"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("0ea8ea89-88dd-45c4-be0b-3562d92b0dae"), true, "Название конкурса/премии", 2, new Guid("7954dce9-b3ab-4145-8700-93cbdba4b5cd"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("12183f02-f501-4307-95b2-0dad60703163"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("a8202e6a-c89d-4631-98a5-7db5490a6335"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("1a674cf5-1414-41bc-94f2-23498bca4c8d"), true, "Год", 1, new Guid("f06867dc-a522-45c1-abb7-45d74c25e95f"), new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("1f7d8c90-c38d-43b6-8096-f757431d6411"), true, "Название организации/должность/ставка", 1, new Guid("c5f5a2de-f3be-47b5-910a-f3494d5c1a5f"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("236f7e47-a803-4cde-bde7-4ce003d1d28b"), true, "Ссылка на платформу", 3, new Guid("f0f1891a-72a8-4de5-87b5-33111e1aa16b"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("25361e15-ecf7-4440-8004-165d785ceb6f"), true, "Наименование курса", 1, new Guid("96835141-e62f-4cea-ba74-6fcd7a2d14a9"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("254540cf-c40a-4287-a992-5d9cd62b768a"), true, "Наличие грифа", 5, new Guid("75874988-29ca-4b03-88dd-158483a577db"), new Guid("2105dfd6-a71e-49f5-9da2-d84f47437b32") },
                    { new Guid("2bad6641-61a1-4102-8299-c46b993004dc"), true, "Вид", 1, new Guid("f47ea8f1-8d76-446e-995b-1d3e966d72cd"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("2d08a868-a1d4-4a47-8287-73e07e8fe725"), true, "Название конкурса", 2, new Guid("f06867dc-a522-45c1-abb7-45d74c25e95f"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("31f78f8d-7ff7-4a33-9563-358f77566ba1"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("96835141-e62f-4cea-ba74-6fcd7a2d14a9"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("34075954-39e0-41c0-abbd-ccfc4abff956"), true, "Название", 1, new Guid("02a509bb-6a9a-4982-93e0-9a1217da81ad"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("3924ff7a-8d95-4821-9530-731823df2f42"), true, "Статус конкурса", 3, new Guid("f06867dc-a522-45c1-abb7-45d74c25e95f"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("43a83aa3-3ce0-40b0-8256-5b6fa582275d"), true, "Год получения документа", 2, new Guid("f60950f5-80de-4965-9905-4ac1bda2a81d"), new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("47784eae-7851-48fc-8bb9-8ffe87d6af47"), true, "Название НИР/НИОКР", 1, new Guid("21946e83-3c62-40a1-b724-e1f7e4cbf352"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("49898a9a-4a23-4634-ac5a-e82de566125a"), true, "Издание, год", 4, new Guid("a8202e6a-c89d-4631-98a5-7db5490a6335"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("4dbd095e-b611-4b8a-a1b5-135f5637bc98"), true, "Год", 4, new Guid("f0f1891a-72a8-4de5-87b5-33111e1aa16b"), new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("4fb52e6d-9395-4055-9ad8-d16f3e3a2525"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("21946e83-3c62-40a1-b724-e1f7e4cbf352"), new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("5426197e-1323-4a8e-a68c-fa74e213a957"), true, "Издательство, год", 6, new Guid("75874988-29ca-4b03-88dd-158483a577db"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("6134230f-32ac-460a-9444-01893e5d0b6c"), true, "Название организации в которую внедрена разработка", 3, new Guid("ebfd4a20-ae4f-4e29-8f56-71213dd1687a"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("66975f23-8763-46a6-b8af-1fed8d5eb2eb"), true, "Лекции (час.)", 3, new Guid("96835141-e62f-4cea-ba74-6fcd7a2d14a9"), new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("696ce2c5-3b26-4d98-89f3-18c0ce60971a"), true, "Вид деятельности (преподавательская)", 3, new Guid("c5f5a2de-f3be-47b5-910a-f3494d5c1a5f"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("700fecb7-5ce7-477f-93aa-ca15e75133f2"), true, "Статус (руководитель/исполнитель)", 4, new Guid("21946e83-3c62-40a1-b724-e1f7e4cbf352"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("76f0ed67-23f2-44df-b935-455977068b48"), true, "Название статьи", 1, new Guid("a8202e6a-c89d-4631-98a5-7db5490a6335"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("7fbe062c-ccc6-4a0e-b4fc-634cff98b3c8"), true, "Название", 2, new Guid("f47ea8f1-8d76-446e-995b-1d3e966d72cd"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("81be4f4b-1b66-4ded-a5e8-f7d228de38bb"), true, "Вид (лекции, лабораторные)", 2, new Guid("8dc37210-6e69-4288-bfbe-4050c2d1164f"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("857b7733-b0bc-412b-a6f0-82bddb1fe2c4"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("21946e83-3c62-40a1-b724-e1f7e4cbf352"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("86f3bf61-500e-4e5e-98a0-bfc8990e7bad"), true, "Итого (час.)", 5, new Guid("96835141-e62f-4cea-ba74-6fcd7a2d14a9"), new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("87e0ce90-2ff9-45ef-bce5-d3f899dfe06a"), true, "Год", 3, new Guid("7954dce9-b3ab-4145-8700-93cbdba4b5cd"), new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("8a6780ea-5b63-48c7-bad1-72c52e558583"), true, "Номер РИД", 4, new Guid("f47ea8f1-8d76-446e-995b-1d3e966d72cd"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("8b3bb22d-dde4-4ffe-a44b-54d48bb7fa90"), true, "Название", 2, new Guid("75874988-29ca-4b03-88dd-158483a577db"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("9d4dc396-9d13-472b-a8cc-d3c07e9beedd"), true, "Название дисциплины", 1, new Guid("8dc37210-6e69-4288-bfbe-4050c2d1164f"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("9eb0f661-3095-4930-9391-ecab095056ab"), true, "Награда", 4, new Guid("f06867dc-a522-45c1-abb7-45d74c25e95f"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("acb3e833-f71d-4f83-8fbf-e3e08e5e329d"), true, "Ссылка", 5, new Guid("f06867dc-a522-45c1-abb7-45d74c25e95f"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("aebf0d6e-00cc-4ab4-b4d1-3eedc8091e74"), true, "Количество печатных листов", 4, new Guid("75874988-29ca-4b03-88dd-158483a577db"), new Guid("cda93755-14ea-4ed0-aa00-4bf00a1a99c8") },
                    { new Guid("b62cc6a2-8945-4e91-a91c-ec0746a5ad2d"), true, "Вид публикации", 1, new Guid("75874988-29ca-4b03-88dd-158483a577db"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("b6b0facf-24ae-4f2d-a562-905281a79981"), true, "Соавторы", 2, new Guid("f0f1891a-72a8-4de5-87b5-33111e1aa16b"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("ba94d1fa-5428-495f-9549-4d611166fd09"), false, "Идентификатор", 2, new Guid("ff874513-9b33-4942-95b5-ff6d15819dd0"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("bd9fdb21-6916-4c0a-8e03-d7300d245aeb"), true, "ФИО соавторов", 3, new Guid("f47ea8f1-8d76-446e-995b-1d3e966d72cd"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("c7cabc5b-c8f9-4ed6-904a-e6ea24045b6a"), true, "Соавторы", 2, new Guid("a8202e6a-c89d-4631-98a5-7db5490a6335"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("c8dcc1b8-5a8a-4109-bd82-8557608fe2f7"), true, "Ссылка на открытый доступ", 8, new Guid("75874988-29ca-4b03-88dd-158483a577db"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("d4886012-5ddd-416e-9f57-572c199bd32e"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("7954dce9-b3ab-4145-8700-93cbdba4b5cd"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("db55d553-4f31-4699-b4b8-bdcb6ebf62aa"), true, "Название курса", 1, new Guid("f0f1891a-72a8-4de5-87b5-33111e1aa16b"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("df18fa1e-1fcf-4073-8075-d7b1a62bbe6c"), true, "Вид", 1, new Guid("ebfd4a20-ae4f-4e29-8f56-71213dd1687a"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("e4a18a7f-43e0-4adb-a3fd-3366d9c8991a"), true, "Название разработки", 2, new Guid("ebfd4a20-ae4f-4e29-8f56-71213dd1687a"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("e4e44437-3cdf-4d34-b24e-7fec8c58e94e"), true, "Название документа, реквизиты", 1, new Guid("f60950f5-80de-4965-9905-4ac1bda2a81d"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("f0f9933d-4a8b-4be7-9456-98bae8975b13"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("8dc37210-6e69-4288-bfbe-4050c2d1164f"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") },
                    { new Guid("f94f22f7-52b1-4350-9254-352a657b08df"), true, "Значение", 2, new Guid("02a509bb-6a9a-4982-93e0-9a1217da81ad"), new Guid("f92cd2e7-5eed-4950-9949-f46c7729de92") },
                    { new Guid("f9ef3b3c-af5f-4bab-a469-43e166f432fd"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("c5f5a2de-f3be-47b5-910a-f3494d5c1a5f"), new Guid("c0d9912a-11ef-4fec-9a36-0b1ac95e18e4") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("07a6a9b2-7916-4b40-ae2d-0d7f7a2cd59d"), new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344") },
                    { new Guid("24f644b8-d2bb-48d2-9cbb-92881fab217e"), new Guid("27fb7a70-167c-40ff-86ba-9c5653124888") },
                    { new Guid("24f644b8-d2bb-48d2-9cbb-92881fab217e"), new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344") },
                    { new Guid("24f644b8-d2bb-48d2-9cbb-92881fab217e"), new Guid("cc8a9b5e-5e80-49bb-ada6-9f3e463dd5b5") },
                    { new Guid("2acc2aeb-f5aa-41c6-9a86-99cb2eb3dc30"), new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046") },
                    { new Guid("2f7a7475-1d1e-4d54-96f4-e9183a910e0a"), new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344") },
                    { new Guid("3d02e513-d5d4-4c4a-a74b-dae357c72389"), new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344") },
                    { new Guid("630f78c8-5b67-401f-92bb-306848ac275f"), new Guid("27fb7a70-167c-40ff-86ba-9c5653124888") },
                    { new Guid("7cfd8f05-a1b7-499c-96bd-1773fbe67730"), new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344") },
                    { new Guid("8493b7c8-1271-49c6-a2d2-0de79fb546ee"), new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344") },
                    { new Guid("8833e2db-7bec-4ded-ba3d-0036b7529fa6"), new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046") },
                    { new Guid("8abdee5a-19e7-4ec0-af08-2c9d88844a46"), new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344") },
                    { new Guid("a5b9c797-d3f0-4d6e-968b-d7d4bc0e8733"), new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344") },
                    { new Guid("b56c31f3-b126-4ce6-b7c0-3dcc22e1228d"), new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046") },
                    { new Guid("bf2cde37-b9de-4739-a0be-64dc3918a931"), new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344") },
                    { new Guid("d54bc427-c324-4ab6-bf7e-95cdb900890d"), new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344") },
                    { new Guid("d5591869-90c6-45f8-bac6-355cf87d464d"), new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344") },
                    { new Guid("e13e9fff-3510-46ff-8329-17dfc7557161"), new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344") },
                    { new Guid("eba011c1-10f1-476d-b255-4eac986b3e05"), new Guid("27fb7a70-167c-40ff-86ba-9c5653124888") },
                    { new Guid("f03af6b7-d3cf-49f8-b3ac-2e9691732a72"), new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344") },
                    { new Guid("f9141d3f-66d7-4bea-9f75-d864eeaa0740"), new Guid("b42ba86d-b0d9-44ac-89f8-531e7caa0344") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046"), new Guid("7954dce9-b3ab-4145-8700-93cbdba4b5cd") },
                    { new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046"), new Guid("96835141-e62f-4cea-ba74-6fcd7a2d14a9") },
                    { new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046"), new Guid("c5f5a2de-f3be-47b5-910a-f3494d5c1a5f") },
                    { new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046"), new Guid("f0f1891a-72a8-4de5-87b5-33111e1aa16b") },
                    { new Guid("27fb7a70-167c-40ff-86ba-9c5653124888"), new Guid("21946e83-3c62-40a1-b724-e1f7e4cbf352") },
                    { new Guid("27fb7a70-167c-40ff-86ba-9c5653124888"), new Guid("a8202e6a-c89d-4631-98a5-7db5490a6335") },
                    { new Guid("27fb7a70-167c-40ff-86ba-9c5653124888"), new Guid("f06867dc-a522-45c1-abb7-45d74c25e95f") },
                    { new Guid("27fb7a70-167c-40ff-86ba-9c5653124888"), new Guid("ff874513-9b33-4942-95b5-ff6d15819dd0") },
                    { new Guid("b195cca1-47a6-4956-b40a-07709088a8eb"), new Guid("ebfd4a20-ae4f-4e29-8f56-71213dd1687a") },
                    { new Guid("b195cca1-47a6-4956-b40a-07709088a8eb"), new Guid("f47ea8f1-8d76-446e-995b-1d3e966d72cd") },
                    { new Guid("b195cca1-47a6-4956-b40a-07709088a8eb"), new Guid("f60950f5-80de-4965-9905-4ac1bda2a81d") },
                    { new Guid("cb0db337-a7d1-472b-b0d0-017af20f9987"), new Guid("02a509bb-6a9a-4982-93e0-9a1217da81ad") },
                    { new Guid("cc8a9b5e-5e80-49bb-ada6-9f3e463dd5b5"), new Guid("f06867dc-a522-45c1-abb7-45d74c25e95f") },
                    { new Guid("cc8a9b5e-5e80-49bb-ada6-9f3e463dd5b5"), new Guid("f60950f5-80de-4965-9905-4ac1bda2a81d") },
                    { new Guid("dc545ee8-4417-423d-b76b-6fb123570b15"), new Guid("75874988-29ca-4b03-88dd-158483a577db") },
                    { new Guid("dc545ee8-4417-423d-b76b-6fb123570b15"), new Guid("8dc37210-6e69-4288-bfbe-4050c2d1164f") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0585fa7e-b6e4-4e6f-9431-4f51f4e522d8"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("7954dce9-b3ab-4145-8700-93cbdba4b5cd") },
                    { new Guid("119a19a7-4461-4cfe-9ec8-237f2bf25fca"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("75874988-29ca-4b03-88dd-158483a577db") },
                    { new Guid("144a0329-f210-4d7a-8a9b-16d92535568c"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("a8202e6a-c89d-4631-98a5-7db5490a6335") },
                    { new Guid("1d491b50-943e-4227-9db7-b110a61a97e2"), null, null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("02a509bb-6a9a-4982-93e0-9a1217da81ad") },
                    { new Guid("31246acb-172f-43f1-b4cf-f58ef88e5a26"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("ebfd4a20-ae4f-4e29-8f56-71213dd1687a") },
                    { new Guid("3f961d75-415b-43c8-9f11-d572f0b2da4b"), "EvaluateMark20", new Guid("eba011c1-10f1-476d-b255-4eac986b3e05"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("5e778b0a-e542-4fc9-934c-c1491605ab4a"), "EvaluateMark3", new Guid("2acc2aeb-f5aa-41c6-9a86-99cb2eb3dc30"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("6be69bbe-386e-4de0-b3a1-9ec946b12084"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("f0f1891a-72a8-4de5-87b5-33111e1aa16b") },
                    { new Guid("6e825c69-9014-4af7-9d3a-2d0be3d2f2fa"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("f47ea8f1-8d76-446e-995b-1d3e966d72cd") },
                    { new Guid("7811d080-77d7-42de-a38d-9c3b773f436d"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("21946e83-3c62-40a1-b724-e1f7e4cbf352") },
                    { new Guid("83ceb038-e468-4e0e-929b-35828fa36b44"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("75874988-29ca-4b03-88dd-158483a577db") },
                    { new Guid("8cc17e88-0af5-4cd9-a09a-e44cb3c36fbe"), "EvaluateMark4", new Guid("8833e2db-7bec-4ded-ba3d-0036b7529fa6"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("8ff50261-392e-41d9-9d69-463e8239ad28"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("96835141-e62f-4cea-ba74-6fcd7a2d14a9") },
                    { new Guid("90be141c-713e-43e9-8beb-e57ff5ae0b16"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("75874988-29ca-4b03-88dd-158483a577db") },
                    { new Guid("96ab4539-ab00-4b53-9e97-7cf267b6b5dd"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("8dc37210-6e69-4288-bfbe-4050c2d1164f") },
                    { new Guid("9bcb2f85-256e-42ab-85a3-513008fe1cd5"), "EvaluateMark19", new Guid("630f78c8-5b67-401f-92bb-306848ac275f"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("a56f8f52-0f47-4c69-957f-5718d914b997"), "EvaluateMark5", new Guid("b56c31f3-b126-4ce6-b7c0-3dcc22e1228d"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("ab192631-b256-4a4e-92da-58c56d1fbdba"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("21946e83-3c62-40a1-b724-e1f7e4cbf352") },
                    { new Guid("b25c74c6-3ec6-47c8-9b84-81dd9ea73cd4"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("75874988-29ca-4b03-88dd-158483a577db") },
                    { new Guid("b99e7ab7-885e-4b5f-b2cb-ed8f0fc73d56"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("96835141-e62f-4cea-ba74-6fcd7a2d14a9") },
                    { new Guid("c58d97c0-1029-428a-9621-8da47274f281"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("f60950f5-80de-4965-9905-4ac1bda2a81d") },
                    { new Guid("d8bc2bea-f0f8-4461-b432-6515da6a7024"), null, null, false, 10, "Оценка уровня предоставленной работы:", 25, new Guid("02a509bb-6a9a-4982-93e0-9a1217da81ad") },
                    { new Guid("d8e16c94-b7ab-453e-a85e-d06ac1630419"), "EvaluateMark13", new Guid("24f644b8-d2bb-48d2-9cbb-92881fab217e"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("f6d35625-6a70-44f3-b5bd-ffb3514ca565"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("f06867dc-a522-45c1-abb7-45d74c25e95f") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("0ff7c42b-6787-4160-8f94-178714889f7f"), true, new Guid("ff874513-9b33-4942-95b5-ff6d15819dd0") },
                    { new Guid("2540adf5-9e7f-4c57-906c-fca05c612c99"), true, new Guid("02a509bb-6a9a-4982-93e0-9a1217da81ad") },
                    { new Guid("3f3b7049-08e6-44c2-8a03-af6704723b4b"), true, new Guid("02a509bb-6a9a-4982-93e0-9a1217da81ad") },
                    { new Guid("4a0ef3d4-3460-44ed-987e-7cb5d8420d6d"), true, new Guid("02a509bb-6a9a-4982-93e0-9a1217da81ad") },
                    { new Guid("4aa80564-5a89-4d62-bb31-e1e7b63430df"), true, new Guid("ff874513-9b33-4942-95b5-ff6d15819dd0") },
                    { new Guid("5b370e40-3bbe-47d1-8fdd-9064988076d6"), true, new Guid("02a509bb-6a9a-4982-93e0-9a1217da81ad") },
                    { new Guid("60138a17-4ccc-494f-8f87-e709b8ff4124"), true, new Guid("02a509bb-6a9a-4982-93e0-9a1217da81ad") },
                    { new Guid("67a58556-790c-4f52-a967-1104653e5b61"), true, new Guid("02a509bb-6a9a-4982-93e0-9a1217da81ad") },
                    { new Guid("92187743-ffa9-40a2-bd3c-c7ff87884b2d"), true, new Guid("02a509bb-6a9a-4982-93e0-9a1217da81ad") },
                    { new Guid("afbf2e17-260c-4416-9891-31ba04c7815f"), true, new Guid("ff874513-9b33-4942-95b5-ff6d15819dd0") },
                    { new Guid("d1a5281f-03c2-4693-a322-8f4a1885c7ec"), true, new Guid("ff874513-9b33-4942-95b5-ff6d15819dd0") },
                    { new Guid("e723aa6e-e639-42e6-a837-7a97fb530267"), true, new Guid("ff874513-9b33-4942-95b5-ff6d15819dd0") },
                    { new Guid("f43f2023-32f6-4442-abb1-1c8fb434abc7"), true, new Guid("02a509bb-6a9a-4982-93e0-9a1217da81ad") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0373a82c-78a9-4efd-8b2b-703a27561e62"), null, new Guid("2f7a7475-1d1e-4d54-96f4-e9183a910e0a"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("39f61ce5-008f-4ef2-88f4-fc73379e7ea9"), null, new Guid("24f644b8-d2bb-48d2-9cbb-92881fab217e"), "Нет" },
                    { new Guid("55dc3fa8-20d9-4405-9ad5-fee133fb31dc"), null, new Guid("2f7a7475-1d1e-4d54-96f4-e9183a910e0a"), "Имеющие ученую степень доктора наук" },
                    { new Guid("6cae46de-7391-422e-bc82-30834d732bf3"), null, new Guid("24f644b8-d2bb-48d2-9cbb-92881fab217e"), "Доцент" },
                    { new Guid("823fd51a-0444-4f93-b98e-264bedb60900"), null, new Guid("e13e9fff-3510-46ff-8329-17dfc7557161"), "Доктор наук" },
                    { new Guid("beced41c-518c-41a2-b2e5-9144551db9b5"), null, new Guid("24f644b8-d2bb-48d2-9cbb-92881fab217e"), "Профессор" },
                    { new Guid("bf3f7e38-3dc5-4ca6-8e5c-7fe4baa46589"), null, new Guid("e13e9fff-3510-46ff-8329-17dfc7557161"), "Кандидат наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("0f2695eb-f76d-46e0-b40b-89e458a6bcb9"), null, new Guid("34075954-39e0-41c0-abbd-ccfc4abff956"), true, true, new Guid("60138a17-4ccc-494f-8f87-e709b8ff4124"), "Инновационность" },
                    { new Guid("153eeafd-18fd-4006-916e-e36dc7299416"), null, new Guid("f94f22f7-52b1-4350-9254-352a657b08df"), false, true, new Guid("60138a17-4ccc-494f-8f87-e709b8ff4124"), null },
                    { new Guid("175a0612-b1ad-448b-81b9-75e19f50c6a7"), null, new Guid("34075954-39e0-41c0-abbd-ccfc4abff956"), true, true, new Guid("f43f2023-32f6-4442-abb1-1c8fb434abc7"), "Методология и методы, используемые в работе" },
                    { new Guid("18ba9055-9364-49e0-91b1-d49d8147ad99"), null, new Guid("048c2e6a-8994-4af8-87b1-7b60d38c75f4"), true, true, new Guid("d1a5281f-03c2-4693-a322-8f4a1885c7ec"), "ScopusID" },
                    { new Guid("27d598c6-4129-4c93-9cc3-4239bb58ff74"), null, new Guid("ba94d1fa-5428-495f-9549-4d611166fd09"), false, true, new Guid("4aa80564-5a89-4d62-bb31-e1e7b63430df"), null },
                    { new Guid("299accfd-7ca7-4089-87ca-8c9904463f7d"), null, new Guid("048c2e6a-8994-4af8-87b1-7b60d38c75f4"), true, true, new Guid("afbf2e17-260c-4416-9891-31ba04c7815f"), "РИНЦ AuthorID" },
                    { new Guid("2a2fa4a5-2387-49f2-97d2-5144869d8775"), null, new Guid("048c2e6a-8994-4af8-87b1-7b60d38c75f4"), true, true, new Guid("0ff7c42b-6787-4160-8f94-178714889f7f"), "Google Scholar ID" },
                    { new Guid("2b396d89-d556-4c76-b32f-8468535e06ad"), null, new Guid("f94f22f7-52b1-4350-9254-352a657b08df"), false, true, new Guid("2540adf5-9e7f-4c57-906c-fca05c612c99"), null },
                    { new Guid("3da5f10e-9d73-4ae0-9852-749e27e93e33"), null, new Guid("f94f22f7-52b1-4350-9254-352a657b08df"), false, true, new Guid("67a58556-790c-4f52-a967-1104653e5b61"), null },
                    { new Guid("5c7321b9-0e94-42d0-90da-80414c266068"), null, new Guid("f94f22f7-52b1-4350-9254-352a657b08df"), false, true, new Guid("4a0ef3d4-3460-44ed-987e-7cb5d8420d6d"), null },
                    { new Guid("61b0cdf6-acc5-4881-8eb1-b85eccc2e0e0"), null, new Guid("f94f22f7-52b1-4350-9254-352a657b08df"), false, true, new Guid("5b370e40-3bbe-47d1-8fdd-9064988076d6"), null },
                    { new Guid("6bc97190-bcba-430a-b1b1-a3cc48bcc496"), null, new Guid("34075954-39e0-41c0-abbd-ccfc4abff956"), true, true, new Guid("92187743-ffa9-40a2-bd3c-c7ff87884b2d"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("7625816a-9cf0-4483-af3e-c149cb98f5d4"), null, new Guid("f94f22f7-52b1-4350-9254-352a657b08df"), false, true, new Guid("f43f2023-32f6-4442-abb1-1c8fb434abc7"), null },
                    { new Guid("7e838f76-58c3-4fa0-945a-edb38c48add5"), null, new Guid("34075954-39e0-41c0-abbd-ccfc4abff956"), true, true, new Guid("3f3b7049-08e6-44c2-8a03-af6704723b4b"), "Результаты и выводы" },
                    { new Guid("870d6735-2d7e-4e1e-804e-2cd1a8d92104"), null, new Guid("048c2e6a-8994-4af8-87b1-7b60d38c75f4"), true, true, new Guid("4aa80564-5a89-4d62-bb31-e1e7b63430df"), "ORCiD" },
                    { new Guid("9f66ca31-e274-4a64-b60d-5a024604f560"), null, new Guid("ba94d1fa-5428-495f-9549-4d611166fd09"), false, true, new Guid("0ff7c42b-6787-4160-8f94-178714889f7f"), null },
                    { new Guid("af326cdc-b8f7-4060-a315-df0f8f10e65b"), null, new Guid("ba94d1fa-5428-495f-9549-4d611166fd09"), false, true, new Guid("afbf2e17-260c-4416-9891-31ba04c7815f"), null },
                    { new Guid("be7e0df5-5117-4dfd-8fd5-ca9c65cbdcad"), null, new Guid("34075954-39e0-41c0-abbd-ccfc4abff956"), true, true, new Guid("4a0ef3d4-3460-44ed-987e-7cb5d8420d6d"), "Название работы" },
                    { new Guid("c3008741-4ff6-4bce-a817-4e8f921783ba"), null, new Guid("f94f22f7-52b1-4350-9254-352a657b08df"), false, true, new Guid("3f3b7049-08e6-44c2-8a03-af6704723b4b"), null },
                    { new Guid("c38ff011-5fdd-4231-9a1c-0da7aee0ae75"), null, new Guid("34075954-39e0-41c0-abbd-ccfc4abff956"), true, true, new Guid("5b370e40-3bbe-47d1-8fdd-9064988076d6"), "Ссылка на конкурсную работу" },
                    { new Guid("c92be2c0-d118-48de-a515-f10f69c16921"), null, new Guid("ba94d1fa-5428-495f-9549-4d611166fd09"), false, true, new Guid("d1a5281f-03c2-4693-a322-8f4a1885c7ec"), null },
                    { new Guid("d82c6796-c02a-4784-9108-47d1e9ead368"), null, new Guid("f94f22f7-52b1-4350-9254-352a657b08df"), false, true, new Guid("92187743-ffa9-40a2-bd3c-c7ff87884b2d"), null },
                    { new Guid("d9391137-055c-40ad-8190-030b7fda71a7"), null, new Guid("ba94d1fa-5428-495f-9549-4d611166fd09"), false, true, new Guid("e723aa6e-e639-42e6-a837-7a97fb530267"), null },
                    { new Guid("dee74c11-c5b0-42b3-b106-c7395c273b49"), null, new Guid("34075954-39e0-41c0-abbd-ccfc4abff956"), true, true, new Guid("67a58556-790c-4f52-a967-1104653e5b61"), "Актуальность конкурсной работы" },
                    { new Guid("ed57bc2e-957e-478c-b583-4da1bdbcd01c"), null, new Guid("048c2e6a-8994-4af8-87b1-7b60d38c75f4"), true, true, new Guid("e723aa6e-e639-42e6-a837-7a97fb530267"), "ResearcherID" },
                    { new Guid("fb3fbd26-a09a-469a-aa15-2a4613c86366"), null, new Guid("34075954-39e0-41c0-abbd-ccfc4abff956"), true, true, new Guid("2540adf5-9e7f-4c57-906c-fca05c612c99"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046"), new Guid("0585fa7e-b6e4-4e6f-9431-4f51f4e522d8") },
                    { new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046"), new Guid("5e778b0a-e542-4fc9-934c-c1491605ab4a") },
                    { new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046"), new Guid("6be69bbe-386e-4de0-b3a1-9ec946b12084") },
                    { new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046"), new Guid("8cc17e88-0af5-4cd9-a09a-e44cb3c36fbe") },
                    { new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046"), new Guid("8ff50261-392e-41d9-9d69-463e8239ad28") },
                    { new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046"), new Guid("a56f8f52-0f47-4c69-957f-5718d914b997") },
                    { new Guid("11bf2729-6ede-4a84-81c5-b84cd038a046"), new Guid("b99e7ab7-885e-4b5f-b2cb-ed8f0fc73d56") },
                    { new Guid("27fb7a70-167c-40ff-86ba-9c5653124888"), new Guid("144a0329-f210-4d7a-8a9b-16d92535568c") },
                    { new Guid("27fb7a70-167c-40ff-86ba-9c5653124888"), new Guid("3f961d75-415b-43c8-9f11-d572f0b2da4b") },
                    { new Guid("27fb7a70-167c-40ff-86ba-9c5653124888"), new Guid("7811d080-77d7-42de-a38d-9c3b773f436d") },
                    { new Guid("27fb7a70-167c-40ff-86ba-9c5653124888"), new Guid("9bcb2f85-256e-42ab-85a3-513008fe1cd5") },
                    { new Guid("27fb7a70-167c-40ff-86ba-9c5653124888"), new Guid("ab192631-b256-4a4e-92da-58c56d1fbdba") },
                    { new Guid("27fb7a70-167c-40ff-86ba-9c5653124888"), new Guid("d8e16c94-b7ab-453e-a85e-d06ac1630419") },
                    { new Guid("27fb7a70-167c-40ff-86ba-9c5653124888"), new Guid("f6d35625-6a70-44f3-b5bd-ffb3514ca565") },
                    { new Guid("b195cca1-47a6-4956-b40a-07709088a8eb"), new Guid("31246acb-172f-43f1-b4cf-f58ef88e5a26") },
                    { new Guid("b195cca1-47a6-4956-b40a-07709088a8eb"), new Guid("6e825c69-9014-4af7-9d3a-2d0be3d2f2fa") },
                    { new Guid("b195cca1-47a6-4956-b40a-07709088a8eb"), new Guid("c58d97c0-1029-428a-9621-8da47274f281") },
                    { new Guid("cb0db337-a7d1-472b-b0d0-017af20f9987"), new Guid("1d491b50-943e-4227-9db7-b110a61a97e2") },
                    { new Guid("cb0db337-a7d1-472b-b0d0-017af20f9987"), new Guid("d8bc2bea-f0f8-4461-b432-6515da6a7024") },
                    { new Guid("cc8a9b5e-5e80-49bb-ada6-9f3e463dd5b5"), new Guid("c58d97c0-1029-428a-9621-8da47274f281") },
                    { new Guid("cc8a9b5e-5e80-49bb-ada6-9f3e463dd5b5"), new Guid("d8e16c94-b7ab-453e-a85e-d06ac1630419") },
                    { new Guid("cc8a9b5e-5e80-49bb-ada6-9f3e463dd5b5"), new Guid("f6d35625-6a70-44f3-b5bd-ffb3514ca565") },
                    { new Guid("dc545ee8-4417-423d-b76b-6fb123570b15"), new Guid("119a19a7-4461-4cfe-9ec8-237f2bf25fca") },
                    { new Guid("dc545ee8-4417-423d-b76b-6fb123570b15"), new Guid("83ceb038-e468-4e0e-929b-35828fa36b44") },
                    { new Guid("dc545ee8-4417-423d-b76b-6fb123570b15"), new Guid("90be141c-713e-43e9-8beb-e57ff5ae0b16") },
                    { new Guid("dc545ee8-4417-423d-b76b-6fb123570b15"), new Guid("96ab4539-ab00-4b53-9e97-7cf267b6b5dd") },
                    { new Guid("dc545ee8-4417-423d-b76b-6fb123570b15"), new Guid("b25c74c6-3ec6-47c8-9b84-81dd9ea73cd4") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("00676f98-302f-4b72-b29d-87008f3ebc6d"), new Guid("c7cabc5b-c8f9-4ed6-904a-e6ea24045b6a"), null, "Есть" },
                    { new Guid("1641c800-e85a-4c79-a0b8-1dfc7f9b7361"), new Guid("2bad6641-61a1-4102-8299-c46b993004dc"), null, "Изобретение" },
                    { new Guid("1a991566-9682-4a74-8c77-d0b0cc7f400a"), new Guid("3924ff7a-8d95-4821-9530-731823df2f42"), null, "Международный" },
                    { new Guid("24251d8a-67f7-4ed0-8567-a741caeeca4e"), new Guid("b62cc6a2-8945-4e91-a91c-ec0746a5ad2d"), null, "Монография" },
                    { new Guid("448f7cd5-aff9-4d61-a8b6-c5502f49637d"), new Guid("df18fa1e-1fcf-4073-8075-d7b1a62bbe6c"), null, "Изобретение" },
                    { new Guid("4891b7bf-a171-4bab-a3cb-882e705af9e2"), new Guid("700fecb7-5ce7-477f-93aa-ca15e75133f2"), null, "Руководитель" },
                    { new Guid("496ca4b4-be42-4505-ab4b-4713cb6fe2dc"), new Guid("01f1805a-48a2-41be-bf02-c1064628f4dd"), null, "Нет" },
                    { new Guid("51f4f085-0fa1-42bd-b6da-5c0165995533"), new Guid("01f1805a-48a2-41be-bf02-c1064628f4dd"), null, "Есть" },
                    { new Guid("586c5170-1e1b-4a53-812c-a080c64f3ad3"), new Guid("3924ff7a-8d95-4821-9530-731823df2f42"), null, "Региональный" },
                    { new Guid("5cf56b23-a0c9-47be-918f-16ce0f14798a"), new Guid("2bad6641-61a1-4102-8299-c46b993004dc"), null, "Полезная модель" },
                    { new Guid("69d09be3-60ef-4e1f-a712-7ccc35829a91"), new Guid("3924ff7a-8d95-4821-9530-731823df2f42"), null, "Всероссийский" },
                    { new Guid("7ef60be8-4ac3-47f9-b36b-7968fe0aa876"), new Guid("81be4f4b-1b66-4ded-a5e8-f7d228de38bb"), null, "Лекции" },
                    { new Guid("897331ae-d236-47a0-958f-456b6a190f09"), new Guid("b62cc6a2-8945-4e91-a91c-ec0746a5ad2d"), null, "Учебник" },
                    { new Guid("8b455d0a-fe28-4fab-89ce-5ab62d96404e"), new Guid("0ac06204-b76f-443f-8ea9-b42fc863d01b"), null, "Русский" },
                    { new Guid("8e04ade1-0cc0-457a-8106-b729a534665f"), new Guid("b62cc6a2-8945-4e91-a91c-ec0746a5ad2d"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("909b54b0-67f5-4820-a664-528b98f0c631"), new Guid("df18fa1e-1fcf-4073-8075-d7b1a62bbe6c"), null, "Полезная модель" },
                    { new Guid("a8837484-f5a4-43db-8e21-9fe6c1cabeef"), new Guid("81be4f4b-1b66-4ded-a5e8-f7d228de38bb"), null, "Лабораторные" },
                    { new Guid("a8906fa7-5706-4300-af9a-d13489bb6616"), new Guid("700fecb7-5ce7-477f-93aa-ca15e75133f2"), null, "Исполнитель" },
                    { new Guid("d2eb4998-1fc1-4cee-ab17-cac0fefebfb9"), new Guid("df18fa1e-1fcf-4073-8075-d7b1a62bbe6c"), null, "База данных" },
                    { new Guid("d967fa54-70dd-4bdd-953d-a69d22814236"), new Guid("0ac06204-b76f-443f-8ea9-b42fc863d01b"), null, "Иностранный" },
                    { new Guid("ec26aa03-5a78-4a14-a6ad-aa96d1979423"), new Guid("2bad6641-61a1-4102-8299-c46b993004dc"), null, "База данных" },
                    { new Guid("fa1b459c-fe8e-4a1e-b6ca-7170d1984fe8"), new Guid("c7cabc5b-c8f9-4ed6-904a-e6ea24045b6a"), null, "Нет" }
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
                name: "Feedbacks");

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
