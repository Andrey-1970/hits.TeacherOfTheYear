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
                    { new Guid("5ff402d9-31bd-4e16-aceb-a59005a79b58"), 6, "Оценена" },
                    { new Guid("6e0c3a16-76f3-4e1b-8eb2-961519341635"), 3, "В процессе рассмотрения" },
                    { new Guid("70bec53d-e0b9-40d3-ad5f-d80baeb7de15"), 5, "Отклонена" },
                    { new Guid("738d80e8-b0ea-45ed-bea7-d57991bcdf9f"), 4, "Одобрена" },
                    { new Guid("d89ddec7-facf-43fe-80b1-98fe3bbf7cf1"), 1, "В ожидании заполнения" },
                    { new Guid("debd201c-a230-4ba0-b7d7-08bfcc63fce5"), 2, "В ожидании рассмотрения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1781acee-0ef3-4468-884b-f972cfcc8d6e", null, "Organiser", "ORGANISER" },
                    { "642b3956-af97-4c27-8f01-41e7f3e77b8d", null, "Admin", "ADMIN" },
                    { "78bdcd1e-9ae6-42c6-b15d-6d0481f3f53e", null, "Voter", "VOTER" },
                    { "9924e6c8-c883-45b8-9667-78c8ab9da072", null, "Expert", "EXPERT" },
                    { "fbb2e714-c91c-4690-bd81-45944552be6f", null, "Participant", "PARTICIPANT" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("034f68d9-6583-452f-8b09-c28c83fd896c"), "Строительство и архитектура", 1 },
                    { new Guid("88fc10bb-a144-44e8-9842-d64fbeecb544"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("04c7506f-23c7-49a6-acc1-70264c3d82fa"), "Деятельность", 4 },
                    { new Guid("36d259d4-ae95-498b-b648-ae33bec05ff1"), "Общая информация", 1 },
                    { new Guid("f05e60e5-bc47-4c7d-81d5-687b205a1578"), "Категория участников", 2 },
                    { new Guid("f19b21e5-65b0-42b1-8067-da36dbf67e15"), "Деятельность", 5 },
                    { new Guid("fab9f7b9-7792-46f2-a31d-ab1f23632fb4"), "Профессиональное развитие", 3 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("10f835c8-a341-4a2c-80ba-5c7eb3346b0f"), "Профессиональные показатели", 4 },
                    { new Guid("1aecdbd8-8b25-4bdf-9dac-ea00183bf0a0"), "Конкурсная работа", 7 },
                    { new Guid("2fadb685-da85-43aa-91e7-59f3b4a2b27b"), "Методическая деятельность", 3 },
                    { new Guid("3c50495c-7355-482f-8661-dc057d347c9c"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("405bae2d-7ef7-4df6-8c86-3d44e1e7bc20"), "Инновационная и иная деятельность", 6 },
                    { new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863"), "Образовательная деятельность", 2 },
                    { new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4"), "Основной", 1 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("14fc941e-94f3-4aa7-b736-aa4b8a587723"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("6b1d7043-98a7-488f-b2bc-2934bc92da63"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5e19966b-b549-46f8-ae7a-d886affac3f5"), "bool" },
                    { new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf"), "string" },
                    { new Guid("df2f793d-8c44-41f9-98fd-b3a826792623"), "DateTime" },
                    { new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7"), "int" },
                    { new Guid("e7d9d555-3729-4e24-a411-b60c9a1a6298"), "TextArea" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("04c7506f-23c7-49a6-acc1-70264c3d82fa"), new Guid("14fc941e-94f3-4aa7-b736-aa4b8a587723") },
                    { new Guid("36d259d4-ae95-498b-b648-ae33bec05ff1"), new Guid("14fc941e-94f3-4aa7-b736-aa4b8a587723") },
                    { new Guid("36d259d4-ae95-498b-b648-ae33bec05ff1"), new Guid("6b1d7043-98a7-488f-b2bc-2934bc92da63") },
                    { new Guid("f05e60e5-bc47-4c7d-81d5-687b205a1578"), new Guid("14fc941e-94f3-4aa7-b736-aa4b8a587723") },
                    { new Guid("f05e60e5-bc47-4c7d-81d5-687b205a1578"), new Guid("6b1d7043-98a7-488f-b2bc-2934bc92da63") },
                    { new Guid("f19b21e5-65b0-42b1-8067-da36dbf67e15"), new Guid("6b1d7043-98a7-488f-b2bc-2934bc92da63") },
                    { new Guid("fab9f7b9-7792-46f2-a31d-ab1f23632fb4"), new Guid("14fc941e-94f3-4aa7-b736-aa4b8a587723") },
                    { new Guid("fab9f7b9-7792-46f2-a31d-ab1f23632fb4"), new Guid("6b1d7043-98a7-488f-b2bc-2934bc92da63") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("04f2e548-f489-4607-8049-8eaf3379de7d"), new Guid("36d259d4-ae95-498b-b648-ae33bec05ff1"), null, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("11badcb7-dcd2-4ce8-8fcb-331f993d0c6e"), new Guid("36d259d4-ae95-498b-b648-ae33bec05ff1"), null, true, "Должность", 9, "Введите свою должность в организации", new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("1355e8cc-46bb-4e7b-b7c8-c076ead498ef"), new Guid("36d259d4-ae95-498b-b648-ae33bec05ff1"), null, true, "Место работы/учебы", 6, "Название организации", new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("3225dcc5-2a90-46f1-aba9-ae32c13545c7"), new Guid("f05e60e5-bc47-4c7d-81d5-687b205a1578"), null, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("3397badb-655d-4aa0-9d29-86c1ca7a9781"), new Guid("36d259d4-ae95-498b-b648-ae33bec05ff1"), null, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("3f1ed0e4-604f-4c6e-b72d-fd5f90f3ef6f"), new Guid("f19b21e5-65b0-42b1-8067-da36dbf67e15"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("4ae741c5-797e-42df-8bb8-801d4564946c"), new Guid("36d259d4-ae95-498b-b648-ae33bec05ff1"), null, true, "Дата рождения", 2, "01.01.2000", new Guid("df2f793d-8c44-41f9-98fd-b3a826792623") },
                    { new Guid("945fe82d-9f24-4edd-8fa0-e7f425760e9d"), new Guid("36d259d4-ae95-498b-b648-ae33bec05ff1"), null, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("a96ceb7a-05ee-4a71-9034-30b305fbe95b"), new Guid("36d259d4-ae95-498b-b648-ae33bec05ff1"), null, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("ad96da61-188f-499f-907c-c37f78f90c40"), new Guid("f05e60e5-bc47-4c7d-81d5-687b205a1578"), null, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("b7ccb597-ad18-402f-9b65-d5735a2810fc"), new Guid("36d259d4-ae95-498b-b648-ae33bec05ff1"), null, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("bc2ff45a-9df8-4c7d-a18c-fd0277405258"), new Guid("36d259d4-ae95-498b-b648-ae33bec05ff1"), null, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("c016ceac-b7bb-4741-b9ab-14233f1bbc01"), new Guid("36d259d4-ae95-498b-b648-ae33bec05ff1"), null, true, "Электронная почта", 5, "user@example.com", new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("c87a13a1-3fc0-41b8-8cf3-e1871426a13b"), new Guid("04c7506f-23c7-49a6-acc1-70264c3d82fa"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("da15fef0-c15c-460e-b7d9-c86610cf24a9"), new Guid("f05e60e5-bc47-4c7d-81d5-687b205a1578"), null, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("e05e46c5-4c4c-4c5a-8f04-1ab86070c3ff"), new Guid("f05e60e5-bc47-4c7d-81d5-687b205a1578"), null, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("f205b29a-9208-40a2-b95b-6192193e4782"), new Guid("04c7506f-23c7-49a6-acc1-70264c3d82fa"), "Руководство дипломными проектами за предыдущий учебный год", true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("f2b3e7a0-ee71-40f6-ad13-c480e735a749"), new Guid("04c7506f-23c7-49a6-acc1-70264c3d82fa"), null, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("f53f7a40-c469-4d40-aebd-6ffc6b1e41bc"), new Guid("f19b21e5-65b0-42b1-8067-da36dbf67e15"), null, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("10f835c8-a341-4a2c-80ba-5c7eb3346b0f"), new Guid("14fc941e-94f3-4aa7-b736-aa4b8a587723") },
                    { new Guid("1aecdbd8-8b25-4bdf-9dac-ea00183bf0a0"), new Guid("14fc941e-94f3-4aa7-b736-aa4b8a587723") },
                    { new Guid("1aecdbd8-8b25-4bdf-9dac-ea00183bf0a0"), new Guid("6b1d7043-98a7-488f-b2bc-2934bc92da63") },
                    { new Guid("2fadb685-da85-43aa-91e7-59f3b4a2b27b"), new Guid("14fc941e-94f3-4aa7-b736-aa4b8a587723") },
                    { new Guid("3c50495c-7355-482f-8661-dc057d347c9c"), new Guid("6b1d7043-98a7-488f-b2bc-2934bc92da63") },
                    { new Guid("405bae2d-7ef7-4df6-8c86-3d44e1e7bc20"), new Guid("6b1d7043-98a7-488f-b2bc-2934bc92da63") },
                    { new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863"), new Guid("14fc941e-94f3-4aa7-b736-aa4b8a587723") },
                    { new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4"), new Guid("14fc941e-94f3-4aa7-b736-aa4b8a587723") },
                    { new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4"), new Guid("6b1d7043-98a7-488f-b2bc-2934bc92da63") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0275c92d-1582-42dd-a06a-2b5b72a62cdb"), new Guid("f19b21e5-65b0-42b1-8067-da36dbf67e15"), false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("224b00ab-0ae6-4ceb-aef1-7b439788ecbb"), new Guid("04c7506f-23c7-49a6-acc1-70264c3d82fa"), false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("2de50853-fb80-457c-b93c-bfa2a1176059"), new Guid("04c7506f-23c7-49a6-acc1-70264c3d82fa"), false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("77949a99-d744-4a1e-b658-4b1bf82751bf"), new Guid("f05e60e5-bc47-4c7d-81d5-687b205a1578"), true, "Краткая аннотация конкурсной работы", 14 },
                    { new Guid("80e73dc7-8933-487a-a33b-b7dbaafe079c"), new Guid("04c7506f-23c7-49a6-acc1-70264c3d82fa"), false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("86e79826-8912-4e3b-baf5-5f171d0f8453"), new Guid("f19b21e5-65b0-42b1-8067-da36dbf67e15"), false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("b05bab3c-5a12-4222-a6bc-c2c75e4f2d3d"), new Guid("04c7506f-23c7-49a6-acc1-70264c3d82fa"), false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("c5f4882f-e8f0-42af-8651-1859320a8481"), new Guid("f19b21e5-65b0-42b1-8067-da36dbf67e15"), false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("cec6d0ab-2b11-42d6-94fe-ae0a6ea08f80"), new Guid("f19b21e5-65b0-42b1-8067-da36dbf67e15"), false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("d178e5ad-e069-40eb-97fb-9d642be81405"), new Guid("f19b21e5-65b0-42b1-8067-da36dbf67e15"), true, "Персональные идентификаторы", 10 },
                    { new Guid("dcfcdc08-c26e-4fcd-b6b8-545b75d996b9"), new Guid("04c7506f-23c7-49a6-acc1-70264c3d82fa"), false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("e12813e0-604d-4fc2-a2f0-24ee6a81a9f2"), new Guid("fab9f7b9-7792-46f2-a31d-ab1f23632fb4"), false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("eb2712f5-68d4-4587-af28-0cbe06a47fe0"), new Guid("04c7506f-23c7-49a6-acc1-70264c3d82fa"), false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("ed991030-ab8f-406b-a841-3b33ee33d91d"), new Guid("fab9f7b9-7792-46f2-a31d-ab1f23632fb4"), false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("07bbad16-7ade-4a1f-a2f7-4fe0b5d3aebb"), true, "Вид деятельности (преподавательская)", 3, new Guid("224b00ab-0ae6-4ceb-aef1-7b439788ecbb"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("08ed39ad-4737-43b1-a5a6-6326d1b3eaea"), true, "Год", 3, new Guid("b05bab3c-5a12-4222-a6bc-c2c75e4f2d3d"), new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("0be9d5b8-d5e8-4ee3-8963-239db934477e"), true, "Год получения документа", 2, new Guid("e12813e0-604d-4fc2-a2f0-24ee6a81a9f2"), new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("0d710cf3-4cc4-4d56-9f3f-1072d99db8dd"), true, "Название", 1, new Guid("77949a99-d744-4a1e-b658-4b1bf82751bf"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("0f7762e0-fd89-4c7c-a4cd-9657b7e86589"), true, "Значение", 2, new Guid("77949a99-d744-4a1e-b658-4b1bf82751bf"), new Guid("e7d9d555-3729-4e24-a411-b60c9a1a6298") },
                    { new Guid("12f32ac6-2b42-4091-a5a1-b1c43eaa1fe3"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("b05bab3c-5a12-4222-a6bc-c2c75e4f2d3d"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("152032c9-af7b-4489-8643-09087951b51a"), true, "Соавторы", 2, new Guid("dcfcdc08-c26e-4fcd-b6b8-545b75d996b9"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("172457ad-37f5-4a6f-9b27-0a6b267631cc"), true, "Вид (лекции, лабораторные)", 2, new Guid("2de50853-fb80-457c-b93c-bfa2a1176059"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("1c7d5cbf-563d-49cc-a00f-1f04cdd500a9"), true, "Название статьи", 1, new Guid("c5f4882f-e8f0-42af-8651-1859320a8481"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("20af9d5f-7f7d-44c0-8074-90f264697e9b"), true, "ФИО соавторов", 3, new Guid("cec6d0ab-2b11-42d6-94fe-ae0a6ea08f80"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("34dca0a9-cf94-4a6c-8123-ca4fcdd0027f"), true, "Название", 2, new Guid("cec6d0ab-2b11-42d6-94fe-ae0a6ea08f80"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("37cf4ed3-0408-4319-9e35-9af9f25b750a"), true, "Награда", 4, new Guid("ed991030-ab8f-406b-a841-3b33ee33d91d"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("3a3fc91a-d767-4969-aca9-7b3d95e67bee"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("80e73dc7-8933-487a-a33b-b7dbaafe079c"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("3d578266-11a3-4724-ac20-08dd645b7910"), true, "Название конкурса/премии", 2, new Guid("b05bab3c-5a12-4222-a6bc-c2c75e4f2d3d"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("3e4ade72-ff03-4189-a5af-714ebe55eff8"), true, "Количество часов", 4, new Guid("224b00ab-0ae6-4ceb-aef1-7b439788ecbb"), new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("40884dae-ef12-4bbd-ad30-142bd837f057"), true, "Название", 2, new Guid("eb2712f5-68d4-4587-af28-0cbe06a47fe0"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("41cecd7e-7567-4c74-99a5-4e3c8407bdad"), true, "Вид", 1, new Guid("cec6d0ab-2b11-42d6-94fe-ae0a6ea08f80"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("42578a79-84d3-4269-8925-0f3e36873234"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("224b00ab-0ae6-4ceb-aef1-7b439788ecbb"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("46067b9f-8151-46f5-9bd4-8b8e298eb36f"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("2de50853-fb80-457c-b93c-bfa2a1176059"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("4d9a625e-83bf-4495-be76-7a54dd22511c"), true, "Ссылка", 5, new Guid("ed991030-ab8f-406b-a841-3b33ee33d91d"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("4f485fb0-be67-4c6d-81ea-995ffba002f7"), true, "Год", 1, new Guid("ed991030-ab8f-406b-a841-3b33ee33d91d"), new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("578950a3-1832-4d10-a753-1839d14af12e"), true, "Соавторы", 2, new Guid("c5f4882f-e8f0-42af-8651-1859320a8481"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("58c037c3-229e-4fa2-a7f6-104dd8f1c7b3"), true, "Название дисциплины", 1, new Guid("2de50853-fb80-457c-b93c-bfa2a1176059"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("633c82c4-fb2b-4c25-92e6-d701730cd04d"), true, "Лекции (час.)", 3, new Guid("80e73dc7-8933-487a-a33b-b7dbaafe079c"), new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("675ae90f-94d1-436b-b1da-d673498fae35"), false, "Тип идентификатора", 1, new Guid("d178e5ad-e069-40eb-97fb-9d642be81405"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("6abce623-6a50-409e-ab4c-7376553e033a"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("c5f4882f-e8f0-42af-8651-1859320a8481"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("6d051cec-b590-4c7b-b002-adf399d2fdfc"), true, "Период выполнения", 3, new Guid("0275c92d-1582-42dd-a06a-2b5b72a62cdb"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("6de112fe-8364-4bf0-bcb4-56207d88ddbb"), true, "Язык публикации", 7, new Guid("eb2712f5-68d4-4587-af28-0cbe06a47fe0"), new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("70405f7b-ab64-4e1e-91aa-a0a5a6fabbff"), true, "Количество печатных листов", 4, new Guid("eb2712f5-68d4-4587-af28-0cbe06a47fe0"), new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("7068312c-4581-4f1c-8f88-000837824e5f"), true, "Вид", 1, new Guid("86e79826-8912-4e3b-baf5-5f171d0f8453"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("789bb4e2-31ff-4523-8539-803d17d8e4e7"), true, "Итого (час.)", 5, new Guid("80e73dc7-8933-487a-a33b-b7dbaafe079c"), new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("7d19e936-0e12-41b1-9793-edb091e85fc3"), true, "Вид публикации", 1, new Guid("eb2712f5-68d4-4587-af28-0cbe06a47fe0"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("81f231c1-03a9-4885-abd1-1ecb001b89b5"), true, "Издательство, год", 6, new Guid("eb2712f5-68d4-4587-af28-0cbe06a47fe0"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("98825df4-3947-445c-99d6-8405836664fb"), true, "Статус (руководитель/исполнитель)", 4, new Guid("0275c92d-1582-42dd-a06a-2b5b72a62cdb"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("9b31b545-77d9-429b-8b8f-889173fca59b"), true, "Год", 4, new Guid("dcfcdc08-c26e-4fcd-b6b8-545b75d996b9"), new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("a6b38eb6-d444-4158-835e-b3bfb00ecb3b"), true, "Название организации/должность/ставка", 1, new Guid("224b00ab-0ae6-4ceb-aef1-7b439788ecbb"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("aa86b8d4-5f1e-4985-8764-e2299e857dc9"), true, "Наличие грифа", 5, new Guid("eb2712f5-68d4-4587-af28-0cbe06a47fe0"), new Guid("5e19966b-b549-46f8-ae7a-d886affac3f5") },
                    { new Guid("acd29f0b-edbd-425b-9130-62736c1f4c47"), true, "Практические занятия (час.)", 4, new Guid("80e73dc7-8933-487a-a33b-b7dbaafe079c"), new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("af841716-a5a8-466a-a585-040d8ec2bfb1"), true, "Название конкурса", 2, new Guid("ed991030-ab8f-406b-a841-3b33ee33d91d"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("be06e5af-188f-4c2f-9636-e45abf248afa"), true, "Название организации в которую внедрена разработка", 3, new Guid("86e79826-8912-4e3b-baf5-5f171d0f8453"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("c3236aa9-9779-4a49-9865-c739d10b12e5"), true, "Название разработки", 2, new Guid("86e79826-8912-4e3b-baf5-5f171d0f8453"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("c6ee8fcc-1b06-414a-8e59-6575b3f6bfda"), true, "Номер РИД", 4, new Guid("cec6d0ab-2b11-42d6-94fe-ae0a6ea08f80"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("cea68bc0-2157-4481-8791-9d8bc1b7167a"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("0275c92d-1582-42dd-a06a-2b5b72a62cdb"), new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("db08cfac-b2ea-4cea-8b52-c1f085f21712"), true, "Издание, год", 4, new Guid("c5f4882f-e8f0-42af-8651-1859320a8481"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("e1186afd-73c1-4baa-847e-448750459112"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("0275c92d-1582-42dd-a06a-2b5b72a62cdb"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("e26c5335-510c-40ec-8f22-8b17eb66314f"), true, "Название НИР/НИОКР", 1, new Guid("0275c92d-1582-42dd-a06a-2b5b72a62cdb"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("e441d6ce-8778-48ea-8093-469c3763e3d2"), true, "Название документа, реквизиты", 1, new Guid("e12813e0-604d-4fc2-a2f0-24ee6a81a9f2"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("eed2cd7c-4970-418a-9509-3bdb6e39ca27"), false, "Соавторы", 3, new Guid("eb2712f5-68d4-4587-af28-0cbe06a47fe0"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("f0c907b5-272e-41c3-bb1b-91392e904ff2"), true, "Статус конкурса", 3, new Guid("ed991030-ab8f-406b-a841-3b33ee33d91d"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("f21f847e-e117-42c9-afd6-604e6a9e2735"), true, "Ссылка на платформу", 3, new Guid("dcfcdc08-c26e-4fcd-b6b8-545b75d996b9"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("f30f38f5-a5c6-4972-9372-46885433ae7c"), false, "Идентификатор", 2, new Guid("d178e5ad-e069-40eb-97fb-9d642be81405"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("f7c66d3c-9254-4d7e-b4c7-ba31f02a4896"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("b05bab3c-5a12-4222-a6bc-c2c75e4f2d3d"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("fa5b3d56-a9fa-46bc-b032-dbd1e21159f5"), true, "Ссылка на открытый доступ", 8, new Guid("eb2712f5-68d4-4587-af28-0cbe06a47fe0"), new Guid("e276cbdb-f82b-455d-a10b-57ab882458b7") },
                    { new Guid("fc39e349-a7bc-43d0-b755-fc3363d6b016"), true, "Название курса", 1, new Guid("dcfcdc08-c26e-4fcd-b6b8-545b75d996b9"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("fd646c56-f15c-4860-a87d-40e6def4771a"), true, "ФИО", 1, new Guid("b05bab3c-5a12-4222-a6bc-c2c75e4f2d3d"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") },
                    { new Guid("fd687a79-58fe-48af-bbfe-96c82e9a8913"), true, "Наименование курса", 1, new Guid("80e73dc7-8933-487a-a33b-b7dbaafe079c"), new Guid("7b5604ae-d1aa-44f2-9e45-cc7b5edb9adf") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("04f2e548-f489-4607-8049-8eaf3379de7d"), new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4") },
                    { new Guid("11badcb7-dcd2-4ce8-8fcb-331f993d0c6e"), new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4") },
                    { new Guid("1355e8cc-46bb-4e7b-b7c8-c076ead498ef"), new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4") },
                    { new Guid("3225dcc5-2a90-46f1-aba9-ae32c13545c7"), new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4") },
                    { new Guid("3397badb-655d-4aa0-9d29-86c1ca7a9781"), new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4") },
                    { new Guid("3f1ed0e4-604f-4c6e-b72d-fd5f90f3ef6f"), new Guid("3c50495c-7355-482f-8661-dc057d347c9c") },
                    { new Guid("4ae741c5-797e-42df-8bb8-801d4564946c"), new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4") },
                    { new Guid("945fe82d-9f24-4edd-8fa0-e7f425760e9d"), new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4") },
                    { new Guid("a96ceb7a-05ee-4a71-9034-30b305fbe95b"), new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4") },
                    { new Guid("ad96da61-188f-499f-907c-c37f78f90c40"), new Guid("10f835c8-a341-4a2c-80ba-5c7eb3346b0f") },
                    { new Guid("ad96da61-188f-499f-907c-c37f78f90c40"), new Guid("3c50495c-7355-482f-8661-dc057d347c9c") },
                    { new Guid("ad96da61-188f-499f-907c-c37f78f90c40"), new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4") },
                    { new Guid("b7ccb597-ad18-402f-9b65-d5735a2810fc"), new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4") },
                    { new Guid("bc2ff45a-9df8-4c7d-a18c-fd0277405258"), new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4") },
                    { new Guid("c016ceac-b7bb-4741-b9ab-14233f1bbc01"), new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4") },
                    { new Guid("c87a13a1-3fc0-41b8-8cf3-e1871426a13b"), new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863") },
                    { new Guid("da15fef0-c15c-460e-b7d9-c86610cf24a9"), new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4") },
                    { new Guid("e05e46c5-4c4c-4c5a-8f04-1ab86070c3ff"), new Guid("ba1b7279-8651-40f2-ab82-a5333fc93dc4") },
                    { new Guid("f205b29a-9208-40a2-b95b-6192193e4782"), new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863") },
                    { new Guid("f2b3e7a0-ee71-40f6-ad13-c480e735a749"), new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863") },
                    { new Guid("f53f7a40-c469-4d40-aebd-6ffc6b1e41bc"), new Guid("3c50495c-7355-482f-8661-dc057d347c9c") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("10f835c8-a341-4a2c-80ba-5c7eb3346b0f"), new Guid("e12813e0-604d-4fc2-a2f0-24ee6a81a9f2") },
                    { new Guid("10f835c8-a341-4a2c-80ba-5c7eb3346b0f"), new Guid("ed991030-ab8f-406b-a841-3b33ee33d91d") },
                    { new Guid("1aecdbd8-8b25-4bdf-9dac-ea00183bf0a0"), new Guid("77949a99-d744-4a1e-b658-4b1bf82751bf") },
                    { new Guid("2fadb685-da85-43aa-91e7-59f3b4a2b27b"), new Guid("2de50853-fb80-457c-b93c-bfa2a1176059") },
                    { new Guid("2fadb685-da85-43aa-91e7-59f3b4a2b27b"), new Guid("eb2712f5-68d4-4587-af28-0cbe06a47fe0") },
                    { new Guid("3c50495c-7355-482f-8661-dc057d347c9c"), new Guid("0275c92d-1582-42dd-a06a-2b5b72a62cdb") },
                    { new Guid("3c50495c-7355-482f-8661-dc057d347c9c"), new Guid("c5f4882f-e8f0-42af-8651-1859320a8481") },
                    { new Guid("3c50495c-7355-482f-8661-dc057d347c9c"), new Guid("d178e5ad-e069-40eb-97fb-9d642be81405") },
                    { new Guid("3c50495c-7355-482f-8661-dc057d347c9c"), new Guid("ed991030-ab8f-406b-a841-3b33ee33d91d") },
                    { new Guid("405bae2d-7ef7-4df6-8c86-3d44e1e7bc20"), new Guid("86e79826-8912-4e3b-baf5-5f171d0f8453") },
                    { new Guid("405bae2d-7ef7-4df6-8c86-3d44e1e7bc20"), new Guid("cec6d0ab-2b11-42d6-94fe-ae0a6ea08f80") },
                    { new Guid("405bae2d-7ef7-4df6-8c86-3d44e1e7bc20"), new Guid("e12813e0-604d-4fc2-a2f0-24ee6a81a9f2") },
                    { new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863"), new Guid("224b00ab-0ae6-4ceb-aef1-7b439788ecbb") },
                    { new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863"), new Guid("80e73dc7-8933-487a-a33b-b7dbaafe079c") },
                    { new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863"), new Guid("b05bab3c-5a12-4222-a6bc-c2c75e4f2d3d") },
                    { new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863"), new Guid("dcfcdc08-c26e-4fcd-b6b8-545b75d996b9") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0a9d4c9a-2464-4798-9125-b448441c078b"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("e12813e0-604d-4fc2-a2f0-24ee6a81a9f2") },
                    { new Guid("260401eb-4ea3-404c-9160-1ea5701488ee"), "EvaluateMark19", new Guid("3f1ed0e4-604f-4c6e-b72d-fd5f90f3ef6f"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("27cb1bb0-a577-44a2-ba02-cfccb0009266"), null, null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("77949a99-d744-4a1e-b658-4b1bf82751bf") },
                    { new Guid("321af304-c21f-49eb-b24d-bf82ba88ba3b"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("c5f4882f-e8f0-42af-8651-1859320a8481") },
                    { new Guid("51f83077-5e1f-427e-a828-3923b851b857"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("80e73dc7-8933-487a-a33b-b7dbaafe079c") },
                    { new Guid("572940f8-ae68-4c00-b87c-898865f3d6e9"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("eb2712f5-68d4-4587-af28-0cbe06a47fe0") },
                    { new Guid("5ddaa699-f280-4443-bf85-f005ddc85980"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("cec6d0ab-2b11-42d6-94fe-ae0a6ea08f80") },
                    { new Guid("6122976c-d164-498b-91b9-077b1825fd9d"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("80e73dc7-8933-487a-a33b-b7dbaafe079c") },
                    { new Guid("67cbf57e-ff45-41bb-96b8-35c4f9109cfa"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("eb2712f5-68d4-4587-af28-0cbe06a47fe0") },
                    { new Guid("94889238-daa4-472d-b980-04a79817326c"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("ed991030-ab8f-406b-a841-3b33ee33d91d") },
                    { new Guid("9ef02c34-be61-4dc3-a359-d65c3d9a63a1"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("2de50853-fb80-457c-b93c-bfa2a1176059") },
                    { new Guid("9f9b33a8-7d8d-49c3-96fa-f94a69ad53e6"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("eb2712f5-68d4-4587-af28-0cbe06a47fe0") },
                    { new Guid("a6eca8ff-eccc-4259-bdc3-62035c774379"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("eb2712f5-68d4-4587-af28-0cbe06a47fe0") },
                    { new Guid("a978471f-c1ed-43ea-9975-834543c6a903"), "EvaluateMark3", new Guid("f205b29a-9208-40a2-b95b-6192193e4782"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("afea940d-8161-4a59-90d5-3d3273eae226"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("0275c92d-1582-42dd-a06a-2b5b72a62cdb") },
                    { new Guid("bf94bf1d-f6af-4e20-83f1-1357cf6e1502"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("b05bab3c-5a12-4222-a6bc-c2c75e4f2d3d") },
                    { new Guid("c14b527e-2211-4b69-985b-1517c767a397"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("dcfcdc08-c26e-4fcd-b6b8-545b75d996b9") },
                    { new Guid("c563667c-5c6f-41b8-9713-56100ddc70a3"), null, null, false, 10, "Оценка уровня предоставленной работы:", 25, new Guid("77949a99-d744-4a1e-b658-4b1bf82751bf") },
                    { new Guid("d226ce08-6ea0-4702-bca7-c73831a8e9dd"), "EvaluateMark4", new Guid("c87a13a1-3fc0-41b8-8cf3-e1871426a13b"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("dae08794-bece-40a9-85eb-5d5606887217"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("0275c92d-1582-42dd-a06a-2b5b72a62cdb") },
                    { new Guid("def20525-68cc-45e9-9679-c1bb60949ee5"), "EvaluateMark5", new Guid("f2b3e7a0-ee71-40f6-ad13-c480e735a749"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("e52c11ae-7053-4688-88d3-51272f73375b"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("86e79826-8912-4e3b-baf5-5f171d0f8453") },
                    { new Guid("f0d843ff-4512-4979-b993-3313ea70b33f"), "EvaluateMark20", new Guid("f53f7a40-c469-4d40-aebd-6ffc6b1e41bc"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("f94ae375-4838-47a0-b327-99972f643f16"), "EvaluateMark13", new Guid("ad96da61-188f-499f-907c-c37f78f90c40"), true, 5, "Баллы за ученое звание:", 13, null }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("06d51838-6ad2-439e-a008-50844b44e350"), true, new Guid("77949a99-d744-4a1e-b658-4b1bf82751bf") },
                    { new Guid("2477a277-c410-4972-8425-84206a8e4972"), true, new Guid("d178e5ad-e069-40eb-97fb-9d642be81405") },
                    { new Guid("3a865e1c-918d-4f15-93e9-480bff352593"), true, new Guid("77949a99-d744-4a1e-b658-4b1bf82751bf") },
                    { new Guid("3f543eec-2f39-45c5-bed8-300038591367"), true, new Guid("d178e5ad-e069-40eb-97fb-9d642be81405") },
                    { new Guid("51d45523-fb26-4cb7-b554-99afb2620a43"), true, new Guid("77949a99-d744-4a1e-b658-4b1bf82751bf") },
                    { new Guid("5d942bba-c237-4a34-b719-6e43c58cc2e1"), true, new Guid("d178e5ad-e069-40eb-97fb-9d642be81405") },
                    { new Guid("5d96caa5-59a6-40b6-9206-1e2ea53a9939"), true, new Guid("77949a99-d744-4a1e-b658-4b1bf82751bf") },
                    { new Guid("733fdbf1-fc9b-46fe-ad3b-e660d6e0bc42"), true, new Guid("d178e5ad-e069-40eb-97fb-9d642be81405") },
                    { new Guid("a905fdb1-00ce-493f-8152-cf4030941cc4"), true, new Guid("77949a99-d744-4a1e-b658-4b1bf82751bf") },
                    { new Guid("ce9e2dbf-23ae-4bac-aaf2-2d4ae6fcf257"), true, new Guid("77949a99-d744-4a1e-b658-4b1bf82751bf") },
                    { new Guid("ecd53b4b-f6cb-4d6c-a7dc-8d91a50d33c5"), true, new Guid("d178e5ad-e069-40eb-97fb-9d642be81405") },
                    { new Guid("fc95b849-09aa-4ed0-a2e7-94b7d8bf6b96"), true, new Guid("77949a99-d744-4a1e-b658-4b1bf82751bf") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("2ecd077b-2f5f-4764-a796-bd38c802be9d"), null, new Guid("3225dcc5-2a90-46f1-aba9-ae32c13545c7"), "Имеющие ученую степень доктора наук" },
                    { new Guid("4d4d608b-70a1-4272-96df-5a4fd588a9bd"), null, new Guid("ad96da61-188f-499f-907c-c37f78f90c40"), "Доцент" },
                    { new Guid("9e4c9b64-b030-4b79-ac3f-7734663af844"), null, new Guid("ad96da61-188f-499f-907c-c37f78f90c40"), "Профессор" },
                    { new Guid("c53b8878-fa76-4dbc-b603-781e89c73b17"), null, new Guid("3225dcc5-2a90-46f1-aba9-ae32c13545c7"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("e90a7bcf-0189-435a-824a-48df7ffc0ebe"), null, new Guid("ad96da61-188f-499f-907c-c37f78f90c40"), "Нет" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("04cf7078-36d7-4187-8cfb-b6cdb7bc4994"), null, new Guid("0f7762e0-fd89-4c7c-a4cd-9657b7e86589"), false, true, new Guid("3a865e1c-918d-4f15-93e9-480bff352593"), null },
                    { new Guid("0d19166a-79f2-46ae-ac03-512e9ec79202"), null, new Guid("675ae90f-94d1-436b-b1da-d673498fae35"), true, true, new Guid("5d942bba-c237-4a34-b719-6e43c58cc2e1"), "ORCiD" },
                    { new Guid("1f12e963-266c-4c3d-a33a-694460d98e60"), null, new Guid("f30f38f5-a5c6-4972-9372-46885433ae7c"), false, true, new Guid("3f543eec-2f39-45c5-bed8-300038591367"), null },
                    { new Guid("267ebf71-7bc4-4429-b10b-2ad2ff6198e0"), null, new Guid("0f7762e0-fd89-4c7c-a4cd-9657b7e86589"), false, true, new Guid("a905fdb1-00ce-493f-8152-cf4030941cc4"), null },
                    { new Guid("2b0f1c72-1a82-473e-8b4c-80b28a96f384"), null, new Guid("675ae90f-94d1-436b-b1da-d673498fae35"), true, true, new Guid("3f543eec-2f39-45c5-bed8-300038591367"), "ResearcherID" },
                    { new Guid("2f80e45d-a325-4af2-8015-da09059ec958"), null, new Guid("0f7762e0-fd89-4c7c-a4cd-9657b7e86589"), false, true, new Guid("51d45523-fb26-4cb7-b554-99afb2620a43"), null },
                    { new Guid("3f30e9c1-e1aa-42a7-b3d9-e59adc69e3b3"), null, new Guid("0d710cf3-4cc4-4d56-9f3f-1072d99db8dd"), true, true, new Guid("51d45523-fb26-4cb7-b554-99afb2620a43"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("4fda8bdc-493b-4115-960a-0288b0557a27"), null, new Guid("0f7762e0-fd89-4c7c-a4cd-9657b7e86589"), false, true, new Guid("5d96caa5-59a6-40b6-9206-1e2ea53a9939"), null },
                    { new Guid("544fda97-8ca6-4dd0-b10d-b96ef9df2616"), null, new Guid("0d710cf3-4cc4-4d56-9f3f-1072d99db8dd"), true, true, new Guid("5d96caa5-59a6-40b6-9206-1e2ea53a9939"), "Результаты и выводы" },
                    { new Guid("55567e56-54ea-4832-b7f0-647bd4ffed94"), null, new Guid("675ae90f-94d1-436b-b1da-d673498fae35"), true, true, new Guid("733fdbf1-fc9b-46fe-ad3b-e660d6e0bc42"), "РИНЦ AuthorID" },
                    { new Guid("586dfb03-a66a-4715-aa9e-de190a77e5b4"), null, new Guid("0d710cf3-4cc4-4d56-9f3f-1072d99db8dd"), true, true, new Guid("fc95b849-09aa-4ed0-a2e7-94b7d8bf6b96"), "Инновационность" },
                    { new Guid("6549d6e1-69db-42c5-9a27-519b30a74150"), null, new Guid("675ae90f-94d1-436b-b1da-d673498fae35"), true, true, new Guid("2477a277-c410-4972-8425-84206a8e4972"), "ScopusID" },
                    { new Guid("6ef01f94-a7d9-46c8-b002-1b95b7cd4d96"), null, new Guid("0d710cf3-4cc4-4d56-9f3f-1072d99db8dd"), true, true, new Guid("a905fdb1-00ce-493f-8152-cf4030941cc4"), "Методология и методы, используемые в работе" },
                    { new Guid("730d4fb4-7138-491a-a954-f8de21aca718"), null, new Guid("0d710cf3-4cc4-4d56-9f3f-1072d99db8dd"), true, true, new Guid("ce9e2dbf-23ae-4bac-aaf2-2d4ae6fcf257"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("7410c62d-6ea8-4663-a4fc-8e4a3e585531"), null, new Guid("0d710cf3-4cc4-4d56-9f3f-1072d99db8dd"), true, true, new Guid("06d51838-6ad2-439e-a008-50844b44e350"), "Название работы" },
                    { new Guid("77f1c777-2f68-4434-9913-4b89e6364109"), null, new Guid("0d710cf3-4cc4-4d56-9f3f-1072d99db8dd"), true, true, new Guid("3a865e1c-918d-4f15-93e9-480bff352593"), "Актуальность конкурсной работы" },
                    { new Guid("79c897cf-ed37-4508-afc7-a7714d39059a"), null, new Guid("675ae90f-94d1-436b-b1da-d673498fae35"), true, true, new Guid("ecd53b4b-f6cb-4d6c-a7dc-8d91a50d33c5"), "Google Scholar ID" },
                    { new Guid("8283d590-42da-4f99-a5c1-49c2546f3fa7"), null, new Guid("f30f38f5-a5c6-4972-9372-46885433ae7c"), false, true, new Guid("ecd53b4b-f6cb-4d6c-a7dc-8d91a50d33c5"), null },
                    { new Guid("85682b3e-2f8d-42c4-98ab-3d5195d26dbb"), null, new Guid("f30f38f5-a5c6-4972-9372-46885433ae7c"), false, true, new Guid("733fdbf1-fc9b-46fe-ad3b-e660d6e0bc42"), null },
                    { new Guid("9fd96613-d0f8-4242-82ad-5bc449217001"), null, new Guid("0f7762e0-fd89-4c7c-a4cd-9657b7e86589"), false, true, new Guid("ce9e2dbf-23ae-4bac-aaf2-2d4ae6fcf257"), null },
                    { new Guid("b48c86cc-e829-4ddf-bbbf-312a12a62473"), null, new Guid("f30f38f5-a5c6-4972-9372-46885433ae7c"), false, true, new Guid("2477a277-c410-4972-8425-84206a8e4972"), null },
                    { new Guid("b4f14743-c472-4311-b2fd-9b5162fb3893"), null, new Guid("0f7762e0-fd89-4c7c-a4cd-9657b7e86589"), false, true, new Guid("06d51838-6ad2-439e-a008-50844b44e350"), null },
                    { new Guid("b946e01e-01d9-4568-8a2c-ba439daca9bc"), null, new Guid("0f7762e0-fd89-4c7c-a4cd-9657b7e86589"), false, true, new Guid("fc95b849-09aa-4ed0-a2e7-94b7d8bf6b96"), null },
                    { new Guid("d7f4ef26-d277-4312-b189-898450130cba"), null, new Guid("f30f38f5-a5c6-4972-9372-46885433ae7c"), false, true, new Guid("5d942bba-c237-4a34-b719-6e43c58cc2e1"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("10f835c8-a341-4a2c-80ba-5c7eb3346b0f"), new Guid("0a9d4c9a-2464-4798-9125-b448441c078b") },
                    { new Guid("10f835c8-a341-4a2c-80ba-5c7eb3346b0f"), new Guid("94889238-daa4-472d-b980-04a79817326c") },
                    { new Guid("10f835c8-a341-4a2c-80ba-5c7eb3346b0f"), new Guid("f94ae375-4838-47a0-b327-99972f643f16") },
                    { new Guid("1aecdbd8-8b25-4bdf-9dac-ea00183bf0a0"), new Guid("27cb1bb0-a577-44a2-ba02-cfccb0009266") },
                    { new Guid("1aecdbd8-8b25-4bdf-9dac-ea00183bf0a0"), new Guid("c563667c-5c6f-41b8-9713-56100ddc70a3") },
                    { new Guid("2fadb685-da85-43aa-91e7-59f3b4a2b27b"), new Guid("572940f8-ae68-4c00-b87c-898865f3d6e9") },
                    { new Guid("2fadb685-da85-43aa-91e7-59f3b4a2b27b"), new Guid("67cbf57e-ff45-41bb-96b8-35c4f9109cfa") },
                    { new Guid("2fadb685-da85-43aa-91e7-59f3b4a2b27b"), new Guid("9ef02c34-be61-4dc3-a359-d65c3d9a63a1") },
                    { new Guid("2fadb685-da85-43aa-91e7-59f3b4a2b27b"), new Guid("9f9b33a8-7d8d-49c3-96fa-f94a69ad53e6") },
                    { new Guid("2fadb685-da85-43aa-91e7-59f3b4a2b27b"), new Guid("a6eca8ff-eccc-4259-bdc3-62035c774379") },
                    { new Guid("3c50495c-7355-482f-8661-dc057d347c9c"), new Guid("260401eb-4ea3-404c-9160-1ea5701488ee") },
                    { new Guid("3c50495c-7355-482f-8661-dc057d347c9c"), new Guid("321af304-c21f-49eb-b24d-bf82ba88ba3b") },
                    { new Guid("3c50495c-7355-482f-8661-dc057d347c9c"), new Guid("94889238-daa4-472d-b980-04a79817326c") },
                    { new Guid("3c50495c-7355-482f-8661-dc057d347c9c"), new Guid("afea940d-8161-4a59-90d5-3d3273eae226") },
                    { new Guid("3c50495c-7355-482f-8661-dc057d347c9c"), new Guid("dae08794-bece-40a9-85eb-5d5606887217") },
                    { new Guid("3c50495c-7355-482f-8661-dc057d347c9c"), new Guid("f0d843ff-4512-4979-b993-3313ea70b33f") },
                    { new Guid("3c50495c-7355-482f-8661-dc057d347c9c"), new Guid("f94ae375-4838-47a0-b327-99972f643f16") },
                    { new Guid("405bae2d-7ef7-4df6-8c86-3d44e1e7bc20"), new Guid("0a9d4c9a-2464-4798-9125-b448441c078b") },
                    { new Guid("405bae2d-7ef7-4df6-8c86-3d44e1e7bc20"), new Guid("5ddaa699-f280-4443-bf85-f005ddc85980") },
                    { new Guid("405bae2d-7ef7-4df6-8c86-3d44e1e7bc20"), new Guid("e52c11ae-7053-4688-88d3-51272f73375b") },
                    { new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863"), new Guid("51f83077-5e1f-427e-a828-3923b851b857") },
                    { new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863"), new Guid("6122976c-d164-498b-91b9-077b1825fd9d") },
                    { new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863"), new Guid("a978471f-c1ed-43ea-9975-834543c6a903") },
                    { new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863"), new Guid("bf94bf1d-f6af-4e20-83f1-1357cf6e1502") },
                    { new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863"), new Guid("c14b527e-2211-4b69-985b-1517c767a397") },
                    { new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863"), new Guid("d226ce08-6ea0-4702-bca7-c73831a8e9dd") },
                    { new Guid("73c4e5dd-55be-43ac-87a9-e15ee49aa863"), new Guid("def20525-68cc-45e9-9679-c1bb60949ee5") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("07ecda91-6441-45e7-976b-231b69462d13"), new Guid("98825df4-3947-445c-99d6-8405836664fb"), null, "Исполнитель" },
                    { new Guid("081a6446-05ac-4ec6-b451-ac383868b587"), new Guid("eed2cd7c-4970-418a-9509-3bdb6e39ca27"), null, "Нет" },
                    { new Guid("1cd6c42d-3d31-45d6-acb4-44378b3a207c"), new Guid("41cecd7e-7567-4c74-99a5-4e3c8407bdad"), null, "База данных" },
                    { new Guid("239edaf9-9fec-44e3-9386-628a4ff32422"), new Guid("eed2cd7c-4970-418a-9509-3bdb6e39ca27"), null, "Да" },
                    { new Guid("308f0ca3-46e5-4f6b-895d-e674de0e653c"), new Guid("6de112fe-8364-4bf0-bcb4-56207d88ddbb"), null, "Русский" },
                    { new Guid("47b8e10f-6ed9-42cd-b1e6-7e2e01c53a36"), new Guid("6de112fe-8364-4bf0-bcb4-56207d88ddbb"), null, "Иностранный" },
                    { new Guid("47d064eb-360d-4bc7-951c-455d19a37607"), new Guid("f0c907b5-272e-41c3-bb1b-91392e904ff2"), null, "Региональный" },
                    { new Guid("4912a8d1-8142-4eec-ac92-e74fc0374d12"), new Guid("41cecd7e-7567-4c74-99a5-4e3c8407bdad"), null, "Полезная модель" },
                    { new Guid("4a37f2f6-e655-42d3-a277-6bcd03ecae3f"), new Guid("7d19e936-0e12-41b1-9793-edb091e85fc3"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("5a0bd16d-6a39-47b5-82c7-f7f6d89def76"), new Guid("7068312c-4581-4f1c-8f88-000837824e5f"), null, "Полезная модель" },
                    { new Guid("5ce64f80-90ea-43e9-add7-65ae97294e1d"), new Guid("7d19e936-0e12-41b1-9793-edb091e85fc3"), null, "Монография" },
                    { new Guid("7a549a00-bda6-4e6c-9664-b58af202073f"), new Guid("7068312c-4581-4f1c-8f88-000837824e5f"), null, "Изобретение" },
                    { new Guid("84333566-aebe-4b7b-a18f-c19a79869789"), new Guid("7068312c-4581-4f1c-8f88-000837824e5f"), null, "База данных" },
                    { new Guid("9f9f3943-0ae5-4b55-ad66-732739832fb9"), new Guid("7d19e936-0e12-41b1-9793-edb091e85fc3"), null, "Учебник" },
                    { new Guid("b26198e5-7651-4cda-a416-79ac26185863"), new Guid("172457ad-37f5-4a6f-9b27-0a6b267631cc"), null, "Лабораторные" },
                    { new Guid("c8697921-008c-4116-81d1-1bcdc17a5570"), new Guid("41cecd7e-7567-4c74-99a5-4e3c8407bdad"), null, "Изобретение" },
                    { new Guid("c879b5b4-4ba3-45ce-b107-fb36811ac941"), new Guid("98825df4-3947-445c-99d6-8405836664fb"), null, "Руководитель" },
                    { new Guid("e0a62dd2-e2a8-4965-a75a-801be5064d10"), new Guid("172457ad-37f5-4a6f-9b27-0a6b267631cc"), null, "Лекции" },
                    { new Guid("e6ef9d48-b22d-44b8-9159-5de9a2ba0254"), new Guid("f0c907b5-272e-41c3-bb1b-91392e904ff2"), null, "Международный" },
                    { new Guid("f4d2d19b-094a-4dbb-b0d6-b3f607fdfd6f"), new Guid("f0c907b5-272e-41c3-bb1b-91392e904ff2"), null, "Всероссийский" }
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
