using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest
{
    class Respect : IDrawable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Draw()
        {
            Console.WriteLine($"Class:Respect. Value:ID:{this.Id},Name:{this.Name}");
            Console.WriteLine();
        }
    }

}
