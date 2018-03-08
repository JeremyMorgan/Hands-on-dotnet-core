using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace turkeytime.Models
{
    public class FoodItem {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;}
        [Required]
        [MaxLength(200)]
        public string FoodItemName { get; set; }
        [Required]
        [MaxLength(50)]
        public string Person { get; set; }
        public bool IsVegan { get; set; }
        public bool IsGlutenFree { get; set; }
    }
}