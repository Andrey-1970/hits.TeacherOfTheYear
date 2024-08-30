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

        public virtual List<ApplicationForm> Applications { get; set; } = new List<ApplicationForm>();
        [InverseProperty("Reviewer")]
        public virtual List<ApplicationForm> ReviewedApplications { get; set; } = new List<ApplicationForm>();
    }
}