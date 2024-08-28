using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ServerApp.Data;

namespace YourProject.Data.Services
{
    public static class EvaluationMethods
    {
        public static int EvaluateMark1(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var vals = context.CellVals
                .Where(c => c.ApplicationId == appId && c.Row!.TableId == tableId).ToArray();
            int resval = 0;
            foreach (var val in vals.Where(c => c.Column!.Name == "Итого (час.)"))
            {
                resval += int.Parse(val.Value ?? "0");
            }
            return resval switch
            {
                >= 1 and <= 199 => 1,
                >= 200 and <= 399 => 2,
                >= 400 => 3,
                _ => 0
            };
        }

        public static int EvaluateMark2(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var vals = context.Rows.Where(r => r.TableId == tableId && r.CellVals.Any(c => c.ApplicationId == appId)); //todo:где указан не русский язык преподавания
            var count = vals.Count();
            return count switch
            {
                1 => 1,
                >= 2 => 2,
                _ => 0
            };
        }

        public static int EvaluateMark3(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var fld = context.FieldVals.FirstOrDefault(e => e.ApplicationId == appId && e.Field.Marks.Any(m => m.Id == markId));
            var fld2 = context.FieldVals.FirstOrDefault(e =>
                e.ApplicationId == appId && e.Field.Name == "Защитившиеся бакалавры");
            var fld3 = context.FieldVals.FirstOrDefault(e =>
                e.ApplicationId == appId && e.Field.Name == "Защитившиеся специалисты");
            
            if (fld == null || fld2 == null || fld3 == null) return 0; 

            var val = int.Parse(fld.Value ?? "0") + int.Parse(fld2.Value ?? "0") + int.Parse(fld3.Value ?? "0");
            return val switch
            {
                1 => 1,
                2 => 2,
                3 => 3,
                4 => 4,
                >= 5 => 5,
                _ => 0
            };
        }

        public static int EvaluateMark4(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var fld = context.FieldVals.FirstOrDefault(e => e.ApplicationId == appId && e.Field.Marks.Any(m => m.Id == markId));
            if (fld == null) return 0; 

            var val = int.Parse(fld.Value ?? "0");
            return val switch
            {
                1 => 1,
                >= 2 => 2,
                _ => 0
            };
        }

        public static int EvaluateMark5(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var fld = context.FieldVals.FirstOrDefault(e => e.ApplicationId == appId && e.Field.Marks.Any(m => m.Id == markId));
            if (fld == null) return 0; 

            var val = int.Parse(fld.Value ?? "0");
            return val switch
            {
                1 => 2,
                >= 2 => 4,
                _ => 0
            };
        }

        public static int EvaluateMark6(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var rows = context.Rows.Where(r => r.TableId == tableId && r.CellVals.Any(c => c.ApplicationId == appId));
            var count = rows.Count();
            return count switch
            {
                >= 1 and <= 2 => 1,
                >= 3 and <= 4 => 2,
                >= 5 and <= 6 => 3,
                >= 7 => 4,
                _ => 0
            };
        }

        public static int EvaluateMark7(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var rows = context.Rows.Where(r => r.TableId == tableId && r.CellVals.Any(c => c.ApplicationId == appId));
            var count = rows.Count();
            return count switch
            {
                1 => 1,
                2 => 2,
                >= 3 => 5,
                _ => 0
            };
        }

        public static int EvaluateMark8(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var rows = context.Rows.Where(r => r.TableId == tableId &&
                r.CellVals.Any(c => c.ApplicationId == appId && c.Column!.Name == "Наличие грифа" && c.Value == "1") &&
                r.CellVals.Any(c => c.ApplicationId == appId && c.Column!.Name == "Соавторы" && string.IsNullOrEmpty(c.Value)))
                .ToList();
            var count = rows.Count;
            return count switch
            {
                1 => 4,
                >= 2 => 5,
                _ => 0
            };
        }

        public static int EvaluateMark9(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var rows = context.Rows.Where(r => r.TableId == tableId &&
                r.CellVals.Any(c => c.ApplicationId == appId && c.Column!.Name == "Наличие грифа" && c.Value == "1") &&
                r.CellVals.Any(c => c.ApplicationId == appId && c.Column!.Name == "Соавторы" && !string.IsNullOrEmpty(c.Value)))
                .ToList();
            var count = rows.Count;
            return count switch
            {
                1 => 2,
                >= 2 => 3,
                _ => 0
            };
        }

        public static int EvaluateMark10(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var rows = context.Rows.Where(r => r.TableId == tableId &&
                r.CellVals.Any(c => c.ApplicationId == appId && c.Column!.Name == "Наличие грифа" && c.Value == "0") &&
                r.CellVals.Any(c => c.ApplicationId == appId && c.Column!.Name == "Соавторы" && string.IsNullOrEmpty(c.Value)))
                .ToList();
            var count = rows.Count;
            return count switch
            {
                1 => 1,
                >= 2 => 2,
                _ => 0
            };
        }

        public static int EvaluateMark11(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var rows = context.Rows.Where(r => r.TableId == tableId &&
                r.CellVals.Any(c => c.ApplicationId == appId && c.Column!.Name == "Наличие грифа" && c.Value == "0") &&
                r.CellVals.Any(c => c.ApplicationId == appId && c.Column!.Name == "Соавторы" && !string.IsNullOrEmpty(c.Value)))
                .ToList();
            var count = rows.Count;
            return count switch
            {
                1 => 1,
                >= 2 => 2,
                _ => 0
            };
        }

