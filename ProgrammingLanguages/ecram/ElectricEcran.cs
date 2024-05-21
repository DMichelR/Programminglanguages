namespace May16;

public class ElectricEcran
{
    private Ecran ecran;
    private byte height;
    private Engine engine;

    private Control control;
    
    public ElectricEcran()
    {
        ecran = new Ecran(20, 10);
        height = ecran.GetHeight();
        engine = new Engine(height);
        control = new Control();
    }
    public void Start()
    {
        string[] ecranD = ecran.GetEcran();
        while (!engine.IsLimit())
        {
            //Console.Clear();
            
            engine.SpinDown();
            for (int i = 0; i < engine.GetCurrentSpin(); i++)
            {
                Console.WriteLine(ecranD[engine.GetLimit()-engine.GetCurrentSpin()+i]);
            }
                
            Console.WriteLine("---------------------------------------");
        }
    }
    
    public void ReturnEcran()
    {
        Console.WriteLine("---Ecran Up---");
        string[] ecranD = ecran.GetEcran();
        while (!engine.Isiniial())
        {
            //Console.Clear();
            
            for (int i = (int)(engine.GetLimit()-engine.GetCurrentSpin() ); i < engine.GetLimit(); i++)
            {
                Console.WriteLine(ecranD[i]);
            }
                
            engine.SpinUp();
            Console.WriteLine("---------------------------------------");
        }
    }
}