namespace ProjectTeam09
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Grade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }

        public int? CourseId { get; set; }

        [StringLength(10)]
        public string Assignment { get; set; }

        [Column("Grade")]
        [StringLength(10)]
        public string Grade1 { get; set; }
    }
}
