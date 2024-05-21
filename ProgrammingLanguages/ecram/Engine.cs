namespace May16;

public class Engine
{
    uint spinlimit;
    uint initialspin = 0;
    uint currentspin;
    
    public Engine( uint spinlimit)
    {
        this.spinlimit = spinlimit;
        this.currentspin = this.initialspin;
    }

    public void SpinUp()
    {
        if (currentspin > 0)
            currentspin--;
        
    }
    public void SpinDown()
    {
        if (currentspin < spinlimit)
        {
            currentspin++;
        }
    }
    
    public uint GetLimit()
    {
        return spinlimit;
    }
    public uint GetCurrentSpin()
    {
        return currentspin;
    }

    public bool Isiniial()
    {
        return currentspin == initialspin;
    }
    public bool IsLimit()
    {
        return currentspin == spinlimit;
    }
}