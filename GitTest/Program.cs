﻿using System;
using System.Collections.Generic;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDrawable> drawableClasses = new List<IDrawable>();
            drawableClasses.Add(new Chelovek() { Id = 1, Name = "Denis" });
            drawableClasses.Add(new ClassAdress() { Id = 2, Name = "Tatiana" });
            drawableClasses.Add(new ClassRooms() { id = 3, name = "Nadya" });
            drawableClasses.Add(new Consultant() { Id = 4, Name = "Tanya" });
            drawableClasses.Add(new Hostel() {id = 5, name = "Alexandr" });
            drawableClasses.Add(new Respect() {Id=6, Name="Dmitriy"});
            drawableClasses.Add(new Subject() { Id = 7, Name = "Natalya" });
            drawableClasses.Add(new User() { id = 8, name = "Alex" });
            drawableClasses.Add(new Client() { Id = 9, Name = "Inna" });
            drawableClasses.Add(new Avto() { Id = 10, Name = "Alexey" });

            foreach (var item in drawableClasses) 
            {
                item.Draw();
            }
            Console.ReadLine();
        }
    }
}
