namespace LTHDT_console
{
    public struct PhanSo
    {
        public int tuSo;
        public int mauSo;
    }
    public class HandleNumber
    {
        public static PhanSo NumberInput(string inputString)
        {
            PhanSo phanSo = new PhanSo();
            Console.WriteLine($"Nhap tu so {inputString}:");
            phanSo.tuSo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Nhap mau so {inputString}:");
            phanSo.mauSo = int.Parse(Console.ReadLine());
            return phanSo;
        }
        public static PhanSo Cong2PS(PhanSo a, PhanSo b)
        {
            PhanSo kq = new()
            {
                tuSo = a.tuSo * b.mauSo + a.mauSo * b.tuSo,
                mauSo = a.mauSo * b.mauSo
            };
            return kq;
        }
        public static void PrintPS(PhanSo phanSo)
        {
            Console.WriteLine($"KQ la: {phanSo.tuSo}/{phanSo.mauSo}");
        }
    }
}
