using System;
using System.Threading.Tasks;
using TopSystem.TopSystem.Implementations;
using TopSystem.TopSystem.Interfaces;

namespace TopSystem
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IFigure circle = new Circle(5, 5, 10);
            await circle.DrawAsync();
        }
    }
}
