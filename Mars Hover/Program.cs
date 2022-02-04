using MarsHover.Terrain;
using System;

class Program
{
    static void Main(string[] args)
    {
        var loopcontrol = true;
        var terrain = new Terrain();
        do
        {
            Console.WriteLine("Set The Size of terrain");
            Console.WriteLine("==============================================");
            var terrainsize = Console.ReadLine();
            if (terrain.PepareTerrain(terrainsize))
                loopcontrol = false;
            else
                Console.WriteLine("Invalid terrain size");
        }
        while (loopcontrol);

        Console.WriteLine("Set Movement Sequence");
        Console.WriteLine("===================================");
        var movSequence = Console.ReadLine();
        var hover = new MarsHover.Hover.Hover(terrain);
        hover.Run(movSequence);

        Console.WriteLine("Result:{0},{1},{2}",hover.X, hover.Y, hover.Orientation);






    }
}