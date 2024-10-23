using System.ComponentModel.DataAnnotations;

namespace AutoMapperProject.model.Dto
{
    public class PersonalDetailDto
    {
        [Required]
        [Key]
        public int Adhaar { get; set; }

        public int Age { get; set; }

        [Required]
        public string Name { get; set; }

        [RegularExpression("^male | female| other $")]
        public string gender { get; set; }

    }
}
