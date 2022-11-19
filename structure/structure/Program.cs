// See https://aka.ms/new-console-template for more information

public class Program
{
    //Khai bao struct hocSinh
    public struct hocSinh
    {
        public string hoTen;
        public int tuoi;
        public string diaChi;
        public string soDienThoai;
    }
    public static void Main()
    {
        //Khai bao bien cua struct
        hocSinh hs;
        //Khai bao mang cac hoc sinh
        hocSinh[] arrHocSinh = new hocSinh[10];
        //Nhap thong tin cho hs do
        Console.WriteLine("Nhap thong tin cho hs 1: ");
        Console.Write("Ho ten: ");
        hs.hoTen = Console.ReadLine();
        Console.Write("Tuoi: ");
        hs.tuoi = int.Parse(Console.ReadLine());
        Console.Write("Dia chi: ");
        hs.diaChi = Console.ReadLine();
        Console.Write("So dien thoai: ");
        hs.soDienThoai = Console.ReadLine();
        //Hien thi thong tin cua hoc sinh
        Console.WriteLine("==================");
        Console.WriteLine("Thong tin cua hoc sinh sau khi nhap:");
        Console.WriteLine("Ho ten: " + hs.hoTen);
        Console.WriteLine("Tuoi: " + hs.tuoi);
        Console.WriteLine("Dia chi: " + hs.diaChi);
        Console.WriteLine("So dien thoai: " + hs.soDienThoai);
        Console.WriteLine(arrHocSinh[0].hoTen);
    }
}