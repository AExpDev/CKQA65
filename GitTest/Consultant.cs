﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest
{
   public class Consultant : IDrawable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Draw()
        {
            Console.WriteLine($"Class:Consultant. Value:ID:{this.Id},Name:{this.Name}"); 
            Console.WriteLine();
        }
    }
}
