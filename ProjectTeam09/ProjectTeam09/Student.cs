namespace ProjectTeam09
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int StudentId { get; set; }

        [Required]
        [StringLength(10)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(10)]
        public string LastName { get; set; }

        public double? GPA { get; set; }

        public int? Class1 { get; set; }

        public int? Class2 { get; set; }

        public int? Class3 { get; set; }

        public int? Class4 { get; set; }

        public int? Class5 { get; set; }
    }
}
