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
                    { new Guid("0882b3ea-6829-4173-a02b-a773b9ed32ed"), 1, "В ожидании заполнения" },
                    { new Guid("2a9aff88-2aa8-472a-9cf3-745473a708fa"), 2, "В ожидании рассмотрения" },
                    { new Guid("2da8531b-1bfb-435f-90b9-669a788cebd8"), 6, "Оценена" },
                    { new Guid("33d307b3-75d2-4874-95e4-4daf69ea5264"), 4, "Одобрена" },
                    { new Guid("a449eaab-d1a0-4c65-a16f-eb802ea4ac36"), 3, "В процессе рассмотрения" },
                    { new Guid("bb6506bc-e37f-4ded-95b8-4bbf1cdf8840"), 5, "Отклонена" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16232178-31fa-4dfc-812e-00ab82c7c002", null, "Expert", "EXPERT" },
                    { "2342e401-c091-443d-84df-e6a9c0d8055e", null, "Organiser", "ORGANISER" },
                    { "767616eb-e0be-4dc6-983f-5e3eec96d643", null, "Admin", "ADMIN" },
                    { "b57cc041-ce07-4659-ba2e-d418bbf66997", null, "Voter", "VOTER" },
                    { "fcb35258-c969-4dcd-9678-292e28c056f7", null, "Participant", "PARTICIPANT" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("732ec941-5d82-4a0a-b0fc-14c305d67ba5"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("ea0a9a58-74c6-4af2-b181-d96cb62922db"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("27147463-9aa0-4d88-8166-9846b170d606"), "Категория участников", 2 },
                    { new Guid("812ee785-2a26-4d6d-a9f4-3c22ec7c0a87"), "Общая информация", 1 },
                    { new Guid("863ea028-98f9-4a3a-aa86-7ce66f4e1de8"), "Деятельность", 5 },
                    { new Guid("8a8148a4-1cc4-4300-85ab-7a491cbc0ac8"), "Профессиональное развитие", 3 },
                    { new Guid("e29ced10-2857-4158-add1-a4b5b55382f1"), "Деятельность", 4 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("054f4e41-e63d-4adc-a2b6-adbc097e68d0"), "Методическая деятельность", 3 },
                    { new Guid("37fdc656-142e-456e-aac9-a33969432caf"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("51376444-9107-4688-81cb-e66a5fc0f400"), "Основной", 1 },
                    { new Guid("53d36a87-2083-4385-b57b-cb2ef2979d7e"), "Конкурсная работа", 7 },
                    { new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6"), "Образовательная деятельность", 2 },
                    { new Guid("835b956b-8139-42f7-900b-30c864323f4b"), "Профессиональные показатели", 4 },
                    { new Guid("c91dd742-f56a-4b9d-bf35-96ef66825392"), "Инновационная и иная деятельность", 6 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("8e2b2f35-e232-4767-a885-53f74129c2d4"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("9d8b53c2-6d1d-4c68-8d53-c9194e56e1d1"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5669d9cf-0bf9-4078-82ec-a74c2c6bad16"), "DateTime" },
                    { new Guid("65eecbf2-6bf0-4d64-9b11-26c0bb39728e"), "TextArea" },
                    { new Guid("772350f7-9382-44be-882d-91f217041310"), "int" },
                    { new Guid("960865fd-c214-4bf8-9509-799da5a74295"), "bool" },
                    { new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7"), "string" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("27147463-9aa0-4d88-8166-9846b170d606"), new Guid("8e2b2f35-e232-4767-a885-53f74129c2d4") },
                    { new Guid("27147463-9aa0-4d88-8166-9846b170d606"), new Guid("9d8b53c2-6d1d-4c68-8d53-c9194e56e1d1") },
                    { new Guid("812ee785-2a26-4d6d-a9f4-3c22ec7c0a87"), new Guid("8e2b2f35-e232-4767-a885-53f74129c2d4") },
                    { new Guid("812ee785-2a26-4d6d-a9f4-3c22ec7c0a87"), new Guid("9d8b53c2-6d1d-4c68-8d53-c9194e56e1d1") },
                    { new Guid("863ea028-98f9-4a3a-aa86-7ce66f4e1de8"), new Guid("9d8b53c2-6d1d-4c68-8d53-c9194e56e1d1") },
                    { new Guid("8a8148a4-1cc4-4300-85ab-7a491cbc0ac8"), new Guid("8e2b2f35-e232-4767-a885-53f74129c2d4") },
                    { new Guid("8a8148a4-1cc4-4300-85ab-7a491cbc0ac8"), new Guid("9d8b53c2-6d1d-4c68-8d53-c9194e56e1d1") },
                    { new Guid("e29ced10-2857-4158-add1-a4b5b55382f1"), new Guid("8e2b2f35-e232-4767-a885-53f74129c2d4") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0bffacbf-65ea-47cc-894c-1e249115fc24"), new Guid("812ee785-2a26-4d6d-a9f4-3c22ec7c0a87"), null, true, true, "Место работы/учебы", 6, "Название организации", new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("18ae4c9f-36ad-4b3a-ac7e-bb98aff5a395"), new Guid("e29ced10-2857-4158-add1-a4b5b55382f1"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 17, "Введите количество", new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("1d722891-12da-42be-9fb3-68e116345030"), new Guid("863ea028-98f9-4a3a-aa86-7ce66f4e1de8"), null, false, true, "Защитившиеся доктора наук", 21, "Введите количество", new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("1e3c8506-66bc-45e0-b6ac-e912b545d977"), new Guid("812ee785-2a26-4d6d-a9f4-3c22ec7c0a87"), null, false, true, "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("22801f72-9a87-4419-9409-39880e9599ca"), new Guid("812ee785-2a26-4d6d-a9f4-3c22ec7c0a87"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("5864f8c3-7ba5-4c48-8f9a-b5b86d4fcbaa"), new Guid("812ee785-2a26-4d6d-a9f4-3c22ec7c0a87"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("5669d9cf-0bf9-4078-82ec-a74c2c6bad16") },
                    { new Guid("5a10fb52-3c96-43dd-88dd-bdcdc23b9ff5"), new Guid("27147463-9aa0-4d88-8166-9846b170d606"), null, false, true, "Научная специальность (по классификации ВАК)", 16, "Введите научную специальность (по классификации ВАК)", new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("63e76f1d-3b8c-4f72-b1d8-8e52b2e60502"), new Guid("812ee785-2a26-4d6d-a9f4-3c22ec7c0a87"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("836bd280-f79d-4660-881a-b9e4e360ecf8"), new Guid("863ea028-98f9-4a3a-aa86-7ce66f4e1de8"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 20, "Введите количество", new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("898a2db3-681c-4193-9a3e-3365f8d407f6"), new Guid("812ee785-2a26-4d6d-a9f4-3c22ec7c0a87"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("8f4abd5f-9e34-4341-b0f0-f4bd35750049"), new Guid("812ee785-2a26-4d6d-a9f4-3c22ec7c0a87"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("99144512-d4aa-4f51-ac5f-e482eede6896"), new Guid("27147463-9aa0-4d88-8166-9846b170d606"), null, true, true, "Ученое звание", 14, "Выберите ученое звание", new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("9d57e084-a977-4568-a2ed-fc87a40d7e2d"), new Guid("812ee785-2a26-4d6d-a9f4-3c22ec7c0a87"), null, true, true, "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("bb28831b-8ce8-4533-8864-88ab1caa8d37"), new Guid("e29ced10-2857-4158-add1-a4b5b55382f1"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 19, "Введите количество", new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("befbfef1-efdc-45a5-81a5-71d44b039c05"), new Guid("27147463-9aa0-4d88-8166-9846b170d606"), null, true, true, "Ученая степень", 15, "Выберите ученую степень", new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("c4461c38-c066-4f87-8f94-2adccf0f7a89"), new Guid("27147463-9aa0-4d88-8166-9846b170d606"), null, false, true, "Категория участника конкурса (Работники высших учебных заведений, отраслевых и академических институтов, работники сектора промышленности (исследователи), осуществляющие научно-исследовательскую и/или научно-педагогическую деятельность)", 11, "Выберите категорию участника конкруса", new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("e6ac8fc4-f5e0-4798-90ea-9925ccb1fc80"), new Guid("812ee785-2a26-4d6d-a9f4-3c22ec7c0a87"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("eea0b5e0-eb9f-43be-bd46-8d5d3acb28c8"), new Guid("812ee785-2a26-4d6d-a9f4-3c22ec7c0a87"), null, false, true, "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("f2679ff9-2d1e-4df1-af6a-54ab9ca0fedd"), new Guid("e29ced10-2857-4158-add1-a4b5b55382f1"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("772350f7-9382-44be-882d-91f217041310") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("054f4e41-e63d-4adc-a2b6-adbc097e68d0"), new Guid("8e2b2f35-e232-4767-a885-53f74129c2d4") },
                    { new Guid("37fdc656-142e-456e-aac9-a33969432caf"), new Guid("9d8b53c2-6d1d-4c68-8d53-c9194e56e1d1") },
                    { new Guid("51376444-9107-4688-81cb-e66a5fc0f400"), new Guid("8e2b2f35-e232-4767-a885-53f74129c2d4") },
                    { new Guid("51376444-9107-4688-81cb-e66a5fc0f400"), new Guid("9d8b53c2-6d1d-4c68-8d53-c9194e56e1d1") },
                    { new Guid("53d36a87-2083-4385-b57b-cb2ef2979d7e"), new Guid("8e2b2f35-e232-4767-a885-53f74129c2d4") },
                    { new Guid("53d36a87-2083-4385-b57b-cb2ef2979d7e"), new Guid("9d8b53c2-6d1d-4c68-8d53-c9194e56e1d1") },
                    { new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6"), new Guid("8e2b2f35-e232-4767-a885-53f74129c2d4") },
                    { new Guid("835b956b-8139-42f7-900b-30c864323f4b"), new Guid("8e2b2f35-e232-4767-a885-53f74129c2d4") },
                    { new Guid("c91dd742-f56a-4b9d-bf35-96ef66825392"), new Guid("9d8b53c2-6d1d-4c68-8d53-c9194e56e1d1") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("1da6169e-e333-4922-9a82-43cb090c09a9"), new Guid("e29ced10-2857-4158-add1-a4b5b55382f1"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("260c8053-2efc-436e-8ff2-35361200e680"), new Guid("863ea028-98f9-4a3a-aa86-7ce66f4e1de8"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("272d058b-cd07-43de-ab3b-19c61871d2dd"), new Guid("8a8148a4-1cc4-4300-85ab-7a491cbc0ac8"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("2ecd855f-721a-415a-8e43-8ce14d4e3260"), new Guid("27147463-9aa0-4d88-8166-9846b170d606"), true, true, "Краткая аннотация конкурсной работы", 14 },
                    { new Guid("49e5f6ee-9d94-46ad-9ca4-de5e261fe0d9"), new Guid("863ea028-98f9-4a3a-aa86-7ce66f4e1de8"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("79909edd-4f9c-4f39-b1cc-09d926e3f099"), new Guid("e29ced10-2857-4158-add1-a4b5b55382f1"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("81aca40a-a9a8-4fce-8615-0aae428b73c4"), new Guid("863ea028-98f9-4a3a-aa86-7ce66f4e1de8"), false, false, "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("9adb1333-6989-45b3-99c9-83d5db0271e9"), new Guid("e29ced10-2857-4158-add1-a4b5b55382f1"), false, false, "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("a681e742-3991-4ae0-af1b-e4e8a1c88905"), new Guid("e29ced10-2857-4158-add1-a4b5b55382f1"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("a8d9263f-3cb5-4052-9165-b8bb59c32e16"), new Guid("863ea028-98f9-4a3a-aa86-7ce66f4e1de8"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("c4b39222-170e-4d9f-8f50-e22894e20744"), new Guid("e29ced10-2857-4158-add1-a4b5b55382f1"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("db2fa52c-818c-473d-bba0-d7c1c90d9fcc"), new Guid("8a8148a4-1cc4-4300-85ab-7a491cbc0ac8"), true, true, "Персональные идентификаторы", 10 },
                    { new Guid("e1b52dc7-2233-43d7-97f3-7a514a9d2488"), new Guid("e29ced10-2857-4158-add1-a4b5b55382f1"), false, false, "Список трудов участника конкурса. Количество монографий, учебников, учебных и учебно-методических пособий с грифами УМО, Министерств РФ или государственных академий наук, изданных типографскимспособом за весь период научно-педагогической деятельности, либо аналогичных работ на иностранномязыке без грифа УМО", 6 },
                    { new Guid("f6204212-69c2-41dd-b558-09241903005c"), new Guid("8a8148a4-1cc4-4300-85ab-7a491cbc0ac8"), false, false, "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("05a8574a-7928-419f-a941-25cf4ca0e9c5"), true, "Язык преподавания (русск./англ./др.)", 2, new Guid("79909edd-4f9c-4f39-b1cc-09d926e3f099"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("05e05962-10a2-44a3-b736-14d71c2bc37b"), true, "Период выполнения", 3, new Guid("a8d9263f-3cb5-4052-9165-b8bb59c32e16"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("0bb55824-edbe-4b39-97f6-414183fcf347"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("81aca40a-a9a8-4fce-8615-0aae428b73c4"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("1201c93c-c98b-49b4-85b1-39fe35f1c4c3"), true, "Название документа, реквизиты", 1, new Guid("272d058b-cd07-43de-ab3b-19c61871d2dd"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("2b1ea5bc-4e96-4487-9937-44dbc448cd81"), true, "Год", 1, new Guid("f6204212-69c2-41dd-b558-09241903005c"), new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("2e4f65b0-b7a6-4d50-b282-3dddb8c6d655"), true, "Название", 1, new Guid("2ecd855f-721a-415a-8e43-8ce14d4e3260"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("33a83c15-a624-472d-9211-cc755e7d8141"), true, "Год", 4, new Guid("a681e742-3991-4ae0-af1b-e4e8a1c88905"), new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("35363b49-f8c3-4b14-b02f-29e1c6cf14aa"), false, "Идентификатор", 2, new Guid("db2fa52c-818c-473d-bba0-d7c1c90d9fcc"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("393bb400-a0cd-4e13-8d3e-9d5eb014ff8a"), true, "Практические занятия (час.)", 4, new Guid("79909edd-4f9c-4f39-b1cc-09d926e3f099"), new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("3a2d0007-b623-49f4-becf-2bafa9dd908e"), true, "Количество печатных листов", 4, new Guid("e1b52dc7-2233-43d7-97f3-7a514a9d2488"), new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("45a83618-a23f-4c98-aa85-9d3ae094174f"), true, "Издательство, год", 6, new Guid("e1b52dc7-2233-43d7-97f3-7a514a9d2488"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("483f39aa-4ca6-44f3-a27a-8a083176d776"), true, "Статус конкурса", 3, new Guid("f6204212-69c2-41dd-b558-09241903005c"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("536a10a7-a110-4d84-b48e-74301d72e959"), true, "Название", 2, new Guid("e1b52dc7-2233-43d7-97f3-7a514a9d2488"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("54b42d1d-e7b7-4501-b43b-f55fe5cc3c63"), true, "Название", 2, new Guid("260c8053-2efc-436e-8ff2-35361200e680"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("5d365cf8-710f-42a6-8be4-172a2288aab9"), true, "ФИО соавторов", 3, new Guid("260c8053-2efc-436e-8ff2-35361200e680"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("60f841bb-4ee1-40fb-949f-36cae61c4b97"), true, "Значение", 2, new Guid("2ecd855f-721a-415a-8e43-8ce14d4e3260"), new Guid("65eecbf2-6bf0-4d64-9b11-26c0bb39728e") },
                    { new Guid("625e8961-c708-4ac7-83e5-9bc880d8dd3d"), true, "Название конкурса/премии", 2, new Guid("1da6169e-e333-4922-9a82-43cb090c09a9"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("6aaf38ab-e08b-4f3a-ba8a-ec09a8ad2396"), true, "Название организации/должность/ставка", 1, new Guid("9adb1333-6989-45b3-99c9-83d5db0271e9"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("6c49491e-186e-4774-a7a9-74c4d174c0c7"), true, "Ссылка", 5, new Guid("f6204212-69c2-41dd-b558-09241903005c"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("73303f54-cb92-4225-af6f-db1510d7e7f5"), true, "Язык публикации", 7, new Guid("e1b52dc7-2233-43d7-97f3-7a514a9d2488"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("78af95d0-9f9c-41d3-b8c9-429831d25659"), true, "Статус (руководитель/исполнитель)", 4, new Guid("a8d9263f-3cb5-4052-9165-b8bb59c32e16"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("78aff2c6-3f75-4eed-8d8f-88dc42abf31e"), true, "Соавторы", 2, new Guid("a681e742-3991-4ae0-af1b-e4e8a1c88905"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("792fd9dd-3b87-410d-acd7-b119c19b1513"), true, "Вид публикации", 1, new Guid("e1b52dc7-2233-43d7-97f3-7a514a9d2488"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("7f635d66-290e-4d7b-bed7-dd2aa79dec5c"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("1da6169e-e333-4922-9a82-43cb090c09a9"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("8297da08-c73f-4c07-bb4e-2a4470842a56"), true, "Вид деятельности (преподавательская)", 3, new Guid("9adb1333-6989-45b3-99c9-83d5db0271e9"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("89bc7aac-c1b2-4099-8077-bc7035a19528"), true, "Итого (час.)", 5, new Guid("79909edd-4f9c-4f39-b1cc-09d926e3f099"), new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("8ca6dcb2-c3e2-424f-87ef-9d500d23acc5"), true, "Количество часов", 4, new Guid("9adb1333-6989-45b3-99c9-83d5db0271e9"), new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("915d2262-0e2a-4aec-961e-b2ad7602099a"), true, "Название дисциплины", 1, new Guid("c4b39222-170e-4d9f-8f50-e22894e20744"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("9563560f-e4f3-49a5-97aa-988b1474deb2"), true, "Вид (лекции, лабораторные)", 2, new Guid("c4b39222-170e-4d9f-8f50-e22894e20744"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("96aad0f5-de13-4b1b-a16d-43c005e382e8"), true, "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("9adb1333-6989-45b3-99c9-83d5db0271e9"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("9c4641e4-f727-4c4e-8b66-5e674465329d"), true, "Наличие грифа", 5, new Guid("e1b52dc7-2233-43d7-97f3-7a514a9d2488"), new Guid("960865fd-c214-4bf8-9509-799da5a74295") },
                    { new Guid("a6c3e477-5688-4321-ad56-b7273e14d876"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("a8d9263f-3cb5-4052-9165-b8bb59c32e16"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("a8c9d0d4-ba4a-4948-9f60-553e16a43a88"), true, "Название организации в которую внедрена разработка", 3, new Guid("49e5f6ee-9d94-46ad-9ca4-de5e261fe0d9"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("abe2435f-49a8-4d7d-b513-51895adffb57"), true, "Год", 3, new Guid("1da6169e-e333-4922-9a82-43cb090c09a9"), new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("adf1a731-b853-4346-9765-88d8502f4c2b"), true, "Название статьи", 1, new Guid("81aca40a-a9a8-4fce-8615-0aae428b73c4"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("b124ee57-d33d-4837-b88d-ccbedbd3938f"), true, "Ссылка на открытый доступ", 8, new Guid("e1b52dc7-2233-43d7-97f3-7a514a9d2488"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("b2815ecd-c1b0-448b-ad9b-3d6cb5bf1e5c"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("c4b39222-170e-4d9f-8f50-e22894e20744"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("bd9f18ff-3f8c-491f-ba88-c5f7f50d1783"), true, "Название НИР/НИОКР", 1, new Guid("a8d9263f-3cb5-4052-9165-b8bb59c32e16"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("bf5bcd7f-144b-4c03-9d56-66f9c183ada0"), true, "Название курса", 1, new Guid("a681e742-3991-4ae0-af1b-e4e8a1c88905"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("c113883d-7e2c-4332-9979-3d56c964c87e"), false, "Соавторы", 3, new Guid("e1b52dc7-2233-43d7-97f3-7a514a9d2488"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("c39f02c0-9ef0-41ee-9fdb-40a6fd550fbd"), true, "Соавторы", 2, new Guid("81aca40a-a9a8-4fce-8615-0aae428b73c4"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("c531f44e-65ac-41d0-b655-df2556cec160"), false, "Тип идентификатора", 1, new Guid("db2fa52c-818c-473d-bba0-d7c1c90d9fcc"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("c6cfecc6-f25a-4f80-8dd1-a708af12f04a"), true, "Вид", 1, new Guid("49e5f6ee-9d94-46ad-9ca4-de5e261fe0d9"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("d09e1bbe-4d96-410c-8069-03dec5eca315"), true, "Вид", 1, new Guid("260c8053-2efc-436e-8ff2-35361200e680"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("d12d2aa5-bc4e-4a81-9986-b8e20ab59667"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("1da6169e-e333-4922-9a82-43cb090c09a9"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("d4162eb4-b55d-461d-80e2-610a35743073"), true, "ФИО", 1, new Guid("1da6169e-e333-4922-9a82-43cb090c09a9"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("d5466446-b5fd-4e9d-834a-00355dfd49c5"), true, "Название разработки", 2, new Guid("49e5f6ee-9d94-46ad-9ca4-de5e261fe0d9"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("d9f73c16-b268-485d-81e7-df5b95380bd8"), true, "Номер РИД", 4, new Guid("260c8053-2efc-436e-8ff2-35361200e680"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("daf4a031-9f7c-4e43-9564-b6cabc2f7dbd"), true, "Ссылка на платформу", 3, new Guid("a681e742-3991-4ae0-af1b-e4e8a1c88905"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("e19ca419-2d91-466c-9d67-8b8bfca56417"), true, "Год получения документа", 2, new Guid("272d058b-cd07-43de-ab3b-19c61871d2dd"), new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("e1d86a41-a82f-4557-9eed-d37d56072c4c"), true, "Лекции (час.)", 3, new Guid("79909edd-4f9c-4f39-b1cc-09d926e3f099"), new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("e7442d83-9c9f-4f00-b9f5-47dee0036f02"), true, "Издание, год", 4, new Guid("81aca40a-a9a8-4fce-8615-0aae428b73c4"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("f341ec5b-06f4-4c7d-aec8-1f0a5c74d73b"), true, "Наименование курса", 1, new Guid("79909edd-4f9c-4f39-b1cc-09d926e3f099"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("f4b651eb-cf2a-4c67-bd70-9d35893b1d0a"), true, "Награда", 4, new Guid("f6204212-69c2-41dd-b558-09241903005c"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") },
                    { new Guid("f5955f16-7335-4ab1-ba59-a2963907d6a4"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("a8d9263f-3cb5-4052-9165-b8bb59c32e16"), new Guid("772350f7-9382-44be-882d-91f217041310") },
                    { new Guid("f6f1067f-f8b3-4102-8e73-66d02104d4dd"), true, "Название конкурса", 2, new Guid("f6204212-69c2-41dd-b558-09241903005c"), new Guid("9840c2ea-9c6f-49ce-a99d-03b1bb27e5d7") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("0bffacbf-65ea-47cc-894c-1e249115fc24"), new Guid("51376444-9107-4688-81cb-e66a5fc0f400") },
                    { new Guid("18ae4c9f-36ad-4b3a-ac7e-bb98aff5a395"), new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6") },
                    { new Guid("1d722891-12da-42be-9fb3-68e116345030"), new Guid("37fdc656-142e-456e-aac9-a33969432caf") },
                    { new Guid("1e3c8506-66bc-45e0-b6ac-e912b545d977"), new Guid("51376444-9107-4688-81cb-e66a5fc0f400") },
                    { new Guid("22801f72-9a87-4419-9409-39880e9599ca"), new Guid("51376444-9107-4688-81cb-e66a5fc0f400") },
                    { new Guid("5864f8c3-7ba5-4c48-8f9a-b5b86d4fcbaa"), new Guid("51376444-9107-4688-81cb-e66a5fc0f400") },
                    { new Guid("5a10fb52-3c96-43dd-88dd-bdcdc23b9ff5"), new Guid("51376444-9107-4688-81cb-e66a5fc0f400") },
                    { new Guid("63e76f1d-3b8c-4f72-b1d8-8e52b2e60502"), new Guid("51376444-9107-4688-81cb-e66a5fc0f400") },
                    { new Guid("836bd280-f79d-4660-881a-b9e4e360ecf8"), new Guid("37fdc656-142e-456e-aac9-a33969432caf") },
                    { new Guid("898a2db3-681c-4193-9a3e-3365f8d407f6"), new Guid("51376444-9107-4688-81cb-e66a5fc0f400") },
                    { new Guid("8f4abd5f-9e34-4341-b0f0-f4bd35750049"), new Guid("51376444-9107-4688-81cb-e66a5fc0f400") },
                    { new Guid("99144512-d4aa-4f51-ac5f-e482eede6896"), new Guid("37fdc656-142e-456e-aac9-a33969432caf") },
                    { new Guid("99144512-d4aa-4f51-ac5f-e482eede6896"), new Guid("51376444-9107-4688-81cb-e66a5fc0f400") },
                    { new Guid("99144512-d4aa-4f51-ac5f-e482eede6896"), new Guid("835b956b-8139-42f7-900b-30c864323f4b") },
                    { new Guid("9d57e084-a977-4568-a2ed-fc87a40d7e2d"), new Guid("51376444-9107-4688-81cb-e66a5fc0f400") },
                    { new Guid("bb28831b-8ce8-4533-8864-88ab1caa8d37"), new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6") },
                    { new Guid("befbfef1-efdc-45a5-81a5-71d44b039c05"), new Guid("51376444-9107-4688-81cb-e66a5fc0f400") },
                    { new Guid("c4461c38-c066-4f87-8f94-2adccf0f7a89"), new Guid("51376444-9107-4688-81cb-e66a5fc0f400") },
                    { new Guid("e6ac8fc4-f5e0-4798-90ea-9925ccb1fc80"), new Guid("51376444-9107-4688-81cb-e66a5fc0f400") },
                    { new Guid("eea0b5e0-eb9f-43be-bd46-8d5d3acb28c8"), new Guid("51376444-9107-4688-81cb-e66a5fc0f400") },
                    { new Guid("f2679ff9-2d1e-4df1-af6a-54ab9ca0fedd"), new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("054f4e41-e63d-4adc-a2b6-adbc097e68d0"), new Guid("c4b39222-170e-4d9f-8f50-e22894e20744") },
                    { new Guid("054f4e41-e63d-4adc-a2b6-adbc097e68d0"), new Guid("e1b52dc7-2233-43d7-97f3-7a514a9d2488") },
                    { new Guid("37fdc656-142e-456e-aac9-a33969432caf"), new Guid("81aca40a-a9a8-4fce-8615-0aae428b73c4") },
                    { new Guid("37fdc656-142e-456e-aac9-a33969432caf"), new Guid("a8d9263f-3cb5-4052-9165-b8bb59c32e16") },
                    { new Guid("37fdc656-142e-456e-aac9-a33969432caf"), new Guid("db2fa52c-818c-473d-bba0-d7c1c90d9fcc") },
                    { new Guid("37fdc656-142e-456e-aac9-a33969432caf"), new Guid("f6204212-69c2-41dd-b558-09241903005c") },
                    { new Guid("53d36a87-2083-4385-b57b-cb2ef2979d7e"), new Guid("2ecd855f-721a-415a-8e43-8ce14d4e3260") },
                    { new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6"), new Guid("1da6169e-e333-4922-9a82-43cb090c09a9") },
                    { new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6"), new Guid("79909edd-4f9c-4f39-b1cc-09d926e3f099") },
                    { new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6"), new Guid("9adb1333-6989-45b3-99c9-83d5db0271e9") },
                    { new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6"), new Guid("a681e742-3991-4ae0-af1b-e4e8a1c88905") },
                    { new Guid("835b956b-8139-42f7-900b-30c864323f4b"), new Guid("272d058b-cd07-43de-ab3b-19c61871d2dd") },
                    { new Guid("835b956b-8139-42f7-900b-30c864323f4b"), new Guid("f6204212-69c2-41dd-b558-09241903005c") },
                    { new Guid("c91dd742-f56a-4b9d-bf35-96ef66825392"), new Guid("260c8053-2efc-436e-8ff2-35361200e680") },
                    { new Guid("c91dd742-f56a-4b9d-bf35-96ef66825392"), new Guid("272d058b-cd07-43de-ab3b-19c61871d2dd") },
                    { new Guid("c91dd742-f56a-4b9d-bf35-96ef66825392"), new Guid("49e5f6ee-9d94-46ad-9ca4-de5e261fe0d9") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("07145293-58b0-4ab7-8abf-f1769e7f7153"), "EvaluateMark6", null, true, 4, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("1da6169e-e333-4922-9a82-43cb090c09a9") },
                    { new Guid("081b5017-bd6d-4c96-9c7f-19cb37408c6f"), "EvaluateMark21", null, true, 4, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("a8d9263f-3cb5-4052-9165-b8bb59c32e16") },
                    { new Guid("15e8ef9b-917a-40b0-a486-d9e431f27389"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("e1b52dc7-2233-43d7-97f3-7a514a9d2488") },
                    { new Guid("20dce4fb-6af6-44ff-9069-c33b9f8c2a62"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("e1b52dc7-2233-43d7-97f3-7a514a9d2488") },
                    { new Guid("31c3f9a9-fd1a-42d4-95ee-2fb79ccd925f"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("c4b39222-170e-4d9f-8f50-e22894e20744") },
                    { new Guid("3e1ad5f5-78d7-4103-9975-143ce8ce93c0"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("49e5f6ee-9d94-46ad-9ca4-de5e261fe0d9") },
                    { new Guid("41e5babc-c41d-4170-ab30-b8d1d066352a"), null, null, false, 10, "Оценка уровня предоставленной работы:", 25, new Guid("2ecd855f-721a-415a-8e43-8ce14d4e3260") },
                    { new Guid("47c02924-102c-4e38-a2dc-7eb98bc0f15c"), "EvaluateMark16", null, true, 5, "Баллы за научные публикации:", 16, new Guid("81aca40a-a9a8-4fce-8615-0aae428b73c4") },
                    { new Guid("49474902-6651-4144-8aa7-3aeb5ecd0c7f"), "EvaluateMark5", new Guid("f2679ff9-2d1e-4df1-af6a-54ab9ca0fedd"), true, 4, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("4bc1f7eb-4b40-4078-ad99-c7e0eaf7e173"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("a681e742-3991-4ae0-af1b-e4e8a1c88905") },
                    { new Guid("5b7b5ecf-1433-4268-826c-2ed019014fb0"), "EvaluateMark19", new Guid("836bd280-f79d-4660-881a-b9e4e360ecf8"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("6a3368eb-b14c-4ffb-bd07-637d5f66807d"), "EvaluateMark8", null, true, 5, "Баллы за труды с грифом и без соавторства:", 8, new Guid("e1b52dc7-2233-43d7-97f3-7a514a9d2488") },
                    { new Guid("7270f593-b8e0-4a1c-a4c5-8f905cb01330"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("f6204212-69c2-41dd-b558-09241903005c") },
                    { new Guid("7470216a-1fd8-4d60-abd3-4b5b536431df"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("272d058b-cd07-43de-ab3b-19c61871d2dd") },
                    { new Guid("81740971-23c2-482e-b9d7-195fd706c3f5"), "EvaluateMark3", new Guid("bb28831b-8ce8-4533-8864-88ab1caa8d37"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("8cda7aa4-7782-4268-b18b-2ae776a6f25e"), "EvaluateMark20", new Guid("1d722891-12da-42be-9fb3-68e116345030"), true, 4, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("8f24493b-0796-4be2-b777-ee4f1d9faeda"), null, null, false, 10, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("2ecd855f-721a-415a-8e43-8ce14d4e3260") },
                    { new Guid("b3a0f16e-5028-4bb4-b6f3-386780973e19"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("e1b52dc7-2233-43d7-97f3-7a514a9d2488") },
                    { new Guid("bd52f4cf-770a-4c91-bf60-ce5740bd326b"), "EvaluateMark22", null, true, 2, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("a8d9263f-3cb5-4052-9165-b8bb59c32e16") },
                    { new Guid("df94ea15-4c38-45a6-b633-a2c413aa06f2"), "EvaluateMark13", new Guid("99144512-d4aa-4f51-ac5f-e482eede6896"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("f072ad3c-ad1f-4d92-8e14-08f915fbb3dc"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("79909edd-4f9c-4f39-b1cc-09d926e3f099") },
                    { new Guid("f7e8cc74-2d10-4848-8d6d-291b4c2aa5f8"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("79909edd-4f9c-4f39-b1cc-09d926e3f099") },
                    { new Guid("fa99fb83-0d00-48ad-8630-3c7ec6e554d9"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("260c8053-2efc-436e-8ff2-35361200e680") },
                    { new Guid("fd77ba1c-f054-4800-9bbc-07f93dc9806b"), "EvaluateMark4", new Guid("18ae4c9f-36ad-4b3a-ac7e-bb98aff5a395"), true, 2, "Баллы за количество защитившихся кандидатов наук:", 4, null }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("0dcbdfbe-6986-48bc-820d-438b510eb625"), true, new Guid("2ecd855f-721a-415a-8e43-8ce14d4e3260") },
                    { new Guid("0f28aa33-ef08-40f1-a61c-642e7d7f8f99"), true, new Guid("db2fa52c-818c-473d-bba0-d7c1c90d9fcc") },
                    { new Guid("4487f240-dcb8-4717-8c6b-adcc22ea7aa8"), true, new Guid("db2fa52c-818c-473d-bba0-d7c1c90d9fcc") },
                    { new Guid("45409cb5-49dc-4664-8694-38d3c8925623"), true, new Guid("2ecd855f-721a-415a-8e43-8ce14d4e3260") },
                    { new Guid("67f206c5-997b-4d6b-8c0c-7cb64a2911e8"), true, new Guid("2ecd855f-721a-415a-8e43-8ce14d4e3260") },
                    { new Guid("90349177-ae64-4268-a651-4496ecf307dc"), true, new Guid("2ecd855f-721a-415a-8e43-8ce14d4e3260") },
                    { new Guid("9c30c47d-1a42-4820-9fa1-7daea5ef5845"), true, new Guid("2ecd855f-721a-415a-8e43-8ce14d4e3260") },
                    { new Guid("bb654504-d95c-464c-aa18-612162030041"), true, new Guid("2ecd855f-721a-415a-8e43-8ce14d4e3260") },
                    { new Guid("bf61107c-cc6d-4e00-829d-4f1588bd3ec9"), true, new Guid("2ecd855f-721a-415a-8e43-8ce14d4e3260") },
                    { new Guid("cf00cc57-d26b-4518-b4b2-c50a65d47983"), true, new Guid("db2fa52c-818c-473d-bba0-d7c1c90d9fcc") },
                    { new Guid("d738b5c9-6c05-414f-9b04-4b2b8e55f1e5"), true, new Guid("db2fa52c-818c-473d-bba0-d7c1c90d9fcc") },
                    { new Guid("db1d97aa-ff85-484d-aeb1-a6cc70e9df66"), true, new Guid("2ecd855f-721a-415a-8e43-8ce14d4e3260") },
                    { new Guid("f9ca7b43-df9b-4941-9adf-be68e0fba4ce"), true, new Guid("db2fa52c-818c-473d-bba0-d7c1c90d9fcc") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0c74fcff-c546-4ad9-91ac-86a9fb83186d"), null, new Guid("99144512-d4aa-4f51-ac5f-e482eede6896"), "Доцент" },
                    { new Guid("31e9f699-f2d4-4a80-956c-b723c1a8c90f"), null, new Guid("c4461c38-c066-4f87-8f94-2adccf0f7a89"), "Имеющие ученую степень доктора наук" },
                    { new Guid("9b53c94c-e173-4abf-8f2d-5be6f567ba81"), null, new Guid("c4461c38-c066-4f87-8f94-2adccf0f7a89"), "Докторанты, имеющие ученую степень кандидата наук" },
                    { new Guid("a7302f55-bc56-4e81-be2c-e1e2151445d6"), null, new Guid("99144512-d4aa-4f51-ac5f-e482eede6896"), "Профессор" },
                    { new Guid("be472dbd-ece9-4ef2-81a2-1896b6b6895a"), null, new Guid("99144512-d4aa-4f51-ac5f-e482eede6896"), "Нет" },
                    { new Guid("e017c871-5a0d-40e5-b739-213359da5513"), null, new Guid("befbfef1-efdc-45a5-81a5-71d44b039c05"), "Доктор наук" },
                    { new Guid("ed561361-4d7e-4600-a6b1-40ed7deac219"), null, new Guid("befbfef1-efdc-45a5-81a5-71d44b039c05"), "Кандидат наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("0a5b6c69-0b8f-4155-a381-4863d0cea299"), null, new Guid("35363b49-f8c3-4b14-b02f-29e1c6cf14aa"), false, true, new Guid("0f28aa33-ef08-40f1-a61c-642e7d7f8f99"), null },
                    { new Guid("2637600d-6dc4-4722-91bc-b64480167b55"), null, new Guid("35363b49-f8c3-4b14-b02f-29e1c6cf14aa"), false, true, new Guid("4487f240-dcb8-4717-8c6b-adcc22ea7aa8"), null },
                    { new Guid("2993685b-bce3-448c-b1b9-2b8b9248231a"), null, new Guid("2e4f65b0-b7a6-4d50-b282-3dddb8c6d655"), true, true, new Guid("bf61107c-cc6d-4e00-829d-4f1588bd3ec9"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("31e89ba4-6e15-420a-a485-2a3bd16cdeac"), null, new Guid("2e4f65b0-b7a6-4d50-b282-3dddb8c6d655"), true, true, new Guid("db1d97aa-ff85-484d-aeb1-a6cc70e9df66"), "Ссылка на конкурсную работу" },
                    { new Guid("3d846116-f042-4df7-9e67-58cbfa57f590"), null, new Guid("60f841bb-4ee1-40fb-949f-36cae61c4b97"), false, true, new Guid("90349177-ae64-4268-a651-4496ecf307dc"), null },
                    { new Guid("3eea3937-1440-4e87-af8a-f8007e8b5e79"), null, new Guid("2e4f65b0-b7a6-4d50-b282-3dddb8c6d655"), true, true, new Guid("0dcbdfbe-6986-48bc-820d-438b510eb625"), "Методология и методы, используемые в работе" },
                    { new Guid("64378e9e-6ad8-417d-b300-c228b1d92da5"), null, new Guid("60f841bb-4ee1-40fb-949f-36cae61c4b97"), false, true, new Guid("45409cb5-49dc-4664-8694-38d3c8925623"), null },
                    { new Guid("6aefdba8-2597-4b55-b324-958fb54a417b"), null, new Guid("35363b49-f8c3-4b14-b02f-29e1c6cf14aa"), false, true, new Guid("f9ca7b43-df9b-4941-9adf-be68e0fba4ce"), null },
                    { new Guid("781b260e-12b4-43e4-ad37-5e9c3c0dacf2"), null, new Guid("2e4f65b0-b7a6-4d50-b282-3dddb8c6d655"), true, true, new Guid("90349177-ae64-4268-a651-4496ecf307dc"), "Название работы" },
                    { new Guid("79360276-d9e6-442b-adea-c1b268810be3"), null, new Guid("2e4f65b0-b7a6-4d50-b282-3dddb8c6d655"), true, true, new Guid("9c30c47d-1a42-4820-9fa1-7daea5ef5845"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("7adb578d-65d4-436f-806a-2126e8c4c973"), null, new Guid("60f841bb-4ee1-40fb-949f-36cae61c4b97"), false, true, new Guid("bb654504-d95c-464c-aa18-612162030041"), null },
                    { new Guid("7c585fb8-7547-438e-a914-a2fa71f36890"), null, new Guid("2e4f65b0-b7a6-4d50-b282-3dddb8c6d655"), true, true, new Guid("45409cb5-49dc-4664-8694-38d3c8925623"), "Актуальность конкурсной работы" },
                    { new Guid("7d7f69ab-48df-43b6-b2f6-b5454a339d92"), null, new Guid("2e4f65b0-b7a6-4d50-b282-3dddb8c6d655"), true, true, new Guid("67f206c5-997b-4d6b-8c0c-7cb64a2911e8"), "Инновационность" },
                    { new Guid("7e5a2576-4e60-465b-aa08-63667cf7bd79"), null, new Guid("35363b49-f8c3-4b14-b02f-29e1c6cf14aa"), false, true, new Guid("d738b5c9-6c05-414f-9b04-4b2b8e55f1e5"), null },
                    { new Guid("82768df0-4644-400a-8bd7-ae50a86e1af8"), null, new Guid("60f841bb-4ee1-40fb-949f-36cae61c4b97"), false, true, new Guid("9c30c47d-1a42-4820-9fa1-7daea5ef5845"), null },
                    { new Guid("8e8fd23a-5e2e-412b-9a64-c1e58995ecc5"), null, new Guid("60f841bb-4ee1-40fb-949f-36cae61c4b97"), false, true, new Guid("0dcbdfbe-6986-48bc-820d-438b510eb625"), null },
                    { new Guid("943b7983-f44c-43c6-946e-243057a4ba1b"), null, new Guid("35363b49-f8c3-4b14-b02f-29e1c6cf14aa"), false, true, new Guid("cf00cc57-d26b-4518-b4b2-c50a65d47983"), null },
                    { new Guid("9ef28a58-b2eb-4762-908c-c66496cd2f54"), null, new Guid("c531f44e-65ac-41d0-b655-df2556cec160"), true, true, new Guid("cf00cc57-d26b-4518-b4b2-c50a65d47983"), "ScopusID" },
                    { new Guid("a2212371-01f6-4347-a762-28cffb2ff68a"), null, new Guid("c531f44e-65ac-41d0-b655-df2556cec160"), true, true, new Guid("4487f240-dcb8-4717-8c6b-adcc22ea7aa8"), "РИНЦ AuthorID" },
                    { new Guid("a56276fd-9a33-445b-88f0-3c1be9bfdbf8"), null, new Guid("c531f44e-65ac-41d0-b655-df2556cec160"), true, true, new Guid("0f28aa33-ef08-40f1-a61c-642e7d7f8f99"), "Google Scholar ID" },
                    { new Guid("a8848684-a14c-440f-b268-4ee82c1eb9c3"), null, new Guid("c531f44e-65ac-41d0-b655-df2556cec160"), true, true, new Guid("f9ca7b43-df9b-4941-9adf-be68e0fba4ce"), "ORCiD" },
                    { new Guid("ac5b9c67-c117-4881-aa5d-43cf54f4b400"), null, new Guid("60f841bb-4ee1-40fb-949f-36cae61c4b97"), false, true, new Guid("bf61107c-cc6d-4e00-829d-4f1588bd3ec9"), null },
                    { new Guid("cbf30aff-9a85-4d84-adba-91e65c0b9661"), null, new Guid("60f841bb-4ee1-40fb-949f-36cae61c4b97"), false, true, new Guid("db1d97aa-ff85-484d-aeb1-a6cc70e9df66"), null },
                    { new Guid("cd562c6c-470d-4404-b827-d8a021a7b4bc"), null, new Guid("2e4f65b0-b7a6-4d50-b282-3dddb8c6d655"), true, true, new Guid("bb654504-d95c-464c-aa18-612162030041"), "Результаты и выводы" },
                    { new Guid("d7e7d4d6-63e6-4793-ba41-3d26d3cdaea1"), null, new Guid("60f841bb-4ee1-40fb-949f-36cae61c4b97"), false, true, new Guid("67f206c5-997b-4d6b-8c0c-7cb64a2911e8"), null },
                    { new Guid("eb5ac0aa-1d8f-43f6-aa6b-95c605f4d3ac"), null, new Guid("c531f44e-65ac-41d0-b655-df2556cec160"), true, true, new Guid("d738b5c9-6c05-414f-9b04-4b2b8e55f1e5"), "ResearcherID" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("054f4e41-e63d-4adc-a2b6-adbc097e68d0"), new Guid("15e8ef9b-917a-40b0-a486-d9e431f27389") },
                    { new Guid("054f4e41-e63d-4adc-a2b6-adbc097e68d0"), new Guid("20dce4fb-6af6-44ff-9069-c33b9f8c2a62") },
                    { new Guid("054f4e41-e63d-4adc-a2b6-adbc097e68d0"), new Guid("31c3f9a9-fd1a-42d4-95ee-2fb79ccd925f") },
                    { new Guid("054f4e41-e63d-4adc-a2b6-adbc097e68d0"), new Guid("6a3368eb-b14c-4ffb-bd07-637d5f66807d") },
                    { new Guid("054f4e41-e63d-4adc-a2b6-adbc097e68d0"), new Guid("b3a0f16e-5028-4bb4-b6f3-386780973e19") },
                    { new Guid("37fdc656-142e-456e-aac9-a33969432caf"), new Guid("081b5017-bd6d-4c96-9c7f-19cb37408c6f") },
                    { new Guid("37fdc656-142e-456e-aac9-a33969432caf"), new Guid("47c02924-102c-4e38-a2dc-7eb98bc0f15c") },
                    { new Guid("37fdc656-142e-456e-aac9-a33969432caf"), new Guid("5b7b5ecf-1433-4268-826c-2ed019014fb0") },
                    { new Guid("37fdc656-142e-456e-aac9-a33969432caf"), new Guid("7270f593-b8e0-4a1c-a4c5-8f905cb01330") },
                    { new Guid("37fdc656-142e-456e-aac9-a33969432caf"), new Guid("8cda7aa4-7782-4268-b18b-2ae776a6f25e") },
                    { new Guid("37fdc656-142e-456e-aac9-a33969432caf"), new Guid("bd52f4cf-770a-4c91-bf60-ce5740bd326b") },
                    { new Guid("37fdc656-142e-456e-aac9-a33969432caf"), new Guid("df94ea15-4c38-45a6-b633-a2c413aa06f2") },
                    { new Guid("53d36a87-2083-4385-b57b-cb2ef2979d7e"), new Guid("41e5babc-c41d-4170-ab30-b8d1d066352a") },
                    { new Guid("53d36a87-2083-4385-b57b-cb2ef2979d7e"), new Guid("8f24493b-0796-4be2-b777-ee4f1d9faeda") },
                    { new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6"), new Guid("07145293-58b0-4ab7-8abf-f1769e7f7153") },
                    { new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6"), new Guid("49474902-6651-4144-8aa7-3aeb5ecd0c7f") },
                    { new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6"), new Guid("4bc1f7eb-4b40-4078-ad99-c7e0eaf7e173") },
                    { new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6"), new Guid("81740971-23c2-482e-b9d7-195fd706c3f5") },
                    { new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6"), new Guid("f072ad3c-ad1f-4d92-8e14-08f915fbb3dc") },
                    { new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6"), new Guid("f7e8cc74-2d10-4848-8d6d-291b4c2aa5f8") },
                    { new Guid("70afde2e-3c16-400d-abf2-335c8331d8b6"), new Guid("fd77ba1c-f054-4800-9bbc-07f93dc9806b") },
                    { new Guid("835b956b-8139-42f7-900b-30c864323f4b"), new Guid("7270f593-b8e0-4a1c-a4c5-8f905cb01330") },
                    { new Guid("835b956b-8139-42f7-900b-30c864323f4b"), new Guid("7470216a-1fd8-4d60-abd3-4b5b536431df") },
                    { new Guid("835b956b-8139-42f7-900b-30c864323f4b"), new Guid("df94ea15-4c38-45a6-b633-a2c413aa06f2") },
                    { new Guid("c91dd742-f56a-4b9d-bf35-96ef66825392"), new Guid("3e1ad5f5-78d7-4103-9975-143ce8ce93c0") },
                    { new Guid("c91dd742-f56a-4b9d-bf35-96ef66825392"), new Guid("7470216a-1fd8-4d60-abd3-4b5b536431df") },
                    { new Guid("c91dd742-f56a-4b9d-bf35-96ef66825392"), new Guid("fa99fb83-0d00-48ad-8630-3c7ec6e554d9") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("2dbf719d-64f9-4bbd-aec7-be201eb8bd05"), new Guid("c39f02c0-9ef0-41ee-9fdb-40a6fd550fbd"), null, "Есть" },
                    { new Guid("3989408b-112f-49c6-b969-0c913c72e170"), new Guid("d09e1bbe-4d96-410c-8069-03dec5eca315"), null, "Полезная модель" },
                    { new Guid("43262c07-64f0-42d9-b4f2-86cedc1e2dc7"), new Guid("c6cfecc6-f25a-4f80-8dd1-a708af12f04a"), null, "Полезная модель" },
                    { new Guid("493bd1c7-3c0d-4dfd-9524-1cf8b98e7b45"), new Guid("78af95d0-9f9c-41d3-b8c9-429831d25659"), null, "Исполнитель" },
                    { new Guid("4a8aa0a2-2a5d-4dca-b53b-e2dc79508a40"), new Guid("483f39aa-4ca6-44f3-a27a-8a083176d776"), null, "Международный" },
                    { new Guid("59ae5bd6-cbac-402b-9e6b-9f815e2c80ca"), new Guid("c113883d-7e2c-4332-9979-3d56c964c87e"), null, "Нет" },
                    { new Guid("6aa413a8-71b4-45c5-bea6-059c2c0a237b"), new Guid("d09e1bbe-4d96-410c-8069-03dec5eca315"), null, "Изобретение" },
                    { new Guid("6fa33691-9aac-4a5b-9e27-b89dfc608801"), new Guid("9563560f-e4f3-49a5-97aa-988b1474deb2"), null, "Лекции" },
                    { new Guid("71bdc85a-ce35-425e-951a-c3f659c75f64"), new Guid("c39f02c0-9ef0-41ee-9fdb-40a6fd550fbd"), null, "Нет" },
                    { new Guid("77e6acf5-7555-425b-8ac8-bbc8a5885d89"), new Guid("792fd9dd-3b87-410d-acd7-b119c19b1513"), null, "Монография" },
                    { new Guid("85d6ebfc-b7fd-45e7-a424-cb6ed112da96"), new Guid("73303f54-cb92-4225-af6f-db1510d7e7f5"), null, "Русский" },
                    { new Guid("86022f80-9b77-4f8a-a892-37e13dc2db3e"), new Guid("9563560f-e4f3-49a5-97aa-988b1474deb2"), null, "Лабораторные" },
                    { new Guid("92ecc025-83ec-41b8-8dd2-1eaee59f0856"), new Guid("c113883d-7e2c-4332-9979-3d56c964c87e"), null, "Есть" },
                    { new Guid("9cd144d5-9d9b-4fd9-9819-29a8277a6002"), new Guid("792fd9dd-3b87-410d-acd7-b119c19b1513"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("a42baa43-437f-411c-957c-600f11b37f7a"), new Guid("78af95d0-9f9c-41d3-b8c9-429831d25659"), null, "Руководитель" },
                    { new Guid("aba509b5-f902-48b8-9048-89c1ee15dc39"), new Guid("d09e1bbe-4d96-410c-8069-03dec5eca315"), null, "База данных" },
                    { new Guid("b944c9d9-039c-465a-bbf6-b13cbc785e0f"), new Guid("483f39aa-4ca6-44f3-a27a-8a083176d776"), null, "Региональный" },
                    { new Guid("cc927f20-cb1c-4338-b7ef-d8ac56ce95a4"), new Guid("c6cfecc6-f25a-4f80-8dd1-a708af12f04a"), null, "База данных" },
                    { new Guid("deb0fdea-167d-4c2e-afa7-85ab5d1fd292"), new Guid("483f39aa-4ca6-44f3-a27a-8a083176d776"), null, "Всероссийский" },
                    { new Guid("e1b1cf57-4818-4da4-b10b-fb71eb84e1a8"), new Guid("73303f54-cb92-4225-af6f-db1510d7e7f5"), null, "Иностранный" },
                    { new Guid("f0f7b705-be9d-4e12-956c-d81b161fad24"), new Guid("c6cfecc6-f25a-4f80-8dd1-a708af12f04a"), null, "Изобретение" },
                    { new Guid("f3b77a71-1350-454e-b3c0-33a5c6cdd5f8"), new Guid("792fd9dd-3b87-410d-acd7-b119c19b1513"), null, "Учебник" }
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
