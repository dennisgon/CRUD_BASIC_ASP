﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Departement
    {
        public int DepartementID { get; set; }
        [StringLength(50, MinimumLength =3)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "Money")]
        public decimal Budget { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode = true)]

        public DateTime StartDate { get; set; }
        public int? InstructorID { get; set; }
        public virtual Instructor Administrator { get; set; }
        public virtual ICollection<Course>Course { get; set; }

    }
}