using System.ComponentModel.DataAnnotations;
namespace Demo.Models
{
    public class DiemSinhVien
    {
        [Key]
        public Guid ID { get; set; }
        public User SinhVien { get; set; }
        public DateTime NgayKiemTra { get; set; }
        public Lop Lop { get; set; }
        public MonHoc MonHoc { get; set; }
        public HinhThucKiemTra HinhThuc { get; set; }
        public string FilePath { get; set; }
        public double Diem { get; set; }
        public string NhanXet { get; set; }
    }
}
