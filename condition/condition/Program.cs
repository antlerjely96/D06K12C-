// See https://aka.ms/new-console-template for more information

//Nhap mot so nguyen a tu ban phim. Kiem tra a la so duong hay am

//Hien thi
Console.Write("Nhap a: ");
//Nhap bien a
int a = int.Parse(Console.ReadLine());
//Kiem tra a la so am hay duong
if (a > 0)
{
    Console.WriteLine(a + " la so duong");
}
else if (a < 0)
{
    Console.WriteLine(a + " la so am");
}
else
{
    Console.WriteLine(a + " la so khong am khong duong");
}

//Nhap mot so nguyen n. Hien thi so ngay cua thang n

Console.Write("Nhap thang: ");
//Nhap bien thang
int thang = int.Parse(Console.ReadLine());
//Hien thi so ngay cua thang
switch (thang)
{
    case 1:
        Console.WriteLine("Thang " + thang + " co 31 ngay");
        break;
    case 2:
        Console.Write("Nhap nam: ");
        int nam = int.Parse(Console.ReadLine());
        if (nam % 4 == 0)
        {
            Console.WriteLine("Thang " + thang + " nam " + nam + " co 29 ngay");
        }
        else
        {
            Console.WriteLine("Thang " + thang + " nam " + nam + " co 28 ngay");
        }
        break;
    case 3:
        Console.WriteLine("Thang " + thang + " co 31 ngay");
        break;
    case 4:
        Console.WriteLine("Thang " + thang + " co 30 ngay");
        break;
    case 5:
        Console.WriteLine("Thang " + thang + " co 31 ngay");
        break;
    case 6:
        Console.WriteLine("Thang " + thang + " co 30 ngay");
        break;
    case 7:
        Console.WriteLine("Thang " + thang + " co 31 ngay");
        break;
    case 8:
        Console.WriteLine("Thang " + thang + " co 31 ngay");
        break;
    case 9:
        Console.WriteLine("Thang " + thang + " co 30 ngay");
        break;
    case 10:
        Console.WriteLine("Thang " + thang + " co 31 ngay");
        break;
    case 11:
        Console.WriteLine("Thang " + thang + " co 30 ngay");
        break;
    case 12:
        Console.WriteLine("Thang " + thang + " co 31 ngay");
        break;
    default:
        Console.WriteLine("Thang " + thang + " khong ton tai");
        break;
}
