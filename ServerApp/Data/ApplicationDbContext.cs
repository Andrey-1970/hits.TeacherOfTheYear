using Microsoft.AspNetCore.Identity;
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
        public DbSet<ApplicationFormExpert> ApplicationFormExperts { get; set; }
        public DbSet<ApplicationStatus> ApplicationStatuses { get; set; }
        public DbSet<BlockReview> BlockReviews { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CellVal> CellVals { get; set; }
        public DbSet<Column> Columns { get; set; }
        public DbSet<EditBlock> EditBlocks { get; set; }
        public DbSet<EditBlockStatus> EditBlockStatuses { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<FieldVal> FieldVals { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<MarkBlock> MarkBlocks { get; set; }
        public DbSet<MarkVal> MarkVals { get; set; }
        public DbSet<Row> Rows { get; set; }
        public DbSet<SelectValue> SelectValues { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<ValuesType> ValueTypes { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<FeedBack> Feedbacks { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            ConfigureModelRelationships(builder);
            OnConfiguringConstraction(builder);
            OnConfiguringData(builder);
        }

        private void ConfigureModelRelationships(ModelBuilder builder)
        {
            // Конфигурация для ApplicationForm и других связанных сущностей
            builder.Entity<ApplicationForm>(entity =>
            {
                entity.HasMany(af => af.BlockReviews)
                    .WithOne(br => br.Application)
                    .HasForeignKey(br => br.ApplicationId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(af => af.MarkVals)
                    .WithOne(mv => mv.Application)
                    .HasForeignKey(mv => mv.ApplicationId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(af => af.FieldVals)
                    .WithOne(fv => fv.Application)
                    .HasForeignKey(fv => fv.ApplicationId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(af => af.CellVals)
                    .WithOne(cv => cv.Application)
                    .HasForeignKey(cv => cv.ApplicationId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(af => af.EditBlockStatusList)
                    .WithOne(ebs => ebs.Application)
                    .HasForeignKey(ebs => ebs.ApplicationId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(af => af.Votes)
                    .WithOne(v => v.ApplicationForm)
                    .HasForeignKey(v => v.ApplicationFormId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasMany(af => af.ApplicationFormExperts)
                    .WithOne(afe => afe.ApplicationForm)
                    .HasForeignKey(afe => afe.ApplicationFormId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            builder.Entity<CellVal>(entity =>
            {
                entity.HasOne(cv => cv.Row)
                    .WithMany(r => r.CellVals)
                    .HasForeignKey(cv => cv.RowId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
    
            builder.Entity<Row>(entity =>
            {
                entity.HasMany(r => r.CellVals)
                    .WithOne(cv => cv.Row)
                    .HasForeignKey(cv => cv.RowId)
                    .OnDelete(DeleteBehavior.Cascade);
            });



            // Конфигурация для ApplicationFormExpert
            builder.Entity<ApplicationFormExpert>(entity =>
            {
                // Composite Key
                entity.HasKey(afe => new { afe.ApplicationFormId, afe.UserInfoId });

                entity.HasOne(afe => afe.ApplicationForm)
                    .WithMany(af => af.ApplicationFormExperts)
                    .HasForeignKey(afe => afe.ApplicationFormId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(afe => afe.UserInfo)
                    .WithMany(ui => ui.ApplicationFormExperts)
                    .HasForeignKey(afe => afe.UserInfoId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
        }


        private static void OnConfiguringConstraction(ModelBuilder builder)
        {
            builder.Entity<ApplicationStatus>().HasIndex(e => e.Status).IsUnique();
            builder.Entity<Category>().HasIndex(e => e.Name).IsUnique();
            builder.Entity<Category>().HasIndex(e => e.Number).IsUnique();
            builder.Entity<CellVal>().HasIndex(cv => new { cv.ApplicationId, cv.RowId, cv.ColumnId }).IsUnique();
            builder.Entity<Column>().HasIndex(t => new { t.TableId, t.Name }).IsUnique();
            builder.Entity<Column>().HasIndex(t => new { t.TableId, t.Number }).IsUnique();
            builder.Entity<ValuesType>().HasIndex(vt => vt.Name).IsUnique();
            builder.Entity<EditBlock>().HasIndex(eb => eb.Number).IsUnique();

            // К сожалению из-за связи многие ко многим уникальность отследить невозможно
            //builder.Entity<EditBlock>().HasIndex(eb => new { eb.Number, eb.Name }).IsUnique();

            builder.Entity<Field>().HasIndex(f => new { f.EditBlockId, f.Name }).IsUnique();
            builder.Entity<Field>().HasIndex(f => f.Number).IsUnique();
            builder.Entity<FieldVal>().HasIndex(fv => new { fv.ApplicationId, fv.FieldId }).IsUnique();
            builder.Entity<Mark>().HasIndex(m => m.Number).IsUnique();
            builder.Entity<MarkBlock>().HasIndex(mb => mb.Number).IsUnique();
            builder.Entity<MarkBlock>().HasIndex(mb => mb.Name).IsUnique();
            builder.Entity<MarkVal>().HasIndex(mv => new { mv.ApplicationId, mv.MarkId, mv.ExpertId }).IsUnique();

            // Должно быть одинаково с Field
            //builder.Entity<Table>().HasIndex(t => t.Name).IsUnique();
            builder.Entity<Table>().HasIndex(t => new { t.EditBlockId, t.Name }).IsUnique();
            builder.Entity<Table>().HasIndex(t => t.Number).IsUnique();

            builder.Entity<Track>().HasIndex(t => t.Number).IsUnique();
            builder.Entity<Track>().HasIndex(t => t.Name).IsUnique();
            builder.Entity<UserInfo>().HasIndex(ui => ui.Username).IsUnique();
        }

        private static void OnConfiguringData(ModelBuilder builder)
        {
            #region ApplicationStatuses

            var appStatus1 = new ApplicationStatus()
                { Id = Guid.NewGuid(), Number = 1, Status = "В ожидании заполнения" };
            var appStatus2 = new ApplicationStatus()
                { Id = Guid.NewGuid(), Number = 2, Status = "В ожидании рассмотрения" };
            var appStatus3 = new ApplicationStatus()
                { Id = Guid.NewGuid(), Number = 3, Status = "В процессе рассмотрения" };
            var appStatus4 = new ApplicationStatus()
                { Id = Guid.NewGuid(), Number = 4, Status = "Одобрена" };
            var appStatus5 = new ApplicationStatus()
                { Id = Guid.NewGuid(), Number = 5, Status = "Отклонена" };
            var appStatus6 = new ApplicationStatus()
                { Id = Guid.NewGuid(), Number = 6, Status = "Оценена" };

            #endregion

            #region Tracks

            var track1 = new Track() { Id = Guid.NewGuid(), Number = 1, Name = "Научно-педагогическая деятельность" };
            var track2 = new Track()
                { Id = Guid.NewGuid(), Number = 2, Name = "Научно-исследовательская деятельность" };

            #endregion

            #region Categories

            var category1 = new Category() { Id = Guid.NewGuid(), Number = 1, Name = "Строительство и архитектура" };
            var category2 = new Category()
                { Id = Guid.NewGuid(), Number = 2, Name = "Энергетика и нефтегазовая индустрия" };

            #endregion

            #region EditBlocks

            var editBlk1 = new EditBlock() { Id = Guid.NewGuid(), Number = 1, Name = "Общая информация" };
            var editBlk2 = new EditBlock() { Id = Guid.NewGuid(), Number = 2, Name = "Категория участников" };
            var editBlk3 = new EditBlock() { Id = Guid.NewGuid(), Number = 3, Name = "Конкурсная работа" };
            var editBlk4 = new EditBlock() { Id = Guid.NewGuid(), Number = 4, Name = "Профессиональное развитие" };
            var editBlk5 = new EditBlock()
                { Id = Guid.NewGuid(), Number = 5, Name = "Научно-педагогическая деятельность" };
            var editBlk6 = new EditBlock()
                { Id = Guid.NewGuid(), Number = 6, Name = "Научно-исследовательская деятельность" };

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

            #endregion

            #region ValuesType

            var valType1 = new ValuesType()
            {
                Id = Guid.NewGuid(),
                Name = "int",
            };
            var valType2 = new ValuesType()
            {
                Id = Guid.NewGuid(),
                Name = "string",
            };
            var valType3 = new ValuesType()
            {
                Id = Guid.NewGuid(),
                Name = "bool",
            };
            var valType4 = new ValuesType()
            {
                Id = Guid.NewGuid(),
                Name = "DateTime",
            };
            var valType5 = new ValuesType()
            {
                Id = Guid.NewGuid(),
                Name = "TextArea",
            };

            #endregion

            #region Tables

            #region Table1

            var tbl01 = new Table()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Краткая аннотация конкурсной работы",
                IsPrefilled = true,
                EditBlockId = editBlk3.Id,
                IsDisplayedOnVotingPage = true
            };

            #region Columns4Table1

            var col0101 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Название",
                ValueTypeId = valType2.Id,
                TableId = tbl01.Id,
            };
            var col0102 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Значение",
                ValueTypeId = valType5.Id,
                TableId = tbl01.Id,
                IsRequired = true
            };

            #endregion

            #region Rows4Table1

            var row0101 = new Row()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                Number = 1,
                TableId = tbl01.Id
            };

            #region Cells4Row0101

            var cell010101 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0101.Id,
                RowId = row0101.Id,
                Disable = true,
                IsPrefilled = true,
                Value = "Название работы"
            };

            var cell010102 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0102.Id,
                RowId = row0101.Id,
                IsPrefilled = true
            };

            #endregion

            var row0102 = new Row()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                Number = 2,
                TableId = tbl01.Id
            };

            #region Cells4Row0102

            var cell010201 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0101.Id,
                RowId = row0102.Id,
                Disable = true,
                IsPrefilled = true,
                Value = "Актуальность конкурсной работы"
            };

            var cell010202 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0102.Id,
                RowId = row0102.Id,
                IsPrefilled = true
            };

            #endregion

            var row0103 = new Row()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                Number = 4,
                TableId = tbl01.Id
            };

            #region Cells4Row0103

            var cell010301 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0101.Id,
                RowId = row0103.Id,
                Disable = true,
                IsPrefilled = true,
                Value = "Методология и методы, используемые в работе"
            };

            var cell010302 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0102.Id,
                RowId = row0103.Id,
                IsPrefilled = true
            };

            #endregion

            var row0104 = new Row()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                Number = 3,
                TableId = tbl01.Id
            };

            #region Cells4Row0104

            var cell010401 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0101.Id,
                RowId = row0104.Id,
                Disable = true,
                IsPrefilled = true,
                Value = "Инновационность"
            };

            var cell010402 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0102.Id,
                RowId = row0104.Id,
                IsPrefilled = true
            };

            #endregion

            var row0105 = new Row()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                Number = 6,
                TableId = tbl01.Id
            };

            #region Cells4Row0105

            var cell010501 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0101.Id,
                RowId = row0105.Id,
                Disable = true,
                IsPrefilled = true,
                Value =
                    "Апробация"
            };

            var cell010502 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0102.Id,
                RowId = row0105.Id,
                IsPrefilled = true
            };

            #endregion

            var row0106 = new Row()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                Number = 8,
                TableId = tbl01.Id
            };

            #region Cells4Row0106

            var cell010601 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0101.Id,
                RowId = row0106.Id,
                Disable = true,
                IsPrefilled = true,
                Value = "Результаты и выводы"
            };

            var cell010602 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0102.Id,
                RowId = row0106.Id,
                IsPrefilled = true
            };

            #endregion

            var row0107 = new Row()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                Number = 7,
                TableId = tbl01.Id
            };

            #region Cells4Row0107

            var cell010701 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0101.Id,
                RowId = row0107.Id,
                Disable = true,
                IsPrefilled = true,
                Value = "Рекомендации и перспективы дальнейшей разработки темы"
            };

            var cell010702 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0102.Id,
                RowId = row0107.Id,
                IsPrefilled = true
            };

            #endregion

            var row0108 = new Row()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                Number = 5,
                TableId = tbl01.Id
            };

            #region Cells4Row0108

            var cell010801 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0101.Id,
                RowId = row0108.Id,
                Disable = true,
                IsPrefilled = true,
                Value = "Ссылка на конкурсную работу"
            };

            var cell010802 = new CellVal()
            {
                Id = Guid.NewGuid(),
                ColumnId = col0102.Id,
                RowId = row0108.Id,
                IsPrefilled = true
            };

            #endregion

            #endregion

            #endregion

            #region Table2

            var tbl02 = new Table()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name =
                    "Награждение премиями, наградами в области научно-педагогической/научно-исследовательской деятельности " +
                    "городского, всероссийского или международного уровня (в том числе зарубежными), " +
                    "победы в профессиональных конкурсах за весь период деятельности",
                EditBlockId = editBlk4.Id
            };

            #region Columns4Table2

            var col0201 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Год",
                ValueTypeId = valType1.Id,
                TableId = tbl02.Id
            };
            var col0202 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Название конкурса",
                ValueTypeId = valType2.Id,
                TableId = tbl02.Id
            };
            var col0203 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 3,
                Name = "Статус конкурса",
                ValueTypeId = valType2.Id,
                TableId = tbl02.Id
            };
            var col0204 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 4,
                Name = "Награда (медаль, диплом с указанием степени)",
                ValueTypeId = valType2.Id,
                TableId = tbl02.Id
            };
            var col0205 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 5,
                Name = "Ссылка",
                ValueTypeId = valType2.Id,
                TableId = tbl02.Id
            };

            #endregion

            #endregion

            #region Table3

            var tbl03 = new Table()
            {
                Id = Guid.NewGuid(),
                Number = 3,
                Name = "Сведения о профессиональном развитии участника конкурса за последние 5 лет " +
                       "(курсы повышения квалификации/ стажировки)",
                EditBlockId = editBlk4.Id
            };

            #region Columns4Table2

            var col0301 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Название документа, реквизиты",
                ValueTypeId = valType2.Id,
                TableId = tbl03.Id
            };
            var col0302 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Год получения документа",
                ValueTypeId = valType1.Id,
                TableId = tbl03.Id
            };

            #endregion

            #endregion

            #region Table4

            var tbl04 = new Table()
            {
                Id = Guid.NewGuid(),
                Number = 4,
                Name = "Персональные идентификаторы",
                EditBlockId = editBlk4.Id,
                IsPrefilled = true,
                IsDisplayedOnVotingPage = true
            };

            #region Columns4Table4

            var col0401 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Тип идентификатора",
                ValueTypeId = valType2.Id,
                TableId = tbl04.Id,
                IsRequired = false
            };
            var col0402 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Идентификатор",
                ValueTypeId = valType2.Id,
                TableId = tbl04.Id,
                IsRequired = false
            };

            #endregion

            #region Rows4Table4

            var row0401 = new Row()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                Number = 1,
                TableId = tbl04.Id
            };

            #region Cells4Row0401

            var cell040101 = new CellVal()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                RowId = row0401.Id,
                ColumnId = col0401.Id,
                Disable = true,
                Value = "ScopusID"
            };
            var cell040102 = new CellVal()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                RowId = row0401.Id,
                ColumnId = col0402.Id,
                Disable = false
            };

            #endregion

            var row0402 = new Row()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                Number = 2,
                TableId = tbl04.Id
            };

            #region Cells4Row0402

            var cell040201 = new CellVal()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                RowId = row0402.Id,
                ColumnId = col0401.Id,
                Disable = true,
                Value = "ORCiD"
            };
            var cell040202 = new CellVal()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                RowId = row0402.Id,
                ColumnId = col0402.Id,
                Disable = false
            };

            #endregion

            var row0403 = new Row()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                Number = 3,
                TableId = tbl04.Id
            };

            #region Cells4Row0403

            var cell040301 = new CellVal()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                RowId = row0403.Id,
                ColumnId = col0401.Id,
                Disable = true,
                Value = "ResearcherID"
            };
            var cell040302 = new CellVal()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                RowId = row0403.Id,
                ColumnId = col0402.Id,
                Disable = false
            };

            #endregion

            var row0404 = new Row()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                Number = 4,
                TableId = tbl04.Id
            };

            #region Cells4Row0404

            var cell040401 = new CellVal()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                RowId = row0404.Id,
                ColumnId = col0401.Id,
                Disable = true,
                Value = "РИНЦ AuthorID"
            };
            var cell040402 = new CellVal()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                RowId = row0404.Id,
                ColumnId = col0402.Id,
                Disable = false
            };

            #endregion

            var row0405 = new Row()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                Number = 5,
                TableId = tbl04.Id
            };

            #region Cells4Row0405

            var cell040501 = new CellVal()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                RowId = row0405.Id,
                ColumnId = col0401.Id,
                Disable = true,
                Value = "Google Scholar ID"
            };
            var cell040502 = new CellVal()
            {
                Id = Guid.NewGuid(),
                IsPrefilled = true,
                RowId = row0405.Id,
                ColumnId = col0402.Id,
                Disable = false
            };

            #endregion

            #endregion

            #endregion

            #region Table5

            var tbl05 = new Table()
            {
                Id = Guid.NewGuid(),
                Number = 5,
                Name = "Учебная нагрузка за предыдущий учебный год (за исключением методической)",
                EditBlockId = editBlk5.Id
            };

            #region Columns4Table3

            var col0501 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Наименование курса",
                ValueTypeId = valType2.Id,
                TableId = tbl05.Id
            };
            var col0502 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Язык преподавания",
                ValueTypeId = valType2.Id,
                TableId = tbl05.Id
            };
            var col0503 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 3,
                Name = "Лекции (час.)",
                ValueTypeId = valType1.Id,
                TableId = tbl05.Id
            };
            var col0504 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 4,
                Name = "Практические занятия (час.)",
                ValueTypeId = valType1.Id,
                TableId = tbl05.Id
            };
            var col0505 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 5,
                Name = "Итого (час.)",
                ValueTypeId = valType1.Id,
                TableId = tbl05.Id
            };

            #endregion

            #endregion

            #region Table6

            var tbl06 = new Table()
            {
                Id = Guid.NewGuid(),
                Number = 6,
                Name =
                    "Список подготовленных под руководством участника конкурса студентов, бакалавров, " +
                    "магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, " +
                    "получивших самостоятельное признание (победители и призеры всероссийских и" +
                    "международных соревнований, конкурсов, олимпиад; лауреаты международных премий, " +
                    "премий Российской Федерации, региональных премий (за исключением внутривузовских конкурсов), " +
                    "за весь период научно-педагогической деятельности",
                EditBlockId = editBlk5.Id
            };

            #region Columns4Table6

            var col0601 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "ФИО",
                ValueTypeId = valType2.Id,
                TableId = tbl06.Id
            };
            var col0602 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Название конкурса/премии",
                ValueTypeId = valType2.Id,
                TableId = tbl06.Id
            };
            var col0603 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 3,
                Name = "Год",
                ValueTypeId = valType1.Id,
                TableId = tbl06.Id
            };
            var col0604 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 4,
                Name = "Статус конкурса (международный, всероссийский), статус награды (РФ, субъект РФ)",
                ValueTypeId = valType2.Id,
                TableId = tbl06.Id
            };
            var col0605 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 5,
                Name = "Награда/премия (медаль, диплом с указанием степени)",
                ValueTypeId = valType2.Id,
                TableId = tbl06.Id
            };

            #endregion

            #endregion

            #region Table7

            var tbl07 = new Table()
            {
                Id = Guid.NewGuid(),
                Number = 7,
                Name =
                    "Список трудов участника конкурса. Монографии, учебники, учебные и учебно-методические " +
                    "пособия с грифами и без грифов УМО, Министерств РФ или государственных академий наук, " +
                    "либо аналогичных работы на иностранном языке без грифов УМО, " +
                    "изданные типографским способом за последние 5 лет",
                EditBlockId = editBlk5.Id
            };

            #region Columns4Table7

            var col0701 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Вид публикации",
                ValueTypeId = valType2.Id,
                TableId = tbl07.Id
            };
            var col0702 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Название",
                ValueTypeId = valType2.Id,
                TableId = tbl07.Id
            };
            var col0703 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 3,
                Name = "Соавторы",
                ValueTypeId = valType2.Id,
                TableId = tbl07.Id,
                IsRequired = false
            };
            var col0704 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 4,
                Name = "Количество печатных листов",
                ValueTypeId = valType1.Id,
                TableId = tbl07.Id
            };
            var col0705 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 5,
                Name = "Наличие грифа",
                ValueTypeId = valType3.Id,
                TableId = tbl07.Id
            };
            var col0706 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 6,
                Name = "Издательство, год",
                ValueTypeId = valType2.Id,
                TableId = tbl07.Id
            };
            var col0707 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 7,
                Name = "Язык публикации",
                ValueTypeId = valType2.Id,
                TableId = tbl07.Id
            };
            var col0708 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 8,
                Name = "Ссылка на открытый доступ",
                ValueTypeId = valType2.Id,
                TableId = tbl07.Id
            };

            #endregion

            #endregion

            #region Table8

            var tbl08 = new Table()
            {
                Id = Guid.NewGuid(),
                Number = 8,
                Name = "Список лабораторных практикумов и курсов лекций" +
                       " (разработанных самостоятельно участником конкурса) за последние 5 лет",
                EditBlockId = editBlk5.Id
            };

            #region Columns4Table9

            var col0801 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Название дисциплины",
                ValueTypeId = valType2.Id,
                TableId = tbl08.Id
            };
            var col0802 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Вид",
                ValueTypeId = valType2.Id,
                TableId = tbl08.Id
            };
            var col0803 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 3,
                Name = "Ссылка на подтверждающий документ (в качестве подтверждения может быть выписка" +
                       " из учебной нагрузки по форме организации или ссылка на онлайн платформу с курсом лекций, например, «Открытое образование»)",
                ValueTypeId = valType2.Id,
                TableId = tbl08.Id
            };

            #endregion

            #endregion

            #region Table9

            var tbl9 = new Table()
            {
                Id = Guid.NewGuid(),
                Number = 9,
                Name = "Список разработанных онлайн-курсов на открытых платформах за последние 5 лет",
                EditBlockId = editBlk5.Id
            };

            #region Columns4Table9

            var col0901 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Название курса",
                ValueTypeId = valType2.Id,
                TableId = tbl9.Id
            };
            var col0902 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Соавторы",
                ValueTypeId = valType2.Id,
                TableId = tbl9.Id
            };
            var col0903 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 3,
                Name = "Ссылка на платформу",
                ValueTypeId = valType2.Id,
                TableId = tbl9.Id
            };
            var col0904 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 4,
                Name = "Год",
                ValueTypeId = valType1.Id,
                TableId = tbl9.Id
            };

            #endregion

            #endregion

            #region Table10

            var tbl10 = new Table()
            {
                Id = Guid.NewGuid(),
                Number = 10,
                Name = "Список научных публикаций за последние 5 лет",
                EditBlockId = editBlk6.Id
            };

            #region Columns4Table11

            var col1001 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Название статьи",
                ValueTypeId = valType2.Id,
                TableId = tbl10.Id
            };
            var col1002 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Соавторы",
                ValueTypeId = valType2.Id,
                TableId = tbl10.Id
            };
            var col1003 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 3,
                Name = "Тип публикации (категория ВАК/квартиль МБД)",
                ValueTypeId = valType2.Id,
                TableId = tbl10.Id
            };
            var col1004 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 4,
                Name = "Издание, год",
                ValueTypeId = valType2.Id,
                TableId = tbl10.Id
            };

            #endregion

            #endregion

            #region Table11

            var tbl11 = new Table()
            {
                Id = Guid.NewGuid(),
                Number = 11,
                Name =
                    "Список выполненных НИР / НИОКР с финансированием в размере от 200 тыс. руб. и выше за последние 5 лет",
                EditBlockId = editBlk6.Id
            };

            #region Columns4Table11

            var col1101 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Название НИР/НИОКР",
                ValueTypeId = valType2.Id,
                TableId = tbl11.Id
            };
            var col1102 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Сумма финансирования (тыс. руб.)",
                ValueTypeId = valType1.Id,
                TableId = tbl11.Id
            };
            var col1103 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 3,
                Name = "Период выполнения",
                ValueTypeId = valType2.Id,
                TableId = tbl11.Id
            };
            var col1104 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 4,
                Name = "Статус",
                ValueTypeId = valType2.Id,
                TableId = tbl11.Id
            };
            var col1105 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 5,
                Name = "Регистрационный номер карты в системе ЕГИСУ (https://www.rosrid.ru/)",
                ValueTypeId = valType2.Id,
                TableId = tbl11.Id
            };

            #endregion

            #endregion

            #region Table12

            var tbl12 = new Table()
            {
                Id = Guid.NewGuid(),
                Number = 12,
                Name =
                    "Список объектов интеллектуальной собственности, " +
                    "созданных участником конкурса за весь период научно-педагогической деятельности " +
                    "(созданных самостоятельно / в соавторстве), " +
                    "официально зарегистрированных в установленном порядке (в России / за рубежом)",
                EditBlockId = editBlk6.Id
            };

            #region Columns4Table12

            var col1201 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Вид",
                ValueTypeId = valType2.Id,
                TableId = tbl12.Id
            };
            var col1202 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Название",
                ValueTypeId = valType2.Id,
                TableId = tbl12.Id
            };
            var col1203 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 3,
                Name = "ФИО соавторов",
                ValueTypeId = valType2.Id,
                TableId = tbl12.Id
            };
            var col1204 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 4,
                Name = "Номер РИД",
                ValueTypeId = valType2.Id,
                TableId = tbl12.Id
            };

            #endregion

            #endregion

            #region Table13

            var tbl13 = new Table()
            {
                Id = Guid.NewGuid(),
                Number = 13,
                Name = "Перечень разработок, " +
                       "внедренных на предприятиях и организациях реального сектора экономики (в России / за рубежом)",
                EditBlockId = editBlk6.Id
            };

            #region Columns4Table13

            var col1301 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Вид",
                ValueTypeId = valType2.Id,
                TableId = tbl13.Id
            };
            var col1302 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Название разработки",
                ValueTypeId = valType2.Id,
                TableId = tbl13.Id
            };
            var col1303 = new Column()
            {
                Id = Guid.NewGuid(),
                Number = 3,
                Name = "Название организации в которую внедрена разработка",
                ValueTypeId = valType2.Id,
                TableId = tbl13.Id
            };

            #endregion

            #endregion

            #endregion

            #region Fields

            var fld1 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "ФИО",
                Placeholder = "Иванов Иван Иванович",
                ValueTypeId = valType2.Id,
                EditBlockId = editBlk1.Id
            };
            var fld2 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Дата рождения",
                Placeholder = "01.01.2000",
                ValueTypeId = valType4.Id,
                EditBlockId = editBlk1.Id
            };
            var fld3 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 3,
                Name = "Домашний адрес",
                Placeholder = "Регион, город, улица, дом, квартира",
                ValueTypeId = valType2.Id,
                EditBlockId = editBlk1.Id
            };
            var fld4 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 4,
                Name = "Контактный телефон",
                Placeholder = "89007005050",
                ValueTypeId = valType1.Id,
                EditBlockId = editBlk1.Id
            };
            var fld5 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 5,
                Name = "Электронная почта",
                Placeholder = "user@example.com",
                ValueTypeId = valType2.Id,
                EditBlockId = editBlk1.Id
            };
            var fld6 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 6,
                Name = "Место работы",
                Placeholder = "Название организации",
                ValueTypeId = valType2.Id,
                EditBlockId = editBlk1.Id,
                IsDisplayedOnVotingPage = true
            };
            var fld7 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 7,
                Name = "Адрес работы",
                Placeholder = "Регион, город, улица, дом",
                ValueTypeId = valType2.Id,
                EditBlockId = editBlk1.Id
            };
            var fld8 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 8,
                Name = "Институт, факультет, кафедра, лаборатория",
                Placeholder = "Введите институт, факультет, кафедру, лабораторию",
                ValueTypeId = valType2.Id,
                EditBlockId = editBlk1.Id,
                IsDisplayedOnVotingPage = true
            };
            var fld9 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 9,
                Name = "Должность",
                Placeholder = "Введите свою должность в организации",
                ValueTypeId = valType2.Id,
                EditBlockId = editBlk1.Id,
                IsDisplayedOnVotingPage = true
            };
            var fld10 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 10,
                Name = "Стаж научно-педагогической/научно-исследовательской деятельности по трудовой книжке",
                Placeholder = "Введите свой стаж",
                ValueTypeId = valType1.Id,
                EditBlockId = editBlk1.Id,
                IsDisplayedOnVotingPage = true
            };
            var fld11 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 11,
                Name = "Ученое звание",
                Placeholder = "Выберите ученое звание",
                ValueTypeId = valType2.Id,
                EditBlockId = editBlk2.Id,
                IsDisplayedOnVotingPage = true
            };
            var fld12 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 12,
                Name = "Ученая степень",
                Placeholder = "Выберите ученую степень",
                ValueTypeId = valType2.Id,
                EditBlockId = editBlk2.Id,
                IsDisplayedOnVotingPage = true
            };
            var fld13 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 13,
                Name = "Научная специальность (по классификации ВАК)",
                Placeholder = "Введите научную специальность (по классификации ВАК)",
                ValueTypeId = valType2.Id,
                EditBlockId = editBlk2.Id
            };
            var fld14 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 14,
                Name = "Защитившиеся кадидаты наук",
                Placeholder = "Введите количество",
                EditGroup =
                    "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-педагогической деятельности",
                ValueTypeId = valType1.Id,
                EditBlockId = editBlk5.Id
            };
            var fld15 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 15,
                Name = "Защитившиеся доктора наук",
                Placeholder = "Введите количество",
                ValueTypeId = valType1.Id,
                EditBlockId = editBlk5.Id
            };
            var fld16 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 16,
                Name = "Защитившиеся бакалавры, специалисты, магистры",
                Placeholder = "Введите количество",
                EditGroup = "Руководство дипломными проектами за предыдущий учебный год",
                ValueTypeId = valType1.Id,
                EditBlockId = editBlk5.Id
            };
            var fld17 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 17,
                Name = "Защитившиеся кандидаты наук",
                Placeholder = "Введите количество",
                EditGroup =
                    "Список подготовленных под руководством участника конкурса аспирантов (докторантов) за последние 5 лет научно-исследовательской деятельности",
                ValueTypeId = valType1.Id,
                EditBlockId = editBlk6.Id
            };
            var fld18 = new Field()
            {
                Id = Guid.NewGuid(),
                Number = 18,
                Name = "Защитившиеся доктора наук",
                Placeholder = "Введите количество",
                ValueTypeId = valType1.Id,
                EditBlockId = editBlk6.Id
            };

            #endregion

            #region SelectValues

            var slctVall1 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Нет",
                FieldId = fld11.Id
            };
            var slctVall2 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Доцент",
                FieldId = fld11.Id
            };
            var slctVall3 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Профессор",
                FieldId = fld11.Id
            };
            var slctVall4 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Кандидат наук",
                FieldId = fld12.Id
            };
            var slctVall5 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Доктор наук",
                FieldId = fld12.Id
            };
            var slctVall6 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Региональный",
                ColumnId = col0203.Id
            };
            var slctVall7 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Всероссийский",
                ColumnId = col0203.Id
            };
            var slctVall8 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Международный",
                ColumnId = col0203.Id
            };
            var slctVall9 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Учебное и/или учебно-методическое пособие",
                ColumnId = col0701.Id
            };
            var slctVall10 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Учебник",
                ColumnId = col0701.Id
            };
            var slctVall11 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Монография",
                ColumnId = col0701.Id
            };
            var slctVall12 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Лекции",
                ColumnId = col0802.Id
            };
            var slctVall13 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Лабораторные",
                ColumnId = col0802.Id
            };
            var slctVall14 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Руководитель",
                ColumnId = col1104.Id
            };
            var slctVall15 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Исполнитель",
                ColumnId = col1104.Id
            };
            var slctVall16 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Изобретение",
                ColumnId = col1201.Id
            };
            var slctVall17 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Полезная модель",
                ColumnId = col1201.Id
            };
            var slctVall18 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Программы для ЭВМ и базы данных",
                ColumnId = col1201.Id
            };
            var slctVall19 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Промышленный образец",
                ColumnId = col1201.Id
            };
            var slctVall20 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Изобретение",
                ColumnId = col1301.Id
            };
            var slctVall21 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Полезная модель",
                ColumnId = col1301.Id
            };
            var slctVall22 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Программы для ЭВМ и базы данных",
                ColumnId = col1301.Id
            };
            var slctVall23 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Промышленный образец",
                ColumnId = col1301.Id
            };
            var slctVall24 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Есть",
                ColumnId = col0703.Id
            };
            var slctVall25 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Нет",
                ColumnId = col0703.Id
            };
            var slctVall26 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Русский",
                ColumnId = col0707.Id
            };
            var slctVall27 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Иностранный",
                ColumnId = col0707.Id
            };
            var slctVall28 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Есть",
                ColumnId = col1002.Id
            };
            var slctVall29 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Нет",
                ColumnId = col1002.Id
            };
            var slctVall30 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "РИНЦ",
                ColumnId = col1003.Id
            };
            var slctVall31 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "ВАК (К2-К3)",
                ColumnId = col1003.Id
            };
            var slctVall32 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "МБД (Q3-Q4)",
                ColumnId = col1003.Id
            };
            var slctVall33 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "ВАК (К1), МБД (Q1-Q2)",
                ColumnId = col1003.Id
            };
            var slctVall34 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Русский",
                ColumnId = col0502.Id
            };
            var slctVall35 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Английский",
                ColumnId = col0502.Id
            };
            var slctVall36 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Другой",
                ColumnId = col0502.Id
            };
            var slctVall37 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Есть",
                ColumnId = col0705.Id
            };
            var slctVall38 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Нет",
                ColumnId = col0705.Id
            };
            var slctVall39 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Есть",
                ColumnId = col0902.Id
            };
            var slctVall40 = new SelectValue()
            {
                Id = Guid.NewGuid(),
                Value = "Нет",
                ColumnId = col0902.Id
            };

            #endregion

            #region Marks

            var mark1 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 1,
                Name = "Баллы за объем учебной нагрузки:",
                TableId = tbl05.Id,
                MaxValue = 3,
                EvaluationMethodName = "EvaluateMark1"
            };
            var mark2 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 2,
                Name = "Баллы за количество дисциплин на иностранном языке," +
                       " которые вел претендент, в предыдущем учебном году:",
                TableId = tbl05.Id,
                MaxValue = 2,
                EvaluationMethodName = "EvaluateMark2"
            };
            var mark3 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 3,
                Name = "Баллы за количество квалификационных работ, " +
                       "выполненных под руководством претендента:",
                FieldId = fld16.Id,
                MaxValue = 5,
                EvaluationMethodName = "EvaluateMark3"
            };
            var mark4 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 4,
                Name = "Баллы за количество защитившихся кандидатов наук:",
                FieldId = fld14.Id,
                MaxValue = 6,
                EvaluationMethodName = "EvaluateMark4"
            };
            var mark5 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 5,
                Name = "Баллы за количество защитившихся докторов наук:",
                FieldId = fld15.Id,
                MaxValue = 10,
                EvaluationMethodName = "EvaluateMark5"
            };
            var mark6 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 6,
                Name = "Баллы за количество подготовленных студентов, бакалавров, " +
                       "магистров/специалистов, аспирантов, адъюнктов, ординаторов, докторантов, получивших самостоятельное признание:",
                TableId = tbl06.Id,
                MaxValue = 5,
                EvaluationMethodName = "EvaluateMark6"
            };
            var mark7 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 7,
                Name = "Баллы за количество онлайн курсов на открытых площадках:",
                TableId = tbl9.Id,
                MaxValue = 5,
                EvaluationMethodName = "EvaluateMark7"
            };
            var mark8 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 8,
                Name = "Баллы за труды с грифом и без соавторства:",
                TableId = tbl07.Id,
                MaxValue = 4,
                EvaluationMethodName = "EvaluateMark8"
            };
            var mark9 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 9,
                Name = "Баллы за труды с грифом в соавторстве:",
                TableId = tbl07.Id,
                MaxValue = 3,
                EvaluationMethodName = "EvaluateMark9"
            };
            var mark10 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 10,
                Name = "Баллы за труды без грифа и без соавторства:",
                TableId = tbl07.Id,
                MaxValue = 2,
                EvaluationMethodName = "EvaluateMark10"
            };
            var mark11 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 11,
                Name = "Баллы за труды без грифа в соавторстве:",
                TableId = tbl07.Id,
                MaxValue = 2,
                EvaluationMethodName = "EvaluateMark11"
            };
            var mark12 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 12,
                Name = "Баллы за количество практикумов и курсов лекций:",
                TableId = tbl08.Id,
                MaxValue = 4,
                EvaluationMethodName = "EvaluateMark12"
            };
            var mark13 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 13,
                Name = "Баллы за ученое звание:",
                FieldId = fld11.Id,
                MaxValue = 5,
                EvaluationMethodName = "EvaluateMark13"
            };
            var mark14 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 14,
                Name = "Баллы за награды:",
                TableId = tbl02.Id,
                MaxValue = 2,
                EvaluationMethodName = "EvaluateMark14"
            };
            var mark15 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 15,
                Name = "Баллы за профессиональное развитие:",
                TableId = tbl03.Id,
                MaxValue = 2,
                EvaluationMethodName = "EvaluateMark15"
            };
            var mark16 = new Mark() //todo!!!!!
            {
                Id = Guid.NewGuid(),
                Number = 16,
                Name = "Баллы за научные публикации:",
                TableId = tbl10.Id,
                MaxValue = 8,
                EvaluationMethodName = "EvaluateMark16"
            };
            var mark19 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 19,
                Name = "Баллы за количество защитившихся кандидатов наук:",
                FieldId = fld17.Id,
                MaxValue = 8,
                EvaluationMethodName = "EvaluateMark19"
            };
            var mark20 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 20,
                Name = "Баллы за количество защитившихся докторов наук:",
                FieldId = fld18.Id,
                MaxValue = 12,
                EvaluationMethodName = "EvaluateMark20"
            };
            var mark21 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 21,
                Name = "Баллы за выполненные НИР/НИОКР в качестве руководителя:",
                TableId = tbl11.Id,
                MaxValue = 8,
                EvaluationMethodName = "EvaluateMark21"
            };
            var mark22 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 22,
                Name = "Баллы за выполненные НИР/НИОКР в качестве исполнителя:",
                TableId = tbl11.Id,
                MaxValue = 5,
                EvaluationMethodName = "EvaluateMark22"
            };
            var mark23 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 23,
                Name = "Баллы за количество объектов интеллектуальной собственности:",
                TableId = tbl12.Id,
                MaxValue = 5,
                EvaluationMethodName = "EvaluateMark23"
            };
            var mark24 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 24,
                Name = "Баллы за количество разработок:",
                TableId = tbl13.Id,
                MaxValue = 5,
                EvaluationMethodName = "EvaluateMark24"
            };
            var mark25 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 25,
                Name = "Оценка уровня предоставленной работы:",
                IsAuto = false,
                TableId = tbl01.Id,
                MaxValue = 15
            };
            var mark26 = new Mark()
            {
                Id = Guid.NewGuid(),
                Number = 26,
                Name = "Использование в представленной работе" +
                       " инновационных методов (проблемного и проективного обучения, " +
                       "тренинговых форм, модульно-кредитных, модульно-рейтинговых систем обучения и контроля знаний):",
                IsAuto = false,
                TableId = tbl01.Id,
                MaxValue = 15
            };

            #endregion

            #region Roles

            var role1 = new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "Voter", NormalizedName = "VOTER" };
            var role2 = new IdentityRole()
                { Id = Guid.NewGuid().ToString(), Name = "Participant", NormalizedName = "PARTICIPANT" };
            var role3 = new IdentityRole()
                { Id = Guid.NewGuid().ToString(), Name = "Expert", NormalizedName = "EXPERT" };
            var role4 = new IdentityRole()
                { Id = Guid.NewGuid().ToString(), Name = "Organiser", NormalizedName = "ORGANISER" };
            var role5 = new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "Admin", NormalizedName = "ADMIN" };

            #endregion

            var feedback1 = new FeedBack() { Id = Guid.NewGuid(), Name = "SYSTEM", Email = "system@system.ru", Message="Test Message for System" };
            builder.Entity<FeedBack>()
                .HasData([feedback1]);

            builder.Entity<ApplicationStatus>()
                .HasData([appStatus1, appStatus2, appStatus3, appStatus4, appStatus5, appStatus6]);
            builder.Entity<Category>().HasData([category1, category2]);
            builder.Entity<ValuesType>().HasData([valType1, valType2, valType3, valType4, valType5]);
            builder.Entity<Track>().HasData([track1, track2]);
            builder.Entity<EditBlock>().HasData([editBlk1, editBlk2, editBlk3, editBlk4, editBlk5, editBlk6]);
            builder.Entity<MarkBlock>().HasData([markBlk1, markBlk2, markBlk3, markBlk4, markBlk5, markBlk6, markBlk7]);
            builder.Entity<Table>().HasData([
                tbl01, tbl02, tbl03, tbl04, tbl05, tbl06, tbl07, tbl08, tbl9, tbl10, tbl11, tbl12, tbl13
            ]);
            builder.Entity<Column>().HasData([
                col0101, col0102,
                col0201, col0202, col0203, col0204, col0205,
                col0301, col0302,
                col0401, col0402,
                col0501, col0502, col0503, col0504, col0505,
                col0601, col0602, col0603, col0604, col0605,
                col0701, col0702, col0703, col0704, col0705, col0706, col0707, col0708,
                col0801, col0802, col0803,
                col0901, col0902, col0903, col0904,
                col1001, col1002, col1003, col1004,
                col1101, col1102, col1103, col1104, col1105,
                col1201, col1202, col1203, col1204,
                col1301, col1302, col1303
            ]);
            builder.Entity<Row>().HasData(
            [
                row0101, row0102, row0103, row0104, row0105, row0106, row0107, row0108,
                row0401, row0402, row0403, row0404, row0405
            ]);
            builder.Entity<CellVal>().HasData([
                cell010101, cell010102,
                cell010201, cell010202,
                cell010301, cell010302,
                cell010401, cell010402,
                cell010501, cell010502,
                cell010601, cell010602,
                cell010701, cell010702,
                cell010801, cell010802,

                cell040101, cell040102,
                cell040201, cell040202,
                cell040301, cell040302,
                cell040401, cell040402,
                cell040501, cell040502
            ]);
            builder.Entity<SelectValue>().HasData([
                slctVall1, slctVall2, slctVall3, slctVall4, slctVall5, slctVall6, slctVall7,
                slctVall8, slctVall9, slctVall10, slctVall11, slctVall12, slctVall13, slctVall14, slctVall15,
                slctVall16,
                slctVall17, slctVall18, slctVall19, slctVall20, slctVall21, slctVall22, slctVall23, slctVall24,
                slctVall25,
                slctVall26, slctVall27, slctVall28, slctVall29, slctVall30, slctVall31, slctVall32, slctVall33,
                slctVall34,
                slctVall35, slctVall36, slctVall37, slctVall38, slctVall39, slctVall40
            ]);
            builder.Entity<Field>().HasData([
                fld1, fld2, fld3, fld4, fld5, fld6, fld7, fld8, fld9, fld10,
                fld11, fld12, fld13, fld14, fld15, fld16, fld17, fld18
            ]);
            builder.Entity<Mark>().HasData([
                mark1, mark2, mark3, mark4, mark5, mark6, mark7, mark8, mark9, mark10, mark11, mark12, mark13, mark14,
                mark15, mark16, mark19, mark20, mark21, mark22, mark23, mark24, mark25, mark26,
            ]);
            builder.Entity<IdentityRole>().HasData([role1, role2, role3, role4, role5]);

            builder.Entity<Track>().HasMany(e => e.EditBlocks).WithMany(e => e.Tracks)
                .UsingEntity(j => j.HasData([
                        new { TracksId = track1.Id, EditBlocksId = editBlk1.Id },
                        new { TracksId = track1.Id, EditBlocksId = editBlk2.Id },
                        new { TracksId = track1.Id, EditBlocksId = editBlk3.Id },
                        new { TracksId = track1.Id, EditBlocksId = editBlk4.Id },
                        new { TracksId = track1.Id, EditBlocksId = editBlk5.Id },
                        new { TracksId = track2.Id, EditBlocksId = editBlk1.Id },
                        new { TracksId = track2.Id, EditBlocksId = editBlk2.Id },
                        new { TracksId = track2.Id, EditBlocksId = editBlk3.Id },
                        new { TracksId = track2.Id, EditBlocksId = editBlk4.Id },
                        new { TracksId = track2.Id, EditBlocksId = editBlk6.Id },
                    ])
                );
            builder.Entity<Track>().HasMany(e => e.MarkBlocks).WithMany(e => e.Tracks)
                .UsingEntity(j => j.HasData([
                        new { TracksId = track1.Id, MarkBlocksId = markBlk1.Id },
                        new { TracksId = track1.Id, MarkBlocksId = markBlk2.Id },
                        new { TracksId = track1.Id, MarkBlocksId = markBlk3.Id },
                        new { TracksId = track1.Id, MarkBlocksId = markBlk4.Id },
                        new { TracksId = track1.Id, MarkBlocksId = markBlk7.Id },
                        new { TracksId = track2.Id, MarkBlocksId = markBlk1.Id },
                        new { TracksId = track2.Id, MarkBlocksId = markBlk5.Id },
                        new { TracksId = track2.Id, MarkBlocksId = markBlk6.Id },
                        new { TracksId = track2.Id, MarkBlocksId = markBlk7.Id }
                    ])
                );
            builder.Entity<MarkBlock>().HasMany(e => e.Tables).WithMany(e => e.MarkBlocks)
                .UsingEntity(j => j.HasData([
                    new { MarkBlocksId = markBlk2.Id, TablesId = tbl05.Id },
                    new { MarkBlocksId = markBlk2.Id, TablesId = tbl06.Id },
                    new { MarkBlocksId = markBlk2.Id, TablesId = tbl9.Id },
                    new { MarkBlocksId = markBlk3.Id, TablesId = tbl07.Id },
                    new { MarkBlocksId = markBlk3.Id, TablesId = tbl08.Id },
                    new { MarkBlocksId = markBlk4.Id, TablesId = tbl02.Id },
                    new { MarkBlocksId = markBlk4.Id, TablesId = tbl03.Id },
                    new { MarkBlocksId = markBlk5.Id, TablesId = tbl02.Id },
                    new { MarkBlocksId = markBlk5.Id, TablesId = tbl10.Id },
                    new { MarkBlocksId = markBlk5.Id, TablesId = tbl11.Id },
                    new { MarkBlocksId = markBlk5.Id, TablesId = tbl04.Id },
                    new { MarkBlocksId = markBlk6.Id, TablesId = tbl03.Id },
                    new { MarkBlocksId = markBlk6.Id, TablesId = tbl12.Id },
                    new { MarkBlocksId = markBlk6.Id, TablesId = tbl13.Id },
                    new { MarkBlocksId = markBlk7.Id, TablesId = tbl01.Id }
                ]));
            builder.Entity<MarkBlock>().HasMany(e => e.Fields).WithMany(e => e.MarkBlocks)
                .UsingEntity(j => j.HasData([
                    new { MarkBlocksId = markBlk1.Id, FieldsId = fld1.Id },
                    new { MarkBlocksId = markBlk1.Id, FieldsId = fld2.Id },
                    new { MarkBlocksId = markBlk1.Id, FieldsId = fld3.Id },
                    new { MarkBlocksId = markBlk1.Id, FieldsId = fld4.Id },
                    new { MarkBlocksId = markBlk1.Id, FieldsId = fld5.Id },
                    new { MarkBlocksId = markBlk1.Id, FieldsId = fld6.Id },
                    new { MarkBlocksId = markBlk1.Id, FieldsId = fld7.Id },
                    new { MarkBlocksId = markBlk1.Id, FieldsId = fld8.Id },
                    new { MarkBlocksId = markBlk1.Id, FieldsId = fld9.Id },
                    new { MarkBlocksId = markBlk1.Id, FieldsId = fld10.Id },
                    new { MarkBlocksId = markBlk1.Id, FieldsId = fld11.Id },
                    new { MarkBlocksId = markBlk1.Id, FieldsId = fld12.Id },
                    new { MarkBlocksId = markBlk1.Id, FieldsId = fld13.Id },
                    new { MarkBlocksId = markBlk2.Id, FieldsId = fld14.Id },
                    new { MarkBlocksId = markBlk2.Id, FieldsId = fld15.Id },
                    new { MarkBlocksId = markBlk2.Id, FieldsId = fld16.Id },
                    new { MarkBlocksId = markBlk4.Id, FieldsId = fld11.Id },
                    new { MarkBlocksId = markBlk5.Id, FieldsId = fld11.Id },
                    new { MarkBlocksId = markBlk5.Id, FieldsId = fld17.Id },
                    new { MarkBlocksId = markBlk5.Id, FieldsId = fld18.Id }
                ]));
            builder.Entity<MarkBlock>().HasMany(e => e.Marks).WithMany(e => e.MarkBlocks)
                .UsingEntity(j => j.HasData([
                    new { MarkBlocksId = markBlk2.Id, MarksId = mark1.Id },
                    new { MarkBlocksId = markBlk2.Id, MarksId = mark2.Id },
                    new { MarkBlocksId = markBlk2.Id, MarksId = mark3.Id },
                    new { MarkBlocksId = markBlk2.Id, MarksId = mark4.Id },
                    new { MarkBlocksId = markBlk2.Id, MarksId = mark5.Id },
                    new { MarkBlocksId = markBlk2.Id, MarksId = mark6.Id },
                    new { MarkBlocksId = markBlk2.Id, MarksId = mark7.Id },
                    new { MarkBlocksId = markBlk3.Id, MarksId = mark8.Id },
                    new { MarkBlocksId = markBlk3.Id, MarksId = mark9.Id },
                    new { MarkBlocksId = markBlk3.Id, MarksId = mark10.Id },
                    new { MarkBlocksId = markBlk3.Id, MarksId = mark11.Id },
                    new { MarkBlocksId = markBlk3.Id, MarksId = mark12.Id },
                    new { MarkBlocksId = markBlk4.Id, MarksId = mark13.Id },
                    new { MarkBlocksId = markBlk4.Id, MarksId = mark14.Id },
                    new { MarkBlocksId = markBlk4.Id, MarksId = mark15.Id },
                    new { MarkBlocksId = markBlk5.Id, MarksId = mark13.Id },
                    new { MarkBlocksId = markBlk5.Id, MarksId = mark14.Id },
                    new { MarkBlocksId = markBlk5.Id, MarksId = mark16.Id },
                    new { MarkBlocksId = markBlk5.Id, MarksId = mark19.Id },
                    new { MarkBlocksId = markBlk5.Id, MarksId = mark20.Id },
                    new { MarkBlocksId = markBlk5.Id, MarksId = mark21.Id },
                    new { MarkBlocksId = markBlk5.Id, MarksId = mark22.Id },
                    new { MarkBlocksId = markBlk6.Id, MarksId = mark15.Id },
                    new { MarkBlocksId = markBlk6.Id, MarksId = mark23.Id },
                    new { MarkBlocksId = markBlk6.Id, MarksId = mark24.Id },
                    new { MarkBlocksId = markBlk7.Id, MarksId = mark25.Id },
                    new { MarkBlocksId = markBlk7.Id, MarksId = mark26.Id },
                ]));
        }
    }
}