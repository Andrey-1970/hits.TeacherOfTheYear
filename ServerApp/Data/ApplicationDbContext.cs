using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServerApp.Data.Entities;

namespace ServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : IdentityDbContext<ApplicationUser>(options)
    {
        #region Init DBSets

        public DbSet<ApplicationForm> ApplicationForms { get; set; }
        public DbSet<CellVal> CellVals { get; set; }
        public DbSet<Column> Columns { get; set; }
        public DbSet<EditBlock> EditBlocks { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<FieldVal> FieldVals { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<MarkBlock> MarkBlocks { get; set; }
        public DbSet<MarkVal> MarkVals { get; set; }
        public DbSet<Row> Rows { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            OnConfiguringConstraction(builder);
            OnConfiguringData(builder);
        }

        private static void OnConfiguringConstraction(ModelBuilder builder)
        {
            builder.Entity<CellVal>().HasIndex(cv => new { cv.ApplicationId, cv.RowId, cv.ColumnId }).IsUnique();
            builder.Entity<Column>().HasIndex(t => new { t.TableId, t.Name }).IsUnique();
            builder.Entity<EditBlock>().HasIndex(eb => eb.Number).IsUnique();

            // К сожалению из-за связи многие ко многим уникальность отследить невозможно
            //builder.Entity<EditBlock>().HasIndex(eb => new { eb.Number, eb.Name }).IsUnique();

            builder.Entity<Field>().HasIndex(f => new { f.EditBlockId, f.Name }).IsUnique();
            builder.Entity<FieldVal>().HasIndex(fv => new { fv.ApplicationId, fv.FieldId }).IsUnique();
            builder.Entity<Mark>().HasIndex(m => m.Number).IsUnique();
            builder.Entity<MarkBlock>().HasIndex(mb => mb.Number).IsUnique();
            builder.Entity<MarkBlock>().HasIndex(mb => mb.Name).IsUnique();
            builder.Entity<MarkVal>().HasIndex(mv => new { mv.ApplicationId, mv.MarkId }).IsUnique();

            // Должно быть одинаково с Field
            //builder.Entity<Table>().HasIndex(t => t.Name).IsUnique();
            builder.Entity<Table>().HasIndex(t => new { t.EditBlockId, t.Name }).IsUnique();

            builder.Entity<Track>().HasIndex(t => t.Number).IsUnique();
            builder.Entity<Track>().HasIndex(t => t.Name).IsUnique();
            builder.Entity<UserInfo>().HasIndex(ui => ui.Username).IsUnique();
        }

        private static void OnConfiguringData(ModelBuilder builder)
        {
            #region UserInfos
            builder.Entity<UserInfo>().HasData([
                new() { Id = Guid.NewGuid(), Name="User 1", Username="admin@mail.ru"},
                new() { Id = Guid.NewGuid(), Name="User 2", Username="user@mail.ru"},
            ]);
            #endregion

            #region Tracks

            var track1 = new Track() { Id = Guid.NewGuid(), Number = 1, Name = "Научно-педагогическая деятельность" };
            var track2 = new Track()
            { Id = Guid.NewGuid(), Number = 2, Name = "Научно-исследовательская деятельность" };

            #endregion

            #region EditBlocks

            var editBlk1 = new EditBlock() { Id = Guid.NewGuid(), Number = 1, Name = "Общая информация" };
            var editBlk2 = new EditBlock() { Id = Guid.NewGuid(), Number = 2, Name = "Категория участников" };
            var editBlk3 = new EditBlock() { Id = Guid.NewGuid(), Number = 3, Name = "Профессиональное развитие" };
            var editBlk4 = new EditBlock() { Id = Guid.NewGuid(), Number = 4, Name = "Деятельность" };
            var editBlk5 = new EditBlock() { Id = Guid.NewGuid(), Number = 5, Name = "Деятельность" };

            #endregion

            #region MarkBlocks

            var markBlk1 = new MarkBlock() { Id = Guid.NewGuid(), Number = 1, Name = "Основной" };
            var markBlk2 = new MarkBlock() { Id = Guid.NewGuid(), Number = 2, Name = "Образовательная деятельность" };
            var markBlk3 = new MarkBlock() { Id = Guid.NewGuid(), Number = 3, Name = "Методическая деятельность" };
            var markBlk4 = new MarkBlock() { Id = Guid.NewGuid(), Number = 4, Name = "Профессиональные показатели" };
            var markBlk5 = new MarkBlock()
            { Id = Guid.NewGuid(), Number = 5, Name = "Научно-исследовательская деятельность" };
            var markBlk6 = new MarkBlock()
            { Id = Guid.NewGuid(), Number = 6, Name = "Инновационная и иная деятельность" };
            var markBlk7 = new MarkBlock() { Id = Guid.NewGuid(), Number = 7, Name = "Конкурсная работа" };
            var markBlk8 = new MarkBlock() { Id = Guid.NewGuid(), Number = 8, Name = "Итог" };

            #endregion

            #region Tables

            var tbl1 = new Table()
            {
                Id = Guid.NewGuid(),
                Name =
                    "Награждение премиями, наградами в области научно-педагогической деятельности" +
                    " городского, всероссийского или международного уровня (в том числе зарубежными), " +
                    "победы в профессиональных конкурсах за весь период научно-педагогической деятельности",
                EditBlockId = editBlk3.Id
            };

            #region Columns4Table1

            var col11 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Год",
                TableId = tbl1.Id
            };
            var col12 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Название конкурса",
                TableId = tbl1.Id
            };
            var col13 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Статус конкурса",
                TableId = tbl1.Id
            };
            var col14 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Награда",
                TableId = tbl1.Id
            };
            var col15 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Ссылка",
                TableId = tbl1.Id
            };

            #endregion

            var tbl2 = new Table()
            {
                Id = Guid.NewGuid(),
                Name = "Сведения о профессиональном развитии участника конкурса за последние 5 лет " +
                       "(курсы повышения квалификации/ стажировки)",
                EditBlockId = editBlk3.Id
            };

            #region Columns4Table2

            var col21 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Название документа, реквизиты",
                TableId = tbl2.Id
            };
            var col22 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Год получения документа",
                TableId = tbl2.Id
            };

            #endregion

            var tbl3 = new Table()
            {
                Id = Guid.NewGuid(),
                Name = "Учебная нагрузка за предыдущий учебный год (за исключением методической)",
                EditBlockId = editBlk4.Id
            };

            #region Columns4Table3

            var col31 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Наименование курса",
                TableId = tbl3.Id
            };
            var col32 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Язык преподавания (русск./англ./др.)",
                TableId = tbl3.Id
            };
            var col33 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Лекции (час.)",
                TableId = tbl3.Id
            };
            var col34 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Практические занятия (час.)",
                TableId = tbl3.Id
            };
            var col35 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Итого (час.)",
                TableId = tbl3.Id
            };

            #endregion

            var tbl4 = new Table()
            {
                Id = Guid.NewGuid(),
                Name =
                    "Список подготовленных под руководством участника конкурса студентов, бакалавров, " +
                    "магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, " +
                    "получивших самостоятельное признание",
                EditBlockId = editBlk4.Id
            };

            #region Columns4Table4

            var col41 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "ФИО",
                TableId = tbl4.Id
            };
            var col42 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Название конкурса/премии",
                TableId = tbl4.Id
            };
            var col43 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Год",
                TableId = tbl4.Id
            };
            var col44 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)",
                TableId = tbl4.Id
            };
            var col45 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Награда/премия (медаль, диплом с указанием степени)",
                TableId = tbl4.Id
            };

            #endregion

            var tbl5 = new Table()
            {
                Id = Guid.NewGuid(),
                Name =
                    "Сведения о работе, выполняемой участником конкурса в области научно-педагогической " +
                    "деятельности по совместительству (не по основному месту работы) в высшем учебном заведении," +
                    " академическом институте, отраслевом научно-исследовательском институте, " +
                    "профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год",
                EditBlockId = editBlk4.Id,
            };

            #region Columns4Table5

            var col51 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Название организации/должность/ставка",
                TableId = tbl5.Id
            };
            var col52 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Место нахождения (субъект РФ, зарубежье)",
                TableId = tbl5.Id
            };
            var col53 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Вид деятельности (преподавательская)",
                TableId = tbl5.Id
            };
            var col54 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Количество часов",
                TableId = tbl5.Id
            };

            #endregion

            var tbl6 = new Table()
            {
                Id = Guid.NewGuid(),
                Name =
                    "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, " +
                    "Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет",
                EditBlockId = editBlk4.Id
            };

            #region Columns4Table6

            var col61 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Вид публикации",
                TableId = tbl6.Id
            };
            var col62 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Название",
                TableId = tbl6.Id
            };
            var col63 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Соавторы",
                TableId = tbl6.Id
            };
            var col64 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Количество печатных листов",
                TableId = tbl6.Id
            };
            var col65 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Наличие грифа",
                TableId = tbl6.Id
            };
            var col66 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Издательство, год",
                TableId = tbl6.Id
            };

            #endregion

            var tbl7 = new Table()
            {
                Id = Guid.NewGuid(),
                Name = "Список лабораторных практикумов и" +
                       " курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет",
                EditBlockId = editBlk4.Id
            };

            #region Columns4Table7

            var col71 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Название дисциплины",
                TableId = tbl7.Id
            };
            var col72 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Вид (лекции, лабораторные)",
                TableId = tbl7.Id
            };

            #endregion

            var tbl8 = new Table()
            {
                Id = Guid.NewGuid(),
                Name = "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет",
                EditBlockId = editBlk4.Id
            };

            #region Columns4Table8

            var col81 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Название курса",
                TableId = tbl8.Id
            };
            var col82 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Соавторы",
                TableId = tbl8.Id
            };
            var col83 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Ссылка на платформу",
                TableId = tbl8.Id
            };
            var col84 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Год",
                TableId = tbl8.Id
            };

            #endregion

            var tbl9 = new Table()
            {
                Id = Guid.NewGuid(),
                Name = "Список научных публикаций за последние 5 лет",
                EditBlockId = editBlk5.Id
            };

            #region Columns4Table9

            var col91 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Название статьи",
                TableId = tbl9.Id
            };
            var col92 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Соавторы",
                TableId = tbl9.Id
            };
            var col93 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Тип публикации (категория ВАК/квартиль МБД)",
                TableId = tbl9.Id
            };
            var col94 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Издание, год",
                TableId = tbl9.Id
            };

            #endregion

            var tbl10 = new Table()
            {
                Id = Guid.NewGuid(),
                Name = "Персональные идентификаторы и показатели",
                EditBlockId = editBlk5.Id
            };

            #region Columns4Table10

            var col101 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Тип идентификатора",
                TableId = tbl10.Id
            };
            var col102 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Идентификатор",
                TableId = tbl10.Id
            };
            var col103 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Количество публикаций в БАЗЕ",
                TableId = tbl10.Id
            };
            var col104 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Количество цитирований",
                TableId = tbl10.Id
            };
            var col105 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Индекс Хирша (за все время)",
                TableId = tbl10.Id
            };

            #endregion

            var tbl11 = new Table()
            {
                Id = Guid.NewGuid(),
                Name =
                    "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет",
                EditBlockId = editBlk5.Id
            };

            #region Columns4Table11

            var col111 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Название НИР/НИОКР",
                TableId = tbl11.Id
            };
            var col112 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Сумма финансирования (тыс. руб.)",
                TableId = tbl11.Id
            };
            var col113 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Период выполнения",
                TableId = tbl11.Id
            };
            var col114 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Статус (руководитель/исполнитель)",
                TableId = tbl11.Id
            };
            var col115 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)",
                TableId = tbl11.Id
            };

            #endregion

            var tbl12 = new Table()
            {
                Id = Guid.NewGuid(),
                Name =
                    "Список объектов интеллектуальной собственности, " +
                    "созданных участником конкурса за весь период научно-педагогической деятельности " +
                    "(созданных самостоятельно / в соавторстве), " +
                    "официально зарегистрированных в установленном порядке (в России / за рубежом)",
                EditBlockId = editBlk5.Id
            };

            #region Columns4Table12

            var col121 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Вид",
                TableId = tbl12.Id
            };
            var col122 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Название",
                TableId = tbl12.Id
            };
            var col123 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "ФИО соавторов",
                TableId = tbl12.Id
            };
            var col124 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Номер РИД",
                TableId = tbl12.Id
            };

            #endregion

            var tbl13 = new Table()
            {
                Id = Guid.NewGuid(),
                Name = "Перечень разработок, " +
                       "внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)",
                EditBlockId = editBlk5.Id
            };

            #region Columns4Table13

            var col131 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Вид",
                TableId = tbl13.Id
            };
            var col132 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Название разработки",
                TableId = tbl13.Id
            };
            var col133 = new Column()
            {
                Id = Guid.NewGuid(),
                Name = "Название организации в которую внедрена разработка",
                TableId = tbl13.Id
            };

            #endregion

            #endregion

            #region Fields

            var fld1 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Трек конкурса",
                EditBlockId = editBlk1.Id
            };
            var fld2 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "ФИО",
                EditBlockId = editBlk1.Id
            };
            var fld3 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Дата рождения",
                EditBlockId = editBlk1.Id
            };
            var fld4 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Домашний адрес",
                EditBlockId = editBlk1.Id
            };
            var fld5 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Контактный телефон",
                EditBlockId = editBlk1.Id
            };
            var fld6 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Электронная почта",
                EditBlockId = editBlk1.Id
            };
            var fld7 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Место работы/учебы",
                EditBlockId = editBlk1.Id
            };
            var fld8 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Адрес работы/учебы",
                EditBlockId = editBlk1.Id
            };
            var fld9 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Институт, факультет, кафедра, лаборатория",
                EditBlockId = editBlk1.Id
            };
            var fld10 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Должность",
                EditBlockId = editBlk1.Id
            };
            var fld11 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Стаж научно-педагогической деятельности по трудовой книжке",
                EditBlockId = editBlk1.Id
            };
            var fld12 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Дополнительная информация",
                EditBlockId = editBlk1.Id
            };
            var fld13 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Направление конкурса",
                EditBlockId = editBlk2.Id
            };
            var fld14 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Категория участника конкурса",
                EditBlockId = editBlk2.Id
            };
            var fld15 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Название конкрусной работы",
                EditBlockId = editBlk2.Id
            };
            var fld16 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Ученое звание",
                EditBlockId = editBlk2.Id
            };
            var fld17 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Ученая степень",
                EditBlockId = editBlk2.Id
            };
            var fld18 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Научная специальность (по классификации ВАК)",
                EditBlockId = editBlk2.Id
            };
            var fld19 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Защитившиеся кадидаты наук",
                EditBlockId = editBlk4.Id
            };
            var fld20 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Защитившиеся доктора наук",
                EditBlockId = editBlk4.Id
            };
            var fld21 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Защитившиеся бакалавры",
                EditBlockId = editBlk4.Id
            };
            var fld22 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Защитившиеся специалисты",
                EditBlockId = editBlk4.Id
            };
            var fld23 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Защитившиеся магистры",
                EditBlockId = editBlk4.Id
            };
            var fld24 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Защитившиеся кандидаты наук",
                EditBlockId = editBlk5.Id
            };
            var fld25 = new Field()
            {
                Id = Guid.NewGuid(),
                Name = "Защитившиеся доктора наук",
                EditBlockId = editBlk5.Id
            };

            #endregion

            #region Marks

            var mark1 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Баллы за объем учебной нагрузки:",
                TableId = tbl3.Id
            };
            var mark2 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Баллы за количество дисциплин на иностранном языке," +
                       " которые вел претендент, в предыдущем учебном году:",
                TableId = tbl3.Id
            };
            var mark3 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 3,
                Name = "Баллы за количество квалификационных работ, " +
                       "выполненных под руководством претендента:",
                FieldId = fld23.Id
            };
            var mark4 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 4,
                Name = "Баллы за количество защитившихся кандидатов наук:",
                FieldId = fld19.Id
            };
            var mark5 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 5,
                Name = "Баллы за количество защитившихся докторов наук:",
                FieldId = fld20.Id
            };
            var mark6 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 6,
                Name = "Баллы за количество подготовленных студентов, бакалавров, " +
                       "магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:",
                TableId = tbl4.Id
            };
            var mark7 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 7,
                Name = "Баллы за количество онлайн курсов на открытых площадках:",
                TableId = tbl8.Id
            };
            var mark8 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 8,
                Name = "Баллы за труды с грифом и без соавторства:",
                TableId = tbl6.Id
            };
            var mark9 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 9,
                Name = "Баллы за труды с грифом в соавторстве:",
                TableId = tbl6.Id
            };
            var mark10 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 10,
                Name = "Баллы за труды без грифа и без соавторства:",
                TableId = tbl6.Id
            };
            var mark11 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 11,
                Name = "Баллы за труды без грифа в соавторстве:",
                TableId = tbl6.Id
            };
            var mark12 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 12,
                Name = "Баллы за количество практикумов и курсов лекций:",
                TableId = tbl7.Id
            };
            var mark13 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 13,
                Name = "Баллы за ученое звание:",
                FieldId = fld16.Id
            };
            var mark14 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 14,
                Name = "Баллы за награды:",
                TableId = tbl1.Id
            };
            var mark15 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 15,
                Name = "Баллы за профессиональное развитие:",
                TableId = tbl2.Id
            };
            var mark16 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 16,
                Name = "Баллы за научные публикации:",
                TableId = tbl9.Id
            };
            var mark17 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 17,
                Name = "Баллы по базе Scopus:",
                TableId = tbl10.Id
            };
            var mark18 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 18,
                Name = "Баллы по базе РИНЦ:",
                TableId = tbl10.Id
            };
            var mark19 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 19,
                Name = "Баллы за количество защитившихся кандидатов наук:",
                FieldId = fld24.Id
            };
            var mark20 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 20,
                Name = "Баллы за количество защитившихся докторов наук:",
                FieldId = fld25.Id
            };
            var mark21 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 21,
                Name = "Баллы за выполненные НИР/НИОКР в качестве руководителя:",
                TableId = tbl11.Id
            };
            var mark22 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 22,
                Name = "Баллы за выполненные НИР/НИОКР в качестве исполнителя:",
                TableId = tbl11.Id
            };
            var mark23 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 23,
                Name = "Баллы за количество объектов интеллектуальной собственности:",
                TableId = tbl12.Id
            };
            var mark24 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 24,
                Name = "Баллы за количество разработок:",
                TableId = tbl13.Id
            };
            var mark25 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 25,
                Name = "Оценка уровня предоставленной работы:",
                //todo: добавить Field конкурсной работы
            };
            var mark26 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 26,
                Name = "Использование в представленной работе" +
                       " инновационных методов (проблемного и проективного обучения, " +
                       "тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):",
                //todo: добавить Field конкурсной работы
            };

            #endregion

            builder.Entity<Track>().HasData([track1, track2]);
            builder.Entity<EditBlock>().HasData([editBlk1, editBlk2, editBlk3, editBlk4, editBlk5]);
            builder.Entity<MarkBlock>().HasData([markBlk1, markBlk2, markBlk3, markBlk4, markBlk5, markBlk6, markBlk7, markBlk8]);
            builder.Entity<Table>().HasData([tbl1, tbl2, tbl3, tbl4, tbl5, tbl6, tbl7, tbl8, tbl9, tbl10, tbl11, tbl12, tbl13]);
            builder.Entity<Column>().HasData([
                col11, col12, col13, col14, col15,
                col21, col22,
                col31, col32, col33, col34, col35,
                col41, col42, col43, col44, col45,
                col51, col52, col53, col54,
                col61, col62, col63, col64, col65, col66,
                col71, col72,
                col81, col82, col83, col84,
                col91, col92, col93, col94,
                col101, col102, col103, col104, col105,
                col111, col112, col113, col114, col115,
                col121, col122, col123, col124,
                col131, col132, col133
            ]);
            builder.Entity<Field>().HasData([fld1, fld2, fld3, fld4, fld5, fld6, fld7, fld8, fld9, fld10, fld11, fld12,
                fld13, fld14, fld15, fld16, fld17, fld18, fld19, fld20, fld21, fld22, fld23, fld24, fld25]);
            builder.Entity<Mark>().HasData([
                mark1, mark2, mark3, mark4, mark5, mark6, mark7, mark8, mark9, mark10, mark11, mark12, mark13, mark14, mark15, mark16, mark17,
                mark18, mark19, mark20, mark21, mark22, mark23, mark24, mark25, mark26,
            ]);

            builder.Entity<Track>().HasMany(e => e.EditBlocks).WithMany(e => e.Tracks)
                .UsingEntity(j => j.HasData([
                        new { TracksId = track1.Id, EditBlocksId = editBlk1.Id },
                        new { TracksId = track1.Id, EditBlocksId = editBlk2.Id },
                        new { TracksId = track1.Id, EditBlocksId = editBlk3.Id },
                        new { TracksId = track1.Id, EditBlocksId = editBlk4.Id },
                        new { TracksId = track2.Id, EditBlocksId = editBlk1.Id },
                        new { TracksId = track2.Id, EditBlocksId = editBlk2.Id },
                        new { TracksId = track2.Id, EditBlocksId = editBlk3.Id },
                        new { TracksId = track2.Id, EditBlocksId = editBlk5.Id },
                    ])
                );
            builder.Entity<Track>().HasMany(e => e.MarkBlocks).WithMany(e => e.Tracks)
                .UsingEntity(j => j.HasData([
                        new { TracksId = track1.Id, MarkBlocksId = markBlk1.Id },
                        new { TracksId = track1.Id, MarkBlocksId = markBlk2.Id },
                        new { TracksId = track1.Id, MarkBlocksId = markBlk3.Id },
                        new { TracksId = track1.Id, MarkBlocksId = markBlk4.Id },
                        new { TracksId = track1.Id, MarkBlocksId = markBlk7.Id },
                        new { TracksId = track1.Id, MarkBlocksId = markBlk8.Id },
                        new { TracksId = track2.Id, MarkBlocksId = markBlk1.Id },
                        new { TracksId = track2.Id, MarkBlocksId = markBlk5.Id },
                        new { TracksId = track2.Id, MarkBlocksId = markBlk6.Id },
                        new { TracksId = track2.Id, MarkBlocksId = markBlk7.Id },
                        new { TracksId = track2.Id, MarkBlocksId = markBlk8.Id }
                    ])
                );
            builder.Entity<MarkBlock>().HasMany(e => e.Tables).WithMany(e => e.MarkBlocks)
                .UsingEntity(j => j.HasData([
                    new {MarkBlocksId = markBlk2.Id, TablesId = tbl3.Id},
                    new {MarkBlocksId = markBlk2.Id, TablesId = tbl4.Id},
                    new {MarkBlocksId = markBlk2.Id, TablesId = tbl5.Id},//todo: узнать у заказчика к какому MarkBlock относится и исправить
                    new {MarkBlocksId = markBlk2.Id, TablesId = tbl8.Id},
                    new {MarkBlocksId = markBlk3.Id, TablesId = tbl6.Id},
                    new {MarkBlocksId = markBlk3.Id, TablesId = tbl7.Id},
                    new {MarkBlocksId = markBlk4.Id, TablesId = tbl1.Id},
                    new {MarkBlocksId = markBlk4.Id, TablesId = tbl2.Id},
                    new {MarkBlocksId = markBlk5.Id, TablesId = tbl1.Id},
                    new {MarkBlocksId = markBlk5.Id, TablesId = tbl9.Id},
                    new {MarkBlocksId = markBlk5.Id, TablesId = tbl10.Id},
                    new {MarkBlocksId = markBlk5.Id, TablesId = tbl11.Id},
                    new {MarkBlocksId = markBlk6.Id, TablesId = tbl2.Id},
                    new {MarkBlocksId = markBlk6.Id, TablesId = tbl12.Id},
                    new {MarkBlocksId = markBlk6.Id, TablesId = tbl13.Id},
                ]));
            builder.Entity<MarkBlock>().HasMany(e => e.Fields).WithMany(e => e.MarkBlocks)
                .UsingEntity(j => j.HasData([
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld1.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld2.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld3.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld4.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld5.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld6.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld7.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld8.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld9.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld10.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld11.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld12.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld13.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld14.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld15.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld16.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld17.Id},
                    new {MarkBlocksId = markBlk1.Id, FieldsId = fld18.Id},
                    new {MarkBlocksId = markBlk2.Id, FieldsId = fld19.Id},
                    new {MarkBlocksId = markBlk2.Id, FieldsId = fld20.Id},
                    new {MarkBlocksId = markBlk2.Id, FieldsId = fld21.Id},
                    new {MarkBlocksId = markBlk2.Id, FieldsId = fld22.Id},
                    new {MarkBlocksId = markBlk2.Id, FieldsId = fld23.Id},
                    new {MarkBlocksId = markBlk4.Id, FieldsId = fld16.Id},
                    new {MarkBlocksId = markBlk5.Id, FieldsId = fld16.Id},
                    new {MarkBlocksId = markBlk5.Id, FieldsId = fld24.Id},
                    new {MarkBlocksId = markBlk5.Id, FieldsId = fld25.Id}
                ]));
            builder.Entity<MarkBlock>().HasMany(e => e.Marks).WithMany(e => e.MarkBlocks)
                .UsingEntity(j => j.HasData([
                    new {MarkBlocksId = markBlk2.Id, MarksId = mark1.Id},
                    new {MarkBlocksId = markBlk2.Id, MarksId = mark2.Id},
                    new {MarkBlocksId = markBlk2.Id, MarksId = mark3.Id},
                    new {MarkBlocksId = markBlk2.Id, MarksId = mark4.Id},
                    new {MarkBlocksId = markBlk2.Id, MarksId = mark5.Id},
                    new {MarkBlocksId = markBlk2.Id, MarksId = mark6.Id},
                    new {MarkBlocksId = markBlk2.Id, MarksId = mark7.Id},
                    new {MarkBlocksId = markBlk3.Id, MarksId = mark8.Id},
                    new {MarkBlocksId = markBlk3.Id, MarksId = mark9.Id},
                    new {MarkBlocksId = markBlk3.Id, MarksId = mark10.Id},
                    new {MarkBlocksId = markBlk3.Id, MarksId = mark11.Id},
                    new {MarkBlocksId = markBlk3.Id, MarksId = mark12.Id},
                    new {MarkBlocksId = markBlk4.Id, MarksId = mark13.Id},
                    new {MarkBlocksId = markBlk4.Id, MarksId = mark14.Id},
                    new {MarkBlocksId = markBlk4.Id, MarksId = mark15.Id},
                    new {MarkBlocksId = markBlk5.Id, MarksId = mark13.Id},
                    new {MarkBlocksId = markBlk5.Id, MarksId = mark14.Id},
                    new {MarkBlocksId = markBlk5.Id, MarksId = mark16.Id},
                    new {MarkBlocksId = markBlk5.Id, MarksId = mark17.Id},
                    new {MarkBlocksId = markBlk5.Id, MarksId = mark18.Id},
                    new {MarkBlocksId = markBlk5.Id, MarksId = mark19.Id},
                    new {MarkBlocksId = markBlk5.Id, MarksId = mark20.Id},
                    new {MarkBlocksId = markBlk5.Id, MarksId = mark21.Id},
                    new {MarkBlocksId = markBlk5.Id, MarksId = mark22.Id},
                    new {MarkBlocksId = markBlk6.Id, MarksId = mark15.Id},
                    new {MarkBlocksId = markBlk6.Id, MarksId = mark23.Id},
                    new {MarkBlocksId = markBlk6.Id, MarksId = mark24.Id},
                    new {MarkBlocksId = markBlk6.Id, MarksId = mark25.Id},
                    new {MarkBlocksId = markBlk6.Id, MarksId = mark26.Id},
                ]));
        }
    }
}