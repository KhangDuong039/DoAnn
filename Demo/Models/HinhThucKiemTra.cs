using System.ComponentModel.DataAnnotations;
namespace Demo.Models
{
    public class HinhThucKiemTra
    {
        [Key]
        public Guid ID { get; set; }
        public string TenHinhThuc { get; set; }
    }
}
