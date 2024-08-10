﻿using System.ComponentModel.DataAnnotations;

namespace ServerApp.Data.Entities
{
    public class EditBlock
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Number { get; set; }
        [MaxLength(255)] public string? Name { get; set; }
        // public virtual Guid TrackId { get; set; }
        public virtual List<Track> Tracks { get; set; } = []; //сделали связь многие ко многим
        public virtual List<Field> Fields { get; set; } = [];
        public virtual List<Table> Tables { get; set; } = [];
    }
}
