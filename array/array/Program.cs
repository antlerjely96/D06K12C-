// See https://aka.ms/new-console-template for more information

//Nhap mot mang n so nguyen (n nhap tu ban phim). Tinh tong cac phan tu co gia tri chia het cho 2

//Nhap n
Console.Write("Nhap n: ");
int n = int.Parse(Console.ReadLine());
//Khai bao mang so nguyen co n phan tu
int[] arr = new int[n];
//Nhap mang
for (int i = 0; i < n; i++)
{
    Console.Write("arr[" + i + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
//Tinh tong cac phan tu co gia tri chan
int tong = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 == 0)
    {
        tong += arr[i];
    }
}
//Hien thi ket qua
Console.WriteLine("Tong cac phan tu co gia tri chan trong mang: " + tong);