// See https://aka.ms/new-console-template for more information

//Nhap so nguyen n. In ra cac so tu 1 den n

Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
/* for */
Console.WriteLine("----- for -------");
for (int i = 1; i < n; i++)
{
    Console.Write(i + "\t");
}
Console.WriteLine();
/* while */
Console.WriteLine("----- while -------");
int j = 1;
while (j < n)
{
    Console.Write(j + "\t");
    j++;
}
Console.WriteLine();
/* do - while */
Console.WriteLine("----- do - while -------");
int k = 1;
do
{
    Console.Write(k + "\t");
    k++;
} while (k < n);