        public static int EvaluateMark12(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var rows = context.Rows.Where(r => r.TableId == tableId && r.CellVals.Any(c => c.ApplicationId == appId));
            var count = rows.Count();
            return count switch
            {
                >= 1 and <= 2 => 1,
                >= 3 and <= 4 => 2,
                >= 5 and <= 6 => 3,
                >= 7 => 4,
                _ => 0
            };
        }

        public static int EvaluateMark13(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var fld = context.FieldVals.FirstOrDefault(e => e.ApplicationId == appId && e.Field.Marks.Any(m => m.Id == markId));
            if (fld == null) return 0; 

            return fld.Value switch
            {
                "Доцент" => 2,
                "Профессор" => 5,
                _ => 0
            };
        }

        public static int EvaluateMark14(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var rows = context.Rows.Where(r => r.TableId == tableId && r.CellVals.Any(c => c.ApplicationId == appId));
            var count = rows.Count();
            return count switch
            {
                1 => 1,
                >= 2 => 2,
                _ => 0
            };
        }

        public static int EvaluateMark15(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var anyRows = context.Rows.Any(r => r.TableId == tableId && r.CellVals.Any(c => c.ApplicationId == appId));
            return anyRows ? 2 : 0;
        }

        public static int EvaluateMark16(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var rows = context.Rows.Where(r => r.TableId == tableId && r.CellVals.Any(c => c.ApplicationId == appId));
            var count = rows.Count();
            return count switch
            {
                1 => 1,
                2 => 2,
                3 => 3,
                4 => 4,
                >= 5 => 5,
                _ => 0
            };
        }

        public static int EvaluateMark17(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var row = context.Rows.Include(row => row.CellVals)
                .ThenInclude(cellVal => cellVal.Column)
                .FirstOrDefault(r => r.CellVals.Any(c => c.ApplicationId == appId && c.Column!.Name == "Тип идентификатора" && c.Value == "ScopusID"));
            if (row == null) return 0; 

            var val = int.Parse(row.CellVals.FirstOrDefault(c => c.Column!.Name == "Индекс Хирша (за все время)")?.Value ?? "0");
            return val switch
            {
                <= 1 => 0,
                4 => 4,
                >= 5 => 5,
                _ => 0
            };
        }

        public static int EvaluateMark18(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var row = context.Rows.Include(row => row.CellVals)
                .ThenInclude(cellVal => cellVal.Column)
                .FirstOrDefault(r => r.CellVals.Any(c => c.ApplicationId == appId && c.Column!.Name == "Тип идентификатора" && c.Value == "РИНЦ AuthorID"));
            if (row == null) return 0; 

            var val = int.Parse(row.CellVals.FirstOrDefault(c => c.Column!.Name == "Индекс Хирша (за все время)")?.Value ?? "0");
            return val switch
            {
                <= 1 => 0,
                4 => 4,
                >= 5 => 5,
                _ => 0
            };
        }

        public static int EvaluateMark19(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var fld = context.FieldVals.FirstOrDefault(e => e.ApplicationId == appId && e.Field.Marks.Any(m => m.Id == markId));
            if (fld == null) return 0; 

            var val = int.Parse(fld.Value ?? "0");
            return val switch
            {
                1 => 1,
                >= 2 => 2,
                _ => 0
            };
        }

        public static int EvaluateMark20(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var fld = context.FieldVals.FirstOrDefault(e => e.ApplicationId == appId && e.Field.Marks.Any(m => m.Id == markId));
            if (fld == null) return 0; 

            var val = int.Parse(fld.Value ?? "0");
            return val switch
            {
                1 => 2,
                >= 2 => 4,
                _ => 0
            };
        }

        public static int EvaluateMark21(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var rows = context.Rows.Where(r => r.TableId == tableId &&
                r.CellVals.Any(c => c.ApplicationId == appId && c.Column!.Name == "Статус (руководитель/исполнитель)" && c.Value == "Руководитель"))
                .ToList();
            var count = rows.Count;
            return count switch
            {
                >= 1 and <= 2 => 2,
                >= 3 => 4,
                _ => 0
            };
        }

        public static int EvaluateMark22(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var rows = context.Rows.Where(r => r.TableId == tableId &&
                                               r.CellVals.Any(c => c.ApplicationId == appId && c.Column!.Name == "Статус (руководитель/исполнитель)" && c.Value == "Исполнитель"))
                .ToList();
            var count = rows.Count;
            return count switch
            {
                >= 1 and <= 2 => 1,
                >= 3 => 2,
                _ => 0
            };
        }

        public static int EvaluateMark23(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var rows = context.Rows.Where(r => r.TableId == tableId && r.CellVals.Any(c => c.ApplicationId == appId));
            var count = rows.Count();
            return count switch
            {
                1 => 1,
                >= 2 => 5,
                _ => 0
            };
        }

        public static int EvaluateMark24(Guid appId, Guid markId, Guid? tableId, ApplicationDbContext context)
        {
            var anyRows = context.Rows.Any(r => r.TableId == tableId && r.CellVals.Any(c => c.ApplicationId == appId));
            return anyRows ? 5 : 0;
        }
    }
}
