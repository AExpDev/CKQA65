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
            drawableClasses.Add(new ClassRooms());
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
