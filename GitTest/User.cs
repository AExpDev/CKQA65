using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest
{
    class User : IDrawable
    {
        public int id { get; set; }
        public string name { get; set; }
        public void Draw()
        {
            Console.WriteLine($"Class:User. Value:ID:{this.id},Name:{this.name}");
            Console.WriteLine();
        }
    }
}
