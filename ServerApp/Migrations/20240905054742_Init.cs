using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EditBlocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditBlocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarkBlocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkBlocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Username = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ValueTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValueTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    IsPrefilled = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisplayedOnVotingPage = table.Column<bool>(type: "boolean", nullable: false),
                    EditBlockId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    EditBlocksId = table.Column<Guid>(type: "uuid", nullable: false),
                    TracksId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    MarkBlocksId = table.Column<Guid>(type: "uuid", nullable: false),
                    TracksId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicationStatusId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    TrackId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    ReviewerId = table.Column<Guid>(type: "uuid", nullable: true)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(400)", maxLength: 400, nullable: true),
                    Placeholder = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    EditGroup = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    IsRequired = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisplayedOnVotingPage = table.Column<bool>(type: "boolean", nullable: false),
                    ValueTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    EditBlockId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    IsRequired = table.Column<bool>(type: "boolean", nullable: false),
                    ValueTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    TableId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    MarkBlocksId = table.Column<Guid>(type: "uuid", nullable: false),
                    TablesId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsPrefilled = table.Column<bool>(type: "boolean", nullable: false),
                    TableId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    Commentary = table.Column<string>(type: "character varying(2048)", maxLength: 2048, nullable: true),
                    MarkBlockId = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uuid", nullable: false),
                    EditBlockId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    VoteTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    VoterId = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicationFormId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    FieldsId = table.Column<Guid>(type: "uuid", nullable: false),
                    MarkBlocksId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ApplicationId = table.Column<Guid>(type: "uuid", nullable: false),
                    FieldId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    IsAuto = table.Column<bool>(type: "boolean", nullable: false),
                    MaxValue = table.Column<int>(type: "integer", nullable: false),
                    FieldId = table.Column<Guid>(type: "uuid", nullable: true),
                    TableId = table.Column<Guid>(type: "uuid", nullable: true),
                    EvaluationMethodName = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: true)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    FieldId = table.Column<Guid>(type: "uuid", nullable: true),
                    ColumnId = table.Column<Guid>(type: "uuid", nullable: true)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    IsPrefilled = table.Column<bool>(type: "boolean", nullable: false),
                    Disable = table.Column<bool>(type: "boolean", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uuid", nullable: true),
                    RowId = table.Column<Guid>(type: "uuid", nullable: false),
                    ColumnId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    MarkBlocksId = table.Column<Guid>(type: "uuid", nullable: false),
                    MarksId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Value = table.Column<int>(type: "integer", maxLength: 255, nullable: true),
                    ApplicationId = table.Column<Guid>(type: "uuid", nullable: false),
                    MarkId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    { new Guid("034854a7-e73b-46f3-a6c8-ffd65fc2d540"), 6, "Оценена" },
                    { new Guid("504571af-a710-4da7-bfa9-7560d37d6511"), 1, "В ожидании заполнения" },
                    { new Guid("6c2e652c-25a4-4f6b-881e-5401d2944a14"), 5, "Отклонена" },
                    { new Guid("92d4cb1e-1dc3-4cc2-8b74-f1e229f83552"), 4, "Одобрена" },
                    { new Guid("baa1639f-fce8-469f-a4b2-33de27bc8786"), 3, "В процессе рассмотрения" },
                    { new Guid("f8dcd398-6eb8-4ea3-a138-0c2e83d1613d"), 2, "В ожидании рассмотрения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b45d484-52a5-4bb0-990a-7a041bfb4939", null, "Voter", "VOTER" },
                    { "0dd07067-0937-4611-8331-65a826236f35", null, "Expert", "EXPERT" },
                    { "8b484d24-249e-4faf-b244-a6eafcfa1fe3", null, "Participant", "PARTICIPANT" },
                    { "c36b9c06-e0a7-48ed-9316-6d394974f58f", null, "Admin", "ADMIN" },
                    { "d9cd8638-4c27-4d5c-88b4-80adad8f08b7", null, "Organiser", "ORGANISER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("11c2f625-8df9-4cc2-ac16-5b44c2b56857"), "Строительство и архитектура", 1 },
                    { new Guid("6a5b6735-8b5f-4fed-b40c-14194056b6a5"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("58297e9d-2d7a-407d-84be-c0f904d8cff0"), "Деятельность", 4 },
                    { new Guid("9a608d88-8028-4ce2-af36-2e4d0c676419"), "Общая информация", 1 },
                    { new Guid("d29c86fa-214a-41c7-b469-90430c7d0b9c"), "Профессиональное развитие", 3 },
                    { new Guid("e0de0de8-225e-4632-94d0-91e83de256a2"), "Категория участников", 2 },
                    { new Guid("f28b8094-39cd-49f7-98b0-6d781dda9fc3"), "Деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0137bf53-a562-4790-a273-d957811bc153"), "Образовательная деятельность", 2 },
                    { new Guid("412694d0-d783-43c8-ba24-d51b705d9e0b"), "Инновационная и иная деятельность", 6 },
                    { new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5"), "Основной", 1 },
                    { new Guid("5279c445-d4e7-43bc-b2d9-ae324c20e033"), "Методическая деятельность", 3 },
                    { new Guid("758b0730-4897-478f-aafb-adb7798593d2"), "Профессиональные показатели", 4 },
                    { new Guid("8d433fd2-6058-4a77-84a0-da3078bfb45d"), "Конкурсная работа", 7 },
                    { new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594"), "Научно-исследовательская деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("2871d460-84fb-483f-84a9-7c5e82d88ac4"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("bf66823e-76fc-4535-82cc-268b62d3c845"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("39a17edb-6b5d-4e6a-a4ab-4ef3c73ea556"), "bool" },
                    { new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a"), "string" },
                    { new Guid("785b8c4d-0c17-4623-b23a-fffcf1ac8b9a"), "TextArea" },
                    { new Guid("87454fc4-a606-46a6-a0fb-87420b4efe7e"), "DateTime" },
                    { new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15"), "int" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("58297e9d-2d7a-407d-84be-c0f904d8cff0"), new Guid("2871d460-84fb-483f-84a9-7c5e82d88ac4") },
                    { new Guid("9a608d88-8028-4ce2-af36-2e4d0c676419"), new Guid("2871d460-84fb-483f-84a9-7c5e82d88ac4") },
                    { new Guid("9a608d88-8028-4ce2-af36-2e4d0c676419"), new Guid("bf66823e-76fc-4535-82cc-268b62d3c845") },
                    { new Guid("d29c86fa-214a-41c7-b469-90430c7d0b9c"), new Guid("2871d460-84fb-483f-84a9-7c5e82d88ac4") },
                    { new Guid("d29c86fa-214a-41c7-b469-90430c7d0b9c"), new Guid("bf66823e-76fc-4535-82cc-268b62d3c845") },
                    { new Guid("e0de0de8-225e-4632-94d0-91e83de256a2"), new Guid("2871d460-84fb-483f-84a9-7c5e82d88ac4") },
                    { new Guid("e0de0de8-225e-4632-94d0-91e83de256a2"), new Guid("bf66823e-76fc-4535-82cc-268b62d3c845") },
                    { new Guid("f28b8094-39cd-49f7-98b0-6d781dda9fc3"), new Guid("bf66823e-76fc-4535-82cc-268b62d3c845") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0ea4b40d-0b82-41bc-8f2c-25663e91fb23"), new Guid("f28b8094-39cd-49f7-98b0-6d781dda9fc3"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("10e99707-96b4-4dae-8256-286180aaa5f2"), new Guid("58297e9d-2d7a-407d-84be-c0f904d8cff0"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("26caaa30-b721-45e5-8da9-ccc30c3a378f"), new Guid("e0de0de8-225e-4632-94d0-91e83de256a2"), null, false, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("2a617a6c-ab3c-416e-9d01-fd96bfea7a23"), new Guid("9a608d88-8028-4ce2-af36-2e4d0c676419"), null, false, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("2b96bdc7-71ca-495b-b44b-8d2d690c9dba"), new Guid("9a608d88-8028-4ce2-af36-2e4d0c676419"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("3023a517-d6a2-4f60-94ff-97a925c97c20"), new Guid("9a608d88-8028-4ce2-af36-2e4d0c676419"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("3151b733-50c8-4719-a8b9-a791209265ef"), new Guid("58297e9d-2d7a-407d-84be-c0f904d8cff0"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("3e0dd756-51c2-43d9-9271-5b3efdde9b4a"), new Guid("9a608d88-8028-4ce2-af36-2e4d0c676419"), null, true, true, "Место работы/учебы", 6, "Название организации", new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("42810a5e-7a0d-49e5-b087-41ca4c036791"), new Guid("9a608d88-8028-4ce2-af36-2e4d0c676419"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("702d3167-7a61-44f8-b51c-9c4cb1bda1c5"), new Guid("e0de0de8-225e-4632-94d0-91e83de256a2"), null, true, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("81fc6d01-1086-42ae-ad69-40330c0c4785"), new Guid("e0de0de8-225e-4632-94d0-91e83de256a2"), null, true, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("8edb16ec-8be3-467b-977b-6f2c46cfbea7"), new Guid("e0de0de8-225e-4632-94d0-91e83de256a2"), null, false, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("9a5d24cb-8be4-47ea-9989-adfb592f239f"), new Guid("9a608d88-8028-4ce2-af36-2e4d0c676419"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("a81bc556-05d9-4eae-b2f0-ac8d61769482"), new Guid("9a608d88-8028-4ce2-af36-2e4d0c676419"), null, true, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("a8d74ae8-6d4f-4514-9d6b-c8e29d4caf4c"), new Guid("9a608d88-8028-4ce2-af36-2e4d0c676419"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("c8f71dcf-acd5-4c3c-8e02-47411d41b7f8"), new Guid("9a608d88-8028-4ce2-af36-2e4d0c676419"), null, false, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("da67a285-18ec-436a-8676-9061b077b47d"), new Guid("58297e9d-2d7a-407d-84be-c0f904d8cff0"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("e8af3900-4a55-4326-85fb-e02c3fe81209"), new Guid("f28b8094-39cd-49f7-98b0-6d781dda9fc3"), null, false, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("f98b9454-1a09-4252-8d5d-567a17cd0ecf"), new Guid("9a608d88-8028-4ce2-af36-2e4d0c676419"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("87454fc4-a606-46a6-a0fb-87420b4efe7e") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0137bf53-a562-4790-a273-d957811bc153"), new Guid("2871d460-84fb-483f-84a9-7c5e82d88ac4") },
                    { new Guid("412694d0-d783-43c8-ba24-d51b705d9e0b"), new Guid("bf66823e-76fc-4535-82cc-268b62d3c845") },
                    { new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5"), new Guid("2871d460-84fb-483f-84a9-7c5e82d88ac4") },
                    { new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5"), new Guid("bf66823e-76fc-4535-82cc-268b62d3c845") },
                    { new Guid("5279c445-d4e7-43bc-b2d9-ae324c20e033"), new Guid("2871d460-84fb-483f-84a9-7c5e82d88ac4") },
                    { new Guid("758b0730-4897-478f-aafb-adb7798593d2"), new Guid("2871d460-84fb-483f-84a9-7c5e82d88ac4") },
                    { new Guid("8d433fd2-6058-4a77-84a0-da3078bfb45d"), new Guid("2871d460-84fb-483f-84a9-7c5e82d88ac4") },
                    { new Guid("8d433fd2-6058-4a77-84a0-da3078bfb45d"), new Guid("bf66823e-76fc-4535-82cc-268b62d3c845") },
                    { new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594"), new Guid("bf66823e-76fc-4535-82cc-268b62d3c845") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("066a3c17-3841-4249-8fa8-3b0c4f18bd89"), new Guid("58297e9d-2d7a-407d-84be-c0f904d8cff0"), false, false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("19a8e937-e52e-434e-888c-48bbd71f1762"), new Guid("f28b8094-39cd-49f7-98b0-6d781dda9fc3"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("57f8ccfe-a25a-4387-84c8-dc891f739633"), new Guid("e0de0de8-225e-4632-94d0-91e83de256a2"), true, true, "Краткая аннотация конкурсной работы", 14 },
                    { new Guid("6096dfb3-673e-4c35-bb17-164fb906a07d"), new Guid("58297e9d-2d7a-407d-84be-c0f904d8cff0"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("78a4e826-d224-4442-a991-f6042723b2cb"), new Guid("58297e9d-2d7a-407d-84be-c0f904d8cff0"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("85f1d02e-c890-43db-9417-dee0d1f29ea1"), new Guid("d29c86fa-214a-41c7-b469-90430c7d0b9c"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("8697ef9f-8082-4975-b498-a0f4526d4582"), new Guid("58297e9d-2d7a-407d-84be-c0f904d8cff0"), false, false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("95b1059f-d5bc-45ae-a9ee-23718df65141"), new Guid("f28b8094-39cd-49f7-98b0-6d781dda9fc3"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("b8644a5c-9024-45c6-823e-d263de9c54bf"), new Guid("d29c86fa-214a-41c7-b469-90430c7d0b9c"), true, true, "Персональные идентификаторы", 10 },
                    { new Guid("d37f7c77-2bb1-4a85-94d2-ca6780fe6a07"), new Guid("f28b8094-39cd-49f7-98b0-6d781dda9fc3"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("dbae62d7-3185-45ea-b30a-54decb78e98c"), new Guid("d29c86fa-214a-41c7-b469-90430c7d0b9c"), false, false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("e6518245-cb2e-429e-bc8c-416bc1fc628d"), new Guid("58297e9d-2d7a-407d-84be-c0f904d8cff0"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("eaa731fb-84f7-4603-83a9-71e162b963ee"), new Guid("58297e9d-2d7a-407d-84be-c0f904d8cff0"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("ec666138-f2c9-4f63-b7ed-b123ccd59133"), new Guid("f28b8094-39cd-49f7-98b0-6d781dda9fc3"), false, false, "Список научных публикаций за последние 5 лет", 9 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0904eb72-2d1d-43c3-a6b8-8faf69dc44b8"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("19a8e937-e52e-434e-888c-48bbd71f1762"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("121f3f60-2c74-4598-ad27-8b8da361c89b"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("066a3c17-3841-4249-8fa8-3b0c4f18bd89"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("1eeae8c8-2243-4d6d-87a2-b8eb0b4a98c7"), true, "Название", 2, new Guid("95b1059f-d5bc-45ae-a9ee-23718df65141"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("1eff6572-230a-4160-9167-3a92e4f6c1b6"), true, "Вид деятельности (преподавательская)", 3, new Guid("066a3c17-3841-4249-8fa8-3b0c4f18bd89"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("1fc0a286-f2e4-49da-add2-d9e5b0f79bbe"), true, "Итого (час.)", 5, new Guid("78a4e826-d224-4442-a991-f6042723b2cb"), new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("22a64286-e01e-4e4d-973d-a936203bdf3f"), true, "Название конкурса", 2, new Guid("dbae62d7-3185-45ea-b30a-54decb78e98c"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("23259ef3-13de-4fa7-b329-4957ca418e25"), true, "Номер РИД", 4, new Guid("95b1059f-d5bc-45ae-a9ee-23718df65141"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("29180656-91ab-4746-b1da-0c6d50a8feb8"), true, "Вид", 1, new Guid("d37f7c77-2bb1-4a85-94d2-ca6780fe6a07"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("315d946e-7964-437c-b43a-627ccf24b056"), true, "Название статьи", 1, new Guid("ec666138-f2c9-4f63-b7ed-b123ccd59133"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("333f91d9-39c8-4865-a710-0a33fd0af6a0"), true, "Год", 3, new Guid("6096dfb3-673e-4c35-bb17-164fb906a07d"), new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("39fe62bc-b4d7-4f8b-876f-b52ad916a7c1"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("19a8e937-e52e-434e-888c-48bbd71f1762"), new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("3fb172a3-89e4-4761-8f82-98d24b6dea1b"), true, "Год получения документа", 2, new Guid("85f1d02e-c890-43db-9417-dee0d1f29ea1"), new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("4c2924da-932a-417f-94e2-e4bf94ddb171"), true, "Ссылка на платформу", 3, new Guid("eaa731fb-84f7-4603-83a9-71e162b963ee"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("5171f04a-b8ef-4236-b89f-93a3b276f270"), true, "Соавторы", 2, new Guid("ec666138-f2c9-4f63-b7ed-b123ccd59133"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("52d0c1b9-adad-46b2-80b9-48c39fdceedc"), true, "Период выполнения", 3, new Guid("19a8e937-e52e-434e-888c-48bbd71f1762"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("5550e311-29d5-44c4-a286-97e9f4b46fe2"), true, "Название", 2, new Guid("8697ef9f-8082-4975-b498-a0f4526d4582"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("5632a9a4-c69d-4393-9004-e64e6d2b1e70"), true, "Издательство, год", 6, new Guid("8697ef9f-8082-4975-b498-a0f4526d4582"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("5fa27250-f48e-45fe-b210-92a2fe0170f9"), true, "Лекции (час.)", 3, new Guid("78a4e826-d224-4442-a991-f6042723b2cb"), new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("691ce3c0-3751-4ecb-abe0-2e62610036e1"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("78a4e826-d224-4442-a991-f6042723b2cb"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("6a267958-ccb4-4f0f-a91f-5a1f22ee84c1"), true, "Год", 4, new Guid("eaa731fb-84f7-4603-83a9-71e162b963ee"), new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("73b86c2f-f3c5-460b-a149-9d70f7337970"), true, "Вид", 1, new Guid("95b1059f-d5bc-45ae-a9ee-23718df65141"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("73e7e1f7-e625-434c-922e-d1c6bd14c50f"), true, "Название курса", 1, new Guid("eaa731fb-84f7-4603-83a9-71e162b963ee"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("77f42af4-4ad8-4828-b5ec-e9c4871ad4f7"), true, "ФИО", 1, new Guid("6096dfb3-673e-4c35-bb17-164fb906a07d"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("7ccd6136-7a49-4be8-bf1f-c4026e49de60"), true, "Наименование курса", 1, new Guid("78a4e826-d224-4442-a991-f6042723b2cb"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("858af379-45f6-440e-839c-8761901e830f"), true, "Название дисциплины", 1, new Guid("e6518245-cb2e-429e-bc8c-416bc1fc628d"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("8ad811ec-d12c-4c48-9494-1a840fdf7e05"), true, "Год", 1, new Guid("dbae62d7-3185-45ea-b30a-54decb78e98c"), new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("8b09847d-9743-4405-b204-951d55216a6f"), true, "Значение", 2, new Guid("57f8ccfe-a25a-4387-84c8-dc891f739633"), new Guid("785b8c4d-0c17-4623-b23a-fffcf1ac8b9a") },
                    { new Guid("8d94f97c-7d6a-49fc-a8e3-0676318f6f5f"), false, "Тип идентификатора", 1, new Guid("b8644a5c-9024-45c6-823e-d263de9c54bf"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("8fd60b4b-bd06-4e32-acdc-a20e3d3816d8"), true, "Вид (лекции, лабораторные)", 2, new Guid("e6518245-cb2e-429e-bc8c-416bc1fc628d"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("9553b74a-b6d0-4911-9615-b9459516f49c"), true, "ФИО соавторов", 3, new Guid("95b1059f-d5bc-45ae-a9ee-23718df65141"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("958a9e39-ea52-42a4-bc04-ff14314abc3a"), true, "Статус (руководитель/исполнитель)", 4, new Guid("19a8e937-e52e-434e-888c-48bbd71f1762"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("96553f66-32e8-4681-88d0-63a87e327d63"), true, "Название НИР/НИОКР", 1, new Guid("19a8e937-e52e-434e-888c-48bbd71f1762"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("9be8f5d5-b926-4941-ba12-581ca42b058a"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("6096dfb3-673e-4c35-bb17-164fb906a07d"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("a0e2bb2b-2433-4875-a099-168ce9ac7fd4"), true, "Количество печатных листов", 4, new Guid("8697ef9f-8082-4975-b498-a0f4526d4582"), new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("af571f38-0463-4305-ab6e-5b68c3809cf1"), true, "Ссылка на открытый доступ", 8, new Guid("8697ef9f-8082-4975-b498-a0f4526d4582"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("b0e928f1-46bb-4c89-919f-ead46a1c20cd"), true, "Наличие грифа", 5, new Guid("8697ef9f-8082-4975-b498-a0f4526d4582"), new Guid("39a17edb-6b5d-4e6a-a4ab-4ef3c73ea556") },
                    { new Guid("b47e1c4e-7497-4469-9fb5-cf0d5c5bb4bb"), true, "Соавторы", 2, new Guid("eaa731fb-84f7-4603-83a9-71e162b963ee"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("bd1db414-deec-4474-8503-d7420d6f74ff"), true, "Издание, год", 4, new Guid("ec666138-f2c9-4f63-b7ed-b123ccd59133"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("c6566db2-748a-4efd-9044-941368404c0e"), true, "Язык публикации", 7, new Guid("8697ef9f-8082-4975-b498-a0f4526d4582"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("cceaac28-6690-4d39-b2e7-b6d3fd96ebd7"), true, "Название конкурса/премии", 2, new Guid("6096dfb3-673e-4c35-bb17-164fb906a07d"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("cec3ef98-6f33-41d2-8dd1-0a976d405098"), true, "Практические занятия (час.)", 4, new Guid("78a4e826-d224-4442-a991-f6042723b2cb"), new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("d8c69bdf-3b32-4fb6-b1b0-b7fc11099b99"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("6096dfb3-673e-4c35-bb17-164fb906a07d"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("dc07ba29-2f72-4f3e-8689-cc1a6821233b"), true, "Награда", 4, new Guid("dbae62d7-3185-45ea-b30a-54decb78e98c"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("dd4dd0ed-a655-41d1-b0b3-1f766a3e0d42"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("ec666138-f2c9-4f63-b7ed-b123ccd59133"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("e28b5666-9538-4e41-84b1-a8f36521d34d"), false, "Соавторы", 3, new Guid("8697ef9f-8082-4975-b498-a0f4526d4582"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("e2c47ed4-b75d-4d40-aaed-e6dbd1cd3e6c"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("e6518245-cb2e-429e-bc8c-416bc1fc628d"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("e7acd63c-5190-4ad1-a32b-b7e3fb0dc39d"), true, "Название документа, реквизиты", 1, new Guid("85f1d02e-c890-43db-9417-dee0d1f29ea1"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("e96539b7-c002-43c8-85d5-823f9057d2c5"), true, "Ссылка", 5, new Guid("dbae62d7-3185-45ea-b30a-54decb78e98c"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("ec539051-fff8-4694-b633-916c0ddb1170"), true, "Статус конкурса", 3, new Guid("dbae62d7-3185-45ea-b30a-54decb78e98c"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("ed26cde1-9a31-4c61-819b-f484c6c6b49b"), true, "Название организации в которую внедрена разработка", 3, new Guid("d37f7c77-2bb1-4a85-94d2-ca6780fe6a07"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("ef7c7b94-8a40-4871-8c66-d357d8f25c61"), true, "Название организации/должность/ставка", 1, new Guid("066a3c17-3841-4249-8fa8-3b0c4f18bd89"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("f082c104-a553-4f38-b069-d2a3537f6a4d"), false, "Идентификатор", 2, new Guid("b8644a5c-9024-45c6-823e-d263de9c54bf"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("f129a86c-981e-4b6d-8789-37e175c6fb3e"), true, "Вид публикации", 1, new Guid("8697ef9f-8082-4975-b498-a0f4526d4582"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("fb9cd531-1150-4e39-bee4-dccbe42f16e1"), true, "Название разработки", 2, new Guid("d37f7c77-2bb1-4a85-94d2-ca6780fe6a07"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") },
                    { new Guid("fe1aa457-33dc-4a8b-a8fc-59272bfc243b"), true, "Количество часов", 4, new Guid("066a3c17-3841-4249-8fa8-3b0c4f18bd89"), new Guid("c480031d-3fdc-4290-b112-f56fb31cbb15") },
                    { new Guid("ffa8d448-ad2c-4ed5-8a9d-34c9d721b775"), true, "Название", 1, new Guid("57f8ccfe-a25a-4387-84c8-dc891f739633"), new Guid("550d6f40-6270-4caf-be45-8a1d4557b00a") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("0ea4b40d-0b82-41bc-8f2c-25663e91fb23"), new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594") },
                    { new Guid("10e99707-96b4-4dae-8256-286180aaa5f2"), new Guid("0137bf53-a562-4790-a273-d957811bc153") },
                    { new Guid("26caaa30-b721-45e5-8da9-ccc30c3a378f"), new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5") },
                    { new Guid("2a617a6c-ab3c-416e-9d01-fd96bfea7a23"), new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5") },
                    { new Guid("2b96bdc7-71ca-495b-b44b-8d2d690c9dba"), new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5") },
                    { new Guid("3023a517-d6a2-4f60-94ff-97a925c97c20"), new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5") },
                    { new Guid("3151b733-50c8-4719-a8b9-a791209265ef"), new Guid("0137bf53-a562-4790-a273-d957811bc153") },
                    { new Guid("3e0dd756-51c2-43d9-9271-5b3efdde9b4a"), new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5") },
                    { new Guid("42810a5e-7a0d-49e5-b087-41ca4c036791"), new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5") },
                    { new Guid("702d3167-7a61-44f8-b51c-9c4cb1bda1c5"), new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5") },
                    { new Guid("702d3167-7a61-44f8-b51c-9c4cb1bda1c5"), new Guid("758b0730-4897-478f-aafb-adb7798593d2") },
                    { new Guid("702d3167-7a61-44f8-b51c-9c4cb1bda1c5"), new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594") },
                    { new Guid("81fc6d01-1086-42ae-ad69-40330c0c4785"), new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5") },
                    { new Guid("8edb16ec-8be3-467b-977b-6f2c46cfbea7"), new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5") },
                    { new Guid("9a5d24cb-8be4-47ea-9989-adfb592f239f"), new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5") },
                    { new Guid("a81bc556-05d9-4eae-b2f0-ac8d61769482"), new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5") },
                    { new Guid("a8d74ae8-6d4f-4514-9d6b-c8e29d4caf4c"), new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5") },
                    { new Guid("c8f71dcf-acd5-4c3c-8e02-47411d41b7f8"), new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5") },
                    { new Guid("da67a285-18ec-436a-8676-9061b077b47d"), new Guid("0137bf53-a562-4790-a273-d957811bc153") },
                    { new Guid("e8af3900-4a55-4326-85fb-e02c3fe81209"), new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594") },
                    { new Guid("f98b9454-1a09-4252-8d5d-567a17cd0ecf"), new Guid("480b1d6b-ee39-4866-b931-645828c7a2b5") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("0137bf53-a562-4790-a273-d957811bc153"), new Guid("066a3c17-3841-4249-8fa8-3b0c4f18bd89") },
                    { new Guid("0137bf53-a562-4790-a273-d957811bc153"), new Guid("6096dfb3-673e-4c35-bb17-164fb906a07d") },
                    { new Guid("0137bf53-a562-4790-a273-d957811bc153"), new Guid("78a4e826-d224-4442-a991-f6042723b2cb") },
                    { new Guid("0137bf53-a562-4790-a273-d957811bc153"), new Guid("eaa731fb-84f7-4603-83a9-71e162b963ee") },
                    { new Guid("412694d0-d783-43c8-ba24-d51b705d9e0b"), new Guid("85f1d02e-c890-43db-9417-dee0d1f29ea1") },
                    { new Guid("412694d0-d783-43c8-ba24-d51b705d9e0b"), new Guid("95b1059f-d5bc-45ae-a9ee-23718df65141") },
                    { new Guid("412694d0-d783-43c8-ba24-d51b705d9e0b"), new Guid("d37f7c77-2bb1-4a85-94d2-ca6780fe6a07") },
                    { new Guid("5279c445-d4e7-43bc-b2d9-ae324c20e033"), new Guid("8697ef9f-8082-4975-b498-a0f4526d4582") },
                    { new Guid("5279c445-d4e7-43bc-b2d9-ae324c20e033"), new Guid("e6518245-cb2e-429e-bc8c-416bc1fc628d") },
                    { new Guid("758b0730-4897-478f-aafb-adb7798593d2"), new Guid("85f1d02e-c890-43db-9417-dee0d1f29ea1") },
                    { new Guid("758b0730-4897-478f-aafb-adb7798593d2"), new Guid("dbae62d7-3185-45ea-b30a-54decb78e98c") },
                    { new Guid("8d433fd2-6058-4a77-84a0-da3078bfb45d"), new Guid("57f8ccfe-a25a-4387-84c8-dc891f739633") },
                    { new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594"), new Guid("19a8e937-e52e-434e-888c-48bbd71f1762") },
                    { new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594"), new Guid("b8644a5c-9024-45c6-823e-d263de9c54bf") },
                    { new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594"), new Guid("dbae62d7-3185-45ea-b30a-54decb78e98c") },
                    { new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594"), new Guid("ec666138-f2c9-4f63-b7ed-b123ccd59133") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("05d26786-3b03-4af9-9bdf-a30ab85ca6a7"), null, null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("57f8ccfe-a25a-4387-84c8-dc891f739633") },
                    { new Guid("17f19ccc-7a3b-4da5-8517-525b9f00d815"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("8697ef9f-8082-4975-b498-a0f4526d4582") },
                    { new Guid("27f848f8-7931-4a25-8c44-edf8e5227eea"), null, null, false, 10, "Оценка уровня предоставленной работы:", 25, new Guid("57f8ccfe-a25a-4387-84c8-dc891f739633") },
                    { new Guid("2854c5b8-4d6a-4159-9d93-acef804f8e46"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("78a4e826-d224-4442-a991-f6042723b2cb") },
                    { new Guid("33964e1c-bd82-4378-ad91-097e26abb67b"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("19a8e937-e52e-434e-888c-48bbd71f1762") },
                    { new Guid("33a86126-6d9b-45b8-ae8d-8a41d08f16a3"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("6096dfb3-673e-4c35-bb17-164fb906a07d") },
                    { new Guid("3e8911ee-5332-4ace-be08-43dca7840b07"), "EvaluateMark19", new Guid("0ea4b40d-0b82-41bc-8f2c-25663e91fb23"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("41a028a4-6883-4216-a568-c51c2f897e99"), "EvaluateMark5", new Guid("10e99707-96b4-4dae-8256-286180aaa5f2"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("423559d5-1f3e-41f2-97f4-7e27432c5504"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("95b1059f-d5bc-45ae-a9ee-23718df65141") },
                    { new Guid("52eecfa3-539f-4438-9583-38f1baa5560f"), "EvaluateMark13", new Guid("702d3167-7a61-44f8-b51c-9c4cb1bda1c5"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("616c7d58-d833-4829-a162-23a1d29e537d"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("dbae62d7-3185-45ea-b30a-54decb78e98c") },
                    { new Guid("661e8681-3991-417c-8be7-f2fdbe6f407f"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("e6518245-cb2e-429e-bc8c-416bc1fc628d") },
                    { new Guid("6ca0ecc6-068b-4fa6-928d-2037f39960b7"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("ec666138-f2c9-4f63-b7ed-b123ccd59133") },
                    { new Guid("7c7b7474-73d8-47d4-8a12-fc1bc4e1ecdc"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("8697ef9f-8082-4975-b498-a0f4526d4582") },
                    { new Guid("8274dcf9-dba3-4715-82c8-06e10bd7262c"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("85f1d02e-c890-43db-9417-dee0d1f29ea1") },
                    { new Guid("8bc9db0c-87a4-40cd-a862-67bbb1ace5c3"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("78a4e826-d224-4442-a991-f6042723b2cb") },
                    { new Guid("8fcaa24b-0593-47db-abf7-c8ca3de899e2"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("d37f7c77-2bb1-4a85-94d2-ca6780fe6a07") },
                    { new Guid("92487515-b375-45c6-9a23-dbbc8d4cefb7"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("eaa731fb-84f7-4603-83a9-71e162b963ee") },
                    { new Guid("97959ed8-8885-4af4-8ab9-ad5cef291dc3"), "EvaluateMark4", new Guid("da67a285-18ec-436a-8676-9061b077b47d"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("9be73cfc-661e-4901-a0df-1917e4f71a89"), "EvaluateMark3", new Guid("3151b733-50c8-4719-a8b9-a791209265ef"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("9fa37be4-160a-45f0-87f8-bf3e6514a650"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("19a8e937-e52e-434e-888c-48bbd71f1762") },
                    { new Guid("c609a41b-dffb-4fa8-90dc-00bdf654340c"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("8697ef9f-8082-4975-b498-a0f4526d4582") },
                    { new Guid("e282f4ad-d602-495f-9c15-3a66cbe5059b"), "EvaluateMark20", new Guid("e8af3900-4a55-4326-85fb-e02c3fe81209"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("f1ca61e6-ffa6-4bf9-8841-339f5056d5ba"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("8697ef9f-8082-4975-b498-a0f4526d4582") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("08def21a-cb79-45f2-bf5d-9e508dd094fa"), true, new Guid("57f8ccfe-a25a-4387-84c8-dc891f739633") },
                    { new Guid("0cf5ebac-beb6-4ff5-ba48-0897cf628a9b"), true, new Guid("b8644a5c-9024-45c6-823e-d263de9c54bf") },
                    { new Guid("17bf9bbb-0c98-43f6-95db-259b9892d561"), true, new Guid("b8644a5c-9024-45c6-823e-d263de9c54bf") },
                    { new Guid("180ecf96-e2e8-4b97-8548-1090cac7cf43"), true, new Guid("57f8ccfe-a25a-4387-84c8-dc891f739633") },
                    { new Guid("2e2fe64b-5250-4d6c-938e-9bb9789f06ce"), true, new Guid("57f8ccfe-a25a-4387-84c8-dc891f739633") },
                    { new Guid("3543d745-0307-48a1-ae0a-ff4586d3a905"), true, new Guid("57f8ccfe-a25a-4387-84c8-dc891f739633") },
                    { new Guid("606f130d-3bfa-423a-b8be-3a1983679a98"), true, new Guid("b8644a5c-9024-45c6-823e-d263de9c54bf") },
                    { new Guid("6f9afd44-6e79-4fe6-add4-cdeb72870acb"), true, new Guid("57f8ccfe-a25a-4387-84c8-dc891f739633") },
                    { new Guid("70b20af9-4c3d-4c47-aac8-9cda4119be56"), true, new Guid("57f8ccfe-a25a-4387-84c8-dc891f739633") },
                    { new Guid("7679d547-07d1-4764-a109-2ee6d64b54f5"), true, new Guid("57f8ccfe-a25a-4387-84c8-dc891f739633") },
                    { new Guid("899bef44-fcee-4c0d-ab93-ef8a0fde2ffc"), true, new Guid("b8644a5c-9024-45c6-823e-d263de9c54bf") },
                    { new Guid("a82bf3f2-59cb-4768-8821-a768e269f55a"), true, new Guid("57f8ccfe-a25a-4387-84c8-dc891f739633") },
                    { new Guid("b27e7614-a7f6-4ffb-b52b-77e6d7108f64"), true, new Guid("b8644a5c-9024-45c6-823e-d263de9c54bf") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("2659f5ff-15bf-416f-8d77-6a2108ff3f59"), null, new Guid("702d3167-7a61-44f8-b51c-9c4cb1bda1c5"), "Нет" },
                    { new Guid("373b1c4b-6427-4ee6-baf0-727b5436fd8d"), null, new Guid("702d3167-7a61-44f8-b51c-9c4cb1bda1c5"), "Профессор" },
                    { new Guid("46f2c81b-9705-4773-89e2-0d76ca70f49d"), null, new Guid("702d3167-7a61-44f8-b51c-9c4cb1bda1c5"), "Доцент" },
                    { new Guid("8fd50876-715b-422b-964a-2d3004be5c04"), null, new Guid("26caaa30-b721-45e5-8da9-ccc30c3a378f"), "Имеющие ученую степень доктора наук" },
                    { new Guid("941a4d07-7d9b-41b9-9e4c-7633fd546ddf"), null, new Guid("81fc6d01-1086-42ae-ad69-40330c0c4785"), "Кандидат наук" },
                    { new Guid("a30e298d-8d14-4445-b7fc-b84eb0859e2c"), null, new Guid("26caaa30-b721-45e5-8da9-ccc30c3a378f"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("f3a4f2c5-82b7-4a44-afb1-bf5bb36f87f7"), null, new Guid("81fc6d01-1086-42ae-ad69-40330c0c4785"), "Доктор наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("1df793f1-d1d1-4ecc-8651-de449d487810"), null, new Guid("f082c104-a553-4f38-b069-d2a3537f6a4d"), false, true, new Guid("899bef44-fcee-4c0d-ab93-ef8a0fde2ffc"), null },
                    { new Guid("2aaae959-dcf5-436c-abe8-1de15501baa4"), null, new Guid("ffa8d448-ad2c-4ed5-8a9d-34c9d721b775"), true, true, new Guid("2e2fe64b-5250-4d6c-938e-9bb9789f06ce"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("37be2e4b-fb86-4353-a5a7-508b76ee359b"), null, new Guid("f082c104-a553-4f38-b069-d2a3537f6a4d"), false, true, new Guid("b27e7614-a7f6-4ffb-b52b-77e6d7108f64"), null },
                    { new Guid("5382617f-26a4-4962-b2fd-d29bb4fefa58"), null, new Guid("8d94f97c-7d6a-49fc-a8e3-0676318f6f5f"), true, true, new Guid("0cf5ebac-beb6-4ff5-ba48-0897cf628a9b"), "Google Scholar ID" },
                    { new Guid("5436645b-1202-4a75-865c-314556c633e9"), null, new Guid("8d94f97c-7d6a-49fc-a8e3-0676318f6f5f"), true, true, new Guid("606f130d-3bfa-423a-b8be-3a1983679a98"), "ORCiD" },
                    { new Guid("61fec6cd-997d-46d9-a97e-30ff2bf1c65e"), null, new Guid("f082c104-a553-4f38-b069-d2a3537f6a4d"), false, true, new Guid("0cf5ebac-beb6-4ff5-ba48-0897cf628a9b"), null },
                    { new Guid("63608ebf-c9ec-4438-b92d-8b42493666ba"), null, new Guid("f082c104-a553-4f38-b069-d2a3537f6a4d"), false, true, new Guid("606f130d-3bfa-423a-b8be-3a1983679a98"), null },
                    { new Guid("690f5023-2c7f-4d1e-9bfe-bf3b9c5e9771"), null, new Guid("8d94f97c-7d6a-49fc-a8e3-0676318f6f5f"), true, true, new Guid("b27e7614-a7f6-4ffb-b52b-77e6d7108f64"), "ResearcherID" },
                    { new Guid("6d44a6de-483b-4d35-a246-d34b54d4c731"), null, new Guid("8b09847d-9743-4405-b204-951d55216a6f"), false, true, new Guid("180ecf96-e2e8-4b97-8548-1090cac7cf43"), null },
                    { new Guid("714dda9a-1594-4fb8-8a1c-61e7470c321a"), null, new Guid("8b09847d-9743-4405-b204-951d55216a6f"), false, true, new Guid("6f9afd44-6e79-4fe6-add4-cdeb72870acb"), null },
                    { new Guid("7c657730-af6d-4c5f-a2e1-b7d0a8438034"), null, new Guid("8b09847d-9743-4405-b204-951d55216a6f"), false, true, new Guid("7679d547-07d1-4764-a109-2ee6d64b54f5"), null },
                    { new Guid("7c7e3cb0-4293-4006-ad21-3973aeab03b5"), null, new Guid("8b09847d-9743-4405-b204-951d55216a6f"), false, true, new Guid("3543d745-0307-48a1-ae0a-ff4586d3a905"), null },
                    { new Guid("88dc6b43-3894-478d-ae2e-d1d1467cd91a"), null, new Guid("f082c104-a553-4f38-b069-d2a3537f6a4d"), false, true, new Guid("17bf9bbb-0c98-43f6-95db-259b9892d561"), null },
                    { new Guid("9511272d-f4f8-487a-b8ed-4ebd1929df4f"), null, new Guid("ffa8d448-ad2c-4ed5-8a9d-34c9d721b775"), true, true, new Guid("180ecf96-e2e8-4b97-8548-1090cac7cf43"), "Название работы" },
                    { new Guid("9d9b037f-8f72-43e6-a014-7efcbb1f707f"), null, new Guid("ffa8d448-ad2c-4ed5-8a9d-34c9d721b775"), true, true, new Guid("6f9afd44-6e79-4fe6-add4-cdeb72870acb"), "Результаты и выводы" },
                    { new Guid("a455a0cc-640a-4226-8ede-5b0bef51bb45"), null, new Guid("8b09847d-9743-4405-b204-951d55216a6f"), false, true, new Guid("2e2fe64b-5250-4d6c-938e-9bb9789f06ce"), null },
                    { new Guid("aa03ebe9-b679-4ace-99d4-becb80c2bf40"), null, new Guid("8b09847d-9743-4405-b204-951d55216a6f"), false, true, new Guid("70b20af9-4c3d-4c47-aac8-9cda4119be56"), null },
                    { new Guid("aac61cbe-b79f-4c5d-8073-ddbc55933775"), null, new Guid("8b09847d-9743-4405-b204-951d55216a6f"), false, true, new Guid("08def21a-cb79-45f2-bf5d-9e508dd094fa"), null },
                    { new Guid("b2834281-0da9-4591-95d3-53f652a89660"), null, new Guid("8b09847d-9743-4405-b204-951d55216a6f"), false, true, new Guid("a82bf3f2-59cb-4768-8821-a768e269f55a"), null },
                    { new Guid("bd594049-817c-48af-8dc7-de4e34a8a0a5"), null, new Guid("ffa8d448-ad2c-4ed5-8a9d-34c9d721b775"), true, true, new Guid("3543d745-0307-48a1-ae0a-ff4586d3a905"), "Актуальность конкурсной работы" },
                    { new Guid("bdbc30e7-e35b-4a89-a19f-271e3736db91"), null, new Guid("ffa8d448-ad2c-4ed5-8a9d-34c9d721b775"), true, true, new Guid("70b20af9-4c3d-4c47-aac8-9cda4119be56"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("c311844f-6df9-4612-a657-c1eb7f20f256"), null, new Guid("8d94f97c-7d6a-49fc-a8e3-0676318f6f5f"), true, true, new Guid("17bf9bbb-0c98-43f6-95db-259b9892d561"), "РИНЦ AuthorID" },
                    { new Guid("c6ed5331-119f-484d-8d1a-8af9ad2f2256"), null, new Guid("8d94f97c-7d6a-49fc-a8e3-0676318f6f5f"), true, true, new Guid("899bef44-fcee-4c0d-ab93-ef8a0fde2ffc"), "ScopusID" },
                    { new Guid("cbd73d4e-57ce-4a84-9ae1-e99ca8f9a1f5"), null, new Guid("ffa8d448-ad2c-4ed5-8a9d-34c9d721b775"), true, true, new Guid("08def21a-cb79-45f2-bf5d-9e508dd094fa"), "Методология и методы, используемые в работе" },
                    { new Guid("ced92356-1108-4023-9039-062a568afb94"), null, new Guid("ffa8d448-ad2c-4ed5-8a9d-34c9d721b775"), true, true, new Guid("a82bf3f2-59cb-4768-8821-a768e269f55a"), "Ссылка на конкурсную работу" },
                    { new Guid("f77b603d-ed6f-4083-8d29-ca6c967a1d17"), null, new Guid("ffa8d448-ad2c-4ed5-8a9d-34c9d721b775"), true, true, new Guid("7679d547-07d1-4764-a109-2ee6d64b54f5"), "Инновационность" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("0137bf53-a562-4790-a273-d957811bc153"), new Guid("2854c5b8-4d6a-4159-9d93-acef804f8e46") },
                    { new Guid("0137bf53-a562-4790-a273-d957811bc153"), new Guid("33a86126-6d9b-45b8-ae8d-8a41d08f16a3") },
                    { new Guid("0137bf53-a562-4790-a273-d957811bc153"), new Guid("41a028a4-6883-4216-a568-c51c2f897e99") },
                    { new Guid("0137bf53-a562-4790-a273-d957811bc153"), new Guid("8bc9db0c-87a4-40cd-a862-67bbb1ace5c3") },
                    { new Guid("0137bf53-a562-4790-a273-d957811bc153"), new Guid("92487515-b375-45c6-9a23-dbbc8d4cefb7") },
                    { new Guid("0137bf53-a562-4790-a273-d957811bc153"), new Guid("97959ed8-8885-4af4-8ab9-ad5cef291dc3") },
                    { new Guid("0137bf53-a562-4790-a273-d957811bc153"), new Guid("9be73cfc-661e-4901-a0df-1917e4f71a89") },
                    { new Guid("412694d0-d783-43c8-ba24-d51b705d9e0b"), new Guid("423559d5-1f3e-41f2-97f4-7e27432c5504") },
                    { new Guid("412694d0-d783-43c8-ba24-d51b705d9e0b"), new Guid("8274dcf9-dba3-4715-82c8-06e10bd7262c") },
                    { new Guid("412694d0-d783-43c8-ba24-d51b705d9e0b"), new Guid("8fcaa24b-0593-47db-abf7-c8ca3de899e2") },
                    { new Guid("5279c445-d4e7-43bc-b2d9-ae324c20e033"), new Guid("17f19ccc-7a3b-4da5-8517-525b9f00d815") },
                    { new Guid("5279c445-d4e7-43bc-b2d9-ae324c20e033"), new Guid("661e8681-3991-417c-8be7-f2fdbe6f407f") },
                    { new Guid("5279c445-d4e7-43bc-b2d9-ae324c20e033"), new Guid("7c7b7474-73d8-47d4-8a12-fc1bc4e1ecdc") },
                    { new Guid("5279c445-d4e7-43bc-b2d9-ae324c20e033"), new Guid("c609a41b-dffb-4fa8-90dc-00bdf654340c") },
                    { new Guid("5279c445-d4e7-43bc-b2d9-ae324c20e033"), new Guid("f1ca61e6-ffa6-4bf9-8841-339f5056d5ba") },
                    { new Guid("758b0730-4897-478f-aafb-adb7798593d2"), new Guid("52eecfa3-539f-4438-9583-38f1baa5560f") },
                    { new Guid("758b0730-4897-478f-aafb-adb7798593d2"), new Guid("616c7d58-d833-4829-a162-23a1d29e537d") },
                    { new Guid("758b0730-4897-478f-aafb-adb7798593d2"), new Guid("8274dcf9-dba3-4715-82c8-06e10bd7262c") },
                    { new Guid("8d433fd2-6058-4a77-84a0-da3078bfb45d"), new Guid("05d26786-3b03-4af9-9bdf-a30ab85ca6a7") },
                    { new Guid("8d433fd2-6058-4a77-84a0-da3078bfb45d"), new Guid("27f848f8-7931-4a25-8c44-edf8e5227eea") },
                    { new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594"), new Guid("33964e1c-bd82-4378-ad91-097e26abb67b") },
                    { new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594"), new Guid("3e8911ee-5332-4ace-be08-43dca7840b07") },
                    { new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594"), new Guid("52eecfa3-539f-4438-9583-38f1baa5560f") },
                    { new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594"), new Guid("616c7d58-d833-4829-a162-23a1d29e537d") },
                    { new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594"), new Guid("6ca0ecc6-068b-4fa6-928d-2037f39960b7") },
                    { new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594"), new Guid("9fa37be4-160a-45f0-87f8-bf3e6514a650") },
                    { new Guid("932eb737-4b3f-4c5e-a00c-b0b5025a1594"), new Guid("e282f4ad-d602-495f-9c15-3a66cbe5059b") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("02eabe6d-6328-4b93-a6c9-5b0b824f63b2"), new Guid("8fd60b4b-bd06-4e32-acdc-a20e3d3816d8"), null, "Лекции" },
                    { new Guid("0a1d7158-6e87-43d2-b839-931e20f481a9"), new Guid("73b86c2f-f3c5-460b-a149-9d70f7337970"), null, "Полезная модель" },
                    { new Guid("0c236527-1819-4a0b-9093-5563e96e2e66"), new Guid("ec539051-fff8-4694-b633-916c0ddb1170"), null, "Международный" },
                    { new Guid("28386ef1-996e-4ad3-acd0-e2c6c922a677"), new Guid("5171f04a-b8ef-4236-b89f-93a3b276f270"), null, "Есть" },
                    { new Guid("2e9495f0-7ea0-41b5-a492-10d61ba3f0ff"), new Guid("958a9e39-ea52-42a4-bc04-ff14314abc3a"), null, "Руководитель" },
                    { new Guid("306a1f35-14ad-4e26-bfa7-b09265b1c629"), new Guid("c6566db2-748a-4efd-9044-941368404c0e"), null, "Иностранный" },
                    { new Guid("3520b16e-c2ec-47a6-898d-fef18a77d327"), new Guid("f129a86c-981e-4b6d-8789-37e175c6fb3e"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("42d6b249-fe0f-44fa-a65e-8be9901a43c8"), new Guid("73b86c2f-f3c5-460b-a149-9d70f7337970"), null, "Изобретение" },
                    { new Guid("50b9cbe0-23e2-4ee7-b669-d163bdc3e65a"), new Guid("e28b5666-9538-4e41-84b1-a8f36521d34d"), null, "Есть" },
                    { new Guid("5d5bfc01-efd4-4bb3-886a-1dd7a9511a26"), new Guid("ec539051-fff8-4694-b633-916c0ddb1170"), null, "Региональный" },
                    { new Guid("66f33a14-ab21-4b8c-b369-2d82fcabf46d"), new Guid("958a9e39-ea52-42a4-bc04-ff14314abc3a"), null, "Исполнитель" },
                    { new Guid("6cc2309f-a8be-4573-ac2d-cc1ca9f0f138"), new Guid("e28b5666-9538-4e41-84b1-a8f36521d34d"), null, "Нет" },
                    { new Guid("6cdfa267-427c-465c-a810-a3f039d8ece0"), new Guid("f129a86c-981e-4b6d-8789-37e175c6fb3e"), null, "Монография" },
                    { new Guid("7551a615-d199-4871-867a-06770c85dc2e"), new Guid("8fd60b4b-bd06-4e32-acdc-a20e3d3816d8"), null, "Лабораторные" },
                    { new Guid("7a3424f3-dbcc-4ab8-9647-80d877d5f131"), new Guid("c6566db2-748a-4efd-9044-941368404c0e"), null, "Русский" },
                    { new Guid("817db17d-a7fc-4054-a0de-f435b6038c50"), new Guid("29180656-91ab-4746-b1da-0c6d50a8feb8"), null, "Изобретение" },
                    { new Guid("8497963e-e565-4abb-a278-eb351a7a79cf"), new Guid("73b86c2f-f3c5-460b-a149-9d70f7337970"), null, "База данных" },
                    { new Guid("aa1cdcde-bd78-4f24-9b6e-cc8cdb9523e6"), new Guid("ec539051-fff8-4694-b633-916c0ddb1170"), null, "Всероссийский" },
                    { new Guid("e9339380-4daa-4cb9-9870-a6fddda6affc"), new Guid("f129a86c-981e-4b6d-8789-37e175c6fb3e"), null, "Учебник" },
                    { new Guid("eeb92ad7-0773-492f-abff-464831de6fa3"), new Guid("5171f04a-b8ef-4236-b89f-93a3b276f270"), null, "Нет" },
                    { new Guid("ef37fa1b-ad1c-4b7d-99bc-db707090679a"), new Guid("29180656-91ab-4746-b1da-0c6d50a8feb8"), null, "База данных" },
                    { new Guid("f41282b5-f7ab-4995-91e3-a31537981b88"), new Guid("29180656-91ab-4746-b1da-0c6d50a8feb8"), null, "Полезная модель" }
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
