﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_LMS.Core.Entities
{
    public class Course
    {
        public int Id { get; set; }
        
        [StringLength (20)]
        [DisplayName ("Course Name")]
        public string CourseName { get; set; }

        [StringLength(200)]
        [DisplayName("Description")]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("End Date")]
        public DateTime EndDate => StartDate.AddMonths(3);


        public ICollection<User> User { get; set; } = new List<User>();
        public ICollection<Module> Module { get; set; } = new List<Module>();
        public ICollection<Document> Document { get; set; } = new List<Document>();


    }
}