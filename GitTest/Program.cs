using System;
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
            drawableClasses.Add(new Respect());
            drawableClasses.Add(new Subject());
            drawableClasses.Add(new User());

            foreach (var item in drawableClasses) 
            {
                item.Draw();
            }
            Console.ReadLine();
        }
    }
}
