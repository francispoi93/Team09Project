namespace ProjectTeam09
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserCredential
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(25)]
        public string Password { get; set; }

        [StringLength(10)]
        public string Permissions { get; set; }
    }
}
