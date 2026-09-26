namespace Module_3_B1
{
    public class ChuyenXe
    {
        public string maSoChuyen { get; set; }
        private string hoTenTaiXe;
        public string HoTenTaiXe
        {
            get { return hoTenTaiXe; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    hoTenTaiXe = value;
                }
            }
        }
        public string soXe { get; set; }
        public double doanhThu { get; }
        public ChuyenXe(string maSoChuyen, string hoTenTaiXe, string soXe, double doanhThu)
        {
            this.maSoChuyen = maSoChuyen;
            this.hoTenTaiXe = hoTenTaiXe;
            this.soXe = soXe;
            this.doanhThu = doanhThu;
        }
    }
}
