using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DataTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EditBlocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditBlocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarkBlocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkBlocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "Fields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 400, nullable: true),
                    Placeholder = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ValueTypeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    EditBlockId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fields_DataTypes_ValueTypeId",
                        column: x => x.ValueTypeId,
                        principalTable: "DataTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fields_EditBlocks_EditBlockId",
                        column: x => x.EditBlockId,
                        principalTable: "EditBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    EditBlockId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                    EditBlocksId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TracksId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                    MarkBlocksId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TracksId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserInfoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TrackId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationForms_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationForms_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FieldMarkBlock",
                columns: table => new
                {
                    FieldsId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MarkBlocksId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                name: "Columns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ValueTypeId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TableId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Columns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Columns_DataTypes_ValueTypeId",
                        column: x => x.ValueTypeId,
                        principalTable: "DataTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Columns_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MarkBlockTable",
                columns: table => new
                {
                    MarkBlocksId = table.Column<Guid>(type: "TEXT", nullable: false),
                    TablesId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    FieldId = table.Column<Guid>(type: "TEXT", nullable: true),
                    TableId = table.Column<Guid>(type: "TEXT", nullable: true)
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
                name: "Rows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TableId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                name: "FieldVals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ApplicationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    FieldId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                name: "MarkMarkBlock",
                columns: table => new
                {
                    MarkBlocksId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MarksId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Value = table.Column<int>(type: "INTEGER", maxLength: 255, nullable: true),
                    ApplicationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    MarkId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "CellVals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    ApplicationId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RowId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ColumnId = table.Column<Guid>(type: "TEXT", nullable: false)
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

            migrationBuilder.InsertData(
                table: "DataTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("09339532-85e3-4a96-9fbe-8a6b87672649"), "string" },
                    { new Guid("7d584302-c308-40ad-ae7a-bc7fddfa57e0"), "DateTime" },
                    { new Guid("978e285a-2719-463d-855d-488801d440ae"), "bool" },
                    { new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2"), "int" }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("5057cb29-44bc-4119-b4b3-d84dd61dc0e9"), "Профессиональное развитие", 3 },
                    { new Guid("83c025bf-049f-4bc8-947c-93e8027c788a"), "Общая информация", 1 },
                    { new Guid("9ccefea5-fead-45a2-a7aa-57e2d584810e"), "Категория участников", 2 },
                    { new Guid("beb58483-4136-450b-b831-d8669e2578f7"), "Деятельность", 5 },
                    { new Guid("e0617a15-0a25-4a3e-831f-cc2a6e1c7e61"), "Деятельность", 4 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), "Научно-исследовательская деятельность", 5 },
                    { new Guid("0534260a-fe4f-450b-843d-01c1b9aab16d"), "Профессиональные показатели", 4 },
                    { new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710"), "Основной", 1 },
                    { new Guid("32439931-0ae4-4fae-a68b-d3698f2cb521"), "Итог", 8 },
                    { new Guid("359a3d74-16f9-4aec-b547-f62e79131852"), "Образовательная деятельность", 2 },
                    { new Guid("491f4511-331b-4624-941a-5a7810619dd1"), "Инновационная и иная деятельность", 6 },
                    { new Guid("5c0cb20f-44c5-4d31-a2dd-ee2fac38abd6"), "Конкурсная работа", 7 },
                    { new Guid("c75445b1-98a9-4875-acb4-8365b68bb5eb"), "Методическая деятельность", 3 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("0a34523d-d1e2-4280-994f-213be4679c0c"), null, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null },
                    { new Guid("89f2232d-1043-4009-aa4f-f36cd35a1d4b"), null, "Оценка уровня предоставленной работы:", 25, null }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("67e4414f-c866-4fa7-856f-1dfb97bc291e"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("dfbcced5-3c0a-44f2-bdfb-dfc1bec36d01"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("725d80ef-ae58-4e0a-8f13-fb65de5d04b8"), "User 1", "admin@mail.ru" },
                    { new Guid("786919c6-e4ad-48e6-bd29-d92a73bfe040"), "User 2", "user@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("5057cb29-44bc-4119-b4b3-d84dd61dc0e9"), new Guid("67e4414f-c866-4fa7-856f-1dfb97bc291e") },
                    { new Guid("5057cb29-44bc-4119-b4b3-d84dd61dc0e9"), new Guid("dfbcced5-3c0a-44f2-bdfb-dfc1bec36d01") },
                    { new Guid("83c025bf-049f-4bc8-947c-93e8027c788a"), new Guid("67e4414f-c866-4fa7-856f-1dfb97bc291e") },
                    { new Guid("83c025bf-049f-4bc8-947c-93e8027c788a"), new Guid("dfbcced5-3c0a-44f2-bdfb-dfc1bec36d01") },
                    { new Guid("9ccefea5-fead-45a2-a7aa-57e2d584810e"), new Guid("67e4414f-c866-4fa7-856f-1dfb97bc291e") },
                    { new Guid("9ccefea5-fead-45a2-a7aa-57e2d584810e"), new Guid("dfbcced5-3c0a-44f2-bdfb-dfc1bec36d01") },
                    { new Guid("beb58483-4136-450b-b831-d8669e2578f7"), new Guid("dfbcced5-3c0a-44f2-bdfb-dfc1bec36d01") },
                    { new Guid("e0617a15-0a25-4a3e-831f-cc2a6e1c7e61"), new Guid("67e4414f-c866-4fa7-856f-1dfb97bc291e") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0a13fe9a-8291-4b82-8ada-af22994ce905"), new Guid("9ccefea5-fead-45a2-a7aa-57e2d584810e"), "Ученое звание", 15, "Выберите ученое звание", new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("2190c802-624c-428c-ae2f-35c98bee5a9f"), new Guid("9ccefea5-fead-45a2-a7aa-57e2d584810e"), "Ученая степень", 16, "Выберите ученую степень", new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("2845d8d1-f08b-4ecb-8d55-f00f556794f0"), new Guid("83c025bf-049f-4bc8-947c-93e8027c788a"), "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("2ab1c897-5131-46fc-a83b-2b9ca0094ab4"), new Guid("e0617a15-0a25-4a3e-831f-cc2a6e1c7e61"), "Защитившиеся бакалавры", 20, "Введите количество", new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("2ae1441a-274e-4373-9adc-01a058198446"), new Guid("83c025bf-049f-4bc8-947c-93e8027c788a"), "Дата рождения", 2, "01.01.2000", new Guid("7d584302-c308-40ad-ae7a-bc7fddfa57e0") },
                    { new Guid("3e0422cb-151d-4d73-a957-c30a6bf5a9d5"), new Guid("83c025bf-049f-4bc8-947c-93e8027c788a"), "Должность", 9, "Введите свою должность в организации", new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("46877dca-d317-4297-b043-aa9f578540c7"), new Guid("9ccefea5-fead-45a2-a7aa-57e2d584810e"), "Научная специальность (по классификации ВАК)", 17, "Введите научную специальность (по классификации ВАК)", new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("4fbcbe10-cec4-42b9-9f8a-47e0b8c4ec77"), new Guid("83c025bf-049f-4bc8-947c-93e8027c788a"), "ФИО", 1, "Иванов Иван Иванович", new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("7225ab70-9bda-4d89-977b-68df83cc4ef0"), new Guid("beb58483-4136-450b-b831-d8669e2578f7"), "Защитившиеся кандидаты наук", 23, "Введите количество", new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("82d35189-647e-428c-8676-e37cf3adf004"), new Guid("beb58483-4136-450b-b831-d8669e2578f7"), "Защитившиеся доктора наук", 24, "Введите количество", new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("876fe695-546f-46cb-834a-9319784ab15b"), new Guid("9ccefea5-fead-45a2-a7aa-57e2d584810e"), "Название конкрусной работы", 14, "Введите название своей конкурсной работы", new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("891c35c9-f30f-4e42-a31d-2de222cd8cbc"), new Guid("83c025bf-049f-4bc8-947c-93e8027c788a"), "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("8c3db563-9dd0-42f7-b543-b824166566eb"), new Guid("83c025bf-049f-4bc8-947c-93e8027c788a"), "Место работы/учебы", 6, "Название организации", new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("8d561551-5f05-4321-8607-22af69a9449c"), new Guid("e0617a15-0a25-4a3e-831f-cc2a6e1c7e61"), "Защитившиеся доктора наук", 19, "Введите количество", new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("a13c12d5-a9b2-4bf4-b3c4-d8ee078db0ed"), new Guid("83c025bf-049f-4bc8-947c-93e8027c788a"), "Дополнительная информация", 11, "Пример", new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("a5cd8441-9bcf-4296-af93-39860cd1a90b"), new Guid("83c025bf-049f-4bc8-947c-93e8027c788a"), "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("a8d4f324-bf85-40a4-94ad-4e8198ec5ca9"), new Guid("83c025bf-049f-4bc8-947c-93e8027c788a"), "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("ac8c84db-e865-49b1-93a1-bf01988d207d"), new Guid("9ccefea5-fead-45a2-a7aa-57e2d584810e"), "Категория участника конкурса", 13, "Выберите категорию участника конкруса", new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("b9012d85-8108-4417-a028-3e86a2ca6ba2"), new Guid("e0617a15-0a25-4a3e-831f-cc2a6e1c7e61"), "Защитившиеся магистры", 22, "Введите количество", new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("bf3392d8-4b8a-4473-bb0b-af7ae3e6a9a4"), new Guid("83c025bf-049f-4bc8-947c-93e8027c788a"), "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("cbf18ced-4896-457f-934c-e78fb697ad22"), new Guid("e0617a15-0a25-4a3e-831f-cc2a6e1c7e61"), "Защитившиеся кадидаты наук", 18, "Введите количество", new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("ceada615-4230-40ab-8f47-74b44c4e17b0"), new Guid("83c025bf-049f-4bc8-947c-93e8027c788a"), "Электронная почта", 5, "user@example.com", new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("e1189cf5-48bb-4dbe-8113-18127a3dbb2f"), new Guid("9ccefea5-fead-45a2-a7aa-57e2d584810e"), "Направление конкурса", 12, "Выберите направление конкурса", new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("f6b8c397-8d66-410f-8238-c00d51c51a11"), new Guid("e0617a15-0a25-4a3e-831f-cc2a6e1c7e61"), "Защитившиеся специалисты", 21, "Введите количество", new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), new Guid("dfbcced5-3c0a-44f2-bdfb-dfc1bec36d01") },
                    { new Guid("0534260a-fe4f-450b-843d-01c1b9aab16d"), new Guid("67e4414f-c866-4fa7-856f-1dfb97bc291e") },
                    { new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710"), new Guid("67e4414f-c866-4fa7-856f-1dfb97bc291e") },
                    { new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710"), new Guid("dfbcced5-3c0a-44f2-bdfb-dfc1bec36d01") },
                    { new Guid("32439931-0ae4-4fae-a68b-d3698f2cb521"), new Guid("67e4414f-c866-4fa7-856f-1dfb97bc291e") },
                    { new Guid("32439931-0ae4-4fae-a68b-d3698f2cb521"), new Guid("dfbcced5-3c0a-44f2-bdfb-dfc1bec36d01") },
                    { new Guid("359a3d74-16f9-4aec-b547-f62e79131852"), new Guid("67e4414f-c866-4fa7-856f-1dfb97bc291e") },
                    { new Guid("491f4511-331b-4624-941a-5a7810619dd1"), new Guid("dfbcced5-3c0a-44f2-bdfb-dfc1bec36d01") },
                    { new Guid("5c0cb20f-44c5-4d31-a2dd-ee2fac38abd6"), new Guid("67e4414f-c866-4fa7-856f-1dfb97bc291e") },
                    { new Guid("5c0cb20f-44c5-4d31-a2dd-ee2fac38abd6"), new Guid("dfbcced5-3c0a-44f2-bdfb-dfc1bec36d01") },
                    { new Guid("c75445b1-98a9-4875-acb4-8365b68bb5eb"), new Guid("67e4414f-c866-4fa7-856f-1dfb97bc291e") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("491f4511-331b-4624-941a-5a7810619dd1"), new Guid("0a34523d-d1e2-4280-994f-213be4679c0c") },
                    { new Guid("491f4511-331b-4624-941a-5a7810619dd1"), new Guid("89f2232d-1043-4009-aa4f-f36cd35a1d4b") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("187ea85a-2703-4662-b66e-1ce518f5fb0e"), new Guid("beb58483-4136-450b-b831-d8669e2578f7"), "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("1de25f8e-f3a4-42ef-bf92-d12fd25b5ea0"), new Guid("e0617a15-0a25-4a3e-831f-cc2a6e1c7e61"), "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("27b9e584-d330-4ae8-b25a-af96c0a9cff1"), new Guid("5057cb29-44bc-4119-b4b3-d84dd61dc0e9"), "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("2f462a8b-4cb0-44c8-824a-6ffe9d7ff1e0"), new Guid("beb58483-4136-450b-b831-d8669e2578f7"), "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("4645d45a-c02f-46e9-938d-d787b58d701b"), new Guid("e0617a15-0a25-4a3e-831f-cc2a6e1c7e61"), "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("4feb52c3-8be3-4468-8e5b-8044f0c39153"), new Guid("beb58483-4136-450b-b831-d8669e2578f7"), "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("568788ad-0b8e-4f33-b909-47c5c988f61c"), new Guid("e0617a15-0a25-4a3e-831f-cc2a6e1c7e61"), "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("5719e3d7-67d7-4f37-b368-5779e1c4e7cd"), new Guid("beb58483-4136-450b-b831-d8669e2578f7"), "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("7bb6953d-0284-44d4-957c-b3be4e09df49"), new Guid("e0617a15-0a25-4a3e-831f-cc2a6e1c7e61"), "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 },
                    { new Guid("a7a5b3b6-a228-41c8-a327-e24419aaef2b"), new Guid("e0617a15-0a25-4a3e-831f-cc2a6e1c7e61"), "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 },
                    { new Guid("c762f8cd-1c05-4025-b9d5-4678983e46ff"), new Guid("beb58483-4136-450b-b831-d8669e2578f7"), "Персональные идентификаторы и показатели", 10 },
                    { new Guid("d3b3bae6-2344-4b53-85cb-3529d48bbe99"), new Guid("5057cb29-44bc-4119-b4b3-d84dd61dc0e9"), "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("fde13e02-8582-481d-a4bb-f2610e697fe1"), new Guid("e0617a15-0a25-4a3e-831f-cc2a6e1c7e61"), "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("0dd84a9b-3d3a-43f7-81a3-894723a1bb9b"), "Индекс Хирша (за все время)", 5, new Guid("c762f8cd-1c05-4025-b9d5-4678983e46ff"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("12a8bdd2-fda9-4671-87d8-3db10483868c"), "Название", 2, new Guid("a7a5b3b6-a228-41c8-a327-e24419aaef2b"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("1b29645f-96e5-48af-85d8-99ded04d1b5c"), "Название разработки", 2, new Guid("5719e3d7-67d7-4f37-b368-5779e1c4e7cd"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("1c131d44-5b5b-40cf-96ea-0922aa4260a3"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("fde13e02-8582-481d-a4bb-f2610e697fe1"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("21a89bdc-71f4-4870-ae07-5495ed8da81f"), "Год", 4, new Guid("1de25f8e-f3a4-42ef-bf92-d12fd25b5ea0"), new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("22795765-869b-4009-8ace-06a2e178eb1b"), "Год", 1, new Guid("d3b3bae6-2344-4b53-85cb-3529d48bbe99"), new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("259a91ab-49aa-4231-9572-4237f1039d3a"), "Год получения документа", 2, new Guid("27b9e584-d330-4ae8-b25a-af96c0a9cff1"), new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("25daf729-7f9c-45e8-9e3a-3dfd437bb785"), "Статус конкурса", 3, new Guid("d3b3bae6-2344-4b53-85cb-3529d48bbe99"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("2cfa490a-ede6-411e-8508-2e7ba65268d7"), "Издание, год", 4, new Guid("2f462a8b-4cb0-44c8-824a-6ffe9d7ff1e0"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("337551cf-f0b1-4d83-956f-0a0cd7abac45"), "Вид деятельности (преподавательская)", 3, new Guid("568788ad-0b8e-4f33-b909-47c5c988f61c"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("376f4a76-68a5-4e1e-b2fc-5479eca304e8"), "Название статьи", 1, new Guid("2f462a8b-4cb0-44c8-824a-6ffe9d7ff1e0"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("39972ea4-0450-46c4-a436-231822b5ae3a"), "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("2f462a8b-4cb0-44c8-824a-6ffe9d7ff1e0"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("3f45ef64-4ec5-4e2c-b41c-8d87a4cafb9f"), "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("568788ad-0b8e-4f33-b909-47c5c988f61c"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("4523e611-de3e-4fd1-bc72-bc379b6c1dcb"), "Название курса", 1, new Guid("1de25f8e-f3a4-42ef-bf92-d12fd25b5ea0"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("4bb462ca-db4c-4cfb-b180-117059051920"), "Статус (руководитель/исполнитель)", 4, new Guid("4feb52c3-8be3-4468-8e5b-8044f0c39153"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("4defc6cb-7b0b-4fab-bdf5-8f9f5dd40049"), "ФИО", 1, new Guid("fde13e02-8582-481d-a4bb-f2610e697fe1"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("4f2d202a-dc1a-4581-9101-aff95272fb3f"), "Вид публикации", 1, new Guid("a7a5b3b6-a228-41c8-a327-e24419aaef2b"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("54f80fc8-43ac-4c2c-b3f4-cf2373e702b9"), "Ссылка", 5, new Guid("d3b3bae6-2344-4b53-85cb-3529d48bbe99"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("576ec524-900c-4189-b94b-c84ec90f2ef2"), "Тип идентификатора", 1, new Guid("c762f8cd-1c05-4025-b9d5-4678983e46ff"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("5ac0e64e-80fb-4f1b-ae27-8a1e74b6bef5"), "Название НИР/НИОКР", 1, new Guid("4feb52c3-8be3-4468-8e5b-8044f0c39153"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("5acd75b5-5639-49c0-9974-20be293da71b"), "Практические занятия (час.)", 4, new Guid("4645d45a-c02f-46e9-938d-d787b58d701b"), new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("616aee20-fa1f-45bd-8700-4b8af2372526"), "Лекции (час.)", 3, new Guid("4645d45a-c02f-46e9-938d-d787b58d701b"), new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("64850e6e-c587-4bdd-9ba9-61ad4cb5733a"), "Период выполнения", 3, new Guid("4feb52c3-8be3-4468-8e5b-8044f0c39153"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("6d8805d5-4392-46da-81b2-15a664aa7990"), "Название дисциплины", 1, new Guid("7bb6953d-0284-44d4-957c-b3be4e09df49"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("7897285c-a951-474f-a689-0e6cd176a717"), "Название", 2, new Guid("187ea85a-2703-4662-b66e-1ce518f5fb0e"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("7b758505-19f5-4911-bb4a-1f898486d229"), "Название документа, реквизиты", 1, new Guid("27b9e584-d330-4ae8-b25a-af96c0a9cff1"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("7f394e07-b743-4ecb-b66e-87e382c97ba8"), "Наименование курса", 1, new Guid("4645d45a-c02f-46e9-938d-d787b58d701b"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("8231e5e1-05d1-421d-9b58-cc5c8768d0e4"), "Идентификатор", 2, new Guid("c762f8cd-1c05-4025-b9d5-4678983e46ff"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("8aaab10c-91e7-4234-8291-ad93c1996bc8"), "Количество печатных листов", 4, new Guid("a7a5b3b6-a228-41c8-a327-e24419aaef2b"), new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("8da2f97a-9699-43a0-9045-3d40ea72e0ed"), "Ссылка на платформу", 3, new Guid("1de25f8e-f3a4-42ef-bf92-d12fd25b5ea0"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("9115d30c-95b0-4756-8373-365c4de0296e"), "Количество публикаций в БАЗЕ", 3, new Guid("c762f8cd-1c05-4025-b9d5-4678983e46ff"), new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("952cf86e-ae11-41df-b91b-e0a1a7efa49b"), "Соавторы", 3, new Guid("a7a5b3b6-a228-41c8-a327-e24419aaef2b"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("95724674-2bc6-42ba-9d2a-ef50d181b023"), "Название организации/должность/ставка", 1, new Guid("568788ad-0b8e-4f33-b909-47c5c988f61c"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("a3a856aa-649b-4ecf-9f75-159144234bdf"), "Вид (лекции, лабораторные)", 2, new Guid("7bb6953d-0284-44d4-957c-b3be4e09df49"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("a6d128e8-0716-4eea-b110-dc9b912732ea"), "Язык преподавания (русск./англ./др.)", 2, new Guid("4645d45a-c02f-46e9-938d-d787b58d701b"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("a75ee7c2-1d54-4662-9b24-42d26cdd783f"), "Соавторы", 2, new Guid("1de25f8e-f3a4-42ef-bf92-d12fd25b5ea0"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("a7f90f3c-a4a8-4189-bdc2-1f28051aad0d"), "Год", 3, new Guid("fde13e02-8582-481d-a4bb-f2610e697fe1"), new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("b031d25a-3d36-4885-b2ff-45fea3c464c8"), "Номер РИД", 4, new Guid("187ea85a-2703-4662-b66e-1ce518f5fb0e"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("c0938620-f392-4824-b270-140b8a5c16a4"), "Соавторы", 2, new Guid("2f462a8b-4cb0-44c8-824a-6ffe9d7ff1e0"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("c1448f16-f553-4c1e-936a-747a61e48312"), "Название конкурса", 2, new Guid("d3b3bae6-2344-4b53-85cb-3529d48bbe99"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("c3f29709-a2ae-4c1a-9532-31b3e992c140"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("4feb52c3-8be3-4468-8e5b-8044f0c39153"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("c82e7c55-71c2-410c-9e34-332f7a76b023"), "ФИО соавторов", 3, new Guid("187ea85a-2703-4662-b66e-1ce518f5fb0e"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("c8d46118-c651-49f9-baad-71dfbc1f2225"), "Награда", 4, new Guid("d3b3bae6-2344-4b53-85cb-3529d48bbe99"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("d51779c4-7f09-4d0d-a89b-2729908f7033"), "Название конкурса/премии", 2, new Guid("fde13e02-8582-481d-a4bb-f2610e697fe1"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("d6d86fe8-4a9c-46a8-a62c-e09dfa5fbb71"), "Количество часов", 4, new Guid("568788ad-0b8e-4f33-b909-47c5c988f61c"), new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("da51a04c-b9d5-496b-8c62-98bbbfa33011"), "Вид", 1, new Guid("187ea85a-2703-4662-b66e-1ce518f5fb0e"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("e1475aed-30ad-4eea-90cf-62079a899592"), "Вид", 1, new Guid("5719e3d7-67d7-4f37-b368-5779e1c4e7cd"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("e3c1a8e5-ca76-422e-8db0-c4a534111803"), "Издательство, год", 6, new Guid("a7a5b3b6-a228-41c8-a327-e24419aaef2b"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("e68d390c-ce69-471a-ae61-9ec05e8730f1"), "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("fde13e02-8582-481d-a4bb-f2610e697fe1"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("eaaa5f28-5504-47fb-9447-36c0f74e5917"), "Название организации в которую внедрена разработка", 3, new Guid("5719e3d7-67d7-4f37-b368-5779e1c4e7cd"), new Guid("09339532-85e3-4a96-9fbe-8a6b87672649") },
                    { new Guid("eb0a9002-2db6-4db1-ad14-34cca07f7671"), "Количество цитирований", 4, new Guid("c762f8cd-1c05-4025-b9d5-4678983e46ff"), new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("f0f33e82-ac2b-415e-b408-2e3bf35ef012"), "Сумма финансирования (тыс. руб.)", 2, new Guid("4feb52c3-8be3-4468-8e5b-8044f0c39153"), new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("f87d43a4-7770-475f-8227-fe0e91f68980"), "Итого (час.)", 5, new Guid("4645d45a-c02f-46e9-938d-d787b58d701b"), new Guid("eeb7ae3d-a2d5-4271-b057-370a1f3c4ec2") },
                    { new Guid("f88df40e-8baf-4c13-8551-eb2d8e46d9e8"), "Наличие грифа", 5, new Guid("a7a5b3b6-a228-41c8-a327-e24419aaef2b"), new Guid("978e285a-2719-463d-855d-488801d440ae") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("0a13fe9a-8291-4b82-8ada-af22994ce905"), new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799") },
                    { new Guid("0a13fe9a-8291-4b82-8ada-af22994ce905"), new Guid("0534260a-fe4f-450b-843d-01c1b9aab16d") },
                    { new Guid("0a13fe9a-8291-4b82-8ada-af22994ce905"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("2190c802-624c-428c-ae2f-35c98bee5a9f"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("2845d8d1-f08b-4ecb-8d55-f00f556794f0"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("2ab1c897-5131-46fc-a83b-2b9ca0094ab4"), new Guid("359a3d74-16f9-4aec-b547-f62e79131852") },
                    { new Guid("2ae1441a-274e-4373-9adc-01a058198446"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("3e0422cb-151d-4d73-a957-c30a6bf5a9d5"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("46877dca-d317-4297-b043-aa9f578540c7"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("4fbcbe10-cec4-42b9-9f8a-47e0b8c4ec77"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("7225ab70-9bda-4d89-977b-68df83cc4ef0"), new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799") },
                    { new Guid("82d35189-647e-428c-8676-e37cf3adf004"), new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799") },
                    { new Guid("876fe695-546f-46cb-834a-9319784ab15b"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("891c35c9-f30f-4e42-a31d-2de222cd8cbc"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("8c3db563-9dd0-42f7-b543-b824166566eb"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("8d561551-5f05-4321-8607-22af69a9449c"), new Guid("359a3d74-16f9-4aec-b547-f62e79131852") },
                    { new Guid("a13c12d5-a9b2-4bf4-b3c4-d8ee078db0ed"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("a5cd8441-9bcf-4296-af93-39860cd1a90b"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("a8d4f324-bf85-40a4-94ad-4e8198ec5ca9"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("ac8c84db-e865-49b1-93a1-bf01988d207d"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("b9012d85-8108-4417-a028-3e86a2ca6ba2"), new Guid("359a3d74-16f9-4aec-b547-f62e79131852") },
                    { new Guid("bf3392d8-4b8a-4473-bb0b-af7ae3e6a9a4"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("cbf18ced-4896-457f-934c-e78fb697ad22"), new Guid("359a3d74-16f9-4aec-b547-f62e79131852") },
                    { new Guid("ceada615-4230-40ab-8f47-74b44c4e17b0"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("e1189cf5-48bb-4dbe-8113-18127a3dbb2f"), new Guid("085f6e85-e21c-463c-af5e-d5883bd7a710") },
                    { new Guid("f6b8c397-8d66-410f-8238-c00d51c51a11"), new Guid("359a3d74-16f9-4aec-b547-f62e79131852") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), new Guid("2f462a8b-4cb0-44c8-824a-6ffe9d7ff1e0") },
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), new Guid("4feb52c3-8be3-4468-8e5b-8044f0c39153") },
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), new Guid("c762f8cd-1c05-4025-b9d5-4678983e46ff") },
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), new Guid("d3b3bae6-2344-4b53-85cb-3529d48bbe99") },
                    { new Guid("0534260a-fe4f-450b-843d-01c1b9aab16d"), new Guid("27b9e584-d330-4ae8-b25a-af96c0a9cff1") },
                    { new Guid("0534260a-fe4f-450b-843d-01c1b9aab16d"), new Guid("d3b3bae6-2344-4b53-85cb-3529d48bbe99") },
                    { new Guid("359a3d74-16f9-4aec-b547-f62e79131852"), new Guid("1de25f8e-f3a4-42ef-bf92-d12fd25b5ea0") },
                    { new Guid("359a3d74-16f9-4aec-b547-f62e79131852"), new Guid("4645d45a-c02f-46e9-938d-d787b58d701b") },
                    { new Guid("359a3d74-16f9-4aec-b547-f62e79131852"), new Guid("568788ad-0b8e-4f33-b909-47c5c988f61c") },
                    { new Guid("359a3d74-16f9-4aec-b547-f62e79131852"), new Guid("fde13e02-8582-481d-a4bb-f2610e697fe1") },
                    { new Guid("491f4511-331b-4624-941a-5a7810619dd1"), new Guid("187ea85a-2703-4662-b66e-1ce518f5fb0e") },
                    { new Guid("491f4511-331b-4624-941a-5a7810619dd1"), new Guid("27b9e584-d330-4ae8-b25a-af96c0a9cff1") },
                    { new Guid("491f4511-331b-4624-941a-5a7810619dd1"), new Guid("5719e3d7-67d7-4f37-b368-5779e1c4e7cd") },
                    { new Guid("c75445b1-98a9-4875-acb4-8365b68bb5eb"), new Guid("7bb6953d-0284-44d4-957c-b3be4e09df49") },
                    { new Guid("c75445b1-98a9-4875-acb4-8365b68bb5eb"), new Guid("a7a5b3b6-a228-41c8-a327-e24419aaef2b") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("053ba6e1-0b76-490a-ab37-1964eed0f6c4"), null, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("4feb52c3-8be3-4468-8e5b-8044f0c39153") },
                    { new Guid("080af0b5-e4c7-4c0e-9937-5bb981a19493"), null, "Баллы за труды без грифа и без соавторства:", 10, new Guid("a7a5b3b6-a228-41c8-a327-e24419aaef2b") },
                    { new Guid("08d51fb0-8b6f-4720-8a95-5a12ad7e8168"), null, "Баллы за награды:", 14, new Guid("d3b3bae6-2344-4b53-85cb-3529d48bbe99") },
                    { new Guid("11b8e5f4-5554-4a7a-8c99-7cf0e33b0828"), new Guid("b9012d85-8108-4417-a028-3e86a2ca6ba2"), "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("12fff4b0-9820-4c08-a6b5-9981831cfde4"), null, "Баллы за количество разработок:", 24, new Guid("5719e3d7-67d7-4f37-b368-5779e1c4e7cd") },
                    { new Guid("1b3c3501-5cc1-4467-91fa-6140e7aad6c5"), new Guid("82d35189-647e-428c-8676-e37cf3adf004"), "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("2345177c-3e08-4e91-b399-1013f1872a6b"), new Guid("cbf18ced-4896-457f-934c-e78fb697ad22"), "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("2e7df487-00d5-4cf5-a173-44849060d9bd"), new Guid("8d561551-5f05-4321-8607-22af69a9449c"), "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("459d09a8-8ef4-4fd8-afca-75af9e722727"), null, "Баллы за научные публикации:", 16, new Guid("2f462a8b-4cb0-44c8-824a-6ffe9d7ff1e0") },
                    { new Guid("552c20df-9c26-4b42-9bfb-d2b4a442569d"), new Guid("7225ab70-9bda-4d89-977b-68df83cc4ef0"), "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("5902bed5-04c7-4146-926a-596af7bff174"), null, "Баллы за профессиональное развитие:", 15, new Guid("27b9e584-d330-4ae8-b25a-af96c0a9cff1") },
                    { new Guid("6af2648c-4831-4d6d-97c0-08e1f902e308"), null, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("1de25f8e-f3a4-42ef-bf92-d12fd25b5ea0") },
                    { new Guid("72dd5279-cb6a-469f-bea9-a8de38f45f27"), null, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("4645d45a-c02f-46e9-938d-d787b58d701b") },
                    { new Guid("98658907-864f-48b5-98d8-1cbcab2ea7ec"), null, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("7bb6953d-0284-44d4-957c-b3be4e09df49") },
                    { new Guid("99002e8a-ffc2-4d89-af9a-896ebdb46ed7"), new Guid("0a13fe9a-8291-4b82-8ada-af22994ce905"), "Баллы за ученое звание:", 13, null },
                    { new Guid("a26f16f6-6536-4099-92be-974343c031fb"), null, "Баллы за труды с грифом и без соавторства:", 8, new Guid("a7a5b3b6-a228-41c8-a327-e24419aaef2b") },
                    { new Guid("a6d1d440-56a6-4d61-b926-7eee957f41b6"), null, "Баллы по базе РИНЦ:", 18, new Guid("c762f8cd-1c05-4025-b9d5-4678983e46ff") },
                    { new Guid("a7d3d7b5-879b-4710-ad4f-817bd39a5aec"), null, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("187ea85a-2703-4662-b66e-1ce518f5fb0e") },
                    { new Guid("b48046e2-a8cc-400e-b677-de930165f33b"), null, "Баллы за труды без грифа в соавторстве:", 11, new Guid("a7a5b3b6-a228-41c8-a327-e24419aaef2b") },
                    { new Guid("c1159ccd-107e-4699-9825-19974cc0c8d3"), null, "Баллы по базе Scopus:", 17, new Guid("c762f8cd-1c05-4025-b9d5-4678983e46ff") },
                    { new Guid("ccb41034-7a05-4402-9bc2-2077d97164e4"), null, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("fde13e02-8582-481d-a4bb-f2610e697fe1") },
                    { new Guid("e4cf10c7-cdf2-49c4-af32-1fecdb50163d"), null, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("4feb52c3-8be3-4468-8e5b-8044f0c39153") },
                    { new Guid("ea8809e6-f29f-4bb7-ab63-897fd572bc80"), null, "Баллы за объем учебной нагрузки:", 1, new Guid("4645d45a-c02f-46e9-938d-d787b58d701b") },
                    { new Guid("f550b7e7-978e-4aeb-9a25-ca9c8bf82c6f"), null, "Баллы за труды с грифом в соавторстве:", 9, new Guid("a7a5b3b6-a228-41c8-a327-e24419aaef2b") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), new Guid("053ba6e1-0b76-490a-ab37-1964eed0f6c4") },
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), new Guid("08d51fb0-8b6f-4720-8a95-5a12ad7e8168") },
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), new Guid("1b3c3501-5cc1-4467-91fa-6140e7aad6c5") },
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), new Guid("459d09a8-8ef4-4fd8-afca-75af9e722727") },
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), new Guid("552c20df-9c26-4b42-9bfb-d2b4a442569d") },
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), new Guid("99002e8a-ffc2-4d89-af9a-896ebdb46ed7") },
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), new Guid("a6d1d440-56a6-4d61-b926-7eee957f41b6") },
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), new Guid("c1159ccd-107e-4699-9825-19974cc0c8d3") },
                    { new Guid("03ec8939-4d74-41b8-8fd5-ff4b098e1799"), new Guid("e4cf10c7-cdf2-49c4-af32-1fecdb50163d") },
                    { new Guid("0534260a-fe4f-450b-843d-01c1b9aab16d"), new Guid("08d51fb0-8b6f-4720-8a95-5a12ad7e8168") },
                    { new Guid("0534260a-fe4f-450b-843d-01c1b9aab16d"), new Guid("5902bed5-04c7-4146-926a-596af7bff174") },
                    { new Guid("0534260a-fe4f-450b-843d-01c1b9aab16d"), new Guid("99002e8a-ffc2-4d89-af9a-896ebdb46ed7") },
                    { new Guid("359a3d74-16f9-4aec-b547-f62e79131852"), new Guid("11b8e5f4-5554-4a7a-8c99-7cf0e33b0828") },
                    { new Guid("359a3d74-16f9-4aec-b547-f62e79131852"), new Guid("2345177c-3e08-4e91-b399-1013f1872a6b") },
                    { new Guid("359a3d74-16f9-4aec-b547-f62e79131852"), new Guid("2e7df487-00d5-4cf5-a173-44849060d9bd") },
                    { new Guid("359a3d74-16f9-4aec-b547-f62e79131852"), new Guid("6af2648c-4831-4d6d-97c0-08e1f902e308") },
                    { new Guid("359a3d74-16f9-4aec-b547-f62e79131852"), new Guid("72dd5279-cb6a-469f-bea9-a8de38f45f27") },
                    { new Guid("359a3d74-16f9-4aec-b547-f62e79131852"), new Guid("ccb41034-7a05-4402-9bc2-2077d97164e4") },
                    { new Guid("359a3d74-16f9-4aec-b547-f62e79131852"), new Guid("ea8809e6-f29f-4bb7-ab63-897fd572bc80") },
                    { new Guid("491f4511-331b-4624-941a-5a7810619dd1"), new Guid("12fff4b0-9820-4c08-a6b5-9981831cfde4") },
                    { new Guid("491f4511-331b-4624-941a-5a7810619dd1"), new Guid("5902bed5-04c7-4146-926a-596af7bff174") },
                    { new Guid("491f4511-331b-4624-941a-5a7810619dd1"), new Guid("a7d3d7b5-879b-4710-ad4f-817bd39a5aec") },
                    { new Guid("c75445b1-98a9-4875-acb4-8365b68bb5eb"), new Guid("080af0b5-e4c7-4c0e-9937-5bb981a19493") },
                    { new Guid("c75445b1-98a9-4875-acb4-8365b68bb5eb"), new Guid("98658907-864f-48b5-98d8-1cbcab2ea7ec") },
                    { new Guid("c75445b1-98a9-4875-acb4-8365b68bb5eb"), new Guid("a26f16f6-6536-4099-92be-974343c031fb") },
                    { new Guid("c75445b1-98a9-4875-acb4-8365b68bb5eb"), new Guid("b48046e2-a8cc-400e-b677-de930165f33b") },
                    { new Guid("c75445b1-98a9-4875-acb4-8365b68bb5eb"), new Guid("f550b7e7-978e-4aeb-9a25-ca9c8bf82c6f") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_TrackId",
                table: "ApplicationForms",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationForms_UserInfoId",
                table: "ApplicationForms",
                column: "UserInfoId");

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
                name: "IX_DataTypes_Name",
                table: "DataTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EditBlocks_Number",
                table: "EditBlocks",
                column: "Number",
                unique: true);

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
                name: "IX_MarkVals_ApplicationId_MarkId",
                table: "MarkVals",
                columns: new[] { "ApplicationId", "MarkId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MarkVals_MarkId",
                table: "MarkVals",
                column: "MarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Rows_TableId",
                table: "Rows",
                column: "TableId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "CellVals");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Columns");

            migrationBuilder.DropTable(
                name: "Rows");

            migrationBuilder.DropTable(
                name: "MarkBlocks");

            migrationBuilder.DropTable(
                name: "ApplicationForms");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "Fields");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropTable(
                name: "DataTypes");

            migrationBuilder.DropTable(
                name: "EditBlocks");
        }
    }
}
