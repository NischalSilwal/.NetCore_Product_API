namespace DatabasePractice1.Models
{
    public class ImageDetail
    {
        public int Id { get; set; }
        public string ProductImage { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string Base64Image { get; set; } = string.Empty;
    }
}
