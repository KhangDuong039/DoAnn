using Microsoft.EntityFrameworkCore;
namespace Demo.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Permisson> Permission { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<KhoaHoc> KhoaHoc { get; set; }
        public DbSet<Lop> Lop { get; set; }
        public DbSet<LopSinhVien> Lop_SinhVien { get; set; }
        public DbSet<LopMonHoc> Lop_MonHoc { get; set; }
        public DbSet<HinhThucKiemTra> HinhThuc_Thi_KiemTra { get; set; }
        public DbSet<ThiKiemTra> Thi_KiemTra { get; set; }
        public DbSet<DiemSinhVien> Diem_SinhVien { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<DiemSinhVien>().HasOne<User>(P => P.SinhVien).WithMany().OnDelete(DeleteBehavior.NoAction);

            builder.Entity<LopSinhVien>().HasOne<User>(P => P.SinhVien).WithMany().OnDelete(DeleteBehavior.NoAction);
        }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);

            }
        } 
    }
}
