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
                    { new Guid("04cda66e-1d11-43c8-86b0-337a450e77c4"), 6, "Оценена" },
                    { new Guid("538d28b5-5356-49aa-b692-17bef499ab41"), 3, "В процессе рассмотрения" },
                    { new Guid("9573523c-cf1d-4f8c-bf7f-6ee4b69c9e42"), 1, "В ожидании заполнения" },
                    { new Guid("a835805c-3754-443e-9023-94f789f2b1cb"), 2, "В ожидании рассмотрения" },
                    { new Guid("de9f828d-2cc4-480b-8d31-77c053e722b2"), 5, "Отклонена" },
                    { new Guid("e07d1a6c-6c94-4b7c-8fad-32e0ffe1b4b0"), 4, "Одобрена" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "35904fd5-b7ac-418b-b5d6-6d51df6b2d50", null, "Voter", "VOTER" },
                    { "b3952180-bf00-42e4-a5c1-2b6399d8236b", null, "Participant", "PARTICIPANT" },
                    { "be923f9e-014e-48b0-83e3-e73e728b8b62", null, "Expert", "EXPERT" },
                    { "e0165e81-9d3b-4219-a786-67ffe2c7e912", null, "Admin", "ADMIN" },
                    { "edd683ea-cf06-48bd-9429-4a2796bbee49", null, "Organiser", "ORGANISER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("024be3d5-32de-481f-9083-590d55a7f058"), "Строительство и архитектура", 1 },
                    { new Guid("3a4349d0-302f-4952-8c9e-308c5df3364e"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("02cbb2b5-4d83-412c-9e63-2cb8605da39c"), "Конкурсная работа", 3 },
                    { new Guid("4751b4b4-b8cc-4f41-9ec5-f483a06cfeae"), "Научно-педагогическая деятельность", 5 },
                    { new Guid("63cb9d69-2f54-41a5-8564-1c9794060f03"), "Общая информация", 1 },
                    { new Guid("6eb54a51-e2c3-496e-9c14-3b4d59529662"), "Категория участников", 2 },
                    { new Guid("aee1c6f0-d172-4d33-baa3-f3b94610f9b6"), "Профессиональное развитие", 4 },
                    { new Guid("da777e74-f04e-4a95-92c8-273842897bd4"), "Научно-исследовательская деятельность", 6 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Checked", "Email", "Message", "Name" },
                values: new object[] { new Guid("10746455-1427-4f8b-9e1d-2320cf8290b4"), false, "system@system.ru", "Test Message for System", "SYSTEM" });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("14c70270-af4c-4cdf-b86b-d0edf2fd06cf"), "Профессиональные показатели", 4 },
                    { new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("3ef15748-de91-45aa-aa34-66dba21db4f9"), "Инновационная и иная деятельность", 6 },
                    { new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95"), "Образовательная деятельность", 2 },
                    { new Guid("91b3af8e-1004-4f85-baae-1e822ef57833"), "Методическая деятельность", 3 },
                    { new Guid("9d6b4747-90c1-44ab-831a-29404a012be7"), "Основной", 1 },
                    { new Guid("b489c041-15b9-49f1-9efa-ae6fada3cd28"), "Конкурсная работа", 7 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("d913f7b8-2963-4f7a-aaf5-8acd52b80ee4"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("ee256d2d-2d15-4a3c-87e9-7374256470a0"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3b6005a3-6de8-498a-8282-9e315b856b90"), "int" },
                    { new Guid("7876653e-40c9-432f-895a-54ad9422a34c"), "TextArea" },
                    { new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5"), "string" },
                    { new Guid("e35da956-df7a-4234-b4f0-99bcad4623a1"), "DateTime" },
                    { new Guid("f296d010-7248-4ad2-a3e3-10f6825f9617"), "bool" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("02cbb2b5-4d83-412c-9e63-2cb8605da39c"), new Guid("d913f7b8-2963-4f7a-aaf5-8acd52b80ee4") },
                    { new Guid("02cbb2b5-4d83-412c-9e63-2cb8605da39c"), new Guid("ee256d2d-2d15-4a3c-87e9-7374256470a0") },
                    { new Guid("4751b4b4-b8cc-4f41-9ec5-f483a06cfeae"), new Guid("ee256d2d-2d15-4a3c-87e9-7374256470a0") },
                    { new Guid("63cb9d69-2f54-41a5-8564-1c9794060f03"), new Guid("d913f7b8-2963-4f7a-aaf5-8acd52b80ee4") },
                    { new Guid("63cb9d69-2f54-41a5-8564-1c9794060f03"), new Guid("ee256d2d-2d15-4a3c-87e9-7374256470a0") },
                    { new Guid("6eb54a51-e2c3-496e-9c14-3b4d59529662"), new Guid("d913f7b8-2963-4f7a-aaf5-8acd52b80ee4") },
                    { new Guid("6eb54a51-e2c3-496e-9c14-3b4d59529662"), new Guid("ee256d2d-2d15-4a3c-87e9-7374256470a0") },
                    { new Guid("aee1c6f0-d172-4d33-baa3-f3b94610f9b6"), new Guid("d913f7b8-2963-4f7a-aaf5-8acd52b80ee4") },
                    { new Guid("aee1c6f0-d172-4d33-baa3-f3b94610f9b6"), new Guid("ee256d2d-2d15-4a3c-87e9-7374256470a0") },
                    { new Guid("da777e74-f04e-4a95-92c8-273842897bd4"), new Guid("d913f7b8-2963-4f7a-aaf5-8acd52b80ee4") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("019d460e-fc4e-4189-b8cc-23eb63d78306"), new Guid("63cb9d69-2f54-41a5-8564-1c9794060f03"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("0e0e107a-de79-4060-8bb4-c980e2fcac81"), new Guid("4751b4b4-b8cc-4f41-9ec5-f483a06cfeae"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("1a4ae845-babb-47d9-9b04-97f0b1f7d88d"), new Guid("63cb9d69-2f54-41a5-8564-1c9794060f03"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("1cd5e797-4fea-4321-82ab-a8ca11924e6b"), new Guid("6eb54a51-e2c3-496e-9c14-3b4d59529662"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("392e77e7-11ed-4162-8731-3a9d48192be4"), new Guid("63cb9d69-2f54-41a5-8564-1c9794060f03"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("543fe1e2-0d5e-47b5-a9e4-8fdc3032d2c5"), new Guid("4751b4b4-b8cc-4f41-9ec5-f483a06cfeae"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("5c4c89ad-9e0f-40db-bfe8-b235d980d97d"), new Guid("4751b4b4-b8cc-4f41-9ec5-f483a06cfeae"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("666edbaf-9af5-4012-8af7-b60212541946"), new Guid("da777e74-f04e-4a95-92c8-273842897bd4"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("769e9d87-2bf0-4f4b-87af-b22a81927188"), new Guid("6eb54a51-e2c3-496e-9c14-3b4d59529662"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("8311e53b-f7c5-48f5-9257-3b02ad060bdf"), new Guid("63cb9d69-2f54-41a5-8564-1c9794060f03"), null, true, true, "Место работы", 6, "Название организации", new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("93a8ba57-ea1c-4c68-9f28-526c856a18be"), new Guid("63cb9d69-2f54-41a5-8564-1c9794060f03"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("baf9e003-c1eb-426b-8f66-52f9db19b49f"), new Guid("6eb54a51-e2c3-496e-9c14-3b4d59529662"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("bbe7ce67-d76f-4086-9404-72d4584b14c0"), new Guid("da777e74-f04e-4a95-92c8-273842897bd4"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("bdc21a39-5bcf-4dbd-8462-56fb2a0bfead"), new Guid("63cb9d69-2f54-41a5-8564-1c9794060f03"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("c94f389c-5cd6-4f8c-bc48-b001f39b3b88"), new Guid("63cb9d69-2f54-41a5-8564-1c9794060f03"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("e35da956-df7a-4234-b4f0-99bcad4623a1") },
                    { new Guid("e9a837fe-ae32-4a9a-81d2-dee4c341f330"), new Guid("63cb9d69-2f54-41a5-8564-1c9794060f03"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("ea089abb-ead8-4b47-82bf-ccdaa3b92b96"), new Guid("63cb9d69-2f54-41a5-8564-1c9794060f03"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("f4e50202-b06b-461a-bdc1-876c87aa5891"), new Guid("63cb9d69-2f54-41a5-8564-1c9794060f03"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("14c70270-af4c-4cdf-b86b-d0edf2fd06cf"), new Guid("ee256d2d-2d15-4a3c-87e9-7374256470a0") },
                    { new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14"), new Guid("d913f7b8-2963-4f7a-aaf5-8acd52b80ee4") },
                    { new Guid("3ef15748-de91-45aa-aa34-66dba21db4f9"), new Guid("d913f7b8-2963-4f7a-aaf5-8acd52b80ee4") },
                    { new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95"), new Guid("ee256d2d-2d15-4a3c-87e9-7374256470a0") },
                    { new Guid("91b3af8e-1004-4f85-baae-1e822ef57833"), new Guid("ee256d2d-2d15-4a3c-87e9-7374256470a0") },
                    { new Guid("9d6b4747-90c1-44ab-831a-29404a012be7"), new Guid("d913f7b8-2963-4f7a-aaf5-8acd52b80ee4") },
                    { new Guid("9d6b4747-90c1-44ab-831a-29404a012be7"), new Guid("ee256d2d-2d15-4a3c-87e9-7374256470a0") },
                    { new Guid("b489c041-15b9-49f1-9efa-ae6fada3cd28"), new Guid("d913f7b8-2963-4f7a-aaf5-8acd52b80ee4") },
                    { new Guid("b489c041-15b9-49f1-9efa-ae6fada3cd28"), new Guid("ee256d2d-2d15-4a3c-87e9-7374256470a0") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0d6b01d8-c2b2-4981-94b4-d55e1479fcdf"), new Guid("aee1c6f0-d172-4d33-baa3-f3b94610f9b6"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("0f63fcce-759d-4f8c-bbdb-dbea7bc3978c"), new Guid("4751b4b4-b8cc-4f41-9ec5-f483a06cfeae"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("30c38833-0f80-43ff-a90c-333049816a07"), new Guid("4751b4b4-b8cc-4f41-9ec5-f483a06cfeae"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 },
                    { new Guid("46a5f250-f1d8-4449-bb82-2eefec5a3fe3"), new Guid("4751b4b4-b8cc-4f41-9ec5-f483a06cfeae"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 },
                    { new Guid("5f59bc9f-1f02-40c7-8988-b0d4b5d16b23"), new Guid("4751b4b4-b8cc-4f41-9ec5-f483a06cfeae"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("62935825-d4ef-4c9f-9a47-b5e129b8fd56"), new Guid("02cbb2b5-4d83-412c-9e63-2cb8605da39c"), true, true, "Краткая аннотация конкурсной работы", 1 },
                    { new Guid("7a942551-54d9-4ff7-930e-410046a50488"), new Guid("da777e74-f04e-4a95-92c8-273842897bd4"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("7bd55868-c2ee-4222-9c69-8e7745b5d665"), new Guid("da777e74-f04e-4a95-92c8-273842897bd4"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("a68c47e6-7d30-4f41-836f-03ac4fb5181a"), new Guid("4751b4b4-b8cc-4f41-9ec5-f483a06cfeae"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 },
                    { new Guid("c8ac826d-5717-43b9-b581-9df3e50354a6"), new Guid("da777e74-f04e-4a95-92c8-273842897bd4"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("de0dd325-f661-4a8c-9cda-ce460d1b7856"), new Guid("aee1c6f0-d172-4d33-baa3-f3b94610f9b6"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("eb0beede-75fa-4c4b-89bf-57fec64a47e4"), new Guid("aee1c6f0-d172-4d33-baa3-f3b94610f9b6"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 },
                    { new Guid("eeb6911c-e106-4eef-9862-55b0e08b49ed"), new Guid("da777e74-f04e-4a95-92c8-273842897bd4"), false, false, "Список научных публикаций за последние 5 лет", 10 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0013f533-661b-4b36-aa76-9e3b4b414d57"), true, "Итого (час.)", 5, new Guid("5f59bc9f-1f02-40c7-8988-b0d4b5d16b23"), new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("06a5dae0-5524-4787-8de0-0e3c2f34d388"), true, "Название документа, реквизиты", 1, new Guid("de0dd325-f661-4a8c-9cda-ce460d1b7856"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("082651d9-007c-4578-8115-c3d68877a303"), false, "Соавторы", 3, new Guid("a68c47e6-7d30-4f41-836f-03ac4fb5181a"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("1b0303f3-88af-409e-b7d5-3f7266b68ec2"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("46a5f250-f1d8-4449-bb82-2eefec5a3fe3"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("279b31ba-12d3-42a4-9fe0-1e244a0e4e6f"), true, "Год", 1, new Guid("eb0beede-75fa-4c4b-89bf-57fec64a47e4"), new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("2afbebf7-206f-46a0-bf23-5dfe7bffb7e7"), true, "Год", 3, new Guid("46a5f250-f1d8-4449-bb82-2eefec5a3fe3"), new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("2bcd4a4c-df5e-48bd-89f2-6b943034d81b"), true, "Статус", 4, new Guid("7a942551-54d9-4ff7-930e-410046a50488"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("343483c0-56c4-4f06-ae21-df0e31c77649"), true, "ФИО", 1, new Guid("46a5f250-f1d8-4449-bb82-2eefec5a3fe3"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("43803922-5e12-4bc7-bb47-457e0b33d745"), true, "Название", 2, new Guid("7bd55868-c2ee-4222-9c69-8e7745b5d665"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("4b5b91b6-5152-4c82-9444-05b01a8133f1"), true, "Статус конкурса", 3, new Guid("eb0beede-75fa-4c4b-89bf-57fec64a47e4"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("56c16b2a-c8ea-4550-a1d0-cef732eecc22"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("46a5f250-f1d8-4449-bb82-2eefec5a3fe3"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("5830aa6b-a9dd-475b-a7fb-1f1c236908c4"), false, "Идентификатор", 2, new Guid("0d6b01d8-c2b2-4981-94b4-d55e1479fcdf"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("58342579-4980-4a2a-9722-c91bcbf07ff1"), true, "Название дисциплины", 1, new Guid("30c38833-0f80-43ff-a90c-333049816a07"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("583569cf-aed3-4bf4-b20b-d3108830bb46"), true, "Значение", 2, new Guid("62935825-d4ef-4c9f-9a47-b5e129b8fd56"), new Guid("7876653e-40c9-432f-895a-54ad9422a34c") },
                    { new Guid("5c084d49-aaf8-47a1-8655-4c9fd4065833"), true, "Период выполнения", 3, new Guid("7a942551-54d9-4ff7-930e-410046a50488"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("5fa607b3-fc38-47f9-81af-e0c7f0e09e30"), true, "Название НИР/НИОКР", 1, new Guid("7a942551-54d9-4ff7-930e-410046a50488"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("67f06a57-b09c-4ce0-927f-c882b9c57e22"), true, "Ссылка", 5, new Guid("eb0beede-75fa-4c4b-89bf-57fec64a47e4"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("74e9ba44-3b8e-484b-9e13-633773de8707"), true, "Лекции (час.)", 3, new Guid("5f59bc9f-1f02-40c7-8988-b0d4b5d16b23"), new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("7a906850-8883-4d6c-9611-a59d51e92945"), true, "Год получения документа", 2, new Guid("de0dd325-f661-4a8c-9cda-ce460d1b7856"), new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("80ae6aeb-0130-48e4-83f7-aeff92127b29"), true, "Язык публикации", 7, new Guid("a68c47e6-7d30-4f41-836f-03ac4fb5181a"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("82f58982-d990-4bb1-95e0-d2cfae3acccf"), true, "Название разработки", 2, new Guid("c8ac826d-5717-43b9-b581-9df3e50354a6"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("852c97be-eba1-437b-b496-f855b4e2e886"), true, "Номер РИД", 4, new Guid("7bd55868-c2ee-4222-9c69-8e7745b5d665"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("8966b28a-de8a-4553-ad7c-446a34935a73"), false, "Тип идентификатора", 1, new Guid("0d6b01d8-c2b2-4981-94b4-d55e1479fcdf"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("8c7a01cf-6fdf-4860-8e46-84239c5c309f"), true, "Название конкурса", 2, new Guid("eb0beede-75fa-4c4b-89bf-57fec64a47e4"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("95d5dbcb-5194-4de6-9f19-e3f8adfd2854"), true, "Вид публикации", 1, new Guid("a68c47e6-7d30-4f41-836f-03ac4fb5181a"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("9c3516ea-4436-4178-8eb3-d9074ae90593"), true, "Практические занятия (час.)", 4, new Guid("5f59bc9f-1f02-40c7-8988-b0d4b5d16b23"), new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("a7287ec4-8f31-4ed4-8878-d3c339615088"), true, "Название организации в которую внедрена разработка", 3, new Guid("c8ac826d-5717-43b9-b581-9df3e50354a6"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("a823a5cf-8d94-48ad-b4c3-14ff77137df0"), true, "Количество печатных листов", 4, new Guid("a68c47e6-7d30-4f41-836f-03ac4fb5181a"), new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("aa5966e6-14e7-430b-bfca-3fe887b55c74"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("7a942551-54d9-4ff7-930e-410046a50488"), new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("b1fdab69-5355-44bd-b1fc-850adc2f7519"), true, "Ссылка на платформу", 3, new Guid("0f63fcce-759d-4f8c-bbdb-dbea7bc3978c"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("b2fac289-6915-4c62-b201-ba0deb8a856b"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("7a942551-54d9-4ff7-930e-410046a50488"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("b6c07694-09c6-4d5b-a090-2c127d1dec3b"), true, "Вид", 1, new Guid("7bd55868-c2ee-4222-9c69-8e7745b5d665"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("bb6edd75-5a6d-4d1f-8071-71edf7bc806b"), true, "Издание, год", 4, new Guid("eeb6911c-e106-4eef-9862-55b0e08b49ed"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("bc966b65-802a-4c0c-8030-ec5127a7359a"), true, "Соавторы", 2, new Guid("0f63fcce-759d-4f8c-bbdb-dbea7bc3978c"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("be3675f8-b0aa-488c-b97c-d790096faf06"), true, "ФИО соавторов", 3, new Guid("7bd55868-c2ee-4222-9c69-8e7745b5d665"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("bf7aae8e-da7b-46e6-a09a-1c82636b5eff"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("30c38833-0f80-43ff-a90c-333049816a07"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("c5896183-0556-4ddb-b8db-59474d7ea69b"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("eb0beede-75fa-4c4b-89bf-57fec64a47e4"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("c7978997-edb1-46d0-9432-60d6a7a11610"), true, "Название", 1, new Guid("62935825-d4ef-4c9f-9a47-b5e129b8fd56"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("d46939c4-cad0-40a5-a4b4-918115842cd1"), true, "Вид", 1, new Guid("c8ac826d-5717-43b9-b581-9df3e50354a6"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("d4fa0af8-f9c1-41ed-8822-30ac421927ea"), true, "Название", 2, new Guid("a68c47e6-7d30-4f41-836f-03ac4fb5181a"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("d57d17ed-3c9f-4e6a-bd51-a0ad1ee79c99"), true, "Ссылка на открытый доступ", 8, new Guid("a68c47e6-7d30-4f41-836f-03ac4fb5181a"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("d66cdc4f-e702-4d3e-9258-47bf0aa734da"), true, "Наименование курса", 1, new Guid("5f59bc9f-1f02-40c7-8988-b0d4b5d16b23"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("d7305ec9-9b9f-4f18-95d3-707580f14522"), true, "Год", 4, new Guid("0f63fcce-759d-4f8c-bbdb-dbea7bc3978c"), new Guid("3b6005a3-6de8-498a-8282-9e315b856b90") },
                    { new Guid("d8725bc0-fe00-465f-9054-071545a06363"), true, "Издательство, год", 6, new Guid("a68c47e6-7d30-4f41-836f-03ac4fb5181a"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("dc54dc56-5bcc-4f76-a43a-d9fd97c981a1"), true, "Вид", 2, new Guid("30c38833-0f80-43ff-a90c-333049816a07"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("df389a80-4299-44c9-b93e-65a442277b0b"), true, "Соавторы", 2, new Guid("eeb6911c-e106-4eef-9862-55b0e08b49ed"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("e017de26-7c6f-4ef4-b01c-f847ba48ec91"), true, "Название курса", 1, new Guid("0f63fcce-759d-4f8c-bbdb-dbea7bc3978c"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("e554e881-f688-4839-8dfc-b11da695230b"), true, "Язык преподавания", 2, new Guid("5f59bc9f-1f02-40c7-8988-b0d4b5d16b23"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("ef33b13e-6f20-42a3-8b40-a3ed1b72cc99"), true, "Название конкурса/премии", 2, new Guid("46a5f250-f1d8-4449-bb82-2eefec5a3fe3"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("f3d117ee-6bd3-4bcc-8a92-b1e8e4eaadd1"), true, "Название статьи", 1, new Guid("eeb6911c-e106-4eef-9862-55b0e08b49ed"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") },
                    { new Guid("f9146a70-ae0c-4477-aee3-c031ad29efa0"), true, "Наличие грифа", 5, new Guid("a68c47e6-7d30-4f41-836f-03ac4fb5181a"), new Guid("f296d010-7248-4ad2-a3e3-10f6825f9617") },
                    { new Guid("ffcbde6c-027b-4134-90d2-e74417e2cb8b"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("eeb6911c-e106-4eef-9862-55b0e08b49ed"), new Guid("a9f78d42-83e4-4837-8f58-fab74440f7b5") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("019d460e-fc4e-4189-b8cc-23eb63d78306"), new Guid("9d6b4747-90c1-44ab-831a-29404a012be7") },
                    { new Guid("0e0e107a-de79-4060-8bb4-c980e2fcac81"), new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95") },
                    { new Guid("1a4ae845-babb-47d9-9b04-97f0b1f7d88d"), new Guid("9d6b4747-90c1-44ab-831a-29404a012be7") },
                    { new Guid("1cd5e797-4fea-4321-82ab-a8ca11924e6b"), new Guid("9d6b4747-90c1-44ab-831a-29404a012be7") },
                    { new Guid("392e77e7-11ed-4162-8731-3a9d48192be4"), new Guid("9d6b4747-90c1-44ab-831a-29404a012be7") },
                    { new Guid("543fe1e2-0d5e-47b5-a9e4-8fdc3032d2c5"), new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95") },
                    { new Guid("5c4c89ad-9e0f-40db-bfe8-b235d980d97d"), new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95") },
                    { new Guid("666edbaf-9af5-4012-8af7-b60212541946"), new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14") },
                    { new Guid("769e9d87-2bf0-4f4b-87af-b22a81927188"), new Guid("14c70270-af4c-4cdf-b86b-d0edf2fd06cf") },
                    { new Guid("769e9d87-2bf0-4f4b-87af-b22a81927188"), new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14") },
                    { new Guid("769e9d87-2bf0-4f4b-87af-b22a81927188"), new Guid("9d6b4747-90c1-44ab-831a-29404a012be7") },
                    { new Guid("8311e53b-f7c5-48f5-9257-3b02ad060bdf"), new Guid("9d6b4747-90c1-44ab-831a-29404a012be7") },
                    { new Guid("93a8ba57-ea1c-4c68-9f28-526c856a18be"), new Guid("9d6b4747-90c1-44ab-831a-29404a012be7") },
                    { new Guid("baf9e003-c1eb-426b-8f66-52f9db19b49f"), new Guid("9d6b4747-90c1-44ab-831a-29404a012be7") },
                    { new Guid("bbe7ce67-d76f-4086-9404-72d4584b14c0"), new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14") },
                    { new Guid("bdc21a39-5bcf-4dbd-8462-56fb2a0bfead"), new Guid("9d6b4747-90c1-44ab-831a-29404a012be7") },
                    { new Guid("c94f389c-5cd6-4f8c-bc48-b001f39b3b88"), new Guid("9d6b4747-90c1-44ab-831a-29404a012be7") },
                    { new Guid("e9a837fe-ae32-4a9a-81d2-dee4c341f330"), new Guid("9d6b4747-90c1-44ab-831a-29404a012be7") },
                    { new Guid("ea089abb-ead8-4b47-82bf-ccdaa3b92b96"), new Guid("9d6b4747-90c1-44ab-831a-29404a012be7") },
                    { new Guid("f4e50202-b06b-461a-bdc1-876c87aa5891"), new Guid("9d6b4747-90c1-44ab-831a-29404a012be7") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("14c70270-af4c-4cdf-b86b-d0edf2fd06cf"), new Guid("de0dd325-f661-4a8c-9cda-ce460d1b7856") },
                    { new Guid("14c70270-af4c-4cdf-b86b-d0edf2fd06cf"), new Guid("eb0beede-75fa-4c4b-89bf-57fec64a47e4") },
                    { new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14"), new Guid("0d6b01d8-c2b2-4981-94b4-d55e1479fcdf") },
                    { new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14"), new Guid("7a942551-54d9-4ff7-930e-410046a50488") },
                    { new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14"), new Guid("eb0beede-75fa-4c4b-89bf-57fec64a47e4") },
                    { new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14"), new Guid("eeb6911c-e106-4eef-9862-55b0e08b49ed") },
                    { new Guid("3ef15748-de91-45aa-aa34-66dba21db4f9"), new Guid("7bd55868-c2ee-4222-9c69-8e7745b5d665") },
                    { new Guid("3ef15748-de91-45aa-aa34-66dba21db4f9"), new Guid("c8ac826d-5717-43b9-b581-9df3e50354a6") },
                    { new Guid("3ef15748-de91-45aa-aa34-66dba21db4f9"), new Guid("de0dd325-f661-4a8c-9cda-ce460d1b7856") },
                    { new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95"), new Guid("0f63fcce-759d-4f8c-bbdb-dbea7bc3978c") },
                    { new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95"), new Guid("46a5f250-f1d8-4449-bb82-2eefec5a3fe3") },
                    { new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95"), new Guid("5f59bc9f-1f02-40c7-8988-b0d4b5d16b23") },
                    { new Guid("91b3af8e-1004-4f85-baae-1e822ef57833"), new Guid("30c38833-0f80-43ff-a90c-333049816a07") },
                    { new Guid("91b3af8e-1004-4f85-baae-1e822ef57833"), new Guid("a68c47e6-7d30-4f41-836f-03ac4fb5181a") },
                    { new Guid("b489c041-15b9-49f1-9efa-ae6fada3cd28"), new Guid("62935825-d4ef-4c9f-9a47-b5e129b8fd56") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0407b820-a80a-4dda-a4d3-1d41ab1150f9"), "EvaluateMark3", new Guid("0e0e107a-de79-4060-8bb4-c980e2fcac81"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("042d25b8-72d4-4e4f-aca7-ce427b4cfb82"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("a68c47e6-7d30-4f41-836f-03ac4fb5181a") },
                    { new Guid("17f28762-b7f9-47ae-9224-ce8f13add82a"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("30c38833-0f80-43ff-a90c-333049816a07") },
                    { new Guid("3a67c6a7-eb06-4baf-b70a-efe3f8dd3edc"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("eb0beede-75fa-4c4b-89bf-57fec64a47e4") },
                    { new Guid("414b117e-1122-43ea-80de-ed48548c6161"), "EvaluateMark5", new Guid("5c4c89ad-9e0f-40db-bfe8-b235d980d97d"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("43e2ff93-450f-4552-84fb-bcda427c6951"), "EvaluateMark19", new Guid("666edbaf-9af5-4012-8af7-b60212541946"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("4567bca9-0036-4836-bb0a-0f34a0a20851"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("c8ac826d-5717-43b9-b581-9df3e50354a6") },
                    { new Guid("4d89c663-0897-4e57-a7c9-5705ca76d662"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("a68c47e6-7d30-4f41-836f-03ac4fb5181a") },
                    { new Guid("4e65b7b9-3ffa-4f25-a437-b0768c008861"), "EvaluateMark4", new Guid("543fe1e2-0d5e-47b5-a9e4-8fdc3032d2c5"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("552b0831-0964-47a5-84f0-b2401aa10033"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом и без соавторства:", 8, new Guid("a68c47e6-7d30-4f41-836f-03ac4fb5181a") },
                    { new Guid("72248509-ee14-48c0-a985-4713301883f0"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("7bd55868-c2ee-4222-9c69-8e7745b5d665") },
                    { new Guid("7de98bd8-5c90-4ebb-a9ce-9d432eaabe9a"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("a68c47e6-7d30-4f41-836f-03ac4fb5181a") },
                    { new Guid("90bf144c-7141-44c6-9a8e-090516507507"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("5f59bc9f-1f02-40c7-8988-b0d4b5d16b23") },
                    { new Guid("90c2694c-1130-4066-890d-a0c7552d30df"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("62935825-d4ef-4c9f-9a47-b5e129b8fd56") },
                    { new Guid("98e4e82c-c880-4aa9-be09-dd71877242d7"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("7a942551-54d9-4ff7-930e-410046a50488") },
                    { new Guid("a06763c1-5166-4f11-8f38-d59416fe586b"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("eeb6911c-e106-4eef-9862-55b0e08b49ed") },
                    { new Guid("bb63f58c-9606-41d2-9431-bf53bfadbd88"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("7a942551-54d9-4ff7-930e-410046a50488") },
                    { new Guid("c3f40036-e3e8-48a5-b966-32063713a580"), "EvaluateMark13", new Guid("769e9d87-2bf0-4f4b-87af-b22a81927188"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("c94f8f1a-f4e8-4493-b10d-9031c448c0c2"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("46a5f250-f1d8-4449-bb82-2eefec5a3fe3") },
                    { new Guid("ca6b2ece-72eb-4d52-989c-68ec19201a5e"), "EvaluateMark20", new Guid("bbe7ce67-d76f-4086-9404-72d4584b14c0"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("cbb91061-a0ef-4805-905d-77feb9048c9b"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("de0dd325-f661-4a8c-9cda-ce460d1b7856") },
                    { new Guid("ed92348d-11f5-409e-8f52-d61f0c150dc7"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("5f59bc9f-1f02-40c7-8988-b0d4b5d16b23") },
                    { new Guid("f3f4bf12-836d-4a7b-a9be-bb6ad2da7ab6"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("0f63fcce-759d-4f8c-bbdb-dbea7bc3978c") },
                    { new Guid("fdc291e2-00e1-4008-8772-433cdd1aff4b"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("62935825-d4ef-4c9f-9a47-b5e129b8fd56") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "TableId" },
                values: new object[,]
                {
                    { new Guid("20653146-eda0-488e-9895-d3ad157f5478"), true, new Guid("62935825-d4ef-4c9f-9a47-b5e129b8fd56") },
                    { new Guid("27ae2bf7-b2bb-4b2d-8996-114a9aecd633"), true, new Guid("62935825-d4ef-4c9f-9a47-b5e129b8fd56") },
                    { new Guid("5c41cc41-6002-447c-b3b7-8c689d27fa32"), true, new Guid("62935825-d4ef-4c9f-9a47-b5e129b8fd56") },
                    { new Guid("67051994-66a3-41f3-bd13-33169d94da80"), true, new Guid("0d6b01d8-c2b2-4981-94b4-d55e1479fcdf") },
                    { new Guid("696b0289-a660-464b-81bb-560af17852b2"), true, new Guid("0d6b01d8-c2b2-4981-94b4-d55e1479fcdf") },
                    { new Guid("743f31b8-8e93-4ba2-9818-56dc3be8dd70"), true, new Guid("62935825-d4ef-4c9f-9a47-b5e129b8fd56") },
                    { new Guid("93e9e782-5e2c-41d1-be83-14e3defb96e7"), true, new Guid("0d6b01d8-c2b2-4981-94b4-d55e1479fcdf") },
                    { new Guid("95854a17-33f2-41a8-af19-f7239bd63b05"), true, new Guid("62935825-d4ef-4c9f-9a47-b5e129b8fd56") },
                    { new Guid("997edd44-795d-4fa5-8b76-b97551aed762"), true, new Guid("0d6b01d8-c2b2-4981-94b4-d55e1479fcdf") },
                    { new Guid("b8d14532-e69d-491e-b9eb-78f2f8c66194"), true, new Guid("62935825-d4ef-4c9f-9a47-b5e129b8fd56") },
                    { new Guid("eabdc2d6-8675-47b0-8435-49452474fbee"), true, new Guid("62935825-d4ef-4c9f-9a47-b5e129b8fd56") },
                    { new Guid("eef130a2-6c21-4a6c-b4c4-a8742423834e"), true, new Guid("0d6b01d8-c2b2-4981-94b4-d55e1479fcdf") },
                    { new Guid("f938f750-1014-42ee-b97e-71dea3a1a67c"), true, new Guid("62935825-d4ef-4c9f-9a47-b5e129b8fd56") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("02c22160-2c72-4b5c-b7e5-8022d99b02d0"), null, new Guid("769e9d87-2bf0-4f4b-87af-b22a81927188"), "Профессор" },
                    { new Guid("41e778ca-b531-498c-9227-b1575be57719"), null, new Guid("1cd5e797-4fea-4321-82ab-a8ca11924e6b"), "Кандидат наук" },
                    { new Guid("c1d1ecf4-6b64-4909-942e-1e2c8310783d"), null, new Guid("1cd5e797-4fea-4321-82ab-a8ca11924e6b"), "Доктор наук" },
                    { new Guid("df0f01fa-b6db-48ca-b12f-5d4091660882"), null, new Guid("769e9d87-2bf0-4f4b-87af-b22a81927188"), "Доцент" },
                    { new Guid("eb57eefd-23a0-4d8c-8186-dbc5b5211fb8"), null, new Guid("769e9d87-2bf0-4f4b-87af-b22a81927188"), "Нет" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("0edbdfee-deaf-48bd-ac98-9357c5ef8e51"), null, new Guid("c7978997-edb1-46d0-9432-60d6a7a11610"), true, true, new Guid("f938f750-1014-42ee-b97e-71dea3a1a67c"), "Название работы" },
                    { new Guid("25e391ea-e8f5-4c4e-b640-ef54c11fd788"), null, new Guid("583569cf-aed3-4bf4-b20b-d3108830bb46"), false, true, new Guid("b8d14532-e69d-491e-b9eb-78f2f8c66194"), null },
                    { new Guid("2b60f982-0cf6-4b51-9f6f-74d85e146d19"), null, new Guid("583569cf-aed3-4bf4-b20b-d3108830bb46"), false, true, new Guid("5c41cc41-6002-447c-b3b7-8c689d27fa32"), null },
                    { new Guid("4f89acef-fa07-4f1e-a7d7-7a89c1e99416"), null, new Guid("583569cf-aed3-4bf4-b20b-d3108830bb46"), false, true, new Guid("743f31b8-8e93-4ba2-9818-56dc3be8dd70"), null },
                    { new Guid("54d1b75a-e85a-415f-a2de-c1fd253b8e68"), null, new Guid("8966b28a-de8a-4553-ad7c-446a34935a73"), true, true, new Guid("696b0289-a660-464b-81bb-560af17852b2"), "ResearcherID" },
                    { new Guid("6d566707-89b7-4182-8052-065fd53af44e"), null, new Guid("583569cf-aed3-4bf4-b20b-d3108830bb46"), false, true, new Guid("20653146-eda0-488e-9895-d3ad157f5478"), null },
                    { new Guid("73779e7c-17f5-4554-ac16-130aa4f44aec"), null, new Guid("c7978997-edb1-46d0-9432-60d6a7a11610"), true, true, new Guid("5c41cc41-6002-447c-b3b7-8c689d27fa32"), "Инновационность" },
                    { new Guid("73f39748-de48-49a5-9f3a-ab09e104bd50"), null, new Guid("583569cf-aed3-4bf4-b20b-d3108830bb46"), false, true, new Guid("f938f750-1014-42ee-b97e-71dea3a1a67c"), null },
                    { new Guid("78ef06d9-d4b8-41b9-90b5-42f4b68ce653"), null, new Guid("5830aa6b-a9dd-475b-a7fb-1f1c236908c4"), false, true, new Guid("696b0289-a660-464b-81bb-560af17852b2"), null },
                    { new Guid("80819b4c-c58c-4a6c-b8a3-cfe141f1d0a5"), null, new Guid("c7978997-edb1-46d0-9432-60d6a7a11610"), true, true, new Guid("95854a17-33f2-41a8-af19-f7239bd63b05"), "Методология и методы, используемые в работе" },
                    { new Guid("8b3d6cbe-0e49-4dd4-8722-083ef1ac088b"), null, new Guid("583569cf-aed3-4bf4-b20b-d3108830bb46"), false, true, new Guid("eabdc2d6-8675-47b0-8435-49452474fbee"), null },
                    { new Guid("903e52db-1906-43ef-ad6a-b9a5cf5d838e"), null, new Guid("5830aa6b-a9dd-475b-a7fb-1f1c236908c4"), false, true, new Guid("93e9e782-5e2c-41d1-be83-14e3defb96e7"), null },
                    { new Guid("96863b7d-7d5f-4311-b9ff-3fef2d69c0d4"), null, new Guid("583569cf-aed3-4bf4-b20b-d3108830bb46"), false, true, new Guid("27ae2bf7-b2bb-4b2d-8996-114a9aecd633"), null },
                    { new Guid("99d4ed29-d875-41ab-b760-a7630ddb2558"), null, new Guid("8966b28a-de8a-4553-ad7c-446a34935a73"), true, true, new Guid("eef130a2-6c21-4a6c-b4c4-a8742423834e"), "Google Scholar ID" },
                    { new Guid("a0825153-fc6c-45b3-b987-22a632bf5e0a"), null, new Guid("5830aa6b-a9dd-475b-a7fb-1f1c236908c4"), false, true, new Guid("eef130a2-6c21-4a6c-b4c4-a8742423834e"), null },
                    { new Guid("b37d6f13-e8a5-4c62-b6fc-61ff697b77e5"), null, new Guid("8966b28a-de8a-4553-ad7c-446a34935a73"), true, true, new Guid("67051994-66a3-41f3-bd13-33169d94da80"), "ScopusID" },
                    { new Guid("c8504f8e-718c-4ecd-8057-551afd3e4f07"), null, new Guid("c7978997-edb1-46d0-9432-60d6a7a11610"), true, true, new Guid("eabdc2d6-8675-47b0-8435-49452474fbee"), "Возможность практического применения (Внедрено ли в практику? В какому курсе/программе подготовки используется/ на кого рассчитано)" },
                    { new Guid("cb36a518-174f-4439-b6f2-a9ab667d1d88"), null, new Guid("8966b28a-de8a-4553-ad7c-446a34935a73"), true, true, new Guid("997edd44-795d-4fa5-8b76-b97551aed762"), "ORCiD" },
                    { new Guid("cdf08a79-dc10-49b9-b582-b0253cc0c403"), null, new Guid("c7978997-edb1-46d0-9432-60d6a7a11610"), true, true, new Guid("27ae2bf7-b2bb-4b2d-8996-114a9aecd633"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("d82e925d-f177-40cc-b438-336c124dee72"), null, new Guid("583569cf-aed3-4bf4-b20b-d3108830bb46"), false, true, new Guid("95854a17-33f2-41a8-af19-f7239bd63b05"), null },
                    { new Guid("d902c4c7-2943-4716-b926-2497fe38cb7d"), null, new Guid("c7978997-edb1-46d0-9432-60d6a7a11610"), true, true, new Guid("743f31b8-8e93-4ba2-9818-56dc3be8dd70"), "Ссылка на конкурсную работу" },
                    { new Guid("dbb2ee6c-a266-4eb8-9472-12da49ffa80a"), null, new Guid("c7978997-edb1-46d0-9432-60d6a7a11610"), true, true, new Guid("b8d14532-e69d-491e-b9eb-78f2f8c66194"), "Результаты и выводы" },
                    { new Guid("de0d9c8b-cf68-424e-b435-8ec28404fe0d"), null, new Guid("5830aa6b-a9dd-475b-a7fb-1f1c236908c4"), false, true, new Guid("67051994-66a3-41f3-bd13-33169d94da80"), null },
                    { new Guid("e0299bfb-3998-4364-b03d-6c12eb83fde0"), null, new Guid("c7978997-edb1-46d0-9432-60d6a7a11610"), true, true, new Guid("20653146-eda0-488e-9895-d3ad157f5478"), "Актуальность конкурсной работы" },
                    { new Guid("ea5fedae-baa1-4a9a-927c-94a6c845c8ca"), null, new Guid("5830aa6b-a9dd-475b-a7fb-1f1c236908c4"), false, true, new Guid("997edd44-795d-4fa5-8b76-b97551aed762"), null },
                    { new Guid("f4e2d906-f148-4973-be01-c48c15518d36"), null, new Guid("8966b28a-de8a-4553-ad7c-446a34935a73"), true, true, new Guid("93e9e782-5e2c-41d1-be83-14e3defb96e7"), "РИНЦ AuthorID" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("14c70270-af4c-4cdf-b86b-d0edf2fd06cf"), new Guid("3a67c6a7-eb06-4baf-b70a-efe3f8dd3edc") },
                    { new Guid("14c70270-af4c-4cdf-b86b-d0edf2fd06cf"), new Guid("c3f40036-e3e8-48a5-b966-32063713a580") },
                    { new Guid("14c70270-af4c-4cdf-b86b-d0edf2fd06cf"), new Guid("cbb91061-a0ef-4805-905d-77feb9048c9b") },
                    { new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14"), new Guid("3a67c6a7-eb06-4baf-b70a-efe3f8dd3edc") },
                    { new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14"), new Guid("43e2ff93-450f-4552-84fb-bcda427c6951") },
                    { new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14"), new Guid("98e4e82c-c880-4aa9-be09-dd71877242d7") },
                    { new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14"), new Guid("a06763c1-5166-4f11-8f38-d59416fe586b") },
                    { new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14"), new Guid("bb63f58c-9606-41d2-9431-bf53bfadbd88") },
                    { new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14"), new Guid("c3f40036-e3e8-48a5-b966-32063713a580") },
                    { new Guid("210d4982-0674-4727-883b-cc6ba1a8ad14"), new Guid("ca6b2ece-72eb-4d52-989c-68ec19201a5e") },
                    { new Guid("3ef15748-de91-45aa-aa34-66dba21db4f9"), new Guid("4567bca9-0036-4836-bb0a-0f34a0a20851") },
                    { new Guid("3ef15748-de91-45aa-aa34-66dba21db4f9"), new Guid("72248509-ee14-48c0-a985-4713301883f0") },
                    { new Guid("3ef15748-de91-45aa-aa34-66dba21db4f9"), new Guid("cbb91061-a0ef-4805-905d-77feb9048c9b") },
                    { new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95"), new Guid("0407b820-a80a-4dda-a4d3-1d41ab1150f9") },
                    { new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95"), new Guid("414b117e-1122-43ea-80de-ed48548c6161") },
                    { new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95"), new Guid("4e65b7b9-3ffa-4f25-a437-b0768c008861") },
                    { new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95"), new Guid("90bf144c-7141-44c6-9a8e-090516507507") },
                    { new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95"), new Guid("c94f8f1a-f4e8-4493-b10d-9031c448c0c2") },
                    { new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95"), new Guid("ed92348d-11f5-409e-8f52-d61f0c150dc7") },
                    { new Guid("6e8b61a7-73a5-4da5-9114-a506063ace95"), new Guid("f3f4bf12-836d-4a7b-a9be-bb6ad2da7ab6") },
                    { new Guid("91b3af8e-1004-4f85-baae-1e822ef57833"), new Guid("042d25b8-72d4-4e4f-aca7-ce427b4cfb82") },
                    { new Guid("91b3af8e-1004-4f85-baae-1e822ef57833"), new Guid("17f28762-b7f9-47ae-9224-ce8f13add82a") },
                    { new Guid("91b3af8e-1004-4f85-baae-1e822ef57833"), new Guid("4d89c663-0897-4e57-a7c9-5705ca76d662") },
                    { new Guid("91b3af8e-1004-4f85-baae-1e822ef57833"), new Guid("552b0831-0964-47a5-84f0-b2401aa10033") },
                    { new Guid("91b3af8e-1004-4f85-baae-1e822ef57833"), new Guid("7de98bd8-5c90-4ebb-a9ce-9d432eaabe9a") },
                    { new Guid("b489c041-15b9-49f1-9efa-ae6fada3cd28"), new Guid("90c2694c-1130-4066-890d-a0c7552d30df") },
                    { new Guid("b489c041-15b9-49f1-9efa-ae6fada3cd28"), new Guid("fdc291e2-00e1-4008-8772-433cdd1aff4b") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0762bd02-5c16-40af-9cb1-8c8706a5bd17"), new Guid("95d5dbcb-5194-4de6-9f19-e3f8adfd2854"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("14ed240c-7b81-4eb6-aa3e-fe57a914d231"), new Guid("e554e881-f688-4839-8dfc-b11da695230b"), null, "Русский" },
                    { new Guid("204f8e77-3282-4ee4-afcd-8e450cd4fc90"), new Guid("95d5dbcb-5194-4de6-9f19-e3f8adfd2854"), null, "Учебник" },
                    { new Guid("24b63ee9-674b-48d6-9cff-038ff77b0ad9"), new Guid("ffcbde6c-027b-4134-90d2-e74417e2cb8b"), null, "МБД (Q3-Q4)" },
                    { new Guid("29012b35-1183-4ac7-8ac3-fa464b11c250"), new Guid("d46939c4-cad0-40a5-a4b4-918115842cd1"), null, "Полезная модель" },
                    { new Guid("3c02706d-8098-47a9-8677-1349655097a6"), new Guid("d46939c4-cad0-40a5-a4b4-918115842cd1"), null, "Изобретение" },
                    { new Guid("46f02232-e24b-419e-bf8f-49cee4cb329c"), new Guid("f9146a70-ae0c-4477-aee3-c031ad29efa0"), null, "Есть" },
                    { new Guid("4e6e1aed-6409-403e-9b79-11a01f021fa5"), new Guid("4b5b91b6-5152-4c82-9444-05b01a8133f1"), null, "Региональный" },
                    { new Guid("5211ec2c-f254-47cb-abb8-91e011df8a41"), new Guid("d46939c4-cad0-40a5-a4b4-918115842cd1"), null, "Промышленный образец" },
                    { new Guid("539ecf2b-3bf8-4708-8b5b-6b16f8ab5e7b"), new Guid("b6c07694-09c6-4d5b-a090-2c127d1dec3b"), null, "Полезная модель" },
                    { new Guid("5ddbcd3e-ab99-47a7-bac3-a13b1a611a9e"), new Guid("ffcbde6c-027b-4134-90d2-e74417e2cb8b"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("611f6bbe-7b19-4683-b2bb-fec73589b28b"), new Guid("80ae6aeb-0130-48e4-83f7-aeff92127b29"), null, "Иностранный" },
                    { new Guid("6f2873de-fe36-4110-8e90-6fe0619ef047"), new Guid("dc54dc56-5bcc-4f76-a43a-d9fd97c981a1"), null, "Лекции" },
                    { new Guid("6fd3e0b3-c6e3-4461-a60e-bd1ece253153"), new Guid("d46939c4-cad0-40a5-a4b4-918115842cd1"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("7feec527-5835-407a-86d1-6b08faf05c4b"), new Guid("2bcd4a4c-df5e-48bd-89f2-6b943034d81b"), null, "Руководитель" },
                    { new Guid("8bd3503b-6196-4017-b936-76b50ad0c1b5"), new Guid("dc54dc56-5bcc-4f76-a43a-d9fd97c981a1"), null, "Лабораторные" },
                    { new Guid("8ee8361d-d765-4bf0-aef1-df2395eea42a"), new Guid("082651d9-007c-4578-8115-c3d68877a303"), null, "Нет" },
                    { new Guid("96c385bc-7fe7-419a-898d-02c6c73d7002"), new Guid("b6c07694-09c6-4d5b-a090-2c127d1dec3b"), null, "Промышленный образец" },
                    { new Guid("999f2b11-4962-49e1-a54a-05458f822ab5"), new Guid("4b5b91b6-5152-4c82-9444-05b01a8133f1"), null, "Всероссийский" },
                    { new Guid("9a616536-c7bf-42b6-ab48-e84e048a455f"), new Guid("ffcbde6c-027b-4134-90d2-e74417e2cb8b"), null, "ВАК (К2-К3)" },
                    { new Guid("9cc7361f-83e8-45b8-a16a-f5de92f5e7bc"), new Guid("082651d9-007c-4578-8115-c3d68877a303"), null, "Есть" },
                    { new Guid("9d81f355-852b-4de2-b6e0-1014bfb9b1d7"), new Guid("f9146a70-ae0c-4477-aee3-c031ad29efa0"), null, "Нет" },
                    { new Guid("a6bab86b-4376-486f-ac59-b5a1dc0e1582"), new Guid("95d5dbcb-5194-4de6-9f19-e3f8adfd2854"), null, "Монография" },
                    { new Guid("c286e4ea-9212-4a26-b0c8-a87d9478d86c"), new Guid("b6c07694-09c6-4d5b-a090-2c127d1dec3b"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("cbdbfdec-1dfd-4158-a190-312b2099d5a7"), new Guid("2bcd4a4c-df5e-48bd-89f2-6b943034d81b"), null, "Исполнитель" },
                    { new Guid("d08c3b88-8162-4f9e-ad7f-3f85a97e1601"), new Guid("b6c07694-09c6-4d5b-a090-2c127d1dec3b"), null, "Изобретение" },
                    { new Guid("d7251aa5-e2b4-483a-b462-2ef74b6a7e97"), new Guid("df389a80-4299-44c9-b93e-65a442277b0b"), null, "Есть" },
                    { new Guid("e0a7059b-f3d0-4160-b702-a0b08f35ff1d"), new Guid("e554e881-f688-4839-8dfc-b11da695230b"), null, "Другой" },
                    { new Guid("e4826291-bc37-4b40-a547-3e55584fe3a9"), new Guid("bc966b65-802a-4c0c-8030-ec5127a7359a"), null, "Нет" },
                    { new Guid("e5607aa4-8372-42fe-a88a-9c090fccc906"), new Guid("80ae6aeb-0130-48e4-83f7-aeff92127b29"), null, "Русский" },
                    { new Guid("e68bf556-36ac-406f-ab57-0b5d0cbb1c96"), new Guid("4b5b91b6-5152-4c82-9444-05b01a8133f1"), null, "Международный" },
                    { new Guid("e992813c-b1b8-4c54-955f-cd74e33d7e2f"), new Guid("df389a80-4299-44c9-b93e-65a442277b0b"), null, "Нет" },
                    { new Guid("ed59a196-5966-4806-9d71-a504dd52d02c"), new Guid("ffcbde6c-027b-4134-90d2-e74417e2cb8b"), null, "РИНЦ" },
                    { new Guid("f257aa4e-debc-45ef-a34c-5ca67a737a6d"), new Guid("bc966b65-802a-4c0c-8030-ec5127a7359a"), null, "Есть" },
                    { new Guid("f79028d7-e670-4b93-9b60-4e17305b6997"), new Guid("e554e881-f688-4839-8dfc-b11da695230b"), null, "Английский" }
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
