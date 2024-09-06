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
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Message = table.Column<string>(type: "TEXT", nullable: true),
                    Checked = table.Column<bool>(type: "INTEGER", nullable: false),
                    ApplicationFormId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_ApplicationForms_ApplicationFormId",
                        column: x => x.ApplicationFormId,
                        principalTable: "ApplicationForms",
                        principalColumn: "Id");
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
                    { new Guid("763c91d5-5170-4993-a808-0e05e25095ea"), 6, "Оценена" },
                    { new Guid("91a46fd3-6f15-4240-956f-c5c93a8c7b62"), 5, "Отклонена" },
                    { new Guid("9a380552-79d6-460a-8f7e-cbaff796031e"), 4, "Одобрена" },
                    { new Guid("a08df53b-ede7-4406-b4e2-b7a8376389a3"), 3, "В процессе рассмотрения" },
                    { new Guid("c85dd3da-ccb1-49eb-8acc-43242b725966"), 1, "В ожидании заполнения" },
                    { new Guid("dd27b52e-c7c2-414c-94d7-c1536508ada4"), 2, "В ожидании рассмотрения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "29cf82aa-678c-454b-9232-8ad370607753", null, "Voter", "VOTER" },
                    { "4a4269c8-30a0-446f-bd23-772927c451d6", null, "Admin", "ADMIN" },
                    { "aa68f334-5d24-41d5-938b-f89bc0a44863", null, "Expert", "EXPERT" },
                    { "cf9c7f65-a5d3-4fae-b7ef-a0d69f1f391d", null, "Organiser", "ORGANISER" },
                    { "dc3f6eb3-0b0b-41fd-81db-af651b75863c", null, "Participant", "PARTICIPANT" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("043fdecf-1ccd-49b6-ab7b-beb1ebb7fb5e"), "Строительство и архитектура", 1 },
                    { new Guid("d7a00c2c-cbe8-46fe-84e8-6694941dcac9"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("358cd0e4-b37b-4d4d-b686-312b25340a02"), "Деятельность", 5 },
                    { new Guid("5561bcf2-ba9e-4d96-bc5d-2ec98f6fd179"), "Профессиональное развитие", 3 },
                    { new Guid("57106eb0-28a8-425b-ac3b-f6a18db32f4f"), "Деятельность", 4 },
                    { new Guid("9ab5e9a9-6df6-4fee-93d0-aca1f11b0714"), "Категория участников", 2 },
                    { new Guid("bfb97334-a908-4ee5-8d09-846b11bce78d"), "Общая информация", 1 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "ApplicationFormId", "Checked", "Email", "Message", "Name" },
                values: new object[] { new Guid("b677dac2-3034-4f03-8492-a41a16e7054f"), null, false, "system@system.ru", "Test Message for System", "SYSTEM" });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0e304fda-a8f9-4b6e-91d7-1002062cf9ef"), "Методическая деятельность", 3 },
                    { new Guid("0fd2fa3a-e9cb-4164-8820-6d7cb5cc8a1b"), "Профессиональные показатели", 4 },
                    { new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97"), "Образовательная деятельность", 2 },
                    { new Guid("56ceacab-2883-4fc3-956e-7f673ac44cd0"), "Конкурсная работа", 7 },
                    { new Guid("66bb6b2d-1842-4456-b543-4ece86abff5d"), "Инновационная и иная деятельность", 6 },
                    { new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50"), "Основной", 1 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("35dfe5ef-82a7-418a-8724-71f5ba108805"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("a4becdfb-e28c-484d-86fc-268e5171cb30"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3f41b224-f1f3-4974-9918-f1b1ae01bb7f"), "bool" },
                    { new Guid("48dc1a17-68d8-41e0-9273-39b43318710b"), "int" },
                    { new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974"), "string" },
                    { new Guid("8e2c2417-6852-4aae-868f-bc2435dde3bd"), "TextArea" },
                    { new Guid("c1976735-c3e6-4435-910a-4295b0275b0c"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("358cd0e4-b37b-4d4d-b686-312b25340a02"), new Guid("35dfe5ef-82a7-418a-8724-71f5ba108805") },
                    { new Guid("5561bcf2-ba9e-4d96-bc5d-2ec98f6fd179"), new Guid("35dfe5ef-82a7-418a-8724-71f5ba108805") },
                    { new Guid("5561bcf2-ba9e-4d96-bc5d-2ec98f6fd179"), new Guid("a4becdfb-e28c-484d-86fc-268e5171cb30") },
                    { new Guid("57106eb0-28a8-425b-ac3b-f6a18db32f4f"), new Guid("a4becdfb-e28c-484d-86fc-268e5171cb30") },
                    { new Guid("9ab5e9a9-6df6-4fee-93d0-aca1f11b0714"), new Guid("35dfe5ef-82a7-418a-8724-71f5ba108805") },
                    { new Guid("9ab5e9a9-6df6-4fee-93d0-aca1f11b0714"), new Guid("a4becdfb-e28c-484d-86fc-268e5171cb30") },
                    { new Guid("bfb97334-a908-4ee5-8d09-846b11bce78d"), new Guid("35dfe5ef-82a7-418a-8724-71f5ba108805") },
                    { new Guid("bfb97334-a908-4ee5-8d09-846b11bce78d"), new Guid("a4becdfb-e28c-484d-86fc-268e5171cb30") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("074df861-a9cd-41fd-a164-5533df0aaa0a"), new Guid("57106eb0-28a8-425b-ac3b-f6a18db32f4f"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("336e9356-f0f1-4e7b-b7ed-af24077b1363"), new Guid("bfb97334-a908-4ee5-8d09-846b11bce78d"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("37c5bafe-13d7-402d-ad75-e608d8b04fe7"), new Guid("358cd0e4-b37b-4d4d-b686-312b25340a02"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("47732a36-9141-42e1-b25e-996798b5f347"), new Guid("bfb97334-a908-4ee5-8d09-846b11bce78d"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("c1976735-c3e6-4435-910a-4295b0275b0c") },
                    { new Guid("4e730b60-1742-45d0-8c45-f48214b99366"), new Guid("bfb97334-a908-4ee5-8d09-846b11bce78d"), null, true, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("508fe299-5354-49cb-b745-a898be9fa040"), new Guid("bfb97334-a908-4ee5-8d09-846b11bce78d"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("537065c7-27d4-4bde-908e-23f428f560a4"), new Guid("bfb97334-a908-4ee5-8d09-846b11bce78d"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("6adc8d97-ad3d-430d-a3f2-e94e45cc5895"), new Guid("bfb97334-a908-4ee5-8d09-846b11bce78d"), null, false, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("6bdbbe3a-325b-4ea9-a66c-c545fa063b77"), new Guid("9ab5e9a9-6df6-4fee-93d0-aca1f11b0714"), null, true, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("6fb39dd0-63c0-4a74-bb06-28b2805d816e"), new Guid("9ab5e9a9-6df6-4fee-93d0-aca1f11b0714"), null, false, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("74862a25-aff3-420e-a728-819d6f4105d7"), new Guid("57106eb0-28a8-425b-ac3b-f6a18db32f4f"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("78c1ac8f-07c5-46d8-b122-f6c103e9c513"), new Guid("358cd0e4-b37b-4d4d-b686-312b25340a02"), null, false, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("7a592818-f3cd-47e6-9aad-9fb3686f7fd1"), new Guid("57106eb0-28a8-425b-ac3b-f6a18db32f4f"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("80bbfa9d-c374-4e27-b9f8-449c9a10c18b"), new Guid("bfb97334-a908-4ee5-8d09-846b11bce78d"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("8162a2db-0dcb-48ef-91cd-44a06c48ff10"), new Guid("9ab5e9a9-6df6-4fee-93d0-aca1f11b0714"), null, false, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("a66f660c-fd15-4819-9b4a-569645152dfa"), new Guid("bfb97334-a908-4ee5-8d09-846b11bce78d"), null, false, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("ba8943b9-9f29-4cbc-a623-d9f94f5982b8"), new Guid("bfb97334-a908-4ee5-8d09-846b11bce78d"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("cac36c3b-9293-400f-af39-8500237408f1"), new Guid("bfb97334-a908-4ee5-8d09-846b11bce78d"), null, true, true, "Место работы/учебы", 6, "Название организации", new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("e3e87448-b8f6-45cf-860d-919b22adfca6"), new Guid("9ab5e9a9-6df6-4fee-93d0-aca1f11b0714"), null, true, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0e304fda-a8f9-4b6e-91d7-1002062cf9ef"), new Guid("a4becdfb-e28c-484d-86fc-268e5171cb30") },
                    { new Guid("0fd2fa3a-e9cb-4164-8820-6d7cb5cc8a1b"), new Guid("a4becdfb-e28c-484d-86fc-268e5171cb30") },
                    { new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97"), new Guid("a4becdfb-e28c-484d-86fc-268e5171cb30") },
                    { new Guid("56ceacab-2883-4fc3-956e-7f673ac44cd0"), new Guid("35dfe5ef-82a7-418a-8724-71f5ba108805") },
                    { new Guid("56ceacab-2883-4fc3-956e-7f673ac44cd0"), new Guid("a4becdfb-e28c-484d-86fc-268e5171cb30") },
                    { new Guid("66bb6b2d-1842-4456-b543-4ece86abff5d"), new Guid("35dfe5ef-82a7-418a-8724-71f5ba108805") },
                    { new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610"), new Guid("35dfe5ef-82a7-418a-8724-71f5ba108805") },
                    { new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50"), new Guid("35dfe5ef-82a7-418a-8724-71f5ba108805") },
                    { new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50"), new Guid("a4becdfb-e28c-484d-86fc-268e5171cb30") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("21e24349-b464-4a5c-8769-b5483dca18de"), new Guid("57106eb0-28a8-425b-ac3b-f6a18db32f4f"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("3c81647b-c961-4610-b7b6-0afe68cbcc1d"), new Guid("358cd0e4-b37b-4d4d-b686-312b25340a02"), false, false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("3ecf8f09-f631-4f8a-a253-7cebcede2841"), new Guid("57106eb0-28a8-425b-ac3b-f6a18db32f4f"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("4290dd6c-dda7-448f-a81b-23520c0f537e"), new Guid("5561bcf2-ba9e-4d96-bc5d-2ec98f6fd179"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("5c527445-b8db-40cd-afce-2d09a162b9fd"), new Guid("57106eb0-28a8-425b-ac3b-f6a18db32f4f"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("6a3b6c8b-8444-48c6-bf23-aa908deb8a57"), new Guid("57106eb0-28a8-425b-ac3b-f6a18db32f4f"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("72905683-dc41-40a5-9f5a-31bd7f886233"), new Guid("5561bcf2-ba9e-4d96-bc5d-2ec98f6fd179"), false, false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("8a3b5a87-1ecc-48f2-b5de-e2b85ed735c8"), new Guid("9ab5e9a9-6df6-4fee-93d0-aca1f11b0714"), true, true, "Краткая аннотация конкурсной работы", 14 },
                    { new Guid("cafabf11-5d3d-4993-a410-eb3a400659f0"), new Guid("5561bcf2-ba9e-4d96-bc5d-2ec98f6fd179"), true, true, "Персональные идентификаторы", 10 },
                    { new Guid("d3301d1f-b164-4a6e-9096-cf4ac233c52d"), new Guid("358cd0e4-b37b-4d4d-b686-312b25340a02"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("da96f661-bcac-4675-a4e8-026850997ce2"), new Guid("358cd0e4-b37b-4d4d-b686-312b25340a02"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("daf56fe3-0da6-4e61-a4b0-65fae73b0a94"), new Guid("358cd0e4-b37b-4d4d-b686-312b25340a02"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("f4c48e64-99c1-4c7b-b865-8296a92effe5"), new Guid("57106eb0-28a8-425b-ac3b-f6a18db32f4f"), false, false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("fda8662c-7296-416d-8fe5-ea6b072de866"), new Guid("57106eb0-28a8-425b-ac3b-f6a18db32f4f"), false, false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("03aa6739-2d0e-44d0-a0c6-42da7eba61ab"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("3ecf8f09-f631-4f8a-a253-7cebcede2841"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("055e4bbb-18ef-4970-8a24-67bef88a21f4"), true, "Название", 1, new Guid("8a3b5a87-1ecc-48f2-b5de-e2b85ed735c8"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("06f61383-f3e4-4f0f-a617-9c150ff48d8a"), true, "Наличие грифа", 5, new Guid("fda8662c-7296-416d-8fe5-ea6b072de866"), new Guid("3f41b224-f1f3-4974-9918-f1b1ae01bb7f") },
                    { new Guid("074b3d60-fad5-4dbd-bfc2-ec52c8206207"), true, "Ссылка", 5, new Guid("72905683-dc41-40a5-9f5a-31bd7f886233"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("0c6e1120-cf40-4eb8-96a1-147aa8b656ec"), true, "Название документа, реквизиты", 1, new Guid("4290dd6c-dda7-448f-a81b-23520c0f537e"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("10718df9-9212-4e7f-b42f-ff381ea25a00"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("21e24349-b464-4a5c-8769-b5483dca18de"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("12e0c50e-fc25-4742-a55e-e4b1233997c3"), true, "Год", 4, new Guid("6a3b6c8b-8444-48c6-bf23-aa908deb8a57"), new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("19792ed9-dcb1-4dd7-801a-ea95fe017ba4"), true, "Итого (час.)", 5, new Guid("21e24349-b464-4a5c-8769-b5483dca18de"), new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("2382b68b-256e-429d-ba42-83ce265b32ed"), true, "Ссылка на платформу", 3, new Guid("6a3b6c8b-8444-48c6-bf23-aa908deb8a57"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("2434659b-84b9-44fb-ae5c-1cad68b45298"), true, "Название конкурса", 2, new Guid("72905683-dc41-40a5-9f5a-31bd7f886233"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("26309fea-b73f-4dc2-8b42-03abe7038651"), false, "Идентификатор", 2, new Guid("cafabf11-5d3d-4993-a410-eb3a400659f0"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("2af68382-93d7-493a-86a8-ce235b478609"), true, "Название", 2, new Guid("da96f661-bcac-4675-a4e8-026850997ce2"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("2d9781ed-ab87-48c6-a987-24b642ff2455"), true, "Лекции (час.)", 3, new Guid("21e24349-b464-4a5c-8769-b5483dca18de"), new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("2ea85b16-14db-4d2d-b9f4-04529460fda8"), true, "Язык публикации", 7, new Guid("fda8662c-7296-416d-8fe5-ea6b072de866"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("3eea53b3-24d1-4f4e-b58e-5a46f765baf5"), true, "Вид деятельности (преподавательская)", 3, new Guid("f4c48e64-99c1-4c7b-b865-8296a92effe5"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("3f4cf052-602b-4c36-9042-ad2d19e44108"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("3c81647b-c961-4610-b7b6-0afe68cbcc1d"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("407de471-b115-4fc7-afcf-1eebbbc50ccc"), true, "Статус конкурса", 3, new Guid("72905683-dc41-40a5-9f5a-31bd7f886233"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("429d0495-3e9f-422e-8948-4c30ae30bf21"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("daf56fe3-0da6-4e61-a4b0-65fae73b0a94"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("450f5256-9c33-4918-8959-c60e94357438"), false, "Соавторы", 3, new Guid("fda8662c-7296-416d-8fe5-ea6b072de866"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("4eefd998-e860-4003-a7da-241175fb7050"), true, "Название курса", 1, new Guid("6a3b6c8b-8444-48c6-bf23-aa908deb8a57"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("51636793-9144-4c8a-879a-c47cafb55cf8"), true, "Период выполнения", 3, new Guid("daf56fe3-0da6-4e61-a4b0-65fae73b0a94"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("584b2242-bb7e-4a01-af0d-cc8337e36d91"), true, "Вид (лекции, лабораторные)", 2, new Guid("5c527445-b8db-40cd-afce-2d09a162b9fd"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("5ec6478e-69fa-4d04-8c9f-eed8f1adb7b7"), true, "Название конкурса/премии", 2, new Guid("3ecf8f09-f631-4f8a-a253-7cebcede2841"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("6294d2c9-0843-40cc-9f84-82ec07a7b5fb"), true, "Значение", 2, new Guid("8a3b5a87-1ecc-48f2-b5de-e2b85ed735c8"), new Guid("8e2c2417-6852-4aae-868f-bc2435dde3bd") },
                    { new Guid("63a7469c-c918-48be-a0e7-848017210e41"), true, "Название статьи", 1, new Guid("3c81647b-c961-4610-b7b6-0afe68cbcc1d"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("6426dfb1-2b0c-40e3-9a90-dac93a339287"), true, "ФИО соавторов", 3, new Guid("da96f661-bcac-4675-a4e8-026850997ce2"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("66542c9c-552c-4757-8227-080a1749fec3"), true, "Соавторы", 2, new Guid("3c81647b-c961-4610-b7b6-0afe68cbcc1d"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("6ed255c7-6b54-4ef3-9b5a-de2dba93303c"), true, "Соавторы", 2, new Guid("6a3b6c8b-8444-48c6-bf23-aa908deb8a57"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("7346fc39-102d-4b23-9ce8-4c6cee883fde"), true, "Название НИР/НИОКР", 1, new Guid("daf56fe3-0da6-4e61-a4b0-65fae73b0a94"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("81b78d95-74f1-4bcd-8193-ad36c79e58c2"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("5c527445-b8db-40cd-afce-2d09a162b9fd"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("8231bb93-4b85-4fc7-a273-d54bc12517d9"), true, "Ссылка на открытый доступ", 8, new Guid("fda8662c-7296-416d-8fe5-ea6b072de866"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("8c6b1e2d-01e7-4ecb-9f2a-55d4138b3d4e"), true, "ФИО", 1, new Guid("3ecf8f09-f631-4f8a-a253-7cebcede2841"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("8d02551b-9b6e-411e-b53b-9310fbe188ba"), true, "Вид", 1, new Guid("d3301d1f-b164-4a6e-9096-cf4ac233c52d"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("8d6e9774-97e6-43c8-84af-e71b4e42aeb3"), true, "Название", 2, new Guid("fda8662c-7296-416d-8fe5-ea6b072de866"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("917f13cf-6ad7-49dd-b475-e9ce2d6ea83e"), true, "Год", 3, new Guid("3ecf8f09-f631-4f8a-a253-7cebcede2841"), new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("9cab5080-c412-458c-84d8-2617596bbaf2"), false, "Тип идентификатора", 1, new Guid("cafabf11-5d3d-4993-a410-eb3a400659f0"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("a3552d49-e27a-49aa-bc8d-1a616fc3fd81"), true, "Награда", 4, new Guid("72905683-dc41-40a5-9f5a-31bd7f886233"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("a5ca8989-c34b-4ba4-944a-389f64b9dbad"), true, "Вид публикации", 1, new Guid("fda8662c-7296-416d-8fe5-ea6b072de866"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("abd5a7b5-c4d5-4130-a8f8-24067d0518a4"), true, "Издательство, год", 6, new Guid("fda8662c-7296-416d-8fe5-ea6b072de866"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("afed5fd8-b5cd-4541-a85c-fd80e4217238"), true, "Название разработки", 2, new Guid("d3301d1f-b164-4a6e-9096-cf4ac233c52d"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("b074fe3e-6eec-4a1d-b552-2640df2f15a4"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("f4c48e64-99c1-4c7b-b865-8296a92effe5"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("b101b42c-e7b7-4219-abd7-7e34d5900c40"), true, "Год", 1, new Guid("72905683-dc41-40a5-9f5a-31bd7f886233"), new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("c153963b-76bc-428e-8812-457cd01f1f17"), true, "Количество часов", 4, new Guid("f4c48e64-99c1-4c7b-b865-8296a92effe5"), new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("c1c87e5e-20aa-4e95-9ca2-c7b0b3a689eb"), true, "Статус (руководитель/исполнитель)", 4, new Guid("daf56fe3-0da6-4e61-a4b0-65fae73b0a94"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("c37d67eb-e47d-4467-b1c3-5ec3a5f55114"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("daf56fe3-0da6-4e61-a4b0-65fae73b0a94"), new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("c5a410e0-0cbc-4ec3-90f8-ce2cc8719955"), true, "Практические занятия (час.)", 4, new Guid("21e24349-b464-4a5c-8769-b5483dca18de"), new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("c93b34d8-c773-4bfd-a412-517dad90a56d"), true, "Вид", 1, new Guid("da96f661-bcac-4675-a4e8-026850997ce2"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("c9e40233-8aef-4ebe-bc59-33638f7d69d1"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("3ecf8f09-f631-4f8a-a253-7cebcede2841"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("cb3b2fca-221e-4e32-b5e0-f5440bb73dd1"), true, "Номер РИД", 4, new Guid("da96f661-bcac-4675-a4e8-026850997ce2"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("d22c0559-e2e5-4004-96b5-83da1bc09baf"), true, "Название дисциплины", 1, new Guid("5c527445-b8db-40cd-afce-2d09a162b9fd"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("d734fc73-d621-4127-a6b3-1c5a7bda30e5"), true, "Наименование курса", 1, new Guid("21e24349-b464-4a5c-8769-b5483dca18de"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("dd3b9098-3b79-4a35-88b9-3a5d704733f6"), true, "Издание, год", 4, new Guid("3c81647b-c961-4610-b7b6-0afe68cbcc1d"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("ea630bec-7958-406a-be0c-b2184521fc8d"), true, "Название организации в которую внедрена разработка", 3, new Guid("d3301d1f-b164-4a6e-9096-cf4ac233c52d"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("f1252f30-f609-4c76-b385-56f4db03751d"), true, "Год получения документа", 2, new Guid("4290dd6c-dda7-448f-a81b-23520c0f537e"), new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") },
                    { new Guid("fc8f093e-9b1b-432c-9977-e1345a9ea691"), true, "Название организации/должность/ставка", 1, new Guid("f4c48e64-99c1-4c7b-b865-8296a92effe5"), new Guid("80481c6d-8ba4-4c78-82e9-3885e0821974") },
                    { new Guid("fcefe5db-b0da-4c8b-b045-ef7cc311b904"), true, "Количество печатных листов", 4, new Guid("fda8662c-7296-416d-8fe5-ea6b072de866"), new Guid("48dc1a17-68d8-41e0-9273-39b43318710b") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("074df861-a9cd-41fd-a164-5533df0aaa0a"), new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97") },
                    { new Guid("336e9356-f0f1-4e7b-b7ed-af24077b1363"), new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50") },
                    { new Guid("37c5bafe-13d7-402d-ad75-e608d8b04fe7"), new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610") },
                    { new Guid("47732a36-9141-42e1-b25e-996798b5f347"), new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50") },
                    { new Guid("4e730b60-1742-45d0-8c45-f48214b99366"), new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50") },
                    { new Guid("508fe299-5354-49cb-b745-a898be9fa040"), new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50") },
                    { new Guid("537065c7-27d4-4bde-908e-23f428f560a4"), new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50") },
                    { new Guid("6adc8d97-ad3d-430d-a3f2-e94e45cc5895"), new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50") },
                    { new Guid("6bdbbe3a-325b-4ea9-a66c-c545fa063b77"), new Guid("0fd2fa3a-e9cb-4164-8820-6d7cb5cc8a1b") },
                    { new Guid("6bdbbe3a-325b-4ea9-a66c-c545fa063b77"), new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610") },
                    { new Guid("6bdbbe3a-325b-4ea9-a66c-c545fa063b77"), new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50") },
                    { new Guid("6fb39dd0-63c0-4a74-bb06-28b2805d816e"), new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50") },
                    { new Guid("74862a25-aff3-420e-a728-819d6f4105d7"), new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97") },
                    { new Guid("78c1ac8f-07c5-46d8-b122-f6c103e9c513"), new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610") },
                    { new Guid("7a592818-f3cd-47e6-9aad-9fb3686f7fd1"), new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97") },
                    { new Guid("80bbfa9d-c374-4e27-b9f8-449c9a10c18b"), new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50") },
                    { new Guid("8162a2db-0dcb-48ef-91cd-44a06c48ff10"), new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50") },
                    { new Guid("a66f660c-fd15-4819-9b4a-569645152dfa"), new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50") },
                    { new Guid("ba8943b9-9f29-4cbc-a623-d9f94f5982b8"), new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50") },
                    { new Guid("cac36c3b-9293-400f-af39-8500237408f1"), new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50") },
                    { new Guid("e3e87448-b8f6-45cf-860d-919b22adfca6"), new Guid("fe9e3510-c049-4e21-a261-6a0fe2849b50") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("0e304fda-a8f9-4b6e-91d7-1002062cf9ef"), new Guid("5c527445-b8db-40cd-afce-2d09a162b9fd") },
                    { new Guid("0e304fda-a8f9-4b6e-91d7-1002062cf9ef"), new Guid("fda8662c-7296-416d-8fe5-ea6b072de866") },
                    { new Guid("0fd2fa3a-e9cb-4164-8820-6d7cb5cc8a1b"), new Guid("4290dd6c-dda7-448f-a81b-23520c0f537e") },
                    { new Guid("0fd2fa3a-e9cb-4164-8820-6d7cb5cc8a1b"), new Guid("72905683-dc41-40a5-9f5a-31bd7f886233") },
                    { new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97"), new Guid("21e24349-b464-4a5c-8769-b5483dca18de") },
                    { new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97"), new Guid("3ecf8f09-f631-4f8a-a253-7cebcede2841") },
                    { new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97"), new Guid("6a3b6c8b-8444-48c6-bf23-aa908deb8a57") },
                    { new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97"), new Guid("f4c48e64-99c1-4c7b-b865-8296a92effe5") },
                    { new Guid("56ceacab-2883-4fc3-956e-7f673ac44cd0"), new Guid("8a3b5a87-1ecc-48f2-b5de-e2b85ed735c8") },
                    { new Guid("66bb6b2d-1842-4456-b543-4ece86abff5d"), new Guid("4290dd6c-dda7-448f-a81b-23520c0f537e") },
                    { new Guid("66bb6b2d-1842-4456-b543-4ece86abff5d"), new Guid("d3301d1f-b164-4a6e-9096-cf4ac233c52d") },
                    { new Guid("66bb6b2d-1842-4456-b543-4ece86abff5d"), new Guid("da96f661-bcac-4675-a4e8-026850997ce2") },
                    { new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610"), new Guid("3c81647b-c961-4610-b7b6-0afe68cbcc1d") },
                    { new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610"), new Guid("72905683-dc41-40a5-9f5a-31bd7f886233") },
                    { new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610"), new Guid("cafabf11-5d3d-4993-a410-eb3a400659f0") },
                    { new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610"), new Guid("daf56fe3-0da6-4e61-a4b0-65fae73b0a94") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("01bbf21e-3ccc-4929-95b9-ca04dfd08935"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("d3301d1f-b164-4a6e-9096-cf4ac233c52d") },
                    { new Guid("0272b968-e658-4e61-b1f0-78e5f9dd24cd"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("6a3b6c8b-8444-48c6-bf23-aa908deb8a57") },
                    { new Guid("0345ae82-893e-432c-a4d2-f0388ba59fc0"), "EvaluateMark20", new Guid("78c1ac8f-07c5-46d8-b122-f6c103e9c513"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("0802f9d8-2837-46d4-a1f4-995328efb84b"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("fda8662c-7296-416d-8fe5-ea6b072de866") },
                    { new Guid("1421fe0b-e97c-49c5-ba11-1d6757bd90bb"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("72905683-dc41-40a5-9f5a-31bd7f886233") },
                    { new Guid("1749c00f-3f36-4a70-8d6b-f36e7619a0af"), "EvaluateMark13", new Guid("6bdbbe3a-325b-4ea9-a66c-c545fa063b77"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("1c20cda1-5b28-4bc4-a23c-2521acb6d74a"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("21e24349-b464-4a5c-8769-b5483dca18de") },
                    { new Guid("1fd8d5f1-ed52-49de-be43-18c33cb9b387"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("daf56fe3-0da6-4e61-a4b0-65fae73b0a94") },
                    { new Guid("2594c842-261a-4150-9b6f-0eae9c7ae9be"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("fda8662c-7296-416d-8fe5-ea6b072de866") },
                    { new Guid("25df9158-d365-4f57-b5a8-cfeb561baf9a"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("5c527445-b8db-40cd-afce-2d09a162b9fd") },
                    { new Guid("2d88a35c-eaba-4dcd-af08-324c71685fdd"), "EvaluateMark19", new Guid("37c5bafe-13d7-402d-ad75-e608d8b04fe7"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("3bf95287-7f14-45a6-a010-037753bc7bf5"), null, null, false, 10, "Оценка уровня предоставленной работы:", 25, new Guid("8a3b5a87-1ecc-48f2-b5de-e2b85ed735c8") },
                    { new Guid("3e57b08c-d369-4328-bbe6-d5f0e7bbced6"), "EvaluateMark5", new Guid("7a592818-f3cd-47e6-9aad-9fb3686f7fd1"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("60324c92-a384-44cc-bf63-1e9db345aa26"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("21e24349-b464-4a5c-8769-b5483dca18de") },
                    { new Guid("7b250abe-5148-4669-88e5-816ba53eab94"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("3c81647b-c961-4610-b7b6-0afe68cbcc1d") },
                    { new Guid("7e5e75c0-45e0-4e4d-8436-2c7d63dacfba"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("da96f661-bcac-4675-a4e8-026850997ce2") },
                    { new Guid("867d5007-422b-4f71-a5aa-340c1b87377e"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("4290dd6c-dda7-448f-a81b-23520c0f537e") },
                    { new Guid("8efca974-729e-4481-9e2a-86ef50175540"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("fda8662c-7296-416d-8fe5-ea6b072de866") },
                    { new Guid("94c639f7-3673-4feb-9aa5-572fc11be281"), "EvaluateMark3", new Guid("74862a25-aff3-420e-a728-819d6f4105d7"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("97b2b8c1-362b-4d8a-861b-67803988b51a"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("daf56fe3-0da6-4e61-a4b0-65fae73b0a94") },
                    { new Guid("bffbb198-9509-43e4-96b5-a69213e59834"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("3ecf8f09-f631-4f8a-a253-7cebcede2841") },
                    { new Guid("ddcbe07c-4623-40f5-aaeb-84d36fec4a9e"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("fda8662c-7296-416d-8fe5-ea6b072de866") },
                    { new Guid("f6d59b23-c41e-4507-b2c0-0ac9f41791a1"), "EvaluateMark4", new Guid("074df861-a9cd-41fd-a164-5533df0aaa0a"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("fae828ea-79d9-422d-81ae-a9b6560d6bfc"), null, null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("8a3b5a87-1ecc-48f2-b5de-e2b85ed735c8") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("150ca833-3135-45ba-bed8-41031d45b0a2"), true, new Guid("cafabf11-5d3d-4993-a410-eb3a400659f0") },
                    { new Guid("2a26168c-d7d8-4ca4-a7f9-f6ed3477dd73"), true, new Guid("8a3b5a87-1ecc-48f2-b5de-e2b85ed735c8") },
                    { new Guid("373bc101-f394-4f92-916e-35058d2cbfe9"), true, new Guid("cafabf11-5d3d-4993-a410-eb3a400659f0") },
                    { new Guid("60c5f960-76eb-474e-98a4-49189c59f75b"), true, new Guid("8a3b5a87-1ecc-48f2-b5de-e2b85ed735c8") },
                    { new Guid("8b6a09b3-922d-4178-a95e-603f3d8068d2"), true, new Guid("8a3b5a87-1ecc-48f2-b5de-e2b85ed735c8") },
                    { new Guid("9412f364-aaa0-4a76-9265-29059f80a62d"), true, new Guid("8a3b5a87-1ecc-48f2-b5de-e2b85ed735c8") },
                    { new Guid("b8095343-64d7-4123-b60c-f4295c2fbbbc"), true, new Guid("8a3b5a87-1ecc-48f2-b5de-e2b85ed735c8") },
                    { new Guid("c0d3e6f6-36a5-4bbd-be30-1e14205ca885"), true, new Guid("cafabf11-5d3d-4993-a410-eb3a400659f0") },
                    { new Guid("c4f0099b-b722-4c41-a75c-5137014d74ec"), true, new Guid("cafabf11-5d3d-4993-a410-eb3a400659f0") },
                    { new Guid("d18f9d9b-9ac7-450e-88e9-d7df5306656d"), true, new Guid("cafabf11-5d3d-4993-a410-eb3a400659f0") },
                    { new Guid("dc018d05-76c6-4f38-8d80-1accbb432e91"), true, new Guid("8a3b5a87-1ecc-48f2-b5de-e2b85ed735c8") },
                    { new Guid("deb09daa-2723-42df-87f7-6acb8e3e397b"), true, new Guid("8a3b5a87-1ecc-48f2-b5de-e2b85ed735c8") },
                    { new Guid("df9affe9-6fa9-438d-ba2c-0cb5fc635a51"), true, new Guid("8a3b5a87-1ecc-48f2-b5de-e2b85ed735c8") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("05f2eda3-7bda-49b7-b756-83958836a266"), null, new Guid("e3e87448-b8f6-45cf-860d-919b22adfca6"), "Доктор наук" },
                    { new Guid("1021c6de-fb7e-47aa-b953-a7cf51121746"), null, new Guid("8162a2db-0dcb-48ef-91cd-44a06c48ff10"), "Имеющие ученую степень доктора наук" },
                    { new Guid("7690410e-f53f-48e3-999e-ccba7f5c8e36"), null, new Guid("6bdbbe3a-325b-4ea9-a66c-c545fa063b77"), "Доцент" },
                    { new Guid("7c484fc9-d76e-4141-9033-895893fa26b5"), null, new Guid("e3e87448-b8f6-45cf-860d-919b22adfca6"), "Кандидат наук" },
                    { new Guid("96b51ffe-fc78-40ef-8a7f-c85c37dc7ae3"), null, new Guid("6bdbbe3a-325b-4ea9-a66c-c545fa063b77"), "Нет" },
                    { new Guid("a6d07739-7dcc-4549-95c8-efc2fc19a903"), null, new Guid("8162a2db-0dcb-48ef-91cd-44a06c48ff10"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("f68a7fdb-3392-4385-bd75-d6b1df28f6c2"), null, new Guid("6bdbbe3a-325b-4ea9-a66c-c545fa063b77"), "Профессор" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("18a9bafb-29cb-4e72-a25c-8f8e9f2f2584"), null, new Guid("26309fea-b73f-4dc2-8b42-03abe7038651"), false, true, new Guid("150ca833-3135-45ba-bed8-41031d45b0a2"), null },
                    { new Guid("1b8c83af-a447-42b6-aa20-217adef67f5c"), null, new Guid("9cab5080-c412-458c-84d8-2617596bbaf2"), true, true, new Guid("150ca833-3135-45ba-bed8-41031d45b0a2"), "РИНЦ AuthorID" },
                    { new Guid("27692865-a6c0-4b27-bbf1-233cdd558a7d"), null, new Guid("055e4bbb-18ef-4970-8a24-67bef88a21f4"), true, true, new Guid("deb09daa-2723-42df-87f7-6acb8e3e397b"), "Инновационность" },
                    { new Guid("2ae45eaf-9664-4210-a42f-65b842c40794"), null, new Guid("6294d2c9-0843-40cc-9f84-82ec07a7b5fb"), false, true, new Guid("deb09daa-2723-42df-87f7-6acb8e3e397b"), null },
                    { new Guid("2eab2bf9-f304-4a5d-ae31-b988e7c43433"), null, new Guid("9cab5080-c412-458c-84d8-2617596bbaf2"), true, true, new Guid("d18f9d9b-9ac7-450e-88e9-d7df5306656d"), "Google Scholar ID" },
                    { new Guid("3d835654-b3fc-45f4-884b-f3e9f32c11f5"), null, new Guid("055e4bbb-18ef-4970-8a24-67bef88a21f4"), true, true, new Guid("2a26168c-d7d8-4ca4-a7f9-f6ed3477dd73"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("534ec84f-4c63-41ca-b38f-7adbd3b087d9"), null, new Guid("055e4bbb-18ef-4970-8a24-67bef88a21f4"), true, true, new Guid("8b6a09b3-922d-4178-a95e-603f3d8068d2"), "Название работы" },
                    { new Guid("577bb7c4-2b8b-4e0c-957b-d58443004f31"), null, new Guid("9cab5080-c412-458c-84d8-2617596bbaf2"), true, true, new Guid("373bc101-f394-4f92-916e-35058d2cbfe9"), "ORCiD" },
                    { new Guid("5eb11ee1-ad73-41af-9e46-639aec8b3781"), null, new Guid("6294d2c9-0843-40cc-9f84-82ec07a7b5fb"), false, true, new Guid("60c5f960-76eb-474e-98a4-49189c59f75b"), null },
                    { new Guid("61374143-7485-4408-8c29-6911c04dde7a"), null, new Guid("6294d2c9-0843-40cc-9f84-82ec07a7b5fb"), false, true, new Guid("dc018d05-76c6-4f38-8d80-1accbb432e91"), null },
                    { new Guid("720364d5-0e27-421d-b71c-a20b3645c2ac"), null, new Guid("6294d2c9-0843-40cc-9f84-82ec07a7b5fb"), false, true, new Guid("8b6a09b3-922d-4178-a95e-603f3d8068d2"), null },
                    { new Guid("73fff3d5-080b-44dd-907a-55f2f10228fb"), null, new Guid("6294d2c9-0843-40cc-9f84-82ec07a7b5fb"), false, true, new Guid("b8095343-64d7-4123-b60c-f4295c2fbbbc"), null },
                    { new Guid("7af8d2f9-1120-4627-a701-a1706eb09359"), null, new Guid("055e4bbb-18ef-4970-8a24-67bef88a21f4"), true, true, new Guid("b8095343-64d7-4123-b60c-f4295c2fbbbc"), "Методология и методы, используемые в работе" },
                    { new Guid("7b57b27d-8c74-4cf2-9627-fda359412df3"), null, new Guid("6294d2c9-0843-40cc-9f84-82ec07a7b5fb"), false, true, new Guid("2a26168c-d7d8-4ca4-a7f9-f6ed3477dd73"), null },
                    { new Guid("8a6fcfd7-bc04-42b9-95a9-8aa12a43c8a9"), null, new Guid("26309fea-b73f-4dc2-8b42-03abe7038651"), false, true, new Guid("373bc101-f394-4f92-916e-35058d2cbfe9"), null },
                    { new Guid("8aaa41c7-e0dc-4ddd-a96e-1a63d0681eb3"), null, new Guid("055e4bbb-18ef-4970-8a24-67bef88a21f4"), true, true, new Guid("9412f364-aaa0-4a76-9265-29059f80a62d"), "Результаты и выводы" },
                    { new Guid("8d2e763f-49d7-42d7-a73f-479326662883"), null, new Guid("055e4bbb-18ef-4970-8a24-67bef88a21f4"), true, true, new Guid("dc018d05-76c6-4f38-8d80-1accbb432e91"), "Актуальность конкурсной работы" },
                    { new Guid("90d65b5b-5ddc-4774-bc7a-694e06e5fda1"), null, new Guid("055e4bbb-18ef-4970-8a24-67bef88a21f4"), true, true, new Guid("df9affe9-6fa9-438d-ba2c-0cb5fc635a51"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("96af8c42-9964-424e-be94-e112440bc5e7"), null, new Guid("26309fea-b73f-4dc2-8b42-03abe7038651"), false, true, new Guid("c0d3e6f6-36a5-4bbd-be30-1e14205ca885"), null },
                    { new Guid("aa6e34d6-4dad-423a-8ce6-d966621d61b4"), null, new Guid("9cab5080-c412-458c-84d8-2617596bbaf2"), true, true, new Guid("c4f0099b-b722-4c41-a75c-5137014d74ec"), "ScopusID" },
                    { new Guid("b72abb30-5e4d-4cd1-95d6-eb9bb899aa4e"), null, new Guid("9cab5080-c412-458c-84d8-2617596bbaf2"), true, true, new Guid("c0d3e6f6-36a5-4bbd-be30-1e14205ca885"), "ResearcherID" },
                    { new Guid("b81d7c03-3b89-4d9d-94d4-4305e8fac0bc"), null, new Guid("6294d2c9-0843-40cc-9f84-82ec07a7b5fb"), false, true, new Guid("9412f364-aaa0-4a76-9265-29059f80a62d"), null },
                    { new Guid("c7072641-52b1-4590-b517-21e9c184ad4f"), null, new Guid("26309fea-b73f-4dc2-8b42-03abe7038651"), false, true, new Guid("c4f0099b-b722-4c41-a75c-5137014d74ec"), null },
                    { new Guid("cc645f74-a2cf-41dc-bf59-04afc957e990"), null, new Guid("6294d2c9-0843-40cc-9f84-82ec07a7b5fb"), false, true, new Guid("df9affe9-6fa9-438d-ba2c-0cb5fc635a51"), null },
                    { new Guid("dd3f684f-a63c-4f93-a901-a663f942ee08"), null, new Guid("26309fea-b73f-4dc2-8b42-03abe7038651"), false, true, new Guid("d18f9d9b-9ac7-450e-88e9-d7df5306656d"), null },
                    { new Guid("f9d3459c-b179-42d9-9140-f3d5af9c2d4a"), null, new Guid("055e4bbb-18ef-4970-8a24-67bef88a21f4"), true, true, new Guid("60c5f960-76eb-474e-98a4-49189c59f75b"), "Ссылка на конкурсную работу" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("0e304fda-a8f9-4b6e-91d7-1002062cf9ef"), new Guid("0802f9d8-2837-46d4-a1f4-995328efb84b") },
                    { new Guid("0e304fda-a8f9-4b6e-91d7-1002062cf9ef"), new Guid("2594c842-261a-4150-9b6f-0eae9c7ae9be") },
                    { new Guid("0e304fda-a8f9-4b6e-91d7-1002062cf9ef"), new Guid("25df9158-d365-4f57-b5a8-cfeb561baf9a") },
                    { new Guid("0e304fda-a8f9-4b6e-91d7-1002062cf9ef"), new Guid("8efca974-729e-4481-9e2a-86ef50175540") },
                    { new Guid("0e304fda-a8f9-4b6e-91d7-1002062cf9ef"), new Guid("ddcbe07c-4623-40f5-aaeb-84d36fec4a9e") },
                    { new Guid("0fd2fa3a-e9cb-4164-8820-6d7cb5cc8a1b"), new Guid("1421fe0b-e97c-49c5-ba11-1d6757bd90bb") },
                    { new Guid("0fd2fa3a-e9cb-4164-8820-6d7cb5cc8a1b"), new Guid("1749c00f-3f36-4a70-8d6b-f36e7619a0af") },
                    { new Guid("0fd2fa3a-e9cb-4164-8820-6d7cb5cc8a1b"), new Guid("867d5007-422b-4f71-a5aa-340c1b87377e") },
                    { new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97"), new Guid("0272b968-e658-4e61-b1f0-78e5f9dd24cd") },
                    { new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97"), new Guid("1c20cda1-5b28-4bc4-a23c-2521acb6d74a") },
                    { new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97"), new Guid("3e57b08c-d369-4328-bbe6-d5f0e7bbced6") },
                    { new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97"), new Guid("60324c92-a384-44cc-bf63-1e9db345aa26") },
                    { new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97"), new Guid("94c639f7-3673-4feb-9aa5-572fc11be281") },
                    { new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97"), new Guid("bffbb198-9509-43e4-96b5-a69213e59834") },
                    { new Guid("3c3a9fb0-92e4-4456-8b3e-be81c2556d97"), new Guid("f6d59b23-c41e-4507-b2c0-0ac9f41791a1") },
                    { new Guid("56ceacab-2883-4fc3-956e-7f673ac44cd0"), new Guid("3bf95287-7f14-45a6-a010-037753bc7bf5") },
                    { new Guid("56ceacab-2883-4fc3-956e-7f673ac44cd0"), new Guid("fae828ea-79d9-422d-81ae-a9b6560d6bfc") },
                    { new Guid("66bb6b2d-1842-4456-b543-4ece86abff5d"), new Guid("01bbf21e-3ccc-4929-95b9-ca04dfd08935") },
                    { new Guid("66bb6b2d-1842-4456-b543-4ece86abff5d"), new Guid("7e5e75c0-45e0-4e4d-8436-2c7d63dacfba") },
                    { new Guid("66bb6b2d-1842-4456-b543-4ece86abff5d"), new Guid("867d5007-422b-4f71-a5aa-340c1b87377e") },
                    { new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610"), new Guid("0345ae82-893e-432c-a4d2-f0388ba59fc0") },
                    { new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610"), new Guid("1421fe0b-e97c-49c5-ba11-1d6757bd90bb") },
                    { new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610"), new Guid("1749c00f-3f36-4a70-8d6b-f36e7619a0af") },
                    { new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610"), new Guid("1fd8d5f1-ed52-49de-be43-18c33cb9b387") },
                    { new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610"), new Guid("2d88a35c-eaba-4dcd-af08-324c71685fdd") },
                    { new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610"), new Guid("7b250abe-5148-4669-88e5-816ba53eab94") },
                    { new Guid("9bf9c4b9-9519-41c1-8c44-9c9cfdd1b610"), new Guid("97b2b8c1-362b-4d8a-861b-67803988b51a") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("1d1616cb-5f2f-4a49-9e02-ec2c604b3b8f"), new Guid("c93b34d8-c773-4bfd-a412-517dad90a56d"), null, "Полезная модель" },
                    { new Guid("485af0f2-2394-4959-a933-a9c52ec7b4c1"), new Guid("2ea85b16-14db-4d2d-b9f4-04529460fda8"), null, "Иностранный" },
                    { new Guid("52c7cf3a-1614-430c-aa4a-f3f33a56d6ff"), new Guid("8d02551b-9b6e-411e-b53b-9310fbe188ba"), null, "База данных" },
                    { new Guid("53bf9861-064b-4741-8c33-cc1f13d8b521"), new Guid("450f5256-9c33-4918-8959-c60e94357438"), null, "Есть" },
                    { new Guid("5c3237cf-46ce-4476-a473-8594b16d59aa"), new Guid("2ea85b16-14db-4d2d-b9f4-04529460fda8"), null, "Русский" },
                    { new Guid("5f820427-5e26-4798-8848-bebd888f2289"), new Guid("c1c87e5e-20aa-4e95-9ca2-c7b0b3a689eb"), null, "Руководитель" },
                    { new Guid("5fc3c772-44d6-4944-a56c-678c43cc2bae"), new Guid("66542c9c-552c-4757-8227-080a1749fec3"), null, "Есть" },
                    { new Guid("5fe64cc9-db6c-4f08-a482-963bfb836e2e"), new Guid("a5ca8989-c34b-4ba4-944a-389f64b9dbad"), null, "Монография" },
                    { new Guid("6f8e2892-e9a4-4b77-b53d-4e53897ea086"), new Guid("66542c9c-552c-4757-8227-080a1749fec3"), null, "Нет" },
                    { new Guid("7a43fc2d-156f-4f67-bded-f24fbe92107c"), new Guid("450f5256-9c33-4918-8959-c60e94357438"), null, "Нет" },
                    { new Guid("851bc4dd-46b6-46a3-80cd-132d73a93206"), new Guid("407de471-b115-4fc7-afcf-1eebbbc50ccc"), null, "Международный" },
                    { new Guid("936b040f-985e-4164-953b-96a8ef0078ef"), new Guid("584b2242-bb7e-4a01-af0d-cc8337e36d91"), null, "Лекции" },
                    { new Guid("9b7be950-b393-4730-9a6d-eba518f9a9b0"), new Guid("a5ca8989-c34b-4ba4-944a-389f64b9dbad"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("a36a303b-3d5e-4ba9-b86e-80ac697dbabd"), new Guid("8d02551b-9b6e-411e-b53b-9310fbe188ba"), null, "Изобретение" },
                    { new Guid("acb0c902-87f1-4db4-bdb3-d944321ada0c"), new Guid("407de471-b115-4fc7-afcf-1eebbbc50ccc"), null, "Региональный" },
                    { new Guid("b04423fb-0553-4485-860d-cf3ac1a044ae"), new Guid("c1c87e5e-20aa-4e95-9ca2-c7b0b3a689eb"), null, "Исполнитель" },
                    { new Guid("bb87a063-dd57-43d2-8a0f-795b6bd17ef2"), new Guid("c93b34d8-c773-4bfd-a412-517dad90a56d"), null, "Изобретение" },
                    { new Guid("bfe4ab52-90da-40f6-9532-0f8870a7254a"), new Guid("407de471-b115-4fc7-afcf-1eebbbc50ccc"), null, "Всероссийский" },
                    { new Guid("d3b7042e-08db-4d21-b029-02fbb96f801f"), new Guid("584b2242-bb7e-4a01-af0d-cc8337e36d91"), null, "Лабораторные" },
                    { new Guid("df11c7c2-507c-4f41-b448-9c19785f74ff"), new Guid("a5ca8989-c34b-4ba4-944a-389f64b9dbad"), null, "Учебник" },
                    { new Guid("f4b6f581-6c9b-4a2a-84d1-2e399271302d"), new Guid("8d02551b-9b6e-411e-b53b-9310fbe188ba"), null, "Полезная модель" },
                    { new Guid("f5074f24-dad1-45a4-bdbe-f65e78435928"), new Guid("c93b34d8-c773-4bfd-a412-517dad90a56d"), null, "База данных" }
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
                name: "IX_Feedbacks_ApplicationFormId",
                table: "Feedbacks",
                column: "ApplicationFormId");

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
