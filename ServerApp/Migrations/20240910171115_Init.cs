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
                name: "ApplicationFormExperts",
                columns: table => new
                {
                    ApplicationFormId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserInfoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationFormExperts", x => new { x.ApplicationFormId, x.UserInfoId });
                    table.ForeignKey(
                        name: "FK_ApplicationFormExperts_ApplicationForms_ApplicationFormId",
                        column: x => x.ApplicationFormId,
                        principalTable: "ApplicationForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationFormExperts_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    MarkId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExpertId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsAuto = table.Column<bool>(type: "boolean", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_MarkVals_UserInfos_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "UserInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ApplicationStatuses",
                columns: new[] { "Id", "Number", "Status" },
                values: new object[,]
                {
                    { new Guid("079b2ed6-4e64-4b3c-85b0-0103f89f2cdf"), 6, "Оценена" },
                    { new Guid("0a8111bf-4b97-40b8-8267-d27535d65f40"), 5, "Отклонена" },
                    { new Guid("1a216686-a310-4c9a-aeb5-46f47a6a02d9"), 1, "В ожидании заполнения" },
                    { new Guid("1a3031f2-a98b-4708-a259-23a7faf189ae"), 3, "В процессе рассмотрения" },
                    { new Guid("61f260c8-9647-44fb-a451-b070f621b6c9"), 4, "Одобрена" },
                    { new Guid("8094ac8f-b610-421c-9023-126dddb062e3"), 2, "В ожидании рассмотрения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ac7b7a5-fd3d-445b-9799-5d1acae823ec", null, "Participant", "PARTICIPANT" },
                    { "21048b29-4a3e-490e-b020-6ea97a53dd59", null, "Organiser", "ORGANISER" },
                    { "3cb0a7f6-80ad-4801-9989-747fcbce1fba", null, "Admin", "ADMIN" },
                    { "3d652730-1bfe-4c06-884f-324360ca947c", null, "Expert", "EXPERT" },
                    { "f2fc2487-5634-48fe-b7fc-55dc6ae22d39", null, "Voter", "VOTER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("5baddaa6-e89f-484d-9bfe-b311bccf891c"), "Строительство и архитектура", 1 },
                    { new Guid("7e9cd782-1a29-4da8-99f8-2a5d4d766852"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0735a811-f994-47f6-91b6-53f6a40dd6cd"), "Научно-исследовательская деятельность", 6 },
                    { new Guid("213abb0b-f923-4850-87e0-17afef85252f"), "Общая информация", 1 },
                    { new Guid("9429c33c-4193-4dc1-b4fd-56c094d72e7e"), "Профессиональное развитие", 4 },
                    { new Guid("ad7b8dd2-a748-4e12-a0e9-4153bec6e692"), "Конкурсная работа", 3 },
                    { new Guid("cbacb16c-d35f-4efe-b3a6-4dce2772800a"), "Категория участников", 2 },
                    { new Guid("ffb9e384-cf34-4201-a3ac-bacafce0817c"), "Научно-педагогическая деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("298bfacd-f28e-43d6-8041-114db12d2a03"), "Образовательная деятельность", 2 },
                    { new Guid("3d1e51fe-18e9-4320-a281-2ee867df6ec0"), "Конкурсная работа", 7 },
                    { new Guid("68986c81-0d69-4fbf-8c01-81036c4bf2f2"), "Инновационная и иная деятельность", 6 },
                    { new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("c86cc38e-1b73-47c6-beae-a93037a36e5e"), "Методическая деятельность", 3 },
                    { new Guid("cf2dce72-bfbd-441c-a1f1-efb5dbfc7661"), "Профессиональные показатели", 4 },
                    { new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d"), "Основной", 1 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0c63a5b6-b38a-4f05-a57f-8cc5ec94bc77"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("89c69578-3e73-4031-bfd2-29a352e36d1d"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("431059ce-25e3-4cac-b31a-1501428cb4d9"), "DateTime" },
                    { new Guid("861961b2-e547-49b0-b389-28bb66e3ac44"), "bool" },
                    { new Guid("cdfdb011-4a38-4866-bc47-5f7ee665cc1d"), "TextArea" },
                    { new Guid("dc2f8204-427f-4a5d-a082-112444bb0575"), "string" },
                    { new Guid("feaf045e-1507-49fd-b069-f0d07b6075af"), "int" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0735a811-f994-47f6-91b6-53f6a40dd6cd"), new Guid("0c63a5b6-b38a-4f05-a57f-8cc5ec94bc77") },
                    { new Guid("213abb0b-f923-4850-87e0-17afef85252f"), new Guid("0c63a5b6-b38a-4f05-a57f-8cc5ec94bc77") },
                    { new Guid("213abb0b-f923-4850-87e0-17afef85252f"), new Guid("89c69578-3e73-4031-bfd2-29a352e36d1d") },
                    { new Guid("9429c33c-4193-4dc1-b4fd-56c094d72e7e"), new Guid("0c63a5b6-b38a-4f05-a57f-8cc5ec94bc77") },
                    { new Guid("9429c33c-4193-4dc1-b4fd-56c094d72e7e"), new Guid("89c69578-3e73-4031-bfd2-29a352e36d1d") },
                    { new Guid("ad7b8dd2-a748-4e12-a0e9-4153bec6e692"), new Guid("0c63a5b6-b38a-4f05-a57f-8cc5ec94bc77") },
                    { new Guid("ad7b8dd2-a748-4e12-a0e9-4153bec6e692"), new Guid("89c69578-3e73-4031-bfd2-29a352e36d1d") },
                    { new Guid("cbacb16c-d35f-4efe-b3a6-4dce2772800a"), new Guid("0c63a5b6-b38a-4f05-a57f-8cc5ec94bc77") },
                    { new Guid("cbacb16c-d35f-4efe-b3a6-4dce2772800a"), new Guid("89c69578-3e73-4031-bfd2-29a352e36d1d") },
                    { new Guid("ffb9e384-cf34-4201-a3ac-bacafce0817c"), new Guid("89c69578-3e73-4031-bfd2-29a352e36d1d") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("13242216-f904-4a9b-b922-642e921cb56c"), new Guid("0735a811-f994-47f6-91b6-53f6a40dd6cd"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("190f3662-1c39-46e1-9ff7-b2847ab3ff62"), new Guid("213abb0b-f923-4850-87e0-17afef85252f"), null, true, true, "Место работы", 6, "Название организации", new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("36cc01f1-e301-4844-91c2-c1ba2523f877"), new Guid("213abb0b-f923-4850-87e0-17afef85252f"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("38774fc4-08aa-4cb0-b360-6a18ee3fabfc"), new Guid("213abb0b-f923-4850-87e0-17afef85252f"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("3b6ba367-d632-44b0-83d4-b5688e4f339f"), new Guid("213abb0b-f923-4850-87e0-17afef85252f"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("5ac0949b-8195-4f4f-9c16-d63f89fc002e"), new Guid("cbacb16c-d35f-4efe-b3a6-4dce2772800a"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("66adab8d-ddd4-4829-a1e3-2bbc8ff99324"), new Guid("ffb9e384-cf34-4201-a3ac-bacafce0817c"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("6df78fad-6b3e-4d1b-869b-962917044372"), new Guid("0735a811-f994-47f6-91b6-53f6a40dd6cd"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("74be5948-c512-404f-83d9-786baddf38e9"), new Guid("213abb0b-f923-4850-87e0-17afef85252f"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("431059ce-25e3-4cac-b31a-1501428cb4d9") },
                    { new Guid("772d09d6-1100-4d05-a9c8-10c180b1c1aa"), new Guid("ffb9e384-cf34-4201-a3ac-bacafce0817c"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("87198fa4-90dc-433c-8397-cac33d2ed235"), new Guid("213abb0b-f923-4850-87e0-17afef85252f"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("a3f47aef-3365-49eb-ae6f-53f21ebbf3d7"), new Guid("213abb0b-f923-4850-87e0-17afef85252f"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("aab9e618-b28d-4074-9963-d697f377274c"), new Guid("cbacb16c-d35f-4efe-b3a6-4dce2772800a"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("bfb1724c-2934-484d-bf23-7d1b432cc9ba"), new Guid("ffb9e384-cf34-4201-a3ac-bacafce0817c"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("d8ac395e-3c65-4699-a740-9d86bb7be008"), new Guid("213abb0b-f923-4850-87e0-17afef85252f"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("dac2fbf1-b7f2-49aa-ba4d-46dcd6b71e82"), new Guid("213abb0b-f923-4850-87e0-17afef85252f"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("e49774b1-b09c-4dd2-a721-36a86e816714"), new Guid("213abb0b-f923-4850-87e0-17afef85252f"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("f3e71212-1747-4ab9-9013-bda3019efd23"), new Guid("cbacb16c-d35f-4efe-b3a6-4dce2772800a"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("298bfacd-f28e-43d6-8041-114db12d2a03"), new Guid("89c69578-3e73-4031-bfd2-29a352e36d1d") },
                    { new Guid("3d1e51fe-18e9-4320-a281-2ee867df6ec0"), new Guid("0c63a5b6-b38a-4f05-a57f-8cc5ec94bc77") },
                    { new Guid("3d1e51fe-18e9-4320-a281-2ee867df6ec0"), new Guid("89c69578-3e73-4031-bfd2-29a352e36d1d") },
                    { new Guid("68986c81-0d69-4fbf-8c01-81036c4bf2f2"), new Guid("0c63a5b6-b38a-4f05-a57f-8cc5ec94bc77") },
                    { new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c"), new Guid("0c63a5b6-b38a-4f05-a57f-8cc5ec94bc77") },
                    { new Guid("c86cc38e-1b73-47c6-beae-a93037a36e5e"), new Guid("89c69578-3e73-4031-bfd2-29a352e36d1d") },
                    { new Guid("cf2dce72-bfbd-441c-a1f1-efb5dbfc7661"), new Guid("89c69578-3e73-4031-bfd2-29a352e36d1d") },
                    { new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d"), new Guid("0c63a5b6-b38a-4f05-a57f-8cc5ec94bc77") },
                    { new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d"), new Guid("89c69578-3e73-4031-bfd2-29a352e36d1d") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("1d09ce56-95ea-4a44-895d-368208643870"), new Guid("0735a811-f994-47f6-91b6-53f6a40dd6cd"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("1eef2e01-3f77-4e7a-8a5e-c2693eed5488"), new Guid("ffb9e384-cf34-4201-a3ac-bacafce0817c"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("278aec07-276e-482a-bdcf-1467a17ad8e6"), new Guid("9429c33c-4193-4dc1-b4fd-56c094d72e7e"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 },
                    { new Guid("361e2016-4542-446b-b5d0-794500ca2fac"), new Guid("ffb9e384-cf34-4201-a3ac-bacafce0817c"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 },
                    { new Guid("523aced1-f35b-4106-8488-c8ec75d4a554"), new Guid("ffb9e384-cf34-4201-a3ac-bacafce0817c"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("7079ce59-17de-4a48-a9fd-fcbbb76e7a7d"), new Guid("9429c33c-4193-4dc1-b4fd-56c094d72e7e"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("831b4ea4-45e4-4a12-8ac7-a8435bbfb869"), new Guid("ffb9e384-cf34-4201-a3ac-bacafce0817c"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 },
                    { new Guid("84767f28-6541-490d-91b4-aa24083bb82a"), new Guid("0735a811-f994-47f6-91b6-53f6a40dd6cd"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("93d22632-1384-42b5-9730-52e924c471e2"), new Guid("0735a811-f994-47f6-91b6-53f6a40dd6cd"), false, false, "Список научных публикаций за последние 5 лет", 10 },
                    { new Guid("93f577ce-e6c5-4001-a7e5-af683aa81511"), new Guid("9429c33c-4193-4dc1-b4fd-56c094d72e7e"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("de13ac7c-436f-464f-be53-028e857738ee"), new Guid("ffb9e384-cf34-4201-a3ac-bacafce0817c"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 },
                    { new Guid("df519d91-bd20-4baa-ac4f-8032115d06c6"), new Guid("0735a811-f994-47f6-91b6-53f6a40dd6cd"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("f29ee4c1-4b56-44ce-8500-217027415015"), new Guid("ad7b8dd2-a748-4e12-a0e9-4153bec6e692"), true, true, "Краткая аннотация конкурсной работы", 1 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("01a3fd5f-e733-4231-bd15-e4822f0c59e4"), true, "Вид", 1, new Guid("df519d91-bd20-4baa-ac4f-8032115d06c6"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("163a3526-8c25-4a74-83d4-f8a2b28861e8"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("278aec07-276e-482a-bdcf-1467a17ad8e6"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("1b881ec7-16d0-4694-902a-8a6001b4b90c"), true, "Язык публикации", 7, new Guid("de13ac7c-436f-464f-be53-028e857738ee"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("24190458-6133-4bb1-8bae-eb8f11da5c55"), true, "Вид публикации", 1, new Guid("de13ac7c-436f-464f-be53-028e857738ee"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("248dc71e-a4cd-4a9c-aa47-1d7ade6bc6c3"), true, "Название документа, реквизиты", 1, new Guid("7079ce59-17de-4a48-a9fd-fcbbb76e7a7d"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("2d8bad94-db38-4cd9-96cb-1a585abf2169"), true, "Ссылка", 5, new Guid("278aec07-276e-482a-bdcf-1467a17ad8e6"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("2e9c172d-55d8-48c3-8ca5-652b83205194"), true, "Лекции (час.)", 3, new Guid("1eef2e01-3f77-4e7a-8a5e-c2693eed5488"), new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("478537a4-c43f-4d58-8fb8-0913218f45ce"), true, "Название", 2, new Guid("df519d91-bd20-4baa-ac4f-8032115d06c6"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("4a96c023-3d63-428d-8cc2-fc52741e397b"), true, "Статус конкурса", 3, new Guid("278aec07-276e-482a-bdcf-1467a17ad8e6"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("4c80a116-6373-43c0-8930-1f04833a94e4"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("361e2016-4542-446b-b5d0-794500ca2fac"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("5663b99b-5cc7-461a-840a-4065648f150e"), true, "Практические занятия (час.)", 4, new Guid("1eef2e01-3f77-4e7a-8a5e-c2693eed5488"), new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("58785baf-71fd-4f3b-ac3f-b086e8da33f3"), true, "Год", 4, new Guid("523aced1-f35b-4106-8488-c8ec75d4a554"), new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("591500c1-16fa-4e2a-906c-1d0592ef78ed"), true, "Вид", 1, new Guid("1d09ce56-95ea-4a44-895d-368208643870"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("5c600814-28ed-4bd1-b46d-c8a11ecdbf3a"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("84767f28-6541-490d-91b4-aa24083bb82a"), new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("6040c54c-4d8e-461e-8c63-4aea9ce43e62"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("831b4ea4-45e4-4a12-8ac7-a8435bbfb869"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("67eefb74-2fbe-451e-a164-a3ed1cbc2bc7"), true, "Итого (час.)", 5, new Guid("1eef2e01-3f77-4e7a-8a5e-c2693eed5488"), new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("6909f0f5-f3f8-4b23-837a-011fee4ca932"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("84767f28-6541-490d-91b4-aa24083bb82a"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("72bdf078-c81a-4795-bf8b-d5eb7aebc7a7"), true, "Значение", 2, new Guid("f29ee4c1-4b56-44ce-8500-217027415015"), new Guid("cdfdb011-4a38-4866-bc47-5f7ee665cc1d") },
                    { new Guid("772ea5b8-c041-47ad-b662-d6f5082d5e95"), true, "Название курса", 1, new Guid("523aced1-f35b-4106-8488-c8ec75d4a554"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("7e99de46-d995-45cf-bfa0-60f57a01d5f6"), true, "Название НИР/НИОКР", 1, new Guid("84767f28-6541-490d-91b4-aa24083bb82a"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("86fb1d72-275f-4610-8788-b461f817b0a0"), true, "Название разработки", 2, new Guid("1d09ce56-95ea-4a44-895d-368208643870"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("870036c3-04ff-436f-9b47-305bc5af4ff0"), true, "ФИО", 1, new Guid("361e2016-4542-446b-b5d0-794500ca2fac"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("922b714b-e078-4e8c-a8bc-cda4cbc2d142"), true, "Год", 1, new Guid("278aec07-276e-482a-bdcf-1467a17ad8e6"), new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("92b106f6-e6ad-4b56-bb26-6ac329a65d21"), true, "Название", 2, new Guid("de13ac7c-436f-464f-be53-028e857738ee"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("966506c5-fb4d-4daf-a420-cb13be4d8538"), true, "Название конкурса/премии", 2, new Guid("361e2016-4542-446b-b5d0-794500ca2fac"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("96a09638-966b-482b-a88e-27e1817aa71f"), true, "Название", 1, new Guid("f29ee4c1-4b56-44ce-8500-217027415015"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("99a1bc5d-a93d-487c-9f52-0c82b247da9c"), true, "Ссылка на платформу", 3, new Guid("523aced1-f35b-4106-8488-c8ec75d4a554"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("a1727995-b4a6-4f35-babc-6daa0fdd067f"), true, "Язык преподавания", 2, new Guid("1eef2e01-3f77-4e7a-8a5e-c2693eed5488"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("ab5e3c53-2a44-4bc1-a1c1-393f0685a6c3"), false, "Тип идентификатора", 1, new Guid("93f577ce-e6c5-4001-a7e5-af683aa81511"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("aede3aac-4611-43dc-b3c3-ca6683ef2ae5"), true, "Наименование курса", 1, new Guid("1eef2e01-3f77-4e7a-8a5e-c2693eed5488"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("b1997a50-f3f4-413b-bdcf-3034460012fb"), true, "Статус", 4, new Guid("84767f28-6541-490d-91b4-aa24083bb82a"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("b2f36209-575a-449b-b571-c6510d761532"), true, "Год", 3, new Guid("361e2016-4542-446b-b5d0-794500ca2fac"), new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("b5537c32-f0dd-4d8c-b2f9-b9a9f5422a0a"), true, "Вид", 2, new Guid("831b4ea4-45e4-4a12-8ac7-a8435bbfb869"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("bc7ff425-4dd5-4c8c-bf75-4415057ab160"), true, "Издание, год", 4, new Guid("93d22632-1384-42b5-9730-52e924c471e2"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("c56f3fc1-3239-43a9-8f93-c000f8e9a99f"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("93d22632-1384-42b5-9730-52e924c471e2"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("c69aa347-6e9c-4c23-a654-d2150536ae52"), true, "Соавторы", 2, new Guid("523aced1-f35b-4106-8488-c8ec75d4a554"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("c84dca20-576d-4645-b8ba-7a17e05a93eb"), true, "Год получения документа", 2, new Guid("7079ce59-17de-4a48-a9fd-fcbbb76e7a7d"), new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("ce36a31b-13cc-4fbc-b5bd-fb2e20525c7d"), true, "Соавторы", 2, new Guid("93d22632-1384-42b5-9730-52e924c471e2"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("ce3bf420-b431-43bd-a325-5fe9a6831ef4"), true, "Название организации в которую внедрена разработка", 3, new Guid("1d09ce56-95ea-4a44-895d-368208643870"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("d373b20b-6b2d-4155-b9e8-0626ff93fbc7"), true, "ФИО соавторов", 3, new Guid("df519d91-bd20-4baa-ac4f-8032115d06c6"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("d6ff6308-d49c-494d-bfec-c152fb170149"), true, "Название дисциплины", 1, new Guid("831b4ea4-45e4-4a12-8ac7-a8435bbfb869"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("d81c1d03-b4b3-435d-9b0a-74df9acd16a8"), true, "Номер РИД", 4, new Guid("df519d91-bd20-4baa-ac4f-8032115d06c6"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("d856acb7-d188-4e41-87e1-21aa5a08ce84"), false, "Соавторы", 3, new Guid("de13ac7c-436f-464f-be53-028e857738ee"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("da44e0fb-76e1-4dfd-8e6c-53f418adc3c3"), true, "Наличие грифа", 5, new Guid("de13ac7c-436f-464f-be53-028e857738ee"), new Guid("861961b2-e547-49b0-b389-28bb66e3ac44") },
                    { new Guid("e6896cba-d3b4-4aa3-8314-47827bf1f03e"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("361e2016-4542-446b-b5d0-794500ca2fac"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("f1d1d0f4-3905-4514-8b07-c17d00ed6573"), true, "Название статьи", 1, new Guid("93d22632-1384-42b5-9730-52e924c471e2"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("f552c88f-d3f1-4c4d-a23f-a8d51fa3a726"), true, "Издательство, год", 6, new Guid("de13ac7c-436f-464f-be53-028e857738ee"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("f8b3e6c6-7372-4921-b2bc-173a6134d09a"), true, "Ссылка на открытый доступ", 8, new Guid("de13ac7c-436f-464f-be53-028e857738ee"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("fd7fb135-620b-4485-9390-a31bab8648ac"), true, "Период выполнения", 3, new Guid("84767f28-6541-490d-91b4-aa24083bb82a"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("fdcf7f50-d7dd-4ccc-9e86-914f9c3a9acf"), true, "Количество печатных листов", 4, new Guid("de13ac7c-436f-464f-be53-028e857738ee"), new Guid("feaf045e-1507-49fd-b069-f0d07b6075af") },
                    { new Guid("fe28051b-1b52-432a-8bc2-35ad66059c81"), false, "Идентификатор", 2, new Guid("93f577ce-e6c5-4001-a7e5-af683aa81511"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") },
                    { new Guid("fff2a2dd-5adb-4903-9768-3525d6f36c0f"), true, "Название конкурса", 2, new Guid("278aec07-276e-482a-bdcf-1467a17ad8e6"), new Guid("dc2f8204-427f-4a5d-a082-112444bb0575") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("13242216-f904-4a9b-b922-642e921cb56c"), new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c") },
                    { new Guid("190f3662-1c39-46e1-9ff7-b2847ab3ff62"), new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d") },
                    { new Guid("36cc01f1-e301-4844-91c2-c1ba2523f877"), new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d") },
                    { new Guid("38774fc4-08aa-4cb0-b360-6a18ee3fabfc"), new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d") },
                    { new Guid("3b6ba367-d632-44b0-83d4-b5688e4f339f"), new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d") },
                    { new Guid("5ac0949b-8195-4f4f-9c16-d63f89fc002e"), new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d") },
                    { new Guid("66adab8d-ddd4-4829-a1e3-2bbc8ff99324"), new Guid("298bfacd-f28e-43d6-8041-114db12d2a03") },
                    { new Guid("6df78fad-6b3e-4d1b-869b-962917044372"), new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c") },
                    { new Guid("74be5948-c512-404f-83d9-786baddf38e9"), new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d") },
                    { new Guid("772d09d6-1100-4d05-a9c8-10c180b1c1aa"), new Guid("298bfacd-f28e-43d6-8041-114db12d2a03") },
                    { new Guid("87198fa4-90dc-433c-8397-cac33d2ed235"), new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d") },
                    { new Guid("a3f47aef-3365-49eb-ae6f-53f21ebbf3d7"), new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d") },
                    { new Guid("aab9e618-b28d-4074-9963-d697f377274c"), new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c") },
                    { new Guid("aab9e618-b28d-4074-9963-d697f377274c"), new Guid("cf2dce72-bfbd-441c-a1f1-efb5dbfc7661") },
                    { new Guid("aab9e618-b28d-4074-9963-d697f377274c"), new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d") },
                    { new Guid("bfb1724c-2934-484d-bf23-7d1b432cc9ba"), new Guid("298bfacd-f28e-43d6-8041-114db12d2a03") },
                    { new Guid("d8ac395e-3c65-4699-a740-9d86bb7be008"), new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d") },
                    { new Guid("dac2fbf1-b7f2-49aa-ba4d-46dcd6b71e82"), new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d") },
                    { new Guid("e49774b1-b09c-4dd2-a721-36a86e816714"), new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d") },
                    { new Guid("f3e71212-1747-4ab9-9013-bda3019efd23"), new Guid("d8a3e2eb-b23a-4513-a5c1-98bbee47a68d") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("298bfacd-f28e-43d6-8041-114db12d2a03"), new Guid("1eef2e01-3f77-4e7a-8a5e-c2693eed5488") },
                    { new Guid("298bfacd-f28e-43d6-8041-114db12d2a03"), new Guid("361e2016-4542-446b-b5d0-794500ca2fac") },
                    { new Guid("298bfacd-f28e-43d6-8041-114db12d2a03"), new Guid("523aced1-f35b-4106-8488-c8ec75d4a554") },
                    { new Guid("3d1e51fe-18e9-4320-a281-2ee867df6ec0"), new Guid("f29ee4c1-4b56-44ce-8500-217027415015") },
                    { new Guid("68986c81-0d69-4fbf-8c01-81036c4bf2f2"), new Guid("1d09ce56-95ea-4a44-895d-368208643870") },
                    { new Guid("68986c81-0d69-4fbf-8c01-81036c4bf2f2"), new Guid("7079ce59-17de-4a48-a9fd-fcbbb76e7a7d") },
                    { new Guid("68986c81-0d69-4fbf-8c01-81036c4bf2f2"), new Guid("df519d91-bd20-4baa-ac4f-8032115d06c6") },
                    { new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c"), new Guid("278aec07-276e-482a-bdcf-1467a17ad8e6") },
                    { new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c"), new Guid("84767f28-6541-490d-91b4-aa24083bb82a") },
                    { new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c"), new Guid("93d22632-1384-42b5-9730-52e924c471e2") },
                    { new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c"), new Guid("93f577ce-e6c5-4001-a7e5-af683aa81511") },
                    { new Guid("c86cc38e-1b73-47c6-beae-a93037a36e5e"), new Guid("831b4ea4-45e4-4a12-8ac7-a8435bbfb869") },
                    { new Guid("c86cc38e-1b73-47c6-beae-a93037a36e5e"), new Guid("de13ac7c-436f-464f-be53-028e857738ee") },
                    { new Guid("cf2dce72-bfbd-441c-a1f1-efb5dbfc7661"), new Guid("278aec07-276e-482a-bdcf-1467a17ad8e6") },
                    { new Guid("cf2dce72-bfbd-441c-a1f1-efb5dbfc7661"), new Guid("7079ce59-17de-4a48-a9fd-fcbbb76e7a7d") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0c1a4869-4465-4355-9037-de683bb878be"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("278aec07-276e-482a-bdcf-1467a17ad8e6") },
                    { new Guid("0d831865-db24-4356-97a9-5901664f592a"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("de13ac7c-436f-464f-be53-028e857738ee") },
                    { new Guid("38e86127-35b7-4a85-ae3b-37635d23806c"), "EvaluateMark3", new Guid("772d09d6-1100-4d05-a9c8-10c180b1c1aa"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("3b7c6dd0-35fb-4429-937b-b0debe2ffbee"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("f29ee4c1-4b56-44ce-8500-217027415015") },
                    { new Guid("3bdfc411-d925-4599-9706-ce2b6227ee5a"), "EvaluateMark20", new Guid("13242216-f904-4a9b-b922-642e921cb56c"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("42bf3c14-e3c2-4d8f-a39f-bdbbef0bb949"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("84767f28-6541-490d-91b4-aa24083bb82a") },
                    { new Guid("4c9334b3-5a83-4d81-8386-0c38bbd525a6"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("831b4ea4-45e4-4a12-8ac7-a8435bbfb869") },
                    { new Guid("4cfe5b5e-203a-4b31-99db-3836a9cca298"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("361e2016-4542-446b-b5d0-794500ca2fac") },
                    { new Guid("4ecfdb43-e729-48c3-aa87-b71bb99e5be5"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("523aced1-f35b-4106-8488-c8ec75d4a554") },
                    { new Guid("51c0bfd5-54e3-4282-a428-850845b1f996"), "EvaluateMark4", new Guid("66adab8d-ddd4-4829-a1e3-2bbc8ff99324"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("51ef4dd1-d4a8-4737-8853-f1c5454b49c1"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("df519d91-bd20-4baa-ac4f-8032115d06c6") },
                    { new Guid("6dcc2b10-2083-423b-8cf4-78e806cba501"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("de13ac7c-436f-464f-be53-028e857738ee") },
                    { new Guid("7182f437-cd87-4a2c-b269-a1db61abd174"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("1d09ce56-95ea-4a44-895d-368208643870") },
                    { new Guid("746ca343-156e-42b0-bcac-266a4d350820"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("84767f28-6541-490d-91b4-aa24083bb82a") },
                    { new Guid("78214b2a-b80f-4e51-a0a0-0321fc3d8c73"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("7079ce59-17de-4a48-a9fd-fcbbb76e7a7d") },
                    { new Guid("7a397476-c662-4728-9d17-5126186cb789"), "EvaluateMark19", new Guid("6df78fad-6b3e-4d1b-869b-962917044372"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("854f4288-350f-4a06-839a-1a5e35661ae2"), "EvaluateMark5", new Guid("bfb1724c-2934-484d-bf23-7d1b432cc9ba"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("902620ee-b410-490d-a7eb-279d99b836d9"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("1eef2e01-3f77-4e7a-8a5e-c2693eed5488") },
                    { new Guid("9a0fb81b-e445-428b-a138-8504798e0689"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("1eef2e01-3f77-4e7a-8a5e-c2693eed5488") },
                    { new Guid("a9aa8408-17e7-45d0-aa88-519b1ba3227e"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("de13ac7c-436f-464f-be53-028e857738ee") },
                    { new Guid("bf92e7e9-6e5d-4d35-8bb2-e9693c270310"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("f29ee4c1-4b56-44ce-8500-217027415015") },
                    { new Guid("cc5aad06-85fa-4cd0-9640-d247f2464871"), "EvaluateMark13", new Guid("aab9e618-b28d-4074-9963-d697f377274c"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("db758007-8d84-44d8-b5d8-493e35b132d3"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("93d22632-1384-42b5-9730-52e924c471e2") },
                    { new Guid("f7581523-987e-41d9-a7f4-1edff7735a40"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом и без соавторства:", 8, new Guid("de13ac7c-436f-464f-be53-028e857738ee") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("332c8c13-efce-423a-a2d3-f25c55f35944"), true, new Guid("93f577ce-e6c5-4001-a7e5-af683aa81511") },
                    { new Guid("40869c61-bf17-4202-ab7e-2d6ad4ee94f5"), true, new Guid("f29ee4c1-4b56-44ce-8500-217027415015") },
                    { new Guid("414f0412-b0c3-476a-8d3b-4f588639cca7"), true, new Guid("f29ee4c1-4b56-44ce-8500-217027415015") },
                    { new Guid("497d36ac-37e2-4c22-98d8-b4ece6f19b48"), true, new Guid("f29ee4c1-4b56-44ce-8500-217027415015") },
                    { new Guid("546f996f-3c7a-4e84-b6f3-06122fe6a810"), true, new Guid("93f577ce-e6c5-4001-a7e5-af683aa81511") },
                    { new Guid("5f54cab0-6fd8-4059-9b18-19f1ffb2bf09"), true, new Guid("93f577ce-e6c5-4001-a7e5-af683aa81511") },
                    { new Guid("681299f7-cc86-408f-8539-9c94ee364814"), true, new Guid("93f577ce-e6c5-4001-a7e5-af683aa81511") },
                    { new Guid("6c85c44d-50cb-407b-bb30-4482348f435b"), true, new Guid("93f577ce-e6c5-4001-a7e5-af683aa81511") },
                    { new Guid("9a0f3e78-f319-4b3f-a670-0ecaccf1b823"), true, new Guid("f29ee4c1-4b56-44ce-8500-217027415015") },
                    { new Guid("aa548383-b4e5-4175-a230-33126b148324"), true, new Guid("f29ee4c1-4b56-44ce-8500-217027415015") },
                    { new Guid("ad83d774-4926-4f45-b815-32f44af8c40c"), true, new Guid("f29ee4c1-4b56-44ce-8500-217027415015") },
                    { new Guid("c5efec5f-b98b-49b6-92f5-ee9cbd24731b"), true, new Guid("f29ee4c1-4b56-44ce-8500-217027415015") },
                    { new Guid("ffb732d7-33ed-49a4-9b4e-47bafad512d9"), true, new Guid("f29ee4c1-4b56-44ce-8500-217027415015") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("2233776a-3195-4f92-81ed-eb9477796d28"), null, new Guid("aab9e618-b28d-4074-9963-d697f377274c"), "Нет" },
                    { new Guid("700ad3c4-1937-4d68-9f94-bd54feaea1df"), null, new Guid("5ac0949b-8195-4f4f-9c16-d63f89fc002e"), "Доктор наук" },
                    { new Guid("b23d7980-c5cb-4299-bbf7-ece3acb8a735"), null, new Guid("aab9e618-b28d-4074-9963-d697f377274c"), "Профессор" },
                    { new Guid("d853bc9c-096e-4ab0-ac35-27fc2dd41034"), null, new Guid("aab9e618-b28d-4074-9963-d697f377274c"), "Доцент" },
                    { new Guid("decb5fc8-63aa-4dfe-af5c-b009d38b2329"), null, new Guid("5ac0949b-8195-4f4f-9c16-d63f89fc002e"), "Кандидат наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("002c3b2c-7219-4f8f-a781-e16116a36955"), null, new Guid("72bdf078-c81a-4795-bf8b-d5eb7aebc7a7"), false, true, new Guid("aa548383-b4e5-4175-a230-33126b148324"), null },
                    { new Guid("010ccf05-c56b-400a-a410-29ba41ad4423"), null, new Guid("72bdf078-c81a-4795-bf8b-d5eb7aebc7a7"), false, true, new Guid("9a0f3e78-f319-4b3f-a670-0ecaccf1b823"), null },
                    { new Guid("070b6237-b97e-4a3d-bbc1-6f20d3115841"), null, new Guid("72bdf078-c81a-4795-bf8b-d5eb7aebc7a7"), false, true, new Guid("ffb732d7-33ed-49a4-9b4e-47bafad512d9"), null },
                    { new Guid("07ce7811-c689-4213-b36d-a442bb307d85"), null, new Guid("fe28051b-1b52-432a-8bc2-35ad66059c81"), false, true, new Guid("5f54cab0-6fd8-4059-9b18-19f1ffb2bf09"), null },
                    { new Guid("0b3cfa0e-77c9-4e91-ac17-5a3e36d25977"), null, new Guid("ab5e3c53-2a44-4bc1-a1c1-393f0685a6c3"), true, true, new Guid("681299f7-cc86-408f-8539-9c94ee364814"), "ResearcherID" },
                    { new Guid("11e58916-7896-4977-97ac-ac3d682e7b75"), null, new Guid("96a09638-966b-482b-a88e-27e1817aa71f"), true, true, new Guid("ffb732d7-33ed-49a4-9b4e-47bafad512d9"), "Ссылка на конкурсную работу" },
                    { new Guid("1a3fc1aa-20d5-4b7b-8092-ced8b8dd45ae"), null, new Guid("72bdf078-c81a-4795-bf8b-d5eb7aebc7a7"), false, true, new Guid("40869c61-bf17-4202-ab7e-2d6ad4ee94f5"), null },
                    { new Guid("3e225323-5e54-4bf0-966c-b1c718c0ec69"), null, new Guid("96a09638-966b-482b-a88e-27e1817aa71f"), true, true, new Guid("ad83d774-4926-4f45-b815-32f44af8c40c"), "Актуальность конкурсной работы" },
                    { new Guid("3f364b2f-1465-4de2-8645-6d522d0f954b"), null, new Guid("ab5e3c53-2a44-4bc1-a1c1-393f0685a6c3"), true, true, new Guid("546f996f-3c7a-4e84-b6f3-06122fe6a810"), "ScopusID" },
                    { new Guid("3fc65a5c-535d-4807-8ad9-95e7800cca24"), null, new Guid("72bdf078-c81a-4795-bf8b-d5eb7aebc7a7"), false, true, new Guid("414f0412-b0c3-476a-8d3b-4f588639cca7"), null },
                    { new Guid("40352cc6-006f-4276-abc2-95f5bb551f64"), null, new Guid("96a09638-966b-482b-a88e-27e1817aa71f"), true, true, new Guid("9a0f3e78-f319-4b3f-a670-0ecaccf1b823"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("5427a2ba-3dfa-413c-8acd-aaeb3d94e4d9"), null, new Guid("fe28051b-1b52-432a-8bc2-35ad66059c81"), false, true, new Guid("6c85c44d-50cb-407b-bb30-4482348f435b"), null },
                    { new Guid("56a00795-1f42-4536-9956-fbb9f5ffae9a"), null, new Guid("72bdf078-c81a-4795-bf8b-d5eb7aebc7a7"), false, true, new Guid("ad83d774-4926-4f45-b815-32f44af8c40c"), null },
                    { new Guid("6ae35bd3-79d3-4b6f-ab9c-280f9bc44083"), null, new Guid("fe28051b-1b52-432a-8bc2-35ad66059c81"), false, true, new Guid("546f996f-3c7a-4e84-b6f3-06122fe6a810"), null },
                    { new Guid("7feadb19-ac8f-4c85-a7c7-fbb26206bb12"), null, new Guid("fe28051b-1b52-432a-8bc2-35ad66059c81"), false, true, new Guid("332c8c13-efce-423a-a2d3-f25c55f35944"), null },
                    { new Guid("8103b030-259b-4f96-979e-13d98c1be364"), null, new Guid("72bdf078-c81a-4795-bf8b-d5eb7aebc7a7"), false, true, new Guid("497d36ac-37e2-4c22-98d8-b4ece6f19b48"), null },
                    { new Guid("814dae57-de98-4215-9f8a-c92d6bb5108f"), null, new Guid("ab5e3c53-2a44-4bc1-a1c1-393f0685a6c3"), true, true, new Guid("332c8c13-efce-423a-a2d3-f25c55f35944"), "РИНЦ AuthorID" },
                    { new Guid("8f917b8e-af42-4eff-8510-92c7f4ad7feb"), null, new Guid("72bdf078-c81a-4795-bf8b-d5eb7aebc7a7"), false, true, new Guid("c5efec5f-b98b-49b6-92f5-ee9cbd24731b"), null },
                    { new Guid("974f0107-ff57-40f4-be95-df7215581663"), null, new Guid("fe28051b-1b52-432a-8bc2-35ad66059c81"), false, true, new Guid("681299f7-cc86-408f-8539-9c94ee364814"), null },
                    { new Guid("a61d68d7-e283-4337-ab1e-74f849c73df4"), null, new Guid("96a09638-966b-482b-a88e-27e1817aa71f"), true, true, new Guid("414f0412-b0c3-476a-8d3b-4f588639cca7"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("b3351a5c-4d26-462c-a6c6-ca11ba5e6104"), null, new Guid("96a09638-966b-482b-a88e-27e1817aa71f"), true, true, new Guid("40869c61-bf17-4202-ab7e-2d6ad4ee94f5"), "Результаты и выводы" },
                    { new Guid("b8d577ea-d21d-4227-a256-f533bfd12069"), null, new Guid("ab5e3c53-2a44-4bc1-a1c1-393f0685a6c3"), true, true, new Guid("6c85c44d-50cb-407b-bb30-4482348f435b"), "ORCiD" },
                    { new Guid("b966c937-f5e3-4651-8ab6-6e32179f2b62"), null, new Guid("ab5e3c53-2a44-4bc1-a1c1-393f0685a6c3"), true, true, new Guid("5f54cab0-6fd8-4059-9b18-19f1ffb2bf09"), "Google Scholar ID" },
                    { new Guid("c1be94e6-d514-49c2-9ef4-883450715e26"), null, new Guid("96a09638-966b-482b-a88e-27e1817aa71f"), true, true, new Guid("497d36ac-37e2-4c22-98d8-b4ece6f19b48"), "Инновационность" },
                    { new Guid("e4f88876-9341-405f-b19d-cbac108a6846"), null, new Guid("96a09638-966b-482b-a88e-27e1817aa71f"), true, true, new Guid("c5efec5f-b98b-49b6-92f5-ee9cbd24731b"), "Название работы" },
                    { new Guid("eca400d2-79c2-4a9a-883c-d84aa74fe1b1"), null, new Guid("96a09638-966b-482b-a88e-27e1817aa71f"), true, true, new Guid("aa548383-b4e5-4175-a230-33126b148324"), "Методология и методы, используемые в работе" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("298bfacd-f28e-43d6-8041-114db12d2a03"), new Guid("38e86127-35b7-4a85-ae3b-37635d23806c") },
                    { new Guid("298bfacd-f28e-43d6-8041-114db12d2a03"), new Guid("4cfe5b5e-203a-4b31-99db-3836a9cca298") },
                    { new Guid("298bfacd-f28e-43d6-8041-114db12d2a03"), new Guid("4ecfdb43-e729-48c3-aa87-b71bb99e5be5") },
                    { new Guid("298bfacd-f28e-43d6-8041-114db12d2a03"), new Guid("51c0bfd5-54e3-4282-a428-850845b1f996") },
                    { new Guid("298bfacd-f28e-43d6-8041-114db12d2a03"), new Guid("854f4288-350f-4a06-839a-1a5e35661ae2") },
                    { new Guid("298bfacd-f28e-43d6-8041-114db12d2a03"), new Guid("902620ee-b410-490d-a7eb-279d99b836d9") },
                    { new Guid("298bfacd-f28e-43d6-8041-114db12d2a03"), new Guid("9a0fb81b-e445-428b-a138-8504798e0689") },
                    { new Guid("3d1e51fe-18e9-4320-a281-2ee867df6ec0"), new Guid("3b7c6dd0-35fb-4429-937b-b0debe2ffbee") },
                    { new Guid("3d1e51fe-18e9-4320-a281-2ee867df6ec0"), new Guid("bf92e7e9-6e5d-4d35-8bb2-e9693c270310") },
                    { new Guid("68986c81-0d69-4fbf-8c01-81036c4bf2f2"), new Guid("51ef4dd1-d4a8-4737-8853-f1c5454b49c1") },
                    { new Guid("68986c81-0d69-4fbf-8c01-81036c4bf2f2"), new Guid("7182f437-cd87-4a2c-b269-a1db61abd174") },
                    { new Guid("68986c81-0d69-4fbf-8c01-81036c4bf2f2"), new Guid("78214b2a-b80f-4e51-a0a0-0321fc3d8c73") },
                    { new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c"), new Guid("0c1a4869-4465-4355-9037-de683bb878be") },
                    { new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c"), new Guid("3bdfc411-d925-4599-9706-ce2b6227ee5a") },
                    { new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c"), new Guid("42bf3c14-e3c2-4d8f-a39f-bdbbef0bb949") },
                    { new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c"), new Guid("746ca343-156e-42b0-bcac-266a4d350820") },
                    { new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c"), new Guid("7a397476-c662-4728-9d17-5126186cb789") },
                    { new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c"), new Guid("cc5aad06-85fa-4cd0-9640-d247f2464871") },
                    { new Guid("85d9c829-55f3-44f0-90d3-937451a0f74c"), new Guid("db758007-8d84-44d8-b5d8-493e35b132d3") },
                    { new Guid("c86cc38e-1b73-47c6-beae-a93037a36e5e"), new Guid("0d831865-db24-4356-97a9-5901664f592a") },
                    { new Guid("c86cc38e-1b73-47c6-beae-a93037a36e5e"), new Guid("4c9334b3-5a83-4d81-8386-0c38bbd525a6") },
                    { new Guid("c86cc38e-1b73-47c6-beae-a93037a36e5e"), new Guid("6dcc2b10-2083-423b-8cf4-78e806cba501") },
                    { new Guid("c86cc38e-1b73-47c6-beae-a93037a36e5e"), new Guid("a9aa8408-17e7-45d0-aa88-519b1ba3227e") },
                    { new Guid("c86cc38e-1b73-47c6-beae-a93037a36e5e"), new Guid("f7581523-987e-41d9-a7f4-1edff7735a40") },
                    { new Guid("cf2dce72-bfbd-441c-a1f1-efb5dbfc7661"), new Guid("0c1a4869-4465-4355-9037-de683bb878be") },
                    { new Guid("cf2dce72-bfbd-441c-a1f1-efb5dbfc7661"), new Guid("78214b2a-b80f-4e51-a0a0-0321fc3d8c73") },
                    { new Guid("cf2dce72-bfbd-441c-a1f1-efb5dbfc7661"), new Guid("cc5aad06-85fa-4cd0-9640-d247f2464871") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0c7b4127-853b-42c1-a1c3-21a8fb69c24f"), new Guid("b1997a50-f3f4-413b-bdcf-3034460012fb"), null, "Исполнитель" },
                    { new Guid("1828b689-6401-48fa-8384-24fea8c0104a"), new Guid("c56f3fc1-3239-43a9-8f93-c000f8e9a99f"), null, "МБД (Q3-Q4)" },
                    { new Guid("1b8f7292-1c04-40d2-a6c9-4030b7953579"), new Guid("da44e0fb-76e1-4dfd-8e6c-53f418adc3c3"), null, "Нет" },
                    { new Guid("206bc03f-41ee-46a8-ac6b-13c3644ce9ac"), new Guid("591500c1-16fa-4e2a-906c-1d0592ef78ed"), null, "Полезная модель" },
                    { new Guid("212220cb-82cd-422e-a0ee-fe4161ccefcc"), new Guid("01a3fd5f-e733-4231-bd15-e4822f0c59e4"), null, "Полезная модель" },
                    { new Guid("2a811229-0078-4c93-99a9-4835bf1133e7"), new Guid("01a3fd5f-e733-4231-bd15-e4822f0c59e4"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("2eaf2bd8-888c-4b7a-bc7e-924c811ff07b"), new Guid("01a3fd5f-e733-4231-bd15-e4822f0c59e4"), null, "Изобретение" },
                    { new Guid("374d852b-d271-4fb7-ae40-eea855bb68f6"), new Guid("d856acb7-d188-4e41-87e1-21aa5a08ce84"), null, "Нет" },
                    { new Guid("39ac4cca-3c6d-4247-b6bc-da12f75101ab"), new Guid("1b881ec7-16d0-4694-902a-8a6001b4b90c"), null, "Русский" },
                    { new Guid("5520524c-b53d-439f-a6a0-28258e956dac"), new Guid("4a96c023-3d63-428d-8cc2-fc52741e397b"), null, "Региональный" },
                    { new Guid("590a2124-a6b7-4c83-8d0f-55ab61f4c303"), new Guid("b5537c32-f0dd-4d8c-b2f9-b9a9f5422a0a"), null, "Лабораторные" },
                    { new Guid("6a8cff74-f49c-4f3b-a48e-dc6015caf5a5"), new Guid("a1727995-b4a6-4f35-babc-6daa0fdd067f"), null, "Английский" },
                    { new Guid("74756c02-28a3-49a7-9ca7-f67f09c422fb"), new Guid("b5537c32-f0dd-4d8c-b2f9-b9a9f5422a0a"), null, "Лекции" },
                    { new Guid("767a5d80-6de7-4213-b93f-b5be1abd8913"), new Guid("01a3fd5f-e733-4231-bd15-e4822f0c59e4"), null, "Промышленный образец" },
                    { new Guid("8dd1a901-8fe5-43bc-8d5d-c82f3e3ac900"), new Guid("24190458-6133-4bb1-8bae-eb8f11da5c55"), null, "Учебник" },
                    { new Guid("958536bd-0bad-4163-83b0-0a9bbaeae761"), new Guid("c69aa347-6e9c-4c23-a654-d2150536ae52"), null, "Нет" },
                    { new Guid("9686686d-6137-4fc8-9cfd-6e45df413c62"), new Guid("c56f3fc1-3239-43a9-8f93-c000f8e9a99f"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("98bc047c-dd6f-44a1-a6b0-38e5e6cd35d8"), new Guid("c56f3fc1-3239-43a9-8f93-c000f8e9a99f"), null, "ВАК (К2-К3)" },
                    { new Guid("a737c546-16f8-4435-a2b5-865892f520b4"), new Guid("4a96c023-3d63-428d-8cc2-fc52741e397b"), null, "Международный" },
                    { new Guid("add564bc-be03-4bfa-8435-7b77a70eee74"), new Guid("4a96c023-3d63-428d-8cc2-fc52741e397b"), null, "Всероссийский" },
                    { new Guid("ba641e10-fbde-40aa-ae38-8f8fd0028551"), new Guid("24190458-6133-4bb1-8bae-eb8f11da5c55"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("bc6d30db-a6d6-4a37-81f4-cc58b7c3a853"), new Guid("c56f3fc1-3239-43a9-8f93-c000f8e9a99f"), null, "РИНЦ" },
                    { new Guid("bf785016-fea3-40eb-82c8-d95be984a095"), new Guid("24190458-6133-4bb1-8bae-eb8f11da5c55"), null, "Монография" },
                    { new Guid("cc2cf5e0-83d6-4c9e-a3bd-bab3c99818cc"), new Guid("c69aa347-6e9c-4c23-a654-d2150536ae52"), null, "Есть" },
                    { new Guid("cf5d1882-31b9-422e-b576-7a0c903f1275"), new Guid("a1727995-b4a6-4f35-babc-6daa0fdd067f"), null, "Другой" },
                    { new Guid("d518d472-27f1-4166-9e8b-e276a78ec261"), new Guid("1b881ec7-16d0-4694-902a-8a6001b4b90c"), null, "Иностранный" },
                    { new Guid("d52ff8a5-a0bf-44e5-9fdd-03dfa684b045"), new Guid("a1727995-b4a6-4f35-babc-6daa0fdd067f"), null, "Русский" },
                    { new Guid("e0f0ab3b-12e8-4a93-ad75-f164ac4d2d0f"), new Guid("ce36a31b-13cc-4fbc-b5bd-fb2e20525c7d"), null, "Нет" },
                    { new Guid("e3f2b317-b1c8-4d46-8523-1ca30d45e049"), new Guid("da44e0fb-76e1-4dfd-8e6c-53f418adc3c3"), null, "Есть" },
                    { new Guid("e6462eb3-04bd-4aca-9147-afb30b39a430"), new Guid("d856acb7-d188-4e41-87e1-21aa5a08ce84"), null, "Есть" },
                    { new Guid("eb072ce9-8208-4851-886e-fcd311a2f033"), new Guid("ce36a31b-13cc-4fbc-b5bd-fb2e20525c7d"), null, "Есть" },
                    { new Guid("ee076437-b83c-4d3d-909c-3d83e84f24c3"), new Guid("591500c1-16fa-4e2a-906c-1d0592ef78ed"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("ee3c29ae-dfe1-4bb2-b772-a9b7678027d7"), new Guid("591500c1-16fa-4e2a-906c-1d0592ef78ed"), null, "Изобретение" },
                    { new Guid("ee69618d-7281-47aa-a792-0350ee2409c9"), new Guid("b1997a50-f3f4-413b-bdcf-3034460012fb"), null, "Руководитель" },
                    { new Guid("f45acad2-1558-4121-bc59-ca341020849e"), new Guid("591500c1-16fa-4e2a-906c-1d0592ef78ed"), null, "Промышленный образец" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationFormExperts_UserInfoId",
                table: "ApplicationFormExperts",
                column: "UserInfoId");

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
                name: "IX_MarkVals_ApplicationId_MarkId_ExpertId",
                table: "MarkVals",
                columns: new[] { "ApplicationId", "MarkId", "ExpertId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MarkVals_ExpertId",
                table: "MarkVals",
                column: "ExpertId");

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
                name: "ApplicationFormExperts");

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
