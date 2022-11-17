namespace method;
//Nhap so nguyen n. Tinh n!
public class demo
{
    //Nhap n
    public static int nhapN()
    {
        int n;
        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());
        return n;
    }
    //Tinh giai thua
    public static int tinhGiaiThua(int n)
    {
        int giaiThua = 1;
        for (int i = 1; i <= n; i++)
        {
            giaiThua *= i;
        }
        return giaiThua;
    }
    //Hien thi
    public static void hienThi(int n)
    {
        Console.WriteLine("n! = " + tinhGiaiThua(n));
    }

    public static int tinhGiaiThuaDeQuy(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        return n * tinhGiaiThuaDeQuy(n - 1);
    }
    public static void Main()
    {
        //B1: xac dinh chuong trinh co bao nhieu chuc nang
        //B2: tach tung chuc nang ra tung method
        int n = nhapN();
        Console.WriteLine("Method thong thuong");
        hienThi(n);
        Console.WriteLine("==================");
        Console.WriteLine("De quy");
        Console.WriteLine("n! = " + tinhGiaiThuaDeQuy(n));
    }
}