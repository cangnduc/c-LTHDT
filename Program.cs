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
           Ps a = new Ps();
            a.TuSo = 5;
            a.Mauso = 10;
            Console.WriteLine(a.TuSo);
            Ps b = a.CongPhanSo(a);
            b.Xuat();

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
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem y: ");
            this.y = int.Parse(Console.ReadLine());
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
            tuSo = int.Parse(Console.ReadLine());
            Console.WriteLine(ghichu);
            Console.WriteLine("Nhap mau so:");
            mauSo = int.Parse(Console.ReadLine());
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
