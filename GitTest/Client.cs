﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest
{
    class Client : IDrawable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Draw()
        {
            Console.WriteLine("Name:" + this.Name);
        }
    }
}
