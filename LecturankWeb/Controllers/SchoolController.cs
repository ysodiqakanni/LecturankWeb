using Microsoft.AspNetCore.Mvc;
using LecturankWeb.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LecturankWeb.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        public async Task<IActionResult> Index()
        {
            var schools = new List<SchoolListViewModel>
            {
                new SchoolListViewModel
                {
                    Id = 1,
                    Name = "Federal University of Technology, Akure",
                    Address = "Akure, Ondo State, Nigeria"
                },
                new SchoolListViewModel
                {
                    Id = 2,
                    Name = "School 2",
                    Address = "Address 2"
                },
                new SchoolListViewModel
                {
                    Id = 3,
                    Name = "School 3",
                    Address = "Address 3"
                }
            };

            return View(schools);
        }

        // GET: School/Details/1
        public IActionResult Details(int id)
        {
            SchoolDetailsViewModel schoolDetails;

            if (id == 1)
            {
                schoolDetails = new SchoolDetailsViewModel
                {
                    Name = "Federal University of Technology, Akure",
                    Address = "Akure, Ondo State, Nigeria",
                    Description = "Welcome to FUTA. You are welcome to the Federal University of Technology, Akure (FUTA), a top ranking University of technology in Nigeria and indeed the nation's pride. Established in 1981, the university has grown tremendously, stretching its academic disciplines and research across eight different schools and over fifty academic departments.",
                    Amenities = new List<string> { "Water", "Library", "Sports Complex", "Laboratories", "Hostel" },
                    LogoImageUrl = "https://www.nairaland.com/attachments/11669470_images7_jpeg_jpegc250b88d3a108a1e74e6c9bf7bb78252",
                    CoverPhotoUrl = "https://www.nairaland.com/attachments/11669470_images7_jpeg_jpegc250b88d3a108a1e74e6c9bf7bb78252",
                    ExtraPhotos = new List<string>
                    {
                        "https://www.nairaland.com/attachments/11669684_images6_jpeg_jpegb8e70b8cebe0822fdd8baa3435f1ac08",
                        "https://www.nairaland.com/attachments/11669471_91c89bb464354869ae95105da911b95b_jpeg61f8a0f5db5b3f7b76c760ccc386fa3d",
                        "https://www.nairaland.com/attachments/11669472_images3_jpeg_jpegd27f509609759ba43b8e9f6487603bb9",
                        "https://www.nairaland.com/attachments/11669523_images9_jpeg_jpegfdb2ae2272d49a281724a44126e0a27d",
                        "https://www.nairaland.com/attachments/11669690_images5_jpeg_jpeg1e52807b9931d5cfcf296bb78d4e5f7e"
                    },
                    Reviews = new List<SchoolReview>
                    {
                        new SchoolReview
                        {
                            ReviewerName = "John Doe",
                            Content = "Bad school",
                            Rating = 2.0M
                        },
                        new SchoolReview
                        {
                            ReviewerName = "Shola Ade",
                            Content = "Great school",
                            Rating = 4.5M
                        }
                    }
                };
            }
            else if (id == 2)
            {
                schoolDetails = new SchoolDetailsViewModel
                {
                    Name = "School 2",
                    Address = "Address 2",
                    Description = "Description for School 2.",
                    Amenities = new List<string> { "Library", "Gym", "Cafeteria" },
                    LogoImageUrl = "https://example.com/logo2.jpg",
                    CoverPhotoUrl = "https://example.com/cover2.jpg",
                    ExtraPhotos = new List<string>
                    {
                        "https://example.com/photo21.jpg",
                        "https://example.com/photo22.jpg",
                        "https://example.com/photo23.jpg"
                    },
                    Reviews = new List<SchoolReview>
                    {
                        new SchoolReview
                        {
                            ReviewerName = "Jane Smith",
                            Content = "Not bad at all.",
                            Rating = 3.5M
                        },
                        new SchoolReview
                        {
                            ReviewerName = "Sam Green",
                            Content = "Could be better.",
                            Rating = 3.0M
                        }
                    }
                };
            }
            else if (id == 3)
            {
                schoolDetails = new SchoolDetailsViewModel
                {
                    Name = "School 3",
                    Address = "Address 3",
                    Description = "Description for School 3.",
                    Amenities = new List<string> { "Swimming Pool", "Library", "Cafeteria" },
                    LogoImageUrl = "https://example.com/logo3.jpg",
                    CoverPhotoUrl = "https://example.com/cover3.jpg",
                    ExtraPhotos = new List<string>
                    {
                        "https://example.com/photo31.jpg",
                        "https://example.com/photo32.jpg",
                        "https://example.com/photo33.jpg"
                    },
                    Reviews = new List<SchoolReview>
                    {
                        new SchoolReview
                        {
                            ReviewerName = "Alice Blue",
                            Content = "Amazing experience.",
                            Rating = 5.0M
                        },
                        new SchoolReview
                        {
                            ReviewerName = "Tom Brown",
                            Content = "Average experience.",
                            Rating = 3.0M
                        }
                    }
                };
            }
            else
            {
                return NotFound();
            }

            return View(schoolDetails);
        }
    }
}
