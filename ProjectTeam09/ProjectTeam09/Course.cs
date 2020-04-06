namespace ProjectTeam09
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        public int CourseId { get; set; }

        [Required]
        [StringLength(25)]
        public string CourseName { get; set; }

    
        [Required]

        public int ProfessorId { get; set; }
        public int Section { get; set; }
        public int MaxCourseSize { get; set; }

        [StringLength(50)]
        public string DocumentsFolder { get; set; }

        public virtual Professor Professor { get; set; }
        
    }
}
