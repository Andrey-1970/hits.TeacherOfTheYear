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
                    { new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4"), "int" },
                    { new Guid("9fa1bf57-5188-4316-a94d-c7fec45314e8"), "bool" },
                    { new Guid("cc119393-578d-44f5-94bc-dc2a6266f7a9"), "DateTime" },
                    { new Guid("e8129f56-1ca2-4090-a93a-656e09bea965"), "string" }
                });

            migrationBuilder.InsertData(
                table: "EditBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("0eab4ab8-36c2-46bd-a80b-fdf71fd043eb"), "Категория участников", 2 },
                    { new Guid("4950b417-c050-44d5-9140-041c817898e5"), "Деятельность", 5 },
                    { new Guid("604522af-e699-4aeb-bbb4-1425e0c94d10"), "Профессиональное развитие", 3 },
                    { new Guid("8a86fa0d-f65a-4450-888a-4ecc04eb4f00"), "Деятельность", 4 },
                    { new Guid("8cc72552-9d27-4e46-a3f1-1fdc944d6365"), "Общая информация", 1 }
                });

            migrationBuilder.InsertData(
                table: "MarkBlocks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("09d843f5-0829-4d50-a4d1-0b9e44c75047"), "Итог", 8 },
                    { new Guid("0aca1cb3-0557-4ce8-99e2-6ea4968a69cf"), "Профессиональные показатели", 4 },
                    { new Guid("3270d52b-f9e4-46cc-8b1f-1b2025a5c613"), "Инновационная и иная деятельность", 6 },
                    { new Guid("6279492f-3623-4b35-9574-783344abc512"), "Методическая деятельность", 3 },
                    { new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5"), "Образовательная деятельность", 2 },
                    { new Guid("69a6a484-4f98-4be3-9c0e-dd619975c266"), "Конкурсная работа", 7 },
                    { new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8"), "Основной", 1 },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), "Научно-исследовательская деятельность", 5 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("4286641b-bd58-45fb-b449-8e80b55256db"), null, "Оценка уровня предоставленной работы:", 25, null },
                    { new Guid("5d3ca024-6ea3-40b7-a1cb-984510615772"), null, "Использование в представленной работе инновационных методов (проблемного и проективного обучения, тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):", 26, null }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("2e920b6e-ae4c-4058-a576-4db305e114ac"), "Научно-педагогическая деятельность", 1 },
                    { new Guid("9efc729b-8364-432c-93f4-c91beb2f03b6"), "Научно-исследовательская деятельность", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Name", "Username" },
                values: new object[,]
                {
                    { new Guid("d2b47b8b-336c-42f1-beed-f443b1c96d8d"), "User 1", "admin@mail.ru" },
                    { new Guid("f76470bf-a8f7-4694-818d-71257330ddcb"), "User 2", "user@mail.ru" }
                });

            migrationBuilder.InsertData(
                table: "EditBlockTrack",
                columns: new[] { "EditBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("0eab4ab8-36c2-46bd-a80b-fdf71fd043eb"), new Guid("2e920b6e-ae4c-4058-a576-4db305e114ac") },
                    { new Guid("0eab4ab8-36c2-46bd-a80b-fdf71fd043eb"), new Guid("9efc729b-8364-432c-93f4-c91beb2f03b6") },
                    { new Guid("4950b417-c050-44d5-9140-041c817898e5"), new Guid("9efc729b-8364-432c-93f4-c91beb2f03b6") },
                    { new Guid("604522af-e699-4aeb-bbb4-1425e0c94d10"), new Guid("2e920b6e-ae4c-4058-a576-4db305e114ac") },
                    { new Guid("604522af-e699-4aeb-bbb4-1425e0c94d10"), new Guid("9efc729b-8364-432c-93f4-c91beb2f03b6") },
                    { new Guid("8a86fa0d-f65a-4450-888a-4ecc04eb4f00"), new Guid("2e920b6e-ae4c-4058-a576-4db305e114ac") },
                    { new Guid("8cc72552-9d27-4e46-a3f1-1fdc944d6365"), new Guid("2e920b6e-ae4c-4058-a576-4db305e114ac") },
                    { new Guid("8cc72552-9d27-4e46-a3f1-1fdc944d6365"), new Guid("9efc729b-8364-432c-93f4-c91beb2f03b6") }
                });

            migrationBuilder.InsertData(
                table: "Fields",
                columns: new[] { "Id", "EditBlockId", "Name", "Number", "Placeholder", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("1896cf73-5457-4660-baff-095484ab531c"), new Guid("8cc72552-9d27-4e46-a3f1-1fdc944d6365"), "Домашний адрес", 3, "Регион, город, улица, дом, квартира", new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("1ce51459-0b59-4372-9858-01f526bf4132"), new Guid("8cc72552-9d27-4e46-a3f1-1fdc944d6365"), "Институт, факультет, кафедра, лаборатория", 8, "Введите институт, факультет, кафедру, лабораторию", new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("2fc220c7-07e5-4aac-97af-54f31d8064df"), new Guid("8cc72552-9d27-4e46-a3f1-1fdc944d6365"), "ФИО", 1, "Иванов Иван Иванович", new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("4230dd9c-ed0f-4b43-9f37-ec866346d419"), new Guid("8cc72552-9d27-4e46-a3f1-1fdc944d6365"), "Дата рождения", 2, "01.01.2000", new Guid("cc119393-578d-44f5-94bc-dc2a6266f7a9") },
                    { new Guid("49d5f336-7c4b-4f77-a8de-617417906036"), new Guid("8a86fa0d-f65a-4450-888a-4ecc04eb4f00"), "Защитившиеся доктора наук", 19, "Введите количество", new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("4a90b917-2627-424d-ba2a-27fc2d0ee2c8"), new Guid("8a86fa0d-f65a-4450-888a-4ecc04eb4f00"), "Защитившиеся магистры", 22, "Введите количество", new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("4bce90d4-8d0a-4119-88aa-ed3a5b7fdbfc"), new Guid("8a86fa0d-f65a-4450-888a-4ecc04eb4f00"), "Защитившиеся бакалавры", 20, "Введите количество", new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("5262b995-ecb2-4b38-aea2-d809d849696b"), new Guid("8cc72552-9d27-4e46-a3f1-1fdc944d6365"), "Место работы/учебы", 6, "Название организации", new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("5ab74dc1-6936-45f3-a7b4-843020fc6f2f"), new Guid("0eab4ab8-36c2-46bd-a80b-fdf71fd043eb"), "Ученая степень", 16, "Выберите ученую степень", new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("61fc7299-c0fb-463c-be37-24f7c630d053"), new Guid("8cc72552-9d27-4e46-a3f1-1fdc944d6365"), "Контактный телефон", 4, "+8 (900)-000-00-00", new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("6411a446-c6c4-4d9c-bc2b-30d56c4af808"), new Guid("8cc72552-9d27-4e46-a3f1-1fdc944d6365"), "Адрес работы/учебы", 7, "Регион, город, улица, дом", new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("6fcf31ac-e486-48e5-8584-9ba2b802b441"), new Guid("0eab4ab8-36c2-46bd-a80b-fdf71fd043eb"), "Ученое звание", 15, "Выберите ученое звание", new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("71cf8f0b-7391-466e-aadc-7b50f462228f"), new Guid("0eab4ab8-36c2-46bd-a80b-fdf71fd043eb"), "Категория участника конкурса", 13, "Выберите категорию участника конкруса", new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("78354a7f-716d-4a34-8ae0-d78dd1aabb12"), new Guid("8a86fa0d-f65a-4450-888a-4ecc04eb4f00"), "Защитившиеся кадидаты наук", 18, "Введите количество", new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("b8545ba3-42cd-47b1-865d-f07496696835"), new Guid("8a86fa0d-f65a-4450-888a-4ecc04eb4f00"), "Защитившиеся специалисты", 21, "Введите количество", new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("cc13aa37-480b-4acb-a907-49523ebe0994"), new Guid("0eab4ab8-36c2-46bd-a80b-fdf71fd043eb"), "Научная специальность (по классификации ВАК)", 17, "Введите научную специальность (по классификации ВАК)", new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("cc38cf10-4e12-4f48-a0c2-de97a78c39a4"), new Guid("8cc72552-9d27-4e46-a3f1-1fdc944d6365"), "Электронная почта", 5, "user@example.com", new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("cc9b31ec-9f25-4d08-aa34-2f4e2137ab9d"), new Guid("8cc72552-9d27-4e46-a3f1-1fdc944d6365"), "Стаж научно-педагогической деятельности по трудовой книжке", 10, "Введите свой стаж", new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("cdbe1d33-c8d1-40b0-ba6a-802032b2d3ed"), new Guid("4950b417-c050-44d5-9140-041c817898e5"), "Защитившиеся кандидаты наук", 23, "Введите количество", new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("d4adc223-06ce-41bf-ac63-c653a953d567"), new Guid("0eab4ab8-36c2-46bd-a80b-fdf71fd043eb"), "Направление конкурса", 12, "Выберите направление конкурса", new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("e488f0ca-874b-486e-b1e5-5d665d1231f8"), new Guid("0eab4ab8-36c2-46bd-a80b-fdf71fd043eb"), "Название конкрусной работы", 14, "Введите название своей конкурсной работы", new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("e758bd4a-4a13-4e0a-afde-0f4ad5f68d50"), new Guid("8cc72552-9d27-4e46-a3f1-1fdc944d6365"), "Должность", 9, "Введите свою должность в организации", new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("e9b396fc-0e5e-4bc3-b1fe-cf58372d0ab6"), new Guid("8cc72552-9d27-4e46-a3f1-1fdc944d6365"), "Дополнительная информация", 11, "Пример", new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("fb382e06-08a7-44d3-9226-b28edf976929"), new Guid("4950b417-c050-44d5-9140-041c817898e5"), "Защитившиеся доктора наук", 24, "Введите количество", new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTrack",
                columns: new[] { "MarkBlocksId", "TracksId" },
                values: new object[,]
                {
                    { new Guid("09d843f5-0829-4d50-a4d1-0b9e44c75047"), new Guid("2e920b6e-ae4c-4058-a576-4db305e114ac") },
                    { new Guid("09d843f5-0829-4d50-a4d1-0b9e44c75047"), new Guid("9efc729b-8364-432c-93f4-c91beb2f03b6") },
                    { new Guid("0aca1cb3-0557-4ce8-99e2-6ea4968a69cf"), new Guid("2e920b6e-ae4c-4058-a576-4db305e114ac") },
                    { new Guid("3270d52b-f9e4-46cc-8b1f-1b2025a5c613"), new Guid("9efc729b-8364-432c-93f4-c91beb2f03b6") },
                    { new Guid("6279492f-3623-4b35-9574-783344abc512"), new Guid("2e920b6e-ae4c-4058-a576-4db305e114ac") },
                    { new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5"), new Guid("2e920b6e-ae4c-4058-a576-4db305e114ac") },
                    { new Guid("69a6a484-4f98-4be3-9c0e-dd619975c266"), new Guid("2e920b6e-ae4c-4058-a576-4db305e114ac") },
                    { new Guid("69a6a484-4f98-4be3-9c0e-dd619975c266"), new Guid("9efc729b-8364-432c-93f4-c91beb2f03b6") },
                    { new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8"), new Guid("2e920b6e-ae4c-4058-a576-4db305e114ac") },
                    { new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8"), new Guid("9efc729b-8364-432c-93f4-c91beb2f03b6") },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), new Guid("9efc729b-8364-432c-93f4-c91beb2f03b6") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("3270d52b-f9e4-46cc-8b1f-1b2025a5c613"), new Guid("4286641b-bd58-45fb-b449-8e80b55256db") },
                    { new Guid("3270d52b-f9e4-46cc-8b1f-1b2025a5c613"), new Guid("5d3ca024-6ea3-40b7-a1cb-984510615772") }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "EditBlockId", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("04640600-667d-48e2-a2ac-ba609f601560"), new Guid("4950b417-c050-44d5-9140-041c817898e5"), "Список научных публикаций за последние 5 лет", 9 },
                    { new Guid("1311c06a-742c-4940-ad38-442571bab727"), new Guid("8a86fa0d-f65a-4450-888a-4ecc04eb4f00"), "Учебная нагрузка за предыдущий учебный год (за исключением методической)", 3 },
                    { new Guid("21a80b73-98cf-4377-b45d-b9aaf1e67562"), new Guid("604522af-e699-4aeb-bbb4-1425e0c94d10"), "Награждение премиями, наградами в области научно-педагогической деятельности городского, всероссийского или международного уровня (в том числе зарубежными), победы в профессиональных конкурсах за весь период научно-педагогической деятельности", 1 },
                    { new Guid("2ac787c9-21cc-4c0c-88f3-dba44c5086ae"), new Guid("8a86fa0d-f65a-4450-888a-4ecc04eb4f00"), "Список подготовленных под руководством участника конкурса студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание", 4 },
                    { new Guid("2b6eee8f-fc62-4206-8369-03a74edfaec4"), new Guid("8a86fa0d-f65a-4450-888a-4ecc04eb4f00"), "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет", 8 },
                    { new Guid("35e3f520-203b-41c2-bbf8-9798017a2704"), new Guid("8a86fa0d-f65a-4450-888a-4ecc04eb4f00"), "Сведения о работе, выполняемой участником конкурса в области научно-педагогической деятельности по совместительству (не по основному месту работы) в высшем учебном заведении, академическом институте, отраслевом научно-исследовательском институте, профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год", 5 },
                    { new Guid("54f5f19d-30fe-4615-96f2-2a11b53eec3d"), new Guid("4950b417-c050-44d5-9140-041c817898e5"), "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет", 11 },
                    { new Guid("6ef7ed79-f91e-4358-a2cd-137d76fff4b6"), new Guid("604522af-e699-4aeb-bbb4-1425e0c94d10"), "Сведения о профессиональном развитии участника конкурса за последние 5 лет (курсы повышения квалификации/ стажировки)", 2 },
                    { new Guid("722dbf55-9caf-4768-84ea-fcf0a94c0206"), new Guid("8a86fa0d-f65a-4450-888a-4ecc04eb4f00"), "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет", 6 },
                    { new Guid("7320a045-0eb0-4ded-96e7-b8b24f73469a"), new Guid("4950b417-c050-44d5-9140-041c817898e5"), "Персональные идентификаторы и показатели", 10 },
                    { new Guid("888c05a4-4fd9-40e0-b374-7adf683ff667"), new Guid("4950b417-c050-44d5-9140-041c817898e5"), "Перечень разработок, внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)", 13 },
                    { new Guid("cb6b56f5-6f97-4d75-af62-9ee97d63f169"), new Guid("4950b417-c050-44d5-9140-041c817898e5"), "Список объектов интеллектуальной собственности, созданных участником конкурса за весь период научно-педагогической деятельности (созданных самостоятельно / в соавторстве), официально зарегистрированных в установленном порядке (в России / за рубежом)", 12 },
                    { new Guid("ef1a4101-267c-4a37-a4d7-c66c89ef0f2b"), new Guid("8a86fa0d-f65a-4450-888a-4ecc04eb4f00"), "Список лабораторных практикумов и курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет", 7 }
                });

            migrationBuilder.InsertData(
                table: "Columns",
                columns: new[] { "Id", "Name", "Number", "TableId", "ValueTypeId" },
                values: new object[,]
                {
                    { new Guid("03994fd4-275b-4480-9906-076372640fa4"), "Награда/премия (медаль, диплом с указанием степени)", 5, new Guid("2ac787c9-21cc-4c0c-88f3-dba44c5086ae"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("05832893-55c4-4b3f-958c-401da1494da9"), "Практические занятия (час.)", 4, new Guid("1311c06a-742c-4940-ad38-442571bab727"), new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("1cebe82b-a626-41a4-8c91-87ad32dc6c50"), "Год", 1, new Guid("21a80b73-98cf-4377-b45d-b9aaf1e67562"), new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("1e2f15d0-a84f-4609-b0d4-31028f48aaff"), "Вид", 1, new Guid("888c05a4-4fd9-40e0-b374-7adf683ff667"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("2848fc45-3f26-4697-9286-4ad83df1cb6c"), "Вид деятельности (преподавательская)", 3, new Guid("35e3f520-203b-41c2-bbf8-9798017a2704"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("2880da51-2855-4b2b-873b-2fd1b9daa99e"), "Тип идентификатора", 1, new Guid("7320a045-0eb0-4ded-96e7-b8b24f73469a"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("318105e6-2328-4bab-bd37-361081bf543b"), "Название дисциплины", 1, new Guid("ef1a4101-267c-4a37-a4d7-c66c89ef0f2b"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("32bbbbca-1e76-40a7-8ca7-45f45a7ca9a8"), "Наличие грифа", 5, new Guid("722dbf55-9caf-4768-84ea-fcf0a94c0206"), new Guid("9fa1bf57-5188-4316-a94d-c7fec45314e8") },
                    { new Guid("40be165b-4e66-450e-979b-a70a4257ecf4"), "Год получения документа", 2, new Guid("6ef7ed79-f91e-4358-a2cd-137d76fff4b6"), new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("4104bde1-0063-467f-85e1-aaf348a0f6d4"), "Название курса", 1, new Guid("2b6eee8f-fc62-4206-8369-03a74edfaec4"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("416b44ac-301d-4520-807c-d23eb36f5f37"), "Вид публикации", 1, new Guid("722dbf55-9caf-4768-84ea-fcf0a94c0206"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("424a4bb3-ac14-4ddc-8041-f9cc85293920"), "Период выполнения", 3, new Guid("54f5f19d-30fe-4615-96f2-2a11b53eec3d"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("48b1384d-906d-42b4-a116-cfe4b1b0050a"), "Количество публикаций в БАЗЕ", 3, new Guid("7320a045-0eb0-4ded-96e7-b8b24f73469a"), new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("4cc0e54d-9f5c-4fd1-8be6-330713963046"), "Название разработки", 2, new Guid("888c05a4-4fd9-40e0-b374-7adf683ff667"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("4f53f3ef-d452-480f-af3c-177170a4e160"), "Язык преподавания (русск./англ./др.)", 2, new Guid("1311c06a-742c-4940-ad38-442571bab727"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("54d3f511-778d-4620-87a9-1becac81a5ca"), "Соавторы", 2, new Guid("2b6eee8f-fc62-4206-8369-03a74edfaec4"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("5a19e780-8e57-48d8-849b-2afe796a7ab1"), "Издание, год", 4, new Guid("04640600-667d-48e2-a2ac-ba609f601560"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("5a6ed502-1090-405c-80f8-788fe63d1bc5"), "Название организации/должность/ставка", 1, new Guid("35e3f520-203b-41c2-bbf8-9798017a2704"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("5f4eaac6-50dc-4d30-b29e-6006e939f0b7"), "Издательство, год", 6, new Guid("722dbf55-9caf-4768-84ea-fcf0a94c0206"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("62d95f61-c022-4571-b61b-442bd1a1ed50"), "Ссылка", 5, new Guid("21a80b73-98cf-4377-b45d-b9aaf1e67562"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("63ea06f6-bb96-41c5-b900-f93c8ae2206b"), "Название", 2, new Guid("cb6b56f5-6f97-4d75-af62-9ee97d63f169"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("64874550-28fa-4e8b-bd7c-a6ae22ac2c19"), "Сумма финансирования (тыс. руб.)", 2, new Guid("54f5f19d-30fe-4615-96f2-2a11b53eec3d"), new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("69785d97-b02d-4fe3-a925-b796b9471b9a"), "Награда", 4, new Guid("21a80b73-98cf-4377-b45d-b9aaf1e67562"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("69efa923-c855-4a98-b3ea-a2c155e4a38d"), "ФИО", 1, new Guid("2ac787c9-21cc-4c0c-88f3-dba44c5086ae"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("76523a53-23d2-4d8e-a9cd-f84360cb3010"), "Номер РИД", 4, new Guid("cb6b56f5-6f97-4d75-af62-9ee97d63f169"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("81b39e28-ccd4-4106-b902-d9138b910dad"), "Год", 4, new Guid("2b6eee8f-fc62-4206-8369-03a74edfaec4"), new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("8ce73638-5c50-411e-9654-b85ae4eb2678"), "Ссылка на платформу", 3, new Guid("2b6eee8f-fc62-4206-8369-03a74edfaec4"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("93c36f8d-fb4c-44bd-bb2d-a4d8d2cb4a4d"), "Тип публикации (категория ВАК/квартиль МБД)", 3, new Guid("04640600-667d-48e2-a2ac-ba609f601560"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("95530dd1-fbd2-4241-92aa-511d022c7d0e"), "Соавторы", 2, new Guid("04640600-667d-48e2-a2ac-ba609f601560"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("a20c521a-f306-499e-817d-edbc93fcf4b2"), "Количество печатных листов", 4, new Guid("722dbf55-9caf-4768-84ea-fcf0a94c0206"), new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("a44162ef-ae92-40d1-8d33-fef2537c9169"), "Индекс Хирша (за все время)", 5, new Guid("7320a045-0eb0-4ded-96e7-b8b24f73469a"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("a4dd6ca7-75c7-47be-bcfc-d22930a4ad4a"), "Название", 2, new Guid("722dbf55-9caf-4768-84ea-fcf0a94c0206"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("ad5a64e7-e901-4b7c-9694-a48bea28d0dd"), "Название организации в которую внедрена разработка", 3, new Guid("888c05a4-4fd9-40e0-b374-7adf683ff667"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("af68b27c-a403-4957-8157-c019749c1d57"), "Вид", 1, new Guid("cb6b56f5-6f97-4d75-af62-9ee97d63f169"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("b3a76fad-1a4e-464d-b6c6-54a1b0e6c5dc"), "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)", 5, new Guid("54f5f19d-30fe-4615-96f2-2a11b53eec3d"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("b5d1c20f-124d-4782-ae10-3d3ec1f53088"), "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)", 4, new Guid("2ac787c9-21cc-4c0c-88f3-dba44c5086ae"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("bb02bcf6-b7b2-4cb3-9b39-aa1c61fedd51"), "Место нахождения (субъект РФ, зарубежье)", 2, new Guid("35e3f520-203b-41c2-bbf8-9798017a2704"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("c3b42b19-722d-4891-9d5d-e06ce9116172"), "Статус конкурса", 3, new Guid("21a80b73-98cf-4377-b45d-b9aaf1e67562"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("c467e0a9-eda2-432c-9e8c-acecc08d047a"), "Статус (руководитель/исполнитель)", 4, new Guid("54f5f19d-30fe-4615-96f2-2a11b53eec3d"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("c4950088-5a51-49b5-b612-7bfb86bf794f"), "Идентификатор", 2, new Guid("7320a045-0eb0-4ded-96e7-b8b24f73469a"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("c678e719-6765-47ef-9ee8-7fcc6da6e313"), "Вид (лекции, лабораторные)", 2, new Guid("ef1a4101-267c-4a37-a4d7-c66c89ef0f2b"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("ccc57585-5351-4941-8c0e-8ae4a458790f"), "Год", 3, new Guid("2ac787c9-21cc-4c0c-88f3-dba44c5086ae"), new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("cfa91135-3194-45d7-ad2d-b1d1c3d01580"), "Наименование курса", 1, new Guid("1311c06a-742c-4940-ad38-442571bab727"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("d3716aee-b750-4f94-b618-a9af3c31eeb4"), "Количество часов", 4, new Guid("35e3f520-203b-41c2-bbf8-9798017a2704"), new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("db5e99ba-63dd-4d1b-88a6-b51985748950"), "Название документа, реквизиты", 1, new Guid("6ef7ed79-f91e-4358-a2cd-137d76fff4b6"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("e32f8c17-1a20-4678-a5c4-9e6bc0c42f1d"), "Название конкурса", 2, new Guid("21a80b73-98cf-4377-b45d-b9aaf1e67562"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("ec3b755d-dd4f-4073-bf65-51d45ab1b025"), "Лекции (час.)", 3, new Guid("1311c06a-742c-4940-ad38-442571bab727"), new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("f31ff489-3684-40c9-85b2-e7fbc25c67be"), "Название НИР/НИОКР", 1, new Guid("54f5f19d-30fe-4615-96f2-2a11b53eec3d"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("f4a317ea-394c-42c8-9c81-afd3e674379c"), "Название статьи", 1, new Guid("04640600-667d-48e2-a2ac-ba609f601560"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("f5f5fdfb-6c50-467e-9ad0-a52d9b41fc87"), "ФИО соавторов", 3, new Guid("cb6b56f5-6f97-4d75-af62-9ee97d63f169"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("f7a40ebe-580b-423c-9e71-93e1653ddf1e"), "Итого (час.)", 5, new Guid("1311c06a-742c-4940-ad38-442571bab727"), new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("f7c8920f-c8f0-4c63-9c48-6d970fd55f2b"), "Количество цитирований", 4, new Guid("7320a045-0eb0-4ded-96e7-b8b24f73469a"), new Guid("9e3d09d6-d2df-484c-9c15-7e109f5b2cf4") },
                    { new Guid("fc61d083-e1d8-416b-8766-09ea64641ef9"), "Соавторы", 3, new Guid("722dbf55-9caf-4768-84ea-fcf0a94c0206"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") },
                    { new Guid("ffa7c70d-d60e-42da-90bf-2d6b655390fb"), "Название конкурса/премии", 2, new Guid("2ac787c9-21cc-4c0c-88f3-dba44c5086ae"), new Guid("e8129f56-1ca2-4090-a93a-656e09bea965") }
                });

            migrationBuilder.InsertData(
                table: "FieldMarkBlock",
                columns: new[] { "FieldsId", "MarkBlocksId" },
                values: new object[,]
                {
                    { new Guid("1896cf73-5457-4660-baff-095484ab531c"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("1ce51459-0b59-4372-9858-01f526bf4132"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("2fc220c7-07e5-4aac-97af-54f31d8064df"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("4230dd9c-ed0f-4b43-9f37-ec866346d419"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("49d5f336-7c4b-4f77-a8de-617417906036"), new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5") },
                    { new Guid("4a90b917-2627-424d-ba2a-27fc2d0ee2c8"), new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5") },
                    { new Guid("4bce90d4-8d0a-4119-88aa-ed3a5b7fdbfc"), new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5") },
                    { new Guid("5262b995-ecb2-4b38-aea2-d809d849696b"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("5ab74dc1-6936-45f3-a7b4-843020fc6f2f"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("61fc7299-c0fb-463c-be37-24f7c630d053"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("6411a446-c6c4-4d9c-bc2b-30d56c4af808"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("6fcf31ac-e486-48e5-8584-9ba2b802b441"), new Guid("0aca1cb3-0557-4ce8-99e2-6ea4968a69cf") },
                    { new Guid("6fcf31ac-e486-48e5-8584-9ba2b802b441"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("6fcf31ac-e486-48e5-8584-9ba2b802b441"), new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1") },
                    { new Guid("71cf8f0b-7391-466e-aadc-7b50f462228f"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("78354a7f-716d-4a34-8ae0-d78dd1aabb12"), new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5") },
                    { new Guid("b8545ba3-42cd-47b1-865d-f07496696835"), new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5") },
                    { new Guid("cc13aa37-480b-4acb-a907-49523ebe0994"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("cc38cf10-4e12-4f48-a0c2-de97a78c39a4"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("cc9b31ec-9f25-4d08-aa34-2f4e2137ab9d"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("cdbe1d33-c8d1-40b0-ba6a-802032b2d3ed"), new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1") },
                    { new Guid("d4adc223-06ce-41bf-ac63-c653a953d567"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("e488f0ca-874b-486e-b1e5-5d665d1231f8"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("e758bd4a-4a13-4e0a-afde-0f4ad5f68d50"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("e9b396fc-0e5e-4bc3-b1fe-cf58372d0ab6"), new Guid("d34979da-e8e4-4626-99c6-ed6b95e9d4e8") },
                    { new Guid("fb382e06-08a7-44d3-9226-b28edf976929"), new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1") }
                });

            migrationBuilder.InsertData(
                table: "MarkBlockTable",
                columns: new[] { "MarkBlocksId", "TablesId" },
                values: new object[,]
                {
                    { new Guid("0aca1cb3-0557-4ce8-99e2-6ea4968a69cf"), new Guid("21a80b73-98cf-4377-b45d-b9aaf1e67562") },
                    { new Guid("0aca1cb3-0557-4ce8-99e2-6ea4968a69cf"), new Guid("6ef7ed79-f91e-4358-a2cd-137d76fff4b6") },
                    { new Guid("3270d52b-f9e4-46cc-8b1f-1b2025a5c613"), new Guid("6ef7ed79-f91e-4358-a2cd-137d76fff4b6") },
                    { new Guid("3270d52b-f9e4-46cc-8b1f-1b2025a5c613"), new Guid("888c05a4-4fd9-40e0-b374-7adf683ff667") },
                    { new Guid("3270d52b-f9e4-46cc-8b1f-1b2025a5c613"), new Guid("cb6b56f5-6f97-4d75-af62-9ee97d63f169") },
                    { new Guid("6279492f-3623-4b35-9574-783344abc512"), new Guid("722dbf55-9caf-4768-84ea-fcf0a94c0206") },
                    { new Guid("6279492f-3623-4b35-9574-783344abc512"), new Guid("ef1a4101-267c-4a37-a4d7-c66c89ef0f2b") },
                    { new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5"), new Guid("1311c06a-742c-4940-ad38-442571bab727") },
                    { new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5"), new Guid("2ac787c9-21cc-4c0c-88f3-dba44c5086ae") },
                    { new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5"), new Guid("2b6eee8f-fc62-4206-8369-03a74edfaec4") },
                    { new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5"), new Guid("35e3f520-203b-41c2-bbf8-9798017a2704") },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), new Guid("04640600-667d-48e2-a2ac-ba609f601560") },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), new Guid("21a80b73-98cf-4377-b45d-b9aaf1e67562") },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), new Guid("54f5f19d-30fe-4615-96f2-2a11b53eec3d") },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), new Guid("7320a045-0eb0-4ded-96e7-b8b24f73469a") }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "FieldId", "Name", "Number", "TableId" },
                values: new object[,]
                {
                    { new Guid("045218a6-3288-4c61-97e6-31028203bad9"), null, "Баллы за объем учебной нагрузки:", 1, new Guid("1311c06a-742c-4940-ad38-442571bab727") },
                    { new Guid("0480b432-44db-415b-8f72-05fa11655ff1"), new Guid("fb382e06-08a7-44d3-9226-b28edf976929"), "Баллы за количество защитившихся докторов наук:", 20, null },
                    { new Guid("106a4341-f3cc-462a-ab14-32c943d0d451"), null, "Баллы за выполненные НИР/НИОКР в качестве руководителя:", 21, new Guid("54f5f19d-30fe-4615-96f2-2a11b53eec3d") },
                    { new Guid("1286c7f8-f983-42c5-b7c9-62253193b02f"), null, "Баллы за труды с грифом в соавторстве:", 9, new Guid("722dbf55-9caf-4768-84ea-fcf0a94c0206") },
                    { new Guid("14ebabf4-0d6a-40f5-8fe9-823f9d0844ab"), null, "Баллы за количество дисциплин на иностранном языке, которые вел претендент, в предыдущем учебном году:", 2, new Guid("1311c06a-742c-4940-ad38-442571bab727") },
                    { new Guid("1e99c47d-5155-4cf0-968d-0d2f57f972d9"), new Guid("78354a7f-716d-4a34-8ae0-d78dd1aabb12"), "Баллы за количество защитившихся кандидатов наук:", 4, null },
                    { new Guid("290d69fd-e634-425f-9b23-00d07471ac6e"), null, "Баллы за количество онлайн курсов на открытых площадках:", 7, new Guid("2b6eee8f-fc62-4206-8369-03a74edfaec4") },
                    { new Guid("2b82dbfb-d54c-437f-a7e6-d949d68f4b12"), new Guid("49d5f336-7c4b-4f77-a8de-617417906036"), "Баллы за количество защитившихся докторов наук:", 5, null },
                    { new Guid("42979eae-b9a0-424e-b47b-6ad73024148c"), null, "Баллы за количество разработок:", 24, new Guid("888c05a4-4fd9-40e0-b374-7adf683ff667") },
                    { new Guid("4a2ab4be-8890-4537-9309-1e2644c30577"), new Guid("cdbe1d33-c8d1-40b0-ba6a-802032b2d3ed"), "Баллы за количество защитившихся кандидатов наук:", 19, null },
                    { new Guid("5649a79b-aefc-433b-a556-7f05cba30135"), null, "Баллы за научные публикации:", 16, new Guid("04640600-667d-48e2-a2ac-ba609f601560") },
                    { new Guid("6a609fa4-06e8-48c6-a871-55c9881030bf"), null, "Баллы за труды без грифа в соавторстве:", 11, new Guid("722dbf55-9caf-4768-84ea-fcf0a94c0206") },
                    { new Guid("7e3f6f65-1189-45df-b19e-fe26ad35d7bb"), null, "Баллы за профессиональное развитие:", 15, new Guid("6ef7ed79-f91e-4358-a2cd-137d76fff4b6") },
                    { new Guid("8fa45e6b-900c-4fac-b6f6-1f838a0a0c7b"), null, "Баллы за награды:", 14, new Guid("21a80b73-98cf-4377-b45d-b9aaf1e67562") },
                    { new Guid("97bfd30d-32e3-4823-b377-2a86ce17f4f9"), null, "Баллы по базе РИНЦ:", 18, new Guid("7320a045-0eb0-4ded-96e7-b8b24f73469a") },
                    { new Guid("9a391275-25ef-448e-a99a-125bf10745c2"), null, "Баллы за количество объектов интеллектуальной собственности:", 23, new Guid("cb6b56f5-6f97-4d75-af62-9ee97d63f169") },
                    { new Guid("a99e763c-1d97-44bd-8377-5c56ba40cc72"), null, "Баллы за труды с грифом и без соавторства:", 8, new Guid("722dbf55-9caf-4768-84ea-fcf0a94c0206") },
                    { new Guid("acfa5e65-f77a-4212-b7f4-5c211359abc5"), null, "Баллы за количество подготовленных студентов, бакалавров, магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:", 6, new Guid("2ac787c9-21cc-4c0c-88f3-dba44c5086ae") },
                    { new Guid("ce04c0e8-d038-48fa-9b00-15167139bbf4"), null, "Баллы за выполненные НИР/НИОКР в качестве исполнителя:", 22, new Guid("54f5f19d-30fe-4615-96f2-2a11b53eec3d") },
                    { new Guid("d675a0de-6227-421f-b4a2-394ae04ea948"), null, "Баллы за количество практикумов и курсов лекций:", 12, new Guid("ef1a4101-267c-4a37-a4d7-c66c89ef0f2b") },
                    { new Guid("d8bb2168-8e58-4491-a5bb-413a04ebfd60"), new Guid("4a90b917-2627-424d-ba2a-27fc2d0ee2c8"), "Баллы за количество квалификационных работ, выполненных под руководством претендента:", 3, null },
                    { new Guid("dadc9642-a81a-4c24-8f83-0b11d115aef2"), new Guid("6fcf31ac-e486-48e5-8584-9ba2b802b441"), "Баллы за ученое звание:", 13, null },
                    { new Guid("eeeba0f3-00aa-45ea-a150-1479328f25ff"), null, "Баллы по базе Scopus:", 17, new Guid("7320a045-0eb0-4ded-96e7-b8b24f73469a") },
                    { new Guid("f8422506-468e-47ef-8864-04d5fe11a1f3"), null, "Баллы за труды без грифа и без соавторства:", 10, new Guid("722dbf55-9caf-4768-84ea-fcf0a94c0206") }
                });

            migrationBuilder.InsertData(
                table: "MarkMarkBlock",
                columns: new[] { "MarkBlocksId", "MarksId" },
                values: new object[,]
                {
                    { new Guid("0aca1cb3-0557-4ce8-99e2-6ea4968a69cf"), new Guid("7e3f6f65-1189-45df-b19e-fe26ad35d7bb") },
                    { new Guid("0aca1cb3-0557-4ce8-99e2-6ea4968a69cf"), new Guid("8fa45e6b-900c-4fac-b6f6-1f838a0a0c7b") },
                    { new Guid("0aca1cb3-0557-4ce8-99e2-6ea4968a69cf"), new Guid("dadc9642-a81a-4c24-8f83-0b11d115aef2") },
                    { new Guid("3270d52b-f9e4-46cc-8b1f-1b2025a5c613"), new Guid("42979eae-b9a0-424e-b47b-6ad73024148c") },
                    { new Guid("3270d52b-f9e4-46cc-8b1f-1b2025a5c613"), new Guid("7e3f6f65-1189-45df-b19e-fe26ad35d7bb") },
                    { new Guid("3270d52b-f9e4-46cc-8b1f-1b2025a5c613"), new Guid("9a391275-25ef-448e-a99a-125bf10745c2") },
                    { new Guid("6279492f-3623-4b35-9574-783344abc512"), new Guid("1286c7f8-f983-42c5-b7c9-62253193b02f") },
                    { new Guid("6279492f-3623-4b35-9574-783344abc512"), new Guid("6a609fa4-06e8-48c6-a871-55c9881030bf") },
                    { new Guid("6279492f-3623-4b35-9574-783344abc512"), new Guid("a99e763c-1d97-44bd-8377-5c56ba40cc72") },
                    { new Guid("6279492f-3623-4b35-9574-783344abc512"), new Guid("d675a0de-6227-421f-b4a2-394ae04ea948") },
                    { new Guid("6279492f-3623-4b35-9574-783344abc512"), new Guid("f8422506-468e-47ef-8864-04d5fe11a1f3") },
                    { new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5"), new Guid("045218a6-3288-4c61-97e6-31028203bad9") },
                    { new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5"), new Guid("14ebabf4-0d6a-40f5-8fe9-823f9d0844ab") },
                    { new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5"), new Guid("1e99c47d-5155-4cf0-968d-0d2f57f972d9") },
                    { new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5"), new Guid("290d69fd-e634-425f-9b23-00d07471ac6e") },
                    { new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5"), new Guid("2b82dbfb-d54c-437f-a7e6-d949d68f4b12") },
                    { new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5"), new Guid("acfa5e65-f77a-4212-b7f4-5c211359abc5") },
                    { new Guid("63f40824-aa16-4568-8b2c-ec9e45638ad5"), new Guid("d8bb2168-8e58-4491-a5bb-413a04ebfd60") },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), new Guid("0480b432-44db-415b-8f72-05fa11655ff1") },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), new Guid("106a4341-f3cc-462a-ab14-32c943d0d451") },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), new Guid("4a2ab4be-8890-4537-9309-1e2644c30577") },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), new Guid("5649a79b-aefc-433b-a556-7f05cba30135") },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), new Guid("8fa45e6b-900c-4fac-b6f6-1f838a0a0c7b") },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), new Guid("97bfd30d-32e3-4823-b377-2a86ce17f4f9") },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), new Guid("ce04c0e8-d038-48fa-9b00-15167139bbf4") },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), new Guid("dadc9642-a81a-4c24-8f83-0b11d115aef2") },
                    { new Guid("f7399a31-ca0f-45b0-9c3b-3e58fe5f73c1"), new Guid("eeeba0f3-00aa-45ea-a150-1479328f25ff") }
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
