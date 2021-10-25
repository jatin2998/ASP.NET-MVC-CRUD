namespace Blog.Models
{
    public class Post
    {
        public int Id {  get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Footer { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
