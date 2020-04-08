namespace ProjectTeam09
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        public int AdminId { get; set; }

        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }   
    }
}