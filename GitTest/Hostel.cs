using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GitTest
{
    class Hostel: IDrawable
    {
        public int id { get; set; }
        public string name { get; set; }
        public void Draw()
        {
            Console.WriteLine($"Class:User. Value:ID:{this.id},Name:{this.name}");
        }
    }
}
