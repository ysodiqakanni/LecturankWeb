using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LecturankWeb.Models
{
    public class School
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string About { get; set; }

        public string BackgroundPicture { get; set; }

        public List<string> ExtraPhotos { get; set; }

        public string Amenities { get; set; }

        public List<Review> Reviews { get; set; }
    }

    public class Review
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime Date { get; set; }
        public School School { get; set; }
    }
}
