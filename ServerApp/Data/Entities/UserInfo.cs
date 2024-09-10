using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerApp.Data.Entities
{
    public class UserInfo
    {
        public Guid Id { get; set; }

        [MaxLength(255)] 
        public string? Name { get; set; }

        [MaxLength(255)]
        public string? Username { get; set; }

        public virtual List<ApplicationForm> Applications { get; set; } = new();
        [InverseProperty("Reviewer")]
        public virtual List<ApplicationForm> ReviewedApplications { get; set; } = new();
        public virtual List<Vote> Votes { get; set; } = new();
        public virtual List<MarkVal> Marks { get; set; } = new();
        public virtual List<ApplicationFormExpert> ApplicationFormExperts { get; set; } = new(); // Связь многие ко многим
    }
}