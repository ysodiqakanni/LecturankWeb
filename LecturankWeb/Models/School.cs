using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LecturankWeb.Models
{
    public class School
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        public bool IsActive { get; set; }
        public ICollection<Lecturer> Lecturers { get; set; }
    }

}