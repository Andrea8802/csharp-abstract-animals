namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animale cane, passerotto, aquila, delfino;


            Console.WriteLine("Il cane fa: ");
            cane = new Cane();
            cane.Dormi();
            cane.Verso();
            cane.Mangia();

            Console.WriteLine("\n\nIl passerotto fa: ");
            passerotto = new Passerotto();
            passerotto.Dormi();
            passerotto.Verso();
            passerotto.Mangia();

            Console.WriteLine("\n\nIl aquila fa: ");
            aquila = new Aquila();
            aquila.Dormi();
            aquila.Verso();
            aquila.Mangia();


            Console.WriteLine("\n\nIl delfino fa: ");
            delfino = new Delfino();
            delfino.Dormi();
            delfino.Verso();
            delfino.Mangia();


            static void FaiVolare(IVolante animale)
            {
                animale.Vola();
            }

            static void FaiNuotare(INuotante animale)
            {
                animale.Nuota();
            }

            Console.WriteLine("\n\nDelfino2: ");
            Delfino delfino2 = new Delfino();
            FaiNuotare(delfino2);

            Console.WriteLine("\n\nAquila2: ");
            Aquila aquila2 = new Aquila();
            FaiVolare(aquila2);

        }
    }
}