namespace ProjectTeam09
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Grade
    {        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int StudentId { get; set; }

        public int CourseId { get; set; }
        public double Grade1 { get; set; }

        [StringLength(20)]
        public string Assignment { get; set; }

        
    }
}
