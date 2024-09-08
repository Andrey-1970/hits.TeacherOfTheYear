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
                    { new Guid("07066821-01f4-40c1-a473-264f2742fe01"), 2, "В ожидании рассмотрения" },
                    { new Guid("1399ac53-6e64-48bc-badb-1ee6f57736ef"), 3, "В процессе рассмотрения" },
                    { new Guid("28d43109-a1cf-4a6c-b5a7-e4bdf5376adf"), 5, "Отклонена" },
                    { new Guid("9f55fdd2-f776-4551-bbb8-7ac4e5907188"), 4, "Одобрена" },
                    { new Guid("cdd7d6b2-3d25-4ae2-852d-23bc077fc4da"), 1, "В ожидании заполнения" },
                    { new Guid("d88a5a85-fe36-471a-b9a5-842ca47d6626"), 6, "Оценена" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26b6b285-96c7-4af3-b9c6-ed326bbc2d84", null, "Organiser", "ORGANISER" },
                    { "2a8051e4-3bbf-4eb4-b865-d5d69a1c0fa4", null, "Voter", "VOTER" },
                    { "2ef47e07-57c1-4d81-b689-9cb50feb2c66", null, "Participant", "PARTICIPANT" },
                    { "578a6fa7-f734-4b99-8d43-ee7e3789093f", null, "Expert", "EXPERT" },
                    { "9e2e1341-5967-4900-8d07-762776a43ca7", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("a6d8a873-c393-4d1d-b93c-a44c71926c8d"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("ad20cbd5-2e8d-4d07-8444-e2b5d872db57"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("174c7600-fe2a-4abf-bb40-3d444cb20928"), "Деятельность", 4 },
                    { new Guid("1f7527f0-c53d-44f8-9f49-1d5e6f50f445"), "Профессиональное развитие", 3 },
                    { new Guid("769665b0-2776-405a-a07a-091e271ca9a8"), "Деятельность", 5 },
                    { new Guid("b12a0ded-6543-40c0-9b05-32ef6e5c7083"), "Общая информация", 1 },
                    { new Guid("e323d509-bb68-4543-95a0-5cacf5e8a5f6"), "Категория участников", 2 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("01202277-d0f5-44ac-949c-9a950dffde3e"), "Основной", 1 },
                    { new Guid("04e13ea1-609d-4526-9cab-06e450b13319"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851"), "Образовательная деятельность", 2 },
                    { new Guid("6d29b694-3a81-48ac-9ff8-dd5061024616"), "Профессиональные показатели", 4 },
                    { new Guid("868b5db0-fef1-4f47-a7f2-0617d9bd6096"), "Инновационная и иная деятельность", 6 },
                    { new Guid("8c78e1e0-c9bc-4a75-996e-801fe2c55297"), "Конкурсная работа", 7 },
                    { new Guid("a09e2304-d6ab-4581-aac9-d46ba07ad3f5"), "Методическая деятельность", 3 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("b2d95364-cec2-49a7-b8c2-ac32cba8f6bf"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("feb5cd54-7803-4ac2-a6e5-64ee3c7c7a42"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6f6117c4-4811-42fd-af33-73f28a26752b"), "TextArea" },
                    { new Guid("83b10d07-ce5d-401c-97d3-b91604307dba"), "bool" },
                    { new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b"), "int" },
                    { new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd"), "string" },
                    { new Guid("ec42cc74-8dc0-4c99-93ca-52a837baeed0"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("174c7600-fe2a-4abf-bb40-3d444cb20928"), new Guid("feb5cd54-7803-4ac2-a6e5-64ee3c7c7a42") },
                    { new Guid("1f7527f0-c53d-44f8-9f49-1d5e6f50f445"), new Guid("b2d95364-cec2-49a7-b8c2-ac32cba8f6bf") },
                    { new Guid("1f7527f0-c53d-44f8-9f49-1d5e6f50f445"), new Guid("feb5cd54-7803-4ac2-a6e5-64ee3c7c7a42") },
                    { new Guid("769665b0-2776-405a-a07a-091e271ca9a8"), new Guid("b2d95364-cec2-49a7-b8c2-ac32cba8f6bf") },
                    { new Guid("b12a0ded-6543-40c0-9b05-32ef6e5c7083"), new Guid("b2d95364-cec2-49a7-b8c2-ac32cba8f6bf") },
                    { new Guid("b12a0ded-6543-40c0-9b05-32ef6e5c7083"), new Guid("feb5cd54-7803-4ac2-a6e5-64ee3c7c7a42") },
                    { new Guid("e323d509-bb68-4543-95a0-5cacf5e8a5f6"), new Guid("b2d95364-cec2-49a7-b8c2-ac32cba8f6bf") },
                    { new Guid("e323d509-bb68-4543-95a0-5cacf5e8a5f6"), new Guid("feb5cd54-7803-4ac2-a6e5-64ee3c7c7a42") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("04ae92df-f39c-4545-b4bc-4539ca1817b8"), new Guid("769665b0-2776-405a-a07a-091e271ca9a8"), null, false, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("0e43e37d-fe27-48b7-adcd-19c63711c9c9"), new Guid("174c7600-fe2a-4abf-bb40-3d444cb20928"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("13a010d2-0194-4bea-b73d-83d12cfba5f3"), new Guid("174c7600-fe2a-4abf-bb40-3d444cb20928"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("26d608ae-27d1-4713-9f77-6f260eaae5b9"), new Guid("e323d509-bb68-4543-95a0-5cacf5e8a5f6"), null, true, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("37e4b536-fdb3-48ec-b717-2378e41db4e1"), new Guid("b12a0ded-6543-40c0-9b05-32ef6e5c7083"), null, true, true, "Место работы/учебы", 6, "Название организации", new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("4008c6c0-70fa-4b32-adeb-5f24c7bd863b"), new Guid("e323d509-bb68-4543-95a0-5cacf5e8a5f6"), null, false, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("442bfc14-07da-4cbf-9ad8-74186da039c8"), new Guid("b12a0ded-6543-40c0-9b05-32ef6e5c7083"), null, false, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("54d9379a-1e90-4866-836a-332fade52b68"), new Guid("b12a0ded-6543-40c0-9b05-32ef6e5c7083"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("771bdf26-8012-4b92-9038-d40c93f75900"), new Guid("b12a0ded-6543-40c0-9b05-32ef6e5c7083"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("ec42cc74-8dc0-4c99-93ca-52a837baeed0") },
                    { new Guid("9229a6f8-c5fe-451f-81a8-9c386122b490"), new Guid("b12a0ded-6543-40c0-9b05-32ef6e5c7083"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("9eca51ec-e711-4687-8bbf-1d77a4340483"), new Guid("e323d509-bb68-4543-95a0-5cacf5e8a5f6"), null, false, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("a5e78675-927d-44e6-ae40-2b80144d79ea"), new Guid("769665b0-2776-405a-a07a-091e271ca9a8"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("a8ada6af-69d3-457e-a606-bd67b4cdcbea"), new Guid("b12a0ded-6543-40c0-9b05-32ef6e5c7083"), null, true, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("b5a60246-f0fe-42fc-ba38-70cc9b9bd6b4"), new Guid("b12a0ded-6543-40c0-9b05-32ef6e5c7083"), null, false, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("bfc4a2a6-25cf-451e-94df-e40464599886"), new Guid("b12a0ded-6543-40c0-9b05-32ef6e5c7083"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("c5e8f13e-0a5b-4d91-8e11-88c1f9127914"), new Guid("e323d509-bb68-4543-95a0-5cacf5e8a5f6"), null, true, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("ca63da51-da1d-4975-980f-8675086bfcfa"), new Guid("b12a0ded-6543-40c0-9b05-32ef6e5c7083"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("e22cd182-4c09-4c4a-b94f-652272e63a45"), new Guid("174c7600-fe2a-4abf-bb40-3d444cb20928"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("eef0dfa5-b008-4381-aa77-1cfb05e40de2"), new Guid("b12a0ded-6543-40c0-9b05-32ef6e5c7083"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("01202277-d0f5-44ac-949c-9a950dffde3e"), new Guid("b2d95364-cec2-49a7-b8c2-ac32cba8f6bf") },
                    { new Guid("01202277-d0f5-44ac-949c-9a950dffde3e"), new Guid("feb5cd54-7803-4ac2-a6e5-64ee3c7c7a42") },
                    { new Guid("04e13ea1-609d-4526-9cab-06e450b13319"), new Guid("b2d95364-cec2-49a7-b8c2-ac32cba8f6bf") },
                    { new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851"), new Guid("feb5cd54-7803-4ac2-a6e5-64ee3c7c7a42") },
                    { new Guid("6d29b694-3a81-48ac-9ff8-dd5061024616"), new Guid("feb5cd54-7803-4ac2-a6e5-64ee3c7c7a42") },
                    { new Guid("868b5db0-fef1-4f47-a7f2-0617d9bd6096"), new Guid("b2d95364-cec2-49a7-b8c2-ac32cba8f6bf") },
                    { new Guid("8c78e1e0-c9bc-4a75-996e-801fe2c55297"), new Guid("b2d95364-cec2-49a7-b8c2-ac32cba8f6bf") },
                    { new Guid("8c78e1e0-c9bc-4a75-996e-801fe2c55297"), new Guid("feb5cd54-7803-4ac2-a6e5-64ee3c7c7a42") },
                    { new Guid("a09e2304-d6ab-4581-aac9-d46ba07ad3f5"), new Guid("feb5cd54-7803-4ac2-a6e5-64ee3c7c7a42") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("130e6a34-1378-42f0-93f2-f357591a2f54"), new Guid("174c7600-fe2a-4abf-bb40-3d444cb20928"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("25390f13-f313-404e-b2be-64d3962c8ebb"), new Guid("174c7600-fe2a-4abf-bb40-3d444cb20928"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("285f7db3-3a2b-47fb-9ec1-05b1e2b07e1b"), new Guid("174c7600-fe2a-4abf-bb40-3d444cb20928"), false, false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("4814fe86-adb2-4a1d-84a7-aeeb37e48e76"), new Guid("1f7527f0-c53d-44f8-9f49-1d5e6f50f445"), false, false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("52725f3e-e03c-4f17-abca-4418da928e50"), new Guid("e323d509-bb68-4543-95a0-5cacf5e8a5f6"), true, true, "Краткая аннотация конкурсной работы", 14 },
                    { new Guid("56de4558-e737-450f-9ecd-97f39da4440d"), new Guid("769665b0-2776-405a-a07a-091e271ca9a8"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("672551e0-43b3-4397-a6c4-b643610241ad"), new Guid("174c7600-fe2a-4abf-bb40-3d444cb20928"), false, false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("6bd85eca-5bae-4bc7-b62c-d3454214f918"), new Guid("769665b0-2776-405a-a07a-091e271ca9a8"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("6f01a7ed-8f3f-4734-9200-63a6889954da"), new Guid("174c7600-fe2a-4abf-bb40-3d444cb20928"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("88ce76e2-e90d-454c-9da1-8884aaafb24f"), new Guid("769665b0-2776-405a-a07a-091e271ca9a8"), false, false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("9e6009de-28f7-48c3-8849-2ded2ac89d1e"), new Guid("769665b0-2776-405a-a07a-091e271ca9a8"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("c3966145-c530-48aa-9606-8be1663e92f0"), new Guid("174c7600-fe2a-4abf-bb40-3d444cb20928"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("e110805e-4351-4953-aa7e-fb381470039d"), new Guid("1f7527f0-c53d-44f8-9f49-1d5e6f50f445"), true, true, "Персональные идентификаторы", 10 },
                    { new Guid("f93caa09-221c-4832-986b-578b1150af43"), new Guid("1f7527f0-c53d-44f8-9f49-1d5e6f50f445"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("02a1e0b2-2a7d-4222-b05e-c0e0f173e6cc"), true, "Издание, год", 4, new Guid("88ce76e2-e90d-454c-9da1-8884aaafb24f"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("02e5ab3b-3fcf-4411-b16f-4d146db6155f"), true, "Вид (лекции, лабораторные)", 2, new Guid("130e6a34-1378-42f0-93f2-f357591a2f54"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("03d1d4e5-9ae2-45d8-ae64-4aea867ab3a6"), true, "Название организации в которую внедрена разработка", 3, new Guid("6bd85eca-5bae-4bc7-b62c-d3454214f918"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("0afe1d39-29e9-4083-b821-ceeb1bedee42"), true, "Название организации/должность/ставка", 1, new Guid("285f7db3-3a2b-47fb-9ec1-05b1e2b07e1b"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("1209514c-8614-43d3-a917-f82f72fcf829"), true, "ФИО", 1, new Guid("c3966145-c530-48aa-9606-8be1663e92f0"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("18687b6a-34bf-448e-9527-1da29e1c9ecf"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("56de4558-e737-450f-9ecd-97f39da4440d"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("22c02550-a18c-4c1f-b608-e4a1e46fa931"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("c3966145-c530-48aa-9606-8be1663e92f0"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("22d22328-d6fa-40ad-ac35-bdc508f6fdef"), true, "Вид", 1, new Guid("9e6009de-28f7-48c3-8849-2ded2ac89d1e"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("2af15c50-fac9-485d-a572-5159cf531df0"), true, "Название конкурса", 2, new Guid("4814fe86-adb2-4a1d-84a7-aeeb37e48e76"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("2c57639b-450a-4a03-b24d-8e55c651d20e"), true, "Название", 1, new Guid("52725f3e-e03c-4f17-abca-4418da928e50"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("37fe7f5d-1e2d-4864-8da7-192d9589c7c2"), true, "Название НИР/НИОКР", 1, new Guid("56de4558-e737-450f-9ecd-97f39da4440d"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("385fc350-be76-48dc-9e2f-e80f28410e36"), true, "Соавторы", 2, new Guid("88ce76e2-e90d-454c-9da1-8884aaafb24f"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("3a2b5373-a76a-4082-90a1-ccd590fdbd09"), true, "Соавторы", 2, new Guid("6f01a7ed-8f3f-4734-9200-63a6889954da"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("4e1c8a08-9b02-46f3-9fa7-b956eaf8887c"), true, "Название дисциплины", 1, new Guid("130e6a34-1378-42f0-93f2-f357591a2f54"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("4e52930e-6ea2-47d8-8bc0-021a392e9445"), true, "Название конкурса/премии", 2, new Guid("c3966145-c530-48aa-9606-8be1663e92f0"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("56bcb8b1-c499-418f-a6ff-a889d44969f6"), true, "Год", 1, new Guid("4814fe86-adb2-4a1d-84a7-aeeb37e48e76"), new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("5705932e-0cf1-4165-a8ee-908f70112e2b"), true, "Статус конкурса", 3, new Guid("4814fe86-adb2-4a1d-84a7-aeeb37e48e76"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("57371a47-b66a-4c72-8486-6e92e597740c"), true, "Вид публикации", 1, new Guid("672551e0-43b3-4397-a6c4-b643610241ad"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("5bcca80b-9b5a-49ea-ba79-7a4a2c284bfe"), true, "Год", 3, new Guid("c3966145-c530-48aa-9606-8be1663e92f0"), new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("5d21b112-5c5b-4a74-840e-048861d547c8"), true, "Наличие грифа", 5, new Guid("672551e0-43b3-4397-a6c4-b643610241ad"), new Guid("83b10d07-ce5d-401c-97d3-b91604307dba") },
                    { new Guid("5db7661d-8a84-497d-8310-10361d37a893"), false, "Идентификатор", 2, new Guid("e110805e-4351-4953-aa7e-fb381470039d"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("60815c80-5ae4-4e03-a26b-5387d489abe7"), true, "Ссылка на платформу", 3, new Guid("6f01a7ed-8f3f-4734-9200-63a6889954da"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("645e4ceb-5034-40be-bbcb-99cf28b7b9ab"), true, "ФИО соавторов", 3, new Guid("9e6009de-28f7-48c3-8849-2ded2ac89d1e"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("76db2383-48e6-4ac1-88c8-c68f1aaead3b"), true, "Издательство, год", 6, new Guid("672551e0-43b3-4397-a6c4-b643610241ad"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("786e6be4-2712-40a8-9f5c-b917c2fa7325"), true, "Практические занятия (час.)", 4, new Guid("25390f13-f313-404e-b2be-64d3962c8ebb"), new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("78a0117f-334b-4b67-b6f0-27be38b34357"), false, "Тип идентификатора", 1, new Guid("e110805e-4351-4953-aa7e-fb381470039d"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("80335649-0c48-405f-86f5-9ad2da41cb48"), true, "Номер РИД", 4, new Guid("9e6009de-28f7-48c3-8849-2ded2ac89d1e"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("85ba6c51-cba7-410b-8c6d-3ca133f9bf75"), true, "Название документа, реквизиты", 1, new Guid("f93caa09-221c-4832-986b-578b1150af43"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("86588b53-ab08-4855-82f2-b5f8bbdbdaa3"), true, "Статус (руководитель/исполнитель)", 4, new Guid("56de4558-e737-450f-9ecd-97f39da4440d"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("8711d79c-7044-4dfd-8a46-6ba5f819876f"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("25390f13-f313-404e-b2be-64d3962c8ebb"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("87fd2fc8-894d-4432-9913-1b7c5845883a"), true, "Количество печатных листов", 4, new Guid("672551e0-43b3-4397-a6c4-b643610241ad"), new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("8923665c-34dc-4a30-b5cb-52718980cbd6"), true, "Количество часов", 4, new Guid("285f7db3-3a2b-47fb-9ec1-05b1e2b07e1b"), new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("8e1a60a5-1c31-4a7d-9866-774a4a0575a7"), true, "Вид деятельности (преподавательская)", 3, new Guid("285f7db3-3a2b-47fb-9ec1-05b1e2b07e1b"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("92f4cdc6-af93-4c65-9111-bd0551f501fa"), true, "Награда", 4, new Guid("4814fe86-adb2-4a1d-84a7-aeeb37e48e76"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("9fdf5079-6063-478f-b116-4e6538d91f09"), true, "Значение", 2, new Guid("52725f3e-e03c-4f17-abca-4418da928e50"), new Guid("6f6117c4-4811-42fd-af33-73f28a26752b") },
                    { new Guid("a0fda36b-e3ee-40ac-886b-06cd19e39c3b"), true, "Название разработки", 2, new Guid("6bd85eca-5bae-4bc7-b62c-d3454214f918"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("a346e106-a5d9-4dc5-829e-e20695784e6a"), true, "Ссылка", 5, new Guid("4814fe86-adb2-4a1d-84a7-aeeb37e48e76"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("b1d1f184-80a6-4ed5-a33b-2e0b994fb86a"), true, "Язык публикации", 7, new Guid("672551e0-43b3-4397-a6c4-b643610241ad"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("b6392210-a6dd-4f11-9ae5-d7120d226427"), true, "Год", 4, new Guid("6f01a7ed-8f3f-4734-9200-63a6889954da"), new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("ba816d0f-c432-476c-8660-6e1f599d4c64"), true, "Вид", 1, new Guid("6bd85eca-5bae-4bc7-b62c-d3454214f918"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("be6a307c-3299-459f-bfd0-056db8a3b719"), true, "Итого (час.)", 5, new Guid("25390f13-f313-404e-b2be-64d3962c8ebb"), new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("c73c0407-2c07-486c-bab6-975369710319"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("56de4558-e737-450f-9ecd-97f39da4440d"), new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("c949f875-ac30-4241-ba1e-8d209991da07"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("130e6a34-1378-42f0-93f2-f357591a2f54"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("c9d55b16-8c35-4e87-a046-fe73b4124a76"), true, "Название", 2, new Guid("672551e0-43b3-4397-a6c4-b643610241ad"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("d11dfb2d-dfbd-4384-9004-ff8552930456"), true, "Период выполнения", 3, new Guid("56de4558-e737-450f-9ecd-97f39da4440d"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("d85f8db2-05e1-4dce-a82f-41d9f61d3255"), false, "Соавторы", 3, new Guid("672551e0-43b3-4397-a6c4-b643610241ad"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("d8850013-4f6c-437e-baf1-eb7aeb8ab65d"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("c3966145-c530-48aa-9606-8be1663e92f0"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("db060dfb-b9e6-47fa-9603-7ef4e8756a31"), true, "Лекции (час.)", 3, new Guid("25390f13-f313-404e-b2be-64d3962c8ebb"), new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("db4a6cc0-d29e-4d97-abb7-0bc99836f52c"), true, "Название", 2, new Guid("9e6009de-28f7-48c3-8849-2ded2ac89d1e"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("e07457d5-70c7-4981-8023-e32dfa18dd93"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("285f7db3-3a2b-47fb-9ec1-05b1e2b07e1b"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("e791a747-358e-404e-a046-3dd2fe48bc31"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("88ce76e2-e90d-454c-9da1-8884aaafb24f"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("f3742dd7-5544-4fa1-b6c3-ecdb3a48c7b7"), true, "Ссылка на открытый доступ", 8, new Guid("672551e0-43b3-4397-a6c4-b643610241ad"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("f52349c7-ec92-40a2-8fd2-e72bd6ab2796"), true, "Наименование курса", 1, new Guid("25390f13-f313-404e-b2be-64d3962c8ebb"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("fa48c90a-69e0-47c9-ab29-dad596ae9c5c"), true, "Название курса", 1, new Guid("6f01a7ed-8f3f-4734-9200-63a6889954da"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") },
                    { new Guid("fbddfb17-2fe8-407f-b327-4119d8252d20"), true, "Год получения документа", 2, new Guid("f93caa09-221c-4832-986b-578b1150af43"), new Guid("9933021f-ff9b-4f40-a05e-4c7fffc77d6b") },
                    { new Guid("fda44dfc-5dd3-4613-9fe8-afb329ad0f50"), true, "Название статьи", 1, new Guid("88ce76e2-e90d-454c-9da1-8884aaafb24f"), new Guid("cdda0e63-b198-41d0-ad48-013a9310c7fd") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("04ae92df-f39c-4545-b4bc-4539ca1817b8"), new Guid("04e13ea1-609d-4526-9cab-06e450b13319") },
                    { new Guid("0e43e37d-fe27-48b7-adcd-19c63711c9c9"), new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851") },
                    { new Guid("13a010d2-0194-4bea-b73d-83d12cfba5f3"), new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851") },
                    { new Guid("26d608ae-27d1-4713-9f77-6f260eaae5b9"), new Guid("01202277-d0f5-44ac-949c-9a950dffde3e") },
                    { new Guid("26d608ae-27d1-4713-9f77-6f260eaae5b9"), new Guid("04e13ea1-609d-4526-9cab-06e450b13319") },
                    { new Guid("26d608ae-27d1-4713-9f77-6f260eaae5b9"), new Guid("6d29b694-3a81-48ac-9ff8-dd5061024616") },
                    { new Guid("37e4b536-fdb3-48ec-b717-2378e41db4e1"), new Guid("01202277-d0f5-44ac-949c-9a950dffde3e") },
                    { new Guid("4008c6c0-70fa-4b32-adeb-5f24c7bd863b"), new Guid("01202277-d0f5-44ac-949c-9a950dffde3e") },
                    { new Guid("442bfc14-07da-4cbf-9ad8-74186da039c8"), new Guid("01202277-d0f5-44ac-949c-9a950dffde3e") },
                    { new Guid("54d9379a-1e90-4866-836a-332fade52b68"), new Guid("01202277-d0f5-44ac-949c-9a950dffde3e") },
                    { new Guid("771bdf26-8012-4b92-9038-d40c93f75900"), new Guid("01202277-d0f5-44ac-949c-9a950dffde3e") },
                    { new Guid("9229a6f8-c5fe-451f-81a8-9c386122b490"), new Guid("01202277-d0f5-44ac-949c-9a950dffde3e") },
                    { new Guid("9eca51ec-e711-4687-8bbf-1d77a4340483"), new Guid("01202277-d0f5-44ac-949c-9a950dffde3e") },
                    { new Guid("a5e78675-927d-44e6-ae40-2b80144d79ea"), new Guid("04e13ea1-609d-4526-9cab-06e450b13319") },
                    { new Guid("a8ada6af-69d3-457e-a606-bd67b4cdcbea"), new Guid("01202277-d0f5-44ac-949c-9a950dffde3e") },
                    { new Guid("b5a60246-f0fe-42fc-ba38-70cc9b9bd6b4"), new Guid("01202277-d0f5-44ac-949c-9a950dffde3e") },
                    { new Guid("bfc4a2a6-25cf-451e-94df-e40464599886"), new Guid("01202277-d0f5-44ac-949c-9a950dffde3e") },
                    { new Guid("c5e8f13e-0a5b-4d91-8e11-88c1f9127914"), new Guid("01202277-d0f5-44ac-949c-9a950dffde3e") },
                    { new Guid("ca63da51-da1d-4975-980f-8675086bfcfa"), new Guid("01202277-d0f5-44ac-949c-9a950dffde3e") },
                    { new Guid("e22cd182-4c09-4c4a-b94f-652272e63a45"), new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851") },
                    { new Guid("eef0dfa5-b008-4381-aa77-1cfb05e40de2"), new Guid("01202277-d0f5-44ac-949c-9a950dffde3e") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("04e13ea1-609d-4526-9cab-06e450b13319"), new Guid("4814fe86-adb2-4a1d-84a7-aeeb37e48e76") },
                    { new Guid("04e13ea1-609d-4526-9cab-06e450b13319"), new Guid("56de4558-e737-450f-9ecd-97f39da4440d") },
                    { new Guid("04e13ea1-609d-4526-9cab-06e450b13319"), new Guid("88ce76e2-e90d-454c-9da1-8884aaafb24f") },
                    { new Guid("04e13ea1-609d-4526-9cab-06e450b13319"), new Guid("e110805e-4351-4953-aa7e-fb381470039d") },
                    { new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851"), new Guid("25390f13-f313-404e-b2be-64d3962c8ebb") },
                    { new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851"), new Guid("285f7db3-3a2b-47fb-9ec1-05b1e2b07e1b") },
                    { new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851"), new Guid("6f01a7ed-8f3f-4734-9200-63a6889954da") },
                    { new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851"), new Guid("c3966145-c530-48aa-9606-8be1663e92f0") },
                    { new Guid("6d29b694-3a81-48ac-9ff8-dd5061024616"), new Guid("4814fe86-adb2-4a1d-84a7-aeeb37e48e76") },
                    { new Guid("6d29b694-3a81-48ac-9ff8-dd5061024616"), new Guid("f93caa09-221c-4832-986b-578b1150af43") },
                    { new Guid("868b5db0-fef1-4f47-a7f2-0617d9bd6096"), new Guid("6bd85eca-5bae-4bc7-b62c-d3454214f918") },
                    { new Guid("868b5db0-fef1-4f47-a7f2-0617d9bd6096"), new Guid("9e6009de-28f7-48c3-8849-2ded2ac89d1e") },
                    { new Guid("868b5db0-fef1-4f47-a7f2-0617d9bd6096"), new Guid("f93caa09-221c-4832-986b-578b1150af43") },
                    { new Guid("8c78e1e0-c9bc-4a75-996e-801fe2c55297"), new Guid("52725f3e-e03c-4f17-abca-4418da928e50") },
                    { new Guid("a09e2304-d6ab-4581-aac9-d46ba07ad3f5"), new Guid("130e6a34-1378-42f0-93f2-f357591a2f54") },
                    { new Guid("a09e2304-d6ab-4581-aac9-d46ba07ad3f5"), new Guid("672551e0-43b3-4397-a6c4-b643610241ad") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("067e74db-18ac-48a4-ba6d-70a5bc0cc761"), "EvaluateMark3", new Guid("e22cd182-4c09-4c4a-b94f-652272e63a45"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("249a818c-4502-4145-b8be-ddcbff59ecdb"), "EvaluateMark13", new Guid("26d608ae-27d1-4713-9f77-6f260eaae5b9"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("2551c876-f0ad-40d1-94f1-5259694bcd96"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("672551e0-43b3-4397-a6c4-b643610241ad") },
                    { new Guid("25f08f47-eb9b-40db-99e7-31f592f59979"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("6f01a7ed-8f3f-4734-9200-63a6889954da") },
                    { new Guid("2d48fba1-5803-42bf-8142-44fea0a363dc"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("672551e0-43b3-4397-a6c4-b643610241ad") },
                    { new Guid("34f0f5d8-c6f7-4824-8aed-53e54b2ade8f"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("56de4558-e737-450f-9ecd-97f39da4440d") },
                    { new Guid("409cc7d2-59cb-42e8-b333-80ec25acf99b"), null, null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("52725f3e-e03c-4f17-abca-4418da928e50") },
                    { new Guid("409f798a-a2c0-42d1-99ed-12fbe9ebef96"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("6bd85eca-5bae-4bc7-b62c-d3454214f918") },
                    { new Guid("47d39a17-bae1-4c3c-bcb3-d9cdb1b9e00c"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("88ce76e2-e90d-454c-9da1-8884aaafb24f") },
                    { new Guid("48589087-88ad-4e5f-a912-3b6e6ac23d90"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("f93caa09-221c-4832-986b-578b1150af43") },
                    { new Guid("501342d2-dce8-48b1-b92a-c3fafb1dea5c"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("130e6a34-1378-42f0-93f2-f357591a2f54") },
                    { new Guid("5ac12ab1-5a7d-47fb-949b-30f42a2523ce"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("56de4558-e737-450f-9ecd-97f39da4440d") },
                    { new Guid("6be3cfb6-da5f-460c-add7-234be47ad067"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("4814fe86-adb2-4a1d-84a7-aeeb37e48e76") },
                    { new Guid("70880503-c605-4696-95c5-8a1a7777326e"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("c3966145-c530-48aa-9606-8be1663e92f0") },
                    { new Guid("7677ed3d-2750-4efa-af7e-2711a8f2d2a7"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("672551e0-43b3-4397-a6c4-b643610241ad") },
                    { new Guid("8216662a-334a-427d-8855-7d04bb9b1e4e"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("672551e0-43b3-4397-a6c4-b643610241ad") },
                    { new Guid("a7185d1c-28fc-42f6-aa49-288a85f770b1"), null, null, false, 10, "Оценка уровня предоставленной работы:", 25, new Guid("52725f3e-e03c-4f17-abca-4418da928e50") },
                    { new Guid("b1b80404-ccf3-48eb-aeaa-d336c84948ae"), "EvaluateMark4", new Guid("13a010d2-0194-4bea-b73d-83d12cfba5f3"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("bb574b0e-a79f-4a51-b726-d1bba2db4ad3"), "EvaluateMark20", new Guid("04ae92df-f39c-4545-b4bc-4539ca1817b8"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("bea4c66b-52a7-42a7-a052-2ae1ec11bddc"), "EvaluateMark5", new Guid("0e43e37d-fe27-48b7-adcd-19c63711c9c9"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("cee37f33-7f48-40e7-845a-53268864c2b1"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("25390f13-f313-404e-b2be-64d3962c8ebb") },
                    { new Guid("d38c3401-486d-41c0-8064-642afe3b2311"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("9e6009de-28f7-48c3-8849-2ded2ac89d1e") },
                    { new Guid("d75e98f7-8eee-4c76-8c03-43b578c4e2c9"), "EvaluateMark19", new Guid("a5e78675-927d-44e6-ae40-2b80144d79ea"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("f8ed4435-30e0-4154-8a78-b9e2574b3506"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("25390f13-f313-404e-b2be-64d3962c8ebb") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("0b9cfe67-d425-40c0-bc27-8f50a82eaa1a"), true, new Guid("52725f3e-e03c-4f17-abca-4418da928e50") },
                    { new Guid("102944b8-994e-4260-aff2-dfc7e584c745"), true, new Guid("52725f3e-e03c-4f17-abca-4418da928e50") },
                    { new Guid("2548654b-a46a-41ea-a2e0-e0e4c6a47260"), true, new Guid("52725f3e-e03c-4f17-abca-4418da928e50") },
                    { new Guid("2e041d14-33e1-4a96-b859-f6d518f6c9bd"), true, new Guid("e110805e-4351-4953-aa7e-fb381470039d") },
                    { new Guid("4b6d62af-d767-4312-8c12-c591921b0ab5"), true, new Guid("52725f3e-e03c-4f17-abca-4418da928e50") },
                    { new Guid("5b43189a-6ae4-4a04-ab35-c2f7e1b48ae4"), true, new Guid("e110805e-4351-4953-aa7e-fb381470039d") },
                    { new Guid("60283e44-8a05-4514-9c8c-7353cbbf48a3"), true, new Guid("52725f3e-e03c-4f17-abca-4418da928e50") },
                    { new Guid("b23c2b95-7ea6-47f6-ab95-a48c8fb6df94"), true, new Guid("52725f3e-e03c-4f17-abca-4418da928e50") },
                    { new Guid("c62f31b3-c680-4c0d-8acf-2ec23c584d61"), true, new Guid("52725f3e-e03c-4f17-abca-4418da928e50") },
                    { new Guid("e3a7c2dd-170e-4a56-97a7-545081f300b1"), true, new Guid("52725f3e-e03c-4f17-abca-4418da928e50") },
                    { new Guid("e6e1d79e-ffa1-4ac3-9d0c-796daeba6945"), true, new Guid("e110805e-4351-4953-aa7e-fb381470039d") },
                    { new Guid("ff337876-e3c5-483d-8093-5037ca47335c"), true, new Guid("e110805e-4351-4953-aa7e-fb381470039d") },
                    { new Guid("ff497ad4-b2a1-482c-bd49-b3ff31f8d4ed"), true, new Guid("e110805e-4351-4953-aa7e-fb381470039d") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("06cac032-3df1-4510-8571-deb99a9f2e10"), null, new Guid("4008c6c0-70fa-4b32-adeb-5f24c7bd863b"), "Имеющие ученую степень доктора наук" },
                    { new Guid("1215e231-cce5-4ae6-868f-39c8a6eef839"), null, new Guid("26d608ae-27d1-4713-9f77-6f260eaae5b9"), "Нет" },
                    { new Guid("5072275d-2e8d-4f62-a13b-d548dca76fff"), null, new Guid("4008c6c0-70fa-4b32-adeb-5f24c7bd863b"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("9a99f0e6-757d-4b5f-8b7a-2a8b56d3e7d3"), null, new Guid("26d608ae-27d1-4713-9f77-6f260eaae5b9"), "Доцент" },
                    { new Guid("b8af7379-f2b9-48ae-8a94-25d923623f65"), null, new Guid("c5e8f13e-0a5b-4d91-8e11-88c1f9127914"), "Доктор наук" },
                    { new Guid("d4e8457b-d93c-44f3-a7ba-5c12f326d1ad"), null, new Guid("26d608ae-27d1-4713-9f77-6f260eaae5b9"), "Профессор" },
                    { new Guid("f02d22cf-1298-4178-b0e4-4b99bebe7118"), null, new Guid("c5e8f13e-0a5b-4d91-8e11-88c1f9127914"), "Кандидат наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("0202aa67-2a4f-43b6-80fe-a19ccc625bc4"), null, new Guid("5db7661d-8a84-497d-8310-10361d37a893"), false, true, new Guid("2e041d14-33e1-4a96-b859-f6d518f6c9bd"), null },
                    { new Guid("0209376b-95c0-4d40-97dc-6eee5b52d6fe"), null, new Guid("2c57639b-450a-4a03-b24d-8e55c651d20e"), true, true, new Guid("102944b8-994e-4260-aff2-dfc7e584c745"), "Ссылка на конкурсную работу" },
                    { new Guid("191def59-4fe4-4084-95d2-c570574a0e19"), null, new Guid("9fdf5079-6063-478f-b116-4e6538d91f09"), false, true, new Guid("c62f31b3-c680-4c0d-8acf-2ec23c584d61"), null },
                    { new Guid("21380070-a2ba-428f-b0fe-2f6f2a6b8444"), null, new Guid("78a0117f-334b-4b67-b6f0-27be38b34357"), true, true, new Guid("ff337876-e3c5-483d-8093-5037ca47335c"), "Google Scholar ID" },
                    { new Guid("2757bb4e-7342-4ecb-b852-fb80bcac365a"), null, new Guid("2c57639b-450a-4a03-b24d-8e55c651d20e"), true, true, new Guid("c62f31b3-c680-4c0d-8acf-2ec23c584d61"), "Результаты и выводы" },
                    { new Guid("2984c3fd-2bed-4792-93a8-a2b690f0b1b6"), null, new Guid("9fdf5079-6063-478f-b116-4e6538d91f09"), false, true, new Guid("4b6d62af-d767-4312-8c12-c591921b0ab5"), null },
                    { new Guid("29882060-ddb6-4a7a-a45a-f507e8994dec"), null, new Guid("9fdf5079-6063-478f-b116-4e6538d91f09"), false, true, new Guid("2548654b-a46a-41ea-a2e0-e0e4c6a47260"), null },
                    { new Guid("2f9c2a0a-eced-48f4-82e7-7fd04783f049"), null, new Guid("2c57639b-450a-4a03-b24d-8e55c651d20e"), true, true, new Guid("2548654b-a46a-41ea-a2e0-e0e4c6a47260"), "Инновационность" },
                    { new Guid("347179a5-0a6b-44c1-9e50-1cc4634b6483"), null, new Guid("2c57639b-450a-4a03-b24d-8e55c651d20e"), true, true, new Guid("60283e44-8a05-4514-9c8c-7353cbbf48a3"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("3886914d-59f0-4d72-a977-e25258a351b2"), null, new Guid("2c57639b-450a-4a03-b24d-8e55c651d20e"), true, true, new Guid("0b9cfe67-d425-40c0-bc27-8f50a82eaa1a"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("50b992b0-0642-4ec5-89f3-6f3939780406"), null, new Guid("5db7661d-8a84-497d-8310-10361d37a893"), false, true, new Guid("ff337876-e3c5-483d-8093-5037ca47335c"), null },
                    { new Guid("63102410-e73e-4770-980f-cf3425948257"), null, new Guid("78a0117f-334b-4b67-b6f0-27be38b34357"), true, true, new Guid("e6e1d79e-ffa1-4ac3-9d0c-796daeba6945"), "ResearcherID" },
                    { new Guid("703b30d9-3e4a-424a-8b54-b8e96d5e66e7"), null, new Guid("5db7661d-8a84-497d-8310-10361d37a893"), false, true, new Guid("ff497ad4-b2a1-482c-bd49-b3ff31f8d4ed"), null },
                    { new Guid("7aca1d23-1bbf-4b13-84e4-f520527e5509"), null, new Guid("78a0117f-334b-4b67-b6f0-27be38b34357"), true, true, new Guid("2e041d14-33e1-4a96-b859-f6d518f6c9bd"), "РИНЦ AuthorID" },
                    { new Guid("7f579cab-a325-46d0-a4d6-cb128f1291bf"), null, new Guid("78a0117f-334b-4b67-b6f0-27be38b34357"), true, true, new Guid("5b43189a-6ae4-4a04-ab35-c2f7e1b48ae4"), "ORCiD" },
                    { new Guid("88c46198-a13d-4d4c-bc99-a36c532dce87"), null, new Guid("5db7661d-8a84-497d-8310-10361d37a893"), false, true, new Guid("5b43189a-6ae4-4a04-ab35-c2f7e1b48ae4"), null },
                    { new Guid("8a57c2a3-b77a-499c-9b59-1ecadd9836be"), null, new Guid("9fdf5079-6063-478f-b116-4e6538d91f09"), false, true, new Guid("102944b8-994e-4260-aff2-dfc7e584c745"), null },
                    { new Guid("8f6f75ce-688b-4fa0-85c4-635330b8869a"), null, new Guid("78a0117f-334b-4b67-b6f0-27be38b34357"), true, true, new Guid("ff497ad4-b2a1-482c-bd49-b3ff31f8d4ed"), "ScopusID" },
                    { new Guid("9a96e930-55f5-4983-a6c8-3821b77f8c59"), null, new Guid("5db7661d-8a84-497d-8310-10361d37a893"), false, true, new Guid("e6e1d79e-ffa1-4ac3-9d0c-796daeba6945"), null },
                    { new Guid("9eaf8174-88ab-4ec6-9a65-ce2348e822f6"), null, new Guid("2c57639b-450a-4a03-b24d-8e55c651d20e"), true, true, new Guid("e3a7c2dd-170e-4a56-97a7-545081f300b1"), "Название работы" },
                    { new Guid("b3456b4d-ad59-4af4-b1ea-a408962cd45b"), null, new Guid("9fdf5079-6063-478f-b116-4e6538d91f09"), false, true, new Guid("0b9cfe67-d425-40c0-bc27-8f50a82eaa1a"), null },
                    { new Guid("b5aafea0-fe2d-4fba-adcd-474880297598"), null, new Guid("9fdf5079-6063-478f-b116-4e6538d91f09"), false, true, new Guid("b23c2b95-7ea6-47f6-ab95-a48c8fb6df94"), null },
                    { new Guid("ced8936a-d1e8-4a84-81e3-9ed2cef7bd51"), null, new Guid("2c57639b-450a-4a03-b24d-8e55c651d20e"), true, true, new Guid("b23c2b95-7ea6-47f6-ab95-a48c8fb6df94"), "Актуальность конкурсной работы" },
                    { new Guid("d265e94a-ca69-42f9-afa5-6ff11cfc0b3f"), null, new Guid("2c57639b-450a-4a03-b24d-8e55c651d20e"), true, true, new Guid("4b6d62af-d767-4312-8c12-c591921b0ab5"), "Методология и методы, используемые в работе" },
                    { new Guid("ebb086d0-065e-4e03-98c4-3b7ec23587ec"), null, new Guid("9fdf5079-6063-478f-b116-4e6538d91f09"), false, true, new Guid("60283e44-8a05-4514-9c8c-7353cbbf48a3"), null },
                    { new Guid("fa6d756a-c2f5-4f10-b7ed-bb363091230b"), null, new Guid("9fdf5079-6063-478f-b116-4e6538d91f09"), false, true, new Guid("e3a7c2dd-170e-4a56-97a7-545081f300b1"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("04e13ea1-609d-4526-9cab-06e450b13319"), new Guid("249a818c-4502-4145-b8be-ddcbff59ecdb") },
                    { new Guid("04e13ea1-609d-4526-9cab-06e450b13319"), new Guid("34f0f5d8-c6f7-4824-8aed-53e54b2ade8f") },
                    { new Guid("04e13ea1-609d-4526-9cab-06e450b13319"), new Guid("47d39a17-bae1-4c3c-bcb3-d9cdb1b9e00c") },
                    { new Guid("04e13ea1-609d-4526-9cab-06e450b13319"), new Guid("5ac12ab1-5a7d-47fb-949b-30f42a2523ce") },
                    { new Guid("04e13ea1-609d-4526-9cab-06e450b13319"), new Guid("6be3cfb6-da5f-460c-add7-234be47ad067") },
                    { new Guid("04e13ea1-609d-4526-9cab-06e450b13319"), new Guid("bb574b0e-a79f-4a51-b726-d1bba2db4ad3") },
                    { new Guid("04e13ea1-609d-4526-9cab-06e450b13319"), new Guid("d75e98f7-8eee-4c76-8c03-43b578c4e2c9") },
                    { new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851"), new Guid("067e74db-18ac-48a4-ba6d-70a5bc0cc761") },
                    { new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851"), new Guid("25f08f47-eb9b-40db-99e7-31f592f59979") },
                    { new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851"), new Guid("70880503-c605-4696-95c5-8a1a7777326e") },
                    { new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851"), new Guid("b1b80404-ccf3-48eb-aeaa-d336c84948ae") },
                    { new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851"), new Guid("bea4c66b-52a7-42a7-a052-2ae1ec11bddc") },
                    { new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851"), new Guid("cee37f33-7f48-40e7-845a-53268864c2b1") },
                    { new Guid("4518f58b-0795-47fa-9bcb-43be8d8e3851"), new Guid("f8ed4435-30e0-4154-8a78-b9e2574b3506") },
                    { new Guid("6d29b694-3a81-48ac-9ff8-dd5061024616"), new Guid("249a818c-4502-4145-b8be-ddcbff59ecdb") },
                    { new Guid("6d29b694-3a81-48ac-9ff8-dd5061024616"), new Guid("48589087-88ad-4e5f-a912-3b6e6ac23d90") },
                    { new Guid("6d29b694-3a81-48ac-9ff8-dd5061024616"), new Guid("6be3cfb6-da5f-460c-add7-234be47ad067") },
                    { new Guid("868b5db0-fef1-4f47-a7f2-0617d9bd6096"), new Guid("409f798a-a2c0-42d1-99ed-12fbe9ebef96") },
                    { new Guid("868b5db0-fef1-4f47-a7f2-0617d9bd6096"), new Guid("48589087-88ad-4e5f-a912-3b6e6ac23d90") },
                    { new Guid("868b5db0-fef1-4f47-a7f2-0617d9bd6096"), new Guid("d38c3401-486d-41c0-8064-642afe3b2311") },
                    { new Guid("8c78e1e0-c9bc-4a75-996e-801fe2c55297"), new Guid("409cc7d2-59cb-42e8-b333-80ec25acf99b") },
                    { new Guid("8c78e1e0-c9bc-4a75-996e-801fe2c55297"), new Guid("a7185d1c-28fc-42f6-aa49-288a85f770b1") },
                    { new Guid("a09e2304-d6ab-4581-aac9-d46ba07ad3f5"), new Guid("2551c876-f0ad-40d1-94f1-5259694bcd96") },
                    { new Guid("a09e2304-d6ab-4581-aac9-d46ba07ad3f5"), new Guid("2d48fba1-5803-42bf-8142-44fea0a363dc") },
                    { new Guid("a09e2304-d6ab-4581-aac9-d46ba07ad3f5"), new Guid("501342d2-dce8-48b1-b92a-c3fafb1dea5c") },
                    { new Guid("a09e2304-d6ab-4581-aac9-d46ba07ad3f5"), new Guid("7677ed3d-2750-4efa-af7e-2711a8f2d2a7") },
                    { new Guid("a09e2304-d6ab-4581-aac9-d46ba07ad3f5"), new Guid("8216662a-334a-427d-8855-7d04bb9b1e4e") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0555afbc-3b40-4608-9a2d-6cf2a19f6757"), new Guid("22d22328-d6fa-40ad-ac35-bdc508f6fdef"), null, "Изобретение" },
                    { new Guid("15b70529-0ddf-479b-b4ad-62eaa067f774"), new Guid("ba816d0f-c432-476c-8660-6e1f599d4c64"), null, "Изобретение" },
                    { new Guid("1c0aea11-c7a2-4a18-9626-d6c3c6a1b917"), new Guid("86588b53-ab08-4855-82f2-b5f8bbdbdaa3"), null, "Руководитель" },
                    { new Guid("1e7e62e9-0201-48fa-8211-47cec0333a6a"), new Guid("ba816d0f-c432-476c-8660-6e1f599d4c64"), null, "Полезная модель" },
                    { new Guid("3410d731-bee2-469c-835d-c5f7af4061d1"), new Guid("5705932e-0cf1-4165-a8ee-908f70112e2b"), null, "Международный" },
                    { new Guid("4f6d0b2d-2d45-49d8-a735-65b3110f4fc1"), new Guid("22d22328-d6fa-40ad-ac35-bdc508f6fdef"), null, "База данных" },
                    { new Guid("5159e68c-1b10-4710-b11e-8a8d04d07cb9"), new Guid("22d22328-d6fa-40ad-ac35-bdc508f6fdef"), null, "Полезная модель" },
                    { new Guid("5eaeb747-71e9-48a8-a9a5-0220a8894896"), new Guid("d85f8db2-05e1-4dce-a82f-41d9f61d3255"), null, "Нет" },
                    { new Guid("61e952ca-4015-45a2-9b43-eccb6d7ed60a"), new Guid("5705932e-0cf1-4165-a8ee-908f70112e2b"), null, "Региональный" },
                    { new Guid("6c5cfd9b-7a67-41b4-bbe0-17d5ad1937c6"), new Guid("57371a47-b66a-4c72-8486-6e92e597740c"), null, "Монография" },
                    { new Guid("7d6e428c-f451-4c9b-9a4d-3456d4be3cc1"), new Guid("57371a47-b66a-4c72-8486-6e92e597740c"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("88262112-c66e-474c-a4dd-5934a3c14fb8"), new Guid("5705932e-0cf1-4165-a8ee-908f70112e2b"), null, "Всероссийский" },
                    { new Guid("96664cb6-ffe3-47dd-b0ac-f81d0608af38"), new Guid("b1d1f184-80a6-4ed5-a33b-2e0b994fb86a"), null, "Иностранный" },
                    { new Guid("a84366c5-d0da-4cf0-a22f-2360fb965225"), new Guid("385fc350-be76-48dc-9e2f-e80f28410e36"), null, "Нет" },
                    { new Guid("aad263c5-6dca-4184-89a2-26f789dc0dfb"), new Guid("d85f8db2-05e1-4dce-a82f-41d9f61d3255"), null, "Есть" },
                    { new Guid("ac962be5-696f-4c33-960d-440abe452e84"), new Guid("b1d1f184-80a6-4ed5-a33b-2e0b994fb86a"), null, "Русский" },
                    { new Guid("ae0eac99-a109-4b9e-9c10-08e5970fcce7"), new Guid("86588b53-ab08-4855-82f2-b5f8bbdbdaa3"), null, "Исполнитель" },
                    { new Guid("b0111bb1-53f5-45f0-b7e8-110e4059da9c"), new Guid("02e5ab3b-3fcf-4411-b16f-4d146db6155f"), null, "Лекции" },
                    { new Guid("d5e2f229-8bc9-4608-b226-4adc1f3e4fc1"), new Guid("385fc350-be76-48dc-9e2f-e80f28410e36"), null, "Есть" },
                    { new Guid("d7631802-f11c-414f-a965-a37f555289a6"), new Guid("57371a47-b66a-4c72-8486-6e92e597740c"), null, "Учебник" },
                    { new Guid("f0ce8bfe-fd2c-496d-8f06-54db4751be6e"), new Guid("ba816d0f-c432-476c-8660-6e1f599d4c64"), null, "База данных" },
                    { new Guid("f2288588-cd22-45e1-a0d4-6c31ecfb74cd"), new Guid("02e5ab3b-3fcf-4411-b16f-4d146db6155f"), null, "Лабораторные" }
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
