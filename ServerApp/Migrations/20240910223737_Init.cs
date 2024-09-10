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
                    { new Guid("0e3eaae0-a78b-4e72-91f6-cc8f4b2eea42"), 1, "В ожидании заполнения" },
                    { new Guid("9b365f24-784c-4c53-a2d9-d8facc149045"), 5, "Отклонена" },
                    { new Guid("c15ee96d-ad76-4018-addc-a02c270dda3d"), 6, "Оценена" },
                    { new Guid("eae99f94-cb1b-44fa-b7a9-577066e36601"), 4, "Одобрена" },
                    { new Guid("f417c058-87c0-49cd-82e3-6cd8fb1ed8e2"), 2, "В ожидании рассмотрения" },
                    { new Guid("fb2279c0-1f41-4ab3-9eee-ca5671a352aa"), 3, "В процессе рассмотрения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8b8ed1e7-49fe-4bc3-8920-489c3f9661c3", null, "Admin", "ADMIN" },
                    { "a07c9f1f-5c74-4070-8638-c6531e53b4f8", null, "Organiser", "ORGANISER" },
                    { "c3ed8a53-7377-4842-84b9-8c1384a7bc68", null, "Expert", "EXPERT" },
                    { "c644d989-fcb9-4a62-b73b-c17e576bf34a", null, "Participant", "PARTICIPANT" },
                    { "d1ad3c60-960c-4b03-ae89-dd3604551419", null, "Voter", "VOTER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("41873c9c-51d7-4eb1-a364-722a174a11bc"), "Строительство и архитектура", 1 },
                    { new Guid("7de2869b-758d-4a34-9db5-49742b27b727"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("01dfccd0-f1c4-4217-8eb2-170520b1dd71"), "Категория участников", 2 },
                    { new Guid("5ebdac06-5b71-4381-b454-7b7a3788ae3f"), "Профессиональное развитие", 4 },
                    { new Guid("861052a6-5337-4bf9-954f-db4ad62b772a"), "Конкурсная работа", 3 },
                    { new Guid("b87d8c0d-b547-41cc-8d4a-bd754c1934f5"), "Научно-исследовательская деятельность", 6 },
                    { new Guid("fdf8ef1c-649c-479c-b004-43176254d491"), "Общая информация", 1 },
                    { new Guid("feddabe7-9ccd-4709-8a45-c841808014f9"), "Научно-педагогическая деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Checked", "Email", "Message", "Name" },
                values: new object[] { new Guid("029b444e-8cac-48e6-80b4-80c6f74825f9"), false, "system@system.ru", "Test Message for System", "SYSTEM" });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c"), "Образовательная деятельность", 2 },
                    { new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("a4f90a18-38b0-4dcb-a68e-043d40191032"), "Конкурсная работа", 7 },
                    { new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5"), "Основной", 1 },
                    { new Guid("cea79a16-4b44-4807-aca7-46a956599e7c"), "Профессиональные показатели", 4 },
                    { new Guid("d019ce39-0fcd-4680-bc49-30af5a92e76e"), "Методическая деятельность", 3 },
                    { new Guid("d5bef8b3-e97c-43c9-a8ed-c537427531cd"), "Инновационная и иная деятельность", 6 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("93ee93a3-cc5c-4182-a7ea-594cb73aa3f2"), "Научно-исследовательская деятельность", 2 },
                    { new Guid("d2924675-9bf8-4c7d-bdd6-9ca60795177d"), "Научно-педагогическая деятельность", 1 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01c56e05-f8a0-43b3-b50b-7611893550a3"), "TextArea" },
                    { new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7"), "string" },
                    { new Guid("628789dc-37f3-472c-a867-9be35f4056cf"), "int" },
                    { new Guid("89e021ab-9923-4052-8a0d-f995e10ce808"), "bool" },
                    { new Guid("ff6196b5-31c8-4769-8b47-2909067654ca"), "DateTime" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("01dfccd0-f1c4-4217-8eb2-170520b1dd71"), new Guid("93ee93a3-cc5c-4182-a7ea-594cb73aa3f2") },
                    { new Guid("01dfccd0-f1c4-4217-8eb2-170520b1dd71"), new Guid("d2924675-9bf8-4c7d-bdd6-9ca60795177d") },
                    { new Guid("5ebdac06-5b71-4381-b454-7b7a3788ae3f"), new Guid("93ee93a3-cc5c-4182-a7ea-594cb73aa3f2") },
                    { new Guid("5ebdac06-5b71-4381-b454-7b7a3788ae3f"), new Guid("d2924675-9bf8-4c7d-bdd6-9ca60795177d") },
                    { new Guid("861052a6-5337-4bf9-954f-db4ad62b772a"), new Guid("93ee93a3-cc5c-4182-a7ea-594cb73aa3f2") },
                    { new Guid("861052a6-5337-4bf9-954f-db4ad62b772a"), new Guid("d2924675-9bf8-4c7d-bdd6-9ca60795177d") },
                    { new Guid("b87d8c0d-b547-41cc-8d4a-bd754c1934f5"), new Guid("93ee93a3-cc5c-4182-a7ea-594cb73aa3f2") },
                    { new Guid("fdf8ef1c-649c-479c-b004-43176254d491"), new Guid("93ee93a3-cc5c-4182-a7ea-594cb73aa3f2") },
                    { new Guid("fdf8ef1c-649c-479c-b004-43176254d491"), new Guid("d2924675-9bf8-4c7d-bdd6-9ca60795177d") },
                    { new Guid("feddabe7-9ccd-4709-8a45-c841808014f9"), new Guid("d2924675-9bf8-4c7d-bdd6-9ca60795177d") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("02c4b9d3-dda3-4dad-9d1a-3888f4f8d61c"), new Guid("feddabe7-9ccd-4709-8a45-c841808014f9"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("25e8b7a5-ac37-4ff0-b9d6-4d6546a2529f"), new Guid("fdf8ef1c-649c-479c-b004-43176254d491"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("ff6196b5-31c8-4769-8b47-2909067654ca") },
                    { new Guid("59f0f6f2-4149-4319-99bf-1ba7cabd33c0"), new Guid("fdf8ef1c-649c-479c-b004-43176254d491"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("60c7ba33-3853-49f3-a72e-36ae8c06c6aa"), new Guid("feddabe7-9ccd-4709-8a45-c841808014f9"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("620495ec-0893-41a9-ab1d-be9bf057a217"), new Guid("fdf8ef1c-649c-479c-b004-43176254d491"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("6ba69f7b-76c7-43ae-b652-f5277667e04d"), new Guid("fdf8ef1c-649c-479c-b004-43176254d491"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("6fc5ef79-309f-4a5c-b895-7a4b21582379"), new Guid("fdf8ef1c-649c-479c-b004-43176254d491"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("766dae35-59de-487c-8990-29419ab55cd7"), new Guid("01dfccd0-f1c4-4217-8eb2-170520b1dd71"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("80b17d6c-3ab5-4e87-9f7d-4391726b0eb2"), new Guid("fdf8ef1c-649c-479c-b004-43176254d491"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("85760593-601f-4473-80cb-056bdd6782c9"), new Guid("01dfccd0-f1c4-4217-8eb2-170520b1dd71"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("9b7a7636-91d0-46eb-9903-6b2b59606585"), new Guid("fdf8ef1c-649c-479c-b004-43176254d491"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("9eda46cb-114e-4434-8557-10c8188b1ca9"), new Guid("fdf8ef1c-649c-479c-b004-43176254d491"), null, true, true, "Место работы", 6, "Название организации", new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("b53a521c-0659-482b-bc85-861e1adb8a79"), new Guid("b87d8c0d-b547-41cc-8d4a-bd754c1934f5"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("b561f2d4-1bea-4cf6-b952-066bf6728c14"), new Guid("b87d8c0d-b547-41cc-8d4a-bd754c1934f5"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("c797f109-31dd-4559-8a16-7e74ff1654c7"), new Guid("01dfccd0-f1c4-4217-8eb2-170520b1dd71"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("d0471717-1256-4025-a501-b6e48d0f402a"), new Guid("fdf8ef1c-649c-479c-b004-43176254d491"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("e39b89c2-a000-42ac-940b-35a763d23d1d"), new Guid("feddabe7-9ccd-4709-8a45-c841808014f9"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("e8ef04a1-d0e2-4825-8de3-9d887cb0e6bc"), new Guid("fdf8ef1c-649c-479c-b004-43176254d491"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c"), new Guid("d2924675-9bf8-4c7d-bdd6-9ca60795177d") },
                    { new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04"), new Guid("93ee93a3-cc5c-4182-a7ea-594cb73aa3f2") },
                    { new Guid("a4f90a18-38b0-4dcb-a68e-043d40191032"), new Guid("93ee93a3-cc5c-4182-a7ea-594cb73aa3f2") },
                    { new Guid("a4f90a18-38b0-4dcb-a68e-043d40191032"), new Guid("d2924675-9bf8-4c7d-bdd6-9ca60795177d") },
                    { new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5"), new Guid("93ee93a3-cc5c-4182-a7ea-594cb73aa3f2") },
                    { new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5"), new Guid("d2924675-9bf8-4c7d-bdd6-9ca60795177d") },
                    { new Guid("cea79a16-4b44-4807-aca7-46a956599e7c"), new Guid("d2924675-9bf8-4c7d-bdd6-9ca60795177d") },
                    { new Guid("d019ce39-0fcd-4680-bc49-30af5a92e76e"), new Guid("d2924675-9bf8-4c7d-bdd6-9ca60795177d") },
                    { new Guid("d5bef8b3-e97c-43c9-a8ed-c537427531cd"), new Guid("93ee93a3-cc5c-4182-a7ea-594cb73aa3f2") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0f481f13-244f-41fe-9f6c-d70ee659a2a4"), new Guid("b87d8c0d-b547-41cc-8d4a-bd754c1934f5"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("1c341020-6ca4-4ed6-9f37-5fac0d8c8137"), new Guid("b87d8c0d-b547-41cc-8d4a-bd754c1934f5"), false, false, "Список научных публикаций за последние 5 лет", 10 },
                    { new Guid("268e0e84-69cd-47bc-a463-803f9d83b464"), new Guid("fdf8ef1c-649c-479c-b004-43176254d491"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("2a452c9f-90db-4269-ac51-8e70d5f02493"), new Guid("feddabe7-9ccd-4709-8a45-c841808014f9"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("2cc7f1b1-880d-494a-a4ed-68802b92ebd6"), new Guid("5ebdac06-5b71-4381-b454-7b7a3788ae3f"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("3bec7f8c-ebc0-40b6-b4b7-e019ad547155"), new Guid("feddabe7-9ccd-4709-8a45-c841808014f9"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("3dccf1f0-797f-4869-9b0f-79f3629b30a7"), new Guid("5ebdac06-5b71-4381-b454-7b7a3788ae3f"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 },
                    { new Guid("48dad204-76c9-4df1-bd68-0f57cc15055e"), new Guid("feddabe7-9ccd-4709-8a45-c841808014f9"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 },
                    { new Guid("67a35d39-ec5f-44ac-bbb1-800661c487e2"), new Guid("feddabe7-9ccd-4709-8a45-c841808014f9"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 },
                    { new Guid("6f738175-4729-46ff-972b-2b1014d803dd"), new Guid("861052a6-5337-4bf9-954f-db4ad62b772a"), true, true, "Краткая аннотация конкурсной работы", 1 },
                    { new Guid("a9f02ab0-ec64-49cd-962e-ed632d859212"), new Guid("b87d8c0d-b547-41cc-8d4a-bd754c1934f5"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("ac75539b-2057-40c1-87bc-c38eced39817"), new Guid("b87d8c0d-b547-41cc-8d4a-bd754c1934f5"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("e8fa2ebc-f799-4603-a627-af0c02aabc46"), new Guid("feddabe7-9ccd-4709-8a45-c841808014f9"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0261a38e-ff0c-4715-9ed7-58467f413ac1"), true, "Название НИР/НИОКР", 1, new Guid("0f481f13-244f-41fe-9f6c-d70ee659a2a4"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("06efda11-e819-4a3f-8f43-113a1c8a4d6a"), true, "Название статьи", 1, new Guid("1c341020-6ca4-4ed6-9f37-5fac0d8c8137"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("0afdc1e4-7760-4063-ab9f-61be0d8afb1a"), false, "Тип идентификатора", 1, new Guid("268e0e84-69cd-47bc-a463-803f9d83b464"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("0c9886f7-85b0-4c08-94a2-49bd48dfc7d8"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("0f481f13-244f-41fe-9f6c-d70ee659a2a4"), new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("0e260441-0c57-411a-b35d-1a27fc611296"), true, "Соавторы", 2, new Guid("3bec7f8c-ebc0-40b6-b4b7-e019ad547155"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("1c3e35a5-ee3a-4f17-bedd-4621d7b76534"), true, "ФИО соавторов", 3, new Guid("ac75539b-2057-40c1-87bc-c38eced39817"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("249d3172-b6b9-47e9-a017-7ac2234b3d76"), true, "Наличие грифа", 5, new Guid("67a35d39-ec5f-44ac-bbb1-800661c487e2"), new Guid("89e021ab-9923-4052-8a0d-f995e10ce808") },
                    { new Guid("3161c727-7256-4857-8434-d64bd150ef43"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("e8fa2ebc-f799-4603-a627-af0c02aabc46"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("35ba012a-2a77-45b1-8f07-baa191e916c1"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("48dad204-76c9-4df1-bd68-0f57cc15055e"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("36278a77-1042-4fe3-aaaf-a39cea09fdae"), true, "Название документа, реквизиты", 1, new Guid("2cc7f1b1-880d-494a-a4ed-68802b92ebd6"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("39f9f9f7-39a2-453b-a687-ead9490a0569"), true, "Вид", 2, new Guid("48dad204-76c9-4df1-bd68-0f57cc15055e"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("39fe9f23-c4b5-4426-bf5b-4ae69c4baf60"), true, "Ссылка на платформу", 3, new Guid("3bec7f8c-ebc0-40b6-b4b7-e019ad547155"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("3c6bfc99-a5ca-4e8f-945a-59c4de57f9c5"), false, "Идентификатор", 2, new Guid("268e0e84-69cd-47bc-a463-803f9d83b464"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("4d01ae6f-31c7-41d9-b5fc-ba4917b9bbd4"), true, "Вид публикации", 1, new Guid("67a35d39-ec5f-44ac-bbb1-800661c487e2"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("4f7a10da-46ca-417c-bcdc-49b50344945c"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("0f481f13-244f-41fe-9f6c-d70ee659a2a4"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("55b4d041-c9e0-4127-b6a7-a908292c9b81"), true, "Год", 3, new Guid("e8fa2ebc-f799-4603-a627-af0c02aabc46"), new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("5b14fcac-a9e5-4eb4-ace1-70fb0b58aa6b"), true, "Год", 4, new Guid("3bec7f8c-ebc0-40b6-b4b7-e019ad547155"), new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("5be741a5-b107-464e-a24c-dbf0e3108857"), true, "Название разработки", 2, new Guid("a9f02ab0-ec64-49cd-962e-ed632d859212"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("5c4a35c9-aaa5-46ab-a907-5a3671263f06"), true, "Количество печатных листов", 4, new Guid("67a35d39-ec5f-44ac-bbb1-800661c487e2"), new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("5d97702e-9995-4419-bf4a-d0ee189913ad"), false, "Соавторы", 3, new Guid("67a35d39-ec5f-44ac-bbb1-800661c487e2"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("5da7a0c5-2263-46f5-9026-d523123a6f9a"), true, "Название курса", 1, new Guid("3bec7f8c-ebc0-40b6-b4b7-e019ad547155"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("5e3f73ff-38ba-4421-86d9-34e27c311929"), true, "Вид", 1, new Guid("a9f02ab0-ec64-49cd-962e-ed632d859212"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("5f868d1e-2d66-4eab-95ac-218bb57770bc"), true, "Ссылка", 5, new Guid("3dccf1f0-797f-4869-9b0f-79f3629b30a7"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("5fcdde34-08e4-4381-a1e3-40787974b352"), true, "Название конкурса", 2, new Guid("3dccf1f0-797f-4869-9b0f-79f3629b30a7"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("61f0f574-c763-475f-a1d5-b47b706cdaf6"), true, "Язык преподавания", 2, new Guid("2a452c9f-90db-4269-ac51-8e70d5f02493"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("65a94aac-af08-49a7-8ea1-22cc4530f0d5"), true, "Значение", 2, new Guid("6f738175-4729-46ff-972b-2b1014d803dd"), new Guid("01c56e05-f8a0-43b3-b50b-7611893550a3") },
                    { new Guid("69a12ae9-631f-4b6d-84f1-b41e05d6c10d"), true, "Название конкурса/премии", 2, new Guid("e8fa2ebc-f799-4603-a627-af0c02aabc46"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("6c1c6a60-10c2-476b-9568-4ba5989e869e"), true, "Ссылка на открытый доступ", 8, new Guid("67a35d39-ec5f-44ac-bbb1-800661c487e2"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("6c6afdb0-cdd5-4a7c-937e-060f33337710"), true, "Название", 2, new Guid("ac75539b-2057-40c1-87bc-c38eced39817"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("6e0ffae4-628a-49b3-96bd-ac1dd18073e4"), true, "Период выполнения", 3, new Guid("0f481f13-244f-41fe-9f6c-d70ee659a2a4"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("72bacc78-5ff1-4594-8b93-77295068abee"), true, "ФИО", 1, new Guid("e8fa2ebc-f799-4603-a627-af0c02aabc46"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("789b9309-3098-41fb-a388-9e023f55c937"), true, "Издание, год", 4, new Guid("1c341020-6ca4-4ed6-9f37-5fac0d8c8137"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("79ac96ce-03c7-4eda-8dd1-48d3f2f10d84"), true, "Практические занятия (час.)", 4, new Guid("2a452c9f-90db-4269-ac51-8e70d5f02493"), new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("883e30d3-a379-4130-9779-a67977ef9beb"), true, "Наименование курса", 1, new Guid("2a452c9f-90db-4269-ac51-8e70d5f02493"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("8a93954e-a0a8-4625-99a4-a11db53c6a35"), true, "Название", 2, new Guid("67a35d39-ec5f-44ac-bbb1-800661c487e2"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("8be25f74-35fc-4dbd-9f2a-bb82741c66e7"), true, "Название организации в которую внедрена разработка", 3, new Guid("a9f02ab0-ec64-49cd-962e-ed632d859212"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("8f818caa-7cce-41e7-a90c-07b679d103fe"), true, "Лекции (час.)", 3, new Guid("2a452c9f-90db-4269-ac51-8e70d5f02493"), new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("93f4298e-f952-40ca-b4dd-c650145291d5"), true, "Издательство, год", 6, new Guid("67a35d39-ec5f-44ac-bbb1-800661c487e2"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("95994b69-035b-4a5b-a4f5-d4410aeda6d8"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("e8fa2ebc-f799-4603-a627-af0c02aabc46"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("990edf57-06b9-4748-b055-2d008c1d0729"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("3dccf1f0-797f-4869-9b0f-79f3629b30a7"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("9a4745bd-db53-4141-a170-366c57cc44a6"), true, "Год", 1, new Guid("3dccf1f0-797f-4869-9b0f-79f3629b30a7"), new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("b76f82cf-fc22-4c74-8e65-003ca06980f6"), true, "Язык публикации", 7, new Guid("67a35d39-ec5f-44ac-bbb1-800661c487e2"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("b8793683-6293-4f59-86ef-73ecee31d211"), true, "Статус конкурса", 3, new Guid("3dccf1f0-797f-4869-9b0f-79f3629b30a7"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("b8d3d760-cefd-4266-b3cc-15d1b3a30ad8"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("1c341020-6ca4-4ed6-9f37-5fac0d8c8137"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("baf990ee-0625-4771-89e3-e6facd009b2e"), true, "Название", 1, new Guid("6f738175-4729-46ff-972b-2b1014d803dd"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("c953ac22-39ed-4d97-9dc1-0f68284a4367"), true, "Вид", 1, new Guid("ac75539b-2057-40c1-87bc-c38eced39817"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("ceea77c3-28da-407e-adc1-7488e5859e7f"), true, "Название дисциплины", 1, new Guid("48dad204-76c9-4df1-bd68-0f57cc15055e"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("d0592609-e34a-406d-8e72-7648f829383c"), true, "Соавторы", 2, new Guid("1c341020-6ca4-4ed6-9f37-5fac0d8c8137"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("d3882049-8cba-4e11-82f2-a5e18765b1a7"), true, "Итого (час.)", 5, new Guid("2a452c9f-90db-4269-ac51-8e70d5f02493"), new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("e20c2b25-242e-4db0-b67b-6f4f8d1bbc13"), true, "Год получения документа", 2, new Guid("2cc7f1b1-880d-494a-a4ed-68802b92ebd6"), new Guid("628789dc-37f3-472c-a867-9be35f4056cf") },
                    { new Guid("ee931aeb-0ee3-4074-988a-4d731d078f1a"), true, "Номер РИД", 4, new Guid("ac75539b-2057-40c1-87bc-c38eced39817"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") },
                    { new Guid("f4dffd8f-0526-402e-b0a2-a61ebf919daa"), true, "Статус", 4, new Guid("0f481f13-244f-41fe-9f6c-d70ee659a2a4"), new Guid("3b2a06c7-c23e-4b06-a46b-323902a497a7") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("02c4b9d3-dda3-4dad-9d1a-3888f4f8d61c"), new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c") },
                    { new Guid("25e8b7a5-ac37-4ff0-b9d6-4d6546a2529f"), new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5") },
                    { new Guid("59f0f6f2-4149-4319-99bf-1ba7cabd33c0"), new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5") },
                    { new Guid("60c7ba33-3853-49f3-a72e-36ae8c06c6aa"), new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c") },
                    { new Guid("620495ec-0893-41a9-ab1d-be9bf057a217"), new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5") },
                    { new Guid("6ba69f7b-76c7-43ae-b652-f5277667e04d"), new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5") },
                    { new Guid("6fc5ef79-309f-4a5c-b895-7a4b21582379"), new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5") },
                    { new Guid("766dae35-59de-487c-8990-29419ab55cd7"), new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5") },
                    { new Guid("80b17d6c-3ab5-4e87-9f7d-4391726b0eb2"), new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5") },
                    { new Guid("85760593-601f-4473-80cb-056bdd6782c9"), new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5") },
                    { new Guid("9b7a7636-91d0-46eb-9903-6b2b59606585"), new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5") },
                    { new Guid("9eda46cb-114e-4434-8557-10c8188b1ca9"), new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5") },
                    { new Guid("b53a521c-0659-482b-bc85-861e1adb8a79"), new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04") },
                    { new Guid("b561f2d4-1bea-4cf6-b952-066bf6728c14"), new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04") },
                    { new Guid("c797f109-31dd-4559-8a16-7e74ff1654c7"), new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04") },
                    { new Guid("c797f109-31dd-4559-8a16-7e74ff1654c7"), new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5") },
                    { new Guid("c797f109-31dd-4559-8a16-7e74ff1654c7"), new Guid("cea79a16-4b44-4807-aca7-46a956599e7c") },
                    { new Guid("d0471717-1256-4025-a501-b6e48d0f402a"), new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5") },
                    { new Guid("e39b89c2-a000-42ac-940b-35a763d23d1d"), new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c") },
                    { new Guid("e8ef04a1-d0e2-4825-8de3-9d887cb0e6bc"), new Guid("b6da3328-bc8f-42ca-a00f-311e0af857f5") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c"), new Guid("2a452c9f-90db-4269-ac51-8e70d5f02493") },
                    { new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c"), new Guid("3bec7f8c-ebc0-40b6-b4b7-e019ad547155") },
                    { new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c"), new Guid("e8fa2ebc-f799-4603-a627-af0c02aabc46") },
                    { new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04"), new Guid("0f481f13-244f-41fe-9f6c-d70ee659a2a4") },
                    { new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04"), new Guid("1c341020-6ca4-4ed6-9f37-5fac0d8c8137") },
                    { new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04"), new Guid("268e0e84-69cd-47bc-a463-803f9d83b464") },
                    { new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04"), new Guid("3dccf1f0-797f-4869-9b0f-79f3629b30a7") },
                    { new Guid("a4f90a18-38b0-4dcb-a68e-043d40191032"), new Guid("6f738175-4729-46ff-972b-2b1014d803dd") },
                    { new Guid("cea79a16-4b44-4807-aca7-46a956599e7c"), new Guid("2cc7f1b1-880d-494a-a4ed-68802b92ebd6") },
                    { new Guid("cea79a16-4b44-4807-aca7-46a956599e7c"), new Guid("3dccf1f0-797f-4869-9b0f-79f3629b30a7") },
                    { new Guid("d019ce39-0fcd-4680-bc49-30af5a92e76e"), new Guid("48dad204-76c9-4df1-bd68-0f57cc15055e") },
                    { new Guid("d019ce39-0fcd-4680-bc49-30af5a92e76e"), new Guid("67a35d39-ec5f-44ac-bbb1-800661c487e2") },
                    { new Guid("d5bef8b3-e97c-43c9-a8ed-c537427531cd"), new Guid("2cc7f1b1-880d-494a-a4ed-68802b92ebd6") },
                    { new Guid("d5bef8b3-e97c-43c9-a8ed-c537427531cd"), new Guid("a9f02ab0-ec64-49cd-962e-ed632d859212") },
                    { new Guid("d5bef8b3-e97c-43c9-a8ed-c537427531cd"), new Guid("ac75539b-2057-40c1-87bc-c38eced39817") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0e00c520-579c-487d-9325-0bb19e305260"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("0f481f13-244f-41fe-9f6c-d70ee659a2a4") },
                    { new Guid("134aed6c-d647-4b97-9675-199e0646a697"), "EvaluateMark20", new Guid("b561f2d4-1bea-4cf6-b952-066bf6728c14"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("1804a4aa-498a-4817-80c8-f456899cb5f5"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом или на иностранном языке и без соавторства:", 8, new Guid("67a35d39-ec5f-44ac-bbb1-800661c487e2") },
                    { new Guid("28495b26-18a0-4870-9394-99a71c626ac3"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("3dccf1f0-797f-4869-9b0f-79f3629b30a7") },
                    { new Guid("2c01a7b7-4b11-40d5-83ea-5f930e46beb1"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("67a35d39-ec5f-44ac-bbb1-800661c487e2") },
                    { new Guid("3e6d02b4-794d-492e-aa12-8e4686401183"), "EvaluateMark19", new Guid("b53a521c-0659-482b-bc85-861e1adb8a79"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("492ba19b-b61b-4404-b194-886644fc0ac1"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("2cc7f1b1-880d-494a-a4ed-68802b92ebd6") },
                    { new Guid("4c86da90-3919-4bd3-bf11-654026673a71"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("2a452c9f-90db-4269-ac51-8e70d5f02493") },
                    { new Guid("6ad828d7-6ff1-45bd-a93d-4d27105eefd3"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом или на иностранном языке в соавторстве:", 9, new Guid("67a35d39-ec5f-44ac-bbb1-800661c487e2") },
                    { new Guid("6e6d7c27-8552-4911-972c-8207fcc105a6"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("6f738175-4729-46ff-972b-2b1014d803dd") },
                    { new Guid("7535d861-3dff-4fca-964c-33c13d016be4"), "EvaluateMark4", new Guid("e39b89c2-a000-42ac-940b-35a763d23d1d"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("8329f51a-ada7-4b62-b9b7-75d3fbd8bdac"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("e8fa2ebc-f799-4603-a627-af0c02aabc46") },
                    { new Guid("849eb435-c83e-4841-bf9d-df326c9cfe8b"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("6f738175-4729-46ff-972b-2b1014d803dd") },
                    { new Guid("8b55d628-662a-4d55-ba9c-c5566eeeacab"), "EvaluateMark5", new Guid("02c4b9d3-dda3-4dad-9d1a-3888f4f8d61c"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("9605f4b0-2bef-4355-bf7b-8a39bfc940ea"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("2a452c9f-90db-4269-ac51-8e70d5f02493") },
                    { new Guid("a1ede88d-0cfb-47fb-8d2d-63833246523f"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("ac75539b-2057-40c1-87bc-c38eced39817") },
                    { new Guid("a2cf4c71-73c6-46ed-94be-7cc574b61a30"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("1c341020-6ca4-4ed6-9f37-5fac0d8c8137") },
                    { new Guid("b2d6bda1-362c-4bc4-88ad-0b40153fd0ff"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("67a35d39-ec5f-44ac-bbb1-800661c487e2") },
                    { new Guid("c572b7a3-9d88-41c8-a4da-fe24586a6d1a"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("a9f02ab0-ec64-49cd-962e-ed632d859212") },
                    { new Guid("c96d5490-aa4e-42db-ad45-56f14b8783f6"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("3bec7f8c-ebc0-40b6-b4b7-e019ad547155") },
                    { new Guid("d9836303-8ae4-48fa-b605-c40b56df3bfe"), "EvaluateMark3", new Guid("60c7ba33-3853-49f3-a72e-36ae8c06c6aa"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("dfaa5950-7a03-45b0-8330-feb7404e8dfb"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("48dad204-76c9-4df1-bd68-0f57cc15055e") },
                    { new Guid("e101aca8-b6b7-46e6-af3c-b3c84ee6036f"), "EvaluateMark13", new Guid("c797f109-31dd-4559-8a16-7e74ff1654c7"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("fd906648-5b3d-4d45-a851-2350f1fd5b16"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("0f481f13-244f-41fe-9f6c-d70ee659a2a4") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0c85629a-cd76-41ee-b72d-7ca6f87f54b6"), true, 3, new Guid("268e0e84-69cd-47bc-a463-803f9d83b464") },
                    { new Guid("22a68852-f003-4e66-921f-d80e79b925bf"), true, 7, new Guid("6f738175-4729-46ff-972b-2b1014d803dd") },
                    { new Guid("25ec9144-19ac-4ee8-8f8c-e6b017fc5a36"), true, 8, new Guid("6f738175-4729-46ff-972b-2b1014d803dd") },
                    { new Guid("313df5ed-4551-4da9-89d3-03ee9761b5a8"), true, 2, new Guid("268e0e84-69cd-47bc-a463-803f9d83b464") },
                    { new Guid("334aaa78-2c21-4ec9-935b-ea76d2c6d7c0"), true, 4, new Guid("6f738175-4729-46ff-972b-2b1014d803dd") },
                    { new Guid("6b614ea1-6d41-47c2-aa1a-5978cbe0944e"), true, 4, new Guid("268e0e84-69cd-47bc-a463-803f9d83b464") },
                    { new Guid("6c89219e-1264-40d3-bb5c-619c6fae7c68"), true, 5, new Guid("6f738175-4729-46ff-972b-2b1014d803dd") },
                    { new Guid("7616db1d-4268-4b07-83e7-3155dc1b9d79"), true, 2, new Guid("6f738175-4729-46ff-972b-2b1014d803dd") },
                    { new Guid("849d879f-6554-4d3f-90bb-a7527a8c18fd"), true, 6, new Guid("6f738175-4729-46ff-972b-2b1014d803dd") },
                    { new Guid("88f41c09-2f6d-492e-8aa5-f72fb56a2262"), true, 1, new Guid("268e0e84-69cd-47bc-a463-803f9d83b464") },
                    { new Guid("bfa96157-04e5-40c4-b02d-2499f440c294"), true, 5, new Guid("268e0e84-69cd-47bc-a463-803f9d83b464") },
                    { new Guid("c6773315-90d6-4cf7-9a4d-850ea99c38cd"), true, 3, new Guid("6f738175-4729-46ff-972b-2b1014d803dd") },
                    { new Guid("dc533cef-82e7-404f-be4c-3a22ec75201a"), true, 1, new Guid("6f738175-4729-46ff-972b-2b1014d803dd") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("1bd775c0-4494-47f4-aab6-b49b473a5815"), null, new Guid("766dae35-59de-487c-8990-29419ab55cd7"), "Кандидат наук" },
                    { new Guid("4b719bf7-545e-464d-b0b5-c8c9ed19e25b"), null, new Guid("c797f109-31dd-4559-8a16-7e74ff1654c7"), "Нет" },
                    { new Guid("661ded91-06da-4723-8936-06343e4c8e01"), null, new Guid("c797f109-31dd-4559-8a16-7e74ff1654c7"), "Доцент" },
                    { new Guid("6ea557d5-64a0-4e54-a9f1-303aa5418983"), null, new Guid("766dae35-59de-487c-8990-29419ab55cd7"), "Доктор наук" },
                    { new Guid("f75abb0f-9480-467b-8186-75162cde45ad"), null, new Guid("c797f109-31dd-4559-8a16-7e74ff1654c7"), "Профессор" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("0c86e6c0-0804-45b3-a431-57d697558fd1"), null, new Guid("0afdc1e4-7760-4063-ab9f-61be0d8afb1a"), true, true, new Guid("88f41c09-2f6d-492e-8aa5-f72fb56a2262"), "ScopusID" },
                    { new Guid("207b1da7-4400-4b1b-a5fb-a78577054140"), null, new Guid("baf990ee-0625-4771-89e3-e6facd009b2e"), true, true, new Guid("6c89219e-1264-40d3-bb5c-619c6fae7c68"), "Ссылка на конкурсную работу" },
                    { new Guid("2cfd4d73-bdc8-452a-b532-a1b61128b3d0"), null, new Guid("65a94aac-af08-49a7-8ea1-22cc4530f0d5"), false, true, new Guid("7616db1d-4268-4b07-83e7-3155dc1b9d79"), null },
                    { new Guid("3c481279-1ed7-4d67-991a-a9232f681fa0"), null, new Guid("3c6bfc99-a5ca-4e8f-945a-59c4de57f9c5"), false, true, new Guid("88f41c09-2f6d-492e-8aa5-f72fb56a2262"), null },
                    { new Guid("3db3a590-93c5-4968-8e4a-c368b32f72d2"), null, new Guid("65a94aac-af08-49a7-8ea1-22cc4530f0d5"), false, true, new Guid("c6773315-90d6-4cf7-9a4d-850ea99c38cd"), null },
                    { new Guid("469da3e8-6e9e-48e6-acc1-6dc21d541500"), null, new Guid("65a94aac-af08-49a7-8ea1-22cc4530f0d5"), false, true, new Guid("849d879f-6554-4d3f-90bb-a7527a8c18fd"), null },
                    { new Guid("5b073160-3c31-40bb-af3f-fdabbb1ece5f"), null, new Guid("baf990ee-0625-4771-89e3-e6facd009b2e"), true, true, new Guid("22a68852-f003-4e66-921f-d80e79b925bf"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("6191b6b8-f3be-4e5f-b76c-9ac4dc7664e5"), null, new Guid("baf990ee-0625-4771-89e3-e6facd009b2e"), true, true, new Guid("c6773315-90d6-4cf7-9a4d-850ea99c38cd"), "Инновационность" },
                    { new Guid("67851244-4404-4efa-b0ae-1f23781055c9"), null, new Guid("65a94aac-af08-49a7-8ea1-22cc4530f0d5"), false, true, new Guid("dc533cef-82e7-404f-be4c-3a22ec75201a"), null },
                    { new Guid("6a15d6b7-5638-4749-b7a1-f76d20d97243"), null, new Guid("baf990ee-0625-4771-89e3-e6facd009b2e"), true, true, new Guid("7616db1d-4268-4b07-83e7-3155dc1b9d79"), "Актуальность конкурсной работы" },
                    { new Guid("82f0d05b-3004-4742-a444-599ff74b29bc"), null, new Guid("65a94aac-af08-49a7-8ea1-22cc4530f0d5"), false, true, new Guid("6c89219e-1264-40d3-bb5c-619c6fae7c68"), null },
                    { new Guid("94e838e2-104f-4675-a0c3-950c3efc4463"), null, new Guid("3c6bfc99-a5ca-4e8f-945a-59c4de57f9c5"), false, true, new Guid("bfa96157-04e5-40c4-b02d-2499f440c294"), null },
                    { new Guid("a54f78cb-7698-4f8b-ad73-f4836dd12e7b"), null, new Guid("baf990ee-0625-4771-89e3-e6facd009b2e"), true, true, new Guid("334aaa78-2c21-4ec9-935b-ea76d2c6d7c0"), "Методология и методы, используемые в работе" },
                    { new Guid("a5ff77d9-b3eb-4299-8e9c-2f84e96d97f7"), null, new Guid("0afdc1e4-7760-4063-ab9f-61be0d8afb1a"), true, true, new Guid("6b614ea1-6d41-47c2-aa1a-5978cbe0944e"), "РИНЦ AuthorID" },
                    { new Guid("abd4c391-572c-4a24-a6ba-7f257ff365e2"), null, new Guid("65a94aac-af08-49a7-8ea1-22cc4530f0d5"), false, true, new Guid("22a68852-f003-4e66-921f-d80e79b925bf"), null },
                    { new Guid("af716d68-7599-406d-9bbf-7b05bf7b1348"), null, new Guid("65a94aac-af08-49a7-8ea1-22cc4530f0d5"), false, true, new Guid("334aaa78-2c21-4ec9-935b-ea76d2c6d7c0"), null },
                    { new Guid("b09f13a4-2e54-44f8-92cb-c7b52d752808"), null, new Guid("0afdc1e4-7760-4063-ab9f-61be0d8afb1a"), true, true, new Guid("bfa96157-04e5-40c4-b02d-2499f440c294"), "Google Scholar ID" },
                    { new Guid("b938c45e-2346-4ad0-8e75-7f9db8cacaec"), null, new Guid("3c6bfc99-a5ca-4e8f-945a-59c4de57f9c5"), false, true, new Guid("313df5ed-4551-4da9-89d3-03ee9761b5a8"), null },
                    { new Guid("dde60a95-3a34-45d2-aeb0-b70780450164"), null, new Guid("baf990ee-0625-4771-89e3-e6facd009b2e"), true, true, new Guid("849d879f-6554-4d3f-90bb-a7527a8c18fd"), "Апробация" },
                    { new Guid("e2b8395f-b86b-4b7d-85ff-8d84f189102a"), null, new Guid("0afdc1e4-7760-4063-ab9f-61be0d8afb1a"), true, true, new Guid("313df5ed-4551-4da9-89d3-03ee9761b5a8"), "ORCiD" },
                    { new Guid("e35fd8bf-4334-4be4-8cf3-b20925f49d06"), null, new Guid("baf990ee-0625-4771-89e3-e6facd009b2e"), true, true, new Guid("dc533cef-82e7-404f-be4c-3a22ec75201a"), "Название работы" },
                    { new Guid("e36122fa-f313-4abc-a524-2a48a603809e"), null, new Guid("baf990ee-0625-4771-89e3-e6facd009b2e"), true, true, new Guid("25ec9144-19ac-4ee8-8f8c-e6b017fc5a36"), "Результаты и выводы" },
                    { new Guid("e45505bc-a6dc-465b-b2ae-7e2267e14f22"), null, new Guid("3c6bfc99-a5ca-4e8f-945a-59c4de57f9c5"), false, true, new Guid("6b614ea1-6d41-47c2-aa1a-5978cbe0944e"), null },
                    { new Guid("e6c072d6-fd48-4828-b25d-76b63dffcd5d"), null, new Guid("65a94aac-af08-49a7-8ea1-22cc4530f0d5"), false, true, new Guid("25ec9144-19ac-4ee8-8f8c-e6b017fc5a36"), null },
                    { new Guid("fd3281bd-a3b2-4ea5-951f-6dec61189579"), null, new Guid("0afdc1e4-7760-4063-ab9f-61be0d8afb1a"), true, true, new Guid("0c85629a-cd76-41ee-b72d-7ca6f87f54b6"), "ResearcherID" },
                    { new Guid("fe04b5be-4b50-43ac-8ff5-ca1b6c5aafe8"), null, new Guid("3c6bfc99-a5ca-4e8f-945a-59c4de57f9c5"), false, true, new Guid("0c85629a-cd76-41ee-b72d-7ca6f87f54b6"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c"), new Guid("4c86da90-3919-4bd3-bf11-654026673a71") },
                    { new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c"), new Guid("7535d861-3dff-4fca-964c-33c13d016be4") },
                    { new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c"), new Guid("8329f51a-ada7-4b62-b9b7-75d3fbd8bdac") },
                    { new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c"), new Guid("8b55d628-662a-4d55-ba9c-c5566eeeacab") },
                    { new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c"), new Guid("9605f4b0-2bef-4355-bf7b-8a39bfc940ea") },
                    { new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c"), new Guid("c96d5490-aa4e-42db-ad45-56f14b8783f6") },
                    { new Guid("112a967a-c67a-4dd2-b239-76c1b882df2c"), new Guid("d9836303-8ae4-48fa-b605-c40b56df3bfe") },
                    { new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04"), new Guid("0e00c520-579c-487d-9325-0bb19e305260") },
                    { new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04"), new Guid("134aed6c-d647-4b97-9675-199e0646a697") },
                    { new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04"), new Guid("28495b26-18a0-4870-9394-99a71c626ac3") },
                    { new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04"), new Guid("3e6d02b4-794d-492e-aa12-8e4686401183") },
                    { new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04"), new Guid("a2cf4c71-73c6-46ed-94be-7cc574b61a30") },
                    { new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04"), new Guid("e101aca8-b6b7-46e6-af3c-b3c84ee6036f") },
                    { new Guid("53907503-f2a7-4c9b-b133-1f69aa3d8e04"), new Guid("fd906648-5b3d-4d45-a851-2350f1fd5b16") },
                    { new Guid("a4f90a18-38b0-4dcb-a68e-043d40191032"), new Guid("6e6d7c27-8552-4911-972c-8207fcc105a6") },
                    { new Guid("a4f90a18-38b0-4dcb-a68e-043d40191032"), new Guid("849eb435-c83e-4841-bf9d-df326c9cfe8b") },
                    { new Guid("cea79a16-4b44-4807-aca7-46a956599e7c"), new Guid("28495b26-18a0-4870-9394-99a71c626ac3") },
                    { new Guid("cea79a16-4b44-4807-aca7-46a956599e7c"), new Guid("492ba19b-b61b-4404-b194-886644fc0ac1") },
                    { new Guid("cea79a16-4b44-4807-aca7-46a956599e7c"), new Guid("e101aca8-b6b7-46e6-af3c-b3c84ee6036f") },
                    { new Guid("d019ce39-0fcd-4680-bc49-30af5a92e76e"), new Guid("1804a4aa-498a-4817-80c8-f456899cb5f5") },
                    { new Guid("d019ce39-0fcd-4680-bc49-30af5a92e76e"), new Guid("2c01a7b7-4b11-40d5-83ea-5f930e46beb1") },
                    { new Guid("d019ce39-0fcd-4680-bc49-30af5a92e76e"), new Guid("6ad828d7-6ff1-45bd-a93d-4d27105eefd3") },
                    { new Guid("d019ce39-0fcd-4680-bc49-30af5a92e76e"), new Guid("b2d6bda1-362c-4bc4-88ad-0b40153fd0ff") },
                    { new Guid("d019ce39-0fcd-4680-bc49-30af5a92e76e"), new Guid("dfaa5950-7a03-45b0-8330-feb7404e8dfb") },
                    { new Guid("d5bef8b3-e97c-43c9-a8ed-c537427531cd"), new Guid("492ba19b-b61b-4404-b194-886644fc0ac1") },
                    { new Guid("d5bef8b3-e97c-43c9-a8ed-c537427531cd"), new Guid("a1ede88d-0cfb-47fb-8d2d-63833246523f") },
                    { new Guid("d5bef8b3-e97c-43c9-a8ed-c537427531cd"), new Guid("c572b7a3-9d88-41c8-a4da-fe24586a6d1a") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("01ee2a5e-9890-495a-aa21-71e9639f2c8f"), new Guid("b76f82cf-fc22-4c74-8e65-003ca06980f6"), null, "Иностранный" },
                    { new Guid("03f60212-9445-4bbc-8d85-a1219d7b0c9f"), new Guid("5e3f73ff-38ba-4421-86d9-34e27c311929"), null, "Промышленный образец" },
                    { new Guid("0988fca9-7cd0-42a0-bc68-34ff1a684dba"), new Guid("4d01ae6f-31c7-41d9-b5fc-ba4917b9bbd4"), null, "Учебник" },
                    { new Guid("0cdc65e5-8680-4971-9e33-b7895b29a311"), new Guid("b8793683-6293-4f59-86ef-73ecee31d211"), null, "Всероссийский" },
                    { new Guid("1673b004-c91f-4cd8-bb4a-87b19bb946ea"), new Guid("5d97702e-9995-4419-bf4a-d0ee189913ad"), null, "Есть" },
                    { new Guid("1c21fbcc-e17e-4731-a480-f386e8a741a1"), new Guid("4d01ae6f-31c7-41d9-b5fc-ba4917b9bbd4"), null, "Монография" },
                    { new Guid("1e2467f1-5845-4984-820a-e8892e9c96d0"), new Guid("0e260441-0c57-411a-b35d-1a27fc611296"), null, "Есть" },
                    { new Guid("20cc4e39-8d36-4ffd-9052-2252c6d65035"), new Guid("f4dffd8f-0526-402e-b0a2-a61ebf919daa"), null, "Руководитель" },
                    { new Guid("24cb4a2e-88b7-4e56-858b-40d013fec952"), new Guid("0e260441-0c57-411a-b35d-1a27fc611296"), null, "Нет" },
                    { new Guid("259405d6-71a2-4bdb-9c04-dfff0680f79d"), new Guid("c953ac22-39ed-4d97-9dc1-0f68284a4367"), null, "Изобретение" },
                    { new Guid("3493a2da-e798-4471-93f0-a2fa035a61f3"), new Guid("b8793683-6293-4f59-86ef-73ecee31d211"), null, "Международный" },
                    { new Guid("3750739d-91a7-4d97-826d-b58419b0bbc2"), new Guid("249d3172-b6b9-47e9-a017-7ac2234b3d76"), null, "Есть" },
                    { new Guid("42857858-2a48-499f-845e-ebc6516c3230"), new Guid("c953ac22-39ed-4d97-9dc1-0f68284a4367"), null, "Промышленный образец" },
                    { new Guid("4472984c-12e0-4561-b09f-269c1fe4564d"), new Guid("b8d3d760-cefd-4266-b3cc-15d1b3a30ad8"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("4773048d-5fe9-4a81-a3c9-199122dff11b"), new Guid("249d3172-b6b9-47e9-a017-7ac2234b3d76"), null, "Нет" },
                    { new Guid("4ca90b17-2fa4-4557-8d0a-253017b7060c"), new Guid("61f0f574-c763-475f-a1d5-b47b706cdaf6"), null, "Английский" },
                    { new Guid("4ee7f22b-7da2-4371-89b5-3fc6d3f23244"), new Guid("61f0f574-c763-475f-a1d5-b47b706cdaf6"), null, "Другой" },
                    { new Guid("52f59426-e392-423b-a906-003108fcd15d"), new Guid("b8793683-6293-4f59-86ef-73ecee31d211"), null, "Региональный" },
                    { new Guid("59f73ecf-5d29-4392-ba81-675a7609d1eb"), new Guid("39f9f9f7-39a2-453b-a687-ead9490a0569"), null, "Лабораторные" },
                    { new Guid("636349a0-f65d-4109-81a7-ff54d35c9033"), new Guid("5d97702e-9995-4419-bf4a-d0ee189913ad"), null, "Нет" },
                    { new Guid("708c37e1-d6b0-4c19-b5fa-289c79b185b2"), new Guid("5e3f73ff-38ba-4421-86d9-34e27c311929"), null, "Полезная модель" },
                    { new Guid("71956c1d-5863-46c9-99ba-675564f7b186"), new Guid("b76f82cf-fc22-4c74-8e65-003ca06980f6"), null, "Русский" },
                    { new Guid("774a455c-cafd-4d51-98e1-27de01b811f9"), new Guid("c953ac22-39ed-4d97-9dc1-0f68284a4367"), null, "Полезная модель" },
                    { new Guid("77f51b89-e539-4329-9785-8076c5aff8c6"), new Guid("b8d3d760-cefd-4266-b3cc-15d1b3a30ad8"), null, "МБД (Q3-Q4)" },
                    { new Guid("7f74223a-85ac-4499-b0ea-de2d6bea0af3"), new Guid("5e3f73ff-38ba-4421-86d9-34e27c311929"), null, "Изобретение" },
                    { new Guid("825b37db-cd9e-45af-9f60-0d008650fe40"), new Guid("d0592609-e34a-406d-8e72-7648f829383c"), null, "Нет" },
                    { new Guid("8f31b829-9f60-45a9-b93f-d905eaae53d6"), new Guid("61f0f574-c763-475f-a1d5-b47b706cdaf6"), null, "Русский" },
                    { new Guid("90eace24-61ba-4773-aa3d-da7fc3853c82"), new Guid("b8d3d760-cefd-4266-b3cc-15d1b3a30ad8"), null, "РИНЦ" },
                    { new Guid("9be1538b-c135-4efa-8a63-561bf911f5a8"), new Guid("b8d3d760-cefd-4266-b3cc-15d1b3a30ad8"), null, "ВАК (К2-К3)" },
                    { new Guid("9bea95e5-ea87-4bde-9347-00c1105fe9a3"), new Guid("4d01ae6f-31c7-41d9-b5fc-ba4917b9bbd4"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("ae919aec-5e1d-4c8a-a5e0-680997129b77"), new Guid("f4dffd8f-0526-402e-b0a2-a61ebf919daa"), null, "Исполнитель" },
                    { new Guid("b9a6e4db-3269-4434-a468-0b6e7e8c9092"), new Guid("c953ac22-39ed-4d97-9dc1-0f68284a4367"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("df9fe084-ed7d-4348-986d-18cb0da3337a"), new Guid("5e3f73ff-38ba-4421-86d9-34e27c311929"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("e8ef5259-75e7-4669-8f1b-419e1b69378c"), new Guid("39f9f9f7-39a2-453b-a687-ead9490a0569"), null, "Лекции" },
                    { new Guid("ef738917-71d3-4982-a367-0539da984a3f"), new Guid("d0592609-e34a-406d-8e72-7648f829383c"), null, "Есть" }
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
