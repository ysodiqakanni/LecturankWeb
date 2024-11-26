using System;

namespace LecturankWeb.Models
{
    public class Lecturer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int SchoolId { get; set; }
        public required string Course { get; set; }
        public string ProfilePicture { get; set; }
        public string ContactInformation { get; set; }
    }
}
