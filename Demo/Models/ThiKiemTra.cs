using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class ThiKiemTra
    {
        [Key]
        public Guid ID { get; set; }
        public Lop Lop { get; set; }
        public DateTime NgayKiemTra { get; set; }
        public MonHoc MonHoc { get; set; }
        public string NoiDung { get; set; }
        public HinhThucKiemTra HinhThuc { get; set; }
        public long ThoiLuong { get; set; }
        public string MoTa { get; set; }
        public string FilePath { get; set; }
        public string Status { get; set; }
    }
}
