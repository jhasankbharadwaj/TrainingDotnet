using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace modelBinding.model
{
    public class AccountDetails
    {
        [Required]
        [RegularExpression(@"^\d+$", ErrorMessage = "The field AccountNumber must be numeric.")]
        [Key]
        public int AccountNumber { get; set; }
        [Required]
        [StringLength(100,MinimumLength =3)]
        [Column("Account_Holder_Name")]
        public string Name { get; set; }
        
        [Required]

        public int Age { get; set; }
        [Required]
        [BindRequired]
        [MaxLength(15)]

        public string City { get; set; }
        

        public string Region { get; set; }
       

    }
}
