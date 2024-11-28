namespace LecturankWeb.Models
{
    public class SchoolListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class SchoolDetailsViewModel
    {
        public string Name { get; set; }
        public string Address { get; set; }  // Add this line
        public string Description { get; set; }
        public string LogoImageUrl { get; set; }
        public string CoverPhotoUrl { get; set; }
        public List<string> Amenities { get; set; }
        public List<string> ExtraPhotos { get; set; }
        public List<SchoolReview> Reviews { get; set; }
    }

    public class SchoolReview
    {
        public string ReviewerName { get; set; }
        public string Content { get; set; }
        public decimal Rating { get; set; }
    }
}
