namespace NewsWorld.Core.ServiceModels.JsonObjects
{
    public class UniversityJsonObject
    {
        public string Name { get; set; }

        public string Alpha_Two_Code { get; set; }

        public string Country { get; set; }

        public string StateProvince { get; set; }

        public IList<string> Web_Pages { get; set; }

        public IList<string> Domains { get; set; }
    }
}
