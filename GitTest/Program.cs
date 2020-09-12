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
            drawableClasses.Add(new ClassAdress() {Id = 0, City="Tatiana" });
            drawableClasses.Add(new ClassRooms() { Id = "3", Name = "Nadya" });
            drawableClasses.Add(new Consultant() { Id = 4, Name = "Tanya" });
            drawableClasses.Add(new Hostel() {id = 5, name = "Alexandr" });
            drawableClasses.Add(new Respect());
            drawableClasses.Add(new Subject() { Id = 7, Name = "Natalya" });
            drawableClasses.Add(new User() { });

            foreach (var item in drawableClasses) 
            {
                item.Draw();
            }
            Console.ReadLine();
        }
    }
}
