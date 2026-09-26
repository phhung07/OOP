namespace Module_3_B1
{
    public class ChuyenXeNgoaiThanh : ChuyenXe
    {
        public string noiDen { get; set; }
        public int soNgayDiDuoc { get; set; }
        public ChuyenXeNgoaiThanh(string maSoChuyen, string hoTenTaiXe, string soXe, string noiDen, int soNgayDiDuoc, double doanhThu) : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu)
        {
            this.noiDen = noiDen;
            this.soNgayDiDuoc = soNgayDiDuoc;
        }
    }
}
