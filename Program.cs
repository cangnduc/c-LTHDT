// See https://aka.ms/new-console-template for more information

namespace LTHDT_console
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            ps a = new ps();
            ps b = new ps();
            a.nhapPhanSo("phan so a");
            b.nhapPhanSo("phan so b");
            ps kq = a.CongPhanSo(b);
            kq.xuat();
            //toaDo a = new toaDo(1, 2);
            //toaDo b = new toaDo(2, 3);
            //toaDo c = new toaDo(3, 4);
            //Diem tamgiac = new Diem(a, b, c);
            //Console.WriteLine(c.khoangCach(a));
            //Console.WriteLine(tamgiac.chuVi());
            ///awdwadss
        }

    }
    public class Diem
    {
        public toaDo A;
        public toaDo B;
        public toaDo C;
        public Diem()
        {
            A = new toaDo(1, 0);
            B = new toaDo(0, 1);
            C = new toaDo(0, 0);
        }
        public Diem(toaDo a, toaDo b, toaDo c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double chuVi()
        {
            double a = A.khoangCach(B);
            double b = B.khoangCach(C);
            double c = C.khoangCach(A);
            return a + b + c;
        }
    }
    public class toaDo
    {
        public int x;
        public int y;
        public toaDo()
        {
            this.x = 0;
            this.y = 0;
        }
        public toaDo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double khoangCach(toaDo b)
        {
            double i = Math.Pow((b.x - this.y), 2) + Math.Pow((b.y - this.x), 2);
            return Math.Sqrt(i);
        }
    }

    public class ps
    {
        public int tuSo;
        public int mauSo;
        public void nhapPhanSo(string ghichu)
        {
            Console.WriteLine(ghichu);
            Console.WriteLine("Nhap tu so:");
            tuSo = int.Parse(Console.ReadLine());
            Console.WriteLine(ghichu);
            Console.WriteLine("Nhap mau so:");
            mauSo = int.Parse(Console.ReadLine());
        }
        public ps CongPhanSo(ps b)
        {
            ps kq = new ps
            {
                tuSo = tuSo * b.mauSo + mauSo * b.tuSo,
                mauSo = mauSo * b.mauSo
            };
            return kq;
        }
        public void xuat()
        {
            Console.WriteLine($"ket qua la: {tuSo}/{mauSo}");
        }
    }

}
