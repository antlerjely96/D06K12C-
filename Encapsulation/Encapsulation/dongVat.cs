namespace Encapsulation;

public class dongVat
{
    public string noiSong;
    private int soChan;
    protected string mauLong;
    public string loai;

    public int getSoChan()
    {
        return soChan;
    }

    public void setSoChan(int soChan)
    {
        this.soChan = soChan;
    }

    public string getMauLong()
    {
        return mauLong;
    }

    public void setMauLong(string mauLong)
    {
        this.mauLong = mauLong;
    }
}