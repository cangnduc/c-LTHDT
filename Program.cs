// See https://aka.ms/new-console-template for more information

namespace LTHDT_console
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            toaDo a = new toaDo(1, 2);
            toaDo b = new toaDo(2, 3);
            Console.WriteLine(a.khoangCach(b));
        }

    }
    public class toaDo
    {
        public int x;
        public int y;
        public toaDo(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double khoangCach(toaDo b)
        {
            int i = (b.x - y) ^ 2 + (b.y - x) ^ 2;
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
        public string xuat()
        {
            return $"ket qua la: {tuSo}/{mauSo}";
        }
    }

}
