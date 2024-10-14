using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace modelBinding.model
{
    public class AccountDetails
    {
        [Required]
        [MaxLength(15)]
        [RegularExpression("0-9")]
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
        public string City { get; set; }
        

        public string Region { get; set; }
       

    }
}
