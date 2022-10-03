namespace NewsWorld.Core.ServiceModels.News
{
    public class NewsServiceModel
    {
        public string Link { get; set; }

        public string Title { get; set; }

        public string[] Creator { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public string Image_Url { get; set; }

        public string Source_Id { get; set; }

        public string PubDate { get; set; }

        public string[] Country { get; set; }

        public string Language { get; set; }
    }
}
