using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServerApp.Data.Entities;
using System.Diagnostics;

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
            builder.Entity<EditBlock>().HasIndex(eb => new { eb.Number, eb.Name }).IsUnique();
            builder.Entity<Field>().HasIndex(f => new { f.EditBlockId, f.Name }).IsUnique();
            builder.Entity<Field>().HasIndex(f => new { f.MarkBlockId, f.Name }).IsUnique();
            builder.Entity<FieldVal>().HasIndex(fv => new { fv.ApplicationId, fv.FieldId }).IsUnique();
            builder.Entity<Mark>().HasIndex(m => m.Number).IsUnique();
            builder.Entity<Mark>().HasIndex(m => m.Name).IsUnique();
            builder.Entity<MarkBlock>().HasIndex(mb => mb.Number).IsUnique();
            builder.Entity<MarkBlock>().HasIndex(mb => mb.Name).IsUnique();
            builder.Entity<MarkVal>().HasIndex(mv => new { mv.ApplicationId, mv.MarkId }).IsUnique();
            builder.Entity<Table>().HasIndex(t => t.Name).IsUnique();
            builder.Entity<Track>().HasIndex(t => t.Number).IsUnique();
            builder.Entity<Track>().HasIndex(t => t.Name).IsUnique();
            builder.Entity<UserInfo>().HasIndex(ui => ui.Username).IsUnique();
        }

        private static void OnConfiguringData(ModelBuilder builder)
        {
            var track1 = new Track() { Id = Guid.NewGuid(), Number = 1, Name = "Name trk 1" };
            var editBlk1 = new EditBlock() { Id = Guid.NewGuid(), Number = 1, Name = "Name blk 1" };
            var editBlk2 = new EditBlock() { Id = Guid.NewGuid(), Number = 2, Name = "Name blk 2" };
            var markBlk1 = new MarkBlock() { Id = Guid.NewGuid(), Number = 1, Name = "Name mark 1" };
            var tbl = new Table() { Id = Guid.NewGuid(), Name = "Table 1", EditBlockId = editBlk1.Id, MarkBlockId=markBlk1.Id };
            
            builder.Entity<Track>().HasData([track1]);
            builder.Entity<EditBlock>().HasData([editBlk1, editBlk2]);
            builder.Entity<MarkBlock>().HasData([markBlk1]);
            builder.Entity<Table>().HasData([tbl]);

            builder.Entity<Track>().HasMany(e => e.EditBlocks).WithMany(e => e.Tracks)
                .UsingEntity(j => j.HasData([
                    new { TracksId=track1.Id, EditBlocksId=editBlk1.Id },
                    new { TracksId=track1.Id, EditBlocksId=editBlk2.Id },
                ])
            );
            builder.Entity<Track>().HasMany(e => e.MarkBlocks).WithMany(e => e.Tracks)
                .UsingEntity(j => j.HasData([
                    new { TracksId=track1.Id, MarkBlocksId=markBlk1.Id },
                ])
            );
        }

        //void ConfigManyToMany<T1, T2>(EntityTypeBuilder<T1> builder1, EntityTypeBuilder<T2> builder2) where T1 : class, T2 : class
        //{
        //    var track1 = new Track() { Id = Guid.NewGuid(), Number = 1, Name = "Name trk 1" };
        //    var editBlk1 = new EditBlock() { Id = Guid.NewGuid(), Number = 1, Name = "Name blk 1" };
        //    var editBlk2 = new EditBlock() { Id = Guid.NewGuid(), Number = 2, Name = "Name blk 2" };

        //    builder1.HasData([track1]);
        //    builder2.Entity<EditBlock>().HasData([editBlk1]);
        //    builder1.HasMany(e => e.EditBlocks).WithMany(e => e.Tracks)
        //        .UsingEntity(j => j.HasData([
        //            new { TrackId=track1.Id, EditBlockId=editBlk1.Id },
        //            new { TrackId=track1.Id, EditBlockId=editBlk2.Id },
        //        ])
        //    );

        //}
        //    void SeedData(ModelBuilder builder)
        //    {
        //        SeedDataTrack(builder);
        //        SeedDataEditBlock(builder);
        //        SeedDataMarkBlock(builder);
        //        SeedDataField(builder);
        //        SeedDataTable(builder);
        //        SeedDataColumn(builder);

        //        builder.Entity<Row>().HasData([
        //            //Персональные идентификаторы todo: сделать названия строк через ячейки
        //        ]);

        //        builder.Entity<Mark>().HasData([
        //            //todo: оценка привязывается не только к блоку, а к конкретному полю или таблицы
        //            //todo: также может быть несколько оценок к одному полю или таблице
        //        ]);
        //        builder.Entity<UserInfo>().HasData([
        //            new() { Name = "User 1", Username = "admin@mail.ru" },
        //            new() { Name = "User 2", Username = "user@mail.ru" },
        //        ]);
        //    }

        //    void SeedDataTrack(ModelBuilder builder)
        //    {
        //        builder.Entity<Track>().HasData([
        //            new() { Number = 1, Name = "Научно-педагогическая деятельность" },
        //            new() { Number = 2, Name = "Научно-исследовательская деятельность" }
        //        ]);
        //    }

        //    void SeedDataEditBlock(ModelBuilder builder)
        //    {
        //        builder.Entity<EditBlock>().HasData([
        //            new() { Number = 1, Name = "Общая информация" }, //Track = Науч-педагогическая + Исследовательская
        //            new() { Number = 2, Name = "Категория участников" }, //Track = Науч-педагогическая + Исследовательская
        //            new()
        //            {
        //                Number = 3, Name = "Профессиональное развитие"
        //            }, //Track = Науч-педагогическая + Исследовательская
        //            new() { Number = 4, Name = "Деятельность" }, //Track = Науч-педагогическая
        //            new() { Number = 5, Name = "Деятельность" } //Track = Науч-исследовательская
        //        ]);
        //    }

        //    void SeedDataField(ModelBuilder builder)
        //    {
        //        builder.Entity<Field>().HasData([
        //            //Трек конкурса???
        //            new() { Name = "Трек конкурса" },
        //            //Общая информация
        //            new() { Name = "ФИО" },
        //            new() { Name = "Дата рождения" },
        //            new() { Name = "Домашний адрес" },
        //            new() { Name = "Контанктный телефон" },
        //            new() { Name = "Электронная почта" },
        //            new() { Name = "Место работы/учебы" },
        //            new() { Name = "Адрес работы/учебы" },
        //            new() { Name = "Институт, факультет, кафедра, лаборатория" },
        //            new() { Name = "Должность" },
        //            new() { Name = "Стаж научно-педагогической деятельности по трудовой книжке" },
        //            new() { Name = "Дополнительная информация" },
        //            //Категория участников
        //            new() { Name = "Направление конкурса" },
        //            new() { Name = "Категория участника конкурса" },
        //            new() { Name = "Название конкурсной работы" },
        //            new() { Name = "Ученое звание" },
        //            new() { Name = "Ученая степень" },
        //            new() { Name = "Научная специальность (по классификации ВАК)" },
        //            //Деятельность для науч-педагогической
        //            new() { Name = "Защитившиеся кандидаты наук" },
        //            new() { Name = "Защитившиеся доктора наук" },
        //            new() { Name = "Защитившиеся бакалавры" },
        //            new() { Name = "Защитившиеся специалисты" },
        //            new() { Name = "Защитившиеся магистры" },
        //            //Деятельность для науч-исследовательской
        //            new() { Name = "Защитившиеся кандидаты наук" },
        //            new() { Name = "Защитившиеся доктора наук" },
        //        ]);
        //    }

        //    void SeedDataTable(ModelBuilder builder)
        //    {
        //        builder.Entity<Table>().HasData([
        //            //Профессиональное развитие
        //            new()
        //            {
        //                Name = "Награждение премиями, наградами в области научно-педагогической деятельности" +
        //                       " городского, всероссийского или международного уровня (в том числе зарубежными), " +
        //                       "победы в профессиональных конкурсах за весь период научно-педагогической деятельности"
        //            },
        //            new()
        //            {
        //                Name = "Сведения о профессиональном развитии участника конкурса за последние 5 лет " +
        //                       "(курсы повышения квалификации/ стажировки)"
        //            },
        //            //Деятельность для науч-педагогической
        //            new() { Name = "Учебная нагрузка за предыдущий учебный год (за исключением методической)" },
        //            new()
        //            {
        //                Name = "Список подготовленных под руководством участника конкурса студентов, бакалавров, " +
        //                       "магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, " +
        //                       "получивших самостоятельное признание"
        //            },
        //            new()
        //            {
        //                Name = "Сведения о работе, выполняемой участником конкурса в области научно-педагогической " +
        //                       "деятельности по совместительству (не по основному месту работы) в высшем учебном заведении," +
        //                       " академическом институте, отраслевом научно-исследовательском институте, " +
        //                       "профессиональной образовательной организации, общеобразовательной организации за предыдущий учебный год"
        //            },
        //            new()
        //            {
        //                Name = "Монографии, учебники, учебные и учебно-методические пособия с грифами и без грифов УМО, " +
        //                       "Министерств РФ или государственных академий наук, изданные типографским способом за последние 5 лет"
        //            },
        //            new()
        //            {
        //                Name = "Список лабораторных практикумов и" +
        //                       " курсов лекций (разработанных самостоятельно участником конкурса) за последние 5 лет"
        //            },
        //            new() { Name = "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет" },
        //            //Деятельность для науч-исследовательской
        //            new() { Name = "Список научных публикаций за последние 5 лет" },
        //            new() { Name = "Персональные идентификаторы и показатели" },
        //            new()
        //            {
        //                Name =
        //                    "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет"
        //            },
        //            new()
        //            {
        //                Name = "Список объектов интеллектуальной собственности, " +
        //                       "созданных участником конкурса за весь период научно-педагогической деятельности " +
        //                       "(созданных самостоятельно / в соавторстве), " +
        //                       "официально зарегистрированных в установленном порядке (в России / за рубежом)"
        //            },
        //            new()
        //            {
        //                Name = "Перечень разработок, " +
        //                       "внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)"
        //            }
        //        ]);
        //    }

        //    void SeedDataColumn(ModelBuilder builder)
        //    {
        //        builder.Entity<Column>().HasData([
        //            //Награды
        //            new() { Name = "Год" },
        //            new() { Name = "Название конкурса" },
        //            new() { Name = "Статус конкурса" },
        //            new() { Name = "Награда" },
        //            new() { Name = "Ссылка" },
        //            //Сведения о проф развитии
        //            new() { Name = "Название документа, реквизиты" },
        //            new() { Name = "Год получения документа" },
        //            //Учебная нагрузка
        //            new() { Name = "Наименование курса" },
        //            new() { Name = "Язык преподавания (русск./англ./др.)" },
        //            new() { Name = "Лекции (час.)" },
        //            new() { Name = "Практические занятия (час.)" },
        //            new() { Name = "Итого (час.)" },
        //            //Список подготовленных людей получивших признание
        //            new() { Name = "ФИО" },
        //            new() { Name = "Название конкурса/премии" },
        //            new() { Name = "Год" },
        //            new() { Name = "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)" },
        //            new() { Name = "Награда/премия (медаль, диплом с указанием степени)" },
        //            //Сведения о работе в науч-пед
        //            new() { Name = "Название организации/должность/ставка" },
        //            new() { Name = "Место нахождения (субъект РФ, зарубежье)" },
        //            new() { Name = "Вид деятельности (преподавательская)" },
        //            new() { Name = "Количество часов" },
        //            //Монографии, учебники...
        //            new() { Name = "Вид публикации" },
        //            new() { Name = "Название" },
        //            new() { Name = "Соавторы" },
        //            new() { Name = "Количество печатных листов" },
        //            new() { Name = "Наличие грифа" },
        //            new() { Name = "Издательство, год" },
        //            //Список лабораторных практикумов
        //            new() { Name = "Название диспциплины" },
        //            new() { Name = "Вид (лекции, лабораторные)" },
        //            //Список онлайн курсов
        //            new() { Name = "Название курса" },
        //            new() { Name = "Соавторы" },
        //            new() { Name = "Ссылка на платформу" },
        //            new() { Name = "Год" },
        //            //Список науч публикаций
        //            new() { Name = "Название статьи" },
        //            new() { Name = "Соавторы" },
        //            new() { Name = "Тип публикации (категория ВАК/квартиль МБД)" },
        //            new() { Name = "Издание, год" },
        //            //Персональные идентификаторы
        //            new() { Name = "Тип идентификатора" },
        //            new() { Name = "Идентификатор" },
        //            new() { Name = "Количество публикаций в БАЗЕ" },
        //            new() { Name = "Количество цитирований" },
        //            new() { Name = "Индекс Хирша (за все время)" },
        //            //Список выполненных НИР/НИОКР
        //            new() { Name = "Название НИР/НИОКР" },
        //            new() { Name = "Сумма финансирования (тыс. руб.)" },
        //            new() { Name = "Период выполнения" },
        //            new() { Name = "Статус (руководитель/исполнитель)" },
        //            new() { Name = "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)" },
        //            //Список объектов интел собственности
        //            new() { Name = "Вид" },
        //            new() { Name = "Название" },
        //            new() { Name = "ФИО соавторов" },
        //            new() { Name = "Номер РИД" },
        //            //Перечень разработок
        //            new() { Name = "Вид" },
        //            new() { Name = "Название разработки" },
        //            new() { Name = "Название организации в которую внедрена разработка" },
        //        ]);
        //    }

        //    void SeedDataMarkBlock(ModelBuilder builder)
        //    {
        //        builder.Entity<MarkBlock>().HasData([
        //            new() { Number = 1, Name = "Основной" }, //Track = Педагог+Исслед
        //            new() { Number = 2, Name = "Образовательная деятельность" }, //Track = Педагог 
        //            new() { Number = 3, Name = "Методическая деятельность" }, //Track = Педагог 
        //            new() { Number = 4, Name = "Профессиональные показатели" }, //Track = Педагог 
        //            new() { Number = 5, Name = "Научно-исследовательская деятельность" }, //Track = Исслед 
        //            new() { Number = 6, Name = "Инновационная и иная деятельность" }, //Track = Исслед 
        //            new() { Number = 7, Name = "Конкурсная работа" }, //Track = Педагог+Исслед 
        //            new() { Number = 8, Name = "Итог" }, //Track = Педагог+Исслед
        //        ]);
        //    }

        //    void SeedDataMark(ModelBuilder builder)
        //    {
        //        builder.Entity<Mark>().HasData([
        //            new() {},
        //        ]);
        //    }
    }
}