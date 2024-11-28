using LecturankWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LecturankWeb.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Schools.Any())
            {
                return; // DB has been seeded
            }

            var schools = new School[]
            {
                new School
                {
                    Name = "Federal University of Technology, Akure",
                    Address = "Akure, Ondo State, Nigeria",
                    About = "Welcome to FUTA. You are welcome to the Federal University of Technology, Akure (FUTA), a top ranking University of technology in Nigeria and indeed the nation's pride. Established in 1981, the university has grown tremendously, stretching its academic disciplines and research across eight different schools and over fifty academic departments. VISION: To be a world class University of Technology and a centre of excellence in training, research and service delivery. MISSION: To promote technological advancement by providing conducive environment for research, teaching and learning, and engendering the development of products that are technologically oriented, self-reliant, and relevant to society.",
                    BackgroundPicture = "https://www.nairaland.com/attachments/11669470_images7_jpeg_jpegc250b88d3a108a1e74e6c9bf7bb78252",
                    ExtraPhotos = new List<string>
                    {
                        "https://www.nairaland.com/attachments/11669684_images6_jpeg_jpegb8e70b8cebe0822fdd8baa3435f1ac08",
                        "https://www.nairaland.com/attachments/11669471_91c89bb464354869ae95105da911b95b_jpeg61f8a0f5db5b3f7b76c760ccc386fa3d",
                        "https://www.nairaland.com/attachments/11669472_images3_jpeg_jpegd27f509609759ba43b8e9f6487603bb9",
                        "https://www.nairaland.com/attachments/11669523_images9_jpeg_jpegfdb2ae2272d49a281724a44126e0a27d",
                        "https://www.nairaland.com/attachments/11669690_images5_jpeg_jpeg1e52807b9931d5cfcf296bb78d4e5f7e"
                    },
                    Amenities = "Library, Sports Facilities, Laboratories, Hostels",
                    Reviews = new List<Review>
                    {
                        new Review { Content = "Great university with excellent facilities!", Rating = 5, Date = DateTime.Now }
                    }
                }
            };

            foreach (var s in schools)
            {
                context.Schools.Add(s);
            }
            context.SaveChanges();
        }
    }
}
