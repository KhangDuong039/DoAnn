using System.ComponentModel.DataAnnotations;
namespace Demo.Models
{
    public class Permisson
    {
        [Key]
        public Guid ID { get; set; }
        public string Permission_Name { get; set; }
    }
}
