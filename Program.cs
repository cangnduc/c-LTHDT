// See https://aka.ms/new-console-template for more information

namespace LTHDT_console
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            //ps a = new ps();
            //ps b = new ps();
            //a.nhapPhanSo("phan so a");
            //b.nhapPhanSo("phan so b");
            //ps kq = a.CongPhanSo(b);
            //kq.xuat();
            //toaDo a = new toaDo(1, 2);
            //toaDo b = new toaDo(2, 3);
            //toaDo c = new toaDo(3, 4);
            //Diem tamgiac = new Diem(a, b, c);
            //Console.WriteLine(c.khoangCach(a));
            //Console.WriteLine(tamgiac.chuVi());
            //TamGiac tg = new TamGiac();
            // tg.A.NhapToaDo();
            // tg.B.NhapToaDo();
            // tg.C.NhapToaDo();
            // Console.WriteLine(tg.ChuVi());
            //Ps a = new Ps();
            // a.TuSo = 5;
            // a.Mauso = 10;
            // Console.WriteLine(a.TuSo);
            // Ps b = a.CongPhanSo(a);
            // b.Xuat();
            //CongTy ct = new CongTy();
            //ct.ThemNV();
            //Console.WriteLine(ct.TongLuong());
            //MatPhang oxy = new MatPhang();
            //oxy.ThemHinh();
            //Console.WriteLine(oxy.TinhTongChuVi());
            MangSoNguyen mangA = new MangSoNguyen(new XulySapXep());
            mangA.SapXepTangDan();
            mangA.SapXepGiam();
            mangA.Xuat();

        }

    }
    class NhanVien
    {
        private string? MaNV { get; set; }
        private string? TenNV { get; set; }
        public virtual void NhapNV(string GhiChu)
        {
            Console.WriteLine(GhiChu);
            Console.WriteLine("Nhap Ma NV: ");
            this.MaNV = Console.ReadLine();
            Console.WriteLine("Nhap ten NV: ");
            this.TenNV = Console.ReadLine();

        }
        public virtual double TongLuong()
        {
            return 0;
        }

    }
    class NVVP : NhanVien
    {
        private double HeSoLuong { get; set; }
        public override void NhapNV(string ghichu)
        {
            base.NhapNV(ghichu);
            Console.WriteLine("Nhap he so luong: ");
            this.HeSoLuong = double.Parse(Console.ReadLine() ?? string.Empty);
        }
        public override double TongLuong()
        {
            return this.HeSoLuong * 100;
        }
    }
    class NVSX : NhanVien
    {
        private int SoLuongSP { get; set; }
        public override void NhapNV(string ghichi)
        {
            base.NhapNV(ghichi);
            Console.WriteLine("Nhap So Luong SP: ");
            this.SoLuongSP = int.Parse(Console.ReadLine() ?? string.Empty);
        }
        public override double TongLuong()
        {
            return this.SoLuongSP * 2;
        }
    }
    class CongTy
    {
        //private string TenCty { get; set; }
        private List<NhanVien> NhanVien { get; set; } = new List<NhanVien>();

        public void ThemNV()
        {
            Console.WriteLine("So Luong Nhan Vien VP: ");
            int n = int.Parse(Console.ReadLine() ?? string.Empty);
            for (int i = 0; i < n; i++)
            {
                NhanVien s = new NhanVien();
                Console.WriteLine("Nhap Loai Nhan Vien 1:NVVP, 2:NVSX");

                int loai = int.Parse(Console.ReadLine() ?? string.Empty);
                if (loai == 1) { s = new NVVP(); }
                else if (loai == 2) { s = new NVSX(); }
                else { Console.WriteLine("only 1 vs 2"); }
                s.NhapNV($"Nhap Nhan Vien thu: {i + 1}");
                this.NhanVien.Add(s);
            }


        }
        public double TongLuong()
        {
            double t = 0;
            foreach (var nv in this.NhanVien)
            {
                t += nv.TongLuong();
            }

            return t;
        }
    }
    class MangSoNguyen
    {
        int[] DanhSach { get; set; }
        private SapXep SapXeps { get; set; }
        public MangSoNguyen(XulySapXep sapxep)
        {
            this.DanhSach = new int[] { 1, 3, 5, 2, 6 };
            this.SapXeps = sapxep;
        }
        public void SapXepTangDan()
        {
            this.SapXeps.SapXepTang(this.DanhSach);
        }
        public void SapXepGiam()
        {
            this.SapXeps.SapXepGiam(this.DanhSach);
        }
        public void Xuat()
        {
            foreach(var i in this.DanhSach)
            {
                Console.Write($"{i} ");
            }
        }

    }
    interface SapXep
    {
        public void SapXepTang(int[] danhsach);
        public void SapXepGiam(int[] danhsach);
    }
    class XulySapXep : SapXep
    {
        public void SapXepTang(int[] danhsach)
        {
            Array.Sort(danhsach);
        }
        public void SapXepGiam(int[] danhsach)
        {
            Array.Reverse(danhsach);
        }
    }
    class Hinh
    {
        private string mausac { get; set; } = string.Empty;
        public virtual void Nhap(string ghichu)
        {
            Console.WriteLine("Mau sac: ");
            this.mausac = Console.ReadLine() ?? string.Empty;
        }
        public virtual double TinhChuVi()
        {
            return 0;
        }
    }
    class HinhTron : Hinh
    {
        private ToaDo I = new ToaDo();
        private double R = 0;
        public override void Nhap(string ghichu)
        {
            base.Nhap(ghichu);
            this.I.NhapToaDo();
            Console.WriteLine("Nhap ban kinh R: ");
            this.R = double.Parse(Console.ReadLine() ?? string.Empty);
        }
        public override double TinhChuVi()
        {
            return this.R * Math.PI * 2;
        }
    }
    class HinhChuNhat : Hinh
    {
        private double ChieuDai { get; set; }
        private double ChieuRong { get; set; }
        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }
        public HinhChuNhat()
        {
            this.ChieuDai = 0;
            this.ChieuRong = 0;
        }
        public override void Nhap(string ghichu)
        {
            base.Nhap(ghichu);
            Console.WriteLine("Chieu dai: ");
            this.ChieuDai = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Chieu rong : ");
            this.ChieuRong = double.Parse(Console.ReadLine() ?? string.Empty);
        }
        public override double TinhChuVi()
        {
            return (this.ChieuDai + this.ChieuRong) * 2;
        }
    }
    class MatPhang
    {
        public List<Hinh> DanhSachHinh { get; set; }
        public MatPhang()
        {
            this.DanhSachHinh = new List<Hinh>();
        }
        public void ThemHinh()
        {
            Console.WriteLine("Nhap so luong hinh: ");
            string s = Console.ReadLine()?? string.Empty;
            int slhinh;
            if (s==string.Empty)
            {
                slhinh = 0;
            }
            else
            {
                slhinh = int.Parse(s);
            }
            for(int i =0; i< slhinh;i++ )
            {
                Console.WriteLine("Nhap Loai Hinh, 1: Hinh Tron, 2:Hinh Chu Nhat");
                Hinh h;
                int Loai = int.Parse(Console.ReadLine() ?? string.Empty);
                if (Loai == 1)
                    h = new HinhTron();
                else
                    h = new HinhChuNhat();
                h.Nhap("Nhap Thong So Cua Hinh: ");
                this.DanhSachHinh.Add(h);
            }
            
        }
        public double TinhTongChuVi()
        {
            double t = 0;
            foreach(var hinh in this.DanhSachHinh)
            {
                t += hinh.TinhChuVi();
            }
            return t;
        }
    }
    public class TamGiac
    {
        public ToaDo A;
        public ToaDo B;
        public ToaDo C;
        public TamGiac()
        {
            A = new ToaDo(1, 0);
            B = new ToaDo(0, 1);
            C = new ToaDo(0, 0);
        }
        public TamGiac(ToaDo a, ToaDo b, ToaDo c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double ChuVi()
        {
            double a = A.KhoangCach(B);
            double b = B.KhoangCach(C);
            double c = C.KhoangCach(A);
            return a + b + c;
        }
    }
    public class ToaDo
    {
        public int x;
        public int y;
        public ToaDo()
        {
            this.x = 0;
            this.y = 0;
        }
        public ToaDo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void NhapToaDo()
        {
            Console.WriteLine("Nhap diem x: ");
            this.x = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Nhap diem y: ");
            this.y = int.Parse(Console.ReadLine() ?? string.Empty);
        }
        public double KhoangCach(ToaDo b)
        {
            double i = Math.Pow((b.x - this.y), 2) + Math.Pow((b.y - this.x), 2);
            return Math.Sqrt(i);
        }
    }

    public class Ps
    {
        private int tuSo;
        private int mauSo;
        public int Mauso { 
            get { return this.mauSo; }
            set { this.mauSo = value; }
        }
        public int TuSo
        {
            get { return this.tuSo; }
            set { this.tuSo = value; }
        }
        public void NhapPhanSo(string ghichu)
        {
            Console.WriteLine(ghichu);
            Console.WriteLine("Nhap tu so:");
            tuSo = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine(ghichu);
            Console.WriteLine("Nhap mau so:");
            mauSo = int.Parse(Console.ReadLine() ?? string.Empty);
        }
        public Ps CongPhanSo(Ps b)
        {
            Ps kq = new Ps
            {
                tuSo = tuSo * b.mauSo + mauSo * b.tuSo,
                mauSo = mauSo * b.mauSo
            };
            return kq;
        }
        public void Xuat()
        {
            Console.WriteLine($"ket qua la: {tuSo}/{mauSo}");
        }
    }

}
