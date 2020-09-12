﻿using System;
using System.Collections.Generic;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDrawable> drawableClasses = new List<IDrawable>();
            drawableClasses.Add(new Chelovek() { Id = 0, Name = "Denis" });
            drawableClasses.Add(new ClassAdress() {Id = "0", City="Tatiana" });
            drawableClasses.Add(new ClassRooms() { Id = "3", Name = "Nadya" });
            drawableClasses.Add(new Consultant() { Id = 4, Name = "Tanya" });
            drawableClasses.Add(new Hostel() {id = 5, name = "Alexandr" });
            drawableClasses.Add(new Respect() {Id="6", Name="Dmitriy"});
            drawableClasses.Add(new Subject() { Id = 7, Name = "Natalya" });
            drawableClasses.Add(new User() { Id = "8", Name = "Alex" });

            foreach (var item in drawableClasses) 
            {
                item.Draw();
            }
            Console.ReadLine();
        }
    }
}
