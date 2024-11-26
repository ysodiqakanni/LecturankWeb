using System;
using System.Collections.Generic;

namespace LecturankWeb.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ProfilePicture { get; set; }
        public ICollection<Lecturer> Lecturers { get; set; }
    }
}