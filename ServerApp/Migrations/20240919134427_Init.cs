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
                name: "Deadlines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Start = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    End = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deadlines", x => x.Id);
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
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Username = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ExpertCategoryId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInfos_Categories_ExpertCategoryId",
                        column: x => x.ExpertCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
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
                        name: "FK_ApplicationFormExperts_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationForms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicationStatusId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FullPhotoId = table.Column<Guid>(type: "uuid", nullable: true),
                    CropPhotoId = table.Column<Guid>(type: "uuid", nullable: true),
                    UserInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    TrackId = table.Column<Guid>(type: "uuid", nullable: true),
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
                        principalColumn: "Id");
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

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicationFormId = table.Column<Guid>(type: "uuid", nullable: false),
                    Base64Data = table.Column<string>(type: "text", nullable: false),
                    X = table.Column<int>(type: "integer", nullable: true),
                    Y = table.Column<int>(type: "integer", nullable: true),
                    Width = table.Column<int>(type: "integer", nullable: true),
                    Height = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_ApplicationForms_ApplicationFormId",
                        column: x => x.ApplicationFormId,
                        principalTable: "ApplicationForms",
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

            migrationBuilder.InsertData(
                table: "ApplicationStatuses",
                columns: new[] { "Id", "Number", "Status" },
                values: new object[,]
                {
                    { new Guid("26f4687b-ad69-4905-b729-64d9345d3d84"), 1, "В ожидании заполнения" },
                    { new Guid("6230785d-ff20-4d12-9d26-4a1dfe5408e7"), 4, "Одобрена" },
                    { new Guid("7a7f9107-ae26-4d93-8cd8-1874da49bcf3"), 2, "В ожидании рассмотрения" },
                    { new Guid("a0ebd598-aabc-49ef-ab1f-1c1792581314"), 6, "Оценена" },
                    { new Guid("b3d29f69-92d9-42af-ac47-0f96d841ea5a"), 3, "В процессе рассмотрения" },
                    { new Guid("c13b78d6-1d99-462c-bbfa-c5c1fa892028"), 5, "Отклонена" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10a9b1f4-b492-47ea-8cd9-30892bbd9404", null, "Voter", "VOTER" },
                    { "47ab566a-decc-4123-917c-8aa3226b7e15", null, "Organiser", "ORGANISER" },
                    { "4af48a6f-ff6e-4b6d-b29e-87f86eb3096f", null, "Participant", "PARTICIPANT" },
                    { "b7e6c1b9-1649-4a46-8c3c-282227845f41", null, "Expert", "EXPERT" },
                    { "d29ab40b-40d4-4af5-9117-b8749d78180f", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("9cc63aab-fc51-41b6-a020-214a57e960da"), "Строительство и архитектура", 1 },
                    { new Guid("b3f15ed7-4dbf-45fd-8bff-e56300b1b561"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "Deadlines",
                columns: new[] { "Id", "End", "Name", "Number", "Start" },
                values: new object[,]
                {
                    { new Guid("0adc4bdf-c085-4370-b459-4166924e5429"), new DateTimeOffset(new DateTime(2024, 11, 30, 23, 59, 59, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Голосование", 2, new DateTimeOffset(new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) },
                    { new Guid("df98170d-e1a3-4f4b-bba3-ab0f791663f5"), new DateTimeOffset(new DateTime(2024, 10, 20, 23, 59, 59, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Прием заявок", 1, new DateTimeOffset(new DateTime(2024, 9, 20, 9, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0d31a144-3e14-4da7-bb20-a2ab77a259a4"), "Профессиональное развитие", 4 },
                    { new Guid("20ae319f-ba03-4fe0-b8cd-893051708844"), "Общая информация", 1 },
                    { new Guid("9967712e-3f47-4ea6-aab9-836f88b487e7"), "Конкурсная работа", 3 },
                    { new Guid("9b58a218-39ec-4237-8ec3-e82dcd328ceb"), "Научно-исследовательская деятельность", 6 },
                    { new Guid("a5224107-9dff-4abf-99f8-7afb5a5bb5e5"), "Научно-педагогическая деятельность", 5 },
                    { new Guid("ffeef190-af6c-4282-969d-62aca2081113"), "Категория участников", 2 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("225c6269-914d-4ec7-990f-e6b0884490d0"), "Конкурсная работа", 7 },
                    { new Guid("22d79145-709c-4d8a-a8ab-c53548e4b31c"), "Профессиональные показатели", 4 },
                    { new Guid("28b82063-0fee-41f6-9278-0917399fb5e2"), "Основной", 1 },
                    { new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707"), "Образовательная деятельность", 2 },
                    { new Guid("d8a7d45c-8180-48f8-978b-447b8a0733e8"), "Инновационная и иная деятельность", 6 },
                    { new Guid("daeb5579-6a97-43ea-9010-f7c15aebd6e6"), "Методическая деятельность", 3 },
                    { new Guid("e88047de-1472-452b-9307-ea0d84d65435"), "Научно-исследовательская деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[] { new Guid("2605c7a1-2818-45a0-a735-d726f77b0690"), "EvaluateMark25", null, true, 10, "Баллы за голосование", 27, null });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("d2340e88-d0b7-4f2c-8f33-590f960d740e"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("ee9ba777-4efe-41ce-a870-a2ad9a27839b"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("12666697-320b-4c92-9113-2bd4a47480fd"), "bool" },
                    { new Guid("1cc5f6d1-e47e-46b1-8ebc-0ae83fa447bb"), "TextArea" },
                    { new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89"), "string" },
                    { new Guid("40c6253f-8a9c-46b4-b941-36069eb524a3"), "DateTime" },
                    { new Guid("a374a321-ee31-4cd8-8656-538a8498c83f"), "int" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0d31a144-3e14-4da7-bb20-a2ab77a259a4"), new Guid("d2340e88-d0b7-4f2c-8f33-590f960d740e") },
                    { new Guid("0d31a144-3e14-4da7-bb20-a2ab77a259a4"), new Guid("ee9ba777-4efe-41ce-a870-a2ad9a27839b") },
                    { new Guid("20ae319f-ba03-4fe0-b8cd-893051708844"), new Guid("d2340e88-d0b7-4f2c-8f33-590f960d740e") },
                    { new Guid("20ae319f-ba03-4fe0-b8cd-893051708844"), new Guid("ee9ba777-4efe-41ce-a870-a2ad9a27839b") },
                    { new Guid("9967712e-3f47-4ea6-aab9-836f88b487e7"), new Guid("d2340e88-d0b7-4f2c-8f33-590f960d740e") },
                    { new Guid("9967712e-3f47-4ea6-aab9-836f88b487e7"), new Guid("ee9ba777-4efe-41ce-a870-a2ad9a27839b") },
                    { new Guid("9b58a218-39ec-4237-8ec3-e82dcd328ceb"), new Guid("ee9ba777-4efe-41ce-a870-a2ad9a27839b") },
                    { new Guid("a5224107-9dff-4abf-99f8-7afb5a5bb5e5"), new Guid("d2340e88-d0b7-4f2c-8f33-590f960d740e") },
                    { new Guid("ffeef190-af6c-4282-969d-62aca2081113"), new Guid("d2340e88-d0b7-4f2c-8f33-590f960d740e") },
                    { new Guid("ffeef190-af6c-4282-969d-62aca2081113"), new Guid("ee9ba777-4efe-41ce-a870-a2ad9a27839b") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("120f2266-c1fe-41e3-b76e-abb96db14140"), new Guid("20ae319f-ba03-4fe0-b8cd-893051708844"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("121c91af-2589-40ef-ab81-b80cf3db3173"), new Guid("20ae319f-ba03-4fe0-b8cd-893051708844"), null, true, true, "Место работы", 6, "Название организации", new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("1e224f2d-da13-45d1-ab61-7b237fd4db4e"), new Guid("9b58a218-39ec-4237-8ec3-e82dcd328ceb"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") },
                    { new Guid("5727090d-2558-458c-8601-7d453dabc509"), new Guid("20ae319f-ba03-4fe0-b8cd-893051708844"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("6523f40f-45af-4b37-a077-ab6096165d43"), new Guid("20ae319f-ba03-4fe0-b8cd-893051708844"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("70f382fc-d843-4a46-8fc2-b5f59fe7d08d"), new Guid("20ae319f-ba03-4fe0-b8cd-893051708844"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") },
                    { new Guid("83cdded2-7dd3-4186-b485-cc1f15680696"), new Guid("9b58a218-39ec-4237-8ec3-e82dcd328ceb"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") },
                    { new Guid("86ee4edd-fbc4-49f4-b943-cf56131a391a"), new Guid("20ae319f-ba03-4fe0-b8cd-893051708844"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("8f9b4f41-7896-46b9-8fd4-551e6450126b"), new Guid("20ae319f-ba03-4fe0-b8cd-893051708844"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("9bacde36-1b12-4b9b-8f22-c9bb7ae7386e"), new Guid("a5224107-9dff-4abf-99f8-7afb5a5bb5e5"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") },
                    { new Guid("9c0880c1-0079-475c-8366-75a06729d405"), new Guid("ffeef190-af6c-4282-969d-62aca2081113"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("a1484d5a-671b-4ec9-b3fe-7078198a5f6a"), new Guid("a5224107-9dff-4abf-99f8-7afb5a5bb5e5"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") },
                    { new Guid("b37f849a-b386-40b4-b278-fed7bcb5e3ed"), new Guid("20ae319f-ba03-4fe0-b8cd-893051708844"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") },
                    { new Guid("b6891625-1b31-412f-88a3-440278e950ee"), new Guid("20ae319f-ba03-4fe0-b8cd-893051708844"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("c399d079-6aed-4829-b0ba-a357007bd345"), new Guid("ffeef190-af6c-4282-969d-62aca2081113"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("c6f2897e-b982-4618-b22e-28bc9cfd8a25"), new Guid("ffeef190-af6c-4282-969d-62aca2081113"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("c950e6c5-6db9-49d6-9db0-16913073d0c2"), new Guid("20ae319f-ba03-4fe0-b8cd-893051708844"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("40c6253f-8a9c-46b4-b941-36069eb524a3") },
                    { new Guid("e642a2d5-45d8-473b-aa01-444b036241e0"), new Guid("a5224107-9dff-4abf-99f8-7afb5a5bb5e5"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("225c6269-914d-4ec7-990f-e6b0884490d0"), new Guid("d2340e88-d0b7-4f2c-8f33-590f960d740e") },
                    { new Guid("225c6269-914d-4ec7-990f-e6b0884490d0"), new Guid("ee9ba777-4efe-41ce-a870-a2ad9a27839b") },
                    { new Guid("22d79145-709c-4d8a-a8ab-c53548e4b31c"), new Guid("d2340e88-d0b7-4f2c-8f33-590f960d740e") },
                    { new Guid("28b82063-0fee-41f6-9278-0917399fb5e2"), new Guid("d2340e88-d0b7-4f2c-8f33-590f960d740e") },
                    { new Guid("28b82063-0fee-41f6-9278-0917399fb5e2"), new Guid("ee9ba777-4efe-41ce-a870-a2ad9a27839b") },
                    { new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707"), new Guid("d2340e88-d0b7-4f2c-8f33-590f960d740e") },
                    { new Guid("d8a7d45c-8180-48f8-978b-447b8a0733e8"), new Guid("ee9ba777-4efe-41ce-a870-a2ad9a27839b") },
                    { new Guid("daeb5579-6a97-43ea-9010-f7c15aebd6e6"), new Guid("d2340e88-d0b7-4f2c-8f33-590f960d740e") },
                    { new Guid("e88047de-1472-452b-9307-ea0d84d65435"), new Guid("ee9ba777-4efe-41ce-a870-a2ad9a27839b") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("05eae27c-71b6-4a1a-afe2-b88d391b7315"), new Guid("a5224107-9dff-4abf-99f8-7afb5a5bb5e5"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("1a4e3b9c-5bd5-43be-af0d-69180481ec7e"), new Guid("0d31a144-3e14-4da7-bb20-a2ab77a259a4"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 },
                    { new Guid("3944c263-680f-44d1-bc0c-fb7f44bb5643"), new Guid("a5224107-9dff-4abf-99f8-7afb5a5bb5e5"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 },
                    { new Guid("52a2156e-118b-49df-8995-24229b971dfe"), new Guid("a5224107-9dff-4abf-99f8-7afb5a5bb5e5"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 },
                    { new Guid("5c2fdd22-bfb7-40b4-b0d4-2617186ae8e8"), new Guid("9967712e-3f47-4ea6-aab9-836f88b487e7"), true, true, "Краткая аннотация конкурсной работы", 1 },
                    { new Guid("69d7a632-4087-40ca-be13-7d811f230c91"), new Guid("9b58a218-39ec-4237-8ec3-e82dcd328ceb"), false, false, "Список научных публикаций за последние 5 лет", 10 },
                    { new Guid("6a837e39-eb55-4648-983a-ef40e462a119"), new Guid("9b58a218-39ec-4237-8ec3-e82dcd328ceb"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("bb03a285-288a-4f48-bfc2-d529d466e1e5"), new Guid("0d31a144-3e14-4da7-bb20-a2ab77a259a4"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("cec261a8-c79a-4994-a50e-7848ad22bd43"), new Guid("a5224107-9dff-4abf-99f8-7afb5a5bb5e5"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 },
                    { new Guid("d45f302b-3fde-4d98-9878-3485c06e3cd2"), new Guid("a5224107-9dff-4abf-99f8-7afb5a5bb5e5"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("d5681c7a-5a17-4702-a9c0-eb4faa1530a7"), new Guid("9b58a218-39ec-4237-8ec3-e82dcd328ceb"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("db414d60-b234-4126-9541-8c583f6b79bb"), new Guid("0d31a144-3e14-4da7-bb20-a2ab77a259a4"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("f410cf37-dbc8-4967-b9d0-a9596f9a9d08"), new Guid("9b58a218-39ec-4237-8ec3-e82dcd328ceb"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("00b48533-b380-436e-8e20-c0abd4c356e5"), true, "Название", 2, new Guid("3944c263-680f-44d1-bc0c-fb7f44bb5643"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("0426748e-6c57-4073-898f-4516b49e18e5"), true, "Название конкурса/премии", 2, new Guid("cec261a8-c79a-4994-a50e-7848ad22bd43"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("0df5c285-988f-46a7-a80a-c3b9f4a17788"), true, "Количество печатных листов", 4, new Guid("3944c263-680f-44d1-bc0c-fb7f44bb5643"), new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") },
                    { new Guid("113e0e86-f774-4512-8a84-692da1abc9db"), true, "Язык публикации", 7, new Guid("3944c263-680f-44d1-bc0c-fb7f44bb5643"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("17b4f97d-7e44-4d4d-8450-100e0b735159"), true, "ФИО соавторов", 3, new Guid("f410cf37-dbc8-4967-b9d0-a9596f9a9d08"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("1c1afe35-4cc2-4536-84c9-aa6dcdec0b2e"), true, "Статус конкурса", 3, new Guid("1a4e3b9c-5bd5-43be-af0d-69180481ec7e"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("27c66ab9-a694-4c22-a221-80a84b6247b0"), true, "Название дисциплины", 1, new Guid("52a2156e-118b-49df-8995-24229b971dfe"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("2b49b9bb-18a5-4aad-acaa-407bb006edb3"), true, "Ссылка на платформу", 3, new Guid("d45f302b-3fde-4d98-9878-3485c06e3cd2"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("2f9da356-5025-4835-8690-c89b25ac434d"), true, "Вид", 2, new Guid("52a2156e-118b-49df-8995-24229b971dfe"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("309c1cc9-9573-422e-af69-eefbaae079c8"), true, "Название", 2, new Guid("f410cf37-dbc8-4967-b9d0-a9596f9a9d08"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("3179ef44-0235-4cc1-b33d-cd60cf5adcb9"), true, "Год", 1, new Guid("1a4e3b9c-5bd5-43be-af0d-69180481ec7e"), new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") },
                    { new Guid("317c84c5-91d7-4fc3-a18d-c6db643b9b43"), true, "Название курса", 1, new Guid("d45f302b-3fde-4d98-9878-3485c06e3cd2"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("3245ff05-4e9b-415a-826f-e8d96c9162ab"), true, "Издание, год", 4, new Guid("69d7a632-4087-40ca-be13-7d811f230c91"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("39b2d0b0-dea6-43e2-a6c2-8c996a6bffd0"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("6a837e39-eb55-4648-983a-ef40e462a119"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("4ccd0150-e2ca-4160-a1fb-57c00a2f3b54"), true, "Статус", 4, new Guid("6a837e39-eb55-4648-983a-ef40e462a119"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("4d828c4f-cd9e-4805-9d80-edd6faccb5ca"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("69d7a632-4087-40ca-be13-7d811f230c91"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("53231167-fc6a-49af-8552-ded0b9c3cbdf"), true, "Вид публикации", 1, new Guid("3944c263-680f-44d1-bc0c-fb7f44bb5643"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("58b7d8d9-36e4-4049-ad94-0d4904e26af6"), true, "Лекции (час.)", 3, new Guid("05eae27c-71b6-4a1a-afe2-b88d391b7315"), new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") },
                    { new Guid("59fe935c-eedb-45c0-85a1-a7e01db9c625"), true, "Год получения документа", 2, new Guid("db414d60-b234-4126-9541-8c583f6b79bb"), new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") },
                    { new Guid("5c04d09a-72b3-4086-8bbc-1428cc3a5fe5"), true, "Вид", 1, new Guid("d5681c7a-5a17-4702-a9c0-eb4faa1530a7"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("5d31cd93-59d2-4e5d-9698-caeecdfa8345"), true, "Соавторы", 2, new Guid("d45f302b-3fde-4d98-9878-3485c06e3cd2"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("6363ecd3-e9a2-4f91-b5dc-d87c60f88134"), true, "Название", 1, new Guid("5c2fdd22-bfb7-40b4-b0d4-2617186ae8e8"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("6fda8e6d-e1fe-4a9a-a838-b7a9539e73ec"), true, "ФИО", 1, new Guid("cec261a8-c79a-4994-a50e-7848ad22bd43"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("7f2cc1e6-210b-4c93-812e-c4d8b71fa594"), false, "Идентификатор", 2, new Guid("bb03a285-288a-4f48-bfc2-d529d466e1e5"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("83032e8f-2a93-4dfa-a26d-fceb27173686"), true, "Название документа, реквизиты", 1, new Guid("db414d60-b234-4126-9541-8c583f6b79bb"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("83ab97b9-9944-4bd9-8cd8-d49b7c07132c"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("52a2156e-118b-49df-8995-24229b971dfe"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("8d9cb476-7a90-431a-ab8b-1040e70baa02"), true, "Ссылка на открытый доступ", 8, new Guid("3944c263-680f-44d1-bc0c-fb7f44bb5643"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("911e324c-bff4-49ae-a68a-3d8a639d6aa0"), true, "Соавторы", 2, new Guid("69d7a632-4087-40ca-be13-7d811f230c91"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("9c85dcdf-53cd-4d5f-9632-f1668f0384e9"), true, "Значение", 2, new Guid("5c2fdd22-bfb7-40b4-b0d4-2617186ae8e8"), new Guid("1cc5f6d1-e47e-46b1-8ebc-0ae83fa447bb") },
                    { new Guid("a1d22b0f-0cbb-48dd-92a5-383605041eb3"), true, "Название статьи", 1, new Guid("69d7a632-4087-40ca-be13-7d811f230c91"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("a57cce37-a28a-4106-b3a7-ef2ab5600c9a"), true, "Практические занятия (час.)", 4, new Guid("05eae27c-71b6-4a1a-afe2-b88d391b7315"), new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") },
                    { new Guid("a8eacf85-4d31-45c1-a784-c4bbce96610c"), true, "Вид", 1, new Guid("f410cf37-dbc8-4967-b9d0-a9596f9a9d08"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("aaa35a2e-28e5-48a9-b858-c50bebf7c99d"), true, "Язык преподавания", 2, new Guid("05eae27c-71b6-4a1a-afe2-b88d391b7315"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("af5ff55e-4cba-4d7b-ac22-9467dee92762"), false, "Соавторы", 3, new Guid("3944c263-680f-44d1-bc0c-fb7f44bb5643"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("b1d99c88-de60-4782-980b-bc235262b088"), true, "Наличие грифа", 5, new Guid("3944c263-680f-44d1-bc0c-fb7f44bb5643"), new Guid("12666697-320b-4c92-9113-2bd4a47480fd") },
                    { new Guid("b1effc34-b154-459f-a899-a0a7e14dfea1"), true, "Наименование курса", 1, new Guid("05eae27c-71b6-4a1a-afe2-b88d391b7315"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("b200902e-2496-4013-a81c-ec2b41000a6f"), true, "Год", 4, new Guid("d45f302b-3fde-4d98-9878-3485c06e3cd2"), new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") },
                    { new Guid("bc3cd99a-0905-40a4-81b5-a3f1b2831992"), true, "Название НИР/НИОКР", 1, new Guid("6a837e39-eb55-4648-983a-ef40e462a119"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("bd226921-3592-4b68-b7f3-f65898230e6e"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("cec261a8-c79a-4994-a50e-7848ad22bd43"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("bda5c300-4cc7-4d21-8df5-ae2df797df6f"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("cec261a8-c79a-4994-a50e-7848ad22bd43"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("bde4c8a1-2996-4047-839c-873828ba1cd0"), true, "Год", 3, new Guid("cec261a8-c79a-4994-a50e-7848ad22bd43"), new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") },
                    { new Guid("c4339936-96e7-434d-b47d-1d0cfd0eec21"), true, "Ссылка", 5, new Guid("1a4e3b9c-5bd5-43be-af0d-69180481ec7e"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("c454027a-8b6e-4e3b-aac1-d8626d9c6895"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("1a4e3b9c-5bd5-43be-af0d-69180481ec7e"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("c45c9202-2de8-4b9d-9c3f-765c8360924b"), true, "Название разработки", 2, new Guid("d5681c7a-5a17-4702-a9c0-eb4faa1530a7"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("d782da9d-376d-494a-9b32-d3e3be10baf7"), true, "Название организации в которую внедрена разработка", 3, new Guid("d5681c7a-5a17-4702-a9c0-eb4faa1530a7"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("e0f5af1e-63ee-4ef0-9d17-e3aed3f3d909"), true, "Номер РИД", 4, new Guid("f410cf37-dbc8-4967-b9d0-a9596f9a9d08"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("e146d8f8-488a-4e18-90b9-096ce5b8535d"), true, "Издательство, год", 6, new Guid("3944c263-680f-44d1-bc0c-fb7f44bb5643"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("e338a101-a8d9-4785-9857-2923db18d724"), false, "Тип идентификатора", 1, new Guid("bb03a285-288a-4f48-bfc2-d529d466e1e5"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("ea31d9c4-f085-43f6-a8b1-b9713fcbc33e"), true, "Название конкурса", 2, new Guid("1a4e3b9c-5bd5-43be-af0d-69180481ec7e"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("ef602d16-6f7a-4389-bc64-149a373666ba"), true, "Итого (час.)", 5, new Guid("05eae27c-71b6-4a1a-afe2-b88d391b7315"), new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") },
                    { new Guid("f6fd1161-13c1-4236-a32e-5c90d7213544"), true, "Период выполнения", 3, new Guid("6a837e39-eb55-4648-983a-ef40e462a119"), new Guid("2ff41c33-80b2-48bc-8c8d-1d0df8771c89") },
                    { new Guid("f789fda7-bfa2-43ab-9579-09dbe2fca5ac"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("6a837e39-eb55-4648-983a-ef40e462a119"), new Guid("a374a321-ee31-4cd8-8656-538a8498c83f") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("120f2266-c1fe-41e3-b76e-abb96db14140"), new Guid("28b82063-0fee-41f6-9278-0917399fb5e2") },
                    { new Guid("121c91af-2589-40ef-ab81-b80cf3db3173"), new Guid("28b82063-0fee-41f6-9278-0917399fb5e2") },
                    { new Guid("1e224f2d-da13-45d1-ab61-7b237fd4db4e"), new Guid("e88047de-1472-452b-9307-ea0d84d65435") },
                    { new Guid("5727090d-2558-458c-8601-7d453dabc509"), new Guid("28b82063-0fee-41f6-9278-0917399fb5e2") },
                    { new Guid("6523f40f-45af-4b37-a077-ab6096165d43"), new Guid("28b82063-0fee-41f6-9278-0917399fb5e2") },
                    { new Guid("70f382fc-d843-4a46-8fc2-b5f59fe7d08d"), new Guid("28b82063-0fee-41f6-9278-0917399fb5e2") },
                    { new Guid("83cdded2-7dd3-4186-b485-cc1f15680696"), new Guid("e88047de-1472-452b-9307-ea0d84d65435") },
                    { new Guid("86ee4edd-fbc4-49f4-b943-cf56131a391a"), new Guid("28b82063-0fee-41f6-9278-0917399fb5e2") },
                    { new Guid("8f9b4f41-7896-46b9-8fd4-551e6450126b"), new Guid("28b82063-0fee-41f6-9278-0917399fb5e2") },
                    { new Guid("9bacde36-1b12-4b9b-8f22-c9bb7ae7386e"), new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707") },
                    { new Guid("9c0880c1-0079-475c-8366-75a06729d405"), new Guid("28b82063-0fee-41f6-9278-0917399fb5e2") },
                    { new Guid("a1484d5a-671b-4ec9-b3fe-7078198a5f6a"), new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707") },
                    { new Guid("b37f849a-b386-40b4-b278-fed7bcb5e3ed"), new Guid("28b82063-0fee-41f6-9278-0917399fb5e2") },
                    { new Guid("b6891625-1b31-412f-88a3-440278e950ee"), new Guid("28b82063-0fee-41f6-9278-0917399fb5e2") },
                    { new Guid("c399d079-6aed-4829-b0ba-a357007bd345"), new Guid("28b82063-0fee-41f6-9278-0917399fb5e2") },
                    { new Guid("c6f2897e-b982-4618-b22e-28bc9cfd8a25"), new Guid("22d79145-709c-4d8a-a8ab-c53548e4b31c") },
                    { new Guid("c6f2897e-b982-4618-b22e-28bc9cfd8a25"), new Guid("28b82063-0fee-41f6-9278-0917399fb5e2") },
                    { new Guid("c6f2897e-b982-4618-b22e-28bc9cfd8a25"), new Guid("e88047de-1472-452b-9307-ea0d84d65435") },
                    { new Guid("c950e6c5-6db9-49d6-9db0-16913073d0c2"), new Guid("28b82063-0fee-41f6-9278-0917399fb5e2") },
                    { new Guid("e642a2d5-45d8-473b-aa01-444b036241e0"), new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("225c6269-914d-4ec7-990f-e6b0884490d0"), new Guid("5c2fdd22-bfb7-40b4-b0d4-2617186ae8e8") },
                    { new Guid("22d79145-709c-4d8a-a8ab-c53548e4b31c"), new Guid("1a4e3b9c-5bd5-43be-af0d-69180481ec7e") },
                    { new Guid("22d79145-709c-4d8a-a8ab-c53548e4b31c"), new Guid("db414d60-b234-4126-9541-8c583f6b79bb") },
                    { new Guid("28b82063-0fee-41f6-9278-0917399fb5e2"), new Guid("bb03a285-288a-4f48-bfc2-d529d466e1e5") },
                    { new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707"), new Guid("05eae27c-71b6-4a1a-afe2-b88d391b7315") },
                    { new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707"), new Guid("cec261a8-c79a-4994-a50e-7848ad22bd43") },
                    { new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707"), new Guid("d45f302b-3fde-4d98-9878-3485c06e3cd2") },
                    { new Guid("d8a7d45c-8180-48f8-978b-447b8a0733e8"), new Guid("d5681c7a-5a17-4702-a9c0-eb4faa1530a7") },
                    { new Guid("d8a7d45c-8180-48f8-978b-447b8a0733e8"), new Guid("db414d60-b234-4126-9541-8c583f6b79bb") },
                    { new Guid("d8a7d45c-8180-48f8-978b-447b8a0733e8"), new Guid("f410cf37-dbc8-4967-b9d0-a9596f9a9d08") },
                    { new Guid("daeb5579-6a97-43ea-9010-f7c15aebd6e6"), new Guid("3944c263-680f-44d1-bc0c-fb7f44bb5643") },
                    { new Guid("daeb5579-6a97-43ea-9010-f7c15aebd6e6"), new Guid("52a2156e-118b-49df-8995-24229b971dfe") },
                    { new Guid("e88047de-1472-452b-9307-ea0d84d65435"), new Guid("1a4e3b9c-5bd5-43be-af0d-69180481ec7e") },
                    { new Guid("e88047de-1472-452b-9307-ea0d84d65435"), new Guid("69d7a632-4087-40ca-be13-7d811f230c91") },
                    { new Guid("e88047de-1472-452b-9307-ea0d84d65435"), new Guid("6a837e39-eb55-4648-983a-ef40e462a119") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("1626eef8-c7f3-497c-b8fe-535f38412070"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("d5681c7a-5a17-4702-a9c0-eb4faa1530a7") },
                    { new Guid("2334316a-0939-42f3-a2ee-7b1d3e7cb328"), "EvaluateMark20", new Guid("83cdded2-7dd3-4186-b485-cc1f15680696"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("23e861bf-4cb0-46ee-a41f-ee12cf0284fb"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("05eae27c-71b6-4a1a-afe2-b88d391b7315") },
                    { new Guid("246518bb-8425-4192-972c-05a05f2b671c"), "EvaluateMark3", new Guid("e642a2d5-45d8-473b-aa01-444b036241e0"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("2fcb76a0-6788-428e-b4c6-a2863b9c1801"), "EvaluateMark4", new Guid("9bacde36-1b12-4b9b-8f22-c9bb7ae7386e"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("37f2f971-0c1a-4f64-8163-6dad4fead714"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("1a4e3b9c-5bd5-43be-af0d-69180481ec7e") },
                    { new Guid("39ee357c-064a-4659-9a91-95192c3fa545"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("52a2156e-118b-49df-8995-24229b971dfe") },
                    { new Guid("5a0e6a41-19b6-4e54-a1ae-4dc9625b7b14"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("cec261a8-c79a-4994-a50e-7848ad22bd43") },
                    { new Guid("62e3155e-0099-4e36-9747-4a4226e03091"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("6a837e39-eb55-4648-983a-ef40e462a119") },
                    { new Guid("6b5dacc3-4f70-4a38-a60a-0056306d0820"), "EvaluateMark5", new Guid("a1484d5a-671b-4ec9-b3fe-7078198a5f6a"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("6c7a217b-39fc-4cd5-9219-756c0d7a3578"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("3944c263-680f-44d1-bc0c-fb7f44bb5643") },
                    { new Guid("793a6be7-b2ec-4c73-a70e-beea032ed8c2"), "EvaluateMark19", new Guid("1e224f2d-da13-45d1-ab61-7b237fd4db4e"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("84ca054b-420b-4748-8da2-e75d4153f631"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("3944c263-680f-44d1-bc0c-fb7f44bb5643") },
                    { new Guid("882a2ebf-120a-48b2-b620-75ce96c597f9"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("f410cf37-dbc8-4967-b9d0-a9596f9a9d08") },
                    { new Guid("94f02709-a6ed-447d-b918-6203387aaae8"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("d45f302b-3fde-4d98-9878-3485c06e3cd2") },
                    { new Guid("9c77e8b8-65eb-4c41-816e-d295da43368b"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("05eae27c-71b6-4a1a-afe2-b88d391b7315") },
                    { new Guid("c2e1efe5-cabb-4ec0-9829-68060a5ba3b5"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом или на иностранном языке и без соавторства:", 8, new Guid("3944c263-680f-44d1-bc0c-fb7f44bb5643") },
                    { new Guid("d10e9753-29c9-400a-a395-2983cef459f7"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом или на иностранном языке в соавторстве:", 9, new Guid("3944c263-680f-44d1-bc0c-fb7f44bb5643") },
                    { new Guid("d69ff61a-656b-4ad6-b083-02f8b2cc5780"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("6a837e39-eb55-4648-983a-ef40e462a119") },
                    { new Guid("d6f20fc3-96a4-4e80-86e6-e928489c3cb0"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("db414d60-b234-4126-9541-8c583f6b79bb") },
                    { new Guid("de25242a-b896-42be-996e-ce140ea6d6bd"), "EvaluateMark13", new Guid("c6f2897e-b982-4618-b22e-28bc9cfd8a25"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("e01b46c4-3433-4ea1-9429-315da9831ccd"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("69d7a632-4087-40ca-be13-7d811f230c91") },
                    { new Guid("ed5927dc-7c1d-4279-9783-074ec0bf0fda"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("5c2fdd22-bfb7-40b4-b0d4-2617186ae8e8") },
                    { new Guid("f20ffb32-8a56-43e1-9021-e5b5d3510515"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("5c2fdd22-bfb7-40b4-b0d4-2617186ae8e8") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("08e86362-252b-4a65-a324-6b7cfc9cd1a2"), true, 4, new Guid("bb03a285-288a-4f48-bfc2-d529d466e1e5") },
                    { new Guid("30536ada-1d88-4639-9409-adb9f080fe79"), true, 2, new Guid("5c2fdd22-bfb7-40b4-b0d4-2617186ae8e8") },
                    { new Guid("416b1c46-e994-433a-9a0a-b9546c3cd244"), true, 5, new Guid("5c2fdd22-bfb7-40b4-b0d4-2617186ae8e8") },
                    { new Guid("537789e3-6937-4396-bce3-ce3c62889b88"), true, 1, new Guid("bb03a285-288a-4f48-bfc2-d529d466e1e5") },
                    { new Guid("817cadde-d90c-4848-811a-83024551e095"), true, 8, new Guid("5c2fdd22-bfb7-40b4-b0d4-2617186ae8e8") },
                    { new Guid("884532fc-4a24-44b5-af56-690338e5330d"), true, 4, new Guid("5c2fdd22-bfb7-40b4-b0d4-2617186ae8e8") },
                    { new Guid("a94facb4-c2bd-4827-b259-32828e307cbf"), true, 3, new Guid("5c2fdd22-bfb7-40b4-b0d4-2617186ae8e8") },
                    { new Guid("c219acb7-d2a8-4ff0-a653-3d5d0aa319e2"), true, 5, new Guid("bb03a285-288a-4f48-bfc2-d529d466e1e5") },
                    { new Guid("c35ace35-8bb2-4aa3-9200-65195296df57"), true, 6, new Guid("5c2fdd22-bfb7-40b4-b0d4-2617186ae8e8") },
                    { new Guid("c858440d-73de-452e-8f70-bd9219b47a7f"), true, 7, new Guid("5c2fdd22-bfb7-40b4-b0d4-2617186ae8e8") },
                    { new Guid("cebb3d70-d992-453b-934e-0826a5769918"), true, 1, new Guid("5c2fdd22-bfb7-40b4-b0d4-2617186ae8e8") },
                    { new Guid("cf308d0d-7233-423b-ad01-3adc945d5c87"), true, 3, new Guid("bb03a285-288a-4f48-bfc2-d529d466e1e5") },
                    { new Guid("e0f612bf-d114-4dcd-995e-ea5cf6688148"), true, 2, new Guid("bb03a285-288a-4f48-bfc2-d529d466e1e5") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("13ed82b1-7852-404c-9dca-9a77c6babf6c"), null, new Guid("9c0880c1-0079-475c-8366-75a06729d405"), "Кандидат наук" },
                    { new Guid("1c9cf108-f2b1-4d81-b0d7-a86c8044b582"), null, new Guid("c6f2897e-b982-4618-b22e-28bc9cfd8a25"), "Доцент" },
                    { new Guid("7050f762-abf1-4195-9992-05e4b774243d"), null, new Guid("c6f2897e-b982-4618-b22e-28bc9cfd8a25"), "Нет" },
                    { new Guid("b76d531f-80be-4ac1-94bb-33ac84f3eaeb"), null, new Guid("9c0880c1-0079-475c-8366-75a06729d405"), "Доктор наук" },
                    { new Guid("d69ceac1-bcd4-4f2b-9f53-f5413026c5bb"), null, new Guid("c6f2897e-b982-4618-b22e-28bc9cfd8a25"), "Профессор" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("00a08c48-18db-4481-b1cd-82608601900f"), null, new Guid("6363ecd3-e9a2-4f91-b5dc-d87c60f88134"), true, true, new Guid("817cadde-d90c-4848-811a-83024551e095"), "Результаты и выводы" },
                    { new Guid("0f51338d-46e6-42e3-a8fb-a00913ae739b"), null, new Guid("7f2cc1e6-210b-4c93-812e-c4d8b71fa594"), false, true, new Guid("08e86362-252b-4a65-a324-6b7cfc9cd1a2"), null },
                    { new Guid("232b31fd-ee72-4a0e-bf90-b80eac02ffb5"), null, new Guid("9c85dcdf-53cd-4d5f-9632-f1668f0384e9"), false, true, new Guid("c858440d-73de-452e-8f70-bd9219b47a7f"), null },
                    { new Guid("2547df98-a778-48ad-aca0-f66f9f491266"), null, new Guid("9c85dcdf-53cd-4d5f-9632-f1668f0384e9"), false, true, new Guid("416b1c46-e994-433a-9a0a-b9546c3cd244"), null },
                    { new Guid("2c791da5-7b77-4e15-bcea-2417aafcd8e4"), null, new Guid("6363ecd3-e9a2-4f91-b5dc-d87c60f88134"), true, true, new Guid("c35ace35-8bb2-4aa3-9200-65195296df57"), "Апробация" },
                    { new Guid("484c4743-7e2b-418d-9361-52ccda5cebf2"), null, new Guid("6363ecd3-e9a2-4f91-b5dc-d87c60f88134"), true, true, new Guid("cebb3d70-d992-453b-934e-0826a5769918"), "Название работы" },
                    { new Guid("5049f21b-20f2-4ffc-8764-b82c663479fb"), null, new Guid("e338a101-a8d9-4785-9857-2923db18d724"), true, true, new Guid("537789e3-6937-4396-bce3-ce3c62889b88"), "ScopusID" },
                    { new Guid("7257057d-e1bf-45bd-823e-aea82dfea5af"), null, new Guid("6363ecd3-e9a2-4f91-b5dc-d87c60f88134"), true, true, new Guid("416b1c46-e994-433a-9a0a-b9546c3cd244"), "Ссылка на конкурсную работу" },
                    { new Guid("8139a774-2c2a-4faa-8966-bc20f8647cec"), null, new Guid("9c85dcdf-53cd-4d5f-9632-f1668f0384e9"), false, true, new Guid("a94facb4-c2bd-4827-b259-32828e307cbf"), null },
                    { new Guid("84d79306-e8c5-458b-8c8f-6c924aa62290"), null, new Guid("e338a101-a8d9-4785-9857-2923db18d724"), true, true, new Guid("08e86362-252b-4a65-a324-6b7cfc9cd1a2"), "РИНЦ AuthorID" },
                    { new Guid("8aeb9cac-98c9-4c2f-8b88-33a0e45be383"), null, new Guid("e338a101-a8d9-4785-9857-2923db18d724"), true, true, new Guid("e0f612bf-d114-4dcd-995e-ea5cf6688148"), "ORCiD" },
                    { new Guid("8ddf9367-df46-45e3-87e2-dc0110b6716e"), null, new Guid("9c85dcdf-53cd-4d5f-9632-f1668f0384e9"), false, true, new Guid("c35ace35-8bb2-4aa3-9200-65195296df57"), null },
                    { new Guid("95d3677e-41bc-4e71-b10e-bcf8b7a66993"), null, new Guid("6363ecd3-e9a2-4f91-b5dc-d87c60f88134"), true, true, new Guid("a94facb4-c2bd-4827-b259-32828e307cbf"), "Инновационность" },
                    { new Guid("a2004dab-e536-475d-a057-02e3ca032a94"), null, new Guid("9c85dcdf-53cd-4d5f-9632-f1668f0384e9"), false, true, new Guid("884532fc-4a24-44b5-af56-690338e5330d"), null },
                    { new Guid("aa40a65e-6050-452b-86fa-60b76742390d"), null, new Guid("6363ecd3-e9a2-4f91-b5dc-d87c60f88134"), true, true, new Guid("884532fc-4a24-44b5-af56-690338e5330d"), "Методология и методы, используемые в работе" },
                    { new Guid("b23cca76-b755-4c15-9a46-fbea632f5af2"), null, new Guid("7f2cc1e6-210b-4c93-812e-c4d8b71fa594"), false, true, new Guid("e0f612bf-d114-4dcd-995e-ea5cf6688148"), null },
                    { new Guid("b3a10402-476d-4b87-b83f-2834caaf5919"), null, new Guid("e338a101-a8d9-4785-9857-2923db18d724"), true, true, new Guid("c219acb7-d2a8-4ff0-a653-3d5d0aa319e2"), "Google Scholar ID" },
                    { new Guid("c67575dd-2e4f-4c3d-8b6e-c0d6ef0fcacb"), null, new Guid("9c85dcdf-53cd-4d5f-9632-f1668f0384e9"), false, true, new Guid("817cadde-d90c-4848-811a-83024551e095"), null },
                    { new Guid("d2108337-098f-480c-bd82-d797d17ff1c9"), null, new Guid("7f2cc1e6-210b-4c93-812e-c4d8b71fa594"), false, true, new Guid("537789e3-6937-4396-bce3-ce3c62889b88"), null },
                    { new Guid("d9498e16-1bac-4c22-a3bc-ebd694505184"), null, new Guid("6363ecd3-e9a2-4f91-b5dc-d87c60f88134"), true, true, new Guid("c858440d-73de-452e-8f70-bd9219b47a7f"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("e961a39b-b50a-4871-a987-7d0ec6881fdf"), null, new Guid("9c85dcdf-53cd-4d5f-9632-f1668f0384e9"), false, true, new Guid("30536ada-1d88-4639-9409-adb9f080fe79"), null },
                    { new Guid("f2a35711-facb-4f82-b74a-98a7c04d295e"), null, new Guid("9c85dcdf-53cd-4d5f-9632-f1668f0384e9"), false, true, new Guid("cebb3d70-d992-453b-934e-0826a5769918"), null },
                    { new Guid("f603f7b0-845a-49b5-bfb8-dca00cedf810"), null, new Guid("e338a101-a8d9-4785-9857-2923db18d724"), true, true, new Guid("cf308d0d-7233-423b-ad01-3adc945d5c87"), "ResearcherID" },
                    { new Guid("f9c06f2a-59f3-4d5e-b9f9-f845d5947320"), null, new Guid("6363ecd3-e9a2-4f91-b5dc-d87c60f88134"), true, true, new Guid("30536ada-1d88-4639-9409-adb9f080fe79"), "Актуальность конкурсной работы" },
                    { new Guid("fa73cea1-d0eb-45c8-a7f0-676b151da156"), null, new Guid("7f2cc1e6-210b-4c93-812e-c4d8b71fa594"), false, true, new Guid("cf308d0d-7233-423b-ad01-3adc945d5c87"), null },
                    { new Guid("fb8dd645-c17c-456c-b6c1-3c7278b35402"), null, new Guid("7f2cc1e6-210b-4c93-812e-c4d8b71fa594"), false, true, new Guid("c219acb7-d2a8-4ff0-a653-3d5d0aa319e2"), null }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("225c6269-914d-4ec7-990f-e6b0884490d0"), new Guid("ed5927dc-7c1d-4279-9783-074ec0bf0fda") },
                    { new Guid("225c6269-914d-4ec7-990f-e6b0884490d0"), new Guid("f20ffb32-8a56-43e1-9021-e5b5d3510515") },
                    { new Guid("22d79145-709c-4d8a-a8ab-c53548e4b31c"), new Guid("37f2f971-0c1a-4f64-8163-6dad4fead714") },
                    { new Guid("22d79145-709c-4d8a-a8ab-c53548e4b31c"), new Guid("d6f20fc3-96a4-4e80-86e6-e928489c3cb0") },
                    { new Guid("22d79145-709c-4d8a-a8ab-c53548e4b31c"), new Guid("de25242a-b896-42be-996e-ce140ea6d6bd") },
                    { new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707"), new Guid("23e861bf-4cb0-46ee-a41f-ee12cf0284fb") },
                    { new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707"), new Guid("246518bb-8425-4192-972c-05a05f2b671c") },
                    { new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707"), new Guid("2fcb76a0-6788-428e-b4c6-a2863b9c1801") },
                    { new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707"), new Guid("5a0e6a41-19b6-4e54-a1ae-4dc9625b7b14") },
                    { new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707"), new Guid("6b5dacc3-4f70-4a38-a60a-0056306d0820") },
                    { new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707"), new Guid("94f02709-a6ed-447d-b918-6203387aaae8") },
                    { new Guid("cfb1d694-c3be-4ac2-8408-3b9c3e21a707"), new Guid("9c77e8b8-65eb-4c41-816e-d295da43368b") },
                    { new Guid("d8a7d45c-8180-48f8-978b-447b8a0733e8"), new Guid("1626eef8-c7f3-497c-b8fe-535f38412070") },
                    { new Guid("d8a7d45c-8180-48f8-978b-447b8a0733e8"), new Guid("882a2ebf-120a-48b2-b620-75ce96c597f9") },
                    { new Guid("d8a7d45c-8180-48f8-978b-447b8a0733e8"), new Guid("d6f20fc3-96a4-4e80-86e6-e928489c3cb0") },
                    { new Guid("daeb5579-6a97-43ea-9010-f7c15aebd6e6"), new Guid("39ee357c-064a-4659-9a91-95192c3fa545") },
                    { new Guid("daeb5579-6a97-43ea-9010-f7c15aebd6e6"), new Guid("6c7a217b-39fc-4cd5-9219-756c0d7a3578") },
                    { new Guid("daeb5579-6a97-43ea-9010-f7c15aebd6e6"), new Guid("84ca054b-420b-4748-8da2-e75d4153f631") },
                    { new Guid("daeb5579-6a97-43ea-9010-f7c15aebd6e6"), new Guid("c2e1efe5-cabb-4ec0-9829-68060a5ba3b5") },
                    { new Guid("daeb5579-6a97-43ea-9010-f7c15aebd6e6"), new Guid("d10e9753-29c9-400a-a395-2983cef459f7") },
                    { new Guid("e88047de-1472-452b-9307-ea0d84d65435"), new Guid("2334316a-0939-42f3-a2ee-7b1d3e7cb328") },
                    { new Guid("e88047de-1472-452b-9307-ea0d84d65435"), new Guid("37f2f971-0c1a-4f64-8163-6dad4fead714") },
                    { new Guid("e88047de-1472-452b-9307-ea0d84d65435"), new Guid("62e3155e-0099-4e36-9747-4a4226e03091") },
                    { new Guid("e88047de-1472-452b-9307-ea0d84d65435"), new Guid("793a6be7-b2ec-4c73-a70e-beea032ed8c2") },
                    { new Guid("e88047de-1472-452b-9307-ea0d84d65435"), new Guid("d69ff61a-656b-4ad6-b083-02f8b2cc5780") },
                    { new Guid("e88047de-1472-452b-9307-ea0d84d65435"), new Guid("de25242a-b896-42be-996e-ce140ea6d6bd") },
                    { new Guid("e88047de-1472-452b-9307-ea0d84d65435"), new Guid("e01b46c4-3433-4ea1-9429-315da9831ccd") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0c9f2d6c-1656-45c2-9731-1ed3304d4739"), new Guid("911e324c-bff4-49ae-a68a-3d8a639d6aa0"), null, "Нет" },
                    { new Guid("0e4c749f-c331-47db-a5da-a3f4523b7a49"), new Guid("a8eacf85-4d31-45c1-a784-c4bbce96610c"), null, "Промышленный образец" },
                    { new Guid("2c8a8f90-1e50-43a0-be44-d50eeb583421"), new Guid("5d31cd93-59d2-4e5d-9698-caeecdfa8345"), null, "Есть" },
                    { new Guid("323be335-e769-4690-8912-4bd6539e47b5"), new Guid("a8eacf85-4d31-45c1-a784-c4bbce96610c"), null, "Изобретение" },
                    { new Guid("38879d4c-0ed0-405a-8886-023916a4c1eb"), new Guid("1c1afe35-4cc2-4536-84c9-aa6dcdec0b2e"), null, "Всероссийский" },
                    { new Guid("39acd1ae-09bd-428d-9015-29b03237ab34"), new Guid("4ccd0150-e2ca-4160-a1fb-57c00a2f3b54"), null, "Исполнитель" },
                    { new Guid("3c35ac46-605b-4c81-9eb7-1b491318c3ff"), new Guid("4d828c4f-cd9e-4805-9d80-edd6faccb5ca"), null, "РИНЦ" },
                    { new Guid("3f59a91e-92c2-471a-8026-0c3bee520eff"), new Guid("5d31cd93-59d2-4e5d-9698-caeecdfa8345"), null, "Нет" },
                    { new Guid("569ff2db-ea7a-45b6-adda-29ceeffd1482"), new Guid("5c04d09a-72b3-4086-8bbc-1428cc3a5fe5"), null, "Изобретение" },
                    { new Guid("575d541a-249a-45f7-a019-7ad211dd7c7a"), new Guid("a8eacf85-4d31-45c1-a784-c4bbce96610c"), null, "Полезная модель" },
                    { new Guid("5c60cea8-f82d-4dee-897c-3aab59498229"), new Guid("aaa35a2e-28e5-48a9-b858-c50bebf7c99d"), null, "Другой" },
                    { new Guid("6a8a741d-e5d3-4ac0-9c54-4bb38766c8fd"), new Guid("113e0e86-f774-4512-8a84-692da1abc9db"), null, "Русский" },
                    { new Guid("6cbfd7c3-6207-45f0-a4f7-e6ad517ab62a"), new Guid("aaa35a2e-28e5-48a9-b858-c50bebf7c99d"), null, "Английский" },
                    { new Guid("72e920e5-06d1-4714-be86-d086ad5915e8"), new Guid("4d828c4f-cd9e-4805-9d80-edd6faccb5ca"), null, "МБД (Q3-Q4)" },
                    { new Guid("752f497e-4e97-41d0-9efa-0a7a6d659480"), new Guid("2f9da356-5025-4835-8690-c89b25ac434d"), null, "Лабораторные" },
                    { new Guid("77c1ec64-360d-4949-ab9f-b6efe32b7b93"), new Guid("a8eacf85-4d31-45c1-a784-c4bbce96610c"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("7d251a00-3a88-4094-8230-9d81aa487f3f"), new Guid("1c1afe35-4cc2-4536-84c9-aa6dcdec0b2e"), null, "Региональный" },
                    { new Guid("88368be0-6b96-4ec9-aea1-2784d324a35a"), new Guid("5c04d09a-72b3-4086-8bbc-1428cc3a5fe5"), null, "Промышленный образец" },
                    { new Guid("885d992a-7923-4e55-a6f2-c615b65c6609"), new Guid("53231167-fc6a-49af-8552-ded0b9c3cbdf"), null, "Учебное и/или учебно-методическое пособие" },
                    { new Guid("902288ec-6e09-4487-bdc2-b7736aabe9f6"), new Guid("113e0e86-f774-4512-8a84-692da1abc9db"), null, "Иностранный" },
                    { new Guid("98e7ffc9-9fbb-44ee-b74a-cf1e6313dd38"), new Guid("af5ff55e-4cba-4d7b-ac22-9467dee92762"), null, "Нет" },
                    { new Guid("9b86502a-51e9-4555-9824-b882c2d4447d"), new Guid("53231167-fc6a-49af-8552-ded0b9c3cbdf"), null, "Монография" },
                    { new Guid("acfa9438-3723-4f0c-9e53-416c9014033e"), new Guid("b1d99c88-de60-4782-980b-bc235262b088"), null, "Нет" },
                    { new Guid("b55ca268-43f5-402b-aa4f-35b3edb76f0b"), new Guid("5c04d09a-72b3-4086-8bbc-1428cc3a5fe5"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("ba40900a-9f0e-4d65-ae40-aba863d790f2"), new Guid("af5ff55e-4cba-4d7b-ac22-9467dee92762"), null, "Есть" },
                    { new Guid("bb28517b-c875-4439-8e9e-26b49f1cfc02"), new Guid("4d828c4f-cd9e-4805-9d80-edd6faccb5ca"), null, "ВАК (К2-К3)" },
                    { new Guid("c5c6f852-e32a-495e-9f00-5ab57ff97429"), new Guid("b1d99c88-de60-4782-980b-bc235262b088"), null, "Есть" },
                    { new Guid("d8e90916-4502-4c86-9e00-bd3b995dbc37"), new Guid("4ccd0150-e2ca-4160-a1fb-57c00a2f3b54"), null, "Руководитель" },
                    { new Guid("de16584c-790d-42f0-9278-f71eca0de8dc"), new Guid("911e324c-bff4-49ae-a68a-3d8a639d6aa0"), null, "Есть" },
                    { new Guid("e20e0bb8-e193-41b0-b933-70b8ae6b3ac0"), new Guid("53231167-fc6a-49af-8552-ded0b9c3cbdf"), null, "Учебник" },
                    { new Guid("ec885007-12bf-45be-aec8-74b96208e6de"), new Guid("4d828c4f-cd9e-4805-9d80-edd6faccb5ca"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("ecf1f9c3-4500-46c9-abee-2eca5eb6e583"), new Guid("5c04d09a-72b3-4086-8bbc-1428cc3a5fe5"), null, "Полезная модель" },
                    { new Guid("f687e3a2-2840-4cb0-88c4-87477b539fab"), new Guid("aaa35a2e-28e5-48a9-b858-c50bebf7c99d"), null, "Русский" },
                    { new Guid("fd85e9dd-41b7-4cdd-b0c6-78fee22a0bb8"), new Guid("2f9da356-5025-4835-8690-c89b25ac434d"), null, "Лекции" },
                    { new Guid("fe30d34a-f10c-41c3-a286-18950ce0050c"), new Guid("1c1afe35-4cc2-4536-84c9-aa6dcdec0b2e"), null, "Международный" }
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
                name: "IX_ApplicationForms_CropPhotoId",
                table: "ApplicationForms",
                column: "CropPhotoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_FullPhotoId",
                table: "ApplicationForms",
                column: "FullPhotoId",
                unique: true);

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
                name: "IX_Photos_ApplicationFormId",
                table: "Photos",
                column: "ApplicationFormId");

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
                name: "IX_UserInfos_ExpertCategoryId",
                table: "UserInfos",
                column: "ExpertCategoryId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationFormExperts_ApplicationForms_ApplicationFormId",
                table: "ApplicationFormExperts",
                column: "ApplicationFormId",
                principalTable: "ApplicationForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationForms_Photos_CropPhotoId",
                table: "ApplicationForms",
                column: "CropPhotoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationForms_Photos_FullPhotoId",
                table: "ApplicationForms",
                column: "FullPhotoId",
                principalTable: "Photos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_ApplicationForms_ApplicationFormId",
                table: "Photos");

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
                name: "Deadlines");

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
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "ValueTypes");

            migrationBuilder.DropTable(
                name: "EditBlocks");

            migrationBuilder.DropTable(
                name: "ApplicationForms");

            migrationBuilder.DropTable(
                name: "ApplicationStatuses");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
