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
                    { new Guid("59e8877b-0e1d-4a7c-b18c-c83c89734c60"), 5, "Отклонена" },
                    { new Guid("5b511bd2-3eee-4625-ba0f-690aec29e8b9"), 4, "Одобрена" },
                    { new Guid("82a325ad-39c4-4714-9428-0fd57d69d4b7"), 2, "В ожидании рассмотрения" },
                    { new Guid("a639b1b7-c845-4234-9ba6-0a153c6e6b22"), 3, "В процессе рассмотрения" },
                    { new Guid("b6fb5915-53ba-4838-970a-f7869a83d5f8"), 1, "В ожидании заполнения" },
                    { new Guid("f41ccc49-7fe2-4c75-af70-494896bafd80"), 6, "Оценена" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d6fdc85-1fd0-49e9-88f5-12239e733a51", null, "Admin", "ADMIN" },
                    { "36506423-4967-40a1-8ab2-a172cca314b4", null, "Voter", "VOTER" },
                    { "3cb27a85-0f83-4177-a649-f86debbd1952", null, "Participant", "PARTICIPANT" },
                    { "7b6d371e-26fc-450f-9f31-9539f8101126", null, "Organiser", "ORGANISER" },
                    { "a11ec3f3-0c12-42a4-8f58-1acdd15ac8f3", null, "Expert", "EXPERT" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("4170fbdf-4682-44df-9e44-91fd966cfbe5"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("7c62bcd9-4845-4041-96b6-27c93b6016a4"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("274c34c4-3be6-4189-881f-3955667edacb"), "Профессиональное развитие", 3 },
                    { new Guid("66c4c2b8-083e-4879-8be8-e55654441048"), "Деятельность", 5 },
                    { new Guid("791808b8-c1a3-4ec5-b6b8-b2db1d38b7f2"), "Деятельность", 4 },
                    { new Guid("87363af2-d58f-4421-8be2-91f8cea77f66"), "Общая информация", 1 },
                    { new Guid("97c0bc37-8697-42b9-98af-0957ce4b5a88"), "Категория участников", 2 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab"), "Основной", 1 },
                    { new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("43ace87c-f3af-4b04-89ea-35bafa0a5d34"), "Профессиональные показатели", 4 },
                    { new Guid("557f2197-b9cd-4ddb-bfb1-6c129e2797a4"), "Методическая деятельность", 3 },
                    { new Guid("afbb4ba1-2323-4c76-9d4b-81ed5f7934cf"), "Конкурсная работа", 7 },
                    { new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe"), "Образовательная деятельность", 2 },
                    { new Guid("ea2413d9-7d54-4eea-9cf2-1e7a42727d22"), "Инновационная и иная деятельность", 6 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("6c793e27-24db-4c22-8988-89394cee6d64"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("d0be49ea-1207-4f64-ba87-4a0497d0fb97"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("400db9ab-8cbf-42e6-bb92-20263b48ecd0"), "DateTime" },
                    { new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e"), "int" },
                    { new Guid("649f9dd0-1a6a-40ea-84b5-193538e74046"), "TextArea" },
                    { new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7"), "string" },
                    { new Guid("80a48873-43f8-4c09-869b-3689105ea1d0"), "bool" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("274c34c4-3be6-4189-881f-3955667edacb"), new Guid("6c793e27-24db-4c22-8988-89394cee6d64") },
                    { new Guid("274c34c4-3be6-4189-881f-3955667edacb"), new Guid("d0be49ea-1207-4f64-ba87-4a0497d0fb97") },
                    { new Guid("66c4c2b8-083e-4879-8be8-e55654441048"), new Guid("d0be49ea-1207-4f64-ba87-4a0497d0fb97") },
                    { new Guid("791808b8-c1a3-4ec5-b6b8-b2db1d38b7f2"), new Guid("6c793e27-24db-4c22-8988-89394cee6d64") },
                    { new Guid("87363af2-d58f-4421-8be2-91f8cea77f66"), new Guid("6c793e27-24db-4c22-8988-89394cee6d64") },
                    { new Guid("87363af2-d58f-4421-8be2-91f8cea77f66"), new Guid("d0be49ea-1207-4f64-ba87-4a0497d0fb97") },
                    { new Guid("97c0bc37-8697-42b9-98af-0957ce4b5a88"), new Guid("6c793e27-24db-4c22-8988-89394cee6d64") },
                    { new Guid("97c0bc37-8697-42b9-98af-0957ce4b5a88"), new Guid("d0be49ea-1207-4f64-ba87-4a0497d0fb97") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("1c4f7db3-cfbb-4fb7-8836-9b71e108f6e6"), new Guid("97c0bc37-8697-42b9-98af-0957ce4b5a88"), null, true, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("2ae2973a-a96c-4bed-af10-10b05e9efa34"), new Guid("87363af2-d58f-4421-8be2-91f8cea77f66"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("3b1925e6-01a7-484b-8e36-06298fe51b78"), new Guid("97c0bc37-8697-42b9-98af-0957ce4b5a88"), null, true, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("454b4c90-1f06-42c0-b679-13d204741811"), new Guid("87363af2-d58f-4421-8be2-91f8cea77f66"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("5f85073f-0d5b-468e-abdd-d14b29182ad1"), new Guid("791808b8-c1a3-4ec5-b6b8-b2db1d38b7f2"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("6ae3891d-3d4c-4fe1-b5a0-120f523a9c0e"), new Guid("87363af2-d58f-4421-8be2-91f8cea77f66"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("400db9ab-8cbf-42e6-bb92-20263b48ecd0") },
                    { new Guid("78cf487f-c6d9-4bf3-a3f7-2c2528aac0ba"), new Guid("791808b8-c1a3-4ec5-b6b8-b2db1d38b7f2"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("7e0f49bf-2323-4c69-b176-e9d4c9da6734"), new Guid("97c0bc37-8697-42b9-98af-0957ce4b5a88"), null, false, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("95ea6168-eae7-4d12-b9dd-93e6e3a807b3"), new Guid("87363af2-d58f-4421-8be2-91f8cea77f66"), null, true, true, "Место работы/учебы", 6, "Название организации", new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("978829c2-9a1a-4c1c-84ea-af8445c19905"), new Guid("87363af2-d58f-4421-8be2-91f8cea77f66"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("b5ad2e26-10d0-483f-9696-38de82e2e341"), new Guid("87363af2-d58f-4421-8be2-91f8cea77f66"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("c0e1a548-4d40-4a03-9c7c-47bceb78cc08"), new Guid("97c0bc37-8697-42b9-98af-0957ce4b5a88"), null, false, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("ccd24fd6-bc99-4369-babc-f6c3fce4b2fb"), new Guid("791808b8-c1a3-4ec5-b6b8-b2db1d38b7f2"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("d66f7dd0-88ad-43d0-af74-d2d86c18efca"), new Guid("66c4c2b8-083e-4879-8be8-e55654441048"), null, false, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("f175752f-5475-4005-ae0e-71c9e2dd8c33"), new Guid("66c4c2b8-083e-4879-8be8-e55654441048"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("f509fbd0-9751-45f8-8c7f-eaf247952374"), new Guid("87363af2-d58f-4421-8be2-91f8cea77f66"), null, false, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("f686c0b1-5882-427a-bf39-276d3b7070a0"), new Guid("87363af2-d58f-4421-8be2-91f8cea77f66"), null, false, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("fa8a9bff-8017-43c4-8b7d-270ff2b7a833"), new Guid("87363af2-d58f-4421-8be2-91f8cea77f66"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("ff9a90cc-640a-48bd-a9a9-fc6e135b0de2"), new Guid("87363af2-d58f-4421-8be2-91f8cea77f66"), null, true, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab"), new Guid("6c793e27-24db-4c22-8988-89394cee6d64") },
                    { new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab"), new Guid("d0be49ea-1207-4f64-ba87-4a0497d0fb97") },
                    { new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd"), new Guid("d0be49ea-1207-4f64-ba87-4a0497d0fb97") },
                    { new Guid("43ace87c-f3af-4b04-89ea-35bafa0a5d34"), new Guid("6c793e27-24db-4c22-8988-89394cee6d64") },
                    { new Guid("557f2197-b9cd-4ddb-bfb1-6c129e2797a4"), new Guid("6c793e27-24db-4c22-8988-89394cee6d64") },
                    { new Guid("afbb4ba1-2323-4c76-9d4b-81ed5f7934cf"), new Guid("6c793e27-24db-4c22-8988-89394cee6d64") },
                    { new Guid("afbb4ba1-2323-4c76-9d4b-81ed5f7934cf"), new Guid("d0be49ea-1207-4f64-ba87-4a0497d0fb97") },
                    { new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe"), new Guid("6c793e27-24db-4c22-8988-89394cee6d64") },
                    { new Guid("ea2413d9-7d54-4eea-9cf2-1e7a42727d22"), new Guid("d0be49ea-1207-4f64-ba87-4a0497d0fb97") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("02c80668-3187-4ed9-bc61-3844ac66963f"), new Guid("791808b8-c1a3-4ec5-b6b8-b2db1d38b7f2"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("128817a6-fdb7-44e8-b7c8-0beeb52f207d"), new Guid("66c4c2b8-083e-4879-8be8-e55654441048"), false, false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("22f1d4f4-f36c-4b06-9875-ca0e34ba54d3"), new Guid("791808b8-c1a3-4ec5-b6b8-b2db1d38b7f2"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("615e6ee8-5487-43d0-acbb-82eb07534fe9"), new Guid("791808b8-c1a3-4ec5-b6b8-b2db1d38b7f2"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("7076770b-3688-4245-96b2-602116b20250"), new Guid("97c0bc37-8697-42b9-98af-0957ce4b5a88"), true, true, "Краткая аннотация конкурсной работы", 14 },
                    { new Guid("75b85878-3db2-448b-b455-638032865ae8"), new Guid("274c34c4-3be6-4189-881f-3955667edacb"), false, false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("a4648860-1193-4dcd-b84a-563d822482d3"), new Guid("791808b8-c1a3-4ec5-b6b8-b2db1d38b7f2"), false, false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("a530871b-cddd-4d2f-8480-20721be466af"), new Guid("274c34c4-3be6-4189-881f-3955667edacb"), true, true, "Персональные идентификаторы", 10 },
                    { new Guid("a67f58d6-8828-49a8-8466-898030b2bf92"), new Guid("274c34c4-3be6-4189-881f-3955667edacb"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("c13e6c4f-be7f-4316-855c-706d5b791158"), new Guid("66c4c2b8-083e-4879-8be8-e55654441048"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("ddb04cf1-e3e5-45c6-ab42-590a01c88599"), new Guid("66c4c2b8-083e-4879-8be8-e55654441048"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("e32c50e6-6379-471e-9a00-a3c2c2b240c3"), new Guid("66c4c2b8-083e-4879-8be8-e55654441048"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("e958e17c-bcc5-41d6-a73c-040fcafd9c20"), new Guid("791808b8-c1a3-4ec5-b6b8-b2db1d38b7f2"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("ea55b18f-6d99-4696-83d5-11b6202c7603"), new Guid("791808b8-c1a3-4ec5-b6b8-b2db1d38b7f2"), false, false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("03137e2a-f423-4a48-8266-ad9d782c6c84"), true, "Год", 4, new Guid("22f1d4f4-f36c-4b06-9875-ca0e34ba54d3"), new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("09985786-f2b4-4b7d-a646-533c8f72e529"), true, "Название конкурса", 2, new Guid("75b85878-3db2-448b-b455-638032865ae8"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("0fcbb692-b5f5-4b6c-966d-b1aed2ba3838"), true, "Ссылка", 5, new Guid("75b85878-3db2-448b-b455-638032865ae8"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("14b8d1b2-1f40-4a96-ac8d-acdf8e23944e"), true, "Название организации в которую внедрена разработка", 3, new Guid("e32c50e6-6379-471e-9a00-a3c2c2b240c3"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("156d5898-8e76-4788-8c60-c4e41396f194"), true, "Статус (руководитель/исполнитель)", 4, new Guid("c13e6c4f-be7f-4316-855c-706d5b791158"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("1576e1aa-b186-4a2e-a8ea-fca4e48c1857"), true, "Период выполнения", 3, new Guid("c13e6c4f-be7f-4316-855c-706d5b791158"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("1612562f-003b-4c57-a1bc-fb9566d3cf8a"), true, "Награда", 4, new Guid("75b85878-3db2-448b-b455-638032865ae8"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("1bb85474-fd6e-4753-8dea-09cbddd79996"), true, "Вид деятельности (преподавательская)", 3, new Guid("a4648860-1193-4dcd-b84a-563d822482d3"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("1d801d3c-4f9f-419c-98d5-592b5026a95d"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("c13e6c4f-be7f-4316-855c-706d5b791158"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("2d0e194a-e942-4429-853e-1f1ca81c1e0e"), true, "Название статьи", 1, new Guid("128817a6-fdb7-44e8-b7c8-0beeb52f207d"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("32533c81-e263-4e6c-bc44-9fd4a27f0082"), true, "Название НИР/НИОКР", 1, new Guid("c13e6c4f-be7f-4316-855c-706d5b791158"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("3a7aee5d-0fc4-4561-a929-64ebbb5bb63b"), true, "Номер РИД", 4, new Guid("ddb04cf1-e3e5-45c6-ab42-590a01c88599"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("3b68ff15-4d54-4f3d-a08a-9320032fe682"), false, "Соавторы", 3, new Guid("ea55b18f-6d99-4696-83d5-11b6202c7603"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("4025d0fd-60df-497b-8440-6d8a618a09dd"), true, "Название", 2, new Guid("ea55b18f-6d99-4696-83d5-11b6202c7603"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("40c7f5ff-6bdd-4d6e-8add-5c562726c080"), true, "Соавторы", 2, new Guid("128817a6-fdb7-44e8-b7c8-0beeb52f207d"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("42f60115-e1f5-4a6d-b6f5-282737626664"), true, "Вид", 1, new Guid("ddb04cf1-e3e5-45c6-ab42-590a01c88599"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("46870f0a-dfd7-4ce2-96ad-ac73193df803"), true, "Год", 3, new Guid("e958e17c-bcc5-41d6-a73c-040fcafd9c20"), new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("4adb6a74-07fb-4fec-b410-189864828f41"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("e958e17c-bcc5-41d6-a73c-040fcafd9c20"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("58ed95ab-4656-4222-9ea1-be07bea84989"), true, "Название курса", 1, new Guid("22f1d4f4-f36c-4b06-9875-ca0e34ba54d3"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("5d531bf8-82f8-4da4-93f2-c47dfc62dcd5"), true, "Название организации/должность/ставка", 1, new Guid("a4648860-1193-4dcd-b84a-563d822482d3"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("6ab3c556-5362-46b3-bb39-e6b6004e9816"), true, "Название документа, реквизиты", 1, new Guid("a67f58d6-8828-49a8-8466-898030b2bf92"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("6e729703-7cf9-4d13-9666-d405461a6af9"), true, "Вид публикации", 1, new Guid("ea55b18f-6d99-4696-83d5-11b6202c7603"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("753baec6-0329-43ca-bf73-ddd99b7fe83e"), true, "Лекции (час.)", 3, new Guid("615e6ee8-5487-43d0-acbb-82eb07534fe9"), new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("76250b4f-7a2b-4d60-acff-f8339f5ccf10"), true, "Издательство, год", 6, new Guid("ea55b18f-6d99-4696-83d5-11b6202c7603"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("78b523cc-4790-4dbd-adf8-58fa91498ce5"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("a4648860-1193-4dcd-b84a-563d822482d3"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("7b345523-597b-43bd-ae4a-e8bd059b9088"), true, "Вид", 1, new Guid("e32c50e6-6379-471e-9a00-a3c2c2b240c3"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("7b94b4a3-9582-4641-a8c6-70d33ae8625f"), true, "Язык публикации", 7, new Guid("ea55b18f-6d99-4696-83d5-11b6202c7603"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("7e1a32b8-a08a-4a90-9eb1-c3a028782902"), true, "Название", 1, new Guid("7076770b-3688-4245-96b2-602116b20250"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("83810f7d-d771-4e70-936f-d32243f3b441"), true, "ФИО соавторов", 3, new Guid("ddb04cf1-e3e5-45c6-ab42-590a01c88599"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("84112e12-03d5-4619-8c91-5d9ab3effd20"), true, "Название разработки", 2, new Guid("e32c50e6-6379-471e-9a00-a3c2c2b240c3"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("8752d00b-6000-49fa-af6f-0312e2a8b0f3"), true, "Название дисциплины", 1, new Guid("02c80668-3187-4ed9-bc61-3844ac66963f"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("9093ce8f-f009-4125-9728-feee371859c3"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("e958e17c-bcc5-41d6-a73c-040fcafd9c20"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("9f230d27-9a6f-4c8c-9c0d-5cdbed3f8d1d"), true, "Издание, год", 4, new Guid("128817a6-fdb7-44e8-b7c8-0beeb52f207d"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("a815baf3-ca3e-440c-b0d7-b6cddd5d5bcb"), false, "Идентификатор", 2, new Guid("a530871b-cddd-4d2f-8480-20721be466af"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("a992f9a0-27d4-4a65-be9e-958977b1aaa2"), true, "ФИО", 1, new Guid("e958e17c-bcc5-41d6-a73c-040fcafd9c20"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("b10c4610-2d65-482e-82d0-e9e4bb1a4c1a"), true, "Наличие грифа", 5, new Guid("ea55b18f-6d99-4696-83d5-11b6202c7603"), new Guid("80a48873-43f8-4c09-869b-3689105ea1d0") },
                    { new Guid("b3117a95-6da6-4557-aebb-f0e0148a6485"), true, "Название конкурса/премии", 2, new Guid("e958e17c-bcc5-41d6-a73c-040fcafd9c20"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("b7043035-7daa-45dd-b449-33ef610793ba"), true, "Итого (час.)", 5, new Guid("615e6ee8-5487-43d0-acbb-82eb07534fe9"), new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("b97d7b98-a7e2-47f9-b8aa-7f19febbb4f3"), true, "Ссылка на платформу", 3, new Guid("22f1d4f4-f36c-4b06-9875-ca0e34ba54d3"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("bdbc1cc8-e481-4ea9-b9fb-fb5d024e779a"), true, "Вид (лекции, лабораторные)", 2, new Guid("02c80668-3187-4ed9-bc61-3844ac66963f"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("c15fbf43-4aac-403e-acba-1a997b47b697"), true, "Количество печатных листов", 4, new Guid("ea55b18f-6d99-4696-83d5-11b6202c7603"), new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("c22150b6-02ad-4c5b-8a96-7dc2a3f9ad4a"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("128817a6-fdb7-44e8-b7c8-0beeb52f207d"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("c2b6d712-0b2e-49ff-905d-817c69011853"), true, "Статус конкурса", 3, new Guid("75b85878-3db2-448b-b455-638032865ae8"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("c436c54c-3b7c-4f36-b92a-27f85027909b"), true, "Количество часов", 4, new Guid("a4648860-1193-4dcd-b84a-563d822482d3"), new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("d045d4e2-988e-4ace-a455-63c386a0ad1b"), true, "Название", 2, new Guid("ddb04cf1-e3e5-45c6-ab42-590a01c88599"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("d18b498c-a26f-4ead-afdd-4579ef5ef82f"), false, "Тип идентификатора", 1, new Guid("a530871b-cddd-4d2f-8480-20721be466af"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("d22cd13c-e051-4095-a4ab-1d4ebe3fd4aa"), true, "Значение", 2, new Guid("7076770b-3688-4245-96b2-602116b20250"), new Guid("649f9dd0-1a6a-40ea-84b5-193538e74046") },
                    { new Guid("d371f43a-e661-44e9-bca9-81ff7bba328e"), true, "Практические занятия (час.)", 4, new Guid("615e6ee8-5487-43d0-acbb-82eb07534fe9"), new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("dab92c53-cce6-42e9-b50e-142bd49ccb58"), true, "Год получения документа", 2, new Guid("a67f58d6-8828-49a8-8466-898030b2bf92"), new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("dce1b57d-95b1-4421-9ec7-571a03d43da0"), true, "Соавторы", 2, new Guid("22f1d4f4-f36c-4b06-9875-ca0e34ba54d3"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("dd1a00f1-8341-4c64-be40-52a5916c4317"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("615e6ee8-5487-43d0-acbb-82eb07534fe9"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("e312fa0a-71a5-4e1c-92d5-62fa7745a1a2"), true, "Наименование курса", 1, new Guid("615e6ee8-5487-43d0-acbb-82eb07534fe9"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("f18ecfbb-724c-4e17-939a-52d873ad3273"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("02c80668-3187-4ed9-bc61-3844ac66963f"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("f4a93999-8162-42c1-a76f-f8a01a49261b"), true, "Год", 1, new Guid("75b85878-3db2-448b-b455-638032865ae8"), new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") },
                    { new Guid("f5a83853-0645-40f1-a5f1-238f82bff08e"), true, "Ссылка на открытый доступ", 8, new Guid("ea55b18f-6d99-4696-83d5-11b6202c7603"), new Guid("64fdf9f3-ee4a-4c7a-b022-7425f656abc7") },
                    { new Guid("fb0ee871-596f-4c83-855d-1a5931074f0f"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("c13e6c4f-be7f-4316-855c-706d5b791158"), new Guid("4d969886-fc1f-40ed-8a1e-2014fec7c01e") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("1c4f7db3-cfbb-4fb7-8836-9b71e108f6e6"), new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab") },
                    { new Guid("2ae2973a-a96c-4bed-af10-10b05e9efa34"), new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab") },
                    { new Guid("3b1925e6-01a7-484b-8e36-06298fe51b78"), new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab") },
                    { new Guid("3b1925e6-01a7-484b-8e36-06298fe51b78"), new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd") },
                    { new Guid("3b1925e6-01a7-484b-8e36-06298fe51b78"), new Guid("43ace87c-f3af-4b04-89ea-35bafa0a5d34") },
                    { new Guid("454b4c90-1f06-42c0-b679-13d204741811"), new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab") },
                    { new Guid("5f85073f-0d5b-468e-abdd-d14b29182ad1"), new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe") },
                    { new Guid("6ae3891d-3d4c-4fe1-b5a0-120f523a9c0e"), new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab") },
                    { new Guid("78cf487f-c6d9-4bf3-a3f7-2c2528aac0ba"), new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe") },
                    { new Guid("7e0f49bf-2323-4c69-b176-e9d4c9da6734"), new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab") },
                    { new Guid("95ea6168-eae7-4d12-b9dd-93e6e3a807b3"), new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab") },
                    { new Guid("978829c2-9a1a-4c1c-84ea-af8445c19905"), new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab") },
                    { new Guid("b5ad2e26-10d0-483f-9696-38de82e2e341"), new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab") },
                    { new Guid("c0e1a548-4d40-4a03-9c7c-47bceb78cc08"), new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab") },
                    { new Guid("ccd24fd6-bc99-4369-babc-f6c3fce4b2fb"), new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe") },
                    { new Guid("d66f7dd0-88ad-43d0-af74-d2d86c18efca"), new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd") },
                    { new Guid("f175752f-5475-4005-ae0e-71c9e2dd8c33"), new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd") },
                    { new Guid("f509fbd0-9751-45f8-8c7f-eaf247952374"), new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab") },
                    { new Guid("f686c0b1-5882-427a-bf39-276d3b7070a0"), new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab") },
                    { new Guid("fa8a9bff-8017-43c4-8b7d-270ff2b7a833"), new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab") },
                    { new Guid("ff9a90cc-640a-48bd-a9a9-fc6e135b0de2"), new Guid("2a21ec4c-ac34-4634-9ed8-e04f6e267aab") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd"), new Guid("128817a6-fdb7-44e8-b7c8-0beeb52f207d") },
                    { new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd"), new Guid("75b85878-3db2-448b-b455-638032865ae8") },
                    { new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd"), new Guid("a530871b-cddd-4d2f-8480-20721be466af") },
                    { new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd"), new Guid("c13e6c4f-be7f-4316-855c-706d5b791158") },
                    { new Guid("43ace87c-f3af-4b04-89ea-35bafa0a5d34"), new Guid("75b85878-3db2-448b-b455-638032865ae8") },
                    { new Guid("43ace87c-f3af-4b04-89ea-35bafa0a5d34"), new Guid("a67f58d6-8828-49a8-8466-898030b2bf92") },
                    { new Guid("557f2197-b9cd-4ddb-bfb1-6c129e2797a4"), new Guid("02c80668-3187-4ed9-bc61-3844ac66963f") },
                    { new Guid("557f2197-b9cd-4ddb-bfb1-6c129e2797a4"), new Guid("ea55b18f-6d99-4696-83d5-11b6202c7603") },
                    { new Guid("afbb4ba1-2323-4c76-9d4b-81ed5f7934cf"), new Guid("7076770b-3688-4245-96b2-602116b20250") },
                    { new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe"), new Guid("22f1d4f4-f36c-4b06-9875-ca0e34ba54d3") },
                    { new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe"), new Guid("615e6ee8-5487-43d0-acbb-82eb07534fe9") },
                    { new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe"), new Guid("a4648860-1193-4dcd-b84a-563d822482d3") },
                    { new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe"), new Guid("e958e17c-bcc5-41d6-a73c-040fcafd9c20") },
                    { new Guid("ea2413d9-7d54-4eea-9cf2-1e7a42727d22"), new Guid("a67f58d6-8828-49a8-8466-898030b2bf92") },
                    { new Guid("ea2413d9-7d54-4eea-9cf2-1e7a42727d22"), new Guid("ddb04cf1-e3e5-45c6-ab42-590a01c88599") },
                    { new Guid("ea2413d9-7d54-4eea-9cf2-1e7a42727d22"), new Guid("e32c50e6-6379-471e-9a00-a3c2c2b240c3") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("04c9e1d3-b337-4d2d-b05d-21826839fad0"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("e32c50e6-6379-471e-9a00-a3c2c2b240c3") },
                    { new Guid("1113c9e0-da52-43b3-8b96-8aecb26dc48c"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("ddb04cf1-e3e5-45c6-ab42-590a01c88599") },
                    { new Guid("20a318ee-ae30-4c5c-bab6-839d30a2e2a2"), null, null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("7076770b-3688-4245-96b2-602116b20250") },
                    { new Guid("2f87d206-17d1-4e9d-b5c7-f209b142a0a5"), "EvaluateMark19", new Guid("f175752f-5475-4005-ae0e-71c9e2dd8c33"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("47e79cf8-5bb5-4132-8a92-128f20fe1156"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("02c80668-3187-4ed9-bc61-3844ac66963f") },
                    { new Guid("48e29102-221c-4b52-bba9-34e5656aadc6"), "EvaluateMark4", new Guid("78cf487f-c6d9-4bf3-a3f7-2c2528aac0ba"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("4d720371-31b5-4def-8564-1c9a94e70e43"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("c13e6c4f-be7f-4316-855c-706d5b791158") },
                    { new Guid("4ecb0a00-7df3-4170-b0da-20dbe7dd1636"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("75b85878-3db2-448b-b455-638032865ae8") },
                    { new Guid("50664347-e2b9-4750-a5d5-7265bd861968"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("22f1d4f4-f36c-4b06-9875-ca0e34ba54d3") },
                    { new Guid("59a9121b-f45d-4657-9b74-64c8f5e09e17"), "EvaluateMark20", new Guid("d66f7dd0-88ad-43d0-af74-d2d86c18efca"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("72325da9-618f-43d4-af51-d0c5f3fa89a6"), "EvaluateMark3", new Guid("5f85073f-0d5b-468e-abdd-d14b29182ad1"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("78281c78-5f32-4f25-b560-d0de55a78505"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("128817a6-fdb7-44e8-b7c8-0beeb52f207d") },
                    { new Guid("7d64ca03-d780-40ca-a699-2a270a4a4b79"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("615e6ee8-5487-43d0-acbb-82eb07534fe9") },
                    { new Guid("85ac2bb1-56c0-4bef-9d30-44daa935485e"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("ea55b18f-6d99-4696-83d5-11b6202c7603") },
                    { new Guid("9eff9cd7-f1a2-490d-bb2d-4085bea3ebdf"), null, null, false, 10, "Оценка уровня предоставленной работы:", 25, new Guid("7076770b-3688-4245-96b2-602116b20250") },
                    { new Guid("a88d8086-7fc8-4d56-99ac-54ff26be15d3"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("ea55b18f-6d99-4696-83d5-11b6202c7603") },
                    { new Guid("c2f9b2fc-2497-45a3-9195-a5d94cddbc68"), "EvaluateMark13", new Guid("3b1925e6-01a7-484b-8e36-06298fe51b78"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("d7f5ae69-5ca4-4537-9219-311495c5bff2"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("e958e17c-bcc5-41d6-a73c-040fcafd9c20") },
                    { new Guid("d968229b-2eea-4437-915a-320b9f1a0a85"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("ea55b18f-6d99-4696-83d5-11b6202c7603") },
                    { new Guid("d9c1d523-2ffd-476f-ba6e-b855f583a410"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("ea55b18f-6d99-4696-83d5-11b6202c7603") },
                    { new Guid("e39cc744-f383-46c2-972d-01363423c1ce"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("a67f58d6-8828-49a8-8466-898030b2bf92") },
                    { new Guid("f023b3bc-bae6-4b30-8958-f4aada53e510"), "EvaluateMark5", new Guid("ccd24fd6-bc99-4369-babc-f6c3fce4b2fb"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("f2446805-9694-466e-a806-12408a42b7c9"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("c13e6c4f-be7f-4316-855c-706d5b791158") },
                    { new Guid("fe4fb102-79f2-4709-9f18-70cfda7e6a2d"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("615e6ee8-5487-43d0-acbb-82eb07534fe9") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("119cfeb3-e036-4887-ba1b-515b00ed9155"), true, new Guid("7076770b-3688-4245-96b2-602116b20250") },
                    { new Guid("1496eda8-cd84-4579-b594-d66b20da567c"), true, new Guid("7076770b-3688-4245-96b2-602116b20250") },
                    { new Guid("2404c47c-0f97-42ba-8a16-32a0f3679b65"), true, new Guid("7076770b-3688-4245-96b2-602116b20250") },
                    { new Guid("3954f53b-e37e-48c5-923c-06438df6bad4"), true, new Guid("7076770b-3688-4245-96b2-602116b20250") },
                    { new Guid("39cd01ba-fee1-45d7-b375-e1d79d212195"), true, new Guid("7076770b-3688-4245-96b2-602116b20250") },
                    { new Guid("3b44f356-e3a0-4724-aee4-a9c49a34a2d4"), true, new Guid("a530871b-cddd-4d2f-8480-20721be466af") },
                    { new Guid("3fa9474e-6ad9-42fd-8dd2-3832a7e311d2"), true, new Guid("a530871b-cddd-4d2f-8480-20721be466af") },
                    { new Guid("440e4656-ee68-498e-8b4e-84be6fff5c2f"), true, new Guid("a530871b-cddd-4d2f-8480-20721be466af") },
                    { new Guid("44e520d2-70fd-452c-ad40-d17b4184c086"), true, new Guid("a530871b-cddd-4d2f-8480-20721be466af") },
                    { new Guid("760c0c32-366e-4715-a86a-89d7c2c67be5"), true, new Guid("7076770b-3688-4245-96b2-602116b20250") },
                    { new Guid("a04ab0d9-ef70-4c43-a74f-cff52c5347f5"), true, new Guid("a530871b-cddd-4d2f-8480-20721be466af") },
                    { new Guid("ab1109a0-2cfe-4669-bfb8-86960b6c1546"), true, new Guid("7076770b-3688-4245-96b2-602116b20250") },
                    { new Guid("eeb6e700-0d51-4c82-8eb7-73e6573af974"), true, new Guid("7076770b-3688-4245-96b2-602116b20250") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0b3c30eb-a489-43c3-95de-fad7c9f33b0f"), null, new Guid("3b1925e6-01a7-484b-8e36-06298fe51b78"), "Профессор" },
                    { new Guid("4cbdce2e-f2aa-4d40-bd01-2f86a40a8ea0"), null, new Guid("7e0f49bf-2323-4c69-b176-e9d4c9da6734"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("69013177-22ce-4932-837b-ce5f8d60aefa"), null, new Guid("1c4f7db3-cfbb-4fb7-8836-9b71e108f6e6"), "Кандидат наук" },
                    { new Guid("87170df3-86ee-45cf-8250-770b9e6672a3"), null, new Guid("3b1925e6-01a7-484b-8e36-06298fe51b78"), "Доцент" },
                    { new Guid("c1ebb57a-59cd-43be-bc7d-d7618869bd45"), null, new Guid("7e0f49bf-2323-4c69-b176-e9d4c9da6734"), "Имеющие ученую степень доктора наук" },
                    { new Guid("d12e7cc7-d46e-41bb-b685-5cb6cc7a2017"), null, new Guid("3b1925e6-01a7-484b-8e36-06298fe51b78"), "Нет" },
                    { new Guid("d862adcb-bb6d-461b-8754-de8e55b005e1"), null, new Guid("1c4f7db3-cfbb-4fb7-8836-9b71e108f6e6"), "Доктор наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("04655cec-f8aa-4d90-9edb-e963edfd8ef6"), null, new Guid("d22cd13c-e051-4095-a4ab-1d4ebe3fd4aa"), false, true, new Guid("eeb6e700-0d51-4c82-8eb7-73e6573af974"), null },
                    { new Guid("09566cce-7c25-4089-b433-cef602b21e4e"), null, new Guid("a815baf3-ca3e-440c-b0d7-b6cddd5d5bcb"), false, true, new Guid("3fa9474e-6ad9-42fd-8dd2-3832a7e311d2"), null },
                    { new Guid("3971f7a4-2986-40d5-a001-7c354658c12c"), null, new Guid("7e1a32b8-a08a-4a90-9eb1-c3a028782902"), true, true, new Guid("3954f53b-e37e-48c5-923c-06438df6bad4"), "Методология и методы, используемые в работе" },
                    { new Guid("3bbcb9f0-d961-43fe-b581-e7212e29e111"), null, new Guid("d18b498c-a26f-4ead-afdd-4579ef5ef82f"), true, true, new Guid("3fa9474e-6ad9-42fd-8dd2-3832a7e311d2"), "ScopusID" },
                    { new Guid("420879ec-0bac-4936-8acf-4e82c97355cd"), null, new Guid("7e1a32b8-a08a-4a90-9eb1-c3a028782902"), true, true, new Guid("ab1109a0-2cfe-4669-bfb8-86960b6c1546"), "Название работы" },
                    { new Guid("4a50faae-b73f-4c2c-9200-37b0bbb719bf"), null, new Guid("d22cd13c-e051-4095-a4ab-1d4ebe3fd4aa"), false, true, new Guid("3954f53b-e37e-48c5-923c-06438df6bad4"), null },
                    { new Guid("4e4bf5e0-18ea-4d40-adfc-edfdbe3afceb"), null, new Guid("d22cd13c-e051-4095-a4ab-1d4ebe3fd4aa"), false, true, new Guid("2404c47c-0f97-42ba-8a16-32a0f3679b65"), null },
                    { new Guid("55abfd6a-f53c-47de-a812-d2cf354bf062"), null, new Guid("d18b498c-a26f-4ead-afdd-4579ef5ef82f"), true, true, new Guid("44e520d2-70fd-452c-ad40-d17b4184c086"), "ORCiD" },
                    { new Guid("5c83feb3-7045-416f-a945-c3fb49e7eeaf"), null, new Guid("7e1a32b8-a08a-4a90-9eb1-c3a028782902"), true, true, new Guid("39cd01ba-fee1-45d7-b375-e1d79d212195"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("5e83f58d-cb32-4c20-8575-80020de2c2ba"), null, new Guid("d22cd13c-e051-4095-a4ab-1d4ebe3fd4aa"), false, true, new Guid("119cfeb3-e036-4887-ba1b-515b00ed9155"), null },
                    { new Guid("6ebdeef6-f8a1-4bbc-861f-35ac7a278361"), null, new Guid("a815baf3-ca3e-440c-b0d7-b6cddd5d5bcb"), false, true, new Guid("a04ab0d9-ef70-4c43-a74f-cff52c5347f5"), null },
                    { new Guid("7a997345-909f-470b-9ad9-d056a0a5267f"), null, new Guid("d22cd13c-e051-4095-a4ab-1d4ebe3fd4aa"), false, true, new Guid("ab1109a0-2cfe-4669-bfb8-86960b6c1546"), null },
                    { new Guid("92268e7d-ccd8-4f83-99a8-2968caea6fb6"), null, new Guid("7e1a32b8-a08a-4a90-9eb1-c3a028782902"), true, true, new Guid("1496eda8-cd84-4579-b594-d66b20da567c"), "Ссылка на конкурсную работу" },
                    { new Guid("99609bc6-bcc0-4383-9aa9-cb937d7bfeb0"), null, new Guid("7e1a32b8-a08a-4a90-9eb1-c3a028782902"), true, true, new Guid("2404c47c-0f97-42ba-8a16-32a0f3679b65"), "Инновационность" },
                    { new Guid("a7945baa-71c8-43df-ab3d-44cc77583957"), null, new Guid("d18b498c-a26f-4ead-afdd-4579ef5ef82f"), true, true, new Guid("440e4656-ee68-498e-8b4e-84be6fff5c2f"), "РИНЦ AuthorID" },
                    { new Guid("ae1c3883-74f9-4109-b991-d409d5f9cf9a"), null, new Guid("d22cd13c-e051-4095-a4ab-1d4ebe3fd4aa"), false, true, new Guid("760c0c32-366e-4715-a86a-89d7c2c67be5"), null },
                    { new Guid("b2826d19-676d-41c8-a973-af736a5774fe"), null, new Guid("7e1a32b8-a08a-4a90-9eb1-c3a028782902"), true, true, new Guid("119cfeb3-e036-4887-ba1b-515b00ed9155"), "Актуальность конкурсной работы" },
                    { new Guid("b931670b-0278-4be0-8484-293738297099"), null, new Guid("7e1a32b8-a08a-4a90-9eb1-c3a028782902"), true, true, new Guid("eeb6e700-0d51-4c82-8eb7-73e6573af974"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("c71561f6-1508-4156-9f09-29720c23fe16"), null, new Guid("d18b498c-a26f-4ead-afdd-4579ef5ef82f"), true, true, new Guid("a04ab0d9-ef70-4c43-a74f-cff52c5347f5"), "ResearcherID" },
                    { new Guid("d08ce785-fceb-44fd-933c-f2086f3c0f01"), null, new Guid("d22cd13c-e051-4095-a4ab-1d4ebe3fd4aa"), false, true, new Guid("39cd01ba-fee1-45d7-b375-e1d79d212195"), null },
                    { new Guid("d6ae2f55-dd80-4bf1-afcc-e28abe6d15d7"), null, new Guid("7e1a32b8-a08a-4a90-9eb1-c3a028782902"), true, true, new Guid("760c0c32-366e-4715-a86a-89d7c2c67be5"), "Результаты и выводы" },
                    { new Guid("df4cfd39-f3d0-4c34-9400-6864bc846c9e"), null, new Guid("d18b498c-a26f-4ead-afdd-4579ef5ef82f"), true, true, new Guid("3b44f356-e3a0-4724-aee4-a9c49a34a2d4"), "Google Scholar ID" },
                    { new Guid("e282a2e6-4168-43fa-84e7-655b65c1092a"), null, new Guid("a815baf3-ca3e-440c-b0d7-b6cddd5d5bcb"), false, true, new Guid("440e4656-ee68-498e-8b4e-84be6fff5c2f"), null },
                    { new Guid("e74728b0-35aa-4826-bca5-3d6047809494"), null, new Guid("d22cd13c-e051-4095-a4ab-1d4ebe3fd4aa"), false, true, new Guid("1496eda8-cd84-4579-b594-d66b20da567c"), null },
                    { new Guid("f1f68a89-e154-4ef0-a889-f6cff223337a"), null, new Guid("a815baf3-ca3e-440c-b0d7-b6cddd5d5bcb"), false, true, new Guid("3b44f356-e3a0-4724-aee4-a9c49a34a2d4"), null },
                    { new Guid("f2cf28c1-b3e2-4f2b-a355-44a7b6ef7ba4"), null, new Guid("a815baf3-ca3e-440c-b0d7-b6cddd5d5bcb"), false, true, new Guid("44e520d2-70fd-452c-ad40-d17b4184c086"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd"), new Guid("2f87d206-17d1-4e9d-b5c7-f209b142a0a5") },
                    { new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd"), new Guid("4d720371-31b5-4def-8564-1c9a94e70e43") },
                    { new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd"), new Guid("4ecb0a00-7df3-4170-b0da-20dbe7dd1636") },
                    { new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd"), new Guid("59a9121b-f45d-4657-9b74-64c8f5e09e17") },
                    { new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd"), new Guid("78281c78-5f32-4f25-b560-d0de55a78505") },
                    { new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd"), new Guid("c2f9b2fc-2497-45a3-9195-a5d94cddbc68") },
                    { new Guid("2de08fe2-e010-499b-9c7d-1dfa6e9bb5bd"), new Guid("f2446805-9694-466e-a806-12408a42b7c9") },
                    { new Guid("43ace87c-f3af-4b04-89ea-35bafa0a5d34"), new Guid("4ecb0a00-7df3-4170-b0da-20dbe7dd1636") },
                    { new Guid("43ace87c-f3af-4b04-89ea-35bafa0a5d34"), new Guid("c2f9b2fc-2497-45a3-9195-a5d94cddbc68") },
                    { new Guid("43ace87c-f3af-4b04-89ea-35bafa0a5d34"), new Guid("e39cc744-f383-46c2-972d-01363423c1ce") },
                    { new Guid("557f2197-b9cd-4ddb-bfb1-6c129e2797a4"), new Guid("47e79cf8-5bb5-4132-8a92-128f20fe1156") },
                    { new Guid("557f2197-b9cd-4ddb-bfb1-6c129e2797a4"), new Guid("85ac2bb1-56c0-4bef-9d30-44daa935485e") },
                    { new Guid("557f2197-b9cd-4ddb-bfb1-6c129e2797a4"), new Guid("a88d8086-7fc8-4d56-99ac-54ff26be15d3") },
                    { new Guid("557f2197-b9cd-4ddb-bfb1-6c129e2797a4"), new Guid("d968229b-2eea-4437-915a-320b9f1a0a85") },
                    { new Guid("557f2197-b9cd-4ddb-bfb1-6c129e2797a4"), new Guid("d9c1d523-2ffd-476f-ba6e-b855f583a410") },
                    { new Guid("afbb4ba1-2323-4c76-9d4b-81ed5f7934cf"), new Guid("20a318ee-ae30-4c5c-bab6-839d30a2e2a2") },
                    { new Guid("afbb4ba1-2323-4c76-9d4b-81ed5f7934cf"), new Guid("9eff9cd7-f1a2-490d-bb2d-4085bea3ebdf") },
                    { new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe"), new Guid("48e29102-221c-4b52-bba9-34e5656aadc6") },
                    { new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe"), new Guid("50664347-e2b9-4750-a5d5-7265bd861968") },
                    { new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe"), new Guid("72325da9-618f-43d4-af51-d0c5f3fa89a6") },
                    { new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe"), new Guid("7d64ca03-d780-40ca-a699-2a270a4a4b79") },
                    { new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe"), new Guid("d7f5ae69-5ca4-4537-9219-311495c5bff2") },
                    { new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe"), new Guid("f023b3bc-bae6-4b30-8958-f4aada53e510") },
                    { new Guid("d341d6fd-e5d5-4787-a192-b753fb85fcfe"), new Guid("fe4fb102-79f2-4709-9f18-70cfda7e6a2d") },
                    { new Guid("ea2413d9-7d54-4eea-9cf2-1e7a42727d22"), new Guid("04c9e1d3-b337-4d2d-b05d-21826839fad0") },
                    { new Guid("ea2413d9-7d54-4eea-9cf2-1e7a42727d22"), new Guid("1113c9e0-da52-43b3-8b96-8aecb26dc48c") },
                    { new Guid("ea2413d9-7d54-4eea-9cf2-1e7a42727d22"), new Guid("e39cc744-f383-46c2-972d-01363423c1ce") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("00603b2e-1b2d-4a07-8071-152dcd6578c2"), new Guid("3b68ff15-4d54-4f3d-a08a-9320032fe682"), null, "Есть" },
                    { new Guid("20adc31b-1391-43f5-9c2d-2ea5446823ba"), new Guid("42f60115-e1f5-4a6d-b6f5-282737626664"), null, "База данных" },
                    { new Guid("2850755c-3807-4aa8-b3f8-758beccf4322"), new Guid("156d5898-8e76-4788-8c60-c4e41396f194"), null, "Руководитель" },
                    { new Guid("371971f9-650f-4daa-a1d0-ffe635846a7e"), new Guid("40c7f5ff-6bdd-4d6e-8add-5c562726c080"), null, "Есть" },
                    { new Guid("4467ceaa-4bb6-4cd4-91c8-4bf836d12066"), new Guid("7b345523-597b-43bd-ae4a-e8bd059b9088"), null, "Изобретение" },
                    { new Guid("5745bddc-16bc-4875-a725-c0293d5bb0ca"), new Guid("156d5898-8e76-4788-8c60-c4e41396f194"), null, "Исполнитель" },
                    { new Guid("64fa9212-82ff-452d-8991-3a4661e2ea52"), new Guid("c2b6d712-0b2e-49ff-905d-817c69011853"), null, "Региональный" },
                    { new Guid("76fd2a64-ce3e-49be-92fe-6de4cea63f65"), new Guid("bdbc1cc8-e481-4ea9-b9fb-fb5d024e779a"), null, "Лабораторные" },
                    { new Guid("786b2ef5-321e-400b-8ec1-12cb5d7a8e52"), new Guid("7b345523-597b-43bd-ae4a-e8bd059b9088"), null, "Полезная модель" },
                    { new Guid("7cbb5949-a89a-439a-b773-b9935c0b7525"), new Guid("c2b6d712-0b2e-49ff-905d-817c69011853"), null, "Международный" },
                    { new Guid("824d318f-bedc-43cd-9eea-9d94791fcba1"), new Guid("42f60115-e1f5-4a6d-b6f5-282737626664"), null, "Полезная модель" },
                    { new Guid("91b88c2d-d89b-4a05-9875-bb710d327fea"), new Guid("42f60115-e1f5-4a6d-b6f5-282737626664"), null, "Изобретение" },
                    { new Guid("99fdba75-991f-4407-9e9e-8c4f1e76ebc2"), new Guid("7b94b4a3-9582-4641-a8c6-70d33ae8625f"), null, "Иностранный" },
                    { new Guid("a4a1b100-1312-4f72-86b9-0b0116e186a7"), new Guid("7b345523-597b-43bd-ae4a-e8bd059b9088"), null, "База данных" },
                    { new Guid("bcdfba04-7a2e-41f9-aa17-d3d5e8ab186d"), new Guid("7b94b4a3-9582-4641-a8c6-70d33ae8625f"), null, "Русский" },
                    { new Guid("c1668d94-0d35-441b-bf32-7155ff3246c9"), new Guid("6e729703-7cf9-4d13-9666-d405461a6af9"), null, "Монография" },
                    { new Guid("cd0a4e0c-0e74-4bee-b70b-ed0581ce0a1d"), new Guid("bdbc1cc8-e481-4ea9-b9fb-fb5d024e779a"), null, "Лекции" },
                    { new Guid("dc0bd31c-8396-45a1-8c6d-1805f3271c73"), new Guid("6e729703-7cf9-4d13-9666-d405461a6af9"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("dffc6423-1ebc-4f8b-8aa2-b695e3c2880d"), new Guid("6e729703-7cf9-4d13-9666-d405461a6af9"), null, "Учебник" },
                    { new Guid("e4ddc422-95b7-40e2-af32-10d8c6773170"), new Guid("c2b6d712-0b2e-49ff-905d-817c69011853"), null, "Всероссийский" },
                    { new Guid("f64c5553-f2e8-4828-8f01-b6840b1da1c3"), new Guid("40c7f5ff-6bdd-4d6e-8add-5c562726c080"), null, "Нет" },
                    { new Guid("fe0adfdd-0a4c-42c5-9ce8-9c4693a15b94"), new Guid("3b68ff15-4d54-4f3d-a08a-9320032fe682"), null, "Нет" }
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
