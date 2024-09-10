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
                    { new Guid("0a594e7a-323e-400a-926e-d7757d060c08"), 2, "В ожидании рассмотрения" },
                    { new Guid("27d0bd9f-3bd6-4bd7-987a-666b50d11c37"), 6, "Оценена" },
                    { new Guid("5891a0a8-1bb6-4553-a383-8c751bfa2b3b"), 1, "В ожидании заполнения" },
                    { new Guid("889e79aa-a4f0-43e2-9dc3-6a3d401a7ed2"), 5, "Отклонена" },
                    { new Guid("fc50830d-1552-46b1-8974-b06de848a9c5"), 4, "Одобрена" },
                    { new Guid("fe5cb1b7-d6a1-418b-996e-71308c7ad4f1"), 3, "В процессе рассмотрения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05463486-141f-429c-adde-19cd5f2fd77d", null, "Admin", "ADMIN" },
                    { "0fd12a8f-62a1-401e-a956-4dc5e494ed5c", null, "Organiser", "ORGANISER" },
                    { "9343c7c9-f47d-4474-b6ab-06a7c0b878c7", null, "Expert", "EXPERT" },
                    { "982db910-7726-4fd1-82ba-92c74b1f8dc7", null, "Participant", "PARTICIPANT" },
                    { "b92c51ee-f4c7-48e6-acde-cc720660ccd2", null, "Voter", "VOTER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("7a97a2e4-2085-423f-8bb6-4f074191407d"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("f6cc7cb6-c93a-436c-80f0-0bee296a5de8"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0373365f-4c9c-4ec4-af74-30f2f3f21352"), "Научно-педагогическая деятельность", 5 },
                    { new Guid("1dd2f109-23fe-485d-82fc-a00eabf6cddc"), "Профессиональное развитие", 4 },
                    { new Guid("4d3d5db6-8a9d-41a0-8a5f-443692887c20"), "Научно-исследовательская деятельность", 6 },
                    { new Guid("88e554fc-fe72-407c-9e00-a9e12ef69c42"), "Общая информация", 1 },
                    { new Guid("d26e96a1-7240-4b9a-a3f7-ae41e46d4de4"), "Конкурсная работа", 3 },
                    { new Guid("d6bbb9f8-eaa0-4864-a63e-537e768d0de1"), "Категория участников", 2 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Checked", "Email", "Message", "Name" },
                values: new object[] { new Guid("0f311045-c4a3-4d13-8b42-959c993b6dee"), false, "system@system.ru", "Test Message for System", "SYSTEM" });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("25d776b7-c234-47b0-b6f0-4be21cbb9090"), "Конкурсная работа", 7 },
                    { new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02"), "Основной", 1 },
                    { new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5"), "Образовательная деятельность", 2 },
                    { new Guid("66a0c11e-c5e8-40cc-b949-42318c941a48"), "Методическая деятельность", 3 },
                    { new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("b5501e38-02f1-42b6-b08d-77de067b62f1"), "Инновационная и иная деятельность", 6 },
                    { new Guid("b838beca-82bb-4f44-bdb4-4b1dee5d0889"), "Профессиональные показатели", 4 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("45139b37-9ccc-45e8-b716-1a88ace5b738"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("75d8269a-2b42-427e-96c5-6e2841ed333b"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052"), "int" },
                    { new Guid("1d751442-b53d-418d-b332-17966e54a79f"), "TextArea" },
                    { new Guid("977dc65d-1eef-4844-afbf-8c93a46a9c51"), "bool" },
                    { new Guid("ba18eee0-5b0d-4ef9-b1bb-7d3f2d6f4e61"), "DateTime" },
                    { new Guid("fec31d8a-1857-40bc-b548-f0341398fe80"), "string" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0373365f-4c9c-4ec4-af74-30f2f3f21352"), new Guid("45139b37-9ccc-45e8-b716-1a88ace5b738") },
                    { new Guid("1dd2f109-23fe-485d-82fc-a00eabf6cddc"), new Guid("45139b37-9ccc-45e8-b716-1a88ace5b738") },
                    { new Guid("1dd2f109-23fe-485d-82fc-a00eabf6cddc"), new Guid("75d8269a-2b42-427e-96c5-6e2841ed333b") },
                    { new Guid("4d3d5db6-8a9d-41a0-8a5f-443692887c20"), new Guid("75d8269a-2b42-427e-96c5-6e2841ed333b") },
                    { new Guid("88e554fc-fe72-407c-9e00-a9e12ef69c42"), new Guid("45139b37-9ccc-45e8-b716-1a88ace5b738") },
                    { new Guid("88e554fc-fe72-407c-9e00-a9e12ef69c42"), new Guid("75d8269a-2b42-427e-96c5-6e2841ed333b") },
                    { new Guid("d26e96a1-7240-4b9a-a3f7-ae41e46d4de4"), new Guid("45139b37-9ccc-45e8-b716-1a88ace5b738") },
                    { new Guid("d26e96a1-7240-4b9a-a3f7-ae41e46d4de4"), new Guid("75d8269a-2b42-427e-96c5-6e2841ed333b") },
                    { new Guid("d6bbb9f8-eaa0-4864-a63e-537e768d0de1"), new Guid("45139b37-9ccc-45e8-b716-1a88ace5b738") },
                    { new Guid("d6bbb9f8-eaa0-4864-a63e-537e768d0de1"), new Guid("75d8269a-2b42-427e-96c5-6e2841ed333b") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("00c065db-2298-4290-a3ff-518a7f2f7664"), new Guid("d6bbb9f8-eaa0-4864-a63e-537e768d0de1"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("02c6bb6e-1c1f-4e33-a0db-2ca3af27343e"), new Guid("4d3d5db6-8a9d-41a0-8a5f-443692887c20"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("0d16c3af-3d39-4359-8b6e-4921b19d583e"), new Guid("88e554fc-fe72-407c-9e00-a9e12ef69c42"), null, true, true, "Место работы", 6, "Название организации", new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("2b96aa3d-d9f7-4d27-b6aa-6db2e7a7e694"), new Guid("0373365f-4c9c-4ec4-af74-30f2f3f21352"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("3be36319-913a-4811-bbd1-a80cc827d8ff"), new Guid("88e554fc-fe72-407c-9e00-a9e12ef69c42"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("3d02a5ad-07b6-46cf-b255-a3eba36fac81"), new Guid("88e554fc-fe72-407c-9e00-a9e12ef69c42"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("406f1feb-3ee0-4faa-a9c5-2c27616fd3ab"), new Guid("88e554fc-fe72-407c-9e00-a9e12ef69c42"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("ba18eee0-5b0d-4ef9-b1bb-7d3f2d6f4e61") },
                    { new Guid("49f2b53f-a843-4f2b-8b08-9d92897c1a6d"), new Guid("88e554fc-fe72-407c-9e00-a9e12ef69c42"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("5550cbd5-8666-431a-ac64-9ad0d02637cf"), new Guid("88e554fc-fe72-407c-9e00-a9e12ef69c42"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("56b8b971-c96f-41f3-acbb-dd55a8d6747b"), new Guid("0373365f-4c9c-4ec4-af74-30f2f3f21352"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("57a1953c-aa17-4f07-9e60-4d671ca883fa"), new Guid("d6bbb9f8-eaa0-4864-a63e-537e768d0de1"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("73f6a5cf-a4f2-4559-b2d6-1a4689105f9b"), new Guid("4d3d5db6-8a9d-41a0-8a5f-443692887c20"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("815d7569-db76-459d-9ec6-f710394a9850"), new Guid("88e554fc-fe72-407c-9e00-a9e12ef69c42"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("9afb914a-bfe2-4949-a33c-b3b449e57063"), new Guid("88e554fc-fe72-407c-9e00-a9e12ef69c42"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("a78f1d7c-0658-4be6-9fe0-007f7cc5b735"), new Guid("d6bbb9f8-eaa0-4864-a63e-537e768d0de1"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("b0d1f39c-9621-4896-8495-d6c479697256"), new Guid("88e554fc-fe72-407c-9e00-a9e12ef69c42"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("b1105017-6764-4c89-82ae-39e55721ed15"), new Guid("88e554fc-fe72-407c-9e00-a9e12ef69c42"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("fa16d661-a3a6-49c2-8e7b-a064ad1bb8fd"), new Guid("0373365f-4c9c-4ec4-af74-30f2f3f21352"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("25d776b7-c234-47b0-b6f0-4be21cbb9090"), new Guid("45139b37-9ccc-45e8-b716-1a88ace5b738") },
                    { new Guid("25d776b7-c234-47b0-b6f0-4be21cbb9090"), new Guid("75d8269a-2b42-427e-96c5-6e2841ed333b") },
                    { new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02"), new Guid("45139b37-9ccc-45e8-b716-1a88ace5b738") },
                    { new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02"), new Guid("75d8269a-2b42-427e-96c5-6e2841ed333b") },
                    { new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5"), new Guid("45139b37-9ccc-45e8-b716-1a88ace5b738") },
                    { new Guid("66a0c11e-c5e8-40cc-b949-42318c941a48"), new Guid("45139b37-9ccc-45e8-b716-1a88ace5b738") },
                    { new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58"), new Guid("75d8269a-2b42-427e-96c5-6e2841ed333b") },
                    { new Guid("b5501e38-02f1-42b6-b08d-77de067b62f1"), new Guid("75d8269a-2b42-427e-96c5-6e2841ed333b") },
                    { new Guid("b838beca-82bb-4f44-bdb4-4b1dee5d0889"), new Guid("45139b37-9ccc-45e8-b716-1a88ace5b738") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("35a6b994-c057-4213-8f68-93edf54d786b"), new Guid("0373365f-4c9c-4ec4-af74-30f2f3f21352"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 },
                    { new Guid("4bf9c880-345c-48b5-b431-9fc241126381"), new Guid("4d3d5db6-8a9d-41a0-8a5f-443692887c20"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("5999e323-16e7-4ef5-9735-c95535fd43ba"), new Guid("1dd2f109-23fe-485d-82fc-a00eabf6cddc"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("62da8c12-4843-4869-9a80-b55cee49785e"), new Guid("d26e96a1-7240-4b9a-a3f7-ae41e46d4de4"), true, true, "Краткая аннотация конкурсной работы", 1 },
                    { new Guid("7b820576-4b39-4ea2-b83e-10fdb7a272a6"), new Guid("1dd2f109-23fe-485d-82fc-a00eabf6cddc"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 },
                    { new Guid("8ecfe285-fd56-4724-8217-0fb39583db81"), new Guid("0373365f-4c9c-4ec4-af74-30f2f3f21352"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 },
                    { new Guid("9d593bee-5c5c-4338-9f2c-6c13ee10e242"), new Guid("4d3d5db6-8a9d-41a0-8a5f-443692887c20"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("a01be511-409e-4ea0-91cd-b74ee07032b8"), new Guid("1dd2f109-23fe-485d-82fc-a00eabf6cddc"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("a664c290-78bc-4a89-917f-4503f7523052"), new Guid("0373365f-4c9c-4ec4-af74-30f2f3f21352"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("b555ff0b-11ba-4d36-89db-b17389bc3064"), new Guid("0373365f-4c9c-4ec4-af74-30f2f3f21352"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 },
                    { new Guid("ca73ac87-a862-4aea-9e7c-4f07b6f77bc9"), new Guid("4d3d5db6-8a9d-41a0-8a5f-443692887c20"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("f6976088-34e8-4254-a347-908d3934dbc9"), new Guid("0373365f-4c9c-4ec4-af74-30f2f3f21352"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("f8e7b62e-5588-45e6-8510-3dbbd3cb85d7"), new Guid("4d3d5db6-8a9d-41a0-8a5f-443692887c20"), false, false, "Список научных публикаций за последние 5 лет", 10 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("02a1fbf7-6a95-4305-a17d-4724917030c5"), true, "Название", 2, new Guid("8ecfe285-fd56-4724-8217-0fb39583db81"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("065f1372-859d-47b5-9749-02d6a0d90f36"), true, "Название разработки", 2, new Guid("4bf9c880-345c-48b5-b431-9fc241126381"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("0a9d6476-c1d3-4a61-aab3-4db4b187e738"), true, "Год", 4, new Guid("f6976088-34e8-4254-a347-908d3934dbc9"), new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("0d948442-9df8-4340-aa11-4f5de5ae4aac"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("7b820576-4b39-4ea2-b83e-10fdb7a272a6"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("12523a94-a14e-4504-9aa7-c8a8982cfc8b"), true, "Ссылка на открытый доступ", 8, new Guid("8ecfe285-fd56-4724-8217-0fb39583db81"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("2212e641-ce5a-4359-9b00-acad6bd41b4d"), true, "Название конкурса/премии", 2, new Guid("b555ff0b-11ba-4d36-89db-b17389bc3064"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("2335f7fd-4b11-465f-bef6-3d916eccaeb9"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("f8e7b62e-5588-45e6-8510-3dbbd3cb85d7"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("28a5b8b8-1cfa-4348-92bd-b2b4e857fc21"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("ca73ac87-a862-4aea-9e7c-4f07b6f77bc9"), new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("3264dc2c-73ff-461e-a7a3-cdebc6bee46d"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("b555ff0b-11ba-4d36-89db-b17389bc3064"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("39ff59d0-2977-4abc-8e3b-d557ef53d6c9"), true, "Название статьи", 1, new Guid("f8e7b62e-5588-45e6-8510-3dbbd3cb85d7"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("3d25f35b-3204-4281-bf61-bdfa17b16700"), false, "Идентификатор", 2, new Guid("a01be511-409e-4ea0-91cd-b74ee07032b8"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("3fc97860-dc56-494e-91af-ec7e5e03ce9a"), true, "Номер РИД", 4, new Guid("9d593bee-5c5c-4338-9f2c-6c13ee10e242"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("40a8b1c7-dcad-45c5-8c3d-0a5e6ad177cf"), true, "Ссылка", 5, new Guid("7b820576-4b39-4ea2-b83e-10fdb7a272a6"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("425db34e-482d-432d-bb66-780ab618a16c"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("35a6b994-c057-4213-8f68-93edf54d786b"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("51f2195d-0889-42c0-ad52-1a39e03dd06f"), true, "Вид", 2, new Guid("35a6b994-c057-4213-8f68-93edf54d786b"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("58ce34cb-e804-4155-9786-300ea84c9af6"), true, "Название документа, реквизиты", 1, new Guid("5999e323-16e7-4ef5-9735-c95535fd43ba"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("59f8c244-1982-4cd8-94e2-b0c2474a7381"), true, "Вид публикации", 1, new Guid("8ecfe285-fd56-4724-8217-0fb39583db81"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("6334b422-029e-4e2b-953a-7a8f30c5c1ee"), true, "ФИО", 1, new Guid("b555ff0b-11ba-4d36-89db-b17389bc3064"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("638ae3eb-4841-4c53-9a0d-b5c63734e549"), true, "Статус", 4, new Guid("ca73ac87-a862-4aea-9e7c-4f07b6f77bc9"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("6635a4e5-c9b1-43c0-ab64-cac12c4a9886"), true, "Ссылка на платформу", 3, new Guid("f6976088-34e8-4254-a347-908d3934dbc9"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("6e3b077f-8a67-4874-9694-b5d39ef805d9"), true, "ФИО соавторов", 3, new Guid("9d593bee-5c5c-4338-9f2c-6c13ee10e242"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("7777e2c3-6df9-4c22-8060-0d1a37b9d855"), true, "Издание, год", 4, new Guid("f8e7b62e-5588-45e6-8510-3dbbd3cb85d7"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("785e7f56-2928-44ad-9664-a8d3019e9e07"), true, "Статус конкурса", 3, new Guid("7b820576-4b39-4ea2-b83e-10fdb7a272a6"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("795ce64a-ad12-4a65-9f6d-fbe18189c1aa"), true, "Год", 1, new Guid("7b820576-4b39-4ea2-b83e-10fdb7a272a6"), new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("83b9e279-6b4f-49cc-a647-7563853d214f"), true, "Соавторы", 2, new Guid("f6976088-34e8-4254-a347-908d3934dbc9"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("8a8dffab-3e6a-4d0a-b6a4-38e794bd32f6"), true, "Вид", 1, new Guid("9d593bee-5c5c-4338-9f2c-6c13ee10e242"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("8a943c30-74c8-4faa-a183-050b8f0fb0e3"), true, "Год получения документа", 2, new Guid("5999e323-16e7-4ef5-9735-c95535fd43ba"), new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("8dc5578f-36b2-4c7b-9027-5b7219c4cd1f"), true, "Язык преподавания", 2, new Guid("a664c290-78bc-4a89-917f-4503f7523052"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("91833b5e-37a2-4bfa-9380-ee6b9e7d0839"), true, "Название конкурса", 2, new Guid("7b820576-4b39-4ea2-b83e-10fdb7a272a6"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("98961a51-4e1e-4d32-b3f1-dd58b1b2172e"), true, "Период выполнения", 3, new Guid("ca73ac87-a862-4aea-9e7c-4f07b6f77bc9"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("9d11c1d0-c23a-403f-9a37-09bb18d1e242"), true, "Вид", 1, new Guid("4bf9c880-345c-48b5-b431-9fc241126381"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("9e76806f-1b32-4781-b679-72907fed60d0"), true, "Издательство, год", 6, new Guid("8ecfe285-fd56-4724-8217-0fb39583db81"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("a62d4587-98d2-47ab-8333-e13b4ac40b68"), true, "Название курса", 1, new Guid("f6976088-34e8-4254-a347-908d3934dbc9"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("a738975d-7066-4264-b224-5e7108fcbbc2"), false, "Тип идентификатора", 1, new Guid("a01be511-409e-4ea0-91cd-b74ee07032b8"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("a7502d54-d593-4d34-b1bf-32873332cdeb"), true, "Практические занятия (час.)", 4, new Guid("a664c290-78bc-4a89-917f-4503f7523052"), new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("a8ed0f32-940e-4b47-b542-95391ddaa5a2"), true, "Количество печатных листов", 4, new Guid("8ecfe285-fd56-4724-8217-0fb39583db81"), new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("aa14eafc-c082-444f-8be9-8595624c5786"), true, "Наименование курса", 1, new Guid("a664c290-78bc-4a89-917f-4503f7523052"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("b0d7937f-ddc2-4eae-b196-0b1e1250dd71"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("ca73ac87-a862-4aea-9e7c-4f07b6f77bc9"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("b6665b63-c5fd-41e8-8fe6-4152657d5669"), true, "Соавторы", 2, new Guid("f8e7b62e-5588-45e6-8510-3dbbd3cb85d7"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("bef76f6b-f11a-49c9-af1a-937efe948e34"), true, "Название организации в которую внедрена разработка", 3, new Guid("4bf9c880-345c-48b5-b431-9fc241126381"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("c9cad5de-7b34-48bc-a271-97aa76491958"), true, "Год", 3, new Guid("b555ff0b-11ba-4d36-89db-b17389bc3064"), new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("ccae35c7-dfa2-42a8-81cc-4e599cfbd263"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("b555ff0b-11ba-4d36-89db-b17389bc3064"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("ce53c974-0b10-4513-88b1-5b5bc29675e5"), true, "Название НИР/НИОКР", 1, new Guid("ca73ac87-a862-4aea-9e7c-4f07b6f77bc9"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("cf36e284-cc09-4890-aa37-61fb0b380a80"), true, "Итого (час.)", 5, new Guid("a664c290-78bc-4a89-917f-4503f7523052"), new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("d240e381-0ed2-4b5f-94a1-e289e7a0fd16"), false, "Соавторы", 3, new Guid("8ecfe285-fd56-4724-8217-0fb39583db81"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("d40c7a6a-513f-40cd-8ef5-062016c3bd47"), true, "Название дисциплины", 1, new Guid("35a6b994-c057-4213-8f68-93edf54d786b"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("d8097bd5-e5c2-4160-809e-6d222f17fb70"), true, "Название", 1, new Guid("62da8c12-4843-4869-9a80-b55cee49785e"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("e0d1aaaa-d5ca-4896-b934-5bf673ef75d8"), true, "Язык публикации", 7, new Guid("8ecfe285-fd56-4724-8217-0fb39583db81"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("e55b716d-2a49-4e81-a690-5697d1a64989"), true, "Лекции (час.)", 3, new Guid("a664c290-78bc-4a89-917f-4503f7523052"), new Guid("03b3e58e-8275-4877-9ba3-494e07f0a052") },
                    { new Guid("ea1e4629-804e-439a-84bf-2631699ff7a3"), true, "Наличие грифа", 5, new Guid("8ecfe285-fd56-4724-8217-0fb39583db81"), new Guid("977dc65d-1eef-4844-afbf-8c93a46a9c51") },
                    { new Guid("ea8d1456-edc2-43cd-b0ad-a3d4c8f1d216"), true, "Название", 2, new Guid("9d593bee-5c5c-4338-9f2c-6c13ee10e242"), new Guid("fec31d8a-1857-40bc-b548-f0341398fe80") },
                    { new Guid("f2580839-3049-4a05-b044-afda2d2e0b5d"), true, "Значение", 2, new Guid("62da8c12-4843-4869-9a80-b55cee49785e"), new Guid("1d751442-b53d-418d-b332-17966e54a79f") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("00c065db-2298-4290-a3ff-518a7f2f7664"), new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02") },
                    { new Guid("00c065db-2298-4290-a3ff-518a7f2f7664"), new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58") },
                    { new Guid("00c065db-2298-4290-a3ff-518a7f2f7664"), new Guid("b838beca-82bb-4f44-bdb4-4b1dee5d0889") },
                    { new Guid("02c6bb6e-1c1f-4e33-a0db-2ca3af27343e"), new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58") },
                    { new Guid("0d16c3af-3d39-4359-8b6e-4921b19d583e"), new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02") },
                    { new Guid("2b96aa3d-d9f7-4d27-b6aa-6db2e7a7e694"), new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5") },
                    { new Guid("3be36319-913a-4811-bbd1-a80cc827d8ff"), new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02") },
                    { new Guid("3d02a5ad-07b6-46cf-b255-a3eba36fac81"), new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02") },
                    { new Guid("406f1feb-3ee0-4faa-a9c5-2c27616fd3ab"), new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02") },
                    { new Guid("49f2b53f-a843-4f2b-8b08-9d92897c1a6d"), new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02") },
                    { new Guid("5550cbd5-8666-431a-ac64-9ad0d02637cf"), new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02") },
                    { new Guid("56b8b971-c96f-41f3-acbb-dd55a8d6747b"), new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5") },
                    { new Guid("57a1953c-aa17-4f07-9e60-4d671ca883fa"), new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02") },
                    { new Guid("73f6a5cf-a4f2-4559-b2d6-1a4689105f9b"), new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58") },
                    { new Guid("815d7569-db76-459d-9ec6-f710394a9850"), new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02") },
                    { new Guid("9afb914a-bfe2-4949-a33c-b3b449e57063"), new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02") },
                    { new Guid("a78f1d7c-0658-4be6-9fe0-007f7cc5b735"), new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02") },
                    { new Guid("b0d1f39c-9621-4896-8495-d6c479697256"), new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02") },
                    { new Guid("b1105017-6764-4c89-82ae-39e55721ed15"), new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02") },
                    { new Guid("fa16d661-a3a6-49c2-8e7b-a064ad1bb8fd"), new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("25d776b7-c234-47b0-b6f0-4be21cbb9090"), new Guid("62da8c12-4843-4869-9a80-b55cee49785e") },
                    { new Guid("4087db9a-2bb0-4521-bc26-6f594391bf02"), new Guid("a01be511-409e-4ea0-91cd-b74ee07032b8") },
                    { new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5"), new Guid("a664c290-78bc-4a89-917f-4503f7523052") },
                    { new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5"), new Guid("b555ff0b-11ba-4d36-89db-b17389bc3064") },
                    { new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5"), new Guid("f6976088-34e8-4254-a347-908d3934dbc9") },
                    { new Guid("66a0c11e-c5e8-40cc-b949-42318c941a48"), new Guid("35a6b994-c057-4213-8f68-93edf54d786b") },
                    { new Guid("66a0c11e-c5e8-40cc-b949-42318c941a48"), new Guid("8ecfe285-fd56-4724-8217-0fb39583db81") },
                    { new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58"), new Guid("7b820576-4b39-4ea2-b83e-10fdb7a272a6") },
                    { new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58"), new Guid("ca73ac87-a862-4aea-9e7c-4f07b6f77bc9") },
                    { new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58"), new Guid("f8e7b62e-5588-45e6-8510-3dbbd3cb85d7") },
                    { new Guid("b5501e38-02f1-42b6-b08d-77de067b62f1"), new Guid("4bf9c880-345c-48b5-b431-9fc241126381") },
                    { new Guid("b5501e38-02f1-42b6-b08d-77de067b62f1"), new Guid("5999e323-16e7-4ef5-9735-c95535fd43ba") },
                    { new Guid("b5501e38-02f1-42b6-b08d-77de067b62f1"), new Guid("9d593bee-5c5c-4338-9f2c-6c13ee10e242") },
                    { new Guid("b838beca-82bb-4f44-bdb4-4b1dee5d0889"), new Guid("5999e323-16e7-4ef5-9735-c95535fd43ba") },
                    { new Guid("b838beca-82bb-4f44-bdb4-4b1dee5d0889"), new Guid("7b820576-4b39-4ea2-b83e-10fdb7a272a6") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0e31347b-02d1-4f68-97c4-6ecce5e6c2fd"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("5999e323-16e7-4ef5-9735-c95535fd43ba") },
                    { new Guid("2a1fc3ec-11ef-4223-bc5d-3f68b9845139"), "EvaluateMark20", new Guid("73f6a5cf-a4f2-4559-b2d6-1a4689105f9b"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("2f761cfc-3beb-4b14-97fe-b55bf77f4d65"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("ca73ac87-a862-4aea-9e7c-4f07b6f77bc9") },
                    { new Guid("2f8e8bad-02a4-407b-9cd4-fbc3d395fc17"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("8ecfe285-fd56-4724-8217-0fb39583db81") },
                    { new Guid("4d5410fd-6b0e-4730-8ed8-88b77564cb4f"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("f6976088-34e8-4254-a347-908d3934dbc9") },
                    { new Guid("4d6056eb-b30e-4f06-9536-36909f7d9900"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом или на иностранном языке в соавторстве:", 9, new Guid("8ecfe285-fd56-4724-8217-0fb39583db81") },
                    { new Guid("50f999a9-b4d5-430c-b4f6-34307f271ed2"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("4bf9c880-345c-48b5-b431-9fc241126381") },
                    { new Guid("5cc2563b-277a-47cd-ba49-3e166a8d1b90"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("a664c290-78bc-4a89-917f-4503f7523052") },
                    { new Guid("6275471d-6f30-4abb-a1c4-14516ac1625e"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("8ecfe285-fd56-4724-8217-0fb39583db81") },
                    { new Guid("64d0122c-4248-435e-a876-9ae1ee1a662d"), "EvaluateMark3", new Guid("fa16d661-a3a6-49c2-8e7b-a064ad1bb8fd"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("76606667-6603-435d-b2c4-340d2c0e62c2"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("ca73ac87-a862-4aea-9e7c-4f07b6f77bc9") },
                    { new Guid("7af78210-b52c-4f69-8f16-c0db4f137ff6"), "EvaluateMark4", new Guid("56b8b971-c96f-41f3-acbb-dd55a8d6747b"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("7c3bdb72-3086-4d50-8589-a2c315cf8f41"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("f8e7b62e-5588-45e6-8510-3dbbd3cb85d7") },
                    { new Guid("9d24ede2-0dce-46f5-8696-c4b47ca6ee11"), "EvaluateMark13", new Guid("00c065db-2298-4290-a3ff-518a7f2f7664"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("a00c36c5-c429-444a-8ffa-2dbaf5d7a141"), "EvaluateMark5", new Guid("2b96aa3d-d9f7-4d27-b6aa-6db2e7a7e694"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("a1575a4d-7f4f-440c-9886-14325b8d2628"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("a664c290-78bc-4a89-917f-4503f7523052") },
                    { new Guid("a9482233-c2d6-474f-85e2-3a0b8ad930d5"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("b555ff0b-11ba-4d36-89db-b17389bc3064") },
                    { new Guid("b2b6ed9f-a23d-4792-b470-19d267cf7422"), "EvaluateMark19", new Guid("02c6bb6e-1c1f-4e33-a0db-2ca3af27343e"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("b304b218-0b09-4490-90e9-7ca253640044"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("62da8c12-4843-4869-9a80-b55cee49785e") },
                    { new Guid("b33d1a5c-0281-4473-8561-1b10872f9b94"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("7b820576-4b39-4ea2-b83e-10fdb7a272a6") },
                    { new Guid("c5c1c0aa-ad0a-4ffb-8546-f8a0fed87a89"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("62da8c12-4843-4869-9a80-b55cee49785e") },
                    { new Guid("d7b9a373-e697-4c30-ace2-7a0b4b4afe18"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("35a6b994-c057-4213-8f68-93edf54d786b") },
                    { new Guid("dbc3898b-8013-472c-9f83-c344c3d70daf"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("9d593bee-5c5c-4338-9f2c-6c13ee10e242") },
                    { new Guid("f749dab0-3254-4537-809c-7b941736c080"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом или на иностранном языке и без соавторства:", 8, new Guid("8ecfe285-fd56-4724-8217-0fb39583db81") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("09aece0a-d825-4215-a88a-c7dd6944ec74"), true, 6, new Guid("62da8c12-4843-4869-9a80-b55cee49785e") },
                    { new Guid("21b3d800-76c9-4843-9413-cb682f43ae30"), true, 8, new Guid("62da8c12-4843-4869-9a80-b55cee49785e") },
                    { new Guid("2ff32d4b-1358-44a8-9308-b010c6bb0185"), true, 7, new Guid("62da8c12-4843-4869-9a80-b55cee49785e") },
                    { new Guid("3b523239-4327-45f7-896a-1cbfedabf754"), true, 1, new Guid("62da8c12-4843-4869-9a80-b55cee49785e") },
                    { new Guid("512ccad5-1ef6-4e6a-8722-72f13f33dfcd"), true, 3, new Guid("a01be511-409e-4ea0-91cd-b74ee07032b8") },
                    { new Guid("7d3fe3fc-7d81-4a9f-9793-405e49c0e0dc"), true, 4, new Guid("a01be511-409e-4ea0-91cd-b74ee07032b8") },
                    { new Guid("a2f3159d-887a-46c3-8bf2-a58de8d79e97"), true, 5, new Guid("a01be511-409e-4ea0-91cd-b74ee07032b8") },
                    { new Guid("a5034236-ddb9-4323-84c3-046d21971632"), true, 5, new Guid("62da8c12-4843-4869-9a80-b55cee49785e") },
                    { new Guid("c6f71f42-b8b3-4e90-a154-f7fe558ecc33"), true, 4, new Guid("62da8c12-4843-4869-9a80-b55cee49785e") },
                    { new Guid("ccf13caa-c96d-4ff7-9dcf-df56b350b37d"), true, 3, new Guid("62da8c12-4843-4869-9a80-b55cee49785e") },
                    { new Guid("dff35b0f-aaf3-4894-bd99-762ed891fe45"), true, 2, new Guid("a01be511-409e-4ea0-91cd-b74ee07032b8") },
                    { new Guid("ec856a5a-be37-4d12-ac06-7512d67c29bf"), true, 2, new Guid("62da8c12-4843-4869-9a80-b55cee49785e") },
                    { new Guid("f53e2c17-c9a7-4245-8df2-b32ddda4a8c4"), true, 1, new Guid("a01be511-409e-4ea0-91cd-b74ee07032b8") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("1b31a67e-a1d2-4012-a576-8e6375db189e"), null, new Guid("00c065db-2298-4290-a3ff-518a7f2f7664"), "Доцент" },
                    { new Guid("366ff9ea-1b88-4ea2-8ac3-11d68d1c4acb"), null, new Guid("00c065db-2298-4290-a3ff-518a7f2f7664"), "Профессор" },
                    { new Guid("60577f02-ada9-47e9-9218-d6d27e269079"), null, new Guid("00c065db-2298-4290-a3ff-518a7f2f7664"), "Нет" },
                    { new Guid("c38379c6-3395-4dc1-94a2-86ac915e6ce3"), null, new Guid("57a1953c-aa17-4f07-9e60-4d671ca883fa"), "Доктор наук" },
                    { new Guid("f02b0a3d-c8be-4d59-9ec0-58afe5d8b6dd"), null, new Guid("57a1953c-aa17-4f07-9e60-4d671ca883fa"), "Кандидат наук" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("21afb3a5-2257-4aa1-8248-5a90ff95b080"), null, new Guid("f2580839-3049-4a05-b044-afda2d2e0b5d"), false, true, new Guid("c6f71f42-b8b3-4e90-a154-f7fe558ecc33"), null },
                    { new Guid("2365ba8a-4155-4e8e-a9e3-20ddf203b4d0"), null, new Guid("f2580839-3049-4a05-b044-afda2d2e0b5d"), false, true, new Guid("2ff32d4b-1358-44a8-9308-b010c6bb0185"), null },
                    { new Guid("2c926bdc-8645-4058-ac39-97615938a34a"), null, new Guid("f2580839-3049-4a05-b044-afda2d2e0b5d"), false, true, new Guid("a5034236-ddb9-4323-84c3-046d21971632"), null },
                    { new Guid("3293e273-d009-4e6e-87e6-fe660fb90261"), null, new Guid("a738975d-7066-4264-b224-5e7108fcbbc2"), true, true, new Guid("a2f3159d-887a-46c3-8bf2-a58de8d79e97"), "Google Scholar ID" },
                    { new Guid("341d1ce1-3df2-48c0-83c5-1ee6fc2d2c58"), null, new Guid("3d25f35b-3204-4281-bf61-bdfa17b16700"), false, true, new Guid("f53e2c17-c9a7-4245-8df2-b32ddda4a8c4"), null },
                    { new Guid("3932be8e-abe2-4ac0-8462-8070f57804a8"), null, new Guid("d8097bd5-e5c2-4160-809e-6d222f17fb70"), true, true, new Guid("c6f71f42-b8b3-4e90-a154-f7fe558ecc33"), "Методология и методы, используемые в работе" },
                    { new Guid("3f1a440b-98aa-4784-b225-e1081f560d17"), null, new Guid("d8097bd5-e5c2-4160-809e-6d222f17fb70"), true, true, new Guid("3b523239-4327-45f7-896a-1cbfedabf754"), "Название работы" },
                    { new Guid("470b0e45-2880-48eb-8cb2-39da68bacdd9"), null, new Guid("a738975d-7066-4264-b224-5e7108fcbbc2"), true, true, new Guid("f53e2c17-c9a7-4245-8df2-b32ddda4a8c4"), "ScopusID" },
                    { new Guid("50f7aad8-fa27-4307-8fe4-03dad66bcbd6"), null, new Guid("f2580839-3049-4a05-b044-afda2d2e0b5d"), false, true, new Guid("09aece0a-d825-4215-a88a-c7dd6944ec74"), null },
                    { new Guid("6c3f3163-6a77-4787-b251-5906d17fa904"), null, new Guid("3d25f35b-3204-4281-bf61-bdfa17b16700"), false, true, new Guid("dff35b0f-aaf3-4894-bd99-762ed891fe45"), null },
                    { new Guid("6f9d53db-0f20-4390-84c0-6b8b49bd8e22"), null, new Guid("3d25f35b-3204-4281-bf61-bdfa17b16700"), false, true, new Guid("7d3fe3fc-7d81-4a9f-9793-405e49c0e0dc"), null },
                    { new Guid("79114761-8738-4192-a99b-530678294a70"), null, new Guid("d8097bd5-e5c2-4160-809e-6d222f17fb70"), true, true, new Guid("21b3d800-76c9-4843-9413-cb682f43ae30"), "Результаты и выводы" },
                    { new Guid("83e0dd2c-445e-4f30-83fe-1ad14248274c"), null, new Guid("d8097bd5-e5c2-4160-809e-6d222f17fb70"), true, true, new Guid("ec856a5a-be37-4d12-ac06-7512d67c29bf"), "Актуальность конкурсной работы" },
                    { new Guid("8526abb4-abf4-4fb8-95ed-781ebc5281a2"), null, new Guid("a738975d-7066-4264-b224-5e7108fcbbc2"), true, true, new Guid("dff35b0f-aaf3-4894-bd99-762ed891fe45"), "ORCiD" },
                    { new Guid("93c24406-f9c0-4f2f-a28b-c026fa7f0d81"), null, new Guid("d8097bd5-e5c2-4160-809e-6d222f17fb70"), true, true, new Guid("2ff32d4b-1358-44a8-9308-b010c6bb0185"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("9484d667-989c-4e81-9f05-c3d552854320"), null, new Guid("f2580839-3049-4a05-b044-afda2d2e0b5d"), false, true, new Guid("ccf13caa-c96d-4ff7-9dcf-df56b350b37d"), null },
                    { new Guid("9df97d59-34e1-4c0f-8da5-b372314e6f26"), null, new Guid("f2580839-3049-4a05-b044-afda2d2e0b5d"), false, true, new Guid("ec856a5a-be37-4d12-ac06-7512d67c29bf"), null },
                    { new Guid("a03bc889-037c-429c-9c00-2ac71915ce2c"), null, new Guid("a738975d-7066-4264-b224-5e7108fcbbc2"), true, true, new Guid("512ccad5-1ef6-4e6a-8722-72f13f33dfcd"), "ResearcherID" },
                    { new Guid("acacd5c4-8395-4218-834e-25fcc8ed4b21"), null, new Guid("a738975d-7066-4264-b224-5e7108fcbbc2"), true, true, new Guid("7d3fe3fc-7d81-4a9f-9793-405e49c0e0dc"), "РИНЦ AuthorID" },
                    { new Guid("c1b0d973-a4b1-47a5-b151-1e7a59d507e0"), null, new Guid("f2580839-3049-4a05-b044-afda2d2e0b5d"), false, true, new Guid("3b523239-4327-45f7-896a-1cbfedabf754"), null },
                    { new Guid("c8b0c5ef-3831-4823-844f-5bcc5d15cf1c"), null, new Guid("d8097bd5-e5c2-4160-809e-6d222f17fb70"), true, true, new Guid("ccf13caa-c96d-4ff7-9dcf-df56b350b37d"), "Инновационность" },
                    { new Guid("ca3a2e4a-0932-45e6-8521-3cc559e8409a"), null, new Guid("3d25f35b-3204-4281-bf61-bdfa17b16700"), false, true, new Guid("a2f3159d-887a-46c3-8bf2-a58de8d79e97"), null },
                    { new Guid("ccbc6071-2a1b-44a9-83c7-884a3dd879a6"), null, new Guid("3d25f35b-3204-4281-bf61-bdfa17b16700"), false, true, new Guid("512ccad5-1ef6-4e6a-8722-72f13f33dfcd"), null },
                    { new Guid("ded7ab19-bad4-4624-ac64-c81f11386bf4"), null, new Guid("d8097bd5-e5c2-4160-809e-6d222f17fb70"), true, true, new Guid("a5034236-ddb9-4323-84c3-046d21971632"), "Ссылка на конкурсную работу" },
                    { new Guid("edcd7cb8-f2f2-46db-8402-4c52aa7e1de5"), null, new Guid("d8097bd5-e5c2-4160-809e-6d222f17fb70"), true, true, new Guid("09aece0a-d825-4215-a88a-c7dd6944ec74"), "Апробация" },
                    { new Guid("f37b96f6-1c1a-47ce-94fa-940bf08e06c4"), null, new Guid("f2580839-3049-4a05-b044-afda2d2e0b5d"), false, true, new Guid("21b3d800-76c9-4843-9413-cb682f43ae30"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("25d776b7-c234-47b0-b6f0-4be21cbb9090"), new Guid("b304b218-0b09-4490-90e9-7ca253640044") },
                    { new Guid("25d776b7-c234-47b0-b6f0-4be21cbb9090"), new Guid("c5c1c0aa-ad0a-4ffb-8546-f8a0fed87a89") },
                    { new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5"), new Guid("4d5410fd-6b0e-4730-8ed8-88b77564cb4f") },
                    { new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5"), new Guid("5cc2563b-277a-47cd-ba49-3e166a8d1b90") },
                    { new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5"), new Guid("64d0122c-4248-435e-a876-9ae1ee1a662d") },
                    { new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5"), new Guid("7af78210-b52c-4f69-8f16-c0db4f137ff6") },
                    { new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5"), new Guid("a00c36c5-c429-444a-8ffa-2dbaf5d7a141") },
                    { new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5"), new Guid("a1575a4d-7f4f-440c-9886-14325b8d2628") },
                    { new Guid("445372c0-ecfa-40d8-8b8c-7a25d1d7dab5"), new Guid("a9482233-c2d6-474f-85e2-3a0b8ad930d5") },
                    { new Guid("66a0c11e-c5e8-40cc-b949-42318c941a48"), new Guid("2f8e8bad-02a4-407b-9cd4-fbc3d395fc17") },
                    { new Guid("66a0c11e-c5e8-40cc-b949-42318c941a48"), new Guid("4d6056eb-b30e-4f06-9536-36909f7d9900") },
                    { new Guid("66a0c11e-c5e8-40cc-b949-42318c941a48"), new Guid("6275471d-6f30-4abb-a1c4-14516ac1625e") },
                    { new Guid("66a0c11e-c5e8-40cc-b949-42318c941a48"), new Guid("d7b9a373-e697-4c30-ace2-7a0b4b4afe18") },
                    { new Guid("66a0c11e-c5e8-40cc-b949-42318c941a48"), new Guid("f749dab0-3254-4537-809c-7b941736c080") },
                    { new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58"), new Guid("2a1fc3ec-11ef-4223-bc5d-3f68b9845139") },
                    { new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58"), new Guid("2f761cfc-3beb-4b14-97fe-b55bf77f4d65") },
                    { new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58"), new Guid("76606667-6603-435d-b2c4-340d2c0e62c2") },
                    { new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58"), new Guid("7c3bdb72-3086-4d50-8589-a2c315cf8f41") },
                    { new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58"), new Guid("9d24ede2-0dce-46f5-8696-c4b47ca6ee11") },
                    { new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58"), new Guid("b2b6ed9f-a23d-4792-b470-19d267cf7422") },
                    { new Guid("ad6cd501-1984-44da-85e4-b7b7646aea58"), new Guid("b33d1a5c-0281-4473-8561-1b10872f9b94") },
                    { new Guid("b5501e38-02f1-42b6-b08d-77de067b62f1"), new Guid("0e31347b-02d1-4f68-97c4-6ecce5e6c2fd") },
                    { new Guid("b5501e38-02f1-42b6-b08d-77de067b62f1"), new Guid("50f999a9-b4d5-430c-b4f6-34307f271ed2") },
                    { new Guid("b5501e38-02f1-42b6-b08d-77de067b62f1"), new Guid("dbc3898b-8013-472c-9f83-c344c3d70daf") },
                    { new Guid("b838beca-82bb-4f44-bdb4-4b1dee5d0889"), new Guid("0e31347b-02d1-4f68-97c4-6ecce5e6c2fd") },
                    { new Guid("b838beca-82bb-4f44-bdb4-4b1dee5d0889"), new Guid("9d24ede2-0dce-46f5-8696-c4b47ca6ee11") },
                    { new Guid("b838beca-82bb-4f44-bdb4-4b1dee5d0889"), new Guid("b33d1a5c-0281-4473-8561-1b10872f9b94") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("098874a4-f16f-4560-8975-25b069543d85"), new Guid("2335f7fd-4b11-465f-bef6-3d916eccaeb9"), null, "РИНЦ" },
                    { new Guid("14dc52be-3afb-4e65-906c-e713f315be4f"), new Guid("638ae3eb-4841-4c53-9a0d-b5c63734e549"), null, "Исполнитель" },
                    { new Guid("1adbfd32-8693-47dd-be02-b7b081e50ec5"), new Guid("59f8c244-1982-4cd8-94e2-b0c2474a7381"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("2504a608-391f-4fe5-b2ec-2fa979b58822"), new Guid("8a8dffab-3e6a-4d0a-b6a4-38e794bd32f6"), null, "Полезная модель" },
                    { new Guid("2f0f5ce8-eb47-449c-8829-489f6129a21b"), new Guid("d240e381-0ed2-4b5f-94a1-e289e7a0fd16"), null, "Есть" },
                    { new Guid("3391c2fd-f92f-4805-a728-d5b5a19328ae"), new Guid("8dc5578f-36b2-4c7b-9027-5b7219c4cd1f"), null, "Другой" },
                    { new Guid("372c45af-cd46-42b0-a364-3709079bb719"), new Guid("2335f7fd-4b11-465f-bef6-3d916eccaeb9"), null, "МБД (Q3-Q4)" },
                    { new Guid("442f3d7e-fb99-4f0b-ba6f-ecf24b316b11"), new Guid("785e7f56-2928-44ad-9664-a8d3019e9e07"), null, "Всероссийский" },
                    { new Guid("49ecfd85-3e09-4845-98d3-535f26cd9e1a"), new Guid("51f2195d-0889-42c0-ad52-1a39e03dd06f"), null, "Лабораторные" },
                    { new Guid("5de3c1e7-30f7-46ea-9138-480bb6936cfd"), new Guid("9d11c1d0-c23a-403f-9a37-09bb18d1e242"), null, "Промышленный образец" },
                    { new Guid("6d1bb098-65e8-4495-8af3-b9ef9dbe2720"), new Guid("51f2195d-0889-42c0-ad52-1a39e03dd06f"), null, "Лекции" },
                    { new Guid("754965fd-382a-4fbc-b0c9-cc56a8c182f8"), new Guid("b6665b63-c5fd-41e8-8fe6-4152657d5669"), null, "Есть" },
                    { new Guid("764cc13a-a1fd-4b36-a86d-1267bcbfc5a5"), new Guid("8dc5578f-36b2-4c7b-9027-5b7219c4cd1f"), null, "Английский" },
                    { new Guid("77bac38c-44bf-4f9a-ad39-d2895ef45079"), new Guid("8dc5578f-36b2-4c7b-9027-5b7219c4cd1f"), null, "Русский" },
                    { new Guid("7cc986e5-7a44-4ac6-827d-0209bf445019"), new Guid("83b9e279-6b4f-49cc-a647-7563853d214f"), null, "Нет" },
                    { new Guid("8152b058-cd35-4a6c-a174-06d33fc641d4"), new Guid("9d11c1d0-c23a-403f-9a37-09bb18d1e242"), null, "Полезная модель" },
                    { new Guid("87b8263b-46da-4588-b002-7ed9588d1455"), new Guid("8a8dffab-3e6a-4d0a-b6a4-38e794bd32f6"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("87ed2fba-8359-417a-8e96-c1bd891ef6a5"), new Guid("59f8c244-1982-4cd8-94e2-b0c2474a7381"), null, "Учебник" },
                    { new Guid("88ae7a13-ee4d-4571-82a6-8f24d5504c1e"), new Guid("b6665b63-c5fd-41e8-8fe6-4152657d5669"), null, "Нет" },
                    { new Guid("9adb7846-0b26-4658-aa84-ddbf7d40a76d"), new Guid("8a8dffab-3e6a-4d0a-b6a4-38e794bd32f6"), null, "Изобретение" },
                    { new Guid("b7836c0e-95c2-420a-8e49-177937b302a1"), new Guid("9d11c1d0-c23a-403f-9a37-09bb18d1e242"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("b94a2bd4-2a77-4ca9-9605-4dbc1b2c10c2"), new Guid("785e7f56-2928-44ad-9664-a8d3019e9e07"), null, "Региональный" },
                    { new Guid("c001406f-c403-4076-a69a-9b2d7a442ee9"), new Guid("2335f7fd-4b11-465f-bef6-3d916eccaeb9"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("c66e5b1b-693f-4fdf-8533-4253391acff7"), new Guid("e0d1aaaa-d5ca-4896-b934-5bf673ef75d8"), null, "Русский" },
                    { new Guid("d44d6266-f71a-404a-bfb0-95d11f8375e2"), new Guid("e0d1aaaa-d5ca-4896-b934-5bf673ef75d8"), null, "Иностранный" },
                    { new Guid("d549a5b5-c6e2-4b65-8f49-3ceecc021859"), new Guid("ea1e4629-804e-439a-84bf-2631699ff7a3"), null, "Нет" },
                    { new Guid("d799ac24-0c9a-4b8a-9660-642a79b7c219"), new Guid("9d11c1d0-c23a-403f-9a37-09bb18d1e242"), null, "Изобретение" },
                    { new Guid("dba509c0-7a36-487b-a502-4dd0ecf73249"), new Guid("8a8dffab-3e6a-4d0a-b6a4-38e794bd32f6"), null, "Промышленный образец" },
                    { new Guid("df6a7f37-c86a-4ba1-903e-5aaf1b90a1bd"), new Guid("59f8c244-1982-4cd8-94e2-b0c2474a7381"), null, "Монография" },
                    { new Guid("e0fe8617-e67d-4118-8a8a-5129da4a223a"), new Guid("2335f7fd-4b11-465f-bef6-3d916eccaeb9"), null, "ВАК (К2-К3)" },
                    { new Guid("e5fc7ccf-c666-46b6-b956-7db25890c415"), new Guid("d240e381-0ed2-4b5f-94a1-e289e7a0fd16"), null, "Нет" },
                    { new Guid("eefc63aa-baff-47cf-977c-842c36d4232a"), new Guid("638ae3eb-4841-4c53-9a0d-b5c63734e549"), null, "Руководитель" },
                    { new Guid("efb238e4-bc85-440a-92b6-b4d77e490971"), new Guid("785e7f56-2928-44ad-9664-a8d3019e9e07"), null, "Международный" },
                    { new Guid("f112e277-ec4e-460f-bed6-76907807f34e"), new Guid("83b9e279-6b4f-49cc-a647-7563853d214f"), null, "Есть" },
                    { new Guid("f56b99cd-0aa5-4efc-be91-7bc4e2ace955"), new Guid("ea1e4629-804e-439a-84bf-2631699ff7a3"), null, "Есть" }
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
