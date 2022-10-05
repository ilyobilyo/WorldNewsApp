using System.ComponentModel.DataAnnotations;

namespace NewsWorld.Core.Data.Universities
{
    public class University
    {
        public University()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Alpha_Two_Code { get; set; }

        [Required]
        [MaxLength(200)]
        public string Country { get; set; }

        public string? StateProvince { get; set; }

        public string? Domain { get; set; }

        public string WebPage { get; set; }
    }
}
