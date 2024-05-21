namespace May16;

public class Ecran
{
    byte width;
    byte height;
    
    public Ecran(byte width, byte height)
    {
        this.width = width;
        this.height = height;
    }
    
    public string[] GetEcran()
    {
        string[] ecran = new string[height];
        ecran[0] = new string('*', width);
        ecran[height - 1] = new string('*', width);
        string mid = new string(' ', width-2);
        for (int i = 1; i < height-1; i++)
        {
            ecran[i] = "*" + mid + "*";
        }
        return ecran;
    }
    
    public byte GetHeight()
    {
        return height;
    }
    
    public byte GetWidth()
    {
        return width;
    }
}