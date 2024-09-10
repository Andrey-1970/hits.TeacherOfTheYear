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
                    { new Guid("1d37e7e4-cdb5-4448-8156-10bbe389dbd5"), 4, "Одобрена" },
                    { new Guid("252c5eee-a7ce-4866-b66f-259b68de4f5f"), 2, "В ожидании рассмотрения" },
                    { new Guid("73152f00-3e5f-463d-adc3-ed23ad465a38"), 5, "Отклонена" },
                    { new Guid("a59ad311-b5d2-46ed-a7ce-f239cb6d0b0f"), 1, "В ожидании заполнения" },
                    { new Guid("b697193b-9d76-431f-88b9-160934d43aa0"), 6, "Оценена" },
                    { new Guid("f15225bc-1c39-4844-aeee-a5c3027b6ba5"), 3, "В процессе рассмотрения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a945df1-2508-43e0-b475-5107c6bbb7de", null, "Participant", "PARTICIPANT" },
                    { "627993c7-1407-4ea5-8a19-b992ad8da369", null, "Organiser", "ORGANISER" },
                    { "8b8206a1-6090-4536-966e-fdcec091c072", null, "Admin", "ADMIN" },
                    { "db441c18-f388-48d1-99ac-b797fd63180c", null, "Voter", "VOTER" },
                    { "fa5a773f-67dd-43bf-a8f5-01bcec1b18c9", null, "Expert", "EXPERT" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("142611c9-f515-4196-b239-f087d0f6e49b"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("461cb115-10f4-4fbf-ad4a-5e2aeeb6c552"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("442321a2-eb8e-4252-865b-e836b92b4281"), "Общая информация", 1 },
                    { new Guid("4904908b-bf3f-4ada-937f-7216c14e7aff"), "Научно-исследовательская деятельность", 6 },
                    { new Guid("5bfc8731-88ef-4367-87ee-e8df5bd99d1f"), "Научно-педагогическая деятельность", 5 },
                    { new Guid("6c660954-514f-4871-913f-c58e3b17de28"), "Категория участников", 2 },
                    { new Guid("826bc23e-2102-4236-9b71-51ee2c1b9103"), "Профессиональное развитие", 4 },
                    { new Guid("bc6f0a31-167c-43a7-8360-23f4b14a14ea"), "Конкурсная работа", 3 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("33fda319-7aa9-4e32-bfe2-3956e72c6df6"), "Методическая деятельность", 3 },
                    { new Guid("7203f2e6-1012-425b-8e5f-4aab263970a2"), "Профессиональные показатели", 4 },
                    { new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a"), "Образовательная деятельность", 2 },
                    { new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a"), "Основной", 1 },
                    { new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("cf8d82db-2591-408a-a14e-5bdf85835a31"), "Инновационная и иная деятельность", 6 },
                    { new Guid("d7669888-52c8-4b48-99e1-22f26be886e6"), "Конкурсная работа", 7 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("95e48c82-35ac-445d-9577-821fbdabdbc4"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("e3bfe35b-1835-4b9a-aaea-8044c935527f"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("286cd814-11dc-4a55-b15a-6d3c422b1a0e"), "bool" },
                    { new Guid("53b84499-7b5c-435c-b578-6f772c9879bb"), "string" },
                    { new Guid("58c343e6-d218-4b14-9c2c-972a233767e7"), "int" },
                    { new Guid("86216d10-1a07-4c1b-ba08-3415e20c4005"), "TextArea" },
                    { new Guid("d0bb8e29-ae04-4e88-9113-f28faab677d9"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("442321a2-eb8e-4252-865b-e836b92b4281"), new Guid("95e48c82-35ac-445d-9577-821fbdabdbc4") },
                    { new Guid("442321a2-eb8e-4252-865b-e836b92b4281"), new Guid("e3bfe35b-1835-4b9a-aaea-8044c935527f") },
                    { new Guid("4904908b-bf3f-4ada-937f-7216c14e7aff"), new Guid("95e48c82-35ac-445d-9577-821fbdabdbc4") },
                    { new Guid("5bfc8731-88ef-4367-87ee-e8df5bd99d1f"), new Guid("e3bfe35b-1835-4b9a-aaea-8044c935527f") },
                    { new Guid("6c660954-514f-4871-913f-c58e3b17de28"), new Guid("95e48c82-35ac-445d-9577-821fbdabdbc4") },
                    { new Guid("6c660954-514f-4871-913f-c58e3b17de28"), new Guid("e3bfe35b-1835-4b9a-aaea-8044c935527f") },
                    { new Guid("826bc23e-2102-4236-9b71-51ee2c1b9103"), new Guid("95e48c82-35ac-445d-9577-821fbdabdbc4") },
                    { new Guid("826bc23e-2102-4236-9b71-51ee2c1b9103"), new Guid("e3bfe35b-1835-4b9a-aaea-8044c935527f") },
                    { new Guid("bc6f0a31-167c-43a7-8360-23f4b14a14ea"), new Guid("95e48c82-35ac-445d-9577-821fbdabdbc4") },
                    { new Guid("bc6f0a31-167c-43a7-8360-23f4b14a14ea"), new Guid("e3bfe35b-1835-4b9a-aaea-8044c935527f") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("089b9c14-84d1-4c70-a386-347c137770e4"), new Guid("442321a2-eb8e-4252-865b-e836b92b4281"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("0ad486c0-e928-4467-b8c0-998ac7985ce4"), new Guid("442321a2-eb8e-4252-865b-e836b92b4281"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("0be5f723-2729-4a1a-9aea-e50c2c24189c"), new Guid("442321a2-eb8e-4252-865b-e836b92b4281"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("19609395-7cfa-4c4a-94c2-135e39f2b950"), new Guid("6c660954-514f-4871-913f-c58e3b17de28"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("37ed6da7-11b6-4020-8a6a-eddffca003eb"), new Guid("4904908b-bf3f-4ada-937f-7216c14e7aff"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("4a8e9061-057f-4ed1-8797-c31c69eb8201"), new Guid("5bfc8731-88ef-4367-87ee-e8df5bd99d1f"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("4ea0a189-add9-4fb3-9aaf-c1e2dd838037"), new Guid("442321a2-eb8e-4252-865b-e836b92b4281"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("5f604cbf-b2b6-4e3b-b1dd-8603dd1eb9f1"), new Guid("442321a2-eb8e-4252-865b-e836b92b4281"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("670d04c0-4608-4eb2-92b6-0e9968174d37"), new Guid("442321a2-eb8e-4252-865b-e836b92b4281"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("68bbab74-57cb-41f1-b691-17ab7516f987"), new Guid("442321a2-eb8e-4252-865b-e836b92b4281"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("81799947-97a0-4edf-8898-7ac5d03f9f25"), new Guid("6c660954-514f-4871-913f-c58e3b17de28"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("873f298e-683c-4246-b000-97efbf8e80a7"), new Guid("5bfc8731-88ef-4367-87ee-e8df5bd99d1f"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("89b82802-867b-4e4f-81ae-deac1e0bdab5"), new Guid("442321a2-eb8e-4252-865b-e836b92b4281"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("9bf65fbb-54d5-4781-8717-62f08fac08ce"), new Guid("6c660954-514f-4871-913f-c58e3b17de28"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("a4168dc4-d19f-4811-9ccb-b3f038ba2992"), new Guid("4904908b-bf3f-4ada-937f-7216c14e7aff"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("b32e5cf3-095e-4a66-9cb6-886003ebb308"), new Guid("5bfc8731-88ef-4367-87ee-e8df5bd99d1f"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("cf5b549f-da92-4dfa-9267-3c365ceff5c9"), new Guid("442321a2-eb8e-4252-865b-e836b92b4281"), null, true, true, "Место работы", 6, "Название организации", new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("dc350ec6-2f6b-4877-8777-d72c7050a062"), new Guid("442321a2-eb8e-4252-865b-e836b92b4281"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("d0bb8e29-ae04-4e88-9113-f28faab677d9") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("33fda319-7aa9-4e32-bfe2-3956e72c6df6"), new Guid("e3bfe35b-1835-4b9a-aaea-8044c935527f") },
                    { new Guid("7203f2e6-1012-425b-8e5f-4aab263970a2"), new Guid("e3bfe35b-1835-4b9a-aaea-8044c935527f") },
                    { new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a"), new Guid("e3bfe35b-1835-4b9a-aaea-8044c935527f") },
                    { new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a"), new Guid("95e48c82-35ac-445d-9577-821fbdabdbc4") },
                    { new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a"), new Guid("e3bfe35b-1835-4b9a-aaea-8044c935527f") },
                    { new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f"), new Guid("95e48c82-35ac-445d-9577-821fbdabdbc4") },
                    { new Guid("cf8d82db-2591-408a-a14e-5bdf85835a31"), new Guid("95e48c82-35ac-445d-9577-821fbdabdbc4") },
                    { new Guid("d7669888-52c8-4b48-99e1-22f26be886e6"), new Guid("95e48c82-35ac-445d-9577-821fbdabdbc4") },
                    { new Guid("d7669888-52c8-4b48-99e1-22f26be886e6"), new Guid("e3bfe35b-1835-4b9a-aaea-8044c935527f") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0396333d-fb94-438e-80fb-0add2a7aea91"), new Guid("826bc23e-2102-4236-9b71-51ee2c1b9103"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("134f4e63-54d2-48ee-9790-bd6f3707fd7c"), new Guid("5bfc8731-88ef-4367-87ee-e8df5bd99d1f"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("20ee5791-13f3-4d8f-80f7-347b0bba2019"), new Guid("826bc23e-2102-4236-9b71-51ee2c1b9103"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("4f0f7932-89d5-4da9-ae21-f0d0046e73dd"), new Guid("5bfc8731-88ef-4367-87ee-e8df5bd99d1f"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("53dec41a-9a9e-4e63-bb29-b218537e68cc"), new Guid("4904908b-bf3f-4ada-937f-7216c14e7aff"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("5ab59416-a2b7-4d16-8080-f5c5dfefd212"), new Guid("5bfc8731-88ef-4367-87ee-e8df5bd99d1f"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 },
                    { new Guid("6a364418-0ca8-4f8e-9227-23e52e2dbefb"), new Guid("4904908b-bf3f-4ada-937f-7216c14e7aff"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("9dbee2b5-160b-4861-a3f4-db5f8010509c"), new Guid("4904908b-bf3f-4ada-937f-7216c14e7aff"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("b0755350-9212-4176-89cd-66bea8054a10"), new Guid("bc6f0a31-167c-43a7-8360-23f4b14a14ea"), true, true, "Краткая аннотация конкурсной работы", 1 },
                    { new Guid("b80c6141-eddc-4903-8d89-7ec310cfb3cd"), new Guid("5bfc8731-88ef-4367-87ee-e8df5bd99d1f"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 },
                    { new Guid("c10270b8-1745-4a9c-b9e9-6203ce24f74a"), new Guid("826bc23e-2102-4236-9b71-51ee2c1b9103"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 },
                    { new Guid("e1987b83-74bd-4f25-a244-6483c48fd3a1"), new Guid("5bfc8731-88ef-4367-87ee-e8df5bd99d1f"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 },
                    { new Guid("ff123000-a20b-4fba-a332-ae81efe45d2a"), new Guid("4904908b-bf3f-4ada-937f-7216c14e7aff"), false, false, "Список научных публикаций за последние 5 лет", 10 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("071d3121-e829-41a9-a7dc-63c2713ad6ae"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("c10270b8-1745-4a9c-b9e9-6203ce24f74a"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("0d69bfd6-711f-4b6b-b616-bbd9ab608b62"), false, "Тип идентификатора", 1, new Guid("0396333d-fb94-438e-80fb-0add2a7aea91"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("0fb7a83a-c75d-4504-8c2c-8a50fa930128"), true, "Ссылка на платформу", 3, new Guid("134f4e63-54d2-48ee-9790-bd6f3707fd7c"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("19856afd-0331-4e65-8080-8d853536080e"), true, "Издательство, год", 6, new Guid("5ab59416-a2b7-4d16-8080-f5c5dfefd212"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("1a92c43a-ec6d-4b2f-9ddf-a1f09c5bf5d5"), true, "Практические занятия (час.)", 4, new Guid("4f0f7932-89d5-4da9-ae21-f0d0046e73dd"), new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("3761b199-43fd-4a93-95eb-9c158a7ef2d2"), true, "Название", 2, new Guid("9dbee2b5-160b-4861-a3f4-db5f8010509c"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("3be85085-85a3-4839-99a6-c54e1c267fed"), true, "Год", 4, new Guid("134f4e63-54d2-48ee-9790-bd6f3707fd7c"), new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("3f4f40bd-e44f-45b6-b1e9-342aa08bcd6c"), true, "ФИО соавторов", 3, new Guid("9dbee2b5-160b-4861-a3f4-db5f8010509c"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("43932a5e-4ae4-49d9-b54e-21c92c78b20e"), true, "Вид", 1, new Guid("53dec41a-9a9e-4e63-bb29-b218537e68cc"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("44e66a48-e6bf-428b-958f-0aa241b6d75f"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("b80c6141-eddc-4903-8d89-7ec310cfb3cd"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("4b9f545e-3797-48ae-9878-b3be41aec242"), true, "Статус конкурса", 3, new Guid("c10270b8-1745-4a9c-b9e9-6203ce24f74a"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("5b8d62dc-1b52-4fdb-bc7e-5604182032ef"), true, "Название НИР/НИОКР", 1, new Guid("6a364418-0ca8-4f8e-9227-23e52e2dbefb"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("5ff041c6-9d25-4b02-8512-5e2775fdc475"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("b80c6141-eddc-4903-8d89-7ec310cfb3cd"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("61122f13-5b7f-48af-a4cd-094d4a73807d"), true, "Период выполнения", 3, new Guid("6a364418-0ca8-4f8e-9227-23e52e2dbefb"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("6af87a52-7eed-4ed1-b0c7-0af506949eaa"), true, "Язык публикации", 7, new Guid("5ab59416-a2b7-4d16-8080-f5c5dfefd212"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("6c603679-f703-41be-9b3d-8682443a45f2"), true, "Название дисциплины", 1, new Guid("e1987b83-74bd-4f25-a244-6483c48fd3a1"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("704fc776-8dfe-4758-8228-8155e5e29189"), true, "Название статьи", 1, new Guid("ff123000-a20b-4fba-a332-ae81efe45d2a"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("7c3fc0c1-5e0d-437a-9cf3-257de0d36156"), true, "Соавторы", 2, new Guid("ff123000-a20b-4fba-a332-ae81efe45d2a"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("7c9290ed-a1a2-4c3b-ba93-e36ec1b0fc04"), true, "Издание, год", 4, new Guid("ff123000-a20b-4fba-a332-ae81efe45d2a"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("8076da5d-67ab-4e12-bb76-02e23ae130bd"), true, "Вид", 1, new Guid("9dbee2b5-160b-4861-a3f4-db5f8010509c"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("80d8a6da-b05a-4e4a-8718-1819961f89d5"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("e1987b83-74bd-4f25-a244-6483c48fd3a1"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("9231d8a8-f1da-4027-8840-7483678efe53"), true, "Количество печатных листов", 4, new Guid("5ab59416-a2b7-4d16-8080-f5c5dfefd212"), new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("9557c16b-6115-41e5-bd1b-4eb695384bc4"), true, "ФИО", 1, new Guid("b80c6141-eddc-4903-8d89-7ec310cfb3cd"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("95da8fcf-fc9d-47d2-a6e8-d78148d10c2c"), true, "Статус", 4, new Guid("6a364418-0ca8-4f8e-9227-23e52e2dbefb"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("9a245acf-9694-4885-96b2-801b9f625a68"), true, "Год", 1, new Guid("c10270b8-1745-4a9c-b9e9-6203ce24f74a"), new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("9ec7a633-c575-4903-84c9-554d7dc8e71b"), true, "Год получения документа", 2, new Guid("20ee5791-13f3-4d8f-80f7-347b0bba2019"), new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("a18a775d-fcd4-459f-b914-523e5769c203"), true, "Ссылка на открытый доступ", 8, new Guid("5ab59416-a2b7-4d16-8080-f5c5dfefd212"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("a1e304e5-7526-44c3-9cd5-97b32ab9fcba"), false, "Идентификатор", 2, new Guid("0396333d-fb94-438e-80fb-0add2a7aea91"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("a896871f-7dca-42b6-b44a-a407e6cee720"), true, "Вид", 2, new Guid("e1987b83-74bd-4f25-a244-6483c48fd3a1"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("aa526734-9e84-4f40-b14e-eb856a40da00"), true, "Значение", 2, new Guid("b0755350-9212-4176-89cd-66bea8054a10"), new Guid("86216d10-1a07-4c1b-ba08-3415e20c4005") },
                    { new Guid("ac3b557a-f000-49f2-96d4-358879c011e4"), true, "Название документа, реквизиты", 1, new Guid("20ee5791-13f3-4d8f-80f7-347b0bba2019"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("af75ae9e-fe4b-4266-933b-8840e3c38593"), true, "Название организации в которую внедрена разработка", 3, new Guid("53dec41a-9a9e-4e63-bb29-b218537e68cc"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("b1f38bd3-4316-4960-a022-182ebbbfaeba"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("ff123000-a20b-4fba-a332-ae81efe45d2a"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("ba988429-3599-4779-b473-4acbcf9a886f"), true, "Год", 3, new Guid("b80c6141-eddc-4903-8d89-7ec310cfb3cd"), new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("bc5e0781-a7c1-4658-9a22-3bef24a01fe9"), true, "Лекции (час.)", 3, new Guid("4f0f7932-89d5-4da9-ae21-f0d0046e73dd"), new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("bc8d98f1-7d9c-4867-a0d3-ebcc2277d21b"), true, "Название", 2, new Guid("5ab59416-a2b7-4d16-8080-f5c5dfefd212"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("bec18c6f-dcf2-4db3-8ff2-52f6cf38922b"), false, "Соавторы", 3, new Guid("5ab59416-a2b7-4d16-8080-f5c5dfefd212"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("c13fb5f4-a5d0-46b4-881f-aa37f21816ad"), true, "Итого (час.)", 5, new Guid("4f0f7932-89d5-4da9-ae21-f0d0046e73dd"), new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("c7c0fefb-0886-4153-9185-014d52089a88"), true, "Название", 1, new Guid("b0755350-9212-4176-89cd-66bea8054a10"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("c7c6ff3e-e401-444a-bb00-54e5c72d4739"), true, "Название конкурса/премии", 2, new Guid("b80c6141-eddc-4903-8d89-7ec310cfb3cd"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("cbb58720-cfe6-4c67-9077-60510bab8e4d"), true, "Название конкурса", 2, new Guid("c10270b8-1745-4a9c-b9e9-6203ce24f74a"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("df8494ba-f010-4a18-927b-f88b7f312d33"), true, "Соавторы", 2, new Guid("134f4e63-54d2-48ee-9790-bd6f3707fd7c"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("e4c6f935-6649-4141-9aa9-b4838bcb29f1"), true, "Наличие грифа", 5, new Guid("5ab59416-a2b7-4d16-8080-f5c5dfefd212"), new Guid("286cd814-11dc-4a55-b15a-6d3c422b1a0e") },
                    { new Guid("e7920855-69ec-49ed-b237-8110845015dc"), true, "Язык преподавания", 2, new Guid("4f0f7932-89d5-4da9-ae21-f0d0046e73dd"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("ea68d8cd-d542-4408-ac0c-624499c42d20"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("6a364418-0ca8-4f8e-9227-23e52e2dbefb"), new Guid("58c343e6-d218-4b14-9c2c-972a233767e7") },
                    { new Guid("eea06e67-4e4d-4280-a78a-37bdb9a24d23"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("6a364418-0ca8-4f8e-9227-23e52e2dbefb"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("eea714ce-9d7c-4ffa-bb91-9ff10d0d569e"), true, "Вид публикации", 1, new Guid("5ab59416-a2b7-4d16-8080-f5c5dfefd212"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("f26abc9d-fd8a-46e5-a18a-6f412851e90a"), true, "Название разработки", 2, new Guid("53dec41a-9a9e-4e63-bb29-b218537e68cc"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("f35a04e7-9018-4f90-80c4-2bb09af9f851"), true, "Название курса", 1, new Guid("134f4e63-54d2-48ee-9790-bd6f3707fd7c"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("f6fc0ff0-7cab-45cd-9785-6d462ae512d9"), true, "Наименование курса", 1, new Guid("4f0f7932-89d5-4da9-ae21-f0d0046e73dd"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("f710a677-9d8d-46f9-9134-36c59996a09d"), true, "Номер РИД", 4, new Guid("9dbee2b5-160b-4861-a3f4-db5f8010509c"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") },
                    { new Guid("f8e607fc-960d-4c15-aa99-77a93829171b"), true, "Ссылка", 5, new Guid("c10270b8-1745-4a9c-b9e9-6203ce24f74a"), new Guid("53b84499-7b5c-435c-b578-6f772c9879bb") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("089b9c14-84d1-4c70-a386-347c137770e4"), new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a") },
                    { new Guid("0ad486c0-e928-4467-b8c0-998ac7985ce4"), new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a") },
                    { new Guid("0be5f723-2729-4a1a-9aea-e50c2c24189c"), new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a") },
                    { new Guid("19609395-7cfa-4c4a-94c2-135e39f2b950"), new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a") },
                    { new Guid("37ed6da7-11b6-4020-8a6a-eddffca003eb"), new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f") },
                    { new Guid("4a8e9061-057f-4ed1-8797-c31c69eb8201"), new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a") },
                    { new Guid("4ea0a189-add9-4fb3-9aaf-c1e2dd838037"), new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a") },
                    { new Guid("5f604cbf-b2b6-4e3b-b1dd-8603dd1eb9f1"), new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a") },
                    { new Guid("670d04c0-4608-4eb2-92b6-0e9968174d37"), new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a") },
                    { new Guid("68bbab74-57cb-41f1-b691-17ab7516f987"), new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a") },
                    { new Guid("81799947-97a0-4edf-8898-7ac5d03f9f25"), new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a") },
                    { new Guid("873f298e-683c-4246-b000-97efbf8e80a7"), new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a") },
                    { new Guid("89b82802-867b-4e4f-81ae-deac1e0bdab5"), new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a") },
                    { new Guid("9bf65fbb-54d5-4781-8717-62f08fac08ce"), new Guid("7203f2e6-1012-425b-8e5f-4aab263970a2") },
                    { new Guid("9bf65fbb-54d5-4781-8717-62f08fac08ce"), new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a") },
                    { new Guid("9bf65fbb-54d5-4781-8717-62f08fac08ce"), new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f") },
                    { new Guid("a4168dc4-d19f-4811-9ccb-b3f038ba2992"), new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f") },
                    { new Guid("b32e5cf3-095e-4a66-9cb6-886003ebb308"), new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a") },
                    { new Guid("cf5b549f-da92-4dfa-9267-3c365ceff5c9"), new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a") },
                    { new Guid("dc350ec6-2f6b-4877-8777-d72c7050a062"), new Guid("8c0414d2-5820-4d6c-b071-d09ff4b67a4a") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("33fda319-7aa9-4e32-bfe2-3956e72c6df6"), new Guid("5ab59416-a2b7-4d16-8080-f5c5dfefd212") },
                    { new Guid("33fda319-7aa9-4e32-bfe2-3956e72c6df6"), new Guid("e1987b83-74bd-4f25-a244-6483c48fd3a1") },
                    { new Guid("7203f2e6-1012-425b-8e5f-4aab263970a2"), new Guid("20ee5791-13f3-4d8f-80f7-347b0bba2019") },
                    { new Guid("7203f2e6-1012-425b-8e5f-4aab263970a2"), new Guid("c10270b8-1745-4a9c-b9e9-6203ce24f74a") },
                    { new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a"), new Guid("134f4e63-54d2-48ee-9790-bd6f3707fd7c") },
                    { new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a"), new Guid("4f0f7932-89d5-4da9-ae21-f0d0046e73dd") },
                    { new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a"), new Guid("b80c6141-eddc-4903-8d89-7ec310cfb3cd") },
                    { new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f"), new Guid("0396333d-fb94-438e-80fb-0add2a7aea91") },
                    { new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f"), new Guid("6a364418-0ca8-4f8e-9227-23e52e2dbefb") },
                    { new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f"), new Guid("c10270b8-1745-4a9c-b9e9-6203ce24f74a") },
                    { new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f"), new Guid("ff123000-a20b-4fba-a332-ae81efe45d2a") },
                    { new Guid("cf8d82db-2591-408a-a14e-5bdf85835a31"), new Guid("20ee5791-13f3-4d8f-80f7-347b0bba2019") },
                    { new Guid("cf8d82db-2591-408a-a14e-5bdf85835a31"), new Guid("53dec41a-9a9e-4e63-bb29-b218537e68cc") },
                    { new Guid("cf8d82db-2591-408a-a14e-5bdf85835a31"), new Guid("9dbee2b5-160b-4861-a3f4-db5f8010509c") },
                    { new Guid("d7669888-52c8-4b48-99e1-22f26be886e6"), new Guid("b0755350-9212-4176-89cd-66bea8054a10") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0ec14e71-071a-46a3-a2e1-6a737d728b00"), "EvaluateMark4", new Guid("b32e5cf3-095e-4a66-9cb6-886003ebb308"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("12734d3f-313b-43d9-9f59-126524d60c64"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("4f0f7932-89d5-4da9-ae21-f0d0046e73dd") },
                    { new Guid("18ea5b48-b22d-423e-bd4a-2263a41f4e0f"), "EvaluateMark19", new Guid("a4168dc4-d19f-4811-9ccb-b3f038ba2992"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("279dc8f8-2937-419a-b98e-7319d043d999"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("6a364418-0ca8-4f8e-9227-23e52e2dbefb") },
                    { new Guid("30de9046-aecf-4ffe-9ca9-c4a54fc3ccc0"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("5ab59416-a2b7-4d16-8080-f5c5dfefd212") },
                    { new Guid("3371c2ab-9664-4402-a3a8-d608749a203a"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("b0755350-9212-4176-89cd-66bea8054a10") },
                    { new Guid("37d53298-6889-4b2f-bf7b-378eacd99a0f"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("e1987b83-74bd-4f25-a244-6483c48fd3a1") },
                    { new Guid("43a7744d-c214-497c-8e8c-b32f475acd5e"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("5ab59416-a2b7-4d16-8080-f5c5dfefd212") },
                    { new Guid("4709b3d4-90f5-415f-bce0-28b60f1d0493"), "EvaluateMark5", new Guid("873f298e-683c-4246-b000-97efbf8e80a7"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("48fa8a99-aeeb-4fce-99cb-f744e7acaaf7"), "EvaluateMark20", new Guid("37ed6da7-11b6-4020-8a6a-eddffca003eb"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("5c241225-a9d9-4582-add6-44c62201b604"), "EvaluateMark3", new Guid("4a8e9061-057f-4ed1-8797-c31c69eb8201"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 5, null },
                    { new Guid("82857856-36d1-43a0-854d-983e50432454"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("53dec41a-9a9e-4e63-bb29-b218537e68cc") },
                    { new Guid("8777cf9b-94b1-421b-9e77-99172a2f97fe"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом и без соавторства:", 8, new Guid("5ab59416-a2b7-4d16-8080-f5c5dfefd212") },
                    { new Guid("92e35077-dbc8-41f7-bbbb-a4508d1c4bbb"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("c10270b8-1745-4a9c-b9e9-6203ce24f74a") },
                    { new Guid("960b3b8c-3d68-43e7-a8f9-1194db9ecb10"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("134f4e63-54d2-48ee-9790-bd6f3707fd7c") },
                    { new Guid("9d35a90a-d15b-4045-91c6-637265f6ea8e"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("4f0f7932-89d5-4da9-ae21-f0d0046e73dd") },
                    { new Guid("a01d615a-3f06-4ba6-a7aa-830cd63a166e"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("6a364418-0ca8-4f8e-9227-23e52e2dbefb") },
                    { new Guid("ad6e6a24-dc52-46e0-a5b5-813337960062"), "EvaluateMark13", new Guid("9bf65fbb-54d5-4781-8717-62f08fac08ce"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("ae251340-2698-4ff7-82b4-856ec1c97de1"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("b80c6141-eddc-4903-8d89-7ec310cfb3cd") },
                    { new Guid("cebad1f3-2c1a-4fa5-a29e-6dc6e0808040"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("20ee5791-13f3-4d8f-80f7-347b0bba2019") },
                    { new Guid("cf17dc1c-a02d-4183-85ee-3f0d1ae1a82d"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("b0755350-9212-4176-89cd-66bea8054a10") },
                    { new Guid("e8dc0281-c3e6-46cb-bfbb-d218640d2591"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("5ab59416-a2b7-4d16-8080-f5c5dfefd212") },
                    { new Guid("eb47b23e-a5f8-4483-b4fb-c58cf4527839"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("ff123000-a20b-4fba-a332-ae81efe45d2a") },
                    { new Guid("eea07bae-c84b-4b17-a80b-24eef7456e91"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("9dbee2b5-160b-4861-a3f4-db5f8010509c") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("1682fdb5-2d27-410b-9586-dce905705fac"), true, new Guid("b0755350-9212-4176-89cd-66bea8054a10") },
                    { new Guid("262ce73a-ce2b-422f-8cd7-59574ea3ef5f"), true, new Guid("0396333d-fb94-438e-80fb-0add2a7aea91") },
                    { new Guid("30dee042-4b84-458e-b500-65b1c74fc7c7"), true, new Guid("0396333d-fb94-438e-80fb-0add2a7aea91") },
                    { new Guid("332dbd73-7148-47ae-b9bf-38ecbcff8f92"), true, new Guid("b0755350-9212-4176-89cd-66bea8054a10") },
                    { new Guid("363aa6c0-56f4-4f15-9643-b16a75fed83d"), true, new Guid("0396333d-fb94-438e-80fb-0add2a7aea91") },
                    { new Guid("4ec39cd4-e23f-4da4-be0d-6dd65dc32a6a"), true, new Guid("0396333d-fb94-438e-80fb-0add2a7aea91") },
                    { new Guid("62a99744-70b6-41ff-84d1-5862b3c4cb17"), true, new Guid("b0755350-9212-4176-89cd-66bea8054a10") },
                    { new Guid("7dea40b7-7802-4d55-a522-522a8b7db53d"), true, new Guid("0396333d-fb94-438e-80fb-0add2a7aea91") },
                    { new Guid("8f4c3a3b-dc5e-42e7-9e35-fca6f26a76d3"), true, new Guid("b0755350-9212-4176-89cd-66bea8054a10") },
                    { new Guid("baa4543f-d30a-4b8e-9814-461f82b4b888"), true, new Guid("b0755350-9212-4176-89cd-66bea8054a10") },
                    { new Guid("e98dfb25-8213-4e45-811e-c361474f616c"), true, new Guid("b0755350-9212-4176-89cd-66bea8054a10") },
                    { new Guid("fce5ad2a-cbc5-4cff-8271-f8abeb1131c9"), true, new Guid("b0755350-9212-4176-89cd-66bea8054a10") },
                    { new Guid("ffe115e1-5304-4118-b5c5-d697c487a5cb"), true, new Guid("b0755350-9212-4176-89cd-66bea8054a10") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("3acb1f8d-67d4-4d84-96b1-2a870645c35b"), null, new Guid("9bf65fbb-54d5-4781-8717-62f08fac08ce"), "Доцент" },
                    { new Guid("445a6a95-1400-4ab4-b4b9-f92bf81b1d08"), null, new Guid("9bf65fbb-54d5-4781-8717-62f08fac08ce"), "Нет" },
                    { new Guid("d765fef2-5998-4ad4-b84e-1009a0378b0c"), null, new Guid("81799947-97a0-4edf-8898-7ac5d03f9f25"), "Доктор наук" },
                    { new Guid("fa6e8229-f9ae-4779-826b-67a1451f5bfd"), null, new Guid("9bf65fbb-54d5-4781-8717-62f08fac08ce"), "Профессор" },
                    { new Guid("fd280a07-9c5e-4d5d-9040-75ad07c364f0"), null, new Guid("81799947-97a0-4edf-8898-7ac5d03f9f25"), "Кандидат наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("02643980-2a56-4563-a0a0-750903cf2589"), null, new Guid("0d69bfd6-711f-4b6b-b616-bbd9ab608b62"), true, true, new Guid("7dea40b7-7802-4d55-a522-522a8b7db53d"), "ORCiD" },
                    { new Guid("13cd6cee-cde6-4439-bb4f-7375a6a51673"), null, new Guid("aa526734-9e84-4f40-b14e-eb856a40da00"), false, true, new Guid("ffe115e1-5304-4118-b5c5-d697c487a5cb"), null },
                    { new Guid("363a5bdc-cfb2-4cc7-b861-04dfe43206c9"), null, new Guid("c7c0fefb-0886-4153-9185-014d52089a88"), true, true, new Guid("1682fdb5-2d27-410b-9586-dce905705fac"), "Инновационность" },
                    { new Guid("381649e9-35c3-4c73-85f9-66bfb658579d"), null, new Guid("0d69bfd6-711f-4b6b-b616-bbd9ab608b62"), true, true, new Guid("30dee042-4b84-458e-b500-65b1c74fc7c7"), "Google Scholar ID" },
                    { new Guid("3c95a1fb-e95a-449b-95cb-2bcae53d13c6"), null, new Guid("c7c0fefb-0886-4153-9185-014d52089a88"), true, true, new Guid("62a99744-70b6-41ff-84d1-5862b3c4cb17"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("3e86fa99-8915-452f-9816-b270d5f56ab7"), null, new Guid("a1e304e5-7526-44c3-9cd5-97b32ab9fcba"), false, true, new Guid("363aa6c0-56f4-4f15-9643-b16a75fed83d"), null },
                    { new Guid("50a11655-e9cd-4af3-8c4d-37ea6460f67b"), null, new Guid("aa526734-9e84-4f40-b14e-eb856a40da00"), false, true, new Guid("8f4c3a3b-dc5e-42e7-9e35-fca6f26a76d3"), null },
                    { new Guid("51e51ea4-90ba-4ff6-ac40-5516f229a717"), null, new Guid("aa526734-9e84-4f40-b14e-eb856a40da00"), false, true, new Guid("fce5ad2a-cbc5-4cff-8271-f8abeb1131c9"), null },
                    { new Guid("6da495d7-d0ea-43ba-acb8-59412484c6e3"), null, new Guid("a1e304e5-7526-44c3-9cd5-97b32ab9fcba"), false, true, new Guid("4ec39cd4-e23f-4da4-be0d-6dd65dc32a6a"), null },
                    { new Guid("6f92b164-b19d-439d-807a-d90c77a5ef45"), null, new Guid("0d69bfd6-711f-4b6b-b616-bbd9ab608b62"), true, true, new Guid("4ec39cd4-e23f-4da4-be0d-6dd65dc32a6a"), "ScopusID" },
                    { new Guid("756f396c-2b00-4523-8915-6cdfc536517c"), null, new Guid("c7c0fefb-0886-4153-9185-014d52089a88"), true, true, new Guid("baa4543f-d30a-4b8e-9814-461f82b4b888"), "Актуальность конкурсной работы" },
                    { new Guid("7cff038a-030c-4eab-9f5c-b2106bba966e"), null, new Guid("aa526734-9e84-4f40-b14e-eb856a40da00"), false, true, new Guid("62a99744-70b6-41ff-84d1-5862b3c4cb17"), null },
                    { new Guid("8937e070-cba2-4ef5-87f1-32a22a81058c"), null, new Guid("aa526734-9e84-4f40-b14e-eb856a40da00"), false, true, new Guid("332dbd73-7148-47ae-b9bf-38ecbcff8f92"), null },
                    { new Guid("99b3b345-8234-4276-bef8-aae2ac5b9275"), null, new Guid("0d69bfd6-711f-4b6b-b616-bbd9ab608b62"), true, true, new Guid("363aa6c0-56f4-4f15-9643-b16a75fed83d"), "ResearcherID" },
                    { new Guid("a3a1122e-be65-4e77-b249-629bf5910882"), null, new Guid("0d69bfd6-711f-4b6b-b616-bbd9ab608b62"), true, true, new Guid("262ce73a-ce2b-422f-8cd7-59574ea3ef5f"), "РИНЦ AuthorID" },
                    { new Guid("a3ea6a82-318b-45d4-b8ec-94cdfc36f209"), null, new Guid("a1e304e5-7526-44c3-9cd5-97b32ab9fcba"), false, true, new Guid("7dea40b7-7802-4d55-a522-522a8b7db53d"), null },
                    { new Guid("aa3abddf-804d-4d4e-9390-34f215b29cd9"), null, new Guid("aa526734-9e84-4f40-b14e-eb856a40da00"), false, true, new Guid("e98dfb25-8213-4e45-811e-c361474f616c"), null },
                    { new Guid("b0d31002-573b-4292-a44e-7b0dad7a6a6a"), null, new Guid("c7c0fefb-0886-4153-9185-014d52089a88"), true, true, new Guid("fce5ad2a-cbc5-4cff-8271-f8abeb1131c9"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("b24c731b-9a0a-47a2-be36-9a20449198ad"), null, new Guid("a1e304e5-7526-44c3-9cd5-97b32ab9fcba"), false, true, new Guid("262ce73a-ce2b-422f-8cd7-59574ea3ef5f"), null },
                    { new Guid("c5f9fc92-5203-4930-a510-c1ff1fedc266"), null, new Guid("aa526734-9e84-4f40-b14e-eb856a40da00"), false, true, new Guid("1682fdb5-2d27-410b-9586-dce905705fac"), null },
                    { new Guid("c86379ff-495d-492b-96f6-762702199dfb"), null, new Guid("c7c0fefb-0886-4153-9185-014d52089a88"), true, true, new Guid("ffe115e1-5304-4118-b5c5-d697c487a5cb"), "Результаты и выводы" },
                    { new Guid("d1a22e67-c39e-4819-afdc-12902c00d31c"), null, new Guid("aa526734-9e84-4f40-b14e-eb856a40da00"), false, true, new Guid("baa4543f-d30a-4b8e-9814-461f82b4b888"), null },
                    { new Guid("d6691349-81cb-4000-9d87-f4e789158a21"), null, new Guid("a1e304e5-7526-44c3-9cd5-97b32ab9fcba"), false, true, new Guid("30dee042-4b84-458e-b500-65b1c74fc7c7"), null },
                    { new Guid("deb5aae4-eecc-4a78-a085-31408edbdd11"), null, new Guid("c7c0fefb-0886-4153-9185-014d52089a88"), true, true, new Guid("8f4c3a3b-dc5e-42e7-9e35-fca6f26a76d3"), "Методология и методы, используемые в работе" },
                    { new Guid("e08b6b94-3c99-40b8-8c58-0adb651ad0e3"), null, new Guid("c7c0fefb-0886-4153-9185-014d52089a88"), true, true, new Guid("332dbd73-7148-47ae-b9bf-38ecbcff8f92"), "Ссылка на конкурсную работу" },
                    { new Guid("f1e24ee0-f10d-431f-9edf-6d5659ef8571"), null, new Guid("c7c0fefb-0886-4153-9185-014d52089a88"), true, true, new Guid("e98dfb25-8213-4e45-811e-c361474f616c"), "Название работы" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("33fda319-7aa9-4e32-bfe2-3956e72c6df6"), new Guid("30de9046-aecf-4ffe-9ca9-c4a54fc3ccc0") },
                    { new Guid("33fda319-7aa9-4e32-bfe2-3956e72c6df6"), new Guid("37d53298-6889-4b2f-bf7b-378eacd99a0f") },
                    { new Guid("33fda319-7aa9-4e32-bfe2-3956e72c6df6"), new Guid("43a7744d-c214-497c-8e8c-b32f475acd5e") },
                    { new Guid("33fda319-7aa9-4e32-bfe2-3956e72c6df6"), new Guid("8777cf9b-94b1-421b-9e77-99172a2f97fe") },
                    { new Guid("33fda319-7aa9-4e32-bfe2-3956e72c6df6"), new Guid("e8dc0281-c3e6-46cb-bfbb-d218640d2591") },
                    { new Guid("7203f2e6-1012-425b-8e5f-4aab263970a2"), new Guid("92e35077-dbc8-41f7-bbbb-a4508d1c4bbb") },
                    { new Guid("7203f2e6-1012-425b-8e5f-4aab263970a2"), new Guid("ad6e6a24-dc52-46e0-a5b5-813337960062") },
                    { new Guid("7203f2e6-1012-425b-8e5f-4aab263970a2"), new Guid("cebad1f3-2c1a-4fa5-a29e-6dc6e0808040") },
                    { new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a"), new Guid("0ec14e71-071a-46a3-a2e1-6a737d728b00") },
                    { new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a"), new Guid("12734d3f-313b-43d9-9f59-126524d60c64") },
                    { new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a"), new Guid("4709b3d4-90f5-415f-bce0-28b60f1d0493") },
                    { new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a"), new Guid("5c241225-a9d9-4582-add6-44c62201b604") },
                    { new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a"), new Guid("960b3b8c-3d68-43e7-a8f9-1194db9ecb10") },
                    { new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a"), new Guid("9d35a90a-d15b-4045-91c6-637265f6ea8e") },
                    { new Guid("889f34c1-b5cf-4af8-85d1-355dce8c085a"), new Guid("ae251340-2698-4ff7-82b4-856ec1c97de1") },
                    { new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f"), new Guid("18ea5b48-b22d-423e-bd4a-2263a41f4e0f") },
                    { new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f"), new Guid("279dc8f8-2937-419a-b98e-7319d043d999") },
                    { new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f"), new Guid("48fa8a99-aeeb-4fce-99cb-f744e7acaaf7") },
                    { new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f"), new Guid("92e35077-dbc8-41f7-bbbb-a4508d1c4bbb") },
                    { new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f"), new Guid("a01d615a-3f06-4ba6-a7aa-830cd63a166e") },
                    { new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f"), new Guid("ad6e6a24-dc52-46e0-a5b5-813337960062") },
                    { new Guid("9a64f626-1181-4cad-bc4a-60af4dce353f"), new Guid("eb47b23e-a5f8-4483-b4fb-c58cf4527839") },
                    { new Guid("cf8d82db-2591-408a-a14e-5bdf85835a31"), new Guid("82857856-36d1-43a0-854d-983e50432454") },
                    { new Guid("cf8d82db-2591-408a-a14e-5bdf85835a31"), new Guid("cebad1f3-2c1a-4fa5-a29e-6dc6e0808040") },
                    { new Guid("cf8d82db-2591-408a-a14e-5bdf85835a31"), new Guid("eea07bae-c84b-4b17-a80b-24eef7456e91") },
                    { new Guid("d7669888-52c8-4b48-99e1-22f26be886e6"), new Guid("3371c2ab-9664-4402-a3a8-d608749a203a") },
                    { new Guid("d7669888-52c8-4b48-99e1-22f26be886e6"), new Guid("cf17dc1c-a02d-4183-85ee-3f0d1ae1a82d") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("08e55412-3c76-4761-80b0-36681a1bb37f"), new Guid("b1f38bd3-4316-4960-a022-182ebbbfaeba"), null, "ВАК (К2-К3)" },
                    { new Guid("17cd04e6-258d-43e0-a1dc-50d14bacffd4"), new Guid("b1f38bd3-4316-4960-a022-182ebbbfaeba"), null, "МБД (Q3-Q4)" },
                    { new Guid("1be1bf59-4033-470c-bc3a-2336d40bde49"), new Guid("a896871f-7dca-42b6-b44a-a407e6cee720"), null, "Лекции" },
                    { new Guid("1ddd2616-e50f-4064-bf88-34286ac6715c"), new Guid("43932a5e-4ae4-49d9-b54e-21c92c78b20e"), null, "Промышленный образец" },
                    { new Guid("27c7178a-3d3f-4a3c-83c0-fa3160a2c706"), new Guid("6af87a52-7eed-4ed1-b0c7-0af506949eaa"), null, "Иностранный" },
                    { new Guid("2f15f36c-b730-4dbd-b8d7-571fe0bf530b"), new Guid("4b9f545e-3797-48ae-9878-b3be41aec242"), null, "Всероссийский" },
                    { new Guid("349ac9d1-8681-4b01-af1e-c8ffee978ed6"), new Guid("7c3fc0c1-5e0d-437a-9cf3-257de0d36156"), null, "Есть" },
                    { new Guid("353a8483-74a2-4f58-90e3-2709041712de"), new Guid("43932a5e-4ae4-49d9-b54e-21c92c78b20e"), null, "Полезная модель" },
                    { new Guid("37571dab-aa08-4e0b-8532-767d54b08ca5"), new Guid("bec18c6f-dcf2-4db3-8ff2-52f6cf38922b"), null, "Нет" },
                    { new Guid("37964d56-948b-4c56-9e41-f8e5c84ababe"), new Guid("95da8fcf-fc9d-47d2-a6e8-d78148d10c2c"), null, "Исполнитель" },
                    { new Guid("39949fe6-f4fe-4481-bd3e-e33e644b23be"), new Guid("6af87a52-7eed-4ed1-b0c7-0af506949eaa"), null, "Русский" },
                    { new Guid("4bb71fdc-ca9a-4bf9-8b6b-bad64d75f626"), new Guid("e4c6f935-6649-4141-9aa9-b4838bcb29f1"), null, "Нет" },
                    { new Guid("4c46412d-5047-41b4-8e14-d7718efaf269"), new Guid("43932a5e-4ae4-49d9-b54e-21c92c78b20e"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("4ee2186c-8bc1-4341-a5df-afe26a6a8716"), new Guid("bec18c6f-dcf2-4db3-8ff2-52f6cf38922b"), null, "Есть" },
                    { new Guid("55e11e1a-8382-462a-99a7-58447e0856dd"), new Guid("e7920855-69ec-49ed-b237-8110845015dc"), null, "Русский" },
                    { new Guid("563dbcb3-17ad-495d-b439-48ec05911197"), new Guid("b1f38bd3-4316-4960-a022-182ebbbfaeba"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("6ea16251-d95f-4fa7-830d-b9e87a28d0b9"), new Guid("e7920855-69ec-49ed-b237-8110845015dc"), null, "Другой" },
                    { new Guid("74b8bd5c-351c-478a-be57-a21c545b5b06"), new Guid("df8494ba-f010-4a18-927b-f88b7f312d33"), null, "Нет" },
                    { new Guid("7f085d9a-64b0-4377-91dd-e0960572b777"), new Guid("8076da5d-67ab-4e12-bb76-02e23ae130bd"), null, "Изобретение" },
                    { new Guid("7ff900d2-f35c-4cce-b316-e75aaa0b9dd6"), new Guid("eea714ce-9d7c-4ffa-bb91-9ff10d0d569e"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("801395ff-b047-443b-8be4-32af234584fa"), new Guid("8076da5d-67ab-4e12-bb76-02e23ae130bd"), null, "Полезная модель" },
                    { new Guid("8454868f-6a98-4e04-a9fd-ecbbc893be0f"), new Guid("8076da5d-67ab-4e12-bb76-02e23ae130bd"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("85d41067-87eb-46a3-bdf4-bddd52ae9e99"), new Guid("eea714ce-9d7c-4ffa-bb91-9ff10d0d569e"), null, "Монография" },
                    { new Guid("8f640508-da51-47b4-aadc-2a7d20d4ab7d"), new Guid("e4c6f935-6649-4141-9aa9-b4838bcb29f1"), null, "Есть" },
                    { new Guid("93c512d4-9a12-41e2-98ee-b06b5c35071b"), new Guid("4b9f545e-3797-48ae-9878-b3be41aec242"), null, "Международный" },
                    { new Guid("a8da0cff-2f65-4d3f-bab4-7204f613f7f9"), new Guid("eea714ce-9d7c-4ffa-bb91-9ff10d0d569e"), null, "Учебник" },
                    { new Guid("ad7a7a92-2be2-4e23-9273-f1ffe3b41ecc"), new Guid("a896871f-7dca-42b6-b44a-a407e6cee720"), null, "Лабораторные" },
                    { new Guid("b29d32ae-a7ab-415c-a4f3-5695102c50a7"), new Guid("df8494ba-f010-4a18-927b-f88b7f312d33"), null, "Есть" },
                    { new Guid("c7bd018f-f123-4c60-be00-2bb7a0f81523"), new Guid("4b9f545e-3797-48ae-9878-b3be41aec242"), null, "Региональный" },
                    { new Guid("c993d6ae-59ed-4d4b-840c-7591ae220b97"), new Guid("8076da5d-67ab-4e12-bb76-02e23ae130bd"), null, "Промышленный образец" },
                    { new Guid("cdfa6026-94d6-4ab2-a62f-cd2d68ae1567"), new Guid("43932a5e-4ae4-49d9-b54e-21c92c78b20e"), null, "Изобретение" },
                    { new Guid("d3bc1c54-a6c3-4d67-9d1f-da5e58644a53"), new Guid("e7920855-69ec-49ed-b237-8110845015dc"), null, "Английский" },
                    { new Guid("d99d7ed0-f42c-4dd3-af5e-9d6eea9e151d"), new Guid("7c3fc0c1-5e0d-437a-9cf3-257de0d36156"), null, "Нет" },
                    { new Guid("dbe39909-1cb9-4c81-ac62-1a0257658557"), new Guid("95da8fcf-fc9d-47d2-a6e8-d78148d10c2c"), null, "Руководитель" },
                    { new Guid("ec869d87-780d-4461-9498-2668260da92c"), new Guid("b1f38bd3-4316-4960-a022-182ebbbfaeba"), null, "РИНЦ" }
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
