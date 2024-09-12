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
                    Value = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
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
                    Value = table.Column<string>(type: "character varying(8000)", maxLength: 8000, nullable: true),
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
                    { new Guid("33cd5935-eef2-46c1-a10b-2da8c49400fa"), 1, "В ожидании заполнения" },
                    { new Guid("54ff3451-e17d-4679-9c77-976093dd6852"), 5, "Отклонена" },
                    { new Guid("5892eb0e-19e5-4929-b799-504a12dfb8d4"), 3, "В процессе рассмотрения" },
                    { new Guid("6a61382a-c4b6-49fe-86d0-2fcde02770c4"), 2, "В ожидании рассмотрения" },
                    { new Guid("957067d3-4f24-4f10-a664-11059810b257"), 6, "Оценена" },
                    { new Guid("f1e05304-0a38-46e2-b5c2-66f64acdd10a"), 4, "Одобрена" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5999c2a8-b8a7-4867-a0ad-d74e9fd967d4", null, "Admin", "ADMIN" },
                    { "7fe320a3-68d8-4df4-a9c7-d7cf458b4143", null, "Organiser", "ORGANISER" },
                    { "a1aeeccb-9c93-404a-850e-3d6f12a6307f", null, "Expert", "EXPERT" },
                    { "ba2cb4fc-bf80-42f2-acdd-82403edbe705", null, "Participant", "PARTICIPANT" },
                    { "e514dd22-6925-4fa6-abee-cf464c6ab24a", null, "Voter", "VOTER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("5baa151f-563d-46fa-bc67-2f5c54bc92b1"), "Энергетика и нефтегазовая индустрия", 2 },
                    { new Guid("7815e237-b0a2-4875-a194-a71c52325fa2"), "Строительство и архитектура", 1 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("7d770e45-2d3a-4dac-8435-c82980888ae7"), "Категория участников", 2 },
                    { new Guid("94e75c97-8884-4f03-ae94-b3a736ecb8e3"), "Общая информация", 1 },
                    { new Guid("94eb0624-5f60-40ac-bc8b-847b1d4ceb4a"), "Конкурсная работа", 3 },
                    { new Guid("c9227d56-6fbf-4260-a82f-01cbfc2a9b39"), "Научно-исследовательская деятельность", 6 },
                    { new Guid("f6813dac-a557-4483-88a2-237e6959f73a"), "Научно-педагогическая деятельность", 5 },
                    { new Guid("fb72555f-b0db-4e7e-ae27-973382879bd2"), "Профессиональное развитие", 4 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Checked", "Email", "Message", "Name" },
                values: new object[] { new Guid("5d005403-ebae-4bdb-89be-a994c922a6ad"), false, "system@system.ru", "Test Message for System", "SYSTEM" });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530"), "Основной", 1 },
                    { new Guid("4c859c29-5b1d-44bb-bcd1-f2ce8b27a79c"), "Методическая деятельность", 3 },
                    { new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("5c77b42b-11e6-460a-950a-0363aef8816c"), "Инновационная и иная деятельность", 6 },
                    { new Guid("85eab800-f947-4795-bc7a-5334c7e116ac"), "Конкурсная работа", 7 },
                    { new Guid("ad5493a5-e709-4394-a0d3-efc41faff48a"), "Профессиональные показатели", 4 },
                    { new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95"), "Образовательная деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("8a0598c6-6157-482f-ae5b-1c57258649b0"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("e0ca7077-f88f-4863-ac35-53647c928f75"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0f74a774-3a94-47f9-baf4-255231845633"), "int" },
                    { new Guid("229b3628-60fe-4f18-9582-6b0de5c60430"), "bool" },
                    { new Guid("24213510-fa0d-4ff1-9e91-bc7af5fc6eae"), "TextArea" },
                    { new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd"), "string" },
                    { new Guid("ecc37f13-7be2-4fe3-8cf2-c021e035b6de"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("7d770e45-2d3a-4dac-8435-c82980888ae7"), new Guid("8a0598c6-6157-482f-ae5b-1c57258649b0") },
                    { new Guid("7d770e45-2d3a-4dac-8435-c82980888ae7"), new Guid("e0ca7077-f88f-4863-ac35-53647c928f75") },
                    { new Guid("94e75c97-8884-4f03-ae94-b3a736ecb8e3"), new Guid("8a0598c6-6157-482f-ae5b-1c57258649b0") },
                    { new Guid("94e75c97-8884-4f03-ae94-b3a736ecb8e3"), new Guid("e0ca7077-f88f-4863-ac35-53647c928f75") },
                    { new Guid("94eb0624-5f60-40ac-bc8b-847b1d4ceb4a"), new Guid("8a0598c6-6157-482f-ae5b-1c57258649b0") },
                    { new Guid("94eb0624-5f60-40ac-bc8b-847b1d4ceb4a"), new Guid("e0ca7077-f88f-4863-ac35-53647c928f75") },
                    { new Guid("c9227d56-6fbf-4260-a82f-01cbfc2a9b39"), new Guid("8a0598c6-6157-482f-ae5b-1c57258649b0") },
                    { new Guid("f6813dac-a557-4483-88a2-237e6959f73a"), new Guid("e0ca7077-f88f-4863-ac35-53647c928f75") },
                    { new Guid("fb72555f-b0db-4e7e-ae27-973382879bd2"), new Guid("8a0598c6-6157-482f-ae5b-1c57258649b0") },
                    { new Guid("fb72555f-b0db-4e7e-ae27-973382879bd2"), new Guid("e0ca7077-f88f-4863-ac35-53647c928f75") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("062bbd3b-d472-469e-bad1-c3f6217e213e"), new Guid("f6813dac-a557-4483-88a2-237e6959f73a"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("23e8ac12-fd55-40dc-9872-5af0803fce03"), new Guid("c9227d56-6fbf-4260-a82f-01cbfc2a9b39"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("2c9d93e1-630b-4558-8a99-cd0be39b9e88"), new Guid("94e75c97-8884-4f03-ae94-b3a736ecb8e3"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("32af627a-0d5f-465e-9c03-2e56b719a8b5"), new Guid("94e75c97-8884-4f03-ae94-b3a736ecb8e3"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("540751a6-d2cd-4204-8e97-c55f42d1ab79"), new Guid("94e75c97-8884-4f03-ae94-b3a736ecb8e3"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("5fab7f36-eaee-462d-8a67-d5514a08f011"), new Guid("94e75c97-8884-4f03-ae94-b3a736ecb8e3"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("67fba31d-0df8-45ad-9314-29d34b9ffe48"), new Guid("94e75c97-8884-4f03-ae94-b3a736ecb8e3"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("ecc37f13-7be2-4fe3-8cf2-c021e035b6de") },
                    { new Guid("73c24ae3-f2e1-4b1e-8573-a6d4a2aa6b39"), new Guid("7d770e45-2d3a-4dac-8435-c82980888ae7"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("8c9f32b6-aed1-42b9-9502-909bb1d4d525"), new Guid("7d770e45-2d3a-4dac-8435-c82980888ae7"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("8ce0ad01-253b-478b-b871-e8092151ad6e"), new Guid("f6813dac-a557-4483-88a2-237e6959f73a"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("90d55918-29e9-46fa-98e0-770829596012"), new Guid("94e75c97-8884-4f03-ae94-b3a736ecb8e3"), null, true, true, "Место работы", 6, "Название организации", new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("978d822c-318f-417c-89d8-87d4ab3ef3c3"), new Guid("f6813dac-a557-4483-88a2-237e6959f73a"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("9c1e3452-6966-482f-8c32-40e559141597"), new Guid("94e75c97-8884-4f03-ae94-b3a736ecb8e3"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("a4814248-c1e2-4b0b-844d-4c3590a45d64"), new Guid("c9227d56-6fbf-4260-a82f-01cbfc2a9b39"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("d33cf67b-81ea-473a-b4a3-052a2058ad1f"), new Guid("94e75c97-8884-4f03-ae94-b3a736ecb8e3"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("edb93efb-2c55-41d6-aa21-55afa8c451da"), new Guid("94e75c97-8884-4f03-ae94-b3a736ecb8e3"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("f7349b05-7f38-470a-ab95-51fe36029365"), new Guid("7d770e45-2d3a-4dac-8435-c82980888ae7"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("f77b26a8-8403-4e45-bf94-c175557fe24c"), new Guid("94e75c97-8884-4f03-ae94-b3a736ecb8e3"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530"), new Guid("8a0598c6-6157-482f-ae5b-1c57258649b0") },
                    { new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530"), new Guid("e0ca7077-f88f-4863-ac35-53647c928f75") },
                    { new Guid("4c859c29-5b1d-44bb-bcd1-f2ce8b27a79c"), new Guid("e0ca7077-f88f-4863-ac35-53647c928f75") },
                    { new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece"), new Guid("8a0598c6-6157-482f-ae5b-1c57258649b0") },
                    { new Guid("5c77b42b-11e6-460a-950a-0363aef8816c"), new Guid("8a0598c6-6157-482f-ae5b-1c57258649b0") },
                    { new Guid("85eab800-f947-4795-bc7a-5334c7e116ac"), new Guid("8a0598c6-6157-482f-ae5b-1c57258649b0") },
                    { new Guid("85eab800-f947-4795-bc7a-5334c7e116ac"), new Guid("e0ca7077-f88f-4863-ac35-53647c928f75") },
                    { new Guid("ad5493a5-e709-4394-a0d3-efc41faff48a"), new Guid("e0ca7077-f88f-4863-ac35-53647c928f75") },
                    { new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95"), new Guid("e0ca7077-f88f-4863-ac35-53647c928f75") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("00244921-5d52-425e-be0c-ff9d63a853b1"), new Guid("f6813dac-a557-4483-88a2-237e6959f73a"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("093fa10c-aaaa-4c78-bee7-11d2199cac9e"), new Guid("fb72555f-b0db-4e7e-ae27-973382879bd2"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 },
                    { new Guid("1f97c629-09fa-4759-b2a8-d07eb156e008"), new Guid("f6813dac-a557-4483-88a2-237e6959f73a"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 },
                    { new Guid("35290cbf-0be4-41b5-bc6b-84a0b7695ee1"), new Guid("c9227d56-6fbf-4260-a82f-01cbfc2a9b39"), false, false, "Список научных публикаций за последние 5 лет", 10 },
                    { new Guid("491aead3-711a-4e43-96e7-b82e18975cab"), new Guid("94eb0624-5f60-40ac-bc8b-847b1d4ceb4a"), true, true, "Краткая аннотация конкурсной работы", 1 },
                    { new Guid("80d1908a-1bb8-4d0f-b325-4a8ed1172edc"), new Guid("fb72555f-b0db-4e7e-ae27-973382879bd2"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("9cb40e91-738c-48f7-a055-25e71123aecf"), new Guid("f6813dac-a557-4483-88a2-237e6959f73a"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 },
                    { new Guid("9f505b13-4bc8-4b11-8939-60e6f2653b03"), new Guid("f6813dac-a557-4483-88a2-237e6959f73a"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 },
                    { new Guid("a4714062-674a-49d7-91d7-1a0c4d0a1fac"), new Guid("c9227d56-6fbf-4260-a82f-01cbfc2a9b39"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("a845d50e-2ba4-44cb-9a6f-ae8cd2f0fe34"), new Guid("f6813dac-a557-4483-88a2-237e6959f73a"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("c331f324-efb5-4907-aa37-7c24cacbc135"), new Guid("c9227d56-6fbf-4260-a82f-01cbfc2a9b39"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("d07328bd-deef-4cdf-9c66-dec9743ad3ab"), new Guid("fb72555f-b0db-4e7e-ae27-973382879bd2"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("f3dc6209-888a-4ee2-ae2d-975da26710c1"), new Guid("c9227d56-6fbf-4260-a82f-01cbfc2a9b39"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("013cc657-4fdd-4720-994c-69f277afe681"), true, "Статус конкурса", 3, new Guid("093fa10c-aaaa-4c78-bee7-11d2199cac9e"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("03ea927d-d02e-42e1-b02d-2c3acefd9c92"), true, "Итого (час.)", 5, new Guid("00244921-5d52-425e-be0c-ff9d63a853b1"), new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("0dcaa1ae-1401-41d1-9590-034906b1c2c8"), true, "Издательство, год", 6, new Guid("9cb40e91-738c-48f7-a055-25e71123aecf"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("20ea88b2-d774-4121-8148-e4a3d49a7eac"), true, "Наименование курса", 1, new Guid("00244921-5d52-425e-be0c-ff9d63a853b1"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("211d83ec-afbe-43e4-a508-5c6bee300db1"), true, "Вид", 2, new Guid("9f505b13-4bc8-4b11-8939-60e6f2653b03"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("2e198dee-e915-42aa-9681-0f225d4bba3e"), true, "Ссылка", 5, new Guid("093fa10c-aaaa-4c78-bee7-11d2199cac9e"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("2e30cca8-85e3-4536-ae20-515b275c52cf"), true, "Номер РИД", 4, new Guid("c331f324-efb5-4907-aa37-7c24cacbc135"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("370683de-7169-4a81-9062-43c0875f638f"), false, "Соавторы", 3, new Guid("9cb40e91-738c-48f7-a055-25e71123aecf"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("3a15b877-318f-4378-a9cb-3714953105a3"), true, "Ссылка на открытый доступ", 8, new Guid("9cb40e91-738c-48f7-a055-25e71123aecf"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("3ce9ec74-6872-47d4-ba0d-71507e5609c0"), true, "Название конкурса/премии", 2, new Guid("1f97c629-09fa-4759-b2a8-d07eb156e008"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("53543a77-4609-4e15-b611-9bed5c29f6d9"), false, "Тип идентификатора", 1, new Guid("d07328bd-deef-4cdf-9c66-dec9743ad3ab"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("5a37f496-3ad7-44d5-b057-b89ed7f30538"), true, "Название", 2, new Guid("9cb40e91-738c-48f7-a055-25e71123aecf"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("5d826a50-3ce8-4af0-a1f4-f8eaefb4462c"), true, "Значение", 2, new Guid("491aead3-711a-4e43-96e7-b82e18975cab"), new Guid("24213510-fa0d-4ff1-9e91-bc7af5fc6eae") },
                    { new Guid("5e591f43-f545-4a17-ac93-add0b2a5ef01"), true, "Год получения документа", 2, new Guid("80d1908a-1bb8-4d0f-b325-4a8ed1172edc"), new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("638715f4-267e-4e55-bab5-486eb13c16af"), true, "Лекции (час.)", 3, new Guid("00244921-5d52-425e-be0c-ff9d63a853b1"), new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("6606ca30-2b99-4745-b7a1-610916d74baf"), true, "Год", 1, new Guid("093fa10c-aaaa-4c78-bee7-11d2199cac9e"), new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("6612e0f6-c2d8-48e8-affb-1b619c00f485"), true, "Название", 2, new Guid("c331f324-efb5-4907-aa37-7c24cacbc135"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("68ddb9e0-1bfb-4fcc-8dad-b4df247543c9"), true, "ФИО", 1, new Guid("1f97c629-09fa-4759-b2a8-d07eb156e008"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("6a7fe71f-de03-4e9d-b12a-4bcfb6506832"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("093fa10c-aaaa-4c78-bee7-11d2199cac9e"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("6b5dc773-2a09-46cc-86fb-1a8ff0210f58"), true, "Статус", 4, new Guid("f3dc6209-888a-4ee2-ae2d-975da26710c1"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("722b6c9a-f6dc-45c8-afd3-a246101335dc"), true, "Издание, год", 4, new Guid("35290cbf-0be4-41b5-bc6b-84a0b7695ee1"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("75695e3c-ca9a-4c75-a0a7-b4e3c67b7f06"), true, "Язык преподавания", 2, new Guid("00244921-5d52-425e-be0c-ff9d63a853b1"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("7b6b5498-afc5-4ef5-84c5-c0fd0da42710"), true, "Ссылка на платформу", 3, new Guid("a845d50e-2ba4-44cb-9a6f-ae8cd2f0fe34"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("7facc820-363d-408a-9852-8779b03f7a6b"), true, "Вид", 1, new Guid("c331f324-efb5-4907-aa37-7c24cacbc135"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("81196c6a-6e88-4f23-b7ae-c94fd6786b36"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("f3dc6209-888a-4ee2-ae2d-975da26710c1"), new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("82123e42-5720-499e-8658-9886e25695b7"), true, "Соавторы", 2, new Guid("35290cbf-0be4-41b5-bc6b-84a0b7695ee1"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("9052f944-f565-4fb7-a12b-a579b40b7c91"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("9f505b13-4bc8-4b11-8939-60e6f2653b03"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("9485e94f-28e5-41f6-b034-436ea6943f68"), true, "Вид", 1, new Guid("a4714062-674a-49d7-91d7-1a0c4d0a1fac"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("9d3c3bec-839d-4ba2-878e-cf27d82fd430"), true, "Практические занятия (час.)", 4, new Guid("00244921-5d52-425e-be0c-ff9d63a853b1"), new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("9dee20e3-a898-478b-b9d9-a58596c20a45"), true, "Название конкурса", 2, new Guid("093fa10c-aaaa-4c78-bee7-11d2199cac9e"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("a3919ddc-1058-4243-9f3e-eca06dac8f51"), true, "Период выполнения", 3, new Guid("f3dc6209-888a-4ee2-ae2d-975da26710c1"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("a50600c0-a952-4cfa-9ced-827634961d49"), true, "Название дисциплины", 1, new Guid("9f505b13-4bc8-4b11-8939-60e6f2653b03"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("a771c893-5ff1-46d4-aadd-495108b5f1dc"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("f3dc6209-888a-4ee2-ae2d-975da26710c1"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("a8629439-c3c9-49a6-bb6a-1c89f08ea375"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("1f97c629-09fa-4759-b2a8-d07eb156e008"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("a98ff166-20e5-427e-bd59-be26bb552114"), true, "Название организации в которую внедрена разработка", 3, new Guid("a4714062-674a-49d7-91d7-1a0c4d0a1fac"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("adf75450-0e51-49e7-ae98-5fd48dfa870c"), false, "Идентификатор", 2, new Guid("d07328bd-deef-4cdf-9c66-dec9743ad3ab"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("b58fb33f-6c26-4e37-850c-61775890b26c"), true, "Название разработки", 2, new Guid("a4714062-674a-49d7-91d7-1a0c4d0a1fac"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("b85368b1-e2b7-48ae-b76e-a6b324a667d7"), true, "Название курса", 1, new Guid("a845d50e-2ba4-44cb-9a6f-ae8cd2f0fe34"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("baa6b31e-23a0-4734-b093-b3f039905f8c"), true, "Наличие грифа", 5, new Guid("9cb40e91-738c-48f7-a055-25e71123aecf"), new Guid("229b3628-60fe-4f18-9582-6b0de5c60430") },
                    { new Guid("bb385730-bbcb-4ef8-a92d-27bb93825960"), true, "Год", 3, new Guid("1f97c629-09fa-4759-b2a8-d07eb156e008"), new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("c5d01a20-ad1b-4726-979b-4943655b6f05"), true, "ФИО соавторов", 3, new Guid("c331f324-efb5-4907-aa37-7c24cacbc135"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("c6b5c2ce-a94e-4b15-b176-53df25850f0b"), true, "Название", 1, new Guid("491aead3-711a-4e43-96e7-b82e18975cab"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("c935dea4-a11b-4f52-b90d-7dfac4297b2a"), true, "Год", 4, new Guid("a845d50e-2ba4-44cb-9a6f-ae8cd2f0fe34"), new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("ca546e81-01e8-4742-a471-5820ee5792e1"), true, "Название статьи", 1, new Guid("35290cbf-0be4-41b5-bc6b-84a0b7695ee1"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("cee14586-3622-4641-aa49-24aeecff3279"), true, "Количество печатных листов", 4, new Guid("9cb40e91-738c-48f7-a055-25e71123aecf"), new Guid("0f74a774-3a94-47f9-baf4-255231845633") },
                    { new Guid("cefbd786-e1d2-44af-aeb4-c01c65133146"), true, "Соавторы", 2, new Guid("a845d50e-2ba4-44cb-9a6f-ae8cd2f0fe34"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("d05ca181-0b67-4e27-ad6e-3d29ff8596ef"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("1f97c629-09fa-4759-b2a8-d07eb156e008"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("dda4ccfd-3c36-4711-993f-2f2645b34e45"), true, "Название НИР/НИОКР", 1, new Guid("f3dc6209-888a-4ee2-ae2d-975da26710c1"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("df321de7-1126-4078-8f42-852956fe4490"), true, "Название документа, реквизиты", 1, new Guid("80d1908a-1bb8-4d0f-b325-4a8ed1172edc"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("f00ced91-bd14-409e-ae4c-abe040ffdafa"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("35290cbf-0be4-41b5-bc6b-84a0b7695ee1"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("f16ef60d-4084-4370-ae24-b29dd3f2f82e"), true, "Вид публикации", 1, new Guid("9cb40e91-738c-48f7-a055-25e71123aecf"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") },
                    { new Guid("fa66da60-7c59-46d8-bc6d-4f72297f3c66"), true, "Язык публикации", 7, new Guid("9cb40e91-738c-48f7-a055-25e71123aecf"), new Guid("a987edbb-f4b7-4a44-ae6a-34d2412f3fdd") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("062bbd3b-d472-469e-bad1-c3f6217e213e"), new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95") },
                    { new Guid("23e8ac12-fd55-40dc-9872-5af0803fce03"), new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece") },
                    { new Guid("2c9d93e1-630b-4558-8a99-cd0be39b9e88"), new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530") },
                    { new Guid("32af627a-0d5f-465e-9c03-2e56b719a8b5"), new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530") },
                    { new Guid("540751a6-d2cd-4204-8e97-c55f42d1ab79"), new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530") },
                    { new Guid("5fab7f36-eaee-462d-8a67-d5514a08f011"), new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530") },
                    { new Guid("67fba31d-0df8-45ad-9314-29d34b9ffe48"), new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530") },
                    { new Guid("73c24ae3-f2e1-4b1e-8573-a6d4a2aa6b39"), new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530") },
                    { new Guid("8c9f32b6-aed1-42b9-9502-909bb1d4d525"), new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530") },
                    { new Guid("8ce0ad01-253b-478b-b871-e8092151ad6e"), new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95") },
                    { new Guid("90d55918-29e9-46fa-98e0-770829596012"), new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530") },
                    { new Guid("978d822c-318f-417c-89d8-87d4ab3ef3c3"), new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95") },
                    { new Guid("9c1e3452-6966-482f-8c32-40e559141597"), new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530") },
                    { new Guid("a4814248-c1e2-4b0b-844d-4c3590a45d64"), new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece") },
                    { new Guid("d33cf67b-81ea-473a-b4a3-052a2058ad1f"), new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530") },
                    { new Guid("edb93efb-2c55-41d6-aa21-55afa8c451da"), new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530") },
                    { new Guid("f7349b05-7f38-470a-ab95-51fe36029365"), new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530") },
                    { new Guid("f7349b05-7f38-470a-ab95-51fe36029365"), new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece") },
                    { new Guid("f7349b05-7f38-470a-ab95-51fe36029365"), new Guid("ad5493a5-e709-4394-a0d3-efc41faff48a") },
                    { new Guid("f77b26a8-8403-4e45-bf94-c175557fe24c"), new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("2debb27a-e14c-4fba-b226-b44ab3c06530"), new Guid("d07328bd-deef-4cdf-9c66-dec9743ad3ab") },
                    { new Guid("4c859c29-5b1d-44bb-bcd1-f2ce8b27a79c"), new Guid("9cb40e91-738c-48f7-a055-25e71123aecf") },
                    { new Guid("4c859c29-5b1d-44bb-bcd1-f2ce8b27a79c"), new Guid("9f505b13-4bc8-4b11-8939-60e6f2653b03") },
                    { new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece"), new Guid("093fa10c-aaaa-4c78-bee7-11d2199cac9e") },
                    { new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece"), new Guid("35290cbf-0be4-41b5-bc6b-84a0b7695ee1") },
                    { new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece"), new Guid("f3dc6209-888a-4ee2-ae2d-975da26710c1") },
                    { new Guid("5c77b42b-11e6-460a-950a-0363aef8816c"), new Guid("80d1908a-1bb8-4d0f-b325-4a8ed1172edc") },
                    { new Guid("5c77b42b-11e6-460a-950a-0363aef8816c"), new Guid("a4714062-674a-49d7-91d7-1a0c4d0a1fac") },
                    { new Guid("5c77b42b-11e6-460a-950a-0363aef8816c"), new Guid("c331f324-efb5-4907-aa37-7c24cacbc135") },
                    { new Guid("85eab800-f947-4795-bc7a-5334c7e116ac"), new Guid("491aead3-711a-4e43-96e7-b82e18975cab") },
                    { new Guid("ad5493a5-e709-4394-a0d3-efc41faff48a"), new Guid("093fa10c-aaaa-4c78-bee7-11d2199cac9e") },
                    { new Guid("ad5493a5-e709-4394-a0d3-efc41faff48a"), new Guid("80d1908a-1bb8-4d0f-b325-4a8ed1172edc") },
                    { new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95"), new Guid("00244921-5d52-425e-be0c-ff9d63a853b1") },
                    { new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95"), new Guid("1f97c629-09fa-4759-b2a8-d07eb156e008") },
                    { new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95"), new Guid("a845d50e-2ba4-44cb-9a6f-ae8cd2f0fe34") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0c979de4-9264-495e-a210-175c248391b2"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("9cb40e91-738c-48f7-a055-25e71123aecf") },
                    { new Guid("38196c5c-df6d-4054-b543-712e62a47412"), "EvaluateMark4", new Guid("062bbd3b-d472-469e-bad1-c3f6217e213e"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("4626f6d0-257b-4d6b-aa65-50e3847129e1"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("a4714062-674a-49d7-91d7-1a0c4d0a1fac") },
                    { new Guid("58739f5b-ddd0-4fbe-b938-c0b5289dac4a"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("c331f324-efb5-4907-aa37-7c24cacbc135") },
                    { new Guid("60c607a8-cea3-48fa-9b64-000f742f58f8"), "EvaluateMark20", new Guid("a4814248-c1e2-4b0b-844d-4c3590a45d64"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("6c255637-8b1c-49e5-80ee-646c043f67a5"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("093fa10c-aaaa-4c78-bee7-11d2199cac9e") },
                    { new Guid("6dc42050-ba7b-42ad-a757-c1de3214e4fc"), "EvaluateMark19", new Guid("23e8ac12-fd55-40dc-9872-5af0803fce03"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("78b3475c-5dab-4458-91d7-fb8213e410f6"), "EvaluateMark5", new Guid("8ce0ad01-253b-478b-b871-e8092151ad6e"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("805e0170-6032-4bdf-9025-ff3ea3849b2d"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("f3dc6209-888a-4ee2-ae2d-975da26710c1") },
                    { new Guid("83d75a73-ce43-4420-a9df-fbf4302d6e1c"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("9f505b13-4bc8-4b11-8939-60e6f2653b03") },
                    { new Guid("9b0add5a-7682-4e12-8590-bdcf0054b63f"), "EvaluateMark13", new Guid("f7349b05-7f38-470a-ab95-51fe36029365"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("9c13b820-473a-479f-ba6b-0e777c2fe879"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("9cb40e91-738c-48f7-a055-25e71123aecf") },
                    { new Guid("a55ba1e5-e4c1-4cac-a820-597e817b0b00"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("491aead3-711a-4e43-96e7-b82e18975cab") },
                    { new Guid("a72731a1-13b4-481f-94d3-8afb32ce99b5"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("00244921-5d52-425e-be0c-ff9d63a853b1") },
                    { new Guid("aeddc5c5-562a-4307-b06d-e7a9ae44d9a2"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("1f97c629-09fa-4759-b2a8-d07eb156e008") },
                    { new Guid("b4d64fcb-566c-494e-8555-781295e82bfa"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом или на иностранном языке в соавторстве:", 9, new Guid("9cb40e91-738c-48f7-a055-25e71123aecf") },
                    { new Guid("bc26b653-2376-47af-b966-ad8f5252d3c1"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("a845d50e-2ba4-44cb-9a6f-ae8cd2f0fe34") },
                    { new Guid("bc4e77b1-d9ab-46dd-8b61-fbe967dd77e4"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("f3dc6209-888a-4ee2-ae2d-975da26710c1") },
                    { new Guid("dd63ec0e-676f-471a-ad04-454a17ec2ab8"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("35290cbf-0be4-41b5-bc6b-84a0b7695ee1") },
                    { new Guid("e7f3c769-f55d-4d41-a76d-a848f4ef14c9"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("80d1908a-1bb8-4d0f-b325-4a8ed1172edc") },
                    { new Guid("ed149db4-f73f-4c11-a70a-fa1779e41b0f"), "EvaluateMark3", new Guid("978d822c-318f-417c-89d8-87d4ab3ef3c3"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("ed36ab02-2d46-440e-9840-5700fbdeeb5e"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("00244921-5d52-425e-be0c-ff9d63a853b1") },
                    { new Guid("ef73e298-5f4d-4f49-8b1c-8dfc553c1a73"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("491aead3-711a-4e43-96e7-b82e18975cab") },
                    { new Guid("f56a01cd-d822-453c-bac8-e683caee27e0"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом или на иностранном языке и без соавторства:", 8, new Guid("9cb40e91-738c-48f7-a055-25e71123aecf") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("07a996d7-5f11-4764-8984-0ea6827702d9"), true, 8, new Guid("491aead3-711a-4e43-96e7-b82e18975cab") },
                    { new Guid("27ac0db2-0300-48cd-ac76-31eff4cd0105"), true, 1, new Guid("d07328bd-deef-4cdf-9c66-dec9743ad3ab") },
                    { new Guid("2ca86695-17c3-476c-a6e2-0f69133bb273"), true, 5, new Guid("d07328bd-deef-4cdf-9c66-dec9743ad3ab") },
                    { new Guid("400f9681-84b9-4ef6-9255-346b481919d4"), true, 1, new Guid("491aead3-711a-4e43-96e7-b82e18975cab") },
                    { new Guid("48fc52fd-d0be-42d9-b838-200bbea9d89e"), true, 7, new Guid("491aead3-711a-4e43-96e7-b82e18975cab") },
                    { new Guid("5977097c-e4cb-4761-8550-97f7659cd82b"), true, 3, new Guid("491aead3-711a-4e43-96e7-b82e18975cab") },
                    { new Guid("70cfd505-3cb1-40f7-9b59-23b35e5a0115"), true, 2, new Guid("491aead3-711a-4e43-96e7-b82e18975cab") },
                    { new Guid("78b403ee-413d-4730-8bf6-f97a4cfd6997"), true, 5, new Guid("491aead3-711a-4e43-96e7-b82e18975cab") },
                    { new Guid("b01444b6-f673-4234-adb0-c1127252a980"), true, 4, new Guid("491aead3-711a-4e43-96e7-b82e18975cab") },
                    { new Guid("c013d404-1774-41b4-9e67-f9ef94163e24"), true, 3, new Guid("d07328bd-deef-4cdf-9c66-dec9743ad3ab") },
                    { new Guid("d18e7f08-9011-4ce0-a290-c9ed070ea853"), true, 2, new Guid("d07328bd-deef-4cdf-9c66-dec9743ad3ab") },
                    { new Guid("ecd9a803-fd14-46af-b45e-21dbbb1e9cbe"), true, 4, new Guid("d07328bd-deef-4cdf-9c66-dec9743ad3ab") },
                    { new Guid("f2bf0c55-9292-4c0a-838f-d70becd8322a"), true, 6, new Guid("491aead3-711a-4e43-96e7-b82e18975cab") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("6094ffdb-4ab2-4c0d-8234-5bbb1afe7473"), null, new Guid("8c9f32b6-aed1-42b9-9502-909bb1d4d525"), "Кандидат наук" },
                    { new Guid("92b9775e-e07c-4cb1-a6ae-01960d6b51fb"), null, new Guid("f7349b05-7f38-470a-ab95-51fe36029365"), "Профессор" },
                    { new Guid("c26550af-4127-4de6-9e26-22931d945dc9"), null, new Guid("8c9f32b6-aed1-42b9-9502-909bb1d4d525"), "Доктор наук" },
                    { new Guid("f4ccc75e-5bde-474a-acc3-2853b04ab4d8"), null, new Guid("f7349b05-7f38-470a-ab95-51fe36029365"), "Нет" },
                    { new Guid("f6c51737-2153-438c-b233-b965efc7abd0"), null, new Guid("f7349b05-7f38-470a-ab95-51fe36029365"), "Доцент" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("19f3eee6-67a3-4868-b789-e9a7b33fcdb4"), null, new Guid("c6b5c2ce-a94e-4b15-b176-53df25850f0b"), true, true, new Guid("b01444b6-f673-4234-adb0-c1127252a980"), "Методология и методы, используемые в работе" },
                    { new Guid("1e72bc2b-9bb4-48df-859b-1450ef4ea394"), null, new Guid("adf75450-0e51-49e7-ae98-5fd48dfa870c"), false, true, new Guid("2ca86695-17c3-476c-a6e2-0f69133bb273"), null },
                    { new Guid("2fa52a42-3ed0-4a00-821e-7f0d1105b989"), null, new Guid("53543a77-4609-4e15-b611-9bed5c29f6d9"), true, true, new Guid("ecd9a803-fd14-46af-b45e-21dbbb1e9cbe"), "РИНЦ AuthorID" },
                    { new Guid("33534c4e-285b-432b-8e5c-1d414ecc347f"), null, new Guid("adf75450-0e51-49e7-ae98-5fd48dfa870c"), false, true, new Guid("ecd9a803-fd14-46af-b45e-21dbbb1e9cbe"), null },
                    { new Guid("486fb2a4-cdf5-431c-bd4b-5433efa29701"), null, new Guid("c6b5c2ce-a94e-4b15-b176-53df25850f0b"), true, true, new Guid("400f9681-84b9-4ef6-9255-346b481919d4"), "Название работы" },
                    { new Guid("52420acd-0033-419d-af46-ae1880081017"), null, new Guid("c6b5c2ce-a94e-4b15-b176-53df25850f0b"), true, true, new Guid("48fc52fd-d0be-42d9-b838-200bbea9d89e"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("524db9aa-3242-4b22-a3bc-91f4b3133e2e"), null, new Guid("53543a77-4609-4e15-b611-9bed5c29f6d9"), true, true, new Guid("c013d404-1774-41b4-9e67-f9ef94163e24"), "ResearcherID" },
                    { new Guid("55e817a2-c17c-43eb-b9b6-e3aef72de046"), null, new Guid("5d826a50-3ce8-4af0-a1f4-f8eaefb4462c"), false, true, new Guid("07a996d7-5f11-4764-8984-0ea6827702d9"), null },
                    { new Guid("76553758-da78-4dde-8b6f-b118d46521f0"), null, new Guid("5d826a50-3ce8-4af0-a1f4-f8eaefb4462c"), false, true, new Guid("78b403ee-413d-4730-8bf6-f97a4cfd6997"), null },
                    { new Guid("8eb975ce-99ca-491d-a929-dddbffe1632a"), null, new Guid("c6b5c2ce-a94e-4b15-b176-53df25850f0b"), true, true, new Guid("70cfd505-3cb1-40f7-9b59-23b35e5a0115"), "Актуальность конкурсной работы" },
                    { new Guid("9578deae-a450-413e-9c73-bb0b0ec91420"), null, new Guid("53543a77-4609-4e15-b611-9bed5c29f6d9"), true, true, new Guid("27ac0db2-0300-48cd-ac76-31eff4cd0105"), "ScopusID" },
                    { new Guid("a7348ac0-0f43-4a50-bd59-65a2f181a69d"), null, new Guid("53543a77-4609-4e15-b611-9bed5c29f6d9"), true, true, new Guid("2ca86695-17c3-476c-a6e2-0f69133bb273"), "Google Scholar ID" },
                    { new Guid("b2fd9de9-cd2f-4536-982e-ce3e3f184e6f"), null, new Guid("5d826a50-3ce8-4af0-a1f4-f8eaefb4462c"), false, true, new Guid("400f9681-84b9-4ef6-9255-346b481919d4"), null },
                    { new Guid("b4054f9d-30d6-49dc-8e37-135f984ef243"), null, new Guid("c6b5c2ce-a94e-4b15-b176-53df25850f0b"), true, true, new Guid("f2bf0c55-9292-4c0a-838f-d70becd8322a"), "Апробация" },
                    { new Guid("b4e5f820-5887-402e-8cab-661c3030b65e"), null, new Guid("53543a77-4609-4e15-b611-9bed5c29f6d9"), true, true, new Guid("d18e7f08-9011-4ce0-a290-c9ed070ea853"), "ORCiD" },
                    { new Guid("bcca9956-6924-4d0b-a0ee-8c62ed1af82c"), null, new Guid("5d826a50-3ce8-4af0-a1f4-f8eaefb4462c"), false, true, new Guid("5977097c-e4cb-4761-8550-97f7659cd82b"), null },
                    { new Guid("bd43c327-388c-40d7-b085-7d5624a0ab2b"), null, new Guid("5d826a50-3ce8-4af0-a1f4-f8eaefb4462c"), false, true, new Guid("b01444b6-f673-4234-adb0-c1127252a980"), null },
                    { new Guid("c1a25179-4bd6-4b9b-aa4d-f8eb370c1e45"), null, new Guid("adf75450-0e51-49e7-ae98-5fd48dfa870c"), false, true, new Guid("27ac0db2-0300-48cd-ac76-31eff4cd0105"), null },
                    { new Guid("d059f01c-e13c-4a46-abe8-26f81c1a4e5a"), null, new Guid("adf75450-0e51-49e7-ae98-5fd48dfa870c"), false, true, new Guid("c013d404-1774-41b4-9e67-f9ef94163e24"), null },
                    { new Guid("d0c59a59-ae5a-45d4-b44e-282194e9d0b3"), null, new Guid("5d826a50-3ce8-4af0-a1f4-f8eaefb4462c"), false, true, new Guid("70cfd505-3cb1-40f7-9b59-23b35e5a0115"), null },
                    { new Guid("df05107d-971a-447c-90a6-5576335b28e7"), null, new Guid("5d826a50-3ce8-4af0-a1f4-f8eaefb4462c"), false, true, new Guid("48fc52fd-d0be-42d9-b838-200bbea9d89e"), null },
                    { new Guid("e08dd749-94eb-4621-a2f4-a87cbc576687"), null, new Guid("adf75450-0e51-49e7-ae98-5fd48dfa870c"), false, true, new Guid("d18e7f08-9011-4ce0-a290-c9ed070ea853"), null },
                    { new Guid("e4be338e-4832-4346-884d-de7040802b7e"), null, new Guid("5d826a50-3ce8-4af0-a1f4-f8eaefb4462c"), false, true, new Guid("f2bf0c55-9292-4c0a-838f-d70becd8322a"), null },
                    { new Guid("e528fb42-c58a-4e46-b2ca-5a05b272aaf3"), null, new Guid("c6b5c2ce-a94e-4b15-b176-53df25850f0b"), true, true, new Guid("78b403ee-413d-4730-8bf6-f97a4cfd6997"), "Ссылка на конкурсную работу" },
                    { new Guid("e7c56802-d81d-4a9c-aba4-d983e62821b6"), null, new Guid("c6b5c2ce-a94e-4b15-b176-53df25850f0b"), true, true, new Guid("5977097c-e4cb-4761-8550-97f7659cd82b"), "Инновационность" },
                    { new Guid("f17ab962-02c3-4b8a-add8-ac92565a2a6c"), null, new Guid("c6b5c2ce-a94e-4b15-b176-53df25850f0b"), true, true, new Guid("07a996d7-5f11-4764-8984-0ea6827702d9"), "Результаты и выводы" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("4c859c29-5b1d-44bb-bcd1-f2ce8b27a79c"), new Guid("0c979de4-9264-495e-a210-175c248391b2") },
                    { new Guid("4c859c29-5b1d-44bb-bcd1-f2ce8b27a79c"), new Guid("83d75a73-ce43-4420-a9df-fbf4302d6e1c") },
                    { new Guid("4c859c29-5b1d-44bb-bcd1-f2ce8b27a79c"), new Guid("9c13b820-473a-479f-ba6b-0e777c2fe879") },
                    { new Guid("4c859c29-5b1d-44bb-bcd1-f2ce8b27a79c"), new Guid("b4d64fcb-566c-494e-8555-781295e82bfa") },
                    { new Guid("4c859c29-5b1d-44bb-bcd1-f2ce8b27a79c"), new Guid("f56a01cd-d822-453c-bac8-e683caee27e0") },
                    { new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece"), new Guid("60c607a8-cea3-48fa-9b64-000f742f58f8") },
                    { new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece"), new Guid("6c255637-8b1c-49e5-80ee-646c043f67a5") },
                    { new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece"), new Guid("6dc42050-ba7b-42ad-a757-c1de3214e4fc") },
                    { new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece"), new Guid("805e0170-6032-4bdf-9025-ff3ea3849b2d") },
                    { new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece"), new Guid("9b0add5a-7682-4e12-8590-bdcf0054b63f") },
                    { new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece"), new Guid("bc4e77b1-d9ab-46dd-8b61-fbe967dd77e4") },
                    { new Guid("5632df00-cf9e-4b7b-8781-ef3d6e7bcece"), new Guid("dd63ec0e-676f-471a-ad04-454a17ec2ab8") },
                    { new Guid("5c77b42b-11e6-460a-950a-0363aef8816c"), new Guid("4626f6d0-257b-4d6b-aa65-50e3847129e1") },
                    { new Guid("5c77b42b-11e6-460a-950a-0363aef8816c"), new Guid("58739f5b-ddd0-4fbe-b938-c0b5289dac4a") },
                    { new Guid("5c77b42b-11e6-460a-950a-0363aef8816c"), new Guid("e7f3c769-f55d-4d41-a76d-a848f4ef14c9") },
                    { new Guid("85eab800-f947-4795-bc7a-5334c7e116ac"), new Guid("a55ba1e5-e4c1-4cac-a820-597e817b0b00") },
                    { new Guid("85eab800-f947-4795-bc7a-5334c7e116ac"), new Guid("ef73e298-5f4d-4f49-8b1c-8dfc553c1a73") },
                    { new Guid("ad5493a5-e709-4394-a0d3-efc41faff48a"), new Guid("6c255637-8b1c-49e5-80ee-646c043f67a5") },
                    { new Guid("ad5493a5-e709-4394-a0d3-efc41faff48a"), new Guid("9b0add5a-7682-4e12-8590-bdcf0054b63f") },
                    { new Guid("ad5493a5-e709-4394-a0d3-efc41faff48a"), new Guid("e7f3c769-f55d-4d41-a76d-a848f4ef14c9") },
                    { new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95"), new Guid("38196c5c-df6d-4054-b543-712e62a47412") },
                    { new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95"), new Guid("78b3475c-5dab-4458-91d7-fb8213e410f6") },
                    { new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95"), new Guid("a72731a1-13b4-481f-94d3-8afb32ce99b5") },
                    { new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95"), new Guid("aeddc5c5-562a-4307-b06d-e7a9ae44d9a2") },
                    { new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95"), new Guid("bc26b653-2376-47af-b966-ad8f5252d3c1") },
                    { new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95"), new Guid("ed149db4-f73f-4c11-a70a-fa1779e41b0f") },
                    { new Guid("ce282a77-5393-470f-86e0-fd9eb9e26c95"), new Guid("ed36ab02-2d46-440e-9840-5700fbdeeb5e") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("00fdf39b-41a7-47da-ae84-d6d2cad67974"), new Guid("f00ced91-bd14-409e-ae4c-abe040ffdafa"), null, "ВАК (К2-К3)" },
                    { new Guid("07430ce8-54c5-4e72-8a9f-44ac97f57175"), new Guid("9485e94f-28e5-41f6-b034-436ea6943f68"), null, "Изобретение" },
                    { new Guid("07eda62f-e73b-4693-ad41-6f6fbb265a33"), new Guid("cefbd786-e1d2-44af-aeb4-c01c65133146"), null, "Нет" },
                    { new Guid("12ffda8d-ef5d-4710-a0fa-6f9a37007951"), new Guid("82123e42-5720-499e-8658-9886e25695b7"), null, "Нет" },
                    { new Guid("1c78ffc8-fed1-499f-a080-d71783f01e51"), new Guid("370683de-7169-4a81-9062-43c0875f638f"), null, "Есть" },
                    { new Guid("1d9559b6-11a1-4ab3-8aec-e2f6eb0e9afa"), new Guid("75695e3c-ca9a-4c75-a0a7-b4e3c67b7f06"), null, "Другой" },
                    { new Guid("3716441e-ab04-4609-a549-a52302e77b37"), new Guid("f16ef60d-4084-4370-ae24-b29dd3f2f82e"), null, "Монография" },
                    { new Guid("3d50fbcf-582a-4e67-bacc-6992e0a0a0d4"), new Guid("f00ced91-bd14-409e-ae4c-abe040ffdafa"), null, "МБД (Q3-Q4)" },
                    { new Guid("40f61fc6-ed4c-4369-8519-d74abcacbe3a"), new Guid("9485e94f-28e5-41f6-b034-436ea6943f68"), null, "Промышленный образец" },
                    { new Guid("4a72cebc-9cc8-4b8e-87ea-debbeff1c393"), new Guid("7facc820-363d-408a-9852-8779b03f7a6b"), null, "Изобретение" },
                    { new Guid("4a982ecf-5119-4c7a-a941-8fd483e7b0dd"), new Guid("013cc657-4fdd-4720-994c-69f277afe681"), null, "Всероссийский" },
                    { new Guid("5b9cf9ec-9232-4daf-92a6-8a6fe5893bee"), new Guid("fa66da60-7c59-46d8-bc6d-4f72297f3c66"), null, "Русский" },
                    { new Guid("5c21d97b-e816-44c7-a07e-151358e62d6b"), new Guid("f00ced91-bd14-409e-ae4c-abe040ffdafa"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("754d720b-e063-43ff-a022-e641bd2e4bd1"), new Guid("f16ef60d-4084-4370-ae24-b29dd3f2f82e"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("778678fc-e12a-4726-a95e-cfc12ebbe2ca"), new Guid("75695e3c-ca9a-4c75-a0a7-b4e3c67b7f06"), null, "Русский" },
                    { new Guid("77e70016-7f1c-4687-a0c2-1d6989f1049f"), new Guid("7facc820-363d-408a-9852-8779b03f7a6b"), null, "Полезная модель" },
                    { new Guid("79befd2e-90f9-4d76-b50b-f2078341ae61"), new Guid("baa6b31e-23a0-4734-b093-b3f039905f8c"), null, "Нет" },
                    { new Guid("82fe58b3-2ae9-4cec-bc7a-bddd510ee3df"), new Guid("6b5dc773-2a09-46cc-86fb-1a8ff0210f58"), null, "Руководитель" },
                    { new Guid("96afd799-f118-4a6f-8201-249af3e48d79"), new Guid("9485e94f-28e5-41f6-b034-436ea6943f68"), null, "Полезная модель" },
                    { new Guid("9790e609-9be5-4a90-929d-cf9d3e5924d8"), new Guid("f00ced91-bd14-409e-ae4c-abe040ffdafa"), null, "РИНЦ" },
                    { new Guid("984f4c2d-e50f-453f-b132-4bc733e1c4f1"), new Guid("82123e42-5720-499e-8658-9886e25695b7"), null, "Есть" },
                    { new Guid("9c20627f-eac7-4201-917f-0f6b79004e15"), new Guid("211d83ec-afbe-43e4-a508-5c6bee300db1"), null, "Лабораторные" },
                    { new Guid("b075d198-4367-4670-8796-0ebaa34f5e71"), new Guid("013cc657-4fdd-4720-994c-69f277afe681"), null, "Региональный" },
                    { new Guid("b8f3beed-05b2-4d61-99f1-e7c152117103"), new Guid("370683de-7169-4a81-9062-43c0875f638f"), null, "Нет" },
                    { new Guid("bc605777-44a4-4c15-b321-b6cab55fc148"), new Guid("7facc820-363d-408a-9852-8779b03f7a6b"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("c5b99423-8997-47b2-8ceb-ce45fe44a614"), new Guid("f16ef60d-4084-4370-ae24-b29dd3f2f82e"), null, "Учебник" },
                    { new Guid("c6afa740-fd26-419e-95cd-5f71af6dbc6a"), new Guid("9485e94f-28e5-41f6-b034-436ea6943f68"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("d0c75117-4e2f-475e-9d6d-e2ba049fdd31"), new Guid("7facc820-363d-408a-9852-8779b03f7a6b"), null, "Промышленный образец" },
                    { new Guid("d692b605-bbf5-455e-bdcb-16a4f0cc6b0d"), new Guid("baa6b31e-23a0-4734-b093-b3f039905f8c"), null, "Есть" },
                    { new Guid("dd6ae91c-c1e3-4882-a3ea-87abddbc9030"), new Guid("fa66da60-7c59-46d8-bc6d-4f72297f3c66"), null, "Иностранный" },
                    { new Guid("e0cd448b-1432-47dc-bf5b-9a68cc6cec4f"), new Guid("211d83ec-afbe-43e4-a508-5c6bee300db1"), null, "Лекции" },
                    { new Guid("eeb81c59-0753-4fc8-b723-fa252a264b0a"), new Guid("cefbd786-e1d2-44af-aeb4-c01c65133146"), null, "Есть" },
                    { new Guid("efca642c-cdc0-4446-ae1a-c0b3faa5feb8"), new Guid("75695e3c-ca9a-4c75-a0a7-b4e3c67b7f06"), null, "Английский" },
                    { new Guid("f9f61304-26ad-4ac3-b983-3283a6b3ca90"), new Guid("013cc657-4fdd-4720-994c-69f277afe681"), null, "Международный" },
                    { new Guid("fe8ffc97-8dfa-4c17-8229-3f7efe9cc6bd"), new Guid("6b5dc773-2a09-46cc-86fb-1a8ff0210f58"), null, "Исполнитель" }
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
