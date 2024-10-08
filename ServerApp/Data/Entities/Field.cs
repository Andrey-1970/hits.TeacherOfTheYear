﻿using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class Field : BaseEntity
    {
        public int Number { get; set; }
        [MaxLength(400)] 
        public string? Name { get; set; }
        [MaxLength(255)]
        public string? Placeholder { get; set; }
        [MaxLength(255)]
        public string? EditGroup { get; set; }

        public bool IsRequired { get; set; } = true;
        
        public bool IsDisplayedOnVotingPage { get; set; } = false;
        
        public virtual Guid ValueTypeId { get; set; }
        public virtual ValuesType? ValueType { get; set; }
        public virtual List<SelectValue> SelectValues { get; set; } = [];
        public virtual Guid EditBlockId { get; set; }
        public virtual EditBlock? EditBlock { get; set; }
        public virtual List<MarkBlock> MarkBlocks { get; set; } = [];
        public virtual List<FieldVal> FieldVals { get; set; } = [];
        public virtual List<Mark> Marks { get; set; } = [];
        //todo: значение по умолчанию
    }
}
