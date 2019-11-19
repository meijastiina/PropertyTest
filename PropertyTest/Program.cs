using System;

namespace PropertyTest
{
    class Program
    {
        enum Choice
        {
            Add = 1,
            Remove = 2

        }
        const int REMOVE_CAT = 2;
        static void Main(string[] args)
        {
            Cat myCat = new Cat();
            myCat.Name = "Misse";
            Console.WriteLine(myCat.Name);
            myCat = new Cat();
            try
            {
                myCat.Name = "Musti";
                Console.WriteLine(myCat.Name);
            } catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            int choice;
            do
            {
                Console.WriteLine("1 - Lisää kissa");
                Console.WriteLine("2 - Poista kissa");
                Console.WriteLine("0 - Lopeta");
                choice = int.Parse(Console.ReadLine());
            } while (choice != 0);

            switch (choice)
            {
                case (int)Choice.Add:
                    Console.WriteLine("Valittu 1");
                    break;
                case REMOVE_CAT:
                    removeCat();
                    break;

            }
        }
        static void removeCat()
        {
            // Here everything that is needed for this case
            Console.WriteLine("Valittu 2");
        }
    }
}
