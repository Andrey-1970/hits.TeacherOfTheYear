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
                    { new Guid("137a5e2c-c6b4-4fe4-812d-3a3a21575362"), 1, "В ожидании заполнения" },
                    { new Guid("8b7cfc2b-227a-4f01-864a-e05d0d16e5a1"), 6, "Оценена" },
                    { new Guid("9b40b5ce-691f-45b5-ab1c-88413cc57b37"), 2, "В ожидании рассмотрения" },
                    { new Guid("c128792d-4c06-4f8e-af45-a64ef519780b"), 4, "Одобрена" },
                    { new Guid("c181eb35-9529-4d0c-bd62-e70528658e53"), 3, "В процессе рассмотрения" },
                    { new Guid("dde2fa72-ef9a-4e4b-b81e-2cc0ba75efcf"), 5, "Отклонена" }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("69c6c4d8-f0f8-40c8-9841-b8bba0b50bc8"), "Деятельность", 4 },
                    { new Guid("87123e7d-5118-421f-b5a0-ccfde837584b"), "Деятельность", 5 },
                    { new Guid("92604528-93a4-4da7-87dc-0994b986fd1d"), "Профессиональное развитие", 3 },
                    { new Guid("a53608f1-ae73-4fc7-808d-58b423dab7c6"), "Категория участников", 2 },
                    { new Guid("bc88acd8-7e71-499c-83c0-e08e597a7ff6"), "Общая информация", 1 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("211fd89a-4ff7-4818-a3df-1193593e4a98"), "Инновационная и иная деятельность", 6 },
                    { new Guid("a9314666-f107-4aea-b355-49b3b5b85a9a"), "Профессиональные показатели", 4 },
                    { new Guid("ae3a47b4-c552-4c5e-bd9e-888044fe1ed3"), "Конкурсная работа", 7 },
                    { new Guid("b4a7bedd-e745-4b41-b8a1-447e2bd15985"), "Методическая деятельность", 3 },
                    { new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3"), "Образовательная деятельность", 2 },
                    { new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5"), "Основной", 1 },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), "Научно-исследовательская деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("8f9dc60d-5b81-48a1-a515-5d0f9bc53eb7"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("b6a38484-db63-494c-bf61-84a82b230f8f"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("19da035a-5700-41ce-afab-d0a43b7b4abe"), "User 1", "admin@mail.ru" },
                    { new Guid("e9932da7-4de9-427a-ad28-48466e4a726e"), "User 2", "user@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3d876c9d-62dd-4294-ba68-8ab7322ee3b4"), "DateTime" },
                    { new Guid("5b62fd88-5467-447f-8707-ad4e2254c62d"), "bool" },
                    { new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927"), "int" },
                    { new Guid("a8702e10-213e-4871-96d5-a77fe88e1162"), "string" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("69c6c4d8-f0f8-40c8-9841-b8bba0b50bc8"), new Guid("8f9dc60d-5b81-48a1-a515-5d0f9bc53eb7") },
                    { new Guid("87123e7d-5118-421f-b5a0-ccfde837584b"), new Guid("b6a38484-db63-494c-bf61-84a82b230f8f") },
                    { new Guid("92604528-93a4-4da7-87dc-0994b986fd1d"), new Guid("8f9dc60d-5b81-48a1-a515-5d0f9bc53eb7") },
                    { new Guid("92604528-93a4-4da7-87dc-0994b986fd1d"), new Guid("b6a38484-db63-494c-bf61-84a82b230f8f") },
                    { new Guid("a53608f1-ae73-4fc7-808d-58b423dab7c6"), new Guid("8f9dc60d-5b81-48a1-a515-5d0f9bc53eb7") },
                    { new Guid("a53608f1-ae73-4fc7-808d-58b423dab7c6"), new Guid("b6a38484-db63-494c-bf61-84a82b230f8f") },
                    { new Guid("bc88acd8-7e71-499c-83c0-e08e597a7ff6"), new Guid("8f9dc60d-5b81-48a1-a515-5d0f9bc53eb7") },
                    { new Guid("bc88acd8-7e71-499c-83c0-e08e597a7ff6"), new Guid("b6a38484-db63-494c-bf61-84a82b230f8f") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0ed4fde5-f504-478b-990e-783b634aa2b8"), new Guid("a53608f1-ae73-4fc7-808d-58b423dab7c6"), null, true, "Название конкурсной работы", 14, "Введите название своей конкурсной работы", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("101ff47a-a556-435e-8394-1eaf1ea307c9"), new Guid("69c6c4d8-f0f8-40c8-9841-b8bba0b50bc8"), null, true, "Защитившиеся магистры", 23, "Введите количество", new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("151544da-b9e2-44aa-9704-fb895aa940ca"), new Guid("bc88acd8-7e71-499c-83c0-e08e597a7ff6"), null, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("30aac708-467d-4ec4-8b54-9b483fb71e47"), new Guid("a53608f1-ae73-4fc7-808d-58b423dab7c6"), null, true, "Ученое звание", 16, "Выберите ученое звание", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("3afdf237-9bf7-48da-86e6-8c14bd12bb7e"), new Guid("bc88acd8-7e71-499c-83c0-e08e597a7ff6"), null, true, "Электронная почта", 5, "user@example.com", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("3b87ddd6-c491-4aaf-91eb-cf280c219179"), new Guid("bc88acd8-7e71-499c-83c0-e08e597a7ff6"), null, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("4207da50-f403-49eb-a5c6-7c8d2137ee12"), new Guid("69c6c4d8-f0f8-40c8-9841-b8bba0b50bc8"), "Руководство дипломными проектами за предыдущий учебный год", true, "Защитившиеся бакалавры", 21, "Введите количество", new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("445884e2-31fa-4f47-be1d-eabcef1c5e1c"), new Guid("a53608f1-ae73-4fc7-808d-58b423dab7c6"), null, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 13, "Выберите категорию участника конкруса", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("477d1793-2e3f-4aab-b852-882820bdfdb2"), new Guid("87123e7d-5118-421f-b5a0-ccfde837584b"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", true, "Защитившиеся кандидаты наук", 24, "Введите количество", new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("50fe68a7-27f7-4228-9e27-3c5ccf682656"), new Guid("69c6c4d8-f0f8-40c8-9841-b8bba0b50bc8"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", true, "Защитившиеся кадидаты наук", 19, "Введите количество", new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("5813bae4-e7de-4cf6-804d-08f2d5463032"), new Guid("a53608f1-ae73-4fc7-808d-58b423dab7c6"), null, true, "Научная специальность (по классификации ВАК)", 18, "Введите научную специальность (по классификации ВАК)", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("69020fa3-26f4-4d08-81bf-4b23f40f56ee"), new Guid("69c6c4d8-f0f8-40c8-9841-b8bba0b50bc8"), null, true, "Защитившиеся доктора наук", 20, "Введите количество", new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("69a9d173-0a07-4437-8d36-d13acadc433e"), new Guid("87123e7d-5118-421f-b5a0-ccfde837584b"), null, true, "Защитившиеся доктора наук", 25, "Введите количество", new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("76ac16dd-2b7f-4e7d-9fb0-f68c5dc592e0"), new Guid("bc88acd8-7e71-499c-83c0-e08e597a7ff6"), null, true, "Дата рождения", 2, "01.01.2000", new Guid("3d876c9d-62dd-4294-ba68-8ab7322ee3b4") },
                    { new Guid("93901780-7992-4324-ae0f-880a6f5d2f47"), new Guid("a53608f1-ae73-4fc7-808d-58b423dab7c6"), null, true, "Ученая степень", 17, "Выберите ученую степень", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("97a67a1f-1ba2-49c7-bc6d-8342f32e8cf3"), new Guid("a53608f1-ae73-4fc7-808d-58b423dab7c6"), null, true, "Направление конкурса", 12, "Выберите направление конкурса", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("ad023554-0e57-434a-8a91-f3d1cd528a09"), new Guid("bc88acd8-7e71-499c-83c0-e08e597a7ff6"), null, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("b875e9a9-f79f-40dd-b178-c05c36c4d27f"), new Guid("a53608f1-ae73-4fc7-808d-58b423dab7c6"), null, true, "Ссылка на конкурсную работу", 15, "Введите ссылку своей конкурсной работы", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("c1b7620b-2084-4f83-bd8c-377f0cecd5d4"), new Guid("69c6c4d8-f0f8-40c8-9841-b8bba0b50bc8"), null, true, "Защитившиеся специалисты", 22, "Введите количество", new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("d17c9b0e-35f5-4c5e-8ac5-0ecb31bf26eb"), new Guid("bc88acd8-7e71-499c-83c0-e08e597a7ff6"), null, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("e0270bc1-1f27-488f-90ae-cc1334cc7fdf"), new Guid("bc88acd8-7e71-499c-83c0-e08e597a7ff6"), null, true, "Место работы/учебы", 6, "Название организации", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("f33dce84-be2b-4663-975a-597df157d73c"), new Guid("bc88acd8-7e71-499c-83c0-e08e597a7ff6"), null, true, "Дополнительная информация", 11, "Пример", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("f640ad32-3192-4856-ab02-ad0dc8674af5"), new Guid("bc88acd8-7e71-499c-83c0-e08e597a7ff6"), null, true, "Должность", 9, "Введите свою должность в организации", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("f7b4bc3a-8aae-4701-acbf-f87ecd7c3029"), new Guid("bc88acd8-7e71-499c-83c0-e08e597a7ff6"), null, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("f816f7e0-a764-414b-8827-cbf5cf0f0f7d"), new Guid("bc88acd8-7e71-499c-83c0-e08e597a7ff6"), null, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("211fd89a-4ff7-4818-a3df-1193593e4a98"), new Guid("b6a38484-db63-494c-bf61-84a82b230f8f") },
                    { new Guid("a9314666-f107-4aea-b355-49b3b5b85a9a"), new Guid("8f9dc60d-5b81-48a1-a515-5d0f9bc53eb7") },
                    { new Guid("ae3a47b4-c552-4c5e-bd9e-888044fe1ed3"), new Guid("8f9dc60d-5b81-48a1-a515-5d0f9bc53eb7") },
                    { new Guid("ae3a47b4-c552-4c5e-bd9e-888044fe1ed3"), new Guid("b6a38484-db63-494c-bf61-84a82b230f8f") },
                    { new Guid("b4a7bedd-e745-4b41-b8a1-447e2bd15985"), new Guid("8f9dc60d-5b81-48a1-a515-5d0f9bc53eb7") },
                    { new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3"), new Guid("8f9dc60d-5b81-48a1-a515-5d0f9bc53eb7") },
                    { new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5"), new Guid("8f9dc60d-5b81-48a1-a515-5d0f9bc53eb7") },
                    { new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5"), new Guid("b6a38484-db63-494c-bf61-84a82b230f8f") },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), new Guid("b6a38484-db63-494c-bf61-84a82b230f8f") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("068b44e7-b1a4-465b-94ac-c4b311922322"), new Guid("87123e7d-5118-421f-b5a0-ccfde837584b"), false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("075fff3c-a7ef-428b-b211-355038fb5646"), new Guid("87123e7d-5118-421f-b5a0-ccfde837584b"), true, "Персональные идентификаторы и показатели", 10 },
                    { new Guid("1acbf44b-5fa7-4ef8-99bc-5db4bc523a14"), new Guid("69c6c4d8-f0f8-40c8-9841-b8bba0b50bc8"), false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("1ce0c445-191e-42fa-989d-cc0f6259f8c1"), new Guid("87123e7d-5118-421f-b5a0-ccfde837584b"), false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("2d90a9a6-f608-4de4-bac8-cbace44d6a14"), new Guid("87123e7d-5118-421f-b5a0-ccfde837584b"), false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("509e5c49-cc9a-4a4b-9443-da813a84fbc8"), new Guid("69c6c4d8-f0f8-40c8-9841-b8bba0b50bc8"), false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("57adaec2-aa81-4afd-8cbf-470fc58684b1"), new Guid("69c6c4d8-f0f8-40c8-9841-b8bba0b50bc8"), false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("5d1cd3f8-d0fc-4815-9502-0254d0a2127c"), new Guid("87123e7d-5118-421f-b5a0-ccfde837584b"), false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("92022fd9-e92e-46fd-9462-f69f76d86192"), new Guid("92604528-93a4-4da7-87dc-0994b986fd1d"), false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("93ec5328-46e7-4e28-94cd-20e4326dc3d5"), new Guid("69c6c4d8-f0f8-40c8-9841-b8bba0b50bc8"), false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("d0b6d7c2-db9b-47d5-b6f1-cd7e57558c05"), new Guid("92604528-93a4-4da7-87dc-0994b986fd1d"), false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("f031480a-cd5f-4339-88ff-8a53cd78d5fc"), new Guid("69c6c4d8-f0f8-40c8-9841-b8bba0b50bc8"), false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("f20d99eb-6325-420b-8f91-054d796bac50"), new Guid("69c6c4d8-f0f8-40c8-9841-b8bba0b50bc8"), false, "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0195a14e-d898-43a7-ac84-c619c77ede74"), true, "Вид", 1, new Guid("068b44e7-b1a4-465b-94ac-c4b311922322"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("02e5cc48-6ff5-4273-b4b1-3b13009830ec"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("2d90a9a6-f608-4de4-bac8-cbace44d6a14"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("038a60b5-732c-4c83-aa37-e1e510dcb43d"), false, "Соавторы", 3, new Guid("f20d99eb-6325-420b-8f91-054d796bac50"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("05632b11-f8fa-4054-99ef-72565e446f80"), true, "Вид (лекции, лабораторные)", 2, new Guid("93ec5328-46e7-4e28-94cd-20e4326dc3d5"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("122de54f-7402-483e-8d0c-cec94eceb021"), true, "Год", 3, new Guid("57adaec2-aa81-4afd-8cbf-470fc58684b1"), new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("170f068e-8435-482a-a82f-3b548a7f2dbd"), true, "Название организации/должность/ставка", 1, new Guid("f031480a-cd5f-4339-88ff-8a53cd78d5fc"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("255e216d-9eb7-465d-834b-07a34bea975b"), true, "Название организации в которую внедрена разработка", 3, new Guid("1ce0c445-191e-42fa-989d-cc0f6259f8c1"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("25849ce2-029d-48ec-9133-31125b7ed7a1"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("57adaec2-aa81-4afd-8cbf-470fc58684b1"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("300f1cba-7187-450e-9aeb-7e96fabb834a"), true, "Издательство, год", 6, new Guid("f20d99eb-6325-420b-8f91-054d796bac50"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("308387c2-1959-43dc-9f51-c6e4cbfaa61c"), true, "Название дисциплины", 1, new Guid("93ec5328-46e7-4e28-94cd-20e4326dc3d5"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("30ee05e8-ab13-4cdc-a4bf-ef27a9f67226"), true, "Ссылка на платформу", 3, new Guid("1acbf44b-5fa7-4ef8-99bc-5db4bc523a14"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("33c4a5f3-3731-4d4d-bbd5-7cfd4b551647"), true, "Статус конкурса", 3, new Guid("d0b6d7c2-db9b-47d5-b6f1-cd7e57558c05"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("341217d0-5dee-4fc7-8783-7bed4f3d2a91"), true, "Наименование курса", 1, new Guid("509e5c49-cc9a-4a4b-9443-da813a84fbc8"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("3850881e-5f56-43a7-9dc5-b9e48d1a9b48"), false, "Идентификатор", 2, new Guid("075fff3c-a7ef-428b-b211-355038fb5646"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("3b2a5720-e278-4e22-ab45-f686c4b23660"), true, "Вид", 1, new Guid("1ce0c445-191e-42fa-989d-cc0f6259f8c1"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("41265bc0-13cb-4627-b372-d90724ee42dd"), true, "Год получения документа", 2, new Guid("92022fd9-e92e-46fd-9462-f69f76d86192"), new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("414f9fdb-4b01-4290-b71b-5ef69a23eac0"), true, "Соавторы", 2, new Guid("1acbf44b-5fa7-4ef8-99bc-5db4bc523a14"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("428bab31-5ade-4442-a96f-81f0f4be720b"), true, "Статус (руководитель/исполнитель)", 4, new Guid("5d1cd3f8-d0fc-4815-9502-0254d0a2127c"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("49d61aea-6def-487a-93d0-8bd51c808325"), true, "Название НИР/НИОКР", 1, new Guid("5d1cd3f8-d0fc-4815-9502-0254d0a2127c"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("581ee557-3db2-4231-8a9b-8bdf2d2afa05"), false, "Количество цитирований", 4, new Guid("075fff3c-a7ef-428b-b211-355038fb5646"), new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("5a1b2496-2c20-4309-9c01-363cabfce35b"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("f031480a-cd5f-4339-88ff-8a53cd78d5fc"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("64c95133-b80f-427b-a4e9-60f351347a8c"), true, "Год", 1, new Guid("d0b6d7c2-db9b-47d5-b6f1-cd7e57558c05"), new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("721d79ea-ebf3-4d18-9d45-6987933dd569"), true, "Соавторы", 2, new Guid("2d90a9a6-f608-4de4-bac8-cbace44d6a14"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("7b6fc0c6-2dbe-4852-8b12-390040c253f5"), true, "ФИО", 1, new Guid("57adaec2-aa81-4afd-8cbf-470fc58684b1"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("7f6b715f-8679-4c8f-b7ee-64e924aef0de"), true, "Награда", 4, new Guid("d0b6d7c2-db9b-47d5-b6f1-cd7e57558c05"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("7fe231c5-c678-4621-8c5b-3a8a6a5d69c4"), true, "Название курса", 1, new Guid("1acbf44b-5fa7-4ef8-99bc-5db4bc523a14"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("806323cb-5308-47db-9a83-f21f1591cfc8"), true, "Ссылка", 5, new Guid("d0b6d7c2-db9b-47d5-b6f1-cd7e57558c05"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("83b5b158-c291-43f6-bf72-35e4767709d8"), true, "Итого (час.)", 5, new Guid("509e5c49-cc9a-4a4b-9443-da813a84fbc8"), new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("88a70167-4ffb-4db9-894b-5d32104e85ce"), true, "Название документа, реквизиты", 1, new Guid("92022fd9-e92e-46fd-9462-f69f76d86192"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("925ad953-ea2c-44a6-a96b-c7bf07f415da"), true, "Количество печатных листов", 4, new Guid("f20d99eb-6325-420b-8f91-054d796bac50"), new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("942fc849-04ab-46cc-b6ac-970cdafd3cb5"), true, "Вид деятельности (преподавательская)", 3, new Guid("f031480a-cd5f-4339-88ff-8a53cd78d5fc"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("9a9d24a6-f390-4841-802e-107529fb6bc8"), true, "Наличие грифа", 5, new Guid("f20d99eb-6325-420b-8f91-054d796bac50"), new Guid("5b62fd88-5467-447f-8707-ad4e2254c62d") },
                    { new Guid("a44567b0-4b58-4880-80f2-d68848c0e404"), true, "Название разработки", 2, new Guid("1ce0c445-191e-42fa-989d-cc0f6259f8c1"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("a8346dba-f318-4e36-aa72-0f5a2049ede1"), true, "Номер РИД", 4, new Guid("068b44e7-b1a4-465b-94ac-c4b311922322"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("b19e8530-f33f-415d-a5ee-b5a1297718c1"), false, "Количество публикаций в БАЗЕ", 3, new Guid("075fff3c-a7ef-428b-b211-355038fb5646"), new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("b752e3ba-8492-4cc4-88de-40b0046f7e06"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("509e5c49-cc9a-4a4b-9443-da813a84fbc8"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("b93ef985-406b-4944-9df0-6f70c802a643"), true, "Вид публикации", 1, new Guid("f20d99eb-6325-420b-8f91-054d796bac50"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("ba89868f-f4cb-4a4d-8584-90ae0eceac89"), true, "Лекции (час.)", 3, new Guid("509e5c49-cc9a-4a4b-9443-da813a84fbc8"), new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("bbbc9c35-c00e-4ea8-a3f7-941895b5d323"), true, "Название статьи", 1, new Guid("2d90a9a6-f608-4de4-bac8-cbace44d6a14"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("bd6f46e5-279a-4548-bcbf-289c82e3e807"), true, "Название", 2, new Guid("068b44e7-b1a4-465b-94ac-c4b311922322"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("d56983c8-abf8-4a98-9665-9dac06bad60d"), true, "Издание, год", 4, new Guid("2d90a9a6-f608-4de4-bac8-cbace44d6a14"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("d639d925-5a37-4511-a2d0-dcc4aedae45c"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("5d1cd3f8-d0fc-4815-9502-0254d0a2127c"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("db19f546-ab80-4f6c-a9e4-5be4dde60250"), true, "Название конкурса", 2, new Guid("d0b6d7c2-db9b-47d5-b6f1-cd7e57558c05"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("ddfbcc4d-136a-479f-af5e-61b5c3bf8b71"), false, "Тип идентификатора", 1, new Guid("075fff3c-a7ef-428b-b211-355038fb5646"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("dea2ce3a-b36e-4929-a2b6-185184e6a12c"), true, "Период выполнения", 3, new Guid("5d1cd3f8-d0fc-4815-9502-0254d0a2127c"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("e0c0caa3-0221-4720-8e55-366e47bdbf2c"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("57adaec2-aa81-4afd-8cbf-470fc58684b1"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("e1dd6073-1847-4a36-9705-4253d722af58"), true, "Год", 4, new Guid("1acbf44b-5fa7-4ef8-99bc-5db4bc523a14"), new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("e246a38f-59ec-4367-ad98-7baa0faa603d"), true, "Количество часов", 4, new Guid("f031480a-cd5f-4339-88ff-8a53cd78d5fc"), new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("e7e472e1-c831-4f06-aeeb-70fab1082bee"), false, "Индекс Хирша (за все время)", 5, new Guid("075fff3c-a7ef-428b-b211-355038fb5646"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("e9cd90e4-9427-467f-a93b-0948f62ddebe"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("5d1cd3f8-d0fc-4815-9502-0254d0a2127c"), new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") },
                    { new Guid("f36b960f-7f10-4811-86df-ede261dce6c4"), true, "Название", 2, new Guid("f20d99eb-6325-420b-8f91-054d796bac50"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("f6ccddbd-01e2-42db-9f90-f276d2ceda5e"), true, "ФИО соавторов", 3, new Guid("068b44e7-b1a4-465b-94ac-c4b311922322"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("f8f92e98-f906-4a39-be1c-d79685c530ab"), true, "Название конкурса/премии", 2, new Guid("57adaec2-aa81-4afd-8cbf-470fc58684b1"), new Guid("a8702e10-213e-4871-96d5-a77fe88e1162") },
                    { new Guid("fb71d8d3-490a-49da-9f7c-bf95bf2d3b9b"), true, "Практические занятия (час.)", 4, new Guid("509e5c49-cc9a-4a4b-9443-da813a84fbc8"), new Guid("67fd9dc2-131c-499f-85e4-cefdb4ae4927") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("0ed4fde5-f504-478b-990e-783b634aa2b8"), new Guid("ae3a47b4-c552-4c5e-bd9e-888044fe1ed3") },
                    { new Guid("101ff47a-a556-435e-8394-1eaf1ea307c9"), new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3") },
                    { new Guid("151544da-b9e2-44aa-9704-fb895aa940ca"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("30aac708-467d-4ec4-8b54-9b483fb71e47"), new Guid("a9314666-f107-4aea-b355-49b3b5b85a9a") },
                    { new Guid("30aac708-467d-4ec4-8b54-9b483fb71e47"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("30aac708-467d-4ec4-8b54-9b483fb71e47"), new Guid("ff833618-5fad-4038-ad97-8019a654fc43") },
                    { new Guid("3afdf237-9bf7-48da-86e6-8c14bd12bb7e"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("3b87ddd6-c491-4aaf-91eb-cf280c219179"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("4207da50-f403-49eb-a5c6-7c8d2137ee12"), new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3") },
                    { new Guid("445884e2-31fa-4f47-be1d-eabcef1c5e1c"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("477d1793-2e3f-4aab-b852-882820bdfdb2"), new Guid("ff833618-5fad-4038-ad97-8019a654fc43") },
                    { new Guid("50fe68a7-27f7-4228-9e27-3c5ccf682656"), new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3") },
                    { new Guid("5813bae4-e7de-4cf6-804d-08f2d5463032"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("69020fa3-26f4-4d08-81bf-4b23f40f56ee"), new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3") },
                    { new Guid("69a9d173-0a07-4437-8d36-d13acadc433e"), new Guid("ff833618-5fad-4038-ad97-8019a654fc43") },
                    { new Guid("76ac16dd-2b7f-4e7d-9fb0-f68c5dc592e0"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("93901780-7992-4324-ae0f-880a6f5d2f47"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("97a67a1f-1ba2-49c7-bc6d-8342f32e8cf3"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("ad023554-0e57-434a-8a91-f3d1cd528a09"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("b875e9a9-f79f-40dd-b178-c05c36c4d27f"), new Guid("ae3a47b4-c552-4c5e-bd9e-888044fe1ed3") },
                    { new Guid("c1b7620b-2084-4f83-bd8c-377f0cecd5d4"), new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3") },
                    { new Guid("d17c9b0e-35f5-4c5e-8ac5-0ecb31bf26eb"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("e0270bc1-1f27-488f-90ae-cc1334cc7fdf"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("f33dce84-be2b-4663-975a-597df157d73c"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("f640ad32-3192-4856-ab02-ad0dc8674af5"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("f7b4bc3a-8aae-4701-acbf-f87ecd7c3029"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") },
                    { new Guid("f816f7e0-a764-414b-8827-cbf5cf0f0f7d"), new Guid("dade1ccf-1ee6-4cc3-aaa1-e44d1f0c7ec5") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("211fd89a-4ff7-4818-a3df-1193593e4a98"), new Guid("068b44e7-b1a4-465b-94ac-c4b311922322") },
                    { new Guid("211fd89a-4ff7-4818-a3df-1193593e4a98"), new Guid("1ce0c445-191e-42fa-989d-cc0f6259f8c1") },
                    { new Guid("211fd89a-4ff7-4818-a3df-1193593e4a98"), new Guid("92022fd9-e92e-46fd-9462-f69f76d86192") },
                    { new Guid("a9314666-f107-4aea-b355-49b3b5b85a9a"), new Guid("92022fd9-e92e-46fd-9462-f69f76d86192") },
                    { new Guid("a9314666-f107-4aea-b355-49b3b5b85a9a"), new Guid("d0b6d7c2-db9b-47d5-b6f1-cd7e57558c05") },
                    { new Guid("b4a7bedd-e745-4b41-b8a1-447e2bd15985"), new Guid("93ec5328-46e7-4e28-94cd-20e4326dc3d5") },
                    { new Guid("b4a7bedd-e745-4b41-b8a1-447e2bd15985"), new Guid("f20d99eb-6325-420b-8f91-054d796bac50") },
                    { new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3"), new Guid("1acbf44b-5fa7-4ef8-99bc-5db4bc523a14") },
                    { new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3"), new Guid("509e5c49-cc9a-4a4b-9443-da813a84fbc8") },
                    { new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3"), new Guid("57adaec2-aa81-4afd-8cbf-470fc58684b1") },
                    { new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3"), new Guid("f031480a-cd5f-4339-88ff-8a53cd78d5fc") },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), new Guid("075fff3c-a7ef-428b-b211-355038fb5646") },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), new Guid("2d90a9a6-f608-4de4-bac8-cbace44d6a14") },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), new Guid("5d1cd3f8-d0fc-4815-9502-0254d0a2127c") },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), new Guid("d0b6d7c2-db9b-47d5-b6f1-cd7e57558c05") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0baf9e83-9036-4bf2-b8d2-9c71884d154d"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("1acbf44b-5fa7-4ef8-99bc-5db4bc523a14") },
                    { new Guid("17803e33-8c2b-4528-98f6-13a2b0a84ad6"), "EvaluateMark13", new Guid("30aac708-467d-4ec4-8b54-9b483fb71e47"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("252d996d-3f45-4357-9611-29a60b26cbe4"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("93ec5328-46e7-4e28-94cd-20e4326dc3d5") },
                    { new Guid("2a360925-fcaf-4e0c-aad8-8c3f1013e457"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("509e5c49-cc9a-4a4b-9443-da813a84fbc8") },
                    { new Guid("31127a89-ff12-4b0c-8d1f-58c5dd91b980"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("f20d99eb-6325-420b-8f91-054d796bac50") },
                    { new Guid("33636b7a-81f7-4289-88c5-579f9bda3860"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("509e5c49-cc9a-4a4b-9443-da813a84fbc8") },
                    { new Guid("33c49a6a-3817-4b42-8c45-c2f141bb976b"), "EvaluateMark4", new Guid("50fe68a7-27f7-4228-9e27-3c5ccf682656"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("500d8ec1-ee23-4d5f-b74c-bfbc6016ecb0"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("2d90a9a6-f608-4de4-bac8-cbace44d6a14") },
                    { new Guid("5693b29c-0a9c-4634-a2c9-cd94983849ed"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("1ce0c445-191e-42fa-989d-cc0f6259f8c1") },
                    { new Guid("6aae4601-567d-4cf5-be40-f52e05ac76da"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("5d1cd3f8-d0fc-4815-9502-0254d0a2127c") },
                    { new Guid("70194d43-e4ae-4098-b9b9-f58d6f6be066"), null, new Guid("b875e9a9-f79f-40dd-b178-c05c36c4d27f"), false, 10, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("739a496e-49cc-4471-9cb7-41181bd3ba41"), null, new Guid("b875e9a9-f79f-40dd-b178-c05c36c4d27f"), false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null },
                    { new Guid("7617c3ad-94c9-4ff5-99a4-9bb6006c8221"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("5d1cd3f8-d0fc-4815-9502-0254d0a2127c") },
                    { new Guid("9bcf27fd-0e4d-4d35-a763-72f71d842c11"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("92022fd9-e92e-46fd-9462-f69f76d86192") },
                    { new Guid("9e3b855b-8ac2-4dc3-b18d-80b601f0b365"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("f20d99eb-6325-420b-8f91-054d796bac50") },
                    { new Guid("a6b6dc2a-922e-47a7-a462-8d0e9868929c"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("068b44e7-b1a4-465b-94ac-c4b311922322") },
                    { new Guid("aeff2f6b-769f-4ac6-bb5f-c6cf29cb1906"), "EvaluateMark17", null, true, 5, "Баллы по базе Scopus:", 17, new Guid("075fff3c-a7ef-428b-b211-355038fb5646") },
                    { new Guid("b42d2dd4-273e-46a0-8d95-168281437e28"), "EvaluateMark3", new Guid("101ff47a-a556-435e-8394-1eaf1ea307c9"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("b84e3bce-19c8-4435-a5e5-3e1c892900b6"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("f20d99eb-6325-420b-8f91-054d796bac50") },
                    { new Guid("c40ba701-d7bc-4095-b8be-6fa31a5cb723"), "EvaluateMark5", new Guid("69020fa3-26f4-4d08-81bf-4b23f40f56ee"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("c7a31900-20ab-4393-955c-a90514a1d9bc"), "EvaluateMark19", new Guid("477d1793-2e3f-4aab-b852-882820bdfdb2"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("c8011067-db53-4541-b1b1-7497a06ae04b"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("d0b6d7c2-db9b-47d5-b6f1-cd7e57558c05") },
                    { new Guid("c8ebaf8f-b323-4826-adae-77528245f238"), "EvaluateMark18", null, true, 3, "Баллы по базе РИНЦ:", 18, new Guid("075fff3c-a7ef-428b-b211-355038fb5646") },
                    { new Guid("f31700e4-3d91-4f45-a935-de6bd9710611"), "EvaluateMark20", new Guid("69a9d173-0a07-4437-8d36-d13acadc433e"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("fb7dfe0b-aedd-4568-82ea-a1efb9818c72"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("57adaec2-aa81-4afd-8cbf-470fc58684b1") },
                    { new Guid("ffe84b57-5a03-4fc1-8db5-144afccabf4c"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("f20d99eb-6325-420b-8f91-054d796bac50") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("083a0f09-87c0-4739-b417-82c34aeb01eb"), true, new Guid("075fff3c-a7ef-428b-b211-355038fb5646") },
                    { new Guid("24be76c8-43cd-4ae2-ae3d-608ad67efddd"), true, new Guid("075fff3c-a7ef-428b-b211-355038fb5646") },
                    { new Guid("39548b71-f254-4b20-b9dd-02351c0d98ca"), true, new Guid("075fff3c-a7ef-428b-b211-355038fb5646") },
                    { new Guid("4a6328fa-97bc-408b-8ed5-7d6997ea28ff"), true, new Guid("075fff3c-a7ef-428b-b211-355038fb5646") },
                    { new Guid("797acf98-d2a3-4c48-ad8a-868e98235a57"), true, new Guid("075fff3c-a7ef-428b-b211-355038fb5646") },
                    { new Guid("ae421b9d-8ee8-41db-ab4a-74e05bdc0fb0"), true, new Guid("075fff3c-a7ef-428b-b211-355038fb5646") },
                    { new Guid("b29e47d7-af7a-4461-92fd-bdca465da002"), true, new Guid("075fff3c-a7ef-428b-b211-355038fb5646") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("29bc4e41-a0bb-4af1-8192-e2bb6293872c"), null, new Guid("30aac708-467d-4ec4-8b54-9b483fb71e47"), "Доцент" },
                    { new Guid("2e914115-59f3-48ab-a478-453b1421e9d9"), null, new Guid("445884e2-31fa-4f47-be1d-eabcef1c5e1c"), "Имеющие ученую степень доктора наук" },
                    { new Guid("40b2200e-a689-42eb-858c-92f28df299c6"), null, new Guid("97a67a1f-1ba2-49c7-bc6d-8342f32e8cf3"), "СТРОИТЕЛЬСТВО И АРХИТЕКТУРА" },
                    { new Guid("52cb6301-c4e4-4f21-9685-1d0b514d9cf6"), null, new Guid("97a67a1f-1ba2-49c7-bc6d-8342f32e8cf3"), "ЭЛЕКТРО- И ТЕПЛОЭНЕРГЕТИКА" },
                    { new Guid("6c8e1829-d1af-4794-9afa-2c9863eac7d3"), null, new Guid("445884e2-31fa-4f47-be1d-eabcef1c5e1c"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("774f557e-cc7a-43ed-8841-540947e36f70"), null, new Guid("30aac708-467d-4ec4-8b54-9b483fb71e47"), "Профессор" },
                    { new Guid("88404e7a-5b05-429d-a305-02da3b317dcc"), null, new Guid("97a67a1f-1ba2-49c7-bc6d-8342f32e8cf3"), "АРХИТЕКТУРА" },
                    { new Guid("9237aeb2-9f32-40ca-9719-edaaf312329f"), null, new Guid("97a67a1f-1ba2-49c7-bc6d-8342f32e8cf3"), "ТЕХНИКА И ТЕХНОЛОГИИ СТРОИТЕЛЬСТВА" },
                    { new Guid("b5f22941-b208-46c6-a994-c24050a168a0"), null, new Guid("97a67a1f-1ba2-49c7-bc6d-8342f32e8cf3"), "ПРИКЛАДНАЯ ГЕОЛОГИЯ, ГОРНОЕ ДЕЛО, НЕФТЕГАЗОВОЕ ДЕЛО И ГЕОДЕЗИЯ" },
                    { new Guid("e7d9272d-b3b6-45d1-8476-535cf41826bd"), null, new Guid("30aac708-467d-4ec4-8b54-9b483fb71e47"), "Нет" },
                    { new Guid("fa9f85d8-815b-41f9-8bbf-7a74d31384e5"), null, new Guid("97a67a1f-1ba2-49c7-bc6d-8342f32e8cf3"), "НЕДРОПОЛЬЗОВАНИЕ И ГОРНЫЕ НАУКИ" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("033ed5d9-21a0-417a-b21d-9f97289ed97c"), null, new Guid("ddfbcc4d-136a-479f-af5e-61b5c3bf8b71"), true, true, new Guid("39548b71-f254-4b20-b9dd-02351c0d98ca"), "РИНЦ AuthorID" },
                    { new Guid("0e271eef-145b-4780-9a0f-f6eb0870e5d1"), null, new Guid("b19e8530-f33f-415d-a5ee-b5a1297718c1"), false, true, new Guid("4a6328fa-97bc-408b-8ed5-7d6997ea28ff"), null },
                    { new Guid("1552ba58-e764-44ab-8a39-7ed90aeba4ad"), null, new Guid("581ee557-3db2-4231-8a9b-8bdf2d2afa05"), false, true, new Guid("24be76c8-43cd-4ae2-ae3d-608ad67efddd"), null },
                    { new Guid("1884c579-720b-4787-89b6-fcc4d141e87a"), null, new Guid("3850881e-5f56-43a7-9dc5-b9e48d1a9b48"), false, true, new Guid("39548b71-f254-4b20-b9dd-02351c0d98ca"), null },
                    { new Guid("1bb0f41c-ddca-44a6-a67d-89a78fcca2c9"), null, new Guid("3850881e-5f56-43a7-9dc5-b9e48d1a9b48"), false, true, new Guid("b29e47d7-af7a-4461-92fd-bdca465da002"), null },
                    { new Guid("1fdfc36d-3f37-446e-bb03-bf27570546e0"), null, new Guid("581ee557-3db2-4231-8a9b-8bdf2d2afa05"), false, true, new Guid("b29e47d7-af7a-4461-92fd-bdca465da002"), null },
                    { new Guid("290dec6f-81e1-483b-adfc-664e3740a55e"), null, new Guid("ddfbcc4d-136a-479f-af5e-61b5c3bf8b71"), true, true, new Guid("24be76c8-43cd-4ae2-ae3d-608ad67efddd"), "Количество монографий/глав в монографии" },
                    { new Guid("2d15f373-c72d-4a56-84e2-61e26d4e9f66"), null, new Guid("b19e8530-f33f-415d-a5ee-b5a1297718c1"), false, true, new Guid("24be76c8-43cd-4ae2-ae3d-608ad67efddd"), null },
                    { new Guid("2f6b678e-e1c9-429d-a667-a4de23be51be"), null, new Guid("ddfbcc4d-136a-479f-af5e-61b5c3bf8b71"), true, true, new Guid("797acf98-d2a3-4c48-ad8a-868e98235a57"), "ORCiD" },
                    { new Guid("3919c9d8-3398-47b8-a32f-0127298e3583"), null, new Guid("581ee557-3db2-4231-8a9b-8bdf2d2afa05"), true, true, new Guid("797acf98-d2a3-4c48-ad8a-868e98235a57"), null },
                    { new Guid("3e7ba431-b629-4933-95e2-1a8d14bcfe57"), null, new Guid("e7e472e1-c831-4f06-aeeb-70fab1082bee"), true, true, new Guid("797acf98-d2a3-4c48-ad8a-868e98235a57"), null },
                    { new Guid("43ec8bb4-0483-4cc5-adc4-616d55cc5fb5"), null, new Guid("3850881e-5f56-43a7-9dc5-b9e48d1a9b48"), false, true, new Guid("ae421b9d-8ee8-41db-ab4a-74e05bdc0fb0"), null },
                    { new Guid("4af78902-4426-4887-a6b1-f444f4bc3b7d"), null, new Guid("ddfbcc4d-136a-479f-af5e-61b5c3bf8b71"), true, true, new Guid("083a0f09-87c0-4739-b417-82c34aeb01eb"), "Google Scholar ID" },
                    { new Guid("4d07c980-4181-49c1-ab50-14f1de2b55e8"), null, new Guid("581ee557-3db2-4231-8a9b-8bdf2d2afa05"), false, true, new Guid("083a0f09-87c0-4739-b417-82c34aeb01eb"), null },
                    { new Guid("4d17e218-c6f6-4ba9-b0d9-c7ece5624797"), null, new Guid("b19e8530-f33f-415d-a5ee-b5a1297718c1"), false, true, new Guid("ae421b9d-8ee8-41db-ab4a-74e05bdc0fb0"), null },
                    { new Guid("4de83241-291b-4e98-a111-a507c1415649"), null, new Guid("b19e8530-f33f-415d-a5ee-b5a1297718c1"), false, true, new Guid("39548b71-f254-4b20-b9dd-02351c0d98ca"), null },
                    { new Guid("568cfc80-bd9f-483b-802f-e51fa082ebbf"), null, new Guid("581ee557-3db2-4231-8a9b-8bdf2d2afa05"), false, true, new Guid("ae421b9d-8ee8-41db-ab4a-74e05bdc0fb0"), null },
                    { new Guid("5a5596ae-a8e6-4a56-9a84-16cf23379202"), null, new Guid("e7e472e1-c831-4f06-aeeb-70fab1082bee"), false, true, new Guid("b29e47d7-af7a-4461-92fd-bdca465da002"), null },
                    { new Guid("5e3e5e90-9440-4d63-a6b6-1ae3fb23794a"), null, new Guid("b19e8530-f33f-415d-a5ee-b5a1297718c1"), false, true, new Guid("797acf98-d2a3-4c48-ad8a-868e98235a57"), null },
                    { new Guid("5ee6c37a-723a-44fb-91eb-be81714bd504"), null, new Guid("3850881e-5f56-43a7-9dc5-b9e48d1a9b48"), true, true, new Guid("24be76c8-43cd-4ae2-ae3d-608ad67efddd"), null },
                    { new Guid("74830300-e7ce-405f-92b4-4822bf6b7db4"), null, new Guid("e7e472e1-c831-4f06-aeeb-70fab1082bee"), true, true, new Guid("24be76c8-43cd-4ae2-ae3d-608ad67efddd"), null },
                    { new Guid("8417cee8-d676-4bdf-b97b-98b501ea5832"), null, new Guid("ddfbcc4d-136a-479f-af5e-61b5c3bf8b71"), true, true, new Guid("4a6328fa-97bc-408b-8ed5-7d6997ea28ff"), "Количество патентов" },
                    { new Guid("8a75955d-e344-4ddb-b443-fb792270bb81"), null, new Guid("581ee557-3db2-4231-8a9b-8bdf2d2afa05"), true, true, new Guid("4a6328fa-97bc-408b-8ed5-7d6997ea28ff"), null },
                    { new Guid("a677fad9-c395-4eac-a639-4f8d970d1e19"), null, new Guid("3850881e-5f56-43a7-9dc5-b9e48d1a9b48"), true, true, new Guid("4a6328fa-97bc-408b-8ed5-7d6997ea28ff"), null },
                    { new Guid("a8b4931b-c498-45c2-9e96-f1a61c2fe863"), null, new Guid("ddfbcc4d-136a-479f-af5e-61b5c3bf8b71"), true, true, new Guid("b29e47d7-af7a-4461-92fd-bdca465da002"), "ResearcherID" },
                    { new Guid("aa48b464-6114-4c33-b3cf-cdd1ed3830b6"), null, new Guid("581ee557-3db2-4231-8a9b-8bdf2d2afa05"), false, true, new Guid("39548b71-f254-4b20-b9dd-02351c0d98ca"), null },
                    { new Guid("aae97e1e-7ccf-4617-8f7e-fa76fda31f05"), null, new Guid("e7e472e1-c831-4f06-aeeb-70fab1082bee"), true, true, new Guid("4a6328fa-97bc-408b-8ed5-7d6997ea28ff"), null },
                    { new Guid("b07d8eaf-32c0-4476-96bf-f99460d1ef6b"), null, new Guid("3850881e-5f56-43a7-9dc5-b9e48d1a9b48"), false, true, new Guid("797acf98-d2a3-4c48-ad8a-868e98235a57"), null },
                    { new Guid("c3ab0af1-6e66-4e9f-87f8-2e492ace625d"), null, new Guid("ddfbcc4d-136a-479f-af5e-61b5c3bf8b71"), true, true, new Guid("ae421b9d-8ee8-41db-ab4a-74e05bdc0fb0"), "ScopusID" },
                    { new Guid("c3e40525-2e58-4696-9c63-a5fca88bff40"), null, new Guid("b19e8530-f33f-415d-a5ee-b5a1297718c1"), false, true, new Guid("083a0f09-87c0-4739-b417-82c34aeb01eb"), null },
                    { new Guid("d39b4cd2-3048-4ed7-9aba-594cc73a2c3f"), null, new Guid("e7e472e1-c831-4f06-aeeb-70fab1082bee"), false, true, new Guid("083a0f09-87c0-4739-b417-82c34aeb01eb"), null },
                    { new Guid("e5454521-b2ad-4e82-9ee7-53c70e778b26"), null, new Guid("b19e8530-f33f-415d-a5ee-b5a1297718c1"), false, true, new Guid("b29e47d7-af7a-4461-92fd-bdca465da002"), null },
                    { new Guid("e68a2f91-ca34-4af6-9f7d-49eb1ce6a9f9"), null, new Guid("e7e472e1-c831-4f06-aeeb-70fab1082bee"), false, true, new Guid("ae421b9d-8ee8-41db-ab4a-74e05bdc0fb0"), null },
                    { new Guid("ebb5c393-bc1c-4d5f-af59-a1055d697afc"), null, new Guid("3850881e-5f56-43a7-9dc5-b9e48d1a9b48"), false, true, new Guid("083a0f09-87c0-4739-b417-82c34aeb01eb"), null },
                    { new Guid("ed7e8765-aa56-4683-84d1-164fc483d854"), null, new Guid("e7e472e1-c831-4f06-aeeb-70fab1082bee"), false, true, new Guid("39548b71-f254-4b20-b9dd-02351c0d98ca"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("211fd89a-4ff7-4818-a3df-1193593e4a98"), new Guid("5693b29c-0a9c-4634-a2c9-cd94983849ed") },
                    { new Guid("211fd89a-4ff7-4818-a3df-1193593e4a98"), new Guid("9bcf27fd-0e4d-4d35-a763-72f71d842c11") },
                    { new Guid("211fd89a-4ff7-4818-a3df-1193593e4a98"), new Guid("a6b6dc2a-922e-47a7-a462-8d0e9868929c") },
                    { new Guid("a9314666-f107-4aea-b355-49b3b5b85a9a"), new Guid("17803e33-8c2b-4528-98f6-13a2b0a84ad6") },
                    { new Guid("a9314666-f107-4aea-b355-49b3b5b85a9a"), new Guid("9bcf27fd-0e4d-4d35-a763-72f71d842c11") },
                    { new Guid("a9314666-f107-4aea-b355-49b3b5b85a9a"), new Guid("c8011067-db53-4541-b1b1-7497a06ae04b") },
                    { new Guid("ae3a47b4-c552-4c5e-bd9e-888044fe1ed3"), new Guid("70194d43-e4ae-4098-b9b9-f58d6f6be066") },
                    { new Guid("ae3a47b4-c552-4c5e-bd9e-888044fe1ed3"), new Guid("739a496e-49cc-4471-9cb7-41181bd3ba41") },
                    { new Guid("b4a7bedd-e745-4b41-b8a1-447e2bd15985"), new Guid("252d996d-3f45-4357-9611-29a60b26cbe4") },
                    { new Guid("b4a7bedd-e745-4b41-b8a1-447e2bd15985"), new Guid("31127a89-ff12-4b0c-8d1f-58c5dd91b980") },
                    { new Guid("b4a7bedd-e745-4b41-b8a1-447e2bd15985"), new Guid("9e3b855b-8ac2-4dc3-b18d-80b601f0b365") },
                    { new Guid("b4a7bedd-e745-4b41-b8a1-447e2bd15985"), new Guid("b84e3bce-19c8-4435-a5e5-3e1c892900b6") },
                    { new Guid("b4a7bedd-e745-4b41-b8a1-447e2bd15985"), new Guid("ffe84b57-5a03-4fc1-8db5-144afccabf4c") },
                    { new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3"), new Guid("0baf9e83-9036-4bf2-b8d2-9c71884d154d") },
                    { new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3"), new Guid("2a360925-fcaf-4e0c-aad8-8c3f1013e457") },
                    { new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3"), new Guid("33636b7a-81f7-4289-88c5-579f9bda3860") },
                    { new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3"), new Guid("33c49a6a-3817-4b42-8c45-c2f141bb976b") },
                    { new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3"), new Guid("b42d2dd4-273e-46a0-8d95-168281437e28") },
                    { new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3"), new Guid("c40ba701-d7bc-4095-b8be-6fa31a5cb723") },
                    { new Guid("b716fc97-91d3-441a-8bce-59f9231a58f3"), new Guid("fb7dfe0b-aedd-4568-82ea-a1efb9818c72") },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), new Guid("17803e33-8c2b-4528-98f6-13a2b0a84ad6") },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), new Guid("500d8ec1-ee23-4d5f-b74c-bfbc6016ecb0") },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), new Guid("6aae4601-567d-4cf5-be40-f52e05ac76da") },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), new Guid("7617c3ad-94c9-4ff5-99a4-9bb6006c8221") },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), new Guid("aeff2f6b-769f-4ac6-bb5f-c6cf29cb1906") },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), new Guid("c7a31900-20ab-4393-955c-a90514a1d9bc") },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), new Guid("c8011067-db53-4541-b1b1-7497a06ae04b") },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), new Guid("c8ebaf8f-b323-4826-adae-77528245f238") },
                    { new Guid("ff833618-5fad-4038-ad97-8019a654fc43"), new Guid("f31700e4-3d91-4f45-a935-de6bd9710611") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("110e2456-c69b-4066-8c3c-174817cce245"), new Guid("05632b11-f8fa-4054-99ef-72565e446f80"), null, "Лабораторные" },
                    { new Guid("369ce779-d1f7-45ef-be26-f3e78d79e867"), new Guid("b93ef985-406b-4944-9df0-6f70c802a643"), null, "Монография" },
                    { new Guid("43b06e1f-dbfa-489f-b9af-5f790a242c4e"), new Guid("b93ef985-406b-4944-9df0-6f70c802a643"), null, "Учебник" },
                    { new Guid("493f5cfb-638e-490c-813e-1191b982aef1"), new Guid("b93ef985-406b-4944-9df0-6f70c802a643"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("495ed871-9bb0-4f24-b1c5-9e1a3db8ae59"), new Guid("3b2a5720-e278-4e22-ab45-f686c4b23660"), null, "Полезная модель" },
                    { new Guid("7bbe59b1-1027-423c-b5de-bd873be5a8b9"), new Guid("33c4a5f3-3731-4d4d-bbd5-7cfd4b551647"), null, "Всероссийский" },
                    { new Guid("8cd8eeae-1e1d-4929-9228-a800c0e1387c"), new Guid("428bab31-5ade-4442-a96f-81f0f4be720b"), null, "Исполнитель" },
                    { new Guid("9bc3a100-3ce6-4bc6-ba7b-dfc273b7001b"), new Guid("33c4a5f3-3731-4d4d-bbd5-7cfd4b551647"), null, "Региональный" },
                    { new Guid("9fbeedb8-535f-4e69-b74f-47a40d62acaf"), new Guid("3b2a5720-e278-4e22-ab45-f686c4b23660"), null, "База данных" },
                    { new Guid("a7a4a998-d6de-4519-bb14-4abce446944f"), new Guid("0195a14e-d898-43a7-ac84-c619c77ede74"), null, "База данных" },
                    { new Guid("bdb9edc3-1042-46fb-bc42-492f98f3e0bb"), new Guid("33c4a5f3-3731-4d4d-bbd5-7cfd4b551647"), null, "Международный" },
                    { new Guid("be543eb2-a016-4f04-9c19-c0a0e20e1c61"), new Guid("05632b11-f8fa-4054-99ef-72565e446f80"), null, "Лекции" },
                    { new Guid("cf2720aa-4f3b-47c6-bd25-4971feaab307"), new Guid("0195a14e-d898-43a7-ac84-c619c77ede74"), null, "Полезная модель" },
                    { new Guid("d0c95176-f836-469d-90ab-2e444a4e54fe"), new Guid("0195a14e-d898-43a7-ac84-c619c77ede74"), null, "Изобретение" },
                    { new Guid("da19f358-2045-4bc6-8ccb-91cd27b787ee"), new Guid("3b2a5720-e278-4e22-ab45-f686c4b23660"), null, "Изобретение" },
                    { new Guid("e62fe851-d3f3-45b5-84a5-4670e686fcd1"), new Guid("428bab31-5ade-4442-a96f-81f0f4be720b"), null, "Руководитель" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_ApplicationStatusId",
                table: "ApplicationForms",
                column: "ApplicationStatusId");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Rows");

            migrationBuilder.DropTable(
                name: "MarkBlocks");

            migrationBuilder.DropTable(
                name: "ApplicationForms");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Columns");

            migrationBuilder.DropTable(
                name: "ApplicationStatuses");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "ValueTypes");

            migrationBuilder.DropTable(
                name: "EditBlocks");
        }
    }
}
