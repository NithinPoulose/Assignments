﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeoAssignAPI
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}")]
        public string DOB { get; set; }
        [StringLength(2000)]
        public string Address { get; set; }
        [Required]
        [StringLength(13)]
        public string PhNo { get; set; }
        public string Course { get; set; }
        //[Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]
        public string EnrolDate { get; set; }
    }
}
