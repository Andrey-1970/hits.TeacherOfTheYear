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
                    LastEmailSentDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicationFormId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserInfoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationFormExperts", x => x.Id);
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
                    { new Guid("3a236626-7d44-4741-bff9-2ce213ffa2a4"), 5, "Отклонена" },
                    { new Guid("59e4b44f-00ab-4266-bb2a-816eadd9eda0"), 3, "В процессе рассмотрения" },
                    { new Guid("63620115-1ba1-43e5-a071-af8fcf616fea"), 1, "В ожидании заполнения" },
                    { new Guid("838c6543-c663-4a77-b5c0-64bfa805b525"), 6, "Оценена" },
                    { new Guid("9667cb70-9c42-41a7-a45f-267b15cacc01"), 4, "Одобрена" },
                    { new Guid("b5bea991-81cf-4209-9bc6-552fb6ed7c83"), 2, "В ожидании рассмотрения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03638c46-2c07-4478-aa96-d79ed015cd9e", null, "Admin", "ADMIN" },
                    { "50786817-3f9b-4244-bd05-3cd80f0e32d6", null, "Organiser", "ORGANISER" },
                    { "638c43b2-6f67-4d89-825c-d7f82fd18ce8", null, "Participant", "PARTICIPANT" },
                    { "86148448-664f-4cb6-8c2f-23954893243b", null, "Voter", "VOTER" },
                    { "ccb0b6b5-cada-46c4-8203-c2fe33926803", null, "Expert", "EXPERT" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("97481e99-56e0-4c21-bfbe-28d045e17873"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("ffe043e0-d1a9-4e51-a287-1baf34b919b3"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("43e5b1fe-fa32-4c5e-a60c-d9b6570c3308"), "Научно-педагогическая деятельность", 5 },
                    { new Guid("4b9a9bb8-9bdd-47e5-a969-14a375f1e20e"), "Научно-исследовательская деятельность", 6 },
                    { new Guid("8b5a6559-a7bb-43ba-9d5d-d1b139922c37"), "Общая информация", 1 },
                    { new Guid("a39ab3ef-84af-46d1-b28f-e07b54e17a5a"), "Конкурсная работа", 3 },
                    { new Guid("ea9da32e-4ab7-4e7d-9677-576252138b26"), "Профессиональное развитие", 4 },
                    { new Guid("eb8357c4-a96e-4ecd-9c4d-4ea2a9effc50"), "Категория участников", 2 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a"), "Основной", 1 },
                    { new Guid("08cddbff-ae00-46f0-8f22-8fd3151e25e8"), "Профессиональные показатели", 4 },
                    { new Guid("4fff241c-0574-4184-ae1f-31c00fada8c0"), "Методическая деятельность", 3 },
                    { new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("c0bbc94d-9e63-403f-9d60-b3755975531b"), "Инновационная и иная деятельность", 6 },
                    { new Guid("c761a92e-2268-4057-a880-1917e1325c41"), "Конкурсная работа", 7 },
                    { new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e"), "Образовательная деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("24e2503e-4776-4373-85c7-abacc3aba665"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("6d1858f1-6238-4767-97c0-9ae21b66ba59"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("14af8ae1-6786-45ea-8325-873875b167ce"), "int" },
                    { new Guid("4ff2d227-7bcc-417a-8f04-0768d6d491bf"), "bool" },
                    { new Guid("52681f66-4c73-4a07-a98e-417cc6a367fd"), "DateTime" },
                    { new Guid("909032a2-1136-4d26-8727-5f97f54abf43"), "string" },
                    { new Guid("dd408d1a-bbb0-4856-b47d-b017c7a7d095"), "TextArea" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("43e5b1fe-fa32-4c5e-a60c-d9b6570c3308"), new Guid("24e2503e-4776-4373-85c7-abacc3aba665") },
                    { new Guid("4b9a9bb8-9bdd-47e5-a969-14a375f1e20e"), new Guid("6d1858f1-6238-4767-97c0-9ae21b66ba59") },
                    { new Guid("8b5a6559-a7bb-43ba-9d5d-d1b139922c37"), new Guid("24e2503e-4776-4373-85c7-abacc3aba665") },
                    { new Guid("8b5a6559-a7bb-43ba-9d5d-d1b139922c37"), new Guid("6d1858f1-6238-4767-97c0-9ae21b66ba59") },
                    { new Guid("a39ab3ef-84af-46d1-b28f-e07b54e17a5a"), new Guid("24e2503e-4776-4373-85c7-abacc3aba665") },
                    { new Guid("a39ab3ef-84af-46d1-b28f-e07b54e17a5a"), new Guid("6d1858f1-6238-4767-97c0-9ae21b66ba59") },
                    { new Guid("ea9da32e-4ab7-4e7d-9677-576252138b26"), new Guid("24e2503e-4776-4373-85c7-abacc3aba665") },
                    { new Guid("ea9da32e-4ab7-4e7d-9677-576252138b26"), new Guid("6d1858f1-6238-4767-97c0-9ae21b66ba59") },
                    { new Guid("eb8357c4-a96e-4ecd-9c4d-4ea2a9effc50"), new Guid("24e2503e-4776-4373-85c7-abacc3aba665") },
                    { new Guid("eb8357c4-a96e-4ecd-9c4d-4ea2a9effc50"), new Guid("6d1858f1-6238-4767-97c0-9ae21b66ba59") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("11040ad1-06fc-48e8-aaa9-c777b6cd5789"), new Guid("8b5a6559-a7bb-43ba-9d5d-d1b139922c37"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("1e521770-e605-47d0-8ac5-06dba254dbf9"), new Guid("43e5b1fe-fa32-4c5e-a60c-d9b6570c3308"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("268aa40e-d144-41e0-a8a1-2c3a10c8b851"), new Guid("eb8357c4-a96e-4ecd-9c4d-4ea2a9effc50"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("295d0cce-037d-4aee-b532-394b0d2805ea"), new Guid("8b5a6559-a7bb-43ba-9d5d-d1b139922c37"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("3e5dd45f-d781-466f-90ec-3543b1610df9"), new Guid("4b9a9bb8-9bdd-47e5-a969-14a375f1e20e"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("3fca78b3-b712-43f2-b488-fd0e28358d48"), new Guid("eb8357c4-a96e-4ecd-9c4d-4ea2a9effc50"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("41ba9b21-4f7c-4db9-a7db-b5f7af80c8f8"), new Guid("8b5a6559-a7bb-43ba-9d5d-d1b139922c37"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("52681f66-4c73-4a07-a98e-417cc6a367fd") },
                    { new Guid("56278d07-eba2-44dd-ba78-1c423387d32f"), new Guid("43e5b1fe-fa32-4c5e-a60c-d9b6570c3308"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("59c0f7ba-5952-4484-ade4-10dff9a71a5c"), new Guid("4b9a9bb8-9bdd-47e5-a969-14a375f1e20e"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("7c662cfa-811c-40fe-98ef-8f246c24dc10"), new Guid("eb8357c4-a96e-4ecd-9c4d-4ea2a9effc50"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("7eeb8b8b-5072-4703-872b-629a9c62959d"), new Guid("8b5a6559-a7bb-43ba-9d5d-d1b139922c37"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("822dd4d6-34c9-4617-9f96-4745570d4c3a"), new Guid("8b5a6559-a7bb-43ba-9d5d-d1b139922c37"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("82a2df51-8b93-496e-a8d3-f9334c44bdc8"), new Guid("8b5a6559-a7bb-43ba-9d5d-d1b139922c37"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("8d52aa9b-f9fe-4725-99d6-7728422aa376"), new Guid("8b5a6559-a7bb-43ba-9d5d-d1b139922c37"), null, true, true, "Место работы", 6, "Название организации", new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("b7b2c736-4ef9-498f-9563-e977609b89e7"), new Guid("43e5b1fe-fa32-4c5e-a60c-d9b6570c3308"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("b8069c39-16f4-4b9e-a795-8b5b9048b7ce"), new Guid("8b5a6559-a7bb-43ba-9d5d-d1b139922c37"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("c1c42a41-4717-45ad-b7b3-d7ccb98c08fa"), new Guid("8b5a6559-a7bb-43ba-9d5d-d1b139922c37"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("f3d127ba-70ab-4eca-9d5f-0218c1cf74c8"), new Guid("8b5a6559-a7bb-43ba-9d5d-d1b139922c37"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("909032a2-1136-4d26-8727-5f97f54abf43") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a"), new Guid("24e2503e-4776-4373-85c7-abacc3aba665") },
                    { new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a"), new Guid("6d1858f1-6238-4767-97c0-9ae21b66ba59") },
                    { new Guid("08cddbff-ae00-46f0-8f22-8fd3151e25e8"), new Guid("24e2503e-4776-4373-85c7-abacc3aba665") },
                    { new Guid("4fff241c-0574-4184-ae1f-31c00fada8c0"), new Guid("24e2503e-4776-4373-85c7-abacc3aba665") },
                    { new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b"), new Guid("6d1858f1-6238-4767-97c0-9ae21b66ba59") },
                    { new Guid("c0bbc94d-9e63-403f-9d60-b3755975531b"), new Guid("6d1858f1-6238-4767-97c0-9ae21b66ba59") },
                    { new Guid("c761a92e-2268-4057-a880-1917e1325c41"), new Guid("24e2503e-4776-4373-85c7-abacc3aba665") },
                    { new Guid("c761a92e-2268-4057-a880-1917e1325c41"), new Guid("6d1858f1-6238-4767-97c0-9ae21b66ba59") },
                    { new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e"), new Guid("24e2503e-4776-4373-85c7-abacc3aba665") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("1bbcbc5b-b337-45bd-87e5-2e19fd5092c8"), new Guid("43e5b1fe-fa32-4c5e-a60c-d9b6570c3308"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("24931e37-1efa-468f-9169-b00e961eec55"), new Guid("ea9da32e-4ab7-4e7d-9677-576252138b26"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 },
                    { new Guid("2dfe1efd-361f-48e1-84c0-3079114de32d"), new Guid("ea9da32e-4ab7-4e7d-9677-576252138b26"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("33b0124e-85c9-4527-9403-dfc57fe9654f"), new Guid("43e5b1fe-fa32-4c5e-a60c-d9b6570c3308"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 },
                    { new Guid("4d1dfc00-c9a9-4f65-ae13-0d8dbcab2fec"), new Guid("ea9da32e-4ab7-4e7d-9677-576252138b26"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("4f04d524-8c6d-420f-869b-d0d704f6c1f2"), new Guid("43e5b1fe-fa32-4c5e-a60c-d9b6570c3308"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("594a6fc2-3bf1-4d0e-913d-8dc57ea1a260"), new Guid("43e5b1fe-fa32-4c5e-a60c-d9b6570c3308"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 },
                    { new Guid("775495e2-d608-4ccf-9924-e8161a715d60"), new Guid("4b9a9bb8-9bdd-47e5-a969-14a375f1e20e"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("806b8266-770b-4a2d-9d02-252cd52bb218"), new Guid("43e5b1fe-fa32-4c5e-a60c-d9b6570c3308"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 },
                    { new Guid("9501cc09-1a05-44c7-9dbb-9983efd2d810"), new Guid("4b9a9bb8-9bdd-47e5-a969-14a375f1e20e"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("9a90dbec-31aa-418a-a1f3-031b78829673"), new Guid("a39ab3ef-84af-46d1-b28f-e07b54e17a5a"), true, true, "Краткая аннотация конкурсной работы", 1 },
                    { new Guid("aa6b9511-d35a-4eb0-8d0e-6cdc2d3388de"), new Guid("4b9a9bb8-9bdd-47e5-a969-14a375f1e20e"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("b3c9e804-7c50-4433-978a-492ce05db224"), new Guid("4b9a9bb8-9bdd-47e5-a969-14a375f1e20e"), false, false, "Список научных публикаций за последние 5 лет", 10 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0040f722-bc93-4383-8e16-94524dd018ee"), true, "Наличие грифа", 5, new Guid("806b8266-770b-4a2d-9d02-252cd52bb218"), new Guid("4ff2d227-7bcc-417a-8f04-0768d6d491bf") },
                    { new Guid("008a843e-06e2-4b6a-b728-82886fd45348"), true, "Название", 1, new Guid("9a90dbec-31aa-418a-a1f3-031b78829673"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("1303b97c-2eff-437f-a03d-db2c8b192925"), true, "Год", 4, new Guid("4f04d524-8c6d-420f-869b-d0d704f6c1f2"), new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("13892676-848f-41f6-93ca-7d35114518ab"), true, "Название НИР/НИОКР", 1, new Guid("9501cc09-1a05-44c7-9dbb-9983efd2d810"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("15d29aed-84fd-41e6-9377-b63c61b6aa9f"), true, "Статус", 4, new Guid("9501cc09-1a05-44c7-9dbb-9983efd2d810"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("1ddff826-f388-4f88-a82b-324a15380eca"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("9501cc09-1a05-44c7-9dbb-9983efd2d810"), new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("2275154a-236e-4b6c-9289-72ec88debe17"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("b3c9e804-7c50-4433-978a-492ce05db224"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("2c845d8e-5a83-417c-bd8e-02fc40d93968"), true, "Название конкурса/премии", 2, new Guid("33b0124e-85c9-4527-9403-dfc57fe9654f"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("2d3b5978-5efa-4fb2-843c-b8149cc36188"), true, "Название", 2, new Guid("aa6b9511-d35a-4eb0-8d0e-6cdc2d3388de"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("32a01d96-d55c-4672-aa24-4158e6752caf"), true, "Вид", 1, new Guid("775495e2-d608-4ccf-9924-e8161a715d60"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("3645dc1a-7f5a-40eb-a354-5332ccd255bc"), true, "Номер РИД", 4, new Guid("aa6b9511-d35a-4eb0-8d0e-6cdc2d3388de"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("3aac6b46-0172-432e-bddd-a31fcc4608a2"), true, "Ссылка на открытый доступ", 8, new Guid("806b8266-770b-4a2d-9d02-252cd52bb218"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("3b19e2ed-cf37-45d4-84c2-cfe70e19f7db"), true, "Наименование курса", 1, new Guid("1bbcbc5b-b337-45bd-87e5-2e19fd5092c8"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("43091a1e-4909-448b-af1e-de85b8eec614"), true, "Итого (час.)", 5, new Guid("1bbcbc5b-b337-45bd-87e5-2e19fd5092c8"), new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("4372eb6b-2a2a-48a4-8537-51d1d38844f6"), true, "Название разработки", 2, new Guid("775495e2-d608-4ccf-9924-e8161a715d60"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("4c87b2e4-719d-4fb4-b290-7c5f4c63a03b"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("9501cc09-1a05-44c7-9dbb-9983efd2d810"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("4f1c9e92-3b66-4bb3-b671-4a870e931ea4"), true, "Статус конкурса", 3, new Guid("24931e37-1efa-468f-9169-b00e961eec55"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("5d0cf43f-0b8e-451f-8f86-6aa0260196e5"), false, "Тип идентификатора", 1, new Guid("2dfe1efd-361f-48e1-84c0-3079114de32d"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("617da312-d437-414b-a70c-1998bcaeb045"), true, "Название", 2, new Guid("806b8266-770b-4a2d-9d02-252cd52bb218"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("64477318-6098-4a4c-9f76-9b0655f1ac61"), true, "Практические занятия (час.)", 4, new Guid("1bbcbc5b-b337-45bd-87e5-2e19fd5092c8"), new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("655ef715-0ee8-425d-9897-00b514519374"), true, "Год", 1, new Guid("24931e37-1efa-468f-9169-b00e961eec55"), new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("69cf72ce-5110-4d1a-8c96-586d0fe4bcee"), true, "Издание, год", 4, new Guid("b3c9e804-7c50-4433-978a-492ce05db224"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("6bae0479-4c84-4e22-9908-4ed60d92bd52"), true, "Значение", 2, new Guid("9a90dbec-31aa-418a-a1f3-031b78829673"), new Guid("dd408d1a-bbb0-4856-b47d-b017c7a7d095") },
                    { new Guid("6c27fe52-fb0e-48b3-8e17-9f84d08ff2bc"), true, "Название конкурса", 2, new Guid("24931e37-1efa-468f-9169-b00e961eec55"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("75113c0f-7fff-453c-9151-2a103a9731ad"), true, "Количество печатных листов", 4, new Guid("806b8266-770b-4a2d-9d02-252cd52bb218"), new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("75bfc55c-31a4-4fc5-a019-c6657ca32f3e"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("33b0124e-85c9-4527-9403-dfc57fe9654f"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("77d1dc24-a350-41c2-83be-fb65099286fa"), true, "Ссылка на платформу", 3, new Guid("4f04d524-8c6d-420f-869b-d0d704f6c1f2"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("781f1c17-82b3-4914-a14c-455faa693cc0"), true, "Вид", 1, new Guid("aa6b9511-d35a-4eb0-8d0e-6cdc2d3388de"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("801d4203-f7b3-48ca-a873-455ba8060d90"), true, "Название документа, реквизиты", 1, new Guid("4d1dfc00-c9a9-4f65-ae13-0d8dbcab2fec"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("85c328bb-4e54-40ee-8c43-f9909eac723d"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("594a6fc2-3bf1-4d0e-913d-8dc57ea1a260"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("902ccb43-f5d4-4de3-85e9-9939099a032a"), true, "Соавторы", 2, new Guid("b3c9e804-7c50-4433-978a-492ce05db224"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("91d50a87-d77f-48e7-b85b-ea78b9ae61ca"), true, "Издательство, год", 6, new Guid("806b8266-770b-4a2d-9d02-252cd52bb218"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("97ee12eb-1967-4346-938c-3c27528b0a9e"), true, "ФИО соавторов", 3, new Guid("aa6b9511-d35a-4eb0-8d0e-6cdc2d3388de"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("988c9678-b13d-4aa3-bc5c-c0d69ea09703"), false, "Соавторы", 3, new Guid("806b8266-770b-4a2d-9d02-252cd52bb218"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("9a56553c-5f1b-4c71-9d05-b191b241da2d"), true, "Период выполнения", 3, new Guid("9501cc09-1a05-44c7-9dbb-9983efd2d810"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("9c9de96d-7cf1-4046-abbb-455064a43dde"), true, "Название организации в которую внедрена разработка", 3, new Guid("775495e2-d608-4ccf-9924-e8161a715d60"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("af67b1b5-ba30-4b75-8aba-ea1e584190b5"), true, "Ссылка", 5, new Guid("24931e37-1efa-468f-9169-b00e961eec55"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("afa3a019-ce1a-41fd-99e4-6ca883d66f1c"), true, "Название курса", 1, new Guid("4f04d524-8c6d-420f-869b-d0d704f6c1f2"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("b121297e-8c9b-4415-a735-48cdfb56df9b"), true, "Год", 3, new Guid("33b0124e-85c9-4527-9403-dfc57fe9654f"), new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("b1d8b9c5-8d3e-4888-bdad-f15eb3f7fa78"), true, "Название дисциплины", 1, new Guid("594a6fc2-3bf1-4d0e-913d-8dc57ea1a260"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("b50cfab0-1039-4031-913e-54173cecec39"), true, "Соавторы", 2, new Guid("4f04d524-8c6d-420f-869b-d0d704f6c1f2"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("c45698d7-dbd7-4d9c-adb1-b4aef7df7b96"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("24931e37-1efa-468f-9169-b00e961eec55"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("c477f924-3796-4d3b-bdf3-b845e71267c1"), false, "Идентификатор", 2, new Guid("2dfe1efd-361f-48e1-84c0-3079114de32d"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("c631a458-58e3-4bae-b8ae-2dc2009fbfa5"), true, "Язык публикации", 7, new Guid("806b8266-770b-4a2d-9d02-252cd52bb218"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("c6f54cfe-7af9-403d-a8da-51f4f0b70fe2"), true, "Название статьи", 1, new Guid("b3c9e804-7c50-4433-978a-492ce05db224"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("d46717ac-1223-45d6-998c-ffddab482e93"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("33b0124e-85c9-4527-9403-dfc57fe9654f"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("efb409a5-3640-4d68-9de0-647c2909466a"), true, "Год получения документа", 2, new Guid("4d1dfc00-c9a9-4f65-ae13-0d8dbcab2fec"), new Guid("14af8ae1-6786-45ea-8325-873875b167ce") },
                    { new Guid("f1039475-4bb9-4029-b58a-6c5e838074ce"), true, "ФИО", 1, new Guid("33b0124e-85c9-4527-9403-dfc57fe9654f"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("f29e802e-40b5-44a1-b6be-8fec0fb804ab"), true, "Вид публикации", 1, new Guid("806b8266-770b-4a2d-9d02-252cd52bb218"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("f3cb36fd-166b-4367-8ac0-4b64931816a3"), true, "Язык преподавания", 2, new Guid("1bbcbc5b-b337-45bd-87e5-2e19fd5092c8"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("f448bd7e-0cd9-4bf8-ad74-23e91f8c5965"), true, "Вид", 2, new Guid("594a6fc2-3bf1-4d0e-913d-8dc57ea1a260"), new Guid("909032a2-1136-4d26-8727-5f97f54abf43") },
                    { new Guid("f7d3c900-4525-4a9d-bae4-9cbf85f1aeb8"), true, "Лекции (час.)", 3, new Guid("1bbcbc5b-b337-45bd-87e5-2e19fd5092c8"), new Guid("14af8ae1-6786-45ea-8325-873875b167ce") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("11040ad1-06fc-48e8-aaa9-c777b6cd5789"), new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a") },
                    { new Guid("1e521770-e605-47d0-8ac5-06dba254dbf9"), new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e") },
                    { new Guid("268aa40e-d144-41e0-a8a1-2c3a10c8b851"), new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a") },
                    { new Guid("295d0cce-037d-4aee-b532-394b0d2805ea"), new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a") },
                    { new Guid("3e5dd45f-d781-466f-90ec-3543b1610df9"), new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b") },
                    { new Guid("3fca78b3-b712-43f2-b488-fd0e28358d48"), new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a") },
                    { new Guid("41ba9b21-4f7c-4db9-a7db-b5f7af80c8f8"), new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a") },
                    { new Guid("56278d07-eba2-44dd-ba78-1c423387d32f"), new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e") },
                    { new Guid("59c0f7ba-5952-4484-ade4-10dff9a71a5c"), new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b") },
                    { new Guid("7c662cfa-811c-40fe-98ef-8f246c24dc10"), new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a") },
                    { new Guid("7c662cfa-811c-40fe-98ef-8f246c24dc10"), new Guid("08cddbff-ae00-46f0-8f22-8fd3151e25e8") },
                    { new Guid("7c662cfa-811c-40fe-98ef-8f246c24dc10"), new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b") },
                    { new Guid("7eeb8b8b-5072-4703-872b-629a9c62959d"), new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a") },
                    { new Guid("822dd4d6-34c9-4617-9f96-4745570d4c3a"), new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a") },
                    { new Guid("82a2df51-8b93-496e-a8d3-f9334c44bdc8"), new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a") },
                    { new Guid("8d52aa9b-f9fe-4725-99d6-7728422aa376"), new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a") },
                    { new Guid("b7b2c736-4ef9-498f-9563-e977609b89e7"), new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e") },
                    { new Guid("b8069c39-16f4-4b9e-a795-8b5b9048b7ce"), new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a") },
                    { new Guid("c1c42a41-4717-45ad-b7b3-d7ccb98c08fa"), new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a") },
                    { new Guid("f3d127ba-70ab-4eca-9d5f-0218c1cf74c8"), new Guid("046bd92c-e6ca-4753-b8fa-9826b218723a") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("08cddbff-ae00-46f0-8f22-8fd3151e25e8"), new Guid("24931e37-1efa-468f-9169-b00e961eec55") },
                    { new Guid("08cddbff-ae00-46f0-8f22-8fd3151e25e8"), new Guid("4d1dfc00-c9a9-4f65-ae13-0d8dbcab2fec") },
                    { new Guid("4fff241c-0574-4184-ae1f-31c00fada8c0"), new Guid("594a6fc2-3bf1-4d0e-913d-8dc57ea1a260") },
                    { new Guid("4fff241c-0574-4184-ae1f-31c00fada8c0"), new Guid("806b8266-770b-4a2d-9d02-252cd52bb218") },
                    { new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b"), new Guid("24931e37-1efa-468f-9169-b00e961eec55") },
                    { new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b"), new Guid("2dfe1efd-361f-48e1-84c0-3079114de32d") },
                    { new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b"), new Guid("9501cc09-1a05-44c7-9dbb-9983efd2d810") },
                    { new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b"), new Guid("b3c9e804-7c50-4433-978a-492ce05db224") },
                    { new Guid("c0bbc94d-9e63-403f-9d60-b3755975531b"), new Guid("4d1dfc00-c9a9-4f65-ae13-0d8dbcab2fec") },
                    { new Guid("c0bbc94d-9e63-403f-9d60-b3755975531b"), new Guid("775495e2-d608-4ccf-9924-e8161a715d60") },
                    { new Guid("c0bbc94d-9e63-403f-9d60-b3755975531b"), new Guid("aa6b9511-d35a-4eb0-8d0e-6cdc2d3388de") },
                    { new Guid("c761a92e-2268-4057-a880-1917e1325c41"), new Guid("9a90dbec-31aa-418a-a1f3-031b78829673") },
                    { new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e"), new Guid("1bbcbc5b-b337-45bd-87e5-2e19fd5092c8") },
                    { new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e"), new Guid("33b0124e-85c9-4527-9403-dfc57fe9654f") },
                    { new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e"), new Guid("4f04d524-8c6d-420f-869b-d0d704f6c1f2") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("05670b43-87ab-4656-8d80-09646c3df98a"), "EvaluateMark13", new Guid("7c662cfa-811c-40fe-98ef-8f246c24dc10"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("071c84dd-2c67-4859-82b5-ff1d660d2db6"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("1bbcbc5b-b337-45bd-87e5-2e19fd5092c8") },
                    { new Guid("0e1034b0-f523-4b4c-abe6-b398826650ae"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("9a90dbec-31aa-418a-a1f3-031b78829673") },
                    { new Guid("14e01340-4341-4d83-aa34-30bf441b8414"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("594a6fc2-3bf1-4d0e-913d-8dc57ea1a260") },
                    { new Guid("182255b2-da2b-4150-85b0-ff0346f72448"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом и без соавторства:", 8, new Guid("806b8266-770b-4a2d-9d02-252cd52bb218") },
                    { new Guid("24699f9b-f5ed-40cd-82f9-8e686348e99e"), "EvaluateMark5", new Guid("b7b2c736-4ef9-498f-9563-e977609b89e7"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("3a298f75-94a5-4c14-ab06-ebe6063c88fc"), "EvaluateMark3", new Guid("1e521770-e605-47d0-8ac5-06dba254dbf9"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("3b523069-e3ba-4c62-8cda-d2f4138f6ac1"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("775495e2-d608-4ccf-9924-e8161a715d60") },
                    { new Guid("4ee162d2-4b00-4a5c-87c2-122222ac35b2"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("806b8266-770b-4a2d-9d02-252cd52bb218") },
                    { new Guid("5eaf9733-e011-433a-9cd3-18648efb010d"), "EvaluateMark20", new Guid("3e5dd45f-d781-466f-90ec-3543b1610df9"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("6c3d4ed8-7617-441b-81c0-2a1a1acda9e0"), "EvaluateMark19", new Guid("59c0f7ba-5952-4484-ade4-10dff9a71a5c"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("7cf274e9-7cbc-414c-beb6-859fbbbcfe72"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("33b0124e-85c9-4527-9403-dfc57fe9654f") },
                    { new Guid("85deb1ae-e8e1-4189-ba0b-e5d611e2b532"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("24931e37-1efa-468f-9169-b00e961eec55") },
                    { new Guid("886bb636-ecbb-4e36-962c-11f7bff104b6"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("b3c9e804-7c50-4433-978a-492ce05db224") },
                    { new Guid("8aaa680b-692f-485d-97c3-39f3122a7174"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("9501cc09-1a05-44c7-9dbb-9983efd2d810") },
                    { new Guid("8c65b718-9a94-427e-bae5-8d08691b1b1f"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("aa6b9511-d35a-4eb0-8d0e-6cdc2d3388de") },
                    { new Guid("9250ad25-788c-492f-b829-3b98d4460175"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("1bbcbc5b-b337-45bd-87e5-2e19fd5092c8") },
                    { new Guid("a5b18cc1-91d5-466d-81f1-faacfcd940ec"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("4d1dfc00-c9a9-4f65-ae13-0d8dbcab2fec") },
                    { new Guid("b5f076b1-3de4-4d99-b8ae-0104712bf357"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("806b8266-770b-4a2d-9d02-252cd52bb218") },
                    { new Guid("c9f363db-5ee6-4e8c-b408-0fe176cb1361"), "EvaluateMark4", new Guid("56278d07-eba2-44dd-ba78-1c423387d32f"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("ca04ea5d-88ea-4785-8f62-a8e9b0cb06b2"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("9501cc09-1a05-44c7-9dbb-9983efd2d810") },
                    { new Guid("d056dffa-6061-4b99-83ee-70abed7312d6"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("4f04d524-8c6d-420f-869b-d0d704f6c1f2") },
                    { new Guid("e45a5816-5d7f-439e-a754-82ff0f8d1d3f"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("9a90dbec-31aa-418a-a1f3-031b78829673") },
                    { new Guid("e688f59f-6e7f-4658-90ed-ada4879fb9bd"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("806b8266-770b-4a2d-9d02-252cd52bb218") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("1b644301-664e-444e-99a0-756058df5c92"), true, new Guid("9a90dbec-31aa-418a-a1f3-031b78829673") },
                    { new Guid("1c00ee0e-4c64-4831-9d92-d83dd75e34fa"), true, new Guid("9a90dbec-31aa-418a-a1f3-031b78829673") },
                    { new Guid("2c0dd453-a779-4892-99e4-9d886af7ad9b"), true, new Guid("2dfe1efd-361f-48e1-84c0-3079114de32d") },
                    { new Guid("4ef2789b-c092-4099-8673-0de7671ecffc"), true, new Guid("2dfe1efd-361f-48e1-84c0-3079114de32d") },
                    { new Guid("594efcca-ebaa-4257-b558-2c1df76d4241"), true, new Guid("9a90dbec-31aa-418a-a1f3-031b78829673") },
                    { new Guid("6334b814-77b5-4acd-8b7b-763a9c0ed6f8"), true, new Guid("9a90dbec-31aa-418a-a1f3-031b78829673") },
                    { new Guid("7292bcde-590a-4daf-ade6-9865e588a806"), true, new Guid("9a90dbec-31aa-418a-a1f3-031b78829673") },
                    { new Guid("78515378-d696-45ac-9313-bba38ba54f5c"), true, new Guid("9a90dbec-31aa-418a-a1f3-031b78829673") },
                    { new Guid("79413976-037c-475d-ad8f-24e173a9073f"), true, new Guid("9a90dbec-31aa-418a-a1f3-031b78829673") },
                    { new Guid("85b6ff62-748f-4fe9-82ff-789d2c3e8c36"), true, new Guid("2dfe1efd-361f-48e1-84c0-3079114de32d") },
                    { new Guid("9047498b-e427-4b33-b6cb-79b129e377b0"), true, new Guid("2dfe1efd-361f-48e1-84c0-3079114de32d") },
                    { new Guid("9bc1c644-a026-41fd-9eb6-1702883e1708"), true, new Guid("9a90dbec-31aa-418a-a1f3-031b78829673") },
                    { new Guid("c9f7a253-9919-4616-bd8e-140d09d4974e"), true, new Guid("2dfe1efd-361f-48e1-84c0-3079114de32d") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("01571add-cbe2-4c55-885e-d64a1d97cb0c"), null, new Guid("7c662cfa-811c-40fe-98ef-8f246c24dc10"), "Нет" },
                    { new Guid("5e708ec1-b260-4989-b692-85c268972eea"), null, new Guid("3fca78b3-b712-43f2-b488-fd0e28358d48"), "Кандидат наук" },
                    { new Guid("6c2e4097-a810-4639-9876-8fd52d3f8f8b"), null, new Guid("7c662cfa-811c-40fe-98ef-8f246c24dc10"), "Доцент" },
                    { new Guid("70f759c7-8edd-48e4-ad6e-e4b47f2869e0"), null, new Guid("3fca78b3-b712-43f2-b488-fd0e28358d48"), "Доктор наук" },
                    { new Guid("7b0c39ef-3fa6-49ed-8b9e-583308a6edd1"), null, new Guid("7c662cfa-811c-40fe-98ef-8f246c24dc10"), "Профессор" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("031d6bb9-f630-4119-9cf2-18a7cc8d193a"), null, new Guid("6bae0479-4c84-4e22-9908-4ed60d92bd52"), false, true, new Guid("1b644301-664e-444e-99a0-756058df5c92"), null },
                    { new Guid("2892e8f4-07d5-4f66-a128-be678dea40e9"), null, new Guid("c477f924-3796-4d3b-bdf3-b845e71267c1"), false, true, new Guid("85b6ff62-748f-4fe9-82ff-789d2c3e8c36"), null },
                    { new Guid("2f36545e-422f-4176-b150-d840a540d8f6"), null, new Guid("6bae0479-4c84-4e22-9908-4ed60d92bd52"), false, true, new Guid("7292bcde-590a-4daf-ade6-9865e588a806"), null },
                    { new Guid("2f6f9660-cb87-423c-80fc-99a9db228f33"), null, new Guid("c477f924-3796-4d3b-bdf3-b845e71267c1"), false, true, new Guid("2c0dd453-a779-4892-99e4-9d886af7ad9b"), null },
                    { new Guid("309af6d9-3671-41bf-a79d-c1d66250498d"), null, new Guid("008a843e-06e2-4b6a-b728-82886fd45348"), true, true, new Guid("1b644301-664e-444e-99a0-756058df5c92"), "Методология и методы, используемые в работе" },
                    { new Guid("335a2ffe-4378-4cfc-b0c8-b0214fc38f74"), null, new Guid("5d0cf43f-0b8e-451f-8f86-6aa0260196e5"), true, true, new Guid("85b6ff62-748f-4fe9-82ff-789d2c3e8c36"), "ORCiD" },
                    { new Guid("501c01d4-8b55-4f41-a635-46a9dd2b9a2d"), null, new Guid("6bae0479-4c84-4e22-9908-4ed60d92bd52"), false, true, new Guid("9bc1c644-a026-41fd-9eb6-1702883e1708"), null },
                    { new Guid("51fc55aa-9d31-46b5-aa03-03f1cb75e008"), null, new Guid("008a843e-06e2-4b6a-b728-82886fd45348"), true, true, new Guid("6334b814-77b5-4acd-8b7b-763a9c0ed6f8"), "Название работы" },
                    { new Guid("5c18ccbe-da19-4dfe-b364-e81c4feabf59"), null, new Guid("008a843e-06e2-4b6a-b728-82886fd45348"), true, true, new Guid("594efcca-ebaa-4257-b558-2c1df76d4241"), "Актуальность конкурсной работы" },
                    { new Guid("5f8df5ee-7ec0-46d6-994e-730729a08c1b"), null, new Guid("6bae0479-4c84-4e22-9908-4ed60d92bd52"), false, true, new Guid("78515378-d696-45ac-9313-bba38ba54f5c"), null },
                    { new Guid("726a460d-3ae9-422e-86c9-4903ed24ab56"), null, new Guid("6bae0479-4c84-4e22-9908-4ed60d92bd52"), false, true, new Guid("1c00ee0e-4c64-4831-9d92-d83dd75e34fa"), null },
                    { new Guid("76f9fe99-b784-4336-869d-2c401a7b0fa8"), null, new Guid("008a843e-06e2-4b6a-b728-82886fd45348"), true, true, new Guid("7292bcde-590a-4daf-ade6-9865e588a806"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("794c8923-e584-4fb7-a556-86f4964a84aa"), null, new Guid("5d0cf43f-0b8e-451f-8f86-6aa0260196e5"), true, true, new Guid("4ef2789b-c092-4099-8673-0de7671ecffc"), "ResearcherID" },
                    { new Guid("806c4f45-c5df-4a62-b172-46b6da2db8fb"), null, new Guid("6bae0479-4c84-4e22-9908-4ed60d92bd52"), false, true, new Guid("79413976-037c-475d-ad8f-24e173a9073f"), null },
                    { new Guid("814dec40-a12b-487b-87e8-4f94dfe378cc"), null, new Guid("5d0cf43f-0b8e-451f-8f86-6aa0260196e5"), true, true, new Guid("2c0dd453-a779-4892-99e4-9d886af7ad9b"), "РИНЦ AuthorID" },
                    { new Guid("8294cdca-72a6-4cfa-9302-ae23c00af99e"), null, new Guid("008a843e-06e2-4b6a-b728-82886fd45348"), true, true, new Guid("79413976-037c-475d-ad8f-24e173a9073f"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("8aa30fa4-1d43-4b9b-b1fe-7aa7c2e87905"), null, new Guid("008a843e-06e2-4b6a-b728-82886fd45348"), true, true, new Guid("1c00ee0e-4c64-4831-9d92-d83dd75e34fa"), "Инновационность" },
                    { new Guid("94c7a24f-6e8b-4e36-8c57-27465c07058c"), null, new Guid("c477f924-3796-4d3b-bdf3-b845e71267c1"), false, true, new Guid("4ef2789b-c092-4099-8673-0de7671ecffc"), null },
                    { new Guid("aa298d52-74bf-42e6-a39a-06cd5171c504"), null, new Guid("6bae0479-4c84-4e22-9908-4ed60d92bd52"), false, true, new Guid("594efcca-ebaa-4257-b558-2c1df76d4241"), null },
                    { new Guid("b3925c3c-e1d9-4bf3-9064-318a5ab7554e"), null, new Guid("5d0cf43f-0b8e-451f-8f86-6aa0260196e5"), true, true, new Guid("c9f7a253-9919-4616-bd8e-140d09d4974e"), "ScopusID" },
                    { new Guid("cab97ae7-0e9d-47cd-84f0-48b7ebed8f72"), null, new Guid("008a843e-06e2-4b6a-b728-82886fd45348"), true, true, new Guid("9bc1c644-a026-41fd-9eb6-1702883e1708"), "Ссылка на конкурсную работу" },
                    { new Guid("d5a230c2-6b05-4b3a-8bdb-435c89576dfb"), null, new Guid("c477f924-3796-4d3b-bdf3-b845e71267c1"), false, true, new Guid("c9f7a253-9919-4616-bd8e-140d09d4974e"), null },
                    { new Guid("e1218caa-ef40-4f30-8712-548f488a5a09"), null, new Guid("5d0cf43f-0b8e-451f-8f86-6aa0260196e5"), true, true, new Guid("9047498b-e427-4b33-b6cb-79b129e377b0"), "Google Scholar ID" },
                    { new Guid("e5a59e42-0b64-4d84-9f3c-3e6f97f17d9d"), null, new Guid("6bae0479-4c84-4e22-9908-4ed60d92bd52"), false, true, new Guid("6334b814-77b5-4acd-8b7b-763a9c0ed6f8"), null },
                    { new Guid("ea85c9f2-41d8-4dc0-a5bb-e7050b143935"), null, new Guid("008a843e-06e2-4b6a-b728-82886fd45348"), true, true, new Guid("78515378-d696-45ac-9313-bba38ba54f5c"), "Результаты и выводы" },
                    { new Guid("ef6b4f6e-ebaf-4fa8-a2c6-38004370abb0"), null, new Guid("c477f924-3796-4d3b-bdf3-b845e71267c1"), false, true, new Guid("9047498b-e427-4b33-b6cb-79b129e377b0"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("08cddbff-ae00-46f0-8f22-8fd3151e25e8"), new Guid("05670b43-87ab-4656-8d80-09646c3df98a") },
                    { new Guid("08cddbff-ae00-46f0-8f22-8fd3151e25e8"), new Guid("85deb1ae-e8e1-4189-ba0b-e5d611e2b532") },
                    { new Guid("08cddbff-ae00-46f0-8f22-8fd3151e25e8"), new Guid("a5b18cc1-91d5-466d-81f1-faacfcd940ec") },
                    { new Guid("4fff241c-0574-4184-ae1f-31c00fada8c0"), new Guid("14e01340-4341-4d83-aa34-30bf441b8414") },
                    { new Guid("4fff241c-0574-4184-ae1f-31c00fada8c0"), new Guid("182255b2-da2b-4150-85b0-ff0346f72448") },
                    { new Guid("4fff241c-0574-4184-ae1f-31c00fada8c0"), new Guid("4ee162d2-4b00-4a5c-87c2-122222ac35b2") },
                    { new Guid("4fff241c-0574-4184-ae1f-31c00fada8c0"), new Guid("b5f076b1-3de4-4d99-b8ae-0104712bf357") },
                    { new Guid("4fff241c-0574-4184-ae1f-31c00fada8c0"), new Guid("e688f59f-6e7f-4658-90ed-ada4879fb9bd") },
                    { new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b"), new Guid("05670b43-87ab-4656-8d80-09646c3df98a") },
                    { new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b"), new Guid("5eaf9733-e011-433a-9cd3-18648efb010d") },
                    { new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b"), new Guid("6c3d4ed8-7617-441b-81c0-2a1a1acda9e0") },
                    { new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b"), new Guid("85deb1ae-e8e1-4189-ba0b-e5d611e2b532") },
                    { new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b"), new Guid("886bb636-ecbb-4e36-962c-11f7bff104b6") },
                    { new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b"), new Guid("8aaa680b-692f-485d-97c3-39f3122a7174") },
                    { new Guid("6c3ad112-3041-4c70-89fb-3d4f4332df3b"), new Guid("ca04ea5d-88ea-4785-8f62-a8e9b0cb06b2") },
                    { new Guid("c0bbc94d-9e63-403f-9d60-b3755975531b"), new Guid("3b523069-e3ba-4c62-8cda-d2f4138f6ac1") },
                    { new Guid("c0bbc94d-9e63-403f-9d60-b3755975531b"), new Guid("8c65b718-9a94-427e-bae5-8d08691b1b1f") },
                    { new Guid("c0bbc94d-9e63-403f-9d60-b3755975531b"), new Guid("a5b18cc1-91d5-466d-81f1-faacfcd940ec") },
                    { new Guid("c761a92e-2268-4057-a880-1917e1325c41"), new Guid("0e1034b0-f523-4b4c-abe6-b398826650ae") },
                    { new Guid("c761a92e-2268-4057-a880-1917e1325c41"), new Guid("e45a5816-5d7f-439e-a754-82ff0f8d1d3f") },
                    { new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e"), new Guid("071c84dd-2c67-4859-82b5-ff1d660d2db6") },
                    { new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e"), new Guid("24699f9b-f5ed-40cd-82f9-8e686348e99e") },
                    { new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e"), new Guid("3a298f75-94a5-4c14-ab06-ebe6063c88fc") },
                    { new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e"), new Guid("7cf274e9-7cbc-414c-beb6-859fbbbcfe72") },
                    { new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e"), new Guid("9250ad25-788c-492f-b829-3b98d4460175") },
                    { new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e"), new Guid("c9f363db-5ee6-4e8c-b408-0fe176cb1361") },
                    { new Guid("dbdc02fe-6af9-4c7e-852a-5e0aec7ad07e"), new Guid("d056dffa-6061-4b99-83ee-70abed7312d6") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0ce5b79b-d522-4f3d-9005-ee8c199d22fd"), new Guid("4f1c9e92-3b66-4bb3-b671-4a870e931ea4"), null, "Региональный" },
                    { new Guid("1de0d575-bfe6-44d7-99a8-320144dcfedb"), new Guid("781f1c17-82b3-4914-a14c-455faa693cc0"), null, "Изобретение" },
                    { new Guid("2b3d7572-782b-450b-86db-7037201dbf0a"), new Guid("15d29aed-84fd-41e6-9377-b63c61b6aa9f"), null, "Руководитель" },
                    { new Guid("2e9f107c-112e-4811-b0a0-b337228223ba"), new Guid("781f1c17-82b3-4914-a14c-455faa693cc0"), null, "Полезная модель" },
                    { new Guid("30f87ed4-efdb-4c38-b6a0-3cc0af793874"), new Guid("988c9678-b13d-4aa3-bc5c-c0d69ea09703"), null, "Есть" },
                    { new Guid("33832c39-4e59-4859-874c-ba1d236958a4"), new Guid("f29e802e-40b5-44a1-b6be-8fec0fb804ab"), null, "Монография" },
                    { new Guid("365eb2fe-c983-4bae-965a-f4c5b8dbbd97"), new Guid("b50cfab0-1039-4031-913e-54173cecec39"), null, "Есть" },
                    { new Guid("3abeb7d5-b025-493b-b282-77730d2fb13e"), new Guid("f29e802e-40b5-44a1-b6be-8fec0fb804ab"), null, "Учебник" },
                    { new Guid("3e7e6e17-603e-4f37-86dc-f807191ef6f0"), new Guid("2275154a-236e-4b6c-9289-72ec88debe17"), null, "ВАК (К2-К3)" },
                    { new Guid("47a0a5d7-f1b8-4b5e-bd0a-a5f6a5350f40"), new Guid("f29e802e-40b5-44a1-b6be-8fec0fb804ab"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("4fb0fd5b-91aa-4648-9c03-54196b79975e"), new Guid("32a01d96-d55c-4672-aa24-4158e6752caf"), null, "Изобретение" },
                    { new Guid("710b4e46-b909-445c-bc51-bf03ffeb7b27"), new Guid("b50cfab0-1039-4031-913e-54173cecec39"), null, "Нет" },
                    { new Guid("79816a01-4550-4847-ab8e-71887271e440"), new Guid("c631a458-58e3-4bae-b8ae-2dc2009fbfa5"), null, "Русский" },
                    { new Guid("7a697820-d839-46c8-8bad-3e020b3927fd"), new Guid("32a01d96-d55c-4672-aa24-4158e6752caf"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("8dffe43a-b997-4bba-b003-12ddd7e2c328"), new Guid("0040f722-bc93-4383-8e16-94524dd018ee"), null, "Есть" },
                    { new Guid("9134954d-2002-4d87-a7aa-10d491d9cff0"), new Guid("c631a458-58e3-4bae-b8ae-2dc2009fbfa5"), null, "Иностранный" },
                    { new Guid("9b1f1412-5d5d-4f50-8188-51762fb3b976"), new Guid("f448bd7e-0cd9-4bf8-ad74-23e91f8c5965"), null, "Лабораторные" },
                    { new Guid("9ea95207-d421-4286-99b9-44cd37be9ace"), new Guid("32a01d96-d55c-4672-aa24-4158e6752caf"), null, "Промышленный образец" },
                    { new Guid("a417dbf5-ae68-4ca7-94af-5733f0bff198"), new Guid("f3cb36fd-166b-4367-8ac0-4b64931816a3"), null, "Другой" },
                    { new Guid("a7e91099-5989-4244-afa0-a0c66fdf1135"), new Guid("15d29aed-84fd-41e6-9377-b63c61b6aa9f"), null, "Исполнитель" },
                    { new Guid("b45cd871-cd53-4bdd-92ba-e698bd701dcb"), new Guid("4f1c9e92-3b66-4bb3-b671-4a870e931ea4"), null, "Всероссийский" },
                    { new Guid("beb86e2d-9bd8-4404-971b-6ff0464ccbce"), new Guid("f448bd7e-0cd9-4bf8-ad74-23e91f8c5965"), null, "Лекции" },
                    { new Guid("c03975e4-30a8-4e4e-86a8-9fab4b55e8b7"), new Guid("781f1c17-82b3-4914-a14c-455faa693cc0"), null, "Промышленный образец" },
                    { new Guid("c0ccbf8c-bab4-4ef3-b64a-4baeda514b0e"), new Guid("f3cb36fd-166b-4367-8ac0-4b64931816a3"), null, "Русский" },
                    { new Guid("c558dbca-e48f-4d74-b062-3cb16d6472fc"), new Guid("902ccb43-f5d4-4de3-85e9-9939099a032a"), null, "Есть" },
                    { new Guid("d01eec62-50c6-466d-a71b-2f568f04fbc5"), new Guid("f3cb36fd-166b-4367-8ac0-4b64931816a3"), null, "Английский" },
                    { new Guid("d1ccc318-8738-4d92-9fbb-0a1245c1aa68"), new Guid("0040f722-bc93-4383-8e16-94524dd018ee"), null, "Нет" },
                    { new Guid("db32655f-f77c-414c-aef1-c596b6fa994e"), new Guid("2275154a-236e-4b6c-9289-72ec88debe17"), null, "РИНЦ" },
                    { new Guid("dfde9d52-294a-4eab-a454-4e16b39709a2"), new Guid("32a01d96-d55c-4672-aa24-4158e6752caf"), null, "Полезная модель" },
                    { new Guid("e43a98de-1d2b-46dc-8f20-a63fe32c9865"), new Guid("988c9678-b13d-4aa3-bc5c-c0d69ea09703"), null, "Нет" },
                    { new Guid("f2c3c3ed-1582-4711-928d-ab1816b512b3"), new Guid("902ccb43-f5d4-4de3-85e9-9939099a032a"), null, "Нет" },
                    { new Guid("fa02d596-2cb7-420d-86d6-772fa73c71a5"), new Guid("4f1c9e92-3b66-4bb3-b671-4a870e931ea4"), null, "Международный" },
                    { new Guid("fce0d72b-cd33-4261-a17b-a14eab59a9ed"), new Guid("2275154a-236e-4b6c-9289-72ec88debe17"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("fd299de6-7b76-4a39-8345-89ad67919f35"), new Guid("781f1c17-82b3-4914-a14c-455faa693cc0"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("fd8e6b92-3a51-4d38-83c5-d0931e78ab2c"), new Guid("2275154a-236e-4b6c-9289-72ec88debe17"), null, "МБД (Q3-Q4)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationFormExperts_ApplicationFormId",
                table: "ApplicationFormExperts",
                column: "ApplicationFormId");

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
