using System.ComponentModel.DataAnnotations;
namespace Demo.Models
{
    public class LopSinhVien
    {
        [Key]
        public Guid ID { get; set; }
        public Lop Lop { get; set; }
        public User SinhVien { get; set; }
    }
}
