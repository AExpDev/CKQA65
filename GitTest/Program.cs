﻿using System;
using System.Collections.Generic;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDrawable> drawableClasses = new List<IDrawable>();
            drawableClasses.Add(new Chelovek());
            drawableClasses.Add(new ClassAdress());
            drawableClasses.Add(new ClassRooms() { Id = "3", Name = "Nadya" }) ;
            drawableClasses.Add(new Consultant());
            drawableClasses.Add(new Hostel());
            drawableClasses.Add(new Respect() { Id = "6", Name="Dmitriy"}); 
            drawableClasses.Add(new Subject() { Id = 7, Name = "Natalya" });
            drawableClasses.Add(new User());

            foreach (var item in drawableClasses) 
            {
                item.Draw();
            }
            Console.ReadLine();
        }
    }
}
