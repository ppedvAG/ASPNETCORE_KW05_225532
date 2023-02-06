namespace RazorPages_Part2.Models
{
    public class WebsiteContext
    {
        public Version Version { get; set; }
        public int CopyrigthYear { get; set; }

        public bool Approved { get; set; }

        public int TagsToShow { get; set; }
    }
}
