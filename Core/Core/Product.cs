using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Core
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public int product_id { get; set; }
        public string product { get; set; }
        public string description { get; set; }
        public int stock { get; set; }
        public int price { get; set; }
        public string type { get; set; }
        public int active { get; set; }

    }
}
