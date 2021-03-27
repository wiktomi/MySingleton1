using System;

namespace MySingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            MySingleton mySingleton = MySingleton.Instance;

            mySingleton.Marka = "Mercedes";
            mySingleton.Model = "AMG GT";

            Console.WriteLine("Pierwsze odwołanie: \n" + "Wartość zmiennej marka: " + mySingleton.Marka + "\nWartość zmiennej model: " + mySingleton.Model);

            // Niby druga instancja klasy singleton
            MySingleton mySingleton1 = MySingleton.Instance;
            // Zmiana wartości zmiennej marka dla "drugiej" instancji
            mySingleton1.Marka = "BMW";
            Console.WriteLine("\nNie mozna stworzyć 'drugiej' instancji klasy singleton ponieważ wzorzec umożliwia stworzenie tylko jednej instancji i każda kolejna bedzie tą samą instancją\n");


            Console.WriteLine("Drgie odwołanie: \n" + "Wartość zmiennej marka: " + mySingleton1.Marka + "\nWartość zmiennej model: " + mySingleton1.Model);

            Console.WriteLine("Pierwsze odwołanie: \n" + "Wartość zmiennej marka: " + mySingleton.Marka + "\nWartość zmiennej model: " + mySingleton.Model);

            Console.WriteLine("Drgie odwołanie: \n" + "Wartość zmiennej marka: " + mySingleton1.Marka + "\nWartość zmiennej model: " + mySingleton1.Model);





        }
    }
}
