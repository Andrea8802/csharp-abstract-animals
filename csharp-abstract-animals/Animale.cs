using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale
    {
        public void Dormi()
        {
            Console.WriteLine("ZZZZZZ");
        }

        public abstract void Verso();
        public abstract void Mangia();
    }

    public class Cane : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Woof Woof!");
        }

        public override void Mangia()
        {
            Console.WriteLine("Carne");
        }
    }

    public class Passerotto : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Cip Cip!");
        }
        public override void Mangia()
        {
            Console.WriteLine("Semi");
        }

    }

    public class Aquila : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Skree!");
        }

        public override void Mangia()
        {
            Console.WriteLine("Lepre");
        }
    }

    public class Delfino : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("weee-eeee-eeee-oooo-oooo-oooo-eeee-eeee-eeee");
        }

        public override void Mangia()
        {
            Console.WriteLine("Pesce");
        }
    }
}
