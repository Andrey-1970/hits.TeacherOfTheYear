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
                    { new Guid("31fe3e0f-7b0c-4ab7-bf4b-ee2e1dad31f2"), 3, "В процессе рассмотрения" },
                    { new Guid("339bb72f-7db0-4abd-aea9-810c7dde577c"), 5, "Отклонена" },
                    { new Guid("3d66ef32-908b-4ea0-8a13-b6177b7eb264"), 2, "В ожидании рассмотрения" },
                    { new Guid("814fb6f4-e591-44fc-a84e-7164e9802bfc"), 1, "В ожидании заполнения" },
                    { new Guid("ef55b7a9-8ef4-49cf-b07a-19c47eff6900"), 6, "Оценена" },
                    { new Guid("f27d0153-cedc-439d-8533-bb616cbe1d5f"), 4, "Одобрена" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c141175-4022-44d4-868e-8b3389f90a2a", null, "Organiser", "ORGANISER" },
                    { "64a7ebc6-93a0-4a5e-b6e4-038c17f371b6", null, "Expert", "EXPERT" },
                    { "653e036a-8613-4353-a880-bd02e7970839", null, "Admin", "ADMIN" },
                    { "9e783888-0690-4733-892a-8afdaab54a1d", null, "Participant", "PARTICIPANT" },
                    { "a9fc755a-3616-45ff-8073-6f9393358879", null, "Voter", "VOTER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0c600152-3678-4ea1-ad6a-d17096d2e1a3"), "Строительство и архитектура", 1 },
                    { new Guid("860b1b5a-5076-42a6-8505-b3e62988ba48"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("1a160172-a1a0-4753-9322-39e561f7894b"), "Научно-педагогическая деятельность", 5 },
                    { new Guid("55345b0e-0a28-4149-975b-a53cd88bb1ba"), "Общая информация", 1 },
                    { new Guid("6fafcf74-e541-4277-9fa9-1663abd7566a"), "Категория участников", 2 },
                    { new Guid("ddb854f6-288e-4531-8c8d-bc7abd13b903"), "Профессиональное развитие", 4 },
                    { new Guid("ecc9acfb-cb7d-4e24-adbd-944dad2e6477"), "Конкурсная работа", 3 },
                    { new Guid("eff5ba8a-4b9d-4862-900c-88b7f0177d0a"), "Научно-исследовательская деятельность", 6 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Checked", "Email", "Message", "Name" },
                values: new object[] { new Guid("29a214da-d059-4b4b-848f-ad13ca7ea1f9"), false, "system@system.ru", "Test Message for System", "SYSTEM" });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("23e3f5a3-9db1-4f8b-98c0-229198a72d83"), "Методическая деятельность", 3 },
                    { new Guid("3f2101f4-c9f6-4e65-89ce-4c7c80002804"), "Инновационная и иная деятельность", 6 },
                    { new Guid("57eea358-1a55-4c2f-b6a0-ac4a70c052b2"), "Конкурсная работа", 7 },
                    { new Guid("7a390d0a-b2df-4655-b992-5df774c3f750"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("aa89f7d0-27a8-4ae2-aefe-0e386166036f"), "Профессиональные показатели", 4 },
                    { new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577"), "Основной", 1 },
                    { new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3"), "Образовательная деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("29466caf-29b4-48d5-bf66-1ddd74ae7f1c"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("c668801c-9e74-46dc-a404-aecbe5c5ebe8"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("82dcb3a9-554a-422d-9066-d22a56caf284"), "TextArea" },
                    { new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7"), "int" },
                    { new Guid("c86453c8-bb60-47fb-9d88-4020a447d121"), "DateTime" },
                    { new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369"), "string" },
                    { new Guid("e6da0a01-2c32-475a-9c27-e60598f54228"), "bool" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("1a160172-a1a0-4753-9322-39e561f7894b"), new Guid("c668801c-9e74-46dc-a404-aecbe5c5ebe8") },
                    { new Guid("55345b0e-0a28-4149-975b-a53cd88bb1ba"), new Guid("29466caf-29b4-48d5-bf66-1ddd74ae7f1c") },
                    { new Guid("55345b0e-0a28-4149-975b-a53cd88bb1ba"), new Guid("c668801c-9e74-46dc-a404-aecbe5c5ebe8") },
                    { new Guid("6fafcf74-e541-4277-9fa9-1663abd7566a"), new Guid("29466caf-29b4-48d5-bf66-1ddd74ae7f1c") },
                    { new Guid("6fafcf74-e541-4277-9fa9-1663abd7566a"), new Guid("c668801c-9e74-46dc-a404-aecbe5c5ebe8") },
                    { new Guid("ddb854f6-288e-4531-8c8d-bc7abd13b903"), new Guid("29466caf-29b4-48d5-bf66-1ddd74ae7f1c") },
                    { new Guid("ddb854f6-288e-4531-8c8d-bc7abd13b903"), new Guid("c668801c-9e74-46dc-a404-aecbe5c5ebe8") },
                    { new Guid("ecc9acfb-cb7d-4e24-adbd-944dad2e6477"), new Guid("29466caf-29b4-48d5-bf66-1ddd74ae7f1c") },
                    { new Guid("ecc9acfb-cb7d-4e24-adbd-944dad2e6477"), new Guid("c668801c-9e74-46dc-a404-aecbe5c5ebe8") },
                    { new Guid("eff5ba8a-4b9d-4862-900c-88b7f0177d0a"), new Guid("29466caf-29b4-48d5-bf66-1ddd74ae7f1c") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("202c4ff2-232e-4624-81d9-2ed1d9814036"), new Guid("55345b0e-0a28-4149-975b-a53cd88bb1ba"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("285852ab-e1df-41ec-9895-b28b441d6c5a"), new Guid("eff5ba8a-4b9d-4862-900c-88b7f0177d0a"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("3bb5d16e-cf1f-4821-abd5-612a0e5fecd8"), new Guid("1a160172-a1a0-4753-9322-39e561f7894b"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("5dfe7ce7-554a-4793-b7b1-fa5a68588a3f"), new Guid("6fafcf74-e541-4277-9fa9-1663abd7566a"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("5e12b848-7796-4c9d-92f7-12054288bb1f"), new Guid("1a160172-a1a0-4753-9322-39e561f7894b"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("5e4b9951-2ff5-4f32-b356-07f8bf2fc3a2"), new Guid("55345b0e-0a28-4149-975b-a53cd88bb1ba"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("5f698694-8145-48ab-a11b-cc03cc04026a"), new Guid("55345b0e-0a28-4149-975b-a53cd88bb1ba"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("760c44c2-66fa-4799-98ba-dd33416d02b7"), new Guid("55345b0e-0a28-4149-975b-a53cd88bb1ba"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("7f8f1abf-fb1f-4505-9a55-01e7be876c58"), new Guid("55345b0e-0a28-4149-975b-a53cd88bb1ba"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("868099f3-a71f-47b2-bff8-e8a1b468503b"), new Guid("55345b0e-0a28-4149-975b-a53cd88bb1ba"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("8eece850-aa0e-4006-951e-00406f1ae283"), new Guid("eff5ba8a-4b9d-4862-900c-88b7f0177d0a"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("8f0c4fdf-3748-47e8-87ba-6ce390748db6"), new Guid("55345b0e-0a28-4149-975b-a53cd88bb1ba"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("9d2ed4a0-f2b6-4e65-840e-7b5a8b668153"), new Guid("55345b0e-0a28-4149-975b-a53cd88bb1ba"), null, true, true, "Место работы", 6, "Название организации", new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("afb20597-1e45-4c00-8cf8-fb0623c845e7"), new Guid("1a160172-a1a0-4753-9322-39e561f7894b"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("c53a5353-2275-4a8a-a6ea-65b57b58529c"), new Guid("6fafcf74-e541-4277-9fa9-1663abd7566a"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("c5d4173a-4997-4a6f-9090-04b985a96c17"), new Guid("6fafcf74-e541-4277-9fa9-1663abd7566a"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("c8d71622-55e3-40f3-82e7-31414073c936"), new Guid("55345b0e-0a28-4149-975b-a53cd88bb1ba"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("d05d7dca-c5ec-4445-ac1d-2204c02a4994"), new Guid("55345b0e-0a28-4149-975b-a53cd88bb1ba"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("c86453c8-bb60-47fb-9d88-4020a447d121") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("23e3f5a3-9db1-4f8b-98c0-229198a72d83"), new Guid("c668801c-9e74-46dc-a404-aecbe5c5ebe8") },
                    { new Guid("3f2101f4-c9f6-4e65-89ce-4c7c80002804"), new Guid("29466caf-29b4-48d5-bf66-1ddd74ae7f1c") },
                    { new Guid("57eea358-1a55-4c2f-b6a0-ac4a70c052b2"), new Guid("29466caf-29b4-48d5-bf66-1ddd74ae7f1c") },
                    { new Guid("57eea358-1a55-4c2f-b6a0-ac4a70c052b2"), new Guid("c668801c-9e74-46dc-a404-aecbe5c5ebe8") },
                    { new Guid("7a390d0a-b2df-4655-b992-5df774c3f750"), new Guid("29466caf-29b4-48d5-bf66-1ddd74ae7f1c") },
                    { new Guid("aa89f7d0-27a8-4ae2-aefe-0e386166036f"), new Guid("c668801c-9e74-46dc-a404-aecbe5c5ebe8") },
                    { new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577"), new Guid("29466caf-29b4-48d5-bf66-1ddd74ae7f1c") },
                    { new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577"), new Guid("c668801c-9e74-46dc-a404-aecbe5c5ebe8") },
                    { new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3"), new Guid("c668801c-9e74-46dc-a404-aecbe5c5ebe8") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("024ecc6b-8207-4c8a-bfbe-04be10f27386"), new Guid("eff5ba8a-4b9d-4862-900c-88b7f0177d0a"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("163c3f68-2b6d-491c-8f5d-48507a307a1f"), new Guid("eff5ba8a-4b9d-4862-900c-88b7f0177d0a"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("18a0d6bf-770a-4857-a3dc-2cab801a2f00"), new Guid("ddb854f6-288e-4531-8c8d-bc7abd13b903"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 },
                    { new Guid("51430dec-ae6f-401c-ac9c-a55c1643c060"), new Guid("ddb854f6-288e-4531-8c8d-bc7abd13b903"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("66e2b6e1-5aa9-4ec3-a02d-0dd305a029d4"), new Guid("1a160172-a1a0-4753-9322-39e561f7894b"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 },
                    { new Guid("ac34c976-4041-46f8-9e0b-a3ba3f0f6512"), new Guid("1a160172-a1a0-4753-9322-39e561f7894b"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 },
                    { new Guid("b2a9be0e-d162-4efe-b594-fdd635c86cbd"), new Guid("ecc9acfb-cb7d-4e24-adbd-944dad2e6477"), true, true, "Краткая аннотация конкурсной работы", 1 },
                    { new Guid("b4753eb2-515f-4568-97c2-031785054fae"), new Guid("eff5ba8a-4b9d-4862-900c-88b7f0177d0a"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("cccaf1ef-6454-4d0b-b2bc-867d8da9131d"), new Guid("1a160172-a1a0-4753-9322-39e561f7894b"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("d88264f8-3767-48eb-90ad-21706e1d2bec"), new Guid("ddb854f6-288e-4531-8c8d-bc7abd13b903"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("df4991fe-f095-430c-a3a0-540c258f5485"), new Guid("eff5ba8a-4b9d-4862-900c-88b7f0177d0a"), false, false, "Список научных публикаций за последние 5 лет", 10 },
                    { new Guid("f950dee5-3feb-4cd0-b5ec-4b8b74ef49c8"), new Guid("1a160172-a1a0-4753-9322-39e561f7894b"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("facae2b8-722b-4e5e-8d71-f95d9f66cd48"), new Guid("1a160172-a1a0-4753-9322-39e561f7894b"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("053eba6e-ebb8-4988-986a-f23ad611c20a"), true, "Год", 1, new Guid("18a0d6bf-770a-4857-a3dc-2cab801a2f00"), new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("0b6a6c5b-502a-4f49-9309-0a9a19b11eb7"), true, "Год получения документа", 2, new Guid("d88264f8-3767-48eb-90ad-21706e1d2bec"), new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("0c41dd85-7772-4274-878f-b9d15e926176"), true, "Название", 2, new Guid("163c3f68-2b6d-491c-8f5d-48507a307a1f"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("0c5071a8-f271-42fe-ae26-e125f7266627"), true, "Номер РИД", 4, new Guid("163c3f68-2b6d-491c-8f5d-48507a307a1f"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("0d73e716-4722-4e0f-94fd-0e2b2a9eed2f"), true, "Название дисциплины", 1, new Guid("66e2b6e1-5aa9-4ec3-a02d-0dd305a029d4"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("10bab067-92e8-4c89-a47f-fe64c5761936"), true, "Наименование курса", 1, new Guid("cccaf1ef-6454-4d0b-b2bc-867d8da9131d"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("15c5c6c9-515c-497f-aaa0-0e592f168de7"), true, "Вид публикации", 1, new Guid("facae2b8-722b-4e5e-8d71-f95d9f66cd48"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("1a17b11d-0116-4f59-8ad5-500c9b9c167c"), true, "Ссылка на открытый доступ", 8, new Guid("facae2b8-722b-4e5e-8d71-f95d9f66cd48"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("251ab893-acbb-4511-8e72-4101f2e659f0"), true, "Название", 2, new Guid("facae2b8-722b-4e5e-8d71-f95d9f66cd48"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("2828a61f-7974-44eb-832c-614f43629a80"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("ac34c976-4041-46f8-9e0b-a3ba3f0f6512"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("2f6bbef8-11fb-4b98-8c34-c40b0243d275"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("b4753eb2-515f-4568-97c2-031785054fae"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("302dbd3a-faa0-49b4-b15f-8236b66ad6c5"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("ac34c976-4041-46f8-9e0b-a3ba3f0f6512"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("32306500-eee1-4b84-8228-40eb1d156c9f"), true, "Название курса", 1, new Guid("f950dee5-3feb-4cd0-b5ec-4b8b74ef49c8"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("34862597-6c59-4d3c-9d94-58b2988de4c3"), true, "Издательство, год", 6, new Guid("facae2b8-722b-4e5e-8d71-f95d9f66cd48"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("37ba7725-d908-47a9-818c-4c2ff62224d7"), true, "Лекции (час.)", 3, new Guid("cccaf1ef-6454-4d0b-b2bc-867d8da9131d"), new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("3c5a26c0-29a4-40f5-bb06-5840637d6ee3"), true, "Название", 1, new Guid("b2a9be0e-d162-4efe-b594-fdd635c86cbd"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("3eeddf24-33bf-41af-b989-544aa64a66aa"), true, "Ссылка", 5, new Guid("18a0d6bf-770a-4857-a3dc-2cab801a2f00"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("4067dede-5a40-4651-8061-1a800f7659f3"), true, "Ссылка на платформу", 3, new Guid("f950dee5-3feb-4cd0-b5ec-4b8b74ef49c8"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("431e73c9-fd8e-4cf5-b2b8-a3e4420be043"), true, "Соавторы", 2, new Guid("f950dee5-3feb-4cd0-b5ec-4b8b74ef49c8"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("4fa7adc9-49fe-49e8-b896-7c02106f88db"), true, "ФИО соавторов", 3, new Guid("163c3f68-2b6d-491c-8f5d-48507a307a1f"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("55e04c5d-ba76-47fe-ad07-9fc2508ed9dc"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("df4991fe-f095-430c-a3a0-540c258f5485"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("571dcbb3-58e0-4551-be60-f99a75dda839"), true, "Название НИР/НИОКР", 1, new Guid("b4753eb2-515f-4568-97c2-031785054fae"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("644ef08f-984c-4e64-9b8d-099f075e4e7c"), true, "Язык публикации", 7, new Guid("facae2b8-722b-4e5e-8d71-f95d9f66cd48"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("6c195661-5698-4a78-827c-96cae0c7ee95"), true, "Итого (час.)", 5, new Guid("cccaf1ef-6454-4d0b-b2bc-867d8da9131d"), new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("71b0113b-ac3f-47de-a5ad-15acf07b6537"), true, "Название конкурса/премии", 2, new Guid("ac34c976-4041-46f8-9e0b-a3ba3f0f6512"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("76533f46-1e83-4564-b758-c3bffb37604d"), true, "Наличие грифа", 5, new Guid("facae2b8-722b-4e5e-8d71-f95d9f66cd48"), new Guid("e6da0a01-2c32-475a-9c27-e60598f54228") },
                    { new Guid("76f08ac7-79bf-4843-ac5b-a4aa3c9e35df"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("18a0d6bf-770a-4857-a3dc-2cab801a2f00"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("84048dd5-aa21-4ba3-8153-39f2188ed262"), true, "Соавторы", 2, new Guid("df4991fe-f095-430c-a3a0-540c258f5485"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("846dde22-6f82-4007-a6c5-cb524404481b"), true, "Период выполнения", 3, new Guid("b4753eb2-515f-4568-97c2-031785054fae"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("85cbbcd2-acdd-4318-9a65-e4aefce4801b"), true, "Вид", 2, new Guid("66e2b6e1-5aa9-4ec3-a02d-0dd305a029d4"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("901fb26a-c9c4-4e84-9cdb-75ebca87d586"), true, "Вид", 1, new Guid("163c3f68-2b6d-491c-8f5d-48507a307a1f"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("9462a63e-3f5b-416a-891d-314b3fb7a60a"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("b4753eb2-515f-4568-97c2-031785054fae"), new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("97dcd596-7ce6-4ae1-856d-51ec7088e985"), true, "Название организации в которую внедрена разработка", 3, new Guid("024ecc6b-8207-4c8a-bfbe-04be10f27386"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("99f5f03b-0dce-404b-a8a1-911ae7b7ed89"), true, "Практические занятия (час.)", 4, new Guid("cccaf1ef-6454-4d0b-b2bc-867d8da9131d"), new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("9b72899c-b984-4598-a464-85e6fa31da46"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("66e2b6e1-5aa9-4ec3-a02d-0dd305a029d4"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("a1310bb8-8735-4222-b388-5a5c01a6157f"), true, "Статус", 4, new Guid("b4753eb2-515f-4568-97c2-031785054fae"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("a329f8f7-e0aa-4615-a2c2-cf9396c0b1a6"), true, "Название разработки", 2, new Guid("024ecc6b-8207-4c8a-bfbe-04be10f27386"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("a6658f08-4db9-474a-a8d2-70b79be83d71"), false, "Тип идентификатора", 1, new Guid("51430dec-ae6f-401c-ac9c-a55c1643c060"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("b95f12e4-4882-47c5-ad80-36193a1b1872"), true, "Год", 4, new Guid("f950dee5-3feb-4cd0-b5ec-4b8b74ef49c8"), new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("c06661e4-ac15-4d50-94b5-83272f549c51"), true, "Издание, год", 4, new Guid("df4991fe-f095-430c-a3a0-540c258f5485"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("c2b2fb11-74e3-4b2c-84e6-3d7fd3832fe2"), true, "ФИО", 1, new Guid("ac34c976-4041-46f8-9e0b-a3ba3f0f6512"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("d4a558e1-824a-4a58-b30c-94412ebf4948"), true, "Количество печатных листов", 4, new Guid("facae2b8-722b-4e5e-8d71-f95d9f66cd48"), new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("d8d011d6-19a1-4c53-8973-c3e9a6c7b02f"), false, "Соавторы", 3, new Guid("facae2b8-722b-4e5e-8d71-f95d9f66cd48"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("d94e98a9-d10b-4bce-a5b7-faa344c319a4"), true, "Название конкурса", 2, new Guid("18a0d6bf-770a-4857-a3dc-2cab801a2f00"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("db9356c8-99f0-4351-ace2-6e873da67eb5"), true, "Год", 3, new Guid("ac34c976-4041-46f8-9e0b-a3ba3f0f6512"), new Guid("c2d0a9ec-7589-4a9c-b055-ed10619b2ef7") },
                    { new Guid("db9d24f1-273c-45fa-9b12-7af653275516"), true, "Язык преподавания", 2, new Guid("cccaf1ef-6454-4d0b-b2bc-867d8da9131d"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("debd5830-d6b6-4ea8-9bf1-be192376bd3f"), false, "Идентификатор", 2, new Guid("51430dec-ae6f-401c-ac9c-a55c1643c060"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("e0c4664d-5f9e-4da8-9a63-0a382ad9d3ae"), true, "Значение", 2, new Guid("b2a9be0e-d162-4efe-b594-fdd635c86cbd"), new Guid("82dcb3a9-554a-422d-9066-d22a56caf284") },
                    { new Guid("e8e6e2bc-f8e4-4389-831a-67c3f518044e"), true, "Вид", 1, new Guid("024ecc6b-8207-4c8a-bfbe-04be10f27386"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("f0ad9e8b-f8a5-4d20-b0a2-ce7781550af0"), true, "Название документа, реквизиты", 1, new Guid("d88264f8-3767-48eb-90ad-21706e1d2bec"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("f8f6e6bb-d6d7-43d4-b0be-1510e4588013"), true, "Название статьи", 1, new Guid("df4991fe-f095-430c-a3a0-540c258f5485"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") },
                    { new Guid("ffff7bee-3535-436d-97ba-002a46926e6d"), true, "Статус конкурса", 3, new Guid("18a0d6bf-770a-4857-a3dc-2cab801a2f00"), new Guid("df9cba96-8f35-499c-9ddb-14e227ecf369") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("202c4ff2-232e-4624-81d9-2ed1d9814036"), new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577") },
                    { new Guid("285852ab-e1df-41ec-9895-b28b441d6c5a"), new Guid("7a390d0a-b2df-4655-b992-5df774c3f750") },
                    { new Guid("3bb5d16e-cf1f-4821-abd5-612a0e5fecd8"), new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3") },
                    { new Guid("5dfe7ce7-554a-4793-b7b1-fa5a68588a3f"), new Guid("7a390d0a-b2df-4655-b992-5df774c3f750") },
                    { new Guid("5dfe7ce7-554a-4793-b7b1-fa5a68588a3f"), new Guid("aa89f7d0-27a8-4ae2-aefe-0e386166036f") },
                    { new Guid("5dfe7ce7-554a-4793-b7b1-fa5a68588a3f"), new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577") },
                    { new Guid("5e12b848-7796-4c9d-92f7-12054288bb1f"), new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3") },
                    { new Guid("5e4b9951-2ff5-4f32-b356-07f8bf2fc3a2"), new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577") },
                    { new Guid("5f698694-8145-48ab-a11b-cc03cc04026a"), new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577") },
                    { new Guid("760c44c2-66fa-4799-98ba-dd33416d02b7"), new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577") },
                    { new Guid("7f8f1abf-fb1f-4505-9a55-01e7be876c58"), new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577") },
                    { new Guid("868099f3-a71f-47b2-bff8-e8a1b468503b"), new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577") },
                    { new Guid("8eece850-aa0e-4006-951e-00406f1ae283"), new Guid("7a390d0a-b2df-4655-b992-5df774c3f750") },
                    { new Guid("8f0c4fdf-3748-47e8-87ba-6ce390748db6"), new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577") },
                    { new Guid("9d2ed4a0-f2b6-4e65-840e-7b5a8b668153"), new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577") },
                    { new Guid("afb20597-1e45-4c00-8cf8-fb0623c845e7"), new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3") },
                    { new Guid("c53a5353-2275-4a8a-a6ea-65b57b58529c"), new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577") },
                    { new Guid("c5d4173a-4997-4a6f-9090-04b985a96c17"), new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577") },
                    { new Guid("c8d71622-55e3-40f3-82e7-31414073c936"), new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577") },
                    { new Guid("d05d7dca-c5ec-4445-ac1d-2204c02a4994"), new Guid("b84b9975-6879-4c6e-a7d0-e8701f968577") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("23e3f5a3-9db1-4f8b-98c0-229198a72d83"), new Guid("66e2b6e1-5aa9-4ec3-a02d-0dd305a029d4") },
                    { new Guid("23e3f5a3-9db1-4f8b-98c0-229198a72d83"), new Guid("facae2b8-722b-4e5e-8d71-f95d9f66cd48") },
                    { new Guid("3f2101f4-c9f6-4e65-89ce-4c7c80002804"), new Guid("024ecc6b-8207-4c8a-bfbe-04be10f27386") },
                    { new Guid("3f2101f4-c9f6-4e65-89ce-4c7c80002804"), new Guid("163c3f68-2b6d-491c-8f5d-48507a307a1f") },
                    { new Guid("3f2101f4-c9f6-4e65-89ce-4c7c80002804"), new Guid("d88264f8-3767-48eb-90ad-21706e1d2bec") },
                    { new Guid("57eea358-1a55-4c2f-b6a0-ac4a70c052b2"), new Guid("b2a9be0e-d162-4efe-b594-fdd635c86cbd") },
                    { new Guid("7a390d0a-b2df-4655-b992-5df774c3f750"), new Guid("18a0d6bf-770a-4857-a3dc-2cab801a2f00") },
                    { new Guid("7a390d0a-b2df-4655-b992-5df774c3f750"), new Guid("51430dec-ae6f-401c-ac9c-a55c1643c060") },
                    { new Guid("7a390d0a-b2df-4655-b992-5df774c3f750"), new Guid("b4753eb2-515f-4568-97c2-031785054fae") },
                    { new Guid("7a390d0a-b2df-4655-b992-5df774c3f750"), new Guid("df4991fe-f095-430c-a3a0-540c258f5485") },
                    { new Guid("aa89f7d0-27a8-4ae2-aefe-0e386166036f"), new Guid("18a0d6bf-770a-4857-a3dc-2cab801a2f00") },
                    { new Guid("aa89f7d0-27a8-4ae2-aefe-0e386166036f"), new Guid("d88264f8-3767-48eb-90ad-21706e1d2bec") },
                    { new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3"), new Guid("ac34c976-4041-46f8-9e0b-a3ba3f0f6512") },
                    { new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3"), new Guid("cccaf1ef-6454-4d0b-b2bc-867d8da9131d") },
                    { new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3"), new Guid("f950dee5-3feb-4cd0-b5ec-4b8b74ef49c8") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("05bdca45-e52b-4d45-97e7-66250d90f5e1"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("b4753eb2-515f-4568-97c2-031785054fae") },
                    { new Guid("0e46bcb3-380f-464f-9464-3366bea6d1f0"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("66e2b6e1-5aa9-4ec3-a02d-0dd305a029d4") },
                    { new Guid("1f81b2ba-1447-45f1-983d-d471b0bd13ec"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("b2a9be0e-d162-4efe-b594-fdd635c86cbd") },
                    { new Guid("3565ac35-3dfe-44b2-bcbe-96cc30d0453e"), "EvaluateMark3", new Guid("3bb5d16e-cf1f-4821-abd5-612a0e5fecd8"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("40747b2d-dbba-4dde-879a-f5f943a31eb2"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("d88264f8-3767-48eb-90ad-21706e1d2bec") },
                    { new Guid("43750645-15d5-4621-81bc-30dcc9ef2dd5"), "EvaluateMark4", new Guid("afb20597-1e45-4c00-8cf8-fb0623c845e7"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("45e4a6a7-5f20-44b4-baeb-fef239173fd6"), "EvaluateMark13", new Guid("5dfe7ce7-554a-4793-b7b1-fa5a68588a3f"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("60bd9a12-9064-4c72-9c33-7f40b2ae6c57"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("facae2b8-722b-4e5e-8d71-f95d9f66cd48") },
                    { new Guid("69cbfe8e-8861-4cde-90cb-cef1026f8d4a"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("cccaf1ef-6454-4d0b-b2bc-867d8da9131d") },
                    { new Guid("6a57bbd5-fa24-4278-a53d-2f101d9940e9"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("f950dee5-3feb-4cd0-b5ec-4b8b74ef49c8") },
                    { new Guid("71a59f78-4cf5-46d1-b061-8c0620b88cfd"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("facae2b8-722b-4e5e-8d71-f95d9f66cd48") },
                    { new Guid("7320b799-edf2-4f32-9478-284bd569b9d7"), "EvaluateMark20", new Guid("285852ab-e1df-41ec-9895-b28b441d6c5a"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("7b8152ec-ea21-4aa4-8a93-f26a8d3d6251"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("cccaf1ef-6454-4d0b-b2bc-867d8da9131d") },
                    { new Guid("7edcb638-48cd-48ca-ad00-b5cc2976c1d9"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("df4991fe-f095-430c-a3a0-540c258f5485") },
                    { new Guid("8c1c6596-dfc0-4e0b-98c5-7c5d151b9947"), "EvaluateMark19", new Guid("8eece850-aa0e-4006-951e-00406f1ae283"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("8effa915-f14d-4776-ac28-9767c6a7e2fd"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("b4753eb2-515f-4568-97c2-031785054fae") },
                    { new Guid("99b49122-1a55-4801-ab4b-28e7d148cafc"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("163c3f68-2b6d-491c-8f5d-48507a307a1f") },
                    { new Guid("a9b1de5d-48f1-472b-b632-8b7850633287"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("b2a9be0e-d162-4efe-b594-fdd635c86cbd") },
                    { new Guid("b85613fc-8633-414b-b38a-9272670b63c9"), "EvaluateMark5", new Guid("5e12b848-7796-4c9d-92f7-12054288bb1f"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("c7bd78d2-9d04-42e7-a222-5303b958c8f4"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("024ecc6b-8207-4c8a-bfbe-04be10f27386") },
                    { new Guid("cca37bde-2dcd-4228-8a87-d6ab48047471"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("ac34c976-4041-46f8-9e0b-a3ba3f0f6512") },
                    { new Guid("e0dc5a50-21e7-42fa-b926-65eb40f2aa5e"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом и без соавторства:", 8, new Guid("facae2b8-722b-4e5e-8d71-f95d9f66cd48") },
                    { new Guid("ef250158-d577-4fc4-bb53-ef9bc5b16e2d"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом в соавторстве:", 9, new Guid("facae2b8-722b-4e5e-8d71-f95d9f66cd48") },
                    { new Guid("f81e479f-7f67-45b6-97c4-bc367636ca85"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("18a0d6bf-770a-4857-a3dc-2cab801a2f00") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0ffecc9c-41df-4830-a1c4-881054c0b520"), true, 1, new Guid("b2a9be0e-d162-4efe-b594-fdd635c86cbd") },
                    { new Guid("12b89ab3-8a27-492a-94e1-b6e31e75e926"), true, 3, new Guid("b2a9be0e-d162-4efe-b594-fdd635c86cbd") },
                    { new Guid("1dfde371-bfbc-4c69-87ef-6105958864e5"), true, 2, new Guid("b2a9be0e-d162-4efe-b594-fdd635c86cbd") },
                    { new Guid("2e311395-5967-4693-b8b8-8d66e9c204d4"), true, 6, new Guid("b2a9be0e-d162-4efe-b594-fdd635c86cbd") },
                    { new Guid("3515f9c6-ec0c-44de-b3e9-b7e318b795e8"), true, 8, new Guid("b2a9be0e-d162-4efe-b594-fdd635c86cbd") },
                    { new Guid("43cd727e-9914-43ff-936a-283fc639baf2"), true, 5, new Guid("51430dec-ae6f-401c-ac9c-a55c1643c060") },
                    { new Guid("4cadb1a1-ce21-4913-bca5-cb43226ad275"), true, 7, new Guid("b2a9be0e-d162-4efe-b594-fdd635c86cbd") },
                    { new Guid("7ef6459b-44c9-4741-9b75-c00570fff366"), true, 2, new Guid("51430dec-ae6f-401c-ac9c-a55c1643c060") },
                    { new Guid("829ce874-59c1-4733-b9b9-9bdda432056b"), true, 1, new Guid("51430dec-ae6f-401c-ac9c-a55c1643c060") },
                    { new Guid("ba61bd0f-7a19-4b57-a078-bfdf681cf4e3"), true, 4, new Guid("b2a9be0e-d162-4efe-b594-fdd635c86cbd") },
                    { new Guid("c47edb9f-e74e-4148-a76d-46931a03fbe0"), true, 5, new Guid("b2a9be0e-d162-4efe-b594-fdd635c86cbd") },
                    { new Guid("d351dc50-8927-40c1-9841-b11754cc9eec"), true, 4, new Guid("51430dec-ae6f-401c-ac9c-a55c1643c060") },
                    { new Guid("ec86f23f-2eb2-40e5-9263-ec116a6055ad"), true, 3, new Guid("51430dec-ae6f-401c-ac9c-a55c1643c060") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("02440a26-ffb1-42ff-a17e-cdfafacb834d"), null, new Guid("c5d4173a-4997-4a6f-9090-04b985a96c17"), "Доктор наук" },
                    { new Guid("4444f4c9-aa52-4e74-bb6b-cb8f80f2af36"), null, new Guid("5dfe7ce7-554a-4793-b7b1-fa5a68588a3f"), "Нет" },
                    { new Guid("589059c7-dd7e-4d88-85f2-a8984ccffefa"), null, new Guid("5dfe7ce7-554a-4793-b7b1-fa5a68588a3f"), "Профессор" },
                    { new Guid("8ee896e8-1523-414a-b6e3-d522f2904c7b"), null, new Guid("c5d4173a-4997-4a6f-9090-04b985a96c17"), "Кандидат наук" },
                    { new Guid("e54a532b-1644-410f-be57-fc1c9f519bc0"), null, new Guid("5dfe7ce7-554a-4793-b7b1-fa5a68588a3f"), "Доцент" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("001a12a9-406d-446e-9380-f46241ad05e4"), null, new Guid("a6658f08-4db9-474a-a8d2-70b79be83d71"), true, true, new Guid("7ef6459b-44c9-4741-9b75-c00570fff366"), "ORCiD" },
                    { new Guid("038975ff-3117-499a-939c-d45369eabb01"), null, new Guid("debd5830-d6b6-4ea8-9bf1-be192376bd3f"), false, true, new Guid("7ef6459b-44c9-4741-9b75-c00570fff366"), null },
                    { new Guid("0d32a553-2b7d-4000-ab62-c1000ffa3e81"), null, new Guid("3c5a26c0-29a4-40f5-bb06-5840637d6ee3"), true, true, new Guid("4cadb1a1-ce21-4913-bca5-cb43226ad275"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("1c730f6d-f45f-4ea5-97fe-55252b29e8cc"), null, new Guid("e0c4664d-5f9e-4da8-9a63-0a382ad9d3ae"), false, true, new Guid("4cadb1a1-ce21-4913-bca5-cb43226ad275"), null },
                    { new Guid("224f66b7-0723-4a7f-b8a1-c74ea5bc74f0"), null, new Guid("debd5830-d6b6-4ea8-9bf1-be192376bd3f"), false, true, new Guid("829ce874-59c1-4733-b9b9-9bdda432056b"), null },
                    { new Guid("360e7c85-5f3b-43aa-aded-17ca8100ad66"), null, new Guid("a6658f08-4db9-474a-a8d2-70b79be83d71"), true, true, new Guid("43cd727e-9914-43ff-936a-283fc639baf2"), "Google Scholar ID" },
                    { new Guid("4478d0a0-cad8-4ade-938b-4fe786e9b025"), null, new Guid("debd5830-d6b6-4ea8-9bf1-be192376bd3f"), false, true, new Guid("43cd727e-9914-43ff-936a-283fc639baf2"), null },
                    { new Guid("4f07ff47-f8ed-411a-acb4-10289a134c2b"), null, new Guid("3c5a26c0-29a4-40f5-bb06-5840637d6ee3"), true, true, new Guid("0ffecc9c-41df-4830-a1c4-881054c0b520"), "Название работы" },
                    { new Guid("62363edf-405f-4f9d-b1ab-b125a1d1e1a5"), null, new Guid("3c5a26c0-29a4-40f5-bb06-5840637d6ee3"), true, true, new Guid("3515f9c6-ec0c-44de-b3e9-b7e318b795e8"), "Результаты и выводы" },
                    { new Guid("62fe4c3f-0d53-4b44-b46a-4d1558333916"), null, new Guid("3c5a26c0-29a4-40f5-bb06-5840637d6ee3"), true, true, new Guid("ba61bd0f-7a19-4b57-a078-bfdf681cf4e3"), "Методология и методы, используемые в работе" },
                    { new Guid("70591fd6-e239-4d56-b7c1-647fd711d653"), null, new Guid("3c5a26c0-29a4-40f5-bb06-5840637d6ee3"), true, true, new Guid("1dfde371-bfbc-4c69-87ef-6105958864e5"), "Актуальность конкурсной работы" },
                    { new Guid("7c9fb4ca-97b3-4e07-83cf-deb8a4328387"), null, new Guid("e0c4664d-5f9e-4da8-9a63-0a382ad9d3ae"), false, true, new Guid("12b89ab3-8a27-492a-94e1-b6e31e75e926"), null },
                    { new Guid("8c2f74c4-7427-4044-ba36-798761bb8d9d"), null, new Guid("debd5830-d6b6-4ea8-9bf1-be192376bd3f"), false, true, new Guid("d351dc50-8927-40c1-9841-b11754cc9eec"), null },
                    { new Guid("9e5e2f35-bf66-4fb4-a44d-0f66c42655d9"), null, new Guid("3c5a26c0-29a4-40f5-bb06-5840637d6ee3"), true, true, new Guid("12b89ab3-8a27-492a-94e1-b6e31e75e926"), "Инновационность" },
                    { new Guid("a3510bf1-a134-40de-80c8-f7189d8c4839"), null, new Guid("e0c4664d-5f9e-4da8-9a63-0a382ad9d3ae"), false, true, new Guid("ba61bd0f-7a19-4b57-a078-bfdf681cf4e3"), null },
                    { new Guid("a544b3b6-faed-4d2f-8405-f86c4efe7d55"), null, new Guid("debd5830-d6b6-4ea8-9bf1-be192376bd3f"), false, true, new Guid("ec86f23f-2eb2-40e5-9263-ec116a6055ad"), null },
                    { new Guid("aac6ef1e-6c5a-4a43-aa1f-0d35336224cf"), null, new Guid("e0c4664d-5f9e-4da8-9a63-0a382ad9d3ae"), false, true, new Guid("0ffecc9c-41df-4830-a1c4-881054c0b520"), null },
                    { new Guid("b06feb57-05da-44e5-8056-761bad94219c"), null, new Guid("e0c4664d-5f9e-4da8-9a63-0a382ad9d3ae"), false, true, new Guid("3515f9c6-ec0c-44de-b3e9-b7e318b795e8"), null },
                    { new Guid("b1a5892f-5411-46d5-b4df-45b3c94ffb1f"), null, new Guid("a6658f08-4db9-474a-a8d2-70b79be83d71"), true, true, new Guid("829ce874-59c1-4733-b9b9-9bdda432056b"), "ScopusID" },
                    { new Guid("bae6ee40-9fa2-425f-902e-629b02dc8842"), null, new Guid("a6658f08-4db9-474a-a8d2-70b79be83d71"), true, true, new Guid("ec86f23f-2eb2-40e5-9263-ec116a6055ad"), "ResearcherID" },
                    { new Guid("be365ab6-7824-4f5c-8c6c-d71699d36591"), null, new Guid("3c5a26c0-29a4-40f5-bb06-5840637d6ee3"), true, true, new Guid("2e311395-5967-4693-b8b8-8d66e9c204d4"), "Апробация" },
                    { new Guid("c7f352d5-d228-46eb-9169-0bc83ee4ee00"), null, new Guid("e0c4664d-5f9e-4da8-9a63-0a382ad9d3ae"), false, true, new Guid("2e311395-5967-4693-b8b8-8d66e9c204d4"), null },
                    { new Guid("d66996cd-4b91-421f-bcfb-39beee8d9030"), null, new Guid("e0c4664d-5f9e-4da8-9a63-0a382ad9d3ae"), false, true, new Guid("c47edb9f-e74e-4148-a76d-46931a03fbe0"), null },
                    { new Guid("e6860710-2aa5-468d-85b8-80dbce21c7bb"), null, new Guid("a6658f08-4db9-474a-a8d2-70b79be83d71"), true, true, new Guid("d351dc50-8927-40c1-9841-b11754cc9eec"), "РИНЦ AuthorID" },
                    { new Guid("e763e467-801c-4b99-92de-b349bfa1d6da"), null, new Guid("3c5a26c0-29a4-40f5-bb06-5840637d6ee3"), true, true, new Guid("c47edb9f-e74e-4148-a76d-46931a03fbe0"), "Ссылка на конкурсную работу" },
                    { new Guid("ea6164b4-a796-4284-88e0-d0c3fa6a41be"), null, new Guid("e0c4664d-5f9e-4da8-9a63-0a382ad9d3ae"), false, true, new Guid("1dfde371-bfbc-4c69-87ef-6105958864e5"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("23e3f5a3-9db1-4f8b-98c0-229198a72d83"), new Guid("0e46bcb3-380f-464f-9464-3366bea6d1f0") },
                    { new Guid("23e3f5a3-9db1-4f8b-98c0-229198a72d83"), new Guid("60bd9a12-9064-4c72-9c33-7f40b2ae6c57") },
                    { new Guid("23e3f5a3-9db1-4f8b-98c0-229198a72d83"), new Guid("71a59f78-4cf5-46d1-b061-8c0620b88cfd") },
                    { new Guid("23e3f5a3-9db1-4f8b-98c0-229198a72d83"), new Guid("e0dc5a50-21e7-42fa-b926-65eb40f2aa5e") },
                    { new Guid("23e3f5a3-9db1-4f8b-98c0-229198a72d83"), new Guid("ef250158-d577-4fc4-bb53-ef9bc5b16e2d") },
                    { new Guid("3f2101f4-c9f6-4e65-89ce-4c7c80002804"), new Guid("40747b2d-dbba-4dde-879a-f5f943a31eb2") },
                    { new Guid("3f2101f4-c9f6-4e65-89ce-4c7c80002804"), new Guid("99b49122-1a55-4801-ab4b-28e7d148cafc") },
                    { new Guid("3f2101f4-c9f6-4e65-89ce-4c7c80002804"), new Guid("c7bd78d2-9d04-42e7-a222-5303b958c8f4") },
                    { new Guid("57eea358-1a55-4c2f-b6a0-ac4a70c052b2"), new Guid("1f81b2ba-1447-45f1-983d-d471b0bd13ec") },
                    { new Guid("57eea358-1a55-4c2f-b6a0-ac4a70c052b2"), new Guid("a9b1de5d-48f1-472b-b632-8b7850633287") },
                    { new Guid("7a390d0a-b2df-4655-b992-5df774c3f750"), new Guid("05bdca45-e52b-4d45-97e7-66250d90f5e1") },
                    { new Guid("7a390d0a-b2df-4655-b992-5df774c3f750"), new Guid("45e4a6a7-5f20-44b4-baeb-fef239173fd6") },
                    { new Guid("7a390d0a-b2df-4655-b992-5df774c3f750"), new Guid("7320b799-edf2-4f32-9478-284bd569b9d7") },
                    { new Guid("7a390d0a-b2df-4655-b992-5df774c3f750"), new Guid("7edcb638-48cd-48ca-ad00-b5cc2976c1d9") },
                    { new Guid("7a390d0a-b2df-4655-b992-5df774c3f750"), new Guid("8c1c6596-dfc0-4e0b-98c5-7c5d151b9947") },
                    { new Guid("7a390d0a-b2df-4655-b992-5df774c3f750"), new Guid("8effa915-f14d-4776-ac28-9767c6a7e2fd") },
                    { new Guid("7a390d0a-b2df-4655-b992-5df774c3f750"), new Guid("f81e479f-7f67-45b6-97c4-bc367636ca85") },
                    { new Guid("aa89f7d0-27a8-4ae2-aefe-0e386166036f"), new Guid("40747b2d-dbba-4dde-879a-f5f943a31eb2") },
                    { new Guid("aa89f7d0-27a8-4ae2-aefe-0e386166036f"), new Guid("45e4a6a7-5f20-44b4-baeb-fef239173fd6") },
                    { new Guid("aa89f7d0-27a8-4ae2-aefe-0e386166036f"), new Guid("f81e479f-7f67-45b6-97c4-bc367636ca85") },
                    { new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3"), new Guid("3565ac35-3dfe-44b2-bcbe-96cc30d0453e") },
                    { new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3"), new Guid("43750645-15d5-4621-81bc-30dcc9ef2dd5") },
                    { new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3"), new Guid("69cbfe8e-8861-4cde-90cb-cef1026f8d4a") },
                    { new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3"), new Guid("6a57bbd5-fa24-4278-a53d-2f101d9940e9") },
                    { new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3"), new Guid("7b8152ec-ea21-4aa4-8a93-f26a8d3d6251") },
                    { new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3"), new Guid("b85613fc-8633-414b-b38a-9272670b63c9") },
                    { new Guid("cc7b6819-0149-4539-b257-9a98d1d1dfb3"), new Guid("cca37bde-2dcd-4228-8a87-d6ab48047471") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0e042da1-4520-4edc-96e3-25be09c23671"), new Guid("431e73c9-fd8e-4cf5-b2b8-a3e4420be043"), null, "Нет" },
                    { new Guid("106940f5-309b-4b9f-89ed-3ee3f42d78e2"), new Guid("644ef08f-984c-4e64-9b8d-099f075e4e7c"), null, "Русский" },
                    { new Guid("121ea70c-0bc5-46db-b7b7-7f74a0511504"), new Guid("a1310bb8-8735-4222-b388-5a5c01a6157f"), null, "Исполнитель" },
                    { new Guid("15d9e6f0-5099-47ac-bbe0-8da7e1fb7dac"), new Guid("901fb26a-c9c4-4e84-9cdb-75ebca87d586"), null, "Изобретение" },
                    { new Guid("2b2bb834-7310-491a-a59b-d66ab0ee8742"), new Guid("ffff7bee-3535-436d-97ba-002a46926e6d"), null, "Региональный" },
                    { new Guid("2d6cf2aa-7c44-4938-94cc-cb47a3db2a1c"), new Guid("d8d011d6-19a1-4c53-8973-c3e9a6c7b02f"), null, "Есть" },
                    { new Guid("2e60c6ea-3ac4-4ebb-975c-23fd648f7f0b"), new Guid("76533f46-1e83-4564-b758-c3bffb37604d"), null, "Нет" },
                    { new Guid("2fc48f85-5a4e-4de7-a39e-84c67fcdfb99"), new Guid("15c5c6c9-515c-497f-aaa0-0e592f168de7"), null, "Монография" },
                    { new Guid("39bb2992-1efd-42b8-8c4c-36ba0e7baab4"), new Guid("55e04c5d-ba76-47fe-ad07-9fc2508ed9dc"), null, "МБД (Q3-Q4)" },
                    { new Guid("40c0708e-7202-43c3-b3f0-1ec8e8ca4c21"), new Guid("e8e6e2bc-f8e4-4389-831a-67c3f518044e"), null, "Промышленный образец" },
                    { new Guid("45662b69-5623-4cdb-83a8-536ea7eb71a3"), new Guid("901fb26a-c9c4-4e84-9cdb-75ebca87d586"), null, "Полезная модель" },
                    { new Guid("46afa68a-0b3a-4e9a-bbe1-86ff7f916f3b"), new Guid("e8e6e2bc-f8e4-4389-831a-67c3f518044e"), null, "Изобретение" },
                    { new Guid("534bd736-d906-459a-be3a-47f75bf815e3"), new Guid("d8d011d6-19a1-4c53-8973-c3e9a6c7b02f"), null, "Нет" },
                    { new Guid("575dfb58-0182-467f-af3b-8d21f8ede37c"), new Guid("e8e6e2bc-f8e4-4389-831a-67c3f518044e"), null, "Полезная модель" },
                    { new Guid("5bce7ea6-0735-4e48-87a8-9b50c2c2f54c"), new Guid("55e04c5d-ba76-47fe-ad07-9fc2508ed9dc"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("65920874-f6ff-44c2-a808-4eb472144553"), new Guid("ffff7bee-3535-436d-97ba-002a46926e6d"), null, "Всероссийский" },
                    { new Guid("6c18924f-c22f-4426-9eb8-839ca6a12292"), new Guid("644ef08f-984c-4e64-9b8d-099f075e4e7c"), null, "Иностранный" },
                    { new Guid("7bc45564-8135-45c6-b42f-6cb5296d41f6"), new Guid("55e04c5d-ba76-47fe-ad07-9fc2508ed9dc"), null, "ВАК (К2-К3)" },
                    { new Guid("8e2deceb-ef36-4610-96b2-a31b352ab8eb"), new Guid("85cbbcd2-acdd-4318-9a65-e4aefce4801b"), null, "Лабораторные" },
                    { new Guid("8f5c5cee-e7b0-4126-bc7f-9f37ec31484d"), new Guid("76533f46-1e83-4564-b758-c3bffb37604d"), null, "Есть" },
                    { new Guid("9c190371-230c-455d-bdc8-fcb2d84ab7bc"), new Guid("ffff7bee-3535-436d-97ba-002a46926e6d"), null, "Международный" },
                    { new Guid("9e375563-2815-432d-a6c6-22dbcdaa99ad"), new Guid("55e04c5d-ba76-47fe-ad07-9fc2508ed9dc"), null, "РИНЦ" },
                    { new Guid("a8ce9d5d-c8b0-45aa-871c-90a1847fe330"), new Guid("901fb26a-c9c4-4e84-9cdb-75ebca87d586"), null, "Промышленный образец" },
                    { new Guid("af9031b6-0848-436c-912f-0ec6ed9dc5ec"), new Guid("db9d24f1-273c-45fa-9b12-7af653275516"), null, "Русский" },
                    { new Guid("bc0bd130-a37d-497b-8f1b-dc312f5467ab"), new Guid("84048dd5-aa21-4ba3-8153-39f2188ed262"), null, "Есть" },
                    { new Guid("bfa1edf9-f435-4699-bb87-534b2d817f03"), new Guid("15c5c6c9-515c-497f-aaa0-0e592f168de7"), null, "Учебник" },
                    { new Guid("c25c833c-d699-4052-a82f-086e84721904"), new Guid("84048dd5-aa21-4ba3-8153-39f2188ed262"), null, "Нет" },
                    { new Guid("cc3a9be2-ce45-4641-bf17-7f16a8edbc55"), new Guid("85cbbcd2-acdd-4318-9a65-e4aefce4801b"), null, "Лекции" },
                    { new Guid("cd1c5678-715b-4740-ada1-180ef9cb66b0"), new Guid("901fb26a-c9c4-4e84-9cdb-75ebca87d586"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("ceb3d431-dad5-4728-acd2-effb7ebd3558"), new Guid("431e73c9-fd8e-4cf5-b2b8-a3e4420be043"), null, "Есть" },
                    { new Guid("d2c57f1b-b950-41f0-b70f-4fcece2e35e1"), new Guid("e8e6e2bc-f8e4-4389-831a-67c3f518044e"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("d67bcc36-b0e8-47a2-a0b8-ecd4d4dae116"), new Guid("db9d24f1-273c-45fa-9b12-7af653275516"), null, "Другой" },
                    { new Guid("e3ad34a1-8cf7-4bcb-8e4e-6f6ef832cb53"), new Guid("15c5c6c9-515c-497f-aaa0-0e592f168de7"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("f142c30d-5c43-4a2c-b347-672b7cff368c"), new Guid("a1310bb8-8735-4222-b388-5a5c01a6157f"), null, "Руководитель" },
                    { new Guid("f8ef5a93-bdb8-40a9-9c81-628f7272bb82"), new Guid("db9d24f1-273c-45fa-9b12-7af653275516"), null, "Английский" }
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
