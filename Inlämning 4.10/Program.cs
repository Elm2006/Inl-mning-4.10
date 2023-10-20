using System;
namespace Inlämning_4.__10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int xPerGrupp = int.Parse(Console.ReadLine());
            Console.WriteLine("<hur många O per grupp?");
            int oPerGrupp = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O-grupper per rad?");
            int oPerRad = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många rader");
            int rader = int.Parse(Console.ReadLine());
            for (int i = 0;i<rader;i++)
            {
                for(int s = 0; s<oPerRad; s++)
                {
                    for (int j = 0; j < xPerGrupp; j++)
                    {
                        Console.Write("X");
                    }
                    Console.Write('-');
                    for(int k = 0;k<oPerGrupp; k++)
                    {
                        Console.Write("O");
                    }
                    Console.Write('-');
                }
                for (int l = 0; l < xPerGrupp; l++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
    }
}