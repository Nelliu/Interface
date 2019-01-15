using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IWasher washerPerson = new Person();
            IWasher washerCar = new CarWash();
            IWasher washerDish = new DishWasher();

            
            

            List<IWasher> washers = new List<IWasher>();
            washers.Add(washerPerson);
            washers.Add(washerCar);
            washers.Add(washerDish);

            // abstrakce, abstraktní třídy

            AWasher washerPersonA = new Person();
            AWasher washerCarA = new CarWash();
            AWasher washerDishA = new DishWasher();

            Person pp = new Person();
            pp.Name = "a";

            // https://ucitel.sps-prosek.cz/~maly/PRG/materials/csharp/#abstrakce-systemu


        }
    }
}
