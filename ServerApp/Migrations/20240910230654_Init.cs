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
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Message = table.Column<string>(type: "text", nullable: true),
                    Checked = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
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
                    DateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
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
                    Number = table.Column<int>(type: "integer", nullable: true),
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
                    { new Guid("31b7f136-b6e9-4358-b3bd-1e8cd359acee"), 4, "Одобрена" },
                    { new Guid("69278ad8-3fca-47f9-9a96-e84751a662a3"), 5, "Отклонена" },
                    { new Guid("7036d9e1-98e3-47ae-8ede-a1b4ad297fa6"), 1, "В ожидании заполнения" },
                    { new Guid("90aa7566-91c3-43ee-9b4f-9adf5798a3b8"), 2, "В ожидании рассмотрения" },
                    { new Guid("a17750a1-c3e9-4524-8e20-d741348580a1"), 3, "В процессе рассмотрения" },
                    { new Guid("b302bffc-a0f9-4492-9ab6-681052f48063"), 6, "Оценена" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38bb985b-dec4-421a-b1f1-c04ae4741935", null, "Expert", "EXPERT" },
                    { "53b2d16b-1b99-4d9e-9e58-277bb3ab8b90", null, "Admin", "ADMIN" },
                    { "9f46b418-8d2f-4900-86b8-d0d39315a96f", null, "Voter", "VOTER" },
                    { "a2864396-d079-4ea5-979e-9e6064520825", null, "Organiser", "ORGANISER" },
                    { "b8929977-9b78-4c00-bee0-50fb55819d62", null, "Participant", "PARTICIPANT" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("4830978d-ceed-4a1e-a0f0-e96c5080ea98"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("f43eda36-1d98-4b6b-80c9-fd5b42d040f6"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), "Научно-исследовательская деятельность", 6 },
                    { new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), "Научно-педагогическая деятельность", 5 },
                    { new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"), "Категория участников", 2 },
                    { new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"), "Профессиональное развитие", 4 },
                    { new Guid("a64f3e23-e949-482b-9aff-ae583a47e248"), "Конкурсная работа", 3 },
                    { new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), "Общая информация", 1 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Checked", "Email", "Message", "Name" },
                values: new object[] { new Guid("1b1ff588-19c1-4b91-ba4b-63fbf593d5c6"), false, "system@system.ru", "Test Message for System", "SYSTEM" });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), "Образовательная деятельность", 2 },
                    { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), "Профессиональные показатели", 4 },
                    { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), "Конкурсная работа", 7 },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), "Методическая деятельность", 3 },
                    { new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5"), "Основной", 1 },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), "Инновационная и иная деятельность", 6 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0bc34fa1-c605-4c83-b091-fa54ba8794c5"), "bool" },
                    { new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026"), "int" },
                    { new Guid("547d8991-7e8d-4494-ae11-a52e16c49516"), "string" },
                    { new Guid("72ce5a0a-e60a-4bcf-b092-cb54124c8c75"), "TextArea" },
                    { new Guid("92c94a40-8fb7-4a6a-939c-034dcab0c559"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("a64f3e23-e949-482b-9aff-ae583a47e248"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("a64f3e23-e949-482b-9aff-ae583a47e248"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("1cab6d78-2a80-41e0-8ea3-2e1db7ee6e48"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("3b97e544-cba5-450b-957f-a80ff4a72365"), new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("4610a55e-968f-40b1-85e5-01448b968819"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("4faf17ee-3feb-454e-ad6b-d7ff4369ddc3"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("7fa13c92-a4ee-4c68-9702-f439e380a050"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("92c94a40-8fb7-4a6a-939c-034dcab0c559") },
                    { new Guid("84b047dd-251c-4652-9044-f5cb64bd1de9"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, true, true, "Место работы", 6, "Название организации", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("87c9a3d2-ee5d-4374-bb80-67b31e9afdae"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("9841de6b-7ed4-40a3-97f1-c82ac5466455"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("9e1e83cf-18a1-40eb-adac-49799e913d92"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("a28c4190-b0ad-445b-b967-05b943d9d536"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("b3be7eef-3aba-4b0c-8bdd-f6974999c02c"), new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("c34361b9-88b6-418a-ac1f-63d94e63d647"), new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("c38b35b5-1e66-42d1-bd84-9a589d79a407"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("c4d26f9e-117b-4bb8-ae87-f6bec5f1a591"), new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), new Guid("68a9bf61-462a-4bc4-8a5e-98a6090ecaba"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("d6a9f624-8610-4668-8ace-8eb455bdc924"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("e7b09488-1a82-4f45-a4fc-a1d96ac736af"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("ed5e778e-1c26-43fb-be9c-595cc97d5ea6"), new Guid("a99fe1ce-f7c1-48b7-9e8b-3255c7453936"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5"), new Guid("dfba9136-c2f7-42e8-b1b7-8fe50e44438e") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("db5cb70e-6825-460e-9ca6-9cf2ce83d13e") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("03578da2-2afc-45ff-88c8-e2e8b2a467af"), new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054"), new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d"), new Guid("a64f3e23-e949-482b-9aff-ae583a47e248"), true, true, "Краткая аннотация конкурсной работы", 1 },
                    { new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 },
                    { new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac"), new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), false, false, "Список научных публикаций за последние 5 лет", 10 },
                    { new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 },
                    { new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6"), new Guid("0ffb4600-b7d1-4d1b-ab22-23196617e437"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("b1beb533-0148-4fb4-8583-7404245bf510"), new Guid("41373ff4-c015-4291-b2cf-8159db79a202"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 },
                    { new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540"), new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e"), new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4"), new Guid("a42fe6c2-839c-4cae-9510-ed27779194c0"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("02a3c59e-ba61-4e30-b209-944ccbf285d5"), true, "Наличие грифа", 5, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("0bc34fa1-c605-4c83-b091-fa54ba8794c5") },
                    { new Guid("039c9e1d-0966-4b3d-ae0d-0effc327c9d1"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("b1beb533-0148-4fb4-8583-7404245bf510"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("03aa1578-1f5c-46f2-9dc8-1e54a0c36828"), true, "Практические занятия (час.)", 4, new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("06c278de-4473-4c93-9f70-df520bc830a7"), true, "Соавторы", 2, new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("0c2bc25c-cdbc-4335-965e-f388d1598472"), true, "Статус", 4, new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("0e3c6a41-d9be-465e-8f1c-db0103f86295"), true, "Лекции (час.)", 3, new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), true, "Значение", 2, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d"), new Guid("72ce5a0a-e60a-4bcf-b092-cb54124c8c75") },
                    { new Guid("2233e705-760b-4d9b-b524-c787175f8759"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, "Название", 1, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("2db5422d-aa7d-4384-a3c7-89c71191ba70"), true, "Издание, год", 4, new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("2f48f06f-2c40-42cc-b82b-f2e8cf92393f"), true, "Ссылка на открытый доступ", 8, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("33b64d67-f389-4a5b-9a56-315140599cc7"), true, "Вид", 2, new Guid("b1beb533-0148-4fb4-8583-7404245bf510"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("35420fd4-a385-42a1-9beb-40f97c2f122b"), false, "Тип идентификатора", 1, new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("3771cf04-09f3-4b58-abd2-f006512d234d"), true, "Название конкурса", 2, new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("3dad72e7-3926-4364-b78f-505ed37b9245"), true, "Название", 2, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("3e66e51c-9807-4936-b045-22ee478015ad"), true, "Вид", 1, new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("430b55f5-cd48-460e-bf02-d2ad1e37205f"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("445ec93c-8e61-42c9-b7a0-8f18e76b00c1"), true, "Название дисциплины", 1, new Guid("b1beb533-0148-4fb4-8583-7404245bf510"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("44633c93-f4ea-4bf8-9e83-3782545d0553"), true, "Год", 4, new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("4466f7ad-6b86-4958-a3db-23618fe55530"), true, "Название", 2, new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("494d86fb-bada-45ab-9a1f-ae5013d01961"), true, "Итого (час.)", 5, new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("4c5cabc9-0c61-46e8-9724-583437de8bfc"), true, "Название курса", 1, new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("512fde20-307e-469e-b265-4f95375c0c1f"), true, "Название организации в которую внедрена разработка", 3, new Guid("03578da2-2afc-45ff-88c8-e2e8b2a467af"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("5e357a82-4986-407f-a18a-8cf61361932f"), true, "Название разработки", 2, new Guid("03578da2-2afc-45ff-88c8-e2e8b2a467af"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("686f349f-1c78-4f96-9339-788998b4f476"), true, "Ссылка на платформу", 3, new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("6cf36b5a-7e73-4b38-87e9-48879651a120"), true, "Ссылка", 5, new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("78241748-438d-4f86-a5a1-774d3922a3a5"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("7a06ca6e-240e-49fc-887f-f1102224fc6e"), true, "Вид публикации", 1, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("83c9a1f6-af24-47f6-83ce-4dc2af45600a"), true, "Название документа, реквизиты", 1, new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("96473636-564b-4eb8-89aa-73ae2bb19da1"), true, "Название статьи", 1, new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("9667f004-f7c7-4080-b1ad-83cc98d7d31f"), false, "Идентификатор", 2, new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("991c0655-0666-494b-9845-110b902a263f"), false, "Соавторы", 3, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("9e4a9a78-27ca-4f6f-a69d-868c35513c84"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("9e90dc00-6ab6-48c1-a973-eaa812a17771"), true, "ФИО соавторов", 3, new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("9fe89c8c-5250-4a53-93c3-f8c793dfbb60"), true, "Название конкурса/премии", 2, new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("a0108ea0-41ca-4d06-b69e-0d42e6df1543"), true, "Год", 1, new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("a12cdc8d-783e-43f5-a845-3793342fe4f1"), true, "Количество печатных листов", 4, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("a33f9c70-a883-4ab7-ae28-3256a581954b"), true, "Издательство, год", 6, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("aa6deed9-1744-46ae-ae6c-75150c98b331"), true, "Период выполнения", 3, new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("b12cae10-eabe-4685-92ca-9aa0ff464bdd"), true, "Год", 3, new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("b30f3b2b-7eef-47b4-9812-826aac2ef167"), true, "Год получения документа", 2, new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540"), new Guid("294122c9-6bca-4985-9ffe-f11eb77b8026") },
                    { new Guid("b649879d-b81b-464b-9940-5aa5bcf0b268"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("b6c32f6e-79d6-4cf9-a8b6-7ea3d61455b1"), true, "ФИО", 1, new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("c298d248-3c2b-4f9e-b5bd-aa229720b375"), true, "Вид", 1, new Guid("03578da2-2afc-45ff-88c8-e2e8b2a467af"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("c7b39b02-e13a-4833-8618-7556f7957f03"), true, "Название НИР/НИОКР", 1, new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("cc15dcb4-5577-4377-b9fd-57134f0cc2c1"), true, "Наименование курса", 1, new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("d7df1ff7-2428-49cc-8c22-6267f451f1cc"), true, "Язык преподавания", 2, new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("de74d92d-666d-4b5d-80a8-bf29df326bcc"), true, "Соавторы", 2, new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("eba0c1fa-d397-495d-82f8-4f004e33b4ab"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("ec6c6816-24f3-4ff7-ad8f-22ce736c0caf"), true, "Статус конкурса", 3, new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("edfc1a70-c91f-4cab-bc29-26c0f4dd6c8e"), true, "Язык публикации", 7, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") },
                    { new Guid("f7cc557f-1d7a-42ec-8857-4b7539e8458b"), true, "Номер РИД", 4, new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6"), new Guid("547d8991-7e8d-4494-ae11-a52e16c49516") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("1cab6d78-2a80-41e0-8ea3-2e1db7ee6e48"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("3b97e544-cba5-450b-957f-a80ff4a72365"), new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283") },
                    { new Guid("4610a55e-968f-40b1-85e5-01448b968819"), new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0") },
                    { new Guid("4faf17ee-3feb-454e-ad6b-d7ff4369ddc3"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("7fa13c92-a4ee-4c68-9702-f439e380a050"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("84b047dd-251c-4652-9044-f5cb64bd1de9"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("87c9a3d2-ee5d-4374-bb80-67b31e9afdae"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("9841de6b-7ed4-40a3-97f1-c82ac5466455"), new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0") },
                    { new Guid("9e1e83cf-18a1-40eb-adac-49799e913d92"), new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0") },
                    { new Guid("a28c4190-b0ad-445b-b967-05b943d9d536"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("b3be7eef-3aba-4b0c-8bdd-f6974999c02c"), new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283") },
                    { new Guid("c34361b9-88b6-418a-ac1f-63d94e63d647"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("c38b35b5-1e66-42d1-bd84-9a589d79a407"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("c4d26f9e-117b-4bb8-ae87-f6bec5f1a591"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f") },
                    { new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283") },
                    { new Guid("d6a9f624-8610-4668-8ace-8eb455bdc924"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("e7b09488-1a82-4f45-a4fc-a1d96ac736af"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") },
                    { new Guid("ed5e778e-1c26-43fb-be9c-595cc97d5ea6"), new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510") },
                    { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540") },
                    { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4") },
                    { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("5b946941-2de7-41d0-80c0-956c98109d5b") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("b1beb533-0148-4fb4-8583-7404245bf510") },
                    { new Guid("818e2f06-fb7e-409a-9c00-720baa993fa5"), new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4") },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("03578da2-2afc-45ff-88c8-e2e8b2a467af") },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6") },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0c1d163a-c4f3-4f3a-b332-b31a7d450c56"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("cf76f83b-a796-47f5-84a0-b8b7e8c21540") },
                    { new Guid("119bc69d-6943-4f3a-82aa-dad403bd1cfe"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9") },
                    { new Guid("18c164c9-4a97-49e6-bf43-c1c4dde7c5e4"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("31805c88-e5d5-4206-95e9-77e3323ce315"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("1e4e4f93-93b6-4e25-b4da-344df5b078c9") },
                    { new Guid("3a735671-f0b5-454c-a686-bbcc1bf90caf"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b") },
                    { new Guid("484a0ea6-1c6e-4ce6-9394-d31cee4be3c0"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054") },
                    { new Guid("54591336-9dd6-4cd2-8ae8-d5aa61bfa0fb"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("8dffba7c-04a0-4107-ba1f-732a107b7510") },
                    { new Guid("547916f4-a0eb-478a-8d11-997adb500129"), "EvaluateMark19", new Guid("b3be7eef-3aba-4b0c-8bdd-f6974999c02c"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("5c2f0af9-4062-4a20-8c08-78694d421f4d"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("03578da2-2afc-45ff-88c8-e2e8b2a467af") },
                    { new Guid("5c9159e7-8856-45b9-9831-295ff470140f"), "EvaluateMark13", new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("66a8770c-7c68-4e96-b821-da55102598e9"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("92c849cc-df6a-4bcd-950b-ef3d1b6c67e6") },
                    { new Guid("8077572e-3e83-4e14-84ab-0082f43e308e"), "EvaluateMark20", new Guid("3b97e544-cba5-450b-957f-a80ff4a72365"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("879d05e5-0be1-4631-a9b0-04a84ae1dc54"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("fa83a3d2-3800-48ff-8c05-d1a569e320f4") },
                    { new Guid("a2d4a97f-ee90-4167-9162-ef8aff3f34ac"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("b1beb533-0148-4fb4-8583-7404245bf510") },
                    { new Guid("a3095d58-bc65-4b73-98f0-f938f990557e"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("11eb8b28-57a0-4de4-8fc0-ff7177d11054") },
                    { new Guid("ad730fe6-d0ae-4dfb-a73f-d448aa062c37"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом или на иностранном языке в соавторстве:", 9, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b") },
                    { new Guid("b697fae5-e4b9-491a-97ec-c952dff212c0"), "EvaluateMark4", new Guid("9e1e83cf-18a1-40eb-adac-49799e913d92"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("c11c58a4-9919-4fb5-aad6-4e997e21b5e0"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("c18bac77-3759-40f8-84e6-148d172a4a78"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("826478d2-6f91-4665-b8ea-7d3355ba4a0a") },
                    { new Guid("c334e415-32d3-4d8a-9890-2109aacedb9a"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("7456f2ac-5acc-46df-86dc-376b1c626cac") },
                    { new Guid("cc23f918-3108-4b54-8f6a-e57565899a10"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом или на иностранном языке и без соавторства:", 8, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b") },
                    { new Guid("cef4c968-643e-45d5-a29d-77601f00a506"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("5b946941-2de7-41d0-80c0-956c98109d5b") },
                    { new Guid("d340ce13-534b-491a-ae2b-bc70acf5bd8d"), "EvaluateMark5", new Guid("9841de6b-7ed4-40a3-97f1-c82ac5466455"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("eb7353cc-da32-4af4-8300-f6e03380296e"), "EvaluateMark3", new Guid("4610a55e-968f-40b1-85e5-01448b968819"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("10a4402f-d8c7-40f7-a144-a771f110ac29"), true, 8, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("2e6fccfa-4f1a-4caa-9c33-6245363ce29e"), true, 1, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("4c16cbe2-e625-4d6b-8c13-8201325a050a"), true, 5, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("5ecec201-29f5-4bd6-a393-e9cdd95772a0"), true, 4, new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e") },
                    { new Guid("62509994-6766-4407-a138-0b40a66fb27f"), true, 3, new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e") },
                    { new Guid("6349177a-7fb6-4dbf-97f0-7313f27c6589"), true, 5, new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e") },
                    { new Guid("6a8951a2-7160-43ad-8799-7b50a861731e"), true, 4, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("7ef0269d-4a15-49a7-b9ae-2d4518844493"), true, 7, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("91ae8af9-3497-4328-b7fa-b79764ecd7b9"), true, 3, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("b05f4e34-ee05-4330-9e4a-eba522945135"), true, 2, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("b407f75b-1ce1-4faa-9aac-477f4be49a3b"), true, 6, new Guid("16f8ee35-c178-494a-b82a-8f3f9fa9025d") },
                    { new Guid("b97ba8b2-64ee-4c90-8572-e15aad8972f2"), true, 2, new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e") },
                    { new Guid("ddb077e2-34e8-4bdc-a6e8-643c30e913a4"), true, 1, new Guid("db3ce028-13b3-405c-a7ff-a3f9b7e01e5e") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0891316c-66ae-414b-b4e1-f3a487c3dfa1"), null, new Guid("c4d26f9e-117b-4bb8-ae87-f6bec5f1a591"), "Кандидат наук" },
                    { new Guid("332c747d-f942-4370-808b-7c050696a9db"), null, new Guid("c4d26f9e-117b-4bb8-ae87-f6bec5f1a591"), "Доктор наук" },
                    { new Guid("430886ca-10c4-477c-92fb-d57c1cc56e90"), null, new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), "Доцент" },
                    { new Guid("59517b42-a706-4b75-89ff-4806a49da2c3"), null, new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), "Профессор" },
                    { new Guid("eb5c72ff-054b-4fef-92e2-942c24772963"), null, new Guid("c5852f2f-bff6-41d5-8c37-e9d8f7d185c6"), "Нет" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("0176aeb5-4d1c-42a2-bfb7-197d7514ad36"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("b407f75b-1ce1-4faa-9aac-477f4be49a3b"), "Апробация" },
                    { new Guid("07216cd6-685d-4448-8dc4-bcb35eb4c57c"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("2e6fccfa-4f1a-4caa-9c33-6245363ce29e"), null },
                    { new Guid("0dd08024-cbeb-4147-b800-1d042386da4a"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("b407f75b-1ce1-4faa-9aac-477f4be49a3b"), null },
                    { new Guid("0e2e0f54-a00e-46ba-a05d-470d38670d8a"), null, new Guid("35420fd4-a385-42a1-9beb-40f97c2f122b"), true, true, new Guid("ddb077e2-34e8-4bdc-a6e8-643c30e913a4"), "ScopusID" },
                    { new Guid("19801b4e-ab6b-4324-9588-2b3663f0e560"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("91ae8af9-3497-4328-b7fa-b79764ecd7b9"), "Инновационность" },
                    { new Guid("2478c504-8204-4494-a47e-794ce0bdf742"), null, new Guid("9667f004-f7c7-4080-b1ad-83cc98d7d31f"), false, true, new Guid("6349177a-7fb6-4dbf-97f0-7313f27c6589"), null },
                    { new Guid("253e3ba0-b2ed-4927-8059-336414947acb"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("6a8951a2-7160-43ad-8799-7b50a861731e"), null },
                    { new Guid("32af5b34-9576-49cb-bf3d-8c552e04d7cf"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("6a8951a2-7160-43ad-8799-7b50a861731e"), "Методология и методы, используемые в работе" },
                    { new Guid("3adc02a3-dfec-4282-842a-94dbb4cd6b09"), null, new Guid("35420fd4-a385-42a1-9beb-40f97c2f122b"), true, true, new Guid("6349177a-7fb6-4dbf-97f0-7313f27c6589"), "Google Scholar ID" },
                    { new Guid("55001ba0-3bcf-4736-8986-72df37163487"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("7ef0269d-4a15-49a7-b9ae-2d4518844493"), null },
                    { new Guid("64e1fbe0-a821-42b1-b5dd-72e1762e8f4d"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("4c16cbe2-e625-4d6b-8c13-8201325a050a"), "Ссылка на конкурсную работу" },
                    { new Guid("66e53646-d39d-484c-a2ef-72dbf86df729"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("7ef0269d-4a15-49a7-b9ae-2d4518844493"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("7f60b3a3-ff50-4b60-8b71-906e12ead667"), null, new Guid("9667f004-f7c7-4080-b1ad-83cc98d7d31f"), false, true, new Guid("ddb077e2-34e8-4bdc-a6e8-643c30e913a4"), null },
                    { new Guid("85cc5213-6ddb-4142-a2ed-7557728e35e9"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("2e6fccfa-4f1a-4caa-9c33-6245363ce29e"), "Название работы" },
                    { new Guid("8748b7c5-c781-49ae-b4fc-35937e90bcc2"), null, new Guid("9667f004-f7c7-4080-b1ad-83cc98d7d31f"), false, true, new Guid("62509994-6766-4407-a138-0b40a66fb27f"), null },
                    { new Guid("8be7aba7-5bbc-4230-a7e2-bb191751bf57"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("b05f4e34-ee05-4330-9e4a-eba522945135"), "Актуальность конкурсной работы" },
                    { new Guid("93edd7cd-1aca-4163-8830-5689d0231d23"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("91ae8af9-3497-4328-b7fa-b79764ecd7b9"), null },
                    { new Guid("b93e16c2-1aef-466b-ade2-49a834f84cdb"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("4c16cbe2-e625-4d6b-8c13-8201325a050a"), null },
                    { new Guid("bca1a84a-836b-4f53-be6a-241f63dcef14"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("b05f4e34-ee05-4330-9e4a-eba522945135"), null },
                    { new Guid("bead9c52-6dfa-4e0a-aeb6-0c2b67bed25e"), null, new Guid("35420fd4-a385-42a1-9beb-40f97c2f122b"), true, true, new Guid("62509994-6766-4407-a138-0b40a66fb27f"), "ResearcherID" },
                    { new Guid("cb9a999d-d604-49ee-8661-8fb0ecddb96d"), null, new Guid("246d20f9-8a3e-40b9-ba7a-784eda5755c3"), true, true, new Guid("10a4402f-d8c7-40f7-a144-a771f110ac29"), "Результаты и выводы" },
                    { new Guid("cdadec0b-ea18-4a0b-91f3-c79fc36011e5"), null, new Guid("35420fd4-a385-42a1-9beb-40f97c2f122b"), true, true, new Guid("b97ba8b2-64ee-4c90-8572-e15aad8972f2"), "ORCiD" },
                    { new Guid("d4189538-8f1a-4718-8a80-3492a42d55e7"), null, new Guid("181ce287-eb4f-4fe1-87ce-38103f25df26"), false, true, new Guid("10a4402f-d8c7-40f7-a144-a771f110ac29"), null },
                    { new Guid("de72d846-01d1-4608-ade5-a9110b76a99b"), null, new Guid("9667f004-f7c7-4080-b1ad-83cc98d7d31f"), false, true, new Guid("b97ba8b2-64ee-4c90-8572-e15aad8972f2"), null },
                    { new Guid("ed10c5a5-ee9c-4d4f-9861-43b0f29acb92"), null, new Guid("9667f004-f7c7-4080-b1ad-83cc98d7d31f"), false, true, new Guid("5ecec201-29f5-4bd6-a393-e9cdd95772a0"), null },
                    { new Guid("ef82e49f-8ab5-4e38-856c-f8f7d99b1c09"), null, new Guid("35420fd4-a385-42a1-9beb-40f97c2f122b"), true, true, new Guid("5ecec201-29f5-4bd6-a393-e9cdd95772a0"), "РИНЦ AuthorID" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("119bc69d-6943-4f3a-82aa-dad403bd1cfe") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("31805c88-e5d5-4206-95e9-77e3323ce315") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("54591336-9dd6-4cd2-8ae8-d5aa61bfa0fb") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("b697fae5-e4b9-491a-97ec-c952dff212c0") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("c18bac77-3759-40f8-84e6-148d172a4a78") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("d340ce13-534b-491a-ae2b-bc70acf5bd8d") },
                    { new Guid("067de697-280e-42cd-a2fc-ae05a4d7d2e0"), new Guid("eb7353cc-da32-4af4-8300-f6e03380296e") },
                    { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("0c1d163a-c4f3-4f3a-b332-b31a7d450c56") },
                    { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("5c9159e7-8856-45b9-9831-295ff470140f") },
                    { new Guid("26d698d1-645e-44fa-9446-21ded9d40b9f"), new Guid("879d05e5-0be1-4631-a9b0-04a84ae1dc54") },
                    { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("18c164c9-4a97-49e6-bf43-c1c4dde7c5e4") },
                    { new Guid("2a64e128-61fc-4cc5-a3eb-89abc7062e9f"), new Guid("c11c58a4-9919-4fb5-aad6-4e997e21b5e0") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("3a735671-f0b5-454c-a686-bbcc1bf90caf") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("a2d4a97f-ee90-4167-9162-ef8aff3f34ac") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("ad730fe6-d0ae-4dfb-a73f-d448aa062c37") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("cc23f918-3108-4b54-8f6a-e57565899a10") },
                    { new Guid("319cccfc-e6b9-4c4c-8729-75cdb1557360"), new Guid("cef4c968-643e-45d5-a29d-77601f00a506") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("484a0ea6-1c6e-4ce6-9394-d31cee4be3c0") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("547916f4-a0eb-478a-8d11-997adb500129") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("5c9159e7-8856-45b9-9831-295ff470140f") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("8077572e-3e83-4e14-84ab-0082f43e308e") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("879d05e5-0be1-4631-a9b0-04a84ae1dc54") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("a3095d58-bc65-4b73-98f0-f938f990557e") },
                    { new Guid("ea2eed56-a68a-4078-8bfd-39f151e17283"), new Guid("c334e415-32d3-4d8a-9890-2109aacedb9a") },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("0c1d163a-c4f3-4f3a-b332-b31a7d450c56") },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("5c2f0af9-4062-4a20-8c08-78694d421f4d") },
                    { new Guid("f89f2d0a-f8fc-48ac-a2eb-1b1bcd6a7c0f"), new Guid("66a8770c-7c68-4e96-b821-da55102598e9") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("08266c95-0a6f-4bcc-a8d4-2fd6305d1e04"), new Guid("de74d92d-666d-4b5d-80a8-bf29df326bcc"), null, "Нет" },
                    { new Guid("0996444a-1835-40e2-9c25-2cd6544c2054"), new Guid("0c2bc25c-cdbc-4335-965e-f388d1598472"), null, "Исполнитель" },
                    { new Guid("0e0168f4-2073-45c5-bbb1-e45236ed9ea6"), new Guid("02a3c59e-ba61-4e30-b209-944ccbf285d5"), null, "Нет" },
                    { new Guid("11916bb7-d803-4f9e-8129-c7d37b1e1169"), new Guid("edfc1a70-c91f-4cab-bc29-26c0f4dd6c8e"), null, "Русский" },
                    { new Guid("14d115ec-cf3c-4ace-98e9-82547abd950f"), new Guid("3e66e51c-9807-4936-b045-22ee478015ad"), null, "Промышленный образец" },
                    { new Guid("1f27b159-f20a-4958-a1c4-021d2d5b8d62"), new Guid("d7df1ff7-2428-49cc-8c22-6267f451f1cc"), null, "Английский" },
                    { new Guid("28fdbb34-cd1f-4ac8-a04e-ee2e66c787b0"), new Guid("3e66e51c-9807-4936-b045-22ee478015ad"), null, "Изобретение" },
                    { new Guid("2d346421-c6f9-4641-b197-af718a046d6c"), new Guid("02a3c59e-ba61-4e30-b209-944ccbf285d5"), null, "Есть" },
                    { new Guid("2def3639-84d1-4c25-ac38-207c734a4762"), new Guid("7a06ca6e-240e-49fc-887f-f1102224fc6e"), null, "Учебник" },
                    { new Guid("3555b073-eb5a-41d9-be24-bf67cc04e86a"), new Guid("ec6c6816-24f3-4ff7-ad8f-22ce736c0caf"), null, "Всероссийский" },
                    { new Guid("3bbd75c1-516d-43c1-ad3b-34843d044d42"), new Guid("2233e705-760b-4d9b-b524-c787175f8759"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("437af78f-5d2e-4dfe-9d4e-831154fe9587"), new Guid("3e66e51c-9807-4936-b045-22ee478015ad"), null, "Полезная модель" },
                    { new Guid("43f297fb-d46e-4478-aa6d-5aae190765b8"), new Guid("0c2bc25c-cdbc-4335-965e-f388d1598472"), null, "Руководитель" },
                    { new Guid("6365520b-034c-45b6-bfbd-669a892c64e6"), new Guid("edfc1a70-c91f-4cab-bc29-26c0f4dd6c8e"), null, "Иностранный" },
                    { new Guid("64ca4b1b-94b4-487b-b196-6048c31efec9"), new Guid("de74d92d-666d-4b5d-80a8-bf29df326bcc"), null, "Есть" },
                    { new Guid("6c34cccc-f313-4670-9118-b6fbbbc62ac7"), new Guid("991c0655-0666-494b-9845-110b902a263f"), null, "Есть" },
                    { new Guid("6d8c95ba-bd68-48ae-927f-3336b9418f98"), new Guid("33b64d67-f389-4a5b-9a56-315140599cc7"), null, "Лабораторные" },
                    { new Guid("73f52e65-44bb-4c94-bc99-3aec8416c382"), new Guid("ec6c6816-24f3-4ff7-ad8f-22ce736c0caf"), null, "Региональный" },
                    { new Guid("740c0e7f-c176-43fd-8b71-85e7535fe287"), new Guid("d7df1ff7-2428-49cc-8c22-6267f451f1cc"), null, "Другой" },
                    { new Guid("75aa2163-a82d-4c99-8036-a4903c547021"), new Guid("2233e705-760b-4d9b-b524-c787175f8759"), null, "МБД (Q3-Q4)" },
                    { new Guid("832a2501-853f-474a-af2a-199d2feef15d"), new Guid("33b64d67-f389-4a5b-9a56-315140599cc7"), null, "Лекции" },
                    { new Guid("92818018-653b-4d10-be50-d07cc73d350b"), new Guid("3e66e51c-9807-4936-b045-22ee478015ad"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("9905e288-6700-421b-a9e7-211cb2385a58"), new Guid("991c0655-0666-494b-9845-110b902a263f"), null, "Нет" },
                    { new Guid("a6561831-8075-40b6-b35a-b74782f9e47c"), new Guid("2233e705-760b-4d9b-b524-c787175f8759"), null, "РИНЦ" },
                    { new Guid("af88f202-d981-4877-8fa5-61d8e3c37226"), new Guid("c298d248-3c2b-4f9e-b5bd-aa229720b375"), null, "Полезная модель" },
                    { new Guid("b06a8d46-4d50-428d-a21c-d5b6a46579bf"), new Guid("c298d248-3c2b-4f9e-b5bd-aa229720b375"), null, "Изобретение" },
                    { new Guid("cb0b7a46-b570-453e-bd99-58b662f7754c"), new Guid("c298d248-3c2b-4f9e-b5bd-aa229720b375"), null, "Промышленный образец" },
                    { new Guid("d8ce7f74-1481-4d63-97a1-08a697dfa986"), new Guid("c298d248-3c2b-4f9e-b5bd-aa229720b375"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("daf8c602-f0cd-4b8e-b2b3-42771a743d96"), new Guid("7a06ca6e-240e-49fc-887f-f1102224fc6e"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("db02d5d4-9e93-4c5b-ba74-cabb7063e1a1"), new Guid("2233e705-760b-4d9b-b524-c787175f8759"), null, "ВАК (К2-К3)" },
                    { new Guid("ddb2e30f-73fe-49d3-b417-4fbdfa817dee"), new Guid("ec6c6816-24f3-4ff7-ad8f-22ce736c0caf"), null, "Международный" },
                    { new Guid("e101723b-83f3-4bb5-b4f7-db39af6c206d"), new Guid("06c278de-4473-4c93-9f70-df520bc830a7"), null, "Нет" },
                    { new Guid("eb541076-5000-4850-af0a-1ca3e4405179"), new Guid("d7df1ff7-2428-49cc-8c22-6267f451f1cc"), null, "Русский" },
                    { new Guid("ee463f6e-14a2-4d41-accb-4b9d09bb32c6"), new Guid("06c278de-4473-4c93-9f70-df520bc830a7"), null, "Есть" },
                    { new Guid("f8a026bf-a239-4ba3-ade2-2bb64b681fda"), new Guid("7a06ca6e-240e-49fc-887f-f1102224fc6e"), null, "Монография" }
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
                name: "Feedbacks");

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
