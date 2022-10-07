using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewsWorld.Core.Data.Universities;
using NewsWorld.Core.ServiceModels.JsonObjects;
using Newtonsoft.Json;

namespace NewsWorld.Core.Data.Configure
{
    public class UniversityConfiguration : IEntityTypeConfiguration<University>
    {
        private readonly string baseUrl = "http://universities.hipolabs.com/search";

        public void Configure(EntityTypeBuilder<University> builder)
        {
            List<University> universities = GetUniversities();

            builder.HasData(universities);
        }

        private List<University> GetUniversities()
        {
            var universities = new List<University>();

            using (var client = new HttpClient())
            {
                HttpRequestMessage request = new HttpRequestMessage();

                request.RequestUri = new Uri(baseUrl);

                request.Method = HttpMethod.Get;

                HttpResponseMessage response = client.Send(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseString = response.Content.ReadAsStringAsync();

                    var jsonObj = JsonConvert.DeserializeObject<List<UniversityJsonObject>>(responseString.Result);

                    foreach (var uni in jsonObj)
                    {
                        var university = new University()
                        {
                            Alpha_Two_Code = uni.Alpha_Two_Code,
                            Country = uni.Country,
                            Name = uni.Name,
                            StateProvince = uni.StateProvince,
                            Domain = uni.Domains[0],
                            WebPage = uni.Web_Pages[0],
                        };

                        universities.Add(university);
                    }
                }
                else
                {
                    return null;
                }
            }

            return universities;
        }
    }
}
