namespace Module_3_B1
{
    public class ChuyenXeNoiThanh : ChuyenXe
    {
        public int soTuyen { get; set; }
        public double soKm { get; set; } = 0;
        public ChuyenXeNoiThanh(string maSoChuyen, string hoTenTaiXe, string soXe, int soTuyen, double soKm, double doanhThu) : base(maSoChuyen,hoTenTaiXe,soXe,doanhThu)
        {
            this.soTuyen = soTuyen;
            this.soKm = soKm;
        }
    }
}
