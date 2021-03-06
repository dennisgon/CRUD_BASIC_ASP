﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Number")]
        public int CourseID { get; set; }
        [StringLength(50, MinimumLength =3)]
        public String Title { get; set; }
        [Range(0,5)]
        public int Credits { get; set; }
        public int DepartementID { get; set; }

        public virtual Departement Departement { get; set; }
        public virtual ICollection<Instructor> Instructor { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}