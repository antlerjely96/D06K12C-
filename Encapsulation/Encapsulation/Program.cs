// See https://aka.ms/new-console-template for more information

using Encapsulation;

public class Program
{
    public static void Main()
    {
        dongVat dv = new dongVat();
        dv.noiSong = "Trai Dat";
        dv.loai = "Cho";
        dv.setSoChan(4);
        dv.setMauLong("Vang");
        Console.WriteLine("Thong tin con vat");
        Console.WriteLine("Loai: " + dv.loai);
        Console.WriteLine("Noi song: " + dv.noiSong);
        Console.WriteLine("So chan: " + dv.getSoChan());
        Console.WriteLine("Mau long: " + dv.getMauLong());
    }
}