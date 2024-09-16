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
                    { new Guid("15bdff09-2f41-4a33-8f42-008cf7f44323"), 3, "В процессе рассмотрения" },
                    { new Guid("23e4ceeb-cb6a-4b00-ac81-9e5fd144581c"), 1, "В ожидании заполнения" },
                    { new Guid("70056a4a-d954-48ae-94e5-4dc604d714c2"), 5, "Отклонена" },
                    { new Guid("9090f7bd-fe04-4796-b916-b03971883737"), 4, "Одобрена" },
                    { new Guid("c4888c38-4332-462a-9b1e-e8c1f5d28160"), 6, "Оценена" },
                    { new Guid("f751746c-d68a-4caf-b00f-260c4b66aa5c"), 2, "В ожидании рассмотрения" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17ff8f16-2b5c-4a51-a4f8-9ee233d59c64", null, "Admin", "ADMIN" },
                    { "6de0e578-f5b5-4f83-a7c7-6c81f386b91b", null, "Participant", "PARTICIPANT" },
                    { "784c7da8-4c4c-4888-8ce0-a8a2b9650b70", null, "Voter", "VOTER" },
                    { "b5f31e62-48a5-4122-a449-2d35e75dcfa5", null, "Expert", "EXPERT" },
                    { "eb97ac3a-186a-4dad-8f4a-0723da32ad24", null, "Organiser", "ORGANISER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("06d3885b-99f3-4b0a-80ff-1e640c68dcb6"), "Строительство и архитектура", 1 },
                    { new Guid("fbcadfbc-4174-4c15-b4cc-88643d9ce9fd"), "Энергетика и нефтегазовая индустрия", 2 }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("39185585-872e-48fd-8dfe-a730bcc00dfa"), "Категория участников", 2 },
                    { new Guid("5ae5d8f3-743c-4502-8926-fcab6e701868"), "Научно-исследовательская деятельность", 6 },
                    { new Guid("b1be0116-6e19-4b25-adc7-0a183d275226"), "Конкурсная работа", 3 },
                    { new Guid("bbc87a89-806f-45c8-83fd-19ea450508f8"), "Профессиональное развитие", 4 },
                    { new Guid("f39c52a8-7af1-4429-b5b6-6027396f84a7"), "Научно-педагогическая деятельность", 5 },
                    { new Guid("fdfaad8b-05bc-402c-99e2-045a59890d57"), "Общая информация", 1 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("247a2faa-ca2f-49ea-9bea-bf8cf2ab5935"), "Инновационная и иная деятельность", 6 },
                    { new Guid("436dc71a-3c25-427b-b66e-199032819ff3"), "Конкурсная работа", 7 },
                    { new Guid("48f0c93c-efc2-412a-8afa-f890944977cd"), "Образовательная деятельность", 2 },
                    { new Guid("918d62e5-101a-4381-bc2b-6ba60963b6f8"), "Профессиональные показатели", 4 },
                    { new Guid("cd861041-c618-4eb5-b984-e26360308541"), "Методическая деятельность", 3 },
                    { new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b"), "Основной", 1 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("02546362-2506-438d-bce8-9fba563c08c1"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("a0ed8f4c-525f-42d0-b804-fa4ca98108d6"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "ValueTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e"), "string" },
                    { new Guid("a6c33722-7baf-4f97-89b1-9dcb444a0f6d"), "bool" },
                    { new Guid("b2e84f3f-39d2-4095-8ba3-8f8081df77d2"), "DateTime" },
                    { new Guid("f80fb147-79ba-46a4-bb2d-aa4fd594040a"), "TextArea" },
                    { new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c"), "int" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("39185585-872e-48fd-8dfe-a730bcc00dfa"), new Guid("02546362-2506-438d-bce8-9fba563c08c1") },
                    { new Guid("39185585-872e-48fd-8dfe-a730bcc00dfa"), new Guid("a0ed8f4c-525f-42d0-b804-fa4ca98108d6") },
                    { new Guid("5ae5d8f3-743c-4502-8926-fcab6e701868"), new Guid("a0ed8f4c-525f-42d0-b804-fa4ca98108d6") },
                    { new Guid("b1be0116-6e19-4b25-adc7-0a183d275226"), new Guid("02546362-2506-438d-bce8-9fba563c08c1") },
                    { new Guid("b1be0116-6e19-4b25-adc7-0a183d275226"), new Guid("a0ed8f4c-525f-42d0-b804-fa4ca98108d6") },
                    { new Guid("bbc87a89-806f-45c8-83fd-19ea450508f8"), new Guid("02546362-2506-438d-bce8-9fba563c08c1") },
                    { new Guid("bbc87a89-806f-45c8-83fd-19ea450508f8"), new Guid("a0ed8f4c-525f-42d0-b804-fa4ca98108d6") },
                    { new Guid("f39c52a8-7af1-4429-b5b6-6027396f84a7"), new Guid("02546362-2506-438d-bce8-9fba563c08c1") },
                    { new Guid("fdfaad8b-05bc-402c-99e2-045a59890d57"), new Guid("02546362-2506-438d-bce8-9fba563c08c1") },
                    { new Guid("fdfaad8b-05bc-402c-99e2-045a59890d57"), new Guid("a0ed8f4c-525f-42d0-b804-fa4ca98108d6") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "EditGroup", "IsDisplayedOnVotingPage", "IsRequired", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0c67c72c-a795-4169-b57a-1dc9458950a1"), new Guid("fdfaad8b-05bc-402c-99e2-045a59890d57"), null, true, true, "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("22c3d8f8-5e95-49dc-a26b-7411e34b184e"), new Guid("f39c52a8-7af1-4429-b5b6-6027396f84a7"), null, false, true, "Защитившиеся доктора наук", 15, "Введите количество", new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("26672c9c-853a-491d-b9ae-0e70a96c8df3"), new Guid("39185585-872e-48fd-8dfe-a730bcc00dfa"), null, false, true, "Научная специальность (по классификации ВАК)", 13, "Введите научную специальность (по классификации ВАК)", new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("3e59dc62-6c9e-45a2-85f7-f53487b28399"), new Guid("fdfaad8b-05bc-402c-99e2-045a59890d57"), null, false, true, "Адрес работы", 7, "Регион, город, улица, дом", new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("4bffa487-af2f-41e1-a8e5-77bb3e9dc4c8"), new Guid("5ae5d8f3-743c-4502-8926-fcab6e701868"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности", false, true, "Защитившиеся кандидаты наук", 17, "Введите количество", new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("62118df7-e82e-45ac-8127-70ea0b124799"), new Guid("fdfaad8b-05bc-402c-99e2-045a59890d57"), null, true, true, "Место работы", 6, "Название организации", new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("7171d9c3-bbb7-486b-9a1a-72d9326b45b0"), new Guid("fdfaad8b-05bc-402c-99e2-045a59890d57"), null, true, true, "Должность", 9, "Введите свою должность в организации", new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("73e2e3a0-fd29-4120-907d-d10a3a134f46"), new Guid("5ae5d8f3-743c-4502-8926-fcab6e701868"), null, false, true, "Защитившиеся доктора наук", 18, "Введите количество", new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("76c67ebc-ba53-4cdf-a8d6-993ac1e2ae75"), new Guid("39185585-872e-48fd-8dfe-a730bcc00dfa"), null, true, true, "Ученая степень", 12, "Выберите ученую степень", new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("8272df20-4333-4737-af95-9bd909d142e6"), new Guid("fdfaad8b-05bc-402c-99e2-045a59890d57"), null, false, true, "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("86fcc07a-8977-40c7-ad24-84d87e9b581a"), new Guid("f39c52a8-7af1-4429-b5b6-6027396f84a7"), "Руководство дипломными проектами за предыдущий учебный год", false, true, "Защитившиеся бакалавры, специалисты, магистры", 16, "Введите количество", new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("93f91c1c-1711-406b-b550-7bd6fe1b4923"), new Guid("fdfaad8b-05bc-402c-99e2-045a59890d57"), null, false, true, "ФИО", 1, "Иванов Иван Иванович", new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("bc15f554-ecf2-49a2-8a6c-a80090a62f4d"), new Guid("fdfaad8b-05bc-402c-99e2-045a59890d57"), null, false, true, "Дата рождения", 2, "01.01.2000", new Guid("b2e84f3f-39d2-4095-8ba3-8f8081df77d2") },
                    { new Guid("bfdbffde-23eb-4c26-ae16-7c8f240cd8f5"), new Guid("fdfaad8b-05bc-402c-99e2-045a59890d57"), null, true, true, "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("d51e3b09-1071-44d1-be3a-15726cf76ad0"), new Guid("f39c52a8-7af1-4429-b5b6-6027396f84a7"), "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности", false, true, "Защитившиеся кадидаты наук", 14, "Введите количество", new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("e82a3439-a8bb-4e76-b2dc-a6b38358c079"), new Guid("39185585-872e-48fd-8dfe-a730bcc00dfa"), null, true, true, "Ученое звание", 11, "Выберите ученое звание", new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("ecd75cb7-ec2c-40ed-85dd-456e1c68ddf8"), new Guid("fdfaad8b-05bc-402c-99e2-045a59890d57"), null, false, true, "Контактный телефон", 4, "89007005050", new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("efb35c8b-68d6-447f-a5f4-2fadb1ede545"), new Guid("fdfaad8b-05bc-402c-99e2-045a59890d57"), null, false, true, "Электронная почта", 5, "user@example.com", new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("247a2faa-ca2f-49ea-9bea-bf8cf2ab5935"), new Guid("a0ed8f4c-525f-42d0-b804-fa4ca98108d6") },
                    { new Guid("436dc71a-3c25-427b-b66e-199032819ff3"), new Guid("02546362-2506-438d-bce8-9fba563c08c1") },
                    { new Guid("436dc71a-3c25-427b-b66e-199032819ff3"), new Guid("a0ed8f4c-525f-42d0-b804-fa4ca98108d6") },
                    { new Guid("48f0c93c-efc2-412a-8afa-f890944977cd"), new Guid("02546362-2506-438d-bce8-9fba563c08c1") },
                    { new Guid("918d62e5-101a-4381-bc2b-6ba60963b6f8"), new Guid("02546362-2506-438d-bce8-9fba563c08c1") },
                    { new Guid("cd861041-c618-4eb5-b984-e26360308541"), new Guid("02546362-2506-438d-bce8-9fba563c08c1") },
                    { new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5"), new Guid("a0ed8f4c-525f-42d0-b804-fa4ca98108d6") },
                    { new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b"), new Guid("02546362-2506-438d-bce8-9fba563c08c1") },
                    { new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b"), new Guid("a0ed8f4c-525f-42d0-b804-fa4ca98108d6") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "IsDisplayedOnVotingPage", "IsPrefilled", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("176fa4a8-c768-4fe6-8c21-841ea8d460fe"), new Guid("f39c52a8-7af1-4429-b5b6-6027396f84a7"), false, false, "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 9 },
                    { new Guid("2ed4d8d5-00c5-4f6d-a24d-d7e941191cc2"), new Guid("5ae5d8f3-743c-4502-8926-fcab6e701868"), false, false, "Список научных публикаций за последние 5 лет", 10 },
                    { new Guid("345280cc-094d-46c7-829f-ae5108e3d2f1"), new Guid("b1be0116-6e19-4b25-adc7-0a183d275226"), true, true, "Краткая аннотация конкурсной работы", 1 },
                    { new Guid("4a3c03db-540b-4636-bc51-024a54606633"), new Guid("f39c52a8-7af1-4429-b5b6-6027396f84a7"), false, false, "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 5 },
                    { new Guid("4e5fe5c4-8271-45ab-ad40-c1c213a4fa19"), new Guid("f39c52a8-7af1-4429-b5b6-6027396f84a7"), false, false, "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание (победители и призеры всероссийских имеждународных соревнований, конкурсов, олимпиад; лауреаты международных премий, премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), за весь период научно-педагогической деятельности", 6 },
                    { new Guid("6fab2e71-a5ce-4a74-b0da-943afb911e9d"), new Guid("f39c52a8-7af1-4429-b5b6-6027396f84a7"), false, false, "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, либо аналогичных работы на иностранном языке без грифов УМО, изданные типографским способом за последние 5 лет", 7 },
                    { new Guid("845fadf7-ebed-49fc-9bf3-b89a623fe46d"), new Guid("5ae5d8f3-743c-4502-8926-fcab6e701868"), false, false, "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("8751e417-b50a-4c54-a8dd-6f7df5e30e19"), new Guid("5ae5d8f3-743c-4502-8926-fcab6e701868"), false, false, "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("8c137232-6c6d-4d87-9205-837ac5f0c103"), new Guid("bbc87a89-806f-45c8-83fd-19ea450508f8"), false, false, "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период деятельности", 2 },
                    { new Guid("b4238c3b-2d21-4db7-be3d-823f7cf38597"), new Guid("5ae5d8f3-743c-4502-8926-fcab6e701868"), false, false, "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("c7d6ae9f-039b-4522-8032-2dc4b263423b"), new Guid("bbc87a89-806f-45c8-83fd-19ea450508f8"), true, true, "Персональные идентификаторы", 4 },
                    { new Guid("d93a808a-f3e7-4222-85fb-31b9b4e311ec"), new Guid("bbc87a89-806f-45c8-83fd-19ea450508f8"), false, false, "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 3 },
                    { new Guid("e50b6a76-57ac-48c8-9e41-440c76e247c7"), new Guid("f39c52a8-7af1-4429-b5b6-6027396f84a7"), false, false, "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 8 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "IsRequired", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("002848da-02cc-47e8-b683-327bccc98f9b"), false, "Соавторы", 3, new Guid("6fab2e71-a5ce-4a74-b0da-943afb911e9d"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("068f5b7f-fff8-4de3-88e8-454a39f32a52"), true, "Год", 3, new Guid("4e5fe5c4-8271-45ab-ad40-c1c213a4fa19"), new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("0744a374-4c90-4a50-9346-18513be1b14f"), true, "Год", 1, new Guid("8c137232-6c6d-4d87-9205-837ac5f0c103"), new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("0cc6cc71-f620-439b-bde1-eb7f8be536cb"), true, "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("b4238c3b-2d21-4db7-be3d-823f7cf38597"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("17bc0fd8-8709-4fb8-b316-6c06c52ba300"), true, "Наличие грифа", 5, new Guid("6fab2e71-a5ce-4a74-b0da-943afb911e9d"), new Guid("a6c33722-7baf-4f97-89b1-9dcb444a0f6d") },
                    { new Guid("187eabb1-d180-4562-a1d0-6f2daac4ab9a"), true, "Год получения документа", 2, new Guid("d93a808a-f3e7-4222-85fb-31b9b4e311ec"), new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("1c16d553-34ea-46e6-bdc1-8e3284e67e02"), true, "Вид", 1, new Guid("845fadf7-ebed-49fc-9bf3-b89a623fe46d"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("1e0f600f-44c9-435f-b173-0a43b6597554"), true, "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("2ed4d8d5-00c5-4f6d-a24d-d7e941191cc2"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("23e71d55-64cf-431c-86ad-6b194c638a48"), true, "Практические занятия (час.)", 4, new Guid("4a3c03db-540b-4636-bc51-024a54606633"), new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("242af49c-98cd-4013-bd1f-5ee2eba8be8e"), true, "Сумма финансирования (тыс. руб.)", 2, new Guid("b4238c3b-2d21-4db7-be3d-823f7cf38597"), new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("34de21ff-1e3c-436c-8738-818564feafe0"), true, "ФИО", 1, new Guid("4e5fe5c4-8271-45ab-ad40-c1c213a4fa19"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("3832ad10-eead-4c79-951f-79054b2e0969"), false, "Тип идентификатора", 1, new Guid("c7d6ae9f-039b-4522-8032-2dc4b263423b"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("3aba2ba2-6e34-4798-9087-f7ee238f8391"), true, "Название документа, реквизиты", 1, new Guid("d93a808a-f3e7-4222-85fb-31b9b4e311ec"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("4624d6fb-077b-41ba-a2de-cdc974ee9042"), true, "Ссылка", 5, new Guid("8c137232-6c6d-4d87-9205-837ac5f0c103"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("4b537736-6173-4dd3-bd12-c80c1fabb05e"), true, "Название курса", 1, new Guid("176fa4a8-c768-4fe6-8c21-841ea8d460fe"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("4b6a1c6a-32c8-486e-9e4a-a32b0ef12495"), true, "Вид", 2, new Guid("e50b6a76-57ac-48c8-9e41-440c76e247c7"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("5871d657-6497-4afb-b32f-631d0009db88"), true, "Название", 2, new Guid("6fab2e71-a5ce-4a74-b0da-943afb911e9d"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("59a77b87-32d0-4ffe-85f4-73b9655dc5b2"), true, "Статус конкурса", 3, new Guid("8c137232-6c6d-4d87-9205-837ac5f0c103"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("6077c4e6-2384-410a-8303-a6ae7dcaf3e0"), true, "Название разработки", 2, new Guid("845fadf7-ebed-49fc-9bf3-b89a623fe46d"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("60bcb438-ec6d-419d-b838-41151f6044e4"), true, "Год", 4, new Guid("176fa4a8-c768-4fe6-8c21-841ea8d460fe"), new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("67854187-cf76-48a0-8c2b-10e18625d211"), true, "Номер РИД", 4, new Guid("8751e417-b50a-4c54-a8dd-6f7df5e30e19"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("69136a93-a5e9-48aa-a6c5-1d7efb72ef48"), true, "Название организации в которую внедрена разработка", 3, new Guid("845fadf7-ebed-49fc-9bf3-b89a623fe46d"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("6a348dee-4548-4502-ba45-29b0da1e8c78"), true, "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("4e5fe5c4-8271-45ab-ad40-c1c213a4fa19"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("715fd35e-93c5-465c-ae08-fa50e1b1d15d"), true, "Ссылка на платформу", 3, new Guid("176fa4a8-c768-4fe6-8c21-841ea8d460fe"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("76bdd034-0594-4f67-bbed-81334bf69685"), true, "Издательство, год", 6, new Guid("6fab2e71-a5ce-4a74-b0da-943afb911e9d"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("777ba5dc-b8d3-4d80-a7a6-fd3407ffe25f"), true, "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("4e5fe5c4-8271-45ab-ad40-c1c213a4fa19"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("782f0b5a-82ec-4756-96fa-9d19cfc38692"), true, "Название", 2, new Guid("8751e417-b50a-4c54-a8dd-6f7df5e30e19"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("80b5f3a1-56e3-46e4-b835-05696280b2f2"), true, "Значение", 2, new Guid("345280cc-094d-46c7-829f-ae5108e3d2f1"), new Guid("f80fb147-79ba-46a4-bb2d-aa4fd594040a") },
                    { new Guid("85d04e6e-988b-4b3a-842d-d6f0de4f3c90"), true, "Вид", 1, new Guid("8751e417-b50a-4c54-a8dd-6f7df5e30e19"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("8bd2fde0-ad7b-44b7-a078-92aa6ef4db36"), true, "Название НИР/НИОКР", 1, new Guid("b4238c3b-2d21-4db7-be3d-823f7cf38597"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("9597d8d2-d8fc-4b5b-aeec-b081e602f2a8"), true, "Итого (час.)", 5, new Guid("4a3c03db-540b-4636-bc51-024a54606633"), new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("97afb212-ba62-4e98-b181-5e4e32b21472"), true, "Язык преподавания", 2, new Guid("4a3c03db-540b-4636-bc51-024a54606633"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("9fa986d5-108e-4238-9760-559fc90c76db"), true, "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)", 3, new Guid("e50b6a76-57ac-48c8-9e41-440c76e247c7"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("a3ba5c3b-18f5-44f9-b4a6-144d6262d756"), true, "Ссылка на открытый доступ", 8, new Guid("6fab2e71-a5ce-4a74-b0da-943afb911e9d"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("a9750f2f-2741-461b-b8d2-2c8b3460a9e3"), true, "Награда (медаль, диплом с указанием степени)", 4, new Guid("8c137232-6c6d-4d87-9205-837ac5f0c103"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("aab4cd51-e476-48e9-9127-6dc6bd1e326c"), true, "Период выполнения", 3, new Guid("b4238c3b-2d21-4db7-be3d-823f7cf38597"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("b6dd7724-2201-4539-8925-7f47b36052c7"), true, "Издание, год", 4, new Guid("2ed4d8d5-00c5-4f6d-a24d-d7e941191cc2"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("bad58737-d443-48b2-91dd-aa731f41616d"), true, "Название статьи", 1, new Guid("2ed4d8d5-00c5-4f6d-a24d-d7e941191cc2"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("bb190a13-1183-4ca9-99cb-155b8829b8c3"), true, "Лекции (час.)", 3, new Guid("4a3c03db-540b-4636-bc51-024a54606633"), new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("be7a3184-bfe8-4bfb-8c32-7a4d1cd652a0"), false, "Идентификатор", 2, new Guid("c7d6ae9f-039b-4522-8032-2dc4b263423b"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("c14012bc-9f08-4c2a-9d30-131809b78738"), true, "Соавторы", 2, new Guid("176fa4a8-c768-4fe6-8c21-841ea8d460fe"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("c178187f-f7c9-44bb-967e-a7d3f460c012"), true, "Статус", 4, new Guid("b4238c3b-2d21-4db7-be3d-823f7cf38597"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("c7158909-8b4c-47c4-95b8-f8b44039ca0a"), true, "Название конкурса/премии", 2, new Guid("4e5fe5c4-8271-45ab-ad40-c1c213a4fa19"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("c981d7a4-570a-4373-95f9-bedeaf19d91d"), true, "ФИО соавторов", 3, new Guid("8751e417-b50a-4c54-a8dd-6f7df5e30e19"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("cafa3fe1-658c-464b-8cc2-8b33a3e5c05f"), true, "Название", 1, new Guid("345280cc-094d-46c7-829f-ae5108e3d2f1"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("cf4c07fe-ebea-4b86-9a46-aa246d16ea51"), true, "Наименование курса", 1, new Guid("4a3c03db-540b-4636-bc51-024a54606633"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("d312ea6c-3400-4cce-8651-ab9fa393c3e8"), true, "Вид публикации", 1, new Guid("6fab2e71-a5ce-4a74-b0da-943afb911e9d"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("e770e5ed-3f99-42a4-b8bf-57e2308e4ca3"), true, "Количество печатных листов", 4, new Guid("6fab2e71-a5ce-4a74-b0da-943afb911e9d"), new Guid("fda64a1e-40b8-4a48-9206-57eadcb8f58c") },
                    { new Guid("e926f4a4-6d10-4c8e-aae4-fa2fec0bd9a5"), true, "Название дисциплины", 1, new Guid("e50b6a76-57ac-48c8-9e41-440c76e247c7"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("e9b4b679-41c8-4820-beff-ac0fe937e4c7"), true, "Соавторы", 2, new Guid("2ed4d8d5-00c5-4f6d-a24d-d7e941191cc2"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("f5119515-db4e-425c-b94d-7ea5c258a023"), true, "Название конкурса", 2, new Guid("8c137232-6c6d-4d87-9205-837ac5f0c103"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") },
                    { new Guid("f7329cd5-e214-4c5a-b30b-a9f6f44d498d"), true, "Язык публикации", 7, new Guid("6fab2e71-a5ce-4a74-b0da-943afb911e9d"), new Guid("a0792259-8080-4d40-bda2-0a9fd8e5561e") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("0c67c72c-a795-4169-b57a-1dc9458950a1"), new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b") },
                    { new Guid("22c3d8f8-5e95-49dc-a26b-7411e34b184e"), new Guid("48f0c93c-efc2-412a-8afa-f890944977cd") },
                    { new Guid("26672c9c-853a-491d-b9ae-0e70a96c8df3"), new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b") },
                    { new Guid("3e59dc62-6c9e-45a2-85f7-f53487b28399"), new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b") },
                    { new Guid("4bffa487-af2f-41e1-a8e5-77bb3e9dc4c8"), new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5") },
                    { new Guid("62118df7-e82e-45ac-8127-70ea0b124799"), new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b") },
                    { new Guid("7171d9c3-bbb7-486b-9a1a-72d9326b45b0"), new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b") },
                    { new Guid("73e2e3a0-fd29-4120-907d-d10a3a134f46"), new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5") },
                    { new Guid("76c67ebc-ba53-4cdf-a8d6-993ac1e2ae75"), new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b") },
                    { new Guid("8272df20-4333-4737-af95-9bd909d142e6"), new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b") },
                    { new Guid("86fcc07a-8977-40c7-ad24-84d87e9b581a"), new Guid("48f0c93c-efc2-412a-8afa-f890944977cd") },
                    { new Guid("93f91c1c-1711-406b-b550-7bd6fe1b4923"), new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b") },
                    { new Guid("bc15f554-ecf2-49a2-8a6c-a80090a62f4d"), new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b") },
                    { new Guid("bfdbffde-23eb-4c26-ae16-7c8f240cd8f5"), new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b") },
                    { new Guid("d51e3b09-1071-44d1-be3a-15726cf76ad0"), new Guid("48f0c93c-efc2-412a-8afa-f890944977cd") },
                    { new Guid("e82a3439-a8bb-4e76-b2dc-a6b38358c079"), new Guid("918d62e5-101a-4381-bc2b-6ba60963b6f8") },
                    { new Guid("e82a3439-a8bb-4e76-b2dc-a6b38358c079"), new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5") },
                    { new Guid("e82a3439-a8bb-4e76-b2dc-a6b38358c079"), new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b") },
                    { new Guid("ecd75cb7-ec2c-40ed-85dd-456e1c68ddf8"), new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b") },
                    { new Guid("efb35c8b-68d6-447f-a5f4-2fadb1ede545"), new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("247a2faa-ca2f-49ea-9bea-bf8cf2ab5935"), new Guid("845fadf7-ebed-49fc-9bf3-b89a623fe46d") },
                    { new Guid("247a2faa-ca2f-49ea-9bea-bf8cf2ab5935"), new Guid("8751e417-b50a-4c54-a8dd-6f7df5e30e19") },
                    { new Guid("247a2faa-ca2f-49ea-9bea-bf8cf2ab5935"), new Guid("d93a808a-f3e7-4222-85fb-31b9b4e311ec") },
                    { new Guid("436dc71a-3c25-427b-b66e-199032819ff3"), new Guid("345280cc-094d-46c7-829f-ae5108e3d2f1") },
                    { new Guid("48f0c93c-efc2-412a-8afa-f890944977cd"), new Guid("176fa4a8-c768-4fe6-8c21-841ea8d460fe") },
                    { new Guid("48f0c93c-efc2-412a-8afa-f890944977cd"), new Guid("4a3c03db-540b-4636-bc51-024a54606633") },
                    { new Guid("48f0c93c-efc2-412a-8afa-f890944977cd"), new Guid("4e5fe5c4-8271-45ab-ad40-c1c213a4fa19") },
                    { new Guid("918d62e5-101a-4381-bc2b-6ba60963b6f8"), new Guid("8c137232-6c6d-4d87-9205-837ac5f0c103") },
                    { new Guid("918d62e5-101a-4381-bc2b-6ba60963b6f8"), new Guid("d93a808a-f3e7-4222-85fb-31b9b4e311ec") },
                    { new Guid("cd861041-c618-4eb5-b984-e26360308541"), new Guid("6fab2e71-a5ce-4a74-b0da-943afb911e9d") },
                    { new Guid("cd861041-c618-4eb5-b984-e26360308541"), new Guid("e50b6a76-57ac-48c8-9e41-440c76e247c7") },
                    { new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5"), new Guid("2ed4d8d5-00c5-4f6d-a24d-d7e941191cc2") },
                    { new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5"), new Guid("8c137232-6c6d-4d87-9205-837ac5f0c103") },
                    { new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5"), new Guid("b4238c3b-2d21-4db7-be3d-823f7cf38597") },
                    { new Guid("f6d0473e-bba7-43da-a5ef-ea6a9c42d52b"), new Guid("c7d6ae9f-039b-4522-8032-2dc4b263423b") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "EvaluationMethodName", "FieldId", "IsAuto", "MaxValue", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("17ccbf23-5db5-41c1-99d1-b096338b3142"), "EvaluateMark12", null, true, 4, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("e50b6a76-57ac-48c8-9e41-440c76e247c7") },
                    { new Guid("1efa9478-d824-4dd3-b4c1-9b90e44109cc"), "EvaluateMark13", new Guid("e82a3439-a8bb-4e76-b2dc-a6b38358c079"), true, 5, "Баллы за ученое звание:", 13, null },
                    { new Guid("22e26cf6-4d01-4e6d-a0af-b5a110f0679d"), "EvaluateMark2", null, true, 2, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("4a3c03db-540b-4636-bc51-024a54606633") },
                    { new Guid("2abda31b-79b4-457b-bfbd-74c90201c78f"), "EvaluateMark20", new Guid("73e2e3a0-fd29-4120-907d-d10a3a134f46"), true, 12, "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("31795f5d-481b-4261-9315-dee9abc06973"), "EvaluateMark21", null, true, 8, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("b4238c3b-2d21-4db7-be3d-823f7cf38597") },
                    { new Guid("3b4eba93-049b-4479-bb5a-2d25191c4207"), null, null, false, 15, "Оценка уровня предоставленной работы:", 25, new Guid("345280cc-094d-46c7-829f-ae5108e3d2f1") },
                    { new Guid("4a78ad53-6a6d-4101-95ce-7e2a3b6ae542"), "EvaluateMark24", null, true, 5, "Баллы за количество разработок:", 24, new Guid("845fadf7-ebed-49fc-9bf3-b89a623fe46d") },
                    { new Guid("52e53484-d91f-4eeb-ac60-949fe7e473d2"), "EvaluateMark3", new Guid("86fcc07a-8977-40c7-ad24-84d87e9b581a"), true, 5, "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("57f5ab5d-5de5-48aa-b584-282f1f64e97c"), "EvaluateMark4", new Guid("d51e3b09-1071-44d1-be3a-15726cf76ad0"), true, 6, "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("587aa02d-7f5f-485c-aac4-18e4bd68e01b"), "EvaluateMark22", null, true, 5, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("b4238c3b-2d21-4db7-be3d-823f7cf38597") },
                    { new Guid("6226987f-3812-41e1-95fc-86552af0838f"), "EvaluateMark10", null, true, 2, "Баллы за труды без грифа и без соавторства:", 10, new Guid("6fab2e71-a5ce-4a74-b0da-943afb911e9d") },
                    { new Guid("816ad20d-9e70-4cfd-b023-028c13db7739"), null, null, false, 15, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, new Guid("345280cc-094d-46c7-829f-ae5108e3d2f1") },
                    { new Guid("82ec164f-c08d-410b-9714-5c9ee17d9ddd"), "EvaluateMark16", null, true, 8, "Баллы за научные публикации:", 16, new Guid("2ed4d8d5-00c5-4f6d-a24d-d7e941191cc2") },
                    { new Guid("8e2c0f76-1d05-4459-81fb-7527be90c212"), "EvaluateMark23", null, true, 5, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("8751e417-b50a-4c54-a8dd-6f7df5e30e19") },
                    { new Guid("93660b1f-6705-41fa-84ee-b36ecae2145d"), "EvaluateMark7", null, true, 5, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("176fa4a8-c768-4fe6-8c21-841ea8d460fe") },
                    { new Guid("96696db0-d3a2-4c56-ab64-dba760ed505c"), "EvaluateMark14", null, true, 2, "Баллы за награды:", 14, new Guid("8c137232-6c6d-4d87-9205-837ac5f0c103") },
                    { new Guid("bee4fd1d-4f0e-45eb-bb3c-943edd537c6e"), "EvaluateMark19", new Guid("4bffa487-af2f-41e1-a8e5-77bb3e9dc4c8"), true, 8, "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("c01bfee8-80a5-435a-a896-e032cb40f931"), "EvaluateMark8", null, true, 4, "Баллы за труды с грифом или на иностранном языке и без соавторства:", 8, new Guid("6fab2e71-a5ce-4a74-b0da-943afb911e9d") },
                    { new Guid("c98a58eb-4989-4785-8a9f-861f4266d7b2"), "EvaluateMark5", new Guid("22c3d8f8-5e95-49dc-a26b-7411e34b184e"), true, 10, "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("d240f796-d88e-439a-b715-589bbc806c75"), "EvaluateMark15", null, true, 2, "Баллы за профессиональное развитие:", 15, new Guid("d93a808a-f3e7-4222-85fb-31b9b4e311ec") },
                    { new Guid("d439fee0-8b9f-4be5-aa39-87f3d2947bac"), "EvaluateMark6", null, true, 5, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("4e5fe5c4-8271-45ab-ad40-c1c213a4fa19") },
                    { new Guid("ecf8870e-8ac9-4051-bce9-9d660ee12ca6"), "EvaluateMark1", null, true, 3, "Баллы за объем учебной нагрузки:", 1, new Guid("4a3c03db-540b-4636-bc51-024a54606633") },
                    { new Guid("f31caf46-91bd-4808-a1b5-7296b6e34e1e"), "EvaluateMark11", null, true, 2, "Баллы за труды без грифа в соавторстве:", 11, new Guid("6fab2e71-a5ce-4a74-b0da-943afb911e9d") },
                    { new Guid("f5c3d414-0c52-4288-af7d-6b5c20a3cdd3"), "EvaluateMark9", null, true, 3, "Баллы за труды с грифом или на иностранном языке в соавторстве:", 9, new Guid("6fab2e71-a5ce-4a74-b0da-943afb911e9d") }
                });

            migrationBuilder.InsertData(
                table: "Rows",
                columns: new[] { "Id", "IsPrefilled", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0872c6d7-58d8-4fb3-8a0c-e0ef6425e04c"), true, 1, new Guid("c7d6ae9f-039b-4522-8032-2dc4b263423b") },
                    { new Guid("25b03951-6c96-4724-97e9-698a582ef2cc"), true, 5, new Guid("c7d6ae9f-039b-4522-8032-2dc4b263423b") },
                    { new Guid("2f397329-9682-4288-b4e3-e2dadb47fba4"), true, 2, new Guid("345280cc-094d-46c7-829f-ae5108e3d2f1") },
                    { new Guid("512a09bd-de08-4e59-9cba-ed74598ccdb9"), true, 3, new Guid("c7d6ae9f-039b-4522-8032-2dc4b263423b") },
                    { new Guid("56ef4fa7-0e82-4c0e-aab3-aac968f7d6f2"), true, 4, new Guid("345280cc-094d-46c7-829f-ae5108e3d2f1") },
                    { new Guid("69e85837-83ea-4325-8f78-e0ec5876b69a"), true, 1, new Guid("345280cc-094d-46c7-829f-ae5108e3d2f1") },
                    { new Guid("75093c79-7dcb-4f4f-af57-66021c17ba19"), true, 2, new Guid("c7d6ae9f-039b-4522-8032-2dc4b263423b") },
                    { new Guid("7e11f0a2-4847-4a04-a01d-8384b615979c"), true, 4, new Guid("c7d6ae9f-039b-4522-8032-2dc4b263423b") },
                    { new Guid("7e150b90-a889-42cd-b307-528ca1cf16bf"), true, 5, new Guid("345280cc-094d-46c7-829f-ae5108e3d2f1") },
                    { new Guid("88450214-83a9-4ae2-8e67-44e9bb0370ad"), true, 7, new Guid("345280cc-094d-46c7-829f-ae5108e3d2f1") },
                    { new Guid("958c35e7-9e28-41e4-aedc-ec8aeca82564"), true, 6, new Guid("345280cc-094d-46c7-829f-ae5108e3d2f1") },
                    { new Guid("a324c1e5-f95e-43f5-8666-bca89c9c93af"), true, 3, new Guid("345280cc-094d-46c7-829f-ae5108e3d2f1") },
                    { new Guid("b690efc5-ce08-4729-964b-de9b65441f2b"), true, 8, new Guid("345280cc-094d-46c7-829f-ae5108e3d2f1") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("2ce40fc6-f2aa-44b6-b023-c8c3e566d818"), null, new Guid("e82a3439-a8bb-4e76-b2dc-a6b38358c079"), "Нет" },
                    { new Guid("3515eb34-676a-4c14-adc1-b8ab35b53f5d"), null, new Guid("76c67ebc-ba53-4cdf-a8d6-993ac1e2ae75"), "Кандидат наук" },
                    { new Guid("b2c02d6b-d625-46bc-bcfd-a8b6ea91fc82"), null, new Guid("76c67ebc-ba53-4cdf-a8d6-993ac1e2ae75"), "Доктор наук" },
                    { new Guid("e662a144-8876-4d51-8274-377d90694706"), null, new Guid("e82a3439-a8bb-4e76-b2dc-a6b38358c079"), "Профессор" },
                    { new Guid("fe86445a-f893-49b9-96c5-e83ab75a92a0"), null, new Guid("e82a3439-a8bb-4e76-b2dc-a6b38358c079"), "Доцент" }
                });

            migrationBuilder.InsertData(
                table: "CellVals",
                columns: new[] { "Id", "ApplicationId", "ColumnId", "Disable", "IsPrefilled", "RowId", "Value" },
                values: new object[,]
                {
                    { new Guid("0e92d2df-07db-4eba-8909-95eb5aa29a7b"), null, new Guid("80b5f3a1-56e3-46e4-b835-05696280b2f2"), false, true, new Guid("69e85837-83ea-4325-8f78-e0ec5876b69a"), null },
                    { new Guid("1b5f00ae-b4db-418f-9372-c05a174550d7"), null, new Guid("3832ad10-eead-4c79-951f-79054b2e0969"), true, true, new Guid("0872c6d7-58d8-4fb3-8a0c-e0ef6425e04c"), "ScopusID" },
                    { new Guid("20484dc2-fd23-4c7e-8ed7-eda29f53a70a"), null, new Guid("80b5f3a1-56e3-46e4-b835-05696280b2f2"), false, true, new Guid("88450214-83a9-4ae2-8e67-44e9bb0370ad"), null },
                    { new Guid("21a334e7-f8ef-45d0-b5f4-e9b0574c6b61"), null, new Guid("be7a3184-bfe8-4bfb-8c32-7a4d1cd652a0"), false, true, new Guid("7e11f0a2-4847-4a04-a01d-8384b615979c"), null },
                    { new Guid("21b93331-9dc0-4b0b-9e86-51086f965c4e"), null, new Guid("80b5f3a1-56e3-46e4-b835-05696280b2f2"), false, true, new Guid("7e150b90-a889-42cd-b307-528ca1cf16bf"), null },
                    { new Guid("22d3b55e-f0de-4a04-a7ad-68e5756c0ffa"), null, new Guid("3832ad10-eead-4c79-951f-79054b2e0969"), true, true, new Guid("75093c79-7dcb-4f4f-af57-66021c17ba19"), "ORCiD" },
                    { new Guid("2cb6bc7c-4f9c-42f0-8b89-bf282cbbfc41"), null, new Guid("cafa3fe1-658c-464b-8cc2-8b33a3e5c05f"), true, true, new Guid("56ef4fa7-0e82-4c0e-aab3-aac968f7d6f2"), "Методология и методы, используемые в работе" },
                    { new Guid("2f38b0b0-7594-49ee-91c1-aff79b2a0d6c"), null, new Guid("be7a3184-bfe8-4bfb-8c32-7a4d1cd652a0"), false, true, new Guid("0872c6d7-58d8-4fb3-8a0c-e0ef6425e04c"), null },
                    { new Guid("306e39ff-b1f4-46ad-94ca-73c0d6813795"), null, new Guid("cafa3fe1-658c-464b-8cc2-8b33a3e5c05f"), true, true, new Guid("a324c1e5-f95e-43f5-8666-bca89c9c93af"), "Инновационность" },
                    { new Guid("30b142dc-a637-4dc8-b296-a17e17cb6c81"), null, new Guid("80b5f3a1-56e3-46e4-b835-05696280b2f2"), false, true, new Guid("2f397329-9682-4288-b4e3-e2dadb47fba4"), null },
                    { new Guid("4855e743-107f-4616-a393-ec9372ba1188"), null, new Guid("be7a3184-bfe8-4bfb-8c32-7a4d1cd652a0"), false, true, new Guid("75093c79-7dcb-4f4f-af57-66021c17ba19"), null },
                    { new Guid("5b755315-ca1f-4771-aa3a-4c2fd5147966"), null, new Guid("cafa3fe1-658c-464b-8cc2-8b33a3e5c05f"), true, true, new Guid("7e150b90-a889-42cd-b307-528ca1cf16bf"), "Ссылка на конкурсную работу" },
                    { new Guid("636cd541-eff1-4aa5-979c-96444689aac8"), null, new Guid("be7a3184-bfe8-4bfb-8c32-7a4d1cd652a0"), false, true, new Guid("25b03951-6c96-4724-97e9-698a582ef2cc"), null },
                    { new Guid("66e424e3-a257-442d-bf7f-a448d51e6b15"), null, new Guid("cafa3fe1-658c-464b-8cc2-8b33a3e5c05f"), true, true, new Guid("b690efc5-ce08-4729-964b-de9b65441f2b"), "Результаты и выводы" },
                    { new Guid("71173064-0ed3-42a2-9ef6-4b7dc5d9f16d"), null, new Guid("80b5f3a1-56e3-46e4-b835-05696280b2f2"), false, true, new Guid("958c35e7-9e28-41e4-aedc-ec8aeca82564"), null },
                    { new Guid("859fdff1-6d07-4cdd-80b5-bc428d54a450"), null, new Guid("80b5f3a1-56e3-46e4-b835-05696280b2f2"), false, true, new Guid("56ef4fa7-0e82-4c0e-aab3-aac968f7d6f2"), null },
                    { new Guid("8d113c40-0fe6-4557-b52d-8782eec407d7"), null, new Guid("80b5f3a1-56e3-46e4-b835-05696280b2f2"), false, true, new Guid("a324c1e5-f95e-43f5-8666-bca89c9c93af"), null },
                    { new Guid("8f04d59d-a60f-4f1f-9274-4303cadb1c61"), null, new Guid("3832ad10-eead-4c79-951f-79054b2e0969"), true, true, new Guid("25b03951-6c96-4724-97e9-698a582ef2cc"), "Google Scholar ID" },
                    { new Guid("a195ba4a-d144-4402-a09d-788c43a386d2"), null, new Guid("80b5f3a1-56e3-46e4-b835-05696280b2f2"), false, true, new Guid("b690efc5-ce08-4729-964b-de9b65441f2b"), null },
                    { new Guid("a3e33ea1-636d-4eda-b55c-f80a35a92704"), null, new Guid("cafa3fe1-658c-464b-8cc2-8b33a3e5c05f"), true, true, new Guid("958c35e7-9e28-41e4-aedc-ec8aeca82564"), "Апробация" },
                    { new Guid("c597d4a6-f14a-41e7-814e-94ce9e821220"), null, new Guid("3832ad10-eead-4c79-951f-79054b2e0969"), true, true, new Guid("512a09bd-de08-4e59-9cba-ed74598ccdb9"), "ResearcherID" },
                    { new Guid("c94162ee-beb6-4745-b924-9a03d6452540"), null, new Guid("cafa3fe1-658c-464b-8cc2-8b33a3e5c05f"), true, true, new Guid("69e85837-83ea-4325-8f78-e0ec5876b69a"), "Название работы" },
                    { new Guid("e09dcc2e-d98e-488b-a184-0d7fc0da2ae6"), null, new Guid("cafa3fe1-658c-464b-8cc2-8b33a3e5c05f"), true, true, new Guid("2f397329-9682-4288-b4e3-e2dadb47fba4"), "Актуальность конкурсной работы" },
                    { new Guid("f88ab08d-e4d6-4191-a466-5144b20f1acf"), null, new Guid("cafa3fe1-658c-464b-8cc2-8b33a3e5c05f"), true, true, new Guid("88450214-83a9-4ae2-8e67-44e9bb0370ad"), "Рекомендации и перспективы дальнейшей разработки темы" },
                    { new Guid("f8b0b039-22c1-4471-9bf7-e7b2a05b7351"), null, new Guid("be7a3184-bfe8-4bfb-8c32-7a4d1cd652a0"), false, true, new Guid("512a09bd-de08-4e59-9cba-ed74598ccdb9"), null },
                    { new Guid("fce61393-1296-4a50-abae-879236162e0f"), null, new Guid("3832ad10-eead-4c79-951f-79054b2e0969"), true, true, new Guid("7e11f0a2-4847-4a04-a01d-8384b615979c"), "РИНЦ AuthorID" }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("247a2faa-ca2f-49ea-9bea-bf8cf2ab5935"), new Guid("4a78ad53-6a6d-4101-95ce-7e2a3b6ae542") },
                    { new Guid("247a2faa-ca2f-49ea-9bea-bf8cf2ab5935"), new Guid("8e2c0f76-1d05-4459-81fb-7527be90c212") },
                    { new Guid("247a2faa-ca2f-49ea-9bea-bf8cf2ab5935"), new Guid("d240f796-d88e-439a-b715-589bbc806c75") },
                    { new Guid("436dc71a-3c25-427b-b66e-199032819ff3"), new Guid("3b4eba93-049b-4479-bb5a-2d25191c4207") },
                    { new Guid("436dc71a-3c25-427b-b66e-199032819ff3"), new Guid("816ad20d-9e70-4cfd-b023-028c13db7739") },
                    { new Guid("48f0c93c-efc2-412a-8afa-f890944977cd"), new Guid("22e26cf6-4d01-4e6d-a0af-b5a110f0679d") },
                    { new Guid("48f0c93c-efc2-412a-8afa-f890944977cd"), new Guid("52e53484-d91f-4eeb-ac60-949fe7e473d2") },
                    { new Guid("48f0c93c-efc2-412a-8afa-f890944977cd"), new Guid("57f5ab5d-5de5-48aa-b584-282f1f64e97c") },
                    { new Guid("48f0c93c-efc2-412a-8afa-f890944977cd"), new Guid("93660b1f-6705-41fa-84ee-b36ecae2145d") },
                    { new Guid("48f0c93c-efc2-412a-8afa-f890944977cd"), new Guid("c98a58eb-4989-4785-8a9f-861f4266d7b2") },
                    { new Guid("48f0c93c-efc2-412a-8afa-f890944977cd"), new Guid("d439fee0-8b9f-4be5-aa39-87f3d2947bac") },
                    { new Guid("48f0c93c-efc2-412a-8afa-f890944977cd"), new Guid("ecf8870e-8ac9-4051-bce9-9d660ee12ca6") },
                    { new Guid("918d62e5-101a-4381-bc2b-6ba60963b6f8"), new Guid("1efa9478-d824-4dd3-b4c1-9b90e44109cc") },
                    { new Guid("918d62e5-101a-4381-bc2b-6ba60963b6f8"), new Guid("96696db0-d3a2-4c56-ab64-dba760ed505c") },
                    { new Guid("918d62e5-101a-4381-bc2b-6ba60963b6f8"), new Guid("d240f796-d88e-439a-b715-589bbc806c75") },
                    { new Guid("cd861041-c618-4eb5-b984-e26360308541"), new Guid("17ccbf23-5db5-41c1-99d1-b096338b3142") },
                    { new Guid("cd861041-c618-4eb5-b984-e26360308541"), new Guid("6226987f-3812-41e1-95fc-86552af0838f") },
                    { new Guid("cd861041-c618-4eb5-b984-e26360308541"), new Guid("c01bfee8-80a5-435a-a896-e032cb40f931") },
                    { new Guid("cd861041-c618-4eb5-b984-e26360308541"), new Guid("f31caf46-91bd-4808-a1b5-7296b6e34e1e") },
                    { new Guid("cd861041-c618-4eb5-b984-e26360308541"), new Guid("f5c3d414-0c52-4288-af7d-6b5c20a3cdd3") },
                    { new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5"), new Guid("1efa9478-d824-4dd3-b4c1-9b90e44109cc") },
                    { new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5"), new Guid("2abda31b-79b4-457b-bfbd-74c90201c78f") },
                    { new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5"), new Guid("31795f5d-481b-4261-9315-dee9abc06973") },
                    { new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5"), new Guid("587aa02d-7f5f-485c-aac4-18e4bd68e01b") },
                    { new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5"), new Guid("82ec164f-c08d-410b-9714-5c9ee17d9ddd") },
                    { new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5"), new Guid("96696db0-d3a2-4c56-ab64-dba760ed505c") },
                    { new Guid("ed8e34d0-b569-4e96-abb3-afce9ceea9c5"), new Guid("bee4fd1d-4f0e-45eb-bb3c-943edd537c6e") }
                });

            migrationBuilder.InsertData(
                table: "SelectValues",
                columns: new[] { "Id", "ColumnId", "FieldId", "Value" },
                values: new object[,]
                {
                    { new Guid("0aa67e5b-1f88-484d-9cee-e32f4d887daa"), new Guid("85d04e6e-988b-4b3a-842d-d6f0de4f3c90"), null, "Промышленный образец" },
                    { new Guid("0b3e50fc-7fe9-4ae3-b3d2-c3766d1cf9d2"), new Guid("1c16d553-34ea-46e6-bdc1-8e3284e67e02"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("1a03276d-8675-4b1f-92d1-4e7a46980396"), new Guid("1c16d553-34ea-46e6-bdc1-8e3284e67e02"), null, "Полезная модель" },
                    { new Guid("30076e2f-9e64-4132-8fc4-c8f4ebf4e059"), new Guid("c178187f-f7c9-44bb-967e-a7d3f460c012"), null, "Руководитель" },
                    { new Guid("3e18cbe4-2572-46ab-a2a0-7026fb97cf05"), new Guid("1c16d553-34ea-46e6-bdc1-8e3284e67e02"), null, "Промышленный образец" },
                    { new Guid("41ff8d4d-2ac4-40ee-9599-8687e8383897"), new Guid("d312ea6c-3400-4cce-8651-ab9fa393c3e8"), null, "Монография" },
                    { new Guid("49c3fdb8-54d4-4550-a863-8d9349f3dad1"), new Guid("e9b4b679-41c8-4820-beff-ac0fe937e4c7"), null, "Есть" },
                    { new Guid("4c0f931c-a78a-4c10-b23d-7009740a76c5"), new Guid("97afb212-ba62-4e98-b181-5e4e32b21472"), null, "Другой" },
                    { new Guid("4cdba399-1e0d-4ee0-a99f-3864a178fb3c"), new Guid("e9b4b679-41c8-4820-beff-ac0fe937e4c7"), null, "Нет" },
                    { new Guid("4f9c7e76-cc64-4a53-8c1f-1e2f785139b6"), new Guid("1e0f600f-44c9-435f-b173-0a43b6597554"), null, "ВАК (К1), МБД (Q1-Q2)" },
                    { new Guid("5dae0be7-21c6-4072-b892-3d4ec5809137"), new Guid("59a77b87-32d0-4ffe-85f4-73b9655dc5b2"), null, "Всероссийский" },
                    { new Guid("7a2c9c14-83b9-44ff-b48d-5e10c65ada74"), new Guid("85d04e6e-988b-4b3a-842d-d6f0de4f3c90"), null, "Полезная модель" },
                    { new Guid("7ea8c0c8-0606-47b8-baa1-c3c7e83ab4bc"), new Guid("59a77b87-32d0-4ffe-85f4-73b9655dc5b2"), null, "Региональный" },
                    { new Guid("8188564b-e8a3-456d-bafc-0f8c68e9b62b"), new Guid("c14012bc-9f08-4c2a-9d30-131809b78738"), null, "Есть" },
                    { new Guid("8cafd03b-364e-4b1d-9868-511ee929bfb0"), new Guid("97afb212-ba62-4e98-b181-5e4e32b21472"), null, "Английский" },
                    { new Guid("90eda8f9-a66d-49db-8d08-0a25ed4bcab8"), new Guid("17bc0fd8-8709-4fb8-b316-6c06c52ba300"), null, "Нет" },
                    { new Guid("952704d2-575e-4621-90d3-09683a56533b"), new Guid("97afb212-ba62-4e98-b181-5e4e32b21472"), null, "Русский" },
                    { new Guid("9845b955-b0c6-48f5-a44a-2aefb8d778b3"), new Guid("1e0f600f-44c9-435f-b173-0a43b6597554"), null, "МБД (Q3-Q4)" },
                    { new Guid("9acfb964-178d-4c09-baf1-13e3db06763f"), new Guid("c14012bc-9f08-4c2a-9d30-131809b78738"), null, "Нет" },
                    { new Guid("a2028890-c2e0-4547-b006-1d3cfa5c387a"), new Guid("1c16d553-34ea-46e6-bdc1-8e3284e67e02"), null, "Изобретение" },
                    { new Guid("a2c4376c-1764-4b46-8d26-749be72f05ea"), new Guid("4b6a1c6a-32c8-486e-9e4a-a32b0ef12495"), null, "Лекции" },
                    { new Guid("a5168a43-384b-42dd-b22c-c38688cf523d"), new Guid("1e0f600f-44c9-435f-b173-0a43b6597554"), null, "РИНЦ" },
                    { new Guid("a7c8e0ec-59fb-4ad0-9cae-e71b3d4f3607"), new Guid("002848da-02cc-47e8-b683-327bccc98f9b"), null, "Есть" },
                    { new Guid("aa776088-4f91-427b-ad18-f8a1d6dbb7b9"), new Guid("85d04e6e-988b-4b3a-842d-d6f0de4f3c90"), null, "Программы для ЭВМ и базы данных" },
                    { new Guid("af5eac1e-9398-4cdf-901b-f235d7ba139e"), new Guid("c178187f-f7c9-44bb-967e-a7d3f460c012"), null, "Исполнитель" },
                    { new Guid("b51d650d-a05f-4eb1-bc52-e4575cd3af1f"), new Guid("002848da-02cc-47e8-b683-327bccc98f9b"), null, "Нет" },
                    { new Guid("b9cea93d-5e77-4c5b-80cd-ab79b6573298"), new Guid("85d04e6e-988b-4b3a-842d-d6f0de4f3c90"), null, "Изобретение" },
                    { new Guid("bf222500-2859-4176-a0cb-374055fa1b38"), new Guid("1e0f600f-44c9-435f-b173-0a43b6597554"), null, "ВАК (К2-К3)" },
                    { new Guid("d455eaad-f149-4091-baf4-a519c55c4097"), new Guid("4b6a1c6a-32c8-486e-9e4a-a32b0ef12495"), null, "Лабораторные" },
                    { new Guid("d64e5ff9-1a92-4937-8c40-503afb1cf95d"), new Guid("d312ea6c-3400-4cce-8651-ab9fa393c3e8"), null, "Учебник" },
                    { new Guid("e9144639-19da-4ea2-a202-38692dcc07c8"), new Guid("f7329cd5-e214-4c5a-b30b-a9f6f44d498d"), null, "Русский" },
                    { new Guid("ebeac66b-ed52-45d0-92e6-95755021c5f7"), new Guid("17bc0fd8-8709-4fb8-b316-6c06c52ba300"), null, "Есть" },
                    { new Guid("f736ec3c-069b-4413-a3e6-a6d33a85d44e"), new Guid("f7329cd5-e214-4c5a-b30b-a9f6f44d498d"), null, "Иностранный" },
                    { new Guid("fe94c197-6dfc-4615-bba7-10b5ba7b14ba"), new Guid("59a77b87-32d0-4ffe-85f4-73b9655dc5b2"), null, "Международный" },
                    { new Guid("ff6a9021-15e2-4d0b-89f3-a7d3c027ef24"), new Guid("d312ea6c-3400-4cce-8651-ab9fa393c3e8"), null, "Учебное и/или учебно-методическое пособие" }
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
