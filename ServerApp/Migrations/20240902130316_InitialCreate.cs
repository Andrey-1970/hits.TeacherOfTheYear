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
                    { new Guid("17185ab5-9acd-49e5-86d7-8260e0c48d2b"), 3, "В процессе рассмотрения" },
                    { new Guid("3e10fe1a-4c2c-4d44-b84d-00b9699cfa4a"), 2, "В ожидании рассмотрения" },
                    { new Guid("bab2ad81-daee-4156-a14f-fb3b9161c472"), 6, "Оценена" },
                    { new Guid("ccf84b5e-1ad9-4307-934d-5280ddd2712a"), 4, "Одобрена" },
                    { new Guid("e0f02bf9-2665-488f-adbc-113487d99a8f"), 5, "Отклонена" },
                    { new Guid("e5fb6fb8-016a-4f5a-b50e-63640b52a551"), 1, "В ожидании заполнения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11c2d152-98e2-49a6-933f-f981460d5d17", null, "Admin", "ADMIN" },
                    { "15f1d388-79f0-4946-bf16-fb4cd4a42945", null, "Participant", "PARTICIPANT" },
                    { "1d4ce103-1a95-43a9-ac26-87d9f2d88766", null, "Organiser", "ORGANISER" },
                    { "8e92c8bd-4a42-4991-b59d-bf5edea872fe", null, "Expert", "EXPERT" },
                    { "a52ff235-a33c-4e1f-b62f-0b45bffb4c66", null, "Voter", "VOTER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("32fa5cc2-5e28-4c89-8b46-04ee71edec69"), "Строительство и архитектура", 1 },
                    { new Guid("f5551fde-b10b-47ad-aba7-a2fa21283d6f"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("092594ea-62a6-4f92-8069-6d92c2f91a8e"), "Категория участников", 2 },
                    { new Guid("43edbed2-d9fb-4adb-915f-d5f49c137c22"), "Профессиональное развитие", 3 },
                    { new Guid("5af76dba-4366-4c86-8bf2-a38deab48b2d"), "Деятельность", 4 },
                    { new Guid("8bde0a08-f6d3-40c2-a979-efe157ddaff6"), "Общая информация", 1 },
                    { new Guid("a2a1e1e6-5cd3-4d25-a96e-5c8bd0a3a3a0"), "Деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8"), "Образовательная деятельность", 2 },
                    { new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("290f58a2-89a0-48e1-8f34-30cda9d4a2bf"), "Профессиональные показатели", 4 },
                    { new Guid("52d232b4-195a-4693-92ac-8fa8bebaabf1"), "Инновационная и иная деятельность", 6 },
                    { new Guid("a934ac2c-8e0d-4bba-b187-62648068b9c6"), "Конкурсная работа", 7 },
                    { new Guid("b05620e6-f627-4a6a-a460-53141cad6715"), "Методическая деятельность", 3 },
                    { new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501"), "Основной", 1 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("3bef1d1a-1a39-46f2-82e2-d97733e8a4ae"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("c99a9a0b-26b3-4b49-8c41-cb0e28defa44"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("58aa34ad-a21b-45b5-8526-42967f21b180"), "string" },
                    { new Guid("84d9ebd7-f8ab-48d2-a82e-a05834b0f17a"), "bool" },
                    { new Guid("c6f6f3b4-0295-40ce-b03f-c2aa08dd27e9"), "DateTime" },
                    { new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac"), "int" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("092594ea-62a6-4f92-8069-6d92c2f91a8e"), new Guid("3bef1d1a-1a39-46f2-82e2-d97733e8a4ae") },
                    { new Guid("092594ea-62a6-4f92-8069-6d92c2f91a8e"), new Guid("c99a9a0b-26b3-4b49-8c41-cb0e28defa44") },
                    { new Guid("43edbed2-d9fb-4adb-915f-d5f49c137c22"), new Guid("3bef1d1a-1a39-46f2-82e2-d97733e8a4ae") },
                    { new Guid("43edbed2-d9fb-4adb-915f-d5f49c137c22"), new Guid("c99a9a0b-26b3-4b49-8c41-cb0e28defa44") },
                    { new Guid("5af76dba-4366-4c86-8bf2-a38deab48b2d"), new Guid("3bef1d1a-1a39-46f2-82e2-d97733e8a4ae") },
                    { new Guid("8bde0a08-f6d3-40c2-a979-efe157ddaff6"), new Guid("3bef1d1a-1a39-46f2-82e2-d97733e8a4ae") },
                    { new Guid("8bde0a08-f6d3-40c2-a979-efe157ddaff6"), new Guid("c99a9a0b-26b3-4b49-8c41-cb0e28defa44") },
                    { new Guid("a2a1e1e6-5cd3-4d25-a96e-5c8bd0a3a3a0"), new Guid("c99a9a0b-26b3-4b49-8c41-cb0e28defa44") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("02ae900d-d6f2-4d71-8285-f397f11534d6"), new Guid("092594ea-62a6-4f92-8069-6d92c2f91a8e"), null, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("030c9f98-12b1-4d74-82ef-fe11f825e38c"), new Guid("8bde0a08-f6d3-40c2-a979-efe157ddaff6"), null, true, "Дата рождения", 2, "01.01.2000", new Guid("c6f6f3b4-0295-40ce-b03f-c2aa08dd27e9") },
                    { new Guid("0e120b49-b789-4b60-b096-d2fd4144bcd9"), new Guid("8bde0a08-f6d3-40c2-a979-efe157ddaff6"), null, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("23c56f38-7ecb-4735-b4e5-d9b6b2236705"), new Guid("8bde0a08-f6d3-40c2-a979-efe157ddaff6"), null, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("336839d6-f398-4fdf-a7b1-11f331913174"), new Guid("092594ea-62a6-4f92-8069-6d92c2f91a8e"), null, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("33fcb784-e58b-4053-88e3-8b4b6700d23d"), new Guid("a2a1e1e6-5cd3-4d25-a96e-5c8bd0a3a3a0"), null, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("46898f69-c8c9-4a5b-a920-b841d452f0f1"), new Guid("8bde0a08-f6d3-40c2-a979-efe157ddaff6"), null, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("58d18847-572f-41e4-a872-5a90dd5bd442"), new Guid("8bde0a08-f6d3-40c2-a979-efe157ddaff6"), null, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("5a087acf-e189-45ce-a65a-8284cc003cdb"), new Guid("8bde0a08-f6d3-40c2-a979-efe157ddaff6"), null, true, "Должность", 9, "Введите свою должность в организации", new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("6511201a-a6aa-4b22-8627-c9c409d93554"), new Guid("5af76dba-4366-4c86-8bf2-a38deab48b2d"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("84d627a5-dcb4-4ba0-93b3-5a9491cf33a4"), new Guid("5af76dba-4366-4c86-8bf2-a38deab48b2d"), "Руководство дипломными проектами за предыдущий учебный год", true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("a3fc447e-c9b5-431b-ba7b-2c0e873ecdff"), new Guid("092594ea-62a6-4f92-8069-6d92c2f91a8e"), null, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("a7656168-a219-434c-8d64-4a6c70597cca"), new Guid("8bde0a08-f6d3-40c2-a979-efe157ddaff6"), null, true, "Место работы/учебы", 6, "Название организации", new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("b0cb787e-2532-42e9-a42f-c5df694450c6"), new Guid("8bde0a08-f6d3-40c2-a979-efe157ddaff6"), null, true, "Электронная почта", 5, "user@example.com", new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("b1f71f6d-a3c8-495e-adb2-8cd9d6b8c706"), new Guid("5af76dba-4366-4c86-8bf2-a38deab48b2d"), null, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("b9e6fb45-9feb-455a-adb4-c234e56b7508"), new Guid("a2a1e1e6-5cd3-4d25-a96e-5c8bd0a3a3a0"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("c61df780-7556-4320-89ba-389ab76e736d"), new Guid("092594ea-62a6-4f92-8069-6d92c2f91a8e"), null, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("d0168ad8-1cdf-4642-927a-99eb81b797f6"), new Guid("8bde0a08-f6d3-40c2-a979-efe157ddaff6"), null, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("e1b15397-ca74-4749-b6c3-633d84ca78a7"), new Guid("8bde0a08-f6d3-40c2-a979-efe157ddaff6"), null, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8"), new Guid("3bef1d1a-1a39-46f2-82e2-d97733e8a4ae") },
                    { new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3"), new Guid("c99a9a0b-26b3-4b49-8c41-cb0e28defa44") },
                    { new Guid("290f58a2-89a0-48e1-8f34-30cda9d4a2bf"), new Guid("3bef1d1a-1a39-46f2-82e2-d97733e8a4ae") },
                    { new Guid("52d232b4-195a-4693-92ac-8fa8bebaabf1"), new Guid("c99a9a0b-26b3-4b49-8c41-cb0e28defa44") },
                    { new Guid("a934ac2c-8e0d-4bba-b187-62648068b9c6"), new Guid("3bef1d1a-1a39-46f2-82e2-d97733e8a4ae") },
                    { new Guid("a934ac2c-8e0d-4bba-b187-62648068b9c6"), new Guid("c99a9a0b-26b3-4b49-8c41-cb0e28defa44") },
                    { new Guid("b05620e6-f627-4a6a-a460-53141cad6715"), new Guid("3bef1d1a-1a39-46f2-82e2-d97733e8a4ae") },
                    { new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501"), new Guid("3bef1d1a-1a39-46f2-82e2-d97733e8a4ae") },
                    { new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501"), new Guid("c99a9a0b-26b3-4b49-8c41-cb0e28defa44") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("27e2fb62-4c2b-4bd7-8874-3941be3caa92"), new Guid("a2a1e1e6-5cd3-4d25-a96e-5c8bd0a3a3a0"), false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("3f5a6dc8-da6e-453a-a33c-18844828a356"), new Guid("a2a1e1e6-5cd3-4d25-a96e-5c8bd0a3a3a0"), false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("4a9273cd-7fe9-4615-ac04-23634e6ccc53"), new Guid("5af76dba-4366-4c86-8bf2-a38deab48b2d"), false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("4fb20457-5e4c-42e3-80d9-2fc21915d507"), new Guid("43edbed2-d9fb-4adb-915f-d5f49c137c22"), false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("5378e1ed-9e71-4e2c-a991-262bc782432c"), new Guid("a2a1e1e6-5cd3-4d25-a96e-5c8bd0a3a3a0"), false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("5e020707-5c59-4e6e-b530-1fabacb58e22"), new Guid("a2a1e1e6-5cd3-4d25-a96e-5c8bd0a3a3a0"), false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("878746aa-d77c-4281-a445-b017b94b3207"), new Guid("43edbed2-d9fb-4adb-915f-d5f49c137c22"), false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("97419931-6d4f-487e-b950-906c4b825198"), new Guid("5af76dba-4366-4c86-8bf2-a38deab48b2d"), false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("9b6ea0b0-d9c5-4ff2-b075-81a7fb3a33fd"), new Guid("5af76dba-4366-4c86-8bf2-a38deab48b2d"), false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("9f09d9a1-155c-473d-a227-eed0915082e4"), new Guid("5af76dba-4366-4c86-8bf2-a38deab48b2d"), false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("b0cea84a-b2c0-4616-a06d-d4ea486bdd11"), new Guid("5af76dba-4366-4c86-8bf2-a38deab48b2d"), false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("df7004d5-c3d2-443f-953d-04e71f95988f"), new Guid("092594ea-62a6-4f92-8069-6d92c2f91a8e"), true, "Краткая аннотация конкурсной работы", 14 },
                    { new Guid("e75de341-80e5-4856-93b4-0549ddce1efa"), new Guid("a2a1e1e6-5cd3-4d25-a96e-5c8bd0a3a3a0"), true, "Персональные идентификаторы", 10 },
                    { new Guid("fac6ec62-47a5-4036-81c5-21241b4f2f6f"), new Guid("5af76dba-4366-4c86-8bf2-a38deab48b2d"), false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("02b7a28f-3f60-4e56-a8d9-3a13cb3545d3"), true, "Название", 2, new Guid("5378e1ed-9e71-4e2c-a991-262bc782432c"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("11050ef1-3019-49ee-9e4d-1a395f4a24bf"), true, "Значение", 2, new Guid("df7004d5-c3d2-443f-953d-04e71f95988f"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("143fe2b9-7d52-4aab-b39c-df74745b580c"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("4a9273cd-7fe9-4615-ac04-23634e6ccc53"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("15843e55-c529-4d91-8009-a661e04f1a11"), true, "Название конкурса/премии", 2, new Guid("9f09d9a1-155c-473d-a227-eed0915082e4"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("168c3e80-fd8a-46f6-99f0-271e91721946"), true, "Период выполнения", 3, new Guid("5e020707-5c59-4e6e-b530-1fabacb58e22"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("1728e9fb-14f3-4076-8a47-93f9cc6c3c88"), true, "Язык публикации", 7, new Guid("b0cea84a-b2c0-4616-a06d-d4ea486bdd11"), new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("183b8578-5c7d-4823-8ea9-d3ddb685b887"), true, "Наличие грифа", 5, new Guid("b0cea84a-b2c0-4616-a06d-d4ea486bdd11"), new Guid("84d9ebd7-f8ab-48d2-a82e-a05834b0f17a") },
                    { new Guid("18716938-6c25-497d-9370-d6930bcbcef4"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("9b6ea0b0-d9c5-4ff2-b075-81a7fb3a33fd"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("1e664d4a-85c2-4bb8-812a-0bbcc143204d"), true, "Ссылка на платформу", 3, new Guid("97419931-6d4f-487e-b950-906c4b825198"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("2c01ffc3-b377-49a6-ad0b-a6a0264f13be"), true, "Название разработки", 2, new Guid("27e2fb62-4c2b-4bd7-8874-3941be3caa92"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("2c7919ef-7ffd-4cba-b26d-1294a3d11af7"), false, "Соавторы", 3, new Guid("b0cea84a-b2c0-4616-a06d-d4ea486bdd11"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("341d5351-3cf1-4a3d-a889-9083129b8a81"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("9f09d9a1-155c-473d-a227-eed0915082e4"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("355f0aa2-5630-41eb-90e1-0cc2befb79a5"), true, "Издание, год", 4, new Guid("3f5a6dc8-da6e-453a-a33c-18844828a356"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("3927d712-8aa7-4a2e-bcd0-bee61068b216"), true, "Год", 4, new Guid("97419931-6d4f-487e-b950-906c4b825198"), new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("40990967-333e-43a8-b169-809a6d5cb24b"), true, "Вид (лекции, лабораторные)", 2, new Guid("4a9273cd-7fe9-4615-ac04-23634e6ccc53"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("48851390-eacc-48b7-a803-91521a2963df"), true, "Название", 1, new Guid("df7004d5-c3d2-443f-953d-04e71f95988f"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("4c0486b6-3eab-41ba-9512-9ee7dfe172bc"), false, "Тип идентификатора", 1, new Guid("e75de341-80e5-4856-93b4-0549ddce1efa"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("58783c08-f216-4f62-aff9-a37d9048817e"), true, "Итого (час.)", 5, new Guid("9b6ea0b0-d9c5-4ff2-b075-81a7fb3a33fd"), new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("5ae6df13-3686-4786-9a50-e023e60334df"), true, "Ссылка", 5, new Guid("4fb20457-5e4c-42e3-80d9-2fc21915d507"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("676c0509-7c38-4816-a8b9-d308b0004422"), true, "Наименование курса", 1, new Guid("9b6ea0b0-d9c5-4ff2-b075-81a7fb3a33fd"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("696a358d-bc4b-4010-8b78-adc01e24bde4"), true, "Издательство, год", 6, new Guid("b0cea84a-b2c0-4616-a06d-d4ea486bdd11"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("6e9a93cb-38ca-418f-aa2b-7807ad48f8c4"), true, "Название НИР/НИОКР", 1, new Guid("5e020707-5c59-4e6e-b530-1fabacb58e22"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("72cba75d-a31e-4914-b54a-684aed9abf99"), true, "Название курса", 1, new Guid("97419931-6d4f-487e-b950-906c4b825198"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("76d7b881-ba15-4aaa-b6cd-1ce499225599"), true, "Название конкурса", 2, new Guid("4fb20457-5e4c-42e3-80d9-2fc21915d507"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("7ed48cee-158c-42ac-83ed-fd28b99eeb50"), true, "Практические занятия (час.)", 4, new Guid("9b6ea0b0-d9c5-4ff2-b075-81a7fb3a33fd"), new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("805fe9d3-0824-4458-82b9-750dec8f0dfb"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("3f5a6dc8-da6e-453a-a33c-18844828a356"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("81df18b0-d505-424e-a8ac-5b40516b5634"), true, "Соавторы", 2, new Guid("97419931-6d4f-487e-b950-906c4b825198"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("830823e8-d2d0-40b7-9fb3-d889bd4f7c35"), true, "Количество часов", 4, new Guid("fac6ec62-47a5-4036-81c5-21241b4f2f6f"), new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("84caeb7e-83a6-434e-a977-b7994f7c22d2"), true, "Вид деятельности (преподавательская)", 3, new Guid("fac6ec62-47a5-4036-81c5-21241b4f2f6f"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("895d24b3-9615-4ece-a8ce-0cf1c3f28710"), true, "Год", 3, new Guid("9f09d9a1-155c-473d-a227-eed0915082e4"), new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("90767ca0-9eae-45bb-a9ea-19b9d1c26b48"), true, "Лекции (час.)", 3, new Guid("9b6ea0b0-d9c5-4ff2-b075-81a7fb3a33fd"), new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("957cd986-f961-41e9-afb0-a986ee66807f"), true, "Количество печатных листов", 4, new Guid("b0cea84a-b2c0-4616-a06d-d4ea486bdd11"), new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("98777da4-a7c5-4c29-8cf8-7f0f2cf5f5e9"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("9f09d9a1-155c-473d-a227-eed0915082e4"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("9a44893c-1c98-4e73-88b3-5b5a74ca4e0a"), true, "Название организации в которую внедрена разработка", 3, new Guid("27e2fb62-4c2b-4bd7-8874-3941be3caa92"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("9ac92682-3a52-4e68-8e4b-29840b729034"), true, "Вид", 1, new Guid("5378e1ed-9e71-4e2c-a991-262bc782432c"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("a2384b72-d100-41f5-843c-b4749fc4db89"), true, "Статус (руководитель/исполнитель)", 4, new Guid("5e020707-5c59-4e6e-b530-1fabacb58e22"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("a477c2e6-4026-4021-b862-2b1db06bba10"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("fac6ec62-47a5-4036-81c5-21241b4f2f6f"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("a663eed1-5e11-4df5-b2e6-ea67e2b0e468"), true, "ФИО", 1, new Guid("9f09d9a1-155c-473d-a227-eed0915082e4"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("ad04f5f2-b8ae-4dda-97fa-a806a9802798"), true, "Название", 2, new Guid("b0cea84a-b2c0-4616-a06d-d4ea486bdd11"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("af7b9e3d-4c5e-4d78-bdeb-d9eec0c795e3"), true, "Год получения документа", 2, new Guid("878746aa-d77c-4281-a445-b017b94b3207"), new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("b2280646-2d84-417c-8e7a-ca8b4eeab320"), true, "Награда", 4, new Guid("4fb20457-5e4c-42e3-80d9-2fc21915d507"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("b8285c94-0822-4548-874a-09807416f8d5"), true, "Название дисциплины", 1, new Guid("4a9273cd-7fe9-4615-ac04-23634e6ccc53"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("ba3a9f44-0d96-46d6-bcae-c390438d1c4a"), true, "Название статьи", 1, new Guid("3f5a6dc8-da6e-453a-a33c-18844828a356"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("c19a2813-4d0d-42ba-90c4-4be8efdc1dd1"), true, "Вид", 1, new Guid("27e2fb62-4c2b-4bd7-8874-3941be3caa92"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("c9a092cb-4dc2-4aca-bf2e-f8a4660ac41e"), true, "Название организации/должность/ставка", 1, new Guid("fac6ec62-47a5-4036-81c5-21241b4f2f6f"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("ccea463e-061b-42bc-9d76-8ca98974bd67"), false, "Идентификатор", 2, new Guid("e75de341-80e5-4856-93b4-0549ddce1efa"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("d3400f35-1c7a-4c4a-87fc-51023ab117cc"), true, "Название документа, реквизиты", 1, new Guid("878746aa-d77c-4281-a445-b017b94b3207"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("d9a5a40e-643a-49ea-acc9-0963ecbae28c"), true, "Соавторы", 2, new Guid("3f5a6dc8-da6e-453a-a33c-18844828a356"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("df175279-96ab-4948-9c2b-bcd3c55a3553"), true, "ФИО соавторов", 3, new Guid("5378e1ed-9e71-4e2c-a991-262bc782432c"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("e274c125-5817-4e7b-b366-cc5b80929d5c"), true, "Номер РИД", 4, new Guid("5378e1ed-9e71-4e2c-a991-262bc782432c"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("e3ef288c-2772-4414-b6a9-f7e71356b5d2"), true, "Вид публикации", 1, new Guid("b0cea84a-b2c0-4616-a06d-d4ea486bdd11"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("eb769b5a-7319-42dd-a745-f911d5c65c30"), true, "Год", 1, new Guid("4fb20457-5e4c-42e3-80d9-2fc21915d507"), new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("ecab153f-779c-4818-a3b6-e7053f5f9f28"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("5e020707-5c59-4e6e-b530-1fabacb58e22"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") },
                    { new Guid("f706385c-fb46-4506-ab97-347ba98c3917"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("5e020707-5c59-4e6e-b530-1fabacb58e22"), new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("fa28cbaf-0e14-4a26-bd82-001b41bd5230"), true, "Ссылка на открытый доступ", 8, new Guid("b0cea84a-b2c0-4616-a06d-d4ea486bdd11"), new Guid("d6ce1ce9-035c-426a-aeea-3e16f39ddbac") },
                    { new Guid("faf051ad-af68-423d-899b-74313b64ad2c"), true, "Статус конкурса", 3, new Guid("4fb20457-5e4c-42e3-80d9-2fc21915d507"), new Guid("58aa34ad-a21b-45b5-8526-42967f21b180") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("02ae900d-d6f2-4d71-8285-f397f11534d6"), new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501") },
                    { new Guid("030c9f98-12b1-4d74-82ef-fe11f825e38c"), new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501") },
                    { new Guid("0e120b49-b789-4b60-b096-d2fd4144bcd9"), new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501") },
                    { new Guid("23c56f38-7ecb-4735-b4e5-d9b6b2236705"), new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501") },
                    { new Guid("336839d6-f398-4fdf-a7b1-11f331913174"), new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3") },
                    { new Guid("336839d6-f398-4fdf-a7b1-11f331913174"), new Guid("290f58a2-89a0-48e1-8f34-30cda9d4a2bf") },
                    { new Guid("336839d6-f398-4fdf-a7b1-11f331913174"), new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501") },
                    { new Guid("33fcb784-e58b-4053-88e3-8b4b6700d23d"), new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3") },
                    { new Guid("46898f69-c8c9-4a5b-a920-b841d452f0f1"), new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501") },
                    { new Guid("58d18847-572f-41e4-a872-5a90dd5bd442"), new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501") },
                    { new Guid("5a087acf-e189-45ce-a65a-8284cc003cdb"), new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501") },
                    { new Guid("6511201a-a6aa-4b22-8627-c9c409d93554"), new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8") },
                    { new Guid("84d627a5-dcb4-4ba0-93b3-5a9491cf33a4"), new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8") },
                    { new Guid("a3fc447e-c9b5-431b-ba7b-2c0e873ecdff"), new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501") },
                    { new Guid("a7656168-a219-434c-8d64-4a6c70597cca"), new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501") },
                    { new Guid("b0cb787e-2532-42e9-a42f-c5df694450c6"), new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501") },
                    { new Guid("b1f71f6d-a3c8-495e-adb2-8cd9d6b8c706"), new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8") },
                    { new Guid("b9e6fb45-9feb-455a-adb4-c234e56b7508"), new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3") },
                    { new Guid("c61df780-7556-4320-89ba-389ab76e736d"), new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501") },
                    { new Guid("d0168ad8-1cdf-4642-927a-99eb81b797f6"), new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501") },
                    { new Guid("e1b15397-ca74-4749-b6c3-633d84ca78a7"), new Guid("d9fbfc81-4d42-43c6-848f-4e108524b501") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8"), new Guid("97419931-6d4f-487e-b950-906c4b825198") },
                    { new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8"), new Guid("9b6ea0b0-d9c5-4ff2-b075-81a7fb3a33fd") },
                    { new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8"), new Guid("9f09d9a1-155c-473d-a227-eed0915082e4") },
                    { new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8"), new Guid("fac6ec62-47a5-4036-81c5-21241b4f2f6f") },
                    { new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3"), new Guid("3f5a6dc8-da6e-453a-a33c-18844828a356") },
                    { new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3"), new Guid("4fb20457-5e4c-42e3-80d9-2fc21915d507") },
                    { new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3"), new Guid("5e020707-5c59-4e6e-b530-1fabacb58e22") },
                    { new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3"), new Guid("e75de341-80e5-4856-93b4-0549ddce1efa") },
                    { new Guid("290f58a2-89a0-48e1-8f34-30cda9d4a2bf"), new Guid("4fb20457-5e4c-42e3-80d9-2fc21915d507") },
                    { new Guid("290f58a2-89a0-48e1-8f34-30cda9d4a2bf"), new Guid("878746aa-d77c-4281-a445-b017b94b3207") },
                    { new Guid("52d232b4-195a-4693-92ac-8fa8bebaabf1"), new Guid("27e2fb62-4c2b-4bd7-8874-3941be3caa92") },
                    { new Guid("52d232b4-195a-4693-92ac-8fa8bebaabf1"), new Guid("5378e1ed-9e71-4e2c-a991-262bc782432c") },
                    { new Guid("52d232b4-195a-4693-92ac-8fa8bebaabf1"), new Guid("878746aa-d77c-4281-a445-b017b94b3207") },
                    { new Guid("a934ac2c-8e0d-4bba-b187-62648068b9c6"), new Guid("df7004d5-c3d2-443f-953d-04e71f95988f") },
                    { new Guid("b05620e6-f627-4a6a-a460-53141cad6715"), new Guid("4a9273cd-7fe9-4615-ac04-23634e6ccc53") },
                    { new Guid("b05620e6-f627-4a6a-a460-53141cad6715"), new Guid("b0cea84a-b2c0-4616-a06d-d4ea486bdd11") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("044ed106-cd18-43a5-b0b0-974f524fb26b"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("5e020707-5c59-4e6e-b530-1fabacb58e22") },
                    { new Guid("1578dad5-0aa0-4a83-8777-31fdd6699f51"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("b0cea84a-b2c0-4616-a06d-d4ea486bdd11") },
                    { new Guid("1e5b4974-d60e-4459-80a9-26d1275fd6e4"), "EvaluateMark13", new Guid("336839d6-f398-4fdf-a7b1-11f331913174"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("1f7a450d-6d0d-4f0e-884a-fbcd4d0369e9"), "EvaluateMark5", new Guid("b1f71f6d-a3c8-495e-adb2-8cd9d6b8c706"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("2670b0bc-2930-4973-bd2c-a8ff026e21c7"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("3f5a6dc8-da6e-453a-a33c-18844828a356") },
                    { new Guid("2fb1dad7-6eb3-4e08-b95c-daf8fde16fea"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("4a9273cd-7fe9-4615-ac04-23634e6ccc53") },
                    { new Guid("45914fa3-2783-4265-b2dc-a0bb75181069"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("9b6ea0b0-d9c5-4ff2-b075-81a7fb3a33fd") },
                    { new Guid("5864b6d8-e068-4b8a-817d-24e2bcd8d3c5"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("b0cea84a-b2c0-4616-a06d-d4ea486bdd11") },
                    { new Guid("58a80d0a-8c02-443c-bded-92c8c490c0ea"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("97419931-6d4f-487e-b950-906c4b825198") },
                    { new Guid("5c79c217-da59-4bec-a601-bcf85b283239"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("b0cea84a-b2c0-4616-a06d-d4ea486bdd11") },
                    { new Guid("885ed870-fb66-4296-936f-00e0d698fa15"), null, null, false, 10, "Оценка уровня предоставленной работы:", 25, new Guid("df7004d5-c3d2-443f-953d-04e71f95988f") },
                    { new Guid("893e57ac-b675-49c7-b738-b0ed56d2ca03"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("878746aa-d77c-4281-a445-b017b94b3207") },
                    { new Guid("8953ad90-a566-4d9a-a111-ff3425eabdb6"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("5e020707-5c59-4e6e-b530-1fabacb58e22") },
                    { new Guid("a633e0ed-bbce-4d08-908c-a56f6c6cfa04"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("9f09d9a1-155c-473d-a227-eed0915082e4") },
                    { new Guid("b1574528-2995-4d23-81cb-cc71fa3cc854"), "EvaluateMark20", new Guid("33fcb784-e58b-4053-88e3-8b4b6700d23d"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("b22bec11-bcba-436a-857d-3591a92b83be"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("27e2fb62-4c2b-4bd7-8874-3941be3caa92") },
                    { new Guid("b40c5928-3067-4cc3-a61a-e09d2d1a2e55"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("9b6ea0b0-d9c5-4ff2-b075-81a7fb3a33fd") },
                    { new Guid("b644c65e-a19c-4b5a-8751-a038f8d3f2e1"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("b0cea84a-b2c0-4616-a06d-d4ea486bdd11") },
                    { new Guid("b727a537-1637-4fd2-a83c-f11e06635be7"), "EvaluateMark19", new Guid("b9e6fb45-9feb-455a-adb4-c234e56b7508"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("e75a5fef-7034-4f7d-8a4b-835eedd0cddc"), null, null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("df7004d5-c3d2-443f-953d-04e71f95988f") },
                    { new Guid("e7ee71ac-d9b8-4c9d-b102-9096e7c3f7f8"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("5378e1ed-9e71-4e2c-a991-262bc782432c") },
                    { new Guid("f188fa84-f985-4133-903d-3584336903dc"), "EvaluateMark4", new Guid("6511201a-a6aa-4b22-8627-c9c409d93554"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("f2508164-bcdc-4c1a-98c0-8524905da673"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("4fb20457-5e4c-42e3-80d9-2fc21915d507") },
                    { new Guid("f81aa45b-9e0a-4234-8a79-579148f6ced1"), "EvaluateMark3", new Guid("84d627a5-dcb4-4ba0-93b3-5a9491cf33a4"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("05b49a8e-20e2-48c8-a07b-347d371c7290"), true, new Guid("df7004d5-c3d2-443f-953d-04e71f95988f") },
                    { new Guid("1c87f7f4-afae-479e-88b6-283fd30a90c2"), true, new Guid("e75de341-80e5-4856-93b4-0549ddce1efa") },
                    { new Guid("2c9b23bf-243d-47c9-9b93-554161437e35"), true, new Guid("df7004d5-c3d2-443f-953d-04e71f95988f") },
                    { new Guid("62ff05ee-7773-4699-a098-c0ae32edf922"), true, new Guid("df7004d5-c3d2-443f-953d-04e71f95988f") },
                    { new Guid("9baea2a8-05e9-4cef-99f2-52c70f8a94e1"), true, new Guid("df7004d5-c3d2-443f-953d-04e71f95988f") },
                    { new Guid("a2ef2d4a-a718-4015-b98e-29f488d114d3"), true, new Guid("df7004d5-c3d2-443f-953d-04e71f95988f") },
                    { new Guid("bf8f5298-5426-40cc-b3cb-ccf8558b1706"), true, new Guid("e75de341-80e5-4856-93b4-0549ddce1efa") },
                    { new Guid("d479c347-bcec-44ef-8b48-2d45f7c72f94"), true, new Guid("df7004d5-c3d2-443f-953d-04e71f95988f") },
                    { new Guid("e702b6d1-33c0-4c92-8509-a8c49f547384"), true, new Guid("e75de341-80e5-4856-93b4-0549ddce1efa") },
                    { new Guid("ef242992-16be-46a1-9061-3fe4549f93d4"), true, new Guid("df7004d5-c3d2-443f-953d-04e71f95988f") },
                    { new Guid("fd14036e-6ce9-452f-9311-38a492a70c5c"), true, new Guid("e75de341-80e5-4856-93b4-0549ddce1efa") },
                    { new Guid("ff2faceb-9bee-4ae0-a631-29488ffcbc09"), true, new Guid("e75de341-80e5-4856-93b4-0549ddce1efa") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("4152ea23-9133-4b35-85f7-1e6298b654d3"), null, new Guid("336839d6-f398-4fdf-a7b1-11f331913174"), "Доцент" },
                    { new Guid("6275fe24-c274-4568-b55e-0be0f9045c7e"), null, new Guid("a3fc447e-c9b5-431b-ba7b-2c0e873ecdff"), "Имеющие ученую степень доктора наук" },
                    { new Guid("a16a5da9-89c0-4390-afa2-801d7223f0e9"), null, new Guid("a3fc447e-c9b5-431b-ba7b-2c0e873ecdff"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("cef77cb1-2a00-4b93-b0df-b1b24f6ee584"), null, new Guid("336839d6-f398-4fdf-a7b1-11f331913174"), "Профессор" },
                    { new Guid("eaef98d2-6baf-4fce-b5c8-5f283b5e18a3"), null, new Guid("336839d6-f398-4fdf-a7b1-11f331913174"), "Нет" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("006a09df-e7a5-49b3-9953-342d6642ca6e"), null, new Guid("11050ef1-3019-49ee-9e4d-1a395f4a24bf"), false, true, new Guid("2c9b23bf-243d-47c9-9b93-554161437e35"), null },
                    { new Guid("05053963-6d1c-437e-ae78-0d75ef19bf37"), null, new Guid("48851390-eacc-48b7-a803-91521a2963df"), true, true, new Guid("05b49a8e-20e2-48c8-a07b-347d371c7290"), "Методология и методы, используемые в работе" },
                    { new Guid("058fd2ed-00fd-49b2-91d3-f76da8e9cc7f"), null, new Guid("4c0486b6-3eab-41ba-9512-9ee7dfe172bc"), true, true, new Guid("e702b6d1-33c0-4c92-8509-a8c49f547384"), "ORCiD" },
                    { new Guid("31aac261-3906-4d07-aa8c-be8b9a31b02e"), null, new Guid("ccea463e-061b-42bc-9d76-8ca98974bd67"), false, true, new Guid("1c87f7f4-afae-479e-88b6-283fd30a90c2"), null },
                    { new Guid("3356e3c6-5155-422f-975a-c270b63db1f5"), null, new Guid("ccea463e-061b-42bc-9d76-8ca98974bd67"), false, true, new Guid("fd14036e-6ce9-452f-9311-38a492a70c5c"), null },
                    { new Guid("39aad474-15ca-4db3-98aa-cc183cafb584"), null, new Guid("11050ef1-3019-49ee-9e4d-1a395f4a24bf"), false, true, new Guid("9baea2a8-05e9-4cef-99f2-52c70f8a94e1"), null },
                    { new Guid("433f61c5-8818-4bc0-bfc1-49a2f1ee84d2"), null, new Guid("48851390-eacc-48b7-a803-91521a2963df"), true, true, new Guid("9baea2a8-05e9-4cef-99f2-52c70f8a94e1"), "Инновационность" },
                    { new Guid("49252adb-91c5-4b5b-b8dd-0c1b440dd8c5"), null, new Guid("48851390-eacc-48b7-a803-91521a2963df"), true, true, new Guid("a2ef2d4a-a718-4015-b98e-29f488d114d3"), "Результаты и выводы" },
                    { new Guid("583f5c1c-ca61-45a2-bf3e-233a77f54fbd"), null, new Guid("48851390-eacc-48b7-a803-91521a2963df"), true, true, new Guid("ef242992-16be-46a1-9061-3fe4549f93d4"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("6407fea8-294f-4f5f-b244-5009b2ab87d9"), null, new Guid("48851390-eacc-48b7-a803-91521a2963df"), true, true, new Guid("62ff05ee-7773-4699-a098-c0ae32edf922"), "Актуальность конкурсной работы" },
                    { new Guid("8180da61-83ac-46d5-a9f5-e590093758bd"), null, new Guid("ccea463e-061b-42bc-9d76-8ca98974bd67"), false, true, new Guid("bf8f5298-5426-40cc-b3cb-ccf8558b1706"), null },
                    { new Guid("82853aa5-b800-412d-9484-1ad312775ed0"), null, new Guid("11050ef1-3019-49ee-9e4d-1a395f4a24bf"), false, true, new Guid("a2ef2d4a-a718-4015-b98e-29f488d114d3"), null },
                    { new Guid("88640e88-5f74-4b98-81bf-c97797333273"), null, new Guid("ccea463e-061b-42bc-9d76-8ca98974bd67"), false, true, new Guid("ff2faceb-9bee-4ae0-a631-29488ffcbc09"), null },
                    { new Guid("92c01c24-a648-4c9d-b7b1-e237ea2183f0"), null, new Guid("4c0486b6-3eab-41ba-9512-9ee7dfe172bc"), true, true, new Guid("bf8f5298-5426-40cc-b3cb-ccf8558b1706"), "Google Scholar ID" },
                    { new Guid("b3f3f9a9-8364-4216-9e17-959ec73d65ee"), null, new Guid("4c0486b6-3eab-41ba-9512-9ee7dfe172bc"), true, true, new Guid("1c87f7f4-afae-479e-88b6-283fd30a90c2"), "ResearcherID" },
                    { new Guid("c2372558-4d87-41ae-a6ce-73f6b693f26a"), null, new Guid("4c0486b6-3eab-41ba-9512-9ee7dfe172bc"), true, true, new Guid("fd14036e-6ce9-452f-9311-38a492a70c5c"), "РИНЦ AuthorID" },
                    { new Guid("c391e0c1-01a3-4ba1-b4cc-7c7a94078ae0"), null, new Guid("48851390-eacc-48b7-a803-91521a2963df"), true, true, new Guid("d479c347-bcec-44ef-8b48-2d45f7c72f94"), "Название работы" },
                    { new Guid("c67fdaa4-bf3f-48fc-884c-574d924d80cf"), null, new Guid("11050ef1-3019-49ee-9e4d-1a395f4a24bf"), false, true, new Guid("05b49a8e-20e2-48c8-a07b-347d371c7290"), null },
                    { new Guid("d5b311db-a08f-43d5-b298-cbf614eaef5f"), null, new Guid("11050ef1-3019-49ee-9e4d-1a395f4a24bf"), false, true, new Guid("ef242992-16be-46a1-9061-3fe4549f93d4"), null },
                    { new Guid("d90714e4-74bf-4bd9-b3c1-f1f46fb33dfa"), null, new Guid("ccea463e-061b-42bc-9d76-8ca98974bd67"), false, true, new Guid("e702b6d1-33c0-4c92-8509-a8c49f547384"), null },
                    { new Guid("dc0cbd19-f858-4f25-b26d-88b9081d2a56"), null, new Guid("4c0486b6-3eab-41ba-9512-9ee7dfe172bc"), true, true, new Guid("ff2faceb-9bee-4ae0-a631-29488ffcbc09"), "ScopusID" },
                    { new Guid("e4870e23-379d-41ee-adf0-8fe06db34cb6"), null, new Guid("11050ef1-3019-49ee-9e4d-1a395f4a24bf"), false, true, new Guid("d479c347-bcec-44ef-8b48-2d45f7c72f94"), null },
                    { new Guid("f44dfca7-4bec-4209-85d3-f3538839100d"), null, new Guid("48851390-eacc-48b7-a803-91521a2963df"), true, true, new Guid("2c9b23bf-243d-47c9-9b93-554161437e35"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("f75a9e27-e47a-40d6-9c1d-ad9b177965e5"), null, new Guid("11050ef1-3019-49ee-9e4d-1a395f4a24bf"), false, true, new Guid("62ff05ee-7773-4699-a098-c0ae32edf922"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8"), new Guid("1f7a450d-6d0d-4f0e-884a-fbcd4d0369e9") },
                    { new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8"), new Guid("45914fa3-2783-4265-b2dc-a0bb75181069") },
                    { new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8"), new Guid("58a80d0a-8c02-443c-bded-92c8c490c0ea") },
                    { new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8"), new Guid("a633e0ed-bbce-4d08-908c-a56f6c6cfa04") },
                    { new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8"), new Guid("b40c5928-3067-4cc3-a61a-e09d2d1a2e55") },
                    { new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8"), new Guid("f188fa84-f985-4133-903d-3584336903dc") },
                    { new Guid("07a40c8d-cfd0-402c-a31d-8e8aa19fbac8"), new Guid("f81aa45b-9e0a-4234-8a79-579148f6ced1") },
                    { new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3"), new Guid("044ed106-cd18-43a5-b0b0-974f524fb26b") },
                    { new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3"), new Guid("1e5b4974-d60e-4459-80a9-26d1275fd6e4") },
                    { new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3"), new Guid("2670b0bc-2930-4973-bd2c-a8ff026e21c7") },
                    { new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3"), new Guid("8953ad90-a566-4d9a-a111-ff3425eabdb6") },
                    { new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3"), new Guid("b1574528-2995-4d23-81cb-cc71fa3cc854") },
                    { new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3"), new Guid("b727a537-1637-4fd2-a83c-f11e06635be7") },
                    { new Guid("1f9184c6-b405-407b-bbcd-bf54f8fd0ba3"), new Guid("f2508164-bcdc-4c1a-98c0-8524905da673") },
                    { new Guid("290f58a2-89a0-48e1-8f34-30cda9d4a2bf"), new Guid("1e5b4974-d60e-4459-80a9-26d1275fd6e4") },
                    { new Guid("290f58a2-89a0-48e1-8f34-30cda9d4a2bf"), new Guid("893e57ac-b675-49c7-b738-b0ed56d2ca03") },
                    { new Guid("290f58a2-89a0-48e1-8f34-30cda9d4a2bf"), new Guid("f2508164-bcdc-4c1a-98c0-8524905da673") },
                    { new Guid("52d232b4-195a-4693-92ac-8fa8bebaabf1"), new Guid("893e57ac-b675-49c7-b738-b0ed56d2ca03") },
                    { new Guid("52d232b4-195a-4693-92ac-8fa8bebaabf1"), new Guid("b22bec11-bcba-436a-857d-3591a92b83be") },
                    { new Guid("52d232b4-195a-4693-92ac-8fa8bebaabf1"), new Guid("e7ee71ac-d9b8-4c9d-b102-9096e7c3f7f8") },
                    { new Guid("a934ac2c-8e0d-4bba-b187-62648068b9c6"), new Guid("885ed870-fb66-4296-936f-00e0d698fa15") },
                    { new Guid("a934ac2c-8e0d-4bba-b187-62648068b9c6"), new Guid("e75a5fef-7034-4f7d-8a4b-835eedd0cddc") },
                    { new Guid("b05620e6-f627-4a6a-a460-53141cad6715"), new Guid("1578dad5-0aa0-4a83-8777-31fdd6699f51") },
                    { new Guid("b05620e6-f627-4a6a-a460-53141cad6715"), new Guid("2fb1dad7-6eb3-4e08-b95c-daf8fde16fea") },
                    { new Guid("b05620e6-f627-4a6a-a460-53141cad6715"), new Guid("5864b6d8-e068-4b8a-817d-24e2bcd8d3c5") },
                    { new Guid("b05620e6-f627-4a6a-a460-53141cad6715"), new Guid("5c79c217-da59-4bec-a601-bcf85b283239") },
                    { new Guid("b05620e6-f627-4a6a-a460-53141cad6715"), new Guid("b644c65e-a19c-4b5a-8751-a038f8d3f2e1") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("101e5b49-120d-487c-9de7-9bfe7d220df6"), new Guid("a2384b72-d100-41f5-843c-b4749fc4db89"), null, "Руководитель" },
                    { new Guid("359aea12-a626-4377-b27a-4f9bafd8a21d"), new Guid("c19a2813-4d0d-42ba-90c4-4be8efdc1dd1"), null, "База данных" },
                    { new Guid("3f5fb45e-4fd0-4bab-999d-886885b6f388"), new Guid("faf051ad-af68-423d-899b-74313b64ad2c"), null, "Международный" },
                    { new Guid("64eb8aa0-880f-4756-84a8-458fd27289cc"), new Guid("9ac92682-3a52-4e68-8e4b-29840b729034"), null, "База данных" },
                    { new Guid("6606a908-3528-48d6-9295-139a013dc804"), new Guid("c19a2813-4d0d-42ba-90c4-4be8efdc1dd1"), null, "Изобретение" },
                    { new Guid("67b47b38-86b5-4d07-9d0e-e5d245b40ad0"), new Guid("e3ef288c-2772-4414-b6a9-f7e71356b5d2"), null, "Учебник" },
                    { new Guid("6a8a6d98-cc3f-440b-aaf3-1b7438e1afc4"), new Guid("40990967-333e-43a8-b169-809a6d5cb24b"), null, "Лекции" },
                    { new Guid("740cc60a-0f2d-40ff-89c3-11139ca74767"), new Guid("1728e9fb-14f3-4076-8a47-93f9cc6c3c88"), null, "Иностранный" },
                    { new Guid("79e01eff-0a5e-468c-8eda-dad159223582"), new Guid("faf051ad-af68-423d-899b-74313b64ad2c"), null, "Всероссийский" },
                    { new Guid("7c297dfc-8bd7-4899-b6b1-e3c560187258"), new Guid("a2384b72-d100-41f5-843c-b4749fc4db89"), null, "Исполнитель" },
                    { new Guid("7e047af2-471d-4c94-be78-c16543a05cc1"), new Guid("2c7919ef-7ffd-4cba-b26d-1294a3d11af7"), null, "Да" },
                    { new Guid("8d7fe693-b3b8-468a-a978-18d45d7ffcfb"), new Guid("2c7919ef-7ffd-4cba-b26d-1294a3d11af7"), null, "Нет" },
                    { new Guid("92c8ac2a-2e52-4084-8b8b-8804f9b5b637"), new Guid("e3ef288c-2772-4414-b6a9-f7e71356b5d2"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("997d8980-d99b-461e-a9de-3143f45406c4"), new Guid("e3ef288c-2772-4414-b6a9-f7e71356b5d2"), null, "Монография" },
                    { new Guid("c160df85-530f-485b-92e8-a9672d10f470"), new Guid("40990967-333e-43a8-b169-809a6d5cb24b"), null, "Лабораторные" },
                    { new Guid("cdf9b7a8-9e12-4729-847b-74b1a6928667"), new Guid("c19a2813-4d0d-42ba-90c4-4be8efdc1dd1"), null, "Полезная модель" },
                    { new Guid("d4f96bd7-bb6b-457c-82af-ba147d60dafb"), new Guid("faf051ad-af68-423d-899b-74313b64ad2c"), null, "Региональный" },
                    { new Guid("e6e926a4-2e60-40ce-9a13-99a1ecca3fee"), new Guid("9ac92682-3a52-4e68-8e4b-29840b729034"), null, "Полезная модель" },
                    { new Guid("f3f18e22-141b-4b05-bcd1-afd8f73872d5"), new Guid("9ac92682-3a52-4e68-8e4b-29840b729034"), null, "Изобретение" },
                    { new Guid("fd4a4ef2-4ddd-46af-b145-c7e7c8714506"), new Guid("1728e9fb-14f3-4076-8a47-93f9cc6c3c88"), null, "Русский" }
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
