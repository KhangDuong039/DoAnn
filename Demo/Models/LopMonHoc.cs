using System.ComponentModel.DataAnnotations;
namespace Demo.Models
{
    public class LopMonHoc
    {
        [Key]
        public Guid ID { get; set; }
        public Lop Lop { get; set; }
        public DateTime ThoiGian { get; set; }
        public MonHoc MonHoc { get; set; }
        public long SoTiet { get; set; }
    }
}
